namespace TOSApp.HT
{
    partial class f000_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f000_login));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_id = new System.Windows.Forms.TextBox();
            this.m_txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cb_chi_nhanh = new System.Windows.Forms.ComboBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.m_lbl_version_build = new System.Windows.Forms.Label();
            this.m_lab_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên truy cập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // m_txt_id
            // 
            this.m_txt_id.Location = new System.Drawing.Point(84, 81);
            this.m_txt_id.Name = "m_txt_id";
            this.m_txt_id.Size = new System.Drawing.Size(163, 20);
            this.m_txt_id.TabIndex = 1;
            this.m_txt_id.Enter += new System.EventHandler(this.m_txt_id_Enter);
            // 
            // m_txt_pass
            // 
            this.m_txt_pass.Location = new System.Drawing.Point(84, 120);
            this.m_txt_pass.Name = "m_txt_pass";
            this.m_txt_pass.PasswordChar = '*';
            this.m_txt_pass.Size = new System.Drawing.Size(163, 20);
            this.m_txt_pass.TabIndex = 2;
            this.m_txt_pass.Enter += new System.EventHandler(this.m_txt_pass_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chi nhánh";
            // 
            // m_cb_chi_nhanh
            // 
            this.m_cb_chi_nhanh.FormattingEnabled = true;
            this.m_cb_chi_nhanh.Location = new System.Drawing.Point(84, 155);
            this.m_cb_chi_nhanh.Name = "m_cb_chi_nhanh";
            this.m_cb_chi_nhanh.Size = new System.Drawing.Size(163, 22);
            this.m_cb_chi_nhanh.TabIndex = 3;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkRed;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 243);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(414, 22);
            this.Panel2.TabIndex = 10;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(247, 73);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::TOSApp.Properties.Resources.telephone;
            this.PictureBox2.Location = new System.Drawing.Point(270, 47);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(132, 130);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // m_lbl_version_build
            // 
            this.m_lbl_version_build.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_version_build.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_version_build.Location = new System.Drawing.Point(253, 9);
            this.m_lbl_version_build.Name = "m_lbl_version_build";
            this.m_lbl_version_build.Size = new System.Drawing.Size(149, 20);
            this.m_lbl_version_build.TabIndex = 13;
            this.m_lbl_version_build.Text = "DVMC 4.0 v1.0 2015-08-18";
            this.m_lbl_version_build.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_lab_error
            // 
            this.m_lab_error.AutoSize = true;
            this.m_lab_error.ForeColor = System.Drawing.Color.Red;
            this.m_lab_error.Location = new System.Drawing.Point(22, 199);
            this.m_lab_error.Name = "m_lab_error";
            this.m_lab_error.Size = new System.Drawing.Size(10, 14);
            this.m_lab_error.TabIndex = 7;
            this.m_lab_error.Text = " ";
            // 
            // f000_login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 265);
            this.Controls.Add(this.m_lbl_version_build);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.m_cb_chi_nhanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_lab_error);
            this.Controls.Add(this.m_txt_pass);
            this.Controls.Add(this.m_txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f000_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.f000_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_id;
        private System.Windows.Forms.TextBox m_txt_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_cb_chi_nhanh;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label m_lbl_version_build;
        private System.Windows.Forms.Label m_lab_error;

    }
}

