Option Strict On
Option Explicit On 


Public Class CDBUtils
    Const C_WRONG_PARAM_NAME As String = "CSUNG- TÊN Tham số không bắt đầu bằng @. Kiểm tra lại"
    Const C_PREFIX_OF_PARAM As String = "@"
    Public Shared Function getImageInputParam(ByVal ip_name As String, _
                                               ByVal ip_value As Object) As SqlClient.SqlParameter
        Try
            Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
            Dim v_sqlPara As New SqlClient.SqlParameter()
            v_sqlPara.SqlDbType = SqlDbType.Image
            v_sqlPara.Direction = ParameterDirection.Input
            v_sqlPara.Value = ip_value
            v_sqlPara.ParameterName = ip_name
            Return v_sqlPara
        Catch v_ex As Exception
            Throw v_ex
        End Try
    End Function

    Public Shared Function getImageOutputParam(ByVal ip_name As String, _
                                                   ByVal ip_value As Object) As SqlClient.SqlParameter
        Try
            Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
            Dim v_sqlPara As New SqlClient.SqlParameter()
            v_sqlPara.SqlDbType = SqlDbType.Image
            v_sqlPara.Direction = ParameterDirection.Output
            v_sqlPara.Value = ip_value
            v_sqlPara.ParameterName = ip_name
            Return v_sqlPara
        Catch v_ex As Exception
            Throw v_ex
        End Try
    End Function
    Public Shared Function getDecimalInputParam(ByVal ip_name As String, _
                                         ByVal ip_value As Object) As SqlClient.SqlParameter
        Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
        Dim v_sqlPara As New SqlClient.SqlParameter()
        v_sqlPara.SqlDbType = SqlDbType.Decimal
        v_sqlPara.Direction = ParameterDirection.Input
        v_sqlPara.Value = ip_value
        v_sqlPara.ParameterName = ip_name
        Return v_sqlPara
    End Function
   

    Public Shared Function getDecimalOutputParam(ByVal ip_name As String, _
                                                    ByVal ip_value As Object) As SqlClient.SqlParameter
        Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
        Dim v_sqlPara As New SqlClient.SqlParameter

        v_sqlPara.SqlDbType = SqlDbType.Decimal
        v_sqlPara.Direction = ParameterDirection.Output
        v_sqlPara.Value = ip_value
        v_sqlPara.ParameterName = ip_name

        Return v_sqlPara
    End Function

    Public Shared Function getDateTimeInputParam(ByVal ip_name As String, _
                                         ByVal ip_value As Object) As SqlClient.SqlParameter

        Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
        Dim v_sqlPara As New SqlClient.SqlParameter
        v_sqlPara.SqlDbType = SqlDbType.DateTime
        v_sqlPara.Direction = ParameterDirection.Input
        v_sqlPara.Value = ip_value
        v_sqlPara.ParameterName = ip_name
        Return v_sqlPara
    End Function

    Public Shared Function getDateTimeOutputParam(ByVal ip_name As String, _
                                     ByVal ip_value As Object) As SqlClient.SqlParameter

        Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
        Dim v_sqlPara As New SqlClient.SqlParameter

        v_sqlPara.SqlDbType = SqlDbType.DateTime
        v_sqlPara.Direction = ParameterDirection.Output
        v_sqlPara.Value = ip_value
        v_sqlPara.ParameterName = ip_name
        Return v_sqlPara
    End Function

    Public Shared Function getNVarcharInputParam(ByVal ip_name As String, _
                                         ByVal ip_value As Object) As SqlClient.SqlParameter
        Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
        Dim v_sqlPara As New SqlClient.SqlParameter
        v_sqlPara.SqlDbType = SqlDbType.NVarChar
        v_sqlPara.Direction = ParameterDirection.Input
        v_sqlPara.Value = ip_value
        v_sqlPara.ParameterName = ip_name
        Return v_sqlPara
    End Function

    Public Shared Function getNVarcharOutputParam(ByVal ip_name As String, _
                                     ByVal ip_value As Object, _
                                     Optional ByVal ip_size_of_value As Integer = 100) As SqlClient.SqlParameter
        Debug.Assert(ip_name.IndexOf(C_PREFIX_OF_PARAM) >= 0, C_WRONG_PARAM_NAME)
        Dim v_sqlPara As New SqlClient.SqlParameter

        v_sqlPara.SqlDbType = SqlDbType.NVarChar
        v_sqlPara.Direction = ParameterDirection.Output
        v_sqlPara.Value = ip_value
        v_sqlPara.ParameterName = ip_name
        v_sqlPara.Size = ip_size_of_value
        Return v_sqlPara
    End Function

    Public Shared Sub Rollback_Without_Closing_Connection(ByVal i_trans As SqlClient.SqlTransaction)
        Try
            i_trans.Rollback()
        Catch

        End Try
    End Sub
End Class


