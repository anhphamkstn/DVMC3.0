Imports System.Data.SqlClient

Public Class CDateCondition
    Implements ICondition
    Private m_strFieldName As String
    Private m_Value As DateTime
    Private m_LoaiSoSanh As eKieuSoSanh

    Public Sub New(ByVal i_strFieldName As String, ByVal i_Value As DateTime, ByVal i_LoaiSoSanh As eKieuSoSanh)
        m_strFieldName = i_strFieldName
        m_Value = i_Value
        m_LoaiSoSanh = i_LoaiSoSanh
    End Sub

    Function GetConditionStr() As String Implements ICondition.GetConditionStr
        Select Case m_LoaiSoSanh
            Case eKieuSoSanh.Bang
                Return " " & m_strFieldName & " = @" & m_strFieldName
            Case eKieuSoSanh.LonHonHoacBang
                Return " " & m_strFieldName & " >= @" & m_strFieldName
            Case eKieuSoSanh.LonHon
                Return " " & m_strFieldName & " > @" & m_strFieldName
            Case eKieuSoSanh.NhoHon
                Return " " & m_strFieldName & " < @" & m_strFieldName
            Case eKieuSoSanh.NhoHonHoacBang
                Return " " & m_strFieldName & " <= @" & m_strFieldName
            Case eKieuSoSanh.NhoHonHoacBangOrIsNull
                Return " (" & m_strFieldName & " <= @" & m_strFieldName _
                        & " or " & m_strFieldName & " is null )"
            Case Else
                Debug.Assert(False, "Kieu ngay khong cung loai so sanh nay trong cdateCondition - tuanqt")
        End Select
    End Function
    Function GetParameter() As SqlParameter Implements ICondition.GetParameter
        Dim v_para As New SqlParameter
        v_para.ParameterName = "@" & m_strFieldName
        v_para.SqlDbType = SqlDbType.DateTime
        v_para.Value = m_Value
        v_para.Direction = ParameterDirection.Input
        Return v_para
    End Function
End Class
