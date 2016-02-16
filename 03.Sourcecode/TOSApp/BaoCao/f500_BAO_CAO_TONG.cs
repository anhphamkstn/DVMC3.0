using DevExpress.XtraCharts;
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
    public partial class f500_BAO_CAO_TONG : Form
    {

        US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
        DataSet v_ds = new DataSet();
        public f500_BAO_CAO_TONG()
        {
            InitializeComponent();               
            load_data_2_grid();
            load_data_to_chart();
        }

        public void load_data_2_grid()
        {
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_BAO_CAO_TONG");
            pivotGridControl1.DataSource = v_ds.Tables[0];
        }

        private void load_data_to_chart()
        {
            chartControl.DataSource = v_ds.Tables[0];
            //chartControl.SeriesDataMember = "TRANG_THAI";
            //chartControl.SeriesTemplate.ArgumentDataMember = "TEN_CHI_NHANH";
            //chartControl.SeriesTemplate.SummaryFunction = "COUNT()";

            var v_ssv = new PieSeriesView();

            //chartControl.SeriesTemplate.View = v_ssv;
            //foreach (Series item in chartControl.Series)
            //{
            //    item.ShowInLegend = true;
            //    item.LegendText = item.Name;
            //    item.LegendTextPattern = "{S} - {A} : {VP:0.##%} ({V} Lao động)";
            //    item.Label.TextPattern = "{S} - {A}";
            //}
        }

       
        
    }
}
