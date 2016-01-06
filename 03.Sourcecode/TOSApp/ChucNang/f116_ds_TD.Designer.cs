namespace TOSApp.ChucNang
{
    partial class f116_ds_TD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f116_ds_TD));
            this.m_cbo_ds_TD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_gui_kem = new System.Windows.Forms.TextBox();
            this.m_txt_ma_don_hang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_Ok = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // m_cbo_ds_TD
            // 
            this.m_cbo_ds_TD.FormattingEnabled = true;
            this.m_cbo_ds_TD.Location = new System.Drawing.Point(125, 74);
            this.m_cbo_ds_TD.Name = "m_cbo_ds_TD";
            this.m_cbo_ds_TD.Size = new System.Drawing.Size(160, 21);
            this.m_cbo_ds_TD.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gửi cho";
            // 
            // m_txt_gui_kem
            // 
            this.m_txt_gui_kem.Location = new System.Drawing.Point(125, 141);
            this.m_txt_gui_kem.Multiline = true;
            this.m_txt_gui_kem.Name = "m_txt_gui_kem";
            this.m_txt_gui_kem.Size = new System.Drawing.Size(252, 64);
            this.m_txt_gui_kem.TabIndex = 7;
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(125, 17);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.ReadOnly = true;
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(160, 20);
            this.m_txt_ma_don_hang.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gửi kèm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã đơn hàng";
            // 
            // m_cmd_Ok
            // 
            this.m_cmd_Ok.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Ok.Image")));
            this.m_cmd_Ok.Location = new System.Drawing.Point(210, 211);
            this.m_cmd_Ok.Name = "m_cmd_Ok";
            this.m_cmd_Ok.Size = new System.Drawing.Size(75, 34);
            this.m_cmd_Ok.TabIndex = 13;
            this.m_cmd_Ok.Text = "OK";
            this.m_cmd_Ok.Click += new System.EventHandler(this.m_cmd_Ok_Click_1);
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_cancel.Image")));
            this.m_cmd_cancel.Location = new System.Drawing.Point(302, 211);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(75, 34);
            this.m_cmd_cancel.TabIndex = 13;
            this.m_cmd_cancel.Text = "Cancel";
            this.m_cmd_cancel.Click += new System.EventHandler(this.m_cmd_cancel_Click_1);
            // 
            // f116_ds_TD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 257);
            this.Controls.Add(this.m_cmd_cancel);
            this.Controls.Add(this.m_cmd_Ok);
            this.Controls.Add(this.m_cbo_ds_TD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_gui_kem);
            this.Controls.Add(this.m_txt_ma_don_hang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "f116_ds_TD";
            this.Text = "f116_Điều phối TD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbo_ds_TD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_gui_kem;
        private System.Windows.Forms.TextBox m_txt_ma_don_hang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Ok;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
    }
}