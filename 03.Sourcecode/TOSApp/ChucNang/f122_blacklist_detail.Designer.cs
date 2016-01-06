namespace TOSApp.ChucNang
{
    partial class f122_blacklist_detail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_so_dien_thoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ho_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_ly_do = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_cancel);
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_ly_do);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.m_txt_ho_ten);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.m_txt_so_dien_thoai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 201);
            this.panel2.TabIndex = 0;
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Location = new System.Drawing.Point(514, 16);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_cancel
            // 
            this.m_cmd_cancel.Location = new System.Drawing.Point(630, 16);
            this.m_cmd_cancel.Name = "m_cmd_cancel";
            this.m_cmd_cancel.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_cancel.TabIndex = 0;
            this.m_cmd_cancel.Text = "Cancel";
            this.m_cmd_cancel.Click += new System.EventHandler(this.m_cmd_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // m_txt_so_dien_thoai
            // 
            this.m_txt_so_dien_thoai.Location = new System.Drawing.Point(114, 40);
            this.m_txt_so_dien_thoai.MaxLength = 11;
            this.m_txt_so_dien_thoai.Name = "m_txt_so_dien_thoai";
            this.m_txt_so_dien_thoai.Size = new System.Drawing.Size(190, 20);
            this.m_txt_so_dien_thoai.TabIndex = 1;
            this.m_txt_so_dien_thoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.format_key);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // m_txt_ho_ten
            // 
            this.m_txt_ho_ten.Location = new System.Drawing.Point(474, 37);
            this.m_txt_ho_ten.Name = "m_txt_ho_ten";
            this.m_txt_ho_ten.Size = new System.Drawing.Size(231, 20);
            this.m_txt_ho_ten.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lý do";
            // 
            // m_txt_ly_do
            // 
            this.m_txt_ly_do.Location = new System.Drawing.Point(114, 95);
            this.m_txt_ly_do.Multiline = true;
            this.m_txt_ly_do.Name = "m_txt_ly_do";
            this.m_txt_ly_do.Size = new System.Drawing.Size(591, 84);
            this.m_txt_ly_do.TabIndex = 1;
            // 
            // f122_blacklist_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f122_blacklist_detail";
            this.Text = "f122_blacklist_detail";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox m_txt_ly_do;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_ho_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_so_dien_thoai;
        private System.Windows.Forms.Label label1;
    }
}