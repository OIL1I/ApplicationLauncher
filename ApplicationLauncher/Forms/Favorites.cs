using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using ApplicationLauncher.Data;
using ApplicationLauncher.Logic;

namespace ApplicationLauncher.Forms
{
    public partial class Favorites : Form
    {
        public Favorites()
        {
            InitializeComponent();
        }

        private void Favorites_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;

            notifyIcon1.ContextMenuStrip = CreateContextMenuStrip();
            notifyIcon1.DoubleClick += ShowFavoriteWindow_Click;

            try
            {
                SaveManager.SavePath = ConfigurationManager.AppSettings.Get("SavePath");

                SaveItem[] items = SaveManager.LoadFromFiles(SaveManager.SavePath);

                foreach (SaveItem saveItem in items)
                {
                    LauncherData.AddItem(new Controls.LauncherItem(saveItem));
                }
            }
            catch (ArgumentNullException ex)
            {
                //TODO: Rework Error Message Titles
                MessageBox.Show(ex.Message, "Undefined Savepath!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exceptions.SavePathNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Missing savepath directory!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReloadFavorites();
        }

        private ContextMenuStrip CreateContextMenuStrip()
        {
            ContextMenuStrip cms = new ContextMenuStrip();

            cms.Items.Add("Show favorites");
            cms.Items.Add("Show all registered applications");
            cms.Items.Add("Settings");
            cms.Items.Add("Close application");

            cms.Items[0].Click += ShowFavoriteWindow_Click;
            cms.Items[1].Click += ShowAllApllications_Click;
            cms.Items[2].Click += ShowSettingsWindow_Click;
            cms.Items[3].Click += QuitApplication_Click;

            return cms;
        }

        private void ShowAllApllications_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LauncherData.GetItemCount; i++)
            {
                var item = LauncherData.GetItem(i);

                item.RemoveClickToLaunch();
            }

            this.Visible = false;
            new AllApps().ShowDialog();
            this.Visible = true;

            ReloadFavorites();
        }

        private void QuitApplication_Click(object sender, EventArgs e)
        {
            //TODO: Write SavePath to .config
            try
            {
                for (int i = 0; i < LauncherData.GetItemCount; i++)
                {
                    SaveManager.SaveToFile(new SaveItem(LauncherData.GetItem(i)));
                }

                Application.Exit();
            }
            catch (Exceptions.SavePathWasNotSetException ex)
            {
                var result = MessageBox.Show(ex.Message + Environment.NewLine + "Would you like to set it now?", "Undefined savepath!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    SaveManager.SetPathsToDefault();
                    (new Settings()).ShowDialog();
                }
                return;
            }
            catch (Exceptions.SavePathNotFoundException ex)
            {
                var result = MessageBox.Show(ex.Message + Environment.NewLine + "Would you like to create it?", "Missing savepath directory", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    SaveManager.CreateDirectory(SaveManager.SavePath);
                }
                return;
            }
            catch (Exceptions.ChangedSavePathException ex)
            {
                var result = MessageBox.Show(ex.Message + Environment.NewLine + "Are you sure ?", "Changed savepath", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    //TODO: remove all savefiles
                    Application.Exit();
                }
                notifyIcon1.BalloonTipText = "Savepath set to default";
                notifyIcon1.ShowBalloonTip(150);
                SaveManager.SetPathsToDefault();
            }
        }

        private void ShowSettingsWindow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Settings().ShowDialog();
            ReloadFavorites();
            this.Visible = true;
        }

        public void ShowFavoriteWindow_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ReloadFavorites()
        {
            foreach (Controls.LauncherItem item in flpannel_items.Controls)
            {
                item.RemoveClickToLaunch();
            }

            flpannel_items.Controls.Clear();

            for (int i = 0; i < Data.LauncherData.GetItemCount; i++)
            {
                if ((Data.LauncherData.GetItem(i)).IsFavorite)
                {
                    Controls.LauncherItem t = Data.LauncherData.GetItem(i);
                    flpannel_items.Controls.Add(t);
                    t.SetClickToLaunch();
                }

            }
        }
    }
}
