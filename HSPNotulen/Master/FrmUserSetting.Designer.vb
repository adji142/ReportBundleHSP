<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserSetting
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
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdBrowseNIK = New System.Windows.Forms.Button()
        Me.txtEmail = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtphone = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.cboNIK = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboTele = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 133)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(361, 54)
        Me.panel2.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(361, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(266, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(177, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Telegram ID"
        '
        'cmdBrowseNIK
        '
        Me.cmdBrowseNIK.Location = New System.Drawing.Point(296, 6)
        Me.cmdBrowseNIK.Name = "cmdBrowseNIK"
        Me.cmdBrowseNIK.Size = New System.Drawing.Size(39, 23)
        Me.cmdBrowseNIK.TabIndex = 21
        Me.cmdBrowseNIK.Text = "..."
        Me.cmdBrowseNIK.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.AllowEnterToMoveNext = True
        Me.txtEmail.Location = New System.Drawing.Point(106, 33)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(243, 20)
        Me.txtEmail.TabIndex = 23
        '
        'txtphone
        '
        Me.txtphone.AllowEnterToMoveNext = True
        Me.txtphone.Location = New System.Drawing.Point(106, 66)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(149, 20)
        Me.txtphone.TabIndex = 24
        '
        'cboNIK
        '
        Me.cboNIK.AllowEnterToMoveNext = True
        Me.cboNIK.DataLocked = False
        Me.cboNIK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNIK.FormattingEnabled = True
        Me.cboNIK.IndexLocked = False
        Me.cboNIK.Location = New System.Drawing.Point(106, 6)
        Me.cboNIK.Name = "cboNIK"
        Me.cboNIK.Size = New System.Drawing.Size(184, 21)
        Me.cboNIK.TabIndex = 26
        '
        'cboTele
        '
        Me.cboTele.AllowEnterToMoveNext = True
        Me.cboTele.DataLocked = False
        Me.cboTele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTele.FormattingEnabled = True
        Me.cboTele.IndexLocked = False
        Me.cboTele.Location = New System.Drawing.Point(106, 92)
        Me.cboTele.Name = "cboTele"
        Me.cboTele.Size = New System.Drawing.Size(184, 21)
        Me.cboTele.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmUserSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 187)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboTele)
        Me.Controls.Add(Me.cboNIK)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cmdBrowseNIK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Setting"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowseNIK As System.Windows.Forms.Button
    Friend WithEvents txtEmail As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtphone As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents cboNIK As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboTele As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
