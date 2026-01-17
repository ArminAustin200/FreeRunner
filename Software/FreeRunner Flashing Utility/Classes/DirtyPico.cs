using FreeRunner_Flashing_Utility;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FreeRunner_Flashing_Utility
{
    public class DirtyPico
    {
        // Must use static paths to define svfPath and svfRoot. This build of UrJtag does not play nice 
        // with \ in file paths and only accepts \\ or / and previous method echos path with \
        private readonly string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        public string svfPathUnfriendly => Path.Combine(svfRoot, "TimingSvfTemp.svf");
        public string svfPath => svfPathUnfriendly.Replace("\\", "/");
        public string svfRoot => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "svftemp");

        public bool ready = false;
        public bool inUse = false;
        public bool waiting = false;
        private string jtagdevice = "";
        public int selType = 0;

        //Created variables to store CPLD manufacturer and part numbers
        private string detectedManufacturer;
        private string detectedPart;
        private readonly object detectLock = new object();
        private ManualResetEventSlim detectEvent = new ManualResetEventSlim(false);

        private readonly StringBuilder _outBuf = new StringBuilder();
        private readonly StringBuilder _errBuf = new StringBuilder();
        private readonly object _bufLock = new object();

        // SVF Flashing
        // Basically everything here is copied from xFlasher class
        public void flashSvf(string filename)

        {
            string DirtyMessage = "DirtyPico: Check wiring before flashing." + Environment.NewLine 
                + "Watch LEDs on glitch chip during flashing." 
                + Environment.NewLine + "If LEDs change you've had a successful flash!"
                + Environment.NewLine + "Flashing will begin in 5s!"
                + Environment.NewLine + "";

            {
                if (inUse || waiting) return;

                if (Process.GetProcessesByName("jtagDirtyPico").Length > 0)
                {
                    mainForm.Instance.Log("DirtyPico: SVF software is already running!");
                    return;
                }

                Thread urJtagThread = new Thread(() =>
                {
                    try
                    {
                        if (!File.Exists(filename))
                        {
                            mainForm.Instance.Log($"DirtyPico: File Not Found: {filename}");
                            return;
                        }
                        if (Path.GetExtension(filename) != ".svf")
                        {
                            mainForm.Instance.Log($"DirtyPico: Wrong File Type: {filename}");
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
                            mainForm.Instance.Log("DirtyPico: Could not open temporary file for flashing");
                            mainForm.Instance.Log($"DirtyPico: {svfPath} is locked by another process");
                            return;
                        }

                        //Logging warning messages
                        mainForm.Instance.Log("WARNING: DIRTYPICO DOES NOT SHOW FLASHING PROGRESS CORRECTLY!!");
                        mainForm.Instance.Log("");
                        mainForm.Instance.Log(DirtyMessage);
                        SystemSounds.Asterisk.Play();

                        //Pausing code execution to allow user to read warnings
                        Thread.Sleep(5000);

                        mainForm.Instance.Log($"DirtyPico: Flashing {Path.GetFileName(filename)} via JTAG");

                        //Setting progress to 0%
                        mainForm.Instance.UpdateProgress(0);

                        Process psi = new Process();
                        psi.StartInfo.FileName = Path.Combine(baseDir, "common", "DirtyPico360", "jtagDirtyPico.exe");
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

                            lock (_bufLock)
                            {
                                _outBuf.AppendLine(e.Data);
                            }

                            var line = e.Data.TrimStart();

                            lock (detectLock)
                            {
                                if (line.StartsWith("Manufacturer:", StringComparison.OrdinalIgnoreCase))
                                {
                                    var raw = line.Split(':', 2)[1].Trim();
                                    int idx = raw.IndexOf('(');
                                    detectedManufacturer = (idx > 0 ? raw.Substring(0, idx) : raw).Trim();
                                }

                                if (line.StartsWith("Part(", StringComparison.OrdinalIgnoreCase))
                                {
                                    var raw = line.Split(':', 2)[1].Trim();
                                    int idx = raw.IndexOf('(');
                                    detectedPart = (idx > 0 ? raw.Substring(0, idx) : raw).Trim();
                                }

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

                        wr.WriteLine("cable dirtyjtag");
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
                                mainForm.Instance.Log($"DirtyPico: {m} {p} Detected")
                            ));
                        });

                        wr.WriteLine("svf " + svfPath); // Do not add + " progress" to this like the xFlasher. Unsure if it's an issue with my build of UrJtag or DirtyJtag but the progress argument breaks UrJtag
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

                        if (strLower.Contains("between")) // Quick and dirty way to get JRunner to display flash success message. DirtyJtag displays TDO mismatch errors in UrJtag during the verification portion of SVF flashing and progress is broken, so this is the easiest way to know if the flash worked and display a success message.
                        {

                            int start = str.IndexOf("Part(0):") + 8;
                            int end = str.IndexOf("Stepping:") - start;

                            if (start <= 0 || end <= 0)
                            {
                                mainForm.Instance.Log("DirtyPico: Failed to detect CPLD type");
                            }

                            mainForm.Instance.Log("DirtyPico: SVF Flash Successful!");
                            mainForm.Instance.Log("");

                            //Setting progress to 100%
                            mainForm.Instance.UpdateProgress(100);

                            SoundPlayer success = new SoundPlayer(Properties.Resources.chime);
                            success.Play();
                        }

                        else if (strLower.Contains("xc2c128") & str.EndsWith("3") | str.EndsWith("0"))
                        {

                            int start = str.IndexOf("Part(0):") + 8;
                            int end = str.IndexOf("Stepping:") - start;

                            if (start <= 0 || end <= 0)
                            {
                                mainForm.Instance.Log("DirtyPico: Failed to detect CPLD type");
                            }
                            else
                            {
                                jtagdevice = str.Substring(start, end).Trim().Replace("\r\n", "");
                                mainForm.Instance.Log($"DirtyPico: {jtagdevice} Detected");
                            }

                            mainForm.Instance.Log("DirtyPico: SVF Flash Successful!");
                            mainForm.Instance.Log("");

                            SoundPlayer success = new SoundPlayer(Properties.Resources.chime);
                            success.Play();
                        }

                        else if (strLower.Contains("chain without any parts") == true)
                        {
                            mainForm.Instance.Log("DirtyPico: Could not connect to CPLD");
                            mainForm.Instance.Log("");
                        }

                        else if (strLower.Contains("stuck at"))
                        {
                            mainForm.Instance.Log("DirtyPico: TDO stuck at 0");
                            mainForm.Instance.Log("Check wiring or power cycle glitch chip");
                            mainForm.Instance.Log("");
                        }
                        else
                        {
                            mainForm.Instance.Log("DirtyPico: SVF Flash Failed");
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
                        if (mainForm.Instance.debug) 
                            mainForm.Instance.Log(ex.ToString());
                        mainForm.Instance.Log("");
                    }
                });
                urJtagThread.Start();
            }
        }
    }
}
