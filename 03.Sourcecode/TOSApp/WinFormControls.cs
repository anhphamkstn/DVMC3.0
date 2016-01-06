using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;


using IPCOREDS;
using IPCOREUS;
using IPCOREDS.CDBNames;

using DevExpress.Utils.Menu;
using System.Configuration;
using System.Data.OleDb;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;


namespace TOSApp
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

        public static void load_data_to_auto_complete_source(string ip_str_table_name, string ip_str_column_name, TextBox ip_txt)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithProc(v_ds, ip_str_table_name, ip_str_column_name);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                ip_txt.AutoCompleteCustomSource.Add(v_dr[ip_str_column_name].ToString());
            }
        }

        

        public static void load_data_to_combobox(string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition, eTAT_CA ip_e_tat_ca,ComboBox ip_cbo)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetCBO(v_ds, ip_str_table_name, ip_str_value_field, ip_str_display_field, ip_str_condition);
            
            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------------Hãy chọn-----------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }


        public static void load_data_to_combobox_with_query(ComboBox ip_cbo, string ip_str_value_field, string ip_str_display_field, eTAT_CA ip_e_tat_ca, string ip_query)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, ip_query);
            
            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "---------- Hãy chọn ----------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }



        #region Report
        static GridView m_grv;
        public static DXMenuItem CreateRowSubMenu(GridView view, int rowHandle)
        {
            m_grv = view;
            DXSubMenuItem subMenu = new DXSubMenuItem("Báo cáo");
            DXMenuItem menuItemReportXLS = new DXMenuItem("&Báo cáo XLS", new EventHandler(ExportXLSClick));
            DXMenuItem menuItemReportPDF = new DXMenuItem("&Báo cáo PDF", new EventHandler(ExportPDFClick));
            DXMenuItem menuItemReportHTML = new DXMenuItem("&Báo cáo HTML", new EventHandler(ExportHTMLClick));
            DXMenuItem menuItemReportDOC = new DXMenuItem("&Báo cáo TXT", new EventHandler(ExportDOCClick));
            subMenu.Items.Add(menuItemReportXLS);
            subMenu.Items.Add(menuItemReportPDF);
            subMenu.Items.Add(menuItemReportHTML);
            subMenu.Items.Add(menuItemReportDOC);
            return subMenu;
        }

        private static void ExportPDFClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToPdf(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportHTMLClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToHtml(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportDOCClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToText(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportXLSClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToXls(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }
        #endregion
    }



    public class US_DUNG_CHUNG : US_Object {
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

        public void FillDatasetLogin(DataSet v_ds, string user,string pass, decimal id_chi_nhanh)
        {
            CStoredProc v_cstore = new CStoredProc("check_login");
            v_cstore.addNVarcharInputParam("@user", user);
            v_cstore.addNVarcharInputParam("@pass", pass);
            v_cstore.addDecimalInputParam("@id_chi_nhanh", id_chi_nhanh);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
        public void CheckEmailDanhMucKhachHang(DataSet v_ds,string email)
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
        internal void FillAllOrder(DataSet v_ds, DateTime StartDate, DateTime EndDate,string orderstate)
        {
            CStoredProc v_cstore = new CStoredProc("getAllOrder");
            v_cstore.addDatetimeInputParam("@startDate", StartDate);
            v_cstore.addDatetimeInputParam("@endDate", EndDate);
            v_cstore.addNVarcharInputParam("@arrayOrderState",orderstate);
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
        public decimal get_id_pm_dich_vu (decimal v_id_loai_dich_vu,decimal v_id_pm)
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

        public iParameter(string ip_name, string ip_value) {
            ParameterName = ip_name;
            ParameterValue = ip_value;
        }
    }
}
