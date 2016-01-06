using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPCOREUS;
using IP.Core.IPCommon;
using DevExpress.XtraGrid.Views.Grid;
namespace TOSApp.ChucNang
{
    public partial class f113_danh_sach_can_phe_duyet_PM : Form
    {
        public f113_danh_sach_can_phe_duyet_PM()
        {
            InitializeComponent();
            load_data_2_grid();
        }
        US_GD_LOG_DAT_HANG m_us = new US_GD_LOG_DAT_HANG();
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_CAN_PM_DANH_GIA");
          //  v_us.FillDatasetWithQuery(v_ds, " select * from V_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH WHERE ID_NHOM = 2");
            m_grc_danh_sach_can_phe_duyet_PM.DataSource = v_ds.Tables[0];
        }
        private void fill_data_2_m_us()
        {

            DataRow v_dr = m_grv_danh_sach_can_phe_duyet_PM.GetDataRow(m_grv_danh_sach_can_phe_duyet_PM.FocusedRowHandle);
            m_us = new US_GD_LOG_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
        }

        private void m_cmd_duyet_Click(object sender, EventArgs e)
        {
            try
            {
                fill_data_2_m_us();
                update_log_da_xu_ly();
                ghi_log_da_duyet(m_us);
                cap_nhat_thoi_gian_hoan_Thanh();
                MessageBox.Show("Thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           

        }

        private void cap_nhat_thoi_gian_hoan_Thanh()
        {
            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG();
            v_us.dcID = m_us.dcID_GD_DAT_HANG;
            v_us.datTHOI_GIAN_HOAN_THANH = System.DateTime.Now;
        }

        private void ghi_log_da_duyet(US_GD_LOG_DAT_HANG m_us)
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us = m_us;
            v_us.strTHAO_TAC_HET_HAN_YN = "N";
            v_us.strGHI_CHU = "đã duyệt";
            v_us.Insert();
        }

        private void update_log_da_xu_ly()
        {
            US_GD_LOG_DAT_HANG v_us = new US_GD_LOG_DAT_HANG();
            v_us = m_us;
            v_us.strTHAO_TAC_HET_HAN_YN = "Y";
            v_us.strGHI_CHU = "đã được PM phê duyệt";
            v_us.Update();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_2_grid();

        }

        private void m_grv_danh_sach_can_phe_duyet_PM_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void m_grv_danh_sach_can_phe_duyet_PM_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            // Check whether a row is right-clicked.
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                // Add a submenu with a single menu item.
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }
        
    }
}
