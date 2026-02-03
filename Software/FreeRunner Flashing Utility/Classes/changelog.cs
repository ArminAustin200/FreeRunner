using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeRunner_Flashing_Utility.Classes
{
    public partial class changelog : Form
    {
        public changelog(int revision, string? changelog)
        {
            InitializeComponent();

            string header = $"What's new in version: {revision}.0?:\n";
            changelogBox.SelectionStart = changelogBox.TextLength;
            changelogBox.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold | FontStyle.Underline);
            changelogBox.AppendText(header);


            changelogBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            changelogBox.AppendText (string.IsNullOrWhiteSpace(changelog)
                ? "No changelog provided."
                : changelog);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
