namespace HA_Volume { 

    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblOSD = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.sliderVol = new System.Windows.Forms.TrackBar();
            this.tmrPoll = new System.Windows.Forms.Timer(this.components);
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.imgPower = new System.Windows.Forms.PictureBox();
            this.imgMute = new System.Windows.Forms.PictureBox();
            this.ntfyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForupdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSources = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMute)).BeginInit();
            this.contextMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOSD
            // 
            this.lblOSD.BackColor = System.Drawing.Color.Transparent;
            this.lblOSD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSD.ForeColor = System.Drawing.Color.White;
            this.lblOSD.Location = new System.Drawing.Point(0, 9);
            this.lblOSD.Name = "lblOSD";
            this.lblOSD.Size = new System.Drawing.Size(334, 55);
            this.lblOSD.TabIndex = 27;
            this.lblOSD.Text = "HA Volume";
            this.lblOSD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOSD.UseMnemonic = false;
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.ForeColor = System.Drawing.Color.White;
            this.lblVol.Location = new System.Drawing.Point(239, 56);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(67, 30);
            this.lblVol.TabIndex = 29;
            this.lblVol.Text = "100%";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderVol
            // 
            this.sliderVol.AutoSize = false;
            this.sliderVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderVol.Location = new System.Drawing.Point(31, 63);
            this.sliderVol.Maximum = 100;
            this.sliderVol.Name = "sliderVol";
            this.sliderVol.Size = new System.Drawing.Size(214, 23);
            this.sliderVol.SmallChange = 2;
            this.sliderVol.TabIndex = 30;
            this.sliderVol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderVol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderVol_MouseDown);
            this.sliderVol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderVol_MouseUp);
            // 
            // tmrPoll
            // 
            this.tmrPoll.Interval = 2000;
            this.tmrPoll.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgInput
            // 
            this.imgInput.BackColor = System.Drawing.Color.Transparent;
            this.imgInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgInput.Image = global::HA_Volume.Properties.Resources.input;
            this.imgInput.Location = new System.Drawing.Point(302, 60);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(26, 26);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgInput.TabIndex = 26;
            this.imgInput.TabStop = false;
            this.imgInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgInput_MouseClick);
            // 
            // imgPower
            // 
            this.imgPower.BackColor = System.Drawing.Color.Transparent;
            this.imgPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPower.Image = global::HA_Volume.Properties.Resources.off;
            this.imgPower.Location = new System.Drawing.Point(1, 2);
            this.imgPower.Name = "imgPower";
            this.imgPower.Size = new System.Drawing.Size(20, 20);
            this.imgPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPower.TabIndex = 31;
            this.imgPower.TabStop = false;
            this.imgPower.Click += new System.EventHandler(this.imgPower_Click);
            // 
            // imgMute
            // 
            this.imgMute.BackColor = System.Drawing.Color.Transparent;
            this.imgMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMute.Image = ((System.Drawing.Image)(resources.GetObject("imgMute.Image")));
            this.imgMute.Location = new System.Drawing.Point(6, 59);
            this.imgMute.Name = "imgMute";
            this.imgMute.Size = new System.Drawing.Size(28, 28);
            this.imgMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMute.TabIndex = 28;
            this.imgMute.TabStop = false;
            this.imgMute.Click += new System.EventHandler(this.imgMute_Click);
            // 
            // ntfyMain
            // 
            this.ntfyMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfyMain.BalloonTipText = "Click to exit";
            this.ntfyMain.BalloonTipTitle = "HA Volume";
            this.ntfyMain.ContextMenuStrip = this.contextMain;
            this.ntfyMain.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyMain.Icon")));
            this.ntfyMain.Text = "HA Volume";
            this.ntfyMain.Visible = true;
            this.ntfyMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfyMain_MouseClick);
            // 
            // contextMain
            // 
            this.contextMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourcesToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForupdatesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMain.Name = "contextMenuStrip1";
            this.contextMain.Size = new System.Drawing.Size(171, 104);
            // 
            // sourcesToolStripMenuItem
            // 
            this.sourcesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sourcesToolStripMenuItem.Text = "&Change Source";
            this.sourcesToolStripMenuItem.Click += new System.EventHandler(this.sourcesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // checkForupdatesToolStripMenuItem
            // 
            this.checkForupdatesToolStripMenuItem.Name = "checkForupdatesToolStripMenuItem";
            this.checkForupdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForupdatesToolStripMenuItem.Text = "Check for &updates";
            this.checkForupdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForupdatesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextSources
            // 
            this.contextSources.Name = "contextMenuStrip1";
            this.contextSources.Size = new System.Drawing.Size(61, 4);
            // 
            // lblHide
            // 
            this.lblHide.BackColor = System.Drawing.Color.Transparent;
            this.lblHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHide.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHide.ForeColor = System.Drawing.Color.White;
            this.lblHide.Location = new System.Drawing.Point(307, -26);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(30, 43);
            this.lblHide.TabIndex = 32;
            this.lblHide.Text = "_";
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(335, 90);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.imgPower);
            this.Controls.Add(this.sliderVol);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.imgMute);
            this.Controls.Add(this.lblOSD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMute)).EndInit();
            this.contextMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal System.Windows.Forms.PictureBox imgInput;
        internal System.Windows.Forms.Label lblOSD;
        internal System.Windows.Forms.PictureBox imgMute;
        internal System.Windows.Forms.Label lblVol;
        internal System.Windows.Forms.TrackBar sliderVol;
        internal System.Windows.Forms.PictureBox imgPower;
        private System.Windows.Forms.Timer tmrPoll;
        private System.Windows.Forms.NotifyIcon ntfyMain;
        private System.Windows.Forms.ContextMenuStrip contextMain;
        private System.Windows.Forms.ToolStripMenuItem checkForupdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextSources;
        private System.Windows.Forms.Label lblHide;
    }
}

