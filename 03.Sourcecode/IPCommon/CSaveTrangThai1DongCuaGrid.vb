Option Strict On
Option Explicit On 

Public Class CSaveTrangThai1DongCuaGrid
    Private m_GiaTriCuaDong As ArrayList ' các cell trong dòng
    Private m_rowUserData As Object 'user data
    Private m_fg As C1.Win.C1FlexGrid.C1FlexGrid
    Private m_row_saved As Integer

    Public Sub New(ByVal i_c1fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                    ByVal i_Row As Integer)
        Debug.Assert(i_c1fg.Rows.Count > i_c1fg.Rows.Fixed, "Khong co du lieu - mtv")
        Debug.Assert(i_Row >= i_c1fg.Rows.Fixed And i_Row < i_c1fg.Rows.Count, "Dong sai roi - mtv")

        m_GiaTriCuaDong = New ArrayList()

        Dim v_iColIndex As Integer
        For v_iColIndex = 0 To i_c1fg.Cols.Count - 1
            m_GiaTriCuaDong.Add(i_c1fg(i_Row, v_iColIndex))
        Next
        m_fg = i_c1fg
        m_row_saved = i_Row
        m_rowUserData = i_c1fg.Rows(i_Row).UserData
    End Sub

    Public Sub UndoTrangThai1Dong(ByVal i_c1fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                    ByVal i_Row As Integer)
        Debug.Assert(i_c1fg.Rows.Count > i_c1fg.Rows.Fixed, "Khong co du lieu - mtv")
        Debug.Assert(i_Row >= i_c1fg.Rows.Fixed And i_Row < i_c1fg.Rows.Count, "Dong sai roi - mtv")
        Dim v_iColIndex As Integer
        For v_iColIndex = 0 To i_c1fg.Cols.Count - 1
            i_c1fg(i_Row, v_iColIndex) = m_GiaTriCuaDong(v_iColIndex)
        Next
        i_c1fg.Rows(i_Row).UserData = m_rowUserData
    End Sub


    Public Sub UndoTrangThai1Dong()
        Debug.Assert(Not (m_fg Is Nothing), "Chua save thi khong undo duoc - csung")
        Dim v_iColIndex As Integer
        For v_iColIndex = 0 To m_fg.Cols.Count - 1
            m_fg(m_row_saved, v_iColIndex) = m_GiaTriCuaDong(v_iColIndex)
        Next
        m_fg.Rows(m_row_saved).UserData = m_rowUserData
    End Sub
End Class
