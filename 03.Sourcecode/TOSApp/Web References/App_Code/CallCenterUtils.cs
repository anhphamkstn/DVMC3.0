using System;
using System.Collections.Generic;
using System.Text;
using IPCOREDS.CDBNames;
using Newtonsoft.Json;

namespace TOSApp.App_Code
{
    class CallCenterUtils
    {
        /// <summary>
        /// Hàm này thực hiện việc add or remove agent, ipphone khỏi queue
        /// </summary>
        /// <param name="ip_extension">Mã của IPPhone</param>
        /// <param name="ip_agent">Agencode; thường để là username</param>
        /// <param name="ip_kho_queue">Tên của Kho queue (tos_mb, tos_mn)</param>
        /// <param name="ip_code_add_or_remove">10: add; 20: remove</param>
        /// <returns></returns>
        public static CJoinRemoveQueueData add_or_remove_agent_ipphone_2_queue(string ip_extension
                                                                            , string ip_agent
                                                                            , string ip_kho_queue
                                                                            , int ip_code_add_or_remove)
        {
            string v_str_result = "";
            string v_str_link_services = "";

            if (ip_code_add_or_remove == 10)
                v_str_link_services =  "http://203.162.121.70:8080/TPCServer/tpc/DoAction.jsp?event=" + WEB_URL_CALL_CENTER.ADD_VAO_QUEUE_GOI(ip_extension, ip_agent, ip_kho_queue);
            else if (ip_code_add_or_remove == 20)
                v_str_link_services = "http://203.162.121.70:8080/TPCServer/tpc/DoAction.jsp?event=" + WEB_URL_CALL_CENTER.REMOVE_KHOI_QUEUE_GOI(ip_extension, ip_agent, ip_kho_queue);

            v_str_result = HelpUtils.get_content_from_weburl(v_str_link_services);

            CJoinRemoveQueue v_obj_infor = JsonConvert.DeserializeObject<CJoinRemoveQueue>(v_str_result);
            return v_obj_infor.Action;
        }
        /// <summary>
        /// Hàm này thực hiện việc Pause agent, ipphone; ko tiếp nhận cuộc gọi nữa, giữ phiên đăng nhập
        /// </summary>
        /// <param name="ip_extension">ipphone</param>
        /// <param name="ip_agent">Agentcode =username</param>
        /// <returns></returns>
        public static CPauseQueueData pause_agent_ipphone_2_queue(string ip_extension
                                                                , string ip_agent)
        {
            string v_str_result = "";
            string v_str_link_services = "";
           // v_str_link_services = f002_main_form.m_str_web_service_url + WEB_URL_CALL_CENTER.PAUSE_AGENT(ip_extension, ip_agent);

            v_str_result = HelpUtils.get_content_from_weburl(v_str_link_services);

            CPauseQueue v_obj_infor = JsonConvert.DeserializeObject<CPauseQueue>(v_str_result);
            return v_obj_infor.Action;
        }

        /// <summary>
        /// Hàm này thực hiện việc UnPause agent, ipphone; tiếp tục nhận cuộc gọi
        /// </summary>
        /// <param name="ip_extension">ipphone</param>
        /// <param name="ip_agent">Agentcode =username</param>
        /// <returns></returns>
        public static CUnPauseQueueData unpause_agent_ipphone_2_queue(string ip_extension
                                                                , string ip_agent)
        {
            string v_str_result = "";
            string v_str_link_services = "";
          //  v_str_link_services = f002_main_form.m_str_web_service_url + WEB_URL_CALL_CENTER.UNPAUSE_AGENT(ip_extension, ip_agent);

            v_str_result = HelpUtils.get_content_from_weburl(v_str_link_services);

            CUnPauseQueue v_obj_infor = JsonConvert.DeserializeObject<CUnPauseQueue>(v_str_result);
            return v_obj_infor.Action;
        }
        /// <summary>
        /// Hàm này thực hiện register ipphone và ip address vào queue
        /// </summary>
        /// <param name="ip_extension">Mã ipphone</param>
        /// <param name="ip_ipaddress">IP address</param>
        /// <returns></returns>
        public static CRegisterQueueData register_ipaddress_ipphone_2_queue(string ip_extension
                                                                , string ip_ipaddress)
        {
            string v_str_result = "";
            string v_str_link_services = "";
           // v_str_link_services = f002_main_form.m_str_web_service_url + WEB_URL_CALL_CENTER.REGISTER_IP(ip_extension, ip_ipaddress);

            v_str_result = HelpUtils.get_content_from_weburl(v_str_link_services);

            CRegisterQueue v_obj_infor = JsonConvert.DeserializeObject<CRegisterQueue>(v_str_result);
            return v_obj_infor.Action;
        }
        /// <summary>
        /// Hàm này thực hiện unregister ipphone khỏi queue
        /// </summary>
        /// <param name="ip_extension">Mã ipphone</param>
        /// <returns></returns>
        public static CUnRegisterQueueData register_ipaddress_ipphone_2_queue(string ip_extension)
        {
            string v_str_result = "";
            string v_str_link_services = "";
           // v_str_link_services = f002_main_form.m_str_web_service_url + WEB_URL_CALL_CENTER.UNREGISTER_IP(ip_extension);

            v_str_result = HelpUtils.get_content_from_weburl(v_str_link_services);

            CUnRegisterQueue v_obj_infor = JsonConvert.DeserializeObject<CUnRegisterQueue>(v_str_result);
            return v_obj_infor.Action;
        }
        
        /// <summary>
        /// Hàm này thực hiện việc add or remove 1 SĐT vào / ra khỏi blacklist
        /// </summary>
        /// <param name="ip_dien_thoai">SĐT cần add / remove</param>
        /// <param name="ip_code">10: add; 20: remove</param>
        /// <returns></returns>
        public static CAddRemoveBlackListData add_remove_blacklist(string ip_dien_thoai, int ip_code)
        {
            string v_str_result = "";
            string v_str_link_services = "";
           // v_str_link_services = f002_main_form.m_str_web_service_url + WEB_URL_CALL_CENTER.ADD_REMOVE_BLACKLIST(ip_dien_thoai, ip_code);

            v_str_result = HelpUtils.get_content_from_weburl(v_str_link_services);

            CAddRemoveBlackList v_obj_infor = JsonConvert.DeserializeObject<CAddRemoveBlackList>(v_str_result);
            return v_obj_infor.Action;
        }

        /// <summary>
        /// Hàm này thực hiện việc get incoming call
        /// </summary>
        /// <param name="ip_extension">Mã máy điện thoại</param>
        /// <returns></returns>
        public static CGetIncomingCallData get_incoming_call(string ip_str_link_services)
        {
            string v_str_result = "";
            //string v_str_link_services = "";
           // v_str_link_services = "http://203.162.121.70:8080/TPCServer/tpc/DoAction.jsp?event=" + WEB_URL_CALL_CENTER.GET_INCOMING_CALL(ip_extension);

            v_str_result = HelpUtils.get_content_from_weburl(ip_str_link_services);

            CGetIncomingCall v_obj_infor = JsonConvert.DeserializeObject<CGetIncomingCall>(v_str_result);
            return v_obj_infor.Action;
        }
        
    }
}
