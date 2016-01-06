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
    public partial class f999_ht_nguoi_su_dung_de : Form
    {
        public f999_ht_nguoi_su_dung_de()
        {
            InitializeComponent();
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
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_HT_NGUOI_SU_DUNG m_us = new US_HT_NGUOI_SU_DUNG();
        
        private void form_to_us()
        {
            m_us.strTEN_TRUY_CAP = txt_ten_truy_cap.Text;
            m_us.strTEN = txt_ten.Text;
            //m_us.strNGUOI_TAO = txt_nguoi_tao.Text;
            m_us.strEMAIL = txt_email.Text;
            m_us.strTRANG_THAI = "N";
            m_us.datNGAY_TAO = System.DateTime.Now;
           
        }

        private bool kiemtrdulieu()
        {
            if(txt_ten_truy_cap.Text==""|| txt_ten.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập dữ liệu!");
                return false;
            }
            return true;
        }

        internal void displayinsert()
        {
            m_e_form_mode =  DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        internal void displayupdate(US_HT_NGUOI_SU_DUNG v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();

        }

        private void us_to_form(US_HT_NGUOI_SU_DUNG v_us)
        {
            txt_ten_truy_cap.Text = v_us.strTEN_TRUY_CAP;
            txt_ten.Text = v_us.strTEN;
            txt_email.Text = v_us.strEMAIL;
            US_V_HT_NGUOI_SU_DUNG V_us = new US_V_HT_NGUOI_SU_DUNG(v_us.dcID);
            m_cbo_cap_xu_ly.SelectedValue = V_us.dcID_NHOM;

        }

        private void simpbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtrdulieu())
                {
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us();
                        m_us.Insert();
                        insert_2_nhom_sd();
                    }
                    else
                    {
                        form_to_us();
                        m_us.Update();
                        update_nhom_sd();

                    }
                }
                MessageBox.Show("Thành công!");
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void update_nhom_sd()
        {
            string m_query = "select top 1 id from ht_nguoi_su_dung_nhom_chi_nhanh where ID_NGUOI_SU_DUNG = "+m_us.dcID ;
            US_DUNG_CHUNG us = new US_DUNG_CHUNG();
            DataSet ds = new DataSet();
            ds.Tables.Add(new DataTable());
            us.FillDatasetWithQuery(ds,m_query);
            US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH m_us_nguoi_sd_nhom_cn = new US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH(CIPConvert.ToDecimal(ds.Tables[0].Rows[0][0].ToString()));
            m_us_nguoi_sd_nhom_cn.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_cap_xu_ly.SelectedValue.ToString());
            m_us.Update();
        }

        private void insert_2_nhom_sd()
        {
            US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH m_us_nguoi_sd_nhom_cn = new US_HT_NGUOI_SU_DUNG_NHOM_CHI_NHANH();
            m_us_nguoi_sd_nhom_cn.dcID_NGUOI_SU_DUNG = m_us.dcID;
            m_us_nguoi_sd_nhom_cn.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_cap_xu_ly.SelectedValue.ToString());
            m_us_nguoi_sd_nhom_cn.dcID_CHI_NHANH = us_user.dcCHI_NHANH;
            m_us_nguoi_sd_nhom_cn.Insert();
        }

      

        private void simpbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtrdulieu())
                {
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        form_to_us();
                        m_us.strMAT_KHAU = us_user.GetMD5("1");
                        m_us.Insert();
                        insert_2_nhom_sd();
                    }
                    else
                    {
                        form_to_us();
                        m_us.Update();
                        update_nhom_sd();

                    }
                }
                MessageBox.Show("Thành công!");
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
