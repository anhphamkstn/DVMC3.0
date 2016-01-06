Imports IP.Core.IPCommon

Public Class f996_license
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents m_pnl_out_place_dm As System.Windows.Forms.Panel
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents m_cmd_tro_ve As SIS.Controls.Button.SiSButton
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents m_grp_so_dang_ky As System.Windows.Forms.GroupBox
    Friend WithEvents m_txt_box5 As System.Windows.Forms.TextBox
    Friend WithEvents m_txt_box4 As System.Windows.Forms.TextBox
    Friend WithEvents m_txt_box3 As System.Windows.Forms.TextBox
    Friend WithEvents m_txt_box2 As System.Windows.Forms.TextBox
    Friend WithEvents m_txt_box1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(f996_license))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.m_pnl_out_place_dm = New System.Windows.Forms.Panel
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.m_cmd_tro_ve = New SIS.Controls.Button.SiSButton
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.m_grp_so_dang_ky = New System.Windows.Forms.GroupBox
        Me.m_txt_box5 = New System.Windows.Forms.TextBox
        Me.m_txt_box4 = New System.Windows.Forms.TextBox
        Me.m_txt_box3 = New System.Windows.Forms.TextBox
        Me.m_txt_box2 = New System.Windows.Forms.TextBox
        Me.m_txt_box1 = New System.Windows.Forms.TextBox
        Me.m_pnl_out_place_dm.SuspendLayout()
        Me.m_grp_so_dang_ky.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'm_pnl_out_place_dm
        '
        Me.m_pnl_out_place_dm.Controls.Add(Me.label5)
        Me.m_pnl_out_place_dm.Controls.Add(Me.label4)
        Me.m_pnl_out_place_dm.Controls.Add(Me.m_cmd_tro_ve)
        Me.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_pnl_out_place_dm.DockPadding.All = 4
        Me.m_pnl_out_place_dm.Location = New System.Drawing.Point(0, 269)
        Me.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm"
        Me.m_pnl_out_place_dm.Size = New System.Drawing.Size(544, 48)
        Me.m_pnl_out_place_dm.TabIndex = 7
        '
        'label5
        '
        Me.label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Red
        Me.label5.Location = New System.Drawing.Point(4, 24)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(432, 20)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Bản quyền của I4U Group."
        '
        'label4
        '
        Me.label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(4, 4)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(432, 20)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Sản phẩm này nằm trong bộ sản phẩm ứng dụng dành cho Công ty chứng khoán"
        '
        'm_cmd_tro_ve
        '
        Me.m_cmd_tro_ve.AdjustImageLocation = New System.Drawing.Point(0, 0)
        Me.m_cmd_tro_ve.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle
        Me.m_cmd_tro_ve.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default
        Me.m_cmd_tro_ve.Dock = System.Windows.Forms.DockStyle.Right
        Me.m_cmd_tro_ve.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_cmd_tro_ve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.m_cmd_tro_ve.ImageIndex = 0
        Me.m_cmd_tro_ve.ImageList = Me.ImageList
        Me.m_cmd_tro_ve.Location = New System.Drawing.Point(436, 4)
        Me.m_cmd_tro_ve.Name = "m_cmd_tro_ve"
        Me.m_cmd_tro_ve.Size = New System.Drawing.Size(104, 40)
        Me.m_cmd_tro_ve.TabIndex = 2
        Me.m_cmd_tro_ve.Text = "OK [Esc]"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(168, 269)
        Me.pictureBox1.TabIndex = 63
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(168, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(376, 48)
        Me.label1.TabIndex = 0
        Me.label1.Text = "I4U Group"
        '
        'label2
        '
        Me.label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.label2.Location = New System.Drawing.Point(168, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(376, 32)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Auction Manager"
        '
        'label3
        '
        Me.label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(168, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(376, 24)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Version 2.0"
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(192, 112)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(328, 24)
        Me.label6.TabIndex = 4
        Me.label6.Text = "Liên hệ: Nguyễn Danh Tú"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(192, 136)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(328, 24)
        Me.label7.TabIndex = 5
        Me.label7.Text = "Di động: 0904 257 115"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkLabel1
        '
        Me.linkLabel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel1.Location = New System.Drawing.Point(192, 160)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(328, 24)
        Me.linkLabel1.TabIndex = 69
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Email: tu_nguyendanh@yahoo.com"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(176, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 8)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'm_grp_so_dang_ky
        '
        Me.m_grp_so_dang_ky.Controls.Add(Me.m_txt_box5)
        Me.m_grp_so_dang_ky.Controls.Add(Me.m_txt_box4)
        Me.m_grp_so_dang_ky.Controls.Add(Me.m_txt_box3)
        Me.m_grp_so_dang_ky.Controls.Add(Me.m_txt_box2)
        Me.m_grp_so_dang_ky.Controls.Add(Me.m_txt_box1)
        Me.m_grp_so_dang_ky.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.m_grp_so_dang_ky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_grp_so_dang_ky.Location = New System.Drawing.Point(172, 200)
        Me.m_grp_so_dang_ky.Name = "m_grp_so_dang_ky"
        Me.m_grp_so_dang_ky.Size = New System.Drawing.Size(368, 64)
        Me.m_grp_so_dang_ky.TabIndex = 6
        Me.m_grp_so_dang_ky.TabStop = False
        Me.m_grp_so_dang_ky.Text = "  Số đăng ký   "
        '
        'm_txt_box5
        '
        Me.m_txt_box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_txt_box5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txt_box5.Location = New System.Drawing.Point(295, 25)
        Me.m_txt_box5.MaxLength = 4
        Me.m_txt_box5.Name = "m_txt_box5"
        Me.m_txt_box5.Size = New System.Drawing.Size(64, 22)
        Me.m_txt_box5.TabIndex = 4
        Me.m_txt_box5.Text = ""
        Me.m_txt_box5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'm_txt_box4
        '
        Me.m_txt_box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_txt_box4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txt_box4.Location = New System.Drawing.Point(223, 25)
        Me.m_txt_box4.MaxLength = 4
        Me.m_txt_box4.Name = "m_txt_box4"
        Me.m_txt_box4.Size = New System.Drawing.Size(64, 22)
        Me.m_txt_box4.TabIndex = 3
        Me.m_txt_box4.Text = ""
        Me.m_txt_box4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'm_txt_box3
        '
        Me.m_txt_box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_txt_box3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txt_box3.Location = New System.Drawing.Point(151, 25)
        Me.m_txt_box3.MaxLength = 4
        Me.m_txt_box3.Name = "m_txt_box3"
        Me.m_txt_box3.Size = New System.Drawing.Size(64, 22)
        Me.m_txt_box3.TabIndex = 2
        Me.m_txt_box3.Text = ""
        Me.m_txt_box3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'm_txt_box2
        '
        Me.m_txt_box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_txt_box2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txt_box2.Location = New System.Drawing.Point(79, 25)
        Me.m_txt_box2.MaxLength = 4
        Me.m_txt_box2.Name = "m_txt_box2"
        Me.m_txt_box2.Size = New System.Drawing.Size(64, 22)
        Me.m_txt_box2.TabIndex = 1
        Me.m_txt_box2.Text = ""
        Me.m_txt_box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'm_txt_box1
        '
        Me.m_txt_box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_txt_box1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txt_box1.Location = New System.Drawing.Point(7, 25)
        Me.m_txt_box1.MaxLength = 4
        Me.m_txt_box1.Name = "m_txt_box1"
        Me.m_txt_box1.Size = New System.Drawing.Size(64, 22)
        Me.m_txt_box1.TabIndex = 0
        Me.m_txt_box1.Text = ""
        Me.m_txt_box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'f996_license
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 317)
        Me.Controls.Add(Me.m_grp_so_dang_ky)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.m_pnl_out_place_dm)
        Me.Name = "f996_license"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F996 - License"
        Me.m_pnl_out_place_dm.ResumeLayout(False)
        Me.m_grp_so_dang_ky.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Public Interface"
    Public Sub display(ByVal i_mode As Integer)
        m_e_form_mode = i_mode
        Me.ShowDialog()
    End Sub
#End Region

#Region "Data Structures"
    Private Enum eFormMode
        LicenseYes = 0
        LicenseNo = 1
    End Enum
#End Region

#Region "Members"
    Dim m_e_form_mode As New eFormMode
#End Region

#Region "Private Methods"
    Private Sub init_form()
        m_txt_box1.Text = ""
        m_txt_box2.Text = ""
        m_txt_box3.Text = ""
        m_txt_box4.Text = ""
        m_txt_box5.Text = ""
    End Sub
#End Region

    Private Sub f101_Dang_Nhap_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            init_form()
            If m_e_form_mode = eFormMode.LicenseYes Then
                m_grp_so_dang_ky.Visible = False
            Else
                m_grp_so_dang_ky.Visible = True
            End If
        Catch v_e As System.Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub

    Private Sub m_cmd_tro_ve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmd_tro_ve.Click
        Try
            Me.Close()
        Catch v_e As System.Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub
End Class
