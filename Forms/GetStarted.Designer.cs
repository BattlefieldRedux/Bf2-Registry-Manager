namespace Bf2_Registry_Manager
{
    partial class GetStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStarted));
            this.TopPainel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.Install_radioBtn = new System.Windows.Forms.RadioButton();
            this.Change_radioBtn = new System.Windows.Forms.RadioButton();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TopPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPainel
            // 
            this.TopPainel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(152)))), ((int)(((byte)(123)))));
            this.TopPainel.Controls.Add(this.pictureBox1);
            this.TopPainel.Controls.Add(this.Close_Btn);
            this.TopPainel.Controls.Add(this.Title_lbl);
            this.TopPainel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPainel.Location = new System.Drawing.Point(0, 0);
            this.TopPainel.Name = "TopPainel";
            this.TopPainel.Size = new System.Drawing.Size(586, 100);
            this.TopPainel.TabIndex = 0;
            this.TopPainel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPainel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Close_Btn
            // 
            this.Close_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_Btn.BackgroundImage")));
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.Location = new System.Drawing.Point(553, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(30, 30);
            this.Close_Btn.TabIndex = 16;
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lbl.Location = new System.Drawing.Point(12, 18);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(293, 34);
            this.Title_lbl.TabIndex = 10;
            this.Title_lbl.Text = "Battlefiled Registry Manager";
            // 
            // Install_radioBtn
            // 
            this.Install_radioBtn.AutoSize = true;
            this.Install_radioBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Install_radioBtn.Location = new System.Drawing.Point(18, 173);
            this.Install_radioBtn.Name = "Install_radioBtn";
            this.Install_radioBtn.Size = new System.Drawing.Size(132, 20);
            this.Install_radioBtn.TabIndex = 25;
            this.Install_radioBtn.TabStop = true;
            this.Install_radioBtn.Text = "Install New BF2 Registry";
            this.Install_radioBtn.UseVisualStyleBackColor = true;
            // 
            // Change_radioBtn
            // 
            this.Change_radioBtn.AutoSize = true;
            this.Change_radioBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Change_radioBtn.Location = new System.Drawing.Point(18, 261);
            this.Change_radioBtn.Name = "Change_radioBtn";
            this.Change_radioBtn.Size = new System.Drawing.Size(111, 20);
            this.Change_radioBtn.TabIndex = 24;
            this.Change_radioBtn.TabStop = true;
            this.Change_radioBtn.Text = "Change the CD-KEY";
            this.Change_radioBtn.UseVisualStyleBackColor = true;
            // 
            // Next_Btn
            // 
            this.Next_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Btn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Btn.Location = new System.Drawing.Point(484, 360);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(90, 29);
            this.Next_Btn.TabIndex = 23;
            this.Next_Btn.Text = "Next";
            this.Next_Btn.UseVisualStyleBackColor = true;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.label5.Location = new System.Drawing.Point(60, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Only change the CD-KEY\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_lbl.Location = new System.Drawing.Point(12, 103);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(375, 32);
            this.Info_lbl.TabIndex = 20;
            this.Info_lbl.Text = "Welcome. This page allow you choose what you want to do with battlefield Registry" +
    ".\r\nChoose Any option below and click Next";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.label2.Location = new System.Drawing.Point(60, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Install a new BF2 registry or Reinstall if it already exists [ RECOMMENDED ]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // GetStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 401);
            this.Controls.Add(this.Install_radioBtn);
            this.Controls.Add(this.Change_radioBtn);
            this.Controls.Add(this.Next_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Info_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TopPainel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetStarted";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopPainel.ResumeLayout(false);
            this.TopPainel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPainel;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.RadioButton Install_radioBtn;
        private System.Windows.Forms.RadioButton Change_radioBtn;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}