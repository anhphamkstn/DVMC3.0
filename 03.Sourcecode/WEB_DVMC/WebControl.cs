using DevExpress.XtraRichEdit.Layout;
using IP.Core.IPUserService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WEB_DVMC
{
    public class WinFormControls
    {
        public WinFormControls()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public enum eTAT_CA
        {
            YES,
            NO
        }
        public enum eLOAI_TU_DIEN
        {
            TRANG_THAI_CHUC_VU,
            LOAI_HOP_DONG,
            LOAI_DON_VI,
            CAP_DON_VI,
            CO_CHE,
            LOAI_DU_AN,
            TRANG_THAI_DU_AN,
            LOAI_QUYET_DINH,
            TRANG_THAI_LAO_DONG,
            DM_CA_HOC
        }
       
    }

    public class US_DUNG_CHUNG : US_Object
    {
        public void FillDatasetWithProc(DataSet op_ds, string ip_str_table_name, string ip_str_column_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_to_dataset_with_table_name_and_column_name");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_NAME", ip_str_column_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }



        public void FillDatasetCBO(DataSet op_ds, string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_for_cbo");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_VALUE", ip_str_value_field);
            v_cstore.addNVarcharInputParam("@COLUMN_DISPLAY", ip_str_display_field);
            v_cstore.addNVarcharInputParam("@CONDITION", ip_str_condition);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithTableName(DataSet op_ds, string ip_str_table_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_from_table");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetWithQuery(DataSet op_ds, string ip_query)
        {
            CStoredProc v_cstore = new CStoredProc("pr_fill_ds_with_query");
            v_cstore.addNVarcharInputParam("@SQL_QUERY", ip_query);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetLogin(DataSet v_ds, string user, string pass, decimal id_chi_nhanh)
        {
            CStoredProc v_cstore = new CStoredProc("check_login");
            v_cstore.addNVarcharInputParam("@user", user);
            v_cstore.addNVarcharInputParam("@pass", pass);
            v_cstore.addDecimalInputParam("@id_chi_nhanh", id_chi_nhanh);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        public void CheckEmailDanhMucKhachHang(DataSet v_ds, string email)
        {
            CStoredProc v_cstore = new CStoredProc("check_email_dm_khach_hang");
            v_cstore.addNVarcharInputParam("@email", email);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        internal void FillDatasetSQLInjection(DataSet v_ds, string p)
        {
            CStoredProc v_cstore = new CStoredProc("sqlInjection");
            v_cstore.addNVarcharInputParam("@str_query", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void GetTimeByProcedure(DataSet v_ds, decimal id_time, DateTime deadline)
        {

            CStoredProc v_cstore = new CStoredProc("get_start_date");
            v_cstore.addDecimalInputParam("@id_khoang_thoi_gian", id_time);
            v_cstore.addDatetimeInputParam("@deadline", deadline);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillAppointmentByDichVu(DataSet v_ds, decimal id_dich_vu)
        {
            CStoredProc v_cstore = new CStoredProc("get_AppointmentByDichVu");
            v_cstore.addDecimalInputParam("@id_dich_vu", id_dich_vu);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        internal void FillResourcesByDichVu(DataSet v_ds, decimal id_dich_vu)
        {
            CStoredProc v_cstore = new CStoredProc("get_nguoi_xu_ly_by_dv");
            v_cstore.addDecimalInputParam("@id_dich_vu", id_dich_vu);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillReportFOByTimeCreated(DataSet v_ds, DateTime StartDate, DateTime EndDate)
        {
            CStoredProc v_cstore = new CStoredProc("get_ReportFOByTimeCreated");
            v_cstore.addDatetimeInputParam("@startDate", StartDate);
            v_cstore.addDatetimeInputParam("@endDate", EndDate);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillReportBOByTimeCreated(DataSet v_ds, DateTime StartDate, DateTime EndDate)
        {
            CStoredProc v_cstore = new CStoredProc("get_ReportBOByTimeCreated");
            v_cstore.addDatetimeInputParam("@startDate", StartDate);
            v_cstore.addDatetimeInputParam("@endDate", EndDate);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public string get_ma_dat_hang_tiep_theo()
        {
            string v_output = "";
            CStoredProc v_cstore = new CStoredProc("pr_get_ma_don_hang");
            SqlParameter v_result = v_cstore.addNVarcharOutputParam("@MA_DON_HANG", v_output);
            v_cstore.ExecuteCommand(this);
            return v_result.Value.ToString();
        }
        public DateTime get_thoi_diem_can_hoan_thanh(string time)
        {
            string v_output = "";
            CStoredProc v_cstore = new CStoredProc("pr_get_thoi_diem_can_hoan_thanh");
            v_cstore.addNVarcharInputParam("@string_time", time);
            SqlParameter v_result = v_cstore.addDatetimeOutputParam("@thoi_diem_can_hoan_thanh", v_output);
            v_cstore.ExecuteCommand(this);
            return (DateTime)v_result.Value;
        }
        public string get_ten_nguoi_su_dung(decimal v_id)
        {
            string v_ten = "";
            CStoredProc v_cstore = new CStoredProc("get_ten_nguoi_su_dung");
            v_cstore.addNVarcharInputParam("@id", v_id);
            SqlParameter v_result = v_cstore.addNVarcharOutputParam("@ten", v_ten);
            v_cstore.ExecuteCommand(this);
            return (string)v_result.Value;
        }
        public decimal get_id_pm_dich_vu(decimal v_id_loai_dich_vu, decimal v_id_pm)
        {
            decimal count = 0;
            CStoredProc v_cstore = new CStoredProc("get_id_pm_dich_vu");
            v_cstore.addDecimalInputParam("@id", v_id_loai_dich_vu);
            v_cstore.addDecimalInputParam("@v_id_pm", v_id_pm);
            SqlParameter v_result = v_cstore.addDecimalOutputParam("@count", count);
            v_cstore.ExecuteCommand(this);
            return (decimal)v_result.Value;
        }
        public decimal get_id_td_dich_vu(decimal v_id_loai_dich_vu, decimal v_id_td)
        {
            decimal count = 0;
            CStoredProc v_cstore = new CStoredProc("get_id_td_dich_vu");
            v_cstore.addDecimalInputParam("@id", v_id_loai_dich_vu);
            v_cstore.addDecimalInputParam("@v_id_td", v_id_td);
            SqlParameter v_result = v_cstore.addDecimalOutputParam("@count", count);
            v_cstore.ExecuteCommand(this);
            return (decimal)v_result.Value;
        }


    }

    public class iParameter
    {
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }

        public iParameter(string ip_name, string ip_value)
        {
            ParameterName = ip_name;
            ParameterValue = ip_value;
        }
    }
   
    
}
