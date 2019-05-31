using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HA_Volume
{
    public partial class Settings : Form
    {
        private System.Windows.Forms.Screen[] Screens;
        dynamic HAData;

        public Settings()
        {
            InitializeComponent();
        }

        //Dropdown to change which monitor the OSD will show on, it will also change the location of the settings window to "preview" which monitor it will be.
        private void cmbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Screen.AllScreens[cmbMonitor.SelectedIndex].Bounds.Location.X + Screen.AllScreens[cmbMonitor.SelectedIndex].WorkingArea.Width /2 - (this.Width /2);
            int y = Screen.AllScreens[cmbMonitor.SelectedIndex].Bounds.Location.Y + Screen.AllScreens[cmbMonitor.SelectedIndex].WorkingArea.Height /2 - (this.Height /2 );
            this.Location = new Point(x, y);
            Properties.Settings.Default.Monitor = cmbMonitor.SelectedIndex;
        }

        //Populates the dropdown with all detected monitors and sets the application version label, disables the dropdowns until valid URL is detected.
        private void Settings_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
            Screens = System.Windows.Forms.Screen.AllScreens;
            foreach (Screen s in Screens)
            {
                cmbMonitor.Items.Add(s.DeviceName.Replace("\\\\.\\DISPLAY", ""));
            }

            cmbMonitor.SelectedIndex = Properties.Settings.Default.Monitor;
            if(txtURL.Text == "" || txtToken.Text == "" || HAAPI.Validate_URL(txtURL.Text))
            {
                cmbEntity.Enabled = true;
                cmbSource.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid URL, please enter the URL in the following format [PROTO]://[IP or DOMAIN]:[PORT] for example http://192.168.1.10:8123", "HA Volume - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEntity.Enabled = false;
                cmbSource.Enabled = false;
            }
        }

        //Restarts application for changes to take afect.
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }

        //Loads my website.
        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cyanlabs.net/applications/ha-volume/");
        }


        //Populates the entity dropdown with all HA media_player entities.
        private void cmbEntity_Click(object sender, EventArgs e)
        {
            HAData = HAAPI.GET();
            foreach (dynamic item in HAData) {
                if (item.ContainsKey("entity_id")) {
                    string entityid = item["entity_id"];
                    if (entityid.Contains("media_player."))
                    {
                        if (!cmbEntity.Items.Contains(item["entity_id"])) cmbEntity.Items.Add(item["entity_id"]);
                    }
                }
            }
        }

        //Populates the source dropdown with all available HA sources.
        private void cmbSource_Click(object sender, EventArgs e)
        {
            HAData = HAAPI.GET(Properties.Settings.Default.HAEntity);
            if (HAData["attributes"].ContainsKey("source_list"))
            {
                foreach (string source in HAData["attributes"]["source_list"])
                {
                    if (!cmbSource.Items.Contains(source)) cmbSource.Items.Add(source);

                }
            }
        }

        //Adds/removes the registry key which makes HA Volume launch on windows startup.
        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (chkStartup.Checked) {
                key.SetValue("HAVolume",AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName);
            } else {
                key.DeleteValue("HAVolume");
            }
        }

        //Validates URL when textbox focus is lost.
        private void txtURL_Leave(object sender, EventArgs e)
        {
            if (HAAPI.Validate_URL(txtURL.Text))
            {
                cmbEntity.Enabled = true;
                cmbSource.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid URL, please enter the URL in the following format [PROTO]://[IP or DOMAIN]:[PORT] for example http://192.168.1.10:8123", "HA Volume - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEntity.Enabled = false;
                cmbSource.Enabled = false;
            }
        }

        private void cmbApplicationStart_Click(object sender, EventArgs e)
        {
            HAData = HAAPI.GET();
            foreach (dynamic item in HAData)
            {
                if (item.ContainsKey("entity_id"))
                {
                    string entityid = item["entity_id"];
                    if (entityid.Contains("switch."))
                    {
                        if (!cmbApplicationStart.Items.Contains(item["entity_id"])) cmbApplicationStart.Items.Add(item["entity_id"]);
                    }
                }
            }
        }

        private void cmbApplicationStop_Click(object sender, EventArgs e)
        {
            HAData = HAAPI.GET();
            foreach (dynamic item in HAData)
            {
                if (item.ContainsKey("entity_id"))
                {
                    string entityid = item["entity_id"];
                    if (entityid.Contains("switch."))
                    {
                        if (!cmbApplicationStop.Items.Contains(item["entity_id"])) cmbApplicationStop.Items.Add(item["entity_id"]);
                    }
                }
            }
        }

        private void cmbApplicationStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbApplicationStart.Text = Properties.Settings.Default.StartSwitch;
        }

        private void cmbApplicationStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbApplicationStop.Text = Properties.Settings.Default.StopSwitch;
        }
    }
}