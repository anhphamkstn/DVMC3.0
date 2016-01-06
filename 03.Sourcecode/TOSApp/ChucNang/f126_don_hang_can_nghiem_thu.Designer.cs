namespace TOSApp.ChucNang
{
    partial class f126_don_hang_can_nghiem_thu
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f126_don_hang_can_nghiem_thu));
            this.c_nguoi_tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_thoi_gian_can_hoan_thanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cap_nhat_lan_cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_trang_thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_nguoi_xu_ly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grv_ds_don_dat_hang_can_nghiem_thu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_user_dat_hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grc_ds_don_dat_hang_can_nghiem_thu = new DevExpress.XtraGrid.GridControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_panel_TM = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.m_cmd_TM_huy_hon_hang = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_TM_danh_gia = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_dat_hang_can_nghiem_thu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_dat_hang_can_nghiem_thu)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.m_panel_TM.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_nguoi_tao
            // 
            this.c_nguoi_tao.Caption = "NV nhận đặt hàng";
            this.c_nguoi_tao.FieldName = "NGUOI_TAO";
            this.c_nguoi_tao.Name = "c_nguoi_tao";
            this.c_nguoi_tao.Visible = true;
            this.c_nguoi_tao.VisibleIndex = 12;
            this.c_nguoi_tao.Width = 133;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Phương thức đặt hàng";
            this.gridColumn1.FieldName = "PHUONG_THUC_DAT_HANG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            this.gridColumn1.Width = 164;
            // 
            // m_thoi_gian_can_hoan_thanh
            // 
            this.m_thoi_gian_can_hoan_thanh.Caption = "Thời gian cần hoàn thành";
            this.m_thoi_gian_can_hoan_thanh.FieldName = "LOAI_THOI_GIAN_CAN_HOAN_THANH";
            this.m_thoi_gian_can_hoan_thanh.Name = "m_thoi_gian_can_hoan_thanh";
            this.m_thoi_gian_can_hoan_thanh.Visible = true;
            this.m_thoi_gian_can_hoan_thanh.VisibleIndex = 11;
            this.m_thoi_gian_can_hoan_thanh.Width = 165;
            // 
            // m_cap_nhat_lan_cuoi
            // 
            this.m_cap_nhat_lan_cuoi.Caption = "Cập nhật lần cuối";
            this.m_cap_nhat_lan_cuoi.FieldName = "CAP_NHAT_CUOI";
            this.m_cap_nhat_lan_cuoi.Name = "m_cap_nhat_lan_cuoi";
            this.m_cap_nhat_lan_cuoi.Visible = true;
            this.m_cap_nhat_lan_cuoi.VisibleIndex = 10;
            this.m_cap_nhat_lan_cuoi.Width = 129;
            // 
            // m_trang_thai
            // 
            this.m_trang_thai.Caption = "Trạng thái đơn hàng";
            this.m_trang_thai.FieldName = "TRANG_THAI_DON_HANG";
            this.m_trang_thai.Name = "m_trang_thai";
            this.m_trang_thai.Visible = true;
            this.m_trang_thai.VisibleIndex = 9;
            this.m_trang_thai.Width = 127;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Thời gian tạo";
            this.gridColumn9.DisplayFormat.FormatString = "g";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn9.FieldName = "THOI_GIAN_TAO";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 129;
            // 
            // c_nguoi_xu_ly
            // 
            this.c_nguoi_xu_ly.Caption = "người xử lý";
            this.c_nguoi_xu_ly.FieldName = "NGUOI_XU_LY";
            this.c_nguoi_xu_ly.Name = "c_nguoi_xu_ly";
            this.c_nguoi_xu_ly.Visible = true;
            this.c_nguoi_xu_ly.VisibleIndex = 8;
            this.c_nguoi_xu_ly.Width = 110;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "thời điểm cần hoàn thành";
            this.THOI_DIEM_CAN_HOAN_THANH.DisplayFormat.FormatString = "g";
            this.THOI_DIEM_CAN_HOAN_THANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 7;
            this.THOI_DIEM_CAN_HOAN_THANH.Width = 139;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đơn vị";
            this.gridColumn7.FieldName = "MA_DON_VI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 84;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nội dung đặt hàng";
            this.gridColumn6.FieldName = "NOI_DUNG_DAT_HANG";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 161;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Dịch vụ yêu cầu";
            this.gridColumn5.FieldName = "TEN_YEU_CAU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 121;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Chi nhánh";
            this.gridColumn11.FieldName = "TEN_CHI_NHANH";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 14;
            this.gridColumn11.Width = 86;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điện thoại";
            this.gridColumn3.FieldName = "DIEN_THOAI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 106;
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "Mã đơn hàng";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 0;
            this.MA_DON_HANG.Width = 110;
            // 
            // m_grv_ds_don_dat_hang_can_nghiem_thu
            // 
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.AppearancePrint.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.AppearancePrint.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_DON_HANG,
            this.c_user_dat_hang,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.c_nguoi_xu_ly,
            this.gridColumn9,
            this.m_trang_thai,
            this.m_cap_nhat_lan_cuoi,
            this.m_thoi_gian_can_hoan_thanh,
            this.gridColumn1,
            this.c_nguoi_tao,
            this.gridColumn11});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.Gray;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[THOI_DIEM_CAN_HOAN_THANH]<=GetDate(AddDays(Today(),1 ))";
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.GridControl = this.m_grc_ds_don_dat_hang_can_nghiem_thu;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.IndicatorWidth = 50;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.Name = "m_grv_ds_don_dat_hang_can_nghiem_thu";
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsBehavior.Editable = false;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsView.ColumnAutoWidth = false;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.OptionsView.ShowFooter = true;
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.PaintStyleName = "Flat";
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_ds_don_dat_hang_can_nghiem_thu_CustomDrawRowIndicator);
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_ds_don_dat_hang_can_nghiem_thu_PopupMenuShowing);
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_grv_ds_don_dat_hang_can_nghiem_thu_KeyDown);
            this.m_grv_ds_don_dat_hang_can_nghiem_thu.DoubleClick += new System.EventHandler(this.m_grv_ds_don_dat_hang_can_nghiem_thu_DoubleClick);
            // 
            // c_user_dat_hang
            // 
            this.c_user_dat_hang.Caption = "User đặt hàng";
            this.c_user_dat_hang.FieldName = "USER_NAME";
            this.c_user_dat_hang.Name = "c_user_dat_hang";
            this.c_user_dat_hang.Visible = true;
            this.c_user_dat_hang.VisibleIndex = 1;
            this.c_user_dat_hang.Width = 139;
            // 
            // m_grc_ds_don_dat_hang_can_nghiem_thu
            // 
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.MainView = this.m_grv_ds_don_dat_hang_can_nghiem_thu;
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.Name = "m_grc_ds_don_dat_hang_can_nghiem_thu";
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.Size = new System.Drawing.Size(785, 275);
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.TabIndex = 0;
            this.m_grc_ds_don_dat_hang_can_nghiem_thu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_don_dat_hang_can_nghiem_thu});
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_grc_ds_don_dat_hang_can_nghiem_thu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(785, 275);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 367);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tất cả các đơn cần nghiệm thu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_panel_TM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 39);
            this.panel2.TabIndex = 1;
            // 
            // m_panel_TM
            // 
            this.m_panel_TM.Controls.Add(this.panel13);
            this.m_panel_TM.Controls.Add(this.m_cmd_TM_danh_gia);
            this.m_panel_TM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_panel_TM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_panel_TM.Location = new System.Drawing.Point(0, 0);
            this.m_panel_TM.Name = "m_panel_TM";
            this.m_panel_TM.Size = new System.Drawing.Size(785, 39);
            this.m_panel_TM.TabIndex = 24;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.m_cmd_TM_huy_hon_hang);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(448, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(165, 39);
            this.panel13.TabIndex = 3;
            // 
            // m_cmd_TM_huy_hon_hang
            // 
            this.m_cmd_TM_huy_hon_hang.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_TM_huy_hon_hang.Appearance.Options.UseFont = true;
            this.m_cmd_TM_huy_hon_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_cmd_TM_huy_hon_hang.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_TM_huy_hon_hang.Image")));
            this.m_cmd_TM_huy_hon_hang.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_TM_huy_hon_hang.Name = "m_cmd_TM_huy_hon_hang";
            this.m_cmd_TM_huy_hon_hang.Size = new System.Drawing.Size(165, 39);
            this.m_cmd_TM_huy_hon_hang.TabIndex = 3;
            this.m_cmd_TM_huy_hon_hang.Text = "Hủy đơn hàng";
            this.m_cmd_TM_huy_hon_hang.Click += new System.EventHandler(this.m_cmd_TM_huy_hon_hang_Click);
            // 
            // m_cmd_TM_danh_gia
            // 
            this.m_cmd_TM_danh_gia.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_TM_danh_gia.Appearance.Options.UseFont = true;
            this.m_cmd_TM_danh_gia.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_TM_danh_gia.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_TM_danh_gia.Image")));
            this.m_cmd_TM_danh_gia.Location = new System.Drawing.Point(613, 0);
            this.m_cmd_TM_danh_gia.Name = "m_cmd_TM_danh_gia";
            this.m_cmd_TM_danh_gia.Size = new System.Drawing.Size(172, 39);
            this.m_cmd_TM_danh_gia.TabIndex = 1;
            this.m_cmd_TM_danh_gia.Text = "Nghiệm thu";
            this.m_cmd_TM_danh_gia.Click += new System.EventHandler(this.m_cmd_TM_danh_gia_Click);
            // 
            // f126_don_hang_can_nghiem_thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 367);
            this.Controls.Add(this.panel4);
            this.Name = "f126_don_hang_can_nghiem_thu";
            this.Text = "f126 đơn hàng cần nghiệm thu";
            this.Load += new System.EventHandler(this.f126_don_hang_can_nghiem_thu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_don_dat_hang_can_nghiem_thu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_don_dat_hang_can_nghiem_thu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.m_panel_TM.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_tao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn m_thoi_gian_can_hoan_thanh;
        private DevExpress.XtraGrid.Columns.GridColumn m_cap_nhat_lan_cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn m_trang_thai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn c_nguoi_xu_ly;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_don_dat_hang_can_nghiem_thu;
        private DevExpress.XtraGrid.Columns.GridColumn c_user_dat_hang;
        private DevExpress.XtraGrid.GridControl m_grc_ds_don_dat_hang_can_nghiem_thu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel m_panel_TM;
        private System.Windows.Forms.Panel panel13;
        public DevExpress.XtraEditors.SimpleButton m_cmd_TM_huy_hon_hang;
        public DevExpress.XtraEditors.SimpleButton m_cmd_TM_danh_gia;
    }
}