﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKoreksiStockBenang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoTimbang = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglTimbang = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNomorWO = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboKodeUnitAsal = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboKodeStatusLama = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboKodeArea = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboKodeMesinLama = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboKodeShift = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeGrupLama = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtQtyPacking = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyPcs = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratBrutto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratNetto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.cboKodeGrupBaru = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeMesinBaru = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboKodeStatusBaru = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtKeteranganLama = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.txtKeteranganBaru = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtAlasanPerubahan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(-20, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 4)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No. Timbang"
        '
        'txtNoTimbang
        '
        Me.txtNoTimbang.AllowEnterToMoveNext = True
        Me.txtNoTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoTimbang.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTimbang.Location = New System.Drawing.Point(135, 23)
        Me.txtNoTimbang.Name = "txtNoTimbang"
        Me.txtNoTimbang.ReadOnly = True
        Me.txtNoTimbang.Size = New System.Drawing.Size(135, 22)
        Me.txtNoTimbang.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(287, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tgl Transaksi"
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTglTransaksi.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglTransaksi.Location = New System.Drawing.Point(390, 23)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.ReadOnly = True
        Me.txtTglTransaksi.Size = New System.Drawing.Size(126, 22)
        Me.txtTglTransaksi.TabIndex = 1
        Me.txtTglTransaksi.TabStop = False
        '
        'txtTglTimbang
        '
        Me.txtTglTimbang.AllowEnterToMoveNext = True
        Me.txtTglTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTglTimbang.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglTimbang.Location = New System.Drawing.Point(625, 23)
        Me.txtTglTimbang.Name = "txtTglTimbang"
        Me.txtTglTimbang.ReadOnly = True
        Me.txtTglTimbang.Size = New System.Drawing.Size(150, 22)
        Me.txtTglTimbang.TabIndex = 2
        Me.txtTglTimbang.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(533, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tgl Timbang"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(21, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Nomor WO"
        '
        'txtNomorWO
        '
        Me.txtNomorWO.AllowEnterToMoveNext = True
        Me.txtNomorWO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomorWO.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomorWO.Location = New System.Drawing.Point(135, 76)
        Me.txtNomorWO.Name = "txtNomorWO"
        Me.txtNomorWO.ReadOnly = True
        Me.txtNomorWO.Size = New System.Drawing.Size(640, 22)
        Me.txtNomorWO.TabIndex = 5
        Me.txtNomorWO.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Kode Item"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeItem.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeItem.Location = New System.Drawing.Point(135, 103)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(640, 22)
        Me.txtKodeItem.TabIndex = 6
        Me.txtKodeItem.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Nama Item"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaItem.Location = New System.Drawing.Point(135, 130)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(640, 22)
        Me.txtNamaItem.TabIndex = 7
        Me.txtNamaItem.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Unit Produksi"
        '
        'cboKodeUnitAsal
        '
        Me.cboKodeUnitAsal.AllowEnterToMoveNext = True
        Me.cboKodeUnitAsal.DataLocked = True
        Me.cboKodeUnitAsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeUnitAsal.FormattingEnabled = True
        Me.cboKodeUnitAsal.IndexLocked = True
        Me.cboKodeUnitAsal.Location = New System.Drawing.Point(135, 157)
        Me.cboKodeUnitAsal.Name = "cboKodeUnitAsal"
        Me.cboKodeUnitAsal.Size = New System.Drawing.Size(640, 21)
        Me.cboKodeUnitAsal.TabIndex = 8
        Me.cboKodeUnitAsal.TabStop = False
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = True
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = True
        Me.cboKodeLokasi.Location = New System.Drawing.Point(135, 183)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(640, 21)
        Me.cboKodeLokasi.TabIndex = 9
        Me.cboKodeLokasi.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Lokasi Produksi"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(622, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 18)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "BERAT NETTO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(136, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 18)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "PACKING"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(298, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 18)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "PCS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(135, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(640, 22)
        Me.Label11.TabIndex = 68
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(460, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 18)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "BERAT BRUTTO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboKodeStatusLama
        '
        Me.cboKodeStatusLama.AllowEnterToMoveNext = True
        Me.cboKodeStatusLama.DataLocked = True
        Me.cboKodeStatusLama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeStatusLama.FormattingEnabled = True
        Me.cboKodeStatusLama.IndexLocked = True
        Me.cboKodeStatusLama.Items.AddRange(New Object() {"OK", "NON OK", "OVER", "UNDER"})
        Me.cboKodeStatusLama.Location = New System.Drawing.Point(625, 209)
        Me.cboKodeStatusLama.Name = "cboKodeStatusLama"
        Me.cboKodeStatusLama.Size = New System.Drawing.Size(150, 21)
        Me.cboKodeStatusLama.TabIndex = 12
        Me.cboKodeStatusLama.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(533, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Status QC"
        '
        'cboKodeArea
        '
        Me.cboKodeArea.AllowEnterToMoveNext = True
        Me.cboKodeArea.DataLocked = True
        Me.cboKodeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeArea.FormattingEnabled = True
        Me.cboKodeArea.IndexLocked = True
        Me.cboKodeArea.Location = New System.Drawing.Point(135, 209)
        Me.cboKodeArea.Name = "cboKodeArea"
        Me.cboKodeArea.Size = New System.Drawing.Size(135, 21)
        Me.cboKodeArea.TabIndex = 10
        Me.cboKodeArea.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(21, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Area Produksi"
        '
        'cboKodeMesinLama
        '
        Me.cboKodeMesinLama.AllowEnterToMoveNext = True
        Me.cboKodeMesinLama.DataLocked = True
        Me.cboKodeMesinLama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeMesinLama.FormattingEnabled = True
        Me.cboKodeMesinLama.IndexLocked = True
        Me.cboKodeMesinLama.Location = New System.Drawing.Point(390, 209)
        Me.cboKodeMesinLama.Name = "cboKodeMesinLama"
        Me.cboKodeMesinLama.Size = New System.Drawing.Size(126, 21)
        Me.cboKodeMesinLama.TabIndex = 11
        Me.cboKodeMesinLama.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(290, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 16)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "Mesin"
        '
        'cboKodeShift
        '
        Me.cboKodeShift.AllowEnterToMoveNext = True
        Me.cboKodeShift.DataLocked = True
        Me.cboKodeShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeShift.FormattingEnabled = True
        Me.cboKodeShift.IndexLocked = True
        Me.cboKodeShift.Location = New System.Drawing.Point(135, 50)
        Me.cboKodeShift.Name = "cboKodeShift"
        Me.cboKodeShift.Size = New System.Drawing.Size(135, 21)
        Me.cboKodeShift.TabIndex = 3
        Me.cboKodeShift.TabStop = False
        '
        'cboKodeGrupLama
        '
        Me.cboKodeGrupLama.AllowEnterToMoveNext = True
        Me.cboKodeGrupLama.DataLocked = True
        Me.cboKodeGrupLama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeGrupLama.FormattingEnabled = True
        Me.cboKodeGrupLama.IndexLocked = True
        Me.cboKodeGrupLama.Location = New System.Drawing.Point(390, 50)
        Me.cboKodeGrupLama.Name = "cboKodeGrupLama"
        Me.cboKodeGrupLama.Size = New System.Drawing.Size(126, 21)
        Me.cboKodeGrupLama.TabIndex = 4
        Me.cboKodeGrupLama.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(21, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Shift Produksi"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(287, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 16)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "Grup Produksi"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(21, 270)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 16)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Kuantitas"
        '
        'txtQtyPacking
        '
        Me.txtQtyPacking.AllowEnterToMoveNext = True
        Me.txtQtyPacking.BackColor = System.Drawing.Color.White
        Me.txtQtyPacking.CheckIsValid = False
        Me.txtQtyPacking.DataFormat = "###,##0.00"
        Me.txtQtyPacking.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPacking.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyPacking.Location = New System.Drawing.Point(135, 267)
        Me.txtQtyPacking.Name = "txtQtyPacking"
        Me.txtQtyPacking.ReadOnly = True
        Me.txtQtyPacking.Size = New System.Drawing.Size(151, 22)
        Me.txtQtyPacking.TabIndex = 13
        Me.txtQtyPacking.TabStop = False
        Me.txtQtyPacking.Text = "0.00"
        Me.txtQtyPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPacking.Value = 0.0R
        '
        'txtQtyPcs
        '
        Me.txtQtyPcs.AllowEnterToMoveNext = True
        Me.txtQtyPcs.BackColor = System.Drawing.Color.White
        Me.txtQtyPcs.CheckIsValid = False
        Me.txtQtyPcs.DataFormat = "###,##0.00"
        Me.txtQtyPcs.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPcs.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyPcs.Location = New System.Drawing.Point(301, 267)
        Me.txtQtyPcs.Name = "txtQtyPcs"
        Me.txtQtyPcs.ReadOnly = True
        Me.txtQtyPcs.Size = New System.Drawing.Size(147, 22)
        Me.txtQtyPcs.TabIndex = 14
        Me.txtQtyPcs.TabStop = False
        Me.txtQtyPcs.Text = "0.00"
        Me.txtQtyPcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPcs.Value = 0.0R
        '
        'txtBeratBrutto
        '
        Me.txtBeratBrutto.AllowEnterToMoveNext = True
        Me.txtBeratBrutto.BackColor = System.Drawing.Color.White
        Me.txtBeratBrutto.CheckIsValid = False
        Me.txtBeratBrutto.DataFormat = "###,##0.00"
        Me.txtBeratBrutto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratBrutto.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratBrutto.Location = New System.Drawing.Point(463, 267)
        Me.txtBeratBrutto.Name = "txtBeratBrutto"
        Me.txtBeratBrutto.ReadOnly = True
        Me.txtBeratBrutto.Size = New System.Drawing.Size(147, 22)
        Me.txtBeratBrutto.TabIndex = 15
        Me.txtBeratBrutto.TabStop = False
        Me.txtBeratBrutto.Text = "0.00"
        Me.txtBeratBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratBrutto.Value = 0.0R
        '
        'txtBeratNetto
        '
        Me.txtBeratNetto.AllowEnterToMoveNext = True
        Me.txtBeratNetto.BackColor = System.Drawing.Color.White
        Me.txtBeratNetto.CheckIsValid = False
        Me.txtBeratNetto.DataFormat = "###,##0.00"
        Me.txtBeratNetto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratNetto.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratNetto.Location = New System.Drawing.Point(625, 267)
        Me.txtBeratNetto.Name = "txtBeratNetto"
        Me.txtBeratNetto.ReadOnly = True
        Me.txtBeratNetto.Size = New System.Drawing.Size(150, 22)
        Me.txtBeratNetto.TabIndex = 16
        Me.txtBeratNetto.TabStop = False
        Me.txtBeratNetto.Text = "0.00"
        Me.txtBeratNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratNetto.Value = 0.0R
        '
        'cboKodeGrupBaru
        '
        Me.cboKodeGrupBaru.AllowEnterToMoveNext = True
        Me.cboKodeGrupBaru.DataLocked = False
        Me.cboKodeGrupBaru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeGrupBaru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeGrupBaru.FormattingEnabled = True
        Me.cboKodeGrupBaru.IndexLocked = False
        Me.cboKodeGrupBaru.Location = New System.Drawing.Point(135, 386)
        Me.cboKodeGrupBaru.Name = "cboKodeGrupBaru"
        Me.cboKodeGrupBaru.Size = New System.Drawing.Size(126, 21)
        Me.cboKodeGrupBaru.TabIndex = 18
        '
        'cboKodeMesinBaru
        '
        Me.cboKodeMesinBaru.AllowEnterToMoveNext = True
        Me.cboKodeMesinBaru.DataLocked = False
        Me.cboKodeMesinBaru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMesinBaru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMesinBaru.FormattingEnabled = True
        Me.cboKodeMesinBaru.IndexLocked = False
        Me.cboKodeMesinBaru.Location = New System.Drawing.Point(390, 386)
        Me.cboKodeMesinBaru.Name = "cboKodeMesinBaru"
        Me.cboKodeMesinBaru.Size = New System.Drawing.Size(126, 21)
        Me.cboKodeMesinBaru.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(290, 388)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 16)
        Me.Label20.TabIndex = 90
        Me.Label20.Text = "Mesin"
        '
        'cboKodeStatusBaru
        '
        Me.cboKodeStatusBaru.AllowEnterToMoveNext = True
        Me.cboKodeStatusBaru.DataLocked = False
        Me.cboKodeStatusBaru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeStatusBaru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeStatusBaru.FormattingEnabled = True
        Me.cboKodeStatusBaru.IndexLocked = False
        Me.cboKodeStatusBaru.Items.AddRange(New Object() {"OK", "NON OK", "OVER", "UNDER", "-"})
        Me.cboKodeStatusBaru.Location = New System.Drawing.Point(625, 386)
        Me.cboKodeStatusBaru.Name = "cboKodeStatusBaru"
        Me.cboKodeStatusBaru.Size = New System.Drawing.Size(150, 21)
        Me.cboKodeStatusBaru.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(533, 388)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 16)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = "Status QC"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(21, 297)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 16)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Keterangan"
        '
        'txtKeteranganLama
        '
        Me.txtKeteranganLama.AllowEnterToMoveNext = True
        Me.txtKeteranganLama.BackColor = System.Drawing.Color.White
        Me.txtKeteranganLama.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeteranganLama.Location = New System.Drawing.Point(135, 294)
        Me.txtKeteranganLama.Name = "txtKeteranganLama"
        Me.txtKeteranganLama.ReadOnly = True
        Me.txtKeteranganLama.Size = New System.Drawing.Size(640, 22)
        Me.txtKeteranganLama.TabIndex = 17
        Me.txtKeteranganLama.TabStop = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(-1, 360)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(802, 22)
        Me.Label23.TabIndex = 96
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(21, 363)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(232, 16)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "DATA PERUBAHAN STOCK BENANG"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(21, 388)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 16)
        Me.Label25.TabIndex = 98
        Me.Label25.Text = "Grup Produksi"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 535)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(800, 54)
        Me.Panel6.TabIndex = 23
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(800, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(607, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(696, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'txtKeteranganBaru
        '
        Me.txtKeteranganBaru.AllowEnterToMoveNext = True
        Me.txtKeteranganBaru.BackColor = System.Drawing.Color.White
        Me.txtKeteranganBaru.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeteranganBaru.Location = New System.Drawing.Point(135, 412)
        Me.txtKeteranganBaru.Name = "txtKeteranganBaru"
        Me.txtKeteranganBaru.Size = New System.Drawing.Size(640, 22)
        Me.txtKeteranganBaru.TabIndex = 21
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(21, 415)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 16)
        Me.Label26.TabIndex = 100
        Me.Label26.Text = "Keterangan"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(132, 450)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(122, 16)
        Me.Label27.TabIndex = 102
        Me.Label27.Text = "Alasan Perubahan :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(21, 470)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 16)
        Me.Label28.TabIndex = 104
        Me.Label28.Text = "Keterangan"
        '
        'txtAlasanPerubahan
        '
        Me.txtAlasanPerubahan.AllowEnterToMoveNext = True
        Me.txtAlasanPerubahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlasanPerubahan.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlasanPerubahan.Location = New System.Drawing.Point(135, 467)
        Me.txtAlasanPerubahan.Name = "txtAlasanPerubahan"
        Me.txtAlasanPerubahan.Size = New System.Drawing.Size(640, 22)
        Me.txtAlasanPerubahan.TabIndex = 22
        '
        'lblSupervisor
        '
        Me.lblSupervisor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisor.ForeColor = System.Drawing.Color.Blue
        Me.lblSupervisor.Location = New System.Drawing.Point(21, 495)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(751, 34)
        Me.lblSupervisor.TabIndex = 105
        Me.lblSupervisor.Text = "Perubahan Data Produksi Harus Dilakukan Oleh User Dengan Hak Supervisor"
        Me.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmKoreksiStockBenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 589)
        Me.Controls.Add(Me.lblSupervisor)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtAlasanPerubahan)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtKeteranganBaru)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtKeteranganLama)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cboKodeStatusBaru)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboKodeMesinBaru)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboKodeGrupBaru)
        Me.Controls.Add(Me.txtBeratNetto)
        Me.Controls.Add(Me.txtBeratBrutto)
        Me.Controls.Add(Me.txtQtyPcs)
        Me.Controls.Add(Me.txtQtyPacking)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboKodeGrupLama)
        Me.Controls.Add(Me.cboKodeShift)
        Me.Controls.Add(Me.cboKodeMesinLama)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboKodeArea)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboKodeStatusLama)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboKodeUnitAsal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtNomorWO)
        Me.Controls.Add(Me.txtTglTimbang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoTimbang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmKoreksiStockBenang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Koreksi Stock Benang"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoTimbang As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtTglTimbang As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNomorWO As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboKodeUnitAsal As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboKodeStatusLama As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboKodeArea As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboKodeMesinLama As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboKodeShift As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeGrupLama As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtQtyPacking As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyPcs As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratBrutto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratNetto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents cboKodeGrupBaru As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeMesinBaru As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboKodeStatusBaru As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtKeteranganLama As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents txtKeteranganBaru As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtAlasanPerubahan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents lblSupervisor As System.Windows.Forms.Label
End Class
