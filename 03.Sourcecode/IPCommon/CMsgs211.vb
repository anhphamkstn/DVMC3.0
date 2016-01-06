Option Explicit On 
Option Strict On
Namespace MessageForms
    Public Class Msgs
#Region "Khai báo biến"
        Public Enum MsgBtnType As Integer
            MsgBtnOK = 0
            MsgBtnYes_No = 1
            MsgBtnYes_No_Cancel = 2
        End Enum
        Public Enum MsgIconType As Integer
            InfomationIcon = 0
            ErrorIcon = 1
            QuestionIcon = 2
            WarningIcon = 3
        End Enum
        Private Shared m_MsgResult As System.Windows.Forms.DialogResult
#End Region
        Public Shared Function Show(ByVal i_StrMsg As String, ByVal i_Title As String, ByVal i_ButtonStyle As MsgBtnType, ByVal i_IconMessage As MsgIconType) As System.Windows.Forms.DialogResult
            Select Case i_ButtonStyle
                Case MsgBtnType.MsgBtnOK
                    Dim v_MyFormMsgOK As New MsgBoxForm_OK()
                    m_MsgResult = v_MyFormMsgOK.Display(i_StrMsg, i_Title, i_IconMessage)
                Case MsgBtnType.MsgBtnYes_No
                    Dim v_MyFormMsgYN As New MsgBoxForm_Yes_No()
                    m_MsgResult = v_MyFormMsgYN.Display(i_StrMsg, i_Title, i_IconMessage)
                Case MsgBtnType.MsgBtnYes_No_Cancel
                    Dim v_MyFormMsgYNC As New MsgBoxFormYes_No_Cancel()
                    m_MsgResult = v_MyFormMsgYNC.Display(i_StrMsg, i_Title, i_IconMessage)
            End Select
            Return m_MsgResult
        End Function
    End Class
End Namespace