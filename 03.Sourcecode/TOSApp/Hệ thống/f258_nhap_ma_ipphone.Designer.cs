namespace TOSApp.Hệ_thống
{
    partial class f258_nhap_ma_ipphone
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
            this.m_tb_ipphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lab_error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_tb_ipphone
            // 
            this.m_tb_ipphone.Location = new System.Drawing.Point(100, 30);
            this.m_tb_ipphone.Name = "m_tb_ipphone";
            this.m_tb_ipphone.Size = new System.Drawing.Size(162, 20);
            this.m_tb_ipphone.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã ipphone";
            // 
            // m_lab_error
            // 
            this.m_lab_error.AutoSize = true;
            this.m_lab_error.ForeColor = System.Drawing.Color.Red;
            this.m_lab_error.Location = new System.Drawing.Point(38, 35);
            this.m_lab_error.Name = "m_lab_error";
            this.m_lab_error.Size = new System.Drawing.Size(10, 14);
            this.m_lab_error.TabIndex = 16;
            this.m_lab_error.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Nhập mã";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // f258_nhap_ma_ipphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 130);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_tb_ipphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lab_error);
            this.Name = "f258_nhap_ma_ipphone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f258_nhap_ma_ipphone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tb_ipphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_lab_error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}