namespace ApplicationLauncher.Forms
{
    partial class AllApps
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
            this.flp_items = new ApplicationLauncher.Controls.ItemFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_items
            // 
            this.flp_items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_items.Location = new System.Drawing.Point(10, 11);
            this.flp_items.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flp_items.Name = "flp_items";
            this.flp_items.Size = new System.Drawing.Size(667, 404);
            this.flp_items.TabIndex = 0;
            // 
            // AllApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 424);
            this.Controls.Add(this.flp_items);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Applications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllApps_FormClosed);
            this.Load += new System.EventHandler(this.AllApps_Load);
            this.SizeChanged += new System.EventHandler(this.AllApps_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ItemFlowLayoutPanel flp_items;
    }
}