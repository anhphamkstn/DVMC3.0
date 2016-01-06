Imports System.Data
Imports System.ComponentModel
Imports C1.Win.C1FlexGrid
Imports IP.Core.IPUserService
Imports IP.Core.IPCommon
Imports IP.Core.IPException

Public Class CC1InplaceEdittingAutoAddRowAndUpdateDBController

#Region "Member"
    Private m_us_cur As US_Object
    Private m_ds_source As DataSet
    Private m_fg As C1FlexGrid
    Private m_obj_transfer As ITransferDataRow
    Private m_e_new_row_position As e_CC1InplaceEditting_NewRowPosition
    Private WithEvents m_obj_edit_controller As CC1InplaceEdittingController

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

#End Region

#Region "public interface"
    Public ReadOnly Property is_editting() As Boolean
        Get
            Return m_obj_edit_controller.is_editting
        End Get
    End Property

    Public ReadOnly Property editting_mode() As e_CC1InplaceEdittingMode
        Get
            Return m_obj_edit_controller.editting_mode
        End Get
    End Property

    Public Sub New(ByVal i_fg As C1FlexGrid, ByVal i_us_obj As US_Object, ByVal i_ds_source As DataSet, ByVal i_obj_transfer As ITransferDataRow)
        m_fg = i_fg
        m_us_cur = i_us_obj
        m_ds_source = i_ds_source
        m_obj_transfer = i_obj_transfer
        m_obj_edit_controller = New CC1InplaceEdittingController(m_fg)
        m_e_new_row_position = e_CC1InplaceEditting_NewRowPosition.next_row

        AddHandler m_fg.StartEdit, AddressOf Me.catch_fg_StartEdit

        AddHandler m_obj_edit_controller.BeforeUpdate, AddressOf m_obj_edit_controller_BeforeUpdate
        AddHandler m_obj_edit_controller.OnUpdate, AddressOf m_obj_edit_controller_OnUpdate
        AddHandler m_obj_edit_controller.OnCancelUpdate, AddressOf m_obj_edit_controller_OnCancelUpdate

        AddHandler m_obj_edit_controller.BeforeInsert, AddressOf m_obj_edit_controller_BeforeInsert
        AddHandler m_obj_edit_controller.OnInsert, AddressOf m_obj_edit_controller_OnInsert
        AddHandler m_obj_edit_controller.OnCancelInsert, AddressOf m_obj_edit_controller_OnCancelInsert

        AddHandler m_obj_edit_controller.BeforeDelete, AddressOf m_obj_edit_controller_BeforeDelete
        AddHandler m_obj_edit_controller.OnDelete, AddressOf m_obj_edit_controller_OnDelete
        AddHandler m_obj_edit_controller.OnCancelDelete, AddressOf m_obj_edit_controller_OnCancelDelete
    End Sub

    Public Sub New(ByVal i_fg As C1FlexGrid, _
                    ByVal i_us_obj As US_Object, _
                    ByVal i_ds_source As DataSet, _
                    ByVal i_obj_transfer As ITransferDataRow, _
                    ByVal i_e_new_row_position As e_CC1InplaceEditting_NewRowPosition)
        Me.New(i_fg, i_us_obj, i_ds_source, i_obj_transfer)
        m_e_new_row_position = i_e_new_row_position
    End Sub

    Public Overridable Sub StartInsert()
        Debug.Assert((m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.none) _
                        Or (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.insert_mode), _
                        "FlexGrid co mode update hoac delete khi goi startInsert")
        If (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.none) Then
            m_us_cur.ClearAllFields()
            Dim v_obj_even_arg As New CC1InplaceEdittingEventArgs(True)
            RaiseEvent BeforeInsert(Me, v_obj_even_arg)
            If (v_obj_even_arg.continue_editting) Then
                'Them hang vao grid
                'If (m_fg.Rows.Count = m_fg.Rows.Fixed) Then
                '    m_fg.Rows.Add()
                '    m_fg.Focus()
                '    m_fg.Row = m_fg.Rows.Count - 1
                '    m_fg.Col = m_fg.Cols.Fixed
                'Else
                '    Dim v_i_new_grid_row As Integer = m_fg.Row + 1
                '    m_fg.Rows.Insert(v_i_new_grid_row)
                '    m_fg.Focus()
                '    m_fg.Row = v_i_new_grid_row
                '    m_fg.Col = m_fg.Cols.Fixed
                '    m_fg.ShowCell(v_i_new_grid_row, m_fg.Col)
                'End If
                Dim v_i_new_grid_row As Integer = get_new_row_position()
                m_fg.Rows.Insert(v_i_new_grid_row)
                m_fg.ShowCell(v_i_new_grid_row, m_fg.Col)
                m_fg.Focus()
                m_fg.Row = v_i_new_grid_row
                m_fg.Col = m_fg.Cols.Fixed
                m_obj_edit_controller.StartInsert()
            Else
                CancelEdit()
            End If
        End If
    End Sub

    Public Overridable Sub StartUpdate()
        Debug.Assert((m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.none) _
                        Or (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.update_mode) _
                        Or (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.insert_mode), _
                        "FlexGrid co mode delete khi goi startUpdate")
        If (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.none) Then
            m_us_cur.ClearAllFields()
            Dim v_obj_even_arg As New CC1InplaceEdittingEventArgs(True)
            RaiseEvent BeforeUpdate(Me, v_obj_even_arg)
            If (v_obj_even_arg.continue_editting) Then
                m_obj_edit_controller.StartUpdate()
            Else
                CancelEdit()
            End If
        End If
    End Sub

    Public Overridable Sub StartDelete()
        Debug.Assert((m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.none) _
                        Or (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.delete_mode), _
                        "FlexGrid co mode insert hoac update khi goi startDelete")
        If (m_obj_edit_controller.editting_mode = e_CC1InplaceEdittingMode.none) Then
            m_us_cur.ClearAllFields()
            Dim v_obj_even_arg As New CC1InplaceEdittingEventArgs(True)
            RaiseEvent BeforeDelete(Me, v_obj_even_arg)
            If (v_obj_even_arg.continue_editting) Then
                m_obj_edit_controller.StartDelete()
                'RemoveHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
                CommitEdit()
                'AddHandler m_fg.BeforeRowColChange, AddressOf catch_m_fg_before_row_col_change
            Else
                CancelEdit()
            End If
        End If
    End Sub

    Public Sub CommitEdit()
        m_obj_edit_controller.CommitEdit()
    End Sub

    Public Sub CancelEdit()
        Select Case m_obj_edit_controller.editting_mode
            Case e_CC1InplaceEdittingMode.insert_mode
            Case e_CC1InplaceEdittingMode.update_mode
            Case e_CC1InplaceEdittingMode.delete_mode
            Case e_CC1InplaceEdittingMode.none
        End Select
        m_us_cur.Rollback()
        m_obj_edit_controller.CancelEdit()
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

    Private Sub catch_fg_StartEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
        Try
            If (Not CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) Then Exit Sub
            If (Not CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) Then Exit Sub
            StartUpdate()
        Catch v_e As Exception
            e.Cancel = True
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub grid_2_us_object(ByVal i_us_object As US_Object, ByVal i_grid_row As Integer)
        Dim v_dr_cur As DataRow
        v_dr_cur = CType(m_fg.Rows(i_grid_row).UserData, DataRow)
        i_us_object.DataRow2Me(v_dr_cur)
    End Sub

    Private Sub us_object_2_grid(ByVal i_us_object As US_Object, ByVal i_grid_row As Integer)
        If (m_fg.Rows(i_grid_row).UserData Is Nothing) Then
            m_fg.Rows(i_grid_row).UserData = m_ds_source.Tables(0).NewRow()
        End If
        Dim v_dr_but_toan As DataRow = CType(m_fg.Rows(i_grid_row).UserData, DataRow)
        i_us_object.Me2DataRow(v_dr_but_toan)
        m_obj_transfer.DataRow2GridRow(v_dr_but_toan, i_grid_row)
    End Sub

    Private Sub restored_old_grid_data(ByVal i_grid_row As Integer)
        Dim v_dr_cur As DataRow = m_fg.Rows(i_grid_row).UserData
        m_obj_transfer.DataRow2GridRow(v_dr_cur, i_grid_row)
    End Sub

    Private Sub m_obj_edit_controller_BeforeUpdate(ByVal sender As Object, ByVal e As CC1InplaceEdittingEventArgs)
        Try
            Dim v_i_grid_row As Integer = m_fg.Row
            m_us_cur.ClearAllFields()
            grid_2_us_object(m_us_cur, v_i_grid_row)
            m_us_cur.BeginTransaction()
            If (m_us_cur.isUpdatable()) Then
                e.continue_editting = True
            End If
        Catch v_e As Exception
            m_us_cur.Rollback()
            e.continue_editting = False
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_OnUpdate(ByVal sender As Object, ByVal e As CC1InplaceEdittingOnEventArgs)
        Try
            m_us_cur.Update()
            Dim v_e As New CC1InplaceEdittingOnEventArgs(e_CC1_inplace_editting_next_action.success_and_change_to_none_status)
            RaiseEvent OnUpdate(Me, v_e)
            If (v_e.next_action = e_CC1_inplace_editting_next_action.success_and_change_to_none_status) Then
                m_us_cur.CommitTransaction()
                us_object_2_grid(m_us_cur, m_fg.Row)
                e.next_action = e_CC1_inplace_editting_next_action.success_and_change_to_none_status
            End If
        Catch v_e As Exception
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
            e.next_action = e_CC1_inplace_editting_next_action.continue_editting
        End Try
    End Sub

    Private Sub m_obj_edit_controller_OnCancelUpdate(ByVal sender As Object, ByVal e As EventArgs)
        Try
            m_us_cur.Rollback()
            'Dua du lieu cu len grid
            restored_old_grid_data(m_fg.Row)
            RaiseEvent OnCancelUpdate(Me, New EventArgs)
        Catch v_e As Exception
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_BeforeInsert(ByVal sender As Object, ByVal e As CC1InplaceEdittingEventArgs)
        Try
            m_us_cur.BeginTransaction()
            e.continue_editting = True
        Catch v_e As Exception
            e.continue_editting = False
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_OnInsert(ByVal sender As Object, ByVal e As CC1InplaceEdittingOnEventArgs)
        Try
            Dim v_e As New CC1InplaceEdittingOnEventArgs(e_CC1_inplace_editting_next_action.success_and_change_to_none_status)
            m_us_cur.Insert()
            RaiseEvent OnInsert(Me, v_e)
            If (v_e.next_action = e_CC1_inplace_editting_next_action.success_and_change_to_none_status) Then
                m_us_cur.CommitTransaction()
                us_object_2_grid(m_us_cur, m_fg.Row)
            End If
        Catch v_e As Exception
            e.next_action = e_CC1_inplace_editting_next_action.continue_editting
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_OnCancelInsert(ByVal sender As Object, ByVal e As EventArgs)
        Try
            m_fg.Rows.Remove(m_fg.Row)
            RaiseEvent OnCancelDelete(Me, New System.EventArgs)
        Catch v_e As Exception
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_BeforeDelete(ByVal sender As Object, ByVal e As CC1InplaceEdittingEventArgs)
        Try
            Dim v_i_grid_row As Integer = m_fg.Row
            grid_2_us_object(m_us_cur, v_i_grid_row)
            m_us_cur.BeginTransaction()
            If (m_us_cur.isUpdatable()) Then
                e.continue_editting = True
            End If
        Catch v_e As Exception
            m_us_cur.Rollback()
            e.continue_editting = False
            Dim v_objErrHandler = New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_OnDelete(ByVal sender As Object, ByVal e As CC1InplaceEdittingOnEventArgs)
        Try
            Dim v_e As New CC1InplaceEdittingOnEventArgs(e_CC1_inplace_editting_next_action.success_and_change_to_none_status)
            m_us_cur.Delete()
            RaiseEvent OnDelete(Me, v_e)
            If (v_e.next_action = e_CC1_inplace_editting_next_action.success_and_change_to_none_status) Then
                m_us_cur.CommitTransaction()
                m_fg.Rows.Remove(m_fg.Row)
            End If
        Catch v_e As Exception
            e.next_action = e_CC1_inplace_editting_next_action.continue_editting
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub m_obj_edit_controller_OnCancelDelete(ByVal sender As Object, ByVal e As EventArgs)
        Try
            m_us_cur.Rollback()
            RaiseEvent OnCancelDelete(Me, New EventArgs)
        Catch v_e As Exception
            Dim v_objErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_objErrHandler.showErrorMessage()
        End Try
    End Sub
#End Region


End Class
