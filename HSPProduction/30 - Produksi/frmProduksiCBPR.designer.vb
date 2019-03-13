<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiCBPR
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btLookupNomorSPK = New System.Windows.Forms.Button()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboNomorSPK = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.PortTimbangan = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrStabil = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btLookupKodeProduksiBahan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKilogram = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblNamaItemBahan = New System.Windows.Forms.Label()
        Me.txtMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKodeItemBahan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiBahan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(951, 151)
        Me.Panel1.TabIndex = 0
        '
        'lblKodeUnitProduksi
        '
        Me.lblKodeUnitProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeUnitProduksi.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblKodeUnitProduksi.ForeColor = System.Drawing.Color.Yellow
        Me.lblKodeUnitProduksi.Location = New System.Drawing.Point(533, 16)
        Me.lblKodeUnitProduksi.Name = "lblKodeUnitProduksi"
        Me.lblKodeUnitProduksi.Size = New System.Drawing.Size(407, 28)
        Me.lblKodeUnitProduksi.TabIndex = 96
        Me.lblKodeUnitProduksi.Text = "UNIT PRODUKSI"
        Me.lblKodeUnitProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKodeLokasiHasilProduksi
        '
        Me.lblKodeLokasiHasilProduksi.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeLokasiHasilProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeLokasiHasilProduksi.ForeColor = System.Drawing.Color.Red
        Me.lblKodeLokasiHasilProduksi.Location = New System.Drawing.Point(541, 46)
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
        Me.lblNamaItemHasilProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemHasilProduksi.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemHasilProduksi.Location = New System.Drawing.Point(268, 111)
        Me.lblNamaItemHasilProduksi.Name = "lblNamaItemHasilProduksi"
        Me.lblNamaItemHasilProduksi.Size = New System.Drawing.Size(90, 23)
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
        Me.lblTransaksi.Size = New System.Drawing.Size(260, 32)
        Me.lblTransaksi.TabIndex = 84
        Me.lblTransaksi.Text = "PEMAKAIAN ROLL"
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
        Me.Label2.Size = New System.Drawing.Size(965, 1)
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
        Me.Panel3.Location = New System.Drawing.Point(0, 386)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(951, 54)
        Me.Panel3.TabIndex = 3
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(951, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(763, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(852, 10)
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
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboKodeMesin)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btLookupNomorSPK)
        Me.GroupBox1.Controls.Add(Me.cboKodeGrup)
        Me.GroupBox1.Controls.Add(Me.cboNomorSPK)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 189)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "No.SPK / WO"
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
        'btLookupNomorSPK
        '
        Me.btLookupNomorSPK.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupNomorSPK.Location = New System.Drawing.Point(392, 108)
        Me.btLookupNomorSPK.Name = "btLookupNomorSPK"
        Me.btLookupNomorSPK.Size = New System.Drawing.Size(34, 28)
        Me.btLookupNomorSPK.TabIndex = 95
        Me.btLookupNomorSPK.TabStop = False
        Me.btLookupNomorSPK.Text = "..."
        Me.btLookupNomorSPK.UseVisualStyleBackColor = True
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
        Me.cboNomorSPK.Location = New System.Drawing.Point(113, 109)
        Me.cboNomorSPK.Name = "cboNomorSPK"
        Me.cboNomorSPK.Size = New System.Drawing.Size(278, 26)
        Me.cboNomorSPK.TabIndex = 0
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
        Me.Label7.Size = New System.Drawing.Size(460, 27)
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
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btLookupKodeProduksiBahan)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtKilogram)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.lblNamaItemBahan)
        Me.GroupBox4.Controls.Add(Me.txtMeter)
        Me.GroupBox4.Controls.Add(Me.txtKodeItemBahan)
        Me.GroupBox4.Controls.Add(Me.txtKodeProduksiBahan)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(475, 191)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(460, 189)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'btLookupKodeProduksiBahan
        '
        Me.btLookupKodeProduksiBahan.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupKodeProduksiBahan.Location = New System.Drawing.Point(159, 61)
        Me.btLookupKodeProduksiBahan.Name = "btLookupKodeProduksiBahan"
        Me.btLookupKodeProduksiBahan.Size = New System.Drawing.Size(22, 25)
        Me.btLookupKodeProduksiBahan.TabIndex = 171
        Me.btLookupKodeProduksiBahan.TabStop = False
        Me.btLookupKodeProduksiBahan.Text = "..."
        Me.btLookupKodeProduksiBahan.UseVisualStyleBackColor = True
        Me.btLookupKodeProduksiBahan.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "KG"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKilogram
        '
        Me.txtKilogram.AllowEnterToMoveNext = True
        Me.txtKilogram.BackColor = System.Drawing.Color.White
        Me.txtKilogram.CheckIsValid = False
        Me.txtKilogram.DataFormat = "###,##0"
        Me.txtKilogram.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtKilogram.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtKilogram.ForeColor = System.Drawing.Color.Blue
        Me.txtKilogram.Location = New System.Drawing.Point(337, 151)
        Me.txtKilogram.Name = "txtKilogram"
        Me.txtKilogram.ReadOnly = True
        Me.txtKilogram.Size = New System.Drawing.Size(108, 32)
        Me.txtKilogram.TabIndex = 3
        Me.txtKilogram.TabStop = False
        Me.txtKilogram.Text = "3,000"
        Me.txtKilogram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKilogram.Value = 3000.0R
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "METER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(184, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 18)
        Me.Label29.TabIndex = 166
        Me.Label29.Text = "KODE ITEM"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNamaItemBahan
        '
        Me.lblNamaItemBahan.AutoSize = True
        Me.lblNamaItemBahan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaItemBahan.ForeColor = System.Drawing.Color.Red
        Me.lblNamaItemBahan.Location = New System.Drawing.Point(33, 87)
        Me.lblNamaItemBahan.Name = "lblNamaItemBahan"
        Me.lblNamaItemBahan.Size = New System.Drawing.Size(288, 16)
        Me.lblNamaItemBahan.TabIndex = 152
        Me.lblNamaItemBahan.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'txtMeter
        '
        Me.txtMeter.AllowEnterToMoveNext = True
        Me.txtMeter.BackColor = System.Drawing.Color.White
        Me.txtMeter.CheckIsValid = False
        Me.txtMeter.DataFormat = "###,##0"
        Me.txtMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtMeter.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtMeter.Location = New System.Drawing.Point(337, 116)
        Me.txtMeter.Name = "txtMeter"
        Me.txtMeter.ReadOnly = True
        Me.txtMeter.Size = New System.Drawing.Size(108, 32)
        Me.txtMeter.TabIndex = 2
        Me.txtMeter.TabStop = False
        Me.txtMeter.Text = "3,000"
        Me.txtMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMeter.Value = 3000.0R
        '
        'txtKodeItemBahan
        '
        Me.txtKodeItemBahan.AllowEnterToMoveNext = True
        Me.txtKodeItemBahan.BackColor = System.Drawing.Color.White
        Me.txtKodeItemBahan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeItemBahan.Location = New System.Drawing.Point(187, 62)
        Me.txtKodeItemBahan.Name = "txtKodeItemBahan"
        Me.txtKodeItemBahan.ReadOnly = True
        Me.txtKodeItemBahan.Size = New System.Drawing.Size(258, 22)
        Me.txtKodeItemBahan.TabIndex = 1
        Me.txtKodeItemBahan.TabStop = False
        Me.txtKodeItemBahan.Text = "1234567890"
        '
        'txtKodeProduksiBahan
        '
        Me.txtKodeProduksiBahan.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiBahan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProduksiBahan.Location = New System.Drawing.Point(36, 62)
        Me.txtKodeProduksiBahan.Name = "txtKodeProduksiBahan"
        Me.txtKodeProduksiBahan.Size = New System.Drawing.Size(123, 22)
        Me.txtKodeProduksiBahan.TabIndex = 0
        Me.txtKodeProduksiBahan.Text = "123456789012345"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(33, 24)
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
        Me.Label6.Location = New System.Drawing.Point(1, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(469, 51)
        Me.Label6.TabIndex = 132
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProduksiCBPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 440)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduksiCBPR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi | Pemakaian Roll Bahan Karung Semen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Private WithEvents lblNamaItemHasilProduksi As System.Windows.Forms.Label
    Private WithEvents btLookupNomorSPK As System.Windows.Forms.Button
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents cboNomorSPK As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents PortTimbangan As System.IO.Ports.SerialPort
    Friend WithEvents tmrStabil As System.Windows.Forms.Timer
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents lblKodeItemHasilProduksi As System.Windows.Forms.Label
    Private WithEvents lblKodeUnitProduksi As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents lblNamaItemBahan As System.Windows.Forms.Label
    Friend WithEvents txtMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeItemBahan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiBahan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lblKodeLokasiHasilProduksi As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKilogram As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btLookupKodeProduksiBahan As System.Windows.Forms.Button
End Class
