using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.BaoCao
{
    public partial class f510_BAO_CAO_TIEP_NHAN : Form
    {
        public f510_BAO_CAO_TIEP_NHAN()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        public void load_data_2_grid()
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DON_HANG_SO_DIEU_PHOI_LAI");
            pivotGridControl1.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillReportFOByTimeCreated(v_ds, m_dat_startDate.Value, m_dat_tg_ket_thuc.Value);
                pivotGridControl1.DataSource = v_ds.Tables[0];
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }

        }

        
    }
}
