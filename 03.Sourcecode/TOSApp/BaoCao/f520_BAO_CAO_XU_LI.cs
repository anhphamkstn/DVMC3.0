using DevExpress.XtraCharts;
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
    public partial class f520_BAO_CAO_XU_LI : Form
    {
        public f520_BAO_CAO_XU_LI()
        {
            InitializeComponent();       
        }

        private void f520_BAO_CAO_XU_LI_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        public void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DON_HANG_NGUOI_XU_LY_DICH_VU_TRANG_THAI_DON_HANG");
            pivotGridControl1.DataSource = v_ds.Tables[0];

            Series series1 = new Series("Series 1", ViewType.SideBySideStackedBar);
            Series series2 = new Series("Series 2", ViewType.SideBySideStackedBar);
            Series series3 = new Series("Series 3", ViewType.SideBySideStackedBar);
            Series series4 = new Series("Series 4", ViewType.SideBySideStackedBar);
            Series series5 = new Series("Series 4", ViewType.SideBySideStackedBar);
            Series series6 = new Series("Series 4", ViewType.SideBySideStackedBar);
            Series series7 = new Series("Series 4", ViewType.SideBySideStackedBar);
            Series series8 = new Series("Series 4", ViewType.SideBySideStackedBar);


        }

        private void m_cmd_loc_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillReportFOByTimeCreated(v_ds, m_dat_tg_dat_dau.Value, m_dat_tg_ket_thuc.Value);
                pivotGridControl1.DataSource = v_ds.Tables[0];
            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

       

       
    }
}
