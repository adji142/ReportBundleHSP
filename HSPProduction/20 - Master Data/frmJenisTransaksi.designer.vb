﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJenisKoreksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJenisKoreksi))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaJenisKoreksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeJenisKoreksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeLokasi = New System.Windows.Forms.Button()
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
        'txtNamaJenisKoreksi
        '
        Me.txtNamaJenisKoreksi.AllowEnterToMoveNext = True
        Me.txtNamaJenisKoreksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaJenisKoreksi.BackColor = System.Drawing.Color.White
        Me.txtNamaJenisKoreksi.Location = New System.Drawing.Point(113, 47)
        Me.txtNamaJenisKoreksi.MaxLength = 50
        Me.txtNamaJenisKoreksi.Name = "txtNamaJenisKoreksi"
        Me.txtNamaJenisKoreksi.Size = New System.Drawing.Size(405, 20)
        Me.txtNamaJenisKoreksi.TabIndex = 1
        '
        'txtKodeJenisKoreksi
        '
        Me.txtKodeJenisKoreksi.AllowEnterToMoveNext = True
        Me.txtKodeJenisKoreksi.BackColor = System.Drawing.Color.White
        Me.txtKodeJenisKoreksi.Location = New System.Drawing.Point(113, 22)
        Me.txtKodeJenisKoreksi.MaxLength = 6
        Me.txtKodeJenisKoreksi.Name = "txtKodeJenisKoreksi"
        Me.txtKodeJenisKoreksi.Size = New System.Drawing.Size(77, 20)
        Me.txtKodeJenisKoreksi.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Keterangan"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode"
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
        Me.panel2.Location = New System.Drawing.Point(0, 113)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(542, 54)
        Me.panel2.TabIndex = 3
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
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Kelompok"
        '
        'cboKelompok
        '
        Me.cboKelompok.AllowEnterToMoveNext = True
        Me.cboKelompok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKelompok.BackColor = System.Drawing.Color.White
        Me.cboKelompok.DataLocked = False
        Me.cboKelompok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompok.IndexLocked = False
        Me.cboKelompok.Location = New System.Drawing.Point(113, 72)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(381, 21)
        Me.cboKelompok.TabIndex = 2
        '
        'btLookupKodeLokasi
        '
        Me.btLookupKodeLokasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLookupKodeLokasi.BackColor = System.Drawing.Color.Transparent
        Me.btLookupKodeLokasi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btLookupKodeLokasi.ForeColor = System.Drawing.Color.Silver
        Me.btLookupKodeLokasi.Location = New System.Drawing.Point(495, 72)
        Me.btLookupKodeLokasi.Name = "btLookupKodeLokasi"
        Me.btLookupKodeLokasi.Size = New System.Drawing.Size(23, 21)
        Me.btLookupKodeLokasi.TabIndex = 85
        Me.btLookupKodeLokasi.TabStop = False
        Me.btLookupKodeLokasi.Text = ".."
        Me.btLookupKodeLokasi.UseVisualStyleBackColor = False
        '
        'frmJenisKoreksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(542, 167)
        Me.Controls.Add(Me.cboKelompok)
        Me.Controls.Add(Me.btLookupKodeLokasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaJenisKoreksi)
        Me.Controls.Add(Me.txtKodeJenisKoreksi)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 205)
        Me.Name = "frmJenisKoreksi"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Jenis Koreksi"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaJenisKoreksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeJenisKoreksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeLokasi As System.Windows.Forms.Button
End Class
