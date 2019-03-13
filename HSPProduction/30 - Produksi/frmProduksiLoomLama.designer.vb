<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiLoomLama
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
        Me.lblStatusTimbang = New System.Windows.Forms.Label()
        Me.lblItemProduksi = New System.Windows.Forms.Label()
        Me.lblKodeUnit = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.lblKodeLokasiProduksi = New System.Windows.Forms.Label()
        Me.lblJamTimbang = New System.Windows.Forms.Label()
        Me.lblTglTimbang = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTglTransaksi = New System.Windows.Forms.Label()
        Me.KeteranganShift = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtKodeShift = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStatusNetto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblStabil = New System.Windows.Forms.Label()
        Me.lblBeratNetto = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.lblBeratBrutto = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btLookupKodeMesin = New System.Windows.Forms.Button()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboNomorSpk = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupNomorSpk = New System.Windows.Forms.Button()
        Me.txtPanjangRoll = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.btLookupKodeMediaTimbang = New System.Windows.Forms.Button()
        Me.cboKodeMediaTimbang = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btLookupKodeUnitPeruntukan = New System.Windows.Forms.Button()
        Me.cboKodeUnitPeruntukan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btReprint = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.Porttimbangan = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrStabil = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtBeratMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btLookupKodeStatus = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBeratNetto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.cboKodeStatus = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboStatusQC = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tmrWarning = New System.Windows.Forms.Timer(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTimbangManual = New System.Windows.Forms.Label()
        Me.txtTimbangManual = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.chkManual = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblStatusTimbang)
        Me.Panel1.Controls.Add(Me.lblItemProduksi)
        Me.Panel1.Controls.Add(Me.lblKodeUnit)
        Me.Panel1.Controls.Add(Me.lblIndicator)
        Me.Panel1.Controls.Add(Me.lblConnectionStatus)
        Me.Panel1.Controls.Add(Me.lblKodeLokasiProduksi)
        Me.Panel1.Controls.Add(Me.lblJamTimbang)
        Me.Panel1.Controls.Add(Me.lblTglTimbang)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblStatusNetto)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.lblStabil)
        Me.Panel1.Controls.Add(Me.lblBeratNetto)
        Me.Panel1.Controls.Add(Me.lblTransaksi)
        Me.Panel1.Controls.Add(Me.lblBeratBrutto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 265)
        Me.Panel1.TabIndex = 1
        '
        'lblStatusTimbang
        '
        Me.lblStatusTimbang.AutoSize = True
        Me.lblStatusTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusTimbang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatusTimbang.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusTimbang.ForeColor = System.Drawing.Color.Lime
        Me.lblStatusTimbang.Location = New System.Drawing.Point(136, 221)
        Me.lblStatusTimbang.Name = "lblStatusTimbang"
        Me.lblStatusTimbang.Size = New System.Drawing.Size(174, 31)
        Me.lblStatusTimbang.TabIndex = 97
        Me.lblStatusTimbang.Text = "OVER / UNDER"
        Me.lblStatusTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemProduksi
        '
        Me.lblItemProduksi.AutoSize = True
        Me.lblItemProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblItemProduksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemProduksi.ForeColor = System.Drawing.Color.White
        Me.lblItemProduksi.Location = New System.Drawing.Point(138, 190)
        Me.lblItemProduksi.Name = "lblItemProduksi"
        Me.lblItemProduksi.Size = New System.Drawing.Size(190, 31)
        Me.lblItemProduksi.TabIndex = 96
        Me.lblItemProduksi.Text = "ITEM PRODUKSI"
        Me.lblItemProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKodeUnit
        '
        Me.lblKodeUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblKodeUnit.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeUnit.ForeColor = System.Drawing.Color.Lime
        Me.lblKodeUnit.Location = New System.Drawing.Point(140, 41)
        Me.lblKodeUnit.Name = "lblKodeUnit"
        Me.lblKodeUnit.Size = New System.Drawing.Size(429, 25)
        Me.lblKodeUnit.TabIndex = 95
        Me.lblKodeUnit.Text = "UNIT PRODUKSI"
        Me.lblKodeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndicator
        '
        Me.lblIndicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIndicator.BackColor = System.Drawing.Color.Transparent
        Me.lblIndicator.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicator.ForeColor = System.Drawing.Color.Yellow
        Me.lblIndicator.Location = New System.Drawing.Point(1204, 89)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(58, 41)
        Me.lblIndicator.TabIndex = 94
        Me.lblIndicator.Text = "<<"
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblConnectionStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblConnectionStatus.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionStatus.ForeColor = System.Drawing.Color.Blue
        Me.lblConnectionStatus.Location = New System.Drawing.Point(138, 123)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(356, 29)
        Me.lblConnectionStatus.TabIndex = 93
        Me.lblConnectionStatus.Text = "OFFLINE"
        Me.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKodeLokasiProduksi
        '
        Me.lblKodeLokasiProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeLokasiProduksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblKodeLokasiProduksi.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeLokasiProduksi.ForeColor = System.Drawing.Color.Red
        Me.lblKodeLokasiProduksi.Location = New System.Drawing.Point(138, 161)
        Me.lblKodeLokasiProduksi.Name = "lblKodeLokasiProduksi"
        Me.lblKodeLokasiProduksi.Size = New System.Drawing.Size(356, 29)
        Me.lblKodeLokasiProduksi.TabIndex = 92
        Me.lblKodeLokasiProduksi.Text = "LOKASI HASIL PRODUKSI"
        Me.lblKodeLokasiProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamTimbang
        '
        Me.lblJamTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblJamTimbang.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamTimbang.ForeColor = System.Drawing.Color.Silver
        Me.lblJamTimbang.Location = New System.Drawing.Point(139, 89)
        Me.lblJamTimbang.Name = "lblJamTimbang"
        Me.lblJamTimbang.Size = New System.Drawing.Size(92, 29)
        Me.lblJamTimbang.TabIndex = 86
        Me.lblJamTimbang.Text = "07:10:15"
        Me.lblJamTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTglTimbang
        '
        Me.lblTglTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTimbang.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTimbang.ForeColor = System.Drawing.Color.Silver
        Me.lblTglTimbang.Location = New System.Drawing.Point(139, 67)
        Me.lblTglTimbang.Name = "lblTglTimbang"
        Me.lblTglTimbang.Size = New System.Drawing.Size(429, 29)
        Me.lblTglTimbang.TabIndex = 85
        Me.lblTglTimbang.Text = "01 SEPTEMBER 2016"
        Me.lblTglTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtTglTransaksi)
        Me.Panel2.Controls.Add(Me.KeteranganShift)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 265)
        Me.Panel2.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(128, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1, 263)
        Me.Label9.TabIndex = 87
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.txtTglTransaksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglTransaksi.ForeColor = System.Drawing.Color.Lime
        Me.txtTglTransaksi.Location = New System.Drawing.Point(11, 190)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(106, 29)
        Me.txtTglTransaksi.TabIndex = 89
        Me.txtTglTransaksi.Text = "01-09-2016"
        Me.txtTglTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KeteranganShift
        '
        Me.KeteranganShift.BackColor = System.Drawing.Color.Transparent
        Me.KeteranganShift.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeteranganShift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KeteranganShift.Location = New System.Drawing.Point(11, 160)
        Me.KeteranganShift.Name = "KeteranganShift"
        Me.KeteranganShift.Size = New System.Drawing.Size(106, 29)
        Me.KeteranganShift.TabIndex = 87
        Me.KeteranganShift.Text = "MALAM"
        Me.KeteranganShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtKodeShift)
        Me.Panel5.Location = New System.Drawing.Point(11, 58)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(106, 98)
        Me.Panel5.TabIndex = 88
        '
        'txtKodeShift
        '
        Me.txtKodeShift.BackColor = System.Drawing.Color.Silver
        Me.txtKodeShift.Font = New System.Drawing.Font("Arial Black", 68.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeShift.ForeColor = System.Drawing.Color.Teal
        Me.txtKodeShift.Location = New System.Drawing.Point(3, -19)
        Me.txtKodeShift.Name = "txtKodeShift"
        Me.txtKodeShift.Size = New System.Drawing.Size(108, 113)
        Me.txtKodeShift.TabIndex = 87
        Me.txtKodeShift.Text = "3"
        Me.txtKodeShift.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(11, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(106, 37)
        Me.Panel4.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 31)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "SHIFT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatusNetto
        '
        Me.lblStatusNetto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusNetto.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusNetto.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusNetto.ForeColor = System.Drawing.Color.Silver
        Me.lblStatusNetto.Location = New System.Drawing.Point(1205, 202)
        Me.lblStatusNetto.Name = "lblStatusNetto"
        Me.lblStatusNetto.Size = New System.Drawing.Size(76, 41)
        Me.lblStatusNetto.TabIndex = 79
        Me.lblStatusNetto.Text = "NET"
        Me.lblStatusNetto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(1205, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 41)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "KG"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(-17, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1298, 1)
        Me.Label2.TabIndex = 80
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(1205, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 38)
        Me.label3.TabIndex = 77
        Me.label3.Text = "KG"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStabil
        '
        Me.lblStabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStabil.BackColor = System.Drawing.Color.Transparent
        Me.lblStabil.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStabil.ForeColor = System.Drawing.Color.Blue
        Me.lblStabil.Location = New System.Drawing.Point(1204, 48)
        Me.lblStabil.Name = "lblStabil"
        Me.lblStabil.Size = New System.Drawing.Size(68, 41)
        Me.lblStabil.TabIndex = 78
        Me.lblStabil.Text = "ST"
        Me.lblStabil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratNetto
        '
        Me.lblBeratNetto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratNetto.ForeColor = System.Drawing.Color.Silver
        Me.lblBeratNetto.Location = New System.Drawing.Point(151, 154)
        Me.lblBeratNetto.Name = "lblBeratNetto"
        Me.lblBeratNetto.Size = New System.Drawing.Size(1080, 98)
        Me.lblBeratNetto.TabIndex = 81
        Me.lblBeratNetto.Text = "0"
        Me.lblBeratNetto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTransaksi
        '
        Me.lblTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTransaksi.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblTransaksi.Location = New System.Drawing.Point(137, 10)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(338, 41)
        Me.lblTransaksi.TabIndex = 84
        Me.lblTransaksi.Text = "HASIL PRODUKSI ROLL"
        Me.lblTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratBrutto
        '
        Me.lblBeratBrutto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratBrutto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratBrutto.Font = New System.Drawing.Font("Arial Narrow", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratBrutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBeratBrutto.Location = New System.Drawing.Point(144, -2)
        Me.lblBeratBrutto.Name = "lblBeratBrutto"
        Me.lblBeratBrutto.Size = New System.Drawing.Size(1101, 159)
        Me.lblBeratBrutto.TabIndex = 76
        Me.lblBeratBrutto.Tag = ""
        Me.lblBeratBrutto.Text = "0"
        Me.lblBeratBrutto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lblTimbangManual)
        Me.Panel3.Controls.Add(Me.txtTimbangManual)
        Me.Panel3.Controls.Add(Me.chkManual)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.btLookupKodeMesin)
        Me.Panel3.Controls.Add(Me.cboKodeMesin)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.cboNomorSpk)
        Me.Panel3.Controls.Add(Me.btLookupNomorSpk)
        Me.Panel3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(12, 293)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 181)
        Me.Panel3.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 17)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "BA"
        Me.Label18.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 17)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "BS"
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "No SPK / WO"
        Me.Label15.Visible = False
        '
        'btLookupKodeMesin
        '
        Me.btLookupKodeMesin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeMesin.Location = New System.Drawing.Point(358, 20)
        Me.btLookupKodeMesin.Name = "btLookupKodeMesin"
        Me.btLookupKodeMesin.Size = New System.Drawing.Size(30, 26)
        Me.btLookupKodeMesin.TabIndex = 10
        Me.btLookupKodeMesin.TabStop = False
        Me.btLookupKodeMesin.Text = "..."
        Me.btLookupKodeMesin.UseVisualStyleBackColor = True
        '
        'cboKodeMesin
        '
        Me.cboKodeMesin.AllowEnterToMoveNext = True
        Me.cboKodeMesin.DataLocked = False
        Me.cboKodeMesin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMesin.DropDownHeight = 105
        Me.cboKodeMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMesin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMesin.FormattingEnabled = True
        Me.cboKodeMesin.IndexLocked = False
        Me.cboKodeMesin.IntegralHeight = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(129, 21)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(229, 25)
        Me.cboKodeMesin.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Mesin Produksi"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "No SPK / WO"
        '
        'cboNomorSpk
        '
        Me.cboNomorSpk.AllowEnterToMoveNext = True
        Me.cboNomorSpk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSpk.DataLocked = False
        Me.cboNomorSpk.DropDownHeight = 105
        Me.cboNomorSpk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorSpk.ForeColor = System.Drawing.Color.Red
        Me.cboNomorSpk.FormattingEnabled = True
        Me.cboNomorSpk.IndexLocked = False
        Me.cboNomorSpk.IntegralHeight = False
        Me.cboNomorSpk.Location = New System.Drawing.Point(129, 51)
        Me.cboNomorSpk.Name = "cboNomorSpk"
        Me.cboNomorSpk.Size = New System.Drawing.Size(229, 27)
        Me.cboNomorSpk.TabIndex = 2
        '
        'btLookupNomorSpk
        '
        Me.btLookupNomorSpk.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupNomorSpk.Location = New System.Drawing.Point(358, 51)
        Me.btLookupNomorSpk.Name = "btLookupNomorSpk"
        Me.btLookupNomorSpk.Size = New System.Drawing.Size(63, 27)
        Me.btLookupNomorSpk.TabIndex = 3
        Me.btLookupNomorSpk.TabStop = False
        Me.btLookupNomorSpk.Text = "DAFTAR"
        Me.btLookupNomorSpk.UseVisualStyleBackColor = True
        '
        'txtPanjangRoll
        '
        Me.txtPanjangRoll.AllowEnterToMoveNext = True
        Me.txtPanjangRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPanjangRoll.CheckIsValid = False
        Me.txtPanjangRoll.DataFormat = "###,###"
        Me.txtPanjangRoll.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPanjangRoll.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanjangRoll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPanjangRoll.Location = New System.Drawing.Point(235, 76)
        Me.txtPanjangRoll.MaxLength = 6
        Me.txtPanjangRoll.Name = "txtPanjangRoll"
        Me.txtPanjangRoll.Size = New System.Drawing.Size(92, 24)
        Me.txtPanjangRoll.TabIndex = 2
        Me.txtPanjangRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPanjangRoll.Value = 0.0R
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia.CheckIsValid = False
        Me.txtBeratMedia.DataFormat = "###,##0.00"
        Me.txtBeratMedia.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia.Location = New System.Drawing.Point(329, 21)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.ReadOnly = True
        Me.txtBeratMedia.Size = New System.Drawing.Size(49, 25)
        Me.txtBeratMedia.TabIndex = 2
        Me.txtBeratMedia.TabStop = False
        Me.txtBeratMedia.Text = "0.00"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia.Value = 0.0R
        '
        'btLookupKodeMediaTimbang
        '
        Me.btLookupKodeMediaTimbang.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeMediaTimbang.Location = New System.Drawing.Point(379, 20)
        Me.btLookupKodeMediaTimbang.Name = "btLookupKodeMediaTimbang"
        Me.btLookupKodeMediaTimbang.Size = New System.Drawing.Size(30, 26)
        Me.btLookupKodeMediaTimbang.TabIndex = 3
        Me.btLookupKodeMediaTimbang.TabStop = False
        Me.btLookupKodeMediaTimbang.Text = "..."
        Me.btLookupKodeMediaTimbang.UseVisualStyleBackColor = True
        '
        'cboKodeMediaTimbang
        '
        Me.cboKodeMediaTimbang.AllowEnterToMoveNext = True
        Me.cboKodeMediaTimbang.DataLocked = False
        Me.cboKodeMediaTimbang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMediaTimbang.DropDownHeight = 105
        Me.cboKodeMediaTimbang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMediaTimbang.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMediaTimbang.FormattingEnabled = True
        Me.cboKodeMediaTimbang.IndexLocked = False
        Me.cboKodeMediaTimbang.IntegralHeight = False
        Me.cboKodeMediaTimbang.Location = New System.Drawing.Point(127, 21)
        Me.cboKodeMediaTimbang.Name = "cboKodeMediaTimbang"
        Me.cboKodeMediaTimbang.Size = New System.Drawing.Size(200, 24)
        Me.cboKodeMediaTimbang.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Media Timbang"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblWarning)
        Me.Panel8.Controls.Add(Me.txtKeterangan)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.btLookupKodeUnitPeruntukan)
        Me.Panel8.Controls.Add(Me.cboKodeUnitPeruntukan)
        Me.Panel8.Controls.Add(Me.Label19)
        Me.Panel8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(887, 293)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(385, 181)
        Me.Panel8.TabIndex = 2
        '
        'lblWarning
        '
        Me.lblWarning.BackColor = System.Drawing.Color.Blue
        Me.lblWarning.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWarning.Font = New System.Drawing.Font("Arial Narrow", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Yellow
        Me.lblWarning.Location = New System.Drawing.Point(17, 86)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(350, 82)
        Me.lblWarning.TabIndex = 98
        Me.lblWarning.Text = "PERIKSA INPUT DATA PANJANG ROLL"
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(116, 52)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(251, 24)
        Me.txtKeterangan.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Keterangan"
        '
        'btLookupKodeUnitPeruntukan
        '
        Me.btLookupKodeUnitPeruntukan.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeUnitPeruntukan.Location = New System.Drawing.Point(337, 20)
        Me.btLookupKodeUnitPeruntukan.Name = "btLookupKodeUnitPeruntukan"
        Me.btLookupKodeUnitPeruntukan.Size = New System.Drawing.Size(30, 26)
        Me.btLookupKodeUnitPeruntukan.TabIndex = 11
        Me.btLookupKodeUnitPeruntukan.TabStop = False
        Me.btLookupKodeUnitPeruntukan.Text = "..."
        Me.btLookupKodeUnitPeruntukan.UseVisualStyleBackColor = True
        '
        'cboKodeUnitPeruntukan
        '
        Me.cboKodeUnitPeruntukan.AllowEnterToMoveNext = True
        Me.cboKodeUnitPeruntukan.DataLocked = False
        Me.cboKodeUnitPeruntukan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnitPeruntukan.DropDownHeight = 105
        Me.cboKodeUnitPeruntukan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnitPeruntukan.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeUnitPeruntukan.FormattingEnabled = True
        Me.cboKodeUnitPeruntukan.IndexLocked = False
        Me.cboKodeUnitPeruntukan.IntegralHeight = False
        Me.cboKodeUnitPeruntukan.Location = New System.Drawing.Point(116, 21)
        Me.cboKodeUnitPeruntukan.Name = "cboKodeUnitPeruntukan"
        Me.cboKodeUnitPeruntukan.Size = New System.Drawing.Size(220, 25)
        Me.cboKodeUnitPeruntukan.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Unit Produksi"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.Controls.Add(Me.btReprint)
        Me.Panel9.Controls.Add(Me.pictureBox2)
        Me.Panel9.Controls.Add(Me.btSave)
        Me.Panel9.Controls.Add(Me.btClose)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 496)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1284, 54)
        Me.Panel9.TabIndex = 3
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(12, 10)
        Me.btReprint.Name = "btReprint"
        Me.btReprint.Size = New System.Drawing.Size(83, 23)
        Me.btReprint.TabIndex = 2
        Me.btReprint.Text = "Reprint"
        Me.btReprint.UseVisualStyleBackColor = True
        Me.btReprint.Visible = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1284, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(1100, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(1189, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(887, 272)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(385, 22)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "RENCANA PERUNTUKAN"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        Me.tmrJam.Interval = 500
        '
        'Porttimbangan
        '
        '
        'tmrStabil
        '
        Me.tmrStabil.Enabled = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(441, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "DATA PRODUKSI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(459, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(422, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "HASIL PRODUKSI"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtBeratMeter)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.btLookupKodeStatus)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Controls.Add(Me.txtBeratNetto)
        Me.Panel6.Controls.Add(Me.cboKodeStatus)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.cboStatusQC)
        Me.Panel6.Controls.Add(Me.txtPanjangRoll)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.txtBeratMedia)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.cboKodeMediaTimbang)
        Me.Panel6.Controls.Add(Me.btLookupKodeMediaTimbang)
        Me.Panel6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(459, 293)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(422, 181)
        Me.Panel6.TabIndex = 1
        '
        'txtBeratMeter
        '
        Me.txtBeratMeter.AllowEnterToMoveNext = True
        Me.txtBeratMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMeter.CheckIsValid = False
        Me.txtBeratMeter.DataFormat = "###,##0.00"
        Me.txtBeratMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMeter.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMeter.ForeColor = System.Drawing.Color.Red
        Me.txtBeratMeter.Location = New System.Drawing.Point(329, 76)
        Me.txtBeratMeter.Name = "txtBeratMeter"
        Me.txtBeratMeter.ReadOnly = True
        Me.txtBeratMeter.Size = New System.Drawing.Size(80, 24)
        Me.txtBeratMeter.TabIndex = 98
        Me.txtBeratMeter.TabStop = False
        Me.txtBeratMeter.Text = "0.00"
        Me.txtBeratMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMeter.Value = 0.0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(349, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "BERAT /M"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btLookupKodeStatus
        '
        Me.btLookupKodeStatus.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeStatus.Location = New System.Drawing.Point(379, 133)
        Me.btLookupKodeStatus.Name = "btLookupKodeStatus"
        Me.btLookupKodeStatus.Size = New System.Drawing.Size(30, 24)
        Me.btLookupKodeStatus.TabIndex = 96
        Me.btLookupKodeStatus.TabStop = False
        Me.btLookupKodeStatus.Text = "..."
        Me.btLookupKodeStatus.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Status QC"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 86)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 17)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Roll Loom"
        '
        'txtBeratNetto
        '
        Me.txtBeratNetto.AllowEnterToMoveNext = True
        Me.txtBeratNetto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratNetto.CheckIsValid = False
        Me.txtBeratNetto.DataFormat = "###,##0.00"
        Me.txtBeratNetto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratNetto.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratNetto.ForeColor = System.Drawing.Color.Red
        Me.txtBeratNetto.Location = New System.Drawing.Point(127, 76)
        Me.txtBeratNetto.Name = "txtBeratNetto"
        Me.txtBeratNetto.Size = New System.Drawing.Size(105, 24)
        Me.txtBeratNetto.TabIndex = 1
        Me.txtBeratNetto.TabStop = False
        Me.txtBeratNetto.Text = "0.00"
        Me.txtBeratNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratNetto.Value = 0.0R
        '
        'cboKodeStatus
        '
        Me.cboKodeStatus.AllowEnterToMoveNext = True
        Me.cboKodeStatus.DataLocked = False
        Me.cboKodeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeStatus.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.cboKodeStatus.FormattingEnabled = True
        Me.cboKodeStatus.IndexLocked = False
        Me.cboKodeStatus.Location = New System.Drawing.Point(127, 134)
        Me.cboKodeStatus.Name = "cboKodeStatus"
        Me.cboKodeStatus.Size = New System.Drawing.Size(252, 23)
        Me.cboKodeStatus.TabIndex = 42
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.IndianRed
        Me.Label22.Location = New System.Drawing.Point(232, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 15)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "PANJANG ROLL"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.IndianRed
        Me.Label21.Location = New System.Drawing.Point(128, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 15)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "BERAT NETTO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboStatusQC
        '
        Me.cboStatusQC.AllowEnterToMoveNext = True
        Me.cboStatusQC.BackColor = System.Drawing.Color.White
        Me.cboStatusQC.DataLocked = False
        Me.cboStatusQC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatusQC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusQC.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusQC.FormattingEnabled = True
        Me.cboStatusQC.IndexLocked = False
        Me.cboStatusQC.Items.AddRange(New Object() {"NONE", "OK", "NON OK"})
        Me.cboStatusQC.Location = New System.Drawing.Point(127, 105)
        Me.cboStatusQC.Name = "cboStatusQC"
        Me.cboStatusQC.Size = New System.Drawing.Size(282, 24)
        Me.cboStatusQC.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(127, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(282, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 17)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Keterangan"
        '
        'tmrWarning
        '
        Me.tmrWarning.Interval = 500
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(363, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 16)
        Me.Label20.TabIndex = 123
        Me.Label20.Text = "KG"
        '
        'lblTimbangManual
        '
        Me.lblTimbangManual.AutoSize = True
        Me.lblTimbangManual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimbangManual.Location = New System.Drawing.Point(126, 128)
        Me.lblTimbangManual.Name = "lblTimbangManual"
        Me.lblTimbangManual.Size = New System.Drawing.Size(103, 16)
        Me.lblTimbangManual.TabIndex = 122
        Me.lblTimbangManual.Text = "Timbang Manual"
        '
        'txtTimbangManual
        '
        Me.txtTimbangManual.AllowEnterToMoveNext = True
        Me.txtTimbangManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimbangManual.CheckIsValid = False
        Me.txtTimbangManual.DataFormat = "###,##0.00"
        Me.txtTimbangManual.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTimbangManual.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTimbangManual.ForeColor = System.Drawing.Color.Blue
        Me.txtTimbangManual.Location = New System.Drawing.Point(255, 124)
        Me.txtTimbangManual.Name = "txtTimbangManual"
        Me.txtTimbangManual.Size = New System.Drawing.Size(102, 25)
        Me.txtTimbangManual.TabIndex = 121
        Me.txtTimbangManual.Text = "3,000.00"
        Me.txtTimbangManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbangManual.Value = 3000.0R
        '
        'chkManual
        '
        Me.chkManual.AllowEnterToMoveNext = True
        Me.chkManual.AutoSize = True
        Me.chkManual.Location = New System.Drawing.Point(129, 101)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(108, 21)
        Me.chkManual.TabIndex = 120
        Me.chkManual.TabStop = False
        Me.chkManual.Text = "Input Manual"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'frmProduksiLoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 550)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProduksiLoom"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi Loom"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lblIndicator As System.Windows.Forms.Label
    Private WithEvents lblConnectionStatus As System.Windows.Forms.Label
    Private WithEvents lblKodeLokasiProduksi As System.Windows.Forms.Label
    Private WithEvents lblJamTimbang As System.Windows.Forms.Label
    Private WithEvents lblTglTimbang As System.Windows.Forms.Label
    Private WithEvents lblTransaksi As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents txtTglTransaksi As System.Windows.Forms.Label
    Private WithEvents KeteranganShift As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents txtKodeShift As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents lblStatusNetto As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lblStabil As System.Windows.Forms.Label
    Private WithEvents lblBeratNetto As System.Windows.Forms.Label
    Private WithEvents lblBeratBrutto As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btLookupKodeMesin As System.Windows.Forms.Button
    Friend WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btLookupNomorSpk As System.Windows.Forms.Button
    Friend WithEvents cboNomorSpk As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPanjangRoll As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents btLookupKodeMediaTimbang As System.Windows.Forms.Button
    Friend WithEvents cboKodeMediaTimbang As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btLookupKodeUnitPeruntukan As System.Windows.Forms.Button
    Friend WithEvents cboKodeUnitPeruntukan As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents btReprint As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents lblItemProduksi As System.Windows.Forms.Label
    Private WithEvents lblKodeUnit As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents Porttimbangan As System.IO.Ports.SerialPort
    Friend WithEvents tmrStabil As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtBeratNetto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboKodeStatus As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboStatusQC As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeStatus As System.Windows.Forms.Button
    Private WithEvents lblStatusTimbang As System.Windows.Forms.Label
    Friend WithEvents txtBeratMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents tmrWarning As System.Windows.Forms.Timer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents lblTimbangManual As System.Windows.Forms.Label
    Friend WithEvents txtTimbangManual As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents chkManual As Enerzie.EPSBasicControls.EPSCheckBox
End Class
