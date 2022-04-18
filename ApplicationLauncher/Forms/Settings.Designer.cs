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
            this.tabctrl_settings = new System.Windows.Forms.TabControl();
            this.tabpage_items = new System.Windows.Forms.TabPage();
            this.cbx_favorite = new System.Windows.Forms.CheckBox();
            this.gbx_launchSettings = new System.Windows.Forms.GroupBox();
            this.btn_applyTxtbxContents = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.txtbx_args = new System.Windows.Forms.TextBox();
            this.cbx_launchArgs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_itemName = new System.Windows.Forms.TextBox();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.gbx_symbol = new System.Windows.Forms.GroupBox();
            this.btn_resetSymbol = new System.Windows.Forms.Button();
            this.btn_chooseSymbol = new System.Windows.Forms.Button();
            this.picbx_itemSymbol = new System.Windows.Forms.PictureBox();
            this.flpanel_items = new ApplicationLauncher.Controls.ItemFlowLayoutPanel();
            this.tabpage_folder = new System.Windows.Forms.TabPage();
            this.gbx_folderAttributes = new System.Windows.Forms.GroupBox();
            this.btn_changeClosedFolderIcon = new System.Windows.Forms.Button();
            this.btn_changeOpenFolderIcon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picbx_closedFolder = new System.Windows.Forms.PictureBox();
            this.picbx_openFolder = new System.Windows.Forms.PictureBox();
            this.txtbx_folderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbx_folderContents = new System.Windows.Forms.GroupBox();
            this.lstbx_folderContents = new System.Windows.Forms.ListBox();
            this.btn_manageFolderContents = new System.Windows.Forms.Button();
            this.btn_removeFolder = new System.Windows.Forms.Button();
            this.btn_addFolder = new System.Windows.Forms.Button();
            this.flpanel_folders = new ApplicationLauncher.Controls.ItemFlowLayoutPanel();
            this.tabpage_launcher = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_default = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_chooseSaveDirectory = new System.Windows.Forms.Button();
            this.txtbx_saveDirectory = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tabctrl_settings.SuspendLayout();
            this.tabpage_items.SuspendLayout();
            this.gbx_launchSettings.SuspendLayout();
            this.gbx_symbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_itemSymbol)).BeginInit();
            this.tabpage_folder.SuspendLayout();
            this.gbx_folderAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_closedFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_openFolder)).BeginInit();
            this.gbx_folderContents.SuspendLayout();
            this.tabpage_launcher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrl_settings
            // 
            this.tabctrl_settings.Controls.Add(this.tabpage_items);
            this.tabctrl_settings.Controls.Add(this.tabpage_folder);
            this.tabctrl_settings.Controls.Add(this.tabpage_launcher);
            this.tabctrl_settings.Location = new System.Drawing.Point(-1, 0);
            this.tabctrl_settings.Name = "tabctrl_settings";
            this.tabctrl_settings.SelectedIndex = 0;
            this.tabctrl_settings.Size = new System.Drawing.Size(551, 483);
            this.tabctrl_settings.TabIndex = 0;
            // 
            // tabpage_items
            // 
            this.tabpage_items.Controls.Add(this.cbx_favorite);
            this.tabpage_items.Controls.Add(this.gbx_launchSettings);
            this.tabpage_items.Controls.Add(this.btn_deleteItem);
            this.tabpage_items.Controls.Add(this.btn_addItem);
            this.tabpage_items.Controls.Add(this.gbx_symbol);
            this.tabpage_items.Controls.Add(this.flpanel_items);
            this.tabpage_items.Location = new System.Drawing.Point(4, 22);
            this.tabpage_items.Name = "tabpage_items";
            this.tabpage_items.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_items.Size = new System.Drawing.Size(543, 457);
            this.tabpage_items.TabIndex = 0;
            this.tabpage_items.Text = "Items";
            this.tabpage_items.UseVisualStyleBackColor = true;
            // 
            // cbx_favorite
            // 
            this.cbx_favorite.AutoSize = true;
            this.cbx_favorite.Location = new System.Drawing.Point(396, 202);
            this.cbx_favorite.Name = "cbx_favorite";
            this.cbx_favorite.Size = new System.Drawing.Size(75, 17);
            this.cbx_favorite.TabIndex = 20;
            this.cbx_favorite.Text = "Is Favorite";
            this.cbx_favorite.UseVisualStyleBackColor = true;
            this.cbx_favorite.CheckedChanged += new System.EventHandler(this.cbx_favorite_CheckedChanged);
            // 
            // gbx_launchSettings
            // 
            this.gbx_launchSettings.Controls.Add(this.btn_applyTxtbxContents);
            this.gbx_launchSettings.Controls.Add(this.btn_help);
            this.gbx_launchSettings.Controls.Add(this.txtbx_args);
            this.gbx_launchSettings.Controls.Add(this.cbx_launchArgs);
            this.gbx_launchSettings.Controls.Add(this.label1);
            this.gbx_launchSettings.Controls.Add(this.txtbx_itemName);
            this.gbx_launchSettings.Location = new System.Drawing.Point(9, 249);
            this.gbx_launchSettings.Name = "gbx_launchSettings";
            this.gbx_launchSettings.Size = new System.Drawing.Size(516, 199);
            this.gbx_launchSettings.TabIndex = 19;
            this.gbx_launchSettings.TabStop = false;
            this.gbx_launchSettings.Text = "Launch settings";
            // 
            // btn_applyTxtbxContents
            // 
            this.btn_applyTxtbxContents.Location = new System.Drawing.Point(435, 173);
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
            this.txtbx_args.Size = new System.Drawing.Size(503, 76);
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
            this.txtbx_itemName.Size = new System.Drawing.Size(504, 20);
            this.txtbx_itemName.TabIndex = 0;
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(90, 220);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteItem.TabIndex = 18;
            this.btn_deleteItem.Text = "Delete";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(9, 220);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 17;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // gbx_symbol
            // 
            this.gbx_symbol.Controls.Add(this.btn_resetSymbol);
            this.gbx_symbol.Controls.Add(this.btn_chooseSymbol);
            this.gbx_symbol.Controls.Add(this.picbx_itemSymbol);
            this.gbx_symbol.Location = new System.Drawing.Point(396, 6);
            this.gbx_symbol.Name = "gbx_symbol";
            this.gbx_symbol.Size = new System.Drawing.Size(129, 190);
            this.gbx_symbol.TabIndex = 16;
            this.gbx_symbol.TabStop = false;
            this.gbx_symbol.Text = "Symbol";
            // 
            // btn_resetSymbol
            // 
            this.btn_resetSymbol.Location = new System.Drawing.Point(7, 158);
            this.btn_resetSymbol.Margin = new System.Windows.Forms.Padding(2);
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
            // picbx_itemSymbol
            // 
            this.picbx_itemSymbol.Location = new System.Drawing.Point(6, 19);
            this.picbx_itemSymbol.Name = "picbx_itemSymbol";
            this.picbx_itemSymbol.Size = new System.Drawing.Size(100, 100);
            this.picbx_itemSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_itemSymbol.TabIndex = 4;
            this.picbx_itemSymbol.TabStop = false;
            // 
            // flpanel_items
            // 
            this.flpanel_items.Location = new System.Drawing.Point(6, 6);
            this.flpanel_items.Name = "flpanel_items";
            this.flpanel_items.Size = new System.Drawing.Size(379, 213);
            this.flpanel_items.TabIndex = 15;
            // 
            // tabpage_folder
            // 
            this.tabpage_folder.Controls.Add(this.gbx_folderAttributes);
            this.tabpage_folder.Controls.Add(this.gbx_folderContents);
            this.tabpage_folder.Controls.Add(this.btn_removeFolder);
            this.tabpage_folder.Controls.Add(this.btn_addFolder);
            this.tabpage_folder.Controls.Add(this.flpanel_folders);
            this.tabpage_folder.Location = new System.Drawing.Point(4, 22);
            this.tabpage_folder.Name = "tabpage_folder";
            this.tabpage_folder.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_folder.Size = new System.Drawing.Size(543, 457);
            this.tabpage_folder.TabIndex = 1;
            this.tabpage_folder.Text = "Folder";
            this.tabpage_folder.UseVisualStyleBackColor = true;
            // 
            // gbx_folderAttributes
            // 
            this.gbx_folderAttributes.Controls.Add(this.btn_changeClosedFolderIcon);
            this.gbx_folderAttributes.Controls.Add(this.btn_changeOpenFolderIcon);
            this.gbx_folderAttributes.Controls.Add(this.label6);
            this.gbx_folderAttributes.Controls.Add(this.label5);
            this.gbx_folderAttributes.Controls.Add(this.label4);
            this.gbx_folderAttributes.Controls.Add(this.picbx_closedFolder);
            this.gbx_folderAttributes.Controls.Add(this.picbx_openFolder);
            this.gbx_folderAttributes.Controls.Add(this.txtbx_folderName);
            this.gbx_folderAttributes.Controls.Add(this.label3);
            this.gbx_folderAttributes.Location = new System.Drawing.Point(10, 248);
            this.gbx_folderAttributes.Name = "gbx_folderAttributes";
            this.gbx_folderAttributes.Size = new System.Drawing.Size(228, 168);
            this.gbx_folderAttributes.TabIndex = 8;
            this.gbx_folderAttributes.TabStop = false;
            this.gbx_folderAttributes.Text = "Folder";
            // 
            // btn_changeClosedFolderIcon
            // 
            this.btn_changeClosedFolderIcon.Location = new System.Drawing.Point(152, 115);
            this.btn_changeClosedFolderIcon.Name = "btn_changeClosedFolderIcon";
            this.btn_changeClosedFolderIcon.Size = new System.Drawing.Size(27, 23);
            this.btn_changeClosedFolderIcon.TabIndex = 12;
            this.btn_changeClosedFolderIcon.Text = "...";
            this.btn_changeClosedFolderIcon.UseVisualStyleBackColor = true;
            // 
            // btn_changeOpenFolderIcon
            // 
            this.btn_changeOpenFolderIcon.Location = new System.Drawing.Point(62, 115);
            this.btn_changeOpenFolderIcon.Name = "btn_changeOpenFolderIcon";
            this.btn_changeOpenFolderIcon.Size = new System.Drawing.Size(27, 23);
            this.btn_changeOpenFolderIcon.TabIndex = 11;
            this.btn_changeOpenFolderIcon.Text = "...";
            this.btn_changeOpenFolderIcon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Closed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Open";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Folder Icons";
            // 
            // picbx_closedFolder
            // 
            this.picbx_closedFolder.Location = new System.Drawing.Point(96, 88);
            this.picbx_closedFolder.Name = "picbx_closedFolder";
            this.picbx_closedFolder.Size = new System.Drawing.Size(50, 50);
            this.picbx_closedFolder.TabIndex = 7;
            this.picbx_closedFolder.TabStop = false;
            // 
            // picbx_openFolder
            // 
            this.picbx_openFolder.Location = new System.Drawing.Point(6, 88);
            this.picbx_openFolder.Name = "picbx_openFolder";
            this.picbx_openFolder.Size = new System.Drawing.Size(50, 50);
            this.picbx_openFolder.TabIndex = 6;
            this.picbx_openFolder.TabStop = false;
            // 
            // txtbx_folderName
            // 
            this.txtbx_folderName.Location = new System.Drawing.Point(6, 37);
            this.txtbx_folderName.Name = "txtbx_folderName";
            this.txtbx_folderName.Size = new System.Drawing.Size(216, 20);
            this.txtbx_folderName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // gbx_folderContents
            // 
            this.gbx_folderContents.Controls.Add(this.lstbx_folderContents);
            this.gbx_folderContents.Controls.Add(this.btn_manageFolderContents);
            this.gbx_folderContents.Location = new System.Drawing.Point(337, 218);
            this.gbx_folderContents.Name = "gbx_folderContents";
            this.gbx_folderContents.Size = new System.Drawing.Size(200, 219);
            this.gbx_folderContents.TabIndex = 7;
            this.gbx_folderContents.TabStop = false;
            this.gbx_folderContents.Text = "Folder Contents";
            // 
            // lstbx_folderContents
            // 
            this.lstbx_folderContents.FormattingEnabled = true;
            this.lstbx_folderContents.Location = new System.Drawing.Point(6, 19);
            this.lstbx_folderContents.Name = "lstbx_folderContents";
            this.lstbx_folderContents.Size = new System.Drawing.Size(188, 160);
            this.lstbx_folderContents.TabIndex = 6;
            // 
            // btn_manageFolderContents
            // 
            this.btn_manageFolderContents.Location = new System.Drawing.Point(6, 190);
            this.btn_manageFolderContents.Name = "btn_manageFolderContents";
            this.btn_manageFolderContents.Size = new System.Drawing.Size(130, 23);
            this.btn_manageFolderContents.TabIndex = 3;
            this.btn_manageFolderContents.Text = "Manage Folder contents";
            this.btn_manageFolderContents.UseVisualStyleBackColor = true;
            this.btn_manageFolderContents.Click += new System.EventHandler(this.btn_manageFolderContents_Click);
            // 
            // btn_removeFolder
            // 
            this.btn_removeFolder.Location = new System.Drawing.Point(92, 217);
            this.btn_removeFolder.Name = "btn_removeFolder";
            this.btn_removeFolder.Size = new System.Drawing.Size(92, 23);
            this.btn_removeFolder.TabIndex = 2;
            this.btn_removeFolder.Text = "Remove Folder";
            this.btn_removeFolder.UseVisualStyleBackColor = true;
            this.btn_removeFolder.Click += new System.EventHandler(this.btn_removeFolder_Click);
            // 
            // btn_addFolder
            // 
            this.btn_addFolder.Location = new System.Drawing.Point(10, 218);
            this.btn_addFolder.Name = "btn_addFolder";
            this.btn_addFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_addFolder.TabIndex = 1;
            this.btn_addFolder.Text = "Add Folder";
            this.btn_addFolder.UseVisualStyleBackColor = true;
            this.btn_addFolder.Click += new System.EventHandler(this.btn_addFolder_Click);
            // 
            // flpanel_folders
            // 
            this.flpanel_folders.Location = new System.Drawing.Point(10, 7);
            this.flpanel_folders.Name = "flpanel_folders";
            this.flpanel_folders.Size = new System.Drawing.Size(527, 204);
            this.flpanel_folders.TabIndex = 0;
            // 
            // tabpage_launcher
            // 
            this.tabpage_launcher.Controls.Add(this.label2);
            this.tabpage_launcher.Controls.Add(this.btn_default);
            this.tabpage_launcher.Controls.Add(this.btn_restore);
            this.tabpage_launcher.Controls.Add(this.btn_chooseSaveDirectory);
            this.tabpage_launcher.Controls.Add(this.txtbx_saveDirectory);
            this.tabpage_launcher.Location = new System.Drawing.Point(4, 22);
            this.tabpage_launcher.Name = "tabpage_launcher";
            this.tabpage_launcher.Size = new System.Drawing.Size(543, 457);
            this.tabpage_launcher.TabIndex = 2;
            this.tabpage_launcher.Text = "Launcher";
            this.tabpage_launcher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Savepath";
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(142, 144);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(56, 19);
            this.btn_default.TabIndex = 26;
            this.btn_default.Text = "Default";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(80, 144);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(56, 19);
            this.btn_restore.TabIndex = 25;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_chooseSaveDirectory
            // 
            this.btn_chooseSaveDirectory.Location = new System.Drawing.Point(6, 142);
            this.btn_chooseSaveDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chooseSaveDirectory.Name = "btn_chooseSaveDirectory";
            this.btn_chooseSaveDirectory.Size = new System.Drawing.Size(30, 19);
            this.btn_chooseSaveDirectory.TabIndex = 24;
            this.btn_chooseSaveDirectory.Text = "...";
            this.btn_chooseSaveDirectory.UseVisualStyleBackColor = true;
            this.btn_chooseSaveDirectory.Click += new System.EventHandler(this.btn_chooseSaveDirectory_Click);
            // 
            // txtbx_saveDirectory
            // 
            this.txtbx_saveDirectory.Location = new System.Drawing.Point(8, 24);
            this.txtbx_saveDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_saveDirectory.Multiline = true;
            this.txtbx_saveDirectory.Name = "txtbx_saveDirectory";
            this.txtbx_saveDirectory.Size = new System.Drawing.Size(192, 113);
            this.txtbx_saveDirectory.TabIndex = 23;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(470, 485);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 25);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 514);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tabctrl_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabctrl_settings.ResumeLayout(false);
            this.tabpage_items.ResumeLayout(false);
            this.tabpage_items.PerformLayout();
            this.gbx_launchSettings.ResumeLayout(false);
            this.gbx_launchSettings.PerformLayout();
            this.gbx_symbol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_itemSymbol)).EndInit();
            this.tabpage_folder.ResumeLayout(false);
            this.gbx_folderAttributes.ResumeLayout(false);
            this.gbx_folderAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_closedFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_openFolder)).EndInit();
            this.gbx_folderContents.ResumeLayout(false);
            this.tabpage_launcher.ResumeLayout(false);
            this.tabpage_launcher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrl_settings;
        private System.Windows.Forms.TabPage tabpage_items;
        private System.Windows.Forms.TabPage tabpage_folder;
        private Controls.ItemFlowLayoutPanel flpanel_items;
        private System.Windows.Forms.GroupBox gbx_symbol;
        private System.Windows.Forms.Button btn_resetSymbol;
        private System.Windows.Forms.Button btn_chooseSymbol;
        private System.Windows.Forms.PictureBox picbx_itemSymbol;
        private System.Windows.Forms.GroupBox gbx_launchSettings;
        private System.Windows.Forms.Button btn_applyTxtbxContents;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TextBox txtbx_args;
        private System.Windows.Forms.CheckBox cbx_launchArgs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_itemName;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabPage tabpage_launcher;
        private System.Windows.Forms.CheckBox cbx_favorite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_chooseSaveDirectory;
        private System.Windows.Forms.TextBox txtbx_saveDirectory;
        private Controls.ItemFlowLayoutPanel flpanel_folders;
        private System.Windows.Forms.GroupBox gbx_folderAttributes;
        private System.Windows.Forms.Button btn_changeClosedFolderIcon;
        private System.Windows.Forms.Button btn_changeOpenFolderIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picbx_closedFolder;
        private System.Windows.Forms.PictureBox picbx_openFolder;
        private System.Windows.Forms.TextBox txtbx_folderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbx_folderContents;
        private System.Windows.Forms.ListBox lstbx_folderContents;
        private System.Windows.Forms.Button btn_manageFolderContents;
        private System.Windows.Forms.Button btn_removeFolder;
        private System.Windows.Forms.Button btn_addFolder;
    }
}