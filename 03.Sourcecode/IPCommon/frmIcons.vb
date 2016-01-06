Public Class frmIcons
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
    Friend WithEvents m_imgListOfIcons As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIcons))
        Me.m_imgListOfIcons = New System.Windows.Forms.ImageList(Me.components)
        '
        'm_imgListOfIcons
        '
        Me.m_imgListOfIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.m_imgListOfIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.m_imgListOfIcons.ImageStream = CType(resources.GetObject("m_imgListOfIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.m_imgListOfIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmIcons
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(219, 34)
        Me.Name = "frmIcons"
        Me.Text = "frmIcons"

    End Sub

#End Region

End Class
