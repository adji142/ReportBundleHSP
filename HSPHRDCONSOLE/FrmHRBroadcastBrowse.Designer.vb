<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHRBroadcastBrowse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHRBroadcastBrowse))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.btAdd = New System.Windows.Forms.ToolStripButton()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnresend = New System.Windows.Forms.ToolStripButton()
        Me.View = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Toolbar.SuspendLayout()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btAdd, Me.btRefresh, Me.btnresend})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(775, 31)
        Me.Toolbar.TabIndex = 2
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'btAdd
        '
        Me.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(28, 28)
        Me.btAdd.Text = " [F6]-Tambah Data "
        '
        'btRefresh
        '
        Me.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(28, 28)
        Me.btRefresh.Text = "Perbaharui Data "
        Me.btRefresh.ToolTipText = " [F5]-Perbaharui Data "
        '
        'btnresend
        '
        Me.btnresend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnresend.Image = Global.HSPHRDCONSOLE.My.Resources.Resources.resend
        Me.btnresend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnresend.Name = "btnresend"
        Me.btnresend.Size = New System.Drawing.Size(28, 28)
        Me.btnresend.Text = "Resend"
        Me.btnresend.ToolTipText = "[F4] Resend"
        '
        'View
        '
        Me.View.AllowUserToAddRows = False
        Me.View.AllowUserToDeleteRows = False
        Me.View.AllowUserToOrderColumns = True
        Me.View.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.View.BackgroundColor = System.Drawing.Color.White
        Me.View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.View.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View.DefaultCellStyle = DataGridViewCellStyle2
        Me.View.Location = New System.Drawing.Point(0, 34)
        Me.View.MultiSelect = False
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.View.RowHeadersVisible = False
        Me.View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View.ShowEditingIcon = False
        Me.View.Size = New System.Drawing.Size(775, 227)
        Me.View.StandardTab = True
        Me.View.TabIndex = 3
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusBar.Location = New System.Drawing.Point(0, 239)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(775, 22)
        Me.StatusBar.TabIndex = 4
        Me.StatusBar.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(31, 17)
        Me.Status.Text = "Data"
        '
        'FrmHRBroadcastBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 261)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.Toolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHRBroadcastBrowse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Riwayat Broadcast"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents btAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Private WithEvents View As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnresend As System.Windows.Forms.ToolStripButton
End Class
