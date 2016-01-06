///************************************************
/// Generated by: Anhpt
/// Date: 07/10/2015 01:06:14
/// Goal: Create User Service Class for V_GD_DAT_HANG
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DAT_HANG
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_V_GD_DAT_HANG : US_Object
	{
		private const string c_TableName = "V_GD_DAT_HANG";
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

		public decimal dcID_USER_NV_DAT_HANG 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_USER_NV_DAT_HANG", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_USER_NV_DAT_HANG"] = value;
			}
		}

		public bool IsID_USER_NV_DAT_HANGNull()	{
			return pm_objDR.IsNull("ID_USER_NV_DAT_HANG");
		}

		public void SetID_USER_NV_DAT_HANGNull() {
			pm_objDR["ID_USER_NV_DAT_HANG"] = System.Convert.DBNull;
		}

		public decimal dcID_DON_VI 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DON_VI"] = value;
			}
		}

		public bool IsID_DON_VINull()	{
			return pm_objDR.IsNull("ID_DON_VI");
		}

		public void SetID_DON_VINull() {
			pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
		}

		public string strMA_DON_VI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MA_DON_VI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MA_DON_VI"] = value;
			}
		}

		public bool IsMA_DON_VINull() 
		{
			return pm_objDR.IsNull("MA_DON_VI");
		}

		public void SetMA_DON_VINull() {
			pm_objDR["MA_DON_VI"] = System.Convert.DBNull;
		}

		public string strDIEN_THOAI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "DIEN_THOAI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["DIEN_THOAI"] = value;
			}
		}

		public bool IsDIEN_THOAINull() 
		{
			return pm_objDR.IsNull("DIEN_THOAI");
		}

		public void SetDIEN_THOAINull() {
			pm_objDR["DIEN_THOAI"] = System.Convert.DBNull;
		}

		public string strHO_TEN_USER_DAT_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "HO_TEN_USER_DAT_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["HO_TEN_USER_DAT_HANG"] = value;
			}
		}

		public bool IsHO_TEN_USER_DAT_HANGNull() 
		{
			return pm_objDR.IsNull("HO_TEN_USER_DAT_HANG");
		}

		public void SetHO_TEN_USER_DAT_HANGNull() {
			pm_objDR["HO_TEN_USER_DAT_HANG"] = System.Convert.DBNull;
		}

		public DateTime datTHOI_DIEM_CAN_HOAN_THANH
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "THOI_DIEM_CAN_HOAN_THANH", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["THOI_DIEM_CAN_HOAN_THANH"] = value;
			}
		}

		public bool IsTHOI_DIEM_CAN_HOAN_THANHNull()
		{
			return pm_objDR.IsNull("THOI_DIEM_CAN_HOAN_THANH");
		}

		public void SetTHOI_DIEM_CAN_HOAN_THANHNull()
		{
			pm_objDR["THOI_DIEM_CAN_HOAN_THANH"] = System.Convert.DBNull;
		}

		public decimal dcID_DV_YEU_CAU 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DV_YEU_CAU", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DV_YEU_CAU"] = value;
			}
		}

		public bool IsID_DV_YEU_CAUNull()	{
			return pm_objDR.IsNull("ID_DV_YEU_CAU");
		}

		public void SetID_DV_YEU_CAUNull() {
			pm_objDR["ID_DV_YEU_CAU"] = System.Convert.DBNull;
		}

		public string strTEN_YEU_CAU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TEN_YEU_CAU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TEN_YEU_CAU"] = value;
			}
		}

		public bool IsTEN_YEU_CAUNull() 
		{
			return pm_objDR.IsNull("TEN_YEU_CAU");
		}

		public void SetTEN_YEU_CAUNull() {
			pm_objDR["TEN_YEU_CAU"] = System.Convert.DBNull;
		}

		public string strNOI_DUNG_DAT_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NOI_DUNG_DAT_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NOI_DUNG_DAT_HANG"] = value;
			}
		}

		public bool IsNOI_DUNG_DAT_HANGNull() 
		{
			return pm_objDR.IsNull("NOI_DUNG_DAT_HANG");
		}

		public void SetNOI_DUNG_DAT_HANGNull() {
			pm_objDR["NOI_DUNG_DAT_HANG"] = System.Convert.DBNull;
		}

		public decimal dcID_LOAI_THOI_GIAN_CAN_HOAN_THANH 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_THOI_GIAN_CAN_HOAN_THANH", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_LOAI_THOI_GIAN_CAN_HOAN_THANH"] = value;
			}
		}

		public bool IsID_LOAI_THOI_GIAN_CAN_HOAN_THANHNull()	{
			return pm_objDR.IsNull("ID_LOAI_THOI_GIAN_CAN_HOAN_THANH");
		}

		public void SetID_LOAI_THOI_GIAN_CAN_HOAN_THANHNull() {
			pm_objDR["ID_LOAI_THOI_GIAN_CAN_HOAN_THANH"] = System.Convert.DBNull;
		}

		public string strLOAI_THOI_GIAN_CAN_HOAN_THANH 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "LOAI_THOI_GIAN_CAN_HOAN_THANH", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["LOAI_THOI_GIAN_CAN_HOAN_THANH"] = value;
			}
		}

		public bool IsLOAI_THOI_GIAN_CAN_HOAN_THANHNull() 
		{
			return pm_objDR.IsNull("LOAI_THOI_GIAN_CAN_HOAN_THANH");
		}

		public void SetLOAI_THOI_GIAN_CAN_HOAN_THANHNull() {
			pm_objDR["LOAI_THOI_GIAN_CAN_HOAN_THANH"] = System.Convert.DBNull;
		}

		public string strPHAN_HOI_TU_DVMC 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "PHAN_HOI_TU_DVMC", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["PHAN_HOI_TU_DVMC"] = value;
			}
		}

		public bool IsPHAN_HOI_TU_DVMCNull() 
		{
			return pm_objDR.IsNull("PHAN_HOI_TU_DVMC");
		}

		public void SetPHAN_HOI_TU_DVMCNull() {
			pm_objDR["PHAN_HOI_TU_DVMC"] = System.Convert.DBNull;
		}

		public DateTime datTHOI_GIAN_HOAN_THANH
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_HOAN_THANH", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["THOI_GIAN_HOAN_THANH"] = value;
			}
		}

		public bool IsTHOI_GIAN_HOAN_THANHNull()
		{
			return pm_objDR.IsNull("THOI_GIAN_HOAN_THANH");
		}

		public void SetTHOI_GIAN_HOAN_THANHNull()
		{
			pm_objDR["THOI_GIAN_HOAN_THANH"] = System.Convert.DBNull;
		}

		public decimal dcID_DANH_GIA_TU_USER_DAT_HANG 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_DANH_GIA_TU_USER_DAT_HANG", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_DANH_GIA_TU_USER_DAT_HANG"] = value;
			}
		}

		public bool IsID_DANH_GIA_TU_USER_DAT_HANGNull()	{
			return pm_objDR.IsNull("ID_DANH_GIA_TU_USER_DAT_HANG");
		}

		public void SetID_DANH_GIA_TU_USER_DAT_HANGNull() {
			pm_objDR["ID_DANH_GIA_TU_USER_DAT_HANG"] = System.Convert.DBNull;
		}

		public string strDANH_GIA_TU_USER_DAT_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "DANH_GIA_TU_USER_DAT_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["DANH_GIA_TU_USER_DAT_HANG"] = value;
			}
		}

		public bool IsDANH_GIA_TU_USER_DAT_HANGNull() 
		{
			return pm_objDR.IsNull("DANH_GIA_TU_USER_DAT_HANG");
		}

		public void SetDANH_GIA_TU_USER_DAT_HANGNull() {
			pm_objDR["DANH_GIA_TU_USER_DAT_HANG"] = System.Convert.DBNull;
		}

		public string strY_KIEN_KHAC_TU_USER_DAT_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "Y_KIEN_KHAC_TU_USER_DAT_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["Y_KIEN_KHAC_TU_USER_DAT_HANG"] = value;
			}
		}

		public bool IsY_KIEN_KHAC_TU_USER_DAT_HANGNull() 
		{
			return pm_objDR.IsNull("Y_KIEN_KHAC_TU_USER_DAT_HANG");
		}

		public void SetY_KIEN_KHAC_TU_USER_DAT_HANGNull() {
			pm_objDR["Y_KIEN_KHAC_TU_USER_DAT_HANG"] = System.Convert.DBNull;
		}

		public DateTime datTHOI_GIAN_TAO
		{
			get   
			{
				return CNull.RowNVLDate(pm_objDR, "THOI_GIAN_TAO", IPConstants.c_DefaultDate);
			}
			set   
			{
				pm_objDR["THOI_GIAN_TAO"] = value;
			}
		}

		public bool IsTHOI_GIAN_TAONull()
		{
			return pm_objDR.IsNull("THOI_GIAN_TAO");
		}

		public void SetTHOI_GIAN_TAONull()
		{
			pm_objDR["THOI_GIAN_TAO"] = System.Convert.DBNull;
		}

		public decimal dcID_PHUONG_THUC_DAT_HANG 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_PHUONG_THUC_DAT_HANG", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_PHUONG_THUC_DAT_HANG"] = value;
			}
		}

		public bool IsID_PHUONG_THUC_DAT_HANGNull()	{
			return pm_objDR.IsNull("ID_PHUONG_THUC_DAT_HANG");
		}

		public void SetID_PHUONG_THUC_DAT_HANGNull() {
			pm_objDR["ID_PHUONG_THUC_DAT_HANG"] = System.Convert.DBNull;
		}

		public string strPHUONG_THUC_DAT_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "PHUONG_THUC_DAT_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["PHUONG_THUC_DAT_HANG"] = value;
			}
		}

		public bool IsPHUONG_THUC_DAT_HANGNull() 
		{
			return pm_objDR.IsNull("PHUONG_THUC_DAT_HANG");
		}

		public void SetPHUONG_THUC_DAT_HANGNull() {
			pm_objDR["PHUONG_THUC_DAT_HANG"] = System.Convert.DBNull;
		}

		public decimal dcID_NGUOI_TAO 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_TAO", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_NGUOI_TAO"] = value;
			}
		}

		public bool IsID_NGUOI_TAONull()	{
			return pm_objDR.IsNull("ID_NGUOI_TAO");
		}

		public void SetID_NGUOI_TAONull() {
			pm_objDR["ID_NGUOI_TAO"] = System.Convert.DBNull;
		}

		public string strNGUOI_TAO 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NGUOI_TAO", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NGUOI_TAO"] = value;
			}
		}

		public bool IsNGUOI_TAONull() 
		{
			return pm_objDR.IsNull("NGUOI_TAO");
		}

		public void SetNGUOI_TAONull() {
			pm_objDR["NGUOI_TAO"] = System.Convert.DBNull;
		}

		public decimal dcID_CHI_NHANH 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_CHI_NHANH", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_CHI_NHANH"] = value;
			}
		}

		public bool IsID_CHI_NHANHNull()	{
			return pm_objDR.IsNull("ID_CHI_NHANH");
		}

		public void SetID_CHI_NHANHNull() {
			pm_objDR["ID_CHI_NHANH"] = System.Convert.DBNull;
		}

		public string strTEN_CHI_NHANH 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TEN_CHI_NHANH", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TEN_CHI_NHANH"] = value;
			}
		}

		public bool IsTEN_CHI_NHANHNull() 
		{
			return pm_objDR.IsNull("TEN_CHI_NHANH");
		}

		public void SetTEN_CHI_NHANHNull() {
			pm_objDR["TEN_CHI_NHANH"] = System.Convert.DBNull;
		}

		public string strEMAIL 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "EMAIL", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["EMAIL"] = value;
			}
		}

		public bool IsEMAILNull() 
		{
			return pm_objDR.IsNull("EMAIL");
		}

		public void SetEMAILNull() {
			pm_objDR["EMAIL"] = System.Convert.DBNull;
		}

		public string strUSER_NAME 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "USER_NAME", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["USER_NAME"] = value;
			}
		}

		public bool IsUSER_NAMENull() 
		{
			return pm_objDR.IsNull("USER_NAME");
		}

		public void SetUSER_NAMENull() {
			pm_objDR["USER_NAME"] = System.Convert.DBNull;
		}

		public string strCAP_NHAT_CUOI 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "CAP_NHAT_CUOI", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["CAP_NHAT_CUOI"] = value;
			}
		}

		public bool IsCAP_NHAT_CUOINull() 
		{
			return pm_objDR.IsNull("CAP_NHAT_CUOI");
		}

		public void SetCAP_NHAT_CUOINull() {
			pm_objDR["CAP_NHAT_CUOI"] = System.Convert.DBNull;
		}

		public string strNGUOI_XU_LY 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "NGUOI_XU_LY", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["NGUOI_XU_LY"] = value;
			}
		}

		public bool IsNGUOI_XU_LYNull() 
		{
			return pm_objDR.IsNull("NGUOI_XU_LY");
		}

		public void SetNGUOI_XU_LYNull() {
			pm_objDR["NGUOI_XU_LY"] = System.Convert.DBNull;
		}

		public string strTRANG_THAI_DON_HANG 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TRANG_THAI_DON_HANG", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TRANG_THAI_DON_HANG"] = value;
			}
		}

		public bool IsTRANG_THAI_DON_HANGNull() 
		{
			return pm_objDR.IsNull("TRANG_THAI_DON_HANG");
		}

		public void SetTRANG_THAI_DON_HANGNull() {
			pm_objDR["TRANG_THAI_DON_HANG"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_V_GD_DAT_HANG() 
		{
			pm_objDS = new DS_V_GD_DAT_HANG();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_V_GD_DAT_HANG(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_V_GD_DAT_HANG(decimal i_dbID) 
		{
			pm_objDS = new DS_V_GD_DAT_HANG();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion


            public void danh_gia_don_hang(decimal ip_id_don_hang, decimal ip_dc_id_danh_gia, string ip_str_y_kien_khac)
        {
            CStoredProc v_cstore = new CStoredProc("pr_V_GD_DAT_HANG_danh_gia_don_hang");
            v_cstore.addDecimalInputParam("@ID_DON_HANG", ip_id_don_hang);
            v_cstore.addDecimalInputParam("@ID_DANH_GIA", ip_dc_id_danh_gia);
            v_cstore.addNVarcharInputParam("@Y_KIEN_KHAC", ip_str_y_kien_khac);
            v_cstore.ExecuteCommand(this);
        }

            public void load_dat_hang_by_ma(string v_str_ma_don_hang, string p, DS_V_GD_DAT_HANG v_ds_gd_dat_hang)
            {
                CStoredProc v_cstore = new CStoredProc("pr_V_GD_DAT_HANG_load_dat_hang_by_ma");
                v_cstore.addNVarcharInputParam("@MA_DAT_HANG", v_str_ma_don_hang);
                v_cstore.addNVarcharInputParam("@USERNAME", p);
                v_cstore.fillDataSetByCommand(this, v_ds_gd_dat_hang);
            }
    }
}