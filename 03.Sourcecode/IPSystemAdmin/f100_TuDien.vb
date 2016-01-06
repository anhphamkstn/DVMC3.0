Option Strict On
Option Explicit On

Imports IP.Core.IPException
Imports IP.Core.IPCommon
Imports IP.Core.IPData
Imports IP.Core.IPUserService
Imports IP.Core.IPData.DBNames

Public Class f100_TuDien
    Inherits System.Windows.Forms.Form
    Implements I_IPDataMaintainForm

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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents m_cboLoaiTDFilter As System.Windows.Forms.ComboBox
    Friend WithEvents m_lblInfo As System.Windows.Forms.Label
    Friend WithEvents m_fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents m_lblFilter As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f100_TuDien))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.m_lblFilter = New System.Windows.Forms.Label()
        Me.m_cboLoaiTDFilter = New System.Windows.Forms.ComboBox()
        Me.m_lblInfo = New System.Windows.Forms.Label()
        Me.m_fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1.SuspendLayout()
        CType(Me.m_fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 493)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.m_lblFilter)
        Me.Panel1.Controls.Add(Me.m_cboLoaiTDFilter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 32)
        Me.Panel1.TabIndex = 11
        '
        'm_lblFilter
        '
        Me.m_lblFilter.Location = New System.Drawing.Point(8, 11)
        Me.m_lblFilter.Name = "m_lblFilter"
        Me.m_lblFilter.Size = New System.Drawing.Size(80, 16)
        Me.m_lblFilter.TabIndex = 12
        Me.m_lblFilter.Text = "Lọc theo loại"
        '
        'm_cboLoaiTDFilter
        '
        Me.m_cboLoaiTDFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.m_cboLoaiTDFilter.Location = New System.Drawing.Point(104, 8)
        Me.m_cboLoaiTDFilter.Name = "m_cboLoaiTDFilter"
        Me.m_cboLoaiTDFilter.Size = New System.Drawing.Size(585, 22)
        Me.m_cboLoaiTDFilter.TabIndex = 11
        '
        'm_lblInfo
        '
        Me.m_lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.m_lblInfo.Location = New System.Drawing.Point(4, 469)
        Me.m_lblInfo.Name = "m_lblInfo"
        Me.m_lblInfo.Size = New System.Drawing.Size(768, 24)
        Me.m_lblInfo.TabIndex = 12
        Me.m_lblInfo.Text = "F3 : thêm ; F4 : sửa; ESC : thoát"
        '
        'm_fg
        '
        Me.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo")
        Me.m_fg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_fg.ExtendLastCol = True
        Me.m_fg.Location = New System.Drawing.Point(4, 32)
        Me.m_fg.Name = "m_fg"
        Me.m_fg.Size = New System.Drawing.Size(768, 437)
        Me.m_fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"))
        Me.m_fg.TabIndex = 13
        '
        'f100_TuDien
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(772, 493)
        Me.Controls.Add(Me.m_fg)
        Me.Controls.Add(Me.m_lblInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "f100_TuDien"
        Me.Text = "M100 - Từ điển"
        Me.Panel1.ResumeLayout(False)
        CType(Me.m_fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Data structure"
    Private Enum ColNumber
        ID = 1
        TEN_OUTLINE = 2
        MA_TU_DIEN = 3
        TEN = 4
    End Enum

    Private Enum TreeLevel
        LOAI_TU_DIEN = 0
        GIA_TRI_TU_DIEN = 1
    End Enum

    Private Enum eformMode
        LOAD_TAT_CA_LOAI_TD = 0
        THEO_LOAI_TD = 1
    End Enum
    Private Const ALL_SELECTED As Decimal = -1
#End Region

#Region "Class Members"
    Private m_LoaiTuDien_CouldBe_Changed As Boolean = True
    Private m_MaLoaiTuDien_Fixed As String
    Private m_ds_loai_tu_dien As DS_CM_DM_LOAI_TD
    Private m_ds_tu_dien As DS_CM_DM_TU_DIEN
    Private m_dc_id_laoi_td As Decimal
    Private m_eformMode As eformMode = eformMode.LOAD_TAT_CA_LOAI_TD

#End Region




#Region "PRIVATE"

    Private Function getTenLoaiTuDien(ByVal i_dcIDLoaiTD As Decimal) As String
        Static v_objTenLoaiHSTable As CListOfDataFromDB
        If v_objTenLoaiHSTable Is Nothing Then
            v_objTenLoaiHSTable = New CListOfDataFromDB(Me.m_ds_loai_tu_dien, "ID", "TEN_LOAI")
        End If
        Return convert.ToString(v_objTenLoaiHSTable(i_dcIDLoaiTD))
    End Function

    Private Function isMaTuDienRow(ByVal i_row As Integer) As Boolean
        Return m_fg.Rows(i_row).Node.Level = treelevel.GIA_TRI_TU_DIEN
    End Function

    Private Sub setLevelOfRow(ByVal i_level As treelevel, ByVal i_grid_row_index As Integer)
        m_fg.Rows(i_grid_row_index).IsNode = True
        m_fg.Rows(i_grid_row_index).Node.Level = i_level

    End Sub


    Private Sub TuDienDataRow_2_GridRow(ByVal i_dr_tu_dien As DataRow, ByVal i_grid_row_index As Integer)
        m_fg(i_grid_row_index, colnumber.ID) = cnull.RowNVLDecimal(i_dr_tu_dien, "ID")
        m_fg(i_grid_row_index, colnumber.MA_TU_DIEN) = cnull.RowNVLString(i_dr_tu_dien, "MA_TU_DIEN")
        m_fg(i_grid_row_index, colnumber.TEN) = cnull.RowNVLString(i_dr_tu_dien, "TEN")
        m_fg(i_grid_row_index, colnumber.TEN_OUTLINE) = cnull.RowNVLString(i_dr_tu_dien, "TEN_NGAN")
        m_fg.rows(i_grid_row_index).UserData = i_dr_tu_dien
        setLevelOfRow(TreeLevel.GIA_TRI_TU_DIEN, i_grid_row_index)
    End Sub



    Private Sub loadData_fromDB_toDatasets()
        Dim v_us_tu_dien As New US_CM_DM_TU_DIEN
        Try
            v_us_tu_dien.BeginTransaction()
            Me.m_ds_tu_dien = New DS_CM_DM_TU_DIEN
            v_us_tu_dien.FillDataset(m_ds_tu_dien)

            Dim v_us_loai_tu_dien As New US_CM_DM_LOAI_TD
            v_us_loai_tu_dien.UseTransOfUSObject(v_us_tu_dien)
            Me.m_ds_loai_tu_dien = New DS_CM_DM_LOAI_TD()
            v_us_loai_tu_dien.FillDataset(m_ds_loai_tu_dien)

            v_us_tu_dien.CommitTransaction()
        Catch v_e As Exception
            v_us_tu_dien.Rollback()
            Dim v_handler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret())
            v_handler.showErrorMessage()
        End Try
    End Sub

    Private Sub loadCBO_LoaiTD()
        Try
            RemoveHandler m_cboLoaiTDFilter.SelectedIndexChanged, AddressOf m_cboLoaiTDFilter_SelectedIndexChanged
            Dim v_arrlist As New ArrayList()
            Dim v_dr_all As DataRow = Me.m_ds_loai_tu_dien.CM_DM_LOAI_TD.NewRow()
            If Me.m_LoaiTuDien_CouldBe_Changed Then
                v_arrlist.Add(v_dr_all)
                v_dr_all("TEN_LOAI") = "Tất cả các loại"
                v_dr_all("ID") = ALL_SELECTED
                Dim v_datarow As DataRow
                For Each v_datarow In Me.m_ds_loai_tu_dien.CM_DM_LOAI_TD
                    v_arrlist.Add(v_datarow)
                Next
            Else ' chỉ được 1 loại duy nhất
                Dim v_dv As New DataView(m_ds_loai_tu_dien.CM_DM_LOAI_TD)
                v_dv.RowFilter = "MA_LOAI = " & "'" & Me.m_MaLoaiTuDien_Fixed & "'"
                Dim v_drv As datarowview
                For Each v_drv In v_dv
                    v_arrlist.Add(v_drv.Row)
                Next
            End If
            m_cboLoaiTDFilter.DataSource = v_arrlist
            m_cboloaitdfilter.ValueMember = "ID"
            m_cboLoaiTDFilter.DisplayMember = "TEN_LOAI"

            m_cboloaitdfilter.SelectedIndex = 0
            Me.m_cboLoaiTDFilter_SelectedIndexChanged(m_cboloaitdfilter, Nothing)

        Catch V_E As Exception
            csystemlog_301.ExceptionHandle(v_e)
        Finally
            AddHandler m_cboLoaiTDFilter.SelectedIndexChanged, AddressOf m_cboLoaiTDFilter_SelectedIndexChanged
        End Try
    End Sub

    Private Sub formatControls()
        CControlFormat.setFormStyle(Me)

        Me.KeyPreview = True
        m_fg.AllowEditing = False
        CControlFormat.setC1FlexFormat(m_fg)
        m_fg.ExtendLastCol = True
        cgridutils.AddSearch_Handlers(m_fg)
        cgridutils.AddTree_Toogle_Handlers(m_fg)
        m_fg.Tree.Column = ColNumber.TEN_OUTLINE
        m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf

    End Sub


#End Region

#Region "PUBLIC INTERFACE"
    Public Sub displayDataMaintain(ByVal i_constraintObject As Object) _
                Implements I_IPDataMaintainForm.displayDataMaintain
        Try
            If i_constraintObject Is Nothing Then
                Me.m_LoaiTuDien_CouldBe_Changed = True
            Else
                m_MaLoaiTuDien_Fixed = CType(i_constraintObject, String)
                Me.m_LoaiTuDien_CouldBe_Changed = False
            End If
            f100_TuDien_Load(Me, Nothing)
            Me.ShowDialog()
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub

    Public Sub display_by_Loai_TD(ByVal i_dc_loai_TD As Decimal)
        Try
            f100_TuDien_Load(Me, Nothing)
            m_dc_id_laoi_td = i_dc_loai_TD
            m_eformMode = eformMode.THEO_LOAI_TD
            Me.ShowDialog()
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub


    Private Sub loadData_fromDatasets_toGrid(ByVal i_dcID_loai_TD As Decimal)
        Try
            m_fg.Redraw = False
            CGridUtils.ClearDataInGrid(m_fg)
            'FILTER LOAI TU DIEN 
            Dim v_strFilterLTD As String = " 1 = 1 "
            If i_dcID_loai_TD <> ALL_SELECTED Then
                v_strFilterLTD = "ID = " & i_dcID_loai_TD.ToString()
            End If
            Dim v_dvLoaiTD As New DataView(Me.m_ds_loai_tu_dien.CM_DM_LOAI_TD, _
                                            v_strFilterLTD, _
                                            "ID", DataViewRowState.CurrentRows)

            Dim v_iGridRowIndex As Integer
            Dim v_drvLTD As DataRowView
            For Each v_drvLTD In v_dvLoaiTD
                Dim v_dcIDLoaiTD As Decimal = CNull.RowNVLDecimal(v_drvLTD.Row, "ID")
                m_fg.Rows.Count += 1
                v_iGridRowIndex = m_fg.Rows.Count - 1
                LoaiTD_2_GridRow(v_dcIDLoaiTD, v_iGridRowIndex)


                Dim v_strSort As String = "ID_LOAI_TU_DIEN, MA_TU_DIEN"
                Dim v_dvTuDien As DataView = New DataView(Me.m_ds_tu_dien.CM_DM_TU_DIEN, _
                                                          "ID_LOAI_TU_DIEN =" & v_dcIDLoaiTD, _
                                                        v_strSort, _
                                                        DataViewRowState.CurrentRows)
                Dim v_drvTuDien As DataRowView
                For Each v_drvTuDien In v_dvTuDien
                    m_fg.Rows.Count += 1
                    v_iGridRowIndex = m_fg.Rows.Count - 1
                    Me.TuDienDataRow_2_GridRow(v_drvTuDien.Row, v_iGridRowIndex)
                Next
            Next
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
        Finally
            m_fg.Redraw = True
        End Try
    End Sub

    Private Sub LoaiTD_2_GridRow(ByVal i_dcIDLoaiTD As Decimal, ByVal i_iGridRowIndex As Integer)
        m_fg(i_iGridRowIndex, ColNumber.ID) = i_dcIDLoaiTD
        m_fg(i_iGridRowIndex, ColNumber.TEN_OUTLINE) = Me.getTenLoaiTuDien(i_dcIDLoaiTD)
        Me.setLevelOfRow(TreeLevel.LOAI_TU_DIEN, i_iGridRowIndex)
        Dim v_cellrange As C1.Win.C1FlexGrid.CellRange = m_fg.GetCellRange(i_iGridRowIndex, ColNumber.TEN_OUTLINE)
        v_cellrange.Style = m_fg.Styles("BOLDSTYLE")
    End Sub

    Private Sub addNewGiaTriTuDien()
        Dim v_dcIDLoaiTD As Decimal
        If Me.isMaTuDienRow(m_fg.Row) Then
            Dim v_usTD As New US_CM_DM_TU_DIEN
            Dim v_drTD As DataRow = CType(m_fg.Rows(m_fg.Row).UserData, DataRow)
            v_usTD.DataRow2Me(v_drTD)
            v_dcIDLoaiTD = v_usTD.dcID_LOAI_TU_DIEN
        Else
            v_dcIDLoaiTD = Convert.ToDecimal(m_fg(m_fg.Row, ColNumber.ID))
        End If
        Dim v_usTuDien As New US_CM_DM_TU_DIEN
        v_usTuDien.dcID_LOAI_TU_DIEN = v_dcIDLoaiTD
        Dim v_CalledForm As New f102_TuDien_DE
        If v_CalledForm.InsertObj(v_usTuDien) = DialogResult.OK Then
            'add new row to dataset
            Dim v_drTuDien As DataRow = Me.m_ds_tu_dien.CM_DM_TU_DIEN.NewRow()
            v_usTuDien.Me2DataRow(v_drTuDien)
            Me.m_ds_tu_dien.CM_DM_TU_DIEN.Rows.Add(v_drTuDien)
            'add new ro to grid
            Dim v_iNewGridRowIndex As Integer = m_fg.Row + 1
            m_fg.Rows.Insert(v_iNewGridRowIndex)
            Me.TuDienDataRow_2_GridRow(v_drTuDien, v_iNewGridRowIndex)
        End If
    End Sub

    Private Sub updateGiaTriTuDien()
        If Not Me.isMaTuDienRow(m_fg.Row) Then Exit Sub
        Dim v_drTuDien As DataRow = CType(m_fg.Rows(m_fg.Row).UserData, DataRow)
        Dim v_usTuDien As New US_CM_DM_TU_DIEN
        v_usTuDien.DataRow2Me(v_drTuDien)
        Try
            Dim v_CalledForm As New f102_TuDien_DE


            If v_CalledForm.UpdateObj(v_usTuDien) = DialogResult.OK Then
                v_usTuDien.Me2DataRow(v_drTuDien)
                Me.TuDienDataRow_2_GridRow(v_drTuDien, m_fg.Row)
            End If


        Catch v_e As System.Exception

            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub

    Private Sub xoaGiaTriTuDien()
        If Not Me.isMaTuDienRow(m_fg.Row) Then Exit Sub
        If BaseMessages.askUser_DataCouldBeDeleted() = BaseMessages.IsDataCouldBeDeleted.ShouldNotBeDeleted Then Exit Sub
        Dim v_drTuDien As DataRow = CType(m_fg.Rows(m_fg.Row).UserData, DataRow)
        Dim v_usTuDien As New US_CM_DM_TU_DIEN
        v_usTuDien.DataRow2Me(v_drTuDien)
        Try
            v_usTuDien.BeginTransaction()
            'If v_usTuDien.isUpdatable() Then
            v_usTuDien.Delete()
            m_fg.Rows.Remove(m_fg.Row)
            'End If
            v_usTuDien.CommitTransaction()
        Catch v_e As System.Exception
            v_usTuDien.Rollback()
            Dim v_ErrHandler As New CDBExceptionHandler(v_e, New CDBClientDBExceptionInterpret)
            v_ErrHandler.showErrorMessage()
        End Try
    End Sub


#End Region
    '
    ' ENVENT HANDLERS
    '
    Private Sub f100_TuDien_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                Case Keys.F3
                    addNewGiaTriTuDien()
                Case Keys.F4
                    updateGiaTriTuDien()
            End Select
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub

    Private Sub f100_TuDien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.loadData_fromDB_toDatasets()
            Me.loadCBO_LoaiTD()
            CGridUtils.stand_on_TopLeft_Cell(m_fg)
            If Not Me.m_LoaiTuDien_CouldBe_Changed Then
                Me.m_lblFilter.Visible = False
                m_lblFilter.Top = -100
                Me.m_cboLoaiTDFilter.Visible = False
                m_cboLoaiTDFilter.Top = -100
            End If

            If m_eformMode = eformMode.THEO_LOAI_TD Then
                m_cboLoaiTDFilter.SelectedValue = m_dc_id_laoi_td
                m_cboLoaiTDFilter.Enabled = False
            End If

        Catch v_e As Exception
            csystemlog_301.ExceptionHandle(v_e)
        End Try
    End Sub

    Private Sub m_cboLoaiTDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_cboLoaiTDFilter.SelectedIndexChanged
        Try
            loadData_fromDatasets_toGrid(Convert.ToDecimal(m_cboLoaiTDFilter.SelectedValue))
        Catch v_e As Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub
End Class