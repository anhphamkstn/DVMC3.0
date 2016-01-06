namespace TOSApp.ChucNang
{
    partial class f128_danh_sach_dich_vu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f128_danh_sach_dich_vu));
            this.m_grc_dich_vu = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dich_vu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nhom_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_loai_dich_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pan_button = new System.Windows.Forms.Panel();
            this.m_cmd_ok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dich_vu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dich_vu)).BeginInit();
            this.m_pan_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_dich_vu
            // 
            this.m_grc_dich_vu.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dich_vu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dich_vu.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dich_vu.MainView = this.m_grv_dich_vu;
            this.m_grc_dich_vu.Name = "m_grc_dich_vu";
            this.m_grc_dich_vu.Size = new System.Drawing.Size(952, 425);
            this.m_grc_dich_vu.TabIndex = 0;
            this.m_grc_dich_vu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dich_vu});
            // 
            // m_grv_dich_vu
            // 
            this.m_grv_dich_vu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_dich_vu,
            this.c_nhom_dich_vu,
            this.c_loai_dich_vu});
            this.m_grv_dich_vu.GridControl = this.m_grc_dich_vu;
            this.m_grv_dich_vu.Name = "m_grv_dich_vu";
            this.m_grv_dich_vu.OptionsSelection.MultiSelect = true;
            this.m_grv_dich_vu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // c_dich_vu
            // 
            this.c_dich_vu.Caption = "Dịch vụ";
            this.c_dich_vu.FieldName = "TEN_YEU_CAU";
            this.c_dich_vu.Name = "c_dich_vu";
            this.c_dich_vu.Visible = true;
            this.c_dich_vu.VisibleIndex = 1;
            // 
            // c_nhom_dich_vu
            // 
            this.c_nhom_dich_vu.Caption = "Nhóm dịch vụ";
            this.c_nhom_dich_vu.FieldName = "TEN_YEU_CAU_CHA";
            this.c_nhom_dich_vu.Name = "c_nhom_dich_vu";
            this.c_nhom_dich_vu.Visible = true;
            this.c_nhom_dich_vu.VisibleIndex = 2;
            // 
            // c_loai_dich_vu
            // 
            this.c_loai_dich_vu.Caption = "Loại dịch vụ";
            this.c_loai_dich_vu.FieldName = "TEN_YEU_CAU_CHA_CHA";
            this.c_loai_dich_vu.Name = "c_loai_dich_vu";
            this.c_loai_dich_vu.Visible = true;
            this.c_loai_dich_vu.VisibleIndex = 3;
            // 
            // m_pan_button
            // 
            this.m_pan_button.Controls.Add(this.m_cmd_ok);
            this.m_pan_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pan_button.Location = new System.Drawing.Point(0, 425);
            this.m_pan_button.Name = "m_pan_button";
            this.m_pan_button.Size = new System.Drawing.Size(952, 45);
            this.m_pan_button.TabIndex = 1;
            // 
            // m_cmd_ok
            // 
            this.m_cmd_ok.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_ok.Appearance.Options.UseFont = true;
            this.m_cmd_ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_ok.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_ok.Image")));
            this.m_cmd_ok.Location = new System.Drawing.Point(855, 0);
            this.m_cmd_ok.Name = "m_cmd_ok";
            this.m_cmd_ok.Size = new System.Drawing.Size(97, 45);
            this.m_cmd_ok.TabIndex = 0;
            this.m_cmd_ok.Text = "&OK";
            this.m_cmd_ok.Click += new System.EventHandler(this.m_cmd_ok_Click);
            // 
            // f128_danh_sach_dich_vu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 470);
            this.Controls.Add(this.m_grc_dich_vu);
            this.Controls.Add(this.m_pan_button);
            this.Name = "f128_danh_sach_dich_vu";
            this.Text = "f128_danh_sach_dich_vu";
            this.Load += new System.EventHandler(this.f128_danh_sach_dich_vu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dich_vu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dich_vu)).EndInit();
            this.m_pan_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dich_vu;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_nhom_dich_vu;
        private DevExpress.XtraGrid.Columns.GridColumn c_loai_dich_vu;
        private System.Windows.Forms.Panel m_pan_button;
        private DevExpress.XtraEditors.SimpleButton m_cmd_ok;
    }
}