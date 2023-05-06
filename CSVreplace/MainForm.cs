// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace CSVreplace
{
    // Directives
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CSVreplace.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the add files button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddFilesButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.textFileOpenFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.textFileOpenFileDialog.ShowDialog() == DialogResult.OK && this.textFileOpenFileDialog.FileNames.Length > 0)
            {
                // Add the text files 
                this.AddTextFiles(this.textFileOpenFileDialog.FileNames);
            }
        }

        /// <summary>
        /// Adds the text files.
        /// </summary>
        /// <param name="textFiles">Text files.</param>
        private void AddTextFiles(IEnumerable textFiles)
        {
            // Iterate collected files
            foreach (string textFile in textFiles)
            {
                // Check for a previous one
                if (!this.targetTextFilesCheckedListBox.Items.Contains(textFile))
                {
                    // Add to target text files
                    this.targetTextFilesCheckedListBox.Items.Add(textFile);
                }

                // Should it be checked on add?
                if (this.checkOnAddToolStripMenuItem.Checked)
                {
                    // Check item (current or previous)
                    this.targetTextFilesCheckedListBox.SetItemChecked(this.targetTextFilesCheckedListBox.Items.IndexOf(textFile), true);
                }
            }
        }

        /// <summary>
        /// Handles the add folder button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAddFolderButtonClick(object sender, EventArgs e)
        {
            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Add the text files 
                this.AddTextFiles(Directory.GetFiles(this.folderBrowserDialog.SelectedPath, "*.txt"));
            }
        }

        /// <summary>
        /// Handles the load csv file button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLoadCsvFileButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.csvFileOpenFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.csvFileOpenFileDialog.ShowDialog() == DialogResult.OK && this.csvFileOpenFileDialog.FileNames.Length > 0)
            {
                // Add the CSV file lines with format <search>,<replace>
                using (StreamReader reader = new StreamReader(this.csvFileOpenFileDialog.FileName))
                {
                    // Current line
                    string line;

                    // Read the lines
                    while ((line = reader.ReadLine()) != null)
                    {
                        /* Check for proper <search>,<replace> format */

                        // Split into fields, trimmed
                        string[] fields = line.Split(new string[] { "," }, 2, StringSplitOptions.None).Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                        // Check there are two
                        if (fields.Length == 2)
                        {
                            // Set to "search, replace" format
                            string displayLine = $"{fields[0]}, {fields[1]}";

                            // Check for a previous one
                            if (!this.csvReplacementsCheckedListBox.Items.Contains(displayLine))
                            {
                                // Add to CSV checked list
                                this.csvReplacementsCheckedListBox.Items.Add(displayLine);
                            }

                            // Should it be checked on add?
                            if (this.checkOnAddToolStripMenuItem.Checked)
                            {
                                // Check item (current or previous)
                                this.csvReplacementsCheckedListBox.SetItemChecked(this.csvReplacementsCheckedListBox.Items.IndexOf(displayLine), true);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the replace button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnReplaceButtonClick(object sender, EventArgs e)
        {
            // Check for checked files to work with
            if (this.targetTextFilesCheckedListBox.CheckedItems.Count == 0)
            {
                // Advise user
                MessageBox.Show("Please add target text files.", "Missing targets", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow
                return;
            }

            // Check for replacements to work with
            if (this.csvReplacementsCheckedListBox.CheckedItems.Count == 0)
            {
                // Advise user
                MessageBox.Show("Please add CSV replacements.", "Missing replacements", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Halt flow
                return;
            }

            // Processed count
            int processed = 0;

            // Check there are checked replacements
            if (this.csvReplacementsCheckedListBox.CheckedItems.Count > 0)
            {
                // Iterate checked files
                foreach (string textFilePath in this.targetTextFilesCheckedListBox.CheckedItems)
                {
                    try
                    {
                        // Check file exists
                        if (File.Exists(textFilePath))
                        {
                            // Set text file contents
                            string textFileContents = File.ReadAllText(textFilePath);

                            // Replace checked
                            foreach (string replacement in this.csvReplacementsCheckedListBox.CheckedItems)
                            {
                                // TODO Extract fields from checked item [Can be centralized]
                                string[] fields = replacement.Split(new string[] { "," }, 2, StringSplitOptions.None).Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                                // Replace
                                textFileContents = textFileContents.Replace(fields[0], fields[1]);
                            }

                            // Check if must backup
                            if (this.backupOnReplaceToolStripMenuItem.Checked)
                            {
                                try
                                {
                                    // Set path for backup
                                    string backupFilePath = Path.Combine(Path.GetDirectoryName(textFilePath), String.Concat(Path.GetFileNameWithoutExtension(textFilePath), $"-{(int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds}", Path.GetExtension(textFilePath)));

                                    // Backup file with epoch
                                    File.Copy(textFilePath, backupFilePath);
                                }
                                catch (Exception ex)
                                {
                                    // Write to error log
                                    this.LogError($"Error when backing up to \"{textFilePath}\". Message: {ex.Message}");

                                    // Halt flow (presumably, the user will not want to lose original file's contents)
                                    continue;
                                }
                            }

                            // Write replaced file
                            File.WriteAllText(textFilePath, textFileContents);

                            // Raise processed
                            processed++;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Write to error log
                        this.LogError($"Error when processing \"{textFilePath}\". Message: {ex.Message}");

                        // Halt flow
                        continue;
                    }
                }
            }

            // Update processed
            this.processedToolStripStatusLabel.Text = $"{processed}/{this.targetTextFilesCheckedListBox.CheckedItems.Count}";

            // Set errors
            int errors = this.targetTextFilesCheckedListBox.CheckedItems.Count - processed;

            // Advise user
            MessageBox.Show($"Replaced with {(errors == 0 ? "no" : errors.ToString())} error{(errors == 1 ? string.Empty : "s")}.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">Message.</param>
        private void LogError(string message)
        {
            try
            {
                // TODO Write to error log [Can do smart new line processing]
                File.AppendAllText("CSVreplace_ErrorLog.txt", $"{Environment.NewLine}{message}");
            }
            catch (Exception ex)
            {
                // TODO Advise user
                ;
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear checked lists
            this.targetTextFilesCheckedListBox.Items.Clear();
            this.csvReplacementsCheckedListBox.Items.Clear();

            // Focus first button
            this.addFilesButton.Focus();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=40760.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
