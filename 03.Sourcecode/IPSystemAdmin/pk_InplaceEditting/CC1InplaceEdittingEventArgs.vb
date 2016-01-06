Public Class CC1InplaceEdittingEventArgs
    Inherits EventArgs
    'Member
    Protected m_b_continue_2_edit As Boolean

    Public Sub New(ByVal i_b_continue_2_edit As Boolean)
        m_b_continue_2_edit = i_b_continue_2_edit
    End Sub

    Public Property continue_editting() As Boolean
        Get
            Return m_b_continue_2_edit
        End Get
        Set(ByVal Value As Boolean)
            m_b_continue_2_edit = Value
        End Set
    End Property
End Class

Public Enum e_CC1InplaceEdittingMode
    none = 0
    insert_mode = 1
    update_mode = 2
    delete_mode = 3
End Enum

Public Enum e_CC1InplaceEditting_NewRowPosition
    next_row = 0
    last_row = 1
End Enum