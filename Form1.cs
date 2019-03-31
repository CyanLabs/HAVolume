using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using System.Drawing;

namespace HA_Volume
{
    public partial class Main : Form
    {
        string json = "";
        dynamic HAData;

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
                        json = new JavaScriptSerializer().Serialize(new { entity_id = Properties.Settings.Default.HAEntity});
                        Task.Factory.StartNew(() => HAAPI.POST("media_player", "volume_up", json));
                        break;

                    case System.Windows.Forms.Keys.VolumeDown:
                        e.Handled = true;
                        json = new JavaScriptSerializer().Serialize(new { entity_id = Properties.Settings.Default.HAEntity});
                        Task.Factory.StartNew(() => HAAPI.POST("media_player", "volume_down", json));
                        break;

                    case System.Windows.Forms.Keys.VolumeMute:
                        e.Handled = true;
                        json = new JavaScriptSerializer().Serialize(new { entity_id = Properties.Settings.Default.HAEntity, is_volume_muted = !HAData["attributes"]["is_volume_muted"] });
                        Task.Factory.StartNew(() => HAAPI.POST("media_player", "volume_mute", json));
                        break;

                    case System.Windows.Forms.Keys.Pause:
                        e.Handled = true;

                        if (e.Modifiers == System.Windows.Forms.Keys.Shift)
                        {
                            json = new JavaScriptSerializer().Serialize(new { entity_id = Properties.Settings.Default.HAEntity, source = Properties.Settings.Default.DefaultInput });
                            Task.Factory.StartNew(() => HAAPI.POST("media_player", "select_source", json));
                        }
                        else
                        {
                            json = new JavaScriptSerializer().Serialize(new { entity_id = Properties.Settings.Default.HAEntity });
                            Task.Factory.StartNew(() => HAAPI.POST("media_player", "toggle", json));
                        }
                        break;
                    default:
                    break;
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);
            // Update OSD
            if (HAData["attributes"].ContainsKey("source")) { lblOSD.Text = HAData["attributes"]["source"]; } else { lblOSD.Text = "Amp Powered Off!"; }

            // Update Power Icon
            if (HAData["state"] == "on") { this.imgPower.Image =Properties.Resources.on; } else { this.imgPower.Image = Properties.Resources.off; }

            // Add Sources to Dropdown without duplicates
            if (HAData["attributes"].ContainsKey("source_list"))
            {
                foreach (string source in HAData["attributes"]["source_list"]) { if (!comboBox1.Items.Contains(source)) comboBox1.Items.Add(source); }
            }

            // Update Mute Icon
            if (HAData["attributes"].ContainsKey("is_volume_muted"))
            {
                if (HAData["attributes"]["is_volume_muted"]) { this.imgMute.Image =Properties.Resources.mute; } else { this.imgMute.Image =Properties.Resources.vol; }
            }

            // Update Slider and Volume Label
            if (HAData["attributes"].ContainsKey("volume_level")) {
                int volaspercent = Convert.ToInt32(HAData["attributes"]["volume_level"] * 100);
                sliderVol.Value = volaspercent;
                lblVol.Text = volaspercent.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form SettingsForm = new Settings();
            SettingsForm.ShowDialog();
        }

        int x; int y;
        private void Main_Load(object sender, EventArgs e)
        {
           if(Properties.Settings.Default.Update) AutoUpdaterDotNET.AutoUpdater.Start("http://cyanlabs.net/raw/latest.php?product=" + System.Windows.Forms.Application.ProductName);
           
           
           // this.Opacity = 0;

            x = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location.X + (Screen.AllScreens[Properties.Settings.Default.Monitor].WorkingArea.Width - this.Width);
            y = Screen.AllScreens[Properties.Settings.Default.Monitor].Bounds.Location.Y + (Screen.AllScreens[Properties.Settings.Default.Monitor].WorkingArea.Height - this.Height);
            Location = new Point(x, y);

            HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);

            _globalHook = Hook.GlobalEvents();
            if(Properties.Settings.Default.Keybinds) _globalHook.KeyDown += _globalHook_KeyDown;
            //tmrPoll.Start();
        }

        private static void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case Microsoft.Win32.PowerModes.Resume:
                    //if (!oncmd = "")
                    //{
                    //Dim RunOnCMD As New Threading.Thread(AddressOf OnCommands) With {.IsBackground = True}
                    //RunOnCMD.Start();
                    //}
                    break;
                case Microsoft.Win32.PowerModes.Suspend:
                    //OffCommands();
                    break;
            }
        }
    }


}