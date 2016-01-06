Option Explicit On 
Option Strict On
Imports C1.Win.C1FlexGrid
Imports Excel

Public Interface IExportColumn
    Sub Export()
    Sub ExportWithoutFixedRows()
End Interface

Public Class CExportColumnFactory
    Private m_fg As C1FlexGrid
    Private m_objWorkSheet As Worksheet

    Public Sub New(ByVal i_fg As C1FlexGrid, ByVal i_objWorkSheet As Excel.Worksheet)
        m_fg = i_fg
        m_objWorkSheet = i_objWorkSheet
    End Sub

    Public Function CreateExportColumn(ByVal i_iGridCol As Integer _
                                    , ByVal i_iSheetCol As Integer _
                                    , ByVal i_iSheetStartRow As Integer) As IExportColumn
        Dim v_objExportCol As New CObjectExportColumn(m_fg _
                                                , m_objWorkSheet _
                                                , i_iGridCol _
                                                , i_iSheetCol _
                                                , i_iSheetStartRow)
        Return v_objExportCol
    End Function
End Class

Public Class CObjectExportColumn
    Implements IExportColumn

    Private m_fg As C1FlexGrid
    Private m_objWorkSheet As Worksheet
    Private m_iGridCol As Integer
    Private m_iSheetCol As Integer
    Private m_iSheetStartRow As Integer

    Public Sub New(ByVal i_fg As C1FlexGrid _
                    , ByVal i_objWorkSheet As Excel.Worksheet _
                    , ByVal i_iGridCol As Integer _
                    , ByVal i_iSheetCol As Integer _
                    , ByVal i_iSheetStartRow As Integer)
        m_fg = i_fg
        m_objWorkSheet = i_objWorkSheet
        m_iGridCol = i_iGridCol
        m_iSheetCol = i_iSheetCol
        m_iSheetStartRow = i_iSheetStartRow
    End Sub

    Public Sub Export() Implements IExportColumn.Export
        Dim v_iGridRow As Integer
        Dim v_iSheetRow As Integer = m_iSheetStartRow
        For v_iGridRow = 0 To m_fg.Rows.Count - 1
            If (m_fg.Rows(v_iGridRow).Visible = True) Then
                m_objWorkSheet.Cells(v_iSheetRow, m_iSheetCol) = _
                                    m_fg(v_iGridRow, m_iGridCol)
                v_iSheetRow += 1
            End If
            
        Next
        DrawGrid(m_fg.Rows.Count - 1)
    End Sub

    Public Sub ExportWithoutFixedRows() Implements IExportColumn.ExportWithoutFixedRows
        Dim v_iGridRow As Integer
        Dim v_iFixedRow As Integer = m_fg.Rows.Fixed
        Dim v_iSheetRow As Integer = m_iSheetStartRow
        For v_iGridRow = v_iFixedRow To m_fg.Rows.Count - 1
            If (m_fg.Rows(v_iGridRow).Visible = True) Then
                m_objWorkSheet.Cells(v_iSheetRow, m_iSheetCol) = _
                                    m_fg(v_iGridRow, m_iGridCol)
                v_iSheetRow += 1
            End If            
        Next
        If m_fg.Rows.Count = 2 Then
            DrawGrid(m_fg.Rows.Count - v_iFixedRow)
        Else
            DrawGrid(m_fg.Rows.Count - 1 - v_iFixedRow)
        End If
    End Sub

    Private Sub DrawGrid(ByVal i_total_row As Integer)
        Dim v_obj_sel As Excel.Range
        v_obj_sel = m_objWorkSheet.Range(m_objWorkSheet.Cells(m_iSheetStartRow, m_iSheetCol) _
                                    , m_objWorkSheet.Cells(m_iSheetStartRow + i_total_row, m_iSheetCol))
        'v_obj_sel.Select()

        v_obj_sel.Borders(XlBordersIndex.xlDiagonalDown).LineStyle = XlLineStyle.xlLineStyleNone
        v_obj_sel.Borders(XlBordersIndex.xlDiagonalUp).LineStyle = XlLineStyle.xlLineStyleNone

        With v_obj_sel.Borders(XlBordersIndex.xlEdgeLeft)
            .LineStyle = XlLineStyle.xlContinuous
            .Weight = XlBorderWeight.xlThin
            .ColorIndex = XlColorIndex.xlColorIndexAutomatic
        End With

        With v_obj_sel.Borders(XlBordersIndex.xlEdgeTop)
            .LineStyle = XlLineStyle.xlContinuous
            .Weight = XlBorderWeight.xlThin
            .ColorIndex = XlColorIndex.xlColorIndexAutomatic
        End With

        With v_obj_sel.Borders(XlBordersIndex.xlEdgeBottom)
            .LineStyle = XlLineStyle.xlContinuous
            .Weight = XlBorderWeight.xlThin
            .ColorIndex = XlColorIndex.xlColorIndexAutomatic
        End With

        With v_obj_sel.Borders(XlBordersIndex.xlEdgeRight)
            .LineStyle = XlLineStyle.xlContinuous
            .Weight = XlBorderWeight.xlThin
            .ColorIndex = XlColorIndex.xlColorIndexAutomatic
        End With

        With v_obj_sel.Borders(XlBordersIndex.xlInsideHorizontal)
            .LineStyle = XlLineStyle.xlContinuous
            .Weight = XlBorderWeight.xlThin
            .ColorIndex = XlColorIndex.xlColorIndexAutomatic
        End With
        'm_objWorkSheet.Range(m_objWorkSheet.Cells(1, 1) _
        '                                   , m_objWorkSheet.Cells(1, 1)).Select()
    End Sub

End Class


