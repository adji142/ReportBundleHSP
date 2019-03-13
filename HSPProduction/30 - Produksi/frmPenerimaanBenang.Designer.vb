<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenerimaanBenang
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
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStabil = New System.Windows.Forms.Label()
        Me.lblBeratBrutto = New System.Windows.Forms.Label()
        Me.lblItemProduksi = New System.Windows.Forms.Label()
        Me.lblAreaProduksi = New System.Windows.Forms.Label()
        Me.lblLokasiProduksi = New System.Windows.Forms.Label()
        Me.lblTglTimbang = New System.Windows.Forms.Label()
        Me.lblUnitProduksi = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNamaGrup = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.PanelShift = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNamaShift = New System.Windows.Forms.Label()
        Me.lblKodeShift = New System.Windows.Forms.Label()
        Me.lblJamTimbang = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBeratNetto = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btReprint = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cboKodeStatus = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboKodeArea = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btLookupNomorSPK = New System.Windows.Forms.Button()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.cboNomorSPK = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTimbangManual = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.chkTimbangManual = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.txtTotalMedia = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBeratMedia3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratMedia2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratMedia1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalMedia3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalMedia2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalMedia1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtJumlahMedia3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtJumlahMedia2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtJumlahMedia1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.cboKodeMedia3 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeMedia2 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeMedia1 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btLookupPolaMedia = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboKodePolaMedia = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tmrWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimbangan = New System.Windows.Forms.Timer(Me.components)
        Me.ScalePort = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelShift.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownHeight = 105
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.IntegralHeight = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(109, 79)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(336, 24)
        Me.cboKodeUnit.TabIndex = 2
        '
        'cboKodeMesin
        '
        Me.cboKodeMesin.AllowEnterToMoveNext = True
        Me.cboKodeMesin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMesin.DataLocked = True
        Me.cboKodeMesin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMesin.DropDownHeight = 105
        Me.cboKodeMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeMesin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMesin.FormattingEnabled = True
        Me.cboKodeMesin.IndexLocked = True
        Me.cboKodeMesin.IntegralHeight = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(109, 135)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(184, 24)
        Me.cboKodeMesin.TabIndex = 4
        Me.cboKodeMesin.TabStop = False
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
        Me.Panel1.Controls.Add(Me.lblBeratBrutto)
        Me.Panel1.Controls.Add(Me.lblItemProduksi)
        Me.Panel1.Controls.Add(Me.lblAreaProduksi)
        Me.Panel1.Controls.Add(Me.lblLokasiProduksi)
        Me.Panel1.Controls.Add(Me.lblTglTimbang)
        Me.Panel1.Controls.Add(Me.lblUnitProduksi)
        Me.Panel1.Controls.Add(Me.lblTransaksi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBeratNetto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 202)
        Me.Panel1.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(115, 80)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(96, 29)
        Me.lblStatus.TabIndex = 101
        Me.lblStatus.Text = "OFFLINE"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(910, 157)
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
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(910, 134)
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
        Me.lblIndicator.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicator.ForeColor = System.Drawing.Color.Yellow
        Me.lblIndicator.Location = New System.Drawing.Point(910, 68)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(51, 22)
        Me.lblIndicator.TabIndex = 97
        Me.lblIndicator.Text = "<<"
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(910, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 23)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "KG"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStabil
        '
        Me.lblStabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStabil.BackColor = System.Drawing.Color.Transparent
        Me.lblStabil.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStabil.ForeColor = System.Drawing.Color.Blue
        Me.lblStabil.Location = New System.Drawing.Point(910, 47)
        Me.lblStabil.Name = "lblStabil"
        Me.lblStabil.Size = New System.Drawing.Size(54, 21)
        Me.lblStabil.TabIndex = 96
        Me.lblStabil.Text = "ST"
        Me.lblStabil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratBrutto
        '
        Me.lblBeratBrutto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratBrutto.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratBrutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBeratBrutto.Location = New System.Drawing.Point(353, 10)
        Me.lblBeratBrutto.Name = "lblBeratBrutto"
        Me.lblBeratBrutto.Size = New System.Drawing.Size(562, 91)
        Me.lblBeratBrutto.TabIndex = 84
        Me.lblBeratBrutto.Text = "0.00"
        Me.lblBeratBrutto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemProduksi
        '
        Me.lblItemProduksi.AutoSize = True
        Me.lblItemProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemProduksi.ForeColor = System.Drawing.Color.White
        Me.lblItemProduksi.Location = New System.Drawing.Point(115, 169)
        Me.lblItemProduksi.Name = "lblItemProduksi"
        Me.lblItemProduksi.Size = New System.Drawing.Size(155, 26)
        Me.lblItemProduksi.TabIndex = 6
        Me.lblItemProduksi.Text = "ITEM PRODUKSI"
        Me.lblItemProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAreaProduksi
        '
        Me.lblAreaProduksi.AutoSize = True
        Me.lblAreaProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblAreaProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAreaProduksi.Location = New System.Drawing.Point(116, 149)
        Me.lblAreaProduksi.Name = "lblAreaProduksi"
        Me.lblAreaProduksi.Size = New System.Drawing.Size(117, 20)
        Me.lblAreaProduksi.TabIndex = 83
        Me.lblAreaProduksi.Text = "AREA PRODUKSI"
        Me.lblAreaProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLokasiProduksi
        '
        Me.lblLokasiProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblLokasiProduksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLokasiProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasiProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLokasiProduksi.Location = New System.Drawing.Point(116, 129)
        Me.lblLokasiProduksi.Name = "lblLokasiProduksi"
        Me.lblLokasiProduksi.Size = New System.Drawing.Size(289, 23)
        Me.lblLokasiProduksi.TabIndex = 82
        Me.lblLokasiProduksi.Text = "LOKASI HASIL PRODUKSI"
        Me.lblLokasiProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTglTimbang
        '
        Me.lblTglTimbang.AutoSize = True
        Me.lblTglTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTimbang.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTimbang.ForeColor = System.Drawing.Color.White
        Me.lblTglTimbang.Location = New System.Drawing.Point(116, 61)
        Me.lblTglTimbang.Name = "lblTglTimbang"
        Me.lblTglTimbang.Size = New System.Drawing.Size(113, 20)
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
        Me.lblUnitProduksi.Location = New System.Drawing.Point(116, 36)
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
        Me.lblTransaksi.Location = New System.Drawing.Point(115, 9)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(232, 29)
        Me.lblTransaksi.TabIndex = 6
        Me.lblTransaksi.Text = "PENERIMAAN BENANG"
        Me.lblTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblNamaGrup)
        Me.Panel2.Controls.Add(Me.lblTglTransaksi)
        Me.Panel2.Controls.Add(Me.PanelShift)
        Me.Panel2.Controls.Add(Me.lblJamTimbang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(109, 202)
        Me.Panel2.TabIndex = 0
        '
        'lblNamaGrup
        '
        Me.lblNamaGrup.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaGrup.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaGrup.ForeColor = System.Drawing.Color.White
        Me.lblNamaGrup.Location = New System.Drawing.Point(15, 168)
        Me.lblNamaGrup.Name = "lblNamaGrup"
        Me.lblNamaGrup.Size = New System.Drawing.Size(77, 23)
        Me.lblNamaGrup.TabIndex = 5
        Me.lblNamaGrup.Text = "GRUP A"
        Me.lblNamaGrup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTglTransaksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTglTransaksi.ForeColor = System.Drawing.Color.Lime
        Me.lblTglTransaksi.Location = New System.Drawing.Point(14, 128)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(78, 22)
        Me.lblTglTransaksi.TabIndex = 4
        Me.lblTglTransaksi.Text = "01/01/2017"
        Me.lblTglTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelShift
        '
        Me.PanelShift.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelShift.Controls.Add(Me.Label3)
        Me.PanelShift.Controls.Add(Me.lblNamaShift)
        Me.PanelShift.Controls.Add(Me.lblKodeShift)
        Me.PanelShift.Location = New System.Drawing.Point(14, 13)
        Me.PanelShift.Name = "PanelShift"
        Me.PanelShift.Size = New System.Drawing.Size(78, 105)
        Me.PanelShift.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SHIFT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNamaShift
        '
        Me.lblNamaShift.BackColor = System.Drawing.Color.Teal
        Me.lblNamaShift.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaShift.ForeColor = System.Drawing.Color.White
        Me.lblNamaShift.Location = New System.Drawing.Point(0, 76)
        Me.lblNamaShift.Name = "lblNamaShift"
        Me.lblNamaShift.Size = New System.Drawing.Size(77, 27)
        Me.lblNamaShift.TabIndex = 3
        Me.lblNamaShift.Text = "MALAM"
        Me.lblNamaShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKodeShift
        '
        Me.lblKodeShift.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblKodeShift.Font = New System.Drawing.Font("Arial Black", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeShift.ForeColor = System.Drawing.Color.Teal
        Me.lblKodeShift.Location = New System.Drawing.Point(8, 10)
        Me.lblKodeShift.Name = "lblKodeShift"
        Me.lblKodeShift.Size = New System.Drawing.Size(64, 68)
        Me.lblKodeShift.TabIndex = 2
        Me.lblKodeShift.Text = "3"
        Me.lblKodeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJamTimbang
        '
        Me.lblJamTimbang.AutoSize = True
        Me.lblJamTimbang.BackColor = System.Drawing.Color.Transparent
        Me.lblJamTimbang.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamTimbang.ForeColor = System.Drawing.Color.White
        Me.lblJamTimbang.Location = New System.Drawing.Point(24, 148)
        Me.lblJamTimbang.Name = "lblJamTimbang"
        Me.lblJamTimbang.Size = New System.Drawing.Size(59, 20)
        Me.lblJamTimbang.TabIndex = 8
        Me.lblJamTimbang.Text = "01:01:01"
        Me.lblJamTimbang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(99, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(900, 1)
        Me.Label9.TabIndex = 81
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratNetto
        '
        Me.lblBeratNetto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratNetto.ForeColor = System.Drawing.Color.White
        Me.lblBeratNetto.Location = New System.Drawing.Point(349, 121)
        Me.lblBeratNetto.Name = "lblBeratNetto"
        Me.lblBeratNetto.Size = New System.Drawing.Size(561, 77)
        Me.lblBeratNetto.TabIndex = 98
        Me.lblBeratNetto.Text = "0.00"
        Me.lblBeratNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(488, 27)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "DATA PRODUKSI"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Grup Produksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Unit Produksi"
        '
        'cboKodeGrup
        '
        Me.cboKodeGrup.AllowEnterToMoveNext = True
        Me.cboKodeGrup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeGrup.DataLocked = False
        Me.cboKodeGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeGrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeGrup.FormattingEnabled = True
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(109, 44)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(184, 24)
        Me.cboKodeGrup.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mesin Produksi"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.btReprint)
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 485)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(984, 54)
        Me.Panel6.TabIndex = 2
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(12, 10)
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
        Me.pictureBox2.Size = New System.Drawing.Size(984, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(791, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(880, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-8, 204)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 4)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-8, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 4)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.cboKodeStatus)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.cboKodeArea)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.btLookupNomorSPK)
        Me.Panel5.Controls.Add(Me.btLookupKodeUnit)
        Me.Panel5.Controls.Add(Me.cboNomorSPK)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.chkShiftSebelumnya)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.cboKodeUnit)
        Me.Panel5.Controls.Add(Me.cboKodeMesin)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.cboKodeGrup)
        Me.Panel5.Location = New System.Drawing.Point(0, 217)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(490, 262)
        Me.Panel5.TabIndex = 0
        '
        'cboKodeStatus
        '
        Me.cboKodeStatus.AllowEnterToMoveNext = True
        Me.cboKodeStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeStatus.DataLocked = False
        Me.cboKodeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeStatus.FormattingEnabled = True
        Me.cboKodeStatus.IndexLocked = False
        Me.cboKodeStatus.Items.AddRange(New Object() {"OK", "NON OK", "OVER", "UNDER", "-"})
        Me.cboKodeStatus.Location = New System.Drawing.Point(109, 191)
        Me.cboKodeStatus.Name = "cboKodeStatus"
        Me.cboKodeStatus.Size = New System.Drawing.Size(184, 24)
        Me.cboKodeStatus.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Status QC"
        '
        'cboKodeArea
        '
        Me.cboKodeArea.AllowEnterToMoveNext = True
        Me.cboKodeArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeArea.DataLocked = False
        Me.cboKodeArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeArea.DropDownHeight = 105
        Me.cboKodeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeArea.FormattingEnabled = True
        Me.cboKodeArea.IndexLocked = False
        Me.cboKodeArea.IntegralHeight = False
        Me.cboKodeArea.Location = New System.Drawing.Point(109, 163)
        Me.cboKodeArea.Name = "cboKodeArea"
        Me.cboKodeArea.Size = New System.Drawing.Size(184, 24)
        Me.cboKodeArea.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Area Simpan"
        '
        'btLookupNomorSPK
        '
        Me.btLookupNomorSPK.Location = New System.Drawing.Point(447, 106)
        Me.btLookupNomorSPK.Name = "btLookupNomorSPK"
        Me.btLookupNomorSPK.Size = New System.Drawing.Size(29, 26)
        Me.btLookupNomorSPK.TabIndex = 15
        Me.btLookupNomorSPK.TabStop = False
        Me.btLookupNomorSPK.Text = "..."
        Me.btLookupNomorSPK.UseVisualStyleBackColor = True
        '
        'btLookupKodeUnit
        '
        Me.btLookupKodeUnit.Location = New System.Drawing.Point(447, 78)
        Me.btLookupKodeUnit.Name = "btLookupKodeUnit"
        Me.btLookupKodeUnit.Size = New System.Drawing.Size(29, 26)
        Me.btLookupKodeUnit.TabIndex = 14
        Me.btLookupKodeUnit.TabStop = False
        Me.btLookupKodeUnit.Text = "..."
        Me.btLookupKodeUnit.UseVisualStyleBackColor = True
        '
        'cboNomorSPK
        '
        Me.cboNomorSPK.AllowEnterToMoveNext = True
        Me.cboNomorSPK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSPK.DataLocked = False
        Me.cboNomorSPK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorSPK.DropDownHeight = 105
        Me.cboNomorSPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorSPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorSPK.FormattingEnabled = True
        Me.cboNomorSPK.IndexLocked = False
        Me.cboNomorSPK.IntegralHeight = False
        Me.cboNomorSPK.Location = New System.Drawing.Point(109, 107)
        Me.cboNomorSPK.Name = "cboNomorSPK"
        Me.cboNomorSPK.Size = New System.Drawing.Size(336, 24)
        Me.cboNomorSPK.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nomor SPK"
        '
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShiftSebelumnya.ForeColor = System.Drawing.Color.Navy
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(299, 47)
        Me.chkShiftSebelumnya.Name = "chkShiftSebelumnya"
        Me.chkShiftSebelumnya.Size = New System.Drawing.Size(125, 19)
        Me.chkShiftSebelumnya.TabIndex = 1
        Me.chkShiftSebelumnya.TabStop = False
        Me.chkShiftSebelumnya.Text = "Shift Sebelumnya"
        Me.chkShiftSebelumnya.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txtKeterangan)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Controls.Add(Me.txtTimbangManual)
        Me.Panel7.Controls.Add(Me.chkTimbangManual)
        Me.Panel7.Controls.Add(Me.txtTotalMedia)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.txtBeratMedia3)
        Me.Panel7.Controls.Add(Me.txtBeratMedia2)
        Me.Panel7.Controls.Add(Me.txtBeratMedia1)
        Me.Panel7.Controls.Add(Me.txtTotalMedia3)
        Me.Panel7.Controls.Add(Me.txtTotalMedia2)
        Me.Panel7.Controls.Add(Me.txtTotalMedia1)
        Me.Panel7.Controls.Add(Me.txtJumlahMedia3)
        Me.Panel7.Controls.Add(Me.txtJumlahMedia2)
        Me.Panel7.Controls.Add(Me.txtJumlahMedia1)
        Me.Panel7.Controls.Add(Me.cboKodeMedia3)
        Me.Panel7.Controls.Add(Me.cboKodeMedia2)
        Me.Panel7.Controls.Add(Me.cboKodeMedia1)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label29)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.btLookupPolaMedia)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.cboKodePolaMedia)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(494, 217)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(490, 262)
        Me.Panel7.TabIndex = 1
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(137, 191)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(332, 23)
        Me.txtKeterangan.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 195)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 15)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "Keterangan"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(138, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(171, 24)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = ">>>"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimbangManual
        '
        Me.txtTimbangManual.AllowEnterToMoveNext = True
        Me.txtTimbangManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTimbangManual.CheckIsValid = False
        Me.txtTimbangManual.DataFormat = "###,##0.00"
        Me.txtTimbangManual.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTimbangManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimbangManual.Location = New System.Drawing.Point(314, 220)
        Me.txtTimbangManual.Name = "txtTimbangManual"
        Me.txtTimbangManual.Size = New System.Drawing.Size(154, 24)
        Me.txtTimbangManual.TabIndex = 16
        Me.txtTimbangManual.TabStop = False
        Me.txtTimbangManual.Text = "0.00"
        Me.txtTimbangManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbangManual.Value = 0.0R
        '
        'chkTimbangManual
        '
        Me.chkTimbangManual.AllowEnterToMoveNext = True
        Me.chkTimbangManual.AutoSize = True
        Me.chkTimbangManual.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimbangManual.ForeColor = System.Drawing.Color.Navy
        Me.chkTimbangManual.Location = New System.Drawing.Point(189, 225)
        Me.chkTimbangManual.Name = "chkTimbangManual"
        Me.chkTimbangManual.Size = New System.Drawing.Size(119, 19)
        Me.chkTimbangManual.TabIndex = 15
        Me.chkTimbangManual.TabStop = False
        Me.chkTimbangManual.Text = "Timbang Manual"
        Me.chkTimbangManual.UseVisualStyleBackColor = True
        '
        'txtTotalMedia
        '
        Me.txtTotalMedia.AllowEnterToMoveNext = True
        Me.txtTotalMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalMedia.CheckIsValid = False
        Me.txtTotalMedia.DataFormat = "###,##0.00"
        Me.txtTotalMedia.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMedia.Location = New System.Drawing.Point(315, 161)
        Me.txtTotalMedia.Name = "txtTotalMedia"
        Me.txtTotalMedia.ReadOnly = True
        Me.txtTotalMedia.Size = New System.Drawing.Size(154, 24)
        Me.txtTotalMedia.TabIndex = 13
        Me.txtTotalMedia.TabStop = False
        Me.txtTotalMedia.Text = "0.00"
        Me.txtTotalMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalMedia.Value = 0.0R
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 15)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Total Media Timbang"
        '
        'txtBeratMedia3
        '
        Me.txtBeratMedia3.AllowEnterToMoveNext = True
        Me.txtBeratMedia3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia3.CheckIsValid = False
        Me.txtBeratMedia3.DataFormat = "###,##0.00"
        Me.txtBeratMedia3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia3.Location = New System.Drawing.Point(419, 134)
        Me.txtBeratMedia3.Name = "txtBeratMedia3"
        Me.txtBeratMedia3.ReadOnly = True
        Me.txtBeratMedia3.Size = New System.Drawing.Size(50, 24)
        Me.txtBeratMedia3.TabIndex = 12
        Me.txtBeratMedia3.TabStop = False
        Me.txtBeratMedia3.Text = "0.00"
        Me.txtBeratMedia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia3.Value = 0.0R
        '
        'txtBeratMedia2
        '
        Me.txtBeratMedia2.AllowEnterToMoveNext = True
        Me.txtBeratMedia2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia2.CheckIsValid = False
        Me.txtBeratMedia2.DataFormat = "###,##0.00"
        Me.txtBeratMedia2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia2.Location = New System.Drawing.Point(419, 106)
        Me.txtBeratMedia2.Name = "txtBeratMedia2"
        Me.txtBeratMedia2.ReadOnly = True
        Me.txtBeratMedia2.Size = New System.Drawing.Size(50, 24)
        Me.txtBeratMedia2.TabIndex = 8
        Me.txtBeratMedia2.TabStop = False
        Me.txtBeratMedia2.Text = "0.00"
        Me.txtBeratMedia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia2.Value = 0.0R
        '
        'txtBeratMedia1
        '
        Me.txtBeratMedia1.AllowEnterToMoveNext = True
        Me.txtBeratMedia1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia1.CheckIsValid = False
        Me.txtBeratMedia1.DataFormat = "###,##0.00"
        Me.txtBeratMedia1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia1.Location = New System.Drawing.Point(419, 78)
        Me.txtBeratMedia1.Name = "txtBeratMedia1"
        Me.txtBeratMedia1.ReadOnly = True
        Me.txtBeratMedia1.Size = New System.Drawing.Size(50, 24)
        Me.txtBeratMedia1.TabIndex = 4
        Me.txtBeratMedia1.TabStop = False
        Me.txtBeratMedia1.Text = "0.00"
        Me.txtBeratMedia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia1.Value = 0.0R
        '
        'txtTotalMedia3
        '
        Me.txtTotalMedia3.AllowEnterToMoveNext = True
        Me.txtTotalMedia3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalMedia3.CheckIsValid = False
        Me.txtTotalMedia3.DataFormat = "###,##0"
        Me.txtTotalMedia3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalMedia3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMedia3.Location = New System.Drawing.Point(367, 134)
        Me.txtTotalMedia3.Name = "txtTotalMedia3"
        Me.txtTotalMedia3.ReadOnly = True
        Me.txtTotalMedia3.Size = New System.Drawing.Size(50, 24)
        Me.txtTotalMedia3.TabIndex = 11
        Me.txtTotalMedia3.TabStop = False
        Me.txtTotalMedia3.Text = "0"
        Me.txtTotalMedia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalMedia3.Value = 0.0R
        '
        'txtTotalMedia2
        '
        Me.txtTotalMedia2.AllowEnterToMoveNext = True
        Me.txtTotalMedia2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalMedia2.CheckIsValid = False
        Me.txtTotalMedia2.DataFormat = "###,##0"
        Me.txtTotalMedia2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalMedia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMedia2.Location = New System.Drawing.Point(367, 106)
        Me.txtTotalMedia2.Name = "txtTotalMedia2"
        Me.txtTotalMedia2.ReadOnly = True
        Me.txtTotalMedia2.Size = New System.Drawing.Size(50, 24)
        Me.txtTotalMedia2.TabIndex = 7
        Me.txtTotalMedia2.TabStop = False
        Me.txtTotalMedia2.Text = "0"
        Me.txtTotalMedia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalMedia2.Value = 0.0R
        '
        'txtTotalMedia1
        '
        Me.txtTotalMedia1.AllowEnterToMoveNext = True
        Me.txtTotalMedia1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalMedia1.CheckIsValid = False
        Me.txtTotalMedia1.DataFormat = "###,##0"
        Me.txtTotalMedia1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalMedia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMedia1.Location = New System.Drawing.Point(367, 78)
        Me.txtTotalMedia1.Name = "txtTotalMedia1"
        Me.txtTotalMedia1.ReadOnly = True
        Me.txtTotalMedia1.Size = New System.Drawing.Size(50, 24)
        Me.txtTotalMedia1.TabIndex = 3
        Me.txtTotalMedia1.TabStop = False
        Me.txtTotalMedia1.Text = "0"
        Me.txtTotalMedia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalMedia1.Value = 0.0R
        '
        'txtJumlahMedia3
        '
        Me.txtJumlahMedia3.AllowEnterToMoveNext = True
        Me.txtJumlahMedia3.CheckIsValid = False
        Me.txtJumlahMedia3.DataFormat = "###,##0"
        Me.txtJumlahMedia3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahMedia3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahMedia3.Location = New System.Drawing.Point(315, 134)
        Me.txtJumlahMedia3.Name = "txtJumlahMedia3"
        Me.txtJumlahMedia3.Size = New System.Drawing.Size(50, 24)
        Me.txtJumlahMedia3.TabIndex = 10
        Me.txtJumlahMedia3.Text = "0"
        Me.txtJumlahMedia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahMedia3.Value = 0.0R
        '
        'txtJumlahMedia2
        '
        Me.txtJumlahMedia2.AllowEnterToMoveNext = True
        Me.txtJumlahMedia2.CheckIsValid = False
        Me.txtJumlahMedia2.DataFormat = "###,##0"
        Me.txtJumlahMedia2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahMedia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahMedia2.Location = New System.Drawing.Point(315, 106)
        Me.txtJumlahMedia2.Name = "txtJumlahMedia2"
        Me.txtJumlahMedia2.Size = New System.Drawing.Size(50, 24)
        Me.txtJumlahMedia2.TabIndex = 6
        Me.txtJumlahMedia2.Text = "0"
        Me.txtJumlahMedia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahMedia2.Value = 0.0R
        '
        'txtJumlahMedia1
        '
        Me.txtJumlahMedia1.AllowEnterToMoveNext = True
        Me.txtJumlahMedia1.CheckIsValid = False
        Me.txtJumlahMedia1.DataFormat = "###,##0"
        Me.txtJumlahMedia1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahMedia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahMedia1.Location = New System.Drawing.Point(315, 78)
        Me.txtJumlahMedia1.Name = "txtJumlahMedia1"
        Me.txtJumlahMedia1.Size = New System.Drawing.Size(50, 24)
        Me.txtJumlahMedia1.TabIndex = 2
        Me.txtJumlahMedia1.Text = "0"
        Me.txtJumlahMedia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahMedia1.Value = 0.0R
        '
        'cboKodeMedia3
        '
        Me.cboKodeMedia3.AllowEnterToMoveNext = True
        Me.cboKodeMedia3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMedia3.DataLocked = True
        Me.cboKodeMedia3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeMedia3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMedia3.FormattingEnabled = True
        Me.cboKodeMedia3.IndexLocked = True
        Me.cboKodeMedia3.Location = New System.Drawing.Point(137, 134)
        Me.cboKodeMedia3.Name = "cboKodeMedia3"
        Me.cboKodeMedia3.Size = New System.Drawing.Size(172, 24)
        Me.cboKodeMedia3.TabIndex = 9
        Me.cboKodeMedia3.TabStop = False
        '
        'cboKodeMedia2
        '
        Me.cboKodeMedia2.AllowEnterToMoveNext = True
        Me.cboKodeMedia2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMedia2.DataLocked = True
        Me.cboKodeMedia2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeMedia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMedia2.FormattingEnabled = True
        Me.cboKodeMedia2.IndexLocked = True
        Me.cboKodeMedia2.Location = New System.Drawing.Point(137, 106)
        Me.cboKodeMedia2.Name = "cboKodeMedia2"
        Me.cboKodeMedia2.Size = New System.Drawing.Size(172, 24)
        Me.cboKodeMedia2.TabIndex = 5
        Me.cboKodeMedia2.TabStop = False
        '
        'cboKodeMedia1
        '
        Me.cboKodeMedia1.AllowEnterToMoveNext = True
        Me.cboKodeMedia1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMedia1.DataLocked = True
        Me.cboKodeMedia1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeMedia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMedia1.FormattingEnabled = True
        Me.cboKodeMedia1.IndexLocked = True
        Me.cboKodeMedia1.Location = New System.Drawing.Point(137, 78)
        Me.cboKodeMedia1.Name = "cboKodeMedia1"
        Me.cboKodeMedia1.Size = New System.Drawing.Size(172, 24)
        Me.cboKodeMedia1.TabIndex = 1
        Me.cboKodeMedia1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(109, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 16)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "#3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(109, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 16)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "#2"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(109, 82)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(22, 16)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "#1"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 80)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Media Timbang"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btLookupPolaMedia
        '
        Me.btLookupPolaMedia.Location = New System.Drawing.Point(440, 43)
        Me.btLookupPolaMedia.Name = "btLookupPolaMedia"
        Me.btLookupPolaMedia.Size = New System.Drawing.Size(29, 26)
        Me.btLookupPolaMedia.TabIndex = 20
        Me.btLookupPolaMedia.TabStop = False
        Me.btLookupPolaMedia.Text = "..."
        Me.btLookupPolaMedia.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Pola Media Timbang"
        '
        'cboKodePolaMedia
        '
        Me.cboKodePolaMedia.AllowEnterToMoveNext = True
        Me.cboKodePolaMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodePolaMedia.DataLocked = False
        Me.cboKodePolaMedia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodePolaMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodePolaMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodePolaMedia.FormattingEnabled = True
        Me.cboKodePolaMedia.IndexLocked = False
        Me.cboKodePolaMedia.Location = New System.Drawing.Point(137, 44)
        Me.cboKodePolaMedia.Name = "cboKodePolaMedia"
        Me.cboKodePolaMedia.Size = New System.Drawing.Size(301, 24)
        Me.cboKodePolaMedia.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Teal
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(488, 27)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "HASIl PRODUKSI"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrWaktu
        '
        Me.tmrWaktu.Enabled = True
        Me.tmrWaktu.Interval = 500
        '
        'tmrTimbangan
        '
        '
        'ScalePort
        '
        '
        'frmPenerimaanBenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 539)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPenerimaanBenang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Hasil Produksi | Extruder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelShift.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents lblIndicator As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblStabil As System.Windows.Forms.Label
    Friend WithEvents lblBeratBrutto As System.Windows.Forms.Label
    Friend WithEvents lblItemProduksi As System.Windows.Forms.Label
    Friend WithEvents lblAreaProduksi As System.Windows.Forms.Label
    Friend WithEvents lblLokasiProduksi As System.Windows.Forms.Label
    Friend WithEvents lblTglTimbang As System.Windows.Forms.Label
    Friend WithEvents lblUnitProduksi As System.Windows.Forms.Label
    Friend WithEvents lblTransaksi As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNamaGrup As System.Windows.Forms.Label
    Friend WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Friend WithEvents PanelShift As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNamaShift As System.Windows.Forms.Label
    Friend WithEvents lblKodeShift As System.Windows.Forms.Label
    Friend WithEvents lblJamTimbang As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBeratNetto As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents btReprint As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents cboNomorSPK As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Friend WithEvents btLookupNomorSPK As System.Windows.Forms.Button
    Friend WithEvents cboKodeArea As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboKodeStatus As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btLookupPolaMedia As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboKodePolaMedia As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboKodeMedia3 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeMedia2 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeMedia1 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtJumlahMedia3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtJumlahMedia2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtJumlahMedia1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratMedia3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratMedia2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratMedia1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalMedia3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalMedia2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalMedia1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalMedia As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTimbangManual As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents chkTimbangManual As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tmrWaktu As System.Windows.Forms.Timer
    Friend WithEvents tmrTimbangan As System.Windows.Forms.Timer
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ScalePort As System.IO.Ports.SerialPort
End Class
