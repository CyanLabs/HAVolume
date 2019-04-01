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

        // Handle the Global Keybinds.
        private void _globalHook_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //Continue only if CTRL wasn't pressed.
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

                        // Pressing the Pause key without Shift will toggle power, with Shift it changes to the DefaultInput.
                    case System.Windows.Forms.Keys.Pause:
                        e.Handled = true;
                        if (e.Modifiers == System.Windows.Forms.Keys.Shift)
                        {
                            Task.Factory.StartNew(() => HAAPI.Set_Input());
                        } else {
                            Task.Factory.StartNew(() => HAAPI.Power());
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        // This timer runs to update HA constantly, by default every 2 seconds.
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

        // Simple method to show OSD for 5 seconds then hide again without locking the UI Thread.
        void ShowOSD()
        {
            this.Invoke((Action)(() => this.Opacity = 1));
            System.Threading.Thread.Sleep(5000);
            this.Invoke((Action)(() => this.Opacity = 0));
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //If HAURL is not set, assume first launch and load settings.
            if (String.IsNullOrEmpty(Properties.Settings.Default.HAURL))
            {
                Form SettingsForm = new Settings();
                SettingsForm.Show();
                this.Opacity = 0;
            
            //If HAURL is set then continue as normal.
            } else {
                lblOSD.Text = "HA Volume - " + System.Windows.Forms.Application.ProductVersion;

                //Check for Updates.
                if (Properties.Settings.Default.Update) AutoUpdaterDotNET.AutoUpdater.Start("http://cyanlabs.net/raw/latest.php?product=" + System.Windows.Forms.Application.ProductName);

                //Set OSD to the correct screen based on settings.
                int x = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location.X + (Screen.AllScreens[Properties.Settings.Default.Monitor].WorkingArea.Width - this.Width);
                int y = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location.Y + (Screen.AllScreens[Properties.Settings.Default.Monitor].WorkingArea.Height - this.Height);
                Location = new Point(x, y);

                //Runs a manual poll to prevent crash before timer has run.
                HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);

                //Populates menu with all sources set in HA.
                if (HAData["attributes"].ContainsKey("source_list"))
                {
                    foreach (string source in HAData["attributes"]["source_list"])
                    {
                        contextSources.Items.Add(source, null, contextsource);
                    }
                }

                //If Keybinds are enables it adds the keybind event handler.
                if (Properties.Settings.Default.Keybinds)
                {
                    _globalHook = Hook.GlobalEvents();
                    _globalHook.KeyDown += _globalHook_KeyDown;
                }

                //Set timer to 1000 x chosen poll speed and start the timer.
                tmrPoll.Interval = Properties.Settings.Default.PollRate * 1000;
                tmrPoll.Start();
            }            
        }

        //This is a workaround to be able to add seperate events to each dynamic context menu entry (source).
        void contextsource(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Set_Input(sender.ToString()));

        //Turns on media_player if not already on and if set to do so in settings.
        void StartupCommands()
        {
            if (Properties.Settings.Default.AutoOff)
            {
                if (HAData["state"] == "off") { Task.Factory.StartNew(() => HAAPI.Power()); }
            }
        }

        //Turns off media_player if not already off and if set to do so in settings.
        void ShutdownCommands()
        {
            if (Properties.Settings.Default.AutoOn)
            {
                if (HAData["state"] == "on") { Task.Factory.StartNew(() => HAAPI.Power()); }
            }

        }

        //Detects computer suspend and resume and if set sets power of media_player accordingly.
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

        //Manual context menu entry to check for updates.
        private void checkForupdatesToolStripMenuItem_Click(object sender, EventArgs e) => AutoUpdaterDotNET.AutoUpdater.Start("http://cyanlabs.net/raw/latest.php?product=" + System.Windows.Forms.Application.ProductName);

        //Manual context menu entry to exit the application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        //Mutes when mute icon clicked.
        private void imgMute_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Volume_Mute(HAData["attributes"]["is_volume_muted"]));

        //Toggles power when power icon clicked.
        private void imgPower_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => HAAPI.Power());

        //If left click show context menu with all available HA sources, if right click automatically change to DefaultInput.
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

        //Manual context menu entry to load settings form.
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SettingsForm = new Settings();
            SettingsForm.ShowDialog();
        }

        //Alternative way to access sources via context menu.
        private void sourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextSources.Show(MousePosition);
        }

        //When mouse is released send the desired volume to HA.
        private void sliderVol_MouseUp(object sender, MouseEventArgs e)
        {
            decimal volumelevel = sliderVol.Value / 100m;
            Task.Factory.StartNew(() => HAAPI.Volume_Set(volumelevel));
            tmrPoll.Start();
        }

        //Temporarily stops the timer to prevent slider value changing while using it.
        private void sliderVol_MouseDown(object sender, MouseEventArgs e)
        {
            tmrPoll.Stop();
        }

        //Manually shows the OSD.
        private void ntfyMain_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Opacity = 1;
                this.Show();
                this.Activate();
            }
        }

        //Manually minimize/hide the OSD.
        private void lblHide_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        //Adds a nice white border to the OSD.
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Rectangle rect = new Rectangle(0, 0, (this.ClientSize.Width - 1), (this.ClientSize.Height - 1));
            e.Graphics.DrawRectangle(Pens.White, rect);
        }
    }
}