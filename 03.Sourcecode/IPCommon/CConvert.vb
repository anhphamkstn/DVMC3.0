Public Class CConvert
    'Ham chuyen tu so sang xau khong quan tam toi Culture
    Public Shared Function Decimal2String(ByVal i_dcIn As Decimal) As String
        Dim v_objFormat As New System.Globalization.NumberFormatInfo
        v_objFormat.NumberDecimalSeparator = "."
        Return System.Convert.ToString(i_dcIn, v_objFormat)
    End Function

    'Hàm chuyển từ xâu ra số, Nếu là chuỗi rỗng thì trả về giá trị mặc định
    Public Shared Function Str2Number(ByVal i_strNumber As String _
                                , Optional ByVal i_DefaultValue As Decimal = 0) As Decimal
        If i_strNumber Is Nothing Or i_strNumber = "" Then
            Return i_DefaultValue
        Else
            Return CType(i_strNumber, Decimal)
        End If
    End Function

    'Chuyển từ Boolean sang Y_N
    Public Shared Function Boolean2YN(ByVal i_bBoolean As Boolean) As String
        If i_bBoolean Then
            Return "Y"
        Else
            Return "N"
        End If
    End Function

    'Chuyển từ Y_N sang Boolean
    Public Shared Function YN2Boolean(ByVal i_strYN As String) As Boolean
        If i_strYN = "Y" Then
            Return True
        Else
            If i_strYN = "N" Then
                Return False
            Else
                Debug.Assert(False)
                'Nếu chương trình bị dừng ở đây 
                'thì chuỗi truyền vào là không hợp lệ
            End If
        End If
    End Function


End Class
