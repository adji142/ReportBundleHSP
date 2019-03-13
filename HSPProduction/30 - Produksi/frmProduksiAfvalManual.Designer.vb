<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiAfvalManual
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTglTimbang = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblMesin = New System.Windows.Forms.Label()
        Me.cboItemAfval = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btLookupItemAfval = New System.Windows.Forms.Button()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboKodeShift = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.cboMediaTimbang = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btLookupMediaTimbang = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBeratBrutto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBeratNetto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.cboNomorWO = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblNomorWO = New System.Windows.Forms.Label()
        Me.btLookupNomorWO = New System.Windows.Forms.Button()
        Me.lblLokasi = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(103, 19)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tgl. Timbang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tgl. Produksi"
        '
        'txtTglTimbang
        '
        Me.txtTglTimbang.AllowEnterToMoveNext = True
        Me.txtTglTimbang.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.txtTglTimbang.Enabled = False
        Me.txtTglTimbang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTimbang.Location = New System.Drawing.Point(103, 90)
        Me.txtTglTimbang.Name = "txtTglTimbang"
        Me.txtTglTimbang.Size = New System.Drawing.Size(143, 20)
        Me.txtTglTimbang.TabIndex = 1
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(444, 90)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtTglTransaksi.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Unit Produksi"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(103, 115)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(250, 21)
        Me.cboKodeUnit.TabIndex = 3
        '
        'cboKodeMesin
        '
        Me.cboKodeMesin.AllowEnterToMoveNext = True
        Me.cboKodeMesin.DataLocked = False
        Me.cboKodeMesin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMesin.FormattingEnabled = True
        Me.cboKodeMesin.IndexLocked = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(103, 141)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(250, 21)
        Me.cboKodeMesin.TabIndex = 5
        '
        'lblMesin
        '
        Me.lblMesin.AutoSize = True
        Me.lblMesin.Location = New System.Drawing.Point(12, 144)
        Me.lblMesin.Name = "lblMesin"
        Me.lblMesin.Size = New System.Drawing.Size(79, 13)
        Me.lblMesin.TabIndex = 9
        Me.lblMesin.Text = "Mesin Produksi"
        '
        'cboItemAfval
        '
        Me.cboItemAfval.AllowEnterToMoveNext = True
        Me.cboItemAfval.DataLocked = False
        Me.cboItemAfval.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboItemAfval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemAfval.FormattingEnabled = True
        Me.cboItemAfval.IndexLocked = False
        Me.cboItemAfval.Location = New System.Drawing.Point(103, 167)
        Me.cboItemAfval.Name = "cboItemAfval"
        Me.cboItemAfval.Size = New System.Drawing.Size(554, 21)
        Me.cboItemAfval.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Item Afval"
        '
        'btLookupItemAfval
        '
        Me.btLookupItemAfval.Location = New System.Drawing.Point(659, 166)
        Me.btLookupItemAfval.Name = "btLookupItemAfval"
        Me.btLookupItemAfval.Size = New System.Drawing.Size(25, 23)
        Me.btLookupItemAfval.TabIndex = 13
        Me.btLookupItemAfval.TabStop = False
        Me.btLookupItemAfval.Text = "..."
        Me.btLookupItemAfval.UseVisualStyleBackColor = True
        '
        'cboKodeGrup
        '
        Me.cboKodeGrup.AllowEnterToMoveNext = True
        Me.cboKodeGrup.DataLocked = False
        Me.cboKodeGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeGrup.FormattingEnabled = True
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(444, 193)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(240, 21)
        Me.cboKodeGrup.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Group Produksi"
        '
        'cboKodeShift
        '
        Me.cboKodeShift.AllowEnterToMoveNext = True
        Me.cboKodeShift.DataLocked = False
        Me.cboKodeShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeShift.FormattingEnabled = True
        Me.cboKodeShift.IndexLocked = False
        Me.cboKodeShift.Location = New System.Drawing.Point(103, 193)
        Me.cboKodeShift.Name = "cboKodeShift"
        Me.cboKodeShift.Size = New System.Drawing.Size(250, 21)
        Me.cboKodeShift.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Shift Produksi"
        '
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(103, 220)
        Me.chkShiftSebelumnya.Name = "chkShiftSebelumnya"
        Me.chkShiftSebelumnya.Size = New System.Drawing.Size(108, 17)
        Me.chkShiftSebelumnya.TabIndex = 9
        Me.chkShiftSebelumnya.Text = "Shift Sebelumnya"
        Me.chkShiftSebelumnya.UseVisualStyleBackColor = True
        '
        'cboMediaTimbang
        '
        Me.cboMediaTimbang.AllowEnterToMoveNext = True
        Me.cboMediaTimbang.DataLocked = False
        Me.cboMediaTimbang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMediaTimbang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMediaTimbang.FormattingEnabled = True
        Me.cboMediaTimbang.IndexLocked = False
        Me.cboMediaTimbang.Location = New System.Drawing.Point(103, 243)
        Me.cboMediaTimbang.Name = "cboMediaTimbang"
        Me.cboMediaTimbang.Size = New System.Drawing.Size(554, 21)
        Me.cboMediaTimbang.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Media Timbang"
        '
        'btLookupMediaTimbang
        '
        Me.btLookupMediaTimbang.Location = New System.Drawing.Point(659, 242)
        Me.btLookupMediaTimbang.Name = "btLookupMediaTimbang"
        Me.btLookupMediaTimbang.Size = New System.Drawing.Size(25, 23)
        Me.btLookupMediaTimbang.TabIndex = 21
        Me.btLookupMediaTimbang.TabStop = False
        Me.btLookupMediaTimbang.Text = "..."
        Me.btLookupMediaTimbang.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Berat Brutto"
        '
        'txtBeratBrutto
        '
        Me.txtBeratBrutto.AllowEnterToMoveNext = True
        Me.txtBeratBrutto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtBeratBrutto.CheckIsValid = False
        Me.txtBeratBrutto.DataFormat = "###,##0.00"
        Me.txtBeratBrutto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratBrutto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratBrutto.ForeColor = System.Drawing.Color.Red
        Me.txtBeratBrutto.Location = New System.Drawing.Point(103, 269)
        Me.txtBeratBrutto.Name = "txtBeratBrutto"
        Me.txtBeratBrutto.Size = New System.Drawing.Size(100, 20)
        Me.txtBeratBrutto.TabIndex = 11
        Me.txtBeratBrutto.Text = "0.00"
        Me.txtBeratBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratBrutto.Value = 0.0R
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.BackColor = System.Drawing.Color.White
        Me.txtBeratMedia.CheckIsValid = False
        Me.txtBeratMedia.DataFormat = "###,##0.00"
        Me.txtBeratMedia.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratMedia.Location = New System.Drawing.Point(103, 294)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.ReadOnly = True
        Me.txtBeratMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtBeratMedia.TabIndex = 12
        Me.txtBeratMedia.TabStop = False
        Me.txtBeratMedia.Text = "0.00"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia.Value = 0.0R
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Berat Media"
        '
        'txtBeratNetto
        '
        Me.txtBeratNetto.AllowEnterToMoveNext = True
        Me.txtBeratNetto.BackColor = System.Drawing.Color.White
        Me.txtBeratNetto.CheckIsValid = False
        Me.txtBeratNetto.DataFormat = "###,##0.00"
        Me.txtBeratNetto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratNetto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratNetto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratNetto.Location = New System.Drawing.Point(103, 319)
        Me.txtBeratNetto.Name = "txtBeratNetto"
        Me.txtBeratNetto.ReadOnly = True
        Me.txtBeratNetto.Size = New System.Drawing.Size(100, 20)
        Me.txtBeratNetto.TabIndex = 13
        Me.txtBeratNetto.TabStop = False
        Me.txtBeratNetto.Text = "0.00"
        Me.txtBeratNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratNetto.Value = 0.0R
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Berat Netto"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(103, 344)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(581, 20)
        Me.txtKeterangan.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 347)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Keterangan"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 400)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(700, 54)
        Me.Panel6.TabIndex = 15
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(700, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(512, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(601, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'cboNomorWO
        '
        Me.cboNomorWO.AllowEnterToMoveNext = True
        Me.cboNomorWO.DataLocked = False
        Me.cboNomorWO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorWO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorWO.FormattingEnabled = True
        Me.cboNomorWO.IndexLocked = False
        Me.cboNomorWO.Location = New System.Drawing.Point(444, 115)
        Me.cboNomorWO.Name = "cboNomorWO"
        Me.cboNomorWO.Size = New System.Drawing.Size(213, 21)
        Me.cboNomorWO.TabIndex = 4
        '
        'lblNomorWO
        '
        Me.lblNomorWO.AutoSize = True
        Me.lblNomorWO.Location = New System.Drawing.Point(359, 118)
        Me.lblNomorWO.Name = "lblNomorWO"
        Me.lblNomorWO.Size = New System.Drawing.Size(60, 13)
        Me.lblNomorWO.TabIndex = 38
        Me.lblNomorWO.Text = "Nomor WO"
        '
        'btLookupNomorWO
        '
        Me.btLookupNomorWO.Location = New System.Drawing.Point(659, 114)
        Me.btLookupNomorWO.Name = "btLookupNomorWO"
        Me.btLookupNomorWO.Size = New System.Drawing.Size(25, 23)
        Me.btLookupNomorWO.TabIndex = 39
        Me.btLookupNomorWO.TabStop = False
        Me.btLookupNomorWO.Text = "..."
        Me.btLookupNomorWO.UseVisualStyleBackColor = True
        '
        'lblLokasi
        '
        Me.lblLokasi.BackColor = System.Drawing.Color.Transparent
        Me.lblLokasi.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokasi.ForeColor = System.Drawing.Color.Navy
        Me.lblLokasi.Location = New System.Drawing.Point(205, 19)
        Me.lblLokasi.Name = "lblLokasi"
        Me.lblLokasi.Size = New System.Drawing.Size(479, 20)
        Me.lblLokasi.TabIndex = 40
        Me.lblLokasi.Text = "LOKASI AFVAL PRODUKSI"
        Me.lblLokasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 2)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 2)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Location = New System.Drawing.Point(0, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 2)
        Me.Panel3.TabIndex = 42
        '
        'lblSupervisor
        '
        Me.lblSupervisor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisor.ForeColor = System.Drawing.Color.Blue
        Me.lblSupervisor.Location = New System.Drawing.Point(15, 366)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(669, 34)
        Me.lblSupervisor.TabIndex = 53
        Me.lblSupervisor.Text = "Pembatalan Data Produksi Harus Dilakukan Oleh User Dengan Hak Supervisor"
        Me.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProduksiAfvalManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 454)
        Me.Controls.Add(Me.lblSupervisor)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblLokasi)
        Me.Controls.Add(Me.btLookupNomorWO)
        Me.Controls.Add(Me.cboNomorWO)
        Me.Controls.Add(Me.lblNomorWO)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBeratNetto)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBeratMedia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBeratBrutto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btLookupMediaTimbang)
        Me.Controls.Add(Me.cboMediaTimbang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkShiftSebelumnya)
        Me.Controls.Add(Me.cboKodeGrup)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboKodeShift)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btLookupItemAfval)
        Me.Controls.Add(Me.cboItemAfval)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboKodeMesin)
        Me.Controls.Add(Me.lblMesin)
        Me.Controls.Add(Me.cboKodeUnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.txtTglTimbang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProduksiAfvalManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Afval Produksi (Manual)"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTglTimbang As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents lblMesin As System.Windows.Forms.Label
    Friend WithEvents cboItemAfval As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btLookupItemAfval As System.Windows.Forms.Button
    Friend WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboKodeShift As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents cboMediaTimbang As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btLookupMediaTimbang As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBeratBrutto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBeratNetto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents cboNomorWO As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents lblNomorWO As System.Windows.Forms.Label
    Friend WithEvents btLookupNomorWO As System.Windows.Forms.Button
    Friend WithEvents lblLokasi As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblSupervisor As System.Windows.Forms.Label
End Class
