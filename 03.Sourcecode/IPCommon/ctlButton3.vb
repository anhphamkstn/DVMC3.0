Option Explicit On 
Option Strict On

Imports System.Windows.Forms

Public Class ctlButton3
    Inherits System.Windows.Forms.UserControl

    Private v_DialogResult3 As DialogResult
    Public Event ClickMe()

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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Chấp nhận (Ctrl - C)"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(142, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Bỏ qua (Ctrl - B)"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(282, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hủy bỏ (Esc)"
        '
        'ctlButton3
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button3, Me.Button2, Me.Button1})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "ctlButton3"
        Me.Size = New System.Drawing.Size(424, 30)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property v_Button() As DialogResult
        Get
            Return v_DialogResult3
        End Get
        Set(ByVal Value As DialogResult)
            Value = v_DialogResult3
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        v_DialogResult3 = DialogResult.OK
        RaiseEvent ClickMe()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        v_DialogResult3 = DialogResult.Cancel
        RaiseEvent ClickMe()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        v_DialogResult3 = DialogResult.Ignore
        RaiseEvent ClickMe()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            v_DialogResult3 = DialogResult.OK
            RaiseEvent ClickMe()
        End If
    End Sub

    Private Sub Button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.Control And e.KeyCode = Keys.B Then
            v_DialogResult3 = DialogResult.Ignore
            RaiseEvent ClickMe()
        End If
    End Sub

    Private Sub Button3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Escape Then
            v_DialogResult3 = DialogResult.Cancel
            RaiseEvent ClickMe()
        End If
    End Sub

End Class
