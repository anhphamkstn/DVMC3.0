namespace TOSApp.ChucNang
{
    partial class f118_ds_log_dat_hang
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lab_tieu_de = new System.Windows.Forms.Label();
            this.m_grc_ds_log_gd_dat_hang = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_log_dat_hang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DON_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_US_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_TAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TEN_LOAI_THAO_TAC_LOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_NHAN_THAO_TAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_log_gd_dat_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_log_dat_hang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lab_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 44);
            this.panel1.TabIndex = 0;
            // 
            // m_lab_tieu_de
            // 
            this.m_lab_tieu_de.AutoSize = true;
            this.m_lab_tieu_de.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lab_tieu_de.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_lab_tieu_de.Location = new System.Drawing.Point(3, 21);
            this.m_lab_tieu_de.Name = "m_lab_tieu_de";
            this.m_lab_tieu_de.Size = new System.Drawing.Size(141, 19);
            this.m_lab_tieu_de.TabIndex = 1;
            this.m_lab_tieu_de.Text = "Lịch sử giao dịch";
            // 
            // m_grc_ds_log_gd_dat_hang
            // 
            this.m_grc_ds_log_gd_dat_hang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_log_gd_dat_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_log_gd_dat_hang.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_log_gd_dat_hang.MainView = this.m_grv_ds_log_dat_hang;
            this.m_grc_ds_log_gd_dat_hang.Name = "m_grc_ds_log_gd_dat_hang";
            this.m_grc_ds_log_gd_dat_hang.Size = new System.Drawing.Size(863, 312);
            this.m_grc_ds_log_gd_dat_hang.TabIndex = 0;
            this.m_grc_ds_log_gd_dat_hang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_log_dat_hang});
            // 
            // m_grv_ds_log_dat_hang
            // 
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_ds_log_dat_hang.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_ds_log_dat_hang.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_ds_log_dat_hang.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_log_dat_hang.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_ds_log_dat_hang.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_log_dat_hang.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_log_dat_hang.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_log_dat_hang.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_log_dat_hang.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_log_dat_hang.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_log_dat_hang.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_log_dat_hang.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_log_dat_hang.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_log_dat_hang.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_log_dat_hang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.MA_DON_HANG,
            this.gridColumn10,
            this.gridColumn11,
            this.GHI_CHU,
            this.TEN_US_HANG,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.THOI_GIAN_TAO,
            this.gridColumn9,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.Gray;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[THOI_DIEM_CAN_HOAN_THANH]< Now()";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            styleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.Gray;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseBorderColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[THOI_DIEM_CAN_HOAN_THANH] <= GetDate(AddDays(Today(),1 ))";
            this.m_grv_ds_log_dat_hang.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.m_grv_ds_log_dat_hang.GridControl = this.m_grc_ds_log_gd_dat_hang;
            this.m_grv_ds_log_dat_hang.IndicatorWidth = 50;
            this.m_grv_ds_log_dat_hang.Name = "m_grv_ds_log_dat_hang";
            this.m_grv_ds_log_dat_hang.OptionsBehavior.Editable = false;
            this.m_grv_ds_log_dat_hang.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_log_dat_hang.OptionsView.ColumnAutoWidth = false;
            this.m_grv_ds_log_dat_hang.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_log_dat_hang.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_log_dat_hang.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_log_dat_hang.PaintStyleName = "Flat";
            this.m_grv_ds_log_dat_hang.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_ds_log_dat_hang_CustomDrawRowIndicator);
            this.m_grv_ds_log_dat_hang.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_ds_log_dat_hang_PopupMenuShowing);
            this.m_grv_ds_log_dat_hang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_grv_ds_log_dat_hang_KeyDown);
            this.m_grv_ds_log_dat_hang.DoubleClick += new System.EventHandler(this.m_grv_ds_log_dat_hang_DoubleClick);
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "THỜI GIAN";
            this.gridColumn12.DisplayFormat.FormatString = "g";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn12.FieldName = "NGAY_LAP_THAO_TAC";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 150;
            // 
            // MA_DON_HANG
            // 
            this.MA_DON_HANG.Caption = "MÃ ĐƠN HÀNG";
            this.MA_DON_HANG.FieldName = "MA_DON_HANG";
            this.MA_DON_HANG.Name = "MA_DON_HANG";
            this.MA_DON_HANG.Visible = true;
            this.MA_DON_HANG.VisibleIndex = 1;
            this.MA_DON_HANG.Width = 137;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "NGƯỜI THỰC HIỆN";
            this.gridColumn10.FieldName = "TEN_NGUOI_TAO_THAO_TAC_LOG";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 143;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "THAO TÁC";
            this.gridColumn11.FieldName = "TEN_LOAI_THAO_TAC_LOG";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            this.gridColumn11.Width = 149;
            // 
            // GHI_CHU
            // 
            this.GHI_CHU.Caption = "GHI CHÚ";
            this.GHI_CHU.FieldName = "GHI_CHU";
            this.GHI_CHU.Name = "GHI_CHU";
            this.GHI_CHU.Visible = true;
            this.GHI_CHU.VisibleIndex = 4;
            this.GHI_CHU.Width = 98;
            // 
            // TEN_US_HANG
            // 
            this.TEN_US_HANG.Caption = "NGƯỜI ĐẶT HÀNG";
            this.TEN_US_HANG.FieldName = "USER_NAME";
            this.TEN_US_HANG.Name = "TEN_US_HANG";
            this.TEN_US_HANG.Visible = true;
            this.TEN_US_HANG.VisibleIndex = 5;
            this.TEN_US_HANG.Width = 154;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ĐIỆN THOẠI";
            this.gridColumn1.FieldName = "DIEN_THOAI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 126;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MÃ ĐƠN VỊ";
            this.gridColumn2.FieldName = "MA_DON_VI";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 14;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "LOẠI DỊCH VỤ";
            this.gridColumn3.FieldName = "TEN_NHOM_DICH_VU_YEU_CAU";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 134;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "YÊU CẦU CỤ THỂ";
            this.gridColumn4.FieldName = "NOI_DUNG_DAT_HANG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 122;
            // 
            // THOI_GIAN_TAO
            // 
            this.THOI_GIAN_TAO.Caption = "THỜI ĐIỂM ĐẶT HÀNG";
            this.THOI_GIAN_TAO.DisplayFormat.FormatString = "g";
            this.THOI_GIAN_TAO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.THOI_GIAN_TAO.FieldName = "THOI_GIAN_TAO";
            this.THOI_GIAN_TAO.Name = "THOI_GIAN_TAO";
            this.THOI_GIAN_TAO.Visible = true;
            this.THOI_GIAN_TAO.VisibleIndex = 9;
            this.THOI_GIAN_TAO.Width = 131;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "THỜI GIAN CẦN HOÀN THÀNH";
            this.gridColumn9.FieldName = "LOAI_THOI_GIAN_CAN_HOAN_THANH";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 10;
            this.gridColumn9.Width = 155;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "THỜI ĐIỂM CẦN HOÀN THÀNH";
            this.gridColumn6.DisplayFormat.FormatString = "g";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "THOI_DIEM_CAN_HOAN_THANH";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            this.gridColumn6.Width = 155;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "KÊNH ĐẶT HÀNG";
            this.gridColumn5.FieldName = "TEN_PHUONG_THUC_DAT_HANG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 12;
            this.gridColumn5.Width = 103;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "CHI NHÁNH";
            this.gridColumn7.FieldName = "TEN_CHI_NHANH";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 13;
            this.gridColumn7.Width = 90;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_ds_log_gd_dat_hang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 312);
            this.panel2.TabIndex = 1;
            // 
            // TEN_LOAI_THAO_TAC_LOG
            // 
            this.TEN_LOAI_THAO_TAC_LOG.Caption = "TÊN THAO TÁC LOG";
            this.TEN_LOAI_THAO_TAC_LOG.FieldName = "TEN_LOAI_THAO_TAC_LOG";
            this.TEN_LOAI_THAO_TAC_LOG.Name = "TEN_LOAI_THAO_TAC_LOG";
            this.TEN_LOAI_THAO_TAC_LOG.Visible = true;
            this.TEN_LOAI_THAO_TAC_LOG.VisibleIndex = 10;
            this.TEN_LOAI_THAO_TAC_LOG.Width = 108;
            // 
            // NGUOI_NHAN_THAO_TAC
            // 
            this.NGUOI_NHAN_THAO_TAC.Caption = "NGƯỜI NHẬN THAO TÁC";
            this.NGUOI_NHAN_THAO_TAC.FieldName = "TEN_NGUOI_NHAN_THAO_TAC";
            this.NGUOI_NHAN_THAO_TAC.Name = "NGUOI_NHAN_THAO_TAC";
            this.NGUOI_NHAN_THAO_TAC.Visible = true;
            this.NGUOI_NHAN_THAO_TAC.VisibleIndex = 10;
            this.NGUOI_NHAN_THAO_TAC.Width = 86;
            // 
            // f118_ds_log_dat_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f118_ds_log_dat_hang";
            this.Text = "f118 Lịch sử giao dịch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_log_gd_dat_hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_log_dat_hang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_ds_log_gd_dat_hang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_log_dat_hang;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_TAO;
        private DevExpress.XtraGrid.Columns.GridColumn GHI_CHU;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DON_HANG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lab_tieu_de;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_US_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_LOAI_THAO_TAC_LOG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_NHAN_THAO_TAC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}