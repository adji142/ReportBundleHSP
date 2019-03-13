<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiPackingCementBag
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
        Me.lblItemBahanBerbeda = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblItemBahan = New System.Windows.Forms.Label()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStabil = New System.Windows.Forms.Label()
        Me.lblBeratBrutto = New System.Windows.Forms.Label()
        Me.lblItemProduksi = New System.Windows.Forms.Label()
        Me.lblLokasiProduksi = New System.Windows.Forms.Label()
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
        Me.lblTimbangManual = New System.Windows.Forms.Label()
        Me.txtTimbangManual = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.chkManual = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.btLookupKodeMesin = New System.Windows.Forms.Button()
        Me.btLookupKodeGrup = New System.Windows.Forms.Button()
        Me.lblKodeMesin = New System.Windows.Forms.Label()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboNomorSpk = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblNomorSpk = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btLookupNomorSpk = New System.Windows.Forms.Button()
        Me.txtHasilPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBeratStandarPerPCS = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboStatusQC = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBeratStandarPerPacking = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBeratBrutto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratNetto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.cboKodeMedia = New Enerzie.EPSBasicControls.EPSComboBox()
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
        Me.txtNamaOperator = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNIKOperator = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.lblItemBahanBerbeda)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblItemBahan)
        Me.Panel1.Controls.Add(Me.lblTransaksi)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblIndicator)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblStabil)
        Me.Panel1.Controls.Add(Me.lblBeratBrutto)
        Me.Panel1.Controls.Add(Me.lblItemProduksi)
        Me.Panel1.Controls.Add(Me.lblLokasiProduksi)
        Me.Panel1.Controls.Add(Me.lblJamTimbang)
        Me.Panel1.Controls.Add(Me.lblTglTimbang)
        Me.Panel1.Controls.Add(Me.lblUnitProduksi)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBeratNetto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 233)
        Me.Panel1.TabIndex = 0
        '
        'lblItemBahanBerbeda
        '
        Me.lblItemBahanBerbeda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItemBahanBerbeda.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemBahanBerbeda.ForeColor = System.Drawing.Color.White
        Me.lblItemBahanBerbeda.Location = New System.Drawing.Point(353, 130)
        Me.lblItemBahanBerbeda.Name = "lblItemBahanBerbeda"
        Me.lblItemBahanBerbeda.Size = New System.Drawing.Size(360, 24)
        Me.lblItemBahanBerbeda.TabIndex = 104
        Me.lblItemBahanBerbeda.Text = "PERINGATAN : ITEM BAHAN TIDAK SESUAI !!"
        Me.lblItemBahanBerbeda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Green
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(142, 198)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 20)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "BAHAN"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(142, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "HASIL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemBahan
        '
        Me.lblItemBahan.AutoSize = True
        Me.lblItemBahan.BackColor = System.Drawing.Color.Transparent
        Me.lblItemBahan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItemBahan.Location = New System.Drawing.Point(195, 197)
        Me.lblItemBahan.Name = "lblItemBahan"
        Me.lblItemBahan.Size = New System.Drawing.Size(113, 20)
        Me.lblItemBahan.TabIndex = 102
        Me.lblItemBahan.Text = "ITEM PRODUKSI"
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.lblTransaksi.Font = New System.Drawing.Font("Arial Narrow", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblTransaksi.Location = New System.Drawing.Point(136, 10)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(221, 35)
        Me.lblTransaksi.TabIndex = 6
        Me.lblTransaksi.Text = "DATA PRODUKSI"
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
        Me.Label17.Location = New System.Drawing.Point(909, 182)
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
        Me.Label16.Location = New System.Drawing.Point(909, 154)
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
        Me.lblIndicator.Location = New System.Drawing.Point(909, 85)
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
        Me.Label14.Location = New System.Drawing.Point(909, 31)
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
        Me.lblStabil.Location = New System.Drawing.Point(909, 59)
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
        Me.lblBeratBrutto.Location = New System.Drawing.Point(438, 6)
        Me.lblBeratBrutto.Name = "lblBeratBrutto"
        Me.lblBeratBrutto.Size = New System.Drawing.Size(502, 134)
        Me.lblBeratBrutto.TabIndex = 84
        Me.lblBeratBrutto.Text = "0.00"
        Me.lblBeratBrutto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemProduksi
        '
        Me.lblItemProduksi.AutoSize = True
        Me.lblItemProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItemProduksi.Location = New System.Drawing.Point(195, 174)
        Me.lblItemProduksi.Name = "lblItemProduksi"
        Me.lblItemProduksi.Size = New System.Drawing.Size(113, 20)
        Me.lblItemProduksi.TabIndex = 6
        Me.lblItemProduksi.Text = "ITEM PRODUKSI"
        '
        'lblLokasiProduksi
        '
        Me.lblLokasiProduksi.AutoSize = True
        Me.lblLokasiProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblLokasiProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasiProduksi.ForeColor = System.Drawing.Color.White
        Me.lblLokasiProduksi.Location = New System.Drawing.Point(138, 152)
        Me.lblLokasiProduksi.Name = "lblLokasiProduksi"
        Me.lblLokasiProduksi.Size = New System.Drawing.Size(134, 20)
        Me.lblLokasiProduksi.TabIndex = 82
        Me.lblLokasiProduksi.Text = "LOKASI  PRODUKSI"
        Me.lblLokasiProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel2.Size = New System.Drawing.Size(130, 233)
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
        Me.Label9.Size = New System.Drawing.Size(894, 1)
        Me.Label9.TabIndex = 81
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratNetto
        '
        Me.lblBeratNetto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratNetto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratNetto.ForeColor = System.Drawing.Color.White
        Me.lblBeratNetto.Location = New System.Drawing.Point(420, 141)
        Me.lblBeratNetto.Name = "lblBeratNetto"
        Me.lblBeratNetto.Size = New System.Drawing.Size(502, 77)
        Me.lblBeratNetto.TabIndex = 98
        Me.lblBeratNetto.Text = "0.00"
        Me.lblBeratNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblTimbangManual)
        Me.Panel3.Controls.Add(Me.txtTimbangManual)
        Me.Panel3.Controls.Add(Me.chkManual)
        Me.Panel3.Controls.Add(Me.btLookupKodeMesin)
        Me.Panel3.Controls.Add(Me.btLookupKodeGrup)
        Me.Panel3.Controls.Add(Me.lblKodeMesin)
        Me.Panel3.Controls.Add(Me.cboKodeMesin)
        Me.Panel3.Controls.Add(Me.chkShiftSebelumnya)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cboKodeGrup)
        Me.Panel3.Controls.Add(Me.cboNomorSpk)
        Me.Panel3.Controls.Add(Me.lblNomorSpk)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btLookupNomorSpk)
        Me.Panel3.Controls.Add(Me.txtHasilPcs)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(18, 282)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(440, 258)
        Me.Panel3.TabIndex = 0
        '
        'lblTimbangManual
        '
        Me.lblTimbangManual.AutoSize = True
        Me.lblTimbangManual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimbangManual.Location = New System.Drawing.Point(7, 215)
        Me.lblTimbangManual.Name = "lblTimbangManual"
        Me.lblTimbangManual.Size = New System.Drawing.Size(103, 16)
        Me.lblTimbangManual.TabIndex = 106
        Me.lblTimbangManual.Text = "Timbang Manual"
        '
        'txtTimbangManual
        '
        Me.txtTimbangManual.AllowEnterToMoveNext = True
        Me.txtTimbangManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimbangManual.CheckIsValid = False
        Me.txtTimbangManual.DataFormat = "###,##0.00"
        Me.txtTimbangManual.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTimbangManual.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTimbangManual.ForeColor = System.Drawing.Color.Blue
        Me.txtTimbangManual.Location = New System.Drawing.Point(118, 211)
        Me.txtTimbangManual.Name = "txtTimbangManual"
        Me.txtTimbangManual.Size = New System.Drawing.Size(186, 25)
        Me.txtTimbangManual.TabIndex = 5
        Me.txtTimbangManual.Text = "3,000.00"
        Me.txtTimbangManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbangManual.Value = 3000.0R
        '
        'chkManual
        '
        Me.chkManual.AllowEnterToMoveNext = True
        Me.chkManual.AutoSize = True
        Me.chkManual.Location = New System.Drawing.Point(315, 214)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(88, 17)
        Me.chkManual.TabIndex = 104
        Me.chkManual.TabStop = False
        Me.chkManual.Text = "Input Manual"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'btLookupKodeMesin
        '
        Me.btLookupKodeMesin.Location = New System.Drawing.Point(398, 77)
        Me.btLookupKodeMesin.Name = "btLookupKodeMesin"
        Me.btLookupKodeMesin.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeMesin.TabIndex = 8
        Me.btLookupKodeMesin.TabStop = False
        Me.btLookupKodeMesin.Text = "..."
        Me.btLookupKodeMesin.UseVisualStyleBackColor = True
        '
        'btLookupKodeGrup
        '
        Me.btLookupKodeGrup.Location = New System.Drawing.Point(398, 17)
        Me.btLookupKodeGrup.Name = "btLookupKodeGrup"
        Me.btLookupKodeGrup.Size = New System.Drawing.Size(28, 25)
        Me.btLookupKodeGrup.TabIndex = 7
        Me.btLookupKodeGrup.TabStop = False
        Me.btLookupKodeGrup.Text = "..."
        Me.btLookupKodeGrup.UseVisualStyleBackColor = True
        '
        'lblKodeMesin
        '
        Me.lblKodeMesin.AutoSize = True
        Me.lblKodeMesin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeMesin.Location = New System.Drawing.Point(7, 81)
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
        Me.cboKodeMesin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMesin.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMesin.IndexLocked = False
        Me.cboKodeMesin.IntegralHeight = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(118, 77)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(279, 25)
        Me.cboKodeMesin.TabIndex = 2
        '
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShiftSebelumnya.ForeColor = System.Drawing.Color.Navy
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(118, 48)
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
        Me.cboKodeGrup.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeGrup.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.IntegralHeight = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(118, 17)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(279, 25)
        Me.cboKodeGrup.TabIndex = 0
        '
        'cboNomorSpk
        '
        Me.cboNomorSpk.AllowEnterToMoveNext = True
        Me.cboNomorSpk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSpk.DataLocked = False
        Me.cboNomorSpk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorSpk.DropDownHeight = 105
        Me.cboNomorSpk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorSpk.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cboNomorSpk.ForeColor = System.Drawing.Color.Red
        Me.cboNomorSpk.IndexLocked = False
        Me.cboNomorSpk.IntegralHeight = False
        Me.cboNomorSpk.Location = New System.Drawing.Point(118, 146)
        Me.cboNomorSpk.Name = "cboNomorSpk"
        Me.cboNomorSpk.Size = New System.Drawing.Size(279, 25)
        Me.cboNomorSpk.TabIndex = 3
        '
        'lblNomorSpk
        '
        Me.lblNomorSpk.AutoSize = True
        Me.lblNomorSpk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomorSpk.Location = New System.Drawing.Point(7, 150)
        Me.lblNomorSpk.Name = "lblNomorSpk"
        Me.lblNomorSpk.Size = New System.Drawing.Size(86, 16)
        Me.lblNomorSpk.TabIndex = 87
        Me.lblNomorSpk.Text = "No. SPK/WO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "PCS "
        '
        'btLookupNomorSpk
        '
        Me.btLookupNomorSpk.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupNomorSpk.Location = New System.Drawing.Point(398, 146)
        Me.btLookupNomorSpk.Name = "btLookupNomorSpk"
        Me.btLookupNomorSpk.Size = New System.Drawing.Size(28, 25)
        Me.btLookupNomorSpk.TabIndex = 91
        Me.btLookupNomorSpk.TabStop = False
        Me.btLookupNomorSpk.Text = "..."
        Me.btLookupNomorSpk.UseVisualStyleBackColor = True
        '
        'txtHasilPcs
        '
        Me.txtHasilPcs.AllowEnterToMoveNext = True
        Me.txtHasilPcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilPcs.CheckIsValid = False
        Me.txtHasilPcs.DataFormat = "###,###"
        Me.txtHasilPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilPcs.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasilPcs.ForeColor = System.Drawing.Color.Blue
        Me.txtHasilPcs.Location = New System.Drawing.Point(118, 175)
        Me.txtHasilPcs.Name = "txtHasilPcs"
        Me.txtHasilPcs.Size = New System.Drawing.Size(83, 32)
        Me.txtHasilPcs.TabIndex = 4
        Me.txtHasilPcs.Text = "3,000"
        Me.txtHasilPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilPcs.Value = 3000.0R
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Jumlah "
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(18, 251)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(945, 28)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "DATA PRODUKSI"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtBeratStandarPerPCS)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.cboStatusQC)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtBeratStandarPerPacking)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtBeratBrutto)
        Me.Panel4.Controls.Add(Me.txtBeratMedia)
        Me.Panel4.Controls.Add(Me.txtBeratNetto)
        Me.Panel4.Controls.Add(Me.cboKodeMedia)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Location = New System.Drawing.Point(464, 282)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(499, 219)
        Me.Panel4.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Gray
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(-1, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(499, 25)
        Me.Label19.TabIndex = 121
        Me.Label19.Text = "QC && BERAT STANDAR"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(211, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 16)
        Me.Label18.TabIndex = 120
        Me.Label18.Text = "GR / PCS"
        '
        'txtBeratStandarPerPCS
        '
        Me.txtBeratStandarPerPCS.AllowEnterToMoveNext = True
        Me.txtBeratStandarPerPCS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBeratStandarPerPCS.CheckIsValid = False
        Me.txtBeratStandarPerPCS.DataFormat = ""
        Me.txtBeratStandarPerPCS.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratStandarPerPCS.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBeratStandarPerPCS.ForeColor = System.Drawing.Color.White
        Me.txtBeratStandarPerPCS.Location = New System.Drawing.Point(122, 146)
        Me.txtBeratStandarPerPCS.Name = "txtBeratStandarPerPCS"
        Me.txtBeratStandarPerPCS.ReadOnly = True
        Me.txtBeratStandarPerPCS.Size = New System.Drawing.Size(83, 25)
        Me.txtBeratStandarPerPCS.TabIndex = 4
        Me.txtBeratStandarPerPCS.TabStop = False
        Me.txtBeratStandarPerPCS.Text = "72"
        Me.txtBeratStandarPerPCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratStandarPerPCS.Value = 72.0R
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Berat Standar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(451, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 16)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "KG"
        '
        'cboStatusQC
        '
        Me.cboStatusQC.AllowEnterToMoveNext = True
        Me.cboStatusQC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStatusQC.DataLocked = False
        Me.cboStatusQC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatusQC.DropDownHeight = 105
        Me.cboStatusQC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboStatusQC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusQC.ForeColor = System.Drawing.Color.Red
        Me.cboStatusQC.IndexLocked = True
        Me.cboStatusQC.IntegralHeight = False
        Me.cboStatusQC.Items.AddRange(New Object() {"-", "OK", "NON OK", "OVER", "UNDER"})
        Me.cboStatusQC.Location = New System.Drawing.Point(122, 177)
        Me.cboStatusQC.Name = "cboStatusQC"
        Me.cboStatusQC.Size = New System.Drawing.Size(353, 27)
        Me.cboStatusQC.TabIndex = 6
        Me.cboStatusQC.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Status QC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(280, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "-------->"
        '
        'txtBeratStandarPerPacking
        '
        Me.txtBeratStandarPerPacking.AllowEnterToMoveNext = True
        Me.txtBeratStandarPerPacking.BackColor = System.Drawing.Color.Red
        Me.txtBeratStandarPerPacking.CheckIsValid = False
        Me.txtBeratStandarPerPacking.DataFormat = "###,##0.00"
        Me.txtBeratStandarPerPacking.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratStandarPerPacking.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBeratStandarPerPacking.ForeColor = System.Drawing.Color.White
        Me.txtBeratStandarPerPacking.Location = New System.Drawing.Point(365, 146)
        Me.txtBeratStandarPerPacking.Name = "txtBeratStandarPerPacking"
        Me.txtBeratStandarPerPacking.ReadOnly = True
        Me.txtBeratStandarPerPacking.Size = New System.Drawing.Size(80, 25)
        Me.txtBeratStandarPerPacking.TabIndex = 5
        Me.txtBeratStandarPerPacking.TabStop = False
        Me.txtBeratStandarPerPacking.Text = "35.00"
        Me.txtBeratStandarPerPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratStandarPerPacking.Value = 35.0R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "KG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(451, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "KG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "KG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "NETTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "BRUTTO"
        '
        'txtBeratBrutto
        '
        Me.txtBeratBrutto.AllowEnterToMoveNext = True
        Me.txtBeratBrutto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratBrutto.CheckIsValid = False
        Me.txtBeratBrutto.DataFormat = "###,##0.00"
        Me.txtBeratBrutto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratBrutto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBeratBrutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBeratBrutto.Location = New System.Drawing.Point(365, 17)
        Me.txtBeratBrutto.Name = "txtBeratBrutto"
        Me.txtBeratBrutto.ReadOnly = True
        Me.txtBeratBrutto.Size = New System.Drawing.Size(80, 25)
        Me.txtBeratBrutto.TabIndex = 1
        Me.txtBeratBrutto.TabStop = False
        Me.txtBeratBrutto.Text = "250.00"
        Me.txtBeratBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratBrutto.Value = 250.0R
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia.CheckIsValid = False
        Me.txtBeratMedia.DataFormat = "###,##0.00"
        Me.txtBeratMedia.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBeratMedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBeratMedia.Location = New System.Drawing.Point(365, 44)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.ReadOnly = True
        Me.txtBeratMedia.Size = New System.Drawing.Size(80, 25)
        Me.txtBeratMedia.TabIndex = 2
        Me.txtBeratMedia.TabStop = False
        Me.txtBeratMedia.Text = "0.50"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia.Value = 0.5R
        '
        'txtBeratNetto
        '
        Me.txtBeratNetto.AllowEnterToMoveNext = True
        Me.txtBeratNetto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratNetto.CheckIsValid = False
        Me.txtBeratNetto.DataFormat = "###,##0.00"
        Me.txtBeratNetto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratNetto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBeratNetto.ForeColor = System.Drawing.Color.Blue
        Me.txtBeratNetto.Location = New System.Drawing.Point(365, 71)
        Me.txtBeratNetto.Name = "txtBeratNetto"
        Me.txtBeratNetto.ReadOnly = True
        Me.txtBeratNetto.Size = New System.Drawing.Size(80, 25)
        Me.txtBeratNetto.TabIndex = 3
        Me.txtBeratNetto.TabStop = False
        Me.txtBeratNetto.Text = "249.50"
        Me.txtBeratNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratNetto.Value = 249.5R
        '
        'cboKodeMedia
        '
        Me.cboKodeMedia.AllowEnterToMoveNext = True
        Me.cboKodeMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeMedia.DataLocked = False
        Me.cboKodeMedia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia.DropDownHeight = 105
        Me.cboKodeMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMedia.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMedia.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMedia.IndexLocked = False
        Me.cboKodeMedia.IntegralHeight = False
        Me.cboKodeMedia.Location = New System.Drawing.Point(122, 44)
        Me.cboKodeMedia.Name = "cboKodeMedia"
        Me.cboKodeMedia.Size = New System.Drawing.Size(233, 25)
        Me.cboKodeMedia.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(11, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 16)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Media Timbang"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(29, 589)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 16)
        Me.Label32.TabIndex = 89
        Me.Label32.Text = "Keterangan"
        Me.Label32.Visible = False
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(140, 586)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(826, 22)
        Me.txtKeterangan.TabIndex = 2
        Me.txtKeterangan.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.btReprint)
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 555)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(978, 54)
        Me.Panel6.TabIndex = 4
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(19, 10)
        Me.btReprint.Name = "btReprint"
        Me.btReprint.Size = New System.Drawing.Size(83, 23)
        Me.btReprint.TabIndex = 8
        Me.btReprint.Text = "Cetak &Ulang"
        Me.btReprint.UseVisualStyleBackColor = True
        Me.btReprint.Visible = False
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
        Me.btSave.TabIndex = 1
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
        'txtNamaOperator
        '
        Me.txtNamaOperator.AllowEnterToMoveNext = True
        Me.txtNamaOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaOperator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaOperator.ForeColor = System.Drawing.Color.White
        Me.txtNamaOperator.Location = New System.Drawing.Point(660, 507)
        Me.txtNamaOperator.Name = "txtNamaOperator"
        Me.txtNamaOperator.ReadOnly = True
        Me.txtNamaOperator.Size = New System.Drawing.Size(303, 26)
        Me.txtNamaOperator.TabIndex = 3
        Me.txtNamaOperator.TabStop = False
        Me.txtNamaOperator.Text = "JOKO SUSILO"
        '
        'txtNIKOperator
        '
        Me.txtNIKOperator.AllowEnterToMoveNext = True
        Me.txtNIKOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNIKOperator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIKOperator.Location = New System.Drawing.Point(587, 507)
        Me.txtNIKOperator.Name = "txtNIKOperator"
        Me.txtNIKOperator.Size = New System.Drawing.Size(70, 26)
        Me.txtNIKOperator.TabIndex = 2
        Me.txtNIKOperator.Text = "001"
        Me.txtNIKOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(476, 512)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 131
        Me.Label22.Text = "OPERATOR"
        '
        'frmProduksiPackingCementBag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 609)
        Me.Controls.Add(Me.txtNamaOperator)
        Me.Controls.Add(Me.txtNIKOperator)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmProduksiPackingCementBag"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi | Packing CementBag"
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
    Friend WithEvents lblLokasiProduksi As System.Windows.Forms.Label
    Friend WithEvents lblBeratBrutto As System.Windows.Forms.Label
    Private WithEvents lblIndicator As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblStabil As System.Windows.Forms.Label
    Friend WithEvents lblBeratNetto As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents lblKodeMesin As System.Windows.Forms.Label
    Private WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents lblNomorSpk As System.Windows.Forms.Label
    Private WithEvents cboNomorSpk As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeGrup As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeMesin As System.Windows.Forms.Button
    Friend WithEvents btLookupNomorSpk As System.Windows.Forms.Button
    Private WithEvents Label27 As System.Windows.Forms.Label
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
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btReprint As System.Windows.Forms.Button
    Friend WithEvents txtBeratNetto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtHasilPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBeratBrutto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBeratStandarPerPacking As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents lblTimbangManual As System.Windows.Forms.Label
    Friend WithEvents txtTimbangManual As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents chkManual As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents cboStatusQC As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblItemBahan As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblItemBahanBerbeda As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBeratStandarPerPCS As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtNamaOperator As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNIKOperator As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label22 As System.Windows.Forms.Label
End Class
