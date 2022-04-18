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
    public partial class ManageFolder : Form
    {
        FolderItemDialog itemDialog;
        public ManageFolder(FolderItemDialog pItemDialog)
        {
            InitializeComponent();
            itemDialog = pItemDialog;

            for (int i = 0; i < Data.LauncherData.ItemCount; i++)
            {
                CheckBox cbx = new CheckBox();
                cbx.Text = Data.LauncherData.GetItem(i).ItemName;
                this.flp_folderContent.Controls.Add(cbx);
            }
        }

        private void btn_saveFolder_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cbx in this.flp_folderContent.Controls)
            {
                if (cbx.Checked)
                {
                    var li = GetItemByName(cbx.Text);
                    if (li != null)
                    {
                        itemDialog.Items.Add(li);
                    }
                }
            }
            this.Close();
        }

        private Controls.LauncherItem GetItemByName(string pItemName)
        {
            Controls.LauncherItem result = null;

            for (int i = 0; i < Data.LauncherData.ItemCount; i++)
            {
                var li = Data.LauncherData.GetItem(i);
                if (li.ItemName.Equals(pItemName))
                {
                    return result = li;
                }
            }

            return result;
        }
    }
}
