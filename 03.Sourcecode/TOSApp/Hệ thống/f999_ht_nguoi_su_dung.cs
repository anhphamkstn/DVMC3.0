using IP.Core.IPCommon;
using IP.Core.IPData.DBNames;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.ChucNang;

namespace TOSApp.Hệ_thống
{
    public partial class f999_ht_nguoi_su_dung : Form
    {
        public f999_ht_nguoi_su_dung()
        {
            InitializeComponent();
            
        }

        private void f999_ht_nguoi_su_dung_Load(object sender, EventArgs e)
        {
            load_data_griv();
        }

        private void load_data_griv()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_HT_NGUOI_SU_DUNG");
            m_grc_ht_nguoi_su_dung.DataSource = v_ds.Tables[0];

        }

        private void simpbtn_them_Click(object sender, EventArgs e)
        {
            try
            {
                f121_tao_user_moi v_f = new f121_tao_user_moi();
                v_f.ShowDialog();
                load_data_griv();

            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void simpbtn_sua_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow v_dr = m_grv_ht_nguoi_su_dung.GetDataRow(m_grv_ht_nguoi_su_dung.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr[HT_NGUOI_SU_DUNG.ID].ToString());
                US_HT_NGUOI_SU_DUNG v_us = new US_HT_NGUOI_SU_DUNG(v_id);
                f999_ht_nguoi_su_dung_de v_f = new f999_ht_nguoi_su_dung_de();
                v_f.displayupdate(v_us);
                load_data_griv();

            }
            catch (Exception v_e)
            {

                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        private void m_grv_ht_nguoi_su_dung_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
