namespace TOSApp.ChucNang
{
    partial class f115_TM_danh_gia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f115_TM_danh_gia));
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ma_don_hang = new System.Windows.Forms.Label();
            this.m_rdb_hoan_thanh = new System.Windows.Forms.RadioButton();
            this.m_rdb_chua_hoan_thanh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_txt_nhan_xet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_chk_gui_email_YN = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.AutoSize = true;
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(196, 19);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(71, 13);
            this.m_txt_ma_don_hang.TabIndex = 0;
            this.m_txt_ma_don_hang.Text = "Mã đơn hàng";
            // 
            // m_rdb_hoan_thanh
            // 
            this.m_rdb_hoan_thanh.AutoSize = true;
            this.m_rdb_hoan_thanh.Location = new System.Drawing.Point(15, 26);
            this.m_rdb_hoan_thanh.Name = "m_rdb_hoan_thanh";
            this.m_rdb_hoan_thanh.Size = new System.Drawing.Size(84, 17);
            this.m_rdb_hoan_thanh.TabIndex = 1;
            this.m_rdb_hoan_thanh.TabStop = true;
            this.m_rdb_hoan_thanh.Text = "Hoàn thành ";
            this.m_rdb_hoan_thanh.UseVisualStyleBackColor = true;
            // 
            // m_rdb_chua_hoan_thanh
            // 
            this.m_rdb_chua_hoan_thanh.AutoSize = true;
            this.m_rdb_chua_hoan_thanh.Location = new System.Drawing.Point(166, 26);
            this.m_rdb_chua_hoan_thanh.Name = "m_rdb_chua_hoan_thanh";
            this.m_rdb_chua_hoan_thanh.Size = new System.Drawing.Size(110, 17);
            this.m_rdb_chua_hoan_thanh.TabIndex = 1;
            this.m_rdb_chua_hoan_thanh.TabStop = true;
            this.m_rdb_chua_hoan_thanh.Text = "Chưa hoàn thành ";
            this.m_rdb_chua_hoan_thanh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_txt_nhan_xet);
            this.groupBox1.Controls.Add(this.m_rdb_hoan_thanh);
            this.groupBox1.Controls.Add(this.m_rdb_chua_hoan_thanh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đánh giá đơn hàng";
            // 
            // m_txt_nhan_xet
            // 
            this.m_txt_nhan_xet.Location = new System.Drawing.Point(9, 89);
            this.m_txt_nhan_xet.Multiline = true;
            this.m_txt_nhan_xet.Name = "m_txt_nhan_xet";
            this.m_txt_nhan_xet.Size = new System.Drawing.Size(338, 95);
            this.m_txt_nhan_xet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhận xét";
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(213, 266);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 30);
            this.m_cmd_OK.TabIndex = 3;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Cancel.Image")));
            this.m_cmd_Cancel.Location = new System.Drawing.Point(294, 266);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(85, 30);
            this.m_cmd_Cancel.TabIndex = 3;
            this.m_cmd_Cancel.Text = "Cancel";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // m_chk_gui_email_YN
            // 
            this.m_chk_gui_email_YN.AutoSize = true;
            this.m_chk_gui_email_YN.Checked = true;
            this.m_chk_gui_email_YN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_chk_gui_email_YN.Enabled = false;
            this.m_chk_gui_email_YN.Location = new System.Drawing.Point(41, 273);
            this.m_chk_gui_email_YN.Name = "m_chk_gui_email_YN";
            this.m_chk_gui_email_YN.Size = new System.Drawing.Size(148, 17);
            this.m_chk_gui_email_YN.TabIndex = 3;
            this.m_chk_gui_email_YN.Text = "gửi email cho khách hàng";
            this.m_chk_gui_email_YN.UseVisualStyleBackColor = true;
            // 
            // f115_TM_danh_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 319);
            this.Controls.Add(this.m_chk_gui_email_YN);
            this.Controls.Add(this.m_cmd_Cancel);
            this.Controls.Add(this.m_cmd_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_txt_ma_don_hang);
            this.Controls.Add(this.label1);
            this.Name = "f115_TM_danh_gia";
            this.Text = "f115_Đánh giá";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_txt_ma_don_hang;
        private System.Windows.Forms.RadioButton m_rdb_hoan_thanh;
        private System.Windows.Forms.RadioButton m_rdb_chua_hoan_thanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_txt_nhan_xet;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private System.Windows.Forms.CheckBox m_chk_gui_email_YN;
    }
}