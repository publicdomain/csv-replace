
namespace CSVreplace
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog textFileOpenFileDialog;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel processedTextToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel processedToolStripStatusLabel;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.Label targetTextFilesLabel;
		private System.Windows.Forms.Button addFilesButton;
		private System.Windows.Forms.Button addFolderButton;
		private System.Windows.Forms.CheckedListBox targetTextFilesCheckedListBox;
		private System.Windows.Forms.Label csvReplacementsLabel;
		private System.Windows.Forms.Button loadCsvFileButton;
		private System.Windows.Forms.CheckedListBox csvReplacementsCheckedListBox;
		private System.Windows.Forms.Button replaceButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backupNoReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.processedTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.processedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.targetTextFilesLabel = new System.Windows.Forms.Label();
			this.addFilesButton = new System.Windows.Forms.Button();
			this.addFolderButton = new System.Windows.Forms.Button();
			this.targetTextFilesCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.csvReplacementsLabel = new System.Windows.Forms.Label();
			this.loadCsvFileButton = new System.Windows.Forms.Button();
			this.csvReplacementsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.replaceButton = new System.Windows.Forms.Button();
			this.csvFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.checkOnAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.minimizeToolStripMenuItem,
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(334, 24);
			this.mainMenuStrip.TabIndex = 37;
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			this.minimizeToolStripMenuItem.Visible = false;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripSeparator,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem,
									this.checkOnAddToolStripMenuItem,
									this.backupNoReplaceToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// backupNoReplaceToolStripMenuItem
			// 
			this.backupNoReplaceToolStripMenuItem.Name = "backupNoReplaceToolStripMenuItem";
			this.backupNoReplaceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.backupNoReplaceToolStripMenuItem.Text = "&Backup no replace";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.freeReleasesPublicDomainisToolStripMenuItem,
									this.originalThreadDonationCodercomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// freeReleasesPublicDomainisToolStripMenuItem
			// 
			this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
			this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.freeReleasesPublicDomainisToolStripMenuItem.Text = "Free Releases @ PublicDomain.is";
			this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
			// 
			// originalThreadDonationCodercomToolStripMenuItem
			// 
			this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
			this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
			this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
			this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
			// 
			// textFileOpenFileDialog
			// 
			this.textFileOpenFileDialog.DefaultExt = "txt";
			this.textFileOpenFileDialog.Filter = "TXT Files|*.txt|All files (*.*)|*.*";
			this.textFileOpenFileDialog.Multiselect = true;
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.processedTextToolStripStatusLabel,
									this.processedToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 440);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(334, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 36;
			// 
			// processedTextToolStripStatusLabel
			// 
			this.processedTextToolStripStatusLabel.Name = "processedTextToolStripStatusLabel";
			this.processedTextToolStripStatusLabel.Size = new System.Drawing.Size(63, 17);
			this.processedTextToolStripStatusLabel.Text = "Processed:";
			// 
			// processedToolStripStatusLabel
			// 
			this.processedToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processedToolStripStatusLabel.Name = "processedToolStripStatusLabel";
			this.processedToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.processedToolStripStatusLabel.Text = "0";
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 2;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.Controls.Add(this.targetTextFilesLabel, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.addFilesButton, 0, 1);
			this.mainTableLayoutPanel.Controls.Add(this.addFolderButton, 1, 1);
			this.mainTableLayoutPanel.Controls.Add(this.targetTextFilesCheckedListBox, 0, 2);
			this.mainTableLayoutPanel.Controls.Add(this.csvReplacementsLabel, 0, 3);
			this.mainTableLayoutPanel.Controls.Add(this.loadCsvFileButton, 0, 4);
			this.mainTableLayoutPanel.Controls.Add(this.csvReplacementsCheckedListBox, 0, 5);
			this.mainTableLayoutPanel.Controls.Add(this.replaceButton, 0, 6);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 7;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(334, 416);
			this.mainTableLayoutPanel.TabIndex = 38;
			// 
			// targetTextFilesLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.targetTextFilesLabel, 2);
			this.targetTextFilesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.targetTextFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetTextFilesLabel.Location = new System.Drawing.Point(3, 0);
			this.targetTextFilesLabel.Name = "targetTextFilesLabel";
			this.targetTextFilesLabel.Size = new System.Drawing.Size(328, 25);
			this.targetTextFilesLabel.TabIndex = 0;
			this.targetTextFilesLabel.Text = "&Target text file(s):";
			this.targetTextFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addFilesButton
			// 
			this.addFilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addFilesButton.ForeColor = System.Drawing.Color.DarkBlue;
			this.addFilesButton.Location = new System.Drawing.Point(3, 28);
			this.addFilesButton.Name = "addFilesButton";
			this.addFilesButton.Size = new System.Drawing.Size(161, 29);
			this.addFilesButton.TabIndex = 1;
			this.addFilesButton.Text = "&Add file(s)";
			this.addFilesButton.UseVisualStyleBackColor = true;
			this.addFilesButton.Click += new System.EventHandler(this.OnAddFilesButtonClick);
			// 
			// addFolderButton
			// 
			this.addFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addFolderButton.ForeColor = System.Drawing.Color.DarkBlue;
			this.addFolderButton.Location = new System.Drawing.Point(170, 28);
			this.addFolderButton.Name = "addFolderButton";
			this.addFolderButton.Size = new System.Drawing.Size(161, 29);
			this.addFolderButton.TabIndex = 2;
			this.addFolderButton.Text = "Add &folder";
			this.addFolderButton.UseVisualStyleBackColor = true;
			this.addFolderButton.Click += new System.EventHandler(this.OnAddFolderButtonClick);
			// 
			// targetTextFilesCheckedListBox
			// 
			this.targetTextFilesCheckedListBox.CheckOnClick = true;
			this.mainTableLayoutPanel.SetColumnSpan(this.targetTextFilesCheckedListBox, 2);
			this.targetTextFilesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.targetTextFilesCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetTextFilesCheckedListBox.FormattingEnabled = true;
			this.targetTextFilesCheckedListBox.IntegralHeight = false;
			this.targetTextFilesCheckedListBox.Location = new System.Drawing.Point(3, 63);
			this.targetTextFilesCheckedListBox.Name = "targetTextFilesCheckedListBox";
			this.targetTextFilesCheckedListBox.Size = new System.Drawing.Size(328, 117);
			this.targetTextFilesCheckedListBox.Sorted = true;
			this.targetTextFilesCheckedListBox.TabIndex = 3;
			// 
			// csvReplacementsLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.csvReplacementsLabel, 2);
			this.csvReplacementsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.csvReplacementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.csvReplacementsLabel.Location = new System.Drawing.Point(3, 183);
			this.csvReplacementsLabel.Name = "csvReplacementsLabel";
			this.csvReplacementsLabel.Size = new System.Drawing.Size(328, 25);
			this.csvReplacementsLabel.TabIndex = 4;
			this.csvReplacementsLabel.Text = "&CSV replacements:";
			this.csvReplacementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loadCsvFileButton
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.loadCsvFileButton, 2);
			this.loadCsvFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadCsvFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadCsvFileButton.ForeColor = System.Drawing.Color.DarkBlue;
			this.loadCsvFileButton.Location = new System.Drawing.Point(3, 211);
			this.loadCsvFileButton.Name = "loadCsvFileButton";
			this.loadCsvFileButton.Size = new System.Drawing.Size(328, 29);
			this.loadCsvFileButton.TabIndex = 5;
			this.loadCsvFileButton.Text = "Load &CSV file";
			this.loadCsvFileButton.UseVisualStyleBackColor = true;
			this.loadCsvFileButton.Click += new System.EventHandler(this.OnLoadCsvFileButtonClick);
			// 
			// csvReplacementsCheckedListBox
			// 
			this.csvReplacementsCheckedListBox.CheckOnClick = true;
			this.mainTableLayoutPanel.SetColumnSpan(this.csvReplacementsCheckedListBox, 2);
			this.csvReplacementsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.csvReplacementsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.csvReplacementsCheckedListBox.FormattingEnabled = true;
			this.csvReplacementsCheckedListBox.IntegralHeight = false;
			this.csvReplacementsCheckedListBox.Location = new System.Drawing.Point(3, 246);
			this.csvReplacementsCheckedListBox.Name = "csvReplacementsCheckedListBox";
			this.csvReplacementsCheckedListBox.Size = new System.Drawing.Size(328, 117);
			this.csvReplacementsCheckedListBox.Sorted = true;
			this.csvReplacementsCheckedListBox.TabIndex = 6;
			// 
			// replaceButton
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.replaceButton, 2);
			this.replaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.replaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.replaceButton.ForeColor = System.Drawing.Color.Red;
			this.replaceButton.Location = new System.Drawing.Point(3, 369);
			this.replaceButton.Name = "replaceButton";
			this.replaceButton.Size = new System.Drawing.Size(328, 44);
			this.replaceButton.TabIndex = 7;
			this.replaceButton.Text = "&REPLACE";
			this.replaceButton.UseVisualStyleBackColor = true;
			this.replaceButton.Click += new System.EventHandler(this.OnReplaceButtonClick);
			// 
			// csvFileOpenFileDialog
			// 
			this.csvFileOpenFileDialog.DefaultExt = "csv";
			this.csvFileOpenFileDialog.Filter = "CSV Files|*.csv|All files (*.*)|*.*";
			// 
			// checkOnAddToolStripMenuItem
			// 
			this.checkOnAddToolStripMenuItem.Checked = true;
			this.checkOnAddToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkOnAddToolStripMenuItem.Name = "checkOnAddToolStripMenuItem";
			this.checkOnAddToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.checkOnAddToolStripMenuItem.Text = "&Check on add";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 462);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CSVreplace";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem checkOnAddToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.ToolStripMenuItem backupNoReplaceToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog csvFileOpenFileDialog;
	}
}
