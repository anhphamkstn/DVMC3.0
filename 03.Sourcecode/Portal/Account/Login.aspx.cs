using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPCommon;
using IP.Core.IPData;
using IP.Core.IPUserService;

using System.Data;

using IPCOREDS;
using IPCOREUS;
using IPCOREDS.CDBNames;

public partial class Account_Login : System.Web.UI.Page
{
    #region Data structure
    #endregion

    #region Members
    US_HT_NGUOI_SU_DUNG m_us_ht_nguoi_su_dung;
    DS_HT_NGUOI_SU_DUNG m_ds_ht_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
    US_HT_NGUOI_SU_DUNG.LogonResult m_logon_result = US_HT_NGUOI_SU_DUNG.LogonResult.WrongPassword_OR_Name;
    #endregion

    #region Private methods
    private void load_data_2_cbo_truong()
    {
        US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
        string v_str_loai_tu_dien = LOAI_TU_DIEN_ID.TO_CHUC_TRUONG.ToString();

        v_us_tu_dien.fill_tu_dien_by_procedure("pr_CM_DM_TU_DIEN_Load_tu_dien_by_procedure", v_str_loai_tu_dien, v_ds_tu_dien);

        m_cbo_truong.DataTextField = CM_DM_TU_DIEN.MA_TU_DIEN;
        m_cbo_truong.DataValueField = CM_DM_TU_DIEN.TEN_NGAN;
        m_cbo_truong.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
        m_cbo_truong.DataBind();
    }
    private void LoginSystem()
    {
        if (Page.IsValid)
        {
            string strUserName = this.txtUserName.Text.Trim();
            string strPassWord = this.txtPassWord.Text.Trim();
            string strMatruong = m_cbo_truong.SelectedValue;
            CheckAccount(strUserName, strPassWord, strMatruong);
        }
        
    }
    // Kiem tra cap ten/mat khau
    public void CheckAccount(string strUserName, string strPassWord, string strMaTruong)
    {
        //string v_str_string_call_ws_login = HelpUtils.gen_string_call_scm_login_ws(strUserName, strPassWord);
        SCMServices.SyncData v_ws_scm = new SCMServices.SyncData();
        DataSet v_ds = new DataSet();
        if (strMaTruong.ToUpper() != "TOPICA")
        {
            v_ds = v_ws_scm.TOS_check_login_scm_status(strUserName, strPassWord, strMaTruong);
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                decimal v_dc_id_qlht = 0;
                v_dc_id_qlht = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][NGUOI_DUNG_SCM.ID]);
                if (v_dc_id_qlht > 0 && CIPConvert.ToStr(v_ds.Tables[0].Rows[0][NGUOI_DUNG_SCM.TRANG_THAI_NGUOI_SU_DUNG]).Equals("NORMAL"))
                {
                    if (this.cbxRememberPassword.Checked)
                    {
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies["PassWord"].Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies["MaTruong"].Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies["UserName"].Value = strUserName;
                        Response.Cookies["PassWord"].Value = strPassWord;
                        Response.Cookies["MaTruong"].Value = strMaTruong;
                        Response.Cookies["UserId"].Value = v_dc_id_qlht.ToString();
                    }
                    Session["AccounLogin"] = "Y";
                    Session["Username"] = strUserName;
                    Session["MaTruong"] = strMaTruong;
                    Session["UserId"] = v_dc_id_qlht;

                    //if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][NGUOI_DUNG_SCM.ID_NHOM_NGUOI_SU_DUNG]) == C_TU_DIEN_NHOM_NGUOI_DUNG.NHAP_LIEU_CVHT_HN)
                        Response.Redirect("../Default.aspx", false);

                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    this.ctvLogin.IsValid = false;
                    ctvLogin.Text = "Tài khoản của bạn đã bị khóa!";
                }
            }
            else
            {
                this.ctvLogin.IsValid = false;
            }
        }
        
        else
        {
            m_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
            m_ds_ht_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
            US_HT_NGUOI_SU_DUNG.LogonResult v_log_on_result = US_HT_NGUOI_SU_DUNG.LogonResult.WrongPassword_OR_Name;
            //m_us_ht_nguoi_su_dung.FillDataset(m_ds_ht_nguoi_su_dung, "where TEN_TRUY_CAP = '" + strUserName + "' and MAT_KHAU = '" + CIPConvert.Encoding(strPassWord) + "'");
            strPassWord = CIPConvert.Encoding(strPassWord);
            m_us_ht_nguoi_su_dung.check_user_web(strUserName, strPassWord, ref v_log_on_result);
            if (v_log_on_result == US_HT_NGUOI_SU_DUNG.LogonResult.OK_Login_Succeeded)
            {
                decimal v_dc_id_qlht = 0;
                v_dc_id_qlht = m_us_ht_nguoi_su_dung.dcID;
                if (v_dc_id_qlht > 0 && m_us_ht_nguoi_su_dung.strTRANG_THAI.Equals("0"))
                {
                    if (this.cbxRememberPassword.Checked)
                    {
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies["PassWord"].Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies["MaTruong"].Expires = DateTime.Now.AddMonths(1);
                        Response.Cookies["UserName"].Value = strUserName;
                        Response.Cookies["PassWord"].Value = strPassWord;
                        Response.Cookies["MaTruong"].Value = strMaTruong;
                        Response.Cookies["UserId"].Value = v_dc_id_qlht.ToString();
                    }
                    Session["AccounLogin"] = "Y";
                    Session["Username"] = strUserName;
                    Session["MaTruong"] = strMaTruong;
                    Session["UserId"] = v_dc_id_qlht;

                    //if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][NGUOI_DUNG_SCM.ID_NHOM_NGUOI_SU_DUNG]) == C_TU_DIEN_NHOM_NGUOI_DUNG.NHAP_LIEU_CVHT_HN)
                        Response.Redirect("../Default2.aspx", false);

                    //if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][NGUOI_DUNG_SCM.ID_NHOM_NGUOI_SU_DUNG]) == C_TU_DIEN_NHOM_NGUOI_DUNG.NHAP_HO_SO_HN)
                    //    Response.Redirect("../Default2.aspx", false);

                    //if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][NGUOI_DUNG_SCM.ID_NHOM_NGUOI_SU_DUNG]) == C_TU_DIEN_NHOM_NGUOI_DUNG.NHAP_HO_SO_HN)
                    //    Response.Redirect("../UC/TongHopSoLuongCuocGoi.aspx", false);

                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    this.ctvLogin.IsValid = false;
                    ctvLogin.Text = "Tài khoản của bạn đã bị khóa!";
                }
            }
            else
            {
                this.ctvLogin.IsValid = false;
            }
        }
        
    }
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                load_data_2_cbo_truong();
                if (Request.Cookies["UserName"] != null && Request.Cookies["PassWord"] != null && Request.Cookies["MaTruong"] != null)
                {
                    Response.Cookies.Set(Request.Cookies["UserName"]);
                    Response.Cookies.Set(Request.Cookies["PassWord"]);
                    Response.Cookies.Set(Request.Cookies["MaTruong"]);
                    if (!Response.Cookies["UserName"].Value.Equals("") && !Response.Cookies["PassWord"].Value.Equals("") && !Response.Cookies["MaTruong"].Value.Equals(""))
                    {
                        this.txtUserName.Text = Response.Cookies["UserName"].Value.ToString().Trim();
                        this.txtPassWord.Text = Response.Cookies["PassWord"].Value.ToString().Trim();
                        this.m_cbo_truong.SelectedValue = Response.Cookies["MaTruong"].Value.ToString().Trim();
                        CheckAccount(Request.Cookies["UserName"].Value, Request.Cookies["PassWord"].Value, Request.Cookies["MaTruong"].Value);
                    }
                }
            }
        }
        catch (Exception)
        {
            
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try {
            this.ctvLogin.IsValid = true;
            LoginSystem();
        }
        catch (Exception) {
        }
    }
}
