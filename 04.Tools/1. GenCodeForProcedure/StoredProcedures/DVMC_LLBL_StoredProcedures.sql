SET NOCOUNT ON
GO
USE [DVMC]
GO
CREATE PROCEDURE [dbo].[pr_V_GD_DAT_HANG_Insert]
	@ID numeric(18, 0),
	@MA_DON_HANG nvarchar(50),
	@USER_NV_DAT_HANG nvarchar(50),
	@ID_DON_VI numeric(18, 0),
	@TEN_DON_VI nvarchar(250),
	@DIEN_THOAI nvarchar(50),
	@HO_TEN_USER_DAT_HANG nvarchar(50),
	@THOI_GIAN_DAT_HANG datetime,
	@ID_LOAI_DV_YEU_CAU numeric(18, 0),
	@TEN_LOAI_DICH_VU nvarchar(250),
	@ID_LOAI_YEU_CAU_CHA numeric(18, 0),
	@TEN_LOAI_YC_CHA nvarchar(250),
	@NOI_DUNG_DAT_HANG nvarchar(500),
	@ID_LOAI_THOI_GIAN_CAN_HOAN_THANH numeric(18, 0),
	@LOAI_THOI_GIAN_CAN_HOAN_THANH nvarchar(250),
	@PHAN_HOI_TU_DVMC nvarchar(500),
	@THOI_GIAN_HOAN_THANH datetime,
	@ID_TRANG_THAI numeric(18, 0),
	@TRANG_THAI_YC nvarchar(250),
	@ID_DANH_GIA_TU_USER_DAT_HANG numeric(18, 0),
	@DANH_GIA_TU_USER_DAT_HANG nvarchar(250),
	@Y_KIEN_KHAC_TU_USER_DAT_HANG nvarchar(500),
	@ID_NGUOI_NHAN_DAT_HANG numeric(18, 0),
	@NGUOI_NHAN_DAT_HANG nvarchar(35),
	@ID_NGUOI_XU_LY numeric(18, 0),
	@NGUOI_XU_LY nvarchar(35),
	@ID_NGUOI_TAO numeric(18, 0),
	@THOI_GIAN_TAO datetime,
	@LICH_SU_TRAO_DOI nvarchar(500),
	@ID_NGUOI_SUA_CUOI numeric(18, 0),
	@USER_NGUOI_SUA_CUOI nvarchar(35),
	@THOI_GIAN_SUA_CUOI datetime
AS
INSERT [dbo].[V_GD_DAT_HANG]
(
	[ID],
	[MA_DON_HANG],
	[USER_NV_DAT_HANG],
	[ID_DON_VI],
	[TEN_DON_VI],
	[DIEN_THOAI],
	[HO_TEN_USER_DAT_HANG],
	[THOI_GIAN_DAT_HANG],
	[ID_LOAI_DV_YEU_CAU],
	[TEN_LOAI_DICH_VU],
	[ID_LOAI_YEU_CAU_CHA],
	[TEN_LOAI_YC_CHA],
	[NOI_DUNG_DAT_HANG],
	[ID_LOAI_THOI_GIAN_CAN_HOAN_THANH],
	[LOAI_THOI_GIAN_CAN_HOAN_THANH],
	[PHAN_HOI_TU_DVMC],
	[THOI_GIAN_HOAN_THANH],
	[ID_TRANG_THAI],
	[TRANG_THAI_YC],
	[ID_DANH_GIA_TU_USER_DAT_HANG],
	[DANH_GIA_TU_USER_DAT_HANG],
	[Y_KIEN_KHAC_TU_USER_DAT_HANG],
	[ID_NGUOI_NHAN_DAT_HANG],
	[NGUOI_NHAN_DAT_HANG],
	[ID_NGUOI_XU_LY],
	[NGUOI_XU_LY],
	[ID_NGUOI_TAO],
	[THOI_GIAN_TAO],
	[LICH_SU_TRAO_DOI],
	[ID_NGUOI_SUA_CUOI],
	[USER_NGUOI_SUA_CUOI],
	[THOI_GIAN_SUA_CUOI]
)
VALUES
(
	@ID,
	@MA_DON_HANG,
	@USER_NV_DAT_HANG,
	@ID_DON_VI,
	@TEN_DON_VI,
	@DIEN_THOAI,
	@HO_TEN_USER_DAT_HANG,
	@THOI_GIAN_DAT_HANG,
	@ID_LOAI_DV_YEU_CAU,
	@TEN_LOAI_DICH_VU,
	@ID_LOAI_YEU_CAU_CHA,
	@TEN_LOAI_YC_CHA,
	@NOI_DUNG_DAT_HANG,
	@ID_LOAI_THOI_GIAN_CAN_HOAN_THANH,
	@LOAI_THOI_GIAN_CAN_HOAN_THANH,
	@PHAN_HOI_TU_DVMC,
	@THOI_GIAN_HOAN_THANH,
	@ID_TRANG_THAI,
	@TRANG_THAI_YC,
	@ID_DANH_GIA_TU_USER_DAT_HANG,
	@DANH_GIA_TU_USER_DAT_HANG,
	@Y_KIEN_KHAC_TU_USER_DAT_HANG,
	@ID_NGUOI_NHAN_DAT_HANG,
	@NGUOI_NHAN_DAT_HANG,
	@ID_NGUOI_XU_LY,
	@NGUOI_XU_LY,
	@ID_NGUOI_TAO,
	@THOI_GIAN_TAO,
	@LICH_SU_TRAO_DOI,
	@ID_NGUOI_SUA_CUOI,
	@USER_NGUOI_SUA_CUOI,
	@THOI_GIAN_SUA_CUOI
)
GO

-- //// Try-to-lock-and-compare Stored procedure.
CREATE PROCEDURE [dbo].[pr_V_GD_DAT_HANG_IsUpdatable]
	@ID numeric(18, 0),
	@MA_DON_HANG nvarchar(50),
	@USER_NV_DAT_HANG nvarchar(50),
	@ID_DON_VI numeric(18, 0),
	@TEN_DON_VI nvarchar(250),
	@DIEN_THOAI nvarchar(50),
	@HO_TEN_USER_DAT_HANG nvarchar(50),
	@THOI_GIAN_DAT_HANG datetime,
	@ID_LOAI_DV_YEU_CAU numeric(18, 0),
	@TEN_LOAI_DICH_VU nvarchar(250),
	@ID_LOAI_YEU_CAU_CHA numeric(18, 0),
	@TEN_LOAI_YC_CHA nvarchar(250),
	@NOI_DUNG_DAT_HANG nvarchar(500),
	@ID_LOAI_THOI_GIAN_CAN_HOAN_THANH numeric(18, 0),
	@LOAI_THOI_GIAN_CAN_HOAN_THANH nvarchar(250),
	@PHAN_HOI_TU_DVMC nvarchar(500),
	@THOI_GIAN_HOAN_THANH datetime,
	@ID_TRANG_THAI numeric(18, 0),
	@TRANG_THAI_YC nvarchar(250),
	@ID_DANH_GIA_TU_USER_DAT_HANG numeric(18, 0),
	@DANH_GIA_TU_USER_DAT_HANG nvarchar(250),
	@Y_KIEN_KHAC_TU_USER_DAT_HANG nvarchar(500),
	@ID_NGUOI_NHAN_DAT_HANG numeric(18, 0),
	@NGUOI_NHAN_DAT_HANG nvarchar(35),
	@ID_NGUOI_XU_LY numeric(18, 0),
	@NGUOI_XU_LY nvarchar(35),
	@ID_NGUOI_TAO numeric(18, 0),
	@THOI_GIAN_TAO datetime,
	@LICH_SU_TRAO_DOI nvarchar(500),
	@ID_NGUOI_SUA_CUOI numeric(18, 0),
	@USER_NGUOI_SUA_CUOI nvarchar(35),
	@THOI_GIAN_SUA_CUOI datetime,
	@op_Error_Code int OUTPUT
/* DESCRIPTION:
|| Procedure nay dung de check 1 record trong bang cm_dm_tu_dien
|| 1. xem co lock duoc record nhu vay khong , 
||	a)thu lock neu khong lock duoc thi user khac dang lock 
||    b) neu khong co thi da bi xoa 
|| 2. xem co giong ban dau khong, neu khong giong thi da bi thay
*/
AS
BEGIN
/*********************************************
|| COMMON SETTINGS
**********************************************/
SET NOCOUNT ON
/**********************************************************
|| DECLARATION
***********************************************************/
	declare @v_ID numeric(18, 0)
	declare @v_MA_DON_HANG nvarchar(50)
	declare @v_USER_NV_DAT_HANG nvarchar(50)
	declare @v_ID_DON_VI numeric(18, 0)
	declare @v_TEN_DON_VI nvarchar(250)
	declare @v_DIEN_THOAI nvarchar(50)
	declare @v_HO_TEN_USER_DAT_HANG nvarchar(50)
	declare @v_THOI_GIAN_DAT_HANG datetime
	declare @v_ID_LOAI_DV_YEU_CAU numeric(18, 0)
	declare @v_TEN_LOAI_DICH_VU nvarchar(250)
	declare @v_ID_LOAI_YEU_CAU_CHA numeric(18, 0)
	declare @v_TEN_LOAI_YC_CHA nvarchar(250)
	declare @v_NOI_DUNG_DAT_HANG nvarchar(500)
	declare @v_ID_LOAI_THOI_GIAN_CAN_HOAN_THANH numeric(18, 0)
	declare @v_LOAI_THOI_GIAN_CAN_HOAN_THANH nvarchar(250)
	declare @v_PHAN_HOI_TU_DVMC nvarchar(500)
	declare @v_THOI_GIAN_HOAN_THANH datetime
	declare @v_ID_TRANG_THAI numeric(18, 0)
	declare @v_TRANG_THAI_YC nvarchar(250)
	declare @v_ID_DANH_GIA_TU_USER_DAT_HANG numeric(18, 0)
	declare @v_DANH_GIA_TU_USER_DAT_HANG nvarchar(250)
	declare @v_Y_KIEN_KHAC_TU_USER_DAT_HANG nvarchar(500)
	declare @v_ID_NGUOI_NHAN_DAT_HANG numeric(18, 0)
	declare @v_NGUOI_NHAN_DAT_HANG nvarchar(35)
	declare @v_ID_NGUOI_XU_LY numeric(18, 0)
	declare @v_NGUOI_XU_LY nvarchar(35)
	declare @v_ID_NGUOI_TAO numeric(18, 0)
	declare @v_THOI_GIAN_TAO datetime
	declare @v_LICH_SU_TRAO_DOI nvarchar(500)
	declare @v_ID_NGUOI_SUA_CUOI numeric(18, 0)
	declare @v_USER_NGUOI_SUA_CUOI nvarchar(35)
	declare @v_THOI_GIAN_SUA_CUOI datetime
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID = ID ,
	@v_MA_DON_HANG = MA_DON_HANG ,
	@v_USER_NV_DAT_HANG = USER_NV_DAT_HANG ,
	@v_ID_DON_VI = ID_DON_VI ,
	@v_TEN_DON_VI = TEN_DON_VI ,
	@v_DIEN_THOAI = DIEN_THOAI ,
	@v_HO_TEN_USER_DAT_HANG = HO_TEN_USER_DAT_HANG ,
	@v_THOI_GIAN_DAT_HANG = THOI_GIAN_DAT_HANG ,
	@v_ID_LOAI_DV_YEU_CAU = ID_LOAI_DV_YEU_CAU ,
	@v_TEN_LOAI_DICH_VU = TEN_LOAI_DICH_VU ,
	@v_ID_LOAI_YEU_CAU_CHA = ID_LOAI_YEU_CAU_CHA ,
	@v_TEN_LOAI_YC_CHA = TEN_LOAI_YC_CHA ,
	@v_NOI_DUNG_DAT_HANG = NOI_DUNG_DAT_HANG ,
	@v_ID_LOAI_THOI_GIAN_CAN_HOAN_THANH = ID_LOAI_THOI_GIAN_CAN_HOAN_THANH ,
	@v_LOAI_THOI_GIAN_CAN_HOAN_THANH = LOAI_THOI_GIAN_CAN_HOAN_THANH ,
	@v_PHAN_HOI_TU_DVMC = PHAN_HOI_TU_DVMC ,
	@v_THOI_GIAN_HOAN_THANH = THOI_GIAN_HOAN_THANH ,
	@v_ID_TRANG_THAI = ID_TRANG_THAI ,
	@v_TRANG_THAI_YC = TRANG_THAI_YC ,
	@v_ID_DANH_GIA_TU_USER_DAT_HANG = ID_DANH_GIA_TU_USER_DAT_HANG ,
	@v_DANH_GIA_TU_USER_DAT_HANG = DANH_GIA_TU_USER_DAT_HANG ,
	@v_Y_KIEN_KHAC_TU_USER_DAT_HANG = Y_KIEN_KHAC_TU_USER_DAT_HANG ,
	@v_ID_NGUOI_NHAN_DAT_HANG = ID_NGUOI_NHAN_DAT_HANG ,
	@v_NGUOI_NHAN_DAT_HANG = NGUOI_NHAN_DAT_HANG ,
	@v_ID_NGUOI_XU_LY = ID_NGUOI_XU_LY ,
	@v_NGUOI_XU_LY = NGUOI_XU_LY ,
	@v_ID_NGUOI_TAO = ID_NGUOI_TAO ,
	@v_THOI_GIAN_TAO = THOI_GIAN_TAO ,
	@v_LICH_SU_TRAO_DOI = LICH_SU_TRAO_DOI ,
	@v_ID_NGUOI_SUA_CUOI = ID_NGUOI_SUA_CUOI ,
	@v_USER_NGUOI_SUA_CUOI = USER_NGUOI_SUA_CUOI ,
	@v_THOI_GIAN_SUA_CUOI = THOI_GIAN_SUA_CUOI 
	 from V_GD_DAT_HANG with (updlock, rowlock, nowait)
	 where ID =  @ID
	 -- 1.b) khong co du lieu  => du lieu da bi xoa mat roi 
	if ( @v_ID is null )
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_DELETED()
		raiserror ('RECORD_DELETED',16,1)
		goto ERROR_HANDLER
	end
	/*2. so sanh cac gia tri co giong  nhau khong */	
	 if (
	isnull( @v_ID,dbo.C_Extrem_Number() ) <> isnull( @ID ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_MA_DON_HANG,dbo.C_Extrem_Str() ) <> isnull( @MA_DON_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_USER_NV_DAT_HANG,dbo.C_Extrem_Str() ) <> isnull( @USER_NV_DAT_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_DON_VI,dbo.C_Extrem_Number() ) <> isnull( @ID_DON_VI ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TEN_DON_VI,dbo.C_Extrem_Str() ) <> isnull( @TEN_DON_VI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_DIEN_THOAI,dbo.C_Extrem_Str() ) <> isnull( @DIEN_THOAI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_HO_TEN_USER_DAT_HANG,dbo.C_Extrem_Str() ) <> isnull( @HO_TEN_USER_DAT_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_THOI_GIAN_DAT_HANG,dbo.C_Extrem_Date() ) <> isnull( @THOI_GIAN_DAT_HANG ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_ID_LOAI_DV_YEU_CAU,dbo.C_Extrem_Number() ) <> isnull( @ID_LOAI_DV_YEU_CAU ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TEN_LOAI_DICH_VU,dbo.C_Extrem_Str() ) <> isnull( @TEN_LOAI_DICH_VU ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_LOAI_YEU_CAU_CHA,dbo.C_Extrem_Number() ) <> isnull( @ID_LOAI_YEU_CAU_CHA ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TEN_LOAI_YC_CHA,dbo.C_Extrem_Str() ) <> isnull( @TEN_LOAI_YC_CHA ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NOI_DUNG_DAT_HANG,dbo.C_Extrem_Str() ) <> isnull( @NOI_DUNG_DAT_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_LOAI_THOI_GIAN_CAN_HOAN_THANH,dbo.C_Extrem_Number() ) <> isnull( @ID_LOAI_THOI_GIAN_CAN_HOAN_THANH ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_LOAI_THOI_GIAN_CAN_HOAN_THANH,dbo.C_Extrem_Str() ) <> isnull( @LOAI_THOI_GIAN_CAN_HOAN_THANH ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_PHAN_HOI_TU_DVMC,dbo.C_Extrem_Str() ) <> isnull( @PHAN_HOI_TU_DVMC ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_THOI_GIAN_HOAN_THANH,dbo.C_Extrem_Date() ) <> isnull( @THOI_GIAN_HOAN_THANH ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_ID_TRANG_THAI,dbo.C_Extrem_Number() ) <> isnull( @ID_TRANG_THAI ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TRANG_THAI_YC,dbo.C_Extrem_Str() ) <> isnull( @TRANG_THAI_YC ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_DANH_GIA_TU_USER_DAT_HANG,dbo.C_Extrem_Number() ) <> isnull( @ID_DANH_GIA_TU_USER_DAT_HANG ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_DANH_GIA_TU_USER_DAT_HANG,dbo.C_Extrem_Str() ) <> isnull( @DANH_GIA_TU_USER_DAT_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_Y_KIEN_KHAC_TU_USER_DAT_HANG,dbo.C_Extrem_Str() ) <> isnull( @Y_KIEN_KHAC_TU_USER_DAT_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_NGUOI_NHAN_DAT_HANG,dbo.C_Extrem_Number() ) <> isnull( @ID_NGUOI_NHAN_DAT_HANG ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_NGUOI_NHAN_DAT_HANG,dbo.C_Extrem_Str() ) <> isnull( @NGUOI_NHAN_DAT_HANG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_NGUOI_XU_LY,dbo.C_Extrem_Number() ) <> isnull( @ID_NGUOI_XU_LY ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_NGUOI_XU_LY,dbo.C_Extrem_Str() ) <> isnull( @NGUOI_XU_LY ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_NGUOI_TAO,dbo.C_Extrem_Number() ) <> isnull( @ID_NGUOI_TAO ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_THOI_GIAN_TAO,dbo.C_Extrem_Date() ) <> isnull( @THOI_GIAN_TAO ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_LICH_SU_TRAO_DOI,dbo.C_Extrem_Str() ) <> isnull( @LICH_SU_TRAO_DOI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_NGUOI_SUA_CUOI,dbo.C_Extrem_Number() ) <> isnull( @ID_NGUOI_SUA_CUOI ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_USER_NGUOI_SUA_CUOI,dbo.C_Extrem_Str() ) <> isnull( @USER_NGUOI_SUA_CUOI ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_THOI_GIAN_SUA_CUOI,dbo.C_Extrem_Date() ) <> isnull( @THOI_GIAN_SUA_CUOI ,dbo.C_Extrem_Date() ) 
	)
	begin
		set @OP_ERROR_CODE = dbo.C_RECORD_UPDATED()
		raiserror ('RECORD_CHANGED',16,1)
		goto ERROR_HANDLER
	end
		return
	/********************************************************* 
	|| ERROR HANDLING
	*********************************************************/
	ERROR_HANDLER:
END
GO

