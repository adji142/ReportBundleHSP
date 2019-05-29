<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiAfvalSementara
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
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStabil = New System.Windows.Forms.Label()
        Me.lblBeratBrutto = New System.Windows.Forms.Label()
        Me.lblItemProduksi = New System.Windows.Forms.Label()
        Me.lblLokasiAfvalProduksi = New System.Windows.Forms.Label()
        Me.lblJamTimbang = New System.Windows.Forms.Label()
        Me.lblTglTimbang = New System.Windows.Forms.Label()
        Me.lblUnitProduksi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNamaGrup = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.PanelShift = New System.Windows.Forms.Panel()
        Me.lblNamaShift = New System.Windows.Forms.Label()
        Me.lblKodeShift = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBeratNetto = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTanggal = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboKodeShift = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeMesin = New System.Windows.Forms.Button()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.btLookupKodeGrup = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblKodeMesin = New System.Windows.Forms.Label()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboNomorSPK = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblNomorSPK = New System.Windows.Forms.Label()
        Me.btLookupNomorSPK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBeratNetto = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtBeratBrutto = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.cboKodeItem = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btLookupKodeItem = New System.Windows.Forms.Button()
        Me.cboKodeMedia = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btLookupKodeMedia = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btReprint = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.ScalePort = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrScale = New System.Windows.Forms.Timer(Me.components)
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelShift.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblTransaksi)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblIndicator)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblStabil)
        Me.Panel1.Controls.Add(Me.lblBeratBrutto)
        Me.Panel1.Controls.Add(Me.lblItemProduksi)
        Me.Panel1.Controls.Add(Me.lblLokasiAfvalProduksi)
        Me.Panel1.Controls.Add(Me.lblJamTimbang)
        Me.Panel1.Controls.Add(Me.lblTglTimbang)
        Me.Panel1.Controls.Add(Me.lblUnitProduksi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBeratNetto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 227)
        Me.Panel1.TabIndex = 0
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTransaksi.Font = New System.Drawing.Font("Arial Narrow", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblTransaksi.Location = New System.Drawing.Point(136, 10)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(234, 35)
        Me.lblTransaksi.TabIndex = 6
        Me.lblTransaksi.Text = "AFVAL PRODUKSI"
        Me.lblTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label17.Location = New System.Drawing.Point(908, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 28)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "NET"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(908, 154)
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
        Me.lblIndicator.Location = New System.Drawing.Point(908, 85)
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
        Me.Label14.Location = New System.Drawing.Point(908, 31)
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
        Me.lblStabil.Location = New System.Drawing.Point(908, 59)
        Me.lblStabil.Name = "lblStabil"
        Me.lblStabil.Size = New System.Drawing.Size(54, 26)
        Me.lblStabil.TabIndex = 96
        Me.lblStabil.Text = "ST"
        Me.lblStabil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratBrutto
        '
        Me.lblBeratBrutto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratBrutto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratBrutto.Font = New System.Drawing.Font("Arial Narrow", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratBrutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBeratBrutto.Location = New System.Drawing.Point(433, 2)
        Me.lblBeratBrutto.Name = "lblBeratBrutto"
        Me.lblBeratBrutto.Size = New System.Drawing.Size(501, 134)
        Me.lblBeratBrutto.TabIndex = 84
        Me.lblBeratBrutto.Text = "0.00"
        Me.lblBeratBrutto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemProduksi
        '
        Me.lblItemProduksi.AutoSize = True
        Me.lblItemProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemProduksi.ForeColor = System.Drawing.Color.White
        Me.lblItemProduksi.Location = New System.Drawing.Point(136, 179)
        Me.lblItemProduksi.Name = "lblItemProduksi"
        Me.lblItemProduksi.Size = New System.Drawing.Size(190, 31)
        Me.lblItemProduksi.TabIndex = 6
        Me.lblItemProduksi.Text = "ITEM PRODUKSI"
        Me.lblItemProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLokasiAfvalProduksi
        '
        Me.lblLokasiAfvalProduksi.AutoSize = True
        Me.lblLokasiAfvalProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblLokasiAfvalProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasiAfvalProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLokasiAfvalProduksi.Location = New System.Drawing.Point(138, 154)
        Me.lblLokasiAfvalProduksi.Name = "lblLokasiAfvalProduksi"
        Me.lblLokasiAfvalProduksi.Size = New System.Drawing.Size(208, 23)
        Me.lblLokasiAfvalProduksi.TabIndex = 82
        Me.lblLokasiAfvalProduksi.Text = "LOKASI AFVAL PRODUKSI"
        Me.lblLokasiAfvalProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblUnitProduksi.AutoSize = True
        Me.lblUnitProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblUnitProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitProduksi.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblUnitProduksi.Location = New System.Drawing.Point(138, 40)
        Me.lblUnitProduksi.Name = "lblUnitProduksi"
        Me.lblUnitProduksi.Size = New System.Drawing.Size(130, 23)
        Me.lblUnitProduksi.TabIndex = 6
        Me.lblUnitProduksi.Text = "UNIT PRODUKSI"
        Me.lblUnitProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label9.Size = New System.Drawing.Size(893, 1)
        Me.Label9.TabIndex = 81
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratNetto
        '
        Me.lblBeratNetto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratNetto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratNetto.ForeColor = System.Drawing.Color.White
        Me.lblBeratNetto.Location = New System.Drawing.Point(415, 143)
        Me.lblBeratNetto.Name = "lblBeratNetto"
        Me.lblBeratNetto.Size = New System.Drawing.Size(501, 77)
        Me.lblBeratNetto.TabIndex = 98
        Me.lblBeratNetto.Text = "0.00"
        Me.lblBeratNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cboTanggal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cboKodeShift)
        Me.Panel3.Controls.Add(Me.btLookupKodeMesin)
        Me.Panel3.Controls.Add(Me.btLookupKodeUnit)
        Me.Panel3.Controls.Add(Me.btLookupKodeGrup)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.cboKodeUnit)
        Me.Panel3.Controls.Add(Me.lblKodeMesin)
        Me.Panel3.Controls.Add(Me.cboKodeMesin)
        Me.Panel3.Controls.Add(Me.chkShiftSebelumnya)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cboKodeGrup)
        Me.Panel3.Location = New System.Drawing.Point(10, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(440, 190)
        Me.Panel3.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Tanggal"
        '
        'cboTanggal
        '
        Me.cboTanggal.AllowEnterToMoveNext = True
        Me.cboTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTanggal.DataLocked = False
        Me.cboTanggal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTanggal.DropDownHeight = 105
        Me.cboTanggal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTanggal.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTanggal.ForeColor = System.Drawing.Color.Blue
        Me.cboTanggal.IndexLocked = False
        Me.cboTanggal.IntegralHeight = False
        Me.cboTanggal.Items.AddRange(New Object() {"0", "-1", "-2"})
        Me.cboTanggal.Location = New System.Drawing.Point(118, 23)
        Me.cboTanggal.Name = "cboTanggal"
        Me.cboTanggal.Size = New System.Drawing.Size(117, 25)
        Me.cboTanggal.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Shift Produksi"
        '
        'cboKodeShift
        '
        Me.cboKodeShift.AllowEnterToMoveNext = True
        Me.cboKodeShift.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeShift.DataLocked = False
        Me.cboKodeShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeShift.DropDownHeight = 105
        Me.cboKodeShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeShift.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeShift.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeShift.IndexLocked = False
        Me.cboKodeShift.IntegralHeight = False
        Me.cboKodeShift.Location = New System.Drawing.Point(118, 53)
        Me.cboKodeShift.Name = "cboKodeShift"
        Me.cboKodeShift.Size = New System.Drawing.Size(279, 25)
        Me.cboKodeShift.TabIndex = 1
        '
        'btLookupKodeMesin
        '
        Me.btLookupKodeMesin.Location = New System.Drawing.Point(398, 143)
        Me.btLookupKodeMesin.Name = "btLookupKodeMesin"
        Me.btLookupKodeMesin.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeMesin.TabIndex = 8
        Me.btLookupKodeMesin.TabStop = False
        Me.btLookupKodeMesin.Text = "..."
        Me.btLookupKodeMesin.UseVisualStyleBackColor = True
        '
        'btLookupKodeUnit
        '
        Me.btLookupKodeUnit.Location = New System.Drawing.Point(398, 112)
        Me.btLookupKodeUnit.Name = "btLookupKodeUnit"
        Me.btLookupKodeUnit.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeUnit.TabIndex = 90
        Me.btLookupKodeUnit.TabStop = False
        Me.btLookupKodeUnit.Text = "..."
        Me.btLookupKodeUnit.UseVisualStyleBackColor = True
        '
        'btLookupKodeGrup
        '
        Me.btLookupKodeGrup.Location = New System.Drawing.Point(398, 83)
        Me.btLookupKodeGrup.Name = "btLookupKodeGrup"
        Me.btLookupKodeGrup.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeGrup.TabIndex = 7
        Me.btLookupKodeGrup.TabStop = False
        Me.btLookupKodeGrup.Text = "..."
        Me.btLookupKodeGrup.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 16)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Unit Produksi"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownHeight = 105
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeUnit.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeUnit.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.IntegralHeight = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(118, 113)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(279, 25)
        Me.cboKodeUnit.TabIndex = 3
        '
        'lblKodeMesin
        '
        Me.lblKodeMesin.AutoSize = True
        Me.lblKodeMesin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeMesin.Location = New System.Drawing.Point(7, 147)
        Me.lblKodeMesin.Name = "lblKodeMesin"
        Me.lblKodeMesin.Size = New System.Drawing.Size(98, 16)
        Me.lblKodeMesin.TabIndex = 88
        Me.lblKodeMesin.Text = "Mesin Produksi"
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
        Me.cboKodeMesin.Location = New System.Drawing.Point(118, 143)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(279, 25)
        Me.cboKodeMesin.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 87)
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
        Me.cboKodeGrup.Location = New System.Drawing.Point(118, 83)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(279, 25)
        Me.cboKodeGrup.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(10, 241)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(945, 28)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "DATA PENERIMAAN AFVAL PRODUKSI"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cboNomorSPK)
        Me.Panel4.Controls.Add(Me.lblNomorSPK)
        Me.Panel4.Controls.Add(Me.btLookupNomorSPK)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtBeratNetto)
        Me.Panel4.Controls.Add(Me.txtBeratBrutto)
        Me.Panel4.Controls.Add(Me.txtBeratMedia)
        Me.Panel4.Controls.Add(Me.cboKodeItem)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btLookupKodeItem)
        Me.Panel4.Controls.Add(Me.cboKodeMedia)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.btLookupKodeMedia)
        Me.Panel4.Location = New System.Drawing.Point(456, 272)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(499, 190)
        Me.Panel4.TabIndex = 1
        '
        'cboNomorSPK
        '
        Me.cboNomorSPK.AllowEnterToMoveNext = True
        Me.cboNomorSPK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSPK.DataLocked = False
        Me.cboNomorSPK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorSPK.DropDownHeight = 105
        Me.cboNomorSPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorSPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNomorSPK.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorSPK.ForeColor = System.Drawing.Color.Blue
        Me.cboNomorSPK.IndexLocked = False
        Me.cboNomorSPK.IntegralHeight = False
        Me.cboNomorSPK.Location = New System.Drawing.Point(122, 21)
        Me.cboNomorSPK.Name = "cboNomorSPK"
        Me.cboNomorSPK.Size = New System.Drawing.Size(321, 25)
        Me.cboNomorSPK.TabIndex = 0
        '
        'lblNomorSPK
        '
        Me.lblNomorSPK.AutoSize = True
        Me.lblNomorSPK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomorSPK.Location = New System.Drawing.Point(11, 25)
        Me.lblNomorSPK.Name = "lblNomorSPK"
        Me.lblNomorSPK.Size = New System.Drawing.Size(86, 16)
        Me.lblNomorSPK.TabIndex = 106
        Me.lblNomorSPK.Text = "No. SPK/WO"
        '
        'btLookupNomorSPK
        '
        Me.btLookupNomorSPK.Location = New System.Drawing.Point(447, 21)
        Me.btLookupNomorSPK.Name = "btLookupNomorSPK"
        Me.btLookupNomorSPK.Size = New System.Drawing.Size(28, 25)
        Me.btLookupNomorSPK.TabIndex = 107
        Me.btLookupNomorSPK.TabStop = False
        Me.btLookupNomorSPK.Text = "..."
        Me.btLookupNomorSPK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(335, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Netto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Brutto"
        '
        'txtBeratNetto
        '
        Me.txtBeratNetto.AllowEnterToMoveNext = True
        Me.txtBeratNetto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 11.0!)
        Me.txtBeratNetto.Location = New System.Drawing.Point(380, 144)
        Me.txtBeratNetto.Name = "txtBeratNetto"
        Me.txtBeratNetto.ReadOnly = True
        Me.txtBeratNetto.Size = New System.Drawing.Size(95, 24)
        Me.txtBeratNetto.TabIndex = 5
        Me.txtBeratNetto.TabStop = False
        Me.txtBeratNetto.Text = "0 KG"
        Me.txtBeratNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBeratBrutto
        '
        Me.txtBeratBrutto.AllowEnterToMoveNext = True
        Me.txtBeratBrutto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratBrutto.Font = New System.Drawing.Font("Arial Narrow", 11.0!)
        Me.txtBeratBrutto.Location = New System.Drawing.Point(380, 90)
        Me.txtBeratBrutto.Name = "txtBeratBrutto"
        Me.txtBeratBrutto.ReadOnly = True
        Me.txtBeratBrutto.Size = New System.Drawing.Size(95, 24)
        Me.txtBeratBrutto.TabIndex = 3
        Me.txtBeratBrutto.TabStop = False
        Me.txtBeratBrutto.Text = "0 KG"
        Me.txtBeratBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia.Font = New System.Drawing.Font("Arial Narrow", 11.0!)
        Me.txtBeratMedia.Location = New System.Drawing.Point(380, 117)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.ReadOnly = True
        Me.txtBeratMedia.Size = New System.Drawing.Size(95, 24)
        Me.txtBeratMedia.TabIndex = 4
        Me.txtBeratMedia.TabStop = False
        Me.txtBeratMedia.Text = "0 KG"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboKodeItem
        '
        Me.cboKodeItem.AllowEnterToMoveNext = True
        Me.cboKodeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeItem.DataLocked = False
        Me.cboKodeItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeItem.DropDownHeight = 105
        Me.cboKodeItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeItem.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeItem.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeItem.IndexLocked = False
        Me.cboKodeItem.IntegralHeight = False
        Me.cboKodeItem.Location = New System.Drawing.Point(122, 55)
        Me.cboKodeItem.Name = "cboKodeItem"
        Me.cboKodeItem.Size = New System.Drawing.Size(321, 25)
        Me.cboKodeItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Afval Produksi"
        '
        'btLookupKodeItem
        '
        Me.btLookupKodeItem.Location = New System.Drawing.Point(447, 55)
        Me.btLookupKodeItem.Name = "btLookupKodeItem"
        Me.btLookupKodeItem.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeItem.TabIndex = 100
        Me.btLookupKodeItem.TabStop = False
        Me.btLookupKodeItem.Text = "..."
        Me.btLookupKodeItem.UseVisualStyleBackColor = True
        '
        'cboKodeMedia
        '
        Me.cboKodeMedia.AllowEnterToMoveNext = True
        Me.cboKodeMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMedia.DataLocked = False
        Me.cboKodeMedia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia.DropDownHeight = 105
        Me.cboKodeMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKodeMedia.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMedia.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMedia.IndexLocked = False
        Me.cboKodeMedia.IntegralHeight = False
        Me.cboKodeMedia.Location = New System.Drawing.Point(122, 116)
        Me.cboKodeMedia.Name = "cboKodeMedia"
        Me.cboKodeMedia.Size = New System.Drawing.Size(222, 25)
        Me.cboKodeMedia.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(11, 120)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 16)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Media Timbang"
        '
        'btLookupKodeMedia
        '
        Me.btLookupKodeMedia.Location = New System.Drawing.Point(346, 116)
        Me.btLookupKodeMedia.Name = "btLookupKodeMedia"
        Me.btLookupKodeMedia.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeMedia.TabIndex = 97
        Me.btLookupKodeMedia.TabStop = False
        Me.btLookupKodeMedia.Text = "..."
        Me.btLookupKodeMedia.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(17, 480)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 16)
        Me.Label32.TabIndex = 89
        Me.Label32.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(129, 476)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(826, 22)
        Me.txtKeterangan.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.btReprint)
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 516)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(977, 54)
        Me.Panel6.TabIndex = 3
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(784, 10)
        Me.btReprint.Name = "btReprint"
        Me.btReprint.Size = New System.Drawing.Size(83, 23)
        Me.btReprint.TabIndex = 8
        Me.btReprint.Text = "Cetak &Ulang"
        Me.btReprint.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(695, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(873, 10)
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
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShiftSebelumnya.ForeColor = System.Drawing.Color.Navy
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(264, 3)
        Me.chkShiftSebelumnya.Name = "chkShiftSebelumnya"
        Me.chkShiftSebelumnya.Size = New System.Drawing.Size(171, 20)
        Me.chkShiftSebelumnya.TabIndex = 5
        Me.chkShiftSebelumnya.TabStop = False
        Me.chkShiftSebelumnya.Text = "Produksi Shift Sebelumnya"
        Me.chkShiftSebelumnya.UseVisualStyleBackColor = True
        Me.chkShiftSebelumnya.Visible = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(977, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'frmProduksiAfvalSementara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 570)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmProduksiAfvalSementara"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi | Penerimaan Afval"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelShift.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents lblLokasiAfvalProduksi As System.Windows.Forms.Label
    Friend WithEvents lblBeratBrutto As System.Windows.Forms.Label
    Private WithEvents lblIndicator As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblStabil As System.Windows.Forms.Label
    Friend WithEvents lblBeratNetto As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents lblKodeMesin As System.Windows.Forms.Label
    Private WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btLookupKodeGrup As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeMesin As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Private WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeMedia As System.Windows.Forms.Button
    Private WithEvents cboKodeMedia As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents ScalePort As System.IO.Ports.SerialPort
    Friend WithEvents tmrScale As System.Windows.Forms.Timer
    Private WithEvents cboKodeItem As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeItem As System.Windows.Forms.Button
    Private WithEvents btReprint As System.Windows.Forms.Button
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBeratNetto As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtBeratBrutto As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents cboNomorSPK As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents lblNomorSPK As System.Windows.Forms.Label
    Friend WithEvents btLookupNomorSPK As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboKodeShift As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cboTanggal As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
End Class
