Imports System.Data.SqlClient
Public Interface IMakeSelectCmd
    Sub AddCondition(ByVal i_strTenTruong As String, _
        ByVal i_Value As Object, _
        ByVal i_KieuDuLieu As eKieuDuLieu, _
        ByVal i_KieuSoSanh As eKieuSoSanh)
    Function getConditionString() As String
    Function getParameters() As Collection
    Function getSelectCmd() As SqlCommand
End Interface

Public Interface ICondition
    Function GetConditionStr() As String
    Function GetParameter() As SqlParameter
End Interface

Public Enum eKieuSoSanh
    LonHon
    LonHonHoacBang
    NhoHon
    NhoHonHoacBang
    NhoHonHoacBangOrIsNull
    Bang
    CoChua
    BatDauBang
    KetThucBang
End Enum

Public Enum eKieuDuLieu
    KieuNumber
    KieuString
    KieuDate
End Enum