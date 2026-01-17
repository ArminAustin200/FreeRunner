using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FreeRunner_Flashing_Utility
{
    public class xFlasher
    {
        private readonly string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        public string svfPath => Path.Combine(svfRoot, "TimingSvfTemp.svf");
        public string svfRoot => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "SVF");

        public bool ready = false;
        public bool inUse = false;
        public bool waiting = false;
        public int selType = 0;

        //Created variables to store CPLD manufacturer and part numbers
        private string detectedManufacturer;
        private string detectedPart;
        private readonly object detectLock = new object();
        private ManualResetEventSlim detectEvent = new ManualResetEventSlim(false);

        private readonly StringBuilder _outBuf = new StringBuilder();
        private readonly StringBuilder _errBuf = new StringBuilder();
        private readonly object _bufLock = new object();

        //Created variable to hold progressbar percentage
        private static readonly Regex _percentRx =
            new Regex(@"\(\s*(\d{1,3})%\)", RegexOptions.Compiled);

        // SVF Flashing
        public void flashSvf(string filename)
        {
            if (inUse || waiting) return;

            if (Process.GetProcessesByName("jtag").Length > 0)
            {
                mainForm.Instance.Log("xFlasher: SVF software is already running!");
                return;
            }

            Thread urJtagThread = new Thread(() =>
            {
                try
                {
                    if (!ready)
                    {
                        waiting = true;
                        mainForm.Instance.Log("xFlasher: Waiting for device to become ready");
                    }
                    while (!ready)
                    {
                        // Do nothing and wait
                    }

                    if (!File.Exists(filename))
                    {
                        mainForm.Instance.Log($"xFlasher: File Not Found: {filename}");
                        return;
                    }
                    if (Path.GetExtension(filename) != ".svf")
                    {
                        mainForm.Instance.Log($"xFlasher: Wrong File Type: {filename}");
                        return;
                    }

                    try
                    {
                        Directory.CreateDirectory(svfRoot);
                        if (File.Exists(svfPath))
                        {
                            File.Delete(svfPath);
                        }
                        File.Copy(filename, svfPath);
                    }
                    catch
                    {
                        mainForm.Instance.Log("xFlasher: Could not open temporary file for flashing");
                        mainForm.Instance.Log($"xFlasher: {svfPath} is locked by another process");
                        return;
                    }

                    mainForm.Instance.Log($"xFlasher: Flashing {Path.GetFileName(filename)} via JTAG");

                    Process psi = new Process();
                    psi.StartInfo.FileName = Path.Combine(baseDir, "common", "xFlasher", "jtag.exe");
                    psi.StartInfo.CreateNoWindow = true;
                    psi.StartInfo.UseShellExecute = false;
                    psi.StartInfo.RedirectStandardOutput = true;
                    psi.StartInfo.RedirectStandardInput = true;
                    psi.StartInfo.RedirectStandardError = true;

                    //Enable synchronous read/write
                    psi.EnableRaisingEvents = true;

                    psi.OutputDataReceived += (s, e) =>
                    {
                        if (string.IsNullOrWhiteSpace(e.Data)) return;
                        
                        var line2 = e.Data;

                        // progress parsing
                        var m = _percentRx.Match(line2);
                        if (m.Success && int.TryParse(m.Groups[1].Value, out int pct))
                        {
                            if (pct < 0) pct = 0;
                            if (pct > 100) pct = 100;

                            mainForm.Instance.BeginInvoke(new Action(() =>
                            {
                                mainForm.Instance.UpdateProgress(pct);
                            }));
                        }

                        lock (_bufLock)
                        {
                            _outBuf.AppendLine(e.Data);
                        }

                        var line = e.Data.TrimStart();

                        lock (detectLock)
                        {
                            if (line.StartsWith("Manufacturer:", StringComparison.OrdinalIgnoreCase))
                                detectedManufacturer = line.Split(':', 2)[1].Trim();

                            if (line.StartsWith("Part(", StringComparison.OrdinalIgnoreCase))
                                detectedPart = line.Split(':', 2)[1].Trim();

                            if (!string.IsNullOrEmpty(detectedManufacturer) &&
                                !string.IsNullOrEmpty(detectedPart))
                                detectEvent.Set();
                        }
                    };

                    inUse = true;

                    lock (_bufLock)
                    {
                        _outBuf.Clear();
                        _errBuf.Clear();
                    }

                    psi.Start();

                    //Enable asynchronous read/write for terminal
                    psi.BeginOutputReadLine();
                    psi.BeginErrorReadLine();

                    StreamWriter wr = psi.StandardInput;

                    wr.WriteLine("cable ft2232");
                    wr.Flush();

                    Thread.Sleep(500);

                    detectedManufacturer = null;
                    detectedPart = null;
                    detectEvent.Reset();

                    wr.WriteLine("detect");
                    wr.Flush();

                    Task.Run(() =>
                    {
                        if (!detectEvent.Wait(TimeSpan.FromSeconds(15)))
                        {
                            mainForm.Instance.BeginInvoke(new Action(() =>
                                mainForm.Instance.Log("Detect did not return Manufacturer/Part in time.")
                            ));
                            return;
                        }

                        string m, p;
                        lock (detectLock)
                        {
                            m = detectedManufacturer; //Set manufactuer of CPLD from urJTAG output
                            p = detectedPart; //Set part number of CPLD from urJTAG output
                        }
                        mainForm.Instance.BeginInvoke(new Action(() =>
                            mainForm.Instance.Log($"xFlasher: {m} {p} Detected")
                        ));
                    });

                    wr.WriteLine("svf " + svfPath + " progress");
                    wr.WriteLine("quit");
                    wr.Flush();
                    psi.WaitForExit();
                    wr.Close();

                    string str;
                    lock (_bufLock)
                    {
                        str = _outBuf.ToString().Replace("\n", "\r\n");
                    }

                    if (str.Length >= 4)
                    {
                        str = str.Remove(str.Length - 4, 4);
                    }

                    string strLower = str.ToLower();
                    inUse = false;

                    if (strLower.Contains("99%"))
                    {
                        int start = str.IndexOf("Part(0):") + 8;
                        int end = str.IndexOf("Stepping:") - start;

                        if (start <= 0 || end <= 0)
                        {
                            mainForm.Instance.Log("xFlasher: Failed to detect CPLD type");
                        }

                        //Setting progress bar to 100%
                        mainForm.Instance.UpdateProgress(100);
                        mainForm.Instance.Log("xFlasher: SVF Flash Successful!");
                        mainForm.Instance.Log("");
                        
                        SoundPlayer success = new SoundPlayer(Properties.Resources.chime);
                        success.Play();
                        
                    }
                    else if (strLower.Contains("chain without any parts") == true)
                    {
                        mainForm.Instance.Log("xFlasher: Could not connect to CPLD");
                        mainForm.Instance.Log("");
                    }
                    else
                    {
                        mainForm.Instance.Log("xFlasher: SVF Flash Failed");
                        mainForm.Instance.Log("");

                        if (mainForm.Instance.debug)
                            mainForm.Instance.Log(strLower);
                    }

                    if (File.Exists(svfPath))
                    {
                        File.Delete(svfPath);
                    }
                }
                catch (Exception ex)
                {
                    inUse = false;

                    mainForm.Instance.Log(ex.Message);
                    mainForm.Instance.Log("");
                }
            });
            urJtagThread.Start();
        }
    }
}
