<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMesin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMesin))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaMesin = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeMesin = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUnitProduksi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.chkAktif = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.txtKodeMesinSAP = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboJenisMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupJenisMesin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
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
        'txtNamaMesin
        '
        Me.txtNamaMesin.AllowEnterToMoveNext = True
        Me.txtNamaMesin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaMesin.BackColor = System.Drawing.Color.White
        Me.txtNamaMesin.Location = New System.Drawing.Point(113, 47)
        Me.txtNamaMesin.MaxLength = 50
        Me.txtNamaMesin.Name = "txtNamaMesin"
        Me.txtNamaMesin.Size = New System.Drawing.Size(405, 20)
        Me.txtNamaMesin.TabIndex = 1
        '
        'txtKodeMesin
        '
        Me.txtKodeMesin.AllowEnterToMoveNext = True
        Me.txtKodeMesin.BackColor = System.Drawing.Color.White
        Me.txtKodeMesin.Location = New System.Drawing.Point(113, 22)
        Me.txtKodeMesin.MaxLength = 6
        Me.txtKodeMesin.Name = "txtKodeMesin"
        Me.txtKodeMesin.Size = New System.Drawing.Size(77, 20)
        Me.txtKodeMesin.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Mesin"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Mesin"
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
        Me.panel2.Location = New System.Drawing.Point(0, 169)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(542, 54)
        Me.panel2.TabIndex = 4
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
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Unit Produksi"
        '
        'cboUnitProduksi
        '
        Me.cboUnitProduksi.AllowEnterToMoveNext = True
        Me.cboUnitProduksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUnitProduksi.BackColor = System.Drawing.Color.White
        Me.cboUnitProduksi.DataLocked = False
        Me.cboUnitProduksi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUnitProduksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnitProduksi.IndexLocked = False
        Me.cboUnitProduksi.Location = New System.Drawing.Point(113, 72)
        Me.cboUnitProduksi.Name = "cboUnitProduksi"
        Me.cboUnitProduksi.Size = New System.Drawing.Size(381, 21)
        Me.cboUnitProduksi.TabIndex = 2
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
        'chkAktif
        '
        Me.chkAktif.AllowEnterToMoveNext = True
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Location = New System.Drawing.Point(471, 21)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(47, 17)
        Me.chkAktif.TabIndex = 86
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'txtKodeMesinSAP
        '
        Me.txtKodeMesinSAP.AllowEnterToMoveNext = True
        Me.txtKodeMesinSAP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeMesinSAP.BackColor = System.Drawing.Color.White
        Me.txtKodeMesinSAP.Location = New System.Drawing.Point(113, 98)
        Me.txtKodeMesinSAP.MaxLength = 50
        Me.txtKodeMesinSAP.Name = "txtKodeMesinSAP"
        Me.txtKodeMesinSAP.Size = New System.Drawing.Size(104, 20)
        Me.txtKodeMesinSAP.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Kode Mesin SAP"
        '
        'cboJenisMesin
        '
        Me.cboJenisMesin.AllowEnterToMoveNext = True
        Me.cboJenisMesin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboJenisMesin.BackColor = System.Drawing.Color.White
        Me.cboJenisMesin.DataLocked = False
        Me.cboJenisMesin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJenisMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenisMesin.IndexLocked = False
        Me.cboJenisMesin.Location = New System.Drawing.Point(113, 123)
        Me.cboJenisMesin.Name = "cboJenisMesin"
        Me.cboJenisMesin.Size = New System.Drawing.Size(381, 21)
        Me.cboJenisMesin.TabIndex = 89
        '
        'btLookupJenisMesin
        '
        Me.btLookupJenisMesin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupJenisMesin.BackColor = System.Drawing.Color.Transparent
        Me.btLookupJenisMesin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupJenisMesin.ForeColor = System.Drawing.Color.Silver
        Me.btLookupJenisMesin.Location = New System.Drawing.Point(495, 123)
        Me.btLookupJenisMesin.Name = "btLookupJenisMesin"
        Me.btLookupJenisMesin.Size = New System.Drawing.Size(23, 21)
        Me.btLookupJenisMesin.TabIndex = 91
        Me.btLookupJenisMesin.TabStop = False
        Me.btLookupJenisMesin.Text = ".."
        Me.btLookupJenisMesin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Jenis Mesin"
        '
        'frmMesin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 223)
        Me.Controls.Add(Me.cboJenisMesin)
        Me.Controls.Add(Me.btLookupJenisMesin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKodeMesinSAP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkAktif)
        Me.Controls.Add(Me.cboUnitProduksi)
        Me.Controls.Add(Me.btLookupKodeUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaMesin)
        Me.Controls.Add(Me.txtKodeMesin)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 205)
        Me.Name = "frmMesin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mesin"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaMesin As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeMesin As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboUnitProduksi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Friend WithEvents chkAktif As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents txtKodeMesinSAP As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboJenisMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupJenisMesin As System.Windows.Forms.Button
    Private WithEvents Label5 As System.Windows.Forms.Label
End Class
