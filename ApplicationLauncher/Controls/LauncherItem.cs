using SaveHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationLauncher.Controls
{
    public partial class LauncherItem : UserControl, ISaveable, Logic.IItem
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
            SetMouseEvents();
        }

        public LauncherItem(SaveHelper.SaveItem saveItem)
        {
            InitializeComponent();
            ConvertFromSaveItem(saveItem);
            this.picbx_symbol.Image = this.Symbol;
            this.picbx_symbol.Update();
            SetMouseEvents();
        }

        private void SetMouseEvents()
        {
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

        public void UpdatePicbx()
        {
            this.picbx_symbol.Image = this.Symbol;
            this.picbx_symbol.Update();
        }

        public void SetClickToLaunch()
        {
            SetClick(OnLaunch_Click);
        }

        public void RemoveClickToLaunch()
        {
            RemoveClick(OnLaunch_Click);
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

        public SaveItem GetSaveItem()
        {
            dynamic result = new SaveItem();
            result.IsFavorite = this.IsFavorite;
            result.Name = this.ItemName;
            result.ItemPath = this.PathToExe;
            result.Args = this.Args;
            result.Symbol = this.Symbol;
            result.DefaultSymbol = this.DefaultItemSymbol;            

            return result;
        }

        public void ConvertFromSaveItem(SaveItem item)
        {
            Dictionary<string, object> dic = item.GetDictionary();
            if (!dic.TryGetValue("IsFavorite", out object _isFav)) throw new Exception("Error converting to LauncherItem: IsFavorite!");
            this.IsFavorite = (bool)_isFav;
            if (!dic.TryGetValue("Name", out object _name)) throw new Exception("Error converting to LauncherItem: Name!");
            this.ItemName = _name.ToString();
            if (!dic.TryGetValue("ItemPath", out object _itemPath)) throw new Exception("Error converting to LauncherItem: ItemPath!");
            this.PathToExe = _itemPath.ToString();
            if (!dic.TryGetValue("Args", out object _args)) throw new Exception("Error converting to LauncherItem: Args!");
            this.Args = _args.ToString();
            if (!dic.TryGetValue("Symbol", out object _symbol)) throw new Exception("Error converting to LauncherItem: Symbol!");
            this.Symbol = (Image)_symbol;
            if (!dic.TryGetValue("DefaultSymbol", out object _defaultSymbol)) throw new Exception("Error converting to LauncherItem: DefaultSymbol!");
            this.DefaultItemSymbol = (Image)_defaultSymbol;
        }
    }
}