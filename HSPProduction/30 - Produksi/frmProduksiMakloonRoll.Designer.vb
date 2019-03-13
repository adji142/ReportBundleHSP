<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiMakloonRoll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduksiMakloonRoll))
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglPencatatan = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPanjangRoll = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratRoll = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = True
        Me.cboKodeUnit.Location = New System.Drawing.Point(108, 22)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(439, 21)
        Me.cboKodeUnit.TabIndex = 0
        Me.cboKodeUnit.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Unit Produksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "No. Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Tgl. Transaksi"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(252, 50)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 138
        Me.Locked.TabStop = False
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(108, 49)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(141, 20)
        Me.txtNoTransaksi.TabIndex = 1
        '
        'txtTglPencatatan
        '
        Me.txtTglPencatatan.AllowEnterToMoveNext = True
        Me.txtTglPencatatan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPencatatan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPencatatan.Location = New System.Drawing.Point(379, 49)
        Me.txtTglPencatatan.Name = "txtTglPencatatan"
        Me.txtTglPencatatan.Size = New System.Drawing.Size(101, 20)
        Me.txtTglPencatatan.TabIndex = 2
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Location = New System.Drawing.Point(108, 164)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(141, 20)
        Me.txtKodeProduksi.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Kode Produksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Kode Item Roll"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.Location = New System.Drawing.Point(108, 112)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(97, 20)
        Me.txtKodeItem.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Nama Item Roll"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Location = New System.Drawing.Point(108, 138)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(439, 20)
        Me.txtNamaItem.TabIndex = 4
        Me.txtNamaItem.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Quantity"
        '
        'txtPanjangRoll
        '
        Me.txtPanjangRoll.AllowEnterToMoveNext = True
        Me.txtPanjangRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPanjangRoll.CheckIsValid = False
        Me.txtPanjangRoll.DataFormat = "###,###"
        Me.txtPanjangRoll.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPanjangRoll.Location = New System.Drawing.Point(108, 221)
        Me.txtPanjangRoll.Name = "txtPanjangRoll"
        Me.txtPanjangRoll.ReadOnly = True
        Me.txtPanjangRoll.Size = New System.Drawing.Size(141, 20)
        Me.txtPanjangRoll.TabIndex = 6
        Me.txtPanjangRoll.TabStop = False
        Me.txtPanjangRoll.Text = "0"
        Me.txtPanjangRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPanjangRoll.Value = 0.0R
        '
        'txtBeratRoll
        '
        Me.txtBeratRoll.AllowEnterToMoveNext = True
        Me.txtBeratRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratRoll.CheckIsValid = False
        Me.txtBeratRoll.DataFormat = "###,###.##"
        Me.txtBeratRoll.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratRoll.Location = New System.Drawing.Point(255, 221)
        Me.txtBeratRoll.Name = "txtBeratRoll"
        Me.txtBeratRoll.ReadOnly = True
        Me.txtBeratRoll.Size = New System.Drawing.Size(113, 20)
        Me.txtBeratRoll.TabIndex = 7
        Me.txtBeratRoll.TabStop = False
        Me.txtBeratRoll.Text = "0.00"
        Me.txtBeratRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratRoll.Value = 0.0R
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label14.Location = New System.Drawing.Point(19, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(528, 21)
        Me.Label14.TabIndex = 151
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label8.Location = New System.Drawing.Point(105, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Panjang Roll"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label7.Location = New System.Drawing.Point(252, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "Berat Roll"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 4)
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 289)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(567, 54)
        Me.Panel6.TabIndex = 9
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(567, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(374, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(463, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'tmrJam
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(108, 247)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(439, 20)
        Me.txtKeterangan.TabIndex = 8
        '
        'frmProduksiMakloonRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 343)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBeratRoll)
        Me.Controls.Add(Me.txtPanjangRoll)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.txtTglPencatatan)
        Me.Controls.Add(Me.cboKodeUnit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProduksiMakloonRoll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengakuan Makloon Roll"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtTglPencatatan As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPanjangRoll As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratRoll As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
End Class
