namespace FreeRunner_Flashing_Utility
{
    using System.IO;

    public partial class main : Form
    {
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


        public main()
        {
            InitializeComponent();

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
            phatTimingButtons = new List<RadioButton> {
                //Falcon/Jasper/Tonasket RGH1.2 Timing
                rbFJ17, rbFJ18, rbFJ19, rbFJ20, rbFJ21, rbFJ22, rbFJ23, rbFJ24,

                //Xenon EXT_CLK Timing
                rbX96_1, rbX96_2, rbX192_1, rbX192_2,

                //Zephyr EXT_CLK Timing
                rbZ96_1, rbZ96_2, rbZ192_1, rbZ192_2
            };

            //Adding all slim radio buttons to a list
            slimTimingButtons = new List<RadioButton> {
                slim60, slim65, slim70, slim75, slim80, slim85, slim90, slim95, 
                slim100, slim105, slim110, slim115, slim120, slim125, slim130, slim135
            };

            multiNANDButtons = new List<RadioButton> {
                //Phat Multi-NAND select
                multiNAND1, multiNAND2, multiNAND3, multiNAND4, multiNAND5, multiNAND6,

                //Slim Multi-NAND select
                multiNAND11, multiNAND21, multiNAND31, multiNAND41, multiNAND51, multiNAND61
            };

            //Run once to set default value
            checkMultiNAND(multiNAND1, EventArgs.Empty);

            foreach (var rb in phatTimingButtons)
            {
                rb.CheckedChanged += TimingRadio_CheckedChanged;
            }

            foreach (var rb in slimTimingButtons) {
                rb.CheckedChanged += SlimTimingRadio_CheckChanged;
            }

            foreach (var rb in multiNANDButtons)
            {
                rb.CheckedChanged += checkMultiNAND;
            }
        }
        private void TimingRadio_CheckedChanged(object sender, EventArgs e) {
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


        private void SlimTimingRadio_CheckChanged(object sender, EventArgs e) {
            var selected = sender as RadioButton;
            //If the value null or is a currently selected button
            if (selected == null || !selected.Checked)
                return;

            else {
                boardTr.Enabled = true;
                boardCor.Enabled = true;
                boardCorWB.Enabled = true;

                string category = selected.Tag?.ToString() ?? "Uknown";
                string timing = selected.Text;

                Log($"Selected timing file: {category} {selected.Text}");
            }
        }

        //Creating multiNAND check method
        private void checkMultiNAND(object sender, EventArgs e) {
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

                Log("YOU ARE A GOAT! 🐐");
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

        //Creating progress bar update method
        private void UpdateProgress(int percent) {
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
        private void Log(String message) {
            debugConsole.AppendText(message + Environment.NewLine);
            debugConsole.ScrollToCaret();
        }

        private void progressPanel_Click_1(object sender, EventArgs e) {
            UpdateProgress(100);
        }

        private void clrBtn_Click(object sender, EventArgs e) {
            //Clearing the console
            debugConsole.Clear();

            //Resetting welcome text
            debugConsole.AppendText("Welcome to FreeRunner Flashing Utility!" + Environment.NewLine);
        }

        private void exitBtn_Click(object sender, EventArgs e) {
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

        private void main_Load(object sender, EventArgs e) {
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
                Log("Multi-NAND: " + multiNAND);
                Log("MAX Multi-NAND Enabled: " + enableMax);
            }
        }
    }
}
