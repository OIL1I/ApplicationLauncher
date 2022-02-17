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
    public partial class FolderItem : UserControl, Logic.IItem
    {
        public Image OpenFolderSymbol { get; set; } 
        public Image ClosedFolderSymbol { get; set; }
        public FolderItemDialog FolderItemDialog { get; set; }
        public bool IsSelected { get; set ; }

        public FolderItem()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs eventArgs)
        {
            OpenFolder();
            FolderItemDialog.ShowDialog();
        }

        public void OpenFolder()
        {
            this.picbx_symbol.Image = OpenFolderSymbol;
            this.picbx_symbol.Update();
        }

        public void CloseFolder()
        {
            this.picbx_symbol.Image = ClosedFolderSymbol;
            this.picbx_symbol.Update();
        }

        public void SetClick(EventHandler handler)
        {
            this.Click += handler;
            foreach (Control c in this.Controls)
            {
                c.Click += handler;
            }
        }

        public void RemoveClick(EventHandler handler)
        {
            this.Click -= handler;
            foreach (Control c in this.Controls)
            {
                c.Click -= handler;
            }
        }

        public void SelectItem()
        {
            this.IsSelected = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = SystemColors.Highlight;
        }

        public void UnselectItem()
        {
            IsSelected = false;
            this.BorderStyle = BorderStyle.None;
            this.BackColor = SystemColors.Control;
        }
    }
}
