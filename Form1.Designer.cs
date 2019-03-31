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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOSD = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.sliderVol = new System.Windows.Forms.TrackBar();
            this.tmrPoll = new System.Windows.Forms.Timer(this.components);
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.imgPower = new System.Windows.Forms.PictureBox();
            this.imgMute = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMute)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblOSD
            // 
            this.lblOSD.BackColor = System.Drawing.Color.Transparent;
            this.lblOSD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOSD.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSD.ForeColor = System.Drawing.Color.White;
            this.lblOSD.Location = new System.Drawing.Point(0, 0);
            this.lblOSD.Name = "lblOSD";
            this.lblOSD.Size = new System.Drawing.Size(335, 53);
            this.lblOSD.TabIndex = 27;
            this.lblOSD.Text = "HAVolume\r\nCyanlabs 2019";
            this.lblOSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOSD.UseMnemonic = false;
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.ForeColor = System.Drawing.Color.White;
            this.lblVol.Location = new System.Drawing.Point(284, 50);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(49, 30);
            this.lblVol.TabIndex = 29;
            this.lblVol.Text = "100";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sliderVol
            // 
            this.sliderVol.AutoSize = false;
            this.sliderVol.Location = new System.Drawing.Point(50, 58);
            this.sliderVol.Maximum = 100;
            this.sliderVol.Name = "sliderVol";
            this.sliderVol.Size = new System.Drawing.Size(233, 23);
            this.sliderVol.SmallChange = 2;
            this.sliderVol.TabIndex = 30;
            this.sliderVol.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tmrPoll
            // 
            this.tmrPoll.Enabled = true;
            this.tmrPoll.Interval = 3000;
            this.tmrPoll.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgInput
            // 
            this.imgInput.BackColor = System.Drawing.Color.Transparent;
            this.imgInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgInput.Image = global::HA_Volume.Properties.Resources.input;
            this.imgInput.Location = new System.Drawing.Point(284, 3);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(20, 20);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgInput.TabIndex = 26;
            this.imgInput.TabStop = false;
            // 
            // imgPower
            // 
            this.imgPower.BackColor = System.Drawing.Color.Transparent;
            this.imgPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPower.Image = global::HA_Volume.Properties.Resources.off;
            this.imgPower.Location = new System.Drawing.Point(310, 3);
            this.imgPower.Name = "imgPower";
            this.imgPower.Size = new System.Drawing.Size(20, 20);
            this.imgPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPower.TabIndex = 31;
            this.imgPower.TabStop = false;
            // 
            // imgMute
            // 
            this.imgMute.BackColor = System.Drawing.Color.Transparent;
            this.imgMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMute.Image = ((System.Drawing.Image)(resources.GetObject("imgMute.Image")));
            this.imgMute.Location = new System.Drawing.Point(12, 49);
            this.imgMute.Name = "imgMute";
            this.imgMute.Size = new System.Drawing.Size(32, 32);
            this.imgMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMute.TabIndex = 28;
            this.imgMute.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(13, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(335, 90);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.imgPower);
            this.Controls.Add(this.sliderVol);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.imgMute);
            this.Controls.Add(this.lblOSD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal System.Windows.Forms.PictureBox imgInput;
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.Label lblOSD;
        internal System.Windows.Forms.PictureBox imgMute;
        internal System.Windows.Forms.Label lblVol;
        internal System.Windows.Forms.TrackBar sliderVol;
        internal System.Windows.Forms.PictureBox imgPower;
        private System.Windows.Forms.Timer tmrPoll;
        private System.Windows.Forms.Button button1;
    }
}

