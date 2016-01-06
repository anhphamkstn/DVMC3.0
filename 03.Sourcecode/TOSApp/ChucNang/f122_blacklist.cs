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
    public partial class f122_blacklist : Form
    {
        public f122_blacklist()
        {
            InitializeComponent();
            if (us_user.dcID==5)
            {
                m_cmd_them.Visible = false;
            }
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());


            v_us.FillDatasetWithQuery(v_ds, " select * from DM_BLACK_LIST where ADD_YN='N'");
            m_grc_ds_backlist.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            f122_blacklist_detail v_f = new f122_blacklist_detail();
            v_f.ShowDialog();
            load_data_2_grid();
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            DataRow v_dr = m_grv_ds_blacklist.GetDataRow(m_grv_ds_blacklist.FocusedRowHandle);
           US_DM_BLACK_LIST v_us = new US_DM_BLACK_LIST(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
           v_us.strADD_YN = "Y";
           v_us.datNGAY_REMOVE = System.DateTime.Now;
           v_us.Update();
           load_data_2_grid();
        }

        private void m_grv_ds_blacklist_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void m_grv_ds_blacklist_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
