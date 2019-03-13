<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembatalanPackingCementBag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPembatalanPackingCementBag))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNomorWO = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtBeratStandar = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboStatusQCOld = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPcsBall = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBeratBall = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.lblSpesifikasi = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Produksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status QC"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblSpesifikasi)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtNomorWO)
        Me.Panel1.Controls.Add(Me.txtBeratStandar)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtKeterangan)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtNoTransaksi)
        Me.Panel1.Controls.Add(Me.txtTglProduksi)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboKodeLokasi)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cboStatusQCOld)
        Me.Panel1.Controls.Add(Me.cboKodeUnit)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtPcsBall)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBeratBall)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNamaItem)
        Me.Panel1.Controls.Add(Me.txtKodeItem)
        Me.Panel1.Controls.Add(Me.txtKodeProduksi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(13, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 390)
        Me.Panel1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(124, 335)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 16)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Alasan Pembatalan :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(358, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 16)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Tgl Produksi"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(16, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Nomor WO"
        '
        'txtNomorWO
        '
        Me.txtNomorWO.AllowEnterToMoveNext = True
        Me.txtNomorWO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomorWO.Location = New System.Drawing.Point(126, 67)
        Me.txtNomorWO.Name = "txtNomorWO"
        Me.txtNomorWO.ReadOnly = True
        Me.txtNomorWO.Size = New System.Drawing.Size(494, 22)
        Me.txtNomorWO.TabIndex = 3
        Me.txtNomorWO.TabStop = False
        '
        'txtBeratStandar
        '
        Me.txtBeratStandar.AllowEnterToMoveNext = True
        Me.txtBeratStandar.BackColor = System.Drawing.Color.Green
        Me.txtBeratStandar.CheckIsValid = False
        Me.txtBeratStandar.DataFormat = "###,##0.00"
        Me.txtBeratStandar.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratStandar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratStandar.ForeColor = System.Drawing.Color.White
        Me.txtBeratStandar.Location = New System.Drawing.Point(458, 241)
        Me.txtBeratStandar.Name = "txtBeratStandar"
        Me.txtBeratStandar.ReadOnly = True
        Me.txtBeratStandar.Size = New System.Drawing.Size(160, 25)
        Me.txtBeratStandar.TabIndex = 11
        Me.txtBeratStandar.TabStop = False
        Me.txtBeratStandar.Text = "0.00"
        Me.txtBeratStandar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratStandar.Value = 0.0R
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(21, 357)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 16)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKeterangan.Location = New System.Drawing.Point(127, 354)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(492, 22)
        Me.txtKeterangan.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Kode Produksi"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoTransaksi.Location = New System.Drawing.Point(126, 17)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.ReadOnly = True
        Me.txtNoTransaksi.Size = New System.Drawing.Size(190, 22)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'txtTglProduksi
        '
        Me.txtTglProduksi.AllowEnterToMoveNext = True
        Me.txtTglProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTglProduksi.Location = New System.Drawing.Point(451, 17)
        Me.txtTglProduksi.Name = "txtTglProduksi"
        Me.txtTglProduksi.ReadOnly = True
        Me.txtTglProduksi.Size = New System.Drawing.Size(169, 22)
        Me.txtTglProduksi.TabIndex = 1
        Me.txtTglProduksi.TabStop = False
        Me.txtTglProduksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(458, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "BERAT STANDAR"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Nama Item"
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = True
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = False
        Me.cboKodeLokasi.Location = New System.Drawing.Point(127, 180)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(493, 24)
        Me.cboKodeLokasi.TabIndex = 7
        Me.cboKodeLokasi.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 183)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 16)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Lokasi Produksi"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 245)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Kuantitas"
        '
        'cboStatusQCOld
        '
        Me.cboStatusQCOld.AllowEnterToMoveNext = True
        Me.cboStatusQCOld.DataLocked = True
        Me.cboStatusQCOld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboStatusQCOld.FormattingEnabled = True
        Me.cboStatusQCOld.IndexLocked = False
        Me.cboStatusQCOld.Items.AddRange(New Object() {"NONE", "OK", "NON OK", "OVER", "UNDER"})
        Me.cboStatusQCOld.Location = New System.Drawing.Point(126, 299)
        Me.cboStatusQCOld.Name = "cboStatusQCOld"
        Me.cboStatusQCOld.Size = New System.Drawing.Size(491, 24)
        Me.cboStatusQCOld.TabIndex = 12
        Me.cboStatusQCOld.TabStop = False
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = True
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(127, 153)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(493, 24)
        Me.cboKodeUnit.TabIndex = 6
        Me.cboKodeUnit.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Unit Produksi"
        '
        'txtPcsBall
        '
        Me.txtPcsBall.AllowEnterToMoveNext = True
        Me.txtPcsBall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPcsBall.CheckIsValid = False
        Me.txtPcsBall.DataFormat = "###,##0.00"
        Me.txtPcsBall.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPcsBall.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPcsBall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPcsBall.Location = New System.Drawing.Point(127, 241)
        Me.txtPcsBall.Name = "txtPcsBall"
        Me.txtPcsBall.ReadOnly = True
        Me.txtPcsBall.Size = New System.Drawing.Size(168, 25)
        Me.txtPcsBall.TabIndex = 8
        Me.txtPcsBall.TabStop = False
        Me.txtPcsBall.Text = "0.00"
        Me.txtPcsBall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPcsBall.Value = 0.0R
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(139, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "LEMBAR"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBeratBall
        '
        Me.txtBeratBall.AllowEnterToMoveNext = True
        Me.txtBeratBall.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratBall.CheckIsValid = False
        Me.txtBeratBall.DataFormat = "###,##0.00"
        Me.txtBeratBall.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratBall.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratBall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBeratBall.Location = New System.Drawing.Point(301, 241)
        Me.txtBeratBall.Name = "txtBeratBall"
        Me.txtBeratBall.ReadOnly = True
        Me.txtBeratBall.Size = New System.Drawing.Size(151, 25)
        Me.txtBeratBall.TabIndex = 9
        Me.txtBeratBall.TabStop = False
        Me.txtBeratBall.Text = "0.00"
        Me.txtBeratBall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratBall.Value = 0.0R
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(301, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "KILOGRAM"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.White
        Me.txtNamaItem.Location = New System.Drawing.Point(127, 125)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(493, 22)
        Me.txtNamaItem.TabIndex = 5
        Me.txtNamaItem.TabStop = False
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.White
        Me.txtKodeItem.Location = New System.Drawing.Point(127, 100)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(494, 22)
        Me.txtKodeItem.TabIndex = 4
        Me.txtKodeItem.TabStop = False
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksi.Location = New System.Drawing.Point(126, 42)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.ReadOnly = True
        Me.txtKodeProduksi.Size = New System.Drawing.Size(494, 22)
        Me.txtKodeProduksi.TabIndex = 2
        Me.txtKodeProduksi.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(127, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(491, 22)
        Me.Label9.TabIndex = 26
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(636, 22)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DATA PRODUKSI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.Controls.Add(Me.pictureBox2)
        Me.Panel9.Controls.Add(Me.btSave)
        Me.Panel9.Controls.Add(Me.btClose)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 572)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(661, 54)
        Me.Panel9.TabIndex = 1
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(661, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(477, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(566, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 101)
        Me.Panel2.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(6, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(631, 62)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = resources.GetString("Label12.Text")
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(616, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "PROSES PEMBATALAN DATA PRODUKSI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSupervisor
        '
        Me.lblSupervisor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisor.ForeColor = System.Drawing.Color.Blue
        Me.lblSupervisor.Location = New System.Drawing.Point(11, 535)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(637, 34)
        Me.lblSupervisor.TabIndex = 52
        Me.lblSupervisor.Text = "Pembatalan Data Produksi Harus Dilakukan Oleh User Dengan Hak Supervisor"
        Me.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpesifikasi
        '
        Me.lblSpesifikasi.Location = New System.Drawing.Point(124, 269)
        Me.lblSpesifikasi.Name = "lblSpesifikasi"
        Me.lblSpesifikasi.Size = New System.Drawing.Size(497, 20)
        Me.lblSpesifikasi.TabIndex = 59
        Me.lblSpesifikasi.Text = "Spesifikasi"
        Me.lblSpesifikasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPembatalanPackingKarung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 626)
        Me.Controls.Add(Me.lblSupervisor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPembatalanPackingKarung"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembatalan Data Produksi | Packing Karung"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPcsBall As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBeratBall As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboStatusQCOld As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTglProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtBeratStandar As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNomorWO As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSupervisor As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSpesifikasi As System.Windows.Forms.Label
End Class
