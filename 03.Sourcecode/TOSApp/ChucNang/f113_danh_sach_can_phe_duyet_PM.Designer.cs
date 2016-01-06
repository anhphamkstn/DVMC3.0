namespace TOSApp.ChucNang
{
    partial class f113_danh_sach_can_phe_duyet_PM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f113_danh_sach_can_phe_duyet_PM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_duyet = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_khong_duyet = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc_danh_sach_can_phe_duyet_PM = new DevExpress.XtraGrid.GridControl();
            this.m_grv_danh_sach_can_phe_duyet_PM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_GD_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_DAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_YEU_CAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANG_THAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_danh_sach_can_phe_duyet_PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_can_phe_duyet_PM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_duyet);
            this.panel1.Controls.Add(this.m_cmd_khong_duyet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 35);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_duyet
            // 
            this.m_cmd_duyet.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_duyet.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_duyet.Image")));
            this.m_cmd_duyet.Location = new System.Drawing.Point(513, 0);
            this.m_cmd_duyet.Name = "m_cmd_duyet";
            this.m_cmd_duyet.Size = new System.Drawing.Size(103, 35);
            this.m_cmd_duyet.TabIndex = 0;
            this.m_cmd_duyet.Text = "Duyệt";
            this.m_cmd_duyet.Click += new System.EventHandler(this.m_cmd_duyet_Click);
            // 
            // m_cmd_khong_duyet
            // 
            this.m_cmd_khong_duyet.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_khong_duyet.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_khong_duyet.Image")));
            this.m_cmd_khong_duyet.Location = new System.Drawing.Point(616, 0);
            this.m_cmd_khong_duyet.Name = "m_cmd_khong_duyet";
            this.m_cmd_khong_duyet.Size = new System.Drawing.Size(134, 35);
            this.m_cmd_khong_duyet.TabIndex = 0;
            this.m_cmd_khong_duyet.Text = "Không phê duyệt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_danh_sach_can_phe_duyet_PM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 378);
            this.panel2.TabIndex = 1;
            // 
            // m_grc_danh_sach_can_phe_duyet_PM
            // 
            this.m_grc_danh_sach_can_phe_duyet_PM.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_danh_sach_can_phe_duyet_PM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_danh_sach_can_phe_duyet_PM.Location = new System.Drawing.Point(0, 0);
            this.m_grc_danh_sach_can_phe_duyet_PM.MainView = this.m_grv_danh_sach_can_phe_duyet_PM;
            this.m_grc_danh_sach_can_phe_duyet_PM.Name = "m_grc_danh_sach_can_phe_duyet_PM";
            this.m_grc_danh_sach_can_phe_duyet_PM.Size = new System.Drawing.Size(750, 378);
            this.m_grc_danh_sach_can_phe_duyet_PM.TabIndex = 0;
            this.m_grc_danh_sach_can_phe_duyet_PM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_danh_sach_can_phe_duyet_PM});
            // 
            // m_grv_danh_sach_can_phe_duyet_PM
            // 
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Preview.Options.UseFont = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_danh_sach_can_phe_duyet_PM.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ID_GD_DAT_HANG,
            this.NGUOI_DAT_HANG,
            this.TEN_YEU_CAU,
            this.BO,
            this.TRANG_THAI});
            this.m_grv_danh_sach_can_phe_duyet_PM.GridControl = this.m_grc_danh_sach_can_phe_duyet_PM;
            this.m_grv_danh_sach_can_phe_duyet_PM.IndicatorWidth = 20;
            this.m_grv_danh_sach_can_phe_duyet_PM.Name = "m_grv_danh_sach_can_phe_duyet_PM";
            this.m_grv_danh_sach_can_phe_duyet_PM.OptionsBehavior.Editable = false;
            this.m_grv_danh_sach_can_phe_duyet_PM.OptionsBehavior.ReadOnly = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.OptionsView.ShowFooter = true;
            this.m_grv_danh_sach_can_phe_duyet_PM.PaintStyleName = "Flat";
            this.m_grv_danh_sach_can_phe_duyet_PM.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_danh_sach_can_phe_duyet_PM_CustomDrawRowIndicator);
            this.m_grv_danh_sach_can_phe_duyet_PM.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_danh_sach_can_phe_duyet_PM_PopupMenuShowing);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // ID_GD_DAT_HANG
            // 
            this.ID_GD_DAT_HANG.Caption = "ID GD ĐẶT HÀNG";
            this.ID_GD_DAT_HANG.FieldName = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Name = "ID_GD_DAT_HANG";
            this.ID_GD_DAT_HANG.Visible = true;
            this.ID_GD_DAT_HANG.VisibleIndex = 1;
            // 
            // NGUOI_DAT_HANG
            // 
            this.NGUOI_DAT_HANG.Caption = "HO_TEN_USER_DAT_HANG";
            this.NGUOI_DAT_HANG.Name = "NGUOI_DAT_HANG";
            this.NGUOI_DAT_HANG.Visible = true;
            this.NGUOI_DAT_HANG.VisibleIndex = 2;
            // 
            // TEN_YEU_CAU
            // 
            this.TEN_YEU_CAU.Caption = "TÊN YÊU CẦU";
            this.TEN_YEU_CAU.FieldName = "TEN_YEU_CAU";
            this.TEN_YEU_CAU.Name = "TEN_YEU_CAU";
            this.TEN_YEU_CAU.Visible = true;
            this.TEN_YEU_CAU.VisibleIndex = 3;
            // 
            // BO
            // 
            this.BO.Caption = "BO";
            this.BO.FieldName = "BO";
            this.BO.Name = "BO";
            this.BO.Visible = true;
            this.BO.VisibleIndex = 4;
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.Caption = "TRẠNG THÁI";
            this.TRANG_THAI.FieldName = "TRANG_THAI";
            this.TRANG_THAI.Name = "TRANG_THAI";
            this.TRANG_THAI.Visible = true;
            this.TRANG_THAI.VisibleIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // f113_danh_sach_can_phe_duyet_PM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 413);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f113_danh_sach_can_phe_duyet_PM";
            this.Text = "f113_Đơn hàng chờ đánh giá";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_danh_sach_can_phe_duyet_PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_sach_can_phe_duyet_PM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_duyet;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_khong_duyet;
        private DevExpress.XtraGrid.GridControl m_grc_danh_sach_can_phe_duyet_PM;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_danh_sach_can_phe_duyet_PM;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_GD_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_DAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_YEU_CAU;
        private DevExpress.XtraGrid.Columns.GridColumn BO;
        private DevExpress.XtraGrid.Columns.GridColumn TRANG_THAI;
        private System.Windows.Forms.Timer timer1;
    }
}