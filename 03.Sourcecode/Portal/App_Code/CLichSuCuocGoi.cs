using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using IP.Core.IPCommon;
using IPCOREDS.CDBNames;

    /// <summary>
    /// Summary description for DALichSuCuocGoi
    /// </summary>
    public class CLichSuCuocGoi
    {
        public CallInfor data { get; set; }
    }

    public class CallInfor
    {
        public string message_code { get; set; }
        public string agent_code { get; set; }
        public string station_id { get; set; }
        public string mobile_phone { get; set; }
        public string datetime_response { get; set; }
        public string call_id { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string duration { get; set; }
        public string ringtime { get; set; }
        public string link_down_record { get; set; }
        public string status { get; set; }
        public string error_code { get; set; }
        public string error_desc { get; set; }
    }
    public class SinhVien
    {
        public string Ma_sinh_vien { get; set; }
        public string Dien_thoai { get; set; }
        public string Truong { get; set; }
        public string Ho_ten { get; set; }
        public string Ma_lop { get; set; }
        public string Noi_sinh { get; set; }
        public DateTime Ngay_sinh { get; set; }

        public void get_sinh_vien_by_ds(DataSet ip_ds_sv)
        {
            if (ip_ds_sv.Tables[0].Rows.Count > 0)
            {
                Ma_sinh_vien = CIPConvert.ToStr(ip_ds_sv.Tables[0].Rows[0][CSinhVien.MA_HOC_VIEN]);
                Dien_thoai = CIPConvert.ToStr(ip_ds_sv.Tables[0].Rows[0][CSinhVien.DIEN_THOAI_DI_DONG]);
                Truong =CIPConvert.ToStr( ip_ds_sv.Tables[0].Rows[0][CSinhVien.MA_TRUONG]);
                Ma_lop = CIPConvert.ToStr(ip_ds_sv.Tables[0].Rows[0][CSinhVien.MA_LOP]);
                Noi_sinh =CIPConvert.ToStr( ip_ds_sv.Tables[0].Rows[0][CSinhVien.NOI_SINH]);
                if(ip_ds_sv.Tables[0].Rows[0][CSinhVien.NGAY_THANG_NAM_SINH] != null)
                    Ngay_sinh = Convert.ToDateTime(ip_ds_sv.Tables[0].Rows[0][CSinhVien.NGAY_THANG_NAM_SINH].ToString());
                Ho_ten = CIPConvert.ToStr(ip_ds_sv.Tables[0].Rows[0][CSinhVien.HO_VA_DEM]) + " " + CIPConvert.ToStr(ip_ds_sv.Tables[0].Rows[0][CSinhVien.TEN_HOC_VIEN]);  
            }
        }

    }