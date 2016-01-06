Option Explicit On 
Option Strict On

Imports System.Windows.Forms
Imports System.Drawing.Color

Public Class ctlClock

    Inherits System.Windows.Forms.UserControl

    Private colFColor As System.Drawing.Color
    Private colBColor As System.Drawing.Color
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.Red
        Me.lblDisplay.Location = New System.Drawing.Point(2, 2)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(118, 20)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ctlClock
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDisplay})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "ctlClock"
        Me.Size = New System.Drawing.Size(122, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Property ClockBackColor() As System.Drawing.Color
        Get
            Return colBColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            colBColor = Value
            lblDisplay.BackColor = colBColor
        End Set
    End Property

    Property ClockForeColor() As System.Drawing.Color
        Get
            Return colFColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            colFColor = Value
            lblDisplay.ForeColor = colFColor
        End Set
    End Property

    Protected Overridable Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDisplay.Text = Format(Now, "hh:mm:ss")
    End Sub

End Class

