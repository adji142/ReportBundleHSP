<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiRewind
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
        Me.btReprint = New System.Windows.Forms.Button()
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNamaOperator = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNIKOperator = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btTimbangHasilProduksi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKodeUnitPeruntukan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtHasilTimbang = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtHasilMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PortTimbangan = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrStabil = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btLookupKodeProduksiBahan4 = New System.Windows.Forms.Button()
        Me.lblNamaItemBahan4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSisaBahan4 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahan4 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahan4 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan4 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan4 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.btLookupKodeProduksiBahan3 = New System.Windows.Forms.Button()
        Me.lblNamaItemBahan3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSisaBahan3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahan3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahan3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan3 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan3 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.btLookupKodeProduksiBahan2 = New System.Windows.Forms.Button()
        Me.btLookupKodeProduksiBahan1 = New System.Windows.Forms.Button()
        Me.txtTotalSisaBahan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalPemakaianBahan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalStockBahan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblNamaItemBahan2 = New System.Windows.Forms.Label()
        Me.lblNamaItemBahan1 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSisaBahan2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahan2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahan2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan2 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan2 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSisaBahan1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahan1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahan1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan1 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan1 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btLookupKodeProduksiBahan5 = New System.Windows.Forms.Button()
        Me.lblNamaItemBahan5 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSisaBahan5 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtPemakaianBahan5 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtStockBahan5 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan5 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan5 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1001, 151)
        Me.Panel1.TabIndex = 0
        '
        'lblKodeUnitProduksi
        '
        Me.lblKodeUnitProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeUnitProduksi.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblKodeUnitProduksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblKodeUnitProduksi.Location = New System.Drawing.Point(546, 16)
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
        Me.lblKodeLokasiHasilProduksi.Location = New System.Drawing.Point(586, 46)
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
        Me.Label2.Size = New System.Drawing.Size(1015, 1)
        Me.Label2.TabIndex = 80
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.btReprint)
        Me.Panel3.Controls.Add(Me.pictureBox2)
        Me.Panel3.Controls.Add(Me.btSave)
        Me.Panel3.Controls.Add(Me.btClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 622)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1001, 54)
        Me.Panel3.TabIndex = 6
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(12, 10)
        Me.btReprint.Name = "btReprint"
        Me.btReprint.Size = New System.Drawing.Size(83, 23)
        Me.btReprint.TabIndex = 9
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
        Me.pictureBox2.Size = New System.Drawing.Size(1001, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(813, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(902, 10)
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
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtNamaOperator)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNIKOperator)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtKeterangan)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.btTimbangHasilProduksi)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboKodeUnitPeruntukan)
        Me.GroupBox2.Controls.Add(Me.txtHasilTimbang)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtHasilMeter)
        Me.GroupBox2.Controls.Add(Me.btLookupNomorSPK)
        Me.GroupBox2.Controls.Add(Me.cboNomorSPK)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 262)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 219)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "Operator"
        '
        'txtNamaOperator
        '
        Me.txtNamaOperator.AllowEnterToMoveNext = True
        Me.txtNamaOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaOperator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaOperator.ForeColor = System.Drawing.Color.White
        Me.txtNamaOperator.Location = New System.Drawing.Point(188, 214)
        Me.txtNamaOperator.Name = "txtNamaOperator"
        Me.txtNamaOperator.ReadOnly = True
        Me.txtNamaOperator.Size = New System.Drawing.Size(237, 26)
        Me.txtNamaOperator.TabIndex = 5
        Me.txtNamaOperator.TabStop = False
        Me.txtNamaOperator.Text = "JOKO SUSILO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(260, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "KILOGRAM"
        '
        'txtNIKOperator
        '
        Me.txtNIKOperator.AllowEnterToMoveNext = True
        Me.txtNIKOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNIKOperator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIKOperator.Location = New System.Drawing.Point(112, 214)
        Me.txtNIKOperator.Name = "txtNIKOperator"
        Me.txtNIKOperator.Size = New System.Drawing.Size(70, 26)
        Me.txtNIKOperator.TabIndex = 6
        Me.txtNIKOperator.Text = "001"
        Me.txtNIKOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "METER"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
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
        'btTimbangHasilProduksi
        '
        Me.btTimbangHasilProduksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimbangHasilProduksi.Location = New System.Drawing.Point(340, 81)
        Me.btTimbangHasilProduksi.Name = "btTimbangHasilProduksi"
        Me.btTimbangHasilProduksi.Size = New System.Drawing.Size(85, 26)
        Me.btTimbangHasilProduksi.TabIndex = 3
        Me.btTimbangHasilProduksi.Text = "TIMBANG"
        Me.btTimbangHasilProduksi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Roll Rewind"
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
        Me.cboKodeUnitPeruntukan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
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
        'txtHasilTimbang
        '
        Me.txtHasilTimbang.AllowEnterToMoveNext = True
        Me.txtHasilTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilTimbang.CheckIsValid = False
        Me.txtHasilTimbang.DataFormat = "###,##0.00"
        Me.txtHasilTimbang.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilTimbang.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtHasilTimbang.ForeColor = System.Drawing.Color.Red
        Me.txtHasilTimbang.Location = New System.Drawing.Point(219, 82)
        Me.txtHasilTimbang.Name = "txtHasilTimbang"
        Me.txtHasilTimbang.ReadOnly = True
        Me.txtHasilTimbang.Size = New System.Drawing.Size(115, 25)
        Me.txtHasilTimbang.TabIndex = 2
        Me.txtHasilTimbang.TabStop = False
        Me.txtHasilTimbang.Text = "250.56"
        Me.txtHasilTimbang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilTimbang.Value = 250.56R
        '
        'txtHasilMeter
        '
        Me.txtHasilMeter.AllowEnterToMoveNext = True
        Me.txtHasilMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilMeter.CheckIsValid = False
        Me.txtHasilMeter.DataFormat = "###,###"
        Me.txtHasilMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilMeter.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtHasilMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtHasilMeter.Location = New System.Drawing.Point(112, 82)
        Me.txtHasilMeter.MaxLength = 6
        Me.txtHasilMeter.Name = "txtHasilMeter"
        Me.txtHasilMeter.Size = New System.Drawing.Size(101, 25)
        Me.txtHasilMeter.TabIndex = 1
        Me.txtHasilMeter.Text = "3,000"
        Me.txtHasilMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilMeter.Value = 3000.0R
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label14.Location = New System.Drawing.Point(112, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(313, 26)
        Me.Label14.TabIndex = 131
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label7.Size = New System.Drawing.Size(505, 27)
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
        Me.Label12.Size = New System.Drawing.Size(407, 27)
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
        Me.Label13.Size = New System.Drawing.Size(407, 27)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "HASIL PRODUKSI"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan5)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan5)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahan5)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahan5)
        Me.GroupBox4.Controls.Add(Me.txtStockBahan5)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan5)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan5)
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan4)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan4)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahan4)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahan4)
        Me.GroupBox4.Controls.Add(Me.txtStockBahan4)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan4)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan4)
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan3)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan3)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahan3)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahan3)
        Me.GroupBox4.Controls.Add(Me.txtStockBahan3)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan3)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan3)
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan2)
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan1)
        Me.GroupBox4.Controls.Add(Me.txtTotalSisaBahan)
        Me.GroupBox4.Controls.Add(Me.txtTotalPemakaianBahan)
        Me.GroupBox4.Controls.Add(Me.txtTotalStockBahan)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan2)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan1)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahan2)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahan2)
        Me.GroupBox4.Controls.Add(Me.txtStockBahan2)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan2)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan2)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtSisaBahan1)
        Me.GroupBox4.Controls.Add(Me.txtPemakaianBahan1)
        Me.GroupBox4.Controls.Add(Me.txtStockBahan1)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan1)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan1)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(475, 191)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(505, 407)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'btLookupKodeProduksiBahan4
        '
        Me.btLookupKodeProduksiBahan4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan4.Location = New System.Drawing.Point(161, 240)
        Me.btLookupKodeProduksiBahan4.Name = "btLookupKodeProduksiBahan4"
        Me.btLookupKodeProduksiBahan4.Size = New System.Drawing.Size(25, 25)
        Me.btLookupKodeProduksiBahan4.TabIndex = 179
        Me.btLookupKodeProduksiBahan4.TabStop = False
        Me.btLookupKodeProduksiBahan4.Text = "..."
        Me.btLookupKodeProduksiBahan4.UseVisualStyleBackColor = True
        '
        'lblNamaItemBahan4
        '
        Me.lblNamaItemBahan4.AutoSize = True
        Me.lblNamaItemBahan4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan4.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan4.Location = New System.Drawing.Point(34, 269)
        Me.lblNamaItemBahan4.Name = "lblNamaItemBahan4"
        Me.lblNamaItemBahan4.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan4.TabIndex = 178
        Me.lblNamaItemBahan4.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 245)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(22, 16)
        Me.Label25.TabIndex = 177
        Me.Label25.Text = "#4"
        '
        'txtSisaBahan4
        '
        Me.txtSisaBahan4.AllowEnterToMoveNext = True
        Me.txtSisaBahan4.BackColor = System.Drawing.Color.White
        Me.txtSisaBahan4.CheckIsValid = False
        Me.txtSisaBahan4.DataFormat = "###,##0"
        Me.txtSisaBahan4.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahan4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahan4.ForeColor = System.Drawing.Color.Blue
        Me.txtSisaBahan4.Location = New System.Drawing.Point(427, 241)
        Me.txtSisaBahan4.Name = "txtSisaBahan4"
        Me.txtSisaBahan4.ReadOnly = True
        Me.txtSisaBahan4.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahan4.TabIndex = 176
        Me.txtSisaBahan4.TabStop = False
        Me.txtSisaBahan4.Text = "0"
        Me.txtSisaBahan4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahan4.Value = 0.0R
        '
        'txtPemakaianBahan4
        '
        Me.txtPemakaianBahan4.AllowEnterToMoveNext = True
        Me.txtPemakaianBahan4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahan4.CheckIsValid = False
        Me.txtPemakaianBahan4.DataFormat = "###,##0"
        Me.txtPemakaianBahan4.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahan4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahan4.ForeColor = System.Drawing.Color.Blue
        Me.txtPemakaianBahan4.Location = New System.Drawing.Point(358, 241)
        Me.txtPemakaianBahan4.Name = "txtPemakaianBahan4"
        Me.txtPemakaianBahan4.ReadOnly = True
        Me.txtPemakaianBahan4.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahan4.TabIndex = 175
        Me.txtPemakaianBahan4.TabStop = False
        Me.txtPemakaianBahan4.Text = "3,000"
        Me.txtPemakaianBahan4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahan4.Value = 3000.0R
        '
        'txtStockBahan4
        '
        Me.txtStockBahan4.AllowEnterToMoveNext = True
        Me.txtStockBahan4.BackColor = System.Drawing.Color.White
        Me.txtStockBahan4.CheckIsValid = False
        Me.txtStockBahan4.DataFormat = "###,##0"
        Me.txtStockBahan4.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahan4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahan4.ForeColor = System.Drawing.Color.Blue
        Me.txtStockBahan4.Location = New System.Drawing.Point(290, 241)
        Me.txtStockBahan4.Name = "txtStockBahan4"
        Me.txtStockBahan4.ReadOnly = True
        Me.txtStockBahan4.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahan4.TabIndex = 174
        Me.txtStockBahan4.TabStop = False
        Me.txtStockBahan4.Text = "3,000"
        Me.txtStockBahan4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahan4.Value = 3000.0R
        '
        'txtKodeItemBahan4
        '
        Me.txtKodeItemBahan4.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan4.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeItemBahan4.Location = New System.Drawing.Point(189, 241)
        Me.txtKodeItemBahan4.Name = "txtKodeItemBahan4"
        Me.txtKodeItemBahan4.ReadOnly = True
        Me.txtKodeItemBahan4.Size = New System.Drawing.Size(93, 22)
        Me.txtKodeItemBahan4.TabIndex = 173
        Me.txtKodeItemBahan4.TabStop = False
        Me.txtKodeItemBahan4.Text = "1234567890"
        '
        'txtKodeProduksiBahan4
        '
        Me.txtKodeProduksiBahan4.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeProduksiBahan4.Location = New System.Drawing.Point(32, 241)
        Me.txtKodeProduksiBahan4.Name = "txtKodeProduksiBahan4"
        Me.txtKodeProduksiBahan4.Size = New System.Drawing.Size(129, 22)
        Me.txtKodeProduksiBahan4.TabIndex = 3
        Me.txtKodeProduksiBahan4.Text = "123456789012345"
        '
        'btLookupKodeProduksiBahan3
        '
        Me.btLookupKodeProduksiBahan3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan3.Location = New System.Drawing.Point(161, 186)
        Me.btLookupKodeProduksiBahan3.Name = "btLookupKodeProduksiBahan3"
        Me.btLookupKodeProduksiBahan3.Size = New System.Drawing.Size(25, 25)
        Me.btLookupKodeProduksiBahan3.TabIndex = 171
        Me.btLookupKodeProduksiBahan3.TabStop = False
        Me.btLookupKodeProduksiBahan3.Text = "..."
        Me.btLookupKodeProduksiBahan3.UseVisualStyleBackColor = True
        '
        'lblNamaItemBahan3
        '
        Me.lblNamaItemBahan3.AutoSize = True
        Me.lblNamaItemBahan3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan3.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan3.Location = New System.Drawing.Point(34, 215)
        Me.lblNamaItemBahan3.Name = "lblNamaItemBahan3"
        Me.lblNamaItemBahan3.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan3.TabIndex = 170
        Me.lblNamaItemBahan3.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 191)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 16)
        Me.Label20.TabIndex = 169
        Me.Label20.Text = "#3"
        '
        'txtSisaBahan3
        '
        Me.txtSisaBahan3.AllowEnterToMoveNext = True
        Me.txtSisaBahan3.BackColor = System.Drawing.Color.White
        Me.txtSisaBahan3.CheckIsValid = False
        Me.txtSisaBahan3.DataFormat = "###,##0"
        Me.txtSisaBahan3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahan3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahan3.ForeColor = System.Drawing.Color.Blue
        Me.txtSisaBahan3.Location = New System.Drawing.Point(426, 186)
        Me.txtSisaBahan3.Name = "txtSisaBahan3"
        Me.txtSisaBahan3.ReadOnly = True
        Me.txtSisaBahan3.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahan3.TabIndex = 168
        Me.txtSisaBahan3.TabStop = False
        Me.txtSisaBahan3.Text = "0"
        Me.txtSisaBahan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahan3.Value = 0.0R
        '
        'txtPemakaianBahan3
        '
        Me.txtPemakaianBahan3.AllowEnterToMoveNext = True
        Me.txtPemakaianBahan3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahan3.CheckIsValid = False
        Me.txtPemakaianBahan3.DataFormat = "###,##0"
        Me.txtPemakaianBahan3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahan3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahan3.ForeColor = System.Drawing.Color.Blue
        Me.txtPemakaianBahan3.Location = New System.Drawing.Point(357, 186)
        Me.txtPemakaianBahan3.Name = "txtPemakaianBahan3"
        Me.txtPemakaianBahan3.ReadOnly = True
        Me.txtPemakaianBahan3.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahan3.TabIndex = 167
        Me.txtPemakaianBahan3.TabStop = False
        Me.txtPemakaianBahan3.Text = "3,000"
        Me.txtPemakaianBahan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahan3.Value = 3000.0R
        '
        'txtStockBahan3
        '
        Me.txtStockBahan3.AllowEnterToMoveNext = True
        Me.txtStockBahan3.BackColor = System.Drawing.Color.White
        Me.txtStockBahan3.CheckIsValid = False
        Me.txtStockBahan3.DataFormat = "###,##0"
        Me.txtStockBahan3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahan3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahan3.ForeColor = System.Drawing.Color.Blue
        Me.txtStockBahan3.Location = New System.Drawing.Point(288, 186)
        Me.txtStockBahan3.Name = "txtStockBahan3"
        Me.txtStockBahan3.ReadOnly = True
        Me.txtStockBahan3.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahan3.TabIndex = 166
        Me.txtStockBahan3.TabStop = False
        Me.txtStockBahan3.Text = "3,000"
        Me.txtStockBahan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahan3.Value = 3000.0R
        '
        'txtKodeItemBahan3
        '
        Me.txtKodeItemBahan3.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan3.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeItemBahan3.Location = New System.Drawing.Point(189, 187)
        Me.txtKodeItemBahan3.Name = "txtKodeItemBahan3"
        Me.txtKodeItemBahan3.ReadOnly = True
        Me.txtKodeItemBahan3.Size = New System.Drawing.Size(93, 22)
        Me.txtKodeItemBahan3.TabIndex = 165
        Me.txtKodeItemBahan3.TabStop = False
        Me.txtKodeItemBahan3.Text = "1234567890"
        '
        'txtKodeProduksiBahan3
        '
        Me.txtKodeProduksiBahan3.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeProduksiBahan3.Location = New System.Drawing.Point(32, 187)
        Me.txtKodeProduksiBahan3.Name = "txtKodeProduksiBahan3"
        Me.txtKodeProduksiBahan3.Size = New System.Drawing.Size(129, 22)
        Me.txtKodeProduksiBahan3.TabIndex = 2
        Me.txtKodeProduksiBahan3.Text = "123456789012345"
        '
        'btLookupKodeProduksiBahan2
        '
        Me.btLookupKodeProduksiBahan2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan2.Location = New System.Drawing.Point(161, 130)
        Me.btLookupKodeProduksiBahan2.Name = "btLookupKodeProduksiBahan2"
        Me.btLookupKodeProduksiBahan2.Size = New System.Drawing.Size(25, 25)
        Me.btLookupKodeProduksiBahan2.TabIndex = 163
        Me.btLookupKodeProduksiBahan2.TabStop = False
        Me.btLookupKodeProduksiBahan2.Text = "..."
        Me.btLookupKodeProduksiBahan2.UseVisualStyleBackColor = True
        '
        'btLookupKodeProduksiBahan1
        '
        Me.btLookupKodeProduksiBahan1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan1.Location = New System.Drawing.Point(161, 77)
        Me.btLookupKodeProduksiBahan1.Name = "btLookupKodeProduksiBahan1"
        Me.btLookupKodeProduksiBahan1.Size = New System.Drawing.Size(25, 25)
        Me.btLookupKodeProduksiBahan1.TabIndex = 162
        Me.btLookupKodeProduksiBahan1.TabStop = False
        Me.btLookupKodeProduksiBahan1.Text = "..."
        Me.btLookupKodeProduksiBahan1.UseVisualStyleBackColor = True
        Me.btLookupKodeProduksiBahan1.Visible = False
        '
        'txtTotalSisaBahan
        '
        Me.txtTotalSisaBahan.AllowEnterToMoveNext = True
        Me.txtTotalSisaBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalSisaBahan.CheckIsValid = False
        Me.txtTotalSisaBahan.DataFormat = "###,##0"
        Me.txtTotalSisaBahan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalSisaBahan.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtTotalSisaBahan.ForeColor = System.Drawing.Color.Red
        Me.txtTotalSisaBahan.Location = New System.Drawing.Point(428, 359)
        Me.txtTotalSisaBahan.Name = "txtTotalSisaBahan"
        Me.txtTotalSisaBahan.ReadOnly = True
        Me.txtTotalSisaBahan.Size = New System.Drawing.Size(64, 22)
        Me.txtTotalSisaBahan.TabIndex = 16
        Me.txtTotalSisaBahan.TabStop = False
        Me.txtTotalSisaBahan.Text = "1,500"
        Me.txtTotalSisaBahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalSisaBahan.Value = 1500.0R
        '
        'txtTotalPemakaianBahan
        '
        Me.txtTotalPemakaianBahan.AllowEnterToMoveNext = True
        Me.txtTotalPemakaianBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalPemakaianBahan.CheckIsValid = False
        Me.txtTotalPemakaianBahan.DataFormat = "###,##0"
        Me.txtTotalPemakaianBahan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalPemakaianBahan.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtTotalPemakaianBahan.ForeColor = System.Drawing.Color.Red
        Me.txtTotalPemakaianBahan.Location = New System.Drawing.Point(359, 359)
        Me.txtTotalPemakaianBahan.Name = "txtTotalPemakaianBahan"
        Me.txtTotalPemakaianBahan.ReadOnly = True
        Me.txtTotalPemakaianBahan.Size = New System.Drawing.Size(68, 22)
        Me.txtTotalPemakaianBahan.TabIndex = 15
        Me.txtTotalPemakaianBahan.TabStop = False
        Me.txtTotalPemakaianBahan.Text = "4,500"
        Me.txtTotalPemakaianBahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalPemakaianBahan.Value = 4500.0R
        '
        'txtTotalStockBahan
        '
        Me.txtTotalStockBahan.AllowEnterToMoveNext = True
        Me.txtTotalStockBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalStockBahan.CheckIsValid = False
        Me.txtTotalStockBahan.DataFormat = "###,##0"
        Me.txtTotalStockBahan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalStockBahan.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtTotalStockBahan.ForeColor = System.Drawing.Color.Red
        Me.txtTotalStockBahan.Location = New System.Drawing.Point(290, 359)
        Me.txtTotalStockBahan.Name = "txtTotalStockBahan"
        Me.txtTotalStockBahan.ReadOnly = True
        Me.txtTotalStockBahan.Size = New System.Drawing.Size(68, 22)
        Me.txtTotalStockBahan.TabIndex = 14
        Me.txtTotalStockBahan.TabStop = False
        Me.txtTotalStockBahan.Text = "6,000"
        Me.txtTotalStockBahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalStockBahan.Value = 6000.0R
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.LightBlue
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(4, 361)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(280, 20)
        Me.Label32.TabIndex = 154
        Me.Label32.Text = "TOTAL"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNamaItemBahan2
        '
        Me.lblNamaItemBahan2.AutoSize = True
        Me.lblNamaItemBahan2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan2.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan2.Location = New System.Drawing.Point(34, 159)
        Me.lblNamaItemBahan2.Name = "lblNamaItemBahan2"
        Me.lblNamaItemBahan2.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan2.TabIndex = 153
        Me.lblNamaItemBahan2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblNamaItemBahan1
        '
        Me.lblNamaItemBahan1.AutoSize = True
        Me.lblNamaItemBahan1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan1.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan1.Location = New System.Drawing.Point(34, 105)
        Me.lblNamaItemBahan1.Name = "lblNamaItemBahan1"
        Me.lblNamaItemBahan1.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan1.TabIndex = 152
        Me.lblNamaItemBahan1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 135)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(22, 16)
        Me.Label29.TabIndex = 151
        Me.Label29.Text = "#2"
        '
        'txtSisaBahan2
        '
        Me.txtSisaBahan2.AllowEnterToMoveNext = True
        Me.txtSisaBahan2.BackColor = System.Drawing.Color.White
        Me.txtSisaBahan2.CheckIsValid = False
        Me.txtSisaBahan2.DataFormat = "###,##0"
        Me.txtSisaBahan2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahan2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahan2.ForeColor = System.Drawing.Color.Blue
        Me.txtSisaBahan2.Location = New System.Drawing.Point(426, 130)
        Me.txtSisaBahan2.Name = "txtSisaBahan2"
        Me.txtSisaBahan2.ReadOnly = True
        Me.txtSisaBahan2.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahan2.TabIndex = 11
        Me.txtSisaBahan2.TabStop = False
        Me.txtSisaBahan2.Text = "0"
        Me.txtSisaBahan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahan2.Value = 0.0R
        '
        'txtPemakaianBahan2
        '
        Me.txtPemakaianBahan2.AllowEnterToMoveNext = True
        Me.txtPemakaianBahan2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahan2.CheckIsValid = False
        Me.txtPemakaianBahan2.DataFormat = "###,##0"
        Me.txtPemakaianBahan2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahan2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahan2.ForeColor = System.Drawing.Color.Blue
        Me.txtPemakaianBahan2.Location = New System.Drawing.Point(357, 130)
        Me.txtPemakaianBahan2.Name = "txtPemakaianBahan2"
        Me.txtPemakaianBahan2.ReadOnly = True
        Me.txtPemakaianBahan2.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahan2.TabIndex = 10
        Me.txtPemakaianBahan2.TabStop = False
        Me.txtPemakaianBahan2.Text = "3,000"
        Me.txtPemakaianBahan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahan2.Value = 3000.0R
        '
        'txtStockBahan2
        '
        Me.txtStockBahan2.AllowEnterToMoveNext = True
        Me.txtStockBahan2.BackColor = System.Drawing.Color.White
        Me.txtStockBahan2.CheckIsValid = False
        Me.txtStockBahan2.DataFormat = "###,##0"
        Me.txtStockBahan2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahan2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahan2.ForeColor = System.Drawing.Color.Blue
        Me.txtStockBahan2.Location = New System.Drawing.Point(288, 130)
        Me.txtStockBahan2.Name = "txtStockBahan2"
        Me.txtStockBahan2.ReadOnly = True
        Me.txtStockBahan2.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahan2.TabIndex = 9
        Me.txtStockBahan2.TabStop = False
        Me.txtStockBahan2.Text = "3,000"
        Me.txtStockBahan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahan2.Value = 3000.0R
        '
        'txtKodeItemBahan2
        '
        Me.txtKodeItemBahan2.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan2.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeItemBahan2.Location = New System.Drawing.Point(189, 131)
        Me.txtKodeItemBahan2.Name = "txtKodeItemBahan2"
        Me.txtKodeItemBahan2.ReadOnly = True
        Me.txtKodeItemBahan2.Size = New System.Drawing.Size(93, 22)
        Me.txtKodeItemBahan2.TabIndex = 8
        Me.txtKodeItemBahan2.TabStop = False
        Me.txtKodeItemBahan2.Text = "1234567890"
        '
        'txtKodeProduksiBahan2
        '
        Me.txtKodeProduksiBahan2.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeProduksiBahan2.Location = New System.Drawing.Point(32, 131)
        Me.txtKodeProduksiBahan2.Name = "txtKodeProduksiBahan2"
        Me.txtKodeProduksiBahan2.Size = New System.Drawing.Size(129, 22)
        Me.txtKodeProduksiBahan2.TabIndex = 1
        Me.txtKodeProduksiBahan2.Text = "123456789012345"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 82)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(22, 16)
        Me.Label28.TabIndex = 145
        Me.Label28.Text = "#1"
        '
        'txtSisaBahan1
        '
        Me.txtSisaBahan1.AllowEnterToMoveNext = True
        Me.txtSisaBahan1.BackColor = System.Drawing.Color.White
        Me.txtSisaBahan1.CheckIsValid = False
        Me.txtSisaBahan1.DataFormat = "###,##0"
        Me.txtSisaBahan1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahan1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahan1.ForeColor = System.Drawing.Color.Blue
        Me.txtSisaBahan1.Location = New System.Drawing.Point(426, 78)
        Me.txtSisaBahan1.Name = "txtSisaBahan1"
        Me.txtSisaBahan1.ReadOnly = True
        Me.txtSisaBahan1.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahan1.TabIndex = 4
        Me.txtSisaBahan1.TabStop = False
        Me.txtSisaBahan1.Text = "0"
        Me.txtSisaBahan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahan1.Value = 0.0R
        '
        'txtPemakaianBahan1
        '
        Me.txtPemakaianBahan1.AllowEnterToMoveNext = True
        Me.txtPemakaianBahan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahan1.CheckIsValid = False
        Me.txtPemakaianBahan1.DataFormat = "###,##0"
        Me.txtPemakaianBahan1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahan1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahan1.ForeColor = System.Drawing.Color.Blue
        Me.txtPemakaianBahan1.Location = New System.Drawing.Point(357, 78)
        Me.txtPemakaianBahan1.Name = "txtPemakaianBahan1"
        Me.txtPemakaianBahan1.ReadOnly = True
        Me.txtPemakaianBahan1.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahan1.TabIndex = 3
        Me.txtPemakaianBahan1.TabStop = False
        Me.txtPemakaianBahan1.Text = "3,000"
        Me.txtPemakaianBahan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahan1.Value = 3000.0R
        '
        'txtStockBahan1
        '
        Me.txtStockBahan1.AllowEnterToMoveNext = True
        Me.txtStockBahan1.BackColor = System.Drawing.Color.White
        Me.txtStockBahan1.CheckIsValid = False
        Me.txtStockBahan1.DataFormat = "###,##0"
        Me.txtStockBahan1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahan1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahan1.ForeColor = System.Drawing.Color.Blue
        Me.txtStockBahan1.Location = New System.Drawing.Point(288, 78)
        Me.txtStockBahan1.Name = "txtStockBahan1"
        Me.txtStockBahan1.ReadOnly = True
        Me.txtStockBahan1.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahan1.TabIndex = 2
        Me.txtStockBahan1.TabStop = False
        Me.txtStockBahan1.Text = "3,000"
        Me.txtStockBahan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahan1.Value = 3000.0R
        '
        'txtKodeItemBahan1
        '
        Me.txtKodeItemBahan1.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan1.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeItemBahan1.Location = New System.Drawing.Point(189, 78)
        Me.txtKodeItemBahan1.Name = "txtKodeItemBahan1"
        Me.txtKodeItemBahan1.ReadOnly = True
        Me.txtKodeItemBahan1.Size = New System.Drawing.Size(93, 22)
        Me.txtKodeItemBahan1.TabIndex = 1
        Me.txtKodeItemBahan1.TabStop = False
        Me.txtKodeItemBahan1.Text = "1234567890"
        '
        'txtKodeProduksiBahan1
        '
        Me.txtKodeProduksiBahan1.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProduksiBahan1.Location = New System.Drawing.Point(32, 78)
        Me.txtKodeProduksiBahan1.Name = "txtKodeProduksiBahan1"
        Me.txtKodeProduksiBahan1.Size = New System.Drawing.Size(129, 22)
        Me.txtKodeProduksiBahan1.TabIndex = 0
        Me.txtKodeProduksiBahan1.Text = "123456789012345"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.LightBlue
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(287, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(203, 20)
        Me.Label27.TabIndex = 138
        Me.Label27.Text = "METER ROLL"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(186, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 18)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "KODE ITEM"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 38)
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
        Me.Label6.Size = New System.Drawing.Size(514, 51)
        Me.Label6.TabIndex = 132
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btLookupKodeProduksiBahan5
        '
        Me.btLookupKodeProduksiBahan5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan5.Location = New System.Drawing.Point(161, 296)
        Me.btLookupKodeProduksiBahan5.Name = "btLookupKodeProduksiBahan5"
        Me.btLookupKodeProduksiBahan5.Size = New System.Drawing.Size(25, 25)
        Me.btLookupKodeProduksiBahan5.TabIndex = 187
        Me.btLookupKodeProduksiBahan5.TabStop = False
        Me.btLookupKodeProduksiBahan5.Text = "..."
        Me.btLookupKodeProduksiBahan5.UseVisualStyleBackColor = True
        '
        'lblNamaItemBahan5
        '
        Me.lblNamaItemBahan5.AutoSize = True
        Me.lblNamaItemBahan5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan5.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan5.Location = New System.Drawing.Point(34, 325)
        Me.lblNamaItemBahan5.Name = "lblNamaItemBahan5"
        Me.lblNamaItemBahan5.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan5.TabIndex = 186
        Me.lblNamaItemBahan5.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 301)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 16)
        Me.Label22.TabIndex = 185
        Me.Label22.Text = "#5"
        '
        'txtSisaBahan5
        '
        Me.txtSisaBahan5.AllowEnterToMoveNext = True
        Me.txtSisaBahan5.BackColor = System.Drawing.Color.White
        Me.txtSisaBahan5.CheckIsValid = False
        Me.txtSisaBahan5.DataFormat = "###,##0"
        Me.txtSisaBahan5.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtSisaBahan5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtSisaBahan5.ForeColor = System.Drawing.Color.Blue
        Me.txtSisaBahan5.Location = New System.Drawing.Point(427, 297)
        Me.txtSisaBahan5.Name = "txtSisaBahan5"
        Me.txtSisaBahan5.ReadOnly = True
        Me.txtSisaBahan5.Size = New System.Drawing.Size(64, 22)
        Me.txtSisaBahan5.TabIndex = 184
        Me.txtSisaBahan5.TabStop = False
        Me.txtSisaBahan5.Text = "0"
        Me.txtSisaBahan5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSisaBahan5.Value = 0.0R
        '
        'txtPemakaianBahan5
        '
        Me.txtPemakaianBahan5.AllowEnterToMoveNext = True
        Me.txtPemakaianBahan5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPemakaianBahan5.CheckIsValid = False
        Me.txtPemakaianBahan5.DataFormat = "###,##0"
        Me.txtPemakaianBahan5.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPemakaianBahan5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtPemakaianBahan5.ForeColor = System.Drawing.Color.Blue
        Me.txtPemakaianBahan5.Location = New System.Drawing.Point(358, 297)
        Me.txtPemakaianBahan5.Name = "txtPemakaianBahan5"
        Me.txtPemakaianBahan5.ReadOnly = True
        Me.txtPemakaianBahan5.Size = New System.Drawing.Size(68, 22)
        Me.txtPemakaianBahan5.TabIndex = 183
        Me.txtPemakaianBahan5.TabStop = False
        Me.txtPemakaianBahan5.Text = "3,000"
        Me.txtPemakaianBahan5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPemakaianBahan5.Value = 3000.0R
        '
        'txtStockBahan5
        '
        Me.txtStockBahan5.AllowEnterToMoveNext = True
        Me.txtStockBahan5.BackColor = System.Drawing.Color.White
        Me.txtStockBahan5.CheckIsValid = False
        Me.txtStockBahan5.DataFormat = "###,##0"
        Me.txtStockBahan5.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtStockBahan5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtStockBahan5.ForeColor = System.Drawing.Color.Blue
        Me.txtStockBahan5.Location = New System.Drawing.Point(290, 297)
        Me.txtStockBahan5.Name = "txtStockBahan5"
        Me.txtStockBahan5.ReadOnly = True
        Me.txtStockBahan5.Size = New System.Drawing.Size(68, 22)
        Me.txtStockBahan5.TabIndex = 182
        Me.txtStockBahan5.TabStop = False
        Me.txtStockBahan5.Text = "3,000"
        Me.txtStockBahan5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStockBahan5.Value = 3000.0R
        '
        'txtKodeItemBahan5
        '
        Me.txtKodeItemBahan5.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan5.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeItemBahan5.Location = New System.Drawing.Point(189, 297)
        Me.txtKodeItemBahan5.Name = "txtKodeItemBahan5"
        Me.txtKodeItemBahan5.ReadOnly = True
        Me.txtKodeItemBahan5.Size = New System.Drawing.Size(93, 22)
        Me.txtKodeItemBahan5.TabIndex = 181
        Me.txtKodeItemBahan5.TabStop = False
        Me.txtKodeItemBahan5.Text = "1234567890"
        '
        'txtKodeProduksiBahan5
        '
        Me.txtKodeProduksiBahan5.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtKodeProduksiBahan5.Location = New System.Drawing.Point(32, 297)
        Me.txtKodeProduksiBahan5.Name = "txtKodeProduksiBahan5"
        Me.txtKodeProduksiBahan5.Size = New System.Drawing.Size(129, 22)
        Me.txtKodeProduksiBahan5.TabIndex = 180
        Me.txtKodeProduksiBahan5.Text = "123456789012345"
        '
        'frmProduksiRewind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 676)
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
        Me.Name = "frmProduksiRewind"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi | Roll To Roll Rewind"
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
    Friend WithEvents txtHasilTimbang As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtHasilMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboKodeUnitPeruntukan As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents btTimbangHasilProduksi As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents lblKodeItemHasilProduksi As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblKodeUnitProduksi As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalSisaBahan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalPemakaianBahan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTotalStockBahan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents lblNamaItemBahan2 As System.Windows.Forms.Label
    Private WithEvents lblNamaItemBahan1 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtSisaBahan2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahan2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahan2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan2 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan2 As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtSisaBahan1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahan1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahan1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan1 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan1 As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lblKodeLokasiHasilProduksi As System.Windows.Forms.Label
    Private WithEvents btReprint As System.Windows.Forms.Button
    Private WithEvents btLookupKodeProduksiBahan1 As System.Windows.Forms.Button
    Private WithEvents btLookupKodeProduksiBahan2 As System.Windows.Forms.Button
    Friend WithEvents txtNIKOperator As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNamaOperator As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents btLookupKodeProduksiBahan4 As System.Windows.Forms.Button
    Private WithEvents lblNamaItemBahan4 As System.Windows.Forms.Label
    Private WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSisaBahan4 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahan4 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahan4 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan4 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan4 As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents btLookupKodeProduksiBahan3 As System.Windows.Forms.Button
    Private WithEvents lblNamaItemBahan3 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSisaBahan3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahan3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahan3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan3 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan3 As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents btLookupKodeProduksiBahan5 As System.Windows.Forms.Button
    Private WithEvents lblNamaItemBahan5 As System.Windows.Forms.Label
    Private WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSisaBahan5 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtPemakaianBahan5 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtStockBahan5 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan5 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan5 As Enerzie.EPSBasicControls.EPSTextBox
End Class
