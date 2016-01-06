Imports System.Data
Imports C1.Win.C1FlexGrid
Imports ip.Core.IPCommon
Imports System.Collections

Public Interface ITransferDataRow
    Sub GridRow2DataRow(ByVal i_Row As Integer, ByVal i_drDest As DataRow)
    Sub DataRow2GridRow(ByVal i_drSource As DataRow, ByVal i_Row As Integer)
    Function getHastableMapping() As Hashtable
End Interface

Public Interface ITransferDataCell
    Sub Data2Cell(ByVal i_drSource As DataRow, ByVal i_Row As Integer)
    Sub Cell2Data(ByVal i_Row As Integer, ByVal i_drDest As DataRow)
End Interface

Public Class CTransferObjectData
    Implements ITransferDataCell
    Dim m_fg As C1FlexGrid
    Dim m_ColNumber As Integer
    Dim m_strColName As String

    Sub New(ByVal i_fg As C1FlexGrid, ByVal i_ColNumber As Integer, _
                    ByVal i_strColName As String)
        m_fg = i_fg
        m_ColNumber = i_ColNumber
        m_strColName = i_strColName
    End Sub

    Sub imp_Data2Cell(ByVal i_drSource As DataRow, ByVal i_Row As Integer) Implements ITransferDataCell.Data2Cell
        Try
            If Not i_drSource.IsNull(m_strColName) Then
                m_fg(i_Row, m_ColNumber) = i_drSource(m_strColName)
            Else
                m_fg(i_Row, m_ColNumber) = Nothing
            End If
        Catch v_e As Exception
            Debug.Assert(False, "Sai kieu cua datarow roi vi khong co col " & m_strColName & " - tuanqt")
        End Try
    End Sub

    Sub imp_Cell2Data(ByVal i_Row As Integer, ByVal i_drDest As DataRow) Implements ITransferDataCell.Cell2Data
        Try
            If m_fg(i_Row, m_ColNumber) Is Nothing Then
                i_drDest(m_strColName) = System.DBNull.Value
            Else
                i_drDest(m_strColName) = m_fg(i_Row, m_ColNumber)
            End If
        Catch v_e As Exception
            Debug.Assert(False, "Sai kieu cua datarow roi vi khong co col " & m_strColName & " - tuanqt")
        End Try
    End Sub

End Class

Public Class CTransferYNData
    Implements ITransferDataCell
    Dim m_fg As C1FlexGrid
    Dim m_ColNumber As Integer
    Dim m_strColName As String

    Sub New(ByVal i_fg As C1FlexGrid, ByVal i_ColNumber As Integer, _
                    ByVal i_strColName As String)
        m_fg = i_fg
        m_ColNumber = i_ColNumber
        m_strColName = i_strColName
    End Sub

    Sub imp_Data2Cell(ByVal i_drSource As DataRow, ByVal i_Row As Integer) Implements ITransferDataCell.Data2Cell
        Try
            If Not i_drSource.IsNull(m_strColName) Then
                m_fg(i_Row, m_ColNumber) = CUtil.YN2Boolean(CType(i_drSource(m_strColName), String))
            Else
                m_fg(i_Row, m_ColNumber) = Nothing
            End If
        Catch v_e As Exception
            Debug.Assert(False, "Sai kieu cua datarow roi vi khong co col " & m_strColName & " hoac col trong grid khong phai boolean - tuanqt")
        End Try
    End Sub

    Sub imp_Cell2Data(ByVal i_Row As Integer, ByVal i_drDest As DataRow) Implements ITransferDataCell.Cell2Data
        Try
            If m_fg(i_Row, m_ColNumber) Is Nothing Then
                i_drDest(m_strColName) = System.DBNull.Value
            Else
                i_drDest(m_strColName) = CUtil.Boolean2YN(CType(m_fg(i_Row, m_ColNumber), Boolean))
            End If
        Catch v_e As Exception
            Debug.Assert(False, "Sai kieu cua datarow roi vi khong co col " & m_strColName & " hoac col trong grid khong phai boolean - tuanqt")
        End Try
    End Sub
End Class

Public Class CTransferDateData
    Implements ITransferDataCell
    Dim m_fg As C1FlexGrid
    Dim m_ColNumber As Integer
    Dim m_strColName As String

    Sub New(ByVal i_fg As C1FlexGrid, ByVal i_ColNumber As Integer, _
                    ByVal i_strColName As String)
        m_fg = i_fg
        m_ColNumber = i_ColNumber
        m_strColName = i_strColName
    End Sub

    Sub imp_Data2Cell(ByVal i_drSource As DataRow, ByVal i_Row As Integer) Implements ITransferDataCell.Data2Cell
        Try
            If Not i_drSource.IsNull(m_strColName) Then
                If m_fg.Cols(m_ColNumber).DataType.ToString() = "System.String" Then
                    m_fg(i_Row, m_ColNumber) = Format(i_drSource(m_strColName), CDateTime.GetDateFormatString())
                Else
                    m_fg(i_Row, m_ColNumber) = i_drSource(m_strColName)
                End If
            Else
                    m_fg(i_Row, m_ColNumber) = Nothing
                End If
        Catch v_e As Exception
            Debug.Assert(False, "Sai kieu cua datarow roi vi khong co col " & m_strColName & " hoac col trong grid khong phai date - tuanqt")
        End Try
    End Sub

    Sub Cell2Data(ByVal i_Row As Integer, ByVal i_drDest As DataRow) Implements ITransferDataCell.Cell2Data
        Try
            If m_fg(i_Row, m_ColNumber) Is Nothing Then
                i_drDest(m_strColName) = System.DBNull.Value
            Else
                If m_fg.Cols(m_ColNumber).DataType.ToString() = "System.String" Then
                    i_drDest(m_strColName) = CDateTime.Str2Date(CType(m_fg(i_Row, m_ColNumber), String))
                Else
                    i_drDest(m_strColName) = m_fg(i_Row, m_ColNumber)
                End If

            End If
        Catch v_e As Exception
            Debug.Assert(False, "Sai kieu cua datarow roi vi khong co col " & m_strColName & " hoac col trong grid khong phai date - tuanqt")
        End Try
    End Sub

End Class

Public Class CTransferFactory
    Public Function CreateTransferObject(ByVal i_fg As C1FlexGrid, ByVal i_Col As Integer, _
                    ByVal i_drDataRow As DataRow, ByVal i_strColName As String) As ITransferDataCell
        Debug.Assert(Not i_fg.Cols(i_Col).DataType Is Nothing, "Chua gan kieu cho cot cua grid - tuanqt")
        Select Case i_fg.Cols(i_Col).DataType.ToString()
            Case "System.Boolean"
                Return New CTransferYNData(i_fg, i_Col, i_strColName)
            Case Else
                If i_drDataRow.Table.Columns(i_strColName).DataType Is GetType(DateTime) Then
                    Return New CTransferDateData(i_fg, i_Col, i_strColName)
                Else
                    Return New CTransferObjectData(i_fg, i_Col, i_strColName)
                End If
        End Select
    End Function

End Class