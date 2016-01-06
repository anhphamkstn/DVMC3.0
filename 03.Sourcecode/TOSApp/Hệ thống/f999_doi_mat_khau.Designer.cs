namespace TOSApp.Hệ_thống
{
    partial class f999_doi_mat_khau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f999_doi_mat_khau));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mat_khau_hien_tai = new System.Windows.Forms.TextBox();
            this.txt_mat_khau_moi = new System.Windows.Forms.TextBox();
            this.txt_nhap_lai_mat_khau_moi = new System.Windows.Forms.TextBox();
            this.lab_eror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(279, 224);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 40);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.Location = new System.Drawing.Point(181, 224);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 40);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "&Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_mat_khau_hien_tai
            // 
            this.txt_mat_khau_hien_tai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau_hien_tai.Location = new System.Drawing.Point(181, 39);
            this.txt_mat_khau_hien_tai.Name = "txt_mat_khau_hien_tai";
            this.txt_mat_khau_hien_tai.PasswordChar = '*';
            this.txt_mat_khau_hien_tai.Size = new System.Drawing.Size(173, 22);
            this.txt_mat_khau_hien_tai.TabIndex = 1;
            // 
            // txt_mat_khau_moi
            // 
            this.txt_mat_khau_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau_moi.Location = new System.Drawing.Point(181, 96);
            this.txt_mat_khau_moi.Name = "txt_mat_khau_moi";
            this.txt_mat_khau_moi.PasswordChar = '*';
            this.txt_mat_khau_moi.Size = new System.Drawing.Size(173, 22);
            this.txt_mat_khau_moi.TabIndex = 2;
            // 
            // txt_nhap_lai_mat_khau_moi
            // 
            this.txt_nhap_lai_mat_khau_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhap_lai_mat_khau_moi.Location = new System.Drawing.Point(181, 148);
            this.txt_nhap_lai_mat_khau_moi.Name = "txt_nhap_lai_mat_khau_moi";
            this.txt_nhap_lai_mat_khau_moi.PasswordChar = '*';
            this.txt_nhap_lai_mat_khau_moi.Size = new System.Drawing.Size(173, 22);
            this.txt_nhap_lai_mat_khau_moi.TabIndex = 3;
            // 
            // lab_eror
            // 
            this.lab_eror.AutoSize = true;
            this.lab_eror.ForeColor = System.Drawing.Color.Red;
            this.lab_eror.Location = new System.Drawing.Point(18, 199);
            this.lab_eror.Name = "lab_eror";
            this.lab_eror.Size = new System.Drawing.Size(0, 13);
            this.lab_eror.TabIndex = 17;
            // 
            // f999_doi_mat_khau
            // 
            this.AcceptButton = this.btn_luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 276);
            this.Controls.Add(this.lab_eror);
            this.Controls.Add(this.txt_nhap_lai_mat_khau_moi);
            this.Controls.Add(this.txt_mat_khau_moi);
            this.Controls.Add(this.txt_mat_khau_hien_tai);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f999_doi_mat_khau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private System.Windows.Forms.TextBox txt_mat_khau_hien_tai;
        private System.Windows.Forms.TextBox txt_mat_khau_moi;
        private System.Windows.Forms.TextBox txt_nhap_lai_mat_khau_moi;
        private System.Windows.Forms.Label lab_eror;
    }
}