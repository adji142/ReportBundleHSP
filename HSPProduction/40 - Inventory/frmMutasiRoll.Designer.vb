<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMutasiRoll
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.cboKodeLokasiAsal = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeLokasiAsal = New System.Windows.Forms.Button()
        Me.btLookupKodeLokasiTujuan = New System.Windows.Forms.Button()
        Me.cboKodeLokasiTujuan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btLookupKodeProduksi = New System.Windows.Forms.Button()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtyUnit = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtQtyTimbang = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPeruntukan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtStatus = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDisposisi = New System.Windows.Forms.Label()
        Me.btDefault = New System.Windows.Forms.Button()
        Me.Panel9.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lokasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ke Lokasi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keterangan"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(97, 23)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(128, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(97, 48)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(128, 20)
        Me.txtTglTransaksi.TabIndex = 1
        '
        'cboKodeLokasiAsal
        '
        Me.cboKodeLokasiAsal.AllowEnterToMoveNext = True
        Me.cboKodeLokasiAsal.DataLocked = False
        Me.cboKodeLokasiAsal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasiAsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasiAsal.FormattingEnabled = True
        Me.cboKodeLokasiAsal.IndexLocked = False
        Me.cboKodeLokasiAsal.Location = New System.Drawing.Point(97, 73)
        Me.cboKodeLokasiAsal.Name = "cboKodeLokasiAsal"
        Me.cboKodeLokasiAsal.Size = New System.Drawing.Size(200, 21)
        Me.cboKodeLokasiAsal.TabIndex = 2
        '
        'btLookupKodeLokasiAsal
        '
        Me.btLookupKodeLokasiAsal.Location = New System.Drawing.Point(298, 72)
        Me.btLookupKodeLokasiAsal.Name = "btLookupKodeLokasiAsal"
        Me.btLookupKodeLokasiAsal.Size = New System.Drawing.Size(26, 23)
        Me.btLookupKodeLokasiAsal.TabIndex = 8
        Me.btLookupKodeLokasiAsal.TabStop = False
        Me.btLookupKodeLokasiAsal.Text = "..."
        Me.btLookupKodeLokasiAsal.UseVisualStyleBackColor = True
        '
        'btLookupKodeLokasiTujuan
        '
        Me.btLookupKodeLokasiTujuan.Location = New System.Drawing.Point(594, 72)
        Me.btLookupKodeLokasiTujuan.Name = "btLookupKodeLokasiTujuan"
        Me.btLookupKodeLokasiTujuan.Size = New System.Drawing.Size(26, 23)
        Me.btLookupKodeLokasiTujuan.TabIndex = 10
        Me.btLookupKodeLokasiTujuan.TabStop = False
        Me.btLookupKodeLokasiTujuan.Text = "..."
        Me.btLookupKodeLokasiTujuan.UseVisualStyleBackColor = True
        '
        'cboKodeLokasiTujuan
        '
        Me.cboKodeLokasiTujuan.AllowEnterToMoveNext = True
        Me.cboKodeLokasiTujuan.DataLocked = False
        Me.cboKodeLokasiTujuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasiTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasiTujuan.FormattingEnabled = True
        Me.cboKodeLokasiTujuan.IndexLocked = False
        Me.cboKodeLokasiTujuan.Location = New System.Drawing.Point(393, 73)
        Me.cboKodeLokasiTujuan.Name = "cboKodeLokasiTujuan"
        Me.cboKodeLokasiTujuan.Size = New System.Drawing.Size(200, 21)
        Me.cboKodeLokasiTujuan.TabIndex = 3
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(97, 99)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(523, 20)
        Me.txtKeterangan.TabIndex = 4
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Location = New System.Drawing.Point(97, 166)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(200, 20)
        Me.txtKodeProduksi.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kode Produksi"
        '
        'btLookupKodeProduksi
        '
        Me.btLookupKodeProduksi.Location = New System.Drawing.Point(298, 164)
        Me.btLookupKodeProduksi.Name = "btLookupKodeProduksi"
        Me.btLookupKodeProduksi.Size = New System.Drawing.Size(26, 23)
        Me.btLookupKodeProduksi.TabIndex = 14
        Me.btLookupKodeProduksi.TabStop = False
        Me.btLookupKodeProduksi.Text = "..."
        Me.btLookupKodeProduksi.UseVisualStyleBackColor = True
        Me.btLookupKodeProduksi.Visible = False
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeItem.Location = New System.Drawing.Point(97, 191)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(128, 20)
        Me.txtKodeItem.TabIndex = 6
        Me.txtKodeItem.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Kode Item"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Location = New System.Drawing.Point(97, 216)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(523, 20)
        Me.txtNamaItem.TabIndex = 7
        Me.txtNamaItem.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Nama Item"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Quantity"
        '
        'txtQtyUnit
        '
        Me.txtQtyUnit.AllowEnterToMoveNext = True
        Me.txtQtyUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyUnit.CheckIsValid = False
        Me.txtQtyUnit.DataFormat = "###,##0.00"
        Me.txtQtyUnit.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyUnit.Location = New System.Drawing.Point(97, 241)
        Me.txtQtyUnit.Name = "txtQtyUnit"
        Me.txtQtyUnit.ReadOnly = True
        Me.txtQtyUnit.Size = New System.Drawing.Size(128, 20)
        Me.txtQtyUnit.TabIndex = 8
        Me.txtQtyUnit.TabStop = False
        Me.txtQtyUnit.Text = "0.00"
        Me.txtQtyUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyUnit.Value = 0.0R
        '
        'txtQtyTimbang
        '
        Me.txtQtyTimbang.AllowEnterToMoveNext = True
        Me.txtQtyTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyTimbang.CheckIsValid = False
        Me.txtQtyTimbang.DataFormat = "###,##0.00"
        Me.txtQtyTimbang.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQtyTimbang.Location = New System.Drawing.Point(97, 267)
        Me.txtQtyTimbang.Name = "txtQtyTimbang"
        Me.txtQtyTimbang.ReadOnly = True
        Me.txtQtyTimbang.Size = New System.Drawing.Size(128, 20)
        Me.txtQtyTimbang.TabIndex = 9
        Me.txtQtyTimbang.TabStop = False
        Me.txtQtyTimbang.Text = "0.00"
        Me.txtQtyTimbang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyTimbang.Value = 0.0R
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(228, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Meter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(228, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "KG"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Peruntukan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 321)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Status"
        '
        'txtPeruntukan
        '
        Me.txtPeruntukan.AllowEnterToMoveNext = True
        Me.txtPeruntukan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeruntukan.Location = New System.Drawing.Point(97, 293)
        Me.txtPeruntukan.Name = "txtPeruntukan"
        Me.txtPeruntukan.ReadOnly = True
        Me.txtPeruntukan.Size = New System.Drawing.Size(523, 20)
        Me.txtPeruntukan.TabIndex = 10
        Me.txtPeruntukan.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.AllowEnterToMoveNext = True
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatus.Location = New System.Drawing.Point(97, 318)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(128, 20)
        Me.txtStatus.TabIndex = 11
        Me.txtStatus.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.Controls.Add(Me.pictureBox2)
        Me.Panel9.Controls.Add(Me.btSave)
        Me.Panel9.Controls.Add(Me.btClose)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 361)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(643, 54)
        Me.Panel9.TabIndex = 12
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(643, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(448, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(537, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(659, 1)
        Me.PictureBox1.TabIndex = 131
        Me.PictureBox1.TabStop = False
        '
        'lblDisposisi
        '
        Me.lblDisposisi.AutoSize = True
        Me.lblDisposisi.Location = New System.Drawing.Point(231, 321)
        Me.lblDisposisi.Name = "lblDisposisi"
        Me.lblDisposisi.Size = New System.Drawing.Size(78, 13)
        Me.lblDisposisi.TabIndex = 132
        Me.lblDisposisi.Text = "StatusDisposisi"
        Me.lblDisposisi.Visible = False
        '
        'btDefault
        '
        Me.btDefault.Location = New System.Drawing.Point(621, 72)
        Me.btDefault.Name = "btDefault"
        Me.btDefault.Size = New System.Drawing.Size(17, 23)
        Me.btDefault.TabIndex = 133
        Me.btDefault.TabStop = False
        Me.btDefault.Text = "<"
        Me.btDefault.UseVisualStyleBackColor = True
        '
        'frmMutasiRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 415)
        Me.Controls.Add(Me.btDefault)
        Me.Controls.Add(Me.lblDisposisi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtPeruntukan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtQtyTimbang)
        Me.Controls.Add(Me.txtQtyUnit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btLookupKodeProduksi)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.btLookupKodeLokasiTujuan)
        Me.Controls.Add(Me.cboKodeLokasiTujuan)
        Me.Controls.Add(Me.btLookupKodeLokasiAsal)
        Me.Controls.Add(Me.cboKodeLokasiAsal)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(659, 454)
        Me.MinimumSize = New System.Drawing.Size(659, 454)
        Me.Name = "frmMutasiRoll"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mutasi Roll"
        Me.Panel9.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents cboKodeLokasiAsal As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeLokasiAsal As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeLokasiTujuan As System.Windows.Forms.Button
    Friend WithEvents cboKodeLokasiTujuan As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeProduksi As System.Windows.Forms.Button
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQtyUnit As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtQtyTimbang As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPeruntukan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtStatus As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDisposisi As System.Windows.Forms.Label
    Friend WithEvents btDefault As System.Windows.Forms.Button
End Class
