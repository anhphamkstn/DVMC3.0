using System;
using System.Collections.Generic;
using System.Text;

using IPCOREDS.CDBNames;
using TOSApp.App_Code;

namespace TOSApp
{
    class CSystemLog_100
    {
        static string m_runmode = RUN_MODE.DEVELOP;

        private static void Initialize()
        {
            m_runmode = System.Configuration.ConfigurationSettings.AppSettings["RUN_MODE"];
        }
        public static void ExceptionHandle(Exception ip_e)
        {
            string v_str_message_error = "";
            string v_str_message_error_save = "";
            v_str_message_error_save = "Lỗi: " + ip_e.Message + "\n Trace: " + ip_e.StackTrace;
            try
            {
                Initialize();
                switch (m_runmode)
                {
                    case RUN_MODE.DEVELOP:
                        v_str_message_error = v_str_message_error_save;
                        break;
                    case RUN_MODE.RELEASE:
                        v_str_message_error = "Đã xảy ra lỗi trong quá trình xử lý hệ thống!";
                        break;
                    default:
                        v_str_message_error = "Đã xảy ra lỗi trong quá trình xử lý hệ thống!";
                        break;
                }
                System.Windows.Forms.MessageBox.Show(v_str_message_error);
                HelpUtils.ghi_log_he_thong( "Exception", v_str_message_error_save);
            }
            catch (Exception)
            {
                HelpUtils.ghi_log_he_thong("Exception" + ip_e.Message, ip_e.StackTrace);
                System.Windows.Forms.MessageBox.Show("Environment- Không có file Ini");
            }
        }
        public static void ExceptionHandle(Exception ip_e, string ip_thong_bao)
        {
            string v_str_message_error = "";
            string v_str_message_error_save = "";
            v_str_message_error_save = "Lỗi: " + ip_e.Message + "\n Trace: " + ip_e.StackTrace;
            try
            {
                Initialize();
                switch (m_runmode)
                {
                    case RUN_MODE.DEVELOP:
                        v_str_message_error = v_str_message_error_save;
                        break;
                    case RUN_MODE.RELEASE:
                        v_str_message_error = ip_thong_bao;
                        break;
                    default:
                        v_str_message_error = ip_thong_bao;
                        break;
                }
                System.Windows.Forms.MessageBox.Show(v_str_message_error);
                HelpUtils.ghi_log_he_thong( "Exception", v_str_message_error_save);
            }
            catch (Exception)
            {
                HelpUtils.ghi_log_he_thong( "Exception"+ ip_e.Message, ip_e.StackTrace);
                System.Windows.Forms.MessageBox.Show("Environment- Không có file Ini");
            }
        }
    }
}
