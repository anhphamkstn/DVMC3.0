using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;


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
            this.Title = "Cổng tra cứu các vấn đề, câu hỏi của học viên cho QLHT";
            
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

    private void set_initial_page_load()
    {

    }
    private void load_data_2_grid()
    {
        DateTime v_dat_tu_ngay, v_dat_den_ngay;

        if (m_dat_tu_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_tu_ngay = Convert.ToDateTime(m_dat_tu_ngay.SelectedDate);
        else v_dat_tu_ngay = Convert.ToDateTime("01/01/1900");

        if (m_dat_den_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_den_ngay = Convert.ToDateTime(m_dat_den_ngay.SelectedDate);
        else v_dat_den_ngay = Convert.ToDateTime("01/01/1900");

        US_V_GD_CAU_HOI_YEU_CAU v_us = new US_V_GD_CAU_HOI_YEU_CAU();
        DataSet v_ds = new DataSet();
        v_ds = v_us.tong_hop_so_luong_cau_hoi_theo_ngay(v_dat_tu_ngay, v_dat_den_ngay);
        m_grv_tong_hop_so_lieu.DataSource = v_ds.Tables[0];
        m_grv_tong_hop_so_lieu.DataBind();
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

    protected void m_cmd_export_excel_Click(object sender, EventArgs e)
    {
        try
        {

            HelpUtils.export_gridview_2_excel(m_grv_tong_hop_so_lieu
                        , "BC_SoLuongCuocGoiTheoThoiGian.xls"); // 0 và 1 là số thứ tự 2 cột: Sửa, Xóa
        }
        catch (Exception v_e)
        {
            //CSystemLog_100.ExceptionHandle(this, v_e);
        }
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
    }  
    #endregion
}