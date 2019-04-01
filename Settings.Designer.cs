namespace HA_Volume
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpHA = new System.Windows.Forms.GroupBox();
            this.lblEntity = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbMonitor = new System.Windows.Forms.ComboBox();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblPoll = new System.Windows.Forms.Label();
            this.lblPoll1 = new System.Windows.Forms.Label();
            this.lblPoll10 = new System.Windows.Forms.Label();
            this.chkOSD = new System.Windows.Forms.CheckBox();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.chkAutoOff = new System.Windows.Forms.CheckBox();
            this.chkAutoOn = new System.Windows.Forms.CheckBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkKeybinds = new System.Windows.Forms.CheckBox();
            this.trackPoll = new System.Windows.Forms.TrackBar();
            this.cmbEntity = new System.Windows.Forms.ComboBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.grpHA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPoll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 71);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "        HA Volume";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseMnemonic = false;
            // 
            // grpHA
            // 
            this.grpHA.Controls.Add(this.lblPoll10);
            this.grpHA.Controls.Add(this.lblPoll1);
            this.grpHA.Controls.Add(this.trackPoll);
            this.grpHA.Controls.Add(this.cmbEntity);
            this.grpHA.Controls.Add(this.txtToken);
            this.grpHA.Controls.Add(this.txtURL);
            this.grpHA.Controls.Add(this.lblPoll);
            this.grpHA.Controls.Add(this.lblEntity);
            this.grpHA.Controls.Add(this.lblToken);
            this.grpHA.Controls.Add(this.lblURL);
            this.grpHA.Location = new System.Drawing.Point(12, 87);
            this.grpHA.Name = "grpHA";
            this.grpHA.Size = new System.Drawing.Size(360, 160);
            this.grpHA.TabIndex = 30;
            this.grpHA.TabStop = false;
            this.grpHA.Text = "Home Assistant Settings";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(23, 79);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(67, 13);
            this.lblEntity.TabIndex = 0;
            this.lblEntity.Text = "Entity Name:";
            this.lblEntity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(15, 53);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(75, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Bearer Token:";
            this.lblToken.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(23, 26);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(66, 13);
            this.lblURL.TabIndex = 100;
            this.lblURL.Text = "HA Address:";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(13, 10);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(69, 69);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 29;
            this.imgLogo.TabStop = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.chkOSD);
            this.grpGeneral.Controls.Add(this.chkMute);
            this.grpGeneral.Controls.Add(this.chkShutdown);
            this.grpGeneral.Controls.Add(this.chkAutoOff);
            this.grpGeneral.Controls.Add(this.chkAutoOn);
            this.grpGeneral.Controls.Add(this.cmbSource);
            this.grpGeneral.Controls.Add(this.lblSource);
            this.grpGeneral.Controls.Add(this.chkStartup);
            this.grpGeneral.Controls.Add(this.chkUpdate);
            this.grpGeneral.Controls.Add(this.cmbMonitor);
            this.grpGeneral.Controls.Add(this.lblMonitor);
            this.grpGeneral.Controls.Add(this.chkKeybinds);
            this.grpGeneral.Location = new System.Drawing.Point(12, 253);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(360, 172);
            this.grpGeneral.TabIndex = 31;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Settings";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(9, 58);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(81, 13);
            this.lblSource.TabIndex = 9;
            this.lblSource.Text = "Default Source:";
            // 
            // cmbMonitor
            // 
            this.cmbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonitor.FormattingEnabled = true;
            this.cmbMonitor.Location = new System.Drawing.Point(311, 55);
            this.cmbMonitor.Name = "cmbMonitor";
            this.cmbMonitor.Size = new System.Drawing.Size(34, 21);
            this.cmbMonitor.TabIndex = 9;
            this.cmbMonitor.SelectedIndexChanged += new System.EventHandler(this.cmbMonitor_SelectedIndexChanged);
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(266, 58);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(48, 13);
            this.lblMonitor.TabIndex = 5;
            this.lblMonitor.Text = "Monitor: ";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.LinkArea = new System.Windows.Forms.LinkArea(11, 8);
            this.lblCopyright.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblCopyright.Location = new System.Drawing.Point(11, 442);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(302, 17);
            this.lblCopyright.TabIndex = 16;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "HAVolume © CyanLabs - Not affiliated with Home Assistant";
            this.lblCopyright.UseCompatibleTextRendering = true;
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(332, 442);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 13);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPoll
            // 
            this.lblPoll.AutoSize = true;
            this.lblPoll.Location = new System.Drawing.Point(11, 112);
            this.lblPoll.Name = "lblPoll";
            this.lblPoll.Size = new System.Drawing.Size(82, 13);
            this.lblPoll.TabIndex = 0;
            this.lblPoll.Text = "Polling Interval: ";
            this.lblPoll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPoll1
            // 
            this.lblPoll1.AutoSize = true;
            this.lblPoll1.Location = new System.Drawing.Point(93, 142);
            this.lblPoll1.Name = "lblPoll1";
            this.lblPoll1.Size = new System.Drawing.Size(53, 13);
            this.lblPoll1.TabIndex = 4;
            this.lblPoll1.Text = "1 Second";
            // 
            // lblPoll10
            // 
            this.lblPoll10.AutoSize = true;
            this.lblPoll10.Location = new System.Drawing.Point(290, 142);
            this.lblPoll10.Name = "lblPoll10";
            this.lblPoll10.Size = new System.Drawing.Size(64, 13);
            this.lblPoll10.TabIndex = 5;
            this.lblPoll10.Text = "10 Seconds";
            // 
            // chkOSD
            // 
            this.chkOSD.AutoSize = true;
            this.chkOSD.Checked = global::HA_Volume.Properties.Settings.Default.OSD;
            this.chkOSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOSD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "OSD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOSD.Location = new System.Drawing.Point(30, 143);
            this.chkOSD.Name = "chkOSD";
            this.chkOSD.Size = new System.Drawing.Size(293, 17);
            this.chkOSD.TabIndex = 14;
            this.chkOSD.Text = "Show OSD on updates (click tray icon to manually show)";
            this.chkOSD.UseVisualStyleBackColor = true;
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Checked = global::HA_Volume.Properties.Settings.Default.DisableMute;
            this.chkMute.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "DisableMute", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMute.Location = new System.Drawing.Point(200, 116);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(129, 17);
            this.chkMute.TabIndex = 13;
            this.chkMute.Text = "Disable Mute Keybind";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.Checked = global::HA_Volume.Properties.Settings.Default.ShutdownResume;
            this.chkShutdown.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "ShutdownResume", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShutdown.Location = new System.Drawing.Point(18, 116);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(176, 17);
            this.chkShutdown.TabIndex = 12;
            this.chkShutdown.Text = "Detect PC Shutdown / Resume";
            this.chkShutdown.UseVisualStyleBackColor = true;
            // 
            // chkAutoOff
            // 
            this.chkAutoOff.AutoSize = true;
            this.chkAutoOff.Checked = global::HA_Volume.Properties.Settings.Default.AutoOff;
            this.chkAutoOff.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "AutoOff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoOff.Location = new System.Drawing.Point(195, 88);
            this.chkAutoOff.Name = "chkAutoOff";
            this.chkAutoOff.Size = new System.Drawing.Size(150, 17);
            this.chkAutoOff.TabIndex = 11;
            this.chkAutoOff.Text = "Automatically turn off AMP";
            this.chkAutoOff.UseVisualStyleBackColor = true;
            // 
            // chkAutoOn
            // 
            this.chkAutoOn.AutoSize = true;
            this.chkAutoOn.Checked = global::HA_Volume.Properties.Settings.Default.AutoOn;
            this.chkAutoOn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "AutoOn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoOn.Location = new System.Drawing.Point(18, 88);
            this.chkAutoOn.Name = "chkAutoOn";
            this.chkAutoOn.Size = new System.Drawing.Size(150, 17);
            this.chkAutoOn.TabIndex = 10;
            this.chkAutoOn.Text = "Automatically turn on AMP";
            this.chkAutoOn.UseVisualStyleBackColor = true;
            // 
            // cmbSource
            // 
            this.cmbSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "DefaultInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(90, 55);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(163, 21);
            this.cmbSource.TabIndex = 8;
            this.cmbSource.Text = global::HA_Volume.Properties.Settings.Default.DefaultInput;
            this.cmbSource.Click += new System.EventHandler(this.cmbSource_Click);
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Checked = global::HA_Volume.Properties.Settings.Default.StartWithWindows;
            this.chkStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "StartWithWindows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkStartup.Location = new System.Drawing.Point(18, 28);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(117, 17);
            this.chkStartup.TabIndex = 5;
            this.chkStartup.Text = "Start with Windows";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Checked = global::HA_Volume.Properties.Settings.Default.Update;
            this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "Update", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUpdate.Location = new System.Drawing.Point(264, 28);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(81, 17);
            this.chkUpdate.TabIndex = 7;
            this.chkUpdate.Text = "Autoupdate";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkKeybinds
            // 
            this.chkKeybinds.AutoSize = true;
            this.chkKeybinds.Checked = global::HA_Volume.Properties.Settings.Default.Keybinds;
            this.chkKeybinds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeybinds.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "Keybinds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkKeybinds.Location = new System.Drawing.Point(142, 28);
            this.chkKeybinds.Name = "chkKeybinds";
            this.chkKeybinds.Size = new System.Drawing.Size(111, 17);
            this.chkKeybinds.TabIndex = 6;
            this.chkKeybinds.Text = "Activate Keybinds";
            this.chkKeybinds.UseVisualStyleBackColor = true;
            // 
            // trackPoll
            // 
            this.trackPoll.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::HA_Volume.Properties.Settings.Default, "PollRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackPoll.Location = new System.Drawing.Point(104, 108);
            this.trackPoll.Minimum = 1;
            this.trackPoll.Name = "trackPoll";
            this.trackPoll.Size = new System.Drawing.Size(234, 45);
            this.trackPoll.TabIndex = 4;
            this.trackPoll.Value = global::HA_Volume.Properties.Settings.Default.PollRate;
            // 
            // cmbEntity
            // 
            this.cmbEntity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "HAEntity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbEntity.FormattingEnabled = true;
            this.cmbEntity.Location = new System.Drawing.Point(96, 76);
            this.cmbEntity.Name = "cmbEntity";
            this.cmbEntity.Size = new System.Drawing.Size(249, 21);
            this.cmbEntity.TabIndex = 3;
            this.cmbEntity.Text = global::HA_Volume.Properties.Settings.Default.HAEntity;
            this.cmbEntity.Click += new System.EventHandler(this.cmbEntity_Click);
            // 
            // txtToken
            // 
            this.txtToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "HAToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtToken.Location = new System.Drawing.Point(96, 50);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(249, 20);
            this.txtToken.TabIndex = 2;
            this.txtToken.Text = global::HA_Volume.Properties.Settings.Default.HAToken;
            // 
            // txtURL
            // 
            this.txtURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "HAURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtURL.Location = new System.Drawing.Point(96, 23);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(249, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = global::HA_Volume.Properties.Settings.Default.HAURL;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpHA);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.grpHA.ResumeLayout(false);
            this.grpHA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.GroupBox grpHA;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.ComboBox cmbMonitor;
        internal System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.CheckBox chkKeybinds;
        private System.Windows.Forms.CheckBox chkOSD;
        private System.Windows.Forms.CheckBox chkShutdown;
        private System.Windows.Forms.CheckBox chkAutoOff;
        private System.Windows.Forms.CheckBox chkAutoOn;
        internal System.Windows.Forms.ComboBox cmbSource;
        internal System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.LinkLabel lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox cmbEntity;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Label lblPoll10;
        private System.Windows.Forms.Label lblPoll1;
        private System.Windows.Forms.TrackBar trackPoll;
        private System.Windows.Forms.Label lblPoll;
    }
}