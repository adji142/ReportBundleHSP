<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTempPengeluaranBenang
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTempPengeluaranBenang))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKodeShift = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.txtItemProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQtySisa = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTglPermintaan = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoPermintaan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtQtyRealisasi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtyPermintaan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTglPengeluaran = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.GridValid = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.btLookupKodeProduksi = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalQty = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.GridInvalid = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.KodeInvalid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemInvalid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountValid = New System.Windows.Forms.Label()
        Me.CountInvalid = New System.Windows.Forms.Label()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridValid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvalid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblShift)
        Me.Panel1.Controls.Add(Me.txtItemProduksi)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtQtySisa)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtTglPermintaan)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNoPermintaan)
        Me.Panel1.Controls.Add(Me.txtQtyRealisasi)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtQtyPermintaan)
        Me.Panel1.Controls.Add(Me.cboKodeGrup)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboKodeUnit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTglPengeluaran)
        Me.Panel1.Controls.Add(Me.Locked)
        Me.Panel1.Controls.Add(Me.txtNoTransaksi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 145)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtKodeShift)
        Me.Panel2.Location = New System.Drawing.Point(384, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 48)
        Me.Panel2.TabIndex = 124
        '
        'txtKodeShift
        '
        Me.txtKodeShift.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeShift.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKodeShift.Location = New System.Drawing.Point(5, -6)
        Me.txtKodeShift.Name = "txtKodeShift"
        Me.txtKodeShift.Size = New System.Drawing.Size(74, 46)
        Me.txtKodeShift.TabIndex = 122
        Me.txtKodeShift.Text = "3"
        Me.txtKodeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblShift.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblShift.Location = New System.Drawing.Point(384, 19)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(82, 20)
        Me.lblShift.TabIndex = 123
        Me.lblShift.Text = " SHIFT"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemProduksi
        '
        Me.txtItemProduksi.AllowEnterToMoveNext = True
        Me.txtItemProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItemProduksi.Location = New System.Drawing.Point(115, 101)
        Me.txtItemProduksi.Name = "txtItemProduksi"
        Me.txtItemProduksi.ReadOnly = True
        Me.txtItemProduksi.Size = New System.Drawing.Size(351, 26)
        Me.txtItemProduksi.TabIndex = 121
        Me.txtItemProduksi.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "Item Produksi"
        '
        'txtQtySisa
        '
        Me.txtQtySisa.AllowEnterToMoveNext = True
        Me.txtQtySisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtySisa.CheckIsValid = False
        Me.txtQtySisa.DataFormat = "###,##0.00"
        Me.txtQtySisa.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtySisa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtySisa.Location = New System.Drawing.Point(632, 101)
        Me.txtQtySisa.Name = "txtQtySisa"
        Me.txtQtySisa.ReadOnly = True
        Me.txtQtySisa.Size = New System.Drawing.Size(117, 26)
        Me.txtQtySisa.TabIndex = 8
        Me.txtQtySisa.TabStop = False
        Me.txtQtySisa.Text = "0.00"
        Me.txtQtySisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtySisa.Value = 0.0R
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(507, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Qty Sisa"
        '
        'txtTglPermintaan
        '
        Me.txtTglPermintaan.AllowEnterToMoveNext = True
        Me.txtTglPermintaan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPermintaan.Enabled = False
        Me.txtTglPermintaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPermintaan.Location = New System.Drawing.Point(844, 19)
        Me.txtTglPermintaan.Name = "txtTglPermintaan"
        Me.txtTglPermintaan.Size = New System.Drawing.Size(111, 20)
        Me.txtTglPermintaan.TabIndex = 4
        Me.txtTglPermintaan.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(755, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Tgl Permintaan"
        '
        'txtNoPermintaan
        '
        Me.txtNoPermintaan.AllowEnterToMoveNext = True
        Me.txtNoPermintaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoPermintaan.Location = New System.Drawing.Point(632, 19)
        Me.txtNoPermintaan.Name = "txtNoPermintaan"
        Me.txtNoPermintaan.ReadOnly = True
        Me.txtNoPermintaan.Size = New System.Drawing.Size(117, 20)
        Me.txtNoPermintaan.TabIndex = 3
        Me.txtNoPermintaan.TabStop = False
        '
        'txtQtyRealisasi
        '
        Me.txtQtyRealisasi.AllowEnterToMoveNext = True
        Me.txtQtyRealisasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyRealisasi.CheckIsValid = False
        Me.txtQtyRealisasi.DataFormat = "###,##0.00"
        Me.txtQtyRealisasi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyRealisasi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyRealisasi.Location = New System.Drawing.Point(844, 70)
        Me.txtQtyRealisasi.Name = "txtQtyRealisasi"
        Me.txtQtyRealisasi.ReadOnly = True
        Me.txtQtyRealisasi.Size = New System.Drawing.Size(111, 26)
        Me.txtQtyRealisasi.TabIndex = 7
        Me.txtQtyRealisasi.TabStop = False
        Me.txtQtyRealisasi.Text = "0.00"
        Me.txtQtyRealisasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyRealisasi.Value = 0.0R
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(758, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Qty Realisasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Qty Permintaan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(507, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Nomor Permintaan"
        '
        'txtQtyPermintaan
        '
        Me.txtQtyPermintaan.AllowEnterToMoveNext = True
        Me.txtQtyPermintaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyPermintaan.CheckIsValid = False
        Me.txtQtyPermintaan.DataFormat = "###,##0.00"
        Me.txtQtyPermintaan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPermintaan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyPermintaan.Location = New System.Drawing.Point(632, 70)
        Me.txtQtyPermintaan.Name = "txtQtyPermintaan"
        Me.txtQtyPermintaan.ReadOnly = True
        Me.txtQtyPermintaan.Size = New System.Drawing.Size(117, 26)
        Me.txtQtyPermintaan.TabIndex = 6
        Me.txtQtyPermintaan.TabStop = False
        Me.txtQtyPermintaan.Text = "0.00"
        Me.txtQtyPermintaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPermintaan.Value = 0.0R
        '
        'cboKodeGrup
        '
        Me.cboKodeGrup.AllowEnterToMoveNext = True
        Me.cboKodeGrup.DataLocked = False
        Me.cboKodeGrup.FormattingEnabled = True
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(115, 69)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(116, 21)
        Me.cboKodeGrup.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Grup Produksi"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeUnit.Enabled = False
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(632, 44)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(323, 21)
        Me.cboKodeUnit.TabIndex = 5
        Me.cboKodeUnit.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(507, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Unit Produksi Tujuan"
        '
        'txtTglPengeluaran
        '
        Me.txtTglPengeluaran.AllowEnterToMoveNext = True
        Me.txtTglPengeluaran.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPengeluaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPengeluaran.Location = New System.Drawing.Point(115, 44)
        Me.txtTglPengeluaran.Name = "txtTglPengeluaran"
        Me.txtTglPengeluaran.Size = New System.Drawing.Size(116, 20)
        Me.txtTglPengeluaran.TabIndex = 1
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(234, 20)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 105
        Me.Locked.TabStop = False
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(115, 19)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(116, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Tgl Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Nomor Transaksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Kode Produksi"
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProduksi.Location = New System.Drawing.Point(116, 166)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(296, 26)
        Me.txtKodeProduksi.TabIndex = 1
        '
        'GridValid
        '
        Me.GridValid.AllowUserToAddRows = False
        Me.GridValid.AllowUserToDeleteRows = False
        Me.GridValid.AllowUserToResizeColumns = False
        Me.GridValid.AllowUserToResizeRows = False
        Me.GridValid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridValid.BackgroundColor = System.Drawing.Color.White
        Me.GridValid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridValid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridValid.ColumnHeadersHeight = 30
        Me.GridValid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridValid.DefaultCellStyle = DataGridViewCellStyle7
        Me.GridValid.Location = New System.Drawing.Point(20, 198)
        Me.GridValid.Name = "GridValid"
        Me.GridValid.ReadOnly = True
        Me.GridValid.RowHeadersVisible = False
        Me.GridValid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridValid.Size = New System.Drawing.Size(625, 227)
        Me.GridValid.TabIndex = 2
        '
        'btLookupKodeProduksi
        '
        Me.btLookupKodeProduksi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksi.Location = New System.Drawing.Point(413, 166)
        Me.btLookupKodeProduksi.Name = "btLookupKodeProduksi"
        Me.btLookupKodeProduksi.Size = New System.Drawing.Size(54, 26)
        Me.btLookupKodeProduksi.TabIndex = 123
        Me.btLookupKodeProduksi.Text = "Daftar"
        Me.btLookupKodeProduksi.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 474)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(978, 54)
        Me.Panel6.TabIndex = 4
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(978, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(785, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(874, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(484, 436)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Total"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.AllowEnterToMoveNext = True
        Me.txtTotalQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalQty.CheckIsValid = False
        Me.txtTotalQty.DataFormat = "###,##0.000"
        Me.txtTotalQty.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalQty.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQty.Location = New System.Drawing.Point(521, 428)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(102, 26)
        Me.txtTotalQty.TabIndex = 3
        Me.txtTotalQty.Text = "0.00"
        Me.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalQty.Value = 0.0R
        '
        'GridInvalid
        '
        Me.GridInvalid.AllowUserToAddRows = False
        Me.GridInvalid.AllowUserToDeleteRows = False
        Me.GridInvalid.AllowUserToResizeColumns = False
        Me.GridInvalid.AllowUserToResizeRows = False
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        Me.GridInvalid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.GridInvalid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridInvalid.BackgroundColor = System.Drawing.Color.White
        Me.GridInvalid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridInvalid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridInvalid.ColumnHeadersHeight = 30
        Me.GridInvalid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridInvalid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeInvalid, Me.ItemInvalid})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridInvalid.DefaultCellStyle = DataGridViewCellStyle10
        Me.GridInvalid.Location = New System.Drawing.Point(651, 198)
        Me.GridInvalid.Name = "GridInvalid"
        Me.GridInvalid.ReadOnly = True
        Me.GridInvalid.RowHeadersVisible = False
        Me.GridInvalid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridInvalid.Size = New System.Drawing.Size(305, 227)
        Me.GridInvalid.TabIndex = 126
        '
        'KodeInvalid
        '
        Me.KodeInvalid.HeaderText = "Kode Produksi"
        Me.KodeInvalid.Name = "KodeInvalid"
        Me.KodeInvalid.ReadOnly = True
        Me.KodeInvalid.Width = 125
        '
        'ItemInvalid
        '
        Me.ItemInvalid.HeaderText = "Nama Item"
        Me.ItemInvalid.Name = "ItemInvalid"
        Me.ItemInvalid.ReadOnly = True
        Me.ItemInvalid.Width = 155
        '
        'CountValid
        '
        Me.CountValid.AutoSize = True
        Me.CountValid.Location = New System.Drawing.Point(17, 428)
        Me.CountValid.Name = "CountValid"
        Me.CountValid.Size = New System.Drawing.Size(27, 13)
        Me.CountValid.TabIndex = 127
        Me.CountValid.Text = "Item"
        '
        'CountInvalid
        '
        Me.CountInvalid.AutoSize = True
        Me.CountInvalid.Location = New System.Drawing.Point(648, 428)
        Me.CountInvalid.Name = "CountInvalid"
        Me.CountInvalid.Size = New System.Drawing.Size(27, 13)
        Me.CountInvalid.TabIndex = 128
        Me.CountInvalid.Text = "Item"
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'frmTempPengeluaranBenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 528)
        Me.Controls.Add(Me.CountInvalid)
        Me.Controls.Add(Me.CountValid)
        Me.Controls.Add(Me.GridInvalid)
        Me.Controls.Add(Me.txtTotalQty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btLookupKodeProduksi)
        Me.Controls.Add(Me.GridValid)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTempPengeluaranBenang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temp Pengeluaran Benang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridValid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvalid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtQtySisa As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTglPermintaan As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoPermintaan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtQtyRealisasi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQtyPermintaan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTglPengeluaran As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents GridValid As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents btLookupKodeProduksi As System.Windows.Forms.Button
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalQty As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents GridInvalid As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents CountValid As System.Windows.Forms.Label
    Friend WithEvents CountInvalid As System.Windows.Forms.Label
    Friend WithEvents txtItemProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents txtKodeShift As System.Windows.Forms.Label
    Friend WithEvents KodeInvalid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemInvalid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblShift As System.Windows.Forms.Label
End Class
