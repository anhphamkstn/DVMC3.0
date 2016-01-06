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
            this.Title = "Cổng tra cứu các vấn đề, câu hỏi của học viên cho QLHT";
            if (!IsPostBack) 
                set_initial_page_load();
            
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    #region Members
    US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien;
    DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien;


    DS_GD_CUOC_GOI_YEU_CAU m_ds = new DS_GD_CUOC_GOI_YEU_CAU();
    US_GD_CUOC_GOI_YEU_CAU m_us = new US_GD_CUOC_GOI_YEU_CAU();

    #endregion

    #region Private Methods
    private void set_initial_page_load()
    {
        load_data_2_cbo_dien_thoai_vien();
        load_data_2_cbo_thoi_diem_goi();
    }
    public string get_file_record(object ip_obj_id)
    {
        if (ip_obj_id == null || ip_obj_id == "") return "";
        string v_str_file ="";
        v_str_file = HelpUtils.get_file_record(ip_obj_id.ToString());
        return v_str_file;
    }
    private void load_data_2_cbo_dien_thoai_vien()
    {
        US_HT_NGUOI_SU_DUNG v_us_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
        DS_HT_NGUOI_SU_DUNG v_ds_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
        string v_str_nhom_nguoi_dung = "1,3";
        v_us_nguoi_su_dung.LoadNguoiDungByNhom(v_str_nhom_nguoi_dung, v_ds_nguoi_su_dung);

        m_ddl_dien_thoai_vien.Items.Add(new ListItem("-- Tất cả --", "0"));

        foreach (DataRow v_dr in v_ds_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows)
        {
            m_ddl_dien_thoai_vien.Items.Add(new ListItem(v_dr[HT_NGUOI_SU_DUNG.TEN_TRUY_CAP].ToString() + " - " + v_dr[HT_NGUOI_SU_DUNG.TEN].ToString(), v_dr[HT_NGUOI_SU_DUNG.ID].ToString()));
        }
    }
    private void load_data_2_cbo_thoi_diem_goi()
    {

        m_ddl_thoi_diem_goi.Items.Add(new ListItem("-- Tất cả --", "2"));
        m_ddl_thoi_diem_goi.Items.Add(new ListItem("Ban ngày", "0"));
        m_ddl_thoi_diem_goi.Items.Add(new ListItem("Buổi tối", "1"));

        //foreach (DataRow v_dr in v_ds_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows)
        //{
        //    m_ddl_dien_thoai_vien.Items.Add(new ListItem(v_dr[HT_NGUOI_SU_DUNG.TEN_TRUY_CAP].ToString() + " - " + v_dr[HT_NGUOI_SU_DUNG.TEN].ToString(), v_dr[HT_NGUOI_SU_DUNG.ID].ToString()));
        //}
    }
    private void load_data_2_grid()
    {
        m_ds = new DS_GD_CUOC_GOI_YEU_CAU();
        m_ds.EnforceConstraints = false;
        
        decimal v_dc_id_nguoi_dung = CIPConvert.ToDecimal(m_ddl_dien_thoai_vien.SelectedValue);
        DateTime v_dat_tu_ngay, v_dat_den_ngay;
        
        if (m_dat_tu_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_tu_ngay = Convert.ToDateTime(m_dat_tu_ngay.SelectedDate);
        else v_dat_tu_ngay = Convert.ToDateTime("01/01/1900");
        
        if (m_dat_den_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_den_ngay = Convert.ToDateTime(m_dat_den_ngay.SelectedDate);
        else v_dat_den_ngay = Convert.ToDateTime("01/01/1900");

        m_us.load_ds_yeu_cau_hoc_vien_portal(m_ds
                                     , m_txt_dien_thoai.Text.Trim()
                                     , m_txt_ho_ten.Text.Trim()
                                     , v_dat_tu_ngay
                                     , v_dat_den_ngay
                                     ,CIPConvert.ToDecimal(m_ddl_thoi_diem_goi.SelectedValue)
                                     , v_dc_id_nguoi_dung);
        m_grv_tong_hop_so_lieu.DataSource = m_ds;
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
    protected void m_ddl_dien_thoai_vien_SelectedIndexChanged(object sender, EventArgs e)
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
            //export_2_excel();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_tong_hop_so_lieu_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_tong_hop_so_lieu.PageIndex = e.NewPageIndex;
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
    protected void  m_ddl_thoi_diem_goi_SelectedIndexChanged(object sender, EventArgs e)
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
}