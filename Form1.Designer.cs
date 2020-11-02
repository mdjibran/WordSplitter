namespace WordSplitter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._txtSourceFile = new System.Windows.Forms.TextBox();
            this._chkBoxNamesList = new System.Windows.Forms.CheckedListBox();
            this._txtPrefix = new System.Windows.Forms.TextBox();
            this._txtSuffix = new System.Windows.Forms.TextBox();
            this._lblFileNames = new System.Windows.Forms.Label();
            this._lblPrefix = new System.Windows.Forms.Label();
            this._lblSuffix = new System.Windows.Forms.Label();
            this._btnStart = new System.Windows.Forms.Button();
            this._txtDestination = new System.Windows.Forms.TextBox();
            this._btnDestination = new System.Windows.Forms.Button();
            this._lblDestination = new System.Windows.Forms.Label();
            this._btnAddFileName = new System.Windows.Forms.Button();
            this._lblAddFileName = new System.Windows.Forms.Label();
            this._txtAddFileName = new System.Windows.Forms.TextBox();
            this._btnRemoveName = new System.Windows.Forms.Button();
            this._lblProcessing = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._chkOpenFile = new System.Windows.Forms.CheckBox();
            this._chkKeepPageNums = new System.Windows.Forms.CheckBox();
            this._chkSavePDF = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File *";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txtSourceFile
            // 
            this._txtSourceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSourceFile.Location = new System.Drawing.Point(8, 58);
            this._txtSourceFile.Name = "_txtSourceFile";
            this._txtSourceFile.ReadOnly = true;
            this._txtSourceFile.Size = new System.Drawing.Size(632, 23);
            this._txtSourceFile.TabIndex = 2;
            // 
            // _chkBoxNamesList
            // 
            this._chkBoxNamesList.CheckOnClick = true;
            this._chkBoxNamesList.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkBoxNamesList.FormattingEnabled = true;
            this._chkBoxNamesList.Location = new System.Drawing.Point(11, 197);
            this._chkBoxNamesList.Name = "_chkBoxNamesList";
            this._chkBoxNamesList.Size = new System.Drawing.Size(347, 289);
            this._chkBoxNamesList.TabIndex = 3;
            this._chkBoxNamesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._chkBoxNamesList_ItemCheck);
            // 
            // _txtPrefix
            // 
            this._txtPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrefix.Location = new System.Drawing.Point(370, 198);
            this._txtPrefix.Name = "_txtPrefix";
            this._txtPrefix.Size = new System.Drawing.Size(347, 23);
            this._txtPrefix.TabIndex = 4;
            // 
            // _txtSuffix
            // 
            this._txtSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSuffix.Location = new System.Drawing.Point(370, 261);
            this._txtSuffix.Name = "_txtSuffix";
            this._txtSuffix.Size = new System.Drawing.Size(347, 23);
            this._txtSuffix.TabIndex = 5;
            // 
            // _lblFileNames
            // 
            this._lblFileNames.AutoSize = true;
            this._lblFileNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFileNames.Location = new System.Drawing.Point(6, 176);
            this._lblFileNames.Name = "_lblFileNames";
            this._lblFileNames.Size = new System.Drawing.Size(171, 18);
            this._lblFileNames.TabIndex = 6;
            this._lblFileNames.Text = "Destination File Names *";
            // 
            // _lblPrefix
            // 
            this._lblPrefix.AutoSize = true;
            this._lblPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPrefix.Location = new System.Drawing.Point(366, 177);
            this._lblPrefix.Name = "_lblPrefix";
            this._lblPrefix.Size = new System.Drawing.Size(112, 18);
            this._lblPrefix.TabIndex = 7;
            this._lblPrefix.Text = "FileName Prefix";
            // 
            // _lblSuffix
            // 
            this._lblSuffix.AutoSize = true;
            this._lblSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSuffix.Location = new System.Drawing.Point(367, 240);
            this._lblSuffix.Name = "_lblSuffix";
            this._lblSuffix.Size = new System.Drawing.Size(111, 18);
            this._lblSuffix.TabIndex = 8;
            this._lblSuffix.Text = "FileName Suffix";
            // 
            // _btnStart
            // 
            this._btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnStart.Location = new System.Drawing.Point(592, 448);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(125, 43);
            this._btnStart.TabIndex = 9;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _txtDestination
            // 
            this._txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDestination.Location = new System.Drawing.Point(8, 122);
            this._txtDestination.Name = "_txtDestination";
            this._txtDestination.ReadOnly = true;
            this._txtDestination.Size = new System.Drawing.Size(632, 23);
            this._txtDestination.TabIndex = 12;
            // 
            // _btnDestination
            // 
            this._btnDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDestination.Location = new System.Drawing.Point(644, 120);
            this._btnDestination.Name = "_btnDestination";
            this._btnDestination.Size = new System.Drawing.Size(75, 27);
            this._btnDestination.TabIndex = 11;
            this._btnDestination.Text = "Select";
            this._btnDestination.UseVisualStyleBackColor = true;
            this._btnDestination.Click += new System.EventHandler(this._btnDestination_Click);
            // 
            // _lblDestination
            // 
            this._lblDestination.AutoSize = true;
            this._lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDestination.Location = new System.Drawing.Point(5, 103);
            this._lblDestination.Name = "_lblDestination";
            this._lblDestination.Size = new System.Drawing.Size(138, 18);
            this._lblDestination.TabIndex = 10;
            this._lblDestination.Text = "Destination Folder *";
            // 
            // _btnAddFileName
            // 
            this._btnAddFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddFileName.Location = new System.Drawing.Point(444, 348);
            this._btnAddFileName.Name = "_btnAddFileName";
            this._btnAddFileName.Size = new System.Drawing.Size(75, 27);
            this._btnAddFileName.TabIndex = 13;
            this._btnAddFileName.Text = "Add Name";
            this._btnAddFileName.UseVisualStyleBackColor = true;
            this._btnAddFileName.Click += new System.EventHandler(this._txtAddFileName_Click);
            // 
            // _lblAddFileName
            // 
            this._lblAddFileName.AutoSize = true;
            this._lblAddFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAddFileName.Location = new System.Drawing.Point(369, 300);
            this._lblAddFileName.Name = "_lblAddFileName";
            this._lblAddFileName.Size = new System.Drawing.Size(134, 18);
            this._lblAddFileName.TabIndex = 14;
            this._lblAddFileName.Text = "Add New FileName";
            // 
            // _txtAddFileName
            // 
            this._txtAddFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAddFileName.Location = new System.Drawing.Point(370, 319);
            this._txtAddFileName.Name = "_txtAddFileName";
            this._txtAddFileName.Size = new System.Drawing.Size(347, 23);
            this._txtAddFileName.TabIndex = 15;
            this._txtAddFileName.TextChanged += new System.EventHandler(this._txtAddFileName_TextChanged);
            // 
            // _btnRemoveName
            // 
            this._btnRemoveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRemoveName.Location = new System.Drawing.Point(530, 348);
            this._btnRemoveName.Name = "_btnRemoveName";
            this._btnRemoveName.Size = new System.Drawing.Size(187, 27);
            this._btnRemoveName.TabIndex = 16;
            this._btnRemoveName.Text = "Remove Checked Items";
            this._btnRemoveName.UseVisualStyleBackColor = true;
            this._btnRemoveName.Click += new System.EventHandler(this._txtRemoveName_Click);
            // 
            // _lblProcessing
            // 
            this._lblProcessing.AutoSize = true;
            this._lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblProcessing.Location = new System.Drawing.Point(552, 451);
            this._lblProcessing.Name = "_lblProcessing";
            this._lblProcessing.Size = new System.Drawing.Size(173, 31);
            this._lblProcessing.TabIndex = 17;
            this._lblProcessing.Text = "Processing...";
            this._lblProcessing.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.summaryToolStripMenuItem.Text = "Logs";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // _chkOpenFile
            // 
            this._chkOpenFile.AutoSize = true;
            this._chkOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkOpenFile.Location = new System.Drawing.Point(369, 381);
            this._chkOpenFile.Name = "_chkOpenFile";
            this._chkOpenFile.Size = new System.Drawing.Size(161, 22);
            this._chkOpenFile.TabIndex = 19;
            this._chkOpenFile.Text = "Open file when done";
            this._chkOpenFile.UseVisualStyleBackColor = true;
            // 
            // _chkKeepPageNums
            // 
            this._chkKeepPageNums.AutoSize = true;
            this._chkKeepPageNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkKeepPageNums.Location = new System.Drawing.Point(369, 405);
            this._chkKeepPageNums.Name = "_chkKeepPageNums";
            this._chkKeepPageNums.Size = new System.Drawing.Size(247, 22);
            this._chkKeepPageNums.TabIndex = 20;
            this._chkKeepPageNums.Text = "Maintain Page Number Sequence";
            this._chkKeepPageNums.UseVisualStyleBackColor = true;
            // 
            // _chkSavePDF
            // 
            this._chkSavePDF.AutoSize = true;
            this._chkSavePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkSavePDF.Location = new System.Drawing.Point(369, 429);
            this._chkSavePDF.Name = "_chkSavePDF";
            this._chkSavePDF.Size = new System.Drawing.Size(115, 22);
            this._chkSavePDF.TabIndex = 21;
            this._chkSavePDF.Text = "Save As PDF";
            this._chkSavePDF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(727, 497);
            this.Controls.Add(this._chkSavePDF);
            this.Controls.Add(this._chkKeepPageNums);
            this.Controls.Add(this._chkOpenFile);
            this.Controls.Add(this._btnRemoveName);
            this.Controls.Add(this._txtAddFileName);
            this.Controls.Add(this._lblAddFileName);
            this.Controls.Add(this._btnAddFileName);
            this.Controls.Add(this._txtDestination);
            this.Controls.Add(this._btnDestination);
            this.Controls.Add(this._lblDestination);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._lblSuffix);
            this.Controls.Add(this._lblPrefix);
            this.Controls.Add(this._lblFileNames);
            this.Controls.Add(this._txtSuffix);
            this.Controls.Add(this._txtPrefix);
            this.Controls.Add(this._chkBoxNamesList);
            this.Controls.Add(this._txtSourceFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblProcessing);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Splitter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _txtSourceFile;
        private System.Windows.Forms.CheckedListBox _chkBoxNamesList;
        private System.Windows.Forms.TextBox _txtPrefix;
        private System.Windows.Forms.TextBox _txtSuffix;
        private System.Windows.Forms.Label _lblFileNames;
        private System.Windows.Forms.Label _lblPrefix;
        private System.Windows.Forms.Label _lblSuffix;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.TextBox _txtDestination;
        private System.Windows.Forms.Button _btnDestination;
        private System.Windows.Forms.Label _lblDestination;
        private System.Windows.Forms.Button _btnAddFileName;
        private System.Windows.Forms.Label _lblAddFileName;
        private System.Windows.Forms.TextBox _txtAddFileName;
        private System.Windows.Forms.Button _btnRemoveName;
        private System.Windows.Forms.Label _lblProcessing;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.CheckBox _chkOpenFile;
        private System.Windows.Forms.CheckBox _chkKeepPageNums;
        private System.Windows.Forms.CheckBox _chkSavePDF;
    }
}

