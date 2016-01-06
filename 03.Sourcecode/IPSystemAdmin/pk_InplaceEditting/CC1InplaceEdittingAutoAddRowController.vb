Imports System.Data
Imports System.ComponentModel
Imports C1.Win.C1FlexGrid
Imports IP.Core.IPUserService
Imports IP.Core.IPCommon
Imports IP.Core.IPException
Imports IP.Core.IPCommon.CommonMsgNumber

Public Class CC1InplaceEdittingAutoAddRowController
    Inherits CC1InplaceEdittingController

#Region "Members"
    Private m_obj_trans As ITransferDataRow
    Private m_e_new_row_position As e_CC1InplaceEditting_NewRowPosition
#End Region

#Region "public interface"
    Public Sub New(ByVal i_fg As C1FlexGrid, ByVal i_obj_trans As ITransferDataRow)
        MyBase.New(i_fg)
        m_obj_trans = i_obj_trans
        m_e_new_row_position = e_CC1InplaceEditting_NewRowPosition.next_row
    End Sub

    Public Sub New(ByVal i_fg As C1FlexGrid, ByVal i_obj_trans As ITransferDataRow, _
                        ByVal i_e_new_row_position As e_CC1InplaceEditting_NewRowPosition)
        Me.New(i_fg, i_obj_trans)
        m_e_new_row_position = i_e_new_row_position
    End Sub

    Public Overrides Sub StartInsert()
        Debug.Assert((Me.editting_mode <> e_CC1InplaceEdittingMode.delete_mode) _
                       , "FlexGrid khong duoc co mode delete khi goi startInsert tuanqt")
        If (Not m_fg.FinishEditing()) Then
            Exit Sub
        End If

        If (Me.editting_mode = e_CC1InplaceEdittingMode.none) _
                    Or (m_fg.Rows.Count = m_fg.Rows.Fixed) Then
            'Them hang vao grid
            Dim v_i_new_grid_row As Integer = get_new_row_position()
            m_fg.Rows.Insert(v_i_new_grid_row)
            m_fg.ShowCell(v_i_new_grid_row, m_fg.Col)
            m_fg.Focus()
            m_fg.Row = v_i_new_grid_row
            m_fg.Col = m_fg.Cols.Fixed

            MyBase.StartInsert()
        Else
            'Dang o che do insert hay update thi commitedit
            If (Me.editting_mode = e_CC1InplaceEdittingMode.insert_mode) _
                Or (Me.editting_mode = e_CC1InplaceEdittingMode.update_mode) Then
                If (BaseMessages.MsgBox_Confirm(eConfirmMsg.Sure_to_update)) Then
                    Me.CommitEdit()
                    'Neu commit thanh cong thi goi lai startinsert
                    'Khi goi lai thi mode cua edit controller da ve mode none
                    If (m_b_commit_successful) Then
                        Me.StartInsert()
                    Else
                        'Neu khong thanh cong thi thoat khoi start insert
                    End If
                Else
                    Me.CancelEdit()
                End If
            End If
        End If
    End Sub

    Public Overrides Sub CancelEdit()
        If (m_fg.Rows.Count = m_fg.Rows.Fixed) Then Return
        If (Not m_fg.Editor Is Nothing) Then
            'Grid dang o che do edit thi huy bo noi dung dang edit
            m_fg.FinishEditing(False)
        End If
        RemoveHandler m_fg.BeforeRowColChange, AddressOf Me.catch_m_fg_before_row_col_change
        Select Case Me.editting_mode
            Case e_CC1InplaceEdittingMode.insert_mode
                m_fg.Rows.Remove(m_fg.Row)
            Case e_CC1InplaceEdittingMode.update_mode
                restore_grid_row(m_fg.Row)
            Case e_CC1InplaceEdittingMode.delete_mode
            Case e_CC1InplaceEdittingMode.none
        End Select
        AddHandler m_fg.BeforeRowColChange, AddressOf Me.catch_m_fg_before_row_col_change
        MyBase.CancelEdit()
    End Sub
#End Region

#Region "private method"

    Private Function get_new_row_position() As Integer
        Dim v_i_new_grid_row = 0
        If (m_fg.Rows.Count = m_fg.Rows.Fixed) Then
            v_i_new_grid_row = m_fg.Rows.Fixed
            Return v_i_new_grid_row
        End If

        Select Case m_e_new_row_position
            Case e_CC1InplaceEditting_NewRowPosition.next_row
                v_i_new_grid_row = m_fg.Row + 1
            Case e_CC1InplaceEditting_NewRowPosition.last_row
                v_i_new_grid_row = m_fg.Rows.Count
            Case Else
                Debug.Assert(False, "CC1InplaceEditting chua implement kieu new row position nay")
        End Select

        Return v_i_new_grid_row
    End Function

    Protected Overrides Sub process_after_raise_on_event(ByVal i_obj_event_arg As CC1InplaceEdittingOnEventArgs _
                    , ByVal i_obj_cancel_arg As CancelEventArgs)
        RemoveHandler m_fg.BeforeRowColChange, AddressOf Me.catch_m_fg_before_row_col_change
        Select Case i_obj_event_arg.next_action
            Case e_CC1_inplace_editting_next_action.cancel_editting
                CancelEdit()
            Case e_CC1_inplace_editting_next_action.success_and_change_to_none_status
                If (m_e_mode = e_CC1InplaceEdittingMode.delete_mode) Then
                    m_fg.Rows.Remove(m_fg.Row)
                End If
                m_b_commit_successful = True
                m_e_mode = e_CC1InplaceEdittingMode.none
            Case e_CC1_inplace_editting_next_action.continue_editting
                i_obj_cancel_arg.Cancel = True
        End Select
        AddHandler m_fg.BeforeRowColChange, AddressOf Me.catch_m_fg_before_row_col_change
    End Sub

    Private Sub restore_grid_row(ByVal i_grid_row As Integer)
        Debug.Assert(Not m_fg.Rows(i_grid_row).UserData Is Nothing, "Chua gan DataRow vao userdata cua gridrow tuanqt")
        Dim v_dr_source As DataRow = CType(m_fg.Rows(i_grid_row).UserData, DataRow)
        m_obj_trans.DataRow2GridRow(v_dr_source, i_grid_row)
    End Sub
#End Region

End Class