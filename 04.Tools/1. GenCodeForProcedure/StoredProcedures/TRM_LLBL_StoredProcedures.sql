SET NOCOUNT ON
GO
USE [TRM]
GO
CREATE PROCEDURE [dbo].[pr_V_GD_CHUNG_TU_ONLINE_Insert]
	@ID numeric(18, 0),
	@ID_HOP_DONG numeric(18, 0),
	@SO_HOP_DONG nvarchar(35),
	@ID_DON_VI_QUAN_LY numeric(18, 0),
	@NGAY_KY datetime,
	@DON_VI_THANH_TOAN nvarchar(250),
	@ID_GIANG_VIEN numeric(18, 0),
	@HO_TEN_GIANG_VIEN nvarchar(101),
	@COURSE_NAME nvarchar(250),
	@ID_MON_HOC numeric(18, 0),
	@TEN_MON nvarchar(250),
	@SO_LUONG_SV numeric(4, 0),
	@NGAY_BAT_DAU datetime,
	@NGAY_KET_THUC datetime,
	@ID_TRANG_THAI_CT numeric(18, 0),
	@TRANG_THAI_HD nvarchar(250),
	@ID_TT_COURSE numeric(18, 0),
	@NGAY_TAO_CT datetime,
	@ID_NGUOI_LAP numeric(18, 0),
	@DEADLINE_TT datetime,
	@NGAY_CHUYEN_CT datetime,
	@NGAY_THANH_TOAN datetime,
	@GHI_CHU nvarchar(250),
	@NOI_DUNG_CHUNG_TU nvarchar(500),
	@TONG_TIEN numeric(18, 3),
	@MA_NHOM numeric(4, 0)
AS
INSERT [dbo].[V_GD_CHUNG_TU_ONLINE]
(
	[ID],
	[ID_HOP_DONG],
	[SO_HOP_DONG],
	[ID_DON_VI_QUAN_LY],
	[NGAY_KY],
	[DON_VI_THANH_TOAN],
	[ID_GIANG_VIEN],
	[HO_TEN_GIANG_VIEN],
	[COURSE_NAME],
	[ID_MON_HOC],
	[TEN_MON],
	[SO_LUONG_SV],
	[NGAY_BAT_DAU],
	[NGAY_KET_THUC],
	[ID_TRANG_THAI_CT],
	[TRANG_THAI_HD],
	[ID_TT_COURSE],
	[NGAY_TAO_CT],
	[ID_NGUOI_LAP],
	[DEADLINE_TT],
	[NGAY_CHUYEN_CT],
	[NGAY_THANH_TOAN],
	[GHI_CHU],
	[NOI_DUNG_CHUNG_TU],
	[TONG_TIEN],
	[MA_NHOM]
)
VALUES
(
	@ID,
	@ID_HOP_DONG,
	@SO_HOP_DONG,
	@ID_DON_VI_QUAN_LY,
	@NGAY_KY,
	@DON_VI_THANH_TOAN,
	@ID_GIANG_VIEN,
	@HO_TEN_GIANG_VIEN,
	@COURSE_NAME,
	@ID_MON_HOC,
	@TEN_MON,
	@SO_LUONG_SV,
	@NGAY_BAT_DAU,
	@NGAY_KET_THUC,
	@ID_TRANG_THAI_CT,
	@TRANG_THAI_HD,
	@ID_TT_COURSE,
	@NGAY_TAO_CT,
	@ID_NGUOI_LAP,
	@DEADLINE_TT,
	@NGAY_CHUYEN_CT,
	@NGAY_THANH_TOAN,
	@GHI_CHU,
	@NOI_DUNG_CHUNG_TU,
	@TONG_TIEN,
	@MA_NHOM
)
GO

-- //// Try-to-lock-and-compare Stored procedure.
CREATE PROCEDURE [dbo].[pr_V_GD_CHUNG_TU_ONLINE_IsUpdatable]
	@ID numeric(18, 0),
	@ID_HOP_DONG numeric(18, 0),
	@SO_HOP_DONG nvarchar(35),
	@ID_DON_VI_QUAN_LY numeric(18, 0),
	@NGAY_KY datetime,
	@DON_VI_THANH_TOAN nvarchar(250),
	@ID_GIANG_VIEN numeric(18, 0),
	@HO_TEN_GIANG_VIEN nvarchar(101),
	@COURSE_NAME nvarchar(250),
	@ID_MON_HOC numeric(18, 0),
	@TEN_MON nvarchar(250),
	@SO_LUONG_SV numeric(4, 0),
	@NGAY_BAT_DAU datetime,
	@NGAY_KET_THUC datetime,
	@ID_TRANG_THAI_CT numeric(18, 0),
	@TRANG_THAI_HD nvarchar(250),
	@ID_TT_COURSE numeric(18, 0),
	@NGAY_TAO_CT datetime,
	@ID_NGUOI_LAP numeric(18, 0),
	@DEADLINE_TT datetime,
	@NGAY_CHUYEN_CT datetime,
	@NGAY_THANH_TOAN datetime,
	@GHI_CHU nvarchar(250),
	@NOI_DUNG_CHUNG_TU nvarchar(500),
	@TONG_TIEN numeric(18, 3),
	@MA_NHOM numeric(4, 0),
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
	declare @v_ID_HOP_DONG numeric(18, 0)
	declare @v_SO_HOP_DONG nvarchar(35)
	declare @v_ID_DON_VI_QUAN_LY numeric(18, 0)
	declare @v_NGAY_KY datetime
	declare @v_DON_VI_THANH_TOAN nvarchar(250)
	declare @v_ID_GIANG_VIEN numeric(18, 0)
	declare @v_HO_TEN_GIANG_VIEN nvarchar(101)
	declare @v_COURSE_NAME nvarchar(250)
	declare @v_ID_MON_HOC numeric(18, 0)
	declare @v_TEN_MON nvarchar(250)
	declare @v_SO_LUONG_SV numeric(4, 0)
	declare @v_NGAY_BAT_DAU datetime
	declare @v_NGAY_KET_THUC datetime
	declare @v_ID_TRANG_THAI_CT numeric(18, 0)
	declare @v_TRANG_THAI_HD nvarchar(250)
	declare @v_ID_TT_COURSE numeric(18, 0)
	declare @v_NGAY_TAO_CT datetime
	declare @v_ID_NGUOI_LAP numeric(18, 0)
	declare @v_DEADLINE_TT datetime
	declare @v_NGAY_CHUYEN_CT datetime
	declare @v_NGAY_THANH_TOAN datetime
	declare @v_GHI_CHU nvarchar(250)
	declare @v_NOI_DUNG_CHUNG_TU nvarchar(500)
	declare @v_TONG_TIEN numeric(18, 3)
	declare @v_MA_NHOM numeric(4, 0)
	 -- 1.a) neu khong lock duoc => ai do dang dung du lieu
	select 
	@v_ID = ID ,
	@v_ID_HOP_DONG = ID_HOP_DONG ,
	@v_SO_HOP_DONG = SO_HOP_DONG ,
	@v_ID_DON_VI_QUAN_LY = ID_DON_VI_QUAN_LY ,
	@v_NGAY_KY = NGAY_KY ,
	@v_DON_VI_THANH_TOAN = DON_VI_THANH_TOAN ,
	@v_ID_GIANG_VIEN = ID_GIANG_VIEN ,
	@v_HO_TEN_GIANG_VIEN = HO_TEN_GIANG_VIEN ,
	@v_COURSE_NAME = COURSE_NAME ,
	@v_ID_MON_HOC = ID_MON_HOC ,
	@v_TEN_MON = TEN_MON ,
	@v_SO_LUONG_SV = SO_LUONG_SV ,
	@v_NGAY_BAT_DAU = NGAY_BAT_DAU ,
	@v_NGAY_KET_THUC = NGAY_KET_THUC ,
	@v_ID_TRANG_THAI_CT = ID_TRANG_THAI_CT ,
	@v_TRANG_THAI_HD = TRANG_THAI_HD ,
	@v_ID_TT_COURSE = ID_TT_COURSE ,
	@v_NGAY_TAO_CT = NGAY_TAO_CT ,
	@v_ID_NGUOI_LAP = ID_NGUOI_LAP ,
	@v_DEADLINE_TT = DEADLINE_TT ,
	@v_NGAY_CHUYEN_CT = NGAY_CHUYEN_CT ,
	@v_NGAY_THANH_TOAN = NGAY_THANH_TOAN ,
	@v_GHI_CHU = GHI_CHU ,
	@v_NOI_DUNG_CHUNG_TU = NOI_DUNG_CHUNG_TU ,
	@v_TONG_TIEN = TONG_TIEN ,
	@v_MA_NHOM = MA_NHOM 
	 from V_GD_CHUNG_TU_ONLINE with (updlock, rowlock, nowait)
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
	isnull( @v_ID_HOP_DONG,dbo.C_Extrem_Number() ) <> isnull( @ID_HOP_DONG ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_SO_HOP_DONG,dbo.C_Extrem_Str() ) <> isnull( @SO_HOP_DONG ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_DON_VI_QUAN_LY,dbo.C_Extrem_Number() ) <> isnull( @ID_DON_VI_QUAN_LY ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_NGAY_KY,dbo.C_Extrem_Date() ) <> isnull( @NGAY_KY ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_DON_VI_THANH_TOAN,dbo.C_Extrem_Str() ) <> isnull( @DON_VI_THANH_TOAN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_GIANG_VIEN,dbo.C_Extrem_Number() ) <> isnull( @ID_GIANG_VIEN ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_HO_TEN_GIANG_VIEN,dbo.C_Extrem_Str() ) <> isnull( @HO_TEN_GIANG_VIEN ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_COURSE_NAME,dbo.C_Extrem_Str() ) <> isnull( @COURSE_NAME ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_MON_HOC,dbo.C_Extrem_Number() ) <> isnull( @ID_MON_HOC ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TEN_MON,dbo.C_Extrem_Str() ) <> isnull( @TEN_MON ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_SO_LUONG_SV,dbo.C_Extrem_Number() ) <> isnull( @SO_LUONG_SV ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_NGAY_BAT_DAU,dbo.C_Extrem_Date() ) <> isnull( @NGAY_BAT_DAU ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_NGAY_KET_THUC,dbo.C_Extrem_Date() ) <> isnull( @NGAY_KET_THUC ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_ID_TRANG_THAI_CT,dbo.C_Extrem_Number() ) <> isnull( @ID_TRANG_THAI_CT ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_TRANG_THAI_HD,dbo.C_Extrem_Str() ) <> isnull( @TRANG_THAI_HD ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_ID_TT_COURSE,dbo.C_Extrem_Number() ) <> isnull( @ID_TT_COURSE ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_NGAY_TAO_CT,dbo.C_Extrem_Date() ) <> isnull( @NGAY_TAO_CT ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_ID_NGUOI_LAP,dbo.C_Extrem_Number() ) <> isnull( @ID_NGUOI_LAP ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_DEADLINE_TT,dbo.C_Extrem_Date() ) <> isnull( @DEADLINE_TT ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_NGAY_CHUYEN_CT,dbo.C_Extrem_Date() ) <> isnull( @NGAY_CHUYEN_CT ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_NGAY_THANH_TOAN,dbo.C_Extrem_Date() ) <> isnull( @NGAY_THANH_TOAN ,dbo.C_Extrem_Date() )  OR 
	isnull( @v_GHI_CHU,dbo.C_Extrem_Str() ) <> isnull( @GHI_CHU ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_NOI_DUNG_CHUNG_TU,dbo.C_Extrem_Str() ) <> isnull( @NOI_DUNG_CHUNG_TU ,dbo.C_Extrem_Str() )  OR 
	isnull( @v_TONG_TIEN,dbo.C_Extrem_Number() ) <> isnull( @TONG_TIEN ,dbo.C_Extrem_Number() )  OR 
	isnull( @v_MA_NHOM,dbo.C_Extrem_Number() ) <> isnull( @MA_NHOM ,dbo.C_Extrem_Number() ) 
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

