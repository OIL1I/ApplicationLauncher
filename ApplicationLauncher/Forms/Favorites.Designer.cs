namespace ApplicationLauncher.Forms
{
    partial class Favorites
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
            this.components = new System.ComponentModel.Container();
            this.btn_hide = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.flpannel_items = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(412, 12);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(25, 25);
            this.btn_hide.TabIndex = 0;
            this.btn_hide.Text = "X";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "App Launcher";
            this.notifyIcon1.Visible = true;
            // 
            // flpannel_items
            // 
            this.flpannel_items.Location = new System.Drawing.Point(13, 12);
            this.flpannel_items.Name = "flpannel_items";
            this.flpannel_items.Size = new System.Drawing.Size(393, 126);
            this.flpannel_items.TabIndex = 1;
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 150);
            this.ControlBox = false;
            this.Controls.Add(this.flpannel_items);
            this.Controls.Add(this.btn_hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Favorites";
            this.ShowInTaskbar = false;
            this.Text = "Favorites";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Favorites_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FlowLayoutPanel flpannel_items;
    }
}