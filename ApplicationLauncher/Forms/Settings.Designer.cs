namespace ApplicationLauncher.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.picbx_itemSymbol = new System.Windows.Forms.PictureBox();
            this.gbx_symbol = new System.Windows.Forms.GroupBox();
            this.btn_resetSymbol = new System.Windows.Forms.Button();
            this.btn_chooseSymbol = new System.Windows.Forms.Button();
            this.gbx_launchSettings = new System.Windows.Forms.GroupBox();
            this.btn_applyTxtbxContents = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.txtbx_args = new System.Windows.Forms.TextBox();
            this.cbx_launchArgs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_itemName = new System.Windows.Forms.TextBox();
            this.flpanel_items = new ApplicationLauncher.Controls.LauncherItemFlowLayoutPanel();
            this.gbx_other = new System.Windows.Forms.GroupBox();
            this.btn_chooseSaveDirectory = new System.Windows.Forms.Button();
            this.txtbx_saveDirectory = new System.Windows.Forms.TextBox();
            this.cbx_favorite = new System.Windows.Forms.CheckBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_default = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_itemSymbol)).BeginInit();
            this.gbx_symbol.SuspendLayout();
            this.gbx_launchSettings.SuspendLayout();
            this.gbx_other.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(448, 434);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 25);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(13, 231);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(94, 231);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteItem.TabIndex = 3;
            this.btn_deleteItem.Text = "Delete";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // picbx_itemSymbol
            // 
            this.picbx_itemSymbol.Location = new System.Drawing.Point(6, 19);
            this.picbx_itemSymbol.Name = "picbx_itemSymbol";
            this.picbx_itemSymbol.Size = new System.Drawing.Size(100, 100);
            this.picbx_itemSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_itemSymbol.TabIndex = 4;
            this.picbx_itemSymbol.TabStop = false;
            // 
            // gbx_symbol
            // 
            this.gbx_symbol.Controls.Add(this.btn_resetSymbol);
            this.gbx_symbol.Controls.Add(this.btn_chooseSymbol);
            this.gbx_symbol.Controls.Add(this.picbx_itemSymbol);
            this.gbx_symbol.Location = new System.Drawing.Point(399, 13);
            this.gbx_symbol.Name = "gbx_symbol";
            this.gbx_symbol.Size = new System.Drawing.Size(129, 190);
            this.gbx_symbol.TabIndex = 5;
            this.gbx_symbol.TabStop = false;
            this.gbx_symbol.Text = "Symbol";
            // 
            // btn_resetSymbol
            // 
            this.btn_resetSymbol.Location = new System.Drawing.Point(7, 158);
            this.btn_resetSymbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_resetSymbol.Name = "btn_resetSymbol";
            this.btn_resetSymbol.Size = new System.Drawing.Size(100, 27);
            this.btn_resetSymbol.TabIndex = 6;
            this.btn_resetSymbol.Text = "Reset symbol";
            this.btn_resetSymbol.UseVisualStyleBackColor = true;
            this.btn_resetSymbol.Click += new System.EventHandler(this.btn_resetSymbol_Click);
            // 
            // btn_chooseSymbol
            // 
            this.btn_chooseSymbol.Location = new System.Drawing.Point(7, 126);
            this.btn_chooseSymbol.Name = "btn_chooseSymbol";
            this.btn_chooseSymbol.Size = new System.Drawing.Size(100, 25);
            this.btn_chooseSymbol.TabIndex = 5;
            this.btn_chooseSymbol.Text = "...";
            this.btn_chooseSymbol.UseVisualStyleBackColor = true;
            this.btn_chooseSymbol.Click += new System.EventHandler(this.btn_chooseSymbol_Click);
            // 
            // gbx_launchSettings
            // 
            this.gbx_launchSettings.Controls.Add(this.btn_applyTxtbxContents);
            this.gbx_launchSettings.Controls.Add(this.btn_help);
            this.gbx_launchSettings.Controls.Add(this.txtbx_args);
            this.gbx_launchSettings.Controls.Add(this.cbx_launchArgs);
            this.gbx_launchSettings.Controls.Add(this.label1);
            this.gbx_launchSettings.Controls.Add(this.txtbx_itemName);
            this.gbx_launchSettings.Location = new System.Drawing.Point(13, 260);
            this.gbx_launchSettings.Name = "gbx_launchSettings";
            this.gbx_launchSettings.Size = new System.Drawing.Size(309, 199);
            this.gbx_launchSettings.TabIndex = 6;
            this.gbx_launchSettings.TabStop = false;
            this.gbx_launchSettings.Text = "Launch settings";
            // 
            // btn_applyTxtbxContents
            // 
            this.btn_applyTxtbxContents.Location = new System.Drawing.Point(7, 170);
            this.btn_applyTxtbxContents.Name = "btn_applyTxtbxContents";
            this.btn_applyTxtbxContents.Size = new System.Drawing.Size(75, 23);
            this.btn_applyTxtbxContents.TabIndex = 8;
            this.btn_applyTxtbxContents.Text = "Apply";
            this.btn_applyTxtbxContents.UseVisualStyleBackColor = true;
            this.btn_applyTxtbxContents.Click += new System.EventHandler(this.btn_applyTxtbxContents_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(229, 62);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(21, 23);
            this.btn_help.TabIndex = 4;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // txtbx_args
            // 
            this.txtbx_args.Enabled = false;
            this.txtbx_args.Location = new System.Drawing.Point(7, 91);
            this.txtbx_args.Multiline = true;
            this.txtbx_args.Name = "txtbx_args";
            this.txtbx_args.Size = new System.Drawing.Size(292, 76);
            this.txtbx_args.TabIndex = 3;
            // 
            // cbx_launchArgs
            // 
            this.cbx_launchArgs.AutoSize = true;
            this.cbx_launchArgs.Location = new System.Drawing.Point(6, 62);
            this.cbx_launchArgs.Name = "cbx_launchArgs";
            this.cbx_launchArgs.Size = new System.Drawing.Size(217, 17);
            this.cbx_launchArgs.TabIndex = 2;
            this.cbx_launchArgs.Text = "Additional launch arguments (Advanced)";
            this.cbx_launchArgs.UseVisualStyleBackColor = true;
            this.cbx_launchArgs.CheckedChanged += new System.EventHandler(this.cbx_launchArgs_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtbx_itemName
            // 
            this.txtbx_itemName.Location = new System.Drawing.Point(6, 36);
            this.txtbx_itemName.Name = "txtbx_itemName";
            this.txtbx_itemName.Size = new System.Drawing.Size(293, 20);
            this.txtbx_itemName.TabIndex = 0;
            // 
            // flpanel_items
            // 
            this.flpanel_items.Location = new System.Drawing.Point(12, 12);
            this.flpanel_items.Name = "flpanel_items";
            this.flpanel_items.Size = new System.Drawing.Size(379, 213);
            this.flpanel_items.TabIndex = 7;
            // 
            // gbx_other
            // 
            this.gbx_other.Controls.Add(this.label2);
            this.gbx_other.Controls.Add(this.btn_default);
            this.gbx_other.Controls.Add(this.btn_restore);
            this.gbx_other.Controls.Add(this.btn_chooseSaveDirectory);
            this.gbx_other.Controls.Add(this.txtbx_saveDirectory);
            this.gbx_other.Controls.Add(this.cbx_favorite);
            this.gbx_other.Location = new System.Drawing.Point(328, 232);
            this.gbx_other.Name = "gbx_other";
            this.gbx_other.Size = new System.Drawing.Size(202, 195);
            this.gbx_other.TabIndex = 8;
            this.gbx_other.TabStop = false;
            this.gbx_other.Text = "Other";
            // 
            // btn_chooseSaveDirectory
            // 
            this.btn_chooseSaveDirectory.Location = new System.Drawing.Point(5, 168);
            this.btn_chooseSaveDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_chooseSaveDirectory.Name = "btn_chooseSaveDirectory";
            this.btn_chooseSaveDirectory.Size = new System.Drawing.Size(30, 19);
            this.btn_chooseSaveDirectory.TabIndex = 2;
            this.btn_chooseSaveDirectory.Text = "...";
            this.btn_chooseSaveDirectory.UseVisualStyleBackColor = true;
            this.btn_chooseSaveDirectory.Click += new System.EventHandler(this.btn_chooseSaveDirectory_Click);
            // 
            // txtbx_saveDirectory
            // 
            this.txtbx_saveDirectory.Location = new System.Drawing.Point(7, 54);
            this.txtbx_saveDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_saveDirectory.Multiline = true;
            this.txtbx_saveDirectory.Name = "txtbx_saveDirectory";
            this.txtbx_saveDirectory.Size = new System.Drawing.Size(192, 110);
            this.txtbx_saveDirectory.TabIndex = 1;
            // 
            // cbx_favorite
            // 
            this.cbx_favorite.AutoSize = true;
            this.cbx_favorite.Location = new System.Drawing.Point(7, 19);
            this.cbx_favorite.Name = "cbx_favorite";
            this.cbx_favorite.Size = new System.Drawing.Size(75, 17);
            this.cbx_favorite.TabIndex = 0;
            this.cbx_favorite.Text = "Is Favorite";
            this.cbx_favorite.UseVisualStyleBackColor = true;
            this.cbx_favorite.CheckedChanged += new System.EventHandler(this.cbx_favorite_CheckedChanged);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(78, 169);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(56, 19);
            this.btn_restore.TabIndex = 3;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(140, 169);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(56, 19);
            this.btn_default.TabIndex = 4;
            this.btn_default.Text = "Default";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Savepath";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 471);
            this.Controls.Add(this.gbx_other);
            this.Controls.Add(this.flpanel_items);
            this.Controls.Add(this.gbx_launchSettings);
            this.Controls.Add(this.gbx_symbol);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_itemSymbol)).EndInit();
            this.gbx_symbol.ResumeLayout(false);
            this.gbx_launchSettings.ResumeLayout(false);
            this.gbx_launchSettings.PerformLayout();
            this.gbx_other.ResumeLayout(false);
            this.gbx_other.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.PictureBox picbx_itemSymbol;
        private System.Windows.Forms.GroupBox gbx_symbol;
        private System.Windows.Forms.Button btn_chooseSymbol;
        private System.Windows.Forms.GroupBox gbx_launchSettings;
        private System.Windows.Forms.TextBox txtbx_args;
        private System.Windows.Forms.CheckBox cbx_launchArgs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_itemName;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_applyTxtbxContents;
        private Controls.LauncherItemFlowLayoutPanel flpanel_items;
        private System.Windows.Forms.GroupBox gbx_other;
        private System.Windows.Forms.CheckBox cbx_favorite;
        private System.Windows.Forms.Button btn_chooseSaveDirectory;
        private System.Windows.Forms.TextBox txtbx_saveDirectory;
        private System.Windows.Forms.Button btn_resetSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_restore;
    }
}