Option Explicit On 
Option Strict On

Public Class CDateTime

    Private Shared m_obj_culture As New System.Globalization.CultureInfo("vi-VN", True)

    Public Shared Function GetDateFormatString() As String
        Return "dd/MM/yyyy"
    End Function
    Public Shared Function isValidDateString(ByVal i_strDate As String, _
                        Optional ByVal i_strFormat As String = "dd/MM/yyyy") As Boolean
        Try
            If i_strFormat <> "" Then
                Str2Date(i_strDate, i_strFormat)
            Else
                Str2Date(i_strDate)
            End If
            'chuoi ngay hop le tra ve true
            Return True
        Catch V_E As System.Exception
            'Co exception => chuoi ngay khong hop le
            Return False
        End Try

    End Function

    'Chuyển từ xâu sang ngày với định dạng cho trước
    Public Shared Function Str2Date(ByVal i_strDate As String _
                    , Optional ByVal i_strFormat As String = "dd/MM/yyyy") As DateTime
        Dim v_format As New System.Globalization.CultureInfo("vi-VN")
        Dim v_myDateTime As System.DateTime

        'Neu khong truyen vao format thi lay format ngam dinh
        Dim v_strFormat As String
        If i_strFormat = "" Then
            v_strFormat = GetDateFormatString()
        Else
            v_strFormat = i_strFormat
        End If

        v_myDateTime = System.DateTime.ParseExact(i_strDate, _
                    v_strFormat, _
                    v_format)
        Return v_myDateTime
    End Function
    ' chuyển sang sâu ngày vn
    Public Shared Function Date2Str_VNFormat(ByVal i_date As DateTime) As String
        Return Format(i_date, GetDateFormatString)
    End Function
    '
    Public Shared Function Date_fromUs_toDisplayStr(ByVal i_date As DateTime) As String
        If i_date = IPConstants.c_DefaultDate Then
            Return String.Empty
        Else
            Return Date2Str_VNFormat(i_date)
        End If
    End Function
End Class
