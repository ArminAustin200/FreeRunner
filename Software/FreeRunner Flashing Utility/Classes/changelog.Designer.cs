
namespace FreeRunner_Flashing_Utility.Classes
{
    partial class changelog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            changelogBox = new RichTextBox();
            okButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(changelogBox, 0, 0);
            tableLayoutPanel1.Controls.Add(okButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(622, 481);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // changelogBox
            // 
            changelogBox.BackColor = SystemColors.ControlLightLight;
            changelogBox.Dock = DockStyle.Fill;
            changelogBox.Font = new Font("Consolas", 10.1F);
            changelogBox.Location = new Point(3, 4);
            changelogBox.Margin = new Padding(3, 4, 3, 4);
            changelogBox.Name = "changelogBox";
            changelogBox.ReadOnly = true;
            changelogBox.Size = new Size(616, 432);
            changelogBox.TabIndex = 3;
            changelogBox.Text = "";
            // 
            // okButton
            // 
            okButton.Dock = DockStyle.Fill;
            okButton.Location = new Point(3, 444);
            okButton.Margin = new Padding(3, 4, 3, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(616, 33);
            okButton.TabIndex = 2;
            okButton.Tag = "Ok";
            okButton.Text = "Confirm and Update";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // changelog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 481);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "changelog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Changelog";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox changelogBox;
        private Button okButton;
    }
}