Imports System.ComponentModel
Imports C1.Win.C1FlexGrid
Imports IP.Core.IPCommon
Imports IP.Core.IPCommon.CommonMsgNumber

'Dieu khien edit tai cho flexgrid
Public Class CC1InplaceEdittingController

#Region "Member"
    Protected m_e_mode As e_CC1InplaceEdittingMode
    Protected WithEvents m_fg As C1FlexGrid
    Private m_b_update_when_row_changed As Boolean

    'Insert event
    Public Delegate Sub BeforeInsertHandler(ByVal sender As Object, ByVal e As CC1InplaceEdittingEventArgs)
    Public Event BeforeInsert As BeforeInsertHandler

    Public Delegate Sub OnInsertHandler(ByVal sender As Object, ByVal e As CC1InplaceEdittingOnEventArgs)
    Public Event OnInsert As OnInsertHandler

    Public Delegate Sub OnCancelInsertHandler(ByVal sender As Object, ByVal e As EventArgs)
    Public Event OnCancelInsert As OnCancelInsertHandler

    'Update event
    Public Delegate Sub BeforeUpdateHandler(ByVal sender As Object, ByVal e As CC1InplaceEdittingEventArgs)
    Public Event BeforeUpdate As BeforeUpdateHandler

    Public Delegate Sub OnUpdateHandler(ByVal sender As Object, ByVal e As CC1InplaceEdittingOnEventArgs)
    Public Event OnUpdate As OnUpdateHandler

    Public Delegate Sub OnCancelUpdateHandler(ByVal sender As Object, ByVal e As EventArgs)
    Public Event OnCancelUpdate As OnCancelUpdateHandler

    'Delete event
    Public Delegate Sub BeforeDeleteHandler(ByVal sender As Object, ByVal e As CC1InplaceEdittingEventArgs)
    Public Event BeforeDelete As BeforeDeleteHandler

    Public Delegate Sub OnDeleteHandler(ByVal sender As Object, ByVal e As CC1InplaceEdittingOnEventArgs)
    Public Event OnDelete As OnDeleteHandler

    Public Delegate Sub OnCancelDeleteHandler(ByVal sender As Object, ByVal e As EventArgs)
    Public Event OnCancelDelete As OnCancelDeleteHandler

    Protected m_b_commit_successful As Boolean
#End Region

    Public Sub New(ByVal i_fg As C1FlexGrid)
        m_fg = i_fg
        m_e_mode = e_CC1InplaceEdittingMode.none
        m_b_update_when_row_changed = True
        m_b_commit_successful = False
        AddHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
        AddHandler m_fg.Leave, AddressOf catch_m_fg_leave
    End Sub

    Public Property is_updated_when_row_changed() As Boolean
        Get
            Return m_b_update_when_row_changed
        End Get
        Set(ByVal Value As Boolean)
            m_b_update_when_row_changed = Value
        End Set
    End Property

    Public ReadOnly Property is_editting() As Boolean
        Get
            Return (m_e_mode <> e_CC1InplaceEdittingMode.none)
        End Get
    End Property

    Public ReadOnly Property editting_mode() As e_CC1InplaceEdittingMode
        Get
            Return m_e_mode
        End Get
    End Property

    Public Overridable Sub StartInsert()
        Debug.Assert((m_e_mode = e_CC1InplaceEdittingMode.none) _
                        Or (m_e_mode = e_CC1InplaceEdittingMode.insert_mode), _
                        "FlexGrid co mode update hoac delete khi goi startInsert")
        If (m_fg.FinishEditing()) Then
            If (m_e_mode = e_CC1InplaceEdittingMode.none) Then
                Dim v_obj_even_arg As New CC1InplaceEdittingEventArgs(True)
                RaiseEvent BeforeInsert(Me, v_obj_even_arg)
                If (v_obj_even_arg.continue_editting) Then
                    m_e_mode = e_CC1InplaceEdittingMode.insert_mode
                    m_b_commit_successful = False
                Else
                    CancelEdit()
                End If
            End If
        End If
    End Sub

    Public Overridable Sub StartUpdate()
        Debug.Assert((m_e_mode = e_CC1InplaceEdittingMode.none) _
                        Or (m_e_mode = e_CC1InplaceEdittingMode.update_mode) _
                        Or (m_e_mode = e_CC1InplaceEdittingMode.insert_mode), _
                        "FlexGrid co mode delete khi goi startUpdate")
        If (m_e_mode = e_CC1InplaceEdittingMode.none) Then
            Dim v_obj_even_arg As New CC1InplaceEdittingEventArgs(True)
            RaiseEvent BeforeUpdate(Me, v_obj_even_arg)
            If (v_obj_even_arg.continue_editting) Then
                m_e_mode = e_CC1InplaceEdittingMode.update_mode
                m_b_commit_successful = False
            Else
                CancelEdit()
            End If
        End If
    End Sub

    Public Overridable Sub StartDelete()
        If (m_fg.Rows.Count = m_fg.Rows.Fixed) Then return
        'Ket thuc trang thai edit cua grid
        If (Not m_fg.FinishEditing()) Then
            Exit Sub
        End If
        'confirm user
        If (Not BaseMessages.MsgBox_Confirm(eConfirmMsg.Sure_to_delete)) Then
            Exit Sub
        End If

        If (m_e_mode = e_CC1InplaceEdittingMode.none) Then
            Dim v_obj_even_arg As New CC1InplaceEdittingEventArgs(True)
            RaiseEvent BeforeDelete(Me, v_obj_even_arg)
            If (v_obj_even_arg.continue_editting) Then
                m_e_mode = e_CC1InplaceEdittingMode.delete_mode
                m_b_commit_successful = False
                RemoveHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
                CommitEdit()
                AddHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
            Else
                CancelEdit()
            End If
        Else
            If (m_e_mode = e_CC1InplaceEdittingMode.insert_mode) Then
                Me.CancelEdit()
            Else
                If (m_e_mode = e_CC1InplaceEdittingMode.update_mode) Then
                    Me.CancelEdit()
                    Me.StartDelete()
                End If
            End If
        End If
    End Sub

    Public Overridable Sub CancelEdit()
        RemoveHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
        Dim v_obj_even_arg As New EventArgs
        Select Case m_e_mode
            Case e_CC1InplaceEdittingMode.insert_mode
                RaiseEvent OnCancelInsert(Me, v_obj_even_arg)
            Case e_CC1InplaceEdittingMode.update_mode
                RaiseEvent OnCancelUpdate(Me, v_obj_even_arg)
            Case e_CC1InplaceEdittingMode.delete_mode
                RaiseEvent OnCancelDelete(Me, v_obj_even_arg)
            Case e_CC1InplaceEdittingMode.none
        End Select
        m_e_mode = e_CC1InplaceEdittingMode.none
        AddHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
    End Sub

    Public Overridable Sub CommitEdit()
        Dim v_e As New CancelEventArgs(False)
        CommitEdit_when_RowColChange(v_e)
    End Sub

    Protected Overridable Sub CommitEdit_when_RowColChange(ByVal e As CancelEventArgs)
        Dim v_obj_even_arg As New CC1InplaceEdittingOnEventArgs(e_CC1_inplace_editting_next_action.success_and_change_to_none_status)
        Select Case m_e_mode
            Case e_CC1InplaceEdittingMode.insert_mode
                RaiseEvent OnInsert(Me, v_obj_even_arg)
            Case e_CC1InplaceEdittingMode.update_mode
                RaiseEvent OnUpdate(Me, v_obj_even_arg)
            Case e_CC1InplaceEdittingMode.delete_mode
                RaiseEvent OnDelete(Me, v_obj_even_arg)
            Case e_CC1InplaceEdittingMode.none
        End Select
        process_after_raise_on_event(v_obj_even_arg, e)
    End Sub

    Protected Overridable Sub process_after_raise_on_event(ByVal i_obj_event_arg As CC1InplaceEdittingOnEventArgs _
                    , ByVal i_obj_cancel_arg As CancelEventArgs)
        Select Case i_obj_event_arg.next_action
            Case e_CC1_inplace_editting_next_action.cancel_editting
                CancelEdit()
            Case e_CC1_inplace_editting_next_action.success_and_change_to_none_status
                m_b_commit_successful = True
                m_e_mode = e_CC1InplaceEdittingMode.none
            Case e_CC1_inplace_editting_next_action.continue_editting
                i_obj_cancel_arg.Cancel = True
        End Select
    End Sub

    Protected Overridable Sub catch_m_fg_before_row_col_change(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs)
        If (m_b_update_when_row_changed) And (e.NewRange.r1 <> e.OldRange.r1) Then
            Dim v_e As New CancelEventArgs(False)
            CommitEdit_when_RowColChange(v_e)
            e.Cancel = v_e.Cancel
        End If
    End Sub

    Protected Overridable Sub catch_m_fg_leave(ByVal sender As Object, ByVal e As System.EventArgs)
        CommitEdit()
    End Sub
End Class 'END CLASS DEFINITION CC1InplaceEdittingController