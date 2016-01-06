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
    public partial class f500_BAO_CAO_DANH_GIA : Form
    {
        public f500_BAO_CAO_DANH_GIA()
        {
            InitializeComponent();
            load_data_2_grid();
        }

        public void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_TINH_HINH_DANH_GIA");
            pivotGridControl1.DataSource = v_ds.Tables[0];

        }

       
        
    }
}
