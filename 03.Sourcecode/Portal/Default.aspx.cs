using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;

using System.Data;
using IPCOREDS.CDBNames;
using IPCOREDS;
using IPCOREUS;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            m_lbl_error.Text = "";
            this.Title = "Cổng tra cứu các vấn đề, câu hỏi của học viên cho QLHT";
            if (!IsPostBack)
            {
                if (Session["AccounLogin"] == null || Session["AccounLogin"].ToString().Equals("N"))
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
                else set_initial_page_load();  
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    #region Members
    US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien;
    DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien;

    US_V_GD_XU_LY_NOI_BO m_us_v_gd_noi_bo;
    DS_V_GD_XU_LY_NOI_BO m_ds_v_gd_noi_bo;

    #endregion

    #region Private Methods
    private void load_data_2_cbo_trang_thai_cau_hoi()
    {
        US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
        
        v_us_tu_dien.fill_tu_dien_cung_loai_ds(LOAI_TU_DIEN_TEXT.TRANG_THAI_GD_CAU_HOI_SV, CM_DM_TU_DIEN.ID, v_ds_tu_dien);

        DataRow v_dr = v_ds_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
        v_dr[CM_DM_TU_DIEN.ID] = "0";
        v_dr[CM_DM_TU_DIEN.TEN] = "-- Tất cả trạng thái --";
        v_ds_tu_dien.EnforceConstraints = false;
        v_ds_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

        m_cbo_trang_thai.DataValueField = CM_DM_TU_DIEN.ID;
        m_cbo_trang_thai.DataTextField = CM_DM_TU_DIEN.TEN;

        m_cbo_trang_thai.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
        m_cbo_trang_thai.DataBind();
    }
    private void set_initial_page_load()
    {
        load_data_2_cbo_trang_thai_cau_hoi();
        
        load_data_2_grid();
    }
    private void load_data_2_grid()
    {
        string v_str_hoten_hoc_vien = m_txt_ho_ten_hoc_vien.Text.Trim();
        string v_str_lop_hoc_vien = m_txt_lop_hoc_vien.Text.Trim();
        string v_str_so_dien_thoai = m_txt_dien_thoai_hoc_vien.Text.Trim();
        decimal v_dc_id_trang_thai_cau_hoi = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);

        m_us_v_gd_noi_bo = new US_V_GD_XU_LY_NOI_BO();
        m_ds_v_gd_noi_bo = new DS_V_GD_XU_LY_NOI_BO();
        m_ds_v_gd_noi_bo.EnforceConstraints = false;
        m_us_v_gd_noi_bo.load_ds_cau_hoi_cho_qlht(m_ds_v_gd_noi_bo
                                                 , v_str_hoten_hoc_vien
                                                 , v_str_lop_hoc_vien
                                                 , v_str_so_dien_thoai
                                                 , v_dc_id_trang_thai_cau_hoi
                                                 , CIPConvert.ToDecimal(Session["UserId"]));

        m_lbl_result_message.Text = CIPConvert.ToStr(m_ds_v_gd_noi_bo.V_GD_XU_LY_NOI_BO.Rows.Count);

        m_grv_cau_hoi_hoc_vien.DataSource = m_ds_v_gd_noi_bo.V_GD_XU_LY_NOI_BO;
        m_grv_cau_hoi_hoc_vien.DataBind();
    }
    private void update_trang_thai(int ip_i_row_index)
    {
        decimal v_dc_id = CIPConvert.ToDecimal(m_grv_cau_hoi_hoc_vien.DataKeys[ip_i_row_index].Value);
        US_V_GD_XU_LY_NOI_BO v_us_gd_xu_ly_noi_bo = new US_V_GD_XU_LY_NOI_BO(v_dc_id);
        if (v_us_gd_xu_ly_noi_bo.dcID_TRANG_THAI_CAU_HOI == TU_DIEN_TRANG_THAI_GD_CAU_HOI_SV.DA_TRA_LOI)
        {
            m_lbl_error.Text = "Câu hỏi này đã được trả lời rồi!";
        }
        else
        {
            v_us_gd_xu_ly_noi_bo.dcID_TRANG_THAI_CAU_HOI = TU_DIEN_TRANG_THAI_GD_CAU_HOI_SV.DA_TRA_LOI;
            v_us_gd_xu_ly_noi_bo.cap_nhat_trang_thai_cau_hoi();
            load_data_2_grid();
            m_lbl_error.Text = "Đã cập nhật trạng thái câu hỏi thành Đã trả lời!";
        }
    }
    #endregion

    #region Events
    protected void m_cmd_tim_kiem_Click(object sender, EventArgs e)
    {
        try
        {
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_bang_tot_nghiep_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_cau_hoi_hoc_vien.PageIndex = e.NewPageIndex;
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_export_excel_Click(object sender, EventArgs e)
    {
        try
        {
            //export_2_excel();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_cau_hoi_hoc_vien_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            update_trang_thai(e.RowIndex);   
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
}