Option Explicit On 
Option Strict On
Imports System.Data.SqlClient

Public Class BS_Object

#Region "Nhiệm vụ của Class"
    ' Trực tiếp thực hiện các lệnh Select, DDL, cũng như các lệnh
    ' vào cơ sở dữ liệu

#End Region

#Region "Data structures"
    Private Enum DMLCommandType
        InsertCommand
        UpdateCommand
        DeleteCommand
        DeleteByIDCommand
    End Enum

    Private Const C_COMMAND_TIME_OUT As Integer = 100
#End Region

#Region "Private Member"
    Private m_Connection As SqlClient.SqlConnection
    Private m_Trans As SqlClient.SqlTransaction
    Private m_HaveTrans As Boolean = False
#End Region

#Region "Public Interface"
    Public ReadOnly Property HaveTransaction() As Boolean
        Get
            Return m_HaveTrans
        End Get
    End Property

    Public Sub FillDataset(ByVal i_ds As DataSet, _
                               ByVal i_TableName As String, _
                               ByVal i_strDieuKien As String)
        ' Lấy một dataset từ csdl dựa trên điều kiện cho trước
        Dim v_da As SqlClient.SqlDataAdapter = CProvider.getAdapter()
        Dim v_cb As CCommandBuilder
        If Not m_HaveTrans Then 'Csung update 
            ' Tạo ra connection
            Dim v_cn As SqlClient.SqlConnection = CProvider.getConnection
            v_cb = New CCommandBuilder(v_cn, i_ds, i_TableName)
            ' Tạo ra adapter
            v_da.SelectCommand = v_cb.getSelectCommand(i_strDieuKien)
        Else
            v_cb = New CCommandBuilder(Me.m_Connection, i_ds, i_TableName)
            v_da.SelectCommand = v_cb.getSelectCommand(i_strDieuKien)
            v_da.SelectCommand.Transaction = m_Trans
            v_da.SelectCommand.Connection = Me.m_Connection
        End If
        v_da.SelectCommand.CommandTimeout = C_COMMAND_TIME_OUT
        ' Lấy dữ liệu từ DB
        Try
            v_da.Fill(i_ds, i_TableName)
        Catch v_e As System.Exception
            Throw v_e
        Finally
            v_cb = Nothing
            v_da = Nothing
            GC.Collect()
        End Try


    End Sub

    Public Sub FillDatasetByCommand(ByVal i_ds As DataSet, _
                               ByVal i_SelectCmd As SqlClient.SqlCommand)
        '*****************************************************
        ' Lấy một dataset từ csdl dựa COMMAND cho trước
        ' COMMAND đã phải có :
        '  - Tên của stored -function, procedure
        '  - các tham số
        '*****************************************************
        ' Tạo ra adapter
        Dim v_da As SqlClient.SqlDataAdapter = CProvider.getAdapter()
        ' Tạo ra connection

        If Not m_HaveTrans Then 'Csung update 
            ' Tạo ra connection
            Dim v_cn As SqlClient.SqlConnection = CProvider.getConnection
            ' Tạo ra adapter
            v_da.SelectCommand = i_SelectCmd
            v_da.SelectCommand.Connection = v_cn
        Else
            v_da.SelectCommand = i_SelectCmd
            v_da.SelectCommand.Transaction = m_Trans
            v_da.SelectCommand.Connection = Me.m_Connection
        End If
        v_da.SelectCommand.CommandTimeout = C_COMMAND_TIME_OUT
        ' Lấy dữ liệu từ DB
        Try
            v_da.Fill(i_ds, i_ds.Tables(0).TableName)
        Catch v_e As System.Exception
            Throw v_e
        Finally
            v_da = Nothing
            GC.Collect()
        End Try
    End Sub
    Public Sub FillData2Dataset(ByVal i_ds As DataSet, _
                               ByVal i_SelectCmd As SqlClient.SqlCommand)
        '*****************************************************
        ' Lấy một dataset từ csdl dựa COMMAND cho trước
        ' COMMAND đã phải có :
        '  - Tên của stored -function, procedure
        '  - các tham số
        '*****************************************************
        ' Tạo ra adapter
        Dim v_da As SqlClient.SqlDataAdapter = CProvider.getAdapter()
        ' Tạo ra connection

        If Not m_HaveTrans Then 'Csung update 
            ' Tạo ra connection
            Dim v_cn As SqlClient.SqlConnection = CProvider.getConnection
            ' Tạo ra adapter
            v_da.SelectCommand = i_SelectCmd
            v_da.SelectCommand.Connection = v_cn
        Else
            v_da.SelectCommand = i_SelectCmd
            v_da.SelectCommand.Transaction = m_Trans
            v_da.SelectCommand.Connection = Me.m_Connection
        End If
        v_da.SelectCommand.CommandTimeout = C_COMMAND_TIME_OUT
        ' Lấy dữ liệu từ DB
        Try
            v_da.Fill(i_ds, "ChamCong")
        Catch v_e As System.Exception
            Throw v_e
        Finally
            v_da = Nothing
            GC.Collect()
        End Try
    End Sub

    Public Sub Update(ByVal i_ds As DataSet, ByVal i_TableName As String)
        ExecuteCommand(i_ds, i_TableName, DMLCommandType.UpdateCommand)
    End Sub
    Public Sub Update_GhiLog(ByVal i_ds As DataSet, ByVal i_TableName As String, _
                              ByVal i_dcNguoiDung As Decimal, ByVal i_strTenThamSo As String)
        ExecuteCommandInsertLog(i_ds, i_TableName, DMLCommandType.UpdateCommand, i_dcNguoiDung, i_strTenThamSo, 0)
    End Sub

    Public Function Insert(ByVal i_ds As DataSet, ByVal i_TableName As String) As Decimal
        Return ExecuteCommand(i_ds, i_TableName, DMLCommandType.InsertCommand)
    End Function
    Public Function Insert_GhiLog(ByVal i_ds As DataSet, ByVal i_TableName As String, _
                                  ByVal i_dcNguoiDung As Decimal, ByVal i_strTenThamSo As String) As Decimal
        Return ExecuteCommandInsertLog(i_ds, i_TableName, DMLCommandType.InsertCommand, i_dcNguoiDung, i_strTenThamSo, 0)
    End Function

    Public Sub Delete(ByVal i_ds As DataSet, ByVal i_TableName As String)
        ExecuteCommand(i_ds, i_TableName, DMLCommandType.DeleteCommand)
    End Sub

    Public Sub DeleteByID(ByVal i_ds As DataSet, ByVal i_TableName As String, _
                                                    ByVal i_dcID As Decimal)
        ExecuteCommand(i_ds, i_TableName, DMLCommandType.DeleteByIDCommand, i_dcID)
    End Sub
    Public Sub DeleteByID_GhiLog(ByVal i_ds As DataSet, ByVal i_TableName As String, _
                                                        ByVal i_dcID As Decimal, _
                                                         ByVal i_dcNguoiDung As Decimal, ByVal i_strTenThamSo As String)
        ExecuteCommandInsertLog(i_ds, i_TableName, DMLCommandType.DeleteByIDCommand, i_dcNguoiDung, i_strTenThamSo, i_dcID)
    End Sub

    Public Sub ExecCommand(ByVal i_cmd As SqlClient.SqlCommand)
        i_cmd.CommandType = CommandType.StoredProcedure
        If m_HaveTrans Then
            i_cmd.Connection = m_Connection
            i_cmd.Transaction = m_Trans
        Else
            i_cmd.Connection = CProvider.getConnection()
            i_cmd.Connection.Open()
        End If
        i_cmd.CommandTimeout = C_COMMAND_TIME_OUT
        i_cmd.ExecuteScalar()
        If Not m_HaveTrans Then
            i_cmd.Connection.Close()
        End If
    End Sub

    'Trả về ID cho đối tượng mới
    Public Function getObjectID() As Decimal
        ' tạo connection và command
        Dim v_cn As SqlClient.SqlConnection = CProvider.getConnection()
        Dim v_cmd As New SqlClient.SqlCommand

        ' thực hiện lệnh DML
        v_cmd.Connection = v_cn
        v_cmd.CommandType = CommandType.StoredProcedure
        v_cmd.CommandText = "pr_ht_get_object_id"
        Dim v_dbID As Decimal
        v_cmd.Parameters.Add(New SqlClient.SqlParameter("@op_next_object_id", v_dbID))
        v_cmd.Parameters("@op_next_object_id").Direction = ParameterDirection.Output
        v_cmd.Parameters("@op_next_object_id").SqlDbType = SqlDbType.Decimal
        Try
            v_cmd.Connection.Open()
            v_cmd.ExecuteScalar()
            Return CType(v_cmd.Parameters("@op_next_object_id").Value, Decimal)
        Catch v_e As System.Exception
            Throw (v_e)
        Finally
            v_cmd.Connection.Close()
        End Try
    End Function

    Public Function isUpdatable(ByVal i_ds As DataSet, ByVal i_TableName As String) As Boolean
        Debug.Assert(Not m_Connection Is Nothing, "Ban chua viet BeginTranaction")
        Dim v_cb As New CCommandBuilder(m_Connection, i_ds, i_TableName)
        Dim v_cmd As SqlClient.SqlCommand
        v_cmd = v_cb.getUpdatableCommand()
        v_cmd.Connection = m_Connection
        v_cmd.Transaction = m_Trans
        v_cmd.CommandType = CommandType.StoredProcedure
        Try
            v_cmd.ExecuteNonQuery()
            Return True
        Catch v_e As System.Exception
            Throw (v_e)
        End Try
    End Function

    Public Function BeginTransaction() As SqlClient.SqlTransaction
        If Not m_HaveTrans Then
            m_Connection = CProvider.getConnection()
            m_Connection.Open()
            m_HaveTrans = True
        End If
        m_Trans = m_Connection.BeginTransaction(IsolationLevel.ReadCommitted)
        Return m_Trans
    End Function

    Public Sub CommitTransaction()
        m_HaveTrans = False
        m_Trans.Commit()
        m_Connection.Close()
    End Sub

    Public Sub CommitTransWithoutCloseConnection()
        m_HaveTrans = True
        m_Trans.Commit()
        m_Trans = m_Connection.BeginTransaction()
    End Sub

    Public Sub Rollback()
        m_HaveTrans = False

        'm_Trans.Rollback()
        m_Connection.Close()
    End Sub

    Public Function getTransaction() As SqlClient.SqlTransaction
        Debug.Assert(Not m_Trans Is Nothing, "BSObject nay chua co transaction - tuanqt BS_Object.vb")
        Return m_Trans
    End Function

    Public Sub setTransaction(ByVal i_Trans As SqlClient.SqlTransaction)
        m_Trans = i_Trans
        m_Connection = i_Trans.Connection
        m_HaveTrans = True
    End Sub

    Public Sub setSavePoint(ByVal i_str_save_point_name As String)
        Debug.Assert(m_HaveTrans, "Chi duoc dat SavePoint khi US_Object co transaction - tuanqt")
        m_Trans.Save(i_str_save_point_name)
    End Sub

    Public Sub rollbackToSavePoint(ByVal i_str_save_point_name As String)
        Debug.Assert(m_HaveTrans, "Chi duoc dat SavePoint khi US_Object co transaction - tuanqt")
        Try
            m_Trans.Rollback(i_str_save_point_name)
        Catch v_e As Exception
            If (v_e.Message.IndexOf("No transaction or savepoint of that name was found") > 0) Then
                Debug.Assert(False, "Khong tim thay save point co ten la " + i_str_save_point_name + " - tuanqt")
            Else
                'Khong biet la loi gi thi phai nem exception ra ngoai de xu ly
                Throw v_e
            End If
        End Try
    End Sub
#End Region

#Region "Private method"
    Private Function ExecuteCommand(ByVal i_ds As DataSet, _
                              ByVal i_TableName As String, _
                              ByVal i_DMLCommandType As DMLCommandType, _
                              Optional ByVal i_dcID As Decimal = 0) As Decimal
        ' Đây là lệch excecute các command
        ' tạo connection và command
        Dim v_cn As SqlClient.SqlConnection
        If m_HaveTrans Then
            v_cn = m_Connection
        Else
            v_cn = CProvider.getConnection()
        End If

        Dim v_cb As New CCommandBuilder(v_cn, i_ds, i_TableName)
        Dim v_cmd As SqlClient.SqlCommand
        Dim v_out_para As SqlParameter
        v_out_para = Nothing
        Select Case i_DMLCommandType
            Case DMLCommandType.DeleteCommand
                v_cmd = v_cb.getDeleteCommand
            Case DMLCommandType.InsertCommand
                v_cmd = v_cb.getInsertCommand
                v_out_para = v_cmd.Parameters("@ID")
            Case DMLCommandType.UpdateCommand
                v_cmd = v_cb.getUpdateCommand
            Case DMLCommandType.DeleteByIDCommand
                v_cmd = v_cb.getDeleteByIDCommand(i_dcID)
        End Select

        v_cmd.CommandTimeout = C_COMMAND_TIME_OUT

        ' thực hiện lệnh DML

        If m_HaveTrans Then
            v_cmd.Transaction = m_Trans
            v_cmd.Connection = m_Trans.Connection
        Else
            'Trai lai thi phai tao mo connection da co
            v_cmd.Connection.Open()
        End If
        'Bien luu id vua insert vao trong truong hop insert
        Dim v_dc_new_id As Decimal = 0

        Try
            v_cmd.ExecuteNonQuery()
            'Neu trong truong hop insert thi phai tra lai id vua moi insert vao
            If (i_DMLCommandType = DMLCommandType.InsertCommand) Then
                v_dc_new_id = CType(v_out_para.Value, Decimal)
            End If
        Catch v_e As System.Exception
            Throw (v_e)
        Finally
            'Neu khong co transaction thi phai dong connection lai
            If Not m_HaveTrans Then
                v_cmd.Connection.Close()
            End If
        End Try
        'Trong truong hop Insert thi tra ve id vua insert
        'Nguoc lai tra ve 0
        Return v_dc_new_id
    End Function

    '' 12/09/2013: LinhDH thêm
    Private Function ExecuteCommandInsertLog(ByVal i_ds As DataSet, _
                              ByVal i_TableName As String, _
                              ByVal i_DMLCommandType As DMLCommandType, _
                              ByVal i_dcIdNguoiDung As Decimal, _
                              ByVal i_strTenThamSo As String, _
                              ByVal i_dcID As Decimal) As Decimal
        ' Đây là lệch excecute các command
        ' tạo connection và command
        Dim v_cn As SqlClient.SqlConnection
        If m_HaveTrans Then
            v_cn = m_Connection
        Else
            v_cn = CProvider.getConnection()
        End If

        Dim v_cb As New CCommandBuilder(v_cn, i_ds, i_TableName)
        Dim v_cmd As SqlClient.SqlCommand
        Dim v_out_para As SqlParameter
        v_out_para = Nothing
        Select Case i_DMLCommandType
            Case DMLCommandType.DeleteCommand
                v_cmd = v_cb.getDeleteCommand
            Case DMLCommandType.InsertCommand
                v_cmd = v_cb.getInsertCommandInsertLog(i_dcIdNguoiDung, i_strTenThamSo)
                v_out_para = v_cmd.Parameters("@ID")
            Case DMLCommandType.UpdateCommand
                v_cmd = v_cb.getUpdateCommandInsertLog(i_dcIdNguoiDung, i_strTenThamSo)
            Case DMLCommandType.DeleteByIDCommand
                v_cmd = v_cb.getDeleteByIDCommandInsertLog(i_dcID, i_dcIdNguoiDung, i_strTenThamSo)
        End Select

        v_cmd.CommandTimeout = C_COMMAND_TIME_OUT

        ' thực hiện lệnh DML

        If m_HaveTrans Then
            v_cmd.Transaction = m_Trans
            v_cmd.Connection = m_Trans.Connection
        Else
            'Trai lai thi phai tao mo connection da co
            v_cmd.Connection.Open()
        End If
        'Bien luu id vua insert vao trong truong hop insert
        Dim v_dc_new_id As Decimal = 0

        Try
            v_cmd.ExecuteNonQuery()
            'Neu trong truong hop insert thi phai tra lai id vua moi insert vao
            If (i_DMLCommandType = DMLCommandType.InsertCommand) Then
                v_dc_new_id = CType(v_out_para.Value, Decimal)
            End If
        Catch v_e As System.Exception
            Throw (v_e)
        Finally
            'Neu khong co transaction thi phai dong connection lai
            If Not m_HaveTrans Then
                v_cmd.Connection.Close()
            End If
        End Try
        'Trong truong hop Insert thi tra ve id vua insert
        'Nguoc lai tra ve 0
        Return v_dc_new_id
    End Function
#End Region

End Class

