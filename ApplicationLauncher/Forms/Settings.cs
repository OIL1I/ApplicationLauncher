using ApplicationLauncher.Properties;
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

            for (int i = 0; i < Data.LauncherData.FolderCount; i++)
            {
                var item = Data.LauncherData.GetFolder(i);
                item.SetClick(SelectFolder);
                item.RemoveClickToOpen();
                flpanel_folders.Controls.Add(item);
            }

            this.flpanel_items.SelectionChanged += ItemSelectionChanged;
            this.flpanel_folders.SelectionChanged += FolderSelectionChanged;
            this.txtbx_saveDirectory.Text = Logic.SaveManager.CurrentSavePath;
            this.localPreviousSavePath = Logic.SaveManager.CurrentSavePath;
            this.flpanel_items.SelectionIndex = -1;
            this.flpanel_folders.SelectionIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Data.LauncherData.ItemCount; i++)
            {
                Data.LauncherData.RemoveItemAt(i);
            }
            for (int i = 0; i <= Data.LauncherData.FolderCount; i++)
            {
                Data.LauncherData.RemoveFolderAt(i);
            }

            foreach (Controls.LauncherItem item in flpanel_items.Controls)
            {
                item.UnselectItem();
                item.RemoveClick(SelectItem);
                Data.LauncherData.AddItem(item);
            }
            foreach (Controls.FolderItem item in flpanel_folders.Controls)
            {
                item.UnselectItem();
                item.RemoveClick(SelectFolder);
                item.SetClickToOpen();
                Data.LauncherData.AddFolder(item);
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
            flpanel_items.OnSelectionChanged(new Controls.ItemFlowLayoutPanelEventArgs(t));
        }

        private void SelectFirstFolder()
        {
            if (flpanel_folders.SelectionIndex == -1) return;
            var t = flpanel_folders.Controls[0] as Controls.FolderItem;
            flpanel_folders.SelectionIndex = GetFolderID(t);
            t.SelectItem();
            flpanel_folders.OnSelectionChanged(new Controls.ItemFlowLayoutPanelEventArgs(t));
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
            tLi = GetItemFromSender(sender) as Controls.LauncherItem;

            if (tLi == null) return;

            tLi.SelectItem();
            flpanel_items.SelectionIndex = GetItemID(tLi);
            flpanel_items.OnSelectionChanged(new Controls.ItemFlowLayoutPanelEventArgs(tLi));
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            Controls.FolderItem tFi = null;
            UnselectAllFolder();
            tFi = GetItemFromSender(sender) as Controls.FolderItem;

            if (tFi == null) return;

            tFi.SelectItem();
            flpanel_folders.SelectionIndex = GetFolderID(tFi);
            flpanel_folders.OnSelectionChanged(new Controls.ItemFlowLayoutPanelEventArgs(tFi));
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                li.UnselectItem();
                li.Click -= SelectItem;
            }
        }

        private void ItemSelectionChanged(object sender, Controls.ItemFlowLayoutPanelEventArgs e)
        {
            if (e.Item == null) return;
            var item = e.Item as Controls.LauncherItem;
            this.picbx_itemSymbol.Image = item.Symbol;
            this.txtbx_itemName.Text = item.ItemName;
            this.txtbx_args.Text = item.Args;
            this.cbx_launchArgs.Checked = false;
            this.cbx_favorite.Checked = item.IsFavorite;
        }

        private void FolderSelectionChanged(object sender, Controls.ItemFlowLayoutPanelEventArgs e)
        {
            if (e.Item == null) return;
            var item = e.Item as Controls.FolderItem;
            this.picbx_closedFolder.Image = item.ClosedFolderSymbol;
            this.picbx_openFolder.Image = item.OpenFolderSymbol;
            this.txtbx_folderName.Text = item.FolderName;
            this.lstbx_folderContents.Items.Clear();
            foreach (Controls.LauncherItem li in item.FolderItemDialog.Items)
            {
                this.lstbx_folderContents.Items.Add(li.ItemName);
            }
        }

        private void UnselectAllItems()
        {
            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                li.UnselectItem();
            }
        }

        private void UnselectAllFolder()
        {
            foreach (Controls.FolderItem fi in flpanel_folders.Controls)
            {
                fi.UnselectItem();
            }
        }

        private Logic.IItem GetItemFromSender(object sender)
        {
            Control c = null;
            Logic.IItem result = null;

            foreach (Controls.LauncherItem li in flpanel_items.Controls)
            {
                if (li.Equals(sender))
                {
                    return result = li;
                }
                else if (li.Contains(c = sender as Control))
                {
                    return result = c.Parent as Logic.IItem;
                }
            }

            foreach (Controls.FolderItem fi in flpanel_folders.Controls)
            {
                if (fi.Equals(sender))
                {
                    return result = fi;
                }
                else if (fi.Contains(c = sender as Control))
                {
                    return result = c.Parent as Logic.IItem;
                }
            }

            return result;
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            if (flpanel_items.SelectionIndex < 0) return;
            var item = flpanel_items.Controls[flpanel_items.SelectionIndex];
            //TODO: Change deleting to remove all files and save in new ones for each existing item
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
        
        private int GetFolderID(Controls.FolderItem pFolderItem)
        {
            int result = -1;

            foreach (Controls.FolderItem li in flpanel_folders.Controls)
            {
                result++;
                if (li.Equals(pFolderItem))
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

        private void btn_addFolder_Click(object sender, EventArgs e)
        {
            Controls.FolderItem folderItem = new Controls.FolderItem();
            folderItem.FolderName = "Folder" + (flpanel_folders.Controls.Count + 1);
            folderItem.FolderItemDialog = new Forms.FolderItemDialog(folderItem);
            folderItem.OpenFolderSymbol = Resources.DefaultFolderOpen;
            folderItem.ClosedFolderSymbol = Resources.DefaultFolderClosed;
            folderItem.CloseFolder();
            folderItem.SetClick(SelectFolder);

            this.flpanel_folders.Controls.Add(folderItem);
            this.flpanel_folders.Update();

            UnselectAllFolder();
            SelectFirstFolder();
        }

        private void btn_removeFolder_Click(object sender, EventArgs e)
        {
            if (flpanel_folders.SelectionIndex == -1) return;

            UnselectAllFolder();
            flpanel_folders.Controls.RemoveAt(flpanel_folders.SelectionIndex);

            SelectFirstFolder();
        }

        private void btn_manageFolderContents_Click(object sender, EventArgs e)
        {
            if (flpanel_folders.SelectionIndex == -1) return;
            new ManageFolder((flpanel_folders.Controls[flpanel_folders.SelectionIndex] as Controls.FolderItem).FolderItemDialog).ShowDialog();
            UnselectAllFolder();
            SelectFirstFolder();
        }
    }
}