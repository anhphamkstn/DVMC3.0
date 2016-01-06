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

namespace TOSApp.Hệ_thống
{
    public partial class f999_ht_bo_pm_td_dich_vu : Form
    {
        public f999_ht_bo_pm_td_dich_vu()
        {
            InitializeComponent();
        }

        private void f999_ht_bo_dich_vu_Load(object sender, EventArgs e)
        {
            load_data_to_grv();
        }

        private void load_data_to_grv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            string v_str_query;
            if ((us_user.dcIDNhom == 3 && v_us.get_id_pm_dich_vu(11,us_user.dcID) != 0) ||(us_user.dcIDNhom == 5  && v_us.get_id_td_dich_vu(11, us_user.dcID) != 0))
            {
                v_str_query = "SELECT * FROM V_DICH_VU_NGUOI_XU_LY";
            }
            else
            {
                m_grv_ht_bo_pm_td_dich_vu.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                v_str_query = "SELECT * FROM V_DICH_VU_NGUOI_XU_LY WHERE ID = ANY (select *from dbo.f_get_ds_id_dich_vu("+ us_user.dcIDNhom.ToString() + "," + us_user.dcID.ToString() + "))";
            }
            
            v_us.FillDatasetWithQuery(v_ds, v_str_query);
            m_grc_ht_bo_pm_td_dich_vu.DataSource = v_ds.Tables[0];
        }

        private void m_grv_ht_bo_pm_td_dich_vu_DoubleClick(object sender, EventArgs e)
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
                 DataRow v_dr_grv = m_grv_ht_bo_pm_td_dich_vu.GetDataRow(m_grv_ht_bo_pm_td_dich_vu.FocusedRowHandle);
                 if(v_dr_grv == null)
                 {
                     try
                     {
                         f999_ht_bo_pm_td_dich_vu_de v_f = new f999_ht_bo_pm_td_dich_vu_de();
                         v_f.WindowState = FormWindowState.Maximized;
                         v_f.displayInsert();
                         load_data_to_grv();
                     }
                     catch(Exception v_e)
                     {
                         CSystemLog_100.ExceptionHandle(v_e);
                     }
                 }
                 else
                 {
                     try
                     {
                         decimal v_id = CIPConvert.ToDecimal(v_dr_grv["ID"].ToString());
                         US_DM_LOAI_YEU_CAU v_us = new US_DM_LOAI_YEU_CAU(v_id);
                         f999_ht_bo_pm_td_dich_vu_de v_f = new f999_ht_bo_pm_td_dich_vu_de();
                         v_f.WindowState = FormWindowState.Maximized;
                         v_f.displayUpdate(v_us);
                         load_data_to_grv();
                     }
                     catch (Exception v_e)
                     {
                         CSystemLog_100.ExceptionHandle(v_e);
                     }
                    
                 }
             }
        }
    }
}
