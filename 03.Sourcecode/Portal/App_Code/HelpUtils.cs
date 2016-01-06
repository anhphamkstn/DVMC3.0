using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IPCOREUS;
using IP.Core.IPSystemAdmin;
using IP.Core.IPCommon;
using IPCOREDS.CDBNames;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;  
using System.Collections.Generic;
using System.Web.UI;

/// <summary>
/// Summary description for HelpUtils
/// </summary>
public class HelpUtils
{
	public HelpUtils()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /// <summary>
    /// Hàm này trả về link record dạng nghe lại được trên Browse or download về được
    /// </summary>
    /// <param name="ip_str_link_record_call_center">link record lấy từ call center</param>
    /// <returns>Link record dạng nghe lại or down về được</returns>
    public static string get_file_record(string ip_str_link_record_call_center)
    {
        string v_str_file = "";
        string v_str_server = System.Configuration.ConfigurationSettings.AppSettings["WEB_RECORDS"].ToString();
        v_str_file = ip_str_link_record_call_center.Replace("/var/spool/asterisk/monitor/", v_str_server);
        return v_str_file;
    }

    /// <summary>
    /// Hàm này trả về string input truyền vào ws đăng nhập của QLHT trên SCM
    /// </summary>
    /// <param name="ip_str_username">User đăng nhập</param>
    /// <param name="ip_str_password">Password</param>
    /// <returns>string</returns>
    public static string gen_string_call_scm_login_ws(string ip_str_username
                                            , string ip_str_password)
    {
        string v_str_search_input = "<USERNAME>" + ip_str_username + "</USERNAME>";
        v_str_search_input += "<PASSWORD>" + ip_str_password + "</PASSWORD>";
        return v_str_search_input;
    }

    /// <summary>
    /// Hàm này thực hiện việc ghi log hành động, thao tác của nươời dùng
    /// </summary>
    /// <param name="ip_loai_hanh_dong">enum: các kiểu hành động của người dùng</param>
    /// <param name="ip_obj_doi_tuong_thao_tac">Thao tác, tác động vào đối tượng nào</param>
    /// <param name="ip_str_mo_ta">Mô tả chi tiết hơn về hành động</param>
    public static void ghi_log_he_thong(decimal ip_dc_loai_hanh_dong
                                        , string ip_obj_doi_tuong_thao_tac
                                        , string ip_str_mo_ta
                                        , string ip_str_ghi_chu
                                        , decimal ip_dc_id_user)
    {
        /* Thông tin chung*/
       // US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();

        //m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = ip_dc_id_user;
        //m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
        //m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = ip_obj_doi_tuong_thao_tac;

        /* Thông tin riêng*/
        //m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = ip_dc_loai_hanh_dong;
        //m_us_v_ht_log_truy_cap.strMO_TA = ip_str_mo_ta;
        //m_us_v_ht_log_truy_cap.strGHI_CHU = ip_str_ghi_chu;

        // ghi log hệ thống
        try
        {
         //   m_us_v_ht_log_truy_cap.Insert();
        }
        catch
        {
            BaseMessages.MsgBox_Infor(THONG_BAO.ER_GHI_LOG_HE_THONG);
        }
    }
    /*
* Chú ý khi xuất excel:
* thêm EnableEventValidation ="false" vào <%@ Page ở trang .aspx
* Hàm load dữ liệu lên lưới để là: load_data_to_grid();
*/
    /// <summary>
    /// Hàm này dùng để xuất dữ liệu từ Gridview ra Excel
    /// </summary>
    /// <param name="ip_grv">Gridview muốn xuất dữ liệu ra</param>
    /// <param name="ip_str_filename">Tên file excel xuất ra</param>
    /// <param name="ip_b_export_all_yn">Xuất tất cả dữ liệu hay chỉ xuất ở trang hiện tại</param>
    /// <param name="ip_i_invisible_columns">Danh sách các cột muốn ẩn đi khi xuất (lấy theo số thứ tự, bắt đầu từ 0)</param>
    public static void export_gridview_2_excel(GridView ip_grv
                               , string ip_str_filename
                               , params int[] ip_i_invisible_columns
                                )
    {
        if (ip_grv.Rows.Count == 0) return;
        HttpContext.Current.Response.Clear();
        //Response.Buffer = true;
        HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + ip_str_filename);
        HttpContext.Current.Response.Charset = "UTF-8";
        HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
        HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
        HttpContext.Current.Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            // Ẩn các cột phân trang ở cả đầu và cuối
            if (ip_grv.TopPagerRow != null) ip_grv.TopPagerRow.Visible = false;
            if (ip_grv.BottomPagerRow != null) ip_grv.BottomPagerRow.Visible = false;

            ip_grv.HeaderRow.BackColor = Color.White;
            foreach (TableCell cell in ip_grv.HeaderRow.Cells)
            {
                cell.BackColor = ip_grv.HeaderStyle.BackColor;
            }
            // Chỗ này để ẩn đi cột trên header
            if (ip_i_invisible_columns.Length > 0)
            {
                for (int v_i = 0; v_i < ip_i_invisible_columns.Length; v_i++)
                {
                    ip_grv.HeaderRow.Cells[v_i].Visible = false;
                }
            }

            foreach (GridViewRow row in ip_grv.Rows)
            {
                // Chỗ này để ẩn đi cột trên các dòng dữ liệu
                if (ip_i_invisible_columns.Length > 0)
                {
                    for (int v_i = 0; v_i < ip_i_invisible_columns.Length; v_i++)
                    {
                        row.Cells[v_i].Visible = false;
                    }
                }

                row.BackColor = Color.White;
                foreach (TableCell cell in row.Cells)
                {
                    if (row.RowIndex % 2 == 0)
                    {
                        cell.BackColor = ip_grv.AlternatingRowStyle.BackColor;
                    }
                    else
                    {
                        cell.BackColor = ip_grv.RowStyle.BackColor;
                    }
                    cell.CssClass = "textmode";

                    List<Control> controls = new List<Control>();
                }
            }
            ip_grv.RenderControl(hw);

            //style to format numbers to string
            string style = @"<style> .textmode { mso-number-format:\@; } </style>";
            HttpContext.Current.Response.Write(style);
            HttpContext.Current.Response.Output.Write(sw.ToString());
            //Response.Write(sw.ToString());
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();
        }
    }
}



public class CSystemLog_100
{
    static string m_runmode = RUN_MODE.DEVELOP;

    private static void Initialize()
    {
        m_runmode = System.Configuration.ConfigurationSettings.AppSettings["RUN_MODE"];
    }
    public static void ExceptionHandle(System.Web.UI.Page i_page, Exception ip_e, decimal ip_dc_user)
    {
        string v_str_message_error = "";
        try
        {
            Initialize();
            switch (m_runmode)
            {
                case RUN_MODE.DEVELOP:
                    v_str_message_error = "Lỗi: " + ip_e.Message + "\n Trace: " + ip_e.StackTrace;
                    break;
                case RUN_MODE.RELEASE:
                    v_str_message_error = "Đã xảy ra lỗi trong quá trình xử lý hệ thống!";
                    break;
                default:
                    v_str_message_error = "Đã xảy ra lỗi trong quá trình xử lý hệ thống!";
                    break;
            }
            HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.LOI_HE_THONG, "Exception", v_str_message_error, "", ip_dc_user);
            i_page.Response.Redirect("MessageError.aspx?Message= Error:" + v_str_message_error);
        }
        catch (Exception)
        {
            HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.LOI_HE_THONG, "Exception", ip_e.Message, ip_e.StackTrace, ip_dc_user);
        }
    }
}