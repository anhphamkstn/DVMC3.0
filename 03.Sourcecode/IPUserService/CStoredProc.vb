' 
'
' 
'
Option Strict On
Option Explicit On 
Imports IP.Core.IPCommon

Public Class CStoredProc
    Private m_SqlCommand As New SqlClient.SqlCommand

    Public Sub New(ByVal i_strProcName As String)
        m_SqlCommand.CommandText = i_strProcName
        m_SqlCommand.CommandType = CommandType.StoredProcedure
    End Sub
    Public Function addDecimalInputParam(ByVal ip_name As String, _
                                         ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getDecimalInputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Function addNVarcharInputParam(ByVal ip_name As String, _
                                             ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getNVarcharInputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Function addDatetimeInputParam(ByVal ip_name As String, _
                                         ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getDateTimeInputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Function addImageInputParam(ByVal ip_name As String, _
                                           ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getImageInputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Sub ExecuteCommand(ByVal i_UsObject As US_Object)
        i_UsObject.ExecCommand(Me.m_SqlCommand)
    End Sub

    Public Function addDecimalOutputParam(ByVal ip_name As String, _
                                       ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getDecimalOutputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Function addNVarcharOutputParam(ByVal ip_name As String, _
                                             ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getNVarcharOutputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Function addDatetimeOutputParam(ByVal ip_name As String, _
                                         ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getDateTimeOutputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Function addImageOutputParam(ByVal ip_name As String, _
                                           ByVal ip_value As Object) As SqlClient.SqlParameter

        Dim v_sqlPara As SqlClient.SqlParameter = _
            m_SqlCommand.Parameters.Add(CDBUtils.getImageOutputParam(ip_name, ip_value))
        Return v_sqlPara
    End Function

    Public Sub fillDataSetByCommand(ByVal i_us As US_Object, ByVal i_ds As DataSet)
        Debug.Assert(Not (i_ds Is Nothing), "DS chua khoi tao")
        Debug.Assert(Not (i_us Is Nothing), "US chua khoi tao")
        i_us.FillDatasetByCommand(i_ds, Me.m_SqlCommand)
    End Sub
    Public Sub fillData2DataSet(ByVal i_us As US_Object, ByVal i_ds As DataSet)
        Debug.Assert(Not (i_ds Is Nothing), "DS chua khoi tao")
        Debug.Assert(Not (i_us Is Nothing), "US chua khoi tao")
        i_us.FillData_2_Dataset(i_ds, Me.m_SqlCommand)
    End Sub
End Class
