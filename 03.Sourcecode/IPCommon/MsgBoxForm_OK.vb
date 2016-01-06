Option Explicit On 
Option Strict On
Namespace MessageForms
    Public Class MsgBoxForm_OK
        Inherits System.Windows.Forms.Form
#Region "Khai báo biến"
        Const c_MaxStringLength As Integer = 80
        Const c_MinStringLength As Integer = 10
        Const c_MinFormWidth As Integer = 100
        Const c_MaxFormWidth As Integer = 600
        Const c_CharaterWidth As Integer = 7
        Const c_FormLabelDiffHeight As Integer = 100
        Const c_LabelLineHeight As Integer = 16
        Const c_FormLabelDiffWidth As Integer = 100
        Private c_Font As New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Private m_Result As System.Windows.Forms.DialogResult
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
        Friend WithEvents MsgIcons As System.Windows.Forms.ImageList
        Friend WithEvents LabMsg As System.Windows.Forms.Label
        Friend WithEvents PicIcon As System.Windows.Forms.PictureBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MsgBoxForm_OK))
            Me.CtlMsgButton = New System.Windows.Forms.Button
            Me.PicIcon = New System.Windows.Forms.PictureBox
            Me.LabMsg = New System.Windows.Forms.Label
            Me.MsgIcons = New System.Windows.Forms.ImageList(Me.components)
            Me.SuspendLayout()
            '
            'CtlMsgButton
            '
            Me.CtlMsgButton.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.CtlMsgButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CtlMsgButton.ForeColor = System.Drawing.Color.Blue
            Me.CtlMsgButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CtlMsgButton.Location = New System.Drawing.Point(97, 56)
            Me.CtlMsgButton.Name = "CtlMsgButton"
            Me.CtlMsgButton.Size = New System.Drawing.Size(105, 24)
            Me.CtlMsgButton.TabIndex = 0
            Me.CtlMsgButton.Text = "Đồng ý"
            '
            'PicIcon
            '
            Me.PicIcon.Image = CType(resources.GetObject("PicIcon.Image"), System.Drawing.Image)
            Me.PicIcon.Location = New System.Drawing.Point(12, 10)
            Me.PicIcon.Name = "PicIcon"
            Me.PicIcon.Size = New System.Drawing.Size(44, 41)
            Me.PicIcon.TabIndex = 1
            Me.PicIcon.TabStop = False
            '
            'LabMsg
            '
            Me.LabMsg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabMsg.Location = New System.Drawing.Point(64, 16)
            Me.LabMsg.Name = "LabMsg"
            Me.LabMsg.Size = New System.Drawing.Size(206, 32)
            Me.LabMsg.TabIndex = 2
            Me.LabMsg.Text = "Cộng hoà xã hội chủ nghĩa"
            '
            'MsgIcons
            '
            Me.MsgIcons.ImageSize = New System.Drawing.Size(32, 32)
            Me.MsgIcons.ImageStream = CType(resources.GetObject("MsgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.MsgIcons.TransparentColor = System.Drawing.Color.Transparent
            '
            'MsgBoxForm_OK
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.CancelButton = Me.CtlMsgButton
            Me.ClientSize = New System.Drawing.Size(278, 92)
            Me.Controls.Add(Me.LabMsg)
            Me.Controls.Add(Me.PicIcon)
            Me.Controls.Add(Me.CtlMsgButton)
            Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "MsgBoxForm_OK"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MsgBoxForm_OK"
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Format form"
        Private Sub SetWidthHeightForm(ByVal i_strMsg As String)
            Dim v_MsgLength As Long = i_strMsg.Length
            Dim v_NumOfLine As Long = 1
            Dim v_LabelWidth As Long
            If v_MsgLength > c_MaxStringLength Then
                v_NumOfLine = CType(v_MsgLength / c_MaxStringLength + 1, Long)
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

        Public Function Display(ByVal i_strMsg As String, ByVal i_titleMsg As String, ByVal i_IconType As MessageForms.Msgs.MsgIconType) As System.Windows.Forms.DialogResult
            SetWidthHeightForm(i_strMsg)
            FormatFormMsg(i_titleMsg, Me.CtlMsgButton)
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
            Return m_Result
        End Function

        Private Sub FormatFormMsg(ByVal i_TitleMsg As String, ByVal i_Button As System.Windows.Forms.Control)
            Try
                Dim v_FormHeight As Integer = Me.Height
                Dim v_FormWidth As Integer = Me.Width
                Dim v_FormTop As Integer = Me.Top
                Dim v_FormLeft As Integer = Me.Left
                Dim v_ButtonWidth As Integer = i_Button.Width
                Dim v_ButtonHeight As Integer = i_Button.Height
                Dim v_ButtonLeft As Integer = CType((v_FormWidth - v_ButtonWidth) / 2, Integer)
                Dim v_buttonTop As Integer = CType(v_FormHeight - v_ButtonHeight - 35, Integer)
                Me.Text = i_TitleMsg
                i_Button.Top = v_buttonTop
                i_Button.Left = v_ButtonLeft
            Catch

            End Try
        End Sub
#End Region
        Friend WithEvents CtlMsgButton As System.Windows.Forms.Button
        Private Sub CtlMsgButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlMsgButton.Click
            m_Result = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
            Select Case e.KeyCode
                Case Windows.Forms.Keys.D
                    m_Result = Windows.Forms.DialogResult.OK
                    Me.Close()
            End Select

        End Sub
    End Class
End Namespace