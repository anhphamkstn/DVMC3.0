using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.ChucNang
{
    public partial class f126_don_hang_can_nghiem_thu : Form
    {
        public f126_don_hang_can_nghiem_thu()
        {
            InitializeComponent();
           
        }
        US_GD_DAT_HANG m_us = new US_GD_DAT_HANG();
        public void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            string v_query = "SELECT * FROM V_GD_DAT_HANG  WHERE dbo.[f_get_trang_thai_da_xu_ly_don_hang_YN](ID) ='Y' ORDER BY THOI_GIAN_TAO DESC";
            v_us.FillDatasetWithQuery(v_ds, v_query);
            m_grc_ds_don_dat_hang_can_nghiem_thu.DataSource = v_ds.Tables[0];
        }

        private void f126_don_hang_can_nghiem_thu_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void m_cmd_TM_danh_gia_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
                m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f115_TM_danh_gia v_f115 = new f115_TM_danh_gia();
                v_f115.displayForTM(m_us);
                load_data_to_grid(); ;
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_TM_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
            DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            v_f.Display_for_update(v_us);
            load_data_to_grid();
        }

        private void m_cmd_TM_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
                m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                f103.Display(m_us);
                load_data_to_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void m_grv_ds_don_dat_hang_can_nghiem_thu_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr = m_grv_ds_don_dat_hang_can_nghiem_thu.GetDataRow(m_grv_ds_don_dat_hang_can_nghiem_thu.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }

        private void m_grv_ds_don_dat_hang_can_nghiem_thu_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void m_grv_ds_don_dat_hang_can_nghiem_thu_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
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

        private void m_grv_ds_don_dat_hang_can_nghiem_thu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                load_data_to_grid();
        }
       
    }
}
