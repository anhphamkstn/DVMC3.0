namespace TOSApp.ChucNang
{
    partial class f112_FO_chuyen_don_hang_cho_PM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f112_FO_chuyen_don_hang_cho_PM));
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ma_don_hang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_gui_kem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_Ok = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cbo_PM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(118, 25);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.ReadOnly = true;
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(160, 20);
            this.m_txt_ma_don_hang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gửi kèm";
            // 
            // m_txt_gui_kem
            // 
            this.m_txt_gui_kem.Location = new System.Drawing.Point(118, 149);
            this.m_txt_gui_kem.Multiline = true;
            this.m_txt_gui_kem.Name = "m_txt_gui_kem";
            this.m_txt_gui_kem.Size = new System.Drawing.Size(252, 64);
            this.m_txt_gui_kem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gửi cho PM";
            // 
            // m_cmd_Ok
            // 
            this.m_cmd_Ok.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Ok.Image")));
            this.m_cmd_Ok.Location = new System.Drawing.Point(183, 230);
            this.m_cmd_Ok.Name = "m_cmd_Ok";
            this.m_cmd_Ok.Size = new System.Drawing.Size(75, 30);
            this.m_cmd_Ok.TabIndex = 4;
            this.m_cmd_Ok.Text = "OK";
            this.m_cmd_Ok.Click += new System.EventHandler(this.m_cmd_Ok_Click_1);
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_cancel.Image")));
            this.m_cmd_cancel.Location = new System.Drawing.Point(295, 230);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(75, 30);
            this.m_cmd_cancel.TabIndex = 4;
            this.m_cmd_cancel.Text = "Cancel";
            this.m_cmd_cancel.Click += new System.EventHandler(this.m_cmd_cancel_Click_1);
            // 
            // m_cbo_PM
            // 
            this.m_cbo_PM.FormattingEnabled = true;
            this.m_cbo_PM.Location = new System.Drawing.Point(118, 82);
            this.m_cbo_PM.Name = "m_cbo_PM";
            this.m_cbo_PM.Size = new System.Drawing.Size(160, 21);
            this.m_cbo_PM.TabIndex = 5;
            // 
            // f112_FO_chuyen_don_hang_cho_PM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 276);
            this.Controls.Add(this.m_cbo_PM);
            this.Controls.Add(this.m_cmd_cancel);
            this.Controls.Add(this.m_cmd_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_gui_kem);
            this.Controls.Add(this.m_txt_ma_don_hang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "f112_FO_chuyen_don_hang_cho_PM";
            this.Text = "f112_Điều phối lên PM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ma_don_hang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_gui_kem;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Ok;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private System.Windows.Forms.ComboBox m_cbo_PM;
    }
}