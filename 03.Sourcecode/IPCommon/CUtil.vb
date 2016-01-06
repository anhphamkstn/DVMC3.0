'Nhiệm vụ của ... file
'Định nghĩa các interface, datatype, ... dùng chung
'
Option Explicit On 
Option Strict On

Imports System.Windows.Forms

Public Interface I_IPDataMaintainForm
    ' Interface mà data maintain form sẽ phải thực hiện
    ' Thì mới có thể gọi được từ form Select
    Sub displayDataMaintain(ByVal i_constraintObject As Object)
End Interface

Public Enum SelectAction_byUser
    Canceled_by_User = 12
    Submited_by_User = 56
End Enum


Public Enum DataType
    NumberType = 0
    StringType = 1
    DateType = 2
End Enum

Public Class CUtil
    'Hàm kiểm tra ô Textbox có hợp lệ hay không
    Public Shared Function IsValidTextbox(ByVal i_txtCtrl As TextBox _
                , ByVal i_DataType As DataType _
                , ByVal i_AllowNull As Boolean) As Boolean

        'Kiem tra dieu kien rong
        If i_txtCtrl.Text = "" Then
            If Not i_AllowNull Then
                Return False
            Else
                Return True
            End If
        End If

        'Trong truong hop khac rong
        Dim v_strText As String
        v_strText = i_txtCtrl.Text
        Select Case i_DataType
            Case DataType.NumberType
                Return IsValidNumber(v_strText, False)
            Case DataType.DateType
                Return CDateTime.isValidDateString(v_strText, CDateTime.GetDateFormatString())
            Case DataType.StringType
                Return True
        End Select
    End Function

    'Hàm kiểm tra xâu đưa vào có phải là số ?
    Public Shared Function IsValidNumber(ByVal i_strNumber As String _
                            , Optional ByVal i_AllowNull As Boolean = False) As Boolean
        If i_strNumber Is Nothing Or i_strNumber = "" Then
            If Not i_AllowNull Then
                Return False
            Else
                Return True
            End If
        End If

        'Trong truong hop xau khac rong
        Try
            Dim v_Number As Double
            v_Number = CDbl(i_strNumber)
            'Khong co exception => so hop le
            Return True
        Catch v_e As Exception
            'co exception => so khong hop le
            Return False
        End Try
    End Function

    'Hàm chuyển từ xâu ra số, Nếu là chuỗi rỗng thì trả về giá trị mặc định
    Public Shared Function Str2Number(ByVal i_strNumber As String _
                                , Optional ByVal i_DefaultValue As Decimal = 0) As Decimal
        If i_strNumber Is Nothing Or i_strNumber = "" Then
            Return i_DefaultValue
        Else
            Return CType(i_strNumber, Decimal)
        End If
    End Function

    'Chuyển từ Boolean sang Y_N
    Public Shared Function Boolean2YN(ByVal i_bBoolean As Boolean) As String
        If i_bBoolean Then
            Return "Y"
        Else
            Return "N"
        End If
    End Function
    'Chuyển từ Y_N sang Boolean
    Public Shared Function YN2Boolean(ByVal i_strYN As String) As Boolean
        If i_strYN = "Y" Then
            Return True
        Else
            If i_strYN = "N" Then
                Return False
            Else
                Debug.Assert(False)
                'Nếu chương trình bị dừng ở đây 
                'thì chuỗi truyền vào là không hợp lệ
            End If
        End If
    End Function

    'Expand or Collapse tree
    Public Shared Sub ExpandOrCloseTreeView(ByVal i_trvTree As TreeView)
        '***************************************************************
        '* Đóng mở Node cho Treeview
        '***************************************************************
        Dim v_Node As TreeNode = i_trvTree.SelectedNode
        If v_Node.IsExpanded Then
            v_Node.Collapse()
        Else
            v_Node.Expand()
        End If
    End Sub

    Public Shared Function getKeyOfHashtable(ByVal i_HashTable As Hashtable, ByVal i_Value As Decimal) As Object
        Dim v_Key As Object
        For Each v_Key In i_HashTable.Keys
            If (CType(i_HashTable(v_Key), Decimal) = i_Value) Then
                Return v_Key
            End If
        Next
    End Function

    Public Shared Sub Swap2RowsOfGrid(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid, _
                        ByVal i_Row1 As Integer, ByVal i_Row2 As Integer, ByVal i_STTCol As Integer)
        Dim v_iTempRow As Integer
        Dim v_Temp As Decimal
        If i_Row1 = i_Row2 Then
            Exit Sub
        End If
        'Phai luon dam bao i_Row1 < i_Row2
        If i_Row1 > i_Row2 Then
            'Dao gia tri cho i_row1 va i_row2
            v_iTempRow = i_Row2
            i_Row2 = i_Row1
            i_Row1 = v_iTempRow
        End If

        'Doi vi tri hai hang
        i_fg.Rows.Move(i_Row1, i_Row2)
        i_fg.Rows.Move(i_Row2 - 1, i_Row1)
        'v_iTempRow = i_fg.Rows.Count
        'i_fg.Rows.Add()
        'i_fg.Rows.Move(i_Row2, i_Row1)
        'i_fg.Rows.Move(i_Row1, i_Row2)
        'i_fg.Rows.Move(v_iTempRow, i_Row1)
        v_Temp = CType(i_fg(i_Row2, i_STTCol), Decimal)
        i_fg(i_Row2, i_STTCol) = CType(i_fg(i_Row1, i_STTCol), Decimal)
        i_fg(i_Row1, i_STTCol) = v_Temp
        'i_fg.Rows.Count -= 1
    End Sub

    Public Shared Sub BindDatasource2Cbo(ByVal i_cbo As ComboBox _
                                        , ByVal i_tbl As DataTable _
                                        , ByVal i_strDisplayField As String _
                                        , ByVal i_strValueField As String)
        i_cbo.DataSource = Nothing
        i_cbo.Items.Clear()
        i_cbo.Text = ""
        i_cbo.DataSource = i_tbl
        i_cbo.DisplayMember = i_strDisplayField
        i_cbo.ValueMember = i_strValueField
    End Sub
End Class

Public Class CSelectedData
    ' Class 
    Public dcID As Decimal
    'Public Property dcID() As Decimal
    '    Get
    '        Return m_dcID
    '    End Get
    '    Set(ByVal Value As Decimal)
    '        m_dcID = Value
    '    End Set
    'End Property

    Public strMa As String

    Public strTen As String

    Default Public Property Item(ByVal name As String) As Object
        Get
            Select Case name
                Case "ID"
                    Return dcID
                Case "TEN"
                    Return strTen
            End Select
        End Get
        Set(ByVal Value As Object)
            Select Case name
                Case "ID"
                    dcID = CType(Value, Decimal)
                Case "TEN"
                    strTen = CType(Value, String)
            End Select
        End Set
    End Property

End Class

