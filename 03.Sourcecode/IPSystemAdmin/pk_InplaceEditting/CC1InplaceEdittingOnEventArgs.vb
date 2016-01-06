Public Class CC1InplaceEdittingOnEventArgs
    Inherits EventArgs
    'Member
    Protected m_e_result As e_CC1_inplace_editting_next_action

    Public Sub New(ByVal i_e_next_action As e_CC1_inplace_editting_next_action)
        m_e_result = i_e_next_action
    End Sub

    Public Property next_action() As e_CC1_inplace_editting_next_action
        Get
            Return m_e_result
        End Get
        Set(ByVal Value As e_CC1_inplace_editting_next_action)
            m_e_result = Value
        End Set
    End Property
End Class

Public Enum e_CC1_inplace_editting_next_action
    success_and_change_to_none_status = 0
    continue_editting = 1
    cancel_editting = 2
End Enum
