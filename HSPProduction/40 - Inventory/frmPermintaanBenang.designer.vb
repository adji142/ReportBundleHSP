<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermintaanBenang
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermintaanBenang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.txtTglPermintaan = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btLookupKodeItem = New System.Windows.Forms.Button()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJumlahPermintaan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalProyeksi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalKebutuhan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtyPS1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyAS1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtQtyAS2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyPS2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtQtyAS3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyPS3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtQtyPTotal = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.lblDaftarWorkOrder = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtQtyRS3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyRS2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyRS1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btSettingKodeUnit = New System.Windows.Forms.Button()
        Me.btDaftarWorkOrder = New System.Windows.Forms.Button()
        Me.View = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.txtTotalPersen = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(111, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl. Transaksi"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 495)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(590, 54)
        Me.Panel6.TabIndex = 22
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(590, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(397, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(486, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(113, 89)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(129, 20)
        Me.txtNoTransaksi.TabIndex = 1
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(281, 86)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(98, 20)
        Me.txtTglTransaksi.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Unit Produksi"
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'txtTglPermintaan
        '
        Me.txtTglPermintaan.AllowEnterToMoveNext = True
        Me.txtTglPermintaan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPermintaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPermintaan.Location = New System.Drawing.Point(397, 86)
        Me.txtTglPermintaan.Name = "txtTglPermintaan"
        Me.txtTglPermintaan.Size = New System.Drawing.Size(98, 20)
        Me.txtTglPermintaan.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "Tgl. Permintaan"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Location = New System.Drawing.Point(242, 116)
        Me.txtNamaItem.MaxLength = 50
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.Size = New System.Drawing.Size(327, 20)
        Me.txtNamaItem.TabIndex = 5
        Me.txtNamaItem.TabStop = False
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeItem.Location = New System.Drawing.Point(113, 116)
        Me.txtKodeItem.MaxLength = 15
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(102, 20)
        Me.txtKodeItem.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Kode Item Benang"
        '
        'btLookupKodeItem
        '
        Me.btLookupKodeItem.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeItem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeItem.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeItem.Location = New System.Drawing.Point(217, 115)
        Me.btLookupKodeItem.Name = "btLookupKodeItem"
        Me.btLookupKodeItem.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeItem.TabIndex = 114
        Me.btLookupKodeItem.TabStop = False
        Me.btLookupKodeItem.Text = ".."
        Me.btLookupKodeItem.UseVisualStyleBackColor = False
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(113, 21)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(430, 21)
        Me.cboKodeUnit.TabIndex = 0
        Me.cboKodeUnit.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Jumlah Permintaan"
        '
        'txtJumlahPermintaan
        '
        Me.txtJumlahPermintaan.AllowEnterToMoveNext = True
        Me.txtJumlahPermintaan.CheckIsValid = False
        Me.txtJumlahPermintaan.DataFormat = "###,##0"
        Me.txtJumlahPermintaan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtInteger
        Me.txtJumlahPermintaan.Location = New System.Drawing.Point(113, 358)
        Me.txtJumlahPermintaan.Name = "txtJumlahPermintaan"
        Me.txtJumlahPermintaan.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlahPermintaan.TabIndex = 7
        Me.txtJumlahPermintaan.Text = "0.00"
        Me.txtJumlahPermintaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahPermintaan.Value = 0.0R
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "KG"
        '
        'groupBox2
        '
        Me.groupBox2.Location = New System.Drawing.Point(0, 48)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(1190, 10)
        Me.groupBox2.TabIndex = 119
        Me.groupBox2.TabStop = False
        '
        'txtTotalProyeksi
        '
        Me.txtTotalProyeksi.AllowEnterToMoveNext = True
        Me.txtTotalProyeksi.BackColor = System.Drawing.Color.White
        Me.txtTotalProyeksi.CheckIsValid = False
        Me.txtTotalProyeksi.DataFormat = "###,##0.00"
        Me.txtTotalProyeksi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalProyeksi.Location = New System.Drawing.Point(237, 326)
        Me.txtTotalProyeksi.Name = "txtTotalProyeksi"
        Me.txtTotalProyeksi.Size = New System.Drawing.Size(106, 20)
        Me.txtTotalProyeksi.TabIndex = 124
        Me.txtTotalProyeksi.TabStop = False
        Me.txtTotalProyeksi.Text = "0.00"
        Me.txtTotalProyeksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalProyeksi.Value = 0.0R
        '
        'txtTotalKebutuhan
        '
        Me.txtTotalKebutuhan.AllowEnterToMoveNext = True
        Me.txtTotalKebutuhan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalKebutuhan.CheckIsValid = False
        Me.txtTotalKebutuhan.DataFormat = "###,##0.00"
        Me.txtTotalKebutuhan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalKebutuhan.Location = New System.Drawing.Point(452, 326)
        Me.txtTotalKebutuhan.Name = "txtTotalKebutuhan"
        Me.txtTotalKebutuhan.Size = New System.Drawing.Size(117, 20)
        Me.txtTotalKebutuhan.TabIndex = 125
        Me.txtTotalKebutuhan.TabStop = False
        Me.txtTotalKebutuhan.Text = "0.00"
        Me.txtTotalKebutuhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalKebutuhan.Value = 0.0R
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Alokasi Kebutuhan "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(3, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(602, 36)
        Me.Label7.TabIndex = 127
        '
        'txtQtyPS1
        '
        Me.txtQtyPS1.AllowEnterToMoveNext = True
        Me.txtQtyPS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtQtyPS1.CheckIsValid = False
        Me.txtQtyPS1.DataFormat = "###,##0.00"
        Me.txtQtyPS1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPS1.Location = New System.Drawing.Point(114, 430)
        Me.txtQtyPS1.Name = "txtQtyPS1"
        Me.txtQtyPS1.ReadOnly = True
        Me.txtQtyPS1.Size = New System.Drawing.Size(49, 20)
        Me.txtQtyPS1.TabIndex = 9
        Me.txtQtyPS1.TabStop = False
        Me.txtQtyPS1.Text = "0.00"
        Me.txtQtyPS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPS1.Value = 0.0R
        '
        'txtQtyAS1
        '
        Me.txtQtyAS1.AllowEnterToMoveNext = True
        Me.txtQtyAS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyAS1.CheckIsValid = False
        Me.txtQtyAS1.DataFormat = "###,##0.00"
        Me.txtQtyAS1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyAS1.Location = New System.Drawing.Point(165, 430)
        Me.txtQtyAS1.Name = "txtQtyAS1"
        Me.txtQtyAS1.ReadOnly = True
        Me.txtQtyAS1.Size = New System.Drawing.Size(78, 20)
        Me.txtQtyAS1.TabIndex = 10
        Me.txtQtyAS1.TabStop = False
        Me.txtQtyAS1.Text = "0.00"
        Me.txtQtyAS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyAS1.Value = 0.0R
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(113, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 18)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "SHIFT 1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(113, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(166, 409)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Alokasi"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(302, 409)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Alokasi"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(249, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 18)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "%"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(249, 391)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 18)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "SHIFT 2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtyAS2
        '
        Me.txtQtyAS2.AllowEnterToMoveNext = True
        Me.txtQtyAS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyAS2.CheckIsValid = False
        Me.txtQtyAS2.DataFormat = "###,##0.00"
        Me.txtQtyAS2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyAS2.Location = New System.Drawing.Point(301, 430)
        Me.txtQtyAS2.Name = "txtQtyAS2"
        Me.txtQtyAS2.ReadOnly = True
        Me.txtQtyAS2.Size = New System.Drawing.Size(78, 20)
        Me.txtQtyAS2.TabIndex = 12
        Me.txtQtyAS2.TabStop = False
        Me.txtQtyAS2.Text = "0.00"
        Me.txtQtyAS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyAS2.Value = 0.0R
        '
        'txtQtyPS2
        '
        Me.txtQtyPS2.AllowEnterToMoveNext = True
        Me.txtQtyPS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtQtyPS2.CheckIsValid = False
        Me.txtQtyPS2.DataFormat = "###,##0.00"
        Me.txtQtyPS2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPS2.Location = New System.Drawing.Point(250, 430)
        Me.txtQtyPS2.Name = "txtQtyPS2"
        Me.txtQtyPS2.ReadOnly = True
        Me.txtQtyPS2.Size = New System.Drawing.Size(49, 20)
        Me.txtQtyPS2.TabIndex = 11
        Me.txtQtyPS2.TabStop = False
        Me.txtQtyPS2.Text = "0.00"
        Me.txtQtyPS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPS2.Value = 0.0R
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(438, 409)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 18)
        Me.Label16.TabIndex = 147
        Me.Label16.Text = "Alokasi"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(385, 409)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 18)
        Me.Label17.TabIndex = 146
        Me.Label17.Text = "%"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(385, 391)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 18)
        Me.Label18.TabIndex = 145
        Me.Label18.Text = "SHIFT 3"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtyAS3
        '
        Me.txtQtyAS3.AllowEnterToMoveNext = True
        Me.txtQtyAS3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyAS3.CheckIsValid = False
        Me.txtQtyAS3.DataFormat = "###,##0.00"
        Me.txtQtyAS3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyAS3.Location = New System.Drawing.Point(437, 430)
        Me.txtQtyAS3.Name = "txtQtyAS3"
        Me.txtQtyAS3.ReadOnly = True
        Me.txtQtyAS3.Size = New System.Drawing.Size(78, 20)
        Me.txtQtyAS3.TabIndex = 14
        Me.txtQtyAS3.TabStop = False
        Me.txtQtyAS3.Text = "0.00"
        Me.txtQtyAS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyAS3.Value = 0.0R
        '
        'txtQtyPS3
        '
        Me.txtQtyPS3.AllowEnterToMoveNext = True
        Me.txtQtyPS3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtQtyPS3.CheckIsValid = False
        Me.txtQtyPS3.DataFormat = "###,##0.00"
        Me.txtQtyPS3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPS3.Location = New System.Drawing.Point(386, 430)
        Me.txtQtyPS3.Name = "txtQtyPS3"
        Me.txtQtyPS3.ReadOnly = True
        Me.txtQtyPS3.Size = New System.Drawing.Size(49, 20)
        Me.txtQtyPS3.TabIndex = 13
        Me.txtQtyPS3.TabStop = False
        Me.txtQtyPS3.Text = "0.00"
        Me.txtQtyPS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPS3.Value = 0.0R
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(521, 391)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 36)
        Me.Label19.TabIndex = 148
        Me.Label19.Text = "%"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtyPTotal
        '
        Me.txtQtyPTotal.AllowEnterToMoveNext = True
        Me.txtQtyPTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtQtyPTotal.CheckIsValid = False
        Me.txtQtyPTotal.DataFormat = "###,##0.00"
        Me.txtQtyPTotal.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPTotal.Location = New System.Drawing.Point(521, 430)
        Me.txtQtyPTotal.Name = "txtQtyPTotal"
        Me.txtQtyPTotal.ReadOnly = True
        Me.txtQtyPTotal.Size = New System.Drawing.Size(49, 20)
        Me.txtQtyPTotal.TabIndex = 15
        Me.txtQtyPTotal.TabStop = False
        Me.txtQtyPTotal.Text = "0.00"
        Me.txtQtyPTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPTotal.Value = 0.0R
        '
        'lblDaftarWorkOrder
        '
        Me.lblDaftarWorkOrder.BackColor = System.Drawing.Color.Silver
        Me.lblDaftarWorkOrder.Location = New System.Drawing.Point(17, 142)
        Me.lblDaftarWorkOrder.Name = "lblDaftarWorkOrder"
        Me.lblDaftarWorkOrder.Size = New System.Drawing.Size(92, 181)
        Me.lblDaftarWorkOrder.TabIndex = 151
        Me.lblDaftarWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 457)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 152
        Me.Label22.Text = "Realisasi"
        '
        'txtQtyRS3
        '
        Me.txtQtyRS3.AllowEnterToMoveNext = True
        Me.txtQtyRS3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyRS3.CheckIsValid = False
        Me.txtQtyRS3.DataFormat = "###,##0.00"
        Me.txtQtyRS3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyRS3.Location = New System.Drawing.Point(437, 454)
        Me.txtQtyRS3.Name = "txtQtyRS3"
        Me.txtQtyRS3.ReadOnly = True
        Me.txtQtyRS3.Size = New System.Drawing.Size(78, 20)
        Me.txtQtyRS3.TabIndex = 20
        Me.txtQtyRS3.TabStop = False
        Me.txtQtyRS3.Text = "0.00"
        Me.txtQtyRS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyRS3.Value = 0.0R
        '
        'txtQtyRS2
        '
        Me.txtQtyRS2.AllowEnterToMoveNext = True
        Me.txtQtyRS2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyRS2.CheckIsValid = False
        Me.txtQtyRS2.DataFormat = "###,##0.00"
        Me.txtQtyRS2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyRS2.Location = New System.Drawing.Point(301, 454)
        Me.txtQtyRS2.Name = "txtQtyRS2"
        Me.txtQtyRS2.ReadOnly = True
        Me.txtQtyRS2.Size = New System.Drawing.Size(78, 20)
        Me.txtQtyRS2.TabIndex = 18
        Me.txtQtyRS2.TabStop = False
        Me.txtQtyRS2.Text = "0.00"
        Me.txtQtyRS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyRS2.Value = 0.0R
        '
        'txtQtyRS1
        '
        Me.txtQtyRS1.AllowEnterToMoveNext = True
        Me.txtQtyRS1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyRS1.CheckIsValid = False
        Me.txtQtyRS1.DataFormat = "###,##0.00"
        Me.txtQtyRS1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyRS1.Location = New System.Drawing.Point(165, 454)
        Me.txtQtyRS1.Name = "txtQtyRS1"
        Me.txtQtyRS1.ReadOnly = True
        Me.txtQtyRS1.Size = New System.Drawing.Size(78, 20)
        Me.txtQtyRS1.TabIndex = 16
        Me.txtQtyRS1.TabStop = False
        Me.txtQtyRS1.Text = "0.00"
        Me.txtQtyRS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyRS1.Value = 0.0R
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(117, 329)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 160
        Me.Label23.Text = "Total "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 92)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 161
        Me.Label24.Text = "Transaksi"
        '
        'btSettingKodeUnit
        '
        Me.btSettingKodeUnit.BackColor = System.Drawing.Color.Transparent
        Me.btSettingKodeUnit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSettingKodeUnit.ForeColor = System.Drawing.Color.Silver
        Me.btSettingKodeUnit.Location = New System.Drawing.Point(546, 21)
        Me.btSettingKodeUnit.Name = "btSettingKodeUnit"
        Me.btSettingKodeUnit.Size = New System.Drawing.Size(23, 21)
        Me.btSettingKodeUnit.TabIndex = 162
        Me.btSettingKodeUnit.TabStop = False
        Me.btSettingKodeUnit.Text = "<"
        Me.btSettingKodeUnit.UseVisualStyleBackColor = False
        '
        'btDaftarWorkOrder
        '
        Me.btDaftarWorkOrder.BackColor = System.Drawing.Color.Transparent
        Me.btDaftarWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btDaftarWorkOrder.ForeColor = System.Drawing.Color.Silver
        Me.btDaftarWorkOrder.Location = New System.Drawing.Point(26, 222)
        Me.btDaftarWorkOrder.Name = "btDaftarWorkOrder"
        Me.btDaftarWorkOrder.Size = New System.Drawing.Size(75, 21)
        Me.btDaftarWorkOrder.TabIndex = 5
        Me.btDaftarWorkOrder.TabStop = False
        Me.btDaftarWorkOrder.Text = "&Work Order"
        Me.btDaftarWorkOrder.UseVisualStyleBackColor = False
        '
        'View
        '
        Me.View.AllowUserToAddRows = False
        Me.View.AllowUserToDeleteRows = False
        Me.View.AllowUserToOrderColumns = True
        Me.View.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        Me.View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.View.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.View.BackgroundColor = System.Drawing.Color.White
        Me.View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.View.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.View.ColumnHeadersHeight = 35
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View.DefaultCellStyle = DataGridViewCellStyle16
        Me.View.Location = New System.Drawing.Point(113, 142)
        Me.View.MultiSelect = False
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.View.RowHeadersVisible = False
        Me.View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View.ShowEditingIcon = False
        Me.View.Size = New System.Drawing.Size(456, 181)
        Me.View.StandardTab = True
        Me.View.TabIndex = 6
        Me.View.TabStop = False
        '
        'txtTotalPersen
        '
        Me.txtTotalPersen.AllowEnterToMoveNext = True
        Me.txtTotalPersen.BackColor = System.Drawing.Color.White
        Me.txtTotalPersen.CheckIsValid = False
        Me.txtTotalPersen.DataFormat = "###,##0.00"
        Me.txtTotalPersen.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalPersen.Location = New System.Drawing.Point(349, 326)
        Me.txtTotalPersen.Name = "txtTotalPersen"
        Me.txtTotalPersen.Size = New System.Drawing.Size(97, 20)
        Me.txtTotalPersen.TabIndex = 163
        Me.txtTotalPersen.TabStop = False
        Me.txtTotalPersen.Text = "0.00"
        Me.txtTotalPersen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalPersen.Value = 0.0R
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(248, 89)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 120
        Me.Locked.TabStop = False
        '
        'frmPermintaanBenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 549)
        Me.Controls.Add(Me.txtTotalPersen)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.btDaftarWorkOrder)
        Me.Controls.Add(Me.btSettingKodeUnit)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtQtyRS3)
        Me.Controls.Add(Me.txtQtyRS2)
        Me.Controls.Add(Me.txtQtyRS1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblDaftarWorkOrder)
        Me.Controls.Add(Me.txtQtyPTotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtQtyAS3)
        Me.Controls.Add(Me.txtQtyPS3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtQtyAS2)
        Me.Controls.Add(Me.txtQtyPS2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtQtyAS1)
        Me.Controls.Add(Me.txtQtyPS1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalKebutuhan)
        Me.Controls.Add(Me.txtTotalProyeksi)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJumlahPermintaan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKodeUnit)
        Me.Controls.Add(Me.btLookupKodeItem)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTglPermintaan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPermintaanBenang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permintaan Benang"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents txtTglPermintaan As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeItem As System.Windows.Forms.Button
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahPermintaan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Friend WithEvents txtTotalProyeksi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalKebutuhan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQtyPS1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyAS1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtQtyAS2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyPS2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtQtyAS3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyPS3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtQtyPTotal As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents lblDaftarWorkOrder As System.Windows.Forms.Label
    Private WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtQtyRS3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyRS2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyRS1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btSettingKodeUnit As System.Windows.Forms.Button
    Friend WithEvents btDaftarWorkOrder As System.Windows.Forms.Button
    Private WithEvents View As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents txtTotalPersen As Enerzie.EPSBasicControls.EPSTextBoxNum
End Class
