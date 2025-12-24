using LibUsbDotNet.WinUsb;
using System.IO;
using System.Management;

namespace FreeRunner_Flashing_Utility
{
    public partial class main : Form
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
        }

        public xFlasher xflasher = new xFlasher();

        // Windows device-change messages (for USB plug/unplug detection)
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

        // Timer used to delay USB rescan slightly so WMI can see new devices
        private System.Windows.Forms.Timer usbChangeTimer;



        //DEBUG BOOLEAN
        private bool debug = false;

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

        public DEVICE device = DEVICE.NO_DEVICE;

        public main()
        {
            InitializeComponent();

            // Timer to debounce / delay USB rescans after plug events
            usbChangeTimer = new System.Windows.Forms.Timer();
            usbChangeTimer.Interval = 10; // milliseconds
            usbChangeTimer.Tick += (s, e) =>
            {
                usbChangeTimer.Stop();  // one-shot
                deviceinit();           // now WMI should see the new device
            };

            //Clearing the console
            debugConsole.Clear();

            //Resetting welcome text
            debugConsole.AppendText("Welcome to FreeRunner Flashing Utility!" + Environment.NewLine);

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
                rbX96_1, rbX96_2, rbX192_1, rbX192_2,

                //Zephyr EXT_CLK Timing
                rbZ96_1, rbZ96_2, rbZ192_1, rbZ192_2
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
        }
        private void TimingRadio_CheckedChanged(object sender, EventArgs e)
        {
            //If the value null or is a currently selected button
            var selected = sender as RadioButton;
            if (selected == null || !selected.Checked)
                return;

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
                Log($"Selected timing file: {category}MHz {selected.Text}");
            }
            else
            {
                Log($"Selected timing file: {category} {selected.Text}");
            }
        }


        private void SlimTimingRadio_CheckChanged(object sender, EventArgs e)
        {
            var selected = sender as RadioButton;
            //If the value null or is a currently selected button
            if (selected == null || !selected.Checked)
                return;

            else
            {
                boardTr.Enabled = true;
                boardCor.Enabled = true;
                boardCorWB.Enabled = true;

                string category = selected.Tag?.ToString() ?? "Uknown";
                string timing = selected.Text;

                Log($"Selected timing file: {category} {selected.Text}");
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
            {
                Log("Multi-NAND: " + multiNAND);
            }
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

                if (debug)
                {
                    Log("Board Type: " + boardType);
                }
            }
        }

        //Creating progress bar update method
        private void UpdateProgress(int percent)
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
        private void Log(String message)
        {
            debugConsole.AppendText(message + Environment.NewLine);
            debugConsole.ScrollToCaret();
        }

        private void progressPanel_Click_1(object sender, EventArgs e)
        {
            UpdateProgress(100);
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clearing the console
            debugConsole.Clear();

            //Resetting welcome text
            debugConsole.AppendText("Welcome to FreeRunner Flashing Utility!" + Environment.NewLine);
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

        private void main_Load(object sender, EventArgs e)
        {
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
            }
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
                //nTools.setImage(Properties.Resources.picoflasher);
                //PicoFlasherToolStripMenuItem.Visible = true;
                device = DEVICE.PICOFLASHER;
            }
            else if (IsUsbDeviceConnected("6010", "0403")) // xFlasher SPI
            {
                //nTools.setImage(Properties.Resources.xflash_spi);
                //xFlasherToolStripMenuItem.Visible = true;
                device = DEVICE.XFLASHER_SPI;
                xflasher.ready = true; // Skip init

                // Only log when we *enter* the xFlasher state
                if (previousDevice != DEVICE.XFLASHER_SPI)
                    Log("XFlasher Connected!");
            }
            else if (IsUsbDeviceConnected("8334", "11D4")) // JR-Programmer Bootloader
            {
                //nTools.setImage(Properties.Resources.usb);
                //jRPBLToolStripMenuItem.Visible = true;
                device = DEVICE.JR_PROGRAMMER_BOOTLOADER;
            }

            if (device == DEVICE.NO_DEVICE) // Must check this after everything else
            {
                if (IsUsbDeviceConnected("AAAA", "8816") || IsUsbDeviceConnected("05E3", "0751")) // xFlasher eMMC
                {
                    //nTools.setImage(Properties.Resources.xflash_emmc);
                    //xFlasherToolStripMenuItem.Visible = true;
                    device = DEVICE.XFLASHER_EMMC;
                }
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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_DEVICECHANGE)
            {
                int wParam = m.WParam.ToInt32();

                if (wParam == DBT_DEVICEARRIVAL)
                {
                    // Device just arrived – wait a bit so Windows finishes enumeration,
                    // then rescan using deviceinit().
                    if (usbChangeTimer != null)
                    {
                        usbChangeTimer.Stop();
                        usbChangeTimer.Start();
                    }
                }
                else if (wParam == DBT_DEVICEREMOVECOMPLETE)
                {
                    // Device removal is complete – safe to rescan immediately.
                    deviceinit();
                }
            }
        }

    }
}
