using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HA_Volume
{
    public partial class Settings : Form
    {
        private System.Windows.Forms.Screen[] Screens;

        public Settings()
        {
            InitializeComponent();
        }

        private void cmbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Screen.AllScreens[cmbMonitor.SelectedIndex].Bounds.Location.X + Screen.AllScreens[cmbMonitor.SelectedIndex].WorkingArea.Width /2 - (this.Width /2);
            int y = Screen.AllScreens[cmbMonitor.SelectedIndex].Bounds.Location.Y + Screen.AllScreens[cmbMonitor.SelectedIndex].WorkingArea.Height /2 - (this.Height /2 );
            this.Location = new Point(x, y);
            Properties.Settings.Default.Monitor = cmbMonitor.SelectedIndex;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
            Screens = System.Windows.Forms.Screen.AllScreens;
            foreach (Screen s in Screens)
            {
                cmbMonitor.Items.Add(s.DeviceName.Replace("\\\\.\\DISPLAY", ""));
            }

            cmbMonitor.SelectedIndex = Properties.Settings.Default.Monitor;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cyanlabs.net/applications/ha-volume/");
        }

        dynamic HAData;

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

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (chkStartup.Checked) {
                key.SetValue("HAVolume",AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName);
            } else {
                key.DeleteValue("HAVolume");
            }
        }
    }
}