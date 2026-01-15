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

namespace JRunner
{
    public class DirtyPico
    {
        // Must use static paths to define svfPath and svfRoot. This build of UrJtag does not play nice 
        // with \ in file paths and only accepts \\ or / and previous method echos path with \

        private readonly string baseDir = AppContext.BaseDirectory;
        public string svfPathUnfriendly => Path.Combine(svfRoot, "TimingSvfTemp.svf");
        public string svfPath => svfPathUnfriendly.Replace("\\", "/");
        public string svfRoot => Path.Combine(baseDir, "Utility", "common", "DirtyPico360", "svftemp");

        public bool ready = false;
        public bool inUse = false;
        public bool waiting = false;
        private string jtagdevice = "";
        public int selType = 0;

        private static int initCount = 0;
        private static int inUseCount = 0;
        //public static string xFlasherTimeString = "";
        System.Windows.Threading.DispatcherTimer initTimer;
        System.Timers.Timer inUseTimer;

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
        // Basically everything here is copied from xFlasher class
        public void flashSvf(string filename)

        {
            MessageBoxButtons DirtyButtons = MessageBoxButtons.OK;
            string DirtyMessage = "Check wiring before flashing." + Environment.NewLine + "Watch LEDs on glitch chip during flashing." + Environment.NewLine + "If LEDs change you've had a successful flash!";
            MessageBox.Show(DirtyMessage, "WARNING", DirtyButtons, MessageBoxIcon.Warning);

            {
                if (inUse || waiting) return;

                if (Process.GetProcessesByName("jtagDirtyPico").Length > 0)
                {
                    //Console.WriteLine("DirtyPico: SVF software is already running!");
                    mainForm.Instance.Log("DirtyPico: SVF software is already running!");
                    return;
                }

                Thread urJtagThread = new Thread(() =>
                {
                    try
                    {
                        if (!File.Exists(filename))
                        {
                            //Console.WriteLine("DirtyPico: File Not Found: {0}", filename);
                            mainForm.Instance.Log($"DirtyPico: File Not Found: {filename}");
                            return;
                        }
                        if (Path.GetExtension(filename) != ".svf")
                        {
                            //Console.WriteLine("DirtyPico: Wrong File Type: {0}", filename);
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
                            //Console.WriteLine("DirtyPico: Could not open temporary file for flashing");
                            mainForm.Instance.Log("DirtyPico: Could not open temporary file for flashing");
                            //Console.WriteLine("DirtyPico: {0} is locked by another process", svfPath);
                            mainForm.Instance.Log($"DirtyPico: {svfPath} is locked by another process");
                            return;
                        }

                        //Console.WriteLine("DirtyPico: Flashing {0} via JTAG", Path.GetFileName(filename));
                        mainForm.Instance.Log($"DirtyPico: Flashing {Path.GetFileName(filename)} via JTAG");

                        Process psi = new Process();
                        psi.StartInfo.FileName = @"common/dirtypico/jtagDirtyPico.exe";
                        psi.StartInfo.CreateNoWindow = true;
                        psi.StartInfo.UseShellExecute = false;
                        psi.StartInfo.RedirectStandardOutput = true;
                        psi.StartInfo.RedirectStandardInput = true;
                        psi.StartInfo.RedirectStandardError = true;

                        inUse = true;
                        psi.Start();

                        StreamWriter wr = psi.StandardInput;
                        StreamReader rr = psi.StandardOutput;

                        wr.WriteLine("cable dirtyjtag");
                        wr.WriteLine("detect");
                        wr.WriteLine("svf " + svfPath); // Do not add + " progress" to this like the xFlasher. Unsure if it's an issue with my build of UrJtag or DirtyJtag but the progress argument breaks UrJtag
                        wr.WriteLine("quit");
                        wr.Flush();
                        wr.Close();

                        string str = "";
                        str = "--";
                        str += rr.ReadToEnd().Replace("\n", "\r\n");

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
                                //Console.WriteLine("DirtyPico: Failed to detect CPLD type");
                                mainForm.Instance.Log("DirtyPico: Failed to detect CPLD type");
                            }
                            else
                            {
                                jtagdevice = str.Substring(start, end).Trim().Replace("\r\n", "");
                                //Console.WriteLine("DirtyPico: {0} Detected", jtagdevice);
                                mainForm.Instance.Log($"DirtyPico: {jtagdevice} Detected");
                            }

                            //Console.WriteLine("DirtyPico: SVF Flash Successful!");
                            mainForm.Instance.Log("DirtyPico: SVF Flash Successful!");
                            Console.WriteLine("");
                            mainForm.Instance.Log("");

                            //if (variables.playSuccess)
                            //{
                            //    SoundPlayer success = new SoundPlayer(Properties.Resources.chime);
                            //    success.Play();
                            //}
                        }

                        else if (strLower.Contains("xc2c128") & str.EndsWith("3") | str.EndsWith("0"))
                        {

                            int start = str.IndexOf("Part(0):") + 8;
                            int end = str.IndexOf("Stepping:") - start;

                            if (start <= 0 || end <= 0)
                            {
                                //Console.WriteLine("DirtyPico: Failed to detect CPLD type");
                                mainForm.Instance.Log("DirtyPico: Failed to detect CPLD type");
                            }
                            else
                            {
                                jtagdevice = str.Substring(start, end).Trim().Replace("\r\n", "");
                                //Console.WriteLine("DirtyPico: {0} Detected", jtagdevice);
                                mainForm.Instance.Log($"DirtyPico: {jtagdevice} Detected");
                            }

                            //Console.WriteLine("DirtyPico: SVF Flash Successful!");
                            mainForm.Instance.Log("DirtyPico: SVF Flash Successful!");
                            Console.WriteLine("");
                            mainForm.Instance.Log("");

                            //if (variables.playSuccess)
                            //{
                            //    SoundPlayer success = new SoundPlayer(Properties.Resources.chime);
                            //    success.Play();
                            //}
                        }

                        else if (strLower.Contains("chain without any parts") == true)
                        {
                            //Console.WriteLine("DirtyPico: Could not connect to CPLD");
                            mainForm.Instance.Log("DirtyPico: Could not connect to CPLD");
                            //Console.WriteLine("");
                            mainForm.Instance.Log("");
                        }

                        else if (strLower.Contains("stuck at"))
                        {
                            //Console.WriteLine("DirtyPico: TDO stuck at 0");
                            mainForm.Instance.Log("DirtyPico: TDO stuck at 0");
                            //Console.WriteLine("Check wiring or power cycle glitch chip");
                            mainForm.Instance.Log("Check wiring or power cycle glitch chip");
                            //Console.WriteLine("");
                            mainForm.Instance.Log("");
                        }
                        else
                        {
                            //Console.WriteLine("DirtyPico: SVF Flash Failed");
                            mainForm.Instance.Log("DirtyPico: SVF Flash Failed");
                            //Console.WriteLine("");
                            mainForm.Instance.Log("");
                        }

                        if (File.Exists(svfPath))
                        {
                            File.Delete(svfPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        inUse = false;

                        //Console.WriteLine(ex.Message);
                        mainForm.Instance.Log(ex.Message);
                        if (mainForm.Instance.debug) 
                            //Console.WriteLine(ex.ToString());
                            mainForm.Instance.Log(ex.ToString());
                        //Console.WriteLine("");
                        mainForm.Instance.Log("");
                    }
                });
                urJtagThread.Start();
            }
        }
    }
}
