namespace HistogramGenerator
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.defaultHistogramButton = new System.Windows.Forms.Button();
            this.invalidAlertLabel = new System.Windows.Forms.Label();
            this.numAlertLabel = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.histogramPB = new System.Windows.Forms.PictureBox();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveTextFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveBitmapDialog = new System.Windows.Forms.SaveFileDialog();
            this.numOfBarsTrackBar = new System.Windows.Forms.TrackBar();
            this.numOfBarsTextBox = new System.Windows.Forms.TextBox();
            this.numOfVertTicTrackBar = new System.Windows.Forms.TrackBar();
            this.numOfVertTicTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HTbox = new System.Windows.Forms.ListBox();
            this.VTbox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfBarsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfVertTicTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenuStrip.BackgroundImage")));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenuStrip.Size = new System.Drawing.Size(984, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMainMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMainMenuItem,
            this.exitToolStripMainMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openToolStripMainMenuItem
            // 
            this.openToolStripMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMainMenuItem.Image")));
            this.openToolStripMainMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMainMenuItem.Name = "openToolStripMainMenuItem";
            this.openToolStripMainMenuItem.Size = new System.Drawing.Size(149, 22);
            this.openToolStripMainMenuItem.Text = "&Open Text File";
            this.openToolStripMainMenuItem.Click += new System.EventHandler(this.openToolStripMainMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(146, 6);
            // 
            // saveToolStripMainMenuItem
            // 
            this.saveToolStripMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToTextFileToolStripMenuItem,
            this.histogramImageToolStripMenuItem});
            this.saveToolStripMainMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMainMenuItem.Image")));
            this.saveToolStripMainMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMainMenuItem.Name = "saveToolStripMainMenuItem";
            this.saveToolStripMainMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveToolStripMainMenuItem.Text = "&Save";
            // 
            // dataToTextFileToolStripMenuItem
            // 
            this.dataToTextFileToolStripMenuItem.Enabled = false;
            this.dataToTextFileToolStripMenuItem.Name = "dataToTextFileToolStripMenuItem";
            this.dataToTextFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dataToTextFileToolStripMenuItem.Text = "Data To Text File";
            this.dataToTextFileToolStripMenuItem.Click += new System.EventHandler(this.dataToTextFileToolStripMenuItem_Click);
            // 
            // histogramImageToolStripMenuItem
            // 
            this.histogramImageToolStripMenuItem.Enabled = false;
            this.histogramImageToolStripMenuItem.Name = "histogramImageToolStripMenuItem";
            this.histogramImageToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.histogramImageToolStripMenuItem.Text = "Histogram Image";
            this.histogramImageToolStripMenuItem.Click += new System.EventHandler(this.histogramImageToolStripMenuItem_Click);
            // 
            // exitToolStripMainMenuItem
            // 
            this.exitToolStripMainMenuItem.Name = "exitToolStripMainMenuItem";
            this.exitToolStripMainMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMainMenuItem.Text = "E&xit";
            this.exitToolStripMainMenuItem.Click += new System.EventHandler(this.exitToolStripMainMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator7,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator8,
            this.selectAllToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem1.Text = "&Undo";
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.redoToolStripMenuItem1.Text = "&Redo";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
            this.cutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem1.Text = "Cu&t";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem1.Image")));
            this.pasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem1.Text = "Select &All";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // customizeToolStripMenuItem1
            // 
            this.customizeToolStripMenuItem1.Name = "customizeToolStripMenuItem1";
            this.customizeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem1.Text = "&Customize";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem1.Text = "&Options";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Controls.Add(this.defaultHistogramButton);
            this.mainPanel.Controls.Add(this.invalidAlertLabel);
            this.mainPanel.Controls.Add(this.numAlertLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(984, 49);
            this.mainPanel.TabIndex = 1;
            // 
            // defaultHistogramButton
            // 
            this.defaultHistogramButton.Enabled = false;
            this.defaultHistogramButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultHistogramButton.Location = new System.Drawing.Point(13, 9);
            this.defaultHistogramButton.Name = "defaultHistogramButton";
            this.defaultHistogramButton.Size = new System.Drawing.Size(176, 26);
            this.defaultHistogramButton.TabIndex = 2;
            this.defaultHistogramButton.Text = "Create Default Histogram";
            this.defaultHistogramButton.UseVisualStyleBackColor = true;
            this.defaultHistogramButton.Click += new System.EventHandler(this.defaultHistogramButton_Click);
            // 
            // invalidAlertLabel
            // 
            this.invalidAlertLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidAlertLabel.AutoSize = true;
            this.invalidAlertLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidAlertLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAlertLabel.ForeColor = System.Drawing.Color.Maroon;
            this.invalidAlertLabel.Location = new System.Drawing.Point(195, 12);
            this.invalidAlertLabel.Name = "invalidAlertLabel";
            this.invalidAlertLabel.Size = new System.Drawing.Size(155, 18);
            this.invalidAlertLabel.TabIndex = 9;
            this.invalidAlertLabel.Text = "Invalid data entered";
            this.invalidAlertLabel.Visible = false;
            // 
            // numAlertLabel
            // 
            this.numAlertLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numAlertLabel.AutoSize = true;
            this.numAlertLabel.BackColor = System.Drawing.Color.Transparent;
            this.numAlertLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAlertLabel.ForeColor = System.Drawing.Color.Maroon;
            this.numAlertLabel.Location = new System.Drawing.Point(195, 12);
            this.numAlertLabel.Name = "numAlertLabel";
            this.numAlertLabel.Size = new System.Drawing.Size(269, 18);
            this.numAlertLabel.TabIndex = 8;
            this.numAlertLabel.Text = "At least 10 values must be entered";
            this.numAlertLabel.Visible = false;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.ForeColor = System.Drawing.Color.Black;
            this.dataTextBox.Location = new System.Drawing.Point(113, 541);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(758, 102);
            this.dataTextBox.TabIndex = 2;
            this.dataTextBox.TabStop = false;
            this.dataTextBox.Text = "\r\n\r\n\r\nEnter Data Here";
            this.dataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataTextBox.TextChanged += new System.EventHandler(this.dataTextBox_TextChanged);
            this.dataTextBox.Enter += new System.EventHandler(this.dataTextBox_Enter);
            // 
            // histogramPB
            // 
            this.histogramPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histogramPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("histogramPB.BackgroundImage")));
            this.histogramPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.histogramPB.Location = new System.Drawing.Point(113, 93);
            this.histogramPB.Name = "histogramPB";
            this.histogramPB.Size = new System.Drawing.Size(758, 385);
            this.histogramPB.TabIndex = 3;
            this.histogramPB.TabStop = false;
            // 
            // openTextFileDialog
            // 
            this.openTextFileDialog.Filter = "Text Documents (*.txt)|*.txt";
            // 
            // saveTextFileDialog
            // 
            this.saveTextFileDialog.FileName = "*.txt";
            this.saveTextFileDialog.Filter = "Text Documents (*.txt)|*.txt";
            // 
            // saveBitmapDialog
            // 
            this.saveBitmapDialog.Filter = "Bitmap (*.bmp)|*.bmp";
            // 
            // numOfBarsTrackBar
            // 
            this.numOfBarsTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numOfBarsTrackBar.Enabled = false;
            this.numOfBarsTrackBar.Location = new System.Drawing.Point(113, 484);
            this.numOfBarsTrackBar.Maximum = 20;
            this.numOfBarsTrackBar.Minimum = 4;
            this.numOfBarsTrackBar.Name = "numOfBarsTrackBar";
            this.numOfBarsTrackBar.Size = new System.Drawing.Size(727, 45);
            this.numOfBarsTrackBar.TabIndex = 0;
            this.numOfBarsTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.numOfBarsTrackBar.Value = 4;
            this.numOfBarsTrackBar.Scroll += new System.EventHandler(this.numOfBarsTrackBar_Scroll);
            // 
            // numOfBarsTextBox
            // 
            this.numOfBarsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numOfBarsTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numOfBarsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numOfBarsTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfBarsTextBox.Location = new System.Drawing.Point(846, 497);
            this.numOfBarsTextBox.Name = "numOfBarsTextBox";
            this.numOfBarsTextBox.ReadOnly = true;
            this.numOfBarsTextBox.Size = new System.Drawing.Size(25, 14);
            this.numOfBarsTextBox.TabIndex = 4;
            this.numOfBarsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numOfVertTicTrackBar
            // 
            this.numOfVertTicTrackBar.Enabled = false;
            this.numOfVertTicTrackBar.Location = new System.Drawing.Point(62, 113);
            this.numOfVertTicTrackBar.Maximum = 20;
            this.numOfVertTicTrackBar.Minimum = 3;
            this.numOfVertTicTrackBar.Name = "numOfVertTicTrackBar";
            this.numOfVertTicTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.numOfVertTicTrackBar.Size = new System.Drawing.Size(45, 365);
            this.numOfVertTicTrackBar.TabIndex = 5;
            this.numOfVertTicTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.numOfVertTicTrackBar.Value = 3;
            this.numOfVertTicTrackBar.Scroll += new System.EventHandler(this.numOfVertTicTrackBar_Scroll);
            // 
            // numOfVertTicTextBox
            // 
            this.numOfVertTicTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numOfVertTicTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numOfVertTicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numOfVertTicTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfVertTicTextBox.Location = new System.Drawing.Point(72, 93);
            this.numOfVertTicTextBox.Name = "numOfVertTicTextBox";
            this.numOfVertTicTextBox.ReadOnly = true;
            this.numOfVertTicTextBox.Size = new System.Drawing.Size(25, 14);
            this.numOfVertTicTextBox.TabIndex = 6;
            this.numOfVertTicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "H Tick Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "V Tick Decimal";
            // 
            // HTbox
            // 
            this.HTbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.HTbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HTbox.FormattingEnabled = true;
            this.HTbox.Items.AddRange(new object[] {
            "0",
            "0.0",
            "0.00",
            "0.000"});
            this.HTbox.Location = new System.Drawing.Point(881, 154);
            this.HTbox.Name = "HTbox";
            this.HTbox.Size = new System.Drawing.Size(35, 56);
            this.HTbox.TabIndex = 11;
            // 
            // VTbox
            // 
            this.VTbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VTbox.FormattingEnabled = true;
            this.VTbox.Items.AddRange(new object[] {
            "0",
            "0.0",
            "0.00"});
            this.VTbox.Location = new System.Drawing.Point(881, 230);
            this.VTbox.Name = "VTbox";
            this.VTbox.Size = new System.Drawing.Size(35, 43);
            this.VTbox.TabIndex = 12;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.VTbox);
            this.Controls.Add(this.HTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfVertTicTextBox);
            this.Controls.Add(this.numOfVertTicTrackBar);
            this.Controls.Add(this.numOfBarsTextBox);
            this.Controls.Add(this.numOfBarsTrackBar);
            this.Controls.Add(this.histogramPB);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "GUI";
            this.Text = "Histogram Generator";
            this.TextChanged += new System.EventHandler(this.dataTextBox_TextChanged);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfBarsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfVertTicTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMainMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button defaultHistogramButton;
        private System.Windows.Forms.ToolStripMenuItem dataToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramImageToolStripMenuItem;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.PictureBox histogramPB;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.SaveFileDialog saveTextFileDialog;
        private System.Windows.Forms.Label numAlertLabel;
        private System.Windows.Forms.Label invalidAlertLabel;
        private System.Windows.Forms.SaveFileDialog saveBitmapDialog;
        private System.Windows.Forms.TrackBar numOfBarsTrackBar;
        private System.Windows.Forms.TextBox numOfBarsTextBox;
        private System.Windows.Forms.TrackBar numOfVertTicTrackBar;
        private System.Windows.Forms.TextBox numOfVertTicTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox HTbox;
        private System.Windows.Forms.ListBox VTbox;
    }
}

