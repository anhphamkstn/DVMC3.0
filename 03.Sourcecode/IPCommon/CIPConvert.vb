Public Class CIPConvert
    'Private Shared m_obj_culture As New System.Globalization.CultureInfo("vi-VN")
    'Private Shared m_obj_culture As New System.Globalization.CultureInfo("en_US")
    Private Shared m_obj_culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentCulture

#Region "Convert from Boolean to YN and reversed"
    Public Shared Function ToYNString(ByVal i_bBoolean As Boolean) As String
        If i_bBoolean Then
            Return "Y"
        Else
            Return "N"
        End If
    End Function

    Public Shared Function ToYNString(ByVal i_obj_Boolean As Object) As String
        Debug.Assert(TypeOf (i_obj_Boolean) Is Boolean, "Doi tuong truyen vao ham ToYNString phai co kieu Boolean")
        If CType(i_obj_Boolean, Boolean) Then
            Return "Y"
        Else
            Return "N"
        End If
    End Function

    Public Shared Function ToBoolean(ByVal i_str_YN As String) As Boolean
        Select Case i_str_YN
            Case "Y"
                Return True
            Case "N"
                Return False
            Case Else
                Debug.Assert(False, "Xau truyen vao ham ToBoolean cua IPConvert khong hop le - tuanqt")
        End Select
    End Function

    Public Shared Function ToBoolean(ByVal i_obj_YN As Object) As Boolean
        Debug.Assert(Not i_obj_YN Is Nothing, "doi tuong truyen vao CIPConvert.ToBoolean phai khac nothing - tuanqt")
        Debug.Assert(TypeOf (i_obj_YN) Is String, "Doi tuong truyen vao CIPConvert.ToBoolean phai co kieu string - tuanqt")
        Dim v_str_temp = CType(i_obj_YN, String)
        Select Case v_str_temp
            Case "Y"
                Return True
            Case "N"
                Return False
            Case Else
                Debug.Assert(False, "Xau truyen vao ham ToBoolean cua IPConvert khong hop le - tuanqt")
        End Select
    End Function
#End Region

#Region "Convert to String from another type"
    Public Shared Function ToStrInQuery(ByVal i_dc_Input As Decimal) As String
        Dim v_objFormat As New System.Globalization.NumberFormatInfo
        v_objFormat.NumberDecimalSeparator = "."
        Return System.Convert.ToString(i_dc_Input, v_objFormat)
    End Function

    Public Shared Function ToStr(ByVal i_dc_Input As Decimal) As String
        Return Convert.ToString(i_dc_Input, m_obj_culture.NumberFormat)
    End Function

    Public Shared Function ToStr(ByVal i_dc_input As Decimal, ByVal i_str_format As String) As String
        Return Convert.ToString(i_dc_input, m_obj_culture.NumberFormat).Format(m_obj_culture.NumberFormat, "{0:" & i_str_format & "}", i_dc_input)
    End Function

    Public Shared Function ToStr(ByVal i_dat_Input As DateTime) As String
        Return Convert.ToString(i_dat_Input, m_obj_culture.DateTimeFormat).Format("{0:dd/MM/yyyy}", i_dat_Input)
    End Function

    Public Shared Function ToStr(ByVal i_dat_Input As DateTime, ByVal i_str_format As String) As String
        Return Convert.ToString(i_dat_Input, m_obj_culture.DateTimeFormat).Format("{0:" & i_str_format & "}", i_dat_Input)
    End Function

    Public Shared Function ToStr(ByVal i_obj_Input As Object) As String
        Debug.Assert(Not i_obj_Input Is Nothing, "Tham so truyen vao ham ToStr phai khac nothing")
        Select Case i_obj_Input.GetType.ToString()
            Case "System.Decimal"
                Return ToStr(CType(i_obj_Input, Decimal))
            Case "System.DateTime"
                Return ToStr(CType(i_obj_Input, DateTime))
            Case Else
                Return CType(i_obj_Input, String)
        End Select
    End Function

    Public Shared Function ToStr(ByVal i_obj_Input As Object, ByVal i_str_format As String) As String
        Debug.Assert(Not i_obj_Input Is Nothing, "Tham so truyen vao ham ToStr phai khac nothing")
        Debug.Assert(Not i_obj_Input Is Nothing, "Tham so truyen vao ham ToStr phai khac nothing")
        Select Case i_obj_Input.GetType.ToString()
            Case "System.Decimal"
                Return ToStr(CType(i_obj_Input, Decimal), i_str_format)
            Case "System.DateTime"
                Return ToStr(CType(i_obj_Input, DateTime), i_str_format)
            Case Else
                Return CType(i_obj_Input, String)
        End Select
    End Function
#End Region

#Region "Convert to Decimal from another type"
    Public Shared Function ToDecimal(ByVal i_str_input As String) As Decimal
        Return Convert.ToDecimal(i_str_input, m_obj_culture.NumberFormat)
    End Function

    Public Shared Function ToDecimal(ByVal i_obj_input As Object) As Decimal
        Debug.Assert(Not i_obj_input Is Nothing, "Doi tuong truyen vao ham ToDecimal phai khac nothing - tuanqt")
        Return Convert.ToDecimal(i_obj_input, m_obj_culture.NumberFormat)
    End Function

    Public Shared Function is_valid_number(ByVal i_str_input As String) As Boolean
        Try
            ToDecimal(i_str_input)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function is_valid_number(ByVal i_obj_input As Object) As Boolean
        Try
            ToDecimal(i_obj_input)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function get_default_dec_format() As String
        Return "#,###"
    End Function
#End Region

#Region "Convert to Datetime from another type"
    Public Shared Function ToDatetime(ByVal i_str_date As String) As DateTime
        Dim v_myDateTime As System.DateTime
        'Neu khong truyen vao format thi lay format ngam dinh
        Dim v_strFormat As String = m_obj_culture.DateTimeFormat.ShortDatePattern
        v_myDateTime = System.DateTime.ParseExact(i_str_date, _
                    get_default_date_format(), _
                    m_obj_culture.DateTimeFormat)
        Return v_myDateTime
    End Function

    Public Shared Function ToDatetime(ByVal i_str_date As String, ByVal i_str_format As String) As DateTime
        Dim v_myDateTime As System.DateTime
        'Neu truyen vao format thi lay format 
        Dim v_strFormat As String = m_obj_culture.DateTimeFormat.ShortDatePattern
        v_myDateTime = System.DateTime.ParseExact(i_str_date, _
                    i_str_format, _
                    m_obj_culture)
        Return v_myDateTime
    End Function

    Public Shared Function ToDatetime(ByVal i_obj_date As Object) As DateTime
        Debug.Assert(Not i_obj_date Is Nothing, "Doi tuong truyen vao ham ToDecimal phai khac nothing - tuanqt")
        Debug.Assert(TypeOf (i_obj_date) Is String, "Doi tuong truyen vao ham ToDate phai co kieu string - tuanqt")
        Dim v_str_temp_date As String = CType(i_obj_date, String)
        Return ToDatetime(v_str_temp_date)
    End Function

    Public Shared Function ToDatetime(ByVal i_obj_date As Object, ByVal i_str_format As String) As DateTime
        Debug.Assert(Not i_obj_date Is Nothing, "Doi tuong truyen vao ham ToDecimal phai khac nothing - tuanqt")
        Debug.Assert(TypeOf (i_obj_date) Is String, "Doi tuong truyen vao ham ToDate phai co kieu string - tuanqt")
        Dim v_str_temp_date As String = CType(i_obj_date, String)
        Return ToDatetime(v_str_temp_date, i_str_format)
    End Function

    Public Shared Function is_valid_datetime(ByVal i_str_input As String) As Boolean
        Try
            ToDatetime(i_str_input)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function is_valid_datetime(ByVal i_obj_input As Object) As Boolean
        Try
            ToDatetime(i_obj_input)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function is_valid_datetime(ByVal i_obj_input As Object, ByVal i_str_format As String) As Boolean
        Try
            ToDatetime(i_obj_input, i_str_format)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function Date_fromUs_toDisplayStr(ByVal i_date As DateTime) As String
        If i_date = IPConstants.c_DefaultDate Then
            Return String.Empty
        Else
            Return ToStr(i_date)
        End If
    End Function

    Public Shared Function get_default_date_format() As String
        Return "dd/MM/yyyy"
    End Function
#End Region

#Region " Encode & Deciphering "
    Private Shared m_str_header As String = "usvndp"
    Private Shared m_str_footer As String = "iejrjk"
    Public Shared Function Encoding(ByVal i_str As String) As String
        Dim o_str_encode As String = ""
        Dim v_i As Integer = 0
        Dim v_dc_len As Integer = Len(i_str)
        Dim v_dc_str As Integer = 0
        o_str_encode = m_str_header
        For v_i = 1 To v_dc_len Step 1
            v_dc_str = Convert.ToInt16(Convert.ToChar(Mid(i_str, v_i, 1)))
            v_dc_str = v_dc_str + v_i
            o_str_encode = o_str_encode + Convert.ToString(Convert.ToChar(v_dc_str))
        Next
        o_str_encode = o_str_encode + m_str_footer
        Return o_str_encode
    End Function
    Public Shared Function Deciphering(ByVal i_str As String) As String
        Dim o_str_deciphering As String = ""
        Dim v_i As Integer = 0
        Dim v_dc_str As Integer = 0
        i_str = Mid(i_str, 1, Len(i_str) - Len(m_str_footer))
        i_str = i_str.Substring(Len(m_str_header))
        Dim v_dc_len As Integer = Len(i_str)
        For v_i = 1 To v_dc_len Step 1
            v_dc_str = Convert.ToInt16(Convert.ToChar(Mid(i_str, v_i, 1)))
            v_dc_str = v_dc_str - v_i
            o_str_deciphering = o_str_deciphering + Convert.ToString(Convert.ToChar(v_dc_str))
        Next
        Return o_str_deciphering
    End Function
    Public Shared Function Encoding(ByVal i_dc As Decimal) As String
        Dim o_str_encoding As String = ""
        o_str_encoding = Encoding(toStr(i_dc))
        Return o_str_encoding
    End Function
    Public Shared Function Encoding(ByVal i_dat As DateTime) As String
        Dim o_str_encoding As String = ""
        o_str_encoding = Encoding(toStr(i_dat))
        Return o_str_encoding
    End Function
#End Region

End Class
