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
        /// The processed.
        /// </summary>
        int processed = 0;

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
                        string[] fields = line.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                        // Check there are two
                        if (fields.Length == 2)
                        {
                            // Set to "search => replace" format
                            string displayLine = $"{fields[0]} => {fields[1]}";

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
            // TODO Add code
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code 
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
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
            // TODO Add code
        }
    }
}
