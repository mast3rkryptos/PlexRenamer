namespace PlexRenamer
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
            this.labelInputFolder = new System.Windows.Forms.Label();
            this.textBoxInputFolder = new System.Windows.Forms.TextBox();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.labelOutputFolder = new System.Windows.Forms.Label();
            this.buttonInputFolder = new System.Windows.Forms.Button();
            this.buttonOutputFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonScan = new System.Windows.Forms.Button();
            this.checkBoxAutoTitleLookup = new System.Windows.Forms.CheckBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEpisode = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonFilePlay = new System.Windows.Forms.Button();
            this.comboBoxShow = new System.Windows.Forms.ComboBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelExtensionFilter = new System.Windows.Forms.Label();
            this.textBoxExtensionFilter = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelVlcExecutable = new System.Windows.Forms.Label();
            this.textBoxVlcExecutable = new System.Windows.Forms.TextBox();
            this.buttonVlcExecutable = new System.Windows.Forms.Button();
            this.groupBoxFileInfo = new System.Windows.Forms.GroupBox();
            this.numericUpDownEndingEpisode = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartingEpisode = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeason = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxFileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndingEpisode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartingEpisode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInputFolder
            // 
            this.labelInputFolder.AutoSize = true;
            this.labelInputFolder.Location = new System.Drawing.Point(6, 22);
            this.labelInputFolder.Name = "labelInputFolder";
            this.labelInputFolder.Size = new System.Drawing.Size(63, 13);
            this.labelInputFolder.TabIndex = 0;
            this.labelInputFolder.Text = "Input Folder";
            // 
            // textBoxInputFolder
            // 
            this.textBoxInputFolder.Location = new System.Drawing.Point(96, 19);
            this.textBoxInputFolder.Name = "textBoxInputFolder";
            this.textBoxInputFolder.ReadOnly = true;
            this.textBoxInputFolder.Size = new System.Drawing.Size(202, 20);
            this.textBoxInputFolder.TabIndex = 1;
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(96, 71);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.ReadOnly = true;
            this.textBoxOutputFolder.Size = new System.Drawing.Size(202, 20);
            this.textBoxOutputFolder.TabIndex = 2;
            // 
            // labelOutputFolder
            // 
            this.labelOutputFolder.AutoSize = true;
            this.labelOutputFolder.Location = new System.Drawing.Point(6, 74);
            this.labelOutputFolder.Name = "labelOutputFolder";
            this.labelOutputFolder.Size = new System.Drawing.Size(71, 13);
            this.labelOutputFolder.TabIndex = 3;
            this.labelOutputFolder.Text = "Output Folder";
            // 
            // buttonInputFolder
            // 
            this.buttonInputFolder.Location = new System.Drawing.Point(306, 19);
            this.buttonInputFolder.Name = "buttonInputFolder";
            this.buttonInputFolder.Size = new System.Drawing.Size(48, 20);
            this.buttonInputFolder.TabIndex = 4;
            this.buttonInputFolder.Text = "...";
            this.buttonInputFolder.UseVisualStyleBackColor = true;
            this.buttonInputFolder.Click += new System.EventHandler(this.buttonInputFolder_Click);
            // 
            // buttonOutputFolder
            // 
            this.buttonOutputFolder.Location = new System.Drawing.Point(306, 71);
            this.buttonOutputFolder.Name = "buttonOutputFolder";
            this.buttonOutputFolder.Size = new System.Drawing.Size(48, 20);
            this.buttonOutputFolder.TabIndex = 5;
            this.buttonOutputFolder.Text = "...";
            this.buttonOutputFolder.UseVisualStyleBackColor = true;
            this.buttonOutputFolder.Click += new System.EventHandler(this.buttonOutputFolder_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(306, 45);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(48, 20);
            this.buttonScan.TabIndex = 6;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // checkBoxAutoTitleLookup
            // 
            this.checkBoxAutoTitleLookup.AutoSize = true;
            this.checkBoxAutoTitleLookup.Checked = true;
            this.checkBoxAutoTitleLookup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoTitleLookup.Location = new System.Drawing.Point(267, 101);
            this.checkBoxAutoTitleLookup.Name = "checkBoxAutoTitleLookup";
            this.checkBoxAutoTitleLookup.Size = new System.Drawing.Size(87, 17);
            this.checkBoxAutoTitleLookup.TabIndex = 17;
            this.checkBoxAutoTitleLookup.Text = "Auto-Lookup";
            this.checkBoxAutoTitleLookup.UseVisualStyleBackColor = true;
            this.checkBoxAutoTitleLookup.CheckedChanged += new System.EventHandler(this.checkBoxAutoTitleLookup_CheckedChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(269, 75);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(304, 72);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(50, 20);
            this.textBoxYear.TabIndex = 15;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(6, 48);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(9, 125);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ReadOnly = true;
            this.textBoxDestination.Size = new System.Drawing.Size(345, 20);
            this.textBoxDestination.TabIndex = 11;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(172, 48);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(34, 13);
            this.labelShow.TabIndex = 8;
            this.labelShow.Text = "Show";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(55, 99);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(206, 20);
            this.textBoxTitle.TabIndex = 7;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 102);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title";
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Location = new System.Drawing.Point(102, 75);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(45, 13);
            this.labelEpisode.TabIndex = 4;
            this.labelEpisode.Text = "Episode";
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(6, 75);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(43, 13);
            this.labelSeason.TabIndex = 2;
            this.labelSeason.Text = "Season";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Movies",
            "TV Shows"});
            this.comboBoxType.Location = new System.Drawing.Point(55, 45);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(111, 21);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonFilePlay
            // 
            this.buttonFilePlay.Location = new System.Drawing.Point(330, 19);
            this.buttonFilePlay.Name = "buttonFilePlay";
            this.buttonFilePlay.Size = new System.Drawing.Size(24, 20);
            this.buttonFilePlay.TabIndex = 8;
            this.buttonFilePlay.Text = "►";
            this.buttonFilePlay.UseVisualStyleBackColor = true;
            this.buttonFilePlay.Click += new System.EventHandler(this.buttonFilePlay_Click);
            // 
            // comboBoxShow
            // 
            this.comboBoxShow.FormattingEnabled = true;
            this.comboBoxShow.Location = new System.Drawing.Point(212, 45);
            this.comboBoxShow.Name = "comboBoxShow";
            this.comboBoxShow.Size = new System.Drawing.Size(141, 21);
            this.comboBoxShow.Sorted = true;
            this.comboBoxShow.TabIndex = 9;
            this.comboBoxShow.SelectedIndexChanged += new System.EventHandler(this.comboBoxShow_SelectedIndexChanged);
            this.comboBoxShow.TextUpdate += new System.EventHandler(this.comboBoxShow_TextUpdate);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(55, 19);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(270, 20);
            this.textBoxFile.TabIndex = 1;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(6, 22);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(23, 13);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "File";
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(270, 303);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(48, 23);
            this.buttonSkip.TabIndex = 16;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(324, 303);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(48, 23);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelExtensionFilter
            // 
            this.labelExtensionFilter.AutoSize = true;
            this.labelExtensionFilter.Location = new System.Drawing.Point(6, 49);
            this.labelExtensionFilter.Name = "labelExtensionFilter";
            this.labelExtensionFilter.Size = new System.Drawing.Size(78, 13);
            this.labelExtensionFilter.TabIndex = 14;
            this.labelExtensionFilter.Text = "Extension Filter";
            // 
            // textBoxExtensionFilter
            // 
            this.textBoxExtensionFilter.Location = new System.Drawing.Point(96, 45);
            this.textBoxExtensionFilter.Name = "textBoxExtensionFilter";
            this.textBoxExtensionFilter.Size = new System.Drawing.Size(202, 20);
            this.textBoxExtensionFilter.TabIndex = 15;
            this.textBoxExtensionFilter.Text = "mkv, mp4";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 303);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 23);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Refresh Lookup";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.labelVlcExecutable);
            this.groupBoxConfig.Controls.Add(this.buttonInputFolder);
            this.groupBoxConfig.Controls.Add(this.textBoxVlcExecutable);
            this.groupBoxConfig.Controls.Add(this.buttonVlcExecutable);
            this.groupBoxConfig.Controls.Add(this.labelExtensionFilter);
            this.groupBoxConfig.Controls.Add(this.textBoxExtensionFilter);
            this.groupBoxConfig.Controls.Add(this.textBoxInputFolder);
            this.groupBoxConfig.Controls.Add(this.buttonScan);
            this.groupBoxConfig.Controls.Add(this.textBoxOutputFolder);
            this.groupBoxConfig.Controls.Add(this.labelOutputFolder);
            this.groupBoxConfig.Controls.Add(this.labelInputFolder);
            this.groupBoxConfig.Controls.Add(this.buttonOutputFolder);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(360, 122);
            this.groupBoxConfig.TabIndex = 20;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Config";
            // 
            // labelVlcExecutable
            // 
            this.labelVlcExecutable.AutoSize = true;
            this.labelVlcExecutable.Location = new System.Drawing.Point(6, 99);
            this.labelVlcExecutable.Name = "labelVlcExecutable";
            this.labelVlcExecutable.Size = new System.Drawing.Size(83, 13);
            this.labelVlcExecutable.TabIndex = 0;
            this.labelVlcExecutable.Text = "VLC Executable";
            // 
            // textBoxVlcExecutable
            // 
            this.textBoxVlcExecutable.Location = new System.Drawing.Point(96, 96);
            this.textBoxVlcExecutable.Name = "textBoxVlcExecutable";
            this.textBoxVlcExecutable.ReadOnly = true;
            this.textBoxVlcExecutable.Size = new System.Drawing.Size(202, 20);
            this.textBoxVlcExecutable.TabIndex = 21;
            // 
            // buttonVlcExecutable
            // 
            this.buttonVlcExecutable.Location = new System.Drawing.Point(304, 96);
            this.buttonVlcExecutable.Name = "buttonVlcExecutable";
            this.buttonVlcExecutable.Size = new System.Drawing.Size(48, 20);
            this.buttonVlcExecutable.TabIndex = 21;
            this.buttonVlcExecutable.Text = "...";
            this.buttonVlcExecutable.UseVisualStyleBackColor = true;
            this.buttonVlcExecutable.Click += new System.EventHandler(this.buttonVlcExecutable_Click);
            // 
            // groupBoxFileInfo
            // 
            this.groupBoxFileInfo.Controls.Add(this.numericUpDownEndingEpisode);
            this.groupBoxFileInfo.Controls.Add(this.numericUpDownStartingEpisode);
            this.groupBoxFileInfo.Controls.Add(this.numericUpDownSeason);
            this.groupBoxFileInfo.Controls.Add(this.textBoxDestination);
            this.groupBoxFileInfo.Controls.Add(this.checkBoxAutoTitleLookup);
            this.groupBoxFileInfo.Controls.Add(this.textBoxFile);
            this.groupBoxFileInfo.Controls.Add(this.labelYear);
            this.groupBoxFileInfo.Controls.Add(this.labelTitle);
            this.groupBoxFileInfo.Controls.Add(this.textBoxTitle);
            this.groupBoxFileInfo.Controls.Add(this.buttonFilePlay);
            this.groupBoxFileInfo.Controls.Add(this.comboBoxType);
            this.groupBoxFileInfo.Controls.Add(this.textBoxYear);
            this.groupBoxFileInfo.Controls.Add(this.comboBoxShow);
            this.groupBoxFileInfo.Controls.Add(this.labelType);
            this.groupBoxFileInfo.Controls.Add(this.labelShow);
            this.groupBoxFileInfo.Controls.Add(this.labelEpisode);
            this.groupBoxFileInfo.Controls.Add(this.labelFile);
            this.groupBoxFileInfo.Controls.Add(this.labelSeason);
            this.groupBoxFileInfo.Location = new System.Drawing.Point(12, 140);
            this.groupBoxFileInfo.Name = "groupBoxFileInfo";
            this.groupBoxFileInfo.Size = new System.Drawing.Size(360, 157);
            this.groupBoxFileInfo.TabIndex = 21;
            this.groupBoxFileInfo.TabStop = false;
            this.groupBoxFileInfo.Text = "File Info";
            // 
            // numericUpDownEndingEpisode
            // 
            this.numericUpDownEndingEpisode.Location = new System.Drawing.Point(200, 72);
            this.numericUpDownEndingEpisode.Name = "numericUpDownEndingEpisode";
            this.numericUpDownEndingEpisode.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownEndingEpisode.TabIndex = 24;
            this.numericUpDownEndingEpisode.ValueChanged += new System.EventHandler(this.numericUpDownEndingEpisode_ValueChanged);
            // 
            // numericUpDownStartingEpisode
            // 
            this.numericUpDownStartingEpisode.Location = new System.Drawing.Point(153, 72);
            this.numericUpDownStartingEpisode.Name = "numericUpDownStartingEpisode";
            this.numericUpDownStartingEpisode.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownStartingEpisode.TabIndex = 23;
            this.numericUpDownStartingEpisode.ValueChanged += new System.EventHandler(this.numericUpDownStartingEpisode_ValueChanged);
            // 
            // numericUpDownSeason
            // 
            this.numericUpDownSeason.Location = new System.Drawing.Point(55, 72);
            this.numericUpDownSeason.Name = "numericUpDownSeason";
            this.numericUpDownSeason.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownSeason.TabIndex = 22;
            this.numericUpDownSeason.ValueChanged += new System.EventHandler(this.numericUpDownSeason_ValueChanged);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "Copy",
            "Move"});
            this.comboBoxOperation.Location = new System.Drawing.Point(212, 304);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(52, 21);
            this.comboBoxOperation.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(12, 332);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(360, 20);
            this.textBoxStatus.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.groupBoxFileInfo);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonApply);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PlexRenamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxFileInfo.ResumeLayout(false);
            this.groupBoxFileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndingEpisode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartingEpisode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputFolder;
        private System.Windows.Forms.TextBox textBoxInputFolder;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.Label labelOutputFolder;
        private System.Windows.Forms.Button buttonInputFolder;
        private System.Windows.Forms.Button buttonOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEpisode;
        private System.Windows.Forms.Button buttonFilePlay;
        private System.Windows.Forms.ComboBox comboBoxShow;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelExtensionFilter;
        private System.Windows.Forms.TextBox textBoxExtensionFilter;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxAutoTitleLookup;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.TextBox textBoxVlcExecutable;
        private System.Windows.Forms.Button buttonVlcExecutable;
        private System.Windows.Forms.Label labelVlcExecutable;
        private System.Windows.Forms.GroupBox groupBoxFileInfo;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.NumericUpDown numericUpDownEndingEpisode;
        private System.Windows.Forms.NumericUpDown numericUpDownStartingEpisode;
        private System.Windows.Forms.NumericUpDown numericUpDownSeason;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}

