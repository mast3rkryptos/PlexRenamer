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
            this.buttonGo = new System.Windows.Forms.Button();
            this.panelFileInfo = new System.Windows.Forms.Panel();
            this.checkBoxTitleLookup = new System.Windows.Forms.CheckBox();
            this.comboBoxEndingEpisode = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonFilePlay = new System.Windows.Forms.Button();
            this.comboBoxShow = new System.Windows.Forms.ComboBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxStartingEpisode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxMove = new System.Windows.Forms.CheckBox();
            this.labelExtensionFilter = new System.Windows.Forms.Label();
            this.textBoxExtensionFilter = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelFileInfo = new System.Windows.Forms.Label();
            this.panelFileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInputFolder
            // 
            this.labelInputFolder.AutoSize = true;
            this.labelInputFolder.Location = new System.Drawing.Point(13, 13);
            this.labelInputFolder.Name = "labelInputFolder";
            this.labelInputFolder.Size = new System.Drawing.Size(63, 13);
            this.labelInputFolder.TabIndex = 0;
            this.labelInputFolder.Text = "Input Folder";
            // 
            // textBoxInputFolder
            // 
            this.textBoxInputFolder.Location = new System.Drawing.Point(82, 10);
            this.textBoxInputFolder.Name = "textBoxInputFolder";
            this.textBoxInputFolder.ReadOnly = true;
            this.textBoxInputFolder.Size = new System.Drawing.Size(206, 20);
            this.textBoxInputFolder.TabIndex = 1;
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(82, 37);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.ReadOnly = true;
            this.textBoxOutputFolder.Size = new System.Drawing.Size(206, 20);
            this.textBoxOutputFolder.TabIndex = 2;
            // 
            // labelOutputFolder
            // 
            this.labelOutputFolder.AutoSize = true;
            this.labelOutputFolder.Location = new System.Drawing.Point(13, 40);
            this.labelOutputFolder.Name = "labelOutputFolder";
            this.labelOutputFolder.Size = new System.Drawing.Size(71, 13);
            this.labelOutputFolder.TabIndex = 3;
            this.labelOutputFolder.Text = "Output Folder";
            // 
            // buttonInputFolder
            // 
            this.buttonInputFolder.Location = new System.Drawing.Point(294, 10);
            this.buttonInputFolder.Name = "buttonInputFolder";
            this.buttonInputFolder.Size = new System.Drawing.Size(24, 20);
            this.buttonInputFolder.TabIndex = 4;
            this.buttonInputFolder.Text = "...";
            this.buttonInputFolder.UseVisualStyleBackColor = true;
            this.buttonInputFolder.Click += new System.EventHandler(this.buttonInputFolder_Click);
            // 
            // buttonOutputFolder
            // 
            this.buttonOutputFolder.Location = new System.Drawing.Point(294, 37);
            this.buttonOutputFolder.Name = "buttonOutputFolder";
            this.buttonOutputFolder.Size = new System.Drawing.Size(24, 20);
            this.buttonOutputFolder.TabIndex = 5;
            this.buttonOutputFolder.Text = "...";
            this.buttonOutputFolder.UseVisualStyleBackColor = true;
            this.buttonOutputFolder.Click += new System.EventHandler(this.buttonOutputFolder_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(324, 10);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(48, 48);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // panelFileInfo
            // 
            this.panelFileInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFileInfo.Controls.Add(this.checkBoxTitleLookup);
            this.panelFileInfo.Controls.Add(this.comboBoxEndingEpisode);
            this.panelFileInfo.Controls.Add(this.textBoxYear);
            this.panelFileInfo.Controls.Add(this.labelYear);
            this.panelFileInfo.Controls.Add(this.comboBoxType);
            this.panelFileInfo.Controls.Add(this.labelType);
            this.panelFileInfo.Controls.Add(this.textBoxDestination);
            this.panelFileInfo.Controls.Add(this.buttonFilePlay);
            this.panelFileInfo.Controls.Add(this.comboBoxShow);
            this.panelFileInfo.Controls.Add(this.labelShow);
            this.panelFileInfo.Controls.Add(this.textBoxTitle);
            this.panelFileInfo.Controls.Add(this.labelTitle);
            this.panelFileInfo.Controls.Add(this.comboBoxStartingEpisode);
            this.panelFileInfo.Controls.Add(this.label5);
            this.panelFileInfo.Controls.Add(this.comboBoxSeason);
            this.panelFileInfo.Controls.Add(this.labelSeason);
            this.panelFileInfo.Controls.Add(this.textBoxFile);
            this.panelFileInfo.Controls.Add(this.labelFile);
            this.panelFileInfo.Location = new System.Drawing.Point(12, 107);
            this.panelFileInfo.Name = "panelFileInfo";
            this.panelFileInfo.Size = new System.Drawing.Size(360, 138);
            this.panelFileInfo.TabIndex = 7;
            // 
            // checkBoxTitleLookup
            // 
            this.checkBoxTitleLookup.AutoSize = true;
            this.checkBoxTitleLookup.Checked = true;
            this.checkBoxTitleLookup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTitleLookup.Location = new System.Drawing.Point(271, 85);
            this.checkBoxTitleLookup.Name = "checkBoxTitleLookup";
            this.checkBoxTitleLookup.Size = new System.Drawing.Size(87, 17);
            this.checkBoxTitleLookup.TabIndex = 17;
            this.checkBoxTitleLookup.Text = "Auto-Lookup";
            this.checkBoxTitleLookup.UseVisualStyleBackColor = true;
            this.checkBoxTitleLookup.CheckedChanged += new System.EventHandler(this.checkBoxTitleLookup_CheckedChanged);
            // 
            // comboBoxEndingEpisode
            // 
            this.comboBoxEndingEpisode.FormattingEnabled = true;
            this.comboBoxEndingEpisode.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBoxEndingEpisode.Location = new System.Drawing.Point(310, 55);
            this.comboBoxEndingEpisode.Name = "comboBoxEndingEpisode";
            this.comboBoxEndingEpisode.Size = new System.Drawing.Size(41, 21);
            this.comboBoxEndingEpisode.TabIndex = 16;
            this.comboBoxEndingEpisode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndingEpisode_SelectedIndexChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(205, 29);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 15;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(170, 32);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "Year";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Movies",
            "TV Shows"});
            this.comboBoxType.Location = new System.Drawing.Point(43, 29);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(3, 32);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(4, 109);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ReadOnly = true;
            this.textBoxDestination.Size = new System.Drawing.Size(347, 20);
            this.textBoxDestination.TabIndex = 11;
            // 
            // buttonFilePlay
            // 
            this.buttonFilePlay.Location = new System.Drawing.Point(329, 3);
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
            this.comboBoxShow.Location = new System.Drawing.Point(43, 56);
            this.comboBoxShow.Name = "comboBoxShow";
            this.comboBoxShow.Size = new System.Drawing.Size(129, 21);
            this.comboBoxShow.Sorted = true;
            this.comboBoxShow.TabIndex = 9;
            this.comboBoxShow.SelectedIndexChanged += new System.EventHandler(this.comboBoxShow_SelectedIndexChanged);
            this.comboBoxShow.TextUpdate += new System.EventHandler(this.comboBoxShow_TextUpdate);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(3, 59);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(34, 13);
            this.labelShow.TabIndex = 8;
            this.labelShow.Text = "Show";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(43, 83);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(222, 20);
            this.textBoxTitle.TabIndex = 7;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 86);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title";
            // 
            // comboBoxStartingEpisode
            // 
            this.comboBoxStartingEpisode.FormattingEnabled = true;
            this.comboBoxStartingEpisode.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBoxStartingEpisode.Location = new System.Drawing.Point(265, 55);
            this.comboBoxStartingEpisode.Name = "comboBoxStartingEpisode";
            this.comboBoxStartingEpisode.Size = new System.Drawing.Size(41, 21);
            this.comboBoxStartingEpisode.TabIndex = 5;
            this.comboBoxStartingEpisode.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartingEpisode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E";
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSeason.Location = new System.Drawing.Point(198, 56);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(41, 21);
            this.comboBoxSeason.TabIndex = 3;
            this.comboBoxSeason.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeason_SelectedIndexChanged);
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(178, 59);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(14, 13);
            this.labelSeason.TabIndex = 2;
            this.labelSeason.Text = "S";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(43, 3);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(280, 20);
            this.textBoxFile.TabIndex = 1;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(3, 6);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(23, 13);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "File";
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(270, 251);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(48, 23);
            this.buttonSkip.TabIndex = 16;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(324, 251);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(48, 23);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxMove
            // 
            this.checkBoxMove.AutoSize = true;
            this.checkBoxMove.Checked = true;
            this.checkBoxMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMove.Location = new System.Drawing.Point(211, 255);
            this.checkBoxMove.Name = "checkBoxMove";
            this.checkBoxMove.Size = new System.Drawing.Size(53, 17);
            this.checkBoxMove.TabIndex = 12;
            this.checkBoxMove.Text = "Move";
            this.checkBoxMove.UseVisualStyleBackColor = true;
            // 
            // labelExtensionFilter
            // 
            this.labelExtensionFilter.AutoSize = true;
            this.labelExtensionFilter.Location = new System.Drawing.Point(13, 65);
            this.labelExtensionFilter.Name = "labelExtensionFilter";
            this.labelExtensionFilter.Size = new System.Drawing.Size(78, 13);
            this.labelExtensionFilter.TabIndex = 14;
            this.labelExtensionFilter.Text = "Extension Filter";
            // 
            // textBoxExtensionFilter
            // 
            this.textBoxExtensionFilter.Location = new System.Drawing.Point(97, 62);
            this.textBoxExtensionFilter.Name = "textBoxExtensionFilter";
            this.textBoxExtensionFilter.Size = new System.Drawing.Size(275, 20);
            this.textBoxExtensionFilter.TabIndex = 15;
            this.textBoxExtensionFilter.Text = "mkv, mp4";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 251);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(79, 23);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Refresh Lookup";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelFileInfo
            // 
            this.labelFileInfo.AutoSize = true;
            this.labelFileInfo.Location = new System.Drawing.Point(13, 91);
            this.labelFileInfo.Name = "labelFileInfo";
            this.labelFileInfo.Size = new System.Drawing.Size(47, 13);
            this.labelFileInfo.TabIndex = 19;
            this.labelFileInfo.Text = "File Info:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.labelFileInfo);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.textBoxExtensionFilter);
            this.Controls.Add(this.labelExtensionFilter);
            this.Controls.Add(this.checkBoxMove);
            this.Controls.Add(this.panelFileInfo);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonOutputFolder);
            this.Controls.Add(this.buttonInputFolder);
            this.Controls.Add(this.labelOutputFolder);
            this.Controls.Add(this.textBoxOutputFolder);
            this.Controls.Add(this.textBoxInputFolder);
            this.Controls.Add(this.labelInputFolder);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PlexRenamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelFileInfo.ResumeLayout(false);
            this.panelFileInfo.PerformLayout();
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
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Panel panelFileInfo;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ComboBox comboBoxSeason;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxStartingEpisode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFilePlay;
        private System.Windows.Forms.ComboBox comboBoxShow;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.CheckBox checkBoxMove;
        private System.Windows.Forms.Label labelExtensionFilter;
        private System.Windows.Forms.TextBox textBoxExtensionFilter;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxEndingEpisode;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxTitleLookup;
        private System.Windows.Forms.Label labelFileInfo;
    }
}

