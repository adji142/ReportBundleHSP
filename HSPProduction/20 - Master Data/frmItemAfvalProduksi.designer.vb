<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemPemakaianProduksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemPemakaianProduksi))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkAktif = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.cboKodeKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeSatuan1 = New System.Windows.Forms.Button()
        Me.cboKodeSatuan1 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeSatuan2 = New System.Windows.Forms.Button()
        Me.cboKodeSatuan2 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeSatuan3 = New System.Windows.Forms.Button()
        Me.cboKodeSatuan3 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeItemSistem = New System.Windows.Forms.Button()
        Me.txtKodeItemSistem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNamaItemSistem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(346, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaItem.BackColor = System.Drawing.Color.White
        Me.txtNamaItem.Location = New System.Drawing.Point(123, 84)
        Me.txtNamaItem.MaxLength = 50
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.Size = New System.Drawing.Size(399, 20)
        Me.txtNamaItem.TabIndex = 1
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.White
        Me.txtKodeItem.Location = New System.Drawing.Point(123, 59)
        Me.txtKodeItem.MaxLength = 15
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(103, 20)
        Me.txtKodeItem.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 87)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Item"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 62)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Item"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(232, 60)
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
        Me.panel2.Location = New System.Drawing.Point(0, 254)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(542, 54)
        Me.panel2.TabIndex = 13
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
        Me.Label3.Location = New System.Drawing.Point(22, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Unit Produksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Kelompok Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Location = New System.Drawing.Point(124, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Kemasan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Location = New System.Drawing.Point(260, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Unit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label7.Location = New System.Drawing.Point(396, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Berat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Kode Item Sistem"
        '
        'chkAktif
        '
        Me.chkAktif.AllowEnterToMoveNext = True
        Me.chkAktif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Location = New System.Drawing.Point(471, 58)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(47, 17)
        Me.chkAktif.TabIndex = 89
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(123, 110)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(379, 21)
        Me.cboKodeUnit.TabIndex = 3
        '
        'btLookupKodeUnit
        '
        Me.btLookupKodeUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeUnit.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeUnit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeUnit.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeUnit.Location = New System.Drawing.Point(503, 110)
        Me.btLookupKodeUnit.Name = "btLookupKodeUnit"
        Me.btLookupKodeUnit.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeUnit.TabIndex = 91
        Me.btLookupKodeUnit.TabStop = False
        Me.btLookupKodeUnit.Text = ".."
        Me.btLookupKodeUnit.UseVisualStyleBackColor = False
        '
        'cboKodeKelompok
        '
        Me.cboKodeKelompok.AllowEnterToMoveNext = True
        Me.cboKodeKelompok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeKelompok.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKodeKelompok.DataLocked = False
        Me.cboKodeKelompok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeKelompok.FormattingEnabled = True
        Me.cboKodeKelompok.IndexLocked = True
        Me.cboKodeKelompok.Location = New System.Drawing.Point(123, 12)
        Me.cboKodeKelompok.Name = "cboKodeKelompok"
        Me.cboKodeKelompok.Size = New System.Drawing.Size(399, 21)
        Me.cboKodeKelompok.TabIndex = 2
        Me.cboKodeKelompok.TabStop = False
        '
        'btLookupKodeSatuan1
        '
        Me.btLookupKodeSatuan1.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan1.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan1.Location = New System.Drawing.Point(231, 180)
        Me.btLookupKodeSatuan1.Name = "btLookupKodeSatuan1"
        Me.btLookupKodeSatuan1.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan1.TabIndex = 95
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
        Me.cboKodeSatuan1.Location = New System.Drawing.Point(123, 181)
        Me.cboKodeSatuan1.Name = "cboKodeSatuan1"
        Me.cboKodeSatuan1.Size = New System.Drawing.Size(107, 21)
        Me.cboKodeSatuan1.TabIndex = 9
        '
        'btLookupKodeSatuan2
        '
        Me.btLookupKodeSatuan2.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan2.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan2.Location = New System.Drawing.Point(367, 180)
        Me.btLookupKodeSatuan2.Name = "btLookupKodeSatuan2"
        Me.btLookupKodeSatuan2.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan2.TabIndex = 97
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
        Me.cboKodeSatuan2.Location = New System.Drawing.Point(263, 181)
        Me.cboKodeSatuan2.Name = "cboKodeSatuan2"
        Me.cboKodeSatuan2.Size = New System.Drawing.Size(103, 21)
        Me.cboKodeSatuan2.TabIndex = 10
        '
        'btLookupKodeSatuan3
        '
        Me.btLookupKodeSatuan3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeSatuan3.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan3.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan3.Location = New System.Drawing.Point(503, 180)
        Me.btLookupKodeSatuan3.Name = "btLookupKodeSatuan3"
        Me.btLookupKodeSatuan3.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan3.TabIndex = 99
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
        Me.cboKodeSatuan3.Location = New System.Drawing.Point(399, 181)
        Me.cboKodeSatuan3.Name = "cboKodeSatuan3"
        Me.cboKodeSatuan3.Size = New System.Drawing.Size(103, 21)
        Me.cboKodeSatuan3.TabIndex = 11
        '
        'btLookupKodeItemSistem
        '
        Me.btLookupKodeItemSistem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeItemSistem.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeItemSistem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeItemSistem.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeItemSistem.Location = New System.Drawing.Point(231, 213)
        Me.btLookupKodeItemSistem.Name = "btLookupKodeItemSistem"
        Me.btLookupKodeItemSistem.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeItemSistem.TabIndex = 101
        Me.btLookupKodeItemSistem.TabStop = False
        Me.btLookupKodeItemSistem.Text = ".."
        Me.btLookupKodeItemSistem.UseVisualStyleBackColor = False
        '
        'txtKodeItemSistem
        '
        Me.txtKodeItemSistem.AllowEnterToMoveNext = True
        Me.txtKodeItemSistem.BackColor = System.Drawing.Color.White
        Me.txtKodeItemSistem.Location = New System.Drawing.Point(121, 214)
        Me.txtKodeItemSistem.MaxLength = 15
        Me.txtKodeItemSistem.Name = "txtKodeItemSistem"
        Me.txtKodeItemSistem.Size = New System.Drawing.Size(109, 20)
        Me.txtKodeItemSistem.TabIndex = 12
        '
        'txtNamaItemSistem
        '
        Me.txtNamaItemSistem.AllowEnterToMoveNext = True
        Me.txtNamaItemSistem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaItemSistem.BackColor = System.Drawing.Color.White
        Me.txtNamaItemSistem.Location = New System.Drawing.Point(263, 214)
        Me.txtNamaItemSistem.MaxLength = 15
        Me.txtNamaItemSistem.Name = "txtNamaItemSistem"
        Me.txtNamaItemSistem.ReadOnly = True
        Me.txtNamaItemSistem.Size = New System.Drawing.Size(263, 20)
        Me.txtNamaItemSistem.TabIndex = 115
        Me.txtNamaItemSistem.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(26, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Satuan"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label14.Location = New System.Drawing.Point(-3, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(557, 21)
        Me.Label14.TabIndex = 117
        '
        'frmItemPemakaianProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 308)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNamaItemSistem)
        Me.Controls.Add(Me.txtKodeItemSistem)
        Me.Controls.Add(Me.btLookupKodeItemSistem)
        Me.Controls.Add(Me.btLookupKodeSatuan3)
        Me.Controls.Add(Me.cboKodeSatuan3)
        Me.Controls.Add(Me.btLookupKodeSatuan2)
        Me.Controls.Add(Me.cboKodeSatuan2)
        Me.Controls.Add(Me.btLookupKodeSatuan1)
        Me.Controls.Add(Me.cboKodeSatuan1)
        Me.Controls.Add(Me.cboKodeKelompok)
        Me.Controls.Add(Me.btLookupKodeUnit)
        Me.Controls.Add(Me.cboKodeUnit)
        Me.Controls.Add(Me.chkAktif)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label14)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemPemakaianProduksi"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Pemakaian Produksi"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkAktif As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Friend WithEvents cboKodeKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeSatuan1 As System.Windows.Forms.Button
    Friend WithEvents cboKodeSatuan1 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeSatuan2 As System.Windows.Forms.Button
    Friend WithEvents cboKodeSatuan2 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeSatuan3 As System.Windows.Forms.Button
    Friend WithEvents cboKodeSatuan3 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeItemSistem As System.Windows.Forms.Button
    Private WithEvents txtKodeItemSistem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtNamaItemSistem As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
End Class
