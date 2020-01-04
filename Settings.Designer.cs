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
            this.lblPoll10 = new System.Windows.Forms.Label();
            this.lblPoll1 = new System.Windows.Forms.Label();
            this.trackPoll = new System.Windows.Forms.TrackBar();
            this.cmbEntity = new System.Windows.Forms.ComboBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblPoll = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkOSD = new System.Windows.Forms.CheckBox();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.cmbMonitor = new System.Windows.Forms.ComboBox();
            this.chkKeybinds = new System.Windows.Forms.CheckBox();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblApplicationStop = new System.Windows.Forms.Label();
            this.lblApplicationStart = new System.Windows.Forms.Label();
            this.grpAutomation = new System.Windows.Forms.GroupBox();
            this.grpTurnOff = new System.Windows.Forms.GroupBox();
            this.cmbApplicationStop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOffSource = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkAutoOff = new System.Windows.Forms.CheckBox();
            this.grpTurnOn = new System.Windows.Forms.GroupBox();
            this.txtExtraApplicationArgs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtExtraApplication = new System.Windows.Forms.TextBox();
            this.lblExtraApplicationStart = new System.Windows.Forms.Label();
            this.cmbApplicationStart = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbOnSource = new System.Windows.Forms.ComboBox();
            this.chkAutoOn = new System.Windows.Forms.CheckBox();
            this.grpHA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.grpGeneral.SuspendLayout();
            this.grpAutomation.SuspendLayout();
            this.grpTurnOff.SuspendLayout();
            this.grpTurnOn.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(760, 71);
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
            this.grpHA.Size = new System.Drawing.Size(360, 173);
            this.grpHA.TabIndex = 30;
            this.grpHA.TabStop = false;
            this.grpHA.Text = "Home Assistant Settings";
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
            // lblPoll1
            // 
            this.lblPoll1.AutoSize = true;
            this.lblPoll1.Location = new System.Drawing.Point(93, 142);
            this.lblPoll1.Name = "lblPoll1";
            this.lblPoll1.Size = new System.Drawing.Size(53, 13);
            this.lblPoll1.TabIndex = 4;
            this.lblPoll1.Text = "1 Second";
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
            this.txtURL.Leave += new System.EventHandler(this.txtURL_Leave);
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
            this.lblToken.Location = new System.Drawing.Point(10, 53);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(79, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Access Token:";
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
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.chkStartup);
            this.grpGeneral.Controls.Add(this.chkShutdown);
            this.grpGeneral.Controls.Add(this.chkUpdate);
            this.grpGeneral.Controls.Add(this.chkOSD);
            this.grpGeneral.Controls.Add(this.chkMute);
            this.grpGeneral.Controls.Add(this.cmbMonitor);
            this.grpGeneral.Controls.Add(this.chkKeybinds);
            this.grpGeneral.Controls.Add(this.lblMonitor);
            this.grpGeneral.Location = new System.Drawing.Point(12, 266);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(360, 124);
            this.grpGeneral.TabIndex = 31;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Settings";
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Checked = global::HA_Volume.Properties.Settings.Default.StartWithWindows;
            this.chkStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "StartWithWindows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkStartup.Location = new System.Drawing.Point(12, 22);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(117, 17);
            this.chkStartup.TabIndex = 5;
            this.chkStartup.Text = "Start with Windows";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.Checked = global::HA_Volume.Properties.Settings.Default.ShutdownResume;
            this.chkShutdown.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "ShutdownResume", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShutdown.Location = new System.Drawing.Point(169, 68);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(176, 17);
            this.chkShutdown.TabIndex = 12;
            this.chkShutdown.Text = "Detect PC Shutdown / Resume";
            this.chkShutdown.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Checked = global::HA_Volume.Properties.Settings.Default.Update;
            this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "Update", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUpdate.Location = new System.Drawing.Point(12, 68);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(144, 17);
            this.chkUpdate.TabIndex = 7;
            this.chkUpdate.Text = "Enable automatic update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkOSD
            // 
            this.chkOSD.AutoSize = true;
            this.chkOSD.Checked = global::HA_Volume.Properties.Settings.Default.OSD;
            this.chkOSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOSD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "OSD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkOSD.Location = new System.Drawing.Point(12, 45);
            this.chkOSD.Name = "chkOSD";
            this.chkOSD.Size = new System.Drawing.Size(142, 17);
            this.chkOSD.TabIndex = 14;
            this.chkOSD.Text = "Automatically show OSD";
            this.chkOSD.UseVisualStyleBackColor = true;
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Checked = global::HA_Volume.Properties.Settings.Default.DisableMute;
            this.chkMute.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "DisableMute", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMute.Location = new System.Drawing.Point(169, 45);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(129, 17);
            this.chkMute.TabIndex = 13;
            this.chkMute.Text = "Disable Mute Keybind";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // cmbMonitor
            // 
            this.cmbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonitor.FormattingEnabled = true;
            this.cmbMonitor.Location = new System.Drawing.Point(197, 92);
            this.cmbMonitor.Name = "cmbMonitor";
            this.cmbMonitor.Size = new System.Drawing.Size(48, 21);
            this.cmbMonitor.TabIndex = 9;
            this.cmbMonitor.SelectedIndexChanged += new System.EventHandler(this.cmbMonitor_SelectedIndexChanged);
            // 
            // chkKeybinds
            // 
            this.chkKeybinds.AutoSize = true;
            this.chkKeybinds.Checked = global::HA_Volume.Properties.Settings.Default.Keybinds;
            this.chkKeybinds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeybinds.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "Keybinds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkKeybinds.Location = new System.Drawing.Point(169, 22);
            this.chkKeybinds.Name = "chkKeybinds";
            this.chkKeybinds.Size = new System.Drawing.Size(104, 17);
            this.chkKeybinds.TabIndex = 6;
            this.chkKeybinds.Text = "Enable keybinds";
            this.chkKeybinds.UseVisualStyleBackColor = true;
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(84, 96);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(114, 13);
            this.lblMonitor.TabIndex = 5;
            this.lblMonitor.Text = "Monitor to show OSD: ";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(17, 74);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 9;
            this.lblSource.Text = "Source:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.LinkArea = new System.Windows.Forms.LinkArea(11, 8);
            this.lblCopyright.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblCopyright.Location = new System.Drawing.Point(11, 438);
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
            this.lblVersion.Location = new System.Drawing.Point(664, 438);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 13);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblApplicationStop
            // 
            this.lblApplicationStop.AutoSize = true;
            this.lblApplicationStop.Location = new System.Drawing.Point(17, 102);
            this.lblApplicationStop.Name = "lblApplicationStop";
            this.lblApplicationStop.Size = new System.Drawing.Size(143, 13);
            this.lblApplicationStop.TabIndex = 1;
            this.lblApplicationStop.Text = "Additional switch to turn off:  ";
            // 
            // lblApplicationStart
            // 
            this.lblApplicationStart.AutoSize = true;
            this.lblApplicationStart.Location = new System.Drawing.Point(17, 102);
            this.lblApplicationStart.Name = "lblApplicationStart";
            this.lblApplicationStart.Size = new System.Drawing.Size(140, 13);
            this.lblApplicationStart.TabIndex = 1;
            this.lblApplicationStart.Text = "Additional switch to turn on: \r\n";
            // 
            // grpAutomation
            // 
            this.grpAutomation.Controls.Add(this.grpTurnOff);
            this.grpAutomation.Controls.Add(this.grpTurnOn);
            this.grpAutomation.Location = new System.Drawing.Point(378, 87);
            this.grpAutomation.Name = "grpAutomation";
            this.grpAutomation.Size = new System.Drawing.Size(332, 354);
            this.grpAutomation.TabIndex = 33;
            this.grpAutomation.TabStop = false;
            this.grpAutomation.Text = "Automation Settings";
            // 
            // grpTurnOff
            // 
            this.grpTurnOff.Controls.Add(this.cmbApplicationStop);
            this.grpTurnOff.Controls.Add(this.label2);
            this.grpTurnOff.Controls.Add(this.lblApplicationStop);
            this.grpTurnOff.Controls.Add(this.cmbOffSource);
            this.grpTurnOff.Controls.Add(this.checkBox2);
            this.grpTurnOff.Controls.Add(this.chkAutoOff);
            this.grpTurnOff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTurnOff.Location = new System.Drawing.Point(3, 226);
            this.grpTurnOff.Name = "grpTurnOff";
            this.grpTurnOff.Size = new System.Drawing.Size(326, 125);
            this.grpTurnOff.TabIndex = 1;
            this.grpTurnOff.TabStop = false;
            this.grpTurnOff.Text = "On Exit/Shutdown";
            // 
            // cmbApplicationStop
            // 
            this.cmbApplicationStop.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "StopSwitch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbApplicationStop.FormattingEnabled = true;
            this.cmbApplicationStop.Location = new System.Drawing.Point(153, 98);
            this.cmbApplicationStop.Name = "cmbApplicationStop";
            this.cmbApplicationStop.Size = new System.Drawing.Size(165, 21);
            this.cmbApplicationStop.TabIndex = 4;
            this.cmbApplicationStop.Text = global::HA_Volume.Properties.Settings.Default.StopSwitch;
            this.cmbApplicationStop.Click += new System.EventHandler(this.cmbApplicationStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Source:";
            // 
            // cmbOffSource
            // 
            this.cmbOffSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "OffInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbOffSource.FormattingEnabled = true;
            this.cmbOffSource.Location = new System.Drawing.Point(67, 71);
            this.cmbOffSource.Name = "cmbOffSource";
            this.cmbOffSource.Size = new System.Drawing.Size(251, 21);
            this.cmbOffSource.TabIndex = 16;
            this.cmbOffSource.Text = global::HA_Volume.Properties.Settings.Default.OffInput;
            this.cmbOffSource.Click += new System.EventHandler(this.cmbOffSource_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::HA_Volume.Properties.Settings.Default.AutoOffSource;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "AutoOffSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(19, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(271, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Automatically switch \'media_player\' to below source ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkAutoOff
            // 
            this.chkAutoOff.AutoSize = true;
            this.chkAutoOff.Checked = global::HA_Volume.Properties.Settings.Default.AutoOff;
            this.chkAutoOff.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "AutoOff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoOff.Location = new System.Drawing.Point(19, 25);
            this.chkAutoOff.Name = "chkAutoOff";
            this.chkAutoOff.Size = new System.Drawing.Size(230, 17);
            this.chkAutoOff.TabIndex = 11;
            this.chkAutoOff.Text = "Switch off \'media_player\' on application exit";
            this.chkAutoOff.UseVisualStyleBackColor = true;
            // 
            // grpTurnOn
            // 
            this.grpTurnOn.Controls.Add(this.txtExtraApplicationArgs);
            this.grpTurnOn.Controls.Add(this.button1);
            this.grpTurnOn.Controls.Add(this.txtExtraApplication);
            this.grpTurnOn.Controls.Add(this.lblExtraApplicationStart);
            this.grpTurnOn.Controls.Add(this.lblSource);
            this.grpTurnOn.Controls.Add(this.cmbApplicationStart);
            this.grpTurnOn.Controls.Add(this.checkBox1);
            this.grpTurnOn.Controls.Add(this.cmbOnSource);
            this.grpTurnOn.Controls.Add(this.lblApplicationStart);
            this.grpTurnOn.Controls.Add(this.chkAutoOn);
            this.grpTurnOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTurnOn.Location = new System.Drawing.Point(3, 16);
            this.grpTurnOn.Name = "grpTurnOn";
            this.grpTurnOn.Size = new System.Drawing.Size(326, 204);
            this.grpTurnOn.TabIndex = 0;
            this.grpTurnOn.TabStop = false;
            this.grpTurnOn.Text = "On Launch/Startup";
            // 
            // txtExtraApplicationArgs
            // 
            this.txtExtraApplicationArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "ExtraApplicationArgs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtraApplicationArgs.Location = new System.Drawing.Point(19, 178);
            this.txtExtraApplicationArgs.Name = "txtExtraApplicationArgs";
            this.txtExtraApplicationArgs.Size = new System.Drawing.Size(299, 20);
            this.txtExtraApplicationArgs.TabIndex = 103;
            this.txtExtraApplicationArgs.Text = global::HA_Volume.Properties.Settings.Default.ExtraApplicationArgs;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 24);
            this.button1.TabIndex = 102;
            this.button1.Text = "Select application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExtraApplication
            // 
            this.txtExtraApplication.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "ExtraApplication", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtraApplication.Location = new System.Drawing.Point(19, 153);
            this.txtExtraApplication.Name = "txtExtraApplication";
            this.txtExtraApplication.ReadOnly = true;
            this.txtExtraApplication.Size = new System.Drawing.Size(299, 20);
            this.txtExtraApplication.TabIndex = 101;
            this.txtExtraApplication.Text = global::HA_Volume.Properties.Settings.Default.ExtraApplication;
            // 
            // lblExtraApplicationStart
            // 
            this.lblExtraApplicationStart.AutoSize = true;
            this.lblExtraApplicationStart.Location = new System.Drawing.Point(19, 132);
            this.lblExtraApplicationStart.Name = "lblExtraApplicationStart";
            this.lblExtraApplicationStart.Size = new System.Drawing.Size(137, 13);
            this.lblExtraApplicationStart.TabIndex = 16;
            this.lblExtraApplicationStart.Text = "Start additional application: ";
            // 
            // cmbApplicationStart
            // 
            this.cmbApplicationStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "StartSwitch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbApplicationStart.FormattingEnabled = true;
            this.cmbApplicationStart.Location = new System.Drawing.Point(153, 98);
            this.cmbApplicationStart.Name = "cmbApplicationStart";
            this.cmbApplicationStart.Size = new System.Drawing.Size(165, 21);
            this.cmbApplicationStart.TabIndex = 4;
            this.cmbApplicationStart.Text = global::HA_Volume.Properties.Settings.Default.StartSwitch;
            this.cmbApplicationStart.SelectedIndexChanged += new System.EventHandler(this.cmbApplicationStart_SelectedIndexChanged);
            this.cmbApplicationStart.Click += new System.EventHandler(this.cmbApplicationStart_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::HA_Volume.Properties.Settings.Default.AutoOnSource;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "AutoOnSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(19, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(271, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Automatically switch \'media_player\' to below source ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbOnSource
            // 
            this.cmbOnSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HA_Volume.Properties.Settings.Default, "OnInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbOnSource.FormattingEnabled = true;
            this.cmbOnSource.Location = new System.Drawing.Point(67, 71);
            this.cmbOnSource.Name = "cmbOnSource";
            this.cmbOnSource.Size = new System.Drawing.Size(251, 21);
            this.cmbOnSource.TabIndex = 8;
            this.cmbOnSource.Text = global::HA_Volume.Properties.Settings.Default.OnInput;
            this.cmbOnSource.Click += new System.EventHandler(this.cmbOnSource_Click);
            // 
            // chkAutoOn
            // 
            this.chkAutoOn.AutoSize = true;
            this.chkAutoOn.Checked = global::HA_Volume.Properties.Settings.Default.AutoOn;
            this.chkAutoOn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::HA_Volume.Properties.Settings.Default, "AutoOn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoOn.Location = new System.Drawing.Point(19, 25);
            this.chkAutoOn.Name = "chkAutoOn";
            this.chkAutoOn.Size = new System.Drawing.Size(234, 17);
            this.chkAutoOn.TabIndex = 10;
            this.chkAutoOn.Text = "Switch on \'media_player\' on application start";
            this.chkAutoOn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 453);
            this.Controls.Add(this.grpAutomation);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackPoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAutomation.ResumeLayout(false);
            this.grpTurnOff.ResumeLayout(false);
            this.grpTurnOff.PerformLayout();
            this.grpTurnOn.ResumeLayout(false);
            this.grpTurnOn.PerformLayout();
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
        internal System.Windows.Forms.ComboBox cmbOnSource;
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
        private System.Windows.Forms.Label lblApplicationStop;
        private System.Windows.Forms.Label lblApplicationStart;
        private System.Windows.Forms.ComboBox cmbApplicationStop;
        private System.Windows.Forms.ComboBox cmbApplicationStart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpAutomation;
        private System.Windows.Forms.GroupBox grpTurnOff;
        private System.Windows.Forms.GroupBox grpTurnOn;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbOffSource;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtExtraApplication;
        private System.Windows.Forms.Label lblExtraApplicationStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtExtraApplicationArgs;
    }
}