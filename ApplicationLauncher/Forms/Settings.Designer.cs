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
            this.btn_resetSymbol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_itemSymbol)).BeginInit();
            this.gbx_symbol.SuspendLayout();
            this.gbx_launchSettings.SuspendLayout();
            this.gbx_other.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(597, 534);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 31);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(17, 284);
            this.btn_addItem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(100, 28);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(125, 284);
            this.btn_deleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(100, 28);
            this.btn_deleteItem.TabIndex = 3;
            this.btn_deleteItem.Text = "Delete";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // picbx_itemSymbol
            // 
            this.picbx_itemSymbol.Location = new System.Drawing.Point(8, 23);
            this.picbx_itemSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.picbx_itemSymbol.Name = "picbx_itemSymbol";
            this.picbx_itemSymbol.Size = new System.Drawing.Size(133, 123);
            this.picbx_itemSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_itemSymbol.TabIndex = 4;
            this.picbx_itemSymbol.TabStop = false;
            // 
            // gbx_symbol
            // 
            this.gbx_symbol.Controls.Add(this.btn_resetSymbol);
            this.gbx_symbol.Controls.Add(this.btn_chooseSymbol);
            this.gbx_symbol.Controls.Add(this.picbx_itemSymbol);
            this.gbx_symbol.Location = new System.Drawing.Point(532, 16);
            this.gbx_symbol.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_symbol.Name = "gbx_symbol";
            this.gbx_symbol.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_symbol.Size = new System.Drawing.Size(172, 234);
            this.gbx_symbol.TabIndex = 5;
            this.gbx_symbol.TabStop = false;
            this.gbx_symbol.Text = "Symbol";
            // 
            // btn_chooseSymbol
            // 
            this.btn_chooseSymbol.Location = new System.Drawing.Point(9, 155);
            this.btn_chooseSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chooseSymbol.Name = "btn_chooseSymbol";
            this.btn_chooseSymbol.Size = new System.Drawing.Size(133, 31);
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
            this.gbx_launchSettings.Location = new System.Drawing.Point(17, 320);
            this.gbx_launchSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_launchSettings.Name = "gbx_launchSettings";
            this.gbx_launchSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_launchSettings.Size = new System.Drawing.Size(412, 245);
            this.gbx_launchSettings.TabIndex = 6;
            this.gbx_launchSettings.TabStop = false;
            this.gbx_launchSettings.Text = "Launch settings";
            // 
            // btn_applyTxtbxContents
            // 
            this.btn_applyTxtbxContents.Location = new System.Drawing.Point(9, 209);
            this.btn_applyTxtbxContents.Margin = new System.Windows.Forms.Padding(4);
            this.btn_applyTxtbxContents.Name = "btn_applyTxtbxContents";
            this.btn_applyTxtbxContents.Size = new System.Drawing.Size(100, 28);
            this.btn_applyTxtbxContents.TabIndex = 8;
            this.btn_applyTxtbxContents.Text = "Apply";
            this.btn_applyTxtbxContents.UseVisualStyleBackColor = true;
            this.btn_applyTxtbxContents.Click += new System.EventHandler(this.btn_applyTxtbxContents_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(305, 76);
            this.btn_help.Margin = new System.Windows.Forms.Padding(4);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(28, 28);
            this.btn_help.TabIndex = 4;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // txtbx_args
            // 
            this.txtbx_args.Enabled = false;
            this.txtbx_args.Location = new System.Drawing.Point(9, 112);
            this.txtbx_args.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_args.Multiline = true;
            this.txtbx_args.Name = "txtbx_args";
            this.txtbx_args.Size = new System.Drawing.Size(388, 93);
            this.txtbx_args.TabIndex = 3;
            // 
            // cbx_launchArgs
            // 
            this.cbx_launchArgs.AutoSize = true;
            this.cbx_launchArgs.Location = new System.Drawing.Point(8, 76);
            this.cbx_launchArgs.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_launchArgs.Name = "cbx_launchArgs";
            this.cbx_launchArgs.Size = new System.Drawing.Size(270, 20);
            this.cbx_launchArgs.TabIndex = 2;
            this.cbx_launchArgs.Text = "Additional launch arguments (Advanced)";
            this.cbx_launchArgs.UseVisualStyleBackColor = true;
            this.cbx_launchArgs.CheckedChanged += new System.EventHandler(this.cbx_launchArgs_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtbx_itemName
            // 
            this.txtbx_itemName.Location = new System.Drawing.Point(8, 44);
            this.txtbx_itemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_itemName.Name = "txtbx_itemName";
            this.txtbx_itemName.Size = new System.Drawing.Size(389, 22);
            this.txtbx_itemName.TabIndex = 0;
            // 
            // flpanel_items
            // 
            this.flpanel_items.Location = new System.Drawing.Point(16, 15);
            this.flpanel_items.Margin = new System.Windows.Forms.Padding(4);
            this.flpanel_items.Name = "flpanel_items";
            this.flpanel_items.Size = new System.Drawing.Size(505, 262);
            this.flpanel_items.TabIndex = 7;
            // 
            // gbx_other
            // 
            this.gbx_other.Controls.Add(this.btn_chooseSaveDirectory);
            this.gbx_other.Controls.Add(this.txtbx_saveDirectory);
            this.gbx_other.Controls.Add(this.cbx_favorite);
            this.gbx_other.Location = new System.Drawing.Point(437, 285);
            this.gbx_other.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_other.Name = "gbx_other";
            this.gbx_other.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_other.Size = new System.Drawing.Size(270, 240);
            this.gbx_other.TabIndex = 8;
            this.gbx_other.TabStop = false;
            this.gbx_other.Text = "Other";
            // 
            // btn_chooseSaveDirectory
            // 
            this.btn_chooseSaveDirectory.Location = new System.Drawing.Point(8, 193);
            this.btn_chooseSaveDirectory.Name = "btn_chooseSaveDirectory";
            this.btn_chooseSaveDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_chooseSaveDirectory.TabIndex = 2;
            this.btn_chooseSaveDirectory.Text = "...";
            this.btn_chooseSaveDirectory.UseVisualStyleBackColor = true;
            this.btn_chooseSaveDirectory.Click += new System.EventHandler(this.btn_chooseSaveDirectory_Click);
            // 
            // txtbx_saveDirectory
            // 
            this.txtbx_saveDirectory.Location = new System.Drawing.Point(8, 51);
            this.txtbx_saveDirectory.Multiline = true;
            this.txtbx_saveDirectory.Name = "txtbx_saveDirectory";
            this.txtbx_saveDirectory.Size = new System.Drawing.Size(255, 135);
            this.txtbx_saveDirectory.TabIndex = 1;
            // 
            // cbx_favorite
            // 
            this.cbx_favorite.AutoSize = true;
            this.cbx_favorite.Location = new System.Drawing.Point(9, 23);
            this.cbx_favorite.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_favorite.Name = "cbx_favorite";
            this.cbx_favorite.Size = new System.Drawing.Size(91, 20);
            this.cbx_favorite.TabIndex = 0;
            this.cbx_favorite.Text = "Is Favorite";
            this.cbx_favorite.UseVisualStyleBackColor = true;
            this.cbx_favorite.CheckedChanged += new System.EventHandler(this.cbx_favorite_CheckedChanged);
            // 
            // btn_resetSymbol
            // 
            this.btn_resetSymbol.Location = new System.Drawing.Point(9, 194);
            this.btn_resetSymbol.Name = "btn_resetSymbol";
            this.btn_resetSymbol.Size = new System.Drawing.Size(133, 33);
            this.btn_resetSymbol.TabIndex = 6;
            this.btn_resetSymbol.Text = "Reset symbol";
            this.btn_resetSymbol.UseVisualStyleBackColor = true;
            this.btn_resetSymbol.Click += new System.EventHandler(this.btn_resetSymbol_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 580);
            this.Controls.Add(this.gbx_other);
            this.Controls.Add(this.flpanel_items);
            this.Controls.Add(this.gbx_launchSettings);
            this.Controls.Add(this.gbx_symbol);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}