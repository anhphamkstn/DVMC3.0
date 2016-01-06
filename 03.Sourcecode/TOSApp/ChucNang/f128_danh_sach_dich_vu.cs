using IP.Core.IPCommon;
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
    public partial class f128_danh_sach_dich_vu : Form
    {
        public f128_danh_sach_dich_vu()
        {
            InitializeComponent();
        }

        private void f128_danh_sach_dich_vu_Load(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if ((us_user.dcIDNhom == 3 && v_us.get_id_pm_dich_vu(11, us_user.dcID) != 0) || (us_user.dcIDNhom == 5 && v_us.get_id_td_dich_vu(11, us_user.dcID) != 0))
            {
                v_us.FillDatasetWithTableName(v_ds, "V_DM_LOAI_YEU_CAU");
            }
            else
                v_us.FillDatasetWithQuery(v_ds, "SELECT dmyc.* FROM HT_BO_DICH_VU,V_DM_LOAI_YEU_CAU AS dmyc WHERE dmyc.ID =HT_BO_DICH_VU.ID_DICH_VU AND HT_BO_DICH_VU.ID_NGUOI_SU_DUNG = " + us_user.dcID.ToString());
            m_grc_dich_vu.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_ok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_grv_dich_vu.SelectedRowsCount; i++)
            {
                f121_tao_user_moi.m_list_dich_vu.Add(CIPConvert.ToDecimal(m_grv_dich_vu.GetDataRow(m_grv_dich_vu.GetSelectedRows()[i])["ID"].ToString()));
            }
            this.Close();
        }
    }
}
