Public Class CIPKeys
    Public Enum KeyMode
        InsertState
        UpdateState
        DeleteState
        ViewState
        ExitState
    End Enum
    Public Shared Function GetStringInsertKey() As String
        Return System.Windows.Forms.Keys.F3.ToString
    End Function
    Public Shared Function GetStringUpdateKey() As String
        Return System.Windows.Forms.Keys.F4.ToString
    End Function
    Public Shared Function GetStringDeleteKey() As String
        Return System.Windows.Forms.Keys.F5.ToString
    End Function
    Public Shared Function GetStringViewKey() As String
        Return System.Windows.Forms.Keys.F6.ToString
    End Function
    Public Shared Function GetStringExitKey() As String
        Return System.Windows.Forms.Keys.Escape.ToString
    End Function

    Public Shared Function GetKeyStateEnum(ByVal ie As System.Windows.Forms.KeyEventArgs) As KeyMode
        Dim vKeyMode As KeyMode
        Select Case ie.KeyCode
            Case Windows.Forms.Keys.F3
                vKeyMode = KeyMode.InsertState
            Case Windows.Forms.Keys.F4
                vKeyMode = KeyMode.UpdateState
            Case Windows.Forms.Keys.F5
                vKeyMode = KeyMode.DeleteState
            Case Windows.Forms.Keys.F6
                vKeyMode = KeyMode.ViewState
            Case Windows.Forms.Keys.Escape
                vKeyMode = KeyMode.ExitState
        End Select
        Return vKeyMode
    End Function

End Class
