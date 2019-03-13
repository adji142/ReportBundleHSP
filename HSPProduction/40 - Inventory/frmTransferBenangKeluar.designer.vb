<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferBenangKeluar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTanggal = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.chkShiftSebelumnya = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKodeShift = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNoPermintaan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTglPermintaan = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboUnitProduksi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQtyBon = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyRealisasi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtySisa = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtJumlahBox = New System.Windows.Forms.Label()
        Me.txtTotalTimbang = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Grid1 = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.KodeProduksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeratNetto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grid2 = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.KodeProduksiWrong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemWrong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalBobin = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLokasiAsal = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtLokasiTujuan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.CountValid = New System.Windows.Forms.Label()
        Me.CountInvalid = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(114, 22)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(121, 23)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Nomor Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(346, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Tanggal"
        '
        'txtTanggal
        '
        Me.txtTanggal.AllowEnterToMoveNext = True
        Me.txtTanggal.CustomFormat = "dd/MM/yyyy"
        Me.txtTanggal.Enabled = False
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(399, 22)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(91, 23)
        Me.txtTanggal.TabIndex = 1
        '
        'chkShiftSebelumnya
        '
        Me.chkShiftSebelumnya.AllowEnterToMoveNext = True
        Me.chkShiftSebelumnya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShiftSebelumnya.AutoSize = True
        Me.chkShiftSebelumnya.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShiftSebelumnya.ForeColor = System.Drawing.Color.Navy
        Me.chkShiftSebelumnya.Location = New System.Drawing.Point(114, 75)
        Me.chkShiftSebelumnya.Name = "chkShiftSebelumnya"
        Me.chkShiftSebelumnya.Size = New System.Drawing.Size(121, 20)
        Me.chkShiftSebelumnya.TabIndex = 3
        Me.chkShiftSebelumnya.TabStop = False
        Me.chkShiftSebelumnya.Text = "Shift Sebelumnya"
        Me.chkShiftSebelumnya.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Grup"
        '
        'cboGrup
        '
        Me.cboGrup.AllowEnterToMoveNext = True
        Me.cboGrup.DataLocked = False
        Me.cboGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrup.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrup.FormattingEnabled = True
        Me.cboGrup.IndexLocked = False
        Me.cboGrup.Location = New System.Drawing.Point(114, 51)
        Me.cboGrup.Name = "cboGrup"
        Me.cboGrup.Size = New System.Drawing.Size(121, 24)
        Me.cboGrup.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtKodeShift)
        Me.Panel2.Location = New System.Drawing.Point(241, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 50)
        Me.Panel2.TabIndex = 130
        '
        'txtKodeShift
        '
        Me.txtKodeShift.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeShift.ForeColor = System.Drawing.Color.Yellow
        Me.txtKodeShift.Location = New System.Drawing.Point(7, -5)
        Me.txtKodeShift.Name = "txtKodeShift"
        Me.txtKodeShift.Size = New System.Drawing.Size(74, 46)
        Me.txtKodeShift.TabIndex = 122
        Me.txtKodeShift.Text = "3"
        Me.txtKodeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.Color.Navy
        Me.lblShift.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.ForeColor = System.Drawing.Color.White
        Me.lblShift.Location = New System.Drawing.Point(241, 22)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(82, 20)
        Me.lblShift.TabIndex = 129
        Me.lblShift.Text = " SHIFT"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Location = New System.Drawing.Point(-22, 153)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(978, 4)
        Me.pictureBox2.TabIndex = 131
        Me.pictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(514, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(4, 140)
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'txtNoPermintaan
        '
        Me.txtNoPermintaan.AllowEnterToMoveNext = True
        Me.txtNoPermintaan.BackColor = System.Drawing.Color.White
        Me.txtNoPermintaan.Location = New System.Drawing.Point(656, 22)
        Me.txtNoPermintaan.Name = "txtNoPermintaan"
        Me.txtNoPermintaan.ReadOnly = True
        Me.txtNoPermintaan.Size = New System.Drawing.Size(115, 23)
        Me.txtNoPermintaan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(536, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "No. Permintaan"
        '
        'txtTglPermintaan
        '
        Me.txtTglPermintaan.AllowEnterToMoveNext = True
        Me.txtTglPermintaan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPermintaan.Enabled = False
        Me.txtTglPermintaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPermintaan.Location = New System.Drawing.Point(847, 22)
        Me.txtTglPermintaan.Name = "txtTglPermintaan"
        Me.txtTglPermintaan.Size = New System.Drawing.Size(91, 23)
        Me.txtTglPermintaan.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(794, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Tanggal"
        '
        'cboUnitProduksi
        '
        Me.cboUnitProduksi.AllowEnterToMoveNext = True
        Me.cboUnitProduksi.DataLocked = True
        Me.cboUnitProduksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUnitProduksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboUnitProduksi.FormattingEnabled = True
        Me.cboUnitProduksi.IndexLocked = True
        Me.cboUnitProduksi.Location = New System.Drawing.Point(656, 51)
        Me.cboUnitProduksi.Name = "cboUnitProduksi"
        Me.cboUnitProduksi.Size = New System.Drawing.Size(282, 24)
        Me.cboUnitProduksi.TabIndex = 6
        Me.cboUnitProduksi.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(536, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "U/ Unit Produksi"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(656, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 19)
        Me.Label7.TabIndex = 140
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(656, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "BON"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(752, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "REALISASI"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(848, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 16)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "SISA"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtyBon
        '
        Me.txtQtyBon.AllowEnterToMoveNext = True
        Me.txtQtyBon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyBon.CheckIsValid = True
        Me.txtQtyBon.DataFormat = "###,##0.00"
        Me.txtQtyBon.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyBon.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyBon.Location = New System.Drawing.Point(656, 104)
        Me.txtQtyBon.Name = "txtQtyBon"
        Me.txtQtyBon.ReadOnly = True
        Me.txtQtyBon.Size = New System.Drawing.Size(90, 30)
        Me.txtQtyBon.TabIndex = 7
        Me.txtQtyBon.TabStop = False
        Me.txtQtyBon.Text = "1.20"
        Me.txtQtyBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyBon.Value = 1.2R
        '
        'txtQtyRealisasi
        '
        Me.txtQtyRealisasi.AllowEnterToMoveNext = True
        Me.txtQtyRealisasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyRealisasi.CheckIsValid = True
        Me.txtQtyRealisasi.DataFormat = "###,##0.00"
        Me.txtQtyRealisasi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyRealisasi.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyRealisasi.Location = New System.Drawing.Point(752, 104)
        Me.txtQtyRealisasi.Name = "txtQtyRealisasi"
        Me.txtQtyRealisasi.ReadOnly = True
        Me.txtQtyRealisasi.Size = New System.Drawing.Size(90, 30)
        Me.txtQtyRealisasi.TabIndex = 8
        Me.txtQtyRealisasi.TabStop = False
        Me.txtQtyRealisasi.Text = "1.20"
        Me.txtQtyRealisasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyRealisasi.Value = 1.2R
        '
        'txtQtySisa
        '
        Me.txtQtySisa.AllowEnterToMoveNext = True
        Me.txtQtySisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtySisa.CheckIsValid = True
        Me.txtQtySisa.DataFormat = "###,##0.00"
        Me.txtQtySisa.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtySisa.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtySisa.Location = New System.Drawing.Point(848, 104)
        Me.txtQtySisa.Name = "txtQtySisa"
        Me.txtQtySisa.ReadOnly = True
        Me.txtQtySisa.Size = New System.Drawing.Size(90, 30)
        Me.txtQtySisa.TabIndex = 9
        Me.txtQtySisa.TabStop = False
        Me.txtQtySisa.Text = "1.20"
        Me.txtQtySisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtySisa.Value = 1.2R
        '
        'txtItem
        '
        Me.txtItem.AllowEnterToMoveNext = True
        Me.txtItem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtItem.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.Color.White
        Me.txtItem.Location = New System.Drawing.Point(15, 104)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(475, 30)
        Me.txtItem.TabIndex = 147
        Me.txtItem.TabStop = False
        Me.txtItem.Text = ">> 575 PT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(12, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 16)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Lokasi Asal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(12, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Lokasi Tujuan"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(-22, 259)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(978, 4)
        Me.PictureBox3.TabIndex = 153
        Me.PictureBox3.TabStop = False
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.BackColor = System.Drawing.Color.Black
        Me.txtKodeProduksi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProduksi.ForeColor = System.Drawing.Color.White
        Me.txtKodeProduksi.Location = New System.Drawing.Point(114, 277)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(209, 26)
        Me.txtKodeProduksi.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(12, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Kode Produksi"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 636)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(959, 54)
        Me.Panel6.TabIndex = 17
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(959, 4)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(766, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(855, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtJumlahBox)
        Me.Panel1.Location = New System.Drawing.Point(729, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 129)
        Me.Panel1.TabIndex = 158
        '
        'txtJumlahBox
        '
        Me.txtJumlahBox.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahBox.ForeColor = System.Drawing.Color.Yellow
        Me.txtJumlahBox.Location = New System.Drawing.Point(3, -5)
        Me.txtJumlahBox.Name = "txtJumlahBox"
        Me.txtJumlahBox.Size = New System.Drawing.Size(205, 133)
        Me.txtJumlahBox.TabIndex = 122
        Me.txtJumlahBox.Text = "3"
        Me.txtJumlahBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalTimbang
        '
        Me.txtTotalTimbang.AllowEnterToMoveNext = True
        Me.txtTotalTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalTimbang.CheckIsValid = False
        Me.txtTotalTimbang.DataFormat = "###,##0.00"
        Me.txtTotalTimbang.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalTimbang.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalTimbang.Location = New System.Drawing.Point(613, 575)
        Me.txtTotalTimbang.Name = "txtTotalTimbang"
        Me.txtTotalTimbang.ReadOnly = True
        Me.txtTotalTimbang.Size = New System.Drawing.Size(87, 34)
        Me.txtTotalTimbang.TabIndex = 16
        Me.txtTotalTimbang.TabStop = False
        Me.txtTotalTimbang.Text = "1.20"
        Me.txtTotalTimbang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalTimbang.Value = 1.2R
        '
        'Grid1
        '
        Me.Grid1.AllowUserToAddRows = False
        Me.Grid1.AllowUserToDeleteRows = False
        Me.Grid1.AllowUserToResizeColumns = False
        Me.Grid1.AllowUserToResizeRows = False
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid1.ColumnHeadersHeight = 35
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeProduksi, Me.NamaItem, Me.Area, Me.Status, Me.Jumlah, Me.BeratNetto})
        Me.Grid1.EnableHeadersVisualStyles = False
        Me.Grid1.Location = New System.Drawing.Point(15, 309)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RowHeadersVisible = False
        Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid1.Size = New System.Drawing.Size(708, 263)
        Me.Grid1.TabIndex = 13
        '
        'KodeProduksi
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeProduksi.DefaultCellStyle = DataGridViewCellStyle2
        Me.KodeProduksi.HeaderText = "KODE PRODUKSI"
        Me.KodeProduksi.Name = "KodeProduksi"
        Me.KodeProduksi.ReadOnly = True
        Me.KodeProduksi.Width = 125
        '
        'NamaItem
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.NamaItem.HeaderText = "ITEM"
        Me.NamaItem.Name = "NamaItem"
        Me.NamaItem.ReadOnly = True
        Me.NamaItem.Width = 200
        '
        'Area
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Area.DefaultCellStyle = DataGridViewCellStyle4
        Me.Area.HeaderText = "AREA"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        Me.Area.Width = 110
        '
        'Status
        '
        Me.Status.HeaderText = "STATUS"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 80
        '
        'Jumlah
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jumlah.DefaultCellStyle = DataGridViewCellStyle5
        Me.Jumlah.HeaderText = "JUMLAH"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.Width = 80
        '
        'BeratNetto
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeratNetto.DefaultCellStyle = DataGridViewCellStyle6
        Me.BeratNetto.HeaderText = "BERAT NET"
        Me.BeratNetto.Name = "BeratNetto"
        Me.BeratNetto.ReadOnly = True
        Me.BeratNetto.Width = 90
        '
        'Grid2
        '
        Me.Grid2.AllowUserToAddRows = False
        Me.Grid2.AllowUserToDeleteRows = False
        Me.Grid2.AllowUserToResizeColumns = False
        Me.Grid2.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red
        Me.Grid2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Grid2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Grid2.ColumnHeadersHeight = 35
        Me.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeProduksiWrong, Me.ItemWrong})
        Me.Grid2.EnableHeadersVisualStyles = False
        Me.Grid2.Location = New System.Drawing.Point(729, 309)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.RowHeadersVisible = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red
        Me.Grid2.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid2.Size = New System.Drawing.Size(209, 263)
        Me.Grid2.TabIndex = 14
        '
        'KodeProduksiWrong
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeProduksiWrong.DefaultCellStyle = DataGridViewCellStyle9
        Me.KodeProduksiWrong.HeaderText = "KODE"
        Me.KodeProduksiWrong.Name = "KodeProduksiWrong"
        Me.KodeProduksiWrong.ReadOnly = True
        '
        'ItemWrong
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemWrong.DefaultCellStyle = DataGridViewCellStyle10
        Me.ItemWrong.HeaderText = "ITEM"
        Me.ItemWrong.Name = "ItemWrong"
        Me.ItemWrong.ReadOnly = True
        Me.ItemWrong.Width = 90
        '
        'txtTotalBobin
        '
        Me.txtTotalBobin.AllowEnterToMoveNext = True
        Me.txtTotalBobin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalBobin.CheckIsValid = False
        Me.txtTotalBobin.DataFormat = "###,##0.00"
        Me.txtTotalBobin.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalBobin.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBobin.Location = New System.Drawing.Point(531, 575)
        Me.txtTotalBobin.Name = "txtTotalBobin"
        Me.txtTotalBobin.ReadOnly = True
        Me.txtTotalBobin.Size = New System.Drawing.Size(81, 34)
        Me.txtTotalBobin.TabIndex = 15
        Me.txtTotalBobin.TabStop = False
        Me.txtTotalBobin.Text = "1.20"
        Me.txtTotalBobin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalBobin.Value = 1.2R
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(463, 586)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 16)
        Me.Label15.TabIndex = 163
        Me.Label15.Text = "Total : "
        '
        'txtLokasiAsal
        '
        Me.txtLokasiAsal.AllowEnterToMoveNext = True
        Me.txtLokasiAsal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLokasiAsal.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLokasiAsal.ForeColor = System.Drawing.Color.Navy
        Me.txtLokasiAsal.Location = New System.Drawing.Point(114, 174)
        Me.txtLokasiAsal.Name = "txtLokasiAsal"
        Me.txtLokasiAsal.ReadOnly = True
        Me.txtLokasiAsal.Size = New System.Drawing.Size(609, 30)
        Me.txtLokasiAsal.TabIndex = 164
        Me.txtLokasiAsal.TabStop = False
        Me.txtLokasiAsal.Text = ">> 575 PT"
        '
        'txtLokasiTujuan
        '
        Me.txtLokasiTujuan.AllowEnterToMoveNext = True
        Me.txtLokasiTujuan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLokasiTujuan.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLokasiTujuan.ForeColor = System.Drawing.Color.Red
        Me.txtLokasiTujuan.Location = New System.Drawing.Point(114, 210)
        Me.txtLokasiTujuan.Name = "txtLokasiTujuan"
        Me.txtLokasiTujuan.ReadOnly = True
        Me.txtLokasiTujuan.Size = New System.Drawing.Size(609, 30)
        Me.txtLokasiTujuan.TabIndex = 165
        Me.txtLokasiTujuan.TabStop = False
        Me.txtLokasiTujuan.Text = ">> 575 PT"
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'CountValid
        '
        Me.CountValid.AutoSize = True
        Me.CountValid.Location = New System.Drawing.Point(12, 575)
        Me.CountValid.Name = "CountValid"
        Me.CountValid.Size = New System.Drawing.Size(29, 17)
        Me.CountValid.TabIndex = 166
        Me.CountValid.Text = "Item"
        '
        'CountInvalid
        '
        Me.CountInvalid.AutoSize = True
        Me.CountInvalid.Location = New System.Drawing.Point(726, 575)
        Me.CountInvalid.Name = "CountInvalid"
        Me.CountInvalid.Size = New System.Drawing.Size(29, 17)
        Me.CountInvalid.TabIndex = 167
        Me.CountInvalid.Text = "Item"
        '
        'frmTransferBenangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 690)
        Me.Controls.Add(Me.CountInvalid)
        Me.Controls.Add(Me.CountValid)
        Me.Controls.Add(Me.txtLokasiTujuan)
        Me.Controls.Add(Me.txtLokasiAsal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotalBobin)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.txtTotalTimbang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtQtySisa)
        Me.Controls.Add(Me.txtQtyRealisasi)
        Me.Controls.Add(Me.txtQtyBon)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboUnitProduksi)
        Me.Controls.Add(Me.txtTglPermintaan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoPermintaan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.cboGrup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkShiftSebelumnya)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferBenangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Benang Keluar"
        Me.Panel2.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents chkShiftSebelumnya As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeShift As System.Windows.Forms.Label
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNoPermintaan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTglPermintaan As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboUnitProduksi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQtyBon As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyRealisasi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtySisa As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtJumlahBox As System.Windows.Forms.Label
    Friend WithEvents txtTotalTimbang As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Grid1 As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents Grid2 As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents txtTotalBobin As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLokasiAsal As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtLokasiTujuan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents CountValid As System.Windows.Forms.Label
    Friend WithEvents CountInvalid As System.Windows.Forms.Label
    Friend WithEvents KodeProduksiWrong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemWrong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeProduksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeratNetto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
