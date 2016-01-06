Option Strict On
Option Explicit On 


Public Class CDBSoapDBExceptionInterpret
    Implements IPException.IDBExceptionInterpret
    Public Function getDBErrorIndex(ByVal i_ExceptionToHandler As System.Exception) As IPException.CDBExceptionHandler.DBErrorIndex Implements IDBExceptionInterpret.getDBErrorIndex
        Dim v_ErrorIndex As CDBExceptionHandler.DBErrorIndex
        If i_ExceptionToHandler.Message.IndexOf("UNIQUE") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.DuplicateIndex
        ElseIf i_ExceptionToHandler.Message.IndexOf("CONNECT") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.NoDBConnection
        Else
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.OtherDBException
        End If
        Return v_ErrorIndex
    End Function
End Class

Public Class CDBClientDBExceptionInterpret
    Implements IPException.IDBExceptionInterpret
    Public Function getDBErrorIndex(ByVal i_ExceptionToHandler As System.Exception) As IPException.CDBExceptionHandler.DBErrorIndex Implements IDBExceptionInterpret.getDBErrorIndex
        Dim v_ErrorIndex As CDBExceptionHandler.DBErrorIndex
        If i_ExceptionToHandler.Message.IndexOf("UNIQUE") > -1 _
            Or i_ExceptionToHandler.Message.IndexOf("PRIMARY KEY") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.DuplicateIndex
        ElseIf i_ExceptionToHandler.Message.IndexOf("FOREIGN KEY") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.NoParentFound
        ElseIf i_ExceptionToHandler.Message.IndexOf("PARENT") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.NoParentFound
        ElseIf i_ExceptionToHandler.Message.IndexOf("NULL") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.NullValueNotAllowed
        ElseIf i_ExceptionToHandler.Message.IndexOf("REFERENCE") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.ChildRecordFound
        ElseIf i_ExceptionToHandler.Message.IndexOf("CONNECT") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.NoDBConnection
        ElseIf i_ExceptionToHandler.Message.IndexOf("Lock request") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.LockTimeOut
        ElseIf i_ExceptionToHandler.Message.IndexOf("RECORD_DELETED") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.RecordDeleted
        ElseIf i_ExceptionToHandler.Message.IndexOf("RECORD_CHANGED") > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.RecordChanged
        ElseIf i_ExceptionToHandler.Message.IndexOf(CBSProcessLockException.C_BSLockProcess_Exception_Name) > -1 Then
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.BusinessProcessLock
        Else
            v_ErrorIndex = CDBExceptionHandler.DBErrorIndex.OtherDBException
        End If
        Return v_ErrorIndex
    End Function
End Class

