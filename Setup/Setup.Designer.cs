namespace Setup
{
    partial class Setup
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.chckbx_autostart = new System.Windows.Forms.CheckBox();
            this.chckbx_shortcut = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbtn_bottomright = new System.Windows.Forms.RadioButton();
            this.radbtn_topright = new System.Windows.Forms.RadioButton();
            this.radbtn_bottomleft = new System.Windows.Forms.RadioButton();
            this.radbtn_topleft = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the ";
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(177, 285);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(75, 23);
            this.btn_finish.TabIndex = 1;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // chckbx_autostart
            // 
            this.chckbx_autostart.AutoSize = true;
            this.chckbx_autostart.Location = new System.Drawing.Point(13, 66);
            this.chckbx_autostart.Name = "chckbx_autostart";
            this.chckbx_autostart.Size = new System.Drawing.Size(68, 17);
            this.chckbx_autostart.TabIndex = 2;
            this.chckbx_autostart.Text = "Autostart";
            this.chckbx_autostart.UseVisualStyleBackColor = true;
            // 
            // chckbx_shortcut
            // 
            this.chckbx_shortcut.AutoSize = true;
            this.chckbx_shortcut.Location = new System.Drawing.Point(12, 89);
            this.chckbx_shortcut.Name = "chckbx_shortcut";
            this.chckbx_shortcut.Size = new System.Drawing.Size(141, 17);
            this.chckbx_shortcut.TabIndex = 3;
            this.chckbx_shortcut.Text = "Create Desktop shortcut";
            this.chckbx_shortcut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default savepath";
            // 
            // txtbx_path
            // 
            this.txtbx_path.Location = new System.Drawing.Point(12, 143);
            this.txtbx_path.Multiline = true;
            this.txtbx_path.Name = "txtbx_path";
            this.txtbx_path.Size = new System.Drawing.Size(240, 53);
            this.txtbx_path.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtn_bottomright);
            this.groupBox1.Controls.Add(this.radbtn_topright);
            this.groupBox1.Controls.Add(this.radbtn_bottomleft);
            this.groupBox1.Controls.Add(this.radbtn_topleft);
            this.groupBox1.Location = new System.Drawing.Point(13, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starting position";
            // 
            // radbtn_bottomright
            // 
            this.radbtn_bottomright.AutoSize = true;
            this.radbtn_bottomright.Checked = true;
            this.radbtn_bottomright.Location = new System.Drawing.Point(148, 43);
            this.radbtn_bottomright.Name = "radbtn_bottomright";
            this.radbtn_bottomright.Size = new System.Drawing.Size(80, 17);
            this.radbtn_bottomright.TabIndex = 3;
            this.radbtn_bottomright.TabStop = true;
            this.radbtn_bottomright.Text = "bottom right";
            this.radbtn_bottomright.UseVisualStyleBackColor = true;
            // 
            // radbtn_topright
            // 
            this.radbtn_topright.AutoSize = true;
            this.radbtn_topright.Location = new System.Drawing.Point(148, 19);
            this.radbtn_topright.Name = "radbtn_topright";
            this.radbtn_topright.Size = new System.Drawing.Size(63, 17);
            this.radbtn_topright.TabIndex = 2;
            this.radbtn_topright.Text = "top rigth";
            this.radbtn_topright.UseVisualStyleBackColor = true;
            // 
            // radbtn_bottomleft
            // 
            this.radbtn_bottomleft.AutoSize = true;
            this.radbtn_bottomleft.Location = new System.Drawing.Point(7, 43);
            this.radbtn_bottomleft.Name = "radbtn_bottomleft";
            this.radbtn_bottomleft.Size = new System.Drawing.Size(74, 17);
            this.radbtn_bottomleft.TabIndex = 1;
            this.radbtn_bottomleft.Text = "bottom left";
            this.radbtn_bottomleft.UseVisualStyleBackColor = true;
            // 
            // radbtn_topleft
            // 
            this.radbtn_topleft.AutoSize = true;
            this.radbtn_topleft.Location = new System.Drawing.Point(7, 20);
            this.radbtn_topleft.Name = "radbtn_topleft";
            this.radbtn_topleft.Size = new System.Drawing.Size(57, 17);
            this.radbtn_topleft.TabIndex = 0;
            this.radbtn_topleft.Text = "top left";
            this.radbtn_topleft.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "ApplicationLauncher setup!";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbx_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chckbx_shortcut);
            this.Controls.Add(this.chckbx_autostart);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.ShowIcon = false;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.CheckBox chckbx_autostart;
        private System.Windows.Forms.CheckBox chckbx_shortcut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbtn_bottomright;
        private System.Windows.Forms.RadioButton radbtn_topright;
        private System.Windows.Forms.RadioButton radbtn_bottomleft;
        private System.Windows.Forms.RadioButton radbtn_topleft;
        private System.Windows.Forms.Label label3;
    }
}

