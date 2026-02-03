namespace FreeRunner_Flashing_Utility
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            debugConsole = new RichTextBox();
            progressPanel = new TableLayoutPanel();
            labelPercent = new Label();
            progressBar1 = new ProgressBar();
            optionsPanel = new TabControl();
            tabPage1 = new TabPage();
            groupBox6 = new GroupBox();
            label2 = new Label();
            nandSelection = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            multiNAND5 = new RadioButton();
            multiNAND1 = new RadioButton();
            multiNAND4 = new RadioButton();
            multiNAND2 = new RadioButton();
            multiNAND3 = new RadioButton();
            multiNAND6 = new RadioButton();
            label6 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            label8 = new Label();
            fjTimings = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            rbFJ24 = new RadioButton();
            rbFJ23 = new RadioButton();
            rbFJ22 = new RadioButton();
            rbFJ21 = new RadioButton();
            rbFJ20 = new RadioButton();
            rbFJ19 = new RadioButton();
            rbFJ18 = new RadioButton();
            rbFJ17 = new RadioButton();
            exitButton = new Button();
            clearButton = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            label7 = new Label();
            xenonTimings = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            rbX_96 = new RadioButton();
            rbX_192 = new RadioButton();
            zephyrTimings = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            rbZ_96 = new RadioButton();
            rbZ_192 = new RadioButton();
            splitContainer1 = new SplitContainer();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label13 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            multiNAND51 = new RadioButton();
            multiNAND11 = new RadioButton();
            multiNAND41 = new RadioButton();
            multiNAND21 = new RadioButton();
            multiNAND31 = new RadioButton();
            multiNAND61 = new RadioButton();
            groupBox2 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            boardTr = new RadioButton();
            boardCor = new RadioButton();
            boardCorWB = new RadioButton();
            label9 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            slim100 = new RadioButton();
            slim105 = new RadioButton();
            slim110 = new RadioButton();
            slim115 = new RadioButton();
            slim120 = new RadioButton();
            slim125 = new RadioButton();
            slim130 = new RadioButton();
            slim135 = new RadioButton();
            slim60 = new RadioButton();
            slim65 = new RadioButton();
            slim70 = new RadioButton();
            slim75 = new RadioButton();
            slim80 = new RadioButton();
            slim85 = new RadioButton();
            slim90 = new RadioButton();
            slim95 = new RadioButton();
            exitButton1 = new Button();
            clearButton1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            programBtn = new Button();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            toolStrip1 = new ToolStrip();
            mainToolStrip = new ToolStripDropDownButton();
            openFileBtn = new ToolStripMenuItem();
            exitBtn = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            changelogButton = new ToolStripMenuItem();
            progressPanel.SuspendLayout();
            optionsPanel.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox6.SuspendLayout();
            nandSelection.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            fjTimings.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            xenonTimings.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            zephyrTimings.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // debugConsole
            // 
            debugConsole.BackColor = SystemColors.ActiveCaptionText;
            debugConsole.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debugConsole.ForeColor = SystemColors.Window;
            debugConsole.Location = new Point(14, 185);
            debugConsole.Margin = new Padding(3, 4, 3, 4);
            debugConsole.Name = "debugConsole";
            debugConsole.ReadOnly = true;
            debugConsole.ScrollBars = RichTextBoxScrollBars.Vertical;
            debugConsole.Size = new Size(545, 397);
            debugConsole.TabIndex = 0;
            debugConsole.Text = "";
            // 
            // progressPanel
            // 
            progressPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            progressPanel.ColumnCount = 2;
            progressPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            progressPanel.ColumnStyles.Add(new ColumnStyle());
            progressPanel.Controls.Add(labelPercent, 1, 0);
            progressPanel.Controls.Add(progressBar1, 0, 0);
            progressPanel.Location = new Point(14, 141);
            progressPanel.Margin = new Padding(3, 4, 3, 4);
            progressPanel.Name = "progressPanel";
            progressPanel.RowCount = 1;
            progressPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            progressPanel.Size = new Size(545, 36);
            progressPanel.TabIndex = 6;
            // 
            // labelPercent
            // 
            labelPercent.AutoSize = true;
            labelPercent.Dock = DockStyle.Right;
            labelPercent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPercent.Location = new Point(513, 0);
            labelPercent.Name = "labelPercent";
            labelPercent.Padding = new Padding(0, 7, 0, 0);
            labelPercent.Size = new Size(29, 36);
            labelPercent.TabIndex = 6;
            labelPercent.Text = "0%";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Left;
            progressBar1.Location = new Point(3, 4);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(498, 28);
            progressBar1.TabIndex = 5;
            // 
            // optionsPanel
            // 
            optionsPanel.Controls.Add(tabPage1);
            optionsPanel.Controls.Add(tabPage2);
            optionsPanel.Location = new Point(566, 24);
            optionsPanel.Margin = new Padding(3, 4, 3, 4);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.SelectedIndex = 0;
            optionsPanel.Size = new Size(344, 569);
            optionsPanel.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(nandSelection);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tableLayoutPanel9);
            tabPage1.Controls.Add(exitButton);
            tabPage1.Controls.Add(clearButton);
            tabPage1.Controls.Add(tableLayoutPanel8);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(336, 536);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phat Timings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label2);
            groupBox6.Location = new Point(147, 364);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(181, 65);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label2.Location = new Point(0, 15);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 12;
            label2.Text = "Select None if you are not using NAND-wich";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // nandSelection
            // 
            nandSelection.Controls.Add(tableLayoutPanel3);
            nandSelection.Location = new Point(10, 421);
            nandSelection.Margin = new Padding(3, 4, 3, 4);
            nandSelection.Name = "nandSelection";
            nandSelection.Padding = new Padding(3, 4, 3, 4);
            nandSelection.Size = new Size(315, 71);
            nandSelection.TabIndex = 3;
            nandSelection.TabStop = false;
            nandSelection.Text = "Multi-NAND";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.Controls.Add(multiNAND5, 4, 0);
            tableLayoutPanel3.Controls.Add(multiNAND1, 0, 0);
            tableLayoutPanel3.Controls.Add(multiNAND4, 3, 0);
            tableLayoutPanel3.Controls.Add(multiNAND2, 1, 0);
            tableLayoutPanel3.Controls.Add(multiNAND3, 2, 0);
            tableLayoutPanel3.Controls.Add(multiNAND6, 5, 0);
            tableLayoutPanel3.Location = new Point(6, 28);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(305, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // multiNAND5
            // 
            multiNAND5.AutoSize = true;
            multiNAND5.Location = new Point(198, 4);
            multiNAND5.Margin = new Padding(3, 4, 3, 4);
            multiNAND5.Name = "multiNAND5";
            multiNAND5.Size = new Size(34, 24);
            multiNAND5.TabIndex = 4;
            multiNAND5.Text = "5";
            multiNAND5.UseVisualStyleBackColor = true;
            // 
            // multiNAND1
            // 
            multiNAND1.AutoSize = true;
            multiNAND1.Checked = true;
            multiNAND1.Location = new Point(3, 4);
            multiNAND1.Margin = new Padding(3, 4, 3, 4);
            multiNAND1.Name = "multiNAND1";
            multiNAND1.Size = new Size(66, 24);
            multiNAND1.TabIndex = 0;
            multiNAND1.TabStop = true;
            multiNAND1.Text = "None";
            multiNAND1.UseVisualStyleBackColor = true;
            // 
            // multiNAND4
            // 
            multiNAND4.AutoSize = true;
            multiNAND4.Location = new Point(158, 4);
            multiNAND4.Margin = new Padding(3, 4, 3, 4);
            multiNAND4.Name = "multiNAND4";
            multiNAND4.Size = new Size(34, 24);
            multiNAND4.TabIndex = 3;
            multiNAND4.Text = "4";
            multiNAND4.UseVisualStyleBackColor = true;
            // 
            // multiNAND2
            // 
            multiNAND2.AutoSize = true;
            multiNAND2.Location = new Point(78, 4);
            multiNAND2.Margin = new Padding(3, 4, 3, 4);
            multiNAND2.Name = "multiNAND2";
            multiNAND2.Size = new Size(34, 24);
            multiNAND2.TabIndex = 1;
            multiNAND2.Text = "2";
            multiNAND2.UseVisualStyleBackColor = true;
            // 
            // multiNAND3
            // 
            multiNAND3.AutoSize = true;
            multiNAND3.Location = new Point(118, 4);
            multiNAND3.Margin = new Padding(3, 4, 3, 4);
            multiNAND3.Name = "multiNAND3";
            multiNAND3.Size = new Size(34, 24);
            multiNAND3.TabIndex = 2;
            multiNAND3.Text = "3";
            multiNAND3.UseVisualStyleBackColor = true;
            // 
            // multiNAND6
            // 
            multiNAND6.AutoSize = true;
            multiNAND6.Location = new Point(238, 4);
            multiNAND6.Margin = new Padding(3, 4, 3, 4);
            multiNAND6.Name = "multiNAND6";
            multiNAND6.Size = new Size(62, 24);
            multiNAND6.TabIndex = 5;
            multiNAND6.TabStop = true;
            multiNAND6.Text = "MAX";
            multiNAND6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(11, 315);
            label6.Name = "label6";
            label6.Size = new Size(105, 45);
            label6.TabIndex = 6;
            label6.Text = "Recommended Timing: 18-21 for RGH1.2";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(label8, 0, 0);
            tableLayoutPanel9.Controls.Add(fjTimings, 0, 1);
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 285F));
            tableLayoutPanel9.Size = new Size(120, 309);
            tableLayoutPanel9.TabIndex = 12;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 23);
            label8.TabIndex = 8;
            label8.Text = "RGH1.2 Timings";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // fjTimings
            // 
            fjTimings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fjTimings.Controls.Add(tableLayoutPanel1);
            fjTimings.Font = new Font("Segoe UI", 9F);
            fjTimings.Location = new Point(3, 29);
            fjTimings.Margin = new Padding(3, 4, 3, 4);
            fjTimings.Name = "fjTimings";
            fjTimings.Padding = new Padding(3, 4, 3, 4);
            fjTimings.Size = new Size(112, 277);
            fjTimings.TabIndex = 1;
            fjTimings.TabStop = false;
            fjTimings.Text = "Falcon/Jasper";
            fjTimings.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(rbFJ24, 0, 7);
            tableLayoutPanel1.Controls.Add(rbFJ23, 0, 6);
            tableLayoutPanel1.Controls.Add(rbFJ22, 0, 5);
            tableLayoutPanel1.Controls.Add(rbFJ21, 0, 4);
            tableLayoutPanel1.Controls.Add(rbFJ20, 0, 3);
            tableLayoutPanel1.Controls.Add(rbFJ19, 0, 2);
            tableLayoutPanel1.Controls.Add(rbFJ18, 0, 1);
            tableLayoutPanel1.Controls.Add(rbFJ17, 0, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(26, 29);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(58, 245);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rbFJ24
            // 
            rbFJ24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ24.AutoSize = true;
            rbFJ24.Location = new Point(6, 221);
            rbFJ24.Margin = new Padding(3, 4, 3, 4);
            rbFJ24.Name = "rbFJ24";
            rbFJ24.Size = new Size(46, 23);
            rbFJ24.TabIndex = 7;
            rbFJ24.TabStop = true;
            rbFJ24.Tag = "Falcon/Jasper";
            rbFJ24.Text = "24";
            rbFJ24.UseVisualStyleBackColor = true;
            // 
            // rbFJ23
            // 
            rbFJ23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ23.AutoSize = true;
            rbFJ23.Location = new Point(6, 190);
            rbFJ23.Margin = new Padding(3, 4, 3, 4);
            rbFJ23.Name = "rbFJ23";
            rbFJ23.Size = new Size(46, 23);
            rbFJ23.TabIndex = 6;
            rbFJ23.TabStop = true;
            rbFJ23.Tag = "Falcon/Jasper";
            rbFJ23.Text = "23";
            rbFJ23.UseVisualStyleBackColor = true;
            // 
            // rbFJ22
            // 
            rbFJ22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ22.AutoSize = true;
            rbFJ22.Location = new Point(6, 159);
            rbFJ22.Margin = new Padding(3, 4, 3, 4);
            rbFJ22.Name = "rbFJ22";
            rbFJ22.Size = new Size(46, 23);
            rbFJ22.TabIndex = 5;
            rbFJ22.TabStop = true;
            rbFJ22.Tag = "Falcon/Jasper";
            rbFJ22.Text = "22";
            rbFJ22.UseVisualStyleBackColor = true;
            // 
            // rbFJ21
            // 
            rbFJ21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ21.AutoSize = true;
            rbFJ21.Location = new Point(6, 128);
            rbFJ21.Margin = new Padding(3, 4, 3, 4);
            rbFJ21.Name = "rbFJ21";
            rbFJ21.Size = new Size(46, 23);
            rbFJ21.TabIndex = 4;
            rbFJ21.TabStop = true;
            rbFJ21.Tag = "Falcon/Jasper";
            rbFJ21.Text = "21";
            rbFJ21.UseVisualStyleBackColor = true;
            // 
            // rbFJ20
            // 
            rbFJ20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ20.AutoSize = true;
            rbFJ20.Location = new Point(6, 97);
            rbFJ20.Margin = new Padding(3, 4, 3, 4);
            rbFJ20.Name = "rbFJ20";
            rbFJ20.Size = new Size(46, 23);
            rbFJ20.TabIndex = 3;
            rbFJ20.TabStop = true;
            rbFJ20.Tag = "Falcon/Jasper";
            rbFJ20.Text = "20";
            rbFJ20.UseVisualStyleBackColor = true;
            // 
            // rbFJ19
            // 
            rbFJ19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ19.AutoSize = true;
            rbFJ19.Location = new Point(6, 66);
            rbFJ19.Margin = new Padding(3, 4, 3, 4);
            rbFJ19.Name = "rbFJ19";
            rbFJ19.Size = new Size(46, 23);
            rbFJ19.TabIndex = 2;
            rbFJ19.TabStop = true;
            rbFJ19.Tag = "Falcon/Jasper";
            rbFJ19.Text = "19";
            rbFJ19.UseVisualStyleBackColor = true;
            // 
            // rbFJ18
            // 
            rbFJ18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ18.AutoSize = true;
            rbFJ18.Location = new Point(6, 35);
            rbFJ18.Margin = new Padding(3, 4, 3, 4);
            rbFJ18.Name = "rbFJ18";
            rbFJ18.Size = new Size(46, 23);
            rbFJ18.TabIndex = 1;
            rbFJ18.TabStop = true;
            rbFJ18.Tag = "Falcon/Jasper";
            rbFJ18.Text = "18";
            rbFJ18.UseVisualStyleBackColor = true;
            // 
            // rbFJ17
            // 
            rbFJ17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFJ17.AutoSize = true;
            rbFJ17.Location = new Point(6, 4);
            rbFJ17.Margin = new Padding(3, 4, 3, 4);
            rbFJ17.Name = "rbFJ17";
            rbFJ17.Size = new Size(46, 23);
            rbFJ17.TabIndex = 0;
            rbFJ17.TabStop = true;
            rbFJ17.Tag = "Falcon/Jasper";
            rbFJ17.Text = "17";
            rbFJ17.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(96, 501);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(86, 31);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitBtn_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(3, 501);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(86, 31);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clrBtn_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(label7, 0, 0);
            tableLayoutPanel8.Controls.Add(xenonTimings, 0, 1);
            tableLayoutPanel8.Controls.Add(zephyrTimings, 0, 2);
            tableLayoutPanel8.Location = new Point(223, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel8.Size = new Size(110, 275);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 7;
            label7.Text = "EXT_CLK";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // xenonTimings
            // 
            xenonTimings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            xenonTimings.Controls.Add(tableLayoutPanel2);
            xenonTimings.Location = new Point(3, 29);
            xenonTimings.Margin = new Padding(3, 4, 3, 4);
            xenonTimings.Name = "xenonTimings";
            xenonTimings.Padding = new Padding(3, 4, 3, 4);
            xenonTimings.Size = new Size(103, 109);
            xenonTimings.TabIndex = 2;
            xenonTimings.TabStop = false;
            xenonTimings.Text = "Xenon";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(rbX_96, 0, 0);
            tableLayoutPanel2.Controls.Add(rbX_192, 0, 1);
            tableLayoutPanel2.Location = new Point(5, 23);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(95, 80);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // rbX_96
            // 
            rbX_96.AutoSize = true;
            rbX_96.Location = new Point(3, 3);
            rbX_96.Name = "rbX_96";
            rbX_96.Padding = new Padding(0, 3, 0, 0);
            rbX_96.Size = new Size(77, 27);
            rbX_96.TabIndex = 0;
            rbX_96.TabStop = true;
            rbX_96.Tag = "Xenon";
            rbX_96.Text = "96MHz";
            rbX_96.UseVisualStyleBackColor = true;
            // 
            // rbX_192
            // 
            rbX_192.AutoSize = true;
            rbX_192.Location = new Point(3, 43);
            rbX_192.Name = "rbX_192";
            rbX_192.Padding = new Padding(0, 3, 0, 0);
            rbX_192.Size = new Size(85, 27);
            rbX_192.TabIndex = 1;
            rbX_192.TabStop = true;
            rbX_192.Tag = "Xenon";
            rbX_192.Text = "192MHz";
            rbX_192.UseVisualStyleBackColor = true;
            // 
            // zephyrTimings
            // 
            zephyrTimings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            zephyrTimings.Controls.Add(tableLayoutPanel4);
            zephyrTimings.Location = new Point(3, 154);
            zephyrTimings.Margin = new Padding(3, 4, 3, 4);
            zephyrTimings.Name = "zephyrTimings";
            zephyrTimings.Padding = new Padding(3, 4, 3, 4);
            zephyrTimings.Size = new Size(103, 109);
            zephyrTimings.TabIndex = 4;
            zephyrTimings.TabStop = false;
            zephyrTimings.Text = "Zephyr";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(rbZ_96, 0, 0);
            tableLayoutPanel4.Controls.Add(rbZ_192, 0, 1);
            tableLayoutPanel4.Controls.Add(splitContainer1, 0, 2);
            tableLayoutPanel4.Location = new Point(5, 23);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(95, 80);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // rbZ_96
            // 
            rbZ_96.AutoSize = true;
            rbZ_96.Location = new Point(3, 3);
            rbZ_96.Name = "rbZ_96";
            rbZ_96.Padding = new Padding(0, 3, 0, 0);
            rbZ_96.Size = new Size(77, 27);
            rbZ_96.TabIndex = 0;
            rbZ_96.TabStop = true;
            rbZ_96.Tag = "Zephyr";
            rbZ_96.Text = "96MHz";
            rbZ_96.UseVisualStyleBackColor = true;
            // 
            // rbZ_192
            // 
            rbZ_192.AutoSize = true;
            rbZ_192.Location = new Point(3, 43);
            rbZ_192.Name = "rbZ_192";
            rbZ_192.Padding = new Padding(0, 3, 0, 0);
            rbZ_192.Size = new Size(85, 27);
            rbZ_192.TabIndex = 1;
            rbZ_192.TabStop = true;
            rbZ_192.Tag = "Zephyr";
            rbZ_192.Text = "192MHz";
            rbZ_192.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 83);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(88, 13);
            splitContainer1.SplitterDistance = 28;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(exitButton1);
            tabPage2.Controls.Add(clearButton1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(336, 536);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Slim Timings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label1);
            groupBox5.Location = new Point(147, 364);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(181, 65);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(178, 41);
            label1.TabIndex = 12;
            label1.Text = "Select None if you are not using NAND-wich";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(135, 3);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(149, 179);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label10.Location = new Point(3, 25);
            label10.Name = "label10";
            label10.Size = new Size(147, 76);
            label10.TabIndex = 16;
            label10.Text = "Note: Waitsburg/Stingray motherboards fall under \"Corona\"";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label13.Location = new Point(3, 137);
            label13.Name = "label13";
            label13.Size = new Size(147, 37);
            label13.TabIndex = 20;
            label13.Text = "Use WB if your system has WB2K RAM";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label11.Location = new Point(3, 101);
            label11.Name = "label11";
            label11.Size = new Size(147, 37);
            label11.TabIndex = 17;
            label11.Text = "This is due to a UI size constraint :)";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel7);
            groupBox3.Location = new Point(10, 421);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(315, 71);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Multi-NAND";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 6;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel7.Controls.Add(multiNAND51, 4, 0);
            tableLayoutPanel7.Controls.Add(multiNAND11, 0, 0);
            tableLayoutPanel7.Controls.Add(multiNAND41, 3, 0);
            tableLayoutPanel7.Controls.Add(multiNAND21, 1, 0);
            tableLayoutPanel7.Controls.Add(multiNAND31, 2, 0);
            tableLayoutPanel7.Controls.Add(multiNAND61, 5, 0);
            tableLayoutPanel7.Location = new Point(6, 28);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.Size = new Size(305, 40);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // multiNAND51
            // 
            multiNAND51.AutoSize = true;
            multiNAND51.Location = new Point(198, 4);
            multiNAND51.Margin = new Padding(3, 4, 3, 4);
            multiNAND51.Name = "multiNAND51";
            multiNAND51.Size = new Size(34, 24);
            multiNAND51.TabIndex = 4;
            multiNAND51.Text = "5";
            multiNAND51.UseVisualStyleBackColor = true;
            // 
            // multiNAND11
            // 
            multiNAND11.AutoSize = true;
            multiNAND11.Checked = true;
            multiNAND11.Location = new Point(3, 4);
            multiNAND11.Margin = new Padding(3, 4, 3, 4);
            multiNAND11.Name = "multiNAND11";
            multiNAND11.Size = new Size(66, 24);
            multiNAND11.TabIndex = 0;
            multiNAND11.TabStop = true;
            multiNAND11.Text = "None";
            multiNAND11.UseVisualStyleBackColor = true;
            // 
            // multiNAND41
            // 
            multiNAND41.AutoSize = true;
            multiNAND41.Location = new Point(158, 4);
            multiNAND41.Margin = new Padding(3, 4, 3, 4);
            multiNAND41.Name = "multiNAND41";
            multiNAND41.Size = new Size(34, 24);
            multiNAND41.TabIndex = 3;
            multiNAND41.Text = "4";
            multiNAND41.UseVisualStyleBackColor = true;
            // 
            // multiNAND21
            // 
            multiNAND21.AutoSize = true;
            multiNAND21.Location = new Point(78, 4);
            multiNAND21.Margin = new Padding(3, 4, 3, 4);
            multiNAND21.Name = "multiNAND21";
            multiNAND21.Size = new Size(34, 24);
            multiNAND21.TabIndex = 1;
            multiNAND21.Text = "2";
            multiNAND21.UseVisualStyleBackColor = true;
            // 
            // multiNAND31
            // 
            multiNAND31.AutoSize = true;
            multiNAND31.Location = new Point(118, 4);
            multiNAND31.Margin = new Padding(3, 4, 3, 4);
            multiNAND31.Name = "multiNAND31";
            multiNAND31.Size = new Size(34, 24);
            multiNAND31.TabIndex = 2;
            multiNAND31.Text = "3";
            multiNAND31.UseVisualStyleBackColor = true;
            // 
            // multiNAND61
            // 
            multiNAND61.AutoSize = true;
            multiNAND61.Location = new Point(238, 4);
            multiNAND61.Margin = new Padding(3, 4, 3, 4);
            multiNAND61.Name = "multiNAND61";
            multiNAND61.Size = new Size(62, 24);
            multiNAND61.TabIndex = 5;
            multiNAND61.TabStop = true;
            multiNAND61.Text = "MAX";
            multiNAND61.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel6);
            groupBox2.Location = new Point(135, 183);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(117, 127);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Board Type";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(boardTr, 0, 0);
            tableLayoutPanel6.Controls.Add(boardCor, 0, 1);
            tableLayoutPanel6.Controls.Add(boardCorWB, 0, 2);
            tableLayoutPanel6.Location = new Point(6, 19);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel6.Size = new Size(111, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // boardTr
            // 
            boardTr.AutoSize = true;
            boardTr.Checked = true;
            boardTr.Enabled = false;
            boardTr.Location = new Point(3, 4);
            boardTr.Margin = new Padding(3, 4, 3, 4);
            boardTr.Name = "boardTr";
            boardTr.Size = new Size(70, 24);
            boardTr.TabIndex = 0;
            boardTr.TabStop = true;
            boardTr.Text = "Trinity";
            boardTr.UseVisualStyleBackColor = true;
            boardTr.CheckedChanged += boardTypeSelect;
            // 
            // boardCor
            // 
            boardCor.AutoSize = true;
            boardCor.Enabled = false;
            boardCor.Location = new Point(3, 37);
            boardCor.Margin = new Padding(3, 4, 3, 4);
            boardCor.Name = "boardCor";
            boardCor.Size = new Size(78, 24);
            boardCor.TabIndex = 1;
            boardCor.Text = "Corona";
            boardCor.UseVisualStyleBackColor = true;
            boardCor.CheckedChanged += boardTypeSelect;
            // 
            // boardCorWB
            // 
            boardCorWB.AutoSize = true;
            boardCorWB.Enabled = false;
            boardCorWB.Font = new Font("Segoe UI", 9F);
            boardCorWB.Location = new Point(3, 70);
            boardCorWB.Margin = new Padding(3, 4, 3, 4);
            boardCorWB.Name = "boardCorWB";
            boardCorWB.Size = new Size(105, 24);
            boardCorWB.TabIndex = 2;
            boardCorWB.Text = "Corona WB";
            boardCorWB.UseVisualStyleBackColor = true;
            boardCorWB.CheckedChanged += boardTypeSelect;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 4);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 14;
            label9.Text = "RGH1.2 Timings";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Location = new Point(2, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(126, 280);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trinity/Corona";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel5.Controls.Add(slim100, 1, 0);
            tableLayoutPanel5.Controls.Add(slim105, 1, 1);
            tableLayoutPanel5.Controls.Add(slim110, 1, 2);
            tableLayoutPanel5.Controls.Add(slim115, 1, 3);
            tableLayoutPanel5.Controls.Add(slim120, 1, 4);
            tableLayoutPanel5.Controls.Add(slim125, 1, 5);
            tableLayoutPanel5.Controls.Add(slim130, 1, 6);
            tableLayoutPanel5.Controls.Add(slim135, 1, 7);
            tableLayoutPanel5.Controls.Add(slim60, 0, 0);
            tableLayoutPanel5.Controls.Add(slim65, 0, 1);
            tableLayoutPanel5.Controls.Add(slim70, 0, 2);
            tableLayoutPanel5.Controls.Add(slim75, 0, 3);
            tableLayoutPanel5.Controls.Add(slim80, 0, 4);
            tableLayoutPanel5.Controls.Add(slim85, 0, 5);
            tableLayoutPanel5.Controls.Add(slim90, 0, 6);
            tableLayoutPanel5.Controls.Add(slim95, 0, 7);
            tableLayoutPanel5.Location = new Point(7, 27);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.Size = new Size(118, 245);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // slim100
            // 
            slim100.AutoSize = true;
            slim100.Location = new Point(60, 4);
            slim100.Margin = new Padding(3, 4, 3, 4);
            slim100.Name = "slim100";
            slim100.Size = new Size(54, 23);
            slim100.TabIndex = 8;
            slim100.TabStop = true;
            slim100.Tag = "Slim";
            slim100.Text = "100";
            slim100.UseVisualStyleBackColor = true;
            // 
            // slim105
            // 
            slim105.AutoSize = true;
            slim105.Location = new Point(60, 35);
            slim105.Margin = new Padding(3, 4, 3, 4);
            slim105.Name = "slim105";
            slim105.Size = new Size(54, 23);
            slim105.TabIndex = 9;
            slim105.TabStop = true;
            slim105.Tag = "Slim";
            slim105.Text = "105";
            slim105.UseVisualStyleBackColor = true;
            // 
            // slim110
            // 
            slim110.AutoSize = true;
            slim110.Location = new Point(60, 66);
            slim110.Margin = new Padding(3, 4, 3, 4);
            slim110.Name = "slim110";
            slim110.Size = new Size(54, 23);
            slim110.TabIndex = 10;
            slim110.TabStop = true;
            slim110.Tag = "Slim";
            slim110.Text = "110";
            slim110.UseVisualStyleBackColor = true;
            // 
            // slim115
            // 
            slim115.AutoSize = true;
            slim115.Location = new Point(60, 97);
            slim115.Margin = new Padding(3, 4, 3, 4);
            slim115.Name = "slim115";
            slim115.Size = new Size(54, 23);
            slim115.TabIndex = 11;
            slim115.TabStop = true;
            slim115.Tag = "Slim";
            slim115.Text = "115";
            slim115.UseVisualStyleBackColor = true;
            // 
            // slim120
            // 
            slim120.AutoSize = true;
            slim120.Location = new Point(60, 128);
            slim120.Margin = new Padding(3, 4, 3, 4);
            slim120.Name = "slim120";
            slim120.Size = new Size(54, 23);
            slim120.TabIndex = 12;
            slim120.TabStop = true;
            slim120.Tag = "Slim";
            slim120.Text = "120";
            slim120.UseVisualStyleBackColor = true;
            // 
            // slim125
            // 
            slim125.AutoSize = true;
            slim125.Location = new Point(60, 159);
            slim125.Margin = new Padding(3, 4, 3, 4);
            slim125.Name = "slim125";
            slim125.Size = new Size(54, 23);
            slim125.TabIndex = 13;
            slim125.TabStop = true;
            slim125.Tag = "Slim";
            slim125.Text = "125";
            slim125.UseVisualStyleBackColor = true;
            // 
            // slim130
            // 
            slim130.AutoSize = true;
            slim130.Location = new Point(60, 190);
            slim130.Margin = new Padding(3, 4, 3, 4);
            slim130.Name = "slim130";
            slim130.Size = new Size(54, 23);
            slim130.TabIndex = 14;
            slim130.TabStop = true;
            slim130.Tag = "Slim";
            slim130.Text = "130";
            slim130.UseVisualStyleBackColor = true;
            // 
            // slim135
            // 
            slim135.AutoSize = true;
            slim135.Location = new Point(60, 221);
            slim135.Margin = new Padding(3, 4, 3, 4);
            slim135.Name = "slim135";
            slim135.Size = new Size(54, 23);
            slim135.TabIndex = 15;
            slim135.TabStop = true;
            slim135.Tag = "Slim";
            slim135.Text = "135";
            slim135.UseVisualStyleBackColor = true;
            // 
            // slim60
            // 
            slim60.AutoSize = true;
            slim60.Location = new Point(3, 4);
            slim60.Margin = new Padding(3, 4, 3, 4);
            slim60.Name = "slim60";
            slim60.Size = new Size(46, 23);
            slim60.TabIndex = 16;
            slim60.TabStop = true;
            slim60.Tag = "Slim";
            slim60.Text = "60";
            slim60.UseVisualStyleBackColor = true;
            // 
            // slim65
            // 
            slim65.AutoSize = true;
            slim65.Location = new Point(3, 35);
            slim65.Margin = new Padding(3, 4, 3, 4);
            slim65.Name = "slim65";
            slim65.Size = new Size(46, 23);
            slim65.TabIndex = 17;
            slim65.TabStop = true;
            slim65.Tag = "Slim";
            slim65.Text = "65";
            slim65.UseVisualStyleBackColor = true;
            // 
            // slim70
            // 
            slim70.AutoSize = true;
            slim70.Location = new Point(3, 66);
            slim70.Margin = new Padding(3, 4, 3, 4);
            slim70.Name = "slim70";
            slim70.Size = new Size(46, 23);
            slim70.TabIndex = 18;
            slim70.TabStop = true;
            slim70.Tag = "Slim";
            slim70.Text = "70";
            slim70.UseVisualStyleBackColor = true;
            // 
            // slim75
            // 
            slim75.AutoSize = true;
            slim75.Location = new Point(3, 97);
            slim75.Margin = new Padding(3, 4, 3, 4);
            slim75.Name = "slim75";
            slim75.Size = new Size(46, 23);
            slim75.TabIndex = 19;
            slim75.TabStop = true;
            slim75.Tag = "Slim";
            slim75.Text = "75";
            slim75.UseVisualStyleBackColor = true;
            // 
            // slim80
            // 
            slim80.AutoSize = true;
            slim80.Location = new Point(3, 128);
            slim80.Margin = new Padding(3, 4, 3, 4);
            slim80.Name = "slim80";
            slim80.Size = new Size(46, 23);
            slim80.TabIndex = 20;
            slim80.TabStop = true;
            slim80.Tag = "Slim";
            slim80.Text = "80";
            slim80.UseVisualStyleBackColor = true;
            // 
            // slim85
            // 
            slim85.AutoSize = true;
            slim85.Location = new Point(3, 159);
            slim85.Margin = new Padding(3, 4, 3, 4);
            slim85.Name = "slim85";
            slim85.Size = new Size(46, 23);
            slim85.TabIndex = 21;
            slim85.TabStop = true;
            slim85.Tag = "Slim";
            slim85.Text = "85";
            slim85.UseVisualStyleBackColor = true;
            // 
            // slim90
            // 
            slim90.AutoSize = true;
            slim90.Location = new Point(3, 190);
            slim90.Margin = new Padding(3, 4, 3, 4);
            slim90.Name = "slim90";
            slim90.Size = new Size(46, 23);
            slim90.TabIndex = 22;
            slim90.TabStop = true;
            slim90.Tag = "Slim";
            slim90.Text = "90";
            slim90.UseVisualStyleBackColor = true;
            // 
            // slim95
            // 
            slim95.AutoSize = true;
            slim95.Location = new Point(3, 221);
            slim95.Margin = new Padding(3, 4, 3, 4);
            slim95.Name = "slim95";
            slim95.Size = new Size(46, 23);
            slim95.TabIndex = 23;
            slim95.TabStop = true;
            slim95.Tag = "Slim";
            slim95.Text = "95";
            slim95.UseVisualStyleBackColor = true;
            // 
            // exitButton1
            // 
            exitButton1.Location = new Point(96, 501);
            exitButton1.Margin = new Padding(3, 4, 3, 4);
            exitButton1.Name = "exitButton1";
            exitButton1.Size = new Size(86, 31);
            exitButton1.TabIndex = 12;
            exitButton1.Text = "Exit";
            exitButton1.UseVisualStyleBackColor = true;
            exitButton1.Click += exitBtn_Click;
            // 
            // clearButton1
            // 
            clearButton1.Location = new Point(3, 501);
            clearButton1.Margin = new Padding(3, 4, 3, 4);
            clearButton1.Name = "clearButton1";
            clearButton1.Size = new Size(86, 31);
            clearButton1.TabIndex = 11;
            clearButton1.Text = "Clear";
            clearButton1.UseVisualStyleBackColor = true;
            clearButton1.Click += clrBtn_Click;
            // 
            // programBtn
            // 
            programBtn.Location = new Point(473, 27);
            programBtn.Margin = new Padding(3, 4, 3, 4);
            programBtn.Name = "programBtn";
            programBtn.Size = new Size(80, 93);
            programBtn.TabIndex = 8;
            programBtn.Text = "Program Timing File";
            programBtn.UseVisualStyleBackColor = true;
            programBtn.Click += programBtn_pressed;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(17, 51);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 85);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(34, 27);
            label14.Margin = new Padding(0);
            label14.Name = "label14";
            label14.Size = new Size(101, 20);
            label14.TabIndex = 10;
            label14.Text = "Programmer:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { mainToolStrip, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(918, 27);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // mainToolStrip
            // 
            mainToolStrip.AccessibleName = "";
            mainToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mainToolStrip.DropDownItems.AddRange(new ToolStripItem[] { openFileBtn, exitBtn });
            mainToolStrip.ImageTransparentColor = Color.Magenta;
            mainToolStrip.Name = "mainToolStrip";
            mainToolStrip.Size = new Size(89, 24);
            mainToolStrip.Text = "Advanced";
            // 
            // openFileBtn
            // 
            openFileBtn.Name = "openFileBtn";
            openFileBtn.Size = new Size(224, 26);
            openFileBtn.Text = "Open File";
            openFileBtn.Click += openFileBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(224, 26);
            exitBtn.Text = "Exit";
            exitBtn.Click += exitBtn_Click_1;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { changelogButton });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(101, 24);
            toolStripDropDownButton1.Text = "Information";
            // 
            // changelogButton
            // 
            changelogButton.Name = "changelogButton";
            changelogButton.Size = new Size(224, 26);
            changelogButton.Text = "Changelog";
            changelogButton.Click += changelog_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 601);
            Controls.Add(toolStrip1);
            Controls.Add(label14);
            Controls.Add(pictureBox1);
            Controls.Add(programBtn);
            Controls.Add(optionsPanel);
            Controls.Add(progressPanel);
            Controls.Add(debugConsole);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "mainForm";
            Text = "FreeRunner Flashing Utility";
            Load += main_Load;
            progressPanel.ResumeLayout(false);
            progressPanel.PerformLayout();
            optionsPanel.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            nandSelection.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            fjTimings.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            xenonTimings.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            zephyrTimings.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel progressPanel;
        private Label labelPercent;
        private ProgressBar progressBar1;
        private TabControl optionsPanel;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton rbFJ17;
        private RadioButton rbFJ18;
        private RadioButton rbFJ19;
        private RadioButton rbFJ20;
        private RadioButton rbFJ21;
        private RadioButton rbFJ22;
        private RadioButton rbFJ23;
        private RadioButton rbFJ24;
        private GroupBox fjTimings;
        private GroupBox xenonTimings;
        private TableLayoutPanel tableLayoutPanel2;
        private Button programBtn;
        private GroupBox nandSelection;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton multiNAND1;
        private RadioButton multiNAND2;
        private RadioButton multiNAND3;
        private RadioButton multiNAND4;
        private RadioButton multiNAND5;
        private GroupBox zephyrTimings;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button clearButton;
        private Button exitButton;
        private Button exitButton1;
        private Button clearButton1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton slim100;
        private RadioButton slim105;
        private RadioButton slim110;
        private RadioButton slim115;
        private RadioButton slim120;
        private RadioButton slim125;
        private RadioButton slim130;
        private RadioButton slim135;
        private RadioButton slim60;
        private RadioButton slim65;
        private RadioButton slim70;
        private RadioButton slim75;
        private RadioButton slim80;
        private RadioButton slim85;
        private RadioButton slim90;
        private RadioButton slim95;
        private Label label9;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private RadioButton boardTr;
        private RadioButton boardCor;
        private RadioButton boardCorWB;
        private Label label10;
        private Label label11;
        private Label label13;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private Label label14;
        private RadioButton rbX_96;
        private RadioButton rbX_192;
        private RadioButton rbZ_96;
        private RadioButton rbZ_192;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private RadioButton multiNAND6;
        private Label label1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel7;
        private RadioButton multiNAND51;
        private RadioButton multiNAND11;
        private RadioButton multiNAND41;
        private RadioButton multiNAND21;
        private RadioButton multiNAND31;
        private RadioButton multiNAND61;
        private RichTextBox debugConsole;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton mainToolStrip;
        private ToolStripMenuItem openFileBtn;
        private ToolStripMenuItem exitBtn;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem changelogButton;
    }
}
