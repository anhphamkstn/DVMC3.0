Option Explicit On 
Option Strict On

Imports System.Data.SqlClient

Public Class CCommandBuilder
    '*--------------------------------------------------------------
    '*Tạo  ra các câu lệnh cập nhật CSDL thích hợp
    '*
    '*--------------------------------------------------------------
    '* Dinh nghia cac hang so
    Private Const c_PRPrefix As String = "pr_"

    Private m_ds As DataSet
    Private m_TableName As String
    Private m_cnn As SqlClient.SqlConnection

    Public Sub New(ByVal i_cnn As SqlClient.SqlConnection, _
                    ByVal i_ds As DataSet, _
                    ByVal i_TableName As String)
        m_cnn = i_cnn
        m_ds = i_ds
        m_TableName = i_TableName
    End Sub

    Public Function getSelectCommand(Optional ByVal i_sDieuKien As String = "") As SqlClient.SqlCommand
        Dim v_Cmd As SqlClient.SqlCommand
        v_Cmd = New SqlClient.SqlCommand(getSelectString(i_sDieuKien), m_cnn)
        v_Cmd.CommandType = CommandType.Text
        Return v_Cmd
    End Function

    Private Function getSelectString(Optional ByVal i_sDieuKien As String = "") As String
        Dim v_strSelect As String = " Select "
        Dim v_DataColumn As System.Data.DataColumn
        For Each v_DataColumn In m_ds.Tables(m_TableName).Columns
            v_strSelect &= v_DataColumn.ColumnName & ", "
        Next
        v_strSelect = v_strSelect.Substring(0, v_strSelect.Length - 2)
        v_strSelect &= " from " & m_TableName
        v_strSelect &= " " & i_sDieuKien
        Return v_strSelect
    End Function

    Public Function getUpdateCommand() As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandType = CommandType.StoredProcedure
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Update"
        setParaCollection4Cmd(v_Cmd)
        Return v_Cmd
    End Function

    Public Function getInsertCommand() As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Insert"
        v_Cmd.CommandType = CommandType.StoredProcedure
        setParaCollection4Cmd(v_Cmd)
        v_Cmd.Parameters("@ID").Direction = ParameterDirection.Output
        Return v_Cmd
    End Function
    Public Function getInsertCommandInsertLog(ByVal i_dcID As Decimal, _
                                              ByVal i_strTenThamSo As String) As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Insert"
        v_Cmd.CommandType = CommandType.StoredProcedure
        setParaCollection4CmdInsertLog(v_Cmd, i_dcID, i_strTenThamSo)
        v_Cmd.Parameters("@ID").Direction = ParameterDirection.Output
        Return v_Cmd
    End Function
    Public Function getUpdateCommandInsertLog(ByVal i_dcID As Decimal, _
                                              ByVal i_strTenThamSo As String) As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandType = CommandType.StoredProcedure
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Update"
        setParaCollection4CmdInsertLog(v_Cmd, i_dcID, i_strTenThamSo)
        Return v_Cmd
    End Function
    Public Function getDeleteByIDCommandInsertLog(ByVal i_dcID As Decimal, _
                                         ByVal i_dcIDNguoiDung As Decimal, _
                                              ByVal i_strTenThamSo As String) As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()

        Dim v_Para As New SqlClient.SqlParameter("@ID", SqlDbType.Decimal)

        v_Para.Value = i_dcID
        v_Cmd.Parameters.Add(v_Para)

        Dim v_Para_NguoiDung As New SqlClient.SqlParameter("@" + i_strTenThamSo, SqlDbType.Decimal)

        v_Para_NguoiDung.Value = i_dcIDNguoiDung
        v_Cmd.Parameters.Add(v_Para_NguoiDung)

        'Gan cac thuoc tinh cua command
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandType = CommandType.StoredProcedure
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Delete"

        Return v_Cmd
    End Function

    Public Function getDeleteCommand() As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()
        Dim v_Column As System.Data.DataColumn
        Dim v_Row As System.Data.DataRow
        Dim v_Para As SqlClient.SqlParameter

        v_Row = m_ds.Tables(m_TableName).Rows(0)

        Dim v_Property As New CProperty()

        For Each v_Column In m_ds.Tables(m_TableName).PrimaryKey
            v_Property.SetValues(v_Column.DataType, v_Column.ColumnName)
            v_Para = v_Property.CreateSQLValuePara()
            v_Para.Value = v_Row(v_Property.getName())
            v_Cmd.Parameters.Add(v_Para)
        Next

        'Gan cac thuoc tinh cua command
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandType = CommandType.StoredProcedure
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Delete"
        Return v_Cmd
    End Function

    Public Function getDeleteByIDCommand(ByVal i_dcID As Decimal) As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()

        Dim v_Para As New SqlClient.SqlParameter("@ID", SqlDbType.Decimal)

        v_Para.Value = i_dcID
        v_Cmd.Parameters.Add(v_Para)

        'Gan cac thuoc tinh cua command
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandType = CommandType.StoredProcedure
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_Delete"

        Return v_Cmd
    End Function

    Public Function getUpdatableCommand() As SqlClient.SqlCommand
        Dim v_Cmd As New SqlClient.SqlCommand()
        v_Cmd.Connection = m_cnn
        v_Cmd.CommandText = c_PRPrefix & m_TableName & "_isupdatable"
        v_Cmd.CommandType = CommandType.StoredProcedure
        setParaCollection4Cmd(v_Cmd)
        Dim v_Para As New SqlParameter()
        v_Para.ParameterName = "@op_Error_Code"
        v_Para.Direction = ParameterDirection.Output
        v_Para.SqlDbType = SqlDbType.Int
        v_Cmd.Parameters.Add(v_Para)
        Return v_Cmd
    End Function

    'Lay ve tham so dung de chua loi do sql server tra ve
    'Protected Function getErrorParameter() As SqlClient.SqlParameter
    '    Dim v_sqlPara As New SqlClient.SqlParameter()
    '    v_sqlPara = New SqlClient.SqlParameter("@ErrorCode", System.Data.SqlDbType.Int)
    '    v_sqlPara.Direction = ParameterDirection.Output
    '    Return v_sqlPara
    'End Function

    'Dat cac gia tri cho cac thuoc tinh
    Protected Sub set_value_4_para(ByVal i_obj_sqlpara As SqlParameter, _
                                ByVal i_obj_property As CProperty, _
                                ByVal i_dr_value As DataRow)
        Dim v_obj_type As Type = i_dr_value.Table.Columns(i_obj_property.getName()).DataType

        Select Case v_obj_type.ToString
            Case "System.String"
                If (i_dr_value.IsNull(i_obj_property.getName())) Then
                    i_obj_sqlpara.Value = System.Convert.DBNull
                Else
                    If (i_dr_value(i_obj_property.getName()).ToString().Trim().Length = 0) Then
                        i_obj_sqlpara.Value = System.Convert.DBNull
                    Else
                        i_obj_sqlpara.Value = i_dr_value(i_obj_property.getName())
                    End If
                End If
            Case "System.DateTime"
                If (i_dr_value.IsNull(i_obj_property.getName())) Then
                    i_obj_sqlpara.Value = System.Convert.DBNull
                Else
                    If (Convert.ToDateTime(i_dr_value(i_obj_property.getName())) _
                             = Convert.ToDateTime("01/01/1900")) Then
                        i_obj_sqlpara.Value = System.Convert.DBNull
                    Else
                        i_obj_sqlpara.Value = i_dr_value(i_obj_property.getName())
                    End If
                End If
            Case Else
                i_obj_sqlpara.Value = i_dr_value(i_obj_property.getName())
        End Select
    End Sub

    '' 12/09/2013 LinhDH thêm để insert được Log
    Protected Sub set_value_4_paraInsertLog(ByVal i_obj_sqlpara As SqlParameter, _
                                ByVal i_obj_property As CProperty, _
                                ByVal i_dc_id_nguoi_dung As Decimal)
        i_obj_sqlpara.Value = i_dc_id_nguoi_dung
    End Sub

    Protected Sub setParaCollection4Cmd(ByVal i_Cmd As SqlClient.SqlCommand)
        Dim v_Column As System.Data.DataColumn
        Dim v_Row As System.Data.DataRow
        Dim v_Para As SqlClient.SqlParameter
        v_Row = m_ds.Tables(m_TableName).Rows(0)

        Dim v_Property As New CProperty
        For Each v_Column In m_ds.Tables(m_TableName).Columns
            v_Property.SetValues(v_Column.DataType, v_Column.ColumnName)
            'tao cac tham so truyen vao cho Stored Procedure
            v_Para = v_Property.CreateSQLValuePara()
            'v_Para.Value = v_Row(v_Property.getName())
            set_value_4_para(v_Para, v_Property, v_Row)
            i_Cmd.Parameters.Add(v_Para)
        Next
        'i_Cmd.Parameters.Add(getErrorParameter())
    End Sub

    Protected Sub setParaCollection4CmdInsertLog(ByVal i_Cmd As SqlClient.SqlCommand, _
                                                 ByVal i_dc_id_nguoi_dung As Decimal, _
                                                 ByVal i_str_ten_tham_so As String)
        Dim v_Column As System.Data.DataColumn
        Dim v_Row As System.Data.DataRow
        Dim v_Para As SqlClient.SqlParameter
        v_Row = m_ds.Tables(m_TableName).Rows(0)

        Dim v_Property As New CProperty
        Dim v_index As Integer
        Dim v_id_index As Integer
        v_index = 0
        For Each v_Column In m_ds.Tables(m_TableName).Columns
            v_Property.SetValues(v_Column.DataType, v_Column.ColumnName)
            If (v_Column.ColumnName.Equals("ID")) Then
                v_id_index = v_index
            End If
            'tao cac tham so truyen vao cho Stored Procedure
            v_Para = v_Property.CreateSQLValuePara()
            'v_Para.Value = v_Row(v_Property.getName())
            set_value_4_para(v_Para, v_Property, v_Row)
            i_Cmd.Parameters.Add(v_Para)
            v_index = v_index + 1
        Next

        '' LinhDH 09/12/2012: Add parameter có insert Log
        v_Property.SetValues(m_ds.Tables(m_TableName).Columns.Item(v_id_index).DataType, i_str_ten_tham_so)
        'tao cac tham so truyen vao cho Stored Procedure
        v_Para = v_Property.CreateSQLValuePara()
        'v_Para.Value = v_Row(v_Property.getName())
        set_value_4_paraInsertLog(v_Para, v_Property, i_dc_id_nguoi_dung)
        i_Cmd.Parameters.Add(v_Para)
    End Sub

End Class
