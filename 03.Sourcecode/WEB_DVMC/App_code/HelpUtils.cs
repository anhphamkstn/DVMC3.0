using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using IP.Core.IPCommon;
using IPCOREUS;
using IP.Core.IPSystemAdmin;
using IP.Core.IPUserService;
using IPCOREDS.CDBNames;

using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;
using TOSApp.SCMServices;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;

namespace TOSApp.App_Code

{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    public class HelpUtils
    {
        public static string SERVER_URL = System.Configuration.ConfigurationSettings.AppSettings["WEB_CALL_URL"];

        /// <summary>
        /// Hàm này để ghi text lên ảnh
        /// </summary>
        /// <param name="ip_graphics"></param>
        /// <param name="ip_i_demo">0: hiển thị thông tin demo trên form; 1: hiển thị thông tin demo trong US</param>
        /// <param name="ip_us_tt_phoi"></param>
        public static void ghi_text_to_image(Graphics ip_graphics
                                    , string ip_str_du_lieu_dien
                                    , float ip_f_vi_tri_x1, float ip_f_vi_tri_y, float ip_f_vi_tri_x2
                                    , string ip_str_font, float ip_f_font_size
                                    , Brush ip_str_font_color, string ip_str_center_yn)
        {
            Font v_font = new Font(ip_str_font, ip_f_font_size);
            PointF v_pointf = new PointF(ip_f_vi_tri_x1, ip_f_vi_tri_y);

            // đoạn này ghi căn thông tin ra giữa
            if (CIPConvert.ToBoolean(ip_str_center_yn))
            {
                int v_i_real_width = (int)ip_graphics.MeasureString(ip_str_du_lieu_dien, v_font).Width + 5;

                int v_i_width = Convert.ToInt32(ip_f_vi_tri_x2 - ip_f_vi_tri_x1) * 3;
                int v_i_height = (int)ip_graphics.MeasureString(ip_str_du_lieu_dien, v_font).Height;

                if (v_i_real_width > v_i_width)
                    v_i_width = v_i_real_width;

                Rectangle rect1 = new Rectangle(Convert.ToInt32(ip_f_vi_tri_x1)
                                           , Convert.ToInt32(ip_f_vi_tri_y)
                                           , v_i_width
                                           , v_i_height);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                ip_graphics.DrawString(ip_str_du_lieu_dien, v_font, ip_str_font_color, rect1, stringFormat);
                ip_graphics.DrawRectangle(Pens.White, rect1);
            }
            else
            {
                ip_graphics.DrawString(ip_str_du_lieu_dien
                    , v_font, ip_str_font_color, v_pointf);
            }
        }
        /// <summary>
        /// Hàm này chuyển 1 chuỗi dạng: "20141015102312" về dạng datetime: 10/15/2014 10:23:12
        /// </summary>
        /// <param name="ip_str_datetime"></param>
        /// <returns></returns>
        public static DateTime string_2_datetime(string ip_str_datetime)
        {
            string v_str_year = ip_str_datetime.Substring(0, 4);
            string v_str_month = ip_str_datetime.Substring(4, 2);
            string v_str_day = ip_str_datetime.Substring(6, 2);
            string v_str_hour = ip_str_datetime.Substring(8, 2);
            string v_str_minute = ip_str_datetime.Substring(10, 2);
            string v_str_second = ip_str_datetime.Substring(12, 2);
            DateTime dat_out_datetime = new DateTime(Convert.ToInt32(v_str_year)
                                                , Convert.ToInt32(v_str_month)
                                                , Convert.ToInt32(v_str_day)
                                                , Convert.ToInt32(v_str_hour)
                                                , Convert.ToInt32(v_str_minute)
                                                , Convert.ToInt32(v_str_second));
            return dat_out_datetime;
        }
        
        /// <summary>
        /// Hàm này dùng để kiểm tra 1 string có phải là 1 số điện thoại ko?
        /// </summary>
        /// <param name="strphone"></param>
        /// <returns></returns>
        public static bool ValidatePhoneMask(string strphone)
        {
            System.Text.RegularExpressions.Regex regexObj =
                new System.Text.RegularExpressions.Regex(@"^([0-9]{3,5})?[ ]?([0-9]{3})[ ]?([0-9]{3})$");
            return regexObj.IsMatch(strphone);
        }
        
        /// <summary>
        /// Chuyển số điện thoại về dạng 985 030 376
        /// </summary>
        /// <param name="ip_str_sdt"></param>
        /// <returns></returns>
        public static string chuan_hoa_so_dien_thoai(string ip_str_sdt)
        {

            try
            {
                string[] v_array = { ".", ",", " ", "-" };
                // Nếu có các ký tự đặc biệt, loại bỏ
                for (int v_i = 0; v_i < v_array.Length; v_i++)
                {
                    while (ip_str_sdt.Contains(v_array[v_i]))
                    {
                        ip_str_sdt = ip_str_sdt.Replace(v_array[v_i], "");
                    }
                }
                if (ip_str_sdt.Substring(0, 1) == "0")
                {
                    ip_str_sdt = ip_str_sdt.Substring(1, ip_str_sdt.Length - 1);
                }
                return ip_str_sdt.Substring(0, ip_str_sdt.Length - 6) + " " + ip_str_sdt.Substring(ip_str_sdt.Length - 6, 3) + " " + ip_str_sdt.Substring(ip_str_sdt.Length - 3, 3);
            }
            catch (Exception)
            {
                return "";
            }

        }
        
        /// <summary>
        /// Hàm này thực hiện việc ghi log hành động, thao tác của nươời dùng
        /// </summary>
        /// <param name="ip_loai_hanh_dong">enum: các kiểu hành động của người dùng</param>
        /// <param name="ip_obj_doi_tuong_thao_tac">Thao tác, tác động vào đối tượng nào</param>
        /// <param name="ip_str_mo_ta">Mô tả chi tiết hơn về hành động</param>
        /// 
        public static void ghi_log_he_thong( string ip_str_mo_ta
                                            , string ip_str_ghi_chu)
        {
            /* Thông tin chung*/
          
             US_HT_LOG_API_CALL_CENTER m_us_v_ht_log_truy_cap = new US_HT_LOG_API_CALL_CENTER();

            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = us_user.dcID;
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;

            /* Thông tin riêng*/
            m_us_v_ht_log_truy_cap.strMO_TA = ip_str_mo_ta;
            m_us_v_ht_log_truy_cap.strGHI_CHU = ip_str_ghi_chu;

            // ghi log hệ thống
            try
            {
                  m_us_v_ht_log_truy_cap.Insert();
            }
            catch
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_GHI_LOG_HE_THONG);
            }
        }
        
        /// <summary>
        /// Hàm này thực hiện việc call contact; trả về thông tin cuộc gọi: call_id, error code
        /// </summary>
        /// <param name="ip_str_dien_thoai">Gọi đến số điện thoại nào</param>
        /// <param name="ip_str_stationId">Dùng mã máy nào để gọi</param>
        /// <param name="ip_str_agencode">Agencode gọi. Thường dùng là username của người gọi</param>
        /// <param name="ip_dat_datetime_request">Thời điểm gọi API (now)</param>
        /// <returns>Đối tượng lưu thông tin cuộc gọi vừa tạo. 
        /// Call_Id đc dùng để lấy lại thông tin sau khi gọi xong. 
        /// Kiểm tra error_code để biết cuộc gọi có lỗi hay ko?(=1 là lỗi)</returns>
        public static CallInfor call_2_contact(string ip_str_dien_thoai
                                            , string ip_str_stationId
                                            , string ip_str_agencode)
        {            
            string v_str_input_string = "";
            string v_str_message_code = "003";
            string v_dat_datetime_request = DateTime.Now.ToLongTimeString();
            
            v_str_input_string = "<agent_code>" + ip_str_agencode + "</agent_code>"
                                  + "<mobile_phone>" + ip_str_dien_thoai + "</mobile_phone>"
                                  + "<station_id>" + ip_str_stationId + "</station_id>"
                                  + "<datetime_request>" + v_dat_datetime_request + "</datetime_request>"
                                  + "<message_code>" + v_str_message_code + "</message_code>";

            WSCallCenter.CallCenterService m_ws_call = new WSCallCenter.CallCenterService();
            string v_str_result = "";
            v_str_result = m_ws_call.submit(v_str_input_string);
            CLichSuCuocGoi v_obj_infor = JsonConvert.DeserializeObject<CLichSuCuocGoi>(v_str_result);
            
            return v_obj_infor.data;
        }

        /// <summary>
        /// Hàm này dùng để get thông tin về cuộc gọi
        /// </summary>
        /// <param name="ip_call_id">Call id dùng để get thông tin cuộc gọi</param>
        /// <param name="ip_str_dien_thoai">Số điện thọai vừa gọi</param>
        /// <param name="ip_str_stationId">station id vừa call</param>
        /// <param name="ip_str_agencode">Agen code thường để là username</param>
        /// <returns>Đối tượng lưu toàn bộ thông tin cuộc gọi.
        /// Kiểm tra error_code để biết cuộc gọi có lỗi hay ko? (=1 là lỗi)</returns>
        public static CallInfor get_call_infor(string ip_call_id
                                         , string ip_str_dien_thoai
                                         , string ip_str_stationId
                                         , string ip_str_agencode)
        {            
            string v_str_input_string = "";
            string v_dat_datetime_request = DateTime.Now.ToLongTimeString();
            string v_str_message_code = "004";

            v_str_input_string = "<agent_code>" + ip_str_agencode + "</agent_code>"
                                     + "<mobile_phone>" + ip_str_dien_thoai + "</mobile_phone>"
                                     + "<station_id>" + ip_str_stationId + "</station_id>"
                                     + "<datetime_request>" + v_dat_datetime_request + "</datetime_request>"
                                     + "<message_code>" + v_str_message_code + "</message_code>"
                                     + "<call_id>" + ip_call_id + "</call_id>";
            
            WSCallCenter.CallCenterService m_ws_call = new WSCallCenter.CallCenterService();
            string v_str_result = "";
            
            v_str_result = m_ws_call.submit(v_str_input_string);
            CLichSuCuocGoi v_obj_infor = JsonConvert.DeserializeObject<CLichSuCuocGoi>(v_str_result);
            
            return v_obj_infor.data;
        }
        
        /// <summary>
        /// Hàm này dùng để get thông tin về cuộc gọi dựa vào callid (ws dạng web link)
        /// </summary>
        /// <param name="ip_call_id">Call id dùng để get thông tin cuộc gọi</param>
        /// <returns>Đối tượng lưu toàn bộ thông tin cuộc gọi</returns>
        public static CallInfor get_call_infor(string ip_call_id)
        {
            string v_str_result = "";
            v_str_result = get_content_from_weburl("http://203.162.121.70:8080/TPCServer/tpc/DoAction.jsp?event=" + WEB_URL_CALL_CENTER.GET_CALL_INFOR(ip_call_id));
            CLichSuCuocGoi v_obj_infor = JsonConvert.DeserializeObject<CLichSuCuocGoi>(v_str_result);

            return v_obj_infor.data;
        }
        public static CallInfor get_call_infor_overtime(string ip_call_id)
        {
            string v_str_result = "";
            v_str_result = get_content_from_weburl("http://203.162.121.70:8080/TPCServer/tpc/DoAction.jsp?event=" + WEB_URL_CALL_CENTER.GET_CALL_INFOR_OVERTIME(ip_call_id));
            CLichSuCuocGoi v_obj_infor = JsonConvert.DeserializeObject<CLichSuCuocGoi>(v_str_result);

            return v_obj_infor.data;
        }
        /// <summary>
        /// Hàm này dùng để kiểm tra xem dòng đang được select có thể edit được ko?
        /// </summary>
        /// <param name="i_grid_row">Dòng đang selected</param>
        /// <param name="m_fg">Lưới C1</param>
        /// <returns>True: có thể Edit; False: ko edit được</returns>
        public static bool is_validated_edit_grid_row(int i_grid_row, C1.Win.C1FlexGrid.C1FlexGrid m_fg)
        {
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, i_grid_row))
            {
                return false;
            }
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return false;

            if (m_fg.Rows[i_grid_row].IsNode)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Hàm này trả về string input truyền vào ws get thông tin sinh viên của SCM
        /// </summary>
        /// <param name="ip_str_dien_thoai"></param>
        /// <param name="ip_str_ho_ten"></param>
        /// <param name="ip_str_email"></param>
        /// <param name="ip_str_tu_khoa"></param>
        /// <param name="ip_str_code"></param>
        /// <returns></returns>
        public static string gen_string_call_scm_get_sinh_vien_ws(string ip_str_dien_thoai
                                                , string ip_str_ho_ten
                                                , string ip_str_email
                                                , string ip_str_tu_khoa
                                                , string ip_str_code
                                                , string ip_str_ma_truong)
        {
            string v_str_search_input = "<DIEN_THOAI>" + ip_str_dien_thoai + "</DIEN_THOAI>";
            if (ip_str_code == "10")
            {
                v_str_search_input += "<CODE>"+ip_str_code+"</CODE>";
                if (ip_str_ma_truong.Trim() != "")
                    v_str_search_input += "<MA_TRUONG>" + ip_str_ma_truong + "</MA_TRUONG>";
            }
            else if (ip_str_code == "20")
            {
                if(ip_str_ho_ten.Trim() != "")
                    v_str_search_input += "<HO_TEN>"+ip_str_ho_ten+"</HO_TEN>";
                if(ip_str_email.Trim() !="")
                    v_str_search_input +=  "<EMAIL>"+ip_str_email+"</EMAIL>";
                if(ip_str_tu_khoa.Trim() != "")
                    v_str_search_input += "<TU_KHOA>"+ip_str_tu_khoa+"</TU_KHOA>";
                if (ip_str_ma_truong.Trim() != "")
                    v_str_search_input += "<MA_TRUONG>" + ip_str_ma_truong + "</MA_TRUONG>";
                v_str_search_input += "<CODE>"+ip_str_code+"</CODE>";
            }
            
            return v_str_search_input;
        }
        /// <summary>
        /// Hàm này trả về string input truyền vào ws get QLHT của SCM
        /// </summary>
        /// <param name="ip_str_ma_sinh_vien">Mã sinh viên</param>
        /// <param name="ip_str_ho_ten">Họ tên QLHT</param>
        /// <param name="ip_str_truong">Trường QLHT làm việc</param>
        /// <param name="ip_str_ma_lop">Mã lớp QLHT làm chủ nhiệm</param>
        /// <param name="ip_str_code">10: search theo mã sinh viên; 20: search theo các thông tin còn lại</param>
        /// <returns></returns>
        public static string gen_string_call_scm_get_QLHT_ws(string ip_str_ma_sinh_vien
                                                , string ip_str_ho_ten
                                                , string ip_str_truong
                                                , string ip_str_ma_lop
                                                , string ip_str_code)
        {
            string v_str_search_input = "";
            if (ip_str_ma_sinh_vien.Trim() != "")
                v_str_search_input = "<MA_SINH_VIEN>" + ip_str_ma_sinh_vien + "</MA_SINH_VIEN>";
            if (ip_str_code == "10")
            {
                v_str_search_input += "<CODE>" + ip_str_code + "</CODE>";
            }
            else if (ip_str_code == "20")
            {
                if (ip_str_ho_ten.Trim() != "")
                    v_str_search_input += "<HO_TEN>" + ip_str_ho_ten + "</HO_TEN>";
                if (ip_str_truong.Trim() != "")
                    v_str_search_input += "<MA_TRUONG>" + ip_str_truong + "</MA_TRUONG>";
                if (ip_str_ma_lop.Trim() != "")
                    v_str_search_input += "<MA_LOP>" + ip_str_ma_lop + "</MA_LOP>";

                v_str_search_input += "<CODE>" + ip_str_code + "</CODE>";
            }

            return v_str_search_input;
        }
        
        /// <summary>
        /// Hàm này thực hiện chức năng trả về 1 Obj call infor, chứa các thông tin ban đầu của cuộc gọi
        /// </summary>
        /// <param name="ip_str_client_string_call">String call của client gửi về; dạng như: </param>
        /// <returns></returns>
        public static CallInfor get_start_callinfo_from_client_string_call(string ip_str_client_string_call)
        {
            // String client có dạng: <MSG><EVENT>INCOMINGCALL</EVENT><PHONENUMBER>01678334137</PHONENUMBER><CALLID>1242332</CALLID></MSG>
            CallInfor v_obj_start_call = new CallInfor();
            //string v_str_event = "";
            string v_str_callid = "";
            string v_str_phonecall = "";
            int v_index_start_phonecall = 0, v_index_end_phonecall = 0, v_index_start_callid = 0, v_index_end_callid = 0;

            v_index_start_phonecall = ip_str_client_string_call.IndexOf("<PHONENUMBER>");
            v_index_end_phonecall = ip_str_client_string_call.IndexOf("</PHONENUMBER>");
            v_index_start_callid = ip_str_client_string_call.IndexOf("<CALLID>");
            v_index_end_callid = ip_str_client_string_call.IndexOf("</CALLID>");

            if (v_index_start_phonecall > 0)
                v_str_phonecall = ip_str_client_string_call.Substring(v_index_start_phonecall + "<PHONENUMBER>".Length, v_index_end_phonecall - (v_index_start_phonecall + "<PHONENUMBER>".Length));
            if (v_index_start_callid > 0)
                v_str_callid = ip_str_client_string_call.Substring(v_index_start_callid + "<CALLID>".Length, v_index_end_callid - (v_index_start_callid + "<CALLID>".Length));

            v_obj_start_call.call_id = v_str_callid;
            v_obj_start_call.mobile_phone = v_str_phonecall;
            return v_obj_start_call;
        }

        /// <summary>
        /// Hàm này parse content from web url và trả về string content
        /// </summary>
        /// <param name="ip_str_weburl">web url</param>
        /// <returns></returns>
        public static string get_content_from_weburl(string ip_str_weburl)
        {
            WebClient v_webclient = new WebClient();
            string v_str_result = "";
            v_str_result = v_webclient.DownloadString(ip_str_weburl);
            v_str_result.Replace("<br>", "\r\n");
            v_str_result.Replace("\r", "");
            v_str_result.Replace("\n", "");
            v_str_result.Replace("\r\n", "");
            return v_str_result;
        }
        
        /// <summary>
        /// Hàm này trả về link record dạng nghe lại được trên Browse or download về được
        /// </summary>
        /// <param name="ip_str_link_record_call_center">link record lấy từ call center</param>
        /// <returns>Link record dạng nghe lại or down về được</returns>
        public static string get_file_record(string ip_str_link_record_call_center)
        {
            string v_str_file = "";
          //  string v_str_server = f002_main_form.m_str_web_record_url;
          //  v_str_file = ip_str_link_record_call_center.Replace("/var/spool/asterisk/monitor/", v_str_server);
            return v_str_file;
        }

        /// <summary>
        /// Hàm này open link ở default browser
        /// </summary>
        /// <param name="ip_str_link">Link cần mở</param>
        public static void open_link_in_default_browser(string ip_str_link)
        {
            Process.Start(ip_str_link);
        }
        
        /// <summary>
        /// Hàm này trả về địa chỉ IP của máy
        /// </summary>
        /// <returns>địa chỉ IP của máy</returns>
        public static IPAddress get_current_ipaddress()
        {
            IPHostEntry v_host_info = Dns.Resolve(Dns.GetHostName());
            return v_host_info.AddressList[0];
        }
        
        /// <summary>
        /// Hàm này trả về thời gian mình sẽ query để check incoming call
        /// </summary>
        /// <returns></returns>
        public static decimal get_time_interval_incoming_call()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.GET_INCOMING_CALL);
            return Convert.ToDecimal(v_us_tham_so_ht.strGIA_TRI);
        }
        /// <summary>
        /// Hàm này trả về Web services URL
        /// </summary>
        /// <returns></returns>
        public static string get_web_service_url()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.WEB_CALL_URL);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
       
        /// <summary>
        /// Hàm này trả về Web URL Record
        /// </summary>
        /// <returns></returns>
        public static string get_web_record_server()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.WEB_RECORDS);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
        public static string get_email_dvmc()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.EMAIL_DVMC);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
        public static string get_password_email_dvmc()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.PASSWORD_DVMC);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
        public static string get_chu_ky_dvmc()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.CHU_KY);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
        public static string get_url_xac_nhan_don_hang()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.URL_VIEW_YC);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
         public static string get_url_hoan_thah_don_hang()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.URL_HOAN_THANH);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
        /// <summary>
        /// Hàm này trả về Title version build cho main form
        /// </summary>
        /// <returns></returns>
        public static string get_version_build_title_mainform()
        {
            US_HT_THAM_SO_HE_THONG v_us_tham_so_ht = new US_HT_THAM_SO_HE_THONG(THAM_SO_HE_THONG_ID.VER_MAINFORM);
            return CIPConvert.ToStr(v_us_tham_so_ht.strGIA_TRI);
        }
        
        /// <summary>
        /// Hàm này thực hiện việc open form call sinh viên khi có 1 cuộc gọi mới vào
        /// </summary>
        /// <param name="ip_call_info"></param>
       
        public static Boolean messenger_xac_nhan(string messenger, string title)
        {
            DialogResult dialogResult = MessageBox.Show(messenger, title, MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
                   {
                       return true;        
                   }
             else if (dialogResult == DialogResult.No)
                   {
                      return false;
                   }
             return true;
        }
        public static void open_form_sinh_vien_call(CallInfor ip_call_info)
        {
            try
            {
                SinhVien v_obj_sinhvien = new SinhVien();
                SyncData v_ws_scm = new SyncData();
                string v_str_search = HelpUtils.gen_string_call_scm_get_sinh_vien_ws(ip_call_info.mobile_phone, "", "", "", "10", "TOPICA");
                DataSet v_ds = v_ws_scm.TOS_search_info_hoc_vien(v_str_search);
                v_obj_sinhvien.get_sinh_vien_by_ds(v_ds);
                //
                // Nếu ko tìm được học viên thì Số điện thoại sẽ được bảo toàn, tránh bị Null
                //
                if (v_obj_sinhvien.Dien_thoai == null) v_obj_sinhvien.Dien_thoai = ip_call_info.mobile_phone;

              //  f200_sinh_vien_goi_den v_f200 = new f200_sinh_vien_goi_den();
              //  v_f200.display(v_obj_sinhvien, ip_call_info.call_id);
                string v_str_thong_tin_goi_vao = "";
                if (v_obj_sinhvien.Ho_ten != "")
                    v_str_thong_tin_goi_vao += "Họ tên: " + v_obj_sinhvien.Ho_ten + "; ";
                if (v_obj_sinhvien.Dien_thoai != "")
                    v_str_thong_tin_goi_vao += "ĐT: " + v_obj_sinhvien.Dien_thoai;
               // HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.HOC_VIEN_GOI_DEN, v_str_thong_tin_goi_vao, "Gọi vào", f002_main_form.m_str_stationId);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }

        /// <summary>
        ///  This fun uses to send mail to, cc with subject and contetn below
        /// </summary>
        /// <param name="to">send to</param>
        /// <param name="toCC">and CC to</param>
        /// <param name="Subject">Subject of the mail</param>
        /// <param name="Content">Content of the mail</param>
        public static void send_mail(string to, string toCC, string Subject, string Content)
        {
          //  string v_str_send_mail = f002_main_form.m_str_email_dvmc;
          //  string v_str_password_send_mail = CEncryptKeyString.DecryptString(f002_main_form.m_str_password_dvmc);
           // string v_str_mail_from = f002_main_form.m_str_ho_ten_dtv + "<" + v_str_send_mail + ">";

           // using (MailMessage v_mail_send = new MailMessage(v_str_mail_from, to))
            //{
            //    v_mail_send.Subject = Subject;
            //    v_mail_send.Body = Content;
            //    v_mail_send.IsBodyHtml = true;
            //    v_mail_send.BodyEncoding = Encoding.UTF8;

            //    if (toCC != "")
            //    {
            //        string[] v_str_cc = toCC.Split(',');
            //        for (int v_i = 0; v_i < v_str_cc.Length; v_i++)
            //        {
            //            v_mail_send.CC.Add(v_str_cc[v_i]);
            //        }
            //    }

            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.EnableSsl = true;
            //    NetworkCredential NetworkCred = new NetworkCredential(v_str_send_mail, v_str_password_send_mail);
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Credentials = NetworkCred;
            //    smtp.Port = 587;
            //    smtp.Send(v_mail_send);
            //}
        }
       
        /// <summary>
        ///  This fun uses to send mail to, cc with subject and contetn below
        /// </summary>
        /// <param name="to">send to</param>
        /// <param name="toCC">and CC to</param>
        /// <param name="Subject">Subject of the mail</param>
        /// <param name="Content">Content of the mail</param>
        public static void send_mail(string Fullname, string from, string password, string to, string toCC, string Subject, string Content)
        {
            string v_str_mail_from = Fullname + "<" + from + ">";

            using (MailMessage v_mail_send = new MailMessage(v_str_mail_from, to))
            {
                v_mail_send.Subject = Subject;
                v_mail_send.Body = Content;
                v_mail_send.IsBodyHtml = true;
                v_mail_send.BodyEncoding = Encoding.UTF8;

                if (toCC != "")
                {
                    string[] v_str_cc = toCC.Split(',');
                    for (int v_i = 0; v_i < v_str_cc.Length; v_i++)
                    {
                        v_mail_send.Bcc.Add(v_str_cc[v_i]);
                    }
                }

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(from, password);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(v_mail_send);
            }
        }

        /// <summary>
        /// Hàm này dùng để gửi tin nhắn
        /// </summary>
        /// dien_thoai:0167834137-0987934822;noi_dung:Noi dung tin nhan;brand:TOPICA</param>
        /// <returns>Trả về 1: thành công; 0: lỗi</returns>
        public static string gui_tin_nhan(string ip_str_list_so_dien_thoai
                                        , string ip_str_noi_dung_gui
                                        , string ip_str_brand)
        {
            string v_str_output = "0";
            string v_str_post_data = "dien_thoai:" + ip_str_list_so_dien_thoai + ";";
            v_str_post_data += "noi_dung:" + ip_str_noi_dung_gui + ";";
            v_str_post_data += "brand:" + ip_str_brand;

            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("data", v_str_post_data);
                reqparm.Add("token", "ngfj3215256jhkj3242jh465j4g548724g234g");
                byte[] responsebytes = client.UploadValues("http://sms.topica.edu.vn/api/send_sms_dvmc", "POST", reqparm);
                v_str_output = Encoding.UTF8.GetString(responsebytes);
            }
            return v_str_output;
        }
    }

    public class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestClient()
        {
            EndPoint = "";
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint)
        {
            EndPoint = endpoint;
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint, HttpVerb method)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = "";
        }

        public RestClient(string endpoint, HttpVerb method, string postData)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = postData;
        }


        public string MakeRequest()
        {
            return MakeRequest("");
        }

        public string MakeRequest(string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);

            request.Method = Method.ToString();
            request.ContentLength = 0;
            request.ContentType = ContentType;

            if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
            {
                var encoding = new UTF8Encoding();
                var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                request.ContentLength = bytes.Length;

                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                return responseValue;
            }
        }

    } // class
}
