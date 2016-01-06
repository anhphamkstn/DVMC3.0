namespace TOSApp.ChucNang
{
    partial class f119_ds_don_hang_hoan_thanh
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
            this.m_lab_tieu_de = new System.Windows.Forms.Label();
            this.m_grc_ds_dh_hoan_thanh = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_dh_hoan_thanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_user_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_DIEM_CAN_HOAN_THANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dh_hoan_thanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dh_hoan_thanh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lab_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 52);
            this.panel1.TabIndex = 0;
            // 
            // m_lab_tieu_de
            // 
            this.m_lab_tieu_de.AutoSize = true;
            this.m_lab_tieu_de.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lab_tieu_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_lab_tieu_de.Location = new System.Drawing.Point(3, 23);
            this.m_lab_tieu_de.Name = "m_lab_tieu_de";
            this.m_lab_tieu_de.Size = new System.Drawing.Size(283, 19);
            this.m_lab_tieu_de.TabIndex = 1;
            this.m_lab_tieu_de.Text = "Danh sách đơn hàng đã hoàn thành";
            // 
            // m_grc_ds_dh_hoan_thanh
            // 
            this.m_grc_ds_dh_hoan_thanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_dh_hoan_thanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_dh_hoan_thanh.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_dh_hoan_thanh.MainView = this.m_grv_ds_dh_hoan_thanh;
            this.m_grc_ds_dh_hoan_thanh.Name = "m_grc_ds_dh_hoan_thanh";
            this.m_grc_ds_dh_hoan_thanh.Size = new System.Drawing.Size(1220, 212);
            this.m_grc_ds_dh_hoan_thanh.TabIndex = 0;
            this.m_grc_ds_dh_hoan_thanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_dh_hoan_thanh});
            // 
            // m_grv_ds_dh_hoan_thanh
            // 
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_dh_hoan_thanh.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_dh_hoan_thanh.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_dh_hoan_thanh.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_dh_hoan_thanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.c_user_name,
            this.gridColumn3,
            this.gridColumn4,
            this.THOI_DIEM_CAN_HOAN_THANH,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn2,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.m_grv_ds_dh_hoan_thanh.GridControl = this.m_grc_ds_dh_hoan_thanh;
            this.m_grv_ds_dh_hoan_thanh.IndicatorWidth = 50;
            this.m_grv_ds_dh_hoan_thanh.Name = "m_grv_ds_dh_hoan_thanh";
            this.m_grv_ds_dh_hoan_thanh.OptionsBehavior.Editable = false;
            this.m_grv_ds_dh_hoan_thanh.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_dh_hoan_thanh.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_dh_hoan_thanh.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_dh_hoan_thanh.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_dh_hoan_thanh.PaintStyleName = "Flat";
            this.m_grv_ds_dh_hoan_thanh.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_ds_dh_hoan_thanh_CustomDrawRowIndicator);
            this.m_grv_ds_dh_hoan_thanh.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_ds_dh_hoan_thanh_PopupMenuShowing);
            this.m_grv_ds_dh_hoan_thanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_grv_ds_dh_hoan_thanh_KeyDown);
            this.m_grv_ds_dh_hoan_thanh.DoubleClick += new System.EventHandler(this.m_grv_ds_dh_hoan_thanh_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ ĐƠN HÀNG";
            this.gridColumn1.FieldName = "MA_DON_HANG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 102;
            // 
            // c_user_name
            // 
            this.c_user_name.Caption = "USER ĐẶT HÀNG";
            this.c_user_name.FieldName = "USER_NAME";
            this.c_user_name.Name = "c_user_name";
            this.c_user_name.Visible = true;
            this.c_user_name.VisibleIndex = 2;
            this.c_user_name.Width = 102;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MÃ ĐƠN VỊ";
            this.gridColumn3.FieldName = "MA_DON_VI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 84;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ĐIỆN THOẠI";
            this.gridColumn4.FieldName = "DIEN_THOAI";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 96;
            // 
            // THOI_DIEM_CAN_HOAN_THANH
            // 
            this.THOI_DIEM_CAN_HOAN_THANH.Caption = "THỜI ĐIỂM CẦN HOÀN THÀNH";
            this.THOI_DIEM_CAN_HOAN_THANH.DisplayFormat.FormatString = "g";
            this.THOI_DIEM_CAN_HOAN_THANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.THOI_DIEM_CAN_HOAN_THANH.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Name = "THOI_DIEM_CAN_HOAN_THANH";
            this.THOI_DIEM_CAN_HOAN_THANH.Visible = true;
            this.THOI_DIEM_CAN_HOAN_THANH.VisibleIndex = 8;
            this.THOI_DIEM_CAN_HOAN_THANH.Width = 126;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "DỊCH VỤ YÊU CẦU";
            this.gridColumn6.FieldName = "TEN_YEU_CAU";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 103;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "NỘI DUNG ĐẶT HÀNG";
            this.gridColumn7.FieldName = "NOI_DUNG_DAT_HANG";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 103;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "THỜI GIAN HOÀN THÀNH";
            this.gridColumn8.DisplayFormat.FormatString = "g";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn8.FieldName = "THOI_GIAN_HOAN_THANH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 97;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "THỜI ĐIỂM ĐẶT HÀNG";
            this.gridColumn2.FieldName = "THOI_GIAN_TAO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 103;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "NGƯỜI XỬ LÝ";
            this.gridColumn11.FieldName = "NGUOI_XU_LY";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 115;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ĐÁNH GIÁ CỦA KHÁCH HÀNG";
            this.gridColumn12.FieldName = "DANH_GIA_TU_USER_DAT_HANG";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 10;
            this.gridColumn12.Width = 61;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "CHI NHÁNH";
            this.gridColumn13.FieldName = "TEN_CHI_NHANH";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "KÊNH ĐẶT HÀNG";
            this.gridColumn14.FieldName = "PHUONG_THUC_DAT_HANG";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 12;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Ý KIẾN KHÁC";
            this.gridColumn15.FieldName = "Y_KIEN_KHAC_TU_USER_DAT_HANG";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_dh_hoan_thanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 212);
            this.panel2.TabIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Name = "gridColumn10";
            // 
            // f119_ds_don_hang_hoan_thanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 264);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f119_ds_don_hang_hoan_thanh";
            this.Text = "f119_Đơn hàng đã hoàn thành";
            this.Load += new System.EventHandler(this.f119_ds_don_hang_hoan_thanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_dh_hoan_thanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_dh_hoan_thanh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_dh_hoan_thanh;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_dh_hoan_thanh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn c_user_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_DIEM_CAN_HOAN_THANH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lab_tieu_de;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}