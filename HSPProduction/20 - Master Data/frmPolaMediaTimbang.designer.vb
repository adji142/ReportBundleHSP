<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPolaMediaTimbang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPolaMediaTimbang))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaPola = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodePola = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboKodeMedia1 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeMedia1 = New System.Windows.Forms.Button()
        Me.cboKodeMedia2 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeMedia2 = New System.Windows.Forms.Button()
        Me.cboKodeMedia3 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeMedia3 = New System.Windows.Forms.Button()
        Me.chkMedia1 = New Enerzie.EPSBasicControls.EPSRadioButton()
        Me.chkMedia2 = New Enerzie.EPSBasicControls.EPSRadioButton()
        Me.chkMedia3 = New Enerzie.EPSBasicControls.EPSRadioButton()
        Me.txtJumlahDefault1 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtJumlahDefault2 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtJumlahDefault3 = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.lblSatuan1 = New System.Windows.Forms.Label()
        Me.lblSatuan2 = New System.Windows.Forms.Label()
        Me.lblSatuan3 = New System.Windows.Forms.Label()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(435, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 5
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(346, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtNamaPola
        '
        Me.txtNamaPola.AllowEnterToMoveNext = True
        Me.txtNamaPola.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaPola.BackColor = System.Drawing.Color.White
        Me.txtNamaPola.Location = New System.Drawing.Point(113, 47)
        Me.txtNamaPola.MaxLength = 50
        Me.txtNamaPola.Name = "txtNamaPola"
        Me.txtNamaPola.Size = New System.Drawing.Size(405, 20)
        Me.txtNamaPola.TabIndex = 1
        '
        'txtKodePola
        '
        Me.txtKodePola.AllowEnterToMoveNext = True
        Me.txtKodePola.BackColor = System.Drawing.Color.White
        Me.txtKodePola.Location = New System.Drawing.Point(113, 22)
        Me.txtKodePola.MaxLength = 6
        Me.txtKodePola.Name = "txtKodePola"
        Me.txtKodePola.Size = New System.Drawing.Size(77, 20)
        Me.txtKodePola.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Pola"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Pola"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(196, 23)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 23
        Me.Locked.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 234)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(542, 54)
        Me.panel2.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(542, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Lokasi Produksi"
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeLokasi.BackColor = System.Drawing.Color.White
        Me.cboKodeLokasi.DataLocked = False
        Me.cboKodeLokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasi.IndexLocked = False
        Me.cboKodeLokasi.Location = New System.Drawing.Point(113, 72)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(381, 21)
        Me.cboKodeLokasi.TabIndex = 2
        '
        'btLookupKodeUnit
        '
        Me.btLookupKodeUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeUnit.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeUnit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeUnit.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeUnit.Location = New System.Drawing.Point(495, 72)
        Me.btLookupKodeUnit.Name = "btLookupKodeUnit"
        Me.btLookupKodeUnit.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeUnit.TabIndex = 85
        Me.btLookupKodeUnit.TabStop = False
        Me.btLookupKodeUnit.Text = ".."
        Me.btLookupKodeUnit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Location = New System.Drawing.Point(112, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Media Timbang"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label15.Location = New System.Drawing.Point(-7, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(557, 21)
        Me.Label15.TabIndex = 131
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Location = New System.Drawing.Point(22, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 73)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Pola"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Location = New System.Drawing.Point(315, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 13)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Dasar Perhitungan Jumlah Kode Produksi"
        '
        'cboKodeMedia1
        '
        Me.cboKodeMedia1.AllowEnterToMoveNext = True
        Me.cboKodeMedia1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeMedia1.BackColor = System.Drawing.Color.White
        Me.cboKodeMedia1.DataLocked = False
        Me.cboKodeMedia1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMedia1.IndexLocked = False
        Me.cboKodeMedia1.Location = New System.Drawing.Point(113, 139)
        Me.cboKodeMedia1.Name = "cboKodeMedia1"
        Me.cboKodeMedia1.Size = New System.Drawing.Size(164, 21)
        Me.cboKodeMedia1.TabIndex = 3
        '
        'btLookupKodeMedia1
        '
        Me.btLookupKodeMedia1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeMedia1.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeMedia1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeMedia1.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeMedia1.Location = New System.Drawing.Point(278, 138)
        Me.btLookupKodeMedia1.Name = "btLookupKodeMedia1"
        Me.btLookupKodeMedia1.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeMedia1.TabIndex = 135
        Me.btLookupKodeMedia1.TabStop = False
        Me.btLookupKodeMedia1.Text = ".."
        Me.btLookupKodeMedia1.UseVisualStyleBackColor = False
        '
        'cboKodeMedia2
        '
        Me.cboKodeMedia2.AllowEnterToMoveNext = True
        Me.cboKodeMedia2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeMedia2.BackColor = System.Drawing.Color.White
        Me.cboKodeMedia2.DataLocked = False
        Me.cboKodeMedia2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMedia2.IndexLocked = False
        Me.cboKodeMedia2.Location = New System.Drawing.Point(113, 165)
        Me.cboKodeMedia2.Name = "cboKodeMedia2"
        Me.cboKodeMedia2.Size = New System.Drawing.Size(164, 21)
        Me.cboKodeMedia2.TabIndex = 6
        '
        'btLookupKodeMedia2
        '
        Me.btLookupKodeMedia2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeMedia2.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeMedia2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeMedia2.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeMedia2.Location = New System.Drawing.Point(278, 164)
        Me.btLookupKodeMedia2.Name = "btLookupKodeMedia2"
        Me.btLookupKodeMedia2.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeMedia2.TabIndex = 137
        Me.btLookupKodeMedia2.TabStop = False
        Me.btLookupKodeMedia2.Text = ".."
        Me.btLookupKodeMedia2.UseVisualStyleBackColor = False
        '
        'cboKodeMedia3
        '
        Me.cboKodeMedia3.AllowEnterToMoveNext = True
        Me.cboKodeMedia3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeMedia3.BackColor = System.Drawing.Color.White
        Me.cboKodeMedia3.DataLocked = False
        Me.cboKodeMedia3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMedia3.IndexLocked = False
        Me.cboKodeMedia3.Location = New System.Drawing.Point(113, 191)
        Me.cboKodeMedia3.Name = "cboKodeMedia3"
        Me.cboKodeMedia3.Size = New System.Drawing.Size(164, 21)
        Me.cboKodeMedia3.TabIndex = 9
        '
        'btLookupKodeMedia3
        '
        Me.btLookupKodeMedia3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeMedia3.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeMedia3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeMedia3.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeMedia3.Location = New System.Drawing.Point(278, 190)
        Me.btLookupKodeMedia3.Name = "btLookupKodeMedia3"
        Me.btLookupKodeMedia3.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeMedia3.TabIndex = 139
        Me.btLookupKodeMedia3.TabStop = False
        Me.btLookupKodeMedia3.Text = ".."
        Me.btLookupKodeMedia3.UseVisualStyleBackColor = False
        '
        'chkMedia1
        '
        Me.chkMedia1.AllowEnterToMoveNext = True
        Me.chkMedia1.AutoSize = True
        Me.chkMedia1.Location = New System.Drawing.Point(318, 140)
        Me.chkMedia1.Name = "chkMedia1"
        Me.chkMedia1.Size = New System.Drawing.Size(46, 17)
        Me.chkMedia1.TabIndex = 4
        Me.chkMedia1.TabStop = True
        Me.chkMedia1.Text = "Aktif"
        Me.chkMedia1.UseVisualStyleBackColor = True
        '
        'chkMedia2
        '
        Me.chkMedia2.AllowEnterToMoveNext = True
        Me.chkMedia2.AutoSize = True
        Me.chkMedia2.Location = New System.Drawing.Point(318, 166)
        Me.chkMedia2.Name = "chkMedia2"
        Me.chkMedia2.Size = New System.Drawing.Size(46, 17)
        Me.chkMedia2.TabIndex = 7
        Me.chkMedia2.TabStop = True
        Me.chkMedia2.Text = "Aktif"
        Me.chkMedia2.UseVisualStyleBackColor = True
        '
        'chkMedia3
        '
        Me.chkMedia3.AllowEnterToMoveNext = True
        Me.chkMedia3.AutoSize = True
        Me.chkMedia3.Location = New System.Drawing.Point(318, 192)
        Me.chkMedia3.Name = "chkMedia3"
        Me.chkMedia3.Size = New System.Drawing.Size(46, 17)
        Me.chkMedia3.TabIndex = 10
        Me.chkMedia3.TabStop = True
        Me.chkMedia3.Text = "Aktif"
        Me.chkMedia3.UseVisualStyleBackColor = True
        '
        'txtJumlahDefault1
        '
        Me.txtJumlahDefault1.AllowEnterToMoveNext = True
        Me.txtJumlahDefault1.CheckIsValid = False
        Me.txtJumlahDefault1.DataFormat = "###,##0.00"
        Me.txtJumlahDefault1.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahDefault1.Location = New System.Drawing.Point(400, 139)
        Me.txtJumlahDefault1.Name = "txtJumlahDefault1"
        Me.txtJumlahDefault1.Size = New System.Drawing.Size(37, 20)
        Me.txtJumlahDefault1.TabIndex = 5
        Me.txtJumlahDefault1.Text = "0.00"
        Me.txtJumlahDefault1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahDefault1.Value = 0.0R
        '
        'txtJumlahDefault2
        '
        Me.txtJumlahDefault2.AllowEnterToMoveNext = True
        Me.txtJumlahDefault2.CheckIsValid = False
        Me.txtJumlahDefault2.DataFormat = "###,##0.00"
        Me.txtJumlahDefault2.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahDefault2.Location = New System.Drawing.Point(400, 165)
        Me.txtJumlahDefault2.Name = "txtJumlahDefault2"
        Me.txtJumlahDefault2.Size = New System.Drawing.Size(37, 20)
        Me.txtJumlahDefault2.TabIndex = 8
        Me.txtJumlahDefault2.Text = "0.00"
        Me.txtJumlahDefault2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahDefault2.Value = 0.0R
        '
        'txtJumlahDefault3
        '
        Me.txtJumlahDefault3.AllowEnterToMoveNext = True
        Me.txtJumlahDefault3.CheckIsValid = False
        Me.txtJumlahDefault3.DataFormat = "###,##0.00"
        Me.txtJumlahDefault3.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahDefault3.Location = New System.Drawing.Point(400, 191)
        Me.txtJumlahDefault3.Name = "txtJumlahDefault3"
        Me.txtJumlahDefault3.Size = New System.Drawing.Size(37, 20)
        Me.txtJumlahDefault3.TabIndex = 11
        Me.txtJumlahDefault3.Text = "0.00"
        Me.txtJumlahDefault3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahDefault3.Value = 0.0R
        '
        'lblSatuan1
        '
        Me.lblSatuan1.AutoSize = True
        Me.lblSatuan1.Location = New System.Drawing.Point(440, 142)
        Me.lblSatuan1.Name = "lblSatuan1"
        Me.lblSatuan1.Size = New System.Drawing.Size(41, 13)
        Me.lblSatuan1.TabIndex = 140
        Me.lblSatuan1.Text = "Satuan"
        '
        'lblSatuan2
        '
        Me.lblSatuan2.AutoSize = True
        Me.lblSatuan2.Location = New System.Drawing.Point(440, 168)
        Me.lblSatuan2.Name = "lblSatuan2"
        Me.lblSatuan2.Size = New System.Drawing.Size(41, 13)
        Me.lblSatuan2.TabIndex = 141
        Me.lblSatuan2.Text = "Satuan"
        '
        'lblSatuan3
        '
        Me.lblSatuan3.AutoSize = True
        Me.lblSatuan3.Location = New System.Drawing.Point(440, 194)
        Me.lblSatuan3.Name = "lblSatuan3"
        Me.lblSatuan3.Size = New System.Drawing.Size(41, 13)
        Me.lblSatuan3.TabIndex = 142
        Me.lblSatuan3.Text = "Satuan"
        '
        'frmPolaMediaTimbang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 288)
        Me.Controls.Add(Me.lblSatuan3)
        Me.Controls.Add(Me.lblSatuan2)
        Me.Controls.Add(Me.lblSatuan1)
        Me.Controls.Add(Me.txtJumlahDefault3)
        Me.Controls.Add(Me.txtJumlahDefault2)
        Me.Controls.Add(Me.txtJumlahDefault1)
        Me.Controls.Add(Me.chkMedia3)
        Me.Controls.Add(Me.chkMedia2)
        Me.Controls.Add(Me.chkMedia1)
        Me.Controls.Add(Me.cboKodeMedia3)
        Me.Controls.Add(Me.btLookupKodeMedia3)
        Me.Controls.Add(Me.cboKodeMedia2)
        Me.Controls.Add(Me.btLookupKodeMedia2)
        Me.Controls.Add(Me.cboKodeMedia1)
        Me.Controls.Add(Me.btLookupKodeMedia1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.btLookupKodeUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaPola)
        Me.Controls.Add(Me.txtKodePola)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label15)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 233)
        Me.Name = "frmPolaMediaTimbang"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pola Media Timbang"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaPola As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodePola As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents cboKodeMedia1 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeMedia1 As System.Windows.Forms.Button
    Private WithEvents cboKodeMedia2 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeMedia2 As System.Windows.Forms.Button
    Private WithEvents cboKodeMedia3 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeMedia3 As System.Windows.Forms.Button
    Friend WithEvents chkMedia1 As Enerzie.EPSBasicControls.EPSRadioButton
    Friend WithEvents chkMedia2 As Enerzie.EPSBasicControls.EPSRadioButton
    Friend WithEvents chkMedia3 As Enerzie.EPSBasicControls.EPSRadioButton
    Friend WithEvents txtJumlahDefault1 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtJumlahDefault2 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtJumlahDefault3 As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents lblSatuan1 As System.Windows.Forms.Label
    Private WithEvents lblSatuan2 As System.Windows.Forms.Label
    Private WithEvents lblSatuan3 As System.Windows.Forms.Label
End Class
