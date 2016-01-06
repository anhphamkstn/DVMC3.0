'Nhiệm vụ của Class:
' Goal: thực hiện tìm kiếm trên các cột của C1, FlexGrid 
'
'
Option Explicit On 
Option Strict On
Imports System.Windows.Forms
Public Class CSearchInColumnOfFlexGrid
    Implements ISearchable

#Region "Data Structures"
    Private Enum GridDataType2Search
        Text_Data
        DateTime_Data
        Numeric_Data
    End Enum
#End Region

#Region "Variables"
    Private m_dataType2Search As GridDataType2Search
    Private m_searchForm As ISearchForm
    Private m_dataForm As Form
    Private m_fg As C1.Win.C1FlexGrid.C1FlexGrid
    Private m_col2Search As Integer
#End Region

#Region "PUBLIC INTERFACES"

    Public Sub New(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                   ByVal i_col As Integer, _
                   ByVal i_dataForm As Form)

        Debug.Assert(Not (i_fg Is Nothing), "Chửa khởi tạo Grid")
        Debug.Assert(i_col >= i_fg.Cols.Fixed, "Column index quá bé")
        Debug.Assert(i_col <= i_fg.Cols.Count - 1, "Column index quá lớn")


        m_fg = i_fg
        m_col2Search = i_col

        If i_fg.Rows.Count = i_fg.Rows.Fixed Then
            Exit Sub ' khong co du lieu de search
        End If

        If i_fg.Cols(i_col).DataType Is System.Type.GetType("System.String") Then
            m_dataType2Search = GridDataType2Search.Text_Data
            m_searchForm = New frmSearchString() ' day la form de ma search
        ElseIf i_fg.Cols(i_col).DataType Is System.Type.GetType("System.Double") Or _
               i_fg.Cols(i_col).DataType Is System.Type.GetType("System.Decimal") Then
            m_dataType2Search = GridDataType2Search.Numeric_Data
            m_searchForm = New frmSearchNumeric()
        ElseIf i_fg.Cols(i_col).DataType Is System.Type.GetType("System.DateTime") Then
            m_dataType2Search = GridDataType2Search.DateTime_Data
            m_searchForm = New frmSearchDate()
        Else
            Debug.Assert(False, "Loại dữ liệu của column không tìm được")
        End If
    End Sub

    Private Sub displaySearchForm()
        If Not m_fg.Cols(m_col2Search).Visible Then Exit Sub
        m_searchForm.displaySearch(Me)
    End Sub

    Public Function startSearch(ByVal i_SearchConditionObject As IFoundCondition, _
                                ByVal i_searchtype As SearchType) As Boolean Implements ISearchable.startSearch
        If m_fg.Rows.Count <= m_fg.Rows.Fixed Then
            Return False
        End If

        Try
            Dim v_found As Boolean = False
            Dim v_i As Integer = 1
            If i_searchtype = SearchType.fromNextRow Then
                v_i = m_fg.Row + 1
            End If

            If v_i > m_fg.Rows.Count - 1 Then ' o qua hang cuoi roi
                Return False
            End If

            While Not v_found And v_i <= m_fg.Rows.Count - 1
                If i_SearchConditionObject.MatchThePattern(m_fg(v_i, m_col2Search)) Then
                    v_found = True
                Else
                    v_i += 1
                End If
            End While
            If v_found Then
                m_fg.Row = v_i
                m_fg.ShowCell(m_fg.Row, m_col2Search)
            End If
            Return v_found
        Catch v_e As Exception
            Return False
        End Try
    End Function

    Public Shared Sub display_Search_in_CurrentColumn(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                                                     ByVal i_dataForm As Form)

        Debug.Assert(Not (i_fg Is Nothing), "Chửa khởi tạo Grid - Csung")
        If i_fg.Cols(i_fg.Col).DataType Is System.Type.GetType("System.Boolean") Then
            Exit Sub
        End If
        If Not i_fg.Editor Is Nothing Then Exit Sub
        Dim v_bAcceptedDataType As Boolean = IsAcceptedDataType(i_fg.Cols(i_fg.Col).DataType)
        Debug.Assert(v_bAcceptedDataType, "Datatype của column không tìm kiếm được - Csung ")
        If Not i_fg.Cols(i_fg.Col).Visible Then Exit Sub ' column khong nhin thay
        If i_fg.Rows.Count = i_fg.Rows.Fixed Then Exit Sub ' khong co data

        Dim v_search As CSearchInColumnOfFlexGrid = New CSearchInColumnOfFlexGrid(i_fg, i_fg.Col, i_dataForm)
        v_search.displaySearchForm()
    End Sub

    Private Shared Function IsAcceptedDataType(ByVal i_dataType As System.Type) As Boolean
        Return i_dataType Is System.Type.GetType("System.String") Or _
                i_dataType Is System.Type.GetType("System.Double") Or _
                i_dataType Is System.Type.GetType("System.Decimal") Or _
                i_dataType Is System.Type.GetType("System.DateTime")
    End Function

#End Region

End Class
