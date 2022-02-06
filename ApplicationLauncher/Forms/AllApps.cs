using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLauncher.Forms
{
    public partial class AllApps : Form
    {
        public AllApps()
        {
            InitializeComponent();
        }

        private void AllApps_SizeChanged(object sender, EventArgs e)
        {
            OnResize();
        }

        private void AllApps_Load(object sender, EventArgs e)
        {
            OnResize();

            for (int i = 0; i < Data.LauncherData.ItemCount; i++)
            {
                var item = Data.LauncherData.GetItem(i);

                item.SetClickToLaunch();
                flp_items.Controls.Add(item);
            }
        }

        private void OnResize()
        {
            var formSize = this.Size;
            this.flp_items.Size = new Size(formSize.Width - 43, formSize.Height - 72);

            this.Update();
            this.flp_items.Update();
        }

        private void AllApps_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Controls.LauncherItem item in flp_items.Controls)
            {
                item.RemoveClickToLaunch();
            }
        }
    }
}
