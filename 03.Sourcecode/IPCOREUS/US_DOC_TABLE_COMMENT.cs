///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:36:12
/// Goal: Create User Service Class for DOC_TABLE_COMMENT
///************************************************
/// <summary>
/// Create User Service Class for DOC_TABLE_COMMENT
/// </summary>


using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace IPCOREUS
{

public class US_DOC_TABLE_COMMENT : US_Object
{
	private const string c_TableName = "DOC_TABLE_COMMENT";
#region "Public Properties"
	public string strTABLE_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TABLE_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TABLE_NAME"] = value;
		}
	}

	public bool IsTABLE_NAMENull() 
	{
		return pm_objDR.IsNull("TABLE_NAME");
	}

	public void SetTABLE_NAMENull() {
		pm_objDR["TABLE_NAME"] = System.Convert.DBNull;
	}

	public string strTABLE_COMMENT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TABLE_COMMENT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TABLE_COMMENT"] = value;
		}
	}

	public bool IsTABLE_COMMENTNull() 
	{
		return pm_objDR.IsNull("TABLE_COMMENT");
	}

	public void SetTABLE_COMMENTNull() {
		pm_objDR["TABLE_COMMENT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DOC_TABLE_COMMENT() 
	{
		pm_objDS = new DS_DOC_TABLE_COMMENT();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DOC_TABLE_COMMENT(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DOC_TABLE_COMMENT(decimal i_dbID) 
	{
		pm_objDS = new DS_DOC_TABLE_COMMENT();
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
