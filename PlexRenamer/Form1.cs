﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace PlexRenamer
{
    public partial class Form1 : Form
    {
        private ArrayList files = new ArrayList();
        private IEnumerator filesEnumerator;

        private void ClearFileInfoDisplay()
        {
            textBoxFile.Clear();
            textBoxYear.Clear();
            comboBoxShow.Text = "";
            comboBoxSeason.Text = "";
            comboBoxStartingEpisode.Text = "";
            comboBoxEndingEpisode.Text = "";
            textBoxTitle.Clear();
            textBoxDestination.Clear();
        }

        private async void LookupAndUpdateTitle()
        {
            if (checkBoxTitleLookup.Checked && comboBoxType.Text == "TV Shows")
            {
                string temp = await Utilities.GetTVDBEpisodeTitle(comboBoxShow.Text, comboBoxSeason.Text, comboBoxStartingEpisode.Text);
                textBoxTitle.Text = temp.Replace(":", "");
            }
        }

        private void UpdateDestination()
        {
            // Replace the characters deemed invalid for Windows filenames
            string tempTitle = textBoxTitle.Text;
            tempTitle = tempTitle.Replace("<", "");
            tempTitle = tempTitle.Replace(">", "");
            tempTitle = tempTitle.Replace(":", "");
            tempTitle = tempTitle.Replace("\"", "");
            tempTitle = tempTitle.Replace("/", "");
            tempTitle = tempTitle.Replace("\\", "");
            tempTitle = tempTitle.Replace("|", "");
            tempTitle = tempTitle.Replace("?", "");
            tempTitle = tempTitle.Replace("*", "");

            if (comboBoxType.Text == "TV Shows")
            {
                // This puts the various data fields about the filepath into the Plex name format
                // TV Shows: [root]\TV Shows\{show name}\Season ##\{show name} - s##e##[-e##] - {optional info}.{ext} 
                // Movies: [root]\{movie name} ({movie year})\{movie name} ({movie year}).{ext}
                textBoxDestination.Text = Path.Combine(
                    textBoxOutputFolder.Text,
                    comboBoxType.Text,
                    comboBoxShow.Text,
                    "Season " + (comboBoxSeason.Text.Length == 1 ? "0" : "") + comboBoxSeason.Text,
                    comboBoxShow.Text + " - s" + (comboBoxSeason.Text.Length == 1 ? "0" : "") + comboBoxSeason.Text +
                        "e" + (comboBoxStartingEpisode.Text.Length == 1 ? "0" : "") + comboBoxStartingEpisode.Text +
                        (comboBoxStartingEpisode.SelectedIndex == comboBoxEndingEpisode.SelectedIndex ? "" : ("-e" + (comboBoxEndingEpisode.Text.Length == 1 ? "0" : "") + comboBoxEndingEpisode.Text)) +
                        ((tempTitle == null || tempTitle == "") ? "" : (" - " + tempTitle)) + Path.GetExtension(textBoxFile.Text));
            }
            else if (comboBoxType.Text == "Movies")
            {
                textBoxDestination.Text = Path.Combine(
                    textBoxOutputFolder.Text,
                    comboBoxType.Text,
                    tempTitle + " (" + textBoxYear.Text + ")",
                    tempTitle + " (" + textBoxYear.Text + ")" + Path.GetExtension(textBoxFile.Text));
            }

            textBoxFile.Select(textBoxFile.Text.Length, 0);
            textBoxDestination.Select(textBoxDestination.Text.Length, 0);
        }

        private void ParseFilepath()
        {
            // Attempt to parse and pre-fill fields from the Plex name format
            string show, season, startingEpisode, endingEpisode, optionalInfo, title, year;
            if (Utilities.ParsePlexTVFilename(textBoxFile.Text, out show, out season, out startingEpisode, out endingEpisode, out optionalInfo))
            {
                comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf("TV Shows");                                    // This needs to select the index of the type
                comboBoxShow.Text = show;                                                                               // This is okay, this is an text-editable combobox
                comboBoxSeason.SelectedIndex = comboBoxSeason.Items.IndexOf(season);                                    // This needs to select the index of the season
                comboBoxStartingEpisode.SelectedIndex = comboBoxSeason.Items.IndexOf(startingEpisode);                  // This needs to select the index of the starting episode
                comboBoxEndingEpisode.SelectedIndex = comboBoxSeason.Items.IndexOf(endingEpisode);                      // This needs to select the index of the ending episode
                textBoxTitle.Text = optionalInfo;                                          // This is a textbox
            }
            else if (Utilities.ParsePlexMovieFilename(textBoxFile.Text, out title, out year))
            {
                comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf("Movies");                                      // This needs to select the index of the type
                textBoxTitle.Text = title;                                          // This is a textbox
                textBoxYear.Text = year;                                                                                // This is a textbox
            }
            else
            {
                // Attempt to infer at least the Season from the filepath
                Utilities.ParseFilepath(textBoxFile.Text, out season);
                comboBoxSeason.SelectedIndex = comboBoxSeason.Items.IndexOf(season);                                    // This needs to select the index of the season
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Program specific intialization
            if (MySettings.Default.Shows != null)
            {
                foreach (string show in MySettings.Default.Shows)
                {
                    comboBoxShow.Items.Add(show);
                }
            }
            textBoxInputFolder.Text = MySettings.Default.InputFolder;
            textBoxOutputFolder.Text = MySettings.Default.OutputFolder;
            textBoxExtensionFilter.Text = MySettings.Default.ExtensionFilter;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Save off any new entries in Show
            if (!comboBoxShow.Items.Contains(comboBoxShow.Text))
            {
                comboBoxShow.Items.Add(comboBoxShow.Text);
            }
            if (!MySettings.Default.Shows.Contains(comboBoxShow.Text))
            {
                MySettings.Default.Shows.Add(comboBoxShow.Text);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(textBoxDestination.Text)));
            File.Delete(Path.GetFullPath(textBoxDestination.Text));
            if (checkBoxMove.Checked) File.Move(Path.GetFullPath(textBoxFile.Text), Path.GetFullPath(textBoxDestination.Text));
            else File.Copy(Path.GetFullPath(textBoxFile.Text), Path.GetFullPath(textBoxDestination.Text));

            if (filesEnumerator.MoveNext()) // Go to the next file in the path
            {
                textBoxFile.Text = filesEnumerator.Current.ToString();
                if (comboBoxType.Text == "TV Shows")
                {
                    // Advance Episode number
                    comboBoxStartingEpisode.SelectedIndex =
                        comboBoxStartingEpisode.SelectedIndex == comboBoxEndingEpisode.SelectedIndex ?
                            comboBoxStartingEpisode.SelectedIndex + 1 : comboBoxEndingEpisode.SelectedIndex + 1;
                }

                textBoxTitle.Clear();
                ParseFilepath();
                LookupAndUpdateTitle();
                UpdateDestination();
            }
            else
            {
                ClearFileInfoDisplay();
                MessageBox.Show("End of file list!");
            }
        }

        private void buttonInputFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxInputFolder.Text = folderBrowserDialog1.SelectedPath;
                textBoxInputFolder.Select(textBoxInputFolder.Text.Length, 0);
                MySettings.Default.InputFolder = textBoxInputFolder.Text;
            }
        }

        private void buttonOutputFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                textBoxOutputFolder.Select(textBoxOutputFolder.Text.Length, 0);
                MySettings.Default.OutputFolder = textBoxOutputFolder.Text;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            MySettings.Default.ExtensionFilter = textBoxExtensionFilter.Text;

            files = Utilities.WalkDirectoryTree(new System.IO.DirectoryInfo(textBoxInputFolder.Text), textBoxExtensionFilter.Text.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries));
            files.Sort();
            filesEnumerator = files.GetEnumerator();
            filesEnumerator.MoveNext();
            textBoxFile.Text = filesEnumerator.Current.ToString();
            textBoxTitle.Clear();
            ParseFilepath();
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void comboBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSeason.SelectedIndex = comboBoxSeason.Items.IndexOf("1");
            comboBoxStartingEpisode.SelectedIndex = comboBoxStartingEpisode.Items.IndexOf("1");
            comboBoxEndingEpisode.SelectedIndex = comboBoxStartingEpisode.SelectedIndex;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void comboBoxShow_TextUpdate(object sender, EventArgs e)
        {
            comboBoxSeason.SelectedIndex = comboBoxSeason.Items.IndexOf("1");
            comboBoxStartingEpisode.SelectedIndex = comboBoxStartingEpisode.Items.IndexOf("1");
            comboBoxEndingEpisode.SelectedIndex = comboBoxStartingEpisode.SelectedIndex;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void comboBoxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStartingEpisode.SelectedIndex = comboBoxStartingEpisode.Items.IndexOf("1");
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void comboBoxStartingEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEndingEpisode.SelectedIndex = comboBoxStartingEpisode.SelectedIndex;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void comboBoxEndingEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDestination();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateDestination();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySettings.Default.Save();
        }

        private void buttonFilePlay_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
            p.StartInfo.Arguments = "--gain=0 \"" + Path.GetFullPath(textBoxFile.Text) + "\"";
            p.Start();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            if (filesEnumerator.MoveNext()) // Go to the next file in the path
            {
                textBoxFile.Text = filesEnumerator.Current.ToString();
                textBoxTitle.Clear();
                ParseFilepath();
                LookupAndUpdateTitle();
                UpdateDestination();
            }
            else
            {
                ClearFileInfoDisplay();
                MessageBox.Show("End of file list!");
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "TV Shows")
            {
                textBoxYear.Enabled = false;
                comboBoxShow.Enabled = true;
                comboBoxSeason.Enabled = true;
                comboBoxStartingEpisode.Enabled = true;
                comboBoxEndingEpisode.Enabled = true;
                textBoxTitle.Enabled = checkBoxTitleLookup.Checked ? false : true;
                checkBoxTitleLookup.Checked = true;
            }
            else if (comboBoxType.Text == "Movies")
            {
                textBoxYear.Enabled = true;
                comboBoxShow.Enabled = false;
                comboBoxSeason.Enabled = false;
                comboBoxStartingEpisode.Enabled = false;
                comboBoxEndingEpisode.Enabled = false;
                textBoxTitle.Enabled = true;
                checkBoxTitleLookup.Checked = false;
            }
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            UpdateDestination();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = await Utilities.GetTVDBEpisodeTitle(comboBoxShow.Text, comboBoxSeason.Text, comboBoxStartingEpisode.Text);
        }

        private void checkBoxTitleLookup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTitleLookup.Checked)
            {
                textBoxTitle.Enabled = false;
                LookupAndUpdateTitle();
            }
            else
            {
                textBoxTitle.Enabled = true;
            }
            UpdateDestination();
        }
    }
}