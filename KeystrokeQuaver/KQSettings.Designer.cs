namespace KeystrokeQuaver
{
    partial class KQSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KQSettings));
            this.recordHotkeyComboBox = new System.Windows.Forms.ComboBox();
            this.recordHotkeyLabel = new System.Windows.Forms.Label();
            this.recordHotkey = new System.Windows.Forms.TextBox();
            this.recordHotkeyListenerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordHotkeyComboBox
            // 
            this.recordHotkeyComboBox.FormattingEnabled = true;
            this.recordHotkeyComboBox.Location = new System.Drawing.Point(133, 12);
            this.recordHotkeyComboBox.Name = "recordHotkeyComboBox";
            this.recordHotkeyComboBox.Size = new System.Drawing.Size(121, 21);
            this.recordHotkeyComboBox.TabIndex = 0;
            // 
            // recordHotkeyLabel
            // 
            this.recordHotkeyLabel.AutoSize = true;
            this.recordHotkeyLabel.Location = new System.Drawing.Point(32, 15);
            this.recordHotkeyLabel.Name = "recordHotkeyLabel";
            this.recordHotkeyLabel.Size = new System.Drawing.Size(95, 13);
            this.recordHotkeyLabel.TabIndex = 1;
            this.recordHotkeyLabel.Text = "\"Record\" Hotkey :";
            // 
            // recordHotkey
            // 
            this.recordHotkey.Location = new System.Drawing.Point(133, 39);
            this.recordHotkey.Name = "recordHotkey";
            this.recordHotkey.ReadOnly = true;
            this.recordHotkey.Size = new System.Drawing.Size(121, 20);
            this.recordHotkey.TabIndex = 2;
            // 
            // recordHotkeyListenerButton
            // 
            this.recordHotkeyListenerButton.Location = new System.Drawing.Point(179, 65);
            this.recordHotkeyListenerButton.Name = "recordHotkeyListenerButton";
            this.recordHotkeyListenerButton.Size = new System.Drawing.Size(75, 23);
            this.recordHotkeyListenerButton.TabIndex = 3;
            this.recordHotkeyListenerButton.Text = "Enter hotkey";
            this.recordHotkeyListenerButton.UseVisualStyleBackColor = true;
            this.recordHotkeyListenerButton.Click += new System.EventHandler(this.recordHotkeyListenerButton_Click);
            // 
            // KQSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.recordHotkeyListenerButton);
            this.Controls.Add(this.recordHotkey);
            this.Controls.Add(this.recordHotkeyLabel);
            this.Controls.Add(this.recordHotkeyComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KQSettings";
            this.Text = "Keystroke Quaver Settings";
            this.Load += new System.EventHandler(this.KQSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox recordHotkeyComboBox;
        private System.Windows.Forms.Label recordHotkeyLabel;
        private System.Windows.Forms.TextBox recordHotkey;
        private System.Windows.Forms.Button recordHotkeyListenerButton;
    }
}