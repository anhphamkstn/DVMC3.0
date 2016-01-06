'NHIỆM VỤ CỦA CLASS
'   
'  Thực hiện các phép lock trên 1 business process
'  User có thể tạo ra 1 lock , và release nó
'
'
'

Option Strict On
Option Explicit On 

Imports IP.Core.IPException

Public Class CBusinessProcessLock

#Region "Members"
    Private m_strLockName As String
    Private m_lock_granted As Boolean = False
    Private m_bs_object As BS_Object
#End Region


#Region "PUBLIC INTERFACE"

    Public Sub New(ByVal i_strLockName As String)
        Debug.Assert(i_strLockName <> "", "lock name khong duoc rong")
        m_strLockName = i_strLockName
        m_bs_object = New BS_Object()
        Dim v_tran As SqlClient.SqlTransaction
        v_tran = m_bs_object.BeginTransaction()
        ' tạo lock và commit
        check_and_make_Lock_in_DB(m_strLockName)
        m_bs_object.CommitTransWithoutCloseConnection()

        subcribe_lock_in_DB(m_strLockName)
        'không kết thúc tran và không commit tra
        m_lock_granted = True
    End Sub

    Public Sub releaseLock()
        Debug.Assert(m_lock_granted, "KHONG CO LOCK , KHONG THE RELEASE DUOC  - CSUNG")
        'release_Lock_in_DB(m_strLockName)
        m_lock_granted = False
        m_bs_object.CommitTransaction()
    End Sub


#End Region

#Region "PRIVATES"


    Private Sub check_and_make_Lock_in_DB(ByVal i_strLockName As String)
        Debug.Assert(i_strLockName <> "", "LOCK NAME PHAI KHAC RONG - CSUNG")
        Try
            Dim v_sqlCommand As New SqlClient.SqlCommand()
            v_sqlCommand.CommandType = CommandType.StoredProcedure
            v_sqlCommand.CommandText = "pr_check_and_make_bp_lock_123"

            Dim v_sqlPara As New SqlClient.SqlParameter()
            v_sqlPara.SqlDbType = SqlDbType.NChar
            v_sqlPara.Direction = ParameterDirection.Input
            v_sqlPara.ParameterName = "@ip_lock_name"
            v_sqlPara.Value = i_strLockName
            v_sqlCommand.Parameters.Add(v_sqlPara)
            m_bs_object.ExecCommand(v_sqlCommand)
        Catch v_e As Exception
            Dim v_e_handler As New CDBExceptionHandler( _
                            v_e, _
                            New CDBClientDBExceptionInterpret())
            If v_e_handler.getDBErrorIndex = CDBExceptionHandler.DBErrorIndex.DuplicateIndex Then
                Throw New CBSProcessLockException()
            Else
                Throw v_e
            End If
        End Try
    End Sub

    Private Sub subcribe_lock_in_DB(ByVal i_strLockName As String)

        Try
            Dim v_sqlCommand As New SqlClient.SqlCommand()
            v_sqlCommand.CommandType = CommandType.StoredProcedure
            v_sqlCommand.CommandText = "pr_Lock_Business_Process_124"
            Dim v_sqlPara As New SqlClient.SqlParameter()
            v_sqlPara.SqlDbType = SqlDbType.NChar
            v_sqlPara.Direction = ParameterDirection.Input
            v_sqlPara.ParameterName = "@ip_lock_name"
            v_sqlPara.Value = i_strLockName
            v_sqlCommand.Parameters.Add(v_sqlPara)
            m_bs_object.ExecCommand(v_sqlCommand)

        Catch v_e As Exception
            Dim v_e_handler As New CDBExceptionHandler( _
                            v_e, _
                            New CDBClientDBExceptionInterpret())
            If v_e_handler.getDBErrorIndex = CDBExceptionHandler.DBErrorIndex.DuplicateIndex Then
                Throw New CBSProcessLockException()
            Else
                Throw v_e
            End If
        End Try
    End Sub

#End Region

End Class
