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

namespace TOSApp.ChucNang
{
    public partial class f121_tao_user_moi : Form
    {
        public f121_tao_user_moi()
        {
            InitializeComponent();
        }
        US_HT_NGUOI_SU_DUNG m_us = new US_HT_NGUOI_SU_DUNG();
        US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH m_us_nguoi_sd_nhom_cn = new US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH();
        US_HT_BO_DICH_VU m_us_ht_bo_dich_vu = new US_HT_BO_DICH_VU();
        public static List<decimal> m_list_dich_vu = new List<decimal>();
        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtradulieu())
                {
                    //insert vào HT_NGUOI_SU_DUNG
                    m_us.strTEN_TRUY_CAP = m_txt_ten_truy_cap.Text;
                    m_us.strTEN = m_txt_ho_ten.Text;
                    m_us.strMAT_KHAU = us_user.GetMD5(m_txt_mat_khau.Text);
                    m_us.datNGAY_TAO = System.DateTime.Now;
                    m_us.strEMAIL = m_txt_email.Text;
                    m_us.strNGUOI_TAO = us_user.strTEN_TRUY_CAP;
                    m_us.Insert();
                    //insert vào HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH
                    m_us_nguoi_sd_nhom_cn.dcID_NGUOI_SU_DUNG = m_us.dcID;
                    m_us_nguoi_sd_nhom_cn.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_cap_xu_ly.SelectedValue.ToString());
                    m_us_nguoi_sd_nhom_cn.dcID_CHI_NHANH = us_user.dcCHI_NHANH;
                    m_us_nguoi_sd_nhom_cn.Insert();
                    //insert htbo dịch vụ
                    for (int i = 0; i < m_list_dich_vu.Count; i++)
                    {
                        m_us_ht_bo_dich_vu.dcID_DICH_VU = m_list_dich_vu[i];
                        m_us_ht_bo_dich_vu.dcID_NGUOI_SU_DUNG = m_us.dcID;
                        if (CIPConvert.ToDecimal(m_cbo_cap_xu_ly.SelectedValue.ToString()) == 7)
                            m_us_ht_bo_dich_vu.dcCAP_SU_DUNG = 2;
                        else
                            m_us_ht_bo_dich_vu.dcCAP_SU_DUNG = CIPConvert.ToDecimal(m_cbo_cap_xu_ly.SelectedValue.ToString());
                        m_us_ht_bo_dich_vu.strTRANG_THAI_HSD = "N";
                        m_us_ht_bo_dich_vu.Insert();
                    }
                    m_list_dich_vu.Clear();
                    MessageBox.Show("Thành công!");
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }

        }

        private bool kiemtradulieu()
        {
            
            if (m_txt_ho_ten.Text == "")
            {
                m_lab_eror.Text = "Nhập họ tên!";
                return false;
            }
            else if (m_txt_ten_truy_cap.Text == "")
            {
                m_lab_eror.Text = "Nhập tên truy cập!";
                return false;
            }
            else if (m_txt_mat_khau.Text == "")
            {
                m_lab_eror.Text = "nhập mật khẩu!";
                return false;
            }
            else if(m_txt_email.Text == "")
            {
                m_lab_eror.Text ="Nhập email của bạn";
                return false;
            }
            else if (m_txt_email.Text.IndexOf("@topica.edu.vn") == -1 && m_txt_email.Text.IndexOf("@topica.asia.vn") == -1)
            {
                m_lab_eror.Text = "Email không đúng định dạng";
                return false;
            }
            else if (m_cmd_chon_dich_vu.Enabled && m_list_dich_vu.Count == 0)
            {
                m_lab_eror.Text = "chọn dịch vụ";
                return false;
            }
            else
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "SELECT ID FROM HT_NGUOI_SU_DUNG WHERE TEN_TRUY_CAP = '" + m_txt_ten_truy_cap.Text + "'");
                if (v_ds.Tables[0].Rows.Count > 0)
                {
                    m_lab_eror.Text = "Tên truy cập đã tồn tại trong hệ thống";
                    m_txt_mat_khau.Text = "";
                    return false;
                }
                return true;
            }
        }

        private void f121_tao_user_moi_Load(object sender, EventArgs e)
        {
            load_cap_xu_ly();
        }
       
        private void load_cap_xu_ly()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            string v_str_query = "";
            if (us_user.dcIDNhom == 5 && v_us.get_id_td_dich_vu(10, us_user.dcID) == 0)
                v_str_query = "SELECT ID, MA_NHOM FROM HT_NHOM_NGUOI_SU_DUNG WHERE ID NOT IN (6,5)";
            else if (us_user.dcIDNhom == 3 && v_us.get_id_pm_dich_vu(10, us_user.dcID) == 0)
                v_str_query = "SELECT ID, MA_NHOM FROM HT_NHOM_NGUOI_SU_DUNG WHERE ID NOT IN  (3,4,5,6)";
            else
                v_str_query = "SELECT ID, MA_NHOM FROM HT_NHOM_NGUOI_SU_DUNG WHERE ID NOT IN (6)";
            WinFormControls.load_data_to_combobox_with_query(m_cbo_cap_xu_ly, "ID", "MA_NHOM", WinFormControls.eTAT_CA.NO, v_str_query);
        }

        private void m_cmd_chon_dich_vu_Click(object sender, EventArgs e)
        {
            f128_danh_sach_dich_vu v_f_ds_dich_vu = new f128_danh_sach_dich_vu();
            v_f_ds_dich_vu.ShowDialog();
        }

        private void m_cbo_cap_xu_ly_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_cbo_cap_xu_ly.Text == "FO" || m_cbo_cap_xu_ly.Text == "TM")
            {
                m_cmd_chon_dich_vu.Enabled = false;
                m_list_dich_vu.Clear();
            }
            else
                m_cmd_chon_dich_vu.Enabled = true;
        }
    }
}
