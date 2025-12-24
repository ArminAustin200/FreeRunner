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
            optionsPanel = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            zephyrTimings = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            radioButton19 = new RadioButton();
            radioButton20 = new RadioButton();
            radioButton21 = new RadioButton();
            radioButton22 = new RadioButton();
            label4 = new Label();
            nandSelection = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton16 = new RadioButton();
            radioButton17 = new RadioButton();
            radioButton18 = new RadioButton();
            xenonTimings = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            label1 = new Label();
            fjTimings = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage2 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            progressPanel.SuspendLayout();
            optionsPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            zephyrTimings.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            nandSelection.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            xenonTimings.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            fjTimings.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            // optionsPanel
            // 
            optionsPanel.Controls.Add(tabPage1);
            optionsPanel.Controls.Add(tabPage2);
            optionsPanel.Location = new Point(495, 6);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.SelectedIndex = 0;
            optionsPanel.Size = new Size(301, 439);
            optionsPanel.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(zephyrTimings);
            tabPage1.Controls.Add(nandSelection);
            tabPage1.Controls.Add(xenonTimings);
            tabPage1.Controls.Add(fjTimings);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(293, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phat Timings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 14);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 8;
            label8.Text = "RGH1.2 Timings";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(195, 372);
            label6.Name = "label6";
            label6.Size = new Size(93, 35);
            label6.TabIndex = 6;
            label6.Text = "Recommended Timing: 18-21 for RGH1.2";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(104, 16);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 7;
            label7.Text = "EXT_CLK";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(195, 137);
            label5.Name = "label5";
            label5.Size = new Size(95, 60);
            label5.TabIndex = 5;
            label5.Text = "Select None if you are not using Multi-NAND";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // zephyrTimings
            // 
            zephyrTimings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            zephyrTimings.Controls.Add(tableLayoutPanel4);
            zephyrTimings.Location = new Point(100, 202);
            zephyrTimings.Name = "zephyrTimings";
            zephyrTimings.Size = new Size(93, 174);
            zephyrTimings.TabIndex = 4;
            zephyrTimings.TabStop = false;
            zephyrTimings.Text = "Zephyr";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 0, 3);
            tableLayoutPanel4.Controls.Add(radioButton19, 0, 5);
            tableLayoutPanel4.Controls.Add(radioButton20, 0, 4);
            tableLayoutPanel4.Controls.Add(radioButton21, 0, 2);
            tableLayoutPanel4.Controls.Add(radioButton22, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Location = new Point(4, 17);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.Size = new Size(83, 154);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Padding = new Padding(12, 10, 0, 0);
            label3.Size = new Size(66, 25);
            label3.TabIndex = 7;
            label3.Text = "192MHz";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton19
            // 
            radioButton19.AutoSize = true;
            radioButton19.Location = new Point(3, 132);
            radioButton19.Name = "radioButton19";
            radioButton19.Size = new Size(64, 19);
            radioButton19.TabIndex = 5;
            radioButton19.TabStop = true;
            radioButton19.Text = "62.5 1.0";
            radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(3, 109);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(64, 17);
            radioButton20.TabIndex = 4;
            radioButton20.TabStop = true;
            radioButton20.Text = "62.5 0.9";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            radioButton21.AutoSize = true;
            radioButton21.Location = new Point(3, 56);
            radioButton21.Name = "radioButton21";
            radioButton21.Size = new Size(64, 17);
            radioButton21.TabIndex = 1;
            radioButton21.TabStop = true;
            radioButton21.Text = "62.5 1.0";
            radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            radioButton22.AutoSize = true;
            radioButton22.Location = new Point(3, 33);
            radioButton22.Name = "radioButton22";
            radioButton22.Size = new Size(64, 17);
            radioButton22.TabIndex = 0;
            radioButton22.TabStop = true;
            radioButton22.Text = "62.5 0.9";
            radioButton22.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(15, 10, 0, 0);
            label4.Size = new Size(62, 25);
            label4.TabIndex = 6;
            label4.Text = "96MHz";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nandSelection
            // 
            nandSelection.Controls.Add(tableLayoutPanel3);
            nandSelection.Location = new Point(195, 197);
            nandSelection.Name = "nandSelection";
            nandSelection.Size = new Size(94, 164);
            nandSelection.TabIndex = 3;
            nandSelection.TabStop = false;
            nandSelection.Text = "Multi-NAND";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(radioButton13, 0, 0);
            tableLayoutPanel3.Controls.Add(radioButton14, 0, 1);
            tableLayoutPanel3.Controls.Add(radioButton15, 0, 2);
            tableLayoutPanel3.Controls.Add(radioButton16, 0, 3);
            tableLayoutPanel3.Controls.Add(radioButton17, 0, 4);
            tableLayoutPanel3.Controls.Add(radioButton18, 0, 5);
            tableLayoutPanel3.Location = new Point(19, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.Size = new Size(61, 138);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(3, 3);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(54, 17);
            radioButton13.TabIndex = 0;
            radioButton13.TabStop = true;
            radioButton13.Text = "None";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Location = new Point(3, 26);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(31, 17);
            radioButton14.TabIndex = 1;
            radioButton14.TabStop = true;
            radioButton14.Text = "2";
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(3, 49);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(31, 17);
            radioButton15.TabIndex = 2;
            radioButton15.TabStop = true;
            radioButton15.Text = "3";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            radioButton16.AutoSize = true;
            radioButton16.Location = new Point(3, 72);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(31, 17);
            radioButton16.TabIndex = 3;
            radioButton16.TabStop = true;
            radioButton16.Text = "4";
            radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            radioButton17.AutoSize = true;
            radioButton17.Location = new Point(3, 95);
            radioButton17.Name = "radioButton17";
            radioButton17.Size = new Size(31, 17);
            radioButton17.TabIndex = 4;
            radioButton17.TabStop = true;
            radioButton17.Text = "5";
            radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            radioButton18.AutoSize = true;
            radioButton18.Enabled = false;
            radioButton18.Location = new Point(3, 118);
            radioButton18.Name = "radioButton18";
            radioButton18.Size = new Size(51, 17);
            radioButton18.TabIndex = 5;
            radioButton18.TabStop = true;
            radioButton18.Text = "MAX";
            radioButton18.UseVisualStyleBackColor = true;
            // 
            // xenonTimings
            // 
            xenonTimings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            xenonTimings.Controls.Add(tableLayoutPanel2);
            xenonTimings.Location = new Point(100, 28);
            xenonTimings.Name = "xenonTimings";
            xenonTimings.Size = new Size(93, 174);
            xenonTimings.TabIndex = 2;
            xenonTimings.TabStop = false;
            xenonTimings.Text = "Xenon";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(radioButton12, 0, 5);
            tableLayoutPanel2.Controls.Add(radioButton11, 0, 4);
            tableLayoutPanel2.Controls.Add(radioButton10, 0, 2);
            tableLayoutPanel2.Controls.Add(radioButton9, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(4, 17);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new Size(83, 154);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Padding = new Padding(12, 10, 0, 0);
            label2.Size = new Size(66, 25);
            label2.TabIndex = 7;
            label2.Text = "192MHz";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(3, 132);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(64, 19);
            radioButton12.TabIndex = 5;
            radioButton12.TabStop = true;
            radioButton12.Text = "59.4 1.0";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(3, 109);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(64, 17);
            radioButton11.TabIndex = 4;
            radioButton11.TabStop = true;
            radioButton11.Text = "59.4 0.9";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(3, 56);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(64, 17);
            radioButton10.TabIndex = 1;
            radioButton10.TabStop = true;
            radioButton10.Text = "59.4 1.0";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(3, 33);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(64, 17);
            radioButton9.TabIndex = 0;
            radioButton9.TabStop = true;
            radioButton9.Text = "59.4 0.9";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 10, 0, 0);
            label1.Size = new Size(62, 25);
            label1.TabIndex = 6;
            label1.Text = "96MHz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fjTimings
            // 
            fjTimings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fjTimings.Controls.Add(tableLayoutPanel1);
            fjTimings.Location = new Point(6, 28);
            fjTimings.Name = "fjTimings";
            fjTimings.Size = new Size(93, 214);
            fjTimings.TabIndex = 1;
            fjTimings.TabStop = false;
            fjTimings.Text = "Falcon/Jasper";
            fjTimings.Enter += groupBox1_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(radioButton8, 0, 7);
            tableLayoutPanel1.Controls.Add(radioButton7, 0, 6);
            tableLayoutPanel1.Controls.Add(radioButton6, 0, 5);
            tableLayoutPanel1.Controls.Add(radioButton5, 0, 4);
            tableLayoutPanel1.Controls.Add(radioButton4, 0, 3);
            tableLayoutPanel1.Controls.Add(radioButton3, 0, 2);
            tableLayoutPanel1.Controls.Add(radioButton2, 0, 1);
            tableLayoutPanel1.Controls.Add(radioButton1, 0, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(23, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new Size(51, 184);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButton8
            // 
            radioButton8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(7, 164);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(37, 17);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "24";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(7, 141);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(37, 17);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "23";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(7, 118);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(37, 17);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "22";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(7, 95);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(37, 17);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "21";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(7, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(37, 17);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "20";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(7, 49);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(37, 17);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "19";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(37, 17);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "18";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "17";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(293, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Slim Timings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(414, 20);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 8;
            button1.Text = "Program Timing File";
            button1.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(optionsPanel);
            Controls.Add(progressPanel);
            Controls.Add(debugConsole);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "main";
            Text = "FreeRunner Flashing Utility";
            progressPanel.ResumeLayout(false);
            progressPanel.PerformLayout();
            optionsPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            zephyrTimings.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            nandSelection.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            xenonTimings.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            fjTimings.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox debugConsole;
        private TableLayoutPanel progressPanel;
        private Label labelPercent;
        private ProgressBar progressBar1;
        private TabControl optionsPanel;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private GroupBox fjTimings;
        private GroupBox xenonTimings;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private Label label1;
        private Button button1;
        private GroupBox nandSelection;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private GroupBox zephyrTimings;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private RadioButton radioButton21;
        private RadioButton radioButton22;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
