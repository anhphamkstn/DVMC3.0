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
    public partial class f999_ht_bo_pm_td_dich_vu_them_nhan_vien : Form
    {
        public f999_ht_bo_pm_td_dich_vu_them_nhan_vien()
        {
            InitializeComponent();
        }
        decimal m_id_nhom;
        US_DM_LOAI_YEU_CAU m_us;
        private void f999_ht_bo_pm_td_dich_vu_them_nhan_vien_Load(object sender, EventArgs e)
        {

        }
        internal void load_to_form(decimal v_id_nhom, List<decimal> v_list)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            string v_query;
            string m_nhom;
            if (v_id_nhom == 2)
            {
                m_nhom = v_id_nhom.ToString() + ",7";
            }
            else m_nhom = v_id_nhom.ToString();
            if (v_list.Count != 0)
            {
                v_query = "SELECT hnsd.ID,hnsd.TEN_TRUY_CAP FROM V_HT_NGUOI_SU_DUNG hnsd WHERE hnsd.ID_NHOM IN ( " + m_nhom + " )AND hnsd.ID NOT IN (";
                for (int i = 0; i < v_list.Count; i++)
                {
                    v_query += v_list[i].ToString() + ",";
                    if (i == v_list.Count - 1)
                        v_query += v_list[i].ToString();
                }
                v_query += ")";
            }
            else
                v_query = "SELECT hnsd.ID,hnsd.TEN_TRUY_CAP FROM V_HT_NGUOI_SU_DUNG hnsd WHERE hnsd.ID_NHOM = " + v_id_nhom.ToString();

            v_ds.Tables.Add(new DataTable()); v_us.FillDatasetWithQuery(v_ds, v_query);
            grc_danh_sach.DataSource = v_ds.Tables[0];
            m_id_nhom = v_id_nhom;

        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_ok_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < grv_danh_sach.SelectedRowsCount; i++)
            {
                if (m_id_nhom == 2)
                {
                     f999_ht_bo_pm_td_dich_vu_de.m_lst_id_nguoi_xu_ly_cap_1.Add(CIPConvert.ToDecimal(grv_danh_sach.GetDataRow(grv_danh_sach.GetSelectedRows()[i])["ID"].ToString()));
                }
                if (m_id_nhom == 3)
                {
                    f999_ht_bo_pm_td_dich_vu_de.m_lst_id_nguoi_xu_ly_cap_2.Add(CIPConvert.ToDecimal(grv_danh_sach.GetDataRow(grv_danh_sach.GetSelectedRows()[i])["ID"].ToString()));
                }
                if (m_id_nhom == 5)
                {
                    f999_ht_bo_pm_td_dich_vu_de.m_lst_id_nguoi_xu_ly_cap_3.Add(CIPConvert.ToDecimal(grv_danh_sach.GetDataRow(grv_danh_sach.GetSelectedRows()[i])["ID"].ToString()));
                }
            }
            this.Close();
        }
    }
}
