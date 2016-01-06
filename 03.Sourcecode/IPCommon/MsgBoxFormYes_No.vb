Option Strict On
Option Explicit On 

Namespace MessageForms
    Public Class MsgBoxForm_Yes_No
        Inherits System.Windows.Forms.Form
#Region "Khai báo biến"
        Const c_MaxStringLength As Integer = 80
        Const c_MinStringLength As Integer = 23
        Const c_MinFormWidth As Integer = 100
        Const c_MaxFormWidth As Integer = 600
        Const c_CharaterWidth As Integer = 6
        Const c_FormLabelDiffHeight As Integer = 100
        Const c_LabelLineHeight As Integer = 16
        Const c_FormLabelDiffWidth As Integer = 100
        Private m_MsgResult As System.Windows.Forms.DialogResult
        Private c_Font As New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
#End Region

#Region "Public Interface"
        Public Function Display(ByVal i_strMsg As String, ByVal i_titleMsg As String, ByVal i_IconType As MessageForms.Msgs.MsgIconType) As System.Windows.Forms.DialogResult
            SetWidthHeightForm(i_strMsg)
            FormatFormMsg(i_titleMsg, Me.m_PanelCtrl)
            m_MsgResult = Windows.Forms.DialogResult.No
            Select Case i_IconType
                Case MessageForms.Msgs.MsgIconType.ErrorIcon
                    PicIcon.Image = Me.MsgIcons.Images(MessageForms.Msgs.MsgIconType.ErrorIcon)
                Case MessageForms.Msgs.MsgIconType.InfomationIcon
                    PicIcon.Image = Me.MsgIcons.Images(MessageForms.Msgs.MsgIconType.InfomationIcon)
                Case MessageForms.Msgs.MsgIconType.QuestionIcon
                    PicIcon.Image = Me.MsgIcons.Images(MessageForms.Msgs.MsgIconType.QuestionIcon)
                Case MessageForms.Msgs.MsgIconType.WarningIcon
                    PicIcon.Image = Me.MsgIcons.Images(MessageForms.Msgs.MsgIconType.WarningIcon)
            End Select
            Me.ShowDialog()
            Return m_MsgResult
        End Function
#End Region

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

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
        Friend WithEvents LabMsg As System.Windows.Forms.Label
        Friend WithEvents MsgIcons As System.Windows.Forms.ImageList
        Friend WithEvents PicIcon As System.Windows.Forms.PictureBox
        Friend WithEvents m_PanelCtrl As System.Windows.Forms.Panel
        Friend WithEvents m_cmdDongY As System.Windows.Forms.Button
        Friend WithEvents m_KhongDongY As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MsgBoxForm_Yes_No))
            Me.PicIcon = New System.Windows.Forms.PictureBox
            Me.LabMsg = New System.Windows.Forms.Label
            Me.MsgIcons = New System.Windows.Forms.ImageList(Me.components)
            Me.m_PanelCtrl = New System.Windows.Forms.Panel
            Me.m_cmdDongY = New System.Windows.Forms.Button
            Me.m_KhongDongY = New System.Windows.Forms.Button
            Me.m_PanelCtrl.SuspendLayout()
            Me.SuspendLayout()
            '
            'PicIcon
            '
            Me.PicIcon.Location = New System.Drawing.Point(12, 10)
            Me.PicIcon.Name = "PicIcon"
            Me.PicIcon.Size = New System.Drawing.Size(49, 40)
            Me.PicIcon.TabIndex = 1
            Me.PicIcon.TabStop = False
            '
            'LabMsg
            '
            Me.LabMsg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabMsg.Location = New System.Drawing.Point(72, 14)
            Me.LabMsg.Name = "LabMsg"
            Me.LabMsg.Size = New System.Drawing.Size(162, 35)
            Me.LabMsg.TabIndex = 2
            Me.LabMsg.Text = "Label1"
            '
            'MsgIcons
            '
            Me.MsgIcons.ImageSize = New System.Drawing.Size(32, 32)
            Me.MsgIcons.ImageStream = CType(resources.GetObject("MsgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.MsgIcons.TransparentColor = System.Drawing.Color.Transparent
            '
            'm_PanelCtrl
            '
            Me.m_PanelCtrl.Controls.Add(Me.m_cmdDongY)
            Me.m_PanelCtrl.Controls.Add(Me.m_KhongDongY)
            Me.m_PanelCtrl.Location = New System.Drawing.Point(5, 61)
            Me.m_PanelCtrl.Name = "m_PanelCtrl"
            Me.m_PanelCtrl.Size = New System.Drawing.Size(243, 42)
            Me.m_PanelCtrl.TabIndex = 4
            '
            'm_cmdDongY
            '
            Me.m_cmdDongY.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.m_cmdDongY.ForeColor = System.Drawing.Color.Blue
            Me.m_cmdDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.m_cmdDongY.Location = New System.Drawing.Point(6, 8)
            Me.m_cmdDongY.Name = "m_cmdDongY"
            Me.m_cmdDongY.Size = New System.Drawing.Size(98, 24)
            Me.m_cmdDongY.TabIndex = 0
            Me.m_cmdDongY.Text = "&Đồng ý"
            '
            'm_KhongDongY
            '
            Me.m_KhongDongY.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.m_KhongDongY.ForeColor = System.Drawing.Color.Blue
            Me.m_KhongDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.m_KhongDongY.Location = New System.Drawing.Point(120, 8)
            Me.m_KhongDongY.Name = "m_KhongDongY"
            Me.m_KhongDongY.Size = New System.Drawing.Size(112, 24)
            Me.m_KhongDongY.TabIndex = 1
            Me.m_KhongDongY.Text = "&Không đồng ý"
            '
            'MsgBoxForm_Yes_No
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(322, 104)
            Me.Controls.Add(Me.m_PanelCtrl)
            Me.Controls.Add(Me.LabMsg)
            Me.Controls.Add(Me.PicIcon)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.KeyPreview = True
            Me.Name = "MsgBoxForm_Yes_No"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MsgBox_Yes_No_Form"
            Me.m_PanelCtrl.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Format form"
        Private Sub SetWidthHeightForm(ByVal i_strMsg As String)
            Dim v_MsgLength As Long = i_strMsg.Length
            Dim v_NumOfLine As Integer = 1
            Dim v_LabelWidth As Long
            If v_MsgLength > c_MaxStringLength Then
                v_NumOfLine = CType(v_MsgLength / c_MaxStringLength, Integer) + 1
                v_LabelWidth = c_MaxStringLength * c_CharaterWidth
            ElseIf v_MsgLength < c_MinStringLength Then
                v_LabelWidth = c_MinStringLength * c_CharaterWidth
            Else
                v_LabelWidth = v_MsgLength * c_CharaterWidth
            End If
            Dim v_FormWidth As Long = v_LabelWidth + c_FormLabelDiffWidth
            Dim v_LabelHeight As Long = c_LabelLineHeight * v_NumOfLine
            Dim v_FormHeight As Long = v_LabelHeight + c_FormLabelDiffHeight
            Me.Width = CType(v_FormWidth, Integer)
            Me.Height = CType(v_FormHeight, Integer)
            LabMsg.Width = CType(v_LabelWidth, Integer)
            LabMsg.Height = CType(v_LabelHeight, Integer)
            LabMsg.Font = c_Font
            LabMsg.Text = i_strMsg
        End Sub

        Private Sub FormatFormMsg(ByVal i_TitleMsg As String, ByVal i_Button As System.Windows.Forms.Control)
            Dim v_FormHeight As Integer = Me.Height
            Dim v_FormWidth As Integer = Me.Width
            Dim v_FormTop As Integer = Me.Top
            Dim v_FormLeft As Integer = Me.Left
            Dim v_ButtonWidth As Integer = i_Button.Width
            Dim v_ButtonHeight As Integer = i_Button.Height
            Dim v_ButtonLeft As Integer = CType((v_FormWidth - v_ButtonWidth) / 2, Integer)
            Dim v_buttonTop As Integer = CType(v_FormHeight - v_ButtonHeight - 25, Integer)
            Me.Text = i_TitleMsg
            i_Button.Top = v_buttonTop
            i_Button.Left = v_ButtonLeft
        End Sub
#End Region

#Region " Private methode"
        'Private Sub CtlMsgButton_ClickMe() Handles CtlMsgButton.ClickMe
        '    m_MsgResult = CtlMsgButton.ClickResult
        '    Me.Close()
        'End Sub

        'Private Sub MsgBoxForm_Yes_No_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'End Sub
        Private Sub DongForm()
            Me.Close()
        End Sub
#End Region

#Region "Events handler"
        Private Sub m_cmdDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdDongY.Click
            m_MsgResult = Windows.Forms.DialogResult.Yes
            DongForm()
        End Sub

        Private Sub m_KhongDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_KhongDongY.Click
            m_MsgResult = Windows.Forms.DialogResult.No
            DongForm()
        End Sub

        Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
            Select Case e.KeyCode
                Case Windows.Forms.Keys.D
                    If e.Alt Then
                        m_MsgResult = Windows.Forms.DialogResult.Yes
                        DongForm()
                    End If
                Case Windows.Forms.Keys.K
                    If e.Alt Then
                        m_MsgResult = Windows.Forms.DialogResult.No
                        DongForm()
                    End If

            End Select
        End Sub
#End Region
        
    End Class
End Namespace