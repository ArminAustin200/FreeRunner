
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
            changelogBox = new RichTextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // changelogBox
            // 
            changelogBox.BackColor = SystemColors.ControlLightLight;
            changelogBox.Font = new Font("Consolas", 10.1F);
            changelogBox.Location = new Point(12, 12);
            changelogBox.Name = "changelogBox";
            changelogBox.ReadOnly = true;
            changelogBox.Size = new Size(520, 310);
            changelogBox.TabIndex = 0;
            changelogBox.Text = "";
            // 
            // okButton
            // 
            okButton.Location = new Point(205, 328);
            okButton.Name = "okButton";
            okButton.Size = new Size(150, 25);
            okButton.TabIndex = 1;
            okButton.Tag = "Ok";
            okButton.Text = "Confirm and Update";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // changelog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 361);
            ControlBox = false;
            Controls.Add(okButton);
            Controls.Add(changelogBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "changelog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Changelog";
            ResumeLayout(false);
        }
        #endregion

        private RichTextBox changelogBox;
        private Button okButton;
    }
}