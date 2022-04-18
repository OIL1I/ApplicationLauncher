using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLauncher.Controls;

namespace ApplicationLauncher.Forms
{
    public partial class FolderItemDialog : Form
    {
        private FlowLayoutPanel layoutPanel;
        private FolderItem parent;

        public List<LauncherItem> Items { get; set; }

        public FolderItemDialog(FolderItem pParent)
        {
            InitializeComponent();
            layoutPanel = new FlowLayoutPanel();
            this.LostFocus += OnFocusLost;
            this.Load += OnLoad;
            this.Items = new List<LauncherItem>();
            parent = pParent;
        }

        private void OnFocusLost(object sender, EventArgs e)
        {
            CloseDialog(null, null);
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            parent.CloseFolder();
            foreach (LauncherItem item in Items)
            {
                item.RemoveClick(CloseDialog);
                if (!item.IsFavorite)
                {
                    item.RemoveClickToLaunch();
                }
            }
            this.Hide();
        }

        public void OnLoad(object sender, EventArgs e)
        {
            foreach (LauncherItem item in Items)
            {
                item.SetClick(CloseDialog);
                if (!item.IsFavorite)
                {
                    item.SetClickToLaunch();
                }
                flp_items.Controls.Add(item);
            }

            this.Size = parent.Parent.Parent.Size;
            this.flp_items.Size = new Size(this.Size.Width - 5, this.Size.Height-5);
            this.Location = new Point(parent.Parent.Parent.Location.X, parent.Parent.Parent.Location.Y - this.Size.Height); //parent.Parent.Parent = Favourites-Window
            this.flp_items.Update();
            this.Update();
        }
    }
}