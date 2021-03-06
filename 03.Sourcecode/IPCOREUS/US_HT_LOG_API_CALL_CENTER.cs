///************************************************
/// Generated by: Anhpt
/// Date: 06/10/2015 12:23:42
/// Goal: Create User Service Class for HT_LOG_API_CALL_CENTER
///************************************************
/// <summary>
/// Create User Service Class for HT_LOG_API_CALL_CENTER
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_HT_LOG_API_CALL_CENTER : US_Object
	{
		private const string c_TableName = "HT_LOG_API_CALL_CENTER";
		#region Public Properties
		public decimal dcID 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID"] = value;
			}
		}

		public bool IsIDNull()	{
			return pm_objDR.IsNull("ID");
		}

		public void SetIDNull() {
			pm_objDR["ID"] = System.Convert.DBNull;
		}

		public decimal dcID_DANG_NHAP 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DANG_NHAP", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DANG_NHAP"] = value;
			}
		}

		public bool IsID_DANG_NHAPNull()	{
			return pm_objDR.IsNull("ID_DANG_NHAP");
		}

		public void SetID_DANG_NHAPNull() {
			pm_objDR["ID_DANG_NHAP"] = System.Convert.DBNull;
		}

		public DateTime datTHOI_GIAN
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "THOI_GIAN", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["THOI_GIAN"] = value;
			}
		}

		public bool IsTHOI_GIANNull()
		{
			return pm_objDR.IsNull("THOI_GIAN");
		}

		public void SetTHOI_GIANNull()
		{
			pm_objDR["THOI_GIAN"] = System.Convert.DBNull;
		}

		public string strMO_TA 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MO_TA"] = value;
			}
		}

		public bool IsMO_TANull() 
		{
			return pm_objDR.IsNull("MO_TA");
		}

		public void SetMO_TANull() {
			pm_objDR["MO_TA"] = System.Convert.DBNull;
		}

		public string strGHI_CHU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["GHI_CHU"] = value;
			}
		}

		public bool IsGHI_CHUNull() 
		{
			return pm_objDR.IsNull("GHI_CHU");
		}

		public void SetGHI_CHUNull() {
			pm_objDR["GHI_CHU"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_HT_LOG_API_CALL_CENTER() 
		{
			pm_objDS = new DS_HT_LOG_API_CALL_CENTER();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_HT_LOG_API_CALL_CENTER(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_HT_LOG_API_CALL_CENTER(decimal i_dbID) 
		{
			pm_objDS = new DS_HT_LOG_API_CALL_CENTER();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion


	}
}
