Option Strict On
Option Explicit On 

Namespace DBNames
    '********************** NAME OF TABLES
    Public Class TABLENAME
        Public Const HT_BACKUP_HISTORY As String = "HT_BACKUP_HISTORY"
        Public Const HT_BUSINESS_PROCESS_LOCK As String = "HT_BUSINESS_PROCESS_LOCK"
        Public Const HT_DON_VI As String = "HT_DON_VI"
        Public Const HT_NGUOI_SU_DUNG As String = "HT_NGUOI_SU_DUNG"
        Public Const HT_NHAT_KY_TRUY_NHAP As String = "HT_NHAT_KY_TRUY_NHAP"
        Public Const HT_NHOM_DUOC_QUYEN_TRUY_NHAP As String = "HT_NHOM_DUOC_QUYEN_TRUY_NHAP"
        Public Const HT_NHOM_NGUOI_SU_DUNG As String = "HT_NHOM_NGUOI_SU_DUNG"
        Public Const HT_PHAN_QUYEN As String = "HT_PHAN_QUYEN"
        Public Const HT_PHAN_QUYEN_CHO_NHOM As String = "HT_PHAN_QUYEN_CHO_NHOM"
        Public Const HT_QUYEN_TRUY_CAP_CSDL_CUA_USER As String = "HT_QUYEN_TRUY_CAP_CSDL_CUA_USER"
        Public Const HT_TEN_CSDL_CUA_DON_VI As String = "HT_TEN_CSDL_CUA_DON_VI"
        Public Const HT_THAM_SO_HE_THONG As String = "HT_THAM_SO_HE_THONG"
    End Class
    Public Class HT_BACKUP_HISTORY
        Public Const ID As String = "ID"
        Public Const NGUOI_BACKUP As String = "NGUOI_BACKUP"
        Public Const NGAY_BACKUP As String = "NGAY_BACKUP"
        Public Const NOI_LUU As String = "NOI_LUU"
        Public Const TEN_FILE As String = "TEN_FILE"
        Public Const GhI_CHU As String = "GhI_CHU"
    End Class
    '****************************
    Public Class HT_BUSINESS_PROCESS_LOCK
        Public Const LOCK_NAME As String = "LOCK_NAME"
        Public Const GRANTED_SYS_DATETIME As String = "GRANTED_SYS_DATETIME"
    End Class
  
    '****************************
    Public Class HT_NGUOI_SU_DUNG
        Public Const ID As String = "ID"
        Public Const TEN_TRUY_CAP As String = "TEN_TRUY_CAP"
        Public Const TEN As String = "TEN"
        Public Const MAT_KHAU As String = "MAT_KHAU"
        Public Const NGAY_TAO As String = "NGAY_TAO"
        Public Const NGUOI_TAO As String = "NGUOI_TAO"
        Public Const TRANG_THAI As String = "TRANG_THAI"
        Public Const ID_DON_VI As String = "ID_DON_VI"
        Public Const BUILT_IN_YN As String = "BUILT_IN_YN"
    End Class
    '****************************
    Public Class HT_NHAT_KY_TRUY_NHAP
        Public Const ID As String = "ID"
        Public Const ID_NGUOI_SU_DUNG As String = "ID_NGUOI_SU_DUNG"
        Public Const NHOM_TRUY_NHAP As String = "NHOM_TRUY_NHAP"
        Public Const THOI_GIAN_TRUY_NHAP As String = "THOI_GIAN_TRUY_NHAP"
        Public Const THOI_GIAN_LOGOUT As String = "THOI_GIAN_LOGOUT"
        Public Const DA_LOG_OUT_YN As String = "DA_LOG_OUT_YN"
        Public Const GHI_CHU As String = "GHI_CHU"
        Public Const MA_PHAN_HE As String = "MA_PHAN_HE"
    End Class

    '****************************
    Public Class CM_DM_LOAI_TD_LIST
        Public Const TRANG_THAI_GD As String = "TRANG_THAI_GD"
        Public Const LOAI_TRAI_PHIEU As String = "LOAI_TRAI_PHIEU"
        Public Const PHAN_QUYEN As String = "PHAN_QUYEN"
        Public Const LOAI_TRAI_CHU As String = "LOAI_TRAI_CHU"
        Public Const DON_VI_KY_HAN As String = "DON_VI_KY_HAN"
        Public Const LOAI_NHAC_NHAC_VIEC As String = "LOAI_NHAC_NHAC_VIEC"
        Public Const NGAN_HANG_DL_QUAN_LY_TK As String = "NGAN_HANG_DL_QUAN_LY_TK"
        Public Const LOAI_NGAY_LAM_VIEC As String = "LOAI_NGAY_LAM_VIEC"
        Public Const TRANG_THAI_DANH_MUC As String = "TRANG_THAI_DANH_MUC"
    End Class



End Namespace