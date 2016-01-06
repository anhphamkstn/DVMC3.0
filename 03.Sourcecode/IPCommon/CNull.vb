Imports IP.Core.IPCommon

Public Class CNull
    Public Shared Function RowNVLDecimal(ByVal i_DataRow As DataRow, ByVal i_FieldName As String, _
             Optional ByVal i_DefaultValue As Decimal = IPConstants.c_DefaultDecimal) As Decimal
        If i_DataRow.IsNull(i_FieldName) Then
            Return i_DefaultValue
        Else
            Return CType(i_DataRow.Item(i_FieldName), Decimal)
        End If
    End Function

    Public Shared Function RowNVLDate(ByVal i_DataRow As DataRow, ByVal i_FieldName As String, _
            Optional ByVal i_DefaultValue As Date = IPConstants.c_DefaultDate) As Date
        If i_DataRow.IsNull(i_FieldName) Then
            Return i_DefaultValue
        Else
            Return CType(i_DataRow.Item(i_FieldName), Date)
        End If
    End Function

    Public Shared Function RowNVLString(ByVal i_DataRow As DataRow, ByVal i_FieldName As String, _
            Optional ByVal i_DefaultValue As String = IPConstants.c_DefaultString) As String
        If i_DataRow.IsNull(i_FieldName) Then
            Return i_DefaultValue
        Else
            Return CType(i_DataRow.Item(i_FieldName), String)
        End If
    End Function

    Public Shared Function NVLDecimal(ByVal i_Object As Object, _
            Optional ByVal i_DefaultValue As Decimal = IPConstants.c_DefaultDecimal) As Decimal
        If i_Object Is Nothing Then
            Return i_DefaultValue
        Else
            Return CType(i_Object, Decimal)
        End If
    End Function

    Public Shared Function NVLDate(ByVal i_Object As Object, _
            Optional ByVal i_DefaultValue As Date = IPConstants.c_DefaultDate) As Date
        If i_Object Is Nothing Then
            Return i_DefaultValue
        Else
            Return CType(i_Object, Date)
        End If
    End Function

    Public Shared Function NVLString(ByVal i_Object As Object, _
            Optional ByVal i_DefaultValue As String = IPConstants.c_DefaultString) As String
        If i_Object Is Nothing Then
            Return i_DefaultValue
        Else
            Return CType(i_Object, String)
        End If
    End Function
    Public Shared Function NVLSqlParameter(ByVal i_SqlPara As SqlClient.SqlParameter, _
                                                 ByVal i_DefaultValue As String) As String
        Dim v_ReturnValue As String
        If System.Convert.IsDBNull(i_SqlPara.Value) Then
            v_ReturnValue = i_DefaultValue
        Else
            v_ReturnValue = CType(i_SqlPara.Value, String)
        End If
        Return v_ReturnValue
    End Function

    Public Shared Function NVLSqlParameter(ByVal i_SqlPara As SqlClient.SqlParameter, _
                                                 ByVal i_DefaultValue As Decimal) As Decimal
        Dim v_ReturnValue As Decimal
        If System.Convert.IsDBNull(i_SqlPara.Value) Then
            v_ReturnValue = i_DefaultValue
        Else
            v_ReturnValue = CType(i_SqlPara.Value, Decimal)
        End If
        Return v_ReturnValue
    End Function

    Public Shared Function NVLSqlParameter(ByVal i_SqlPara As SqlClient.SqlParameter, _
                                                 ByVal i_DefaultValue As Date) As Date
        Dim v_ReturnValue As Date
        If System.Convert.IsDBNull(i_SqlPara.Value) Then
            v_ReturnValue = i_DefaultValue
        Else
            v_ReturnValue = CType(i_SqlPara.Value, Date)
        End If
        Return v_ReturnValue
    End Function


End Class
