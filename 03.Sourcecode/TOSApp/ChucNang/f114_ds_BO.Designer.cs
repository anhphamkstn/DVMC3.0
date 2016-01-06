namespace TOSApp.ChucNang
{
    partial class f114_ds_BO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f114_ds_BO));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_txt_ma_don_hang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_sch = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.m_grc_ds_BO = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_BO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_BO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_BO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_BO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_OK);
            this.panel1.Controls.Add(this.m_cmd_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 33);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_OK
            // 
            this.m_cmd_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_OK.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_OK.Image")));
            this.m_cmd_OK.Location = new System.Drawing.Point(614, 0);
            this.m_cmd_OK.Name = "m_cmd_OK";
            this.m_cmd_OK.Size = new System.Drawing.Size(75, 33);
            this.m_cmd_OK.TabIndex = 0;
            this.m_cmd_OK.Text = "OK";
            this.m_cmd_OK.Click += new System.EventHandler(this.m_cmd_OK_Click);
            // 
            // m_cmd_Cancel
            // 
            this.m_cmd_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_Cancel.Image")));
            this.m_cmd_Cancel.Location = new System.Drawing.Point(689, 0);
            this.m_cmd_Cancel.Name = "m_cmd_Cancel";
            this.m_cmd_Cancel.Size = new System.Drawing.Size(75, 33);
            this.m_cmd_Cancel.TabIndex = 0;
            this.m_cmd_Cancel.Text = "Cancel";
            this.m_cmd_Cancel.Click += new System.EventHandler(this.m_cmd_Cancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_txt_ma_don_hang);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 38);
            this.panel3.TabIndex = 0;
            // 
            // m_txt_ma_don_hang
            // 
            this.m_txt_ma_don_hang.AutoSize = true;
            this.m_txt_ma_don_hang.Location = new System.Drawing.Point(258, 9);
            this.m_txt_ma_don_hang.Name = "m_txt_ma_don_hang";
            this.m_txt_ma_don_hang.Size = new System.Drawing.Size(70, 14);
            this.m_txt_ma_don_hang.TabIndex = 0;
            this.m_txt_ma_don_hang.Text = "mã đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_sch);
            this.panel2.Controls.Add(this.m_grc_ds_BO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 387);
            this.panel2.TabIndex = 1;
            // 
            // m_sch
            // 
            this.m_sch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_sch.Location = new System.Drawing.Point(196, 0);
            this.m_sch.Name = "m_sch";
            this.m_sch.Size = new System.Drawing.Size(568, 387);
            this.m_sch.Start = new System.DateTime(2015, 9, 10, 0, 0, 0, 0);
            this.m_sch.Storage = this.schedulerStorage1;
            this.m_sch.TabIndex = 1;
            this.m_sch.Text = "schedulerControl1";
            timeRuler1.AlwaysShowTimeDesignator = true;
            timeRuler1.TimeZone.Id = "SE Asia Standard Time";
            timeRuler1.UseClientTimeZone = false;
            this.m_sch.Views.DayView.TimeRulers.Add(timeRuler1);
            this.m_sch.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // m_grc_ds_BO
            // 
            this.m_grc_ds_BO.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_BO.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_grc_ds_BO.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_BO.MainView = this.m_grv_ds_BO;
            this.m_grc_ds_BO.Name = "m_grc_ds_BO";
            this.m_grc_ds_BO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.m_grc_ds_BO.Size = new System.Drawing.Size(196, 387);
            this.m_grc_ds_BO.TabIndex = 0;
            this.m_grc_ds_BO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_BO});
            // 
            // m_grv_ds_BO
            // 
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.Empty.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.EvenRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.EvenRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.EvenRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FilterPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FilterPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.m_grv_ds_BO.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FocusedCell.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FocusedCell.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.m_grv_ds_BO.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.m_grv_ds_BO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.FooterPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.FooterPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.GroupButton.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupButton.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupFooter.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.GroupFooter.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.GroupRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.GroupRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.GroupRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.m_grv_ds_BO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.m_grv_ds_BO.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_BO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.HorzLine.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.OddRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.OddRow.Options.UseBorderColor = true;
            this.m_grv_ds_BO.Appearance.OddRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.m_grv_ds_BO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_BO.Appearance.Preview.Options.UseFont = true;
            this.m_grv_ds_BO.Appearance.Preview.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.m_grv_ds_BO.Appearance.Row.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.Row.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.m_grv_ds_BO.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.RowSeparator.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.m_grv_ds_BO.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.SelectedRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.SelectedRow.Options.UseForeColor = true;
            this.m_grv_ds_BO.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.m_grv_ds_BO.Appearance.TopNewRow.Options.UseBackColor = true;
            this.m_grv_ds_BO.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.m_grv_ds_BO.Appearance.VertLine.Options.UseBackColor = true;
            this.m_grv_ds_BO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN_BO,
            this.gridColumn1});
            this.m_grv_ds_BO.GridControl = this.m_grc_ds_BO;
            this.m_grv_ds_BO.IndicatorWidth = 20;
            this.m_grv_ds_BO.Name = "m_grv_ds_BO";
            this.m_grv_ds_BO.OptionsBehavior.Editable = false;
            this.m_grv_ds_BO.OptionsBehavior.ReadOnly = true;
            this.m_grv_ds_BO.OptionsSelection.MultiSelect = true;
            this.m_grv_ds_BO.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.m_grv_ds_BO.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv_ds_BO.OptionsView.EnableAppearanceOddRow = true;
            this.m_grv_ds_BO.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_ds_BO.OptionsView.ShowFooter = true;
            this.m_grv_ds_BO.OptionsView.ShowGroupPanel = false;
            this.m_grv_ds_BO.PaintStyleName = "Flat";
            this.m_grv_ds_BO.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.m_grv_ds_BO_CustomDrawRowIndicator);
            // 
            // TEN_BO
            // 
            this.TEN_BO.Caption = "TÊN BO";
            this.TEN_BO.FieldName = "BO";
            this.TEN_BO.Name = "TEN_BO";
            this.TEN_BO.Visible = true;
            this.TEN_BO.VisibleIndex = 1;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chi nhánh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // f114_ds_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "f114_ds_BO";
            this.Text = "f114_Danh sách BO";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_sch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_BO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_BO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_OK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_txt_ma_don_hang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_Cancel;
        private DevExpress.XtraGrid.GridControl m_grc_ds_BO;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_BO;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_BO;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraScheduler.SchedulerControl m_sch;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}