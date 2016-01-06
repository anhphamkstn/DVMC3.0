using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_DVMC.hethong
{
    public partial class f000_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_dcID"] != null)
            {
                Response.Redirect("~/ht/f100_nghiepvu_bo.aspx"); 
            }
            m_lab_error.Visible = true;
           
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                m_lab_error.Text = "";
                if ((login_username.Text == "") || (login_password.Text == ""))
                    m_lab_error.Text = "Tên truy cập hoặc password để trống.";
                else
                {
                    if (check_login())
                    {
                        if (Session["user_dcIDNhom"].ToString() == "2")
                            Response.Redirect("~/ht/f100_nghiepvu_bo.aspx?mode=can_tiep_nhan");
                        else m_lab_error.Text = "User này chưa được hỗ trợ";
                    }
                    else m_lab_error.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                }
            }
            catch (Exception v_e)
            {
               
            }
        }

        private bool check_login()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetLogin(v_ds, login_username.Text, usUser.GetMD5(login_password.Text), CIPConvert.ToDecimal(select_chi_nhanh.SelectedValue.ToString()));
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[0];
                US_V_HT_NGUOI_SU_DUNG ht_us = new US_V_HT_NGUOI_SU_DUNG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                //us_user.dcID = ht_us.dcID;
                //us_user.dcIDNhom = ht_us.dcID_NHOM;
                //us_user.dcCHI_NHANH = CIPConvert.ToDecimal(select_chi_nhanh.SelectedValue.ToString());
                //us_user.strTEN_TRUY_CAP = ht_us.strTEN_TRUY_CAP;
                //us_user.strEMAIL = ht_us.strEMAIL;
                Session["user_dcID"] = ht_us.dcID;
                Session["user_dcIDNhom"] = ht_us.dcID_NHOM;
                Session["user_dcCHI_NHANH"] = CIPConvert.ToDecimal(select_chi_nhanh.SelectedValue.ToString());
                Session["user_strTEN_TRUY_CAP"] = ht_us.strTEN_TRUY_CAP;
                Session["user_strEMAIL"] = ht_us.strEMAIL;
                return true;
            }
            else return false;
        }
    }
}