using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationLauncher.Forms
{
    public partial class Settings : Form
    {
        private string localPreviousSavePath;

        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.LauncherData.ItemCount; i++)
            {
                var item = Data.LauncherData.GetItem(i);
                item.RemoveClickToLaunch();
                item.SetClick(SelectItem);
                flpanel_items.Controls.Add(item);
            }

            this.flpanel_items.SelectionChanged += ItemSelectionChanged;
            this.txtbx_saveDirectory.Text = Logic.SaveManager.CurrentSavePath;
            this.localPreviousSavePath = Logic.SaveManager.CurrentSavePath;
            this.flpanel_items.SelectionIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Data.LauncherData.ItemCount; i++)
            {
                Data.LauncherData.RemoveItemAt(i);
            }

            foreach (Controls.LauncherItem item in flpanel_items.Controls)
            {
                item.UnselectItem();
                item.RemoveClick(SelectItem);
                Data.LauncherData.AddItem(item);
            }

            this.Close();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose an executable to add";
            ofd.Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = "c:\\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            else return;

            if (!filePath.EndsWith(".exe")) return;

            var ico = Icon.ExtractAssociatedIcon(filePath).ToBitmap();

            var li = new Controls.LauncherItem()
            {
                PathToExe = filePath,
                Symbol = ico,
                DefaultItemSymbol = ico,
                IsFavorite = false,
                ItemName = filePath.Split('\\').Last(),
                Args = ""
            };

            li.SetClick(SelectItem);
            li.UpdatePicbx();

            flpanel_items.Controls.Add(li);
            flpanel_items.Update();

            UnselectAllItems();
            SelectFistItem();
        }

        private void SelectFistItem()
        {
            var t = flpanel_items.Controls[0] as Controls.LauncherItem;
            flpanel_items.SelectionIndex = GetItemID(t);
            t.SelectItem();
            flpanel_items.OnSelectionChanged(new Controls.LauncherItemFlowLayoutPanelEventArgs(t));
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Default value \"\"." +
                    "\n" +
                    "\n" +
                    "A single string containing arguments send to the targetapplication.\n" +
                    "This string gets analized by the targetapplication and has to meet its expectations.\n" +
                    "Under Windows Vista and earlier versions it has to be smaller than 2080 characters, under Windows 7 and newer it has to be smaller than 32699 characters long.\n" +
                    ".Net-Applications interpret spaces as delimiters.",
                    "Argument informations",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }

        private void cbx_launchArgs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_launchArgs.Checked)
            {
                txtbx_args.Enabled = true;
                return;
            }
            txtbx_args.Enabled = false;
        }

        private void btn_applyTxtbxContents_Click(object sender, EventArgs e)
        {
            if (flpanel_items.SelectionIndex < 0) { this.cbx_launchArgs.Checked = false; return; }

            Controls.LauncherItem selectedLaunecherItem = flpanel_items.Controls[flpanel_items.SelectionIndex] as Controls.LauncherItem;

            if (selectedLaunecherItem == null) return;

            var newName = txtbx_itemName.Text;
            var newArgs = txtbx_args.Text;

            if (newName != "")
            {
                selectedLaunecherItem.ItemName = newName;
            }

            selectedLaunecherItem.Args = newArgs;

            txtbx_args.Text = selectedLaunecherItem.Args;
            txtbx_itemName.Text = selectedLaunecherItem.ItemName;
        }

        private void SelectItem(object sender, EventArgs e)
        {
            Controls.LauncherItem tLi = null;

            UnselectAllItems();
            tLi = GetLauncherItemEventSender(sender);

            if (tLi == null) return;

            tLi.SelectItem();
            flpanel_items.SelectionIndex = GetItemID(tLi);
            flpanel_items.OnSelectionChanged(new Controls.LauncherItemFlowLayoutPanelEventArgs(tLi));
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                li.UnselectItem();
                li.Click -= SelectItem;
            }
        }

        private void ItemSelectionChanged(object sender, Controls.LauncherItemFlowLayoutPanelEventArgs e)
        {
            if (e.LauncherItem == null) return;

            this.picbx_itemSymbol.Image = e.LauncherItem.Symbol;
            this.txtbx_itemName.Text = e.LauncherItem.ItemName;
            this.txtbx_args.Text = e.LauncherItem.Args;
            this.cbx_launchArgs.Checked = false;
            this.cbx_favorite.Checked = e.LauncherItem.IsFavorite;
        }

        private void UnselectAllItems()
        {
            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                li.UnselectItem();
            }
        }

        private Controls.LauncherItem GetLauncherItemEventSender(object sender)
        {
            Control c = null;
            Controls.LauncherItem result = null;

            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                if (li.Equals(sender))
                {
                    result = li;
                    break;
                }
                else if (li.Contains(c = sender as Control))
                {
                    result = c.Parent as Controls.LauncherItem;
                    break;
                }
            }

            return result;
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            if (flpanel_items.SelectionIndex < 0) return;
            var item = flpanel_items.Controls[flpanel_items.SelectionIndex];
            Logic.SaveManager.RemoveSaveFile(((Controls.LauncherItem)item).ItemName);
            flpanel_items.Controls.Remove(item);
            if (flpanel_items.Controls.Count > 0)
            {
                UnselectAllItems();
                SelectFistItem();
                return;
            }

            this.picbx_itemSymbol.Image = null;
            this.txtbx_itemName.Text = "";
            this.txtbx_args.Text = "";
            this.cbx_launchArgs.Checked = false;
            this.cbx_favorite.Checked = false;
            flpanel_items.SelectionIndex = -1;
        }

        private void btn_chooseSymbol_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png, *.jpg, *.gif)|*.png; *.jpg; *.gif|All files (*.*)|*.*";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(ofd.FileName);
                    (flpanel_items.Controls[flpanel_items.SelectionIndex] as Controls.LauncherItem).SetSymbol(img);
                    this.picbx_itemSymbol.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Symbol is set back to default.", "Image error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var li = (flpanel_items.Controls[flpanel_items.SelectionIndex] as Controls.LauncherItem);
                    li.SetSymbolToDefault();
                    this.picbx_itemSymbol.Image = li.DefaultItemSymbol;
                }
            }
        }

        private int GetItemID(Controls.LauncherItem pLauncherItem)
        {
            int result = -1;

            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                result++;
                if (li.Equals(pLauncherItem))
                {
                    break;
                }
            }

            return result;
        }

        private void cbx_favorite_CheckedChanged(object sender, EventArgs e)
        {
            if (flpanel_items.SelectionIndex < 0)
            {
                cbx_favorite.Checked = false;
                return;
            }
            if (cbx_favorite.Checked)
            {
                (flpanel_items.Controls[flpanel_items.SelectionIndex] as Controls.LauncherItem).IsFavorite = true;
                return;
            }
            (flpanel_items.Controls[flpanel_items.SelectionIndex] as Controls.LauncherItem).IsFavorite = false;
        }

        private void btn_chooseSaveDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.MyComputer;
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                localPreviousSavePath = txtbx_saveDirectory.Text;

                Logic.SaveManager.CurrentSavePath = dlg.SelectedPath + "\\";
                txtbx_saveDirectory.Text = dlg.SelectedPath + "\\";
            }
        }

        private void btn_resetSymbol_Click(object sender, EventArgs e)
        {
            if (this.picbx_itemSymbol.Image == null || flpanel_items.SelectionIndex < 0) return;

            var li = (flpanel_items.Controls[flpanel_items.SelectionIndex] as Controls.LauncherItem);
            li.SetSymbolToDefault();
            this.picbx_itemSymbol.Image = li.DefaultItemSymbol;
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Logic.SaveManager.CurrentSavePath = localPreviousSavePath;
            this.txtbx_saveDirectory.Text = localPreviousSavePath; 
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            Logic.SaveManager.SetPathsToDefault();
            this.txtbx_saveDirectory.Text = Logic.SaveManager.CurrentSavePath;
        }
    }
}
