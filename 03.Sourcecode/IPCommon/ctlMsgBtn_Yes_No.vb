Namespace MessageForms
    Public Class MsgBtn_Yes_No
        Inherits System.Windows.Forms.UserControl
#Region "Nhiệm vụ"
        '*************************************************************************
        'Định nghĩa một Control gồm ba nút "Yes", "No", "Cancel"
        'Event: ClickMe
        'Output: Yes,No,Cancel
        '*************************************************************************
#End Region

#Region "Khai báo biến"
        Private m_Result As System.Windows.Forms.DialogResult
        Private c_Font As New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
#End Region

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
        Friend WithEvents BtnDongY As System.Windows.Forms.Button
        Friend WithEvents BtnKhongDongY As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.BtnDongY = New System.Windows.Forms.Button()
            Me.BtnKhongDongY = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'BtnDongY
            '
            Me.BtnDongY.Location = New System.Drawing.Point(9, 6)
            Me.BtnDongY.Name = "BtnDongY"
            Me.BtnDongY.Size = New System.Drawing.Size(92, 25)
            Me.BtnDongY.TabIndex = 0
            Me.BtnDongY.Text = "Đồng ý"
            '
            'BtnKhongDongY
            '
            Me.BtnKhongDongY.Location = New System.Drawing.Point(111, 6)
            Me.BtnKhongDongY.Name = "BtnKhongDongY"
            Me.BtnKhongDongY.Size = New System.Drawing.Size(92, 25)
            Me.BtnKhongDongY.TabIndex = 1
            Me.BtnKhongDongY.Text = "Không đồng ý"
            '
            'MsgBtn_Yes_No
            '
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.BtnKhongDongY, Me.BtnDongY})
            Me.Name = "MsgBtn_Yes_No"
            Me.Size = New System.Drawing.Size(210, 38)
            Me.ResumeLayout(False)

        End Sub

#End Region
#Region "Public Interface"
        Public Property ClickResult() As System.Windows.Forms.DialogResult
            Get
                Return m_Result
            End Get
            Set(ByVal Value As System.Windows.Forms.DialogResult)

            End Set
        End Property
#End Region

#Region "Control Event"
        Public Event ClickMe()
#End Region

#Region "Các hành động của control"
        Private Sub BtnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDongY.Click
            m_Result = System.Windows.Forms.DialogResult.Yes
            RaiseEvent ClickMe()
        End Sub

        Private Sub BtnKhongDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKhongDongY.Click
            m_Result = System.Windows.Forms.DialogResult.No
            RaiseEvent ClickMe()
        End Sub

#End Region

        Private Sub MsgBtn_Yes_No_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BtnDongY.Font = c_Font
            Me.BtnKhongDongY.Font = c_Font
        End Sub
    End Class
End Namespace