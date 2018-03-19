namespace Bf2_Registry_Manager
{
    partial class GameDir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDir));
            this.txtBx_Dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.PicBx_Logo = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBx_Dir
            // 
            this.txtBx_Dir.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBx_Dir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_Dir.ForeColor = System.Drawing.Color.Gray;
            this.txtBx_Dir.Location = new System.Drawing.Point(160, 113);
            this.txtBx_Dir.Name = "txtBx_Dir";
            this.txtBx_Dir.ReadOnly = true;
            this.txtBx_Dir.Size = new System.Drawing.Size(460, 26);
            this.txtBx_Dir.TabIndex = 15;
            this.txtBx_Dir.Text = "...\\BF2.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Open Your Game Directory";
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.Btn_Ok.FlatAppearance.BorderSize = 3;
            this.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ok.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ok.ForeColor = System.Drawing.Color.Black;
            this.Btn_Ok.Location = new System.Drawing.Point(508, 181);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(112, 46);
            this.Btn_Ok.TabIndex = 12;
            this.Btn_Ok.Text = "Install";
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // PicBx_Logo
            // 
            this.PicBx_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicBx_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PicBx_Logo.Image")));
            this.PicBx_Logo.Location = new System.Drawing.Point(0, 0);
            this.PicBx_Logo.Name = "PicBx_Logo";
            this.PicBx_Logo.Size = new System.Drawing.Size(154, 239);
            this.PicBx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_Logo.TabIndex = 11;
            this.PicBx_Logo.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "BF2 |*.exe";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(98)))), ((int)(((byte)(73)))));
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(496, 145);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(124, 28);
            this.Search_btn.TabIndex = 14;
            this.Search_btn.Text = "Search The Directory";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "to proceed you need to select where your game is installed";
            // 
            // GameDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(152)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(632, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_Dir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.PicBx_Logo);
            this.Controls.Add(this.Search_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameDir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameDir";
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_Dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.PictureBox PicBx_Logo;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label label2;
    }
}