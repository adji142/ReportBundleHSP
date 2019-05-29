<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Friend WithEvents AxCalendar1 As AxCALENDARLib.AxCalendar
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AxCalendar1 = New AxCALENDARLib.AxCalendar()
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CmbMonthPeriod = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbYearPeriod = New System.Windows.Forms.ToolStripComboBox()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewWO = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ViewBOM = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ViewMechine = New Enerzie.EPSGridControls.EPSDataGridView()
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Toolbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ViewWO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ViewBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ViewMechine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxCalendar1
        '
        Me.AxCalendar1.Enabled = True
        Me.AxCalendar1.Location = New System.Drawing.Point(12, 34)
        Me.AxCalendar1.Name = "AxCalendar1"
        Me.AxCalendar1.OcxState = CType(resources.GetObject("AxCalendar1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCalendar1.Size = New System.Drawing.Size(471, 361)
        Me.AxCalendar1.TabIndex = 59
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.CmbMonthPeriod, Me.ToolStripLabel1, Me.cmbYearPeriod, Me.btRefresh})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(1255, 31)
        Me.Toolbar.TabIndex = 60
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(56, 28)
        Me.ToolStripLabel2.Text = "&Periode : "
        '
        'CmbMonthPeriod
        '
        Me.CmbMonthPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMonthPeriod.Name = "CmbMonthPeriod"
        Me.CmbMonthPeriod.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(12, 28)
        Me.ToolStripLabel1.Text = "-"
        '
        'cmbYearPeriod
        '
        Me.cmbYearPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearPeriod.Name = "cmbYearPeriod"
        Me.cmbYearPeriod.Size = New System.Drawing.Size(121, 31)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(489, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 23)
        Me.Panel1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Work Order this Day"
        '
        'ViewWO
        '
        Me.ViewWO.AllowUserToAddRows = False
        Me.ViewWO.AllowUserToDeleteRows = False
        Me.ViewWO.AllowUserToOrderColumns = True
        Me.ViewWO.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.ViewWO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewWO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ViewWO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewWO.BackgroundColor = System.Drawing.Color.White
        Me.ViewWO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewWO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewWO.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewWO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewWO.DefaultCellStyle = DataGridViewCellStyle2
        Me.ViewWO.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ViewWO.Location = New System.Drawing.Point(489, 63)
        Me.ViewWO.MultiSelect = False
        Me.ViewWO.Name = "ViewWO"
        Me.ViewWO.ReadOnly = True
        Me.ViewWO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewWO.RowHeadersVisible = False
        Me.ViewWO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ViewWO.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ViewWO.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.ViewWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewWO.ShowEditingIcon = False
        Me.ViewWO.Size = New System.Drawing.Size(754, 112)
        Me.ViewWO.StandardTab = True
        Me.ViewWO.TabIndex = 62
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(489, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(754, 23)
        Me.Panel2.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bill Of Material"
        '
        'ViewBOM
        '
        Me.ViewBOM.AllowUserToAddRows = False
        Me.ViewBOM.AllowUserToDeleteRows = False
        Me.ViewBOM.AllowUserToOrderColumns = True
        Me.ViewBOM.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.ViewBOM.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ViewBOM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ViewBOM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewBOM.BackgroundColor = System.Drawing.Color.White
        Me.ViewBOM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewBOM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewBOM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewBOM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewBOM.DefaultCellStyle = DataGridViewCellStyle5
        Me.ViewBOM.Location = New System.Drawing.Point(489, 210)
        Me.ViewBOM.MultiSelect = False
        Me.ViewBOM.Name = "ViewBOM"
        Me.ViewBOM.ReadOnly = True
        Me.ViewBOM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewBOM.RowHeadersVisible = False
        Me.ViewBOM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewBOM.ShowEditingIcon = False
        Me.ViewBOM.Size = New System.Drawing.Size(754, 112)
        Me.ViewBOM.StandardTab = True
        Me.ViewBOM.TabIndex = 63
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(489, 328)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(754, 23)
        Me.Panel3.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mechine Used"
        '
        'ViewMechine
        '
        Me.ViewMechine.AllowUserToAddRows = False
        Me.ViewMechine.AllowUserToDeleteRows = False
        Me.ViewMechine.AllowUserToOrderColumns = True
        Me.ViewMechine.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.ViewMechine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ViewMechine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ViewMechine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewMechine.BackgroundColor = System.Drawing.Color.White
        Me.ViewMechine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewMechine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewMechine.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewMechine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewMechine.DefaultCellStyle = DataGridViewCellStyle7
        Me.ViewMechine.Location = New System.Drawing.Point(489, 357)
        Me.ViewMechine.MultiSelect = False
        Me.ViewMechine.Name = "ViewMechine"
        Me.ViewMechine.ReadOnly = True
        Me.ViewMechine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewMechine.RowHeadersVisible = False
        Me.ViewMechine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewMechine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewMechine.ShowEditingIcon = False
        Me.ViewMechine.Size = New System.Drawing.Size(754, 112)
        Me.ViewMechine.StandardTab = True
        Me.ViewMechine.TabIndex = 64
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 492)
        Me.Controls.Add(Me.ViewMechine)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ViewBOM)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ViewWO)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Toolbar)
        Me.Controls.Add(Me.AxCalendar1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ViewWO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ViewBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ViewMechine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbMonthPeriod As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbYearPeriod As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents ViewWO As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents ViewBOM As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents ViewMechine As Enerzie.EPSGridControls.EPSDataGridView

End Class
