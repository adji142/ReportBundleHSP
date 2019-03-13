<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKoreksiKeluar
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
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboKelompokKoreksi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKelompok = New System.Windows.Forms.Button()
        Me.btLookupLokasi = New System.Windows.Forms.Button()
        Me.cboLokasiStock = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btLookupJenisKoreksi = New System.Windows.Forms.Button()
        Me.cboJenisKoreksi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(106, 22)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(122, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "No Transaksi"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(248, 25)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 13)
        Me.label2.TabIndex = 135
        Me.label2.Text = "Tgl Transaksi"
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(325, 22)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(95, 20)
        Me.txtTglTransaksi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Kelompok Koreksi"
        '
        'cboKelompokKoreksi
        '
        Me.cboKelompokKoreksi.AllowEnterToMoveNext = True
        Me.cboKelompokKoreksi.DataLocked = False
        Me.cboKelompokKoreksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKelompokKoreksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompokKoreksi.FormattingEnabled = True
        Me.cboKelompokKoreksi.IndexLocked = False
        Me.cboKelompokKoreksi.Location = New System.Drawing.Point(106, 46)
        Me.cboKelompokKoreksi.Name = "cboKelompokKoreksi"
        Me.cboKelompokKoreksi.Size = New System.Drawing.Size(485, 21)
        Me.cboKelompokKoreksi.TabIndex = 2
        '
        'btLookupKelompok
        '
        Me.btLookupKelompok.Location = New System.Drawing.Point(593, 45)
        Me.btLookupKelompok.Name = "btLookupKelompok"
        Me.btLookupKelompok.Size = New System.Drawing.Size(26, 23)
        Me.btLookupKelompok.TabIndex = 139
        Me.btLookupKelompok.TabStop = False
        Me.btLookupKelompok.Text = "..."
        Me.btLookupKelompok.UseVisualStyleBackColor = True
        '
        'btLookupLokasi
        '
        Me.btLookupLokasi.Location = New System.Drawing.Point(593, 70)
        Me.btLookupLokasi.Name = "btLookupLokasi"
        Me.btLookupLokasi.Size = New System.Drawing.Size(26, 23)
        Me.btLookupLokasi.TabIndex = 142
        Me.btLookupLokasi.TabStop = False
        Me.btLookupLokasi.Text = "..."
        Me.btLookupLokasi.UseVisualStyleBackColor = True
        '
        'cboLokasiStock
        '
        Me.cboLokasiStock.AllowEnterToMoveNext = True
        Me.cboLokasiStock.DataLocked = False
        Me.cboLokasiStock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLokasiStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLokasiStock.FormattingEnabled = True
        Me.cboLokasiStock.IndexLocked = False
        Me.cboLokasiStock.Location = New System.Drawing.Point(106, 71)
        Me.cboLokasiStock.Name = "cboLokasiStock"
        Me.cboLokasiStock.Size = New System.Drawing.Size(485, 21)
        Me.cboLokasiStock.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Lokasi Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Kode Produksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Kode Item"
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Location = New System.Drawing.Point(106, 108)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(122, 20)
        Me.txtKodeProduksi.TabIndex = 4
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.Location = New System.Drawing.Point(106, 132)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(89, 20)
        Me.txtKodeItem.TabIndex = 5
        Me.txtKodeItem.TabStop = False
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Location = New System.Drawing.Point(197, 132)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(422, 20)
        Me.txtNamaItem.TabIndex = 6
        Me.txtNamaItem.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 383)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(638, 54)
        Me.panel2.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(638, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(531, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(442, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btLookupJenisKoreksi
        '
        Me.btLookupJenisKoreksi.Location = New System.Drawing.Point(593, 316)
        Me.btLookupJenisKoreksi.Name = "btLookupJenisKoreksi"
        Me.btLookupJenisKoreksi.Size = New System.Drawing.Size(26, 23)
        Me.btLookupJenisKoreksi.TabIndex = 153
        Me.btLookupJenisKoreksi.Text = "..."
        Me.btLookupJenisKoreksi.UseVisualStyleBackColor = True
        '
        'cboJenisKoreksi
        '
        Me.cboJenisKoreksi.AllowEnterToMoveNext = True
        Me.cboJenisKoreksi.DataLocked = False
        Me.cboJenisKoreksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJenisKoreksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenisKoreksi.FormattingEnabled = True
        Me.cboJenisKoreksi.IndexLocked = False
        Me.cboJenisKoreksi.Location = New System.Drawing.Point(106, 317)
        Me.cboJenisKoreksi.Name = "cboJenisKoreksi"
        Me.cboJenisKoreksi.Size = New System.Drawing.Size(485, 21)
        Me.cboJenisKoreksi.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Jenis Koreksi"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(106, 342)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(513, 20)
        Me.txtKeterangan.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Keterangan"
        '
        'Grid
        '
        Me.Grid.AllowDeleteRow = False
        Me.Grid.AllowInsertRow = False
        Me.Grid.AlternatingCellFocusBackColor = System.Drawing.SystemColors.Highlight
        Me.Grid.AlternatingCellFocusForeColor = System.Drawing.Color.White
        Me.Grid.AlternatingDataGridBackColor = System.Drawing.Color.White
        Me.Grid.AlternatingDataGridForeColor = System.Drawing.Color.Empty
        Me.Grid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Grid.CellFocusBackColor = System.Drawing.SystemColors.Highlight
        Me.Grid.CellFocusForeColor = System.Drawing.Color.White
        Me.Grid.DataGridBackColor = System.Drawing.Color.White
        Me.Grid.DataGridForeColor = System.Drawing.Color.Empty
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.GridColor = System.Drawing.Color.Silver
        Me.Grid.HeaderBackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid.HeaderForeColor = System.Drawing.Color.Black
        Me.Grid.Location = New System.Drawing.Point(15, 172)
        Me.Grid.LookupButtonBackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(604, 125)
        Me.Grid.TabIndex = 7
        '
        'frmKoreksiKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 437)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btLookupJenisKoreksi)
        Me.Controls.Add(Me.cboJenisKoreksi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btLookupLokasi)
        Me.Controls.Add(Me.cboLokasiStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btLookupKelompok)
        Me.Controls.Add(Me.cboKelompokKoreksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKoreksiKeluar"
        Me.Text = "Adjusment Out (Koreksi Keluar)"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboKelompokKoreksi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKelompok As System.Windows.Forms.Button
    Friend WithEvents btLookupLokasi As System.Windows.Forms.Button
    Friend WithEvents cboLokasiStock As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btLookupJenisKoreksi As System.Windows.Forms.Button
    Friend WithEvents cboJenisKoreksi As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
End Class
