Imports System.Windows.Forms

Public Class CForm_Escape_Keydown_Handler
    Private WithEvents m_fForm As Form

    Public Sub New(ByVal i_fForm As Form)
        m_fForm = i_fForm
    End Sub

    Public Sub HandleEscapeKeydown()
        AddHandler m_fForm.KeyDown, AddressOf m_fForm_KeyDown
    End Sub

    Private Sub m_fForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                m_fForm.Close()
        End Select
    End Sub
End Class
