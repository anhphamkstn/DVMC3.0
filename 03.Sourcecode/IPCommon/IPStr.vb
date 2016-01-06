Option Explicit On 
Option Strict On


Public Class IPStr
    Public Shared Function singleQuoteSTR(ByVal i_str As String) As String
        Return IPConstants.C_SINGLE_QUOTE & i_str & IPConstants.C_SINGLE_QUOTE
    End Function
End Class
