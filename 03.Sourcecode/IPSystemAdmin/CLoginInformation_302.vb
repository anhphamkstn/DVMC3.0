Option Explicit On 
Option Strict On
Imports IP.Core.IPUserService
Public Class CLoginInformation_302
#Region "Nhiệm vụ của Class"
    '************************************************
    '* Chứa thông tin đăng nhập - dùng cho form login (f102)
    '*
    '************************************************
#End Region

    Public m_us_user As US_HT_NGUOI_SU_DUNG
    'Public m_strMaPhanHe As String

    Public Sub New(ByVal i_us_user As US_HT_NGUOI_SU_DUNG)
        MyBase.New()
        m_us_user = i_us_user

        ' m_strMaPhanHe = i_strMaPhanHe
    End Sub

End Class


