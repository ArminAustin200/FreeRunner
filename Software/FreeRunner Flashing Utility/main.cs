namespace FreeRunner_Flashing_Utility
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            progressBar1.Minimum = 0; //Setting min value
            progressBar1.Maximum = 100; //Setting max value
            progressBar1.Value = 0; //Setting current value
        }

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

        private void progressPanel_Click_1(object sender, EventArgs e)
        {
            UpdateProgress(100);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
