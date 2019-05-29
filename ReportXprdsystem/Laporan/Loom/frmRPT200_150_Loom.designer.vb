<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPT200_150_Loom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPT200_150_Loom))
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboKodeUnit = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cboNomorWO = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboLaporan = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.RPT = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btLookupNomorWO = New System.Windows.Forms.ToolStripButton()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Toolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.cboKodeUnit, Me.ToolStripSeparator6, Me.ToolStripLabel4, Me.cboNomorWO, Me.btLookupNomorWO, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboLaporan, Me.ToolStripSeparator4, Me.btRefresh, Me.ProgressBar})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Toolbar.Size = New System.Drawing.Size(1086, 31)
        Me.Toolbar.TabIndex = 4
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 28)
        Me.ToolStripLabel2.Text = "&Unit Produksi :"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(150, 31)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(77, 28)
        Me.ToolStripLabel4.Text = "Nomor WO : "
        '
        'cboNomorWO
        '
        Me.cboNomorWO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorWO.Name = "cboNomorWO"
        Me.cboNomorWO.Size = New System.Drawing.Size(200, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
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
        Me.cboLaporan.Items.AddRange(New Object() {"200151"})
        Me.cboLaporan.Name = "cboLaporan"
        Me.cboLaporan.Size = New System.Drawing.Size(150, 31)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ProgressBar
        '
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(150, 28)
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
        Me.RPT.Size = New System.Drawing.Size(1086, 353)
        Me.RPT.TabIndex = 3
        Me.RPT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.RPT.ToolPanelWidth = 250
        '
        'btLookupNomorWO
        '
        Me.btLookupNomorWO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btLookupNomorWO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btLookupNomorWO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btLookupNomorWO.Image = CType(resources.GetObject("btLookupNomorWO.Image"), System.Drawing.Image)
        Me.btLookupNomorWO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btLookupNomorWO.Name = "btLookupNomorWO"
        Me.btLookupNomorWO.Size = New System.Drawing.Size(23, 28)
        Me.btLookupNomorWO.Text = "..."
        Me.btLookupNomorWO.ToolTipText = "[F10] Lookup Nomor WO"
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
        'frmRPT200_150_Loom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1086, 385)
        Me.Controls.Add(Me.RPT)
        Me.Controls.Add(Me.Toolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRPT200_150_Loom"
        Me.Text = "Laporan Penyelesaian Work Order Loom"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents RPT As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents RPT As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboKodeUnit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboLaporan As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboNomorWO As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btLookupNomorWO As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar

End Class
