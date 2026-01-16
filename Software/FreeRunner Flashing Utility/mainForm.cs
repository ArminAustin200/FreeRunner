using FreeRunner_Flashing_Utility.Classes;
using FreeRunner_Flashing_Utility.Properties;
using LibUsbDotNet.WinUsb;
using Microsoft.VisualBasic.Logging;
using System.IO;
using System.Management;
using System.Media;

namespace FreeRunner_Flashing_Utility
{
    public partial class mainForm : Form
    {
        public enum DEVICE
        {
            JR_PROGRAMMER_BOOTLOADER = -1,
            NO_DEVICE = 0,
            JR_PROGRAMMER = 1,
            NAND_X = 2,
            XFLASHER_SPI = 3,
            XFLASHER_EMMC = 4,
            PICOFLASHER = 5,
            DIRTYPICO = 6,
        }

        public xFlasher xflasher = new xFlasher();
        public DirtyPico dirtypico = new DirtyPico();

        //Windows device-change messages (for USB plug/unplug detection)
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVNODES_CHANGED = 0x0007;

        //Timer used to delay USB rescan slightly so WMI can see new devices
        private System.Windows.Forms.Timer usbChangeTimer;

        //How many times we've tried to rescan after a plug event
        //private int usbScanAttempts;



        //DEBUG BOOLEAN
        public bool debug = false;

        //Creating list to hold all phatTimingButtons
        private List<RadioButton> phatTimingButtons;

        //Creating list to hold all multiNAND buttons
        private List<RadioButton> multiNANDButtons;

        //Creating a list to hold all slimTimingButtons
        private List<RadioButton> slimTimingButtons;

        //Creating a variable to store multiNAND value
        private int multiNAND;

        //Creating a variable to store the board type
        private string boardType = "";

        //Creating a variable to store the filename
        private String filename;

        public DEVICE device = DEVICE.NO_DEVICE;

        private String welcomeText = "Welcome to FreeRunner Flashing Utility!\n" +
                                     "By: ArminAustin200";

        public static mainForm Instance {get; private set;}
        public mainForm()
        {
            //Initializing main window
            InitializeComponent();
            Instance = this;

            //Centering pictureBox1
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            // Timer to debounce / delay USB rescans after plug events
            usbChangeTimer = new System.Windows.Forms.Timer();
            usbChangeTimer.Interval = 10; // milliseconds was 10ms
            usbChangeTimer.Tick += (s, e) =>
            {
                usbChangeTimer.Stop();  // one-shot
                deviceinit();           // now WMI should see the new device
            };

            //Clearing the console
            Log_Clear();

            //Setting min value
            progressBar1.Minimum = 0;
            //Setting max value
            progressBar1.Maximum = 100;
            //Setting current value
            progressBar1.Value = 0;

            //Adding all phat radio buttons to a list
            phatTimingButtons = new List<RadioButton>
            {
                //Falcon/Jasper/Tonasket RGH1.2 Timing
                rbFJ17, rbFJ18, rbFJ19, rbFJ20, rbFJ21, rbFJ22, rbFJ23, rbFJ24,

                //Xenon EXT_CLK Timing
                rbX_96, rbX_192,

                //Zephyr EXT_CLK Timing
                rbZ_96, rbZ_192
            };

            //Adding all slim radio buttons to a list
            slimTimingButtons = new List<RadioButton>
            {
                slim60, slim65, slim70, slim75, slim80, slim85, slim90, slim95,
                slim100, slim105, slim110, slim115, slim120, slim125, slim130, slim135
            };

            multiNANDButtons = new List<RadioButton>
            {
                //Phat Multi-NAND select
                multiNAND1, multiNAND2, multiNAND3, multiNAND4, multiNAND5, multiNAND6,

                //Slim Multi-NAND select
                multiNAND11, multiNAND21, multiNAND31, multiNAND41, multiNAND51, multiNAND61
            };

            //Running at start to set multiNAND value
            checkMultiNAND(multiNAND1, EventArgs.Empty);

            //Running at start to set boardType
            boardTypeSelect(boardTr, EventArgs.Empty);

            deviceinit();

            foreach (var rb in phatTimingButtons)
            {
                rb.CheckedChanged += TimingRadio_CheckedChanged;
            }

            foreach (var rb in slimTimingButtons)
            {
                rb.CheckedChanged += SlimTimingRadio_CheckChanged;
            }

            foreach (var rb in multiNANDButtons)
            {
                rb.CheckedChanged += checkMultiNAND;
            }

            //Resetting filename on startup
            filename = "";
        }

        private void TimingRadio_CheckedChanged(object sender, EventArgs e)
        {
            //If the value null or is a currently selected button
            var selected = sender as RadioButton;
            if (selected == null || !selected.Checked)
                return;
            //Disable slim board types
            boardTr.Enabled = false;
            boardCor.Enabled = false;
            boardCorWB.Enabled = false;

            //Uncheck all slim buttons
            foreach (var rb in slimTimingButtons) {
                if (rb.Checked)
                    rb.Checked = false; ;
            }

            // Uncheck all other timing radios
            foreach (var rb in phatTimingButtons)
            {
                if (rb != selected)
                    rb.Checked = false;
            }

            string category = selected.Tag?.ToString() ?? "Uknown";
            string timing = selected.Text;

            if (category.Contains("Xenon") || category.Contains("Zephyr"))
            {
                //Disable multi-NAND
                multiNAND1.Enabled = false;
                multiNAND2.Enabled = false;
                multiNAND3.Enabled = false;
                multiNAND4.Enabled = false;
                multiNAND5.Enabled = false;
                multiNAND6.Enabled = false;

                //Forcing no multi-NAND
                multiNAND1.Checked = true;

                //Set filename
                filename = $"maxv_ext_clk_{selected.Text.ToLower()}_{category.ToLower()}.svf";
            }
            else
            {
                //Enable multi-NAND
                multiNAND1.Enabled = true;
                multiNAND2.Enabled = true;
                multiNAND3.Enabled = true;
                multiNAND4.Enabled = true;
                multiNAND5.Enabled = true;
                multiNAND6.Enabled = true;

                //Set filename
                filename = "maxv_fj_" + selected.Text +"_rgh12.svf";
            }

            if(debug)
                Log($"Filename: {filename}");
        }

        private void SlimTimingRadio_CheckChanged(object sender, EventArgs e)
        {
            //Uncheck all phat buttons
            foreach (var rb in phatTimingButtons)
            {
                if (rb.Checked)
                    rb.Checked = false; ;
            }

            var selected = sender as RadioButton;
            //If the value null or is a currently selected button
            if (selected == null || !selected.Checked)
                return;

            else
            {
                //Enabling board type buttons
                boardTr.Enabled = true;
                boardCor.Enabled = true;
                boardCorWB.Enabled = true;

                string timing = selected.Text;

                //Setting filename
                if (boardType.Equals("Trinity"))
                {
                    filename = "maxv_tr_";
                }
                else if (boardType.Equals("Corona"))
                {
                    filename = "maxv_cr_";
                }
                else 
                    filename = "maxv_cr_wb_";

                filename = filename + $"{selected.Text}_rgh12.svf";

                if (debug)
                    Log($"Filename: {filename}");
            }
        }

        //Creating multiNAND check method
        private void checkMultiNAND(object sender, EventArgs e)
        {
            var selected = sender as RadioButton;
            //If the value null or is a currently selected button
            if (selected == null || !selected.Checked)
                return;

            //If the None button is selected
            if (selected.Text == "None")
            {
                //Set to a value of -1
                multiNAND = -1;
            }

            //If the MAX button is selected
            else if (selected.Text == "MAX")
            {
                //Set to a value of 6
                multiNAND = 6;

                Log("YOU ARE THE GOAT! 🐐");
            }

            //If any other button is selected
            else
            {
                //Set to the value of the button
                multiNAND = int.Parse(selected.Text);
            }

            if (debug)
                Log("Multi-NAND: " + multiNAND);
            
        }

        private void boardTypeSelect(object sender, EventArgs e)
        {
            var selected = sender as RadioButton;

            //If the value null or is a currently selected button
            if (selected == null || !selected.Checked)
                return;

            else
            {
                boardType = selected.Text;

                String timing = "";

                foreach (var rb in slimTimingButtons) {
                    if (rb.Checked) { 
                        timing = rb.Text;
                    }
                }

                //Setting filename
                if (boardType.Equals("Trinity"))
                {
                    filename = "maxv_tr_";
                }
                else if (boardType.Equals("Corona"))
                {
                    filename = "maxv_cr_";
                }
                else
                    filename = "maxv_cr_wb_";

                filename = filename + $"{timing}_rgh12.svf";

                if (debug)
                    Log($"Filename: {filename}");
            }
        }

        //Creating progress bar update method
        public void UpdateProgress(int percent)
        {
            if (percent < progressBar1.Minimum)
            {
                percent = progressBar1.Minimum;
            }
            if (percent > progressBar1.Maximum)
            {
                percent = progressBar1.Maximum;
            }

            progressBar1.Value = percent;

            //Setting progress label text
            labelPercent.Text = percent.ToString() + "%";
        }

        //Creating log updater method
        public void Log(String message)
        {
            if (IsDisposed) return;

            void Write()
            {
                if (message.StartsWith("WARNING:", StringComparison.OrdinalIgnoreCase) || message.StartsWith("DirtyPico: Check", StringComparison.OrdinalIgnoreCase))
                    debugConsole.SelectionColor = Color.Red;
                else
                    debugConsole.SelectionColor = debugConsole.ForeColor;

                debugConsole.AppendText(message + Environment.NewLine);
                debugConsole.ScrollToCaret();
            }

            if (debugConsole.InvokeRequired)
                debugConsole.BeginInvoke((Action)Write);
            else
                Write();
        }

        //Creating log clear method
        private void Log_Clear() { 
            debugConsole.Clear();
        }

        //Creating application path getter method
        private String getPath()
        {
            return Path.Combine(Environment.CurrentDirectory, "common", "SVF");
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clearing the console
            Log_Clear();

            //Resetting welcome text
            Log(welcomeText);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private async void main_Load(object sender, EventArgs e)
        {
            bool updFail = false;

            try
            {
                //Current program revision
                int currentVersion = 1;

                await update.CheckAndUpdateFullAsync(
                    "https://raw.githubusercontent.com/ArminAustin200/FreeRunner-Flash-Utility-Updater/refs/heads/main/autoupdate.json", //Update JSON URL
                    currentVersion,
                    onProgress: p => UpdateProgress(p),
                    onStatus: msg => Log(msg)
                );
            }
            catch (Exception ex)
            {
                Log("Update Failed: " + ex.Message);

                updFail = true;
            }

            if (!updFail) {
                await Task.Delay(1000);
                Log_Clear();
            }

            //Resetting welcome text
            Log(welcomeText);

            //Generate path to the config file
            string filePath = Path.Combine(Application.StartupPath, "config.cfg");

            string requiredValue = "PRE_ORDER_GOAT";

            bool enableMax = false;

            //Checking if the file exists
            if (File.Exists(filePath))
            {
                //Reading all content of the file
                foreach (string line in File.ReadAllLines(filePath))
                {
                    //If the line is empty or commented
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    //Normalizing spacing and case
                    string trimmed = line.Trim().ToUpper();

                    //Looking for target value
                    if (trimmed.StartsWith(requiredValue))
                    {
                        string[] parts = trimmed.Split('=');

                        if (parts.Length == 2)
                        {
                            string value = parts[1].Trim();

                            if (value == "TRUE" || value == "YES" || value == "1" || value == "ENABLED")
                            {
                                enableMax = true;
                            }
                        }
                    }

                    //Looking for debug value
                    else if (trimmed.StartsWith("DEBUG"))
                    {
                        string[] parts = trimmed.Split('=');

                        if (parts.Length == 2)
                        {
                            string value = parts[1].Trim();

                            if (value == "TRUE" || value == "YES" || value == "1" || value == "ENABLED")
                            {
                                debug = true;
                            }
                        }
                    }
                }
            }

            multiNAND6.Enabled = enableMax;
            multiNAND61.Enabled = enableMax;

            if ((!enableMax && multiNAND6.Enabled) || (!enableMax && multiNAND61.Enabled))
            {
                multiNAND1.Checked = true;
                multiNAND11.Checked = true;
            }

            if (debug)
            {
                Log("Debug Enabled: " + debug);
                Log("MAX Multi-NAND Enabled: " + enableMax);
                Log("Multi-NAND: " + multiNAND);
                Log("Board Type: " + boardType);

                await Task.Delay(2500); //Wait 2.5s
                Log_Clear();
                Log(welcomeText);
            }

            //Check for USB devices
            deviceinit();
        }

        public bool IsUsbDeviceConnected(string pid, string vid)
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher(
                           @"SELECT * FROM Win32_USBControllerDevice"))
                using (var collection = searcher.Get())
                {
                    foreach (ManagementObject device in collection)
                    {
                        // "Dependent" looks like: 
                        // Win32_PnPEntity.DeviceID="USB\VID_600D&PID_7001\..."
                        var dependent = device["Dependent"]?.ToString();
                        if (string.IsNullOrEmpty(dependent))
                            continue;

                        if (dependent.Contains(pid, StringComparison.OrdinalIgnoreCase) &&
                            dependent.Contains(vid, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (ManagementException)
            {
                // WMI provider in a weird state; treat as "device not connected"
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                // COM / RPC glitch in WMI; ignore
            }
            catch (InvalidCastException)
            {
                // Exactly the exception you're seeing – ignore and return false
            }

            return false;
        }

        public delegate void UpdatedDevice();
        public event UpdatedDevice updateDevice;

        private void deviceinit()
        {
            // Remember what the device was before this rescan
            DEVICE previousDevice = device;

            // Reset and re-detect from scratch
            device = DEVICE.NO_DEVICE;

            if (IsUsbDeviceConnected("7001", "600D")) // PicoFlasher
            {
                setImage(Properties.Resources.picoflasher); //Update the image to PicoFlasher
                device = DEVICE.PICOFLASHER;

                if (previousDevice != DEVICE.PICOFLASHER && debug)
                    Log($"{device} Connected!");
            }

            else if (IsUsbDeviceConnected("C0CA", "1209")) // DirtyPico
            {
                setImage(Properties.Resources.dirtypico);
                device = DEVICE.DIRTYPICO;

                Log("Creds to ThisIsCheez for creating DirtyPico360 :D");

                if (previousDevice != DEVICE.DIRTYPICO && debug)
                    Log($"{device} Connected!");
            }

            else if (IsUsbDeviceConnected("8338", "11D4"))
            {  // JR-Programmer
                setImage(Properties.Resources.jrp);

                if (previousDevice != DEVICE.JR_PROGRAMMER && debug)
                    Log($"{device} Connected!");

            }
            else if (IsUsbDeviceConnected("6010", "0403")) // xFlasher SPI
            {
                setImage(Properties.Resources.xflash_spi); //Update the image to xFlasher
                device = DEVICE.XFLASHER_SPI;
                xflasher.ready = true; // Skip init

                if (previousDevice != DEVICE.XFLASHER_SPI && debug)
                    Log($"{device} Connected!");
            }
            else if (IsUsbDeviceConnected("8334", "11D4")) // JR-Programmer Bootloader
            {
                setImage(Properties.Resources.jrp); //Update the image to JR-Programmer
                device = DEVICE.JR_PROGRAMMER_BOOTLOADER;

                if (previousDevice != DEVICE.JR_PROGRAMMER_BOOTLOADER && debug)
                    Log($"{device} Connected!");
            }

            if (device == DEVICE.NO_DEVICE) // Must check this after everything else
            {
                if (IsUsbDeviceConnected("AAAA", "8816") || IsUsbDeviceConnected("05E3", "0751")) // xFlasher eMMC
                {
                    setImage(Properties.Resources.xflash_emmc); //Update the image to xFlasher eMMC
                    device = DEVICE.XFLASHER_EMMC;

                    if (previousDevice != DEVICE.XFLASHER_EMMC && debug)
                        Log($"{device} Connected!");
                }
            }

            //If a valid device was unplugged
            if (previousDevice != DEVICE.NO_DEVICE && device == DEVICE.NO_DEVICE)
            {
                if (debug)
                {
                    Log($"{previousDevice} disconnected!");
                }

                //Clearing the image
                setImage(null);

                //Resetting progress bar
                UpdateProgress(0);
            }

            try // It'll fail if the thing doesn't exist
            {
                if (updateDevice != null)
                    updateDevice();
            }
            catch
            {
                // Do nothing
            }
        }

        private void UsbChangeTimer_Tick(object sender, EventArgs e)
        {
            //usbScanAttempts++;

            // Re-scan USB devices
            deviceinit();

            // Stop if we’ve found something or tried ~5 seconds worth of scans
            if (device != DEVICE.NO_DEVICE) // || usbScanAttempts >= 10
            {
                usbChangeTimer.Stop();
            }
        }

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == WM_DEVICECHANGE)
        //    {
        //        int wParam = m.WParam.ToInt32();

        //        // Optional debug – helps you see what Windows is sending
        //        // Log($"WM_DEVICECHANGE wParam = 0x{wParam:X}");

        //        // For any of these events, re-scan USB devices
        //        if (wParam == DBT_DEVICEARRIVAL ||
        //            wParam == DBT_DEVICEREMOVECOMPLETE ||
        //            wParam == DBT_DEVNODES_CHANGED)
        //        {
        //            if (usbChangeTimer != null)
        //            {
        //                usbChangeTimer.Stop();
        //                usbChangeTimer.Start();   // will call deviceinit() on Tick
        //            }
        //        }
        //    }

        //    // Let the base class also handle the message
        //    base.WndProc(ref m);
        //}

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                int wParam = m.WParam.ToInt32();

                // Treat ANY of these as "USB bus changed, rescan after debounce"
                if (wParam == DBT_DEVICEARRIVAL ||
                    wParam == DBT_DEVICEREMOVECOMPLETE ||
                    wParam == DBT_DEVNODES_CHANGED)
                {
                    if (usbChangeTimer != null)
                    {
                        usbChangeTimer.Stop();  // reset debounce window
                        usbChangeTimer.Start(); // deviceinit() will run once after 750ms
                    }
                }
            }

            base.WndProc(ref m);
        }

        private void setImage(Image m)
        {
            pictureBox1.Image = m;
        }

        private void programBtn_pressed(object sender, EventArgs e)
        {
            //If a SVF Program is attempted with no device attached
            if (device == DEVICE.NO_DEVICE)
            { 
                Log("Please attach a valid programmer before continuing!");
                SystemSounds.Asterisk.Play(); //Notify user
            }

            //If a SVF Program is attempted in eMMC mode (xFlasher_eMMC)
            else if (device == DEVICE.XFLASHER_EMMC)
            {
                MessageBox.Show(
                    "Please switch to SPI mode before continuing.",
                    "Wrong Mode Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            //If SVF Program is attempted with xFlasher
            else if (device == DEVICE.XFLASHER_SPI)
            {
                //If there is a valid filename
                if (filename != null && filename != "")
                    xflasher.flashSvf(Path.Combine(getPath(), filename));
                else {
                    Log("Please select a timing before continuing!");
                    SystemSounds.Asterisk.Play();
                }
            }

            ///////ADD DIRTYPICO SUPPORT AS WELL\\\\\\\\\\\
            else if (device == DEVICE.DIRTYPICO){
                //If there is a valid filename
                if (filename != null && filename != "")
                    dirtypico.flashSvf(Path.Combine(getPath(), filename));
                else {
                    Log("Please select a timing before continuing!");
                    SystemSounds.Asterisk.Play();
                }
            }


            //If SVF Program is attempted with PicoFlasher
            else if (device == DEVICE.PICOFLASHER)
            {
                MessageBox.Show(
                    "PicoFlasher firmware is not supported. Please use DirtyPico360 firmware instead.",
                    "Unsupported Flasher Detected!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Log($"DirtyPico360 Firmware can be found in: {Path.Combine(Environment.CurrentDirectory, "common", "DirtyPico360")}");
                SystemSounds.Asterisk.Play();
            }

            //If SVF Program is attempted with JRP or NANDX 
            else if (device == DEVICE.JR_PROGRAMMER || device == DEVICE.NAND_X)
            {
                MessageBox.Show(
                    "The JR-Programmer/NAND-X are not yet supported, but don't worry, we're working on adding support for those very soon :)",
                    "Unsupported Flasher Detected!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
