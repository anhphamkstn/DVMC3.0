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
    public partial class f122_ds_don_hang_dang_xu_ly : Form
    {
        public f122_ds_don_hang_dang_xu_ly()
        {
            InitializeComponent();
        }

        private void f122_ds_don_hang_dang_xu_ly_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }
        public void load_data_to_grid()
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                string v_str_query = "SELECT gdh.*FROM V_GD_DAT_HANG as gdh, HT_BO_DICH_VU bdv WHERE dbo.f_get_trang_thai_xu_ly_don_hang_YN(gdh.ID) = 'Y' AND gdh.ID_DV_YEU_CAU = bdv.ID_DICH_VU AND bdv.ID_NGUOI_SU_DUNG =" + us_user.dcID.ToString() + "and  bdv.CAP_SU_DUNG =" + us_user.dcIDNhom.ToString() + "ORDER BY gdh.[THOI_GIAN_TAO] DESC";
                v_us.FillDatasetWithQuery(v_ds, v_str_query);
                m_grc_ds_don_hang_dang_xu_ly.DataSource = v_ds.Tables[0];
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
            
        }
        private void m_grv_ds_don_hang_dang_xu_ly_DoubleClick(object sender, EventArgs e)
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
                DataRow v_dr = m_grv_ds_don_hang_dang_xu_ly.GetDataRow(m_grv_ds_don_hang_dang_xu_ly.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }

        private void m_grv_ds_don_hang_dang_xu_ly_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

        }


        private void m_grv_ds_don_hang_dang_xu_ly_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
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

        private void m_grv_ds_don_hang_dang_xu_ly_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                load_data_to_grid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

       
    }
}
