<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReprintBarcodePrinting
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
        Me.txtKodeProduksiBahan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksiHasil = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTimbang = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel9.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Produksi Bahan"
        '
        'txtKodeProduksiBahan
        '
        Me.txtKodeProduksiBahan.AllowEnterToMoveNext = True
        Me.txtKodeProduksiBahan.Location = New System.Drawing.Point(137, 26)
        Me.txtKodeProduksiBahan.Name = "txtKodeProduksiBahan"
        Me.txtKodeProduksiBahan.Size = New System.Drawing.Size(183, 20)
        Me.txtKodeProduksiBahan.TabIndex = 1
        '
        'txtKodeProduksiHasil
        '
        Me.txtKodeProduksiHasil.AllowEnterToMoveNext = True
        Me.txtKodeProduksiHasil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksiHasil.Location = New System.Drawing.Point(137, 52)
        Me.txtKodeProduksiHasil.Name = "txtKodeProduksiHasil"
        Me.txtKodeProduksiHasil.ReadOnly = True
        Me.txtKodeProduksiHasil.Size = New System.Drawing.Size(183, 20)
        Me.txtKodeProduksiHasil.TabIndex = 3
        Me.txtKodeProduksiHasil.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Produksi Hasil"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeItem.Location = New System.Drawing.Point(137, 78)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(91, 20)
        Me.txtKodeItem.TabIndex = 5
        Me.txtKodeItem.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kode Item"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaItem.Location = New System.Drawing.Point(137, 104)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(526, 20)
        Me.txtNamaItem.TabIndex = 7
        Me.txtNamaItem.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hasil Meter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hasil Timbang"
        '
        'txtMeter
        '
        Me.txtMeter.AllowEnterToMoveNext = True
        Me.txtMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMeter.CheckIsValid = False
        Me.txtMeter.DataFormat = "###,##0.00"
        Me.txtMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtMeter.Location = New System.Drawing.Point(137, 130)
        Me.txtMeter.Name = "txtMeter"
        Me.txtMeter.ReadOnly = True
        Me.txtMeter.Size = New System.Drawing.Size(91, 20)
        Me.txtMeter.TabIndex = 11
        Me.txtMeter.TabStop = False
        Me.txtMeter.Text = "0.00"
        Me.txtMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMeter.Value = 0.0R
        '
        'txtTimbang
        '
        Me.txtTimbang.AllowEnterToMoveNext = True
        Me.txtTimbang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimbang.CheckIsValid = False
        Me.txtTimbang.DataFormat = "###,##0.00"
        Me.txtTimbang.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTimbang.Location = New System.Drawing.Point(137, 156)
        Me.txtTimbang.Name = "txtTimbang"
        Me.txtTimbang.ReadOnly = True
        Me.txtTimbang.Size = New System.Drawing.Size(91, 20)
        Me.txtTimbang.TabIndex = 12
        Me.txtTimbang.TabStop = False
        Me.txtTimbang.Text = "0.00"
        Me.txtTimbang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbang.Value = 0.0R
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel9.Controls.Add(Me.pictureBox2)
        Me.Panel9.Controls.Add(Me.btPrint)
        Me.Panel9.Controls.Add(Me.btClose)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 202)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(682, 54)
        Me.Panel9.TabIndex = 13
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(682, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btPrint
        '
        Me.btPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPrint.Location = New System.Drawing.Point(487, 10)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(83, 23)
        Me.btPrint.TabIndex = 0
        Me.btPrint.Text = "[F6] &Print"
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(576, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nama Item"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Meter"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "KG"
        '
        'frmReprintBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 256)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txtTimbang)
        Me.Controls.Add(Me.txtMeter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKodeProduksiHasil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeProduksiBahan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReprintBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Barcode Ulang"
        Me.Panel9.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeProduksiBahan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksiHasil As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTimbang As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btPrint As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
