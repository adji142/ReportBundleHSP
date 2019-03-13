<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiBenangMultifilament
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStabil = New System.Windows.Forms.Label()
        Me.lblItemProduksi = New System.Windows.Forms.Label()
        Me.lblAreaProduksi = New System.Windows.Forms.Label()
        Me.lblLokasiProduksi = New System.Windows.Forms.Label()
        Me.lblJamTimbang = New System.Windows.Forms.Label()
        Me.lblTglTimbang = New System.Windows.Forms.Label()
        Me.lblUnitProduksi = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNamaGrup = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.PanelShift = New System.Windows.Forms.Panel()
        Me.lblNamaShift = New System.Windows.Forms.Label()
        Me.lblKodeShift = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBeratNetto = New System.Windows.Forms.Label()
        Me.lblBeratBrutto = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btLookupKodeMesin = New System.Windows.Forms.Button()
        Me.btLookupKodeGrup = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btLookupNomorSpk = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboStatusQc = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboNomorSpk = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTimbangManual = New System.Windows.Forms.Label()
        Me.txtTimbangManual = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.chkManual = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJumlahCones = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btLookupKodePolaMediaTimbang = New System.Windows.Forms.Button()
        Me.cboKodeMediaTimbang = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btReprint = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.ScalePort = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrScale = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelShift.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblIndicator)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblStabil)
        Me.Panel1.Controls.Add(Me.lblItemProduksi)
        Me.Panel1.Controls.Add(Me.lblAreaProduksi)
        Me.Panel1.Controls.Add(Me.lblLokasiProduksi)
        Me.Panel1.Controls.Add(Me.lblJamTimbang)
        Me.Panel1.Controls.Add(Me.lblTglTimbang)
        Me.Panel1.Controls.Add(Me.lblUnitProduksi)
        Me.Panel1.Controls.Add(Me.lblTransaksi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBeratNetto)
        Me.Panel1.Controls.Add(Me.lblBeratBrutto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 227)
        Me.Panel1.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(136, 107)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(110, 31)
        Me.lblStatus.TabIndex = 101
        Me.lblStatus.Text = "OFFLINE"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1118, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 28)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "NETT"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(1118, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 28)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "KG"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndicator
        '
        Me.lblIndicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIndicator.BackColor = System.Drawing.Color.Transparent
        Me.lblIndicator.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicator.ForeColor = System.Drawing.Color.Yellow
        Me.lblIndicator.Location = New System.Drawing.Point(1119, 87)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(51, 27)
        Me.lblIndicator.TabIndex = 97
        Me.lblIndicator.Text = "<<"
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(1118, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 28)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "KG"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStabil
        '
        Me.lblStabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStabil.BackColor = System.Drawing.Color.Transparent
        Me.lblStabil.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStabil.ForeColor = System.Drawing.Color.Blue
        Me.lblStabil.Location = New System.Drawing.Point(1118, 54)
        Me.lblStabil.Name = "lblStabil"
        Me.lblStabil.Size = New System.Drawing.Size(54, 26)
        Me.lblStabil.TabIndex = 96
        Me.lblStabil.Text = "ST"
        Me.lblStabil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemProduksi
        '
        Me.lblItemProduksi.AutoSize = True
        Me.lblItemProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemProduksi.ForeColor = System.Drawing.Color.White
        Me.lblItemProduksi.Location = New System.Drawing.Point(136, 192)
        Me.lblItemProduksi.Name = "lblItemProduksi"
        Me.lblItemProduksi.Size = New System.Drawing.Size(190, 31)
        Me.lblItemProduksi.TabIndex = 6
        Me.lblItemProduksi.Text = "ITEM PRODUKSI"
        Me.lblItemProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAreaProduksi
        '
        Me.lblAreaProduksi.AutoSize = True
        Me.lblAreaProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblAreaProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAreaProduksi.Location = New System.Drawing.Point(138, 169)
        Me.lblAreaProduksi.Name = "lblAreaProduksi"
        Me.lblAreaProduksi.Size = New System.Drawing.Size(137, 23)
        Me.lblAreaProduksi.TabIndex = 83
        Me.lblAreaProduksi.Text = "AREA PRODUKSI"
        Me.lblAreaProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLokasiProduksi
        '
        Me.lblLokasiProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblLokasiProduksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLokasiProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasiProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLokasiProduksi.Location = New System.Drawing.Point(138, 146)
        Me.lblLokasiProduksi.Name = "lblLokasiProduksi"
        Me.lblLokasiProduksi.Size = New System.Drawing.Size(289, 23)
        Me.lblLokasiProduksi.TabIndex = 82
        Me.lblLokasiProduksi.Text = "LOKASI HASIL PRODUKSI"
        Me.lblLokasiProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamTimbang
        '
        Me.lblJamTimbang.AutoSize = True
        Me.lblJamTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblJamTimbang.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamTimbang.ForeColor = System.Drawing.Color.White
        Me.lblJamTimbang.Location = New System.Drawing.Point(138, 85)
        Me.lblJamTimbang.Name = "lblJamTimbang"
        Me.lblJamTimbang.Size = New System.Drawing.Size(68, 22)
        Me.lblJamTimbang.TabIndex = 8
        Me.lblJamTimbang.Text = "01:01:01"
        Me.lblJamTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTglTimbang
        '
        Me.lblTglTimbang.AutoSize = True
        Me.lblTglTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTimbang.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTimbang.ForeColor = System.Drawing.Color.White
        Me.lblTglTimbang.Location = New System.Drawing.Point(138, 66)
        Me.lblTglTimbang.Name = "lblTglTimbang"
        Me.lblTglTimbang.Size = New System.Drawing.Size(133, 22)
        Me.lblTglTimbang.TabIndex = 7
        Me.lblTglTimbang.Text = "01 JANUARI 2017"
        Me.lblTglTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnitProduksi
        '
        Me.lblUnitProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblUnitProduksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUnitProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitProduksi.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblUnitProduksi.Location = New System.Drawing.Point(138, 40)
        Me.lblUnitProduksi.Name = "lblUnitProduksi"
        Me.lblUnitProduksi.Size = New System.Drawing.Size(289, 23)
        Me.lblUnitProduksi.TabIndex = 6
        Me.lblUnitProduksi.Text = "UNIT PRODUKSI"
        Me.lblUnitProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTransaksi.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblTransaksi.Location = New System.Drawing.Point(136, 10)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(394, 29)
        Me.lblTransaksi.TabIndex = 6
        Me.lblTransaksi.Text = "PENERIMAAN BENANG MULTIFILAMENT"
        Me.lblTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblNamaGrup)
        Me.Panel2.Controls.Add(Me.lblTglTransaksi)
        Me.Panel2.Controls.Add(Me.PanelShift)
        Me.Panel2.Controls.Add(Me.lblShift)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 227)
        Me.Panel2.TabIndex = 0
        '
        'lblNamaGrup
        '
        Me.lblNamaGrup.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaGrup.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaGrup.ForeColor = System.Drawing.Color.White
        Me.lblNamaGrup.Location = New System.Drawing.Point(12, 161)
        Me.lblNamaGrup.Name = "lblNamaGrup"
        Me.lblNamaGrup.Size = New System.Drawing.Size(105, 29)
        Me.lblNamaGrup.TabIndex = 5
        Me.lblNamaGrup.Text = "GRUP A"
        Me.lblNamaGrup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTransaksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTransaksi.ForeColor = System.Drawing.Color.Lime
        Me.lblTglTransaksi.Location = New System.Drawing.Point(12, 138)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(105, 22)
        Me.lblTglTransaksi.TabIndex = 4
        Me.lblTglTransaksi.Text = "01/01/2017"
        Me.lblTglTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelShift
        '
        Me.PanelShift.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelShift.Controls.Add(Me.lblNamaShift)
        Me.PanelShift.Controls.Add(Me.lblKodeShift)
        Me.PanelShift.Location = New System.Drawing.Point(11, 44)
        Me.PanelShift.Name = "PanelShift"
        Me.PanelShift.Size = New System.Drawing.Size(106, 91)
        Me.PanelShift.TabIndex = 2
        '
        'lblNamaShift
        '
        Me.lblNamaShift.BackColor = System.Drawing.Color.Teal
        Me.lblNamaShift.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaShift.ForeColor = System.Drawing.Color.White
        Me.lblNamaShift.Location = New System.Drawing.Point(0, 63)
        Me.lblNamaShift.Name = "lblNamaShift"
        Me.lblNamaShift.Size = New System.Drawing.Size(105, 27)
        Me.lblNamaShift.TabIndex = 3
        Me.lblNamaShift.Text = "MALAM"
        Me.lblNamaShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKodeShift
        '
        Me.lblKodeShift.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblKodeShift.Font = New System.Drawing.Font("Arial Black", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeShift.ForeColor = System.Drawing.Color.Teal
        Me.lblKodeShift.Location = New System.Drawing.Point(3, -24)
        Me.lblKodeShift.Name = "lblKodeShift"
        Me.lblKodeShift.Size = New System.Drawing.Size(105, 106)
        Me.lblKodeShift.TabIndex = 2
        Me.lblKodeShift.Text = "3"
        Me.lblKodeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.Color.Teal
        Me.lblShift.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblShift.Location = New System.Drawing.Point(11, 11)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(105, 28)
        Me.lblShift.TabIndex = 1
        Me.lblShift.Text = " SHIFT"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(99, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1100, 1)
        Me.Label9.TabIndex = 81
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratNetto
        '
        Me.lblBeratNetto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratNetto.ForeColor = System.Drawing.Color.White
        Me.lblBeratNetto.Location = New System.Drawing.Point(422, 144)
        Me.lblBeratNetto.Name = "lblBeratNetto"
        Me.lblBeratNetto.Size = New System.Drawing.Size(705, 77)
        Me.lblBeratNetto.TabIndex = 98
        Me.lblBeratNetto.Text = "0.00"
        Me.lblBeratNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBeratBrutto
        '
        Me.lblBeratBrutto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratBrutto.Font = New System.Drawing.Font("Arial Narrow", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratBrutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBeratBrutto.Location = New System.Drawing.Point(433, 2)
        Me.lblBeratBrutto.Name = "lblBeratBrutto"
        Me.lblBeratBrutto.Size = New System.Drawing.Size(705, 134)
        Me.lblBeratBrutto.TabIndex = 84
        Me.lblBeratBrutto.Text = "0.00"
        Me.lblBeratBrutto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btLookupKodeMesin)
        Me.Panel3.Controls.Add(Me.btLookupKodeGrup)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.cboKodeMesin)
        Me.Panel3.Controls.Add(Me.chkShiftSebelumnya)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cboKodeGrup)
        Me.Panel3.Location = New System.Drawing.Point(10, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 190)
        Me.Panel3.TabIndex = 0
        '
        'btLookupKodeMesin
        '
        Me.btLookupKodeMesin.Location = New System.Drawing.Point(318, 75)
        Me.btLookupKodeMesin.Name = "btLookupKodeMesin"
        Me.btLookupKodeMesin.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeMesin.TabIndex = 8
        Me.btLookupKodeMesin.TabStop = False
        Me.btLookupKodeMesin.Text = "..."
        Me.btLookupKodeMesin.UseVisualStyleBackColor = True
        '
        'btLookupKodeGrup
        '
        Me.btLookupKodeGrup.Location = New System.Drawing.Point(318, 17)
        Me.btLookupKodeGrup.Name = "btLookupKodeGrup"
        Me.btLookupKodeGrup.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeGrup.TabIndex = 7
        Me.btLookupKodeGrup.TabStop = False
        Me.btLookupKodeGrup.Text = "..."
        Me.btLookupKodeGrup.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 16)
        Me.Label19.TabIndex = 88
        Me.Label19.Text = "Mesin Produksi"
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
        Me.cboKodeMesin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMesin.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMesin.IndexLocked = False
        Me.cboKodeMesin.IntegralHeight = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(118, 75)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(197, 25)
        Me.cboKodeMesin.TabIndex = 1
        '
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShiftSebelumnya.ForeColor = System.Drawing.Color.Navy
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(118, 46)
        Me.chkShiftSebelumnya.Name = "chkShiftSebelumnya"
        Me.chkShiftSebelumnya.Size = New System.Drawing.Size(171, 20)
        Me.chkShiftSebelumnya.TabIndex = 1
        Me.chkShiftSebelumnya.TabStop = False
        Me.chkShiftSebelumnya.Text = "Produksi Shift Sebelumnya"
        Me.chkShiftSebelumnya.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 16)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "Grup Produksi"
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
        Me.cboKodeGrup.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeGrup.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.IntegralHeight = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(118, 17)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(197, 25)
        Me.cboKodeGrup.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(10, 245)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(360, 28)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "DATA PRODUKSI"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(375, 245)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(410, 28)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "DATA PRODUKSI"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btLookupNomorSpk)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.cboStatusQc)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.cboNomorSpk)
        Me.Panel4.Location = New System.Drawing.Point(375, 272)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(410, 190)
        Me.Panel4.TabIndex = 1
        '
        'btLookupNomorSpk
        '
        Me.btLookupNomorSpk.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupNomorSpk.Location = New System.Drawing.Point(330, 17)
        Me.btLookupNomorSpk.Name = "btLookupNomorSpk"
        Me.btLookupNomorSpk.Size = New System.Drawing.Size(63, 27)
        Me.btLookupNomorSpk.TabIndex = 91
        Me.btLookupNomorSpk.TabStop = False
        Me.btLookupNomorSpk.Text = "DAFTAR"
        Me.btLookupNomorSpk.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 79)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 16)
        Me.Label24.TabIndex = 88
        Me.Label24.Text = "Status QC"
        '
        'cboStatusQc
        '
        Me.cboStatusQc.AllowEnterToMoveNext = True
        Me.cboStatusQc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStatusQc.DataLocked = False
        Me.cboStatusQc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatusQc.DropDownHeight = 105
        Me.cboStatusQc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusQc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatusQc.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusQc.ForeColor = System.Drawing.Color.Blue
        Me.cboStatusQc.IndexLocked = False
        Me.cboStatusQc.IntegralHeight = False
        Me.cboStatusQc.Items.AddRange(New Object() {"ST - STANDARD", "TS - TIDAK STANDARD", "PR - PRODUKSI", "-"})
        Me.cboStatusQc.Location = New System.Drawing.Point(101, 75)
        Me.cboStatusQc.Name = "cboStatusQc"
        Me.cboStatusQc.Size = New System.Drawing.Size(226, 25)
        Me.cboStatusQc.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 16)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "No. SPK"
        '
        'cboNomorSpk
        '
        Me.cboNomorSpk.AllowEnterToMoveNext = True
        Me.cboNomorSpk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSpk.DataLocked = False
        Me.cboNomorSpk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorSpk.DropDownHeight = 105
        Me.cboNomorSpk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorSpk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNomorSpk.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorSpk.ForeColor = System.Drawing.Color.Red
        Me.cboNomorSpk.IndexLocked = False
        Me.cboNomorSpk.IntegralHeight = False
        Me.cboNomorSpk.Location = New System.Drawing.Point(101, 17)
        Me.cboNomorSpk.Name = "cboNomorSpk"
        Me.cboNomorSpk.Size = New System.Drawing.Size(226, 27)
        Me.cboNomorSpk.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Location = New System.Drawing.Point(790, 245)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(383, 28)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "HASIL PRODUKSI"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblTimbangManual)
        Me.Panel5.Controls.Add(Me.txtTimbangManual)
        Me.Panel5.Controls.Add(Me.chkManual)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtJumlahCones)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtBeratMedia)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.btLookupKodePolaMediaTimbang)
        Me.Panel5.Controls.Add(Me.cboKodeMediaTimbang)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Location = New System.Drawing.Point(790, 272)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(383, 190)
        Me.Panel5.TabIndex = 2
        '
        'lblTimbangManual
        '
        Me.lblTimbangManual.AutoSize = True
        Me.lblTimbangManual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimbangManual.Location = New System.Drawing.Point(18, 40)
        Me.lblTimbangManual.Name = "lblTimbangManual"
        Me.lblTimbangManual.Size = New System.Drawing.Size(103, 16)
        Me.lblTimbangManual.TabIndex = 111
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
        Me.txtTimbangManual.Location = New System.Drawing.Point(127, 36)
        Me.txtTimbangManual.Name = "txtTimbangManual"
        Me.txtTimbangManual.Size = New System.Drawing.Size(236, 25)
        Me.txtTimbangManual.TabIndex = 1
        Me.txtTimbangManual.Text = "3,000.00"
        Me.txtTimbangManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbangManual.Value = 3000.0R
        '
        'chkManual
        '
        Me.chkManual.AllowEnterToMoveNext = True
        Me.chkManual.AutoSize = True
        Me.chkManual.Location = New System.Drawing.Point(127, 13)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(88, 17)
        Me.chkManual.TabIndex = 0
        Me.chkManual.TabStop = False
        Me.chkManual.Text = "Input Manual"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Pcs"
        '
        'txtJumlahCones
        '
        Me.txtJumlahCones.AllowEnterToMoveNext = True
        Me.txtJumlahCones.BackColor = System.Drawing.Color.White
        Me.txtJumlahCones.CheckIsValid = False
        Me.txtJumlahCones.DataFormat = "###,##0.00"
        Me.txtJumlahCones.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahCones.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahCones.Location = New System.Drawing.Point(127, 136)
        Me.txtJumlahCones.Name = "txtJumlahCones"
        Me.txtJumlahCones.Size = New System.Drawing.Size(205, 24)
        Me.txtJumlahCones.TabIndex = 4
        Me.txtJumlahCones.Text = "0.00"
        Me.txtJumlahCones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahCones.Value = 0.0R
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Jumlah Cones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "KG"
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.BackColor = System.Drawing.Color.White
        Me.txtBeratMedia.CheckIsValid = False
        Me.txtBeratMedia.DataFormat = "###,##0.00"
        Me.txtBeratMedia.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia.Location = New System.Drawing.Point(127, 106)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.ReadOnly = True
        Me.txtBeratMedia.Size = New System.Drawing.Size(205, 24)
        Me.txtBeratMedia.TabIndex = 3
        Me.txtBeratMedia.TabStop = False
        Me.txtBeratMedia.Text = "0.00"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia.Value = 0.0R
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(14, 111)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(78, 16)
        Me.Label33.TabIndex = 104
        Me.Label33.Text = "Berat Media"
        '
        'btLookupKodePolaMediaTimbang
        '
        Me.btLookupKodePolaMediaTimbang.Location = New System.Drawing.Point(335, 75)
        Me.btLookupKodePolaMediaTimbang.Name = "btLookupKodePolaMediaTimbang"
        Me.btLookupKodePolaMediaTimbang.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodePolaMediaTimbang.TabIndex = 97
        Me.btLookupKodePolaMediaTimbang.TabStop = False
        Me.btLookupKodePolaMediaTimbang.Text = "..."
        Me.btLookupKodePolaMediaTimbang.UseVisualStyleBackColor = True
        '
        'cboKodeMediaTimbang
        '
        Me.cboKodeMediaTimbang.AllowEnterToMoveNext = True
        Me.cboKodeMediaTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMediaTimbang.DataLocked = False
        Me.cboKodeMediaTimbang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMediaTimbang.DropDownHeight = 105
        Me.cboKodeMediaTimbang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMediaTimbang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeMediaTimbang.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMediaTimbang.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMediaTimbang.IndexLocked = False
        Me.cboKodeMediaTimbang.IntegralHeight = False
        Me.cboKodeMediaTimbang.Location = New System.Drawing.Point(127, 75)
        Me.cboKodeMediaTimbang.Name = "cboKodeMediaTimbang"
        Me.cboKodeMediaTimbang.Size = New System.Drawing.Size(205, 25)
        Me.cboKodeMediaTimbang.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(14, 79)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 16)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Media Timbang"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(15, 471)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 16)
        Me.Label32.TabIndex = 89
        Me.Label32.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(129, 468)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(1044, 22)
        Me.txtKeterangan.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.btReprint)
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 520)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1184, 54)
        Me.Panel6.TabIndex = 4
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(10, 10)
        Me.btReprint.Name = "btReprint"
        Me.btReprint.Size = New System.Drawing.Size(83, 23)
        Me.btReprint.TabIndex = 2
        Me.btReprint.Text = "&Reprint"
        Me.btReprint.UseVisualStyleBackColor = True
        Me.btReprint.Visible = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1184, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(991, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(1080, 10)
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
        'ScalePort
        '
        '
        'tmrScale
        '
        '
        'frmProduksiBenangMultifilament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 574)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmProduksiBenangMultifilament"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi Benang Multifilament"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelShift.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Friend WithEvents lblKodeShift As System.Windows.Forms.Label
    Friend WithEvents PanelShift As System.Windows.Forms.Panel
    Friend WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Friend WithEvents lblNamaShift As System.Windows.Forms.Label
    Friend WithEvents lblNamaGrup As System.Windows.Forms.Label
    Friend WithEvents lblTransaksi As System.Windows.Forms.Label
    Friend WithEvents lblUnitProduksi As System.Windows.Forms.Label
    Friend WithEvents lblTglTimbang As System.Windows.Forms.Label
    Friend WithEvents lblJamTimbang As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblItemProduksi As System.Windows.Forms.Label
    Friend WithEvents lblAreaProduksi As System.Windows.Forms.Label
    Friend WithEvents lblLokasiProduksi As System.Windows.Forms.Label
    Friend WithEvents lblBeratBrutto As System.Windows.Forms.Label
    Private WithEvents lblIndicator As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblStabil As System.Windows.Forms.Label
    Friend WithEvents lblBeratNetto As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents cboStatusQc As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents cboNomorSpk As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btLookupKodeGrup As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeMesin As System.Windows.Forms.Button
    Friend WithEvents btLookupNomorSpk As System.Windows.Forms.Button
    Private WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodePolaMediaTimbang As System.Windows.Forms.Button
    Private WithEvents cboKodeMediaTimbang As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents btReprint As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents ScalePort As System.IO.Ports.SerialPort
    Friend WithEvents tmrScale As System.Windows.Forms.Timer
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahCones As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents lblTimbangManual As System.Windows.Forms.Label
    Friend WithEvents txtTimbangManual As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents chkManual As Enerzie.EPSBasicControls.EPSCheckBox
End Class
