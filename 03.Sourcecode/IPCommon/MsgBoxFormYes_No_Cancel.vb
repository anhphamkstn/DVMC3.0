Namespace MessageForms
    Public Class MsgBoxFormYes_No_Cancel
        Inherits System.Windows.Forms.Form

#Region "Khai báo biến"
        Const c_MaxStringLength As Integer = 80
        Const c_MinStringLength As Integer = 40
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
        Public Function Display(ByVal i_strMsg As String, ByVal i_TitleMsg As String, ByVal i_IconType As MessageForms.Msgs.MsgIconType) As System.Windows.Forms.DialogResult
            SetWidthHeightForm(i_strMsg)
            FormatFormMsg(i_TitleMsg, m_PanelCtrl)
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

#Region "Windows Form Designer generated code "

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
        'Friend WithEvents CtlMsgButton As MessageForms.MsgBoxFormYes_No_Cancel
        Friend WithEvents m_PanelCtrl As System.Windows.Forms.Panel
        Friend WithEvents m_cmdDongY As System.Windows.Forms.Button
        Friend WithEvents m_cmdKhongDongY As System.Windows.Forms.Button
        Friend WithEvents m_cmdHuyBo As System.Windows.Forms.Button
        Friend WithEvents ImageList As System.Windows.Forms.ImageList
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MsgBoxFormYes_No_Cancel))
            Me.MsgIcons = New System.Windows.Forms.ImageList(Me.components)
            Me.PicIcon = New System.Windows.Forms.PictureBox
            Me.LabMsg = New System.Windows.Forms.Label
            Me.m_PanelCtrl = New System.Windows.Forms.Panel
            Me.m_cmdHuyBo = New System.Windows.Forms.Button
            Me.m_cmdKhongDongY = New System.Windows.Forms.Button
            Me.m_cmdDongY = New System.Windows.Forms.Button
            Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.m_PanelCtrl.SuspendLayout()
            Me.SuspendLayout()
            '
            'MsgIcons
            '
            Me.MsgIcons.ImageSize = New System.Drawing.Size(32, 32)
            Me.MsgIcons.ImageStream = CType(resources.GetObject("MsgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.MsgIcons.TransparentColor = System.Drawing.Color.Transparent
            '
            'PicIcon
            '
            Me.PicIcon.Location = New System.Drawing.Point(8, 8)
            Me.PicIcon.Name = "PicIcon"
            Me.PicIcon.Size = New System.Drawing.Size(50, 39)
            Me.PicIcon.TabIndex = 2
            Me.PicIcon.TabStop = False
            '
            'LabMsg
            '
            Me.LabMsg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabMsg.Location = New System.Drawing.Point(70, 12)
            Me.LabMsg.Name = "LabMsg"
            Me.LabMsg.Size = New System.Drawing.Size(162, 35)
            Me.LabMsg.TabIndex = 3
            Me.LabMsg.Text = "Label1"
            '
            'm_PanelCtrl
            '
            Me.m_PanelCtrl.Controls.Add(Me.m_cmdHuyBo)
            Me.m_PanelCtrl.Controls.Add(Me.m_cmdKhongDongY)
            Me.m_PanelCtrl.Controls.Add(Me.m_cmdDongY)
            Me.m_PanelCtrl.Location = New System.Drawing.Point(24, 68)
            Me.m_PanelCtrl.Name = "m_PanelCtrl"
            Me.m_PanelCtrl.Size = New System.Drawing.Size(329, 44)
            Me.m_PanelCtrl.TabIndex = 5
            '
            'm_cmdHuyBo
            '
            Me.m_cmdHuyBo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.m_cmdHuyBo.ForeColor = System.Drawing.Color.Blue
            Me.m_cmdHuyBo.Location = New System.Drawing.Point(220, 8)
            Me.m_cmdHuyBo.Name = "m_cmdHuyBo"
            Me.m_cmdHuyBo.Size = New System.Drawing.Size(105, 24)
            Me.m_cmdHuyBo.TabIndex = 2
            Me.m_cmdHuyBo.Text = "&Huỷ bỏ"
            '
            'm_cmdKhongDongY
            '
            Me.m_cmdKhongDongY.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.m_cmdKhongDongY.ForeColor = System.Drawing.Color.Blue
            Me.m_cmdKhongDongY.Location = New System.Drawing.Point(112, 8)
            Me.m_cmdKhongDongY.Name = "m_cmdKhongDongY"
            Me.m_cmdKhongDongY.Size = New System.Drawing.Size(105, 24)
            Me.m_cmdKhongDongY.TabIndex = 1
            Me.m_cmdKhongDongY.Text = "&Không đồng ý"
            '
            'm_cmdDongY
            '
            Me.m_cmdDongY.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.m_cmdDongY.ForeColor = System.Drawing.Color.Blue
            Me.m_cmdDongY.Location = New System.Drawing.Point(4, 8)
            Me.m_cmdDongY.Name = "m_cmdDongY"
            Me.m_cmdDongY.Size = New System.Drawing.Size(105, 24)
            Me.m_cmdDongY.TabIndex = 0
            Me.m_cmdDongY.Text = "&Đồng ý"
            '
            'ImageList
            '
            Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
            '
            'MsgBoxFormYes_No_Cancel
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(366, 128)
            Me.Controls.Add(Me.m_PanelCtrl)
            Me.Controls.Add(Me.LabMsg)
            Me.Controls.Add(Me.PicIcon)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "MsgBoxFormYes_No_Cancel"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form3"
            Me.m_PanelCtrl.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Format form"
        Private Sub SetWidthHeightForm(ByVal i_strMsg As String)
            Dim v_MsgLength As Long = i_strMsg.Length
            Dim v_NumOfLine As Integer = 1
            Dim v_LabelWidth As Integer
            If v_MsgLength > c_MaxStringLength Then
                v_NumOfLine = CType(v_MsgLength / c_MaxStringLength, Integer) + 1
                v_LabelWidth = c_MaxStringLength * c_CharaterWidth
            ElseIf v_MsgLength < c_MinStringLength Then
                v_LabelWidth = c_MinStringLength * c_CharaterWidth
            Else
                v_LabelWidth = v_MsgLength * c_CharaterWidth
            End If
            Dim v_FormWidth As Integer = v_LabelWidth + c_FormLabelDiffWidth
            Dim v_LabelHeight As Integer = c_LabelLineHeight * v_NumOfLine
            Dim v_FormHeight As Integer = v_LabelHeight + c_FormLabelDiffHeight
            Me.Width = CType(v_FormWidth, Integer)
            Me.Height = CType(v_FormHeight, Integer)
            LabMsg.Width = CType(v_LabelWidth, Integer)
            LabMsg.Height = CType(v_LabelHeight, Integer)
            LabMsg.Text = i_strMsg
            LabMsg.Font = c_Font
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

        

#Region "Private methode"
        Private Sub DongForm()
            Me.Close()
        End Sub
#End Region

#Region "Events handler"
        Private Sub m_cmdDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdDongY.Click
            m_MsgResult = Windows.Forms.DialogResult.Yes
            DongForm()
        End Sub

        Private Sub m_cmdKhongDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdKhongDongY.Click
            m_MsgResult = Windows.Forms.DialogResult.No
            DongForm()
        End Sub

        Private Sub m_cmdHuyBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdHuyBo.Click
            m_MsgResult = Windows.Forms.DialogResult.Cancel
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
                Case Windows.Forms.Keys.H
                    If e.Alt Then
                        m_MsgResult = Windows.Forms.DialogResult.Cancel
                        DongForm()
                    End If
            End Select
        End Sub

#End Region

    End Class

End Namespace