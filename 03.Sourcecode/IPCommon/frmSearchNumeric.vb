Option Explicit On 
Option Strict On

Imports System.Windows.Forms

#Region "Enummeration"
Public Enum NumberSearchType
    Equal_Number = 0
    LesserOrEqual_Number = 1
    LargerOrEqual_Number = 2
    Lesser_Number = 3
    Larger_Number = 4
End Enum
#End Region

Public Class frmSearchNumeric
    Inherits System.Windows.Forms.Form
    Implements ISearchForm

#Region "Variables"
    Dim m_frmSearch As ISearchable
#End Region

#Region "Public Interface"

    Public Sub displaySearch(ByVal i_form2Search As ISearchable) Implements ISearchForm.displaySearch
        m_frmSearch = i_form2Search
        Me.ShowDialog()
    End Sub
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CControlFormat.setFormStyle(Me)
        Me.CenterToParent()
        Me.KeyPreview = True
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents m_txtNumber2Search As System.Windows.Forms.TextBox
    Friend WithEvents m_lblSearchInfo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents m_rbLargerOrEqual As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbLesserOrEqual As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbEqual As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbLarger As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbLesser As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.m_txtNumber2Search = New System.Windows.Forms.TextBox()
        Me.m_lblSearchInfo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.m_rbLesser = New System.Windows.Forms.RadioButton()
        Me.m_rbLarger = New System.Windows.Forms.RadioButton()
        Me.m_rbLesserOrEqual = New System.Windows.Forms.RadioButton()
        Me.m_rbLargerOrEqual = New System.Windows.Forms.RadioButton()
        Me.m_rbEqual = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_txtNumber2Search
        '
        Me.m_txtNumber2Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.m_txtNumber2Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txtNumber2Search.Name = "m_txtNumber2Search"
        Me.m_txtNumber2Search.Size = New System.Drawing.Size(356, 22)
        Me.m_txtNumber2Search.TabIndex = 0
        Me.m_txtNumber2Search.Text = ""
        '
        'm_lblSearchInfo
        '
        Me.m_lblSearchInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_lblSearchInfo.Location = New System.Drawing.Point(0, 111)
        Me.m_lblSearchInfo.Name = "m_lblSearchInfo"
        Me.m_lblSearchInfo.Size = New System.Drawing.Size(356, 22)
        Me.m_lblSearchInfo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.m_rbLesser, Me.m_rbLarger, Me.m_rbLesserOrEqual, Me.m_rbLargerOrEqual, Me.m_rbEqual})
        Me.GroupBox1.Location = New System.Drawing.Point(0, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 84)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'm_rbLesser
        '
        Me.m_rbLesser.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_rbLesser.Location = New System.Drawing.Point(76, 38)
        Me.m_rbLesser.Name = "m_rbLesser"
        Me.m_rbLesser.Size = New System.Drawing.Size(44, 24)
        Me.m_rbLesser.TabIndex = 4
        Me.m_rbLesser.Text = "<"
        '
        'm_rbLarger
        '
        Me.m_rbLarger.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_rbLarger.Location = New System.Drawing.Point(76, 16)
        Me.m_rbLarger.Name = "m_rbLarger"
        Me.m_rbLarger.Size = New System.Drawing.Size(44, 24)
        Me.m_rbLarger.TabIndex = 3
        Me.m_rbLarger.Text = ">"
        '
        'm_rbLesserOrEqual
        '
        Me.m_rbLesserOrEqual.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_rbLesserOrEqual.Location = New System.Drawing.Point(14, 60)
        Me.m_rbLesserOrEqual.Name = "m_rbLesserOrEqual"
        Me.m_rbLesserOrEqual.Size = New System.Drawing.Size(44, 24)
        Me.m_rbLesserOrEqual.TabIndex = 2
        Me.m_rbLesserOrEqual.Text = "<="
        '
        'm_rbLargerOrEqual
        '
        Me.m_rbLargerOrEqual.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_rbLargerOrEqual.Location = New System.Drawing.Point(14, 38)
        Me.m_rbLargerOrEqual.Name = "m_rbLargerOrEqual"
        Me.m_rbLargerOrEqual.Size = New System.Drawing.Size(44, 24)
        Me.m_rbLargerOrEqual.TabIndex = 1
        Me.m_rbLargerOrEqual.Text = ">="
        '
        'm_rbEqual
        '
        Me.m_rbEqual.Checked = True
        Me.m_rbEqual.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_rbEqual.Location = New System.Drawing.Point(14, 16)
        Me.m_rbEqual.Name = "m_rbEqual"
        Me.m_rbEqual.Size = New System.Drawing.Size(44, 24)
        Me.m_rbEqual.TabIndex = 0
        Me.m_rbEqual.TabStop = True
        Me.m_rbEqual.Text = "="
        '
        'frmSearchNumeric
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(356, 133)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.m_lblSearchInfo, Me.m_txtNumber2Search})
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSearchNumeric"
        Me.Text = "Ctrl+F=tìm kiếm từ đầu; F3 = tìm từ vị trí tiếp theo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Private Methods"
    Private Sub startSearch(ByVal i_searchtype As SearchType)
        If m_frmSearch Is Nothing Then Exit Sub
        If m_txtNumber2Search.Text = "" Then
            m_lblSearchInfo.Text = "Không có điều kiện để tìm"
            Exit Sub
        End If
        ' tạo điều kiện tìm kiếm
        Dim v_number2Search As Decimal
        Try
            v_number2Search = CType(m_txtNumber2Search.Text, Decimal)
        Catch
            m_lblSearchInfo.Text = "Không có số hợp lệ để tìm"
            Exit Sub
        End Try
        m_lblSearchInfo.Text = "Không tìm thấy"
        Try
            Dim v_numberCompareType As NumberSearchType
            If m_rbEqual.Checked Then
                v_numberCompareType = NumberSearchType.Equal_Number
            ElseIf m_rbLarger.Checked Then
                v_numberCompareType = NumberSearchType.Larger_Number
            ElseIf m_rbLargerOrEqual.Checked Then
                v_numberCompareType = NumberSearchType.LargerOrEqual_Number
            ElseIf m_rbLesser.Checked Then
                v_numberCompareType = NumberSearchType.Lesser_Number
            ElseIf m_rbLesserOrEqual.Checked Then
                v_numberCompareType = NumberSearchType.LesserOrEqual_Number
            End If

            Dim v_numberSearchPattern As NumberSearchPattern = _
                         New NumberSearchPattern(v_number2Search, _
                                                 v_numberCompareType)
            m_lblSearchInfo.Text = "Đang tìm kiếm ..."
            If m_frmSearch.startSearch(v_numberSearchPattern, i_searchtype) Then
                m_lblSearchInfo.Text = "Tìm thấy"
            Else
                m_lblSearchInfo.Text = "Không tìm thấy"
            End If
        Catch
            m_lblSearchInfo.Text = "Không tìm thấy"
        End Try
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub frmSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
                e.Handled = True
            Case Keys.F3
                startSearch(SearchType.fromNextRow)
                e.Handled = True
            Case Keys.F
                If e.Control Then
                    startSearch(SearchType.fromStart)
                    e.Handled = True
                Else
                    e.Handled = False
                End If
        End Select
    End Sub

    Private Sub m_txtNumber2Search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_txtNumber2Search.TextChanged
        m_lblSearchInfo.Text = ""
    End Sub

#End Region

#Region "Inner Classes"

    Private Class NumberSearchPattern
        Implements IFoundCondition

#Region "Nhiệm vụ của Class"
        ' Dùng để tìm các dữ liệu
        ' 
        '
#End Region

        Private m_number2Search As Decimal
        Private m_numberSearchType As NumberSearchType

        Public Sub New(ByVal i_Number2Search As Decimal, _
                       ByVal i_searchType As NumberSearchType)
            m_number2Search = i_Number2Search
            m_numberSearchType = i_searchType
        End Sub

        Public Function MatchThePattern(ByVal i_Data2Compare As Object) As Boolean Implements IFoundCondition.MatchThePattern
            Try
                Dim v_numberData As Decimal = CType(i_Data2Compare, Decimal)
                Select Case m_numberSearchType
                    Case NumberSearchType.Equal_Number
                        Return v_numberData = m_number2Search
                    Case NumberSearchType.LargerOrEqual_Number
                        Return v_numberData >= m_number2Search
                    Case NumberSearchType.LesserOrEqual_Number
                        Return v_numberData <= m_number2Search
                    Case NumberSearchType.Larger_Number
                        Return v_numberData > m_number2Search
                    Case NumberSearchType.Lesser_Number
                        Return v_numberData < m_number2Search
                End Select
            Catch
                Return False
            End Try
        End Function

    End Class
#End Region

End Class
