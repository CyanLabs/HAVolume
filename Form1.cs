using System;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using System.Drawing;
using System.Diagnostics;

/* TODO 

    Add X/Y setting

 */

namespace HA_Volume
{
    public partial class Main : Form
    {
        dynamic HAData;
        dynamic PrevHAData;
        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        private IKeyboardMouseEvents _globalHook;
        public enum PowerModes { Resume = 1, StatusChange = 2, Suspend = 3 }

        public Main()
        {
            SystemEvents.PowerModeChanged += OnPowerModeChanged;
            InitializeComponent();
        }

        // keyboard hook handler
        private void _globalHook_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers != System.Windows.Forms.Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case System.Windows.Forms.Keys.VolumeUp:
                        e.Handled = true;
                        Task.Factory.StartNew(() => HAAPI.Volume_Up());
                        if (Properties.Settings.Default.OSD && this.Opacity == 0) Task.Factory.StartNew(() => ShowOSD());
                        break;

                    case System.Windows.Forms.Keys.VolumeDown:
                        e.Handled = true;
                        Task.Factory.StartNew(() => HAAPI.Volume_Down());
                        if (Properties.Settings.Default.OSD && this.Opacity == 0) Task.Factory.StartNew(() => ShowOSD());
                        break;

                    case System.Windows.Forms.Keys.VolumeMute:
                        e.Handled = true;
                        bool state = HAData["attributes"]["is_volume_muted"];
                        Task.Factory.StartNew(() => HAAPI.Volume_Mute(state));
                        break;

                    case System.Windows.Forms.Keys.Pause:
                        e.Handled = true;
                        if (e.Modifiers == System.Windows.Forms.Keys.Shift)
                        {
                            Task.Factory.StartNew(() => HAAPI.Set_Input());
                        }
                        else
                        {
                            Task.Factory.StartNew(() => HAAPI.Power());
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrevHAData = HAData;
            HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);
            // Update OSD
            if (HAData["attributes"].ContainsKey("source")) { lblOSD.Text = HAData["attributes"]["source"]; } else { lblOSD.Text = "Amp Powered Off!"; }

            // Update Power Icon
            if (HAData["state"] == "on") { this.imgPower.Image = Properties.Resources.on; } else { this.imgPower.Image = Properties.Resources.off; }

            // Update Mute Icon
            if (HAData["attributes"].ContainsKey("is_volume_muted"))
            {
                if (HAData["attributes"]["is_volume_muted"]) { this.imgMute.Image = Properties.Resources.mute; } else { this.imgMute.Image = Properties.Resources.vol; }
            }

            // Update Slider and Volume Label
            if (HAData["attributes"].ContainsKey("volume_level"))
            {
                int volaspercent = Convert.ToInt32(HAData["attributes"]["volume_level"] * 100);
                sliderVol.Value = volaspercent;
                lblVol.Text = volaspercent.ToString() + "%";
            }

            // Show OSD when change in volume or source detected
            if (Properties.Settings.Default.OSD && this.Opacity == 0) {
                //PrevHAData
                if(PrevHAData["attributes"]["source"] != HAData["attributes"]["source"])
                {
                    string temp1 = PrevHAData["attributes"]["source"];
                   string temp2 = HAData["attributes"]["source"];
                    Debug.WriteLine("Old Data: " + temp1);
                    Debug.WriteLine("New Data: " + temp2);
                    Task.Factory.StartNew(() => ShowOSD());
                } else if (PrevHAData["attributes"]["volume_level"] != HAData["attributes"]["volume_level"]) {
                    decimal temp1 = PrevHAData["attributes"]["volume_level"];
                    decimal temp2 = HAData["attributes"]["volume_level"];
                    Debug.WriteLine("Old Data: " + temp1);
                    Debug.WriteLine("New Data: " + temp2);
                    Task.Factory.StartNew(() => ShowOSD());
                }
            }
        }

        void ShowOSD()
        {
            this.Invoke((Action)(() => this.Opacity = 1));
            System.Threading.Thread.Sleep(5000);
            this.Invoke((Action)(() => this.Opacity = 0));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.HAURL))
            {
                Form SettingsForm = new Settings();
                SettingsForm.Show();
                this.Opacity = 0;
            } else {
                lblOSD.Text = "HA Volume - " + System.Windows.Forms.Application.ProductVersion;
                if (Properties.Settings.Default.Update) AutoUpdaterDotNET.AutoUpdater.Start("http://cyanlabs.net/raw/latest.php?product=" + System.Windows.Forms.Application.ProductName);
                tmrPoll.Interval = Properties.Settings.Default.PollRate * 1000;
                tmrPoll.Start();

                int x = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location.X + (Screen.AllScreens[Properties.Settings.Default.Monitor].WorkingArea.Width - this.Width);
                int y = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location.Y + (Screen.AllScreens[Properties.Settings.Default.Monitor].WorkingArea.Height - this.Height);
                Location = new Point(x, y);

                HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);

                _globalHook = Hook.GlobalEvents();

                HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);
                if (HAData["attributes"].ContainsKey("source_list"))
                {
                    foreach (string source in HAData["attributes"]["source_list"])
                    {
                        contextSources.Items.Add(source, null, contextsource);
                    }
                }

                if (Properties.Settings.Default.Keybinds) _globalHook.KeyDown += _globalHook_KeyDown;
            }            
        }

        void contextsource(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Set_Input(sender.ToString()));

        void StartupCommands()
        {
            if (Properties.Settings.Default.AutoOff)
            {
                if (HAData["state"] == "off") { Task.Factory.StartNew(() => HAAPI.Power()); }
            }
        }

        void ShutdownCommands()
        {
            if (Properties.Settings.Default.AutoOn)
            {
                if (HAData["state"] == "on") { Task.Factory.StartNew(() => HAAPI.Power()); }
            }

        }

        private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (Properties.Settings.Default.ShutdownResume)
            {
                switch (e.Mode)
                {
                    case Microsoft.Win32.PowerModes.Resume:
                        StartupCommands();
                        break;

                    case Microsoft.Win32.PowerModes.Suspend:
                        StartupCommands();
                        break;
                }
            }
        }

        private void checkForupdatesToolStripMenuItem_Click(object sender, EventArgs e) => AutoUpdaterDotNET.AutoUpdater.Start("http://cyanlabs.net/raw/latest.php?product=" + System.Windows.Forms.Application.ProductName);

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void imgMute_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Volume_Mute(HAData["attributes"]["is_volume_muted"]));

        private void imgInput_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Set_Input());

        private void imgPower_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Power());

        private void imgInput_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    contextSources.Show(this, imgInput.Location, ToolStripDropDownDirection.BelowRight);
                    break;

                case MouseButtons.Right:
                    Task.Factory.StartNew(() => HAAPI.Set_Input());
                    break;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SettingsForm = new Settings();
            SettingsForm.ShowDialog();
        }

        private void sourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextSources.Show(MousePosition);
        }

        private void sliderVol_MouseUp(object sender, MouseEventArgs e)
        {
            decimal volumelevel = sliderVol.Value / 100m;
            Task.Factory.StartNew(() => HAAPI.Volume_Set(volumelevel));
            tmrPoll.Start();
        }

        private void sliderVol_MouseDown(object sender, MouseEventArgs e)
        {
            tmrPoll.Stop();
        }

        private void ntfyMain_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Opacity = 1;
                this.Show();
                this.Activate();
            }
        }

        private void lblHide_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Rectangle rect = new Rectangle(0, 0, (this.ClientSize.Width - 1), (this.ClientSize.Height - 1));
            e.Graphics.DrawRectangle(Pens.White, rect);
        }
    }
}