<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMutasiAreaBenang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboKodeAreaAsal = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btAddAll = New System.Windows.Forms.Button()
        Me.btAddOne = New System.Windows.Forms.Button()
        Me.btRemoveOne = New System.Windows.Forms.Button()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ViewAsal = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.ViewTujuan = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.ItemAsal = New System.Windows.Forms.Label()
        Me.btLookupKodeAreaAsal = New System.Windows.Forms.Button()
        Me.btLookupKodeAreaTujuan = New System.Windows.Forms.Button()
        Me.cboKodeAreaTujuan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.JumlahBaris2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btReprint = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btShow = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Berat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ViewAsal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewTujuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area Asal"
        '
        'cboKodeAreaAsal
        '
        Me.cboKodeAreaAsal.AllowEnterToMoveNext = True
        Me.cboKodeAreaAsal.DataLocked = False
        Me.cboKodeAreaAsal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeAreaAsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeAreaAsal.FormattingEnabled = True
        Me.cboKodeAreaAsal.IndexLocked = False
        Me.cboKodeAreaAsal.Location = New System.Drawing.Point(120, 117)
        Me.cboKodeAreaAsal.Name = "cboKodeAreaAsal"
        Me.cboKodeAreaAsal.Size = New System.Drawing.Size(167, 21)
        Me.cboKodeAreaAsal.TabIndex = 4
        '
        'btAddAll
        '
        Me.btAddAll.Location = New System.Drawing.Point(539, 260)
        Me.btAddAll.Name = "btAddAll"
        Me.btAddAll.Size = New System.Drawing.Size(57, 23)
        Me.btAddAll.TabIndex = 8
        Me.btAddAll.Text = ">>"
        Me.btAddAll.UseVisualStyleBackColor = True
        '
        'btAddOne
        '
        Me.btAddOne.Location = New System.Drawing.Point(539, 289)
        Me.btAddOne.Name = "btAddOne"
        Me.btAddOne.Size = New System.Drawing.Size(57, 23)
        Me.btAddOne.TabIndex = 9
        Me.btAddOne.Text = ">"
        Me.btAddOne.UseVisualStyleBackColor = True
        '
        'btRemoveOne
        '
        Me.btRemoveOne.Location = New System.Drawing.Point(539, 318)
        Me.btRemoveOne.Name = "btRemoveOne"
        Me.btRemoveOne.Size = New System.Drawing.Size(57, 23)
        Me.btRemoveOne.TabIndex = 10
        Me.btRemoveOne.Text = "<"
        Me.btRemoveOne.UseVisualStyleBackColor = True
        '
        'btRemoveAll
        '
        Me.btRemoveAll.Location = New System.Drawing.Point(539, 347)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(57, 23)
        Me.btRemoveAll.TabIndex = 11
        Me.btRemoveAll.Text = "<<"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Area Tujuan"
        '
        'ViewAsal
        '
        Me.ViewAsal.AllowUserToAddRows = False
        Me.ViewAsal.AllowUserToDeleteRows = False
        Me.ViewAsal.AllowUserToOrderColumns = True
        Me.ViewAsal.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ViewAsal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewAsal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewAsal.BackgroundColor = System.Drawing.Color.White
        Me.ViewAsal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewAsal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewAsal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewAsal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.KodeItem, Me.NamaItem, Me.Area, Me.Jumlah, Me.Berat})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAsal.DefaultCellStyle = DataGridViewCellStyle2
        Me.ViewAsal.Location = New System.Drawing.Point(29, 173)
        Me.ViewAsal.Name = "ViewAsal"
        Me.ViewAsal.ReadOnly = True
        Me.ViewAsal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewAsal.RowHeadersVisible = False
        Me.ViewAsal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewAsal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewAsal.ShowEditingIcon = False
        Me.ViewAsal.Size = New System.Drawing.Size(504, 322)
        Me.ViewAsal.StandardTab = True
        Me.ViewAsal.TabIndex = 7
        '
        'ViewTujuan
        '
        Me.ViewTujuan.AllowUserToAddRows = False
        Me.ViewTujuan.AllowUserToDeleteRows = False
        Me.ViewTujuan.AllowUserToOrderColumns = True
        Me.ViewTujuan.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.ViewTujuan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ViewTujuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewTujuan.BackgroundColor = System.Drawing.Color.White
        Me.ViewTujuan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewTujuan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewTujuan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewTujuan.ColumnHeadersHeight = 35
        Me.ViewTujuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewTujuan.DefaultCellStyle = DataGridViewCellStyle4
        Me.ViewTujuan.Location = New System.Drawing.Point(602, 173)
        Me.ViewTujuan.Name = "ViewTujuan"
        Me.ViewTujuan.ReadOnly = True
        Me.ViewTujuan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewTujuan.RowHeadersVisible = False
        Me.ViewTujuan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewTujuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewTujuan.ShowEditingIcon = False
        Me.ViewTujuan.Size = New System.Drawing.Size(504, 322)
        Me.ViewTujuan.StandardTab = True
        Me.ViewTujuan.TabIndex = 8
        '
        'ItemAsal
        '
        Me.ItemAsal.AutoSize = True
        Me.ItemAsal.Location = New System.Drawing.Point(26, 498)
        Me.ItemAsal.Name = "ItemAsal"
        Me.ItemAsal.Size = New System.Drawing.Size(66, 13)
        Me.ItemAsal.TabIndex = 15
        Me.ItemAsal.Text = "Jumlah Baris"
        '
        'btLookupKodeAreaAsal
        '
        Me.btLookupKodeAreaAsal.Location = New System.Drawing.Point(288, 116)
        Me.btLookupKodeAreaAsal.Name = "btLookupKodeAreaAsal"
        Me.btLookupKodeAreaAsal.Size = New System.Drawing.Size(27, 23)
        Me.btLookupKodeAreaAsal.TabIndex = 16
        Me.btLookupKodeAreaAsal.Text = "..."
        Me.btLookupKodeAreaAsal.UseVisualStyleBackColor = True
        '
        'btLookupKodeAreaTujuan
        '
        Me.btLookupKodeAreaTujuan.Location = New System.Drawing.Point(871, 116)
        Me.btLookupKodeAreaTujuan.Name = "btLookupKodeAreaTujuan"
        Me.btLookupKodeAreaTujuan.Size = New System.Drawing.Size(27, 23)
        Me.btLookupKodeAreaTujuan.TabIndex = 18
        Me.btLookupKodeAreaTujuan.Text = "..."
        Me.btLookupKodeAreaTujuan.UseVisualStyleBackColor = True
        '
        'cboKodeAreaTujuan
        '
        Me.cboKodeAreaTujuan.AllowEnterToMoveNext = True
        Me.cboKodeAreaTujuan.DataLocked = False
        Me.cboKodeAreaTujuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeAreaTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeAreaTujuan.FormattingEnabled = True
        Me.cboKodeAreaTujuan.IndexLocked = False
        Me.cboKodeAreaTujuan.Location = New System.Drawing.Point(670, 117)
        Me.cboKodeAreaTujuan.Name = "cboKodeAreaTujuan"
        Me.cboKodeAreaTujuan.Size = New System.Drawing.Size(200, 21)
        Me.cboKodeAreaTujuan.TabIndex = 6
        '
        'JumlahBaris2
        '
        Me.JumlahBaris2.AutoSize = True
        Me.JumlahBaris2.Location = New System.Drawing.Point(599, 498)
        Me.JumlahBaris2.Name = "JumlahBaris2"
        Me.JumlahBaris2.Size = New System.Drawing.Size(66, 13)
        Me.JumlahBaris2.TabIndex = 19
        Me.JumlahBaris2.Text = "Jumlah Baris"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.btReprint)
        Me.Panel3.Controls.Add(Me.pictureBox2)
        Me.Panel3.Controls.Add(Me.btSave)
        Me.Panel3.Controls.Add(Me.btClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 539)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1134, 54)
        Me.Panel3.TabIndex = 9
        '
        'btReprint
        '
        Me.btReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReprint.Location = New System.Drawing.Point(-101, 10)
        Me.btReprint.Name = "btReprint"
        Me.btReprint.Size = New System.Drawing.Size(83, 23)
        Me.btReprint.TabIndex = 10
        Me.btReprint.Text = "Reprint"
        Me.btReprint.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1134, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(940, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(1029, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(422, 25)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(111, 20)
        Me.txtTglTransaksi.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(317, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Tgl. Transaksi"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(120, 26)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(167, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(26, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "No Transaksi"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 4)
        Me.Panel1.TabIndex = 133
        '
        'btShow
        '
        Me.btShow.Location = New System.Drawing.Point(315, 116)
        Me.btShow.Name = "btShow"
        Me.btShow.Size = New System.Drawing.Size(111, 23)
        Me.btShow.TabIndex = 5
        Me.btShow.TabStop = False
        Me.btShow.Text = "Tampilkan"
        Me.btShow.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(120, 51)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(986, 20)
        Me.txtKeterangan.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(599, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Lokasi"
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = False
        Me.cboKodeLokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = False
        Me.cboKodeLokasi.Location = New System.Drawing.Point(670, 25)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(436, 21)
        Me.cboKodeLokasi.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 139
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(539, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 23)
        Me.Button2.TabIndex = 140
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Kode Produksi"
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Location = New System.Drawing.Point(120, 147)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(167, 20)
        Me.txtKodeProduksi.TabIndex = 5
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode Produksi"
        Me.Kode.Name = "Kode"
        Me.Kode.ReadOnly = True
        '
        'KodeItem
        '
        Me.KodeItem.HeaderText = "Kode Item"
        Me.KodeItem.Name = "KodeItem"
        Me.KodeItem.ReadOnly = True
        '
        'NamaItem
        '
        Me.NamaItem.HeaderText = "Nama Item"
        Me.NamaItem.Name = "NamaItem"
        Me.NamaItem.ReadOnly = True
        '
        'Area
        '
        Me.Area.HeaderText = "Area"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'Berat
        '
        Me.Berat.HeaderText = "Berat"
        Me.Berat.Name = "Berat"
        Me.Berat.ReadOnly = True
        '
        'frmMutasiAreaBenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 593)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btShow)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.JumlahBaris2)
        Me.Controls.Add(Me.btLookupKodeAreaTujuan)
        Me.Controls.Add(Me.cboKodeAreaTujuan)
        Me.Controls.Add(Me.btLookupKodeAreaAsal)
        Me.Controls.Add(Me.ItemAsal)
        Me.Controls.Add(Me.ViewTujuan)
        Me.Controls.Add(Me.ViewAsal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btRemoveAll)
        Me.Controls.Add(Me.btRemoveOne)
        Me.Controls.Add(Me.btAddOne)
        Me.Controls.Add(Me.btAddAll)
        Me.Controls.Add(Me.cboKodeAreaAsal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmMutasiAreaBenang"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mutasi Area"
        CType(Me.ViewAsal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewTujuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboKodeAreaAsal As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btAddAll As System.Windows.Forms.Button
    Friend WithEvents btAddOne As System.Windows.Forms.Button
    Friend WithEvents btRemoveOne As System.Windows.Forms.Button
    Friend WithEvents btRemoveAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents ViewAsal As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents ViewTujuan As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents ItemAsal As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeAreaAsal As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeAreaTujuan As System.Windows.Forms.Button
    Friend WithEvents cboKodeAreaTujuan As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents JumlahBaris2 As System.Windows.Forms.Label
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents btReprint As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btShow As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Berat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
