using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLauncher.Controls
{
    public partial class FolderItemDialog : UserControl
    {
        private FlowLayoutPanel layoutPanel;
        private FolderItem parent;

        public List<LauncherItem> Items { get; set; }

        public FolderItemDialog()
        {
            InitializeComponent();
            layoutPanel = new FlowLayoutPanel();
            this.LostFocus += OnFocusLost;
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
            }
            this.Hide();
        }

        public void ShowDialog()
        {
            var _size = new Size(10, 10);

            for (int i = 0; i < Items.Count; i++)
            {
                if (i % 4 == 0)
                {
                    _size.Height += 50;
                    continue;
                }
                _size.Width += 50;
                Items[i].SetClick(CloseDialog);
            }

            this.Size = _size;
            this.layoutPanel.Size = _size;
            this.layoutPanel.Controls.AddRange(Items.ToArray());
            this.Show();
        }
    }
}
