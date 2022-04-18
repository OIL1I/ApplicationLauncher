namespace ApplicationLauncher.Forms
{
    partial class ManageFolder
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
            this.flp_folderContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_saveFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_folderContent
            // 
            this.flp_folderContent.Location = new System.Drawing.Point(13, 13);
            this.flp_folderContent.Name = "flp_folderContent";
            this.flp_folderContent.Size = new System.Drawing.Size(709, 411);
            this.flp_folderContent.TabIndex = 0;
            // 
            // btn_saveFolder
            // 
            this.btn_saveFolder.Location = new System.Drawing.Point(647, 442);
            this.btn_saveFolder.Name = "btn_saveFolder";
            this.btn_saveFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_saveFolder.TabIndex = 1;
            this.btn_saveFolder.Text = "Save";
            this.btn_saveFolder.UseVisualStyleBackColor = true;
            this.btn_saveFolder.Click += new System.EventHandler(this.btn_saveFolder_Click);
            // 
            // ManageFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 477);
            this.Controls.Add(this.btn_saveFolder);
            this.Controls.Add(this.flp_folderContent);
            this.Name = "ManageFolder";
            this.Text = "ManageFolder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_folderContent;
        private System.Windows.Forms.Button btn_saveFolder;
    }
}