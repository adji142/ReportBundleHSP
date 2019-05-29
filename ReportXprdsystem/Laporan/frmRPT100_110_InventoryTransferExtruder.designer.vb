<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT100_110_InventoryTransferExtruder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT100_110_InventoryTransferExtruder))
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboKodeLokasi = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboLaporan = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.RPT = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Toolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripSeparator5, Me.ToolStripLabel2, Me.cboKodeLokasi, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.cboLaporan, Me.ToolStripSeparator1, Me.btRefresh})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Toolbar.Size = New System.Drawing.Size(1006, 31)
        Me.Toolbar.TabIndex = 4
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(56, 28)
        Me.ToolStripLabel3.Text = "&Periode : "
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(24, 28)
        Me.ToolStripLabel4.Text = "s/d"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(46, 28)
        Me.ToolStripLabel2.Text = "&Lokasi :"
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(250, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 28)
        Me.ToolStripLabel1.Text = "Laporan : "
        '
        'cboLaporan
        '
        Me.cboLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLaporan.Items.AddRange(New Object() {"100111", "100112"})
        Me.cboLaporan.Name = "cboLaporan"
        Me.cboLaporan.Size = New System.Drawing.Size(250, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btRefresh
        '
        Me.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(28, 28)
        Me.btRefresh.Text = "Tampilkan Laporan"
        Me.btRefresh.ToolTipText = " [F5]-Tampilkan Laporan"
        '
        'RPT
        '
        Me.RPT.ActiveViewIndex = -1
        Me.RPT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RPT.AutoScroll = True
        Me.RPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RPT.Cursor = System.Windows.Forms.Cursors.Default
        Me.RPT.DisplayBackgroundEdge = False
        Me.RPT.DisplayStatusBar = False
        Me.RPT.EnableDrillDown = False
        Me.RPT.EnableRefresh = False
        Me.RPT.EnableToolTips = False
        Me.RPT.Location = New System.Drawing.Point(0, 34)
        Me.RPT.Name = "RPT"
        Me.RPT.ShowCloseButton = False
        Me.RPT.ShowLogo = False
        Me.RPT.ShowParameterPanelButton = False
        Me.RPT.ShowRefreshButton = False
        Me.RPT.Size = New System.Drawing.Size(1006, 353)
        Me.RPT.TabIndex = 3
        Me.RPT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.RPT.ToolPanelWidth = 250
        '
        'frmRPT100_110_InventoryTransferExtruder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 385)
        Me.Controls.Add(Me.RPT)
        Me.Controls.Add(Me.Toolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRPT100_110_InventoryTransferExtruder"
        Me.Text = "Laporan Penerimaan Produksi"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents RPT As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboKodeLokasi As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboLaporan As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RPT As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
