Option Explicit On
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPUserService
Imports IP.Core.IPData

'Imports eSchool.eSchoolData
'Imports eSchool.eSchoolUserService

#Region "Nhiệm vụ của Class"
'************************************************************************
'* Phục vụ lấy dữ liệu đặc trưng cho ứng dụng
'*
'************************************************************************
#End Region

Public Class CAppContext_201
    Implements IControlerControl

#Region "Variables"
    Private Shared m_us_user As US_HT_NGUOI_SU_DUNG
    Private Shared m_strRunMode As String
    Private Shared m_dsDecentralization As New DS_HT_PHAN_QUYEN_DETAIL
#End Region

#Region "Public interface"
    Public Shared Sub LoadDecentralizationByUserLogin()
        Dim v_us As New US_HT_PHAN_QUYEN_DETAIL
        m_dsDecentralization.Clear()
        v_us.FillDatasetByUserLogin(m_dsDecentralization, CAppContext_201.getCurrentUserName())
    End Sub
    Public Function CanUseControl(ByVal ip_strFormName As String, ByVal ip_strControlName As String, ByVal ip_strControlType As String) As Boolean Implements IPCommon.IControlerControl.CanUseControl
        Return Me.CanUseThisControl(ip_strFormName, ip_strControlName, ip_strControlType)
    End Function

    Public Shared Function IsHavingQuyen(ByVal i_str_ma_quyen As String) As Boolean
        Return US_HT_NGUOI_SU_DUNG.IsHavingMA_QUYEN( _
           CAppContext_201.getCurrentUserID() _
           , i_str_ma_quyen)

    End Function



    Public Shared Sub InitializeContext(ByVal i_LoginInfo As CLoginInformation_302)
        '*****************************************************************
        '* Init context 
        '* 1. các giá trị thường dùng trong hệ thống
        '* 2. load phân quyền hệ thống về 
        '* 3. Các biến môi trường khác
        '****************************************************************
        '* 1. các giá trị thường dùng trong hệ thống
        '        Debug.Assert(m_strCurrentUserName <> "")
        Try

            m_us_user = i_LoginInfo.m_us_user
            '* 2. load phân quyền hệ thống về 
            '* 3. Các biến môi trường khác
            Dim v_configReader As New System.Configuration.AppSettingsReader
            m_strRunMode = v_configReader.GetValue("RUN_MODE", IPConstants.C_StringType).ToString()
            v_configReader = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function getCurentDate() As DateTime
        '*****************************************************************
        '*  Gọi để lấy ngày hiện tại
        '***********************************************************************
        Return System.DateTime.Now.Date
    End Function

    Public Shared Function getCurrentUserName() As String
        Return m_us_user.strTEN_TRUY_CAP
    End Function

    Public Shared Function getCurrentUser() As String
        Return m_us_user.strTEN
    End Function

    Public Shared Function getCurrentUserID() As Decimal
        Return m_us_user.dcID
    End Function

    Public Shared Function getRunMode() As String
        Return m_strRunMode
    End Function

    Public Shared Function getAppPath() As String
        Return AppDomain.CurrentDomain.SetupInformation.ApplicationBase
    End Function

    Public Shared Function get_DefaultReportRootPath() As String
        Dim v_strRootPath As String
        v_strRootPath = Application.StartupPath
        'v_strRootPath += "\..\.."
        v_strRootPath += "\Reports"
        Return v_strRootPath
    End Function

    Public Shared Function checkLicense() As Boolean

    End Function
#End Region


#Region "Private Methods"
    Private Shared Sub LoadDecentralization(ByVal ip_dsDecentralization As DS_HT_PHAN_QUYEN_DETAIL)
        m_dsDecentralization = ip_dsDecentralization
    End Sub

    Private Shared Function CanUseThisControl( _
                ByVal ip_strFormName As String _
                , ByVal ip_strControlName As String _
                , ByVal ip_strControlType As String) As Boolean
        If (m_dsDecentralization.HT_PHAN_QUYEN_DETAIL.Select("FORM_NAME = '" & ip_strFormName & "' AND CONTROL_NAME ='" & ip_strControlName & "'").Length > 0) Then
            Return True
        End If
        Return False
    End Function
#End Region
End Class
Public Class PHAN_QUYEN
    Public Const QLHT_NHOM_NGUOI_DUNG As String = "QLHT_nhom_nguoi_dung"
    Public Const QLHT_NGUOI_SU_DUNG As String = "QLHT_nguoi_su_dung"
    Public Const QLHT_NGAY_LAM_VIEC As String = "QLHT_ngay_lam_viec"
    Public Const QLHT_THAM_SO_HE_THONG As String = "QLHT_tham_so_he_thong"
    Public Const QLHT_THAM_SO_NHAC_VIEC As String = "QLHT_tham_so_nhac_viec"
    Public Const QLHT_LICH_SU_TRUY_CAP As String = "QLHT_lich_su_truy_cap"
    Public Const QLTD_TU_DIEN As String = "QLTD_tu_dien"
    Public Const QLDM_DS_QLHT As String = "QLDM_ds_qlht"
    Public Const QLDM_CAU_HOI As String = "QLDM_Cau_Hoi"
    Public Const QLDM_NGUOI_DAI_DIEN As String = "QLDM_Nguoi_Dai_Dien"
    Public Const QLDM_LICH_SU_CAU_TRA_LOI As String = "QLDM_Lich_Su_Cau_Tra_Loi"
    Public Const QLDM_DUOI_SO_VAO_SO As String = "QLDM_duoi_so_vao_so"
    Public Const QLNV_BLACKLIST As String = "QLNV_BlackList"
    Public Const QLDM_TIM_KIEM_CAU_HOI As String = "QLDM_TimKiemCauHoi"
    Public Const QLNV_XU_LY_NOI_BO As String = "QLNV_Xu_Ly_Noi_Bo"
    Public Const QLNV_GOI_LAI_CHO_HOC_VIEN As String = "QLNV_Goi_Lai_Cho_Hoc_Vien"
    Public Const QLNV_HOC_VIEN_GOI_VAO As String = "QLNV_Hoc_vien_goi_vao"
    Public Const QLNV_NHAP_DAT_HANG_MOI As String = "QLNV_Nhap_Dat_Hang_Moi"
    Public Const QLNV_DS_DAT_HANG As String = "QLNV_DS_Dat_Hang_Moi"
    Public Const QLNV_GT_DM_GIAO_DICH As String = "QLNV_GT_dm_giao_dich"
    Public Const QLNV_GT_BAO_CAO As String = "QLNV_GT_bao_cao"
    Public Const QLNV_IMPORT_CHUNG_NHAN_CHUAN_TOPICA As String = "QLNV_Import_chung_nhan_chuan_Topica"
    Public Const QLNV_IMPORT_CHUNG_NHAN_HD_NGOAI_KHOA_HOC_TAP As String = "QLNV_Import_chung_nhan_hd_ngoai_khoa_hoc_tap"
    Public Const QLNV_CNLS_THOA_THUAN As String = "QLNV_cnls_thoa_thuan"
    Public Const QLNV_TRA_LAI As String = "QLNV_tra_lai"
    Public Const BC_DANH_SACH_YEU_CAU As String = "BC_Danh_Sach_Yeu_Cau"
    Public Const BC_DS_XU_LY_NOI_BO As String = "BC_Danh_Sach_Xu_Ly_Noi_Bo"
    Public Const BC_DS_CONTACT_IMPORT_TRUNG As String = "BC_Ds_Contact_Import_Trung"
    Public Const BC_TK_TY_LE_TREN_L2_THEO_NGUON As String = "BC_Tk_Ty_Le_Tren_L2_Theo_Nguon"
    Public Const BC_NGHIEM_THU_CONTACT_L5B_L8 As String = "BC_Nghiem_Thu_Contact_L5BL8"
    Public Const LIC_GIOI_THIEU As String = "Gioi_thieu"
End Class
