using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using IPCOREDS.CDBNames;

using System.Data;

using TOSApp.SCMServices;
using IP.Core.IPCommon;

namespace TOSApp.App_Code
{
    public class AsynchronousSocketListener
    {
        private static TcpListener tcpListener;
        public static Thread listenThread;

        public AsynchronousSocketListener()
        {
        }

        public static void StartListening()
        {
            IPAddress ipAddress = HelpUtils.get_current_ipaddress();
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                tcpListener = new TcpListener(localEndPoint);
                listenThread = new Thread(new ThreadStart(ListenForClients));
                listenThread.Start();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        public static void StopListening()
        {
            listenThread.Abort();
            tcpListener.Stop();
        }

        private static void ListenForClients()
        {
            tcpListener.Start();

            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = tcpListener.AcceptTcpClient();

                //create a thread to handle communication 
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private static void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                string v_str_output = encoder.GetString(message, 0, bytesRead);
                CallInfor v_obj_callinfo = HelpUtils.get_start_callinfo_from_client_string_call(v_str_output);
                if (v_obj_callinfo.mobile_phone == "Anonymous") return;
                open_form_sinh_vien_call(v_obj_callinfo);
                tcpClient.Close();
            }
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

                //f200_sinh_vien_goi_den v_f200 = new f200_sinh_vien_goi_den();
               // v_f200.display(v_obj_sinhvien, ip_call_info.call_id);
                string v_str_thong_tin_goi_vao = "";
                if (v_obj_sinhvien.Ho_ten != "")
                    v_str_thong_tin_goi_vao += "Họ tên: " + v_obj_sinhvien.Ho_ten + "; ";
                if (v_obj_sinhvien.Dien_thoai != "")
                    v_str_thong_tin_goi_vao += "ĐT: " + v_obj_sinhvien.Dien_thoai;
              //  HelpUtils.ghi_log_he_thong(LOG_TRUY_CAP.HOC_VIEN_GOI_DEN, v_str_thong_tin_goi_vao, "Gọi vào", f002_main_form.m_str_stationId);
            }
            catch (Exception v_e)
            {
                CSystemLog_100.ExceptionHandle(v_e);
            }
        }
    }

}
