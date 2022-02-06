using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ShortcutHelper;

namespace Setup
{
    public partial class Setup : Form
    {
        string setupPath;

        public Setup()
        {
            if (System.Diagnostics.Process.GetProcessesByName("ApplicationLauncher").Length > 0)
            {
                MessageBox.Show("ApplicationLauncher is currently running." + Environment.NewLine + "Please close ApplicationLauncher before using the setup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(575);
            }

            setupPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Substring(0, System.IO.Path.GetDirectoryName(Application.ExecutablePath).Length - "Binaries".Length);
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs eventArgs)
        {
            this.txtbx_path.Text = setupPath + "Saves\\";
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(setupPath + "ApplicationLauncher.exe");
            config.AppSettings.Settings["Autostart"].Value = chckbx_autostart.Checked ? "true" : "false";
            config.AppSettings.Settings["DefaultSavePath"].Value = String.IsNullOrEmpty(txtbx_path.Text) ? setupPath + "Saves\\" : txtbx_path.Text;
            config.AppSettings.Settings["CurrentSavePath"].Value = String.IsNullOrEmpty(txtbx_path.Text) ? setupPath + "Saves\\" : txtbx_path.Text;
            config.AppSettings.Settings["FirstLaunch"].Value = "false";
            config.AppSettings.Settings["Width"].Value = "466";
            config.AppSettings.Settings["Height"].Value = "189";

            if (radbtn_topleft.Checked)
            {
                config.AppSettings.Settings["PositionX"].Value = "0";
                config.AppSettings.Settings["PositionY"].Value = "0";
            }
            else if (radbtn_bottomleft.Checked)
            {
                config.AppSettings.Settings["PositionX"].Value = "0";
                config.AppSettings.Settings["PositionY"].Value = (Screen.PrimaryScreen.WorkingArea.Height - 189).ToString(); // Working area height - favorites window height
            }
            else if (radbtn_topright.Checked)
            {
                config.AppSettings.Settings["PositionX"].Value = Screen.PrimaryScreen.WorkingArea.Width.ToString();
                config.AppSettings.Settings["PositionY"].Value = "0";
            }
            else if (radbtn_bottomright.Checked)
            {
                config.AppSettings.Settings["PositionX"].Value = (Screen.PrimaryScreen.WorkingArea.Width - 466).ToString();
                config.AppSettings.Settings["PositionY"].Value = (Screen.PrimaryScreen.WorkingArea.Height - 189).ToString();
            }

            config.Save(ConfigurationSaveMode.Modified);

            //Shortcuts
            try
            {
                if (chckbx_shortcut.Checked)
                {
                    ShortcutCreater.TryCreateDesktopShortcut(setupPath + "ApplicationLauncher.exe");
                }
                else
                {
                    ShortcutDeleter.TryDeleteDesktopShortcut("ApplicationLauncher.exe");
                }
                if (chckbx_autostart.Checked)
                {
                    ShortcutCreater.TryCreateStartupShortcutWithArguments(setupPath + "ApplicationLauncher.exe", "Autostart");
                }else
                {
                    ShortcutDeleter.TryDeleteStartupShortcut("ApplicationLauncher.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Setup Complete!" + Environment.NewLine + "This program will now close", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }
    }
}
