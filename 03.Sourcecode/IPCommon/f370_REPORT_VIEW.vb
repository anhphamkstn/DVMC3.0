Imports System.Windows.Forms

'''''import crystal
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine

Public Class f370_REPORT_VIEW
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.formatform()

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
    Friend WithEvents m_crvVIEW_REPORT As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.m_crvVIEW_REPORT = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'm_crvVIEW_REPORT
        '
        Me.m_crvVIEW_REPORT.ActiveViewIndex = -1
        Me.m_crvVIEW_REPORT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m_crvVIEW_REPORT.Location = New System.Drawing.Point(0, 0)
        Me.m_crvVIEW_REPORT.Name = "m_crvVIEW_REPORT"
        Me.m_crvVIEW_REPORT.ReportSource = Nothing
        Me.m_crvVIEW_REPORT.ShowRefreshButton = False
        Me.m_crvVIEW_REPORT.Size = New System.Drawing.Size(790, 531)
        Me.m_crvVIEW_REPORT.TabIndex = 0
        '
        'f370_REPORT_VIEW
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 531)
        Me.Controls.Add(Me.m_crvVIEW_REPORT)
        Me.Name = "f370_REPORT_VIEW"
        Me.Text = "M370 - In báo cáo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region " MEMBERS "

#End Region

#Region "Public interface"

    Public Sub show_Report(ByVal i_dt As DataTable, _
                            ByVal i_strPath As String, _
                            Optional ByVal i_pfParameterFields As ParameterFields = Nothing)
        Dim v_crsReport As New ReportDocument
        v_crsReport.Load(i_strPath)
        v_crsReport.SetDataSource(i_dt)
        If Not i_pfParameterFields Is Nothing Then
            m_crvVIEW_REPORT.ParameterFieldInfo = i_pfParameterFields
        End If
        m_crvVIEW_REPORT.ReportSource = v_crsReport

        Me.ShowDialog()
    End Sub

#End Region

#Region "PRIVATE METHODS"
    Private Sub formatform()
        'CControlFormat.setFormStyle(Me)
        Me.KeyPreview = True
    End Sub
#End Region

End Class
