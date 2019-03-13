<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengakuanStockBenang
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
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTglProduksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBeratNetto = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtJumlahBox = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtBeratBox = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboStatus = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboArea = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btProcess = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btLookupKodeArea = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KodeItem"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.Location = New System.Drawing.Point(92, 45)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(97, 20)
        Me.txtKodeItem.TabIndex = 1
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.Location = New System.Drawing.Point(192, 45)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(371, 20)
        Me.txtNamaItem.TabIndex = 2
        Me.txtNamaItem.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal"
        '
        'txtTglProduksi
        '
        Me.txtTglProduksi.AllowEnterToMoveNext = True
        Me.txtTglProduksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglProduksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglProduksi.Location = New System.Drawing.Point(92, 22)
        Me.txtTglProduksi.Name = "txtTglProduksi"
        Me.txtTglProduksi.Size = New System.Drawing.Size(97, 20)
        Me.txtTglProduksi.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Berat Netto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah Box"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Berat /Box"
        '
        'txtBeratNetto
        '
        Me.txtBeratNetto.AllowEnterToMoveNext = True
        Me.txtBeratNetto.CheckIsValid = False
        Me.txtBeratNetto.DataFormat = "###,##0.00"
        Me.txtBeratNetto.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratNetto.Location = New System.Drawing.Point(92, 84)
        Me.txtBeratNetto.Name = "txtBeratNetto"
        Me.txtBeratNetto.Size = New System.Drawing.Size(97, 20)
        Me.txtBeratNetto.TabIndex = 3
        Me.txtBeratNetto.Text = "0.00"
        Me.txtBeratNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratNetto.Value = 0.0R
        '
        'txtJumlahBox
        '
        Me.txtJumlahBox.AllowEnterToMoveNext = True
        Me.txtJumlahBox.CheckIsValid = False
        Me.txtJumlahBox.DataFormat = "###,##0.00"
        Me.txtJumlahBox.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJumlahBox.Location = New System.Drawing.Point(92, 108)
        Me.txtJumlahBox.Name = "txtJumlahBox"
        Me.txtJumlahBox.Size = New System.Drawing.Size(97, 20)
        Me.txtJumlahBox.TabIndex = 4
        Me.txtJumlahBox.Text = "0.00"
        Me.txtJumlahBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJumlahBox.Value = 0.0R
        '
        'txtBeratBox
        '
        Me.txtBeratBox.AllowEnterToMoveNext = True
        Me.txtBeratBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratBox.CheckIsValid = False
        Me.txtBeratBox.DataFormat = "###,##0.00"
        Me.txtBeratBox.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratBox.Location = New System.Drawing.Point(92, 132)
        Me.txtBeratBox.Name = "txtBeratBox"
        Me.txtBeratBox.ReadOnly = True
        Me.txtBeratBox.Size = New System.Drawing.Size(97, 20)
        Me.txtBeratBox.TabIndex = 5
        Me.txtBeratBox.TabStop = False
        Me.txtBeratBox.Text = "0.00"
        Me.txtBeratBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratBox.Value = 0.0R
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(256, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.AllowEnterToMoveNext = True
        Me.cboStatus.DataLocked = False
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.IndexLocked = False
        Me.cboStatus.Items.AddRange(New Object() {"OK", "NON OK", "OVER", "UNDER"})
        Me.cboStatus.Location = New System.Drawing.Point(299, 83)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 6
        '
        'cboArea
        '
        Me.cboArea.AllowEnterToMoveNext = True
        Me.cboArea.DataLocked = False
        Me.cboArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.IndexLocked = False
        Me.cboArea.Items.AddRange(New Object() {"OK", "NON OK", "OVER", "UNDER"})
        Me.cboArea.Location = New System.Drawing.Point(299, 107)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(236, 21)
        Me.cboArea.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Area"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btProcess)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 172)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(586, 54)
        Me.Panel6.TabIndex = 8
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(586, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btProcess
        '
        Me.btProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btProcess.Location = New System.Drawing.Point(393, 10)
        Me.btProcess.Name = "btProcess"
        Me.btProcess.Size = New System.Drawing.Size(83, 23)
        Me.btProcess.TabIndex = 0
        Me.btProcess.Text = "[F6] &Proses"
        Me.btProcess.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(482, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "&Batal"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btLookupKodeArea
        '
        Me.btLookupKodeArea.Location = New System.Drawing.Point(537, 106)
        Me.btLookupKodeArea.Name = "btLookupKodeArea"
        Me.btLookupKodeArea.Size = New System.Drawing.Size(25, 22)
        Me.btLookupKodeArea.TabIndex = 93
        Me.btLookupKodeArea.TabStop = False
        Me.btLookupKodeArea.Text = "..."
        Me.btLookupKodeArea.UseVisualStyleBackColor = True
        '
        'frmPengakuanStockBenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 226)
        Me.Controls.Add(Me.btLookupKodeArea)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBeratBox)
        Me.Controls.Add(Me.txtJumlahBox)
        Me.Controls.Add(Me.txtBeratNetto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTglProduksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPengakuanStockBenang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengakuan Stock Benang"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTglProduksi As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBeratNetto As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtJumlahBox As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtBeratBox As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboArea As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btProcess As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeArea As System.Windows.Forms.Button
End Class
