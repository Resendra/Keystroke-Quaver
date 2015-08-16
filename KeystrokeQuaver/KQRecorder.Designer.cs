namespace KeystrokeQuaver
{
    partial class KQRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KQRecorder));
            this.recordButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.keystrokeName = new System.Windows.Forms.TextBox();
            this.lastKeyStrokeLabel = new System.Windows.Forms.Label();
            this.pressedWhileLabel = new System.Windows.Forms.Label();
            this.pressedWhileTextBox = new System.Windows.Forms.TextBox();
            this.keystrokeLogTextBox = new System.Windows.Forms.TextBox();
            this.keystrokeLogLabel = new System.Windows.Forms.Label();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.KQRecorderMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordElapsedTimeLabel = new System.Windows.Forms.Label();
            this.recordElapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.eraseElapsedTimeButton = new System.Windows.Forms.Button();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KQRecorderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(98, 251);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 23);
            this.recordButton.TabIndex = 0;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(179, 251);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // keystrokeName
            // 
            this.keystrokeName.Location = new System.Drawing.Point(123, 37);
            this.keystrokeName.Name = "keystrokeName";
            this.keystrokeName.ReadOnly = true;
            this.keystrokeName.Size = new System.Drawing.Size(131, 20);
            this.keystrokeName.TabIndex = 3;
            // 
            // lastKeyStrokeLabel
            // 
            this.lastKeyStrokeLabel.AutoSize = true;
            this.lastKeyStrokeLabel.Location = new System.Drawing.Point(26, 40);
            this.lastKeyStrokeLabel.Name = "lastKeyStrokeLabel";
            this.lastKeyStrokeLabel.Size = new System.Drawing.Size(91, 13);
            this.lastKeyStrokeLabel.TabIndex = 4;
            this.lastKeyStrokeLabel.Text = "Last Key Stroke : ";
            // 
            // pressedWhileLabel
            // 
            this.pressedWhileLabel.AutoSize = true;
            this.pressedWhileLabel.Location = new System.Drawing.Point(26, 69);
            this.pressedWhileLabel.Name = "pressedWhileLabel";
            this.pressedWhileLabel.Size = new System.Drawing.Size(81, 13);
            this.pressedWhileLabel.TabIndex = 5;
            this.pressedWhileLabel.Text = "Pressed while : ";
            // 
            // pressedWhileTextBox
            // 
            this.pressedWhileTextBox.Location = new System.Drawing.Point(123, 66);
            this.pressedWhileTextBox.Name = "pressedWhileTextBox";
            this.pressedWhileTextBox.ReadOnly = true;
            this.pressedWhileTextBox.Size = new System.Drawing.Size(131, 20);
            this.pressedWhileTextBox.TabIndex = 6;
            // 
            // keystrokeLogTextBox
            // 
            this.keystrokeLogTextBox.Location = new System.Drawing.Point(29, 124);
            this.keystrokeLogTextBox.Multiline = true;
            this.keystrokeLogTextBox.Name = "keystrokeLogTextBox";
            this.keystrokeLogTextBox.ReadOnly = true;
            this.keystrokeLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keystrokeLogTextBox.Size = new System.Drawing.Size(225, 92);
            this.keystrokeLogTextBox.TabIndex = 7;
            // 
            // keystrokeLogLabel
            // 
            this.keystrokeLogLabel.AutoSize = true;
            this.keystrokeLogLabel.Location = new System.Drawing.Point(26, 108);
            this.keystrokeLogLabel.Name = "keystrokeLogLabel";
            this.keystrokeLogLabel.Size = new System.Drawing.Size(89, 13);
            this.keystrokeLogLabel.TabIndex = 8;
            this.keystrokeLogLabel.Text = "Keystrokes Log : ";
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(179, 222);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 9;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // KQRecorderMenu
            // 
            this.KQRecorderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.KQRecorderMenu.Location = new System.Drawing.Point(0, 0);
            this.KQRecorderMenu.Name = "KQRecorderMenu";
            this.KQRecorderMenu.Size = new System.Drawing.Size(284, 24);
            this.KQRecorderMenu.TabIndex = 11;
            this.KQRecorderMenu.Text = "KQRecorderMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogsToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveLogsToolStripMenuItem
            // 
            this.saveLogsToolStripMenuItem.Name = "saveLogsToolStripMenuItem";
            this.saveLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveLogsToolStripMenuItem.Text = "Save logs";
            this.saveLogsToolStripMenuItem.Click += new System.EventHandler(this.saveLogsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeysToolStripMenuItem});
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Visible = false;
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click);
            // 
            // recordElapsedTimeLabel
            // 
            this.recordElapsedTimeLabel.AutoSize = true;
            this.recordElapsedTimeLabel.Location = new System.Drawing.Point(37, 286);
            this.recordElapsedTimeLabel.Name = "recordElapsedTimeLabel";
            this.recordElapsedTimeLabel.Size = new System.Drawing.Size(80, 13);
            this.recordElapsedTimeLabel.TabIndex = 12;
            this.recordElapsedTimeLabel.Text = "Elapsed Time : ";
            // 
            // recordElapsedTimeTextBox
            // 
            this.recordElapsedTimeTextBox.Location = new System.Drawing.Point(123, 283);
            this.recordElapsedTimeTextBox.Name = "recordElapsedTimeTextBox";
            this.recordElapsedTimeTextBox.ReadOnly = true;
            this.recordElapsedTimeTextBox.Size = new System.Drawing.Size(86, 20);
            this.recordElapsedTimeTextBox.TabIndex = 13;
            // 
            // eraseElapsedTimeButton
            // 
            this.eraseElapsedTimeButton.BackgroundImage = global::KeystrokeQuaver.Properties.Resources.action_Cancel_16xMD;
            this.eraseElapsedTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eraseElapsedTimeButton.Location = new System.Drawing.Point(215, 281);
            this.eraseElapsedTimeButton.Name = "eraseElapsedTimeButton";
            this.eraseElapsedTimeButton.Size = new System.Drawing.Size(39, 23);
            this.eraseElapsedTimeButton.TabIndex = 14;
            this.eraseElapsedTimeButton.UseVisualStyleBackColor = true;
            this.eraseElapsedTimeButton.Click += new System.EventHandler(this.eraseElapsedTimeButton_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVFileToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportToCSVFileToolStripMenuItem
            // 
            this.exportToCSVFileToolStripMenuItem.Name = "exportToCSVFileToolStripMenuItem";
            this.exportToCSVFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exportToCSVFileToolStripMenuItem.Text = "Export to CSV file";
            this.exportToCSVFileToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVFileToolStripMenuItem_Click);
            // 
            // KQRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.eraseElapsedTimeButton);
            this.Controls.Add(this.recordElapsedTimeTextBox);
            this.Controls.Add(this.recordElapsedTimeLabel);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.keystrokeLogLabel);
            this.Controls.Add(this.keystrokeLogTextBox);
            this.Controls.Add(this.pressedWhileTextBox);
            this.Controls.Add(this.pressedWhileLabel);
            this.Controls.Add(this.lastKeyStrokeLabel);
            this.Controls.Add(this.keystrokeName);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.KQRecorderMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.KQRecorderMenu;
            this.MaximizeBox = false;
            this.Name = "KQRecorder";
            this.Text = "Keystroke Quaver Recorder";
            this.KQRecorderMenu.ResumeLayout(false);
            this.KQRecorderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox keystrokeName;
        private System.Windows.Forms.Label lastKeyStrokeLabel;
        private System.Windows.Forms.Label pressedWhileLabel;
        private System.Windows.Forms.TextBox pressedWhileTextBox;
        private System.Windows.Forms.TextBox keystrokeLogTextBox;
        private System.Windows.Forms.Label keystrokeLogLabel;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.MenuStrip KQRecorderMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.Label recordElapsedTimeLabel;
        private System.Windows.Forms.TextBox recordElapsedTimeTextBox;
        private System.Windows.Forms.Button eraseElapsedTimeButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVFileToolStripMenuItem;
    }
}

