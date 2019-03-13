<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLokasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLokasi))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaLokasi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeLokasi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrefiks = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.chkBenang = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.chkRoll = New Enerzie.EPSBasicControls.EPSCheckBox()
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
        'txtNamaLokasi
        '
        Me.txtNamaLokasi.AllowEnterToMoveNext = True
        Me.txtNamaLokasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaLokasi.BackColor = System.Drawing.Color.White
        Me.txtNamaLokasi.Location = New System.Drawing.Point(115, 47)
        Me.txtNamaLokasi.MaxLength = 50
        Me.txtNamaLokasi.Name = "txtNamaLokasi"
        Me.txtNamaLokasi.Size = New System.Drawing.Size(403, 20)
        Me.txtNamaLokasi.TabIndex = 1
        '
        'txtKodeLokasi
        '
        Me.txtKodeLokasi.AllowEnterToMoveNext = True
        Me.txtKodeLokasi.BackColor = System.Drawing.Color.White
        Me.txtKodeLokasi.Location = New System.Drawing.Point(115, 22)
        Me.txtKodeLokasi.MaxLength = 6
        Me.txtKodeLokasi.Name = "txtKodeLokasi"
        Me.txtKodeLokasi.Size = New System.Drawing.Size(81, 20)
        Me.txtKodeLokasi.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(69, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Lokasi"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Lokasi"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(202, 23)
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
        Me.panel2.Location = New System.Drawing.Point(0, 199)
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
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Prefiks Produksi"
        '
        'txtPrefiks
        '
        Me.txtPrefiks.AllowEnterToMoveNext = True
        Me.txtPrefiks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrefiks.BackColor = System.Drawing.Color.White
        Me.txtPrefiks.Location = New System.Drawing.Point(115, 72)
        Me.txtPrefiks.MaxLength = 50
        Me.txtPrefiks.Name = "txtPrefiks"
        Me.txtPrefiks.Size = New System.Drawing.Size(81, 20)
        Me.txtPrefiks.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Lokasi"
        '
        'cboLokasi
        '
        Me.cboLokasi.AllowEnterToMoveNext = True
        Me.cboLokasi.DataLocked = False
        Me.cboLokasi.FormattingEnabled = True
        Me.cboLokasi.IndexLocked = False
        Me.cboLokasi.Items.AddRange(New Object() {"Produksi", "Gudang"})
        Me.cboLokasi.Location = New System.Drawing.Point(115, 97)
        Me.cboLokasi.Name = "cboLokasi"
        Me.cboLokasi.Size = New System.Drawing.Size(403, 21)
        Me.cboLokasi.TabIndex = 3
        '
        'chkBenang
        '
        Me.chkBenang.AllowEnterToMoveNext = True
        Me.chkBenang.AutoSize = True
        Me.chkBenang.Location = New System.Drawing.Point(115, 134)
        Me.chkBenang.Name = "chkBenang"
        Me.chkBenang.Size = New System.Drawing.Size(130, 17)
        Me.chkBenang.TabIndex = 85
        Me.chkBenang.Text = "Penyimpanan Benang"
        Me.chkBenang.UseVisualStyleBackColor = True
        '
        'chkRoll
        '
        Me.chkRoll.AllowEnterToMoveNext = True
        Me.chkRoll.AutoSize = True
        Me.chkRoll.Location = New System.Drawing.Point(115, 152)
        Me.chkRoll.Name = "chkRoll"
        Me.chkRoll.Size = New System.Drawing.Size(111, 17)
        Me.chkRoll.TabIndex = 86
        Me.chkRoll.Text = "Penyimpanan Roll"
        Me.chkRoll.UseVisualStyleBackColor = True
        '
        'frmLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 253)
        Me.Controls.Add(Me.chkRoll)
        Me.Controls.Add(Me.chkBenang)
        Me.Controls.Add(Me.cboLokasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrefiks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaLokasi)
        Me.Controls.Add(Me.txtKodeLokasi)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 233)
        Me.Name = "frmLokasi"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lokasi Produksi"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaLokasi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeLokasi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtPrefiks As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents chkBenang As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents chkRoll As Enerzie.EPSBasicControls.EPSCheckBox
End Class
