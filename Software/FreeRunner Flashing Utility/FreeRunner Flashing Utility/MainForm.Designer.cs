
namespace FreeRunner_Flashing_Utility
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            returnConsole = new TextBox();
            topPanel = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            progressBar = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(returnConsole);
            splitContainer1.Panel1.Controls.Add(topPanel);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(804, 451);
            splitContainer1.SplitterDistance = 408;
            splitContainer1.TabIndex = 0;
            // 
            // returnConsole
            // 
            returnConsole.BackColor = SystemColors.InfoText;
            returnConsole.Cursor = Cursors.IBeam;
            returnConsole.ForeColor = SystemColors.Window;
            returnConsole.Location = new Point(12, 258);
            returnConsole.Multiline = true;
            returnConsole.Name = "returnConsole";
            returnConsole.ReadOnly = true;
            returnConsole.ScrollBars = ScrollBars.Vertical;
            returnConsole.Size = new Size(389, 187);
            returnConsole.TabIndex = 22;
            returnConsole.TabStop = false;
            // 
            // topPanel
            // 
            topPanel.BorderStyle = BorderStyle.Fixed3D;
            topPanel.Location = new Point(2, 2);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(401, 196);
            topPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(progressBar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 50);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(342, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(48, 16);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(59, 16);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(279, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 1;
            progressBar.Click += progressBar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Progress:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Text = "FreeRunner Flashing Utility";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ProgressBar progressBar;
        private Label label1;
        private TextBox textBox1;
        private Panel topPanel;
        private TextBox returnConsole;
    }
}
