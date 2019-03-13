<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitProduksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnitProduksi))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaUnit = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeUnit = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btLookupKodeSatuan3 = New System.Windows.Forms.Button()
        Me.cboKodeSatuan3 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeSatuan2 = New System.Windows.Forms.Button()
        Me.cboKodeSatuan2 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeSatuan1 = New System.Windows.Forms.Button()
        Me.cboKodeSatuan1 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodeUnitSAP = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPemakaian = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.chkAfval = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.chkProduksi = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.List = New System.Windows.Forms.ListView()
        Me.chkList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Kode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UnitProduksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrefikKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btLookupKodeLokasi = New System.Windows.Forms.Button()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(493, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(404, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtNamaUnit
        '
        Me.txtNamaUnit.AllowEnterToMoveNext = True
        Me.txtNamaUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaUnit.BackColor = System.Drawing.Color.White
        Me.txtNamaUnit.Location = New System.Drawing.Point(110, 47)
        Me.txtNamaUnit.MaxLength = 50
        Me.txtNamaUnit.Name = "txtNamaUnit"
        Me.txtNamaUnit.Size = New System.Drawing.Size(466, 20)
        Me.txtNamaUnit.TabIndex = 1
        '
        'txtKodeUnit
        '
        Me.txtKodeUnit.AllowEnterToMoveNext = True
        Me.txtKodeUnit.BackColor = System.Drawing.Color.White
        Me.txtKodeUnit.Location = New System.Drawing.Point(110, 22)
        Me.txtKodeUnit.MaxLength = 6
        Me.txtKodeUnit.Name = "txtKodeUnit"
        Me.txtKodeUnit.Size = New System.Drawing.Size(69, 20)
        Me.txtKodeUnit.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Unit"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Unit"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(182, 23)
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
        Me.panel2.Location = New System.Drawing.Point(0, 417)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(600, 54)
        Me.panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(600, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(22, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Satuan"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btLookupKodeSatuan3
        '
        Me.btLookupKodeSatuan3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeSatuan3.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan3.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan3.Location = New System.Drawing.Point(553, 381)
        Me.btLookupKodeSatuan3.Name = "btLookupKodeSatuan3"
        Me.btLookupKodeSatuan3.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan3.TabIndex = 123
        Me.btLookupKodeSatuan3.TabStop = False
        Me.btLookupKodeSatuan3.Text = ".."
        Me.btLookupKodeSatuan3.UseVisualStyleBackColor = False
        '
        'cboKodeSatuan3
        '
        Me.cboKodeSatuan3.AllowEnterToMoveNext = True
        Me.cboKodeSatuan3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeSatuan3.DataLocked = False
        Me.cboKodeSatuan3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeSatuan3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeSatuan3.FormattingEnabled = True
        Me.cboKodeSatuan3.IndexLocked = False
        Me.cboKodeSatuan3.Location = New System.Drawing.Point(427, 381)
        Me.cboKodeSatuan3.Name = "cboKodeSatuan3"
        Me.cboKodeSatuan3.Size = New System.Drawing.Size(125, 21)
        Me.cboKodeSatuan3.TabIndex = 8
        '
        'btLookupKodeSatuan2
        '
        Me.btLookupKodeSatuan2.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan2.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan2.Location = New System.Drawing.Point(394, 381)
        Me.btLookupKodeSatuan2.Name = "btLookupKodeSatuan2"
        Me.btLookupKodeSatuan2.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan2.TabIndex = 122
        Me.btLookupKodeSatuan2.TabStop = False
        Me.btLookupKodeSatuan2.Text = ".."
        Me.btLookupKodeSatuan2.UseVisualStyleBackColor = False
        '
        'cboKodeSatuan2
        '
        Me.cboKodeSatuan2.AllowEnterToMoveNext = True
        Me.cboKodeSatuan2.DataLocked = False
        Me.cboKodeSatuan2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeSatuan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeSatuan2.FormattingEnabled = True
        Me.cboKodeSatuan2.IndexLocked = False
        Me.cboKodeSatuan2.Location = New System.Drawing.Point(268, 381)
        Me.cboKodeSatuan2.Name = "cboKodeSatuan2"
        Me.cboKodeSatuan2.Size = New System.Drawing.Size(125, 21)
        Me.cboKodeSatuan2.TabIndex = 7
        '
        'btLookupKodeSatuan1
        '
        Me.btLookupKodeSatuan1.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan1.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan1.Location = New System.Drawing.Point(236, 381)
        Me.btLookupKodeSatuan1.Name = "btLookupKodeSatuan1"
        Me.btLookupKodeSatuan1.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan1.TabIndex = 121
        Me.btLookupKodeSatuan1.TabStop = False
        Me.btLookupKodeSatuan1.Text = ".."
        Me.btLookupKodeSatuan1.UseVisualStyleBackColor = False
        '
        'cboKodeSatuan1
        '
        Me.cboKodeSatuan1.AllowEnterToMoveNext = True
        Me.cboKodeSatuan1.DataLocked = False
        Me.cboKodeSatuan1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeSatuan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeSatuan1.FormattingEnabled = True
        Me.cboKodeSatuan1.IndexLocked = False
        Me.cboKodeSatuan1.Location = New System.Drawing.Point(110, 381)
        Me.cboKodeSatuan1.Name = "cboKodeSatuan1"
        Me.cboKodeSatuan1.Size = New System.Drawing.Size(125, 21)
        Me.cboKodeSatuan1.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label14.Location = New System.Drawing.Point(-7, 351)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(615, 21)
        Me.Label14.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label7.Location = New System.Drawing.Point(424, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Berat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Location = New System.Drawing.Point(265, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(107, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Kemasan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Kode Unit SAP"
        '
        'txtKodeUnitSAP
        '
        Me.txtKodeUnitSAP.AllowEnterToMoveNext = True
        Me.txtKodeUnitSAP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeUnitSAP.BackColor = System.Drawing.Color.White
        Me.txtKodeUnitSAP.Location = New System.Drawing.Point(110, 72)
        Me.txtKodeUnitSAP.MaxLength = 50
        Me.txtKodeUnitSAP.Name = "txtKodeUnitSAP"
        Me.txtKodeUnitSAP.Size = New System.Drawing.Size(466, 20)
        Me.txtKodeUnitSAP.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPemakaian)
        Me.GroupBox1.Controls.Add(Me.chkAfval)
        Me.GroupBox1.Controls.Add(Me.chkProduksi)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 73)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "      No. Mesin Pada Proses Timbang"
        '
        'chkPemakaian
        '
        Me.chkPemakaian.AllowEnterToMoveNext = True
        Me.chkPemakaian.AutoSize = True
        Me.chkPemakaian.Location = New System.Drawing.Point(126, 32)
        Me.chkPemakaian.Name = "chkPemakaian"
        Me.chkPemakaian.Size = New System.Drawing.Size(113, 17)
        Me.chkPemakaian.TabIndex = 1
        Me.chkPemakaian.Text = "Pemakaian Bahan"
        Me.chkPemakaian.UseVisualStyleBackColor = True
        '
        'chkAfval
        '
        Me.chkAfval.AllowEnterToMoveNext = True
        Me.chkAfval.AutoSize = True
        Me.chkAfval.Location = New System.Drawing.Point(255, 32)
        Me.chkAfval.Name = "chkAfval"
        Me.chkAfval.Size = New System.Drawing.Size(50, 17)
        Me.chkAfval.TabIndex = 2
        Me.chkAfval.Text = "Afval"
        Me.chkAfval.UseVisualStyleBackColor = True
        '
        'chkProduksi
        '
        Me.chkProduksi.AllowEnterToMoveNext = True
        Me.chkProduksi.AutoSize = True
        Me.chkProduksi.Location = New System.Drawing.Point(27, 32)
        Me.chkProduksi.Name = "chkProduksi"
        Me.chkProduksi.Size = New System.Drawing.Size(93, 17)
        Me.chkProduksi.TabIndex = 0
        Me.chkProduksi.Text = "Hasil Produksi"
        Me.chkProduksi.UseVisualStyleBackColor = True
        '
        'List
        '
        Me.List.CheckBoxes = True
        Me.List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chkList, Me.Kode, Me.UnitProduksi})
        Me.List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.List.Location = New System.Drawing.Point(110, 97)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(466, 107)
        Me.List.TabIndex = 3
        Me.List.UseCompatibleStateImageBehavior = False
        Me.List.View = System.Windows.Forms.View.Details
        '
        'chkList
        '
        Me.chkList.Text = ""
        Me.chkList.Width = 20
        '
        'Kode
        '
        Me.Kode.Text = "Kode"
        Me.Kode.Width = 85
        '
        'UnitProduksi
        '
        Me.UnitProduksi.Text = "Unit Produksi"
        Me.UnitProduksi.Width = 336
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Unit Tujuan"
        '
        'txtPrefikKodeProduksi
        '
        Me.txtPrefikKodeProduksi.AllowEnterToMoveNext = True
        Me.txtPrefikKodeProduksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrefikKodeProduksi.BackColor = System.Drawing.Color.White
        Me.txtPrefikKodeProduksi.Location = New System.Drawing.Point(110, 210)
        Me.txtPrefikKodeProduksi.MaxLength = 2
        Me.txtPrefikKodeProduksi.Name = "txtPrefikKodeProduksi"
        Me.txtPrefikKodeProduksi.Size = New System.Drawing.Size(466, 20)
        Me.txtPrefikKodeProduksi.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Prefik Produksi"
        '
        'btLookupKodeLokasi
        '
        Me.btLookupKodeLokasi.Location = New System.Drawing.Point(549, 236)
        Me.btLookupKodeLokasi.Name = "btLookupKodeLokasi"
        Me.btLookupKodeLokasi.Size = New System.Drawing.Size(27, 23)
        Me.btLookupKodeLokasi.TabIndex = 136
        Me.btLookupKodeLokasi.TabStop = False
        Me.btLookupKodeLokasi.Text = "..."
        Me.btLookupKodeLokasi.UseVisualStyleBackColor = True
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = False
        Me.cboKodeLokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = False
        Me.cboKodeLokasi.Location = New System.Drawing.Point(110, 236)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(437, 21)
        Me.cboKodeLokasi.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Lokasi Produksi"
        '
        'frmUnitProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(600, 471)
        Me.Controls.Add(Me.btLookupKodeLokasi)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrefikKodeProduksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtKodeUnitSAP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btLookupKodeSatuan3)
        Me.Controls.Add(Me.cboKodeSatuan3)
        Me.Controls.Add(Me.btLookupKodeSatuan2)
        Me.Controls.Add(Me.cboKodeSatuan2)
        Me.Controls.Add(Me.btLookupKodeSatuan1)
        Me.Controls.Add(Me.cboKodeSatuan1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaUnit)
        Me.Controls.Add(Me.txtKodeUnit)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(616, 488)
        Me.Name = "frmUnitProduksi"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unit Produksi"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaUnit As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeUnit As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeSatuan3 As System.Windows.Forms.Button
    Friend WithEvents cboKodeSatuan3 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeSatuan2 As System.Windows.Forms.Button
    Friend WithEvents cboKodeSatuan2 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeSatuan1 As System.Windows.Forms.Button
    Friend WithEvents cboKodeSatuan1 As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txtKodeUnitSAP As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAfval As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents chkProduksi As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents List As System.Windows.Forms.ListView
    Friend WithEvents chkList As System.Windows.Forms.ColumnHeader
    Friend WithEvents Kode As System.Windows.Forms.ColumnHeader
    Friend WithEvents UnitProduksi As System.Windows.Forms.ColumnHeader
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtPrefikKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkPemakaian As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents btLookupKodeLokasi As System.Windows.Forms.Button
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
