<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExecuteRMIssue
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
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLokasiAsal = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLokasiTujuan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Transaksi"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(97, 24)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(123, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.BackColor = System.Drawing.Color.White
        Me.txtKodeProduksi.Location = New System.Drawing.Point(97, 48)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.ReadOnly = True
        Me.txtKodeProduksi.Size = New System.Drawing.Size(123, 20)
        Me.txtKodeProduksi.TabIndex = 1
        Me.txtKodeProduksi.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kode Produksi"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.BackColor = System.Drawing.Color.White
        Me.txtKodeItem.Location = New System.Drawing.Point(97, 72)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.ReadOnly = True
        Me.txtKodeItem.Size = New System.Drawing.Size(123, 20)
        Me.txtKodeItem.TabIndex = 2
        Me.txtKodeItem.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kode Item"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.White
        Me.txtNamaItem.Location = New System.Drawing.Point(97, 96)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(446, 20)
        Me.txtNamaItem.TabIndex = 3
        Me.txtNamaItem.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nama Item"
        '
        'txtLokasiAsal
        '
        Me.txtLokasiAsal.AllowEnterToMoveNext = True
        Me.txtLokasiAsal.BackColor = System.Drawing.Color.White
        Me.txtLokasiAsal.Location = New System.Drawing.Point(97, 120)
        Me.txtLokasiAsal.Name = "txtLokasiAsal"
        Me.txtLokasiAsal.ReadOnly = True
        Me.txtLokasiAsal.Size = New System.Drawing.Size(39, 20)
        Me.txtLokasiAsal.TabIndex = 4
        Me.txtLokasiAsal.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lokasi"
        '
        'txtLokasiTujuan
        '
        Me.txtLokasiTujuan.AllowEnterToMoveNext = True
        Me.txtLokasiTujuan.BackColor = System.Drawing.Color.White
        Me.txtLokasiTujuan.Location = New System.Drawing.Point(181, 120)
        Me.txtLokasiTujuan.Name = "txtLokasiTujuan"
        Me.txtLokasiTujuan.ReadOnly = True
        Me.txtLokasiTujuan.Size = New System.Drawing.Size(39, 20)
        Me.txtLokasiTujuan.TabIndex = 5
        Me.txtLokasiTujuan.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ke"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 187)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(567, 54)
        Me.panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(567, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(460, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(371, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "Execute"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Quantity"
        '
        'txtQty
        '
        Me.txtQty.AllowEnterToMoveNext = True
        Me.txtQty.CheckIsValid = False
        Me.txtQty.DataFormat = "###,##0.00"
        Me.txtQty.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtQty.Location = New System.Drawing.Point(97, 144)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(123, 20)
        Me.txtQty.TabIndex = 6
        Me.txtQty.TabStop = False
        Me.txtQty.Text = "0.00"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQty.Value = 0.0R
        '
        'frmExecuteRMIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 241)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.txtLokasiTujuan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLokasiAsal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmExecuteRMIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eksekusi RM Issue Manual"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLokasiAsal As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLokasiTujuan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQty As Enerzie.EPSBasicControls.EPSTextBoxNum
End Class
