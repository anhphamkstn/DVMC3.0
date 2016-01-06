Imports C1.Win.C1FlexGrid
Public Class CC1TransferDataRow
    Implements ITransferDataRow
    Private m_fg As C1FlexGrid
    Private m_htbColMapping As Hashtable
    Private m_arrCol As ArrayList
    Private m_dr As DataRow

    Sub New(ByVal i_fg As C1FlexGrid, ByVal i_htbColMapping As Hashtable, ByVal i_drPrototype As DataRow)
        m_fg = i_fg
        m_htbColMapping = i_htbColMapping
        m_dr = i_drPrototype
        BuildArrCol()
    End Sub
    Private Sub BuildArrCol()
        m_arrCol = New ArrayList()
        Dim v_obj As Object
        Dim v_strColName As String
        Dim v_iColNumber As Integer
        Dim v_oTransData As ITransferDataCell
        Dim v_oCreate As New CTransferFactory()

        For Each v_obj In m_htbColMapping.Keys
            v_strColName = CType(v_obj, String)
            v_iColNumber = CType(m_htbColMapping(v_strColName), Integer)
            m_arrCol.Add(v_oCreate.CreateTransferObject(m_fg, _
                        v_iColNumber, m_dr, v_strColName))
        Next
    End Sub

    Private Sub GridRow2DataRow(ByVal i_Row As Integer, ByVal i_drDest As DataRow) Implements ITransferDataRow.GridRow2DataRow
        Dim v_obj As Object
        Dim v_CellTrans As ITransferDataCell
        For Each v_obj In m_arrCol
            v_CellTrans = CType(v_obj, ITransferDataCell)
            v_CellTrans.Cell2Data(i_Row, i_drDest)
        Next
    End Sub

    Private Sub DataRow2GridRow(ByVal i_drSource As DataRow, ByVal i_Row As Integer) Implements ITransferDataRow.DataRow2GridRow
        Dim v_obj As Object
        Dim v_CellTrans As ITransferDataCell
        For Each v_obj In m_arrCol
            v_CellTrans = CType(v_obj, ITransferDataCell)
            v_CellTrans.Data2Cell(i_drSource, i_Row)
        Next
    End Sub

    Private Function getHastableMapping() As Hashtable Implements ITransferDataRow.getHastableMapping
        Return m_htbColMapping
    End Function
End Class