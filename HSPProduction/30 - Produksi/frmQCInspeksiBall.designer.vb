<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCInspeksiBall
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboStatusQCOld = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPcsBall = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBeratBall = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btLookupKodeStatus = New System.Windows.Forms.Button()
        Me.cboKodeStatus = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboStatusQCNew = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Produksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Produksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status Lama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status Baru"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keterangan"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboKodeLokasi)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cboStatusQCOld)
        Me.Panel1.Controls.Add(Me.cboKodeUnit)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtPcsBall)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtBeratBall)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNamaItem)
        Me.Panel1.Controls.Add(Me.txtKodeItem)
        Me.Panel1.Controls.Add(Me.txtKodeProduksi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 206)
        Me.Panel1.TabIndex = 0
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = True
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = False
        Me.cboKodeLokasi.Location = New System.Drawing.Point(470, 71)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(146, 24)
        Me.cboKodeLokasi.TabIndex = 4
        Me.cboKodeLokasi.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(354, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 16)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Lokasi Produksi"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Ball"
        '
        'cboStatusQCOld
        '
        Me.cboStatusQCOld.AllowEnterToMoveNext = True
        Me.cboStatusQCOld.DataLocked = True
        Me.cboStatusQCOld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboStatusQCOld.FormattingEnabled = True
        Me.cboStatusQCOld.IndexLocked = False
        Me.cboStatusQCOld.Items.AddRange(New Object() {"NONE", "OK", "NON OK", "OVER", "UNDER"})
        Me.cboStatusQCOld.Location = New System.Drawing.Point(122, 156)
        Me.cboStatusQCOld.Name = "cboStatusQCOld"
        Me.cboStatusQCOld.Size = New System.Drawing.Size(494, 24)
        Me.cboStatusQCOld.TabIndex = 9
        Me.cboStatusQCOld.TabStop = False
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = True
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(122, 71)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(226, 24)
        Me.cboKodeUnit.TabIndex = 3
        Me.cboKodeUnit.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Unit Produksi"
        '
        'txtPcsBall
        '
        Me.txtPcsBall.AllowEnterToMoveNext = True
        Me.txtPcsBall.BackColor = System.Drawing.Color.White
        Me.txtPcsBall.CheckIsValid = False
        Me.txtPcsBall.DataFormat = "###,##0.00"
        Me.txtPcsBall.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtPcsBall.Location = New System.Drawing.Point(238, 129)
        Me.txtPcsBall.Name = "txtPcsBall"
        Me.txtPcsBall.ReadOnly = True
        Me.txtPcsBall.Size = New System.Drawing.Size(110, 22)
        Me.txtPcsBall.TabIndex = 6
        Me.txtPcsBall.TabStop = False
        Me.txtPcsBall.Text = "0.00"
        Me.txtPcsBall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPcsBall.Value = 0.0R
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(238, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "PCS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBeratBall
        '
        Me.txtBeratBall.AllowEnterToMoveNext = True
        Me.txtBeratBall.BackColor = System.Drawing.Color.White
        Me.txtBeratBall.CheckIsValid = False
        Me.txtBeratBall.DataFormat = "###,##0.00"
        Me.txtBeratBall.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratBall.Location = New System.Drawing.Point(122, 129)
        Me.txtBeratBall.Name = "txtBeratBall"
        Me.txtBeratBall.ReadOnly = True
        Me.txtBeratBall.Size = New System.Drawing.Size(110, 22)
        Me.txtBeratBall.TabIndex = 5
        Me.txtBeratBall.TabStop = False
        Me.txtBeratBall.Text = "0.00"
        Me.txtBeratBall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratBall.Value = 0.0R
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(122, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "BERAT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.White
        Me.txtNamaItem.Location = New System.Drawing.Point(238, 44)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(378, 22)
        Me.txtNamaItem.TabIndex = 2
        Me.txtNamaItem.TabStop = False
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.White
        Me.txtKodeItem.Location = New System.Drawing.Point(122, 44)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(110, 22)
        Me.txtKodeItem.TabIndex = 1
        Me.txtKodeItem.TabStop = False
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Location = New System.Drawing.Point(122, 17)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(226, 22)
        Me.txtKodeProduksi.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(122, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 22)
        Me.Label9.TabIndex = 26
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(636, 22)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DATA PRODUKSI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btLookupKodeStatus)
        Me.Panel2.Controls.Add(Me.cboKodeStatus)
        Me.Panel2.Controls.Add(Me.cboStatusQCNew)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 94)
        Me.Panel2.TabIndex = 1
        '
        'btLookupKodeStatus
        '
        Me.btLookupKodeStatus.Location = New System.Drawing.Point(588, 44)
        Me.btLookupKodeStatus.Name = "btLookupKodeStatus"
        Me.btLookupKodeStatus.Size = New System.Drawing.Size(28, 23)
        Me.btLookupKodeStatus.TabIndex = 40
        Me.btLookupKodeStatus.TabStop = False
        Me.btLookupKodeStatus.Text = "..."
        Me.btLookupKodeStatus.UseVisualStyleBackColor = True
        '
        'cboKodeStatus
        '
        Me.cboKodeStatus.AllowEnterToMoveNext = True
        Me.cboKodeStatus.DataLocked = False
        Me.cboKodeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeStatus.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.cboKodeStatus.FormattingEnabled = True
        Me.cboKodeStatus.IndexLocked = False
        Me.cboKodeStatus.Location = New System.Drawing.Point(122, 45)
        Me.cboKodeStatus.Name = "cboKodeStatus"
        Me.cboKodeStatus.Size = New System.Drawing.Size(465, 23)
        Me.cboKodeStatus.TabIndex = 1
        '
        'cboStatusQCNew
        '
        Me.cboStatusQCNew.AllowEnterToMoveNext = True
        Me.cboStatusQCNew.BackColor = System.Drawing.Color.White
        Me.cboStatusQCNew.DataLocked = False
        Me.cboStatusQCNew.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatusQCNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusQCNew.FormattingEnabled = True
        Me.cboStatusQCNew.IndexLocked = False
        Me.cboStatusQCNew.Items.AddRange(New Object() {"OK", "NON OK", "OVER", "UNDER"})
        Me.cboStatusQCNew.Location = New System.Drawing.Point(122, 16)
        Me.cboStatusQCNew.Name = "cboStatusQCNew"
        Me.cboStatusQCNew.Size = New System.Drawing.Size(110, 23)
        Me.cboStatusQCNew.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(636, 22)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "QUALITY CONTROL"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.Controls.Add(Me.pictureBox2)
        Me.Panel9.Controls.Add(Me.btSave)
        Me.Panel9.Controls.Add(Me.btClose)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 380)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(661, 54)
        Me.Panel9.TabIndex = 2
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(661, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(477, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(566, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'frmQCInspeksiBall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 434)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmQCInspeksiBall"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inspeksi Ball"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPcsBall As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBeratBall As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboStatusQCOld As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeStatus As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboStatusQCNew As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeStatus As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
