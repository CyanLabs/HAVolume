using HA_Volume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HATest1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "HAVolume", out createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
                else
                {
                    MessageBox.Show("The Application Is Already Running", "HAVolume", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
