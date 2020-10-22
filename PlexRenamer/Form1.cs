using Microsoft.VisualBasic.FileIO;
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

        /*** Form init and close ***/

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
            comboBoxOperation.Text = MySettings.Default.Move;
            textBoxVlcExecutable.Text = MySettings.Default.VLCExecutable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySettings.Default.Save();
        }

        /*** Form utilities ***/

        private void ClearFileInfoDisplay()
        {
            textBoxFile.Clear();
            comboBoxShow.SelectedIndex = -1;
            numericUpDownSeason.Value = 0;
            numericUpDownStartingEpisode.Value = 0;
            numericUpDownEndingEpisode.Value = 0;
            textBoxYear.Clear();
            textBoxTitle.Clear();
            textBoxDestination.Clear();
        }

        private async void LookupAndUpdateTitle()
        {
            if (checkBoxAutoTitleLookup.Checked && comboBoxType.SelectedItem != null && comboBoxType.SelectedItem.Equals("TV Shows"))
            {
                textBoxTitle.Text = await Utilities.GetEpisodeTitle(comboBoxShow.Text, numericUpDownSeason.Value.ToString(), numericUpDownStartingEpisode.Value.ToString());
            }
        }

        private void UpdateDestination()
        {
            // Replace the characters deemed invalid for Windows filenames
            string tempTitle = textBoxTitle.Text;
            tempTitle = tempTitle.Replace("<",  "");
            tempTitle = tempTitle.Replace(">",  "");
            tempTitle = tempTitle.Replace(":",  "");
            tempTitle = tempTitle.Replace("\"", "");
            tempTitle = tempTitle.Replace("/",  "");
            tempTitle = tempTitle.Replace("\\", "");
            tempTitle = tempTitle.Replace("|",  "");
            tempTitle = tempTitle.Replace("?",  "");
            tempTitle = tempTitle.Replace("*",  "");

            if (comboBoxType.SelectedItem != null && comboBoxType.SelectedItem.Equals("TV Shows"))
            {
                string episodeStr = numericUpDownStartingEpisode.Value == numericUpDownEndingEpisode.Value ? numericUpDownStartingEpisode.Value.ToString() : numericUpDownStartingEpisode.Value + "-e" + numericUpDownEndingEpisode.Value;

                // This puts the various data fields about the filepath into the Plex name format
                // TV Shows: [root]\TV Shows\{show name}\Season ##\{show name} - s##e##[-e##] - {optional info}.{ext} 
                // Movies: [root]\{movie name} ({movie year})\{movie name} ({movie year}).{ext}
                textBoxDestination.Text = Path.Combine(
                    textBoxOutputFolder.Text,
                    comboBoxType.Text,
                    comboBoxShow.Text,
                    String.Format("Season {0:00}", numericUpDownSeason.Value),
                    String.Format("{0} - s{1:00}e{2}{3}{4}", 
                        comboBoxShow.Text,
                        numericUpDownSeason.Value,
                        episodeStr,
                        ((tempTitle == null || tempTitle == "") ? "" : (" - " + tempTitle)),
                        Path.GetExtension(textBoxFile.Text)));
            }
            else if (comboBoxType.SelectedItem != null && comboBoxType.SelectedItem.Equals("Movies"))
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

        /*** Form interaction events ***/
        private void buttonInputFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxInputFolder.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxInputFolder.Text = folderBrowserDialog1.SelectedPath;
                textBoxInputFolder.Select(textBoxInputFolder.Text.Length, 0);
                MySettings.Default.InputFolder = textBoxInputFolder.Text;
                MySettings.Default.Save();
            }
        }

        private void buttonOutputFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxOutputFolder.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                textBoxOutputFolder.Select(textBoxOutputFolder.Text.Length, 0);
                MySettings.Default.OutputFolder = textBoxOutputFolder.Text;
                MySettings.Default.Save();
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            MySettings.Default.ExtensionFilter = textBoxExtensionFilter.Text;
            MySettings.Default.Save();

            files = Utilities.WalkDirectoryTree(new System.IO.DirectoryInfo(textBoxInputFolder.Text), textBoxExtensionFilter.Text.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries));
            files.Sort();
            filesEnumerator = files.GetEnumerator();
            filesEnumerator.MoveNext();
            ClearFileInfoDisplay();
            textBoxFile.Text = filesEnumerator.Current.ToString();
        }

        private void buttonVlcExecutable_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxVlcExecutable.Text = openFileDialog1.FileName;
                textBoxVlcExecutable.Select(textBoxVlcExecutable.Text.Length, 0);
                MySettings.Default.VLCExecutable = textBoxVlcExecutable.Text;
                MySettings.Default.Save();
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.Equals("TV Shows"))
            {
                checkBoxAutoTitleLookup.Enabled = true;
                comboBoxShow.Enabled = true;
                numericUpDownSeason.Enabled = true;
                numericUpDownStartingEpisode.Enabled = true;
                numericUpDownEndingEpisode.Enabled = true;
                textBoxYear.Enabled = false;
                textBoxTitle.Enabled = checkBoxAutoTitleLookup.Checked ? false : true;
            }
            else if (comboBoxType.SelectedItem.Equals("Movies"))
            {
                checkBoxAutoTitleLookup.Enabled = false;
                comboBoxShow.Enabled = false;
                numericUpDownSeason.Enabled = false;
                numericUpDownStartingEpisode.Enabled = false;
                numericUpDownEndingEpisode.Enabled = false;
                textBoxYear.Enabled = true;
                textBoxTitle.Enabled = true;
                checkBoxAutoTitleLookup.Checked = false;
            }
            LookupAndUpdateTitle();
            UpdateDestination();
        }
        
        private void comboBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownSeason.Value = 1;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void comboBoxShow_TextUpdate(object sender, EventArgs e)
        {
            numericUpDownSeason.Value = 1;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateDestination();
        }

        private void buttonFilePlay_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = textBoxVlcExecutable.Text;
            p.StartInfo.Arguments = "--gain=0 \"" + Path.GetFullPath(textBoxFile.Text) + "\"";
            p.Start();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            if (filesEnumerator.MoveNext()) // Go to the next file in the path
            {
                textBoxFile.Text = filesEnumerator.Current.ToString();
                LookupAndUpdateTitle();
                UpdateDestination();
            }
            else
            {
                ClearFileInfoDisplay();
                textBoxStatus.Text = "End of file list!";
            }
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
                MySettings.Default.Save();
            }

            Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(textBoxDestination.Text)));
            textBoxStatus.Text = "Deleting destination file ...";
            File.Delete(Path.GetFullPath(textBoxDestination.Text));
            if (comboBoxOperation.SelectedItem.Equals("Move"))
            {
                textBoxStatus.Text = "Executing move operation...";
                File.Move(Path.GetFullPath(textBoxFile.Text), Path.GetFullPath(textBoxDestination.Text));
            }
            else
            {
                textBoxStatus.Text = "Executing copy operation...";
                File.Copy(Path.GetFullPath(textBoxFile.Text), Path.GetFullPath(textBoxDestination.Text));
            }

            textBoxStatus.Text = "Completed!";

            if (filesEnumerator.MoveNext()) // Go to the next file in the path
            {
                textBoxFile.Text = filesEnumerator.Current.ToString();
                if (comboBoxType.SelectedItem != null && comboBoxType.SelectedItem.Equals("TV Shows"))
                {
                    // Advance Episode number
                    numericUpDownStartingEpisode.Value++;
                }

                LookupAndUpdateTitle();
                UpdateDestination();
            }
            else
            {
                ClearFileInfoDisplay();
                textBoxStatus.Text = "End of file list!";
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            UpdateDestination();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void checkBoxAutoTitleLookup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoTitleLookup.Checked) 
            {
                textBoxTitle.Enabled = false;
                if (comboBoxType.SelectedItem != null && comboBoxType.SelectedItem.Equals("TV Shows"))
                {
                    LookupAndUpdateTitle();
                }
            }
            else
            {
                textBoxTitle.Enabled = true;
                textBoxTitle.Clear();
            }
            UpdateDestination();
        }

        private void numericUpDownSeason_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownStartingEpisode.Value = 1;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void numericUpDownStartingEpisode_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEndingEpisode.Value = numericUpDownStartingEpisode.Value;
            LookupAndUpdateTitle();
            UpdateDestination();
        }

        private void numericUpDownEndingEpisode_ValueChanged(object sender, EventArgs e)
        {
            UpdateDestination();
        }
    }
    
}
