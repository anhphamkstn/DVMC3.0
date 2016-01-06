Option Explicit On 
Option Strict On

Imports IP.Core.IPUserService

Imports IP.Core.IPData
Imports IP.Core.IPException
Imports IP.Core.IPCommon

Public Class f102_TuDien_DE
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()


        'Add any initialization after the InitializeComponent() call
        formatControls()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaTuDien As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNgan As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents m_cmdChapNhan As System.Windows.Forms.Button
    Friend WithEvents m_cmdHuyBo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaTuDien = New System.Windows.Forms.TextBox()
        Me.txtTenNgan = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.m_cmdChapNhan = New System.Windows.Forms.Button()
        Me.m_cmdHuyBo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-16, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã từ điển:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-32, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên ngắn:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-32, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaTuDien
        '
        Me.txtMaTuDien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaTuDien.Location = New System.Drawing.Point(88, 4)
        Me.txtMaTuDien.MaxLength = 15
        Me.txtMaTuDien.Name = "txtMaTuDien"
        Me.txtMaTuDien.Size = New System.Drawing.Size(128, 22)
        Me.txtMaTuDien.TabIndex = 3
        '
        'txtTenNgan
        '
        Me.txtTenNgan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNgan.Location = New System.Drawing.Point(88, 32)
        Me.txtTenNgan.MaxLength = 50
        Me.txtTenNgan.Name = "txtTenNgan"
        Me.txtTenNgan.Size = New System.Drawing.Size(336, 22)
        Me.txtTenNgan.TabIndex = 4
        '
        'txtTen
        '
        Me.txtTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Location = New System.Drawing.Point(88, 64)
        Me.txtTen.MaxLength = 250
        Me.txtTen.Multiline = True
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(336, 104)
        Me.txtTen.TabIndex = 5
        '
        'm_cmdChapNhan
        '
        Me.m_cmdChapNhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_cmdChapNhan.Location = New System.Drawing.Point(160, 176)
        Me.m_cmdChapNhan.Name = "m_cmdChapNhan"
        Me.m_cmdChapNhan.Size = New System.Drawing.Size(130, 28)
        Me.m_cmdChapNhan.TabIndex = 6
        Me.m_cmdChapNhan.Text = "&Chấp nhận"
        '
        'm_cmdHuyBo
        '
        Me.m_cmdHuyBo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_cmdHuyBo.Location = New System.Drawing.Point(296, 176)
        Me.m_cmdHuyBo.Name = "m_cmdHuyBo"
        Me.m_cmdHuyBo.Size = New System.Drawing.Size(130, 28)
        Me.m_cmdHuyBo.TabIndex = 7
        Me.m_cmdHuyBo.Text = "&Hủy bỏ"
        '
        'f102_TuDien_DE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 207)
        Me.Controls.Add(Me.m_cmdHuyBo)
        Me.Controls.Add(Me.m_cmdChapNhan)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtTenNgan)
        Me.Controls.Add(Me.txtMaTuDien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f102_TuDien_DE"
        Me.Text = "M102 - Cập nhật từ điển"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Các thuộc tính riêng"
    Private m_FormMode As IPConstants.DataEntryFormMode
    Private m_USTuDien As US_CM_DM_TU_DIEN
    Private m_DialogResult As DialogResult
#End Region

#Region "Public interface"
    Public Function InsertObj(ByVal i_objTuDien As US_CM_DM_TU_DIEN) As DialogResult
        m_FormMode = IPConstants.DataEntryFormMode.InsertDataState
        m_USTuDien = i_objTuDien
        Me.ShowDialog()
        Return m_DialogResult
    End Function

    Public Function UpdateObj(ByVal i_objTuDien As US_CM_DM_TU_DIEN) As DialogResult
        m_FormMode = IPConstants.DataEntryFormMode.UpdateDataState
        m_USTuDien = i_objTuDien
        Me.ShowDialog()
        Return m_DialogResult
    End Function
#End Region

#Region "Private method"
    Private Sub formatControls()
        CControlFormat.setFormStyle(Me)
        Me.KeyPreview = True
        CControlFormat.setButtonStyle(Me.m_cmdChapNhan, CControlFormat.ButtonStyle.OkButtonStyle)
        CControlFormat.setButtonStyle(Me.m_cmdHuyBo, CControlFormat.ButtonStyle.CancelButtonStyle)

    End Sub
    Private Function CheckValidate() As Boolean
        If Not CValidateTextBox.IsValid(txtMaTuDien, DataType.StringType, allowNull.NO) Then Return False
        If Not CValidateTextBox.IsValid(Me.txtTenNgan, DataType.StringType, allowNull.NO) Then Return False
        Return True
    End Function

    Private Sub Form2USObj(ByVal i_objUS As US_CM_DM_TU_DIEN)
        i_objUS.strMA_TU_DIEN = txtMaTuDien.Text
        i_objUS.strTEN = txtTen.Text
        i_objUS.strTEN_NGAN = txtTenNgan.Text
        i_objUS.strGHI_CHU = ""
    End Sub

    Private Sub USObj2Form(ByVal i_objUS As US_CM_DM_TU_DIEN)
        txtMaTuDien.Text = i_objUS.strMA_TU_DIEN
        txtTenNgan.Text = i_objUS.strTEN_NGAN
        txtTen.Text = i_objUS.strTEN
    End Sub

#End Region


    Private Sub f101_TuDien_DE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_DialogResult = DialogResult.Cancel
        Select Case m_FormMode
            Case IPConstants.DataEntryFormMode.InsertDataState

            Case IPConstants.DataEntryFormMode.UpdateDataState
                Me.USObj2Form(m_USTuDien)
        End Select
    End Sub

    Private Sub m_cmdHuyBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdHuyBo.Click
        Me.Close()
    End Sub


    Private Sub m_cmdChapNhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_cmdChapNhan.Click
        If Not Me.CheckValidate() Then
            Exit Sub
        End If

        Me.Form2USObj(m_USTuDien)
        Try
            Select Case m_FormMode
                Case IPConstants.DataEntryFormMode.InsertDataState
                    m_USTuDien.Insert()
                Case IPConstants.DataEntryFormMode.UpdateDataState
                    m_USTuDien.Update()
            End Select
            m_DialogResult = DialogResult.OK
            Me.Close()
        Catch v_e As Exception
            Dim v_ErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_ErrHandler.setErrorMsg(CDBExceptionHandler.DBErrorIndex.NoParentFound, "Không tìm thấy loại từ điển")
            v_ErrHandler.showErrorMessage()
        End Try
    End Sub

    Private Sub f101_TuDien_DE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                Case Keys.C
                    If e.Alt Then
                        m_cmdChapNhan_Click(sender, e)
                    End If
            End Select
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub
End Class
