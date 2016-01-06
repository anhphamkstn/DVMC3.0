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
    public string m_str_table_cham_cong = "";
    US_GD_CUOC_GOI_YEU_CAU m_us = new US_GD_CUOC_GOI_YEU_CAU();
    DataSet m_ds_bc_cham_cong = new DataSet();
    #endregion

    #region Private Methods
    private void set_initial_page_load()
    {
        load_data_2_cbo_dien_thoai_vien();
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
    private void load_data_2_grid()
    {
        m_us = new US_GD_CUOC_GOI_YEU_CAU();
        
        decimal v_dc_id_nguoi_dung = CIPConvert.ToDecimal(m_ddl_dien_thoai_vien.SelectedValue);
        DateTime v_dat_tu_ngay, v_dat_den_ngay;
        
        if (m_dat_tu_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_tu_ngay = Convert.ToDateTime(m_dat_tu_ngay.SelectedDate);
        else v_dat_tu_ngay = Convert.ToDateTime("01/01/1900");
        
        if (m_dat_den_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_den_ngay = Convert.ToDateTime(m_dat_den_ngay.SelectedDate);
        else v_dat_den_ngay = Convert.ToDateTime("01/01/1900");


        m_ds_bc_cham_cong = m_us.load_bao_cao_cham_cong(v_dat_tu_ngay, v_dat_den_ngay, v_dc_id_nguoi_dung);

        // Load table header
        m_str_table_cham_cong = "<table cellspacing=\"0\" cellpadding=\"0\" width=\"100%\" border=\"1px\" border-style=\"solid\" border-collapse=\"collapse\">";
        m_str_table_cham_cong += "\n <thead style='background-color:#810C15; color:White; text-align:center; font-weight:bold;'>";
        m_str_table_cham_cong += "\n <tr style='height:28px;'>";
        for (int v_i = 0; v_i < m_ds_bc_cham_cong.Tables[0].Columns.Count; v_i++)
        {
            m_str_table_cham_cong += "\n <td>" + m_ds_bc_cham_cong.Tables[0].Rows[0][v_i].ToString() + "</td>";
        }
        m_str_table_cham_cong += "\n </tr>";
        m_str_table_cham_cong += "\n </thead>";

        // Load Table Body
        for (int v_i = 1; v_i < m_ds_bc_cham_cong.Tables[0].Rows.Count; v_i++)
        {
            m_str_table_cham_cong += "\n <tr style='height:28px;'>";
            
            load_cham_cong_by_ngay(v_i);

            m_str_table_cham_cong += "\n </tr>";
        }

        // Load footer của Table
        m_str_table_cham_cong += "\n </table>";

    }
    private void load_cham_cong_by_ngay(int ip_i_row_index)
    {
        for (int v_i = 0; v_i < m_ds_bc_cham_cong.Tables[0].Columns.Count; v_i++)
        {
            m_str_table_cham_cong += "\n <td style='text-align:center;'>";
            m_str_table_cham_cong += m_ds_bc_cham_cong.Tables[0].Rows[ip_i_row_index][v_i].ToString();
            m_str_table_cham_cong += "\n </td>";
        }
    }
    #endregion

    #region Export Excel
    private void export_2_excel()
    {
        string html = loadExport();
        string strNamFile = "BaoCaoChamCongTheoNgay" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xls";
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(1));
        Response.Clear();
        Response.AppendHeader("content-disposition", "attachment;filename=" + strNamFile);
        Response.Charset = "UTF-8";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = "text/csv";
        Response.ContentType = "application/vnd.ms-excel";
        this.EnableViewState = false;
        Response.Write("\r\n");
        Response.Write(html);
        HttpContext.Current.ApplicationInstance.CompleteRequest();
    }

    private void loadDSExprort(ref string strTable)
    {
        // Mỗi cột dữ liệu ứng với từng dòng là label
        for (int v_i = 1; v_i < m_ds_bc_cham_cong.Tables[0].Rows.Count; v_i++)
        {
            strTable += "\n<tr>";

            for (int v_j = 0; v_j < m_ds_bc_cham_cong.Tables[0].Columns.Count; v_j++)
            {
                strTable += "\n<td style='width:12%;' class='cssTitleReport' nowrap='nowrap'>" + "<span style='font-family:Tahoma; font-size:0.9em'>" + m_ds_bc_cham_cong.Tables[0].Rows[v_i][v_j].ToString() + "</span></td>";                
            }

            strTable += "\n</tr>";
        }
    }

    private void loadTieuDe(ref string strTable)
    {
        m_us = new US_GD_CUOC_GOI_YEU_CAU();

        decimal v_dc_id_nguoi_dung = CIPConvert.ToDecimal(m_ddl_dien_thoai_vien.SelectedValue);
        DateTime v_dat_tu_ngay, v_dat_den_ngay;

        if (m_dat_tu_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_tu_ngay = Convert.ToDateTime(m_dat_tu_ngay.SelectedDate);
        else v_dat_tu_ngay = Convert.ToDateTime("01/01/1900");

        if (m_dat_den_ngay.SelectedDate != CIPConvert.ToDatetime("01/01/0001"))
            v_dat_den_ngay = Convert.ToDateTime(m_dat_den_ngay.SelectedDate);
        else v_dat_den_ngay = Convert.ToDateTime("01/01/1900");


        m_ds_bc_cham_cong = m_us.load_bao_cao_cham_cong(v_dat_tu_ngay, v_dat_den_ngay, v_dc_id_nguoi_dung);

        strTable += "<table cellpadding='2' cellspacing='0' class='cssTableReport'>";

        strTable += "\n<tr>";
        strTable += "\n<td colspan='6'  align='center'><class='cssTableView' style='width: 100%;  height: 40px; font-size: large; color:White; background-color:#810C15;' nowrap='wrap'><span style='font-family:Times New Roman; font-weight:bold; font-size:1.3em;'>BÁO CÁO CHẤM CÔNG" + "</span></td>";
        strTable += "\n</tr>";
        //
        strTable += "\n<tr>";
        strTable += "\n<td colspan='3' align='center'><class='cssTableView' style='width:100%;' nowrap='nowrap'> <span style='font-family:Times New Roman; font-size:1.0em'>Từ ngày: " + v_dat_tu_ngay.ToShortDateString() + "</span></td>";
        strTable += "\n<td colspan='3' align='center'><class='cssTableView' style='width:100%;' nowrap='nowrap'> <span style='font-family:Times New Roman; font-size:1.0em'>đến ngày: " + v_dat_den_ngay.ToShortDateString() + "</span></td>";
        strTable += "\n</tr>";
        strTable += "\n</table>";
        //table noi dung
        strTable += "<table cellpadding='2' cellspacing='0' class='cssTableReport'>";
        strTable += "\n<tr>";
        for (int v_i = 0; v_i < m_ds_bc_cham_cong.Tables[0].Columns.Count; v_i++)
        {
            strTable += "\n<td style='width:12%;' class='cssTableView' nowrap='nowrap'>" + m_ds_bc_cham_cong.Tables[0].Rows[0][v_i].ToString() + "</td>";
        }
        strTable += "\n</tr>";
        loadDSExprort(ref strTable);
        strTable += "\n</table>";
    }
    private string loadExport()
    {
        try
        {
            string strHTML = "<html xmlns:o='urn:schemas-microsoft-com:office:office'"
            + "\n xmlns:x='urn:schemas-microsoft-com:office:excel'"
            + "\n xmlns='http://www.w3.org/TR/REC-html40'>"
            + "\n <head>"
            + "\n <meta http-equiv=Content-Type content='text/html; charset=utf-8'>"
            + "\n <meta name=ProgId content=Excel.Sheet>"
            + "\n <meta name=Generator content='Microsoft Excel 11'>"
            + "\n <link rel=File-List href='Book1_files/filelist.xml'>"
            + "\n <style id='Book1_28091_Styles'><!--table"
            + "\n 	{mso-displayed-decimal-separator:'\\.';"
            + "\n 	mso-displayed-thousand-separator:'\\,';}"
            + ".cssTitleReport"
            + "{font-family: tahoma; font-size: 11px;font-weight:normal;border: 1px #000000 solid;text-align:left;}"
            + ".cssTableView"
            + "{color:#FFFFFF;background-color:#800000;font-family: tahoma,Arial,Times New Roman; font-size: 12px;font-weight:bold;border: 1px #000000 solid;}"
            + "\n 	--></style>"
            + "\n 	</head>"
            + "\n 	<body><div id='Book1_28091' align=center x:publishsource='Excel'>";
            string strTable = "";
            loadTieuDe(ref strTable);
            strHTML += strTable;
            strHTML += "\n </div></body> ";
            strHTML += "\n </html> ";

            return strHTML;
        }
        catch
        {
            return "";
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
            export_2_excel();
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
            //m_grv_tong_hop_so_lieu.PageIndex = e.NewPageIndex;
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    //public override void VerifyRenderingInServerForm(Control control)
    //{
    //}  
    #endregion
}