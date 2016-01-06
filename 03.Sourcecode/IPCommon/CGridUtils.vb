Option Explicit On 
Option Strict On

Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms

Public Class CGridUtils


#Region "public "
    Public Shared Sub MakeSoTT(ByVal i_col As Integer, ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        Debug.Assert(i_col >= 0 And i_col <= i_fg.Cols.Count - 1, "Chi so cot khong co -MTV ")
        Dim v_RowIndex As Integer
        Dim v_i_stt As Integer = 1
        For v_RowIndex = i_fg.Rows.Fixed To i_fg.Rows.Count - 1
            i_fg(v_RowIndex, i_col) = v_i_stt
            v_i_stt += 1
        Next
    End Sub

    Public Shared Sub MakeSoTTByLevelofRow(ByVal i_colSTT As Integer, _
                                                ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                                                ByVal i_Level As Integer, _
                                                ByVal i_restartSTT_WhenLevel_isChanged As Boolean)
        Dim v_iRowIndex As Integer
        Dim v_iCurrLevel As Integer
        Dim v_iSTT As Integer = 1
        For v_iRowIndex = i_fg.Rows.Fixed To i_fg.Rows.Count - 1

            If i_fg.Rows(v_iRowIndex).Node.Level = i_Level Then
                i_fg(v_iRowIndex, i_colSTT) = v_iSTT
                v_iSTT += 1
            ElseIf i_restartSTT_WhenLevel_isChanged Then
                v_iSTT = 1
            End If
        Next
    End Sub

    Public Shared Sub MakeSoTTofRowNotIsNode(ByVal i_colSTT As Integer, _
                                                ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                                                ByVal i_restartSTT_WhenLevel_isChanged As Boolean)
        Dim v_iRowIndex As Integer
        Dim v_iSTT As Integer = 1
        For v_iRowIndex = i_fg.Rows.Fixed To i_fg.Rows.Count - 1
            If i_fg.Rows(v_iRowIndex).IsNode = True Then
                If i_restartSTT_WhenLevel_isChanged Then
                    v_iSTT = 1
                End If
            Else
                i_fg(v_iRowIndex, i_colSTT) = v_iSTT
                v_iSTT += 1
            End If
        Next
    End Sub

    Public Shared Sub AllowEditingCols(ByVal i_FromCol As Integer, ByVal i_ToCol As Integer, ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        Debug.Assert(i_FromCol >= i_fg.Cols.Fixed, "FromCol < Cot nho nhat cua Grid -MTV ")
        Debug.Assert(i_ToCol <= i_fg.Cols.Count - 1, "ToCol > tong so cot cua grid -MTV ")
        Debug.Assert(i_FromCol <= i_ToCol, "FromCol phai nho hon ToCol -MTV ")
        Dim v_ColIndex As Integer
        For v_ColIndex = i_FromCol To i_ToCol
            i_fg.Cols(v_ColIndex).AllowEditing = True
        Next
    End Sub

    Public Shared Sub DisAllowEditingCols(ByVal i_FromCol As Integer, ByVal i_ToCol As Integer, ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        Debug.Assert(i_FromCol >= i_fg.Cols.Fixed, "FromCol < Cot nho nhat cua Grid -MTV ")
        Debug.Assert(i_ToCol <= i_fg.Cols.Count - 1, "ToCol > tong so cot cua grid -MTV ")
        Debug.Assert(i_FromCol <= i_ToCol, "FromCol phai nho hon ToCol -MTV ")
        Dim v_ColIndex As Integer
        For v_ColIndex = i_FromCol To i_ToCol
            i_fg.Cols(v_ColIndex).AllowEditing = False
        Next
    End Sub

    Public Shared Sub HideCols(ByVal i_FromCol As Integer, ByVal i_ToCol As Integer, ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        Debug.Assert(i_FromCol >= i_fg.Cols.Fixed, "FromCol < Cot nho nhat cua Grid -MTV ")
        Debug.Assert(i_ToCol <= i_fg.Cols.Count - 1, "ToCol > tong so cot cua grid -MTV ")
        Debug.Assert(i_FromCol <= i_ToCol, "FromCol phai nho hon ToCol -MTV ")
        Dim v_ColIndex As Integer
        For v_ColIndex = i_FromCol To i_ToCol
            i_fg.Cols(v_ColIndex).Visible = False
        Next
    End Sub

    Public Shared Sub ShowCols(ByVal i_FromCol As Integer, ByVal i_ToCol As Integer, ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        Debug.Assert(i_FromCol >= i_fg.Cols.Fixed, "FromCol < Cot nho nhat cua Grid -MTV ")
        Debug.Assert(i_ToCol <= i_fg.Cols.Count - 1, "ToCol > tong so cot cua grid -MTV ")
        Debug.Assert(i_FromCol <= i_ToCol, "FromCol phai nho hon ToCol -MTV ")
        Dim v_ColIndex As Integer
        For v_ColIndex = i_FromCol To i_ToCol
            i_fg.Cols(v_ColIndex).Visible = True
        Next
    End Sub

    Public Shared Function isValidColIndex(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                                             ByVal i_col As Integer) As Boolean
        Return i_col >= 0 And i_col <= i_fg.Cols.Count - 1
    End Function

    Public Shared Function isValid_NonFixed_RowIndex(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                                                ByVal i_row As Integer) As Boolean

        If i_fg.Rows.Count = 0 Then Return False
        Return i_row >= i_fg.Rows.Fixed And i_row <= i_fg.Rows.Count - 1
    End Function

    Public Shared Function IsThere_Any_NonFixed_Row(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid) As Boolean
        Return i_fg.Rows.Count > i_fg.Rows.Fixed
    End Function

    Public Shared Sub ClearDataInGrid(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        If i_fg.Rows.Count = i_fg.Rows.Fixed Then Exit Sub
        i_fg.Rows.Count = i_fg.Rows.Fixed
    End Sub

    Public Shared Sub stand_on_TopLeft_Cell(ByVal i_fg As C1FlexGrid)
        If Not IsThere_Any_NonFixed_Row(i_fg) Then Exit Sub
        Dim v_visible_column_found As Boolean = False
        Dim v_first_visible_column_Index As Integer = i_fg.Cols.Fixed
        While v_first_visible_column_Index <= i_fg.Cols.Count - 1
            If i_fg.Cols(v_first_visible_column_Index).Visible Then
                v_visible_column_found = True
                Exit While
            End If
            v_first_visible_column_Index += 1
        End While

        If v_visible_column_found Then
            i_fg.Row = i_fg.Rows.Fixed
            i_fg.Col = v_first_visible_column_Index
        End If
    End Sub

    Public Shared Sub AddTree_Toogle_Handlers(ByVal i_fg As C1FlexGrid)
        AddHandler i_fg.KeyDown, AddressOf grid_KeydownEnter_In_Tree
        AddHandler i_fg.DoubleClick, AddressOf grid_DoubleClick
    End Sub

    Public Shared Sub AddSearch_Handlers(ByVal i_fg As C1FlexGrid)
        AddHandler i_fg.KeyDown, AddressOf grid_Keydown_Search
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Thêm chức năng Save cho grid
    ''' </summary>
    ''' <param name="i_fg"></param>
    ''' <remarks>
    ''' Thường được gọi tại format control
    ''' </remarks>
    ''' <history>
    ''' 	[tund]	26/04/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Shared Sub AddSave_Excel_Handlers(ByVal i_fg As C1FlexGrid)
        AddHandler i_fg.KeyDown, AddressOf grid_Keydown_Save
        add_PopUp_Menu(i_fg)

    End Sub

    Public Shared Sub SetCellImage(ByVal i_image As System.Drawing.Image, _
                                    ByVal i_fg As C1FlexGrid, _
                                    ByVal i_row As Integer, _
                                    ByVal i_col As Integer)

        Debug.Assert(i_col >= i_fg.Cols.Fixed And _
                     i_col <= i_fg.Cols.Count - 1 And _
                     i_row >= i_fg.Rows.Fixed And _
                     i_row <= i_fg.Rows.Count - 1, "Invalid cell range-csung")

        Dim v_cellrange As CellRange = i_fg.GetCellRange(i_row, i_col)
        v_cellrange.Image = i_image
    End Sub

    Public Shared Sub Dataset2C1Grid(ByVal i_ds As DataSet _
                                , ByVal i_fg As C1FlexGrid _
                                , ByVal i_oTransfer As ITransferDataRow)
        Debug.Assert(Not i_ds Is Nothing, "Chua khoi tao Dataset - tuanqt")
        Debug.Assert(Not i_fg Is Nothing, "Chua khoi tao fg - tuanqt")
        Debug.Assert(Not i_oTransfer Is Nothing, "Chua khoi tao transfer object - tuanqt")
        Dim v_i_cur_row As Integer = i_fg.Row
        i_fg.Rows.Count = i_fg.Rows.Fixed
        If i_ds.Tables(0).Rows.Count > 0 Then
            Dim v_iRowIndex As Integer = i_fg.Rows.Fixed
            Dim v_dr As DataRow
            For Each v_dr In i_ds.Tables(0).Rows
                i_fg.Rows.Add()
                i_fg.Rows(v_iRowIndex).UserData = v_dr
                i_oTransfer.DataRow2GridRow(v_dr, v_iRowIndex)
                v_iRowIndex += 1
            Next

            ' add column name
            Dim v_hst As New Hashtable()
            v_hst = i_oTransfer.getHastableMapping()
            Dim v_obj As Object
            Dim v_strColName As String
            Dim v_iColNumber As Integer
            For Each v_obj In v_hst.Keys
                v_strColName = CType(v_obj, String)
                v_iColNumber = CType(v_hst(v_strColName), Integer)
                i_fg.Cols(v_iColNumber).UserData = v_strColName

            Next

            If (i_fg.Rows.Count > v_i_cur_row) Then
                i_fg.Row = v_i_cur_row
            Else
                i_fg.Row = i_fg.Rows.Count - 1
            End If
        End If
    End Sub

    Public Shared Sub WrapWordInOneCell(ByVal i_fg As C1FlexGrid _
                                            , ByVal i_iRow As Integer _
                                            , ByVal i_iCol As Integer)
        Dim v_csCellStyle As C1.Win.C1FlexGrid.CellStyle
        v_csCellStyle = i_fg.GetCellStyleDisplay(i_iRow, i_iCol)
        v_csCellStyle.WordWrap = True
    End Sub

    Public Shared Sub SetFocusOnOneCell(ByVal i_fg As C1FlexGrid _
                                        , ByVal i_iRow As Integer _
                                        , ByVal i_iCol As Integer)
        i_fg.Select(i_iRow, i_iCol)
        i_fg.ShowCell(i_iRow, i_iCol)
    End Sub

    Public Shared Sub setTreeLevelOfRow(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, ByVal i_row As Integer, ByVal i_level As Integer)
        i_fg.Rows(i_row).IsNode = True
        i_fg.Rows(i_row).Node.Level = i_level
    End Sub

    Public Shared Sub FillColumnWithString(ByVal i_col As Integer, ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid _
                                        , ByVal i_strValue As String)
        Debug.Assert(i_col >= i_fg.Cols.Fixed And i_col <= i_fg.Cols.Count - 1, "Chi so cot khong co -MTV ")
        Dim v_RowIndex As Integer
        For v_RowIndex = i_fg.Rows.Fixed To i_fg.Rows.Count - 1
            i_fg(v_RowIndex, i_col) = i_strValue
        Next
    End Sub
#End Region

#Region "PRIVATES"
    Private Shared Sub grid_Keydown_Save(ByVal sender As Object, _
                          ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Windows.Forms.Keys.S And e.Control Then
            Dim v_fg As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
            Dim dlgSave As New System.Windows.Forms.SaveFileDialog


            dlgSave.Filter = "Excel Files |*.xls"
            dlgSave.FileName = "FMSTemplateFile.xls"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                v_fg.SaveExcel(dlgSave.FileName, "OutPut", FileFlags.IncludeFixedCells)
                'v_fg.SaveGrid(dlgSave.FileName, FileFormatEnum.TextTab, True, System.Text.Encoding.Unicode)
            End If

        End If
    End Sub
    Private Shared Sub add_PopUp_Menu(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        '1. create context mnu
        Dim v_context_mnu As New System.Windows.Forms.ContextMenu
        Dim v_mnu_save_image As New System.Windows.Forms.MenuItem
        v_context_mnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {v_mnu_save_image})
        v_mnu_save_image.Index = 0
        v_mnu_save_image.Text = "Save Excel"
        AddHandler v_mnu_save_image.Click, AddressOf grid_PopUp_Save
        '2. Add to grid
        i_fg.ContextMenu = v_context_mnu
    End Sub
    Private Shared Sub grid_PopUp_Save(ByVal sender As Object, _
                         ByVal e As System.EventArgs)
        Dim v_mnu_save_image As System.Windows.Forms.MenuItem = CType(sender, System.Windows.Forms.MenuItem)
        Dim v_context_mnu As System.Windows.Forms.ContextMenu = CType(v_mnu_save_image.Parent, System.Windows.Forms.ContextMenu)
        Dim v_fg As C1.Win.C1FlexGrid.C1FlexGrid = CType(v_context_mnu.SourceControl, C1.Win.C1FlexGrid.C1FlexGrid)

        Dim dlgSave As New System.Windows.Forms.SaveFileDialog
        dlgSave.Filter = "Excel Files |*.xls"
        dlgSave.FileName = "FMSTemplateFile.xls"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            v_fg.SaveExcel(dlgSave.FileName, "OutPut", FileFlags.IncludeFixedCells)
            'v_fg.SaveGrid(dlgSave.FileName, FileFormatEnum.TextTab, True, System.Text.Encoding.Unicode)
        End If
    End Sub
    Private Shared Sub grid_DoubleClick(ByVal sender As Object, _
                                 ByVal e As EventArgs)
        Dim v_fg As C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        If v_fg.Tree.Column = v_fg.Col Then
            ToggleNodeState(v_fg)
        End If
    End Sub



    Private Shared Sub grid_KeydownEnter_In_Tree(ByVal sender As Object, _
                           ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim v_fg As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            ToggleNodeState(v_fg)
        End If
    End Sub

    Private Shared Sub grid_Keydown_Search(ByVal sender As Object, _
                            ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Windows.Forms.Keys.F And e.Control Then
            Dim v_fg As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
            startSearchForm(v_fg, v_fg.FindForm)
        End If
    End Sub

    Private Shared Sub ToggleNodeState(ByVal i_fg As C1FlexGrid)
        'if in edit mode , no work
        If Not (i_fg.Editor) Is Nothing Then Exit Sub
        ' if the current row is not a node, no work
        Dim v_row As Row = i_fg.Rows(i_fg.Row)
        If Not v_row.IsNode Then Exit Sub
        ' toggle collapsed state
        v_row.Node.Collapsed = Not v_row.Node.Collapsed
    End Sub

    Private Shared Sub startSearchForm(ByVal i_fg As C1FlexGrid, ByVal i_form As Form)
        CSearchInColumnOfFlexGrid.display_Search_in_CurrentColumn(i_fg, i_form)
    End Sub
#End Region

End Class
