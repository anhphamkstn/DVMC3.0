'NHIỆM VỤ CỦA CLASS
'   
'
'
'
'
'

Option Explicit On 
Option Strict On

Imports IP.Core.IPBusinessService

Public Class US_BUSINESS_PROCESS_LOCK

    Private m_bp_Lock As CBusinessProcessLock

#Region "PUBLIC INTERFACE"
    Public Sub New(ByVal i_strLockName As String)
        Debug.Assert(i_strLockName <> "", "CSUNG - lock phai co ten chu")
        m_bp_Lock = New CBusinessProcessLock(i_strLockName)
    End Sub

    Public Sub releaseLock()
        m_bp_Lock.releaseLock()
    End Sub
#End Region


End Class
