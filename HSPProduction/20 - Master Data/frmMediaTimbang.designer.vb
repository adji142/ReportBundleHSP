<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediaTimbang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMediaTimbang))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaMedia = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeMedia = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeLokasi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkAktif = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.cboKodeSatuan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeSatuan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
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
        'txtNamaMedia
        '
        Me.txtNamaMedia.AllowEnterToMoveNext = True
        Me.txtNamaMedia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaMedia.BackColor = System.Drawing.Color.White
        Me.txtNamaMedia.Location = New System.Drawing.Point(113, 47)
        Me.txtNamaMedia.MaxLength = 50
        Me.txtNamaMedia.Name = "txtNamaMedia"
        Me.txtNamaMedia.Size = New System.Drawing.Size(405, 20)
        Me.txtNamaMedia.TabIndex = 1
        '
        'txtKodeMedia
        '
        Me.txtKodeMedia.AllowEnterToMoveNext = True
        Me.txtKodeMedia.BackColor = System.Drawing.Color.White
        Me.txtKodeMedia.Location = New System.Drawing.Point(113, 22)
        Me.txtKodeMedia.MaxLength = 6
        Me.txtKodeMedia.Name = "txtKodeMedia"
        Me.txtKodeMedia.Size = New System.Drawing.Size(77, 20)
        Me.txtKodeMedia.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(67, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Media"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Media"
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
        Me.panel2.Location = New System.Drawing.Point(0, 226)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(542, 54)
        Me.panel2.TabIndex = 7
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
        Me.Label3.Location = New System.Drawing.Point(22, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Lokasi"
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
        Me.cboKodeLokasi.Location = New System.Drawing.Point(113, 97)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(381, 21)
        Me.cboKodeLokasi.TabIndex = 3
        '
        'btLookupKodeLokasi
        '
        Me.btLookupKodeLokasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeLokasi.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeLokasi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeLokasi.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeLokasi.Location = New System.Drawing.Point(495, 97)
        Me.btLookupKodeLokasi.Name = "btLookupKodeLokasi"
        Me.btLookupKodeLokasi.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeLokasi.TabIndex = 85
        Me.btLookupKodeLokasi.TabStop = False
        Me.btLookupKodeLokasi.Text = ".."
        Me.btLookupKodeLokasi.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Berat Media"
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.CheckIsValid = False
        Me.txtBeratMedia.DataFormat = "###,##0.000"
        Me.txtBeratMedia.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratMedia.Location = New System.Drawing.Point(113, 72)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.Size = New System.Drawing.Size(77, 20)
        Me.txtBeratMedia.TabIndex = 2
        Me.txtBeratMedia.Text = "0.000"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratMedia.Value = 0.0R
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "KG"
        '
        'chkAktif
        '
        Me.chkAktif.AllowEnterToMoveNext = True
        Me.chkAktif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Location = New System.Drawing.Point(113, 158)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(218, 17)
        Me.chkAktif.TabIndex = 5
        Me.chkAktif.Text = "Ijinkan Pengisian Jumlah Media Timbang"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'cboKodeSatuan
        '
        Me.cboKodeSatuan.AllowEnterToMoveNext = True
        Me.cboKodeSatuan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeSatuan.BackColor = System.Drawing.Color.White
        Me.cboKodeSatuan.DataLocked = False
        Me.cboKodeSatuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeSatuan.IndexLocked = False
        Me.cboKodeSatuan.Location = New System.Drawing.Point(113, 181)
        Me.cboKodeSatuan.Name = "cboKodeSatuan"
        Me.cboKodeSatuan.Size = New System.Drawing.Size(381, 21)
        Me.cboKodeSatuan.TabIndex = 6
        '
        'btLookupKodeSatuan
        '
        Me.btLookupKodeSatuan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeSatuan.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeSatuan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeSatuan.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeSatuan.Location = New System.Drawing.Point(495, 181)
        Me.btLookupKodeSatuan.Name = "btLookupKodeSatuan"
        Me.btLookupKodeSatuan.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeSatuan.TabIndex = 92
        Me.btLookupKodeSatuan.TabStop = False
        Me.btLookupKodeSatuan.Text = ".."
        Me.btLookupKodeSatuan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Satuan Pokok"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKodeUnit.BackColor = System.Drawing.Color.White
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(113, 124)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(381, 21)
        Me.cboKodeUnit.TabIndex = 4
        '
        'btLookupKodeUnit
        '
        Me.btLookupKodeUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeUnit.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeUnit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeUnit.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeUnit.Location = New System.Drawing.Point(495, 124)
        Me.btLookupKodeUnit.Name = "btLookupKodeUnit"
        Me.btLookupKodeUnit.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeUnit.TabIndex = 95
        Me.btLookupKodeUnit.TabStop = False
        Me.btLookupKodeUnit.Text = ".."
        Me.btLookupKodeUnit.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Unit Produksi"
        '
        'frmMediaTimbang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 280)
        Me.Controls.Add(Me.cboKodeUnit)
        Me.Controls.Add(Me.btLookupKodeUnit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboKodeSatuan)
        Me.Controls.Add(Me.btLookupKodeSatuan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkAktif)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBeratMedia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.btLookupKodeLokasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaMedia)
        Me.Controls.Add(Me.txtKodeMedia)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 285)
        Me.Name = "frmMediaTimbang"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Media Timbang"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaMedia As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeMedia As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeLokasi As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkAktif As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents cboKodeSatuan As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeSatuan As System.Windows.Forms.Button
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Private WithEvents Label7 As System.Windows.Forms.Label
End Class
