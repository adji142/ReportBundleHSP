<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenjelasanProduksi
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTanggal = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.cboUnitProduksi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboNomorWO = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtHasilProduksi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.RichTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.btLookupNomorWO = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtyPlan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtProsentase = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTglMulai = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglSelesai = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nomor SPK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal SPK"
        '
        'txtTanggal
        '
        Me.txtTanggal.AllowEnterToMoveNext = True
        Me.txtTanggal.CustomFormat = "dd/MM/yyyy"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(286, 22)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(100, 20)
        Me.txtTanggal.TabIndex = 1
        '
        'cboUnitProduksi
        '
        Me.cboUnitProduksi.AllowEnterToMoveNext = True
        Me.cboUnitProduksi.DataLocked = True
        Me.cboUnitProduksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUnitProduksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboUnitProduksi.FormattingEnabled = True
        Me.cboUnitProduksi.IndexLocked = True
        Me.cboUnitProduksi.Location = New System.Drawing.Point(112, 79)
        Me.cboUnitProduksi.Name = "cboUnitProduksi"
        Me.cboUnitProduksi.Size = New System.Drawing.Size(538, 21)
        Me.cboUnitProduksi.TabIndex = 2
        Me.cboUnitProduksi.TabStop = False
        '
        'cboNomorWO
        '
        Me.cboNomorWO.AllowEnterToMoveNext = True
        Me.cboNomorWO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorWO.DataLocked = False
        Me.cboNomorWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorWO.ForeColor = System.Drawing.Color.Red
        Me.cboNomorWO.FormattingEnabled = True
        Me.cboNomorWO.IndexLocked = False
        Me.cboNomorWO.Location = New System.Drawing.Point(112, 109)
        Me.cboNomorWO.Name = "cboNomorWO"
        Me.cboNomorWO.Size = New System.Drawing.Size(508, 28)
        Me.cboNomorWO.TabIndex = 3
        '
        'txtHasilProduksi
        '
        Me.txtHasilProduksi.AllowEnterToMoveNext = True
        Me.txtHasilProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilProduksi.CheckIsValid = False
        Me.txtHasilProduksi.DataFormat = "###,##0.00"
        Me.txtHasilProduksi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilProduksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasilProduksi.ForeColor = System.Drawing.Color.Red
        Me.txtHasilProduksi.Location = New System.Drawing.Point(270, 230)
        Me.txtHasilProduksi.Name = "txtHasilProduksi"
        Me.txtHasilProduksi.ReadOnly = True
        Me.txtHasilProduksi.Size = New System.Drawing.Size(155, 26)
        Me.txtHasilProduksi.TabIndex = 9
        Me.txtHasilProduksi.TabStop = False
        Me.txtHasilProduksi.Text = "0.00"
        Me.txtHasilProduksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilProduksi.Value = 0.0R
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(112, 263)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(538, 142)
        Me.txtKeterangan.TabIndex = 10
        Me.txtKeterangan.Text = ""
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 423)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(668, 54)
        Me.Panel6.TabIndex = 11
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(668, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(475, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(564, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "Item Produksi"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeItem.ForeColor = System.Drawing.Color.Navy
        Me.txtKodeItem.Location = New System.Drawing.Point(112, 142)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(100, 23)
        Me.txtKodeItem.TabIndex = 4
        Me.txtKodeItem.TabStop = False
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaItem.ForeColor = System.Drawing.Color.Navy
        Me.txtNamaItem.Location = New System.Drawing.Point(214, 142)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(436, 23)
        Me.txtNamaItem.TabIndex = 5
        Me.txtNamaItem.TabStop = False
        '
        'btLookupNomorWO
        '
        Me.btLookupNomorWO.Location = New System.Drawing.Point(622, 108)
        Me.btLookupNomorWO.Name = "btLookupNomorWO"
        Me.btLookupNomorWO.Size = New System.Drawing.Size(28, 29)
        Me.btLookupNomorWO.TabIndex = 149
        Me.btLookupNomorWO.Text = "..."
        Me.btLookupNomorWO.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(623, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 24)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "%"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "No Transaksi"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.BackColor = System.Drawing.Color.White
        Me.txtNoTransaksi.Location = New System.Drawing.Point(112, 22)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Data Produksi"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Teal
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 25)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "Quantity Plan"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(112, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 25)
        Me.Panel1.TabIndex = 155
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Teal
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(329, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(179, 25)
        Me.Label14.TabIndex = 157
        Me.Label14.Text = "Prosentase Pencapaian Hasil"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(158, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 25)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Quantity Hasil"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtyPlan
        '
        Me.txtQtyPlan.AllowEnterToMoveNext = True
        Me.txtQtyPlan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyPlan.CheckIsValid = False
        Me.txtQtyPlan.DataFormat = "###,##0.00"
        Me.txtQtyPlan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyPlan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyPlan.Location = New System.Drawing.Point(112, 230)
        Me.txtQtyPlan.Name = "txtQtyPlan"
        Me.txtQtyPlan.ReadOnly = True
        Me.txtQtyPlan.Size = New System.Drawing.Size(155, 26)
        Me.txtQtyPlan.TabIndex = 156
        Me.txtQtyPlan.TabStop = False
        Me.txtQtyPlan.Text = "0.00"
        Me.txtQtyPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyPlan.Value = 0.0R
        '
        'txtProsentase
        '
        Me.txtProsentase.AllowEnterToMoveNext = True
        Me.txtProsentase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProsentase.CheckIsValid = False
        Me.txtProsentase.DataFormat = "###,##0.00"
        Me.txtProsentase.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtProsentase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProsentase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProsentase.Location = New System.Drawing.Point(441, 230)
        Me.txtProsentase.Name = "txtProsentase"
        Me.txtProsentase.ReadOnly = True
        Me.txtProsentase.Size = New System.Drawing.Size(179, 26)
        Me.txtProsentase.TabIndex = 157
        Me.txtProsentase.TabStop = False
        Me.txtProsentase.Text = "0.00"
        Me.txtProsentase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtProsentase.Value = 0.0R
        '
        'txtTglMulai
        '
        Me.txtTglMulai.AllowEnterToMoveNext = True
        Me.txtTglMulai.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTglMulai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglMulai.ForeColor = System.Drawing.Color.Navy
        Me.txtTglMulai.Location = New System.Drawing.Point(112, 170)
        Me.txtTglMulai.Name = "txtTglMulai"
        Me.txtTglMulai.ReadOnly = True
        Me.txtTglMulai.Size = New System.Drawing.Size(100, 23)
        Me.txtTglMulai.TabIndex = 158
        Me.txtTglMulai.TabStop = False
        '
        'txtTglSelesai
        '
        Me.txtTglSelesai.AllowEnterToMoveNext = True
        Me.txtTglSelesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTglSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglSelesai.ForeColor = System.Drawing.Color.Navy
        Me.txtTglSelesai.Location = New System.Drawing.Point(214, 170)
        Me.txtTglSelesai.Name = "txtTglSelesai"
        Me.txtTglSelesai.ReadOnly = True
        Me.txtTglSelesai.Size = New System.Drawing.Size(100, 23)
        Me.txtTglSelesai.TabIndex = 159
        Me.txtTglSelesai.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(668, 4)
        Me.Panel2.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unit Produksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(625, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 19)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "%"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPenjelasanProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 477)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtTglSelesai)
        Me.Controls.Add(Me.txtTglMulai)
        Me.Controls.Add(Me.txtProsentase)
        Me.Controls.Add(Me.txtQtyPlan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btLookupNomorWO)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHasilProduksi)
        Me.Controls.Add(Me.cboNomorWO)
        Me.Controls.Add(Me.cboUnitProduksi)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPenjelasanProduksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjelasan Proses Produksi"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents cboUnitProduksi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboNomorWO As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtHasilProduksi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.RichTextBox
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents btLookupNomorWO As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtQtyPlan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProsentase As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTglMulai As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtTglSelesai As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
