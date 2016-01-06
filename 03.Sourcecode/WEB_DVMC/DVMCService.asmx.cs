using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace WEB_DVMC
{
    /// <summary>
    /// Summary description for DVMCService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class DVMCService : System.Web.Services.WebService
    {

        [WebMethod]
        public void load_data_2_grid_dang_xu_ly(decimal id_user)
        {
            string query = "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where THAO_TAC_HET_HAN_YN = 'N'";
            query += "And ID_LOAI_THAO_TAC in (296) And ID_NGUOI_NHAN_THAO_TAC = " + id_user;

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, query);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in v_ds.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in v_ds.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            Context.Response.Write(js.Serialize(rows));
        }

        [WebMethod]
        public void load_data_2_grid_dp_lai(decimal id_user)
        {
            string query = "select * from V_GD_DAT_HANG_GD_LOG_DAT_HANG where THAO_TAC_HET_HAN_YN = 'N'";
            query += "And ID_LOAI_THAO_TAC in (295,311) And ID_NGUOI_NHAN_THAO_TAC = " + id_user;

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, query);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in v_ds.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in v_ds.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            Context.Response.Write(js.Serialize(rows));
        }
    }
}
