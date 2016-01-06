Option Explicit On 
Option Strict On
Imports System.Windows.Forms
Public Class frmEditText
    Inherits System.Windows.Forms.Form

    Private m_Left, m_Top As Integer
    Private m_Under As Boolean
    Private m_strTitle As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents m_txtContent As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.m_txtContent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'm_txtContent
        '
        Me.m_txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_txtContent.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txtContent.Multiline = True
        Me.m_txtContent.Name = "m_txtContent"
        Me.m_txtContent.Size = New System.Drawing.Size(450, 262)
        Me.m_txtContent.TabIndex = 0
        Me.m_txtContent.Text = ""
        '
        'frmEditText
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 262)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.m_txtContent})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditText"
        Me.Text = "Alt+S = save; ESC = cancel - chú ý cho ví dụ"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_strEdit As String


    Public Sub editText(ByRef io_strEdit As String, _
                        Optional ByVal i_Left As Integer = -1, _
                         Optional ByVal i_Top As Integer = -1, _
                         Optional ByVal i_strTitle As String = "Ghi chú")
        m_strEdit = io_strEdit
        m_Left = i_Left
        m_Top = i_Top

        m_strTitle = i_strTitle

        Me.ShowDialog()
        io_strEdit = m_strEdit
    End Sub


    Private Sub frmEditText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.S
                If e.Alt Or e.Control Then
                    m_strEdit = m_txtContent.Text
                    e.Handled = True
                    Me.Close()
                End If
        End Select
    End Sub



    Private Sub m_txtContent_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_txtContent.Enter
        m_txtContent.Select(m_txtContent.Text.Length, 0)
    End Sub


    Private Sub frmEditText_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_txtContent.Text = m_strEdit
        If m_Top > 0 Then
            Me.Top = m_Top
            Me.Left = m_Left
        Else
            Me.CenterToParent()
        End If
        Me.Text = m_strTitle & " - Alt+S = save; ESC = cancel"
    End Sub
End Class
