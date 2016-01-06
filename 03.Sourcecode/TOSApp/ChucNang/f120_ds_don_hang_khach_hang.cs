using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
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
    public partial class f120_ds_don_hang_khach_hang : Form
    {
        public f120_ds_don_hang_khach_hang()
        {
            InitializeComponent();
          
        }    
        public void load_data_2_grid()
        {                    
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            if (deStartDate.EditValue == null) startDate = new DateTime(2000, 1, 1);
            else startDate = (DateTime)deStartDate.EditValue;
            if (deEndDate.EditValue == null) endDate = DateTime.Now;
            else endDate = (DateTime)deEndDate.EditValue;
             var states = (from CheckedListBoxItem item in chbbOrderState.Properties.Items
                        where item.CheckState == CheckState.Checked
                        select item.Value.ToString()).ToArray();
             string orderState = "";
            foreach (string state in states)
            {
                orderState += state + ",";
            }
            orderState += "0";
            v_us.FillAllOrder(v_ds, startDate, endDate, orderState);             
            m_grc_ds_tat_ca_don_dat_hang.DataSource = v_ds.Tables[0];
        }

        private void view_thong_tin_don_hang(object sender, EventArgs e)
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
                DataRow v_dr = m_grv_ds_tat_ca_don_dat_hang.GetDataRow(m_grv_ds_tat_ca_don_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG v_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f100_don_dat_hang_new v_f100 = new f100_don_dat_hang_new();
                v_f100.displayForUpdate2(v_us);
                this.Show();
            }
        }

        private void m_grv_ds_don_hang_nguoi_xu_ly_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

        }

        private void m_grv_ds_don_hang_nguoi_xu_ly_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
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

        private void m_grv_ds_tat_ca_don_dat_hang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                load_data_2_grid();
        }

        private void m_cmd_FO_huy_hon_hang_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_ds_tat_ca_don_dat_hang.GetDataRow(m_grv_ds_tat_ca_don_dat_hang.FocusedRowHandle);
                US_GD_DAT_HANG m_us = new US_GD_DAT_HANG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                f103_TD_ly_do_tu_choi f103 = new f103_TD_ly_do_tu_choi();
                f103.Display(m_us);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void f120_ds_don_hang_khach_hang_Load(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "getAllOrderState");
            //chbbOrderState.Properties.DataSource = (from DataRow dr in v_ds.Tables[0].Rows
            //                                        select (string)dr["TEN"]).ToList();
            chbbOrderState.Properties.DataSource = v_ds.Tables[0];
            chbbOrderState.Properties.DisplayMember = "TEN";
            chbbOrderState.Properties.ValueMember = "ID";
            chbbOrderState.CheckAll();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(); 
                             
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        
    }
}
