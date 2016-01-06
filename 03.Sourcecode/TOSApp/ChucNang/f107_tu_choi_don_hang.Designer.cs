namespace TOSApp.ChucNang
{
    partial class f107_tu_choi_don_hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f107_tu_choi_don_hang));
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_gui = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_ly_do_tu_choi = new System.Windows.Forms.TextBox();
            this.m_txt_nguoi_nhan_tao_tac = new System.Windows.Forms.TextBox();
            this.m_txt_ma_don_hang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_cancel.Image")));
            this.m_cmd_cancel.Location = new System.Drawing.Point(414, 207);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(80, 32);
            this.m_cmd_cancel.TabIndex = 9;
            this.m_cmd_cancel.Text = "Cancel";
            this.m_cmd_cancel.Click += new System.EventHandler(this.m_cmd_cancel_Click);
            // 
            // m_cmd_gui
            // 
            this.m_cmd_gui.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_gui.Image")));
            this.m_cmd_gui.Location = new System.Drawing.Point(262, 207);
            this.m_cmd_gui.Name = "m_cmd_gui";
            this.m_cmd_gui.Size = new System.Drawing.Size(84, 32);
            this.m_cmd_gui.TabIndex = 10;
            this.m_cmd_gui.Text = "Gửi";
            this.m_cmd_gui.Click += new System.EventHandler(this.m_cmd_gui_Click);
            // 
            // m_txt_ly_do_tu_choi
            // 
            this.m_txt_ly_do_tu_choi.Location = new System.Drawing.Point(178, 101);
            this.m_txt_ly_do_tu_choi.Multiline = true;
            this.m_txt_ly_do_tu_choi.Name = "m_txt_ly_do_tu_choi";
            this.m_txt_ly_do_tu_choi.Size = new System.Drawing.Size(316, 76);
            this.m_txt_ly_do_tu_choi.TabIndex = 6;
            // 
            // m_txt_nguoi_nhan_tao_tac
            // 
            this.m_txt_nguoi_nhan_tao_tac.Location = new System.Drawing.Point(178, 64);
            this.m_txt_nguoi_nhan_tao_tac.Name = "m_txt_nguoi_nhan_tao_tac";
            this.m_txt_nguoi_nhan_tao_tac.ReadOnly = true;
            this.m_txt_nguoi_nhan_tao_tac.Size = new System.Drawing.Size(316, 20);
            this.m_txt_nguoi_nhan_tao_tac.TabIndex = 7;
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(178, 31);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.ReadOnly = true;
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(316, 20);
            this.m_txt_ma_don_hang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lý do từ chối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Người nhận tao tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã đơn hàng";
            // 
            // f107_tu_choi_don_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.Controls.Add(this.m_cmd_cancel);
            this.Controls.Add(this.m_cmd_gui);
            this.Controls.Add(this.m_txt_ly_do_tu_choi);
            this.Controls.Add(this.m_txt_nguoi_nhan_tao_tac);
            this.Controls.Add(this.m_txt_ma_don_hang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "f107_tu_choi_don_hang";
            this.Text = "f107_Từ chối";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_gui;
        private System.Windows.Forms.TextBox m_txt_ly_do_tu_choi;
        private System.Windows.Forms.TextBox m_txt_nguoi_nhan_tao_tac;
        private System.Windows.Forms.TextBox m_txt_ma_don_hang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}