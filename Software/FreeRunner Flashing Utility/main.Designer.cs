namespace FreeRunner_Flashing_Utility
{
    partial class main
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
            debugConsole = new RichTextBox();
            progressPanel = new TableLayoutPanel();
            labelPercent = new Label();
            progressBar1 = new ProgressBar();
            progressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // debugConsole
            // 
            debugConsole.BackColor = SystemColors.ActiveCaptionText;
            debugConsole.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debugConsole.ForeColor = SystemColors.Window;
            debugConsole.Location = new Point(12, 139);
            debugConsole.Name = "debugConsole";
            debugConsole.ReadOnly = true;
            debugConsole.ScrollBars = RichTextBoxScrollBars.Vertical;
            debugConsole.Size = new Size(477, 299);
            debugConsole.TabIndex = 0;
            debugConsole.Text = "This is the console:";
            // 
            // progressPanel
            // 
            progressPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            progressPanel.ColumnCount = 2;
            progressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            progressPanel.ColumnStyles.Add(new ColumnStyle());
            progressPanel.Controls.Add(labelPercent, 1, 0);
            progressPanel.Controls.Add(progressBar1, 0, 0);
            progressPanel.Location = new Point(12, 106);
            progressPanel.Name = "progressPanel";
            progressPanel.RowCount = 1;
            progressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            progressPanel.Size = new Size(477, 27);
            progressPanel.TabIndex = 6;
            progressPanel.Click += progressPanel_Click_1;
            // 
            // labelPercent
            // 
            labelPercent.AutoSize = true;
            labelPercent.Dock = DockStyle.Right;
            labelPercent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPercent.Location = new Point(451, 0);
            labelPercent.Name = "labelPercent";
            labelPercent.Padding = new Padding(0, 5, 0, 0);
            labelPercent.Size = new Size(23, 27);
            labelPercent.TabIndex = 6;
            labelPercent.Text = "0%";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Left;
            progressBar1.Location = new Point(3, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(442, 21);
            progressBar1.TabIndex = 5;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressPanel);
            Controls.Add(debugConsole);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "main";
            Text = "FreeRunner Flashing Utility";
            progressPanel.ResumeLayout(false);
            progressPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox debugConsole;
        private TableLayoutPanel progressPanel;
        private Label labelPercent;
        private ProgressBar progressBar1;
    }
}
