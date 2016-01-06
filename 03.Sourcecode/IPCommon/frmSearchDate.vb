Option Explicit On 
Option Strict On

Imports System.Windows.Forms

Public Class frmSearchDate
    Inherits System.Windows.Forms.Form
    Implements ISearchForm

    Dim m_frmSearch As ISearchable

    Public Sub displaySearch(ByVal i_form2Search As ISearchable) Implements ISearchForm.displaySearch
        m_frmSearch = i_form2Search
        Me.ShowDialog()
    End Sub


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
    Friend WithEvents m_lblSearchInfo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents m_rbLargerOrEqual As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbLesserOrEqual As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbEqual As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbLarger As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbLesser As System.Windows.Forms.RadioButton
    Friend WithEvents m_txtDate2Search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.m_txtDate2Search = New System.Windows.Forms.TextBox()
        Me.m_lblSearchInfo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.m_rbLesser = New System.Windows.Forms.RadioButton()
        Me.m_rbLarger = New System.Windows.Forms.RadioButton()
        Me.m_rbLesserOrEqual = New System.Windows.Forms.RadioButton()
        Me.m_rbLargerOrEqual = New System.Windows.Forms.RadioButton()
        Me.m_rbEqual = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_txtDate2Search
        '
        Me.m_txtDate2Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txtDate2Search.Name = "m_txtDate2Search"
        Me.m_txtDate2Search.Size = New System.Drawing.Size(174, 22)
        Me.m_txtDate2Search.TabIndex = 0
        Me.m_txtDate2Search.Text = ""
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
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(188, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ngày/tháng/năm"
        '
        'frmSearchDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(356, 133)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.GroupBox1, Me.m_lblSearchInfo, Me.m_txtDate2Search})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSearchDate"
        Me.Text = "Ctrl+F=tìm kiếm từ đầu; F3 = tìm từ vị trí tiếp theo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub startSearch(ByVal i_searchtype As SearchType)
        If m_frmSearch Is Nothing Then Exit Sub
        If m_txtDate2Search.Text = "" Then
            m_lblSearchInfo.Text = "Không có điều kiện để tìm"
            Exit Sub
        End If
        ' tạo điều kiện tìm kiếm
        Dim v_DateTime2Search As DateTime
        Try
            v_DateTime2Search = Str2Date(m_txtDate2Search.Text)
        Catch
            m_lblSearchInfo.Text = "Không có ngày hợp lệ để tìm"
            Exit Sub
        End Try
        m_lblSearchInfo.Text = "Không tìm thấy"
        Try
            Dim v_DateTimeCompareType As DateSearchType
            If m_rbEqual.Checked Then
                v_DateTimeCompareType = DateSearchType.Equal_DateTime
            ElseIf m_rbLarger.Checked Then
                v_DateTimeCompareType = DateSearchType.Larger_DateTime
            ElseIf m_rbLargerOrEqual.Checked Then
                v_DateTimeCompareType = DateSearchType.LargerOrEqual_DateTime
            ElseIf m_rbLesser.Checked Then
                v_DateTimeCompareType = DateSearchType.Lesser_DateTime
            ElseIf m_rbLesserOrEqual.Checked Then
                v_DateTimeCompareType = DateSearchType.LesserOrEqual_DateTime
            End If

            Dim v_DateTimeSearchPattern As DateSearchPattern = _
                         New DateSearchPattern(v_DateTime2Search, _
                                                 v_DateTimeCompareType)
            m_lblSearchInfo.Text = "Đang tìm kiếm ..."
            If m_frmSearch.startSearch(v_DateTimeSearchPattern, i_searchtype) Then
                m_lblSearchInfo.Text = "Tìm thấy"
            Else
                m_lblSearchInfo.Text = "Không tìm thấy"
            End If
        Catch
            m_lblSearchInfo.Text = "Không tìm thấy"
        End Try
    End Sub

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



    'Chuyển từ xâu sang ngày với định dạng cho trước
    Private Function Str2Date(ByVal i_strDate As String _
                    , Optional ByVal i_strFormat As String = "dd/MM/yyyy") As DateTime
        Dim v_format As New System.Globalization.CultureInfo("vi-VN", True)
        Dim v_myDateTime As System.DateTime

        v_myDateTime = System.DateTime.ParseExact(i_strDate, _
                    i_strFormat, _
                    v_format)
        Return v_myDateTime
    End Function


    Public Enum DateSearchType
        Equal_DateTime = 0
        LesserOrEqual_DateTime = 1
        LargerOrEqual_DateTime = 2
        Lesser_DateTime = 3
        Larger_DateTime = 4
    End Enum

    Private Class DateSearchPattern
        Implements IFoundCondition

#Region "Nhiệm vụ của Class"
        ' Dùng để tìm các dữ liệu
        ' 
        '
#End Region

        Private m_DateTime2Search As DateTime
        Private m_DateSearchType As DateSearchType

        Public Sub New(ByVal i_DateTime2Search As DateTime, _
                       ByVal i_searchType As DateSearchType)
            m_DateTime2Search = i_DateTime2Search
            m_DateSearchType = i_searchType
        End Sub

        Public Function MatchThePattern(ByVal i_Data2Compare As Object) As Boolean Implements IFoundCondition.MatchThePattern
            Try
                Dim v_DateTimeData As DateTime = CType(i_Data2Compare, DateTime)
                Select Case m_DateSearchType
                    Case DateSearchType.Equal_DateTime
                        Return v_DateTimeData = m_DateTime2Search
                    Case DateSearchType.LargerOrEqual_DateTime
                        Return v_DateTimeData >= m_DateTime2Search
                    Case DateSearchType.LesserOrEqual_DateTime
                        Return v_DateTimeData <= m_DateTime2Search
                    Case DateSearchType.Larger_DateTime
                        Return v_DateTimeData > m_DateTime2Search
                    Case DateSearchType.Lesser_DateTime
                        Return v_DateTimeData < m_DateTime2Search
                End Select
            Catch
                Return False
            End Try
        End Function

    End Class

    Private Sub m_txtNumber2Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_txtDate2Search.TextChanged
        m_lblSearchInfo.Text = ""
    End Sub
End Class
