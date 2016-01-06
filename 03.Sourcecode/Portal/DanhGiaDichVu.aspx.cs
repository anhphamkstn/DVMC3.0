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


using IP.Core.IPExcelReport;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack) 
                set_initial_page_load();
            
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    #region Members
   
    #endregion

    #region Private Methods
    private void set_initial_page_load()
    {
        load_thong_tin_don_hang();
    }
    private void load_thong_tin_don_hang()
    {
        US_V_GD_DAT_HANG v_us_gd_dat_hang = new US_V_GD_DAT_HANG();
        DS_V_GD_DAT_HANG v_ds_gd_dat_hang = new DS_V_GD_DAT_HANG();
        string v_str_ma_don_hang = "";
        if (Request.QueryString["ma"] != null)
        {
            v_str_ma_don_hang = CIPConvert.ToStr(Request.QueryString["ma"]);
            Session["DON_HANG"] = v_str_ma_don_hang;
        }
        else if(Session["DON_HANG"] != null)
            v_str_ma_don_hang = CIPConvert.ToStr(Session["DON_HANG"]);
        v_ds_gd_dat_hang.EnforceConstraints = false;
        v_us_gd_dat_hang.load_dat_hang_by_ma(v_str_ma_don_hang,"", v_ds_gd_dat_hang);
        /*if (Session["USERNAME"] == null)
            Session["USERNAME"] = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.USER_NV_DAT_HANG];
        */
        if (v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows.Count > 0
            && v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.ID_DANH_GIA_TU_USER_DAT_HANG].ToString()!= "")
        {
            m_lbl_message.Text = "Đơn hàng này đã được đánh giá.Xin cảm ơn!";
            decimal v_dc_id_hang_danh_gia = CIPConvert.ToDecimal(v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.ID_DANH_GIA_TU_USER_DAT_HANG]);
            if (v_dc_id_hang_danh_gia == ID_HANG_DANH_GIA.RAT_HAI_LONG)
                m_rdb_rat_hai_long.Checked = true;
            else if (v_dc_id_hang_danh_gia == ID_HANG_DANH_GIA.HAI_LONG)
                m_rdb_hai_long.Checked = true;
            else if (v_dc_id_hang_danh_gia == ID_HANG_DANH_GIA.XONG_VIEC)
                m_rdb_xong_viec.Checked = true;
            else if (v_dc_id_hang_danh_gia == ID_HANG_DANH_GIA.KHONG_DAT)
                m_rdb_khong_dat.Checked = true;
            else if (v_dc_id_hang_danh_gia == ID_HANG_DANH_GIA.HOI_DUOI)
                m_rdb_hoi_duoi.Checked = true;
            m_txt_y_kien_khac.Text = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.Y_KIEN_KHAC_TU_USER_DAT_HANG].ToString();
            m_cmd_gui_danh_gia.Visible = false;
        }
        if (v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows.Count > 0)
        {
            m_lbl_ma_don_hang.Text = v_str_ma_don_hang;
            m_lbl_loai_dat_hang.Text = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.TEN_LOAI_DICH_VU].ToString();
            m_dat_ngay_dat_hang.SelectedDate = Convert.ToDateTime(v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.THOI_GIAN_DAT_HANG]);
            m_lbl_loai_thoi_han.Text = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.LOAI_THOI_GIAN_CAN_HOAN_THANH].ToString();
            m_txt_noi_dung_dat_hang.Text = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.NOI_DUNG_DAT_HANG].ToString();
            hdf_id_don_hang.Value = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.ID].ToString();
        }
    }
    private void luu_danh_gia_don_hang()
    {
        US_V_GD_DAT_HANG v_us_dm_dat_hang = new US_V_GD_DAT_HANG();
        decimal v_dc_id_don_hang = 0;
        v_dc_id_don_hang = CIPConvert.ToDecimal(hdf_id_don_hang.Value);
        decimal v_dc_id_danh_gia = 0;
        if (m_rdb_rat_hai_long.Checked) v_dc_id_danh_gia = ID_HANG_DANH_GIA.RAT_HAI_LONG;
        else if (m_rdb_hai_long.Checked) v_dc_id_danh_gia = ID_HANG_DANH_GIA.HAI_LONG;
        else if (m_rdb_xong_viec.Checked) v_dc_id_danh_gia = ID_HANG_DANH_GIA.XONG_VIEC;
        else if (m_rdb_hoi_duoi.Checked) v_dc_id_danh_gia = ID_HANG_DANH_GIA.HOI_DUOI;
        else if (m_rdb_khong_dat.Checked) v_dc_id_danh_gia = ID_HANG_DANH_GIA.KHONG_DAT;
        string v_str_y_kien_khac = m_txt_y_kien_khac.Text.Trim();
        v_us_dm_dat_hang.danh_gia_don_hang(v_dc_id_don_hang, v_dc_id_danh_gia, v_str_y_kien_khac);
        Response.Redirect("Thanks.aspx", false);
        HttpContext.Current.ApplicationInstance.CompleteRequest(); 
    }
    #endregion

    #region Events
    protected void m_cmd_gui_danh_gia_Click(object sender, EventArgs e)
    {
        try
        {
            luu_danh_gia_don_hang();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    } 
    #endregion
}