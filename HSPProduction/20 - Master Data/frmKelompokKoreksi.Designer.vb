<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKelompokKoreksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKelompokKoreksi))
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtKodeKelompok = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNamaKelompok = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.chkKodeProduksi = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btAddLokasi = New System.Windows.Forms.Button()
        Me.DeleteList = New System.Windows.Forms.Button()
        Me.lstLokasi = New System.Windows.Forms.ListBox()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(18, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Kode Kelompok"
        '
        'txtKodeKelompok
        '
        Me.txtKodeKelompok.AllowEnterToMoveNext = True
        Me.txtKodeKelompok.BackColor = System.Drawing.Color.White
        Me.txtKodeKelompok.Location = New System.Drawing.Point(119, 21)
        Me.txtKodeKelompok.MaxLength = 6
        Me.txtKodeKelompok.Name = "txtKodeKelompok"
        Me.txtKodeKelompok.Size = New System.Drawing.Size(77, 20)
        Me.txtKodeKelompok.TabIndex = 24
        '
        'txtNamaKelompok
        '
        Me.txtNamaKelompok.AllowEnterToMoveNext = True
        Me.txtNamaKelompok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaKelompok.BackColor = System.Drawing.Color.White
        Me.txtNamaKelompok.Location = New System.Drawing.Point(119, 45)
        Me.txtNamaKelompok.MaxLength = 50
        Me.txtNamaKelompok.Name = "txtNamaKelompok"
        Me.txtNamaKelompok.Size = New System.Drawing.Size(401, 20)
        Me.txtNamaKelompok.TabIndex = 26
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(18, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 13)
        Me.label2.TabIndex = 27
        Me.label2.Text = "Nama Kelompok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Kelompok Item"
        '
        'cboKelompok
        '
        Me.cboKelompok.AllowEnterToMoveNext = True
        Me.cboKelompok.DataLocked = False
        Me.cboKelompok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompok.FormattingEnabled = True
        Me.cboKelompok.IndexLocked = False
        Me.cboKelompok.Items.AddRange(New Object() {"Roll", "Ball", "Benang Multifilament", "Benang Extruder"})
        Me.cboKelompok.Location = New System.Drawing.Point(119, 69)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(401, 21)
        Me.cboKelompok.TabIndex = 29
        '
        'chkKodeProduksi
        '
        Me.chkKodeProduksi.AllowEnterToMoveNext = True
        Me.chkKodeProduksi.AutoSize = True
        Me.chkKodeProduksi.Location = New System.Drawing.Point(119, 96)
        Me.chkKodeProduksi.Name = "chkKodeProduksi"
        Me.chkKodeProduksi.Size = New System.Drawing.Size(95, 17)
        Me.chkKodeProduksi.TabIndex = 30
        Me.chkKodeProduksi.Text = "Kode Produksi"
        Me.chkKodeProduksi.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 298)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(538, 54)
        Me.panel2.TabIndex = 31
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(538, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(437, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 5
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(348, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Lokasi"
        '
        'btAddLokasi
        '
        Me.btAddLokasi.Location = New System.Drawing.Point(493, 123)
        Me.btAddLokasi.Name = "btAddLokasi"
        Me.btAddLokasi.Size = New System.Drawing.Size(27, 23)
        Me.btAddLokasi.TabIndex = 34
        Me.btAddLokasi.Text = "+"
        Me.btAddLokasi.UseVisualStyleBackColor = True
        '
        'DeleteList
        '
        Me.DeleteList.Location = New System.Drawing.Point(493, 152)
        Me.DeleteList.Name = "DeleteList"
        Me.DeleteList.Size = New System.Drawing.Size(27, 23)
        Me.DeleteList.TabIndex = 35
        Me.DeleteList.Text = "-"
        Me.DeleteList.UseVisualStyleBackColor = True
        '
        'lstLokasi
        '
        Me.lstLokasi.FormattingEnabled = True
        Me.lstLokasi.Location = New System.Drawing.Point(119, 123)
        Me.lstLokasi.Name = "lstLokasi"
        Me.lstLokasi.Size = New System.Drawing.Size(368, 160)
        Me.lstLokasi.TabIndex = 36
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(202, 22)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 25
        Me.Locked.TabStop = False
        '
        'frmKelompokKoreksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 352)
        Me.Controls.Add(Me.lstLokasi)
        Me.Controls.Add(Me.DeleteList)
        Me.Controls.Add(Me.btAddLokasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.chkKodeProduksi)
        Me.Controls.Add(Me.cboKelompok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaKelompok)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtKodeKelompok)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKelompokKoreksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kelompok Koreksi"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents txtKodeKelompok As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtNamaKelompok As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents chkKodeProduksi As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btAddLokasi As System.Windows.Forms.Button
    Friend WithEvents DeleteList As System.Windows.Forms.Button
    Friend WithEvents lstLokasi As System.Windows.Forms.ListBox
End Class
