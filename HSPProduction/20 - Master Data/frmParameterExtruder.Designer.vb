<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParameterExtruder
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
        Me.txtNamaItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeItem = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDenierAktual = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJmlBenang = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKecepatan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKapasitas = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtKonstanta = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNamaItem
        '
        Me.txtNamaItem.AllowEnterToMoveNext = True
        Me.txtNamaItem.BackColor = System.Drawing.Color.White
        Me.txtNamaItem.Location = New System.Drawing.Point(100, 46)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.ReadOnly = True
        Me.txtNamaItem.Size = New System.Drawing.Size(499, 20)
        Me.txtNamaItem.TabIndex = 1
        '
        'txtKodeItem
        '
        Me.txtKodeItem.AllowEnterToMoveNext = True
        Me.txtKodeItem.Location = New System.Drawing.Point(100, 21)
        Me.txtKodeItem.Name = "txtKodeItem"
        Me.txtKodeItem.Size = New System.Drawing.Size(85, 20)
        Me.txtKodeItem.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Parameter"
        '
        'txtDenierAktual
        '
        Me.txtDenierAktual.AllowEnterToMoveNext = True
        Me.txtDenierAktual.CheckIsValid = False
        Me.txtDenierAktual.DataFormat = "###,##0"
        Me.txtDenierAktual.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtDenierAktual.Location = New System.Drawing.Point(100, 119)
        Me.txtDenierAktual.Name = "txtDenierAktual"
        Me.txtDenierAktual.Size = New System.Drawing.Size(95, 20)
        Me.txtDenierAktual.TabIndex = 2
        Me.txtDenierAktual.Text = "0"
        Me.txtDenierAktual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDenierAktual.Value = 0.0R
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(100, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 29)
        Me.Panel1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(407, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Konstanta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(306, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kapasitas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(205, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kecepatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(101, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jumlah Benang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Denier Aktual"
        '
        'txtJmlBenang
        '
        Me.txtJmlBenang.AllowEnterToMoveNext = True
        Me.txtJmlBenang.CheckIsValid = False
        Me.txtJmlBenang.DataFormat = "###,##0"
        Me.txtJmlBenang.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtJmlBenang.Location = New System.Drawing.Point(201, 119)
        Me.txtJmlBenang.Name = "txtJmlBenang"
        Me.txtJmlBenang.Size = New System.Drawing.Size(95, 20)
        Me.txtJmlBenang.TabIndex = 3
        Me.txtJmlBenang.Text = "0"
        Me.txtJmlBenang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtJmlBenang.Value = 0.0R
        '
        'txtKecepatan
        '
        Me.txtKecepatan.AllowEnterToMoveNext = True
        Me.txtKecepatan.CheckIsValid = False
        Me.txtKecepatan.DataFormat = "###,##0"
        Me.txtKecepatan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtKecepatan.Location = New System.Drawing.Point(302, 119)
        Me.txtKecepatan.Name = "txtKecepatan"
        Me.txtKecepatan.Size = New System.Drawing.Size(95, 20)
        Me.txtKecepatan.TabIndex = 4
        Me.txtKecepatan.Text = "0"
        Me.txtKecepatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKecepatan.Value = 0.0R
        '
        'txtKapasitas
        '
        Me.txtKapasitas.AllowEnterToMoveNext = True
        Me.txtKapasitas.CheckIsValid = False
        Me.txtKapasitas.DataFormat = "###,##0"
        Me.txtKapasitas.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtKapasitas.Location = New System.Drawing.Point(403, 119)
        Me.txtKapasitas.Name = "txtKapasitas"
        Me.txtKapasitas.Size = New System.Drawing.Size(95, 20)
        Me.txtKapasitas.TabIndex = 5
        Me.txtKapasitas.Text = "0"
        Me.txtKapasitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKapasitas.Value = 0.0R
        '
        'txtKonstanta
        '
        Me.txtKonstanta.AllowEnterToMoveNext = True
        Me.txtKonstanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKonstanta.CheckIsValid = False
        Me.txtKonstanta.DataFormat = "###,##0"
        Me.txtKonstanta.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtKonstanta.Location = New System.Drawing.Point(504, 119)
        Me.txtKonstanta.Name = "txtKonstanta"
        Me.txtKonstanta.ReadOnly = True
        Me.txtKonstanta.Size = New System.Drawing.Size(95, 20)
        Me.txtKonstanta.TabIndex = 6
        Me.txtKonstanta.TabStop = False
        Me.txtKonstanta.Text = "9,000,000"
        Me.txtKonstanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKonstanta.Value = 9000000.0R
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 161)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(619, 54)
        Me.panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(619, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(512, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(423, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'frmParameterExtruder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 215)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.txtKonstanta)
        Me.Controls.Add(Me.txtKapasitas)
        Me.Controls.Add(Me.txtKecepatan)
        Me.Controls.Add(Me.txtJmlBenang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtDenierAktual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtKodeItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParameterExtruder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parameter Extruder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNamaItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtKodeItem As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDenierAktual As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJmlBenang As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKecepatan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKapasitas As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKonstanta As Enerzie.EPSBasicControls.EPSTextBoxNum
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
End Class
