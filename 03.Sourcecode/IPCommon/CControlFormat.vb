Option Explicit On 
Option Strict On

Imports System.Windows.Forms

Public Interface IControlerControl
    Function CanUseControl( _
                ByVal ip_strFormName As String _
                , ByVal ip_strControlName As String _
                , ByVal ip_strControlType As String) As Boolean
End Interface

Public Class CControlFormat

#Region "Nhiệm vụ của class"
    '*******************************************************************
    ' Class này dùng để format các control dùng trong ứng dụng eSchool
    '*******************************************************************
#End Region

#Region "Constants declaration"
    Private Const C_FontName As String = "Tahoma"
    Private Const C_FormFontSize As Double = 8.35!
    Private Const C_GridFontSizeNormal As Double = 8.55!
    Private Const C_GridFontSize As Double = 10.0!
#End Region

#Region "Data structures"
    Public Enum ButtonStyle

        ExitButtonStyle
        CancelButtonStyle
        OkButtonStyle

        SmallFunctionButtonStyle
        MediumFunctionButtonStyle
        LongFunctionButtonStyle
        FreeFunctionButtonStyle
    End Enum

    Public Enum LabelStyle
        Title_Info
        HighLight_Info
        Additional_Info
        Prompt_Info
    End Enum
#End Region

#Region "Private services"
    Private Shared Function getRegularFont() As System.Drawing.Font
        Return New System.Drawing.Font(C_FontName, C_FormFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Function

    Private Shared Function getRegularForeColor() As System.Drawing.Color
        Return System.Drawing.Color.Navy
    End Function

    Private Shared Function getRegularBackColor() As System.Drawing.Color
        Return System.Drawing.Color.Gainsboro
    End Function

    Private Shared Function getBoldFont() As System.Drawing.Font
        Return New System.Drawing.Font(C_FontName, C_FormFontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Function

    Private Shared Sub i_form_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "\HELP\help.chm")
        End If

    End Sub

    Private Shared Sub formatControlInForms( _
    ByVal ip_str_form_name As String _
    , ByVal i_objControlerControl As IControlerControl _
    , ByVal ip_control As System.Windows.Forms.Control)

        'If (ip_control.ToString().IndexOf("SIS.Controls.Button.SiSButton") >= 0) Then
        '    If (i_objControlerControl.CanUseControl(ip_str_form_name, ip_control.Name, "") = False) Then
        '        ip_control.Visible = False
        '        ip_control.Enabled = False
        '    End If
        'End If
        If TypeOf ip_control Is Label Then
            ip_control.Font = getRegularFont()
            ip_control.ForeColor = getRegularForeColor()
            ip_control.BackColor = getRegularBackColor()
        ElseIf TypeOf ip_control Is TextBox Then
            ip_control.Font = getRegularFont()
            ip_control.ForeColor = getRegularForeColor()
        ElseIf TypeOf ip_control Is GroupBox Then
            ip_control.Font = getRegularFont()
            ip_control.ForeColor = getRegularForeColor()
            ip_control.BackColor = getRegularBackColor()
        ElseIf TypeOf ip_control Is ComboBox Then
            ip_control.Font = getRegularFont()
            ip_control.ForeColor = getRegularForeColor()
        ElseIf TypeOf ip_control Is CheckBox Then
            ip_control.Font = getRegularFont()
            ip_control.ForeColor = getRegularForeColor()
        ElseIf TypeOf ip_control Is Button Then
            ip_control.Font = getRegularFont()
            ip_control.ForeColor = getRegularForeColor()
            If (i_objControlerControl.CanUseControl(ip_str_form_name, ip_control.Name, "") = False) Then
                ip_control.Visible = False
                ip_control.Enabled = False
            End If
        End If
        Dim v_control As System.Windows.Forms.Control
        For Each v_control In ip_control.Controls
            formatControlInForms(ip_str_form_name, i_objControlerControl, v_control)
        Next

    End Sub
#End Region

#Region "Public interface"

    Public Shared Sub setFormStyle(ByVal i_form As Form _
    , ByVal i_objControlerControl As IControlerControl _
    , Optional ByVal i_form_style As IPFormStyle = IPFormStyle.DialogForm)
        Try
            AddHandler i_form.KeyDown, AddressOf i_form_KeyDown

            Dim v_Control As System.Windows.Forms.Control
            i_form.KeyPreview = True
            With i_form
                '.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
                .BackColor = getRegularBackColor()
                .Font = getRegularFont()
                .ForeColor = getRegularForeColor()
                Select Case i_form_style
                    Case IPFormStyle.DialogForm
                        .FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
                        .MaximizeBox = False
                        .MinimizeBox = False
                        .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                        .ShowInTaskbar = False
                    Case IPFormStyle.DockableTopForm
                        .FormBorderStyle = FormBorderStyle.Sizable
                        .MaximizeBox = False
                        .MinimizeBox = False
                        .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                        .ShowInTaskbar = False
                    Case Else

                End Select

                '.ResumeLayout(False)
                'Tund sửa ngày 11/06/2008
                formatControlInForms(i_form.Name, i_objControlerControl, i_form)

            End With
        Catch exp As Exception
            MessageBox.Show(exp.Message, i_form.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
        Finally

        End Try
    End Sub

    Public Shared Sub setFormStyle(ByVal i_form As Form)
        '***************************************************
        ' Dùng để set các property của Form ngoại trừ frmMain
        '***************************************************
        AddHandler i_form.KeyDown, AddressOf i_form_KeyDown

        Try
            Dim v_Control As System.Windows.Forms.Control
            i_form.KeyPreview = True
            With i_form
                '.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
                .BackColor = getRegularBackColor()
                .Font = getRegularFont()
                .ForeColor = getRegularForeColor()
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
                .MaximizeBox = False
                .MinimizeBox = False
                .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                .ShowInTaskbar = False
                '.ResumeLayout(False)
                'TA sửa ngày 29/12/2003
                For Each v_Control In .Controls
                    If TypeOf v_Control Is Label Then
                        v_Control.Font = getRegularFont()
                        v_Control.ForeColor = getRegularForeColor()
                        v_Control.BackColor = getRegularBackColor()
                    ElseIf TypeOf v_Control Is TextBox Then
                        v_Control.Font = getRegularFont()
                        v_Control.ForeColor = getRegularForeColor()
                    ElseIf TypeOf v_Control Is GroupBox Then
                        v_Control.Font = getRegularFont()
                        v_Control.ForeColor = getRegularForeColor()
                        v_Control.BackColor = getRegularBackColor()
                    ElseIf TypeOf v_Control Is DataGrid_Custom Then
                        v_Control.Font = getRegularFont()
                    ElseIf TypeOf v_Control Is ComboBox Then
                        v_Control.Font = getRegularFont()
                        v_Control.ForeColor = getRegularForeColor()
                    End If
                Next
            End With
        Catch exp As Exception
            MessageBox.Show(exp.Message, i_form.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
        Finally

        End Try
    End Sub

    Public Shared Sub setDataGridFormat(ByVal i_datagrid As DataGrid)
        '***************************************************
        ' Dùng để set các property của DataGrid
        '***************************************************
        With i_datagrid
            .AlternatingBackColor = System.Drawing.Color.OldLace
            .BackColor = System.Drawing.Color.OldLace
            .BackgroundColor = System.Drawing.Color.Tan
            .BorderStyle = System.Windows.Forms.BorderStyle.None
            .CaptionBackColor = System.Drawing.Color.SaddleBrown
            .CaptionForeColor = System.Drawing.Color.OldLace
            .FlatMode = True
            .Font = New System.Drawing.Font(C_FontName, C_FormFontSize)
            .ForeColor = System.Drawing.Color.DarkSlateGray
            .GridLineColor = System.Drawing.Color.Tan
            .HeaderBackColor = System.Drawing.Color.Wheat
            .HeaderFont = New System.Drawing.Font(C_FontName, C_FormFontSize, System.Drawing.FontStyle.Bold)
            .HeaderForeColor = System.Drawing.Color.SaddleBrown
            .LinkColor = System.Drawing.Color.DarkSlateBlue
            .ParentRowsBackColor = System.Drawing.Color.OldLace
            .ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
            .SelectionBackColor = System.Drawing.Color.SlateGray
            .SelectionForeColor = System.Drawing.Color.White
        End With
    End Sub

    Public Shared Sub setC1FlexFormat(ByVal i_fg As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic)
        '***************************************************
        ' Dùng để set các property của C1FlexGridClassic
        '***************************************************
        With i_fg
            'Tund sửa ngày 8/12/2004
            .KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
            .KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
            .AllowBigSelection = False
            .AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            .BackColor = System.Drawing.SystemColors.Window
            .BackColorAlternate = System.Drawing.SystemColors.Window
            .BackColorBkg = System.Drawing.SystemColors.AppWorkspace
            .BackColorFixed = System.Drawing.SystemColors.Control
            .BackColorSel = System.Drawing.SystemColors.Highlight
            .Editable = C1.Win.C1FlexGrid.Classic.EditableSettings.flexEDKbdMouse
            .ExplorerBar = C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExSortShowAndMove
            .ExtendLastCol = False
            .ForeColor = System.Drawing.SystemColors.WindowText
            .ForeColorFixed = System.Drawing.SystemColors.Highlight
            .ForeColorSel = System.Drawing.SystemColors.HighlightText
            .GridColor = System.Drawing.SystemColors.Control
            .GridColorFixed = System.Drawing.SystemColors.ControlDark
            .MergeCells = C1.Win.C1FlexGrid.Classic.MergeSettings.flexMergeOutline
            .OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
            .SheetBorder = System.Drawing.SystemColors.WindowText
            .TreeColor = System.Drawing.Color.DarkGray
            .SelectionMode = C1.Win.C1FlexGrid.Classic.SelModeSettings.flexSelectionFree
        End With
    End Sub

    Public Shared Sub setC1FixedRowsFormat(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        '***************************************************
        ' Dùng để set các property của C1FlexGrid
        '***************************************************
        With i_fg
            .AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
            .AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
            .BackColor = System.Drawing.SystemColors.Window
            .ExtendLastCol = False
            .FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            .ForeColor = System.Drawing.SystemColors.WindowText
            .Font = New System.Drawing.Font(C_FontName, C_FormFontSize, Drawing.FontStyle.Regular)
            .Styles.Fixed.Font = New System.Drawing.Font(C_FontName, C_FormFontSize, Drawing.FontStyle.Bold)
            .Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            .Styles.Fixed.ForeColor = System.Drawing.SystemColors.Highlight
            .Styles.EmptyArea.BackColor = .BackColor
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        End With
    End Sub
    ''' <summary>
    ''' Dùng để set các property của C1FlexGrid mà có thể Edit row
    ''' NinhVh sửa Ngày 21/01/2013
    ''' </summary>
    ''' <param name="i_fg"></param>
    ''' <remarks></remarks>
    Public Shared Sub setC1FlexFormatCanEdit(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        '***************************************************
        ' Dùng để set các property của C1FlexGrid
        '***************************************************
        With i_fg
            '.AllowEditing = False
            '.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
            '.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
            .BackColor = System.Drawing.SystemColors.Window
            '.Dock = System.Windows.Forms.DockStyle.Fill
            .ExtendLastCol = False
            .ForeColor = System.Drawing.SystemColors.WindowText
            .Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Complete
            .Font = New System.Drawing.Font(C_FontName, C_GridFontSize, Drawing.FontStyle.Regular)
            .Styles.Fixed.Font = New System.Drawing.Font(C_FontName, C_GridFontSize, Drawing.FontStyle.Bold)
            .Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            .Styles.Fixed.ForeColor = System.Drawing.SystemColors.Highlight
            .Styles.Alternate.BackColor = System.Drawing.Color.FromArgb(CType(241, Byte), CType(252, Byte), CType(218, Byte))
            .Styles.EmptyArea.BackColor = .BackColor
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
            .Rows.DefaultSize = 28

        End With
    End Sub
    Public Shared Sub setC1FlexFormat(ByVal i_fg As C1.Win.C1FlexGrid.C1FlexGrid)
        '***************************************************
        ' Dùng để set các property của C1FlexGrid
        '***************************************************
        With i_fg
            .AllowEditing = False
            '.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
            .AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
            .BackColor = System.Drawing.SystemColors.Window
            '.Dock = System.Windows.Forms.DockStyle.Fill
            .ExtendLastCol = False
            .ForeColor = System.Drawing.SystemColors.WindowText
            .Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Complete
            .Font = New System.Drawing.Font(C_FontName, C_GridFontSizeNormal, Drawing.FontStyle.Regular)
            .Styles.Fixed.Font = New System.Drawing.Font(C_FontName, C_FormFontSize, Drawing.FontStyle.Bold)
            .Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            .Styles.Fixed.ForeColor = System.Drawing.SystemColors.Highlight
            .Styles.Alternate.BackColor = System.Drawing.Color.FromArgb(CType(241, Byte), CType(252, Byte), CType(218, Byte))
            .Styles.EmptyArea.BackColor = .BackColor
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
        End With
    End Sub

    Public Shared Sub setTreeview(ByVal i_Treeview As TreeView)

        With i_Treeview
            .BackColor = System.Drawing.SystemColors.Info
            .Font = getRegularFont()
            .ForeColor = getRegularForeColor()
        End With
    End Sub



    Public Shared Sub setButtonStyle(ByVal i_Button As System.Windows.Forms.Button, _
                                     ByVal i_ButtonStyle As ButtonStyle)
        i_Button.Font = getRegularFont()
        i_Button.Height = 25
        i_Button.Width = 130
        i_Button.BackColor = System.Drawing.Color.LightYellow
        i_Button.ForeColor = getRegularForeColor()

        Select Case i_ButtonStyle
            Case ButtonStyle.CancelButtonStyle
                i_Button.Text = "Hủy bỏ (ESC)"
            Case ButtonStyle.ExitButtonStyle
                i_Button.Text = "Thoát (ESC)"
            Case ButtonStyle.OkButtonStyle
                i_Button.Text = "Chấp nhận (Alt+C)"
            Case ButtonStyle.FreeFunctionButtonStyle

            Case ButtonStyle.LongFunctionButtonStyle
                i_Button.Width = 200
            Case ButtonStyle.MediumFunctionButtonStyle
                i_Button.Width = 160
            Case ButtonStyle.SmallFunctionButtonStyle
                i_Button.Width = 130
        End Select
    End Sub


    Public Shared Sub setLabelStyle(ByVal i_lbl As Label, _
                                    ByVal i_labelStyle As LabelStyle)
        Dim v_Font As System.Drawing.Font = getRegularFont()
        Dim v_ForeColor As System.Drawing.Color = getRegularForeColor()
        Select Case i_labelStyle
            Case LabelStyle.Title_Info
                v_Font = getBoldFont()
                v_ForeColor = System.Drawing.Color.Blue
            Case LabelStyle.HighLight_Info
                v_Font = getBoldFont()
                v_ForeColor = System.Drawing.Color.Blue
            Case LabelStyle.Additional_Info

            Case LabelStyle.Prompt_Info
                i_lbl.Text = i_lbl.Text & vbCrLf
                i_lbl.TextAlign = Drawing.ContentAlignment.MiddleRight
        End Select
        i_lbl.Font = v_Font
        i_lbl.ForeColor = v_ForeColor
    End Sub
#End Region




End Class

Public Enum IPFormStyle
    DockableTopForm
    DialogForm
    MessageForm
    FlashForm
End Enum


