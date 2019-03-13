<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParameterRollLaminasi
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
        Me.OptionBopp = New Enerzie.EPSBasicControls.EPSRadioButton()
        Me.OptionNonBopp = New Enerzie.EPSBasicControls.EPSRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtBahanPP = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBahanPE = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBahanVist = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBahanBopp = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalBahan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBeratKarung = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBeratTeoritis = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptionBopp
        '
        Me.OptionBopp.AllowEnterToMoveNext = True
        Me.OptionBopp.AutoSize = True
        Me.OptionBopp.Location = New System.Drawing.Point(100, 103)
        Me.OptionBopp.Name = "OptionBopp"
        Me.OptionBopp.Size = New System.Drawing.Size(54, 17)
        Me.OptionBopp.TabIndex = 3
        Me.OptionBopp.TabStop = True
        Me.OptionBopp.Text = "BOPP"
        Me.OptionBopp.UseVisualStyleBackColor = True
        '
        'OptionNonBopp
        '
        Me.OptionNonBopp.AllowEnterToMoveNext = True
        Me.OptionNonBopp.AutoSize = True
        Me.OptionNonBopp.Location = New System.Drawing.Point(203, 103)
        Me.OptionNonBopp.Name = "OptionNonBopp"
        Me.OptionNonBopp.Size = New System.Drawing.Size(81, 17)
        Me.OptionNonBopp.TabIndex = 4
        Me.OptionNonBopp.TabStop = True
        Me.OptionNonBopp.Text = "NON BOPP"
        Me.OptionNonBopp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Item"
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.Location = New System.Drawing.Point(100, 25)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(85, 20)
        Me.txtKodeItem.TabIndex = 0
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.White
        Me.txtNamaItem.Location = New System.Drawing.Point(100, 50)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(449, 20)
        Me.txtNamaItem.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(100, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 245)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(573, 54)
        Me.panel2.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(573, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(466, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(377, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtBahanPP
        '
        Me.txtBahanPP.AllowEnterToMoveNext = True
        Me.txtBahanPP.CheckIsValid = False
        Me.txtBahanPP.DataFormat = "###,##0.00"
        Me.txtBahanPP.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBahanPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBahanPP.Location = New System.Drawing.Point(100, 172)
        Me.txtBahanPP.Name = "txtBahanPP"
        Me.txtBahanPP.Size = New System.Drawing.Size(85, 22)
        Me.txtBahanPP.TabIndex = 5
        Me.txtBahanPP.Text = "0.00"
        Me.txtBahanPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBahanPP.Value = 0.0R
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(103, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(194, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "PE"
        '
        'txtBahanPE
        '
        Me.txtBahanPE.AllowEnterToMoveNext = True
        Me.txtBahanPE.CheckIsValid = False
        Me.txtBahanPE.DataFormat = "###,##0.00"
        Me.txtBahanPE.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBahanPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBahanPE.Location = New System.Drawing.Point(191, 172)
        Me.txtBahanPE.Name = "txtBahanPE"
        Me.txtBahanPE.Size = New System.Drawing.Size(85, 22)
        Me.txtBahanPE.TabIndex = 6
        Me.txtBahanPE.Text = "0.00"
        Me.txtBahanPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBahanPE.Value = 0.0R
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(285, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "VISTAMAX"
        '
        'txtBahanVist
        '
        Me.txtBahanVist.AllowEnterToMoveNext = True
        Me.txtBahanVist.CheckIsValid = False
        Me.txtBahanVist.DataFormat = "###,##0.00"
        Me.txtBahanVist.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBahanVist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBahanVist.Location = New System.Drawing.Point(282, 172)
        Me.txtBahanVist.Name = "txtBahanVist"
        Me.txtBahanVist.Size = New System.Drawing.Size(85, 22)
        Me.txtBahanVist.TabIndex = 7
        Me.txtBahanVist.Text = "0.00"
        Me.txtBahanVist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBahanVist.Value = 0.0R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Berat Laminasi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(376, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "BOPP"
        '
        'txtBahanBopp
        '
        Me.txtBahanBopp.AllowEnterToMoveNext = True
        Me.txtBahanBopp.CheckIsValid = False
        Me.txtBahanBopp.DataFormat = "###,##0.00"
        Me.txtBahanBopp.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBahanBopp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBahanBopp.Location = New System.Drawing.Point(373, 172)
        Me.txtBahanBopp.Name = "txtBahanBopp"
        Me.txtBahanBopp.Size = New System.Drawing.Size(85, 22)
        Me.txtBahanBopp.TabIndex = 8
        Me.txtBahanBopp.Text = "0.00"
        Me.txtBahanBopp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBahanBopp.Value = 0.0R
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(467, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "TOTAL"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalBahan
        '
        Me.txtTotalBahan.AllowEnterToMoveNext = True
        Me.txtTotalBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalBahan.CheckIsValid = False
        Me.txtTotalBahan.DataFormat = "###,##0.00"
        Me.txtTotalBahan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalBahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalBahan.Location = New System.Drawing.Point(464, 172)
        Me.txtTotalBahan.Name = "txtTotalBahan"
        Me.txtTotalBahan.ReadOnly = True
        Me.txtTotalBahan.Size = New System.Drawing.Size(85, 22)
        Me.txtTotalBahan.TabIndex = 9
        Me.txtTotalBahan.Text = "0.00"
        Me.txtTotalBahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalBahan.Value = 0.0R
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Berat Karung"
        '
        'txtBeratKarung
        '
        Me.txtBeratKarung.AllowEnterToMoveNext = True
        Me.txtBeratKarung.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratKarung.CheckIsValid = False
        Me.txtBeratKarung.DataFormat = "###,##0.00"
        Me.txtBeratKarung.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratKarung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratKarung.ForeColor = System.Drawing.Color.IndianRed
        Me.txtBeratKarung.Location = New System.Drawing.Point(100, 75)
        Me.txtBeratKarung.Name = "txtBeratKarung"
        Me.txtBeratKarung.Size = New System.Drawing.Size(85, 22)
        Me.txtBeratKarung.TabIndex = 2
        Me.txtBeratKarung.Text = "0.00"
        Me.txtBeratKarung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratKarung.Value = 0.0R
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(188, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Gram/ Meter"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Gram/ Meter"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Berat Teoritis"
        '
        'txtBeratTeoritis
        '
        Me.txtBeratTeoritis.AllowEnterToMoveNext = True
        Me.txtBeratTeoritis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBeratTeoritis.CheckIsValid = False
        Me.txtBeratTeoritis.DataFormat = "###,##0.00"
        Me.txtBeratTeoritis.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBeratTeoritis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratTeoritis.ForeColor = System.Drawing.Color.IndianRed
        Me.txtBeratTeoritis.Location = New System.Drawing.Point(100, 200)
        Me.txtBeratTeoritis.Name = "txtBeratTeoritis"
        Me.txtBeratTeoritis.ReadOnly = True
        Me.txtBeratTeoritis.Size = New System.Drawing.Size(85, 22)
        Me.txtBeratTeoritis.TabIndex = 10
        Me.txtBeratTeoritis.Text = "0.00"
        Me.txtBeratTeoritis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeratTeoritis.Value = 0.0R
        '
        'frmParameterRollLaminasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 299)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBeratTeoritis)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBeratKarung)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalBahan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBahanBopp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBahanVist)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBahanPE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBahanPP)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OptionNonBopp)
        Me.Controls.Add(Me.OptionBopp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmParameterRollLaminasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parameter Roll Laminasi"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OptionBopp As Enerzie.EPSBasicControls.EPSRadioButton
    Friend WithEvents OptionNonBopp As Enerzie.EPSBasicControls.EPSRadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtBahanPP As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBahanPE As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBahanVist As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBahanBopp As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBahan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBeratKarung As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBeratTeoritis As Enerzie.EPSBasicControls.EPSTextBoxNum
End Class
