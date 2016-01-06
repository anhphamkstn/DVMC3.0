Option Strict On
Option Explicit On 

Public Class CBSProcessLockException
    Inherits System.Exception

    Public Const C_BSLockProcess_Exception_Name As String = "IP_BUSINESS_PROCESS_LOCK_EXCEPTION"

    Public Sub New()
        MyBase.New(C_BSLockProcess_Exception_Name)
    End Sub
End Class
