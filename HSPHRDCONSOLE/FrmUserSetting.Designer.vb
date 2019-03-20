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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUserID = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtUserName = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtNik = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.btLookupNik = New System.Windows.Forms.Button()
        Me.txtNamaKaryawan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Karyawan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "UserName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "UserID"
        '
        'txtUserID
        '
        Me.txtUserID.AllowEnterToMoveNext = True
        Me.txtUserID.Location = New System.Drawing.Point(77, 22)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtUserID.TabIndex = 8
        '
        'txtUserName
        '
        Me.txtUserName.AllowEnterToMoveNext = True
        Me.txtUserName.Location = New System.Drawing.Point(77, 48)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(447, 20)
        Me.txtUserName.TabIndex = 9
        '
        'txtNik
        '
        Me.txtNik.AllowEnterToMoveNext = True
        Me.txtNik.Location = New System.Drawing.Point(77, 74)
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(100, 20)
        Me.txtNik.TabIndex = 10
        '
        'btLookupNik
        '
        Me.btLookupNik.Location = New System.Drawing.Point(183, 72)
        Me.btLookupNik.Name = "btLookupNik"
        Me.btLookupNik.Size = New System.Drawing.Size(25, 23)
        Me.btLookupNik.TabIndex = 11
        Me.btLookupNik.Text = "..."
        Me.btLookupNik.UseVisualStyleBackColor = True
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.AllowEnterToMoveNext = True
        Me.txtNamaKaryawan.BackColor = System.Drawing.Color.White
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(214, 74)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.ReadOnly = True
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(310, 20)
        Me.txtNamaKaryawan.TabIndex = 12
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
        Me.panel2.Size = New System.Drawing.Size(536, 54)
        Me.panel2.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(536, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(441, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(352, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'FrmUserSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 167)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.txtNamaKaryawan)
        Me.Controls.Add(Me.btLookupNik)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Personal Bot"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtUserName As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtNik As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents btLookupNik As System.Windows.Forms.Button
    Friend WithEvents txtNamaKaryawan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
End Class
