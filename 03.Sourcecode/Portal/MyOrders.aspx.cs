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
            this.Title = "Các đặt hàng của tôi!";
            if (!IsPostBack)
            {
               set_initial_page_load();  
            }
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
        load_data_2_grid();
    }
    private void load_data_2_grid()
    {
        US_V_GD_DAT_HANG v_us_gd_dat_hang = new US_V_GD_DAT_HANG();
        DS_V_GD_DAT_HANG v_ds_gd_dat_hang = new DS_V_GD_DAT_HANG();
        string v_str_ma_don_hang = "";
        if (Request.QueryString["ma"] != null)
        {
            v_str_ma_don_hang = CIPConvert.ToStr(Request.QueryString["ma"]);
        }

        string v_str_username = "";        
        /*if (Session["USERNAME"] != null)
            v_str_username = CIPConvert.ToStr(Session["USERNAME"]);
        */
        v_ds_gd_dat_hang.EnforceConstraints = false;
        v_us_gd_dat_hang.load_dat_hang_by_ma(v_str_ma_don_hang, v_str_username, v_ds_gd_dat_hang);
        /*if (Session["USERNAME"] == null
            && v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows.Count>0 )
            Session["USERNAME"] = v_ds_gd_dat_hang.V_GD_DAT_HANG.Rows[0][V_GD_DAT_HANG.USER_NV_DAT_HANG];
        */
        m_grv_cau_hoi_hoc_vien.DataSource = v_ds_gd_dat_hang.V_GD_DAT_HANG;
        m_grv_cau_hoi_hoc_vien.DataBind();
    }
    private void update_trang_thai(int ip_i_row_index)
    {
        decimal v_dc_id = CIPConvert.ToDecimal(m_grv_cau_hoi_hoc_vien.DataKeys[ip_i_row_index].Value);
        US_V_GD_XU_LY_NOI_BO v_us_gd_xu_ly_noi_bo = new US_V_GD_XU_LY_NOI_BO(v_dc_id);
        
    }
    #endregion

    #region Events
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
    #endregion
}