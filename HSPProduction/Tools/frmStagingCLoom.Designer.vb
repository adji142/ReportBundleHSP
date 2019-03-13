<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStagingCLoom
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTanggal = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ViewStaging = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.DataConsole = New System.Windows.Forms.Label()
        Me.ViewConsole = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalConsole = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.DataStaging = New System.Windows.Forms.Label()
        Me.txtTotalStaging = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSelisih = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ViewStaging, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewConsole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal : "
        '
        'txtTanggal
        '
        Me.txtTanggal.AllowEnterToMoveNext = True
        Me.txtTanggal.CustomFormat = "dd/MM/yyyy"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(88, 18)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(97, 20)
        Me.txtTanggal.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewStaging
        '
        Me.ViewStaging.AllowUserToAddRows = False
        Me.ViewStaging.AllowUserToDeleteRows = False
        Me.ViewStaging.AllowUserToOrderColumns = True
        Me.ViewStaging.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.ViewStaging.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ViewStaging.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewStaging.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewStaging.BackgroundColor = System.Drawing.Color.White
        Me.ViewStaging.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewStaging.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewStaging.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewStaging.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewStaging.ColumnHeadersHeight = 35
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewStaging.DefaultCellStyle = DataGridViewCellStyle6
        Me.ViewStaging.Location = New System.Drawing.Point(493, 78)
        Me.ViewStaging.MultiSelect = False
        Me.ViewStaging.Name = "ViewStaging"
        Me.ViewStaging.ReadOnly = True
        Me.ViewStaging.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewStaging.RowHeadersVisible = False
        Me.ViewStaging.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewStaging.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewStaging.ShowEditingIcon = False
        Me.ViewStaging.Size = New System.Drawing.Size(451, 274)
        Me.ViewStaging.StandardTab = True
        Me.ViewStaging.TabIndex = 3
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 419)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(968, 54)
        Me.panel2.TabIndex = 83
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(968, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(861, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 9
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(772, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 8
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'DataConsole
        '
        Me.DataConsole.AutoSize = True
        Me.DataConsole.Location = New System.Drawing.Point(12, 362)
        Me.DataConsole.Name = "DataConsole"
        Me.DataConsole.Size = New System.Drawing.Size(68, 13)
        Me.DataConsole.TabIndex = 84
        Me.DataConsole.Text = "Jumlah WO :"
        '
        'ViewConsole
        '
        Me.ViewConsole.AllowUserToAddRows = False
        Me.ViewConsole.AllowUserToDeleteRows = False
        Me.ViewConsole.AllowUserToOrderColumns = True
        Me.ViewConsole.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.ViewConsole.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ViewConsole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewConsole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewConsole.BackgroundColor = System.Drawing.Color.White
        Me.ViewConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ViewConsole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewConsole.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewConsole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewConsole.ColumnHeadersHeight = 35
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewConsole.DefaultCellStyle = DataGridViewCellStyle8
        Me.ViewConsole.Location = New System.Drawing.Point(15, 78)
        Me.ViewConsole.MultiSelect = False
        Me.ViewConsole.Name = "ViewConsole"
        Me.ViewConsole.ReadOnly = True
        Me.ViewConsole.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewConsole.RowHeadersVisible = False
        Me.ViewConsole.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewConsole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewConsole.ShowEditingIcon = False
        Me.ViewConsole.Size = New System.Drawing.Size(462, 274)
        Me.ViewConsole.StandardTab = True
        Me.ViewConsole.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Total : "
        '
        'txtTotalConsole
        '
        Me.txtTotalConsole.AllowEnterToMoveNext = True
        Me.txtTotalConsole.BackColor = System.Drawing.Color.White
        Me.txtTotalConsole.CheckIsValid = False
        Me.txtTotalConsole.DataFormat = "###,##0.00"
        Me.txtTotalConsole.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalConsole.Location = New System.Drawing.Point(362, 359)
        Me.txtTotalConsole.Name = "txtTotalConsole"
        Me.txtTotalConsole.ReadOnly = True
        Me.txtTotalConsole.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalConsole.TabIndex = 88
        Me.txtTotalConsole.Text = "0.00"
        Me.txtTotalConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalConsole.Value = 0.0R
        '
        'DataStaging
        '
        Me.DataStaging.AutoSize = True
        Me.DataStaging.Location = New System.Drawing.Point(490, 362)
        Me.DataStaging.Name = "DataStaging"
        Me.DataStaging.Size = New System.Drawing.Size(68, 13)
        Me.DataStaging.TabIndex = 89
        Me.DataStaging.Text = "Jumlah WO :"
        '
        'txtTotalStaging
        '
        Me.txtTotalStaging.AllowEnterToMoveNext = True
        Me.txtTotalStaging.BackColor = System.Drawing.Color.White
        Me.txtTotalStaging.CheckIsValid = False
        Me.txtTotalStaging.DataFormat = "###,##0.00"
        Me.txtTotalStaging.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalStaging.Location = New System.Drawing.Point(829, 359)
        Me.txtTotalStaging.Name = "txtTotalStaging"
        Me.txtTotalStaging.ReadOnly = True
        Me.txtTotalStaging.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalStaging.TabIndex = 91
        Me.txtTotalStaging.Text = "0.00"
        Me.txtTotalStaging.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalStaging.Value = 0.0R
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(783, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Total : "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(462, 23)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "DATA CONSOLE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(493, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(451, 23)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "DATA STAGING"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSelisih
        '
        Me.txtSelisih.AllowEnterToMoveNext = True
        Me.txtSelisih.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSelisih.CheckIsValid = False
        Me.txtSelisih.DataFormat = "###,##0.00"
        Me.txtSelisih.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSelisih.Location = New System.Drawing.Point(362, 385)
        Me.txtSelisih.Name = "txtSelisih"
        Me.txtSelisih.ReadOnly = True
        Me.txtSelisih.Size = New System.Drawing.Size(100, 20)
        Me.txtSelisih.TabIndex = 95
        Me.txtSelisih.Text = "0.00"
        Me.txtSelisih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSelisih.Value = 0.0R
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Selisih : "
        '
        'frmStagingCLoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 473)
        Me.Controls.Add(Me.txtSelisih)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalStaging)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataStaging)
        Me.Controls.Add(Me.txtTotalConsole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ViewConsole)
        Me.Controls.Add(Me.DataConsole)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.ViewStaging)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStagingCLoom"
        Me.Text = "Compare Data Pemakaian Bahan Circular Loom"
        CType(Me.ViewStaging, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewConsole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents ViewStaging As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents DataConsole As System.Windows.Forms.Label
    Private WithEvents ViewConsole As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalConsole As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents DataStaging As System.Windows.Forms.Label
    Friend WithEvents txtTotalStaging As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSelisih As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
