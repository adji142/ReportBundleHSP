<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProsesTimbang
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTimbangManual = New System.Windows.Forms.Label()
        Me.txtTimbangManual = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.chkManual = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBeratMedia = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.cboKodeMedia = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeMedia = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblStabil = New System.Windows.Forms.Label()
        Me.lblBeratBrutto = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBeratNetto = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btProcess = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.ScalePort = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrScale = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblIndicator)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblStabil)
        Me.Panel1.Controls.Add(Me.lblBeratBrutto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblBeratNetto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 227)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTimbangManual)
        Me.Panel2.Controls.Add(Me.txtTimbangManual)
        Me.Panel2.Controls.Add(Me.chkManual)
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtBeratMedia)
        Me.Panel2.Controls.Add(Me.cboKodeMedia)
        Me.Panel2.Controls.Add(Me.btLookupKodeMedia)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 227)
        Me.Panel2.TabIndex = 101
        '
        'lblTimbangManual
        '
        Me.lblTimbangManual.AutoSize = True
        Me.lblTimbangManual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimbangManual.Location = New System.Drawing.Point(16, 186)
        Me.lblTimbangManual.Name = "lblTimbangManual"
        Me.lblTimbangManual.Size = New System.Drawing.Size(103, 16)
        Me.lblTimbangManual.TabIndex = 103
        Me.lblTimbangManual.Text = "Timbang Manual"
        '
        'txtTimbangManual
        '
        Me.txtTimbangManual.AllowEnterToMoveNext = True
        Me.txtTimbangManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimbangManual.CheckIsValid = False
        Me.txtTimbangManual.DataFormat = "###,##0.00"
        Me.txtTimbangManual.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTimbangManual.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTimbangManual.ForeColor = System.Drawing.Color.Blue
        Me.txtTimbangManual.Location = New System.Drawing.Point(125, 182)
        Me.txtTimbangManual.Name = "txtTimbangManual"
        Me.txtTimbangManual.Size = New System.Drawing.Size(188, 25)
        Me.txtTimbangManual.TabIndex = 102
        Me.txtTimbangManual.Text = "3,000.00"
        Me.txtTimbangManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbangManual.Value = 3000.0R
        '
        'chkManual
        '
        Me.chkManual.AllowEnterToMoveNext = True
        Me.chkManual.AutoSize = True
        Me.chkManual.Location = New System.Drawing.Point(125, 159)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(88, 17)
        Me.chkManual.TabIndex = 101
        Me.chkManual.Text = "Input Manual"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(355, 39)
        Me.lblStatus.TabIndex = 100
        Me.lblStatus.Text = "OFFLINE"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Berat Media"
        '
        'txtBeratMedia
        '
        Me.txtBeratMedia.AllowEnterToMoveNext = True
        Me.txtBeratMedia.BackColor = System.Drawing.Color.White
        Me.txtBeratMedia.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeratMedia.Location = New System.Drawing.Point(125, 85)
        Me.txtBeratMedia.Name = "txtBeratMedia"
        Me.txtBeratMedia.ReadOnly = True
        Me.txtBeratMedia.Size = New System.Drawing.Size(188, 21)
        Me.txtBeratMedia.TabIndex = 3
        Me.txtBeratMedia.TabStop = False
        Me.txtBeratMedia.Text = "0 KG"
        Me.txtBeratMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboKodeMedia
        '
        Me.cboKodeMedia.AllowEnterToMoveNext = True
        Me.cboKodeMedia.BackColor = System.Drawing.Color.White
        Me.cboKodeMedia.DataLocked = False
        Me.cboKodeMedia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMedia.DropDownHeight = 105
        Me.cboKodeMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMedia.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKodeMedia.ForeColor = System.Drawing.Color.Blue
        Me.cboKodeMedia.IndexLocked = False
        Me.cboKodeMedia.IntegralHeight = False
        Me.cboKodeMedia.Location = New System.Drawing.Point(125, 59)
        Me.cboKodeMedia.Name = "cboKodeMedia"
        Me.cboKodeMedia.Size = New System.Drawing.Size(188, 22)
        Me.cboKodeMedia.TabIndex = 2
        '
        'btLookupKodeMedia
        '
        Me.btLookupKodeMedia.Location = New System.Drawing.Point(314, 58)
        Me.btLookupKodeMedia.Name = "btLookupKodeMedia"
        Me.btLookupKodeMedia.Size = New System.Drawing.Size(28, 24)
        Me.btLookupKodeMedia.TabIndex = 97
        Me.btLookupKodeMedia.TabStop = False
        Me.btLookupKodeMedia.Text = "..."
        Me.btLookupKodeMedia.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 61)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 16)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Media Timbang"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(820, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 28)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "NET"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(820, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 28)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "KG"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIndicator
        '
        Me.lblIndicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIndicator.BackColor = System.Drawing.Color.Transparent
        Me.lblIndicator.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicator.ForeColor = System.Drawing.Color.Yellow
        Me.lblIndicator.Location = New System.Drawing.Point(820, 85)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(51, 27)
        Me.lblIndicator.TabIndex = 97
        Me.lblIndicator.Text = "<<"
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(820, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 28)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "KG"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStabil
        '
        Me.lblStabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStabil.BackColor = System.Drawing.Color.Transparent
        Me.lblStabil.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStabil.ForeColor = System.Drawing.Color.Blue
        Me.lblStabil.Location = New System.Drawing.Point(820, 59)
        Me.lblStabil.Name = "lblStabil"
        Me.lblStabil.Size = New System.Drawing.Size(54, 26)
        Me.lblStabil.TabIndex = 96
        Me.lblStabil.Text = "ST"
        Me.lblStabil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratBrutto
        '
        Me.lblBeratBrutto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratBrutto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratBrutto.Font = New System.Drawing.Font("Arial Narrow", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratBrutto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBeratBrutto.Location = New System.Drawing.Point(433, 2)
        Me.lblBeratBrutto.Name = "lblBeratBrutto"
        Me.lblBeratBrutto.Size = New System.Drawing.Size(413, 134)
        Me.lblBeratBrutto.TabIndex = 84
        Me.lblBeratBrutto.Text = "0.00"
        Me.lblBeratBrutto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(123, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(805, 1)
        Me.Label9.TabIndex = 81
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeratNetto
        '
        Me.lblBeratNetto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeratNetto.BackColor = System.Drawing.Color.Transparent
        Me.lblBeratNetto.Font = New System.Drawing.Font("Arial Narrow", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeratNetto.ForeColor = System.Drawing.Color.White
        Me.lblBeratNetto.Location = New System.Drawing.Point(415, 143)
        Me.lblBeratNetto.Name = "lblBeratNetto"
        Me.lblBeratNetto.Size = New System.Drawing.Size(413, 77)
        Me.lblBeratNetto.TabIndex = 98
        Me.lblBeratNetto.Text = "0.00"
        Me.lblBeratNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btProcess)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 227)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(889, 54)
        Me.Panel6.TabIndex = 4
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(889, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btProcess
        '
        Me.btProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btProcess.Location = New System.Drawing.Point(696, 10)
        Me.btProcess.Name = "btProcess"
        Me.btProcess.Size = New System.Drawing.Size(83, 23)
        Me.btProcess.TabIndex = 0
        Me.btProcess.Text = "[F6] &Proses"
        Me.btProcess.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(785, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "&Batal"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        Me.tmrJam.Interval = 500
        '
        'ScalePort
        '
        '
        'tmrScale
        '
        '
        'frmProsesTimbang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 281)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmProsesTimbang"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses Timbang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBeratBrutto As System.Windows.Forms.Label
    Private WithEvents lblIndicator As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents lblStabil As System.Windows.Forms.Label
    Friend WithEvents lblBeratNetto As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btLookupKodeMedia As System.Windows.Forms.Button
    Private WithEvents cboKodeMedia As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btProcess As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents ScalePort As System.IO.Ports.SerialPort
    Friend WithEvents tmrScale As System.Windows.Forms.Timer
    Friend WithEvents txtBeratMedia As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents lblStatus As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkManual As Enerzie.EPSBasicControls.EPSCheckBox
    Private WithEvents lblTimbangManual As System.Windows.Forms.Label
    Friend WithEvents txtTimbangManual As Enerzie.EPSBasicControls.EPSTextBoxNum
End Class
