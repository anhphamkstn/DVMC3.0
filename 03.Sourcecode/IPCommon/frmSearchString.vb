Option Explicit On 
Option Strict On
Imports System.Windows.Forms

Public Class frmSearchString
    Inherits System.Windows.Forms.Form
    Implements ISearchForm

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
    Friend WithEvents m_txtPattern As System.Windows.Forms.TextBox
    Friend WithEvents m_lblSearchInfo As System.Windows.Forms.Label
    Friend WithEvents m_chkCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents m_rbStartWith As System.Windows.Forms.RadioButton
    Friend WithEvents m_rbContain As System.Windows.Forms.RadioButton
    Friend WithEvents m_chkSearchAsYouType As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.m_txtPattern = New System.Windows.Forms.TextBox()
        Me.m_lblSearchInfo = New System.Windows.Forms.Label()
        Me.m_rbStartWith = New System.Windows.Forms.RadioButton()
        Me.m_rbContain = New System.Windows.Forms.RadioButton()
        Me.m_chkCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.m_chkSearchAsYouType = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'm_txtPattern
        '
        Me.m_txtPattern.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txtPattern.ForeColor = System.Drawing.SystemColors.Highlight
        Me.m_txtPattern.Location = New System.Drawing.Point(1, 0)
        Me.m_txtPattern.Name = "m_txtPattern"
        Me.m_txtPattern.Size = New System.Drawing.Size(347, 22)
        Me.m_txtPattern.TabIndex = 0
        Me.m_txtPattern.Text = ""
        '
        'm_lblSearchInfo
        '
        Me.m_lblSearchInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_lblSearchInfo.ForeColor = System.Drawing.Color.OrangeRed
        Me.m_lblSearchInfo.Location = New System.Drawing.Point(0, 90)
        Me.m_lblSearchInfo.Name = "m_lblSearchInfo"
        Me.m_lblSearchInfo.Size = New System.Drawing.Size(350, 18)
        Me.m_lblSearchInfo.TabIndex = 4
        '
        'm_rbStartWith
        '
        Me.m_rbStartWith.Location = New System.Drawing.Point(8, 36)
        Me.m_rbStartWith.Name = "m_rbStartWith"
        Me.m_rbStartWith.TabIndex = 1
        Me.m_rbStartWith.Text = "Bắt đầu bằng"
        '
        'm_rbContain
        '
        Me.m_rbContain.Checked = True
        Me.m_rbContain.Location = New System.Drawing.Point(8, 58)
        Me.m_rbContain.Name = "m_rbContain"
        Me.m_rbContain.TabIndex = 2
        Me.m_rbContain.TabStop = True
        Me.m_rbContain.Text = "Có chứa "
        '
        'm_chkCaseSensitive
        '
        Me.m_chkCaseSensitive.Location = New System.Drawing.Point(147, 30)
        Me.m_chkCaseSensitive.Name = "m_chkCaseSensitive"
        Me.m_chkCaseSensitive.Size = New System.Drawing.Size(201, 24)
        Me.m_chkCaseSensitive.TabIndex = 3
        Me.m_chkCaseSensitive.Text = "Phân biệt chữ  hoa/thường"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 63)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'm_chkSearchAsYouType
        '
        Me.m_chkSearchAsYouType.Location = New System.Drawing.Point(147, 60)
        Me.m_chkSearchAsYouType.Name = "m_chkSearchAsYouType"
        Me.m_chkSearchAsYouType.Size = New System.Drawing.Size(201, 24)
        Me.m_chkSearchAsYouType.TabIndex = 5
        Me.m_chkSearchAsYouType.Text = "Tìm sau từng ký tự"
        '
        'frmSearchString
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(350, 108)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.m_chkSearchAsYouType, Me.m_chkCaseSensitive, Me.m_rbContain, Me.m_rbStartWith, Me.m_lblSearchInfo, Me.m_txtPattern, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSearchString"
        Me.Text = "Ctrl + F = tìm từ đầu; F3= tìm từ vị trí tiếp theo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim m_frmSearch As ISearchable
    Dim m_currentSearchType As SearchType = SearchType.fromStart

    Public Sub displaySearch(ByVal i_form2Search As ISearchable) Implements ISearchForm.displaySearch
        m_frmSearch = i_form2Search
        Me.ShowDialog()
    End Sub

    Private Sub startSearch(ByVal i_searchtype As SearchType)
        m_currentSearchType = i_searchtype
        If m_frmSearch Is Nothing Then Exit Sub
        If m_txtPattern.Text = "" Then
            m_lblSearchInfo.Text = "Không có điều kiện để tìm"
            Exit Sub
        End If
        m_lblSearchInfo.Text = "Không tìm thấy"
        Try
            Dim v_newStringSearchPattern As StringSearchPattern = _
                         New StringSearchPattern(m_txtPattern.Text, _
                                                 m_rbStartWith.Checked, _
                                                 m_chkCaseSensitive.Checked)
            m_lblSearchInfo.Text = "Đang tìm kiếm ..."
            If m_frmSearch.startSearch(v_newStringSearchPattern, i_searchtype) Then
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

    Private Sub m_txtPattern_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_txtPattern.TextChanged
        m_lblSearchInfo.Text = ""
        If m_chkSearchAsYouType.Checked Then
            startSearch(SearchType.fromStart)
        End If
    End Sub


    Private Sub m_txtPattern_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles m_txtPattern.KeyDown
        If e.KeyCode = Keys.Enter Then
            startSearch(m_currentSearchType)
        End If
    End Sub

    Private Class StringSearchPattern
        Implements IFoundCondition

#Region "Nhiệm vụ của Class"
        ' Dùng để tìm các dữ liệu
        ' 
        '
#End Region

        Private m_pattern As String
        Private m_startWith As Boolean
        Private m_caseSensitive As Boolean

        Public Sub New(ByVal i_strPattern As String, _
                       ByVal i_startWith As Boolean, _
                       ByVal i_caseSensitive As Boolean)

            Debug.Assert(i_strPattern <> "", "Sao không có condition thế này")
            m_caseSensitive = i_caseSensitive
            m_startWith = i_startWith
            m_pattern = i_strPattern
        End Sub

        Public Function MatchThePattern(ByVal i_Data2Compare As Object) As Boolean Implements IFoundCondition.MatchThePattern
            Try
                Dim v_strData As String = CType(i_Data2Compare, String)
                Dim v_pattern As String

                If Not m_caseSensitive Then
                    v_strData = v_strData.ToLower
                    v_pattern = m_pattern.ToLower
                End If

                If m_startWith Then
                    Return v_strData.IndexOf(v_pattern) = 0
                Else
                    Return v_strData.IndexOf(v_pattern) >= 0
                End If
            Catch
                Return False
            End Try
        End Function
    End Class

End Class
