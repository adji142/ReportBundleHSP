<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonitoringSO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitoringSO))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CmbStatus = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.TabDetail = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.GridOP = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.GridWO = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Tab4 = New System.Windows.Forms.TabPage()
        Me.TabSubDetail = New System.Windows.Forms.TabControl()
        Me.SubDetail1 = New System.Windows.Forms.TabPage()
        Me.GridStockProd = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.SubDetail2 = New System.Windows.Forms.TabPage()
        Me.GridStockWHS = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Tab5 = New System.Windows.Forms.TabPage()
        Me.GridDeliv = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.View = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCari = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Toolbar.SuspendLayout()
        Me.TabDetail.SuspendLayout()
        Me.Tab1.SuspendLayout()
        CType(Me.GridOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab2.SuspendLayout()
        CType(Me.GridWO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab4.SuspendLayout()
        Me.TabSubDetail.SuspendLayout()
        Me.SubDetail1.SuspendLayout()
        CType(Me.GridStockProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubDetail2.SuspendLayout()
        CType(Me.GridStockWHS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab5.SuspendLayout()
        CType(Me.GridDeliv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CmbStatus, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.txtCari, Me.ToolStripSeparator3, Me.btRefresh})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Toolbar.Size = New System.Drawing.Size(811, 31)
        Me.Toolbar.TabIndex = 5
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(63, 28)
        Me.ToolStripLabel2.Text = "Status SO :"
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.Items.AddRange(New Object() {"Open", "Close"})
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(180, 31)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
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
        'TabDetail
        '
        Me.TabDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabDetail.Controls.Add(Me.Tab1)
        Me.TabDetail.Controls.Add(Me.Tab2)
        Me.TabDetail.Controls.Add(Me.Tab4)
        Me.TabDetail.Controls.Add(Me.Tab5)
        Me.TabDetail.Location = New System.Drawing.Point(12, 221)
        Me.TabDetail.Name = "TabDetail"
        Me.TabDetail.SelectedIndex = 0
        Me.TabDetail.Size = New System.Drawing.Size(787, 164)
        Me.TabDetail.TabIndex = 17
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.GridOP)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(779, 138)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Production Order"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'GridOP
        '
        Me.GridOP.AllowUserToAddRows = False
        Me.GridOP.AllowUserToDeleteRows = False
        Me.GridOP.AllowUserToOrderColumns = True
        Me.GridOP.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.GridOP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.GridOP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridOP.BackgroundColor = System.Drawing.Color.White
        Me.GridOP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridOP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridOP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.GridOP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridOP.ColumnHeadersHeight = 35
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridOP.DefaultCellStyle = DataGridViewCellStyle14
        Me.GridOP.Location = New System.Drawing.Point(6, 6)
        Me.GridOP.MultiSelect = False
        Me.GridOP.Name = "GridOP"
        Me.GridOP.ReadOnly = True
        Me.GridOP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridOP.RowHeadersVisible = False
        Me.GridOP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridOP.ShowEditingIcon = False
        Me.GridOP.Size = New System.Drawing.Size(767, 126)
        Me.GridOP.StandardTab = True
        Me.GridOP.TabIndex = 17
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.GridWO)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(779, 138)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Work Order"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'GridWO
        '
        Me.GridWO.AllowUserToAddRows = False
        Me.GridWO.AllowUserToDeleteRows = False
        Me.GridWO.AllowUserToOrderColumns = True
        Me.GridWO.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        Me.GridWO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.GridWO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridWO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridWO.BackgroundColor = System.Drawing.Color.White
        Me.GridWO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridWO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridWO.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.GridWO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridWO.ColumnHeadersHeight = 35
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridWO.DefaultCellStyle = DataGridViewCellStyle16
        Me.GridWO.Location = New System.Drawing.Point(6, 6)
        Me.GridWO.MultiSelect = False
        Me.GridWO.Name = "GridWO"
        Me.GridWO.ReadOnly = True
        Me.GridWO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridWO.RowHeadersVisible = False
        Me.GridWO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridWO.ShowEditingIcon = False
        Me.GridWO.Size = New System.Drawing.Size(767, 126)
        Me.GridWO.StandardTab = True
        Me.GridWO.TabIndex = 17
        '
        'Tab4
        '
        Me.Tab4.Controls.Add(Me.TabSubDetail)
        Me.Tab4.Location = New System.Drawing.Point(4, 22)
        Me.Tab4.Name = "Tab4"
        Me.Tab4.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab4.Size = New System.Drawing.Size(779, 138)
        Me.Tab4.TabIndex = 3
        Me.Tab4.Text = "Stock"
        Me.Tab4.UseVisualStyleBackColor = True
        '
        'TabSubDetail
        '
        Me.TabSubDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabSubDetail.Controls.Add(Me.SubDetail1)
        Me.TabSubDetail.Controls.Add(Me.SubDetail2)
        Me.TabSubDetail.Location = New System.Drawing.Point(6, 6)
        Me.TabSubDetail.Name = "TabSubDetail"
        Me.TabSubDetail.SelectedIndex = 0
        Me.TabSubDetail.Size = New System.Drawing.Size(767, 126)
        Me.TabSubDetail.TabIndex = 0
        '
        'SubDetail1
        '
        Me.SubDetail1.Controls.Add(Me.GridStockProd)
        Me.SubDetail1.Location = New System.Drawing.Point(4, 22)
        Me.SubDetail1.Name = "SubDetail1"
        Me.SubDetail1.Padding = New System.Windows.Forms.Padding(3)
        Me.SubDetail1.Size = New System.Drawing.Size(759, 100)
        Me.SubDetail1.TabIndex = 0
        Me.SubDetail1.Text = "Production"
        Me.SubDetail1.UseVisualStyleBackColor = True
        '
        'GridStockProd
        '
        Me.GridStockProd.AllowUserToAddRows = False
        Me.GridStockProd.AllowUserToDeleteRows = False
        Me.GridStockProd.AllowUserToOrderColumns = True
        Me.GridStockProd.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        Me.GridStockProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.GridStockProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridStockProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridStockProd.BackgroundColor = System.Drawing.Color.White
        Me.GridStockProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridStockProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridStockProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.GridStockProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridStockProd.ColumnHeadersHeight = 35
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridStockProd.DefaultCellStyle = DataGridViewCellStyle18
        Me.GridStockProd.Location = New System.Drawing.Point(6, 6)
        Me.GridStockProd.MultiSelect = False
        Me.GridStockProd.Name = "GridStockProd"
        Me.GridStockProd.ReadOnly = True
        Me.GridStockProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridStockProd.RowHeadersVisible = False
        Me.GridStockProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridStockProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridStockProd.ShowEditingIcon = False
        Me.GridStockProd.Size = New System.Drawing.Size(747, 88)
        Me.GridStockProd.StandardTab = True
        Me.GridStockProd.TabIndex = 17
        '
        'SubDetail2
        '
        Me.SubDetail2.Controls.Add(Me.GridStockWHS)
        Me.SubDetail2.Location = New System.Drawing.Point(4, 22)
        Me.SubDetail2.Name = "SubDetail2"
        Me.SubDetail2.Padding = New System.Windows.Forms.Padding(3)
        Me.SubDetail2.Size = New System.Drawing.Size(759, 100)
        Me.SubDetail2.TabIndex = 1
        Me.SubDetail2.Text = "Warehoueses"
        Me.SubDetail2.UseVisualStyleBackColor = True
        '
        'GridStockWHS
        '
        Me.GridStockWHS.AllowUserToAddRows = False
        Me.GridStockWHS.AllowUserToDeleteRows = False
        Me.GridStockWHS.AllowUserToOrderColumns = True
        Me.GridStockWHS.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        Me.GridStockWHS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.GridStockWHS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridStockWHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridStockWHS.BackgroundColor = System.Drawing.Color.White
        Me.GridStockWHS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridStockWHS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridStockWHS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.GridStockWHS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridStockWHS.ColumnHeadersHeight = 35
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridStockWHS.DefaultCellStyle = DataGridViewCellStyle20
        Me.GridStockWHS.Location = New System.Drawing.Point(6, 6)
        Me.GridStockWHS.MultiSelect = False
        Me.GridStockWHS.Name = "GridStockWHS"
        Me.GridStockWHS.ReadOnly = True
        Me.GridStockWHS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridStockWHS.RowHeadersVisible = False
        Me.GridStockWHS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridStockWHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridStockWHS.ShowEditingIcon = False
        Me.GridStockWHS.Size = New System.Drawing.Size(747, 88)
        Me.GridStockWHS.StandardTab = True
        Me.GridStockWHS.TabIndex = 18
        '
        'Tab5
        '
        Me.Tab5.Controls.Add(Me.GridDeliv)
        Me.Tab5.Location = New System.Drawing.Point(4, 22)
        Me.Tab5.Name = "Tab5"
        Me.Tab5.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab5.Size = New System.Drawing.Size(779, 138)
        Me.Tab5.TabIndex = 4
        Me.Tab5.Text = "Delivery"
        Me.Tab5.UseVisualStyleBackColor = True
        '
        'GridDeliv
        '
        Me.GridDeliv.AllowUserToAddRows = False
        Me.GridDeliv.AllowUserToDeleteRows = False
        Me.GridDeliv.AllowUserToOrderColumns = True
        Me.GridDeliv.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.GridDeliv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.GridDeliv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDeliv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridDeliv.BackgroundColor = System.Drawing.Color.White
        Me.GridDeliv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridDeliv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridDeliv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.GridDeliv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDeliv.ColumnHeadersHeight = 35
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDeliv.DefaultCellStyle = DataGridViewCellStyle22
        Me.GridDeliv.Location = New System.Drawing.Point(6, 6)
        Me.GridDeliv.MultiSelect = False
        Me.GridDeliv.Name = "GridDeliv"
        Me.GridDeliv.ReadOnly = True
        Me.GridDeliv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDeliv.RowHeadersVisible = False
        Me.GridDeliv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridDeliv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDeliv.ShowEditingIcon = False
        Me.GridDeliv.Size = New System.Drawing.Size(767, 126)
        Me.GridDeliv.StandardTab = True
        Me.GridDeliv.TabIndex = 18
        '
        'View
        '
        Me.View.AllowUserToAddRows = False
        Me.View.AllowUserToDeleteRows = False
        Me.View.AllowUserToOrderColumns = True
        Me.View.AllowUserToResizeRows = False
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.White
        Me.View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle23
        Me.View.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.View.BackgroundColor = System.Drawing.Color.White
        Me.View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.View.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.View.ColumnHeadersHeight = 35
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View.DefaultCellStyle = DataGridViewCellStyle24
        Me.View.Location = New System.Drawing.Point(12, 34)
        Me.View.MultiSelect = False
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.View.RowHeadersVisible = False
        Me.View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View.ShowEditingIcon = False
        Me.View.Size = New System.Drawing.Size(787, 181)
        Me.View.StandardTab = True
        Me.View.TabIndex = 16
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 28)
        Me.ToolStripLabel1.Text = "Cari Data :"
        '
        'txtCari
        '
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(100, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'FrmMonitoringSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 397)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.TabDetail)
        Me.Controls.Add(Me.Toolbar)
        Me.Name = "FrmMonitoringSO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMonitoringSO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.TabDetail.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        CType(Me.GridOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab2.ResumeLayout(False)
        CType(Me.GridWO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab4.ResumeLayout(False)
        Me.TabSubDetail.ResumeLayout(False)
        Me.SubDetail1.ResumeLayout(False)
        CType(Me.GridStockProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubDetail2.ResumeLayout(False)
        CType(Me.GridStockWHS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab5.ResumeLayout(False)
        CType(Me.GridDeliv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbStatus As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabDetail As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents Tab4 As System.Windows.Forms.TabPage
    Friend WithEvents Tab5 As System.Windows.Forms.TabPage
    Friend WithEvents TabSubDetail As System.Windows.Forms.TabControl
    Friend WithEvents SubDetail1 As System.Windows.Forms.TabPage
    Friend WithEvents SubDetail2 As System.Windows.Forms.TabPage
    Private WithEvents View As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents GridOP As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents GridWO As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents GridStockProd As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents GridStockWHS As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents GridDeliv As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCari As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
