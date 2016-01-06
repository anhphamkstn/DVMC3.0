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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace TOSApp.ChucNang
{
    public partial class f117_ds_tat_ca_don_dat_hang : Form
    {
        decimal v_deadline = 0;
        US_GD_DAT_HANG m_us;
        public f117_ds_tat_ca_don_dat_hang()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        public void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_GD_DAT_HANG where dbo.f_get_trang_thai_xu_ly_don_hang_YN(ID) = 'Y' order by THOI_GIAN_TAO DESC");
            m_grc_ds_don_dat_hang.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_chinh_sua_don_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate(v_us, v_deadline);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_data_2_grid();
        }
     
        internal void display_for_refurse_dealine(decimal deadline_id)
        {

            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                this.Show();
                v_deadline = deadline_id;
                load_data_2_grid();

            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_grv_ds_don_dat_hang_DoubleClick(object sender, EventArgs e)
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
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }

        private void m_grv_ds_don_dat_hang_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void m_grv_ds_don_dat_hang_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Clear();
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }

        private void m_cmd_FO_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
                m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                f103.Display(m_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_FO_cap_nhat_xu_ly_Click(object sender, EventArgs e)
        {
            f101_cap_nhat_xu_don_hang v_f = new f101_cap_nhat_xu_don_hang();
            DataRow v_dr = m_grv_ds_don_dat_hang.GetDataRow(m_grv_ds_don_dat_hang.FocusedRowHandle);
            US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
            v_f.Display_for_update(v_us);
            load_data_2_grid();
        }

        private void m_grv_ds_don_dat_hang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                load_data_2_grid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data_2_grid();
        }


    }
}
