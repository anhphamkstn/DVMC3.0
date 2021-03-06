///************************************************
/// Generated by: vannd
/// Date: 08/08/2015 04:03:37
/// Goal: Create User Service Class for DM_MA_DON_HANG
///************************************************
/// <summary>
/// Create User Service Class for DM_MA_DON_HANG
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_DM_MA_DON_HANG : US_Object
	{
		private const string c_TableName = "DM_MA_DON_HANG";
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

		public string strMA_DON_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MA_DON_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MA_DON_HANG"] = value;
			}
		}

		public bool IsMA_DON_HANGNull() 
		{
			return pm_objDR.IsNull("MA_DON_HANG");
		}

		public void SetMA_DON_HANGNull() {
			pm_objDR["MA_DON_HANG"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_DM_MA_DON_HANG() 
		{
			pm_objDS = new DS_DM_MA_DON_HANG();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_DM_MA_DON_HANG(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_DM_MA_DON_HANG(decimal i_dbID) 
		{
			pm_objDS = new DS_DM_MA_DON_HANG();
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
