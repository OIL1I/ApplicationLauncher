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
    //TODO: Make LauncherItem Control smaller
    public partial class LauncherItem : UserControl
    {
        public bool IsFavorite { get; set; }
        public string PathToExe { get; set; }
        public Image Symbol { get; set; }
        public string ItemName { get; set; }
        public string Args { get; set; }
        public bool IsSelected { get; set; }
        public Image DefaultItemSymbol { get; set; }

        public LauncherItem()
        {
            InitializeComponent();

            this.picbx_symbol.Image = this.Symbol;
            this.picbx_symbol.Update();
        }

        public LauncherItem(Data.SaveItem saveItem)
        {
            InitializeComponent();

            this.IsFavorite = saveItem.isFavorite;
            this.ItemName = saveItem.itemName;
            this.Args = saveItem.args;
            this.PathToExe = saveItem.itemPath;
            this.Symbol = saveItem.symbol;
            this.DefaultItemSymbol = saveItem.defaultSymbol;

            this.picbx_symbol.Image = this.Symbol;
            this.picbx_symbol.Update();

            this.MouseEnter += delegate (object sender, EventArgs e) { OnMouseEnter(); };
            this.MouseLeave += delegate (object sender, EventArgs e) { OnMouseLeave(); };
            foreach (Control c in this.Controls)
            {
                c.MouseEnter += delegate (object sender, EventArgs e) { OnMouseEnter(); };
                c.MouseLeave += delegate (object sender, EventArgs e) { OnMouseLeave(); };
            }
        }

        private void LauncherItem_Load(object sender, EventArgs e)
        {
            this.picbx_symbol.Update();
        }

        private void OnLaunch_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDark;
            this.BorderStyle = BorderStyle.Fixed3D;

            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                process.StartInfo.FileName = PathToExe;
                process.StartInfo.Arguments = Args;
                process.Start();
            }

            System.Threading.Thread.Sleep(30);
            this.BorderStyle = BorderStyle.None;
            this.BackColor = SystemColors.Control;
        }

        private void OnMouseEnter()
        {
            if (!IsSelected)
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = SystemColors.ButtonHighlight;
            }
        }

        private void OnMouseLeave()
        {
            if (!IsSelected)
            {
                this.BorderStyle = BorderStyle.None;
                this.BackColor = SystemColors.Control;
            }
        }

        public void SetClickToLaunch()
        {
            this.Click += OnLaunch_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += OnLaunch_Click;
            }
        }

        public void RemoveClickToLaunch()
        {
            this.Click -= OnLaunch_Click;
            foreach (Control c in this.Controls)
            {
                c.Click -= OnLaunch_Click;
            }
        }

        public void SetClick(EventHandler method)
        {
            this.Click += method;
            foreach (Control c in this.Controls)
            {
                c.Click += method;
            }
        }

        public void RemoveClick(EventHandler method)
        {
            this.Click -= method;
            foreach (Control c in this.Controls)
            {
                c.Click -= method;
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

        public void SetSymbolToDefault()
        {
            this.Symbol = this.DefaultItemSymbol;
            this.picbx_symbol.Image = this.DefaultItemSymbol;
            this.picbx_symbol.Update();
        }

        public void SetSymbol(Image img)
        {
            this.Symbol = img;
            this.picbx_symbol.Image = img;
            this.picbx_symbol.Update();
        }
    }
}
