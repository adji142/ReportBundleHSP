<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiCutting
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblKodeUnitProduksi = New System.Windows.Forms.Label()
        Me.lblKodeLokasiHasilProduksi = New System.Windows.Forms.Label()
        Me.lblKodeItemHasilProduksi = New System.Windows.Forms.Label()
        Me.lblNamaItemHasilProduksi = New System.Windows.Forms.Label()
        Me.lblTglTimbang = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblGrupProduksi = New System.Windows.Forms.Label()
        Me.lblJamTimbang = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.lblNamaShift = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblKodeShift = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboNomorSPK = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupNomorSPK = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHasilTotal = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKodeUnitPeruntukan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtHasilBS = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtHasilPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PortTimbangan = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrStabil = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkLokasiMesin = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotalSisaBahanPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btTimbangSisaBahan = New System.Windows.Forms.Button()
        Me.txtTotalSisaBahanTimbang = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalSisaBahanMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtHasilPotong = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTargetPotong = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btLookupKodeProduksiBahan = New System.Windows.Forms.Button()
        Me.lblJenisRoll = New System.Windows.Forms.Label()
        Me.txtPanjangPotong = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSisaBahanPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahanPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahanPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.btHabisBahan = New System.Windows.Forms.Button()
        Me.btSisaBahan = New System.Windows.Forms.Button()
        Me.lblNamaItemBahan = New System.Windows.Forms.Label()
        Me.txtSisaBahanMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahanMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahanMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.BAHAN = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblKodeUnitProduksi)
        Me.Panel1.Controls.Add(Me.lblKodeLokasiHasilProduksi)
        Me.Panel1.Controls.Add(Me.lblKodeItemHasilProduksi)
        Me.Panel1.Controls.Add(Me.lblNamaItemHasilProduksi)
        Me.Panel1.Controls.Add(Me.lblTglTimbang)
        Me.Panel1.Controls.Add(Me.lblTransaksi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 151)
        Me.Panel1.TabIndex = 0
        '
        'lblKodeUnitProduksi
        '
        Me.lblKodeUnitProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeUnitProduksi.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblKodeUnitProduksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblKodeUnitProduksi.Location = New System.Drawing.Point(592, 17)
        Me.lblKodeUnitProduksi.Name = "lblKodeUnitProduksi"
        Me.lblKodeUnitProduksi.Size = New System.Drawing.Size(439, 28)
        Me.lblKodeUnitProduksi.TabIndex = 96
        Me.lblKodeUnitProduksi.Text = "UNIT PRODUKSI"
        Me.lblKodeUnitProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKodeLokasiHasilProduksi
        '
        Me.lblKodeLokasiHasilProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeLokasiHasilProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeLokasiHasilProduksi.ForeColor = System.Drawing.Color.Red
        Me.lblKodeLokasiHasilProduksi.Location = New System.Drawing.Point(632, 47)
        Me.lblKodeLokasiHasilProduksi.Name = "lblKodeLokasiHasilProduksi"
        Me.lblKodeLokasiHasilProduksi.Size = New System.Drawing.Size(394, 23)
        Me.lblKodeLokasiHasilProduksi.TabIndex = 95
        Me.lblKodeLokasiHasilProduksi.Text = "LOKASI HASIL PRODUKSI"
        Me.lblKodeLokasiHasilProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKodeItemHasilProduksi
        '
        Me.lblKodeItemHasilProduksi.AutoSize = True
        Me.lblKodeItemHasilProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeItemHasilProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeItemHasilProduksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblKodeItemHasilProduksi.Location = New System.Drawing.Point(269, 91)
        Me.lblKodeItemHasilProduksi.Name = "lblKodeItemHasilProduksi"
        Me.lblKodeItemHasilProduksi.Size = New System.Drawing.Size(77, 23)
        Me.lblKodeItemHasilProduksi.TabIndex = 92
        Me.lblKodeItemHasilProduksi.Text = "300.0001"
        Me.lblKodeItemHasilProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaItemHasilProduksi
        '
        Me.lblNamaItemHasilProduksi.AutoSize = True
        Me.lblNamaItemHasilProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaItemHasilProduksi.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemHasilProduksi.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemHasilProduksi.Location = New System.Drawing.Point(268, 111)
        Me.lblNamaItemHasilProduksi.Name = "lblNamaItemHasilProduksi"
        Me.lblNamaItemHasilProduksi.Size = New System.Drawing.Size(111, 29)
        Me.lblNamaItemHasilProduksi.TabIndex = 91
        Me.lblNamaItemHasilProduksi.Text = "90 8x8 900"
        Me.lblNamaItemHasilProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTglTimbang
        '
        Me.lblTglTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTimbang.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTimbang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTglTimbang.Location = New System.Drawing.Point(271, 44)
        Me.lblTglTimbang.Name = "lblTglTimbang"
        Me.lblTglTimbang.Size = New System.Drawing.Size(429, 29)
        Me.lblTglTimbang.TabIndex = 85
        Me.lblTglTimbang.Text = "01 SEPTEMBER 2016"
        Me.lblTglTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTransaksi.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.ForeColor = System.Drawing.Color.Lime
        Me.lblTransaksi.Location = New System.Drawing.Point(267, 15)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(247, 32)
        Me.lblTransaksi.TabIndex = 84
        Me.lblTransaksi.Text = "DATA PRODUKSI "
        Me.lblTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblGrupProduksi)
        Me.Panel2.Controls.Add(Me.lblJamTimbang)
        Me.Panel2.Controls.Add(Me.lblTglTransaksi)
        Me.Panel2.Controls.Add(Me.lblNamaShift)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 151)
        Me.Panel2.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 31)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "SHIFT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(254, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(2, 149)
        Me.Label9.TabIndex = 87
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGrupProduksi
        '
        Me.lblGrupProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblGrupProduksi.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupProduksi.ForeColor = System.Drawing.Color.White
        Me.lblGrupProduksi.Location = New System.Drawing.Point(130, 16)
        Me.lblGrupProduksi.Name = "lblGrupProduksi"
        Me.lblGrupProduksi.Size = New System.Drawing.Size(106, 29)
        Me.lblGrupProduksi.TabIndex = 90
        Me.lblGrupProduksi.Text = "GRUP B"
        Me.lblGrupProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJamTimbang
        '
        Me.lblJamTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblJamTimbang.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamTimbang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblJamTimbang.Location = New System.Drawing.Point(143, 110)
        Me.lblJamTimbang.Name = "lblJamTimbang"
        Me.lblJamTimbang.Size = New System.Drawing.Size(92, 29)
        Me.lblJamTimbang.TabIndex = 86
        Me.lblJamTimbang.Text = "07:10:15"
        Me.lblJamTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTransaksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTransaksi.ForeColor = System.Drawing.Color.Lime
        Me.lblTglTransaksi.Location = New System.Drawing.Point(129, 87)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(106, 29)
        Me.lblTglTransaksi.TabIndex = 89
        Me.lblTglTransaksi.Text = "01-09-2016"
        Me.lblTglTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNamaShift
        '
        Me.lblNamaShift.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaShift.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaShift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNamaShift.Location = New System.Drawing.Point(129, 45)
        Me.lblNamaShift.Name = "lblNamaShift"
        Me.lblNamaShift.Size = New System.Drawing.Size(106, 29)
        Me.lblNamaShift.TabIndex = 87
        Me.lblNamaShift.Text = "MALAM"
        Me.lblNamaShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblKodeShift)
        Me.Panel5.Location = New System.Drawing.Point(11, 49)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(107, 90)
        Me.Panel5.TabIndex = 88
        '
        'lblKodeShift
        '
        Me.lblKodeShift.BackColor = System.Drawing.Color.Silver
        Me.lblKodeShift.Font = New System.Drawing.Font("Arial Black", 68.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeShift.ForeColor = System.Drawing.Color.Teal
        Me.lblKodeShift.Location = New System.Drawing.Point(20, -24)
        Me.lblKodeShift.Name = "lblKodeShift"
        Me.lblKodeShift.Size = New System.Drawing.Size(75, 104)
        Me.lblKodeShift.TabIndex = 87
        Me.lblKodeShift.Text = "3"
        Me.lblKodeShift.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(11, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(106, 28)
        Me.Panel4.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(-17, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1054, 1)
        Me.Label2.TabIndex = 80
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.pictureBox2)
        Me.Panel3.Controls.Add(Me.btSave)
        Me.Panel3.Controls.Add(Me.btClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 579)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1040, 54)
        Me.Panel3.TabIndex = 3
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1040, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(852, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(941, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        Me.tmrJam.Interval = 500
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkShiftSebelumnya)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboKodeMesin)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboKodeGrup)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(113, 52)
        Me.chkShiftSebelumnya.Name = "chkShiftSebelumnya"
        Me.chkShiftSebelumnya.Size = New System.Drawing.Size(129, 20)
        Me.chkShiftSebelumnya.TabIndex = 1
        Me.chkShiftSebelumnya.Text = "&Shift Sebelumnya"
        Me.chkShiftSebelumnya.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Mesin Produksi"
        '
        'cboKodeMesin
        '
        Me.cboKodeMesin.AllowEnterToMoveNext = True
        Me.cboKodeMesin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMesin.DataLocked = False
        Me.cboKodeMesin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMesin.DropDownHeight = 105
        Me.cboKodeMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMesin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeMesin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMesin.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMesin.IndexLocked = False
        Me.cboKodeMesin.IntegralHeight = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(113, 77)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(311, 26)
        Me.cboKodeMesin.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Grup Produksi"
        '
        'cboKodeGrup
        '
        Me.cboKodeGrup.AllowEnterToMoveNext = True
        Me.cboKodeGrup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeGrup.DataLocked = False
        Me.cboKodeGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeGrup.DropDownHeight = 105
        Me.cboKodeGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeGrup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeGrup.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeGrup.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.IntegralHeight = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(113, 21)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(311, 26)
        Me.cboKodeGrup.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "No.SPK / WO"
        '
        'cboNomorSPK
        '
        Me.cboNomorSPK.AllowEnterToMoveNext = True
        Me.cboNomorSPK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSPK.DataLocked = False
        Me.cboNomorSPK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorSPK.DropDownHeight = 105
        Me.cboNomorSPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorSPK.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorSPK.ForeColor = System.Drawing.Color.Red
        Me.cboNomorSPK.IndexLocked = False
        Me.cboNomorSPK.IntegralHeight = False
        Me.cboNomorSPK.Location = New System.Drawing.Point(112, 18)
        Me.cboNomorSPK.Name = "cboNomorSPK"
        Me.cboNomorSPK.Size = New System.Drawing.Size(278, 26)
        Me.cboNomorSPK.TabIndex = 0
        '
        'btLookupNomorSPK
        '
        Me.btLookupNomorSPK.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupNomorSPK.Location = New System.Drawing.Point(391, 17)
        Me.btLookupNomorSPK.Name = "btLookupNomorSPK"
        Me.btLookupNomorSPK.Size = New System.Drawing.Size(34, 28)
        Me.btLookupNomorSPK.TabIndex = 95
        Me.btLookupNomorSPK.TabStop = False
        Me.btLookupNomorSPK.Text = "..."
        Me.btLookupNomorSPK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtHasilTotal)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtKeterangan)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboKodeUnitPeruntukan)
        Me.GroupBox2.Controls.Add(Me.txtHasilBS)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtHasilPcs)
        Me.GroupBox2.Controls.Add(Me.btLookupNomorSPK)
        Me.GroupBox2.Controls.Add(Me.cboNomorSPK)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 228)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(314, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 21)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "TOTAL"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHasilTotal
        '
        Me.txtHasilTotal.AllowEnterToMoveNext = True
        Me.txtHasilTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilTotal.CheckIsValid = False
        Me.txtHasilTotal.DataFormat = "###,###"
        Me.txtHasilTotal.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtHasilTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtHasilTotal.Location = New System.Drawing.Point(314, 98)
        Me.txtHasilTotal.Name = "txtHasilTotal"
        Me.txtHasilTotal.ReadOnly = True
        Me.txtHasilTotal.Size = New System.Drawing.Size(111, 25)
        Me.txtHasilTotal.TabIndex = 3
        Me.txtHasilTotal.TabStop = False
        Me.txtHasilTotal.Text = "250"
        Me.txtHasilTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilTotal.Value = 250.0R
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(216, 78)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 21)
        Me.Label22.TabIndex = 133
        Me.Label22.Text = "HASIL BS"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(112, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 21)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "HASIL BAIK"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(112, 160)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(313, 25)
        Me.txtKeterangan.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 16)
        Me.Label19.TabIndex = 121
        Me.Label19.Text = "Keterangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Hasil Produksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Peruntukan"
        '
        'cboKodeUnitPeruntukan
        '
        Me.cboKodeUnitPeruntukan.AllowEnterToMoveNext = True
        Me.cboKodeUnitPeruntukan.BackColor = System.Drawing.Color.White
        Me.cboKodeUnitPeruntukan.DataLocked = False
        Me.cboKodeUnitPeruntukan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnitPeruntukan.DropDownHeight = 105
        Me.cboKodeUnitPeruntukan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnitPeruntukan.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeUnitPeruntukan.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeUnitPeruntukan.IndexLocked = False
        Me.cboKodeUnitPeruntukan.IntegralHeight = False
        Me.cboKodeUnitPeruntukan.Location = New System.Drawing.Point(112, 131)
        Me.cboKodeUnitPeruntukan.Name = "cboKodeUnitPeruntukan"
        Me.cboKodeUnitPeruntukan.Size = New System.Drawing.Size(313, 26)
        Me.cboKodeUnitPeruntukan.TabIndex = 4
        '
        'txtHasilBS
        '
        Me.txtHasilBS.AllowEnterToMoveNext = True
        Me.txtHasilBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilBS.CheckIsValid = False
        Me.txtHasilBS.DataFormat = "###,###"
        Me.txtHasilBS.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilBS.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtHasilBS.ForeColor = System.Drawing.Color.Red
        Me.txtHasilBS.Location = New System.Drawing.Point(216, 98)
        Me.txtHasilBS.Name = "txtHasilBS"
        Me.txtHasilBS.Size = New System.Drawing.Size(99, 25)
        Me.txtHasilBS.TabIndex = 2
        Me.txtHasilBS.Text = "250"
        Me.txtHasilBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilBS.Value = 250.0R
        '
        'txtHasilPcs
        '
        Me.txtHasilPcs.AllowEnterToMoveNext = True
        Me.txtHasilPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilPcs.CheckIsValid = False
        Me.txtHasilPcs.DataFormat = "###,###"
        Me.txtHasilPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilPcs.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtHasilPcs.ForeColor = System.Drawing.Color.Blue
        Me.txtHasilPcs.Location = New System.Drawing.Point(112, 98)
        Me.txtHasilPcs.Name = "txtHasilPcs"
        Me.txtHasilPcs.Size = New System.Drawing.Size(105, 25)
        Me.txtHasilPcs.TabIndex = 1
        Me.txtHasilPcs.Text = "3,000"
        Me.txtHasilPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilPcs.Value = 3000.0R
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 20)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "LEMBAR"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(475, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(549, 27)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "PEMAKAIAN ROLL"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Green
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(446, 27)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "DATA PRODUKSI"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Green
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(446, 27)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "HASIL PRODUKSI"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.chkLokasiMesin)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtTotalSisaBahanPcs)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.btTimbangSisaBahan)
        Me.GroupBox3.Controls.Add(Me.txtTotalSisaBahanTimbang)
        Me.GroupBox3.Controls.Add(Me.txtTotalSisaBahanMeter)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(475, 449)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 115)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'chkLokasiMesin
        '
        Me.chkLokasiMesin.AllowEnterToMoveNext = True
        Me.chkLokasiMesin.AutoSize = True
        Me.chkLokasiMesin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLokasiMesin.ForeColor = System.Drawing.Color.Red
        Me.chkLokasiMesin.Location = New System.Drawing.Point(377, 77)
        Me.chkLokasiMesin.Name = "chkLokasiMesin"
        Me.chkLokasiMesin.Size = New System.Drawing.Size(148, 17)
        Me.chkLokasiMesin.TabIndex = 155
        Me.chkLokasiMesin.Text = "Sisa Roll Berada Di Mesin"
        Me.chkLokasiMesin.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(232, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 16)
        Me.Label31.TabIndex = 154
        Me.Label31.Text = "PCS"
        '
        'txtTotalSisaBahanPcs
        '
        Me.txtTotalSisaBahanPcs.AllowEnterToMoveNext = True
        Me.txtTotalSisaBahanPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalSisaBahanPcs.CheckIsValid = False
        Me.txtTotalSisaBahanPcs.DataFormat = "###,##0"
        Me.txtTotalSisaBahanPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalSisaBahanPcs.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSisaBahanPcs.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalSisaBahanPcs.Location = New System.Drawing.Point(194, 46)
        Me.txtTotalSisaBahanPcs.Name = "txtTotalSisaBahanPcs"
        Me.txtTotalSisaBahanPcs.ReadOnly = True
        Me.txtTotalSisaBahanPcs.Size = New System.Drawing.Size(91, 25)
        Me.txtTotalSisaBahanPcs.TabIndex = 0
        Me.txtTotalSisaBahanPcs.TabStop = False
        Me.txtTotalSisaBahanPcs.Text = "1,500"
        Me.txtTotalSisaBahanPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalSisaBahanPcs.Value = 1500.0R
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(166, 16)
        Me.Label30.TabIndex = 152
        Me.Label30.Text = "Sisa Roll Bahan Cutting >>"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(396, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 16)
        Me.Label18.TabIndex = 124
        Me.Label18.Text = "KILOGRAM"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(321, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 16)
        Me.Label20.TabIndex = 123
        Me.Label20.Text = "METER"
        '
        'btTimbangSisaBahan
        '
        Me.btTimbangSisaBahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimbangSisaBahan.Location = New System.Drawing.Point(467, 45)
        Me.btTimbangSisaBahan.Name = "btTimbangSisaBahan"
        Me.btTimbangSisaBahan.Size = New System.Drawing.Size(75, 26)
        Me.btTimbangSisaBahan.TabIndex = 3
        Me.btTimbangSisaBahan.Text = "TIMBANG"
        Me.btTimbangSisaBahan.UseVisualStyleBackColor = True
        '
        'txtTotalSisaBahanTimbang
        '
        Me.txtTotalSisaBahanTimbang.AllowEnterToMoveNext = True
        Me.txtTotalSisaBahanTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalSisaBahanTimbang.CheckIsValid = False
        Me.txtTotalSisaBahanTimbang.DataFormat = "###,##0.00"
        Me.txtTotalSisaBahanTimbang.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalSisaBahanTimbang.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSisaBahanTimbang.ForeColor = System.Drawing.Color.Red
        Me.txtTotalSisaBahanTimbang.Location = New System.Drawing.Point(377, 46)
        Me.txtTotalSisaBahanTimbang.Name = "txtTotalSisaBahanTimbang"
        Me.txtTotalSisaBahanTimbang.ReadOnly = True
        Me.txtTotalSisaBahanTimbang.Size = New System.Drawing.Size(89, 25)
        Me.txtTotalSisaBahanTimbang.TabIndex = 2
        Me.txtTotalSisaBahanTimbang.TabStop = False
        Me.txtTotalSisaBahanTimbang.Text = "125.56"
        Me.txtTotalSisaBahanTimbang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalSisaBahanTimbang.Value = 125.56R
        '
        'txtTotalSisaBahanMeter
        '
        Me.txtTotalSisaBahanMeter.AllowEnterToMoveNext = True
        Me.txtTotalSisaBahanMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalSisaBahanMeter.CheckIsValid = False
        Me.txtTotalSisaBahanMeter.DataFormat = "###,##0"
        Me.txtTotalSisaBahanMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalSisaBahanMeter.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSisaBahanMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalSisaBahanMeter.Location = New System.Drawing.Point(290, 46)
        Me.txtTotalSisaBahanMeter.Name = "txtTotalSisaBahanMeter"
        Me.txtTotalSisaBahanMeter.ReadOnly = True
        Me.txtTotalSisaBahanMeter.Size = New System.Drawing.Size(84, 25)
        Me.txtTotalSisaBahanMeter.TabIndex = 1
        Me.txtTotalSisaBahanMeter.TabStop = False
        Me.txtTotalSisaBahanMeter.Text = "1,500"
        Me.txtTotalSisaBahanMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalSisaBahanMeter.Value = 1500.0R
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label25.Location = New System.Drawing.Point(0, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(549, 26)
        Me.Label25.TabIndex = 131
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Green
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(475, 434)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(549, 26)
        Me.Label21.TabIndex = 124
        Me.Label21.Text = "SISA ROLL BAHAN"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.lblStatus)
        Me.GroupBox4.Controls.Add(Me.txtHasilPotong)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txtTargetPotong)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan)
        Me.GroupBox4.Controls.Add(Me.lblJenisRoll)
        Me.GroupBox4.Controls.Add(Me.txtPanjangPotong)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahanPcs)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahanPcs)
        Me.GroupBox4.Controls.Add(Me.txtStockBahanPcs)
        Me.GroupBox4.Controls.Add(Me.btHabisBahan)
        Me.GroupBox4.Controls.Add(Me.btSisaBahan)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahanMeter)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahanMeter)
        Me.GroupBox4.Controls.Add(Me.txtStockBahanMeter)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan)
        Me.GroupBox4.Controls.Add(Me.BAHAN)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(475, 191)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 240)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(399, 193)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(137, 32)
        Me.lblStatus.TabIndex = 175
        Me.lblStatus.Text = "STATUS "
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHasilPotong
        '
        Me.txtHasilPotong.AllowEnterToMoveNext = True
        Me.txtHasilPotong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilPotong.CheckIsValid = False
        Me.txtHasilPotong.DataFormat = "###,##0"
        Me.txtHasilPotong.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilPotong.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasilPotong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtHasilPotong.Location = New System.Drawing.Point(275, 188)
        Me.txtHasilPotong.Name = "txtHasilPotong"
        Me.txtHasilPotong.ReadOnly = True
        Me.txtHasilPotong.Size = New System.Drawing.Size(124, 41)
        Me.txtHasilPotong.TabIndex = 174
        Me.txtHasilPotong.TabStop = False
        Me.txtHasilPotong.Text = "90"
        Me.txtHasilPotong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHasilPotong.Value = 90.0R
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(275, 162)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(124, 27)
        Me.Label33.TabIndex = 173
        Me.Label33.Text = "Hasil Potong"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTargetPotong
        '
        Me.txtTargetPotong.AllowEnterToMoveNext = True
        Me.txtTargetPotong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTargetPotong.CheckIsValid = False
        Me.txtTargetPotong.DataFormat = "###,##0"
        Me.txtTargetPotong.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTargetPotong.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTargetPotong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTargetPotong.Location = New System.Drawing.Point(140, 188)
        Me.txtTargetPotong.Name = "txtTargetPotong"
        Me.txtTargetPotong.ReadOnly = True
        Me.txtTargetPotong.Size = New System.Drawing.Size(129, 41)
        Me.txtTargetPotong.TabIndex = 172
        Me.txtTargetPotong.TabStop = False
        Me.txtTargetPotong.Text = "90"
        Me.txtTargetPotong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTargetPotong.Value = 90.0R
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Red
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(140, 162)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 27)
        Me.Label32.TabIndex = 171
        Me.Label32.Text = "Target Potong"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btLookupKodeProduksiBahan
        '
        Me.btLookupKodeProduksiBahan.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan.Location = New System.Drawing.Point(149, 98)
        Me.btLookupKodeProduksiBahan.Name = "btLookupKodeProduksiBahan"
        Me.btLookupKodeProduksiBahan.Size = New System.Drawing.Size(22, 25)
        Me.btLookupKodeProduksiBahan.TabIndex = 170
        Me.btLookupKodeProduksiBahan.TabStop = False
        Me.btLookupKodeProduksiBahan.Text = "..."
        Me.btLookupKodeProduksiBahan.UseVisualStyleBackColor = True
        Me.btLookupKodeProduksiBahan.Visible = False
        '
        'lblJenisRoll
        '
        Me.lblJenisRoll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisRoll.ForeColor = System.Drawing.Color.Red
        Me.lblJenisRoll.Location = New System.Drawing.Point(23, 140)
        Me.lblJenisRoll.Name = "lblJenisRoll"
        Me.lblJenisRoll.Size = New System.Drawing.Size(111, 16)
        Me.lblJenisRoll.TabIndex = 169
        Me.lblJenisRoll.Text = "ROLL PRINTING"
        Me.lblJenisRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPanjangPotong
        '
        Me.txtPanjangPotong.AllowEnterToMoveNext = True
        Me.txtPanjangPotong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPanjangPotong.CheckIsValid = False
        Me.txtPanjangPotong.DataFormat = "###,##0.0"
        Me.txtPanjangPotong.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPanjangPotong.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanjangPotong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPanjangPotong.Location = New System.Drawing.Point(26, 188)
        Me.txtPanjangPotong.Name = "txtPanjangPotong"
        Me.txtPanjangPotong.ReadOnly = True
        Me.txtPanjangPotong.Size = New System.Drawing.Size(108, 41)
        Me.txtPanjangPotong.TabIndex = 168
        Me.txtPanjangPotong.TabStop = False
        Me.txtPanjangPotong.Text = "90"
        Me.txtPanjangPotong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPanjangPotong.Value = 90.0R
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Teal
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(26, 162)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 27)
        Me.Label28.TabIndex = 167
        Me.Label28.Text = "Panjang Potong"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(174, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 18)
        Me.Label29.TabIndex = 166
        Me.Label29.Text = "KODE ITEM"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(495, 123)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 16)
        Me.Label27.TabIndex = 164
        Me.Label27.Text = "Pcs"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(495, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 16)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "Meter"
        '
        'txtSisaBahanPcs
        '
        Me.txtSisaBahanPcs.AllowEnterToMoveNext = True
        Me.txtSisaBahanPcs.BackColor = System.Drawing.Color.White
        Me.txtSisaBahanPcs.CheckIsValid = False
        Me.txtSisaBahanPcs.DataFormat = "###,##0"
        Me.txtSisaBahanPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahanPcs.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahanPcs.ForeColor = System.Drawing.Color.Red
        Me.txtSisaBahanPcs.Location = New System.Drawing.Point(429, 123)
        Me.txtSisaBahanPcs.Name = "txtSisaBahanPcs"
        Me.txtSisaBahanPcs.ReadOnly = True
        Me.txtSisaBahanPcs.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahanPcs.TabIndex = 7
        Me.txtSisaBahanPcs.TabStop = False
        Me.txtSisaBahanPcs.Text = "0"
        Me.txtSisaBahanPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahanPcs.Value = 0.0R
        '
        'txtPemakaianBahanPcs
        '
        Me.txtPemakaianBahanPcs.AllowEnterToMoveNext = True
        Me.txtPemakaianBahanPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahanPcs.CheckIsValid = False
        Me.txtPemakaianBahanPcs.DataFormat = "###,##0"
        Me.txtPemakaianBahanPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahanPcs.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahanPcs.ForeColor = System.Drawing.Color.Red
        Me.txtPemakaianBahanPcs.Location = New System.Drawing.Point(360, 123)
        Me.txtPemakaianBahanPcs.Name = "txtPemakaianBahanPcs"
        Me.txtPemakaianBahanPcs.ReadOnly = True
        Me.txtPemakaianBahanPcs.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahanPcs.TabIndex = 6
        Me.txtPemakaianBahanPcs.Text = "3,000"
        Me.txtPemakaianBahanPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahanPcs.Value = 3000.0R
        '
        'txtStockBahanPcs
        '
        Me.txtStockBahanPcs.AllowEnterToMoveNext = True
        Me.txtStockBahanPcs.BackColor = System.Drawing.Color.White
        Me.txtStockBahanPcs.CheckIsValid = False
        Me.txtStockBahanPcs.DataFormat = "###,##0"
        Me.txtStockBahanPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahanPcs.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahanPcs.ForeColor = System.Drawing.Color.Red
        Me.txtStockBahanPcs.Location = New System.Drawing.Point(291, 123)
        Me.txtStockBahanPcs.Name = "txtStockBahanPcs"
        Me.txtStockBahanPcs.ReadOnly = True
        Me.txtStockBahanPcs.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahanPcs.TabIndex = 5
        Me.txtStockBahanPcs.TabStop = False
        Me.txtStockBahanPcs.Text = "3,000"
        Me.txtStockBahanPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahanPcs.Value = 3000.0R
        '
        'btHabisBahan
        '
        Me.btHabisBahan.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHabisBahan.Location = New System.Drawing.Point(461, 145)
        Me.btHabisBahan.Name = "btHabisBahan"
        Me.btHabisBahan.Size = New System.Drawing.Size(32, 24)
        Me.btHabisBahan.TabIndex = 159
        Me.btHabisBahan.TabStop = False
        Me.btHabisBahan.Text = "H"
        Me.btHabisBahan.UseVisualStyleBackColor = True
        '
        'btSisaBahan
        '
        Me.btSisaBahan.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSisaBahan.Location = New System.Drawing.Point(429, 145)
        Me.btSisaBahan.Name = "btSisaBahan"
        Me.btSisaBahan.Size = New System.Drawing.Size(34, 24)
        Me.btSisaBahan.TabIndex = 157
        Me.btSisaBahan.TabStop = False
        Me.btSisaBahan.Text = "S"
        Me.btSisaBahan.UseVisualStyleBackColor = True
        '
        'lblNamaItemBahan
        '
        Me.lblNamaItemBahan.AutoSize = True
        Me.lblNamaItemBahan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan.Location = New System.Drawing.Point(23, 80)
        Me.lblNamaItemBahan.Name = "lblNamaItemBahan"
        Me.lblNamaItemBahan.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan.TabIndex = 152
        Me.lblNamaItemBahan.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'txtSisaBahanMeter
        '
        Me.txtSisaBahanMeter.AllowEnterToMoveNext = True
        Me.txtSisaBahanMeter.BackColor = System.Drawing.Color.White
        Me.txtSisaBahanMeter.CheckIsValid = False
        Me.txtSisaBahanMeter.DataFormat = "###,##0"
        Me.txtSisaBahanMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahanMeter.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahanMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtSisaBahanMeter.Location = New System.Drawing.Point(429, 99)
        Me.txtSisaBahanMeter.Name = "txtSisaBahanMeter"
        Me.txtSisaBahanMeter.ReadOnly = True
        Me.txtSisaBahanMeter.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahanMeter.TabIndex = 4
        Me.txtSisaBahanMeter.TabStop = False
        Me.txtSisaBahanMeter.Text = "0"
        Me.txtSisaBahanMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahanMeter.Value = 0.0R
        '
        'txtPemakaianBahanMeter
        '
        Me.txtPemakaianBahanMeter.AllowEnterToMoveNext = True
        Me.txtPemakaianBahanMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahanMeter.CheckIsValid = False
        Me.txtPemakaianBahanMeter.DataFormat = "###,##0"
        Me.txtPemakaianBahanMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahanMeter.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahanMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtPemakaianBahanMeter.Location = New System.Drawing.Point(360, 99)
        Me.txtPemakaianBahanMeter.Name = "txtPemakaianBahanMeter"
        Me.txtPemakaianBahanMeter.ReadOnly = True
        Me.txtPemakaianBahanMeter.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahanMeter.TabIndex = 3
        Me.txtPemakaianBahanMeter.Text = "3,000"
        Me.txtPemakaianBahanMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahanMeter.Value = 3000.0R
        '
        'txtStockBahanMeter
        '
        Me.txtStockBahanMeter.AllowEnterToMoveNext = True
        Me.txtStockBahanMeter.BackColor = System.Drawing.Color.White
        Me.txtStockBahanMeter.CheckIsValid = False
        Me.txtStockBahanMeter.DataFormat = "###,##0"
        Me.txtStockBahanMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahanMeter.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahanMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtStockBahanMeter.Location = New System.Drawing.Point(291, 99)
        Me.txtStockBahanMeter.Name = "txtStockBahanMeter"
        Me.txtStockBahanMeter.ReadOnly = True
        Me.txtStockBahanMeter.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahanMeter.TabIndex = 2
        Me.txtStockBahanMeter.TabStop = False
        Me.txtStockBahanMeter.Text = "3,000"
        Me.txtStockBahanMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahanMeter.Value = 3000.0R
        '
        'txtKodeItemBahan
        '
        Me.txtKodeItemBahan.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeItemBahan.Location = New System.Drawing.Point(177, 99)
        Me.txtKodeItemBahan.Name = "txtKodeItemBahan"
        Me.txtKodeItemBahan.ReadOnly = True
        Me.txtKodeItemBahan.Size = New System.Drawing.Size(108, 22)
        Me.txtKodeItemBahan.TabIndex = 1
        Me.txtKodeItemBahan.TabStop = False
        Me.txtKodeItemBahan.Text = "1234567890"
        '
        'txtKodeProduksiBahan
        '
        Me.txtKodeProduksiBahan.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProduksiBahan.Location = New System.Drawing.Point(26, 99)
        Me.txtKodeProduksiBahan.Name = "txtKodeProduksiBahan"
        Me.txtKodeProduksiBahan.Size = New System.Drawing.Size(122, 22)
        Me.txtKodeProduksiBahan.TabIndex = 0
        Me.txtKodeProduksiBahan.Text = "123456789012345"
        '
        'BAHAN
        '
        Me.BAHAN.BackColor = System.Drawing.Color.LightBlue
        Me.BAHAN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAHAN.Location = New System.Drawing.Point(287, 27)
        Me.BAHAN.Name = "BAHAN"
        Me.BAHAN.Size = New System.Drawing.Size(255, 20)
        Me.BAHAN.TabIndex = 138
        Me.BAHAN.Text = "BAHAN"
        Me.BAHAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(459, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 14)
        Me.Label26.TabIndex = 137
        Me.Label26.Text = "SISA"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(358, 53)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 14)
        Me.Label24.TabIndex = 136
        Me.Label24.Text = "PEMAKAIAN"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(314, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 14)
        Me.Label23.TabIndex = 135
        Me.Label23.Text = "STOCK"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 18)
        Me.Label16.TabIndex = 133
        Me.Label16.Text = "KODE PRODUKSI"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Location = New System.Drawing.Point(-9, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(558, 51)
        Me.Label6.TabIndex = 132
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProduksiCutting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 633)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduksiCutting"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi | Cutting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents lblJamTimbang As System.Windows.Forms.Label
    Private WithEvents lblTglTimbang As System.Windows.Forms.Label
    Private WithEvents lblTransaksi As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents lblGrupProduksi As System.Windows.Forms.Label
    Private WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Private WithEvents lblNamaShift As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents lblKodeShift As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents lblNamaItemHasilProduksi As System.Windows.Forms.Label
    Private WithEvents btLookupNomorSPK As System.Windows.Forms.Button
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents cboNomorSPK As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents PortTimbangan As System.IO.Ports.SerialPort
    Friend WithEvents tmrStabil As System.Windows.Forms.Timer
    Friend WithEvents txtHasilBS As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtHasilPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboKodeUnitPeruntukan As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents lblKodeItemHasilProduksi As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents btTimbangSisaBahan As System.Windows.Forms.Button
    Friend WithEvents txtTotalSisaBahanTimbang As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalSisaBahanMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents lblKodeUnitProduksi As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents lblNamaItemBahan As System.Windows.Forms.Label
    Friend WithEvents txtSisaBahanMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahanMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahanMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents BAHAN As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lblKodeLokasiHasilProduksi As System.Windows.Forms.Label
    Private WithEvents Label30 As System.Windows.Forms.Label
    Private WithEvents btSisaBahan As System.Windows.Forms.Button
    Private WithEvents btHabisBahan As System.Windows.Forms.Button
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtHasilTotal As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtSisaBahanPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahanPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahanPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSisaBahanPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtPanjangPotong As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents lblJenisRoll As System.Windows.Forms.Label
    Private WithEvents btLookupKodeProduksiBahan As System.Windows.Forms.Button
    Friend WithEvents chkLokasiMesin As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents txtTargetPotong As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtHasilPotong As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents lblStatus As System.Windows.Forms.Label
End Class
