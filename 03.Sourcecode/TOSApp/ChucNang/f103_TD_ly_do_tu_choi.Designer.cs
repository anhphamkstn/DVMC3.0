namespace TOSApp.ChucNang
{
    partial class f103_TD_ly_do_tu_choi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f103_TD_ly_do_tu_choi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_txt_ly_do = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 39);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(323, 0);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(82, 39);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Cancel.Image")));
            this.m_cmd_Cancel.Location = new System.Drawing.Point(405, 0);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 39);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Cancel";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_txt_ly_do);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mời nhập lí do";
            // 
            // m_txt_ly_do
            // 
            this.m_txt_ly_do.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_txt_ly_do.Location = new System.Drawing.Point(3, 16);
            this.m_txt_ly_do.Multiline = true;
            this.m_txt_ly_do.Name = "m_txt_ly_do";
            this.m_txt_ly_do.Size = new System.Drawing.Size(474, 202);
            this.m_txt_ly_do.TabIndex = 0;
            // 
            // f103_TD_ly_do_tu_choi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "f103_TD_ly_do_tu_choi";
            this.Text = "f103_TD_ly_do_tu_choi";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_txt_ly_do;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
    }
}