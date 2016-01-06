Imports System.Windows.Forms
Public Class DataGrid_Custom
    Inherits System.Windows.Forms.DataGrid

    'Widnows designer generated code omitted.
    Public Delegate Sub DeleteRowEventHandler(ByVal sender As Object, ByVal e As DeleteRowEventArgs)
    Public Event DeleteRow As DeleteRowEventHandler

    Public Delegate Sub OutPlaceUpdateRowEventHandler(ByVal sender As Object, ByVal e As OutPlaceUpdateEventArgs)
    Public Event OutPlaceUpdateRow As OutPlaceUpdateRowEventHandler

    Public Delegate Sub OutPlaceInsertRowEventHandler(ByVal sender As Object, ByVal e As OutPlaceInsertEventArgs)
    Public Event OutPlaceInsertRow As OutPlaceInsertRowEventHandler

    Public Delegate Sub CellValidatedHandler(ByVal sender As Object, ByVal e As RowColChangedEventArgs)
    Public Event CellValidated As CellValidatedHandler

    Public Delegate Sub Custom_KeydownHandler(ByVal sender As Object, ByVal e As EventArgs)
    Public Event Custom_Keydown As Custom_KeydownHandler

    Private m_OldCol As Integer = -1
    Private m_OldRow As Integer = -1
    Private m_OldValue As String = ""
    Private m_NewCol As Integer
    Private m_NewRow As Integer

    'binding datatable ,form
    Private m_Form As Form
    Private WithEvents m_Table As DataTable
    Private WithEvents m_View As DataView
    Private WithEvents m_CurMan As CurrencyManager

    Public Sub SetBinding(ByVal i_Form As Form, ByVal i_Table As DataTable)
        m_Form = i_Form
        m_Table = i_Table
        Dim v_View As DataView
        v_View = m_Table.DefaultView
        v_View.AllowNew = False
        Me.SetDataBinding(v_View, "")
        m_View = v_View
        m_CurMan = CType(m_Form.BindingContext(v_View), CurrencyManager)
    End Sub

    Public Sub SetBindingWithView(ByVal i_Form As Form, ByVal i_View As DataView)
        m_Form = i_Form
        m_Table = i_View.Table
        i_View.AllowNew = False
        Me.SetDataBinding(i_View, "")
        m_View = i_View
        m_CurMan = CType(m_Form.BindingContext(i_View), CurrencyManager)
    End Sub

    'Tra ve hang hien tai
    Public Function getCurrentRow() As DataRow
        Return m_View(m_CurMan.Position).Row
    End Function

    'Tra ve CurMan
    Public Function getCurrencyManager() As CurrencyManager
        Return m_CurMan
    End Function

    'Tra ve View duoc binding
    Public Function getBindingView() As DataView
        Return m_View
    End Function

    'Bat su kien da xoa hang cua m_Table
    Private Sub m_Table_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles m_Table.RowDeleted
        m_Table.AcceptChanges()
        m_CurMan.Refresh()
        Me.Focus()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim v_KeyCode As Int32 = msg.WParam.ToInt32()

        If v_KeyCode = CInt(Keys.Delete) Then
            'If the whole row is selected when Delete key is pressed, prompt the User.
            If Me.IsSelected(Me.CurrentCell.RowNumber) Then
                If Not Me.DeleteRowAllowed() Then
                    Return True
                End If
            End If
        ElseIf v_KeyCode = CInt(Keys.F4) Then
            OutPlaceUpdate()
            Return True
        ElseIf v_KeyCode = CInt(Keys.F3) Then
            OutPlaceInsert()
            Return True
        ElseIf v_KeyCode = CInt(Keys.F5) Then
            If Not Me.DeleteRowAllowed() Then
                Return True
            End If
        Else
            RaiseCustom_Keydown()
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub RaiseCustom_Keydown()
        Dim v_e As New EventArgs()
        RaiseEvent Custom_Keydown(Me, v_e)
    End Sub

    Private Sub OutPlaceUpdate()
        Dim e As New OutPlaceUpdateEventArgs()
        e.Row = Me.getCurrentRow()
        RaiseEvent OutPlaceUpdateRow(Me, e)
        If Not e.Cancel Then
            m_Table.AcceptChanges()
            m_CurMan.Refresh()
        Else
            m_Table.RejectChanges()
        End If
        Me.Focus()
        Me.CurrentRowIndex = Me.CurrentCell.RowNumber
    End Sub

    Private Sub OutPlaceInsert()
        Dim e As New OutPlaceInsertEventArgs()
        RaiseEvent OutPlaceInsertRow(Me, e)
        If Not e.Cancel Then
            Dim v_row As DataRow = m_Table.NewRow()
            CopyRow(e.Row, v_row)
            m_Table.Rows.InsertAt(v_row, e.Position)
            m_Table.AcceptChanges()
            m_CurMan.Refresh()
            Me.Focus()
            Me.CurrentCell = New DataGridCell(e.Position, 0)
        End If
    End Sub

    Private Function CopyRow(ByVal i_FromRow As DataRow, ByVal i_ToRow As DataRow) As DataRow
        Dim v_Col As DataColumn
        For Each v_Col In i_FromRow.Table.Columns
            i_ToRow.Item(v_Col.ColumnName) = i_FromRow.Item(v_Col.ColumnName)
        Next
    End Function

    Private Function DeleteRowAllowed() As Boolean
        Dim e As New DeleteRowEventArgs()
        RaiseEvent DeleteRow(Me, e)
        If e.Cancel Then
            Return False  'Cannot Delete
        Else
            Me.getCurrentRow().Delete()
            Return True    'Deletion allowed
        End If
    End Function

    Protected Overrides Sub OnCurrentCellChanged(ByVal e As System.EventArgs)
        m_NewRow = Me.CurrentCell.RowNumber
        m_NewCol = Me.CurrentCell.ColumnNumber
        If m_NewRow <> m_OldRow Or m_NewCol <> m_OldCol Then
            If Not isCellChangedAllow() Then
                Me.CurrentCell = New DataGridCell(m_OldRow, m_OldCol)
                Exit Sub
            End If
            m_OldRow = m_NewRow
            m_OldCol = m_NewCol
            m_OldValue = Me(m_OldRow, m_OldCol).ToString()
        End If
    End Sub

    Private Function isCellChangedAllow() As Boolean
        Dim e As New RowColChangedEventArgs()
        'Neu la lan dau tien thi khong kiem tra
        If (m_OldRow = -1) And (m_OldCol = -1) Then
            Return True
        End If

        e.Col = m_OldCol
        e.Row = m_OldRow

        RaiseEvent CellValidated(Me, e)

        If e.Cancel Then
            Return False  'Cannot changed
        Else
            Return True    'Changed
        End If
    End Function

End Class

Public Class DeleteRowEventArgs
    Inherits EventArgs
    Private _Cancel As Boolean

    Public Sub New()
        _Cancel = True
    End Sub
    Public Property Cancel() As Boolean
        Get
            Return _Cancel
        End Get
        Set(ByVal Value As Boolean)
            _Cancel = Value
        End Set
    End Property
End Class

Public Class OutPlaceUpdateEventArgs
    Inherits EventArgs
    Private _Cancel As Boolean

    Public Sub New()
        _Cancel = True
    End Sub
    Public Property Cancel() As Boolean
        Get
            Return _Cancel
        End Get
        Set(ByVal Value As Boolean)
            _Cancel = Value
        End Set
    End Property

    Private m_DataRow As DataRow
    Public Property Row() As DataRow
        Get
            Return m_DataRow
        End Get
        Set(ByVal Value As DataRow)
            m_DataRow = Value
        End Set
    End Property

End Class

Public Class OutPlaceInsertEventArgs
    Inherits EventArgs
    Private _Cancel As Boolean

    Public Sub New()
        _Cancel = True
    End Sub
    Public Property Cancel() As Boolean
        Get
            Return _Cancel
        End Get
        Set(ByVal Value As Boolean)
            _Cancel = Value
        End Set
    End Property

    Private m_Position As Integer
    Public Property Position() As Integer
        Get
            Return m_Position
        End Get
        Set(ByVal Value As Integer)
            m_Position = Value
        End Set
    End Property

    Private m_DataRow As DataRow
    Public Property Row() As DataRow
        Get
            Return m_DataRow
        End Get
        Set(ByVal Value As DataRow)
            m_DataRow = Value
        End Set
    End Property
End Class

Public Class RowColChangedEventArgs
    Inherits EventArgs
    Private _Cancel As Boolean

    Public Sub New()
        _Cancel = False
    End Sub
    Public Property Cancel() As Boolean
        Get
            Return _Cancel
        End Get
        Set(ByVal Value As Boolean)
            _Cancel = Value
        End Set
    End Property

    Private m_row As Integer
    Public Property Row() As Integer
        Get
            Return m_row
        End Get
        Set(ByVal Value As Integer)
            m_row = Value
        End Set
    End Property

    Private m_col As Integer
    Public Property Col() As Integer
        Get
            Return m_col
        End Get
        Set(ByVal Value As Integer)
            m_col = Value
        End Set
    End Property
End Class