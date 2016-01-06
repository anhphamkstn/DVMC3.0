Option Explicit On 
Option Strict On

Public Class CExpUtils
    Public Shared Function get_CS_ExpHandler(ByVal i_e As Exception) As CDBExceptionHandler
        Return New CDBExceptionHandler(i_e, New CDBClientDBExceptionInterpret())
    End Function
End Class
