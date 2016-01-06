Option Explicit On 
Option Strict On

Imports System.Windows.Forms

Public Class ctlButton2
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cập nhận (Ctrl - C)"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(142, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Hủy bỏ (Esc)"
        '
        'ctlButton2
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "ctlButton2"
        Me.Size = New System.Drawing.Size(284, 30)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Các định nghĩa"
    Public Enum TT_NUT
        i_BO_QUA = 0
        i_CHAP_NHAN = 1
        i_THOAT = 2
    End Enum

#End Region
    Private v_DialogResult2 As DialogResult
    Public Event ClickMe()


    ' Declares the property.

    Public Property v_Button() As DialogResult
        Get
            Return v_DialogResult2
        End Get
        Set(ByVal Value As DialogResult)
            Value = v_DialogResult2
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        v_DialogResult2 = DialogResult.OK
        RaiseEvent ClickMe()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        v_DialogResult2 = DialogResult.Cancel
        RaiseEvent ClickMe()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            v_DialogResult2 = DialogResult.OK
            RaiseEvent ClickMe()
        End If
    End Sub

    Private Sub Button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Escape Then
            v_DialogResult2 = DialogResult.Cancel
            RaiseEvent ClickMe()
        End If
    End Sub
End Class
