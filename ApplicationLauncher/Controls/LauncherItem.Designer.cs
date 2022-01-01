namespace ApplicationLauncher.Controls
{
    partial class LauncherItem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbx_symbol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_symbol)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx_symbol
            // 
            this.picbx_symbol.Location = new System.Drawing.Point(0, 0);
            this.picbx_symbol.Name = "picbx_symbol";
            this.picbx_symbol.Size = new System.Drawing.Size(50, 50);
            this.picbx_symbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_symbol.TabIndex = 0;
            this.picbx_symbol.TabStop = false;
            // 
            // LauncherItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picbx_symbol);
            this.Name = "LauncherItem";
            this.Size = new System.Drawing.Size(50, 50);
            this.Load += new System.EventHandler(this.LauncherItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_symbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_symbol;
    }
}
