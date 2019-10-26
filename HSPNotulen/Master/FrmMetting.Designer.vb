<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMetting
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttopik = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.cboPeriod = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboDept = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cmdBrowseDept = New System.Windows.Forms.Button()
        Me.cbkAktif = New Enerzie.EPSBasicControls.EPSCheckBox()
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
        Me.panel2.Location = New System.Drawing.Point(0, 122)
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
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Topik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Periode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Departemen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Status"
        '
        'txttopik
        '
        Me.txttopik.AllowEnterToMoveNext = True
        Me.txttopik.Location = New System.Drawing.Point(81, 6)
        Me.txttopik.Name = "txttopik"
        Me.txttopik.Size = New System.Drawing.Size(231, 20)
        Me.txttopik.TabIndex = 17
        '
        'cboPeriod
        '
        Me.cboPeriod.AllowEnterToMoveNext = True
        Me.cboPeriod.DataLocked = False
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.IndexLocked = False
        Me.cboPeriod.Items.AddRange(New Object() {"-", "Bulanan", "Mingguan", "InCase"})
        Me.cboPeriod.Location = New System.Drawing.Point(81, 32)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(231, 21)
        Me.cboPeriod.TabIndex = 18
        '
        'cboDept
        '
        Me.cboDept.AllowEnterToMoveNext = True
        Me.cboDept.DataLocked = False
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.IndexLocked = False
        Me.cboDept.Location = New System.Drawing.Point(81, 60)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(186, 21)
        Me.cboDept.TabIndex = 19
        '
        'cmdBrowseDept
        '
        Me.cmdBrowseDept.Location = New System.Drawing.Point(273, 59)
        Me.cmdBrowseDept.Name = "cmdBrowseDept"
        Me.cmdBrowseDept.Size = New System.Drawing.Size(39, 23)
        Me.cmdBrowseDept.TabIndex = 20
        Me.cmdBrowseDept.Text = "..."
        Me.cmdBrowseDept.UseVisualStyleBackColor = True
        '
        'cbkAktif
        '
        Me.cbkAktif.AllowEnterToMoveNext = True
        Me.cbkAktif.AutoSize = True
        Me.cbkAktif.Checked = True
        Me.cbkAktif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbkAktif.Location = New System.Drawing.Point(81, 94)
        Me.cbkAktif.Name = "cbkAktif"
        Me.cbkAktif.Size = New System.Drawing.Size(47, 17)
        Me.cbkAktif.TabIndex = 21
        Me.cbkAktif.Text = "Aktif"
        Me.cbkAktif.UseVisualStyleBackColor = True
        '
        'FrmMetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 176)
        Me.Controls.Add(Me.cbkAktif)
        Me.Controls.Add(Me.cmdBrowseDept)
        Me.Controls.Add(Me.cboDept)
        Me.Controls.Add(Me.cboPeriod)
        Me.Controls.Add(Me.txttopik)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Metting"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttopik As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents cboPeriod As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboDept As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cmdBrowseDept As System.Windows.Forms.Button
    Friend WithEvents cbkAktif As Enerzie.EPSBasicControls.EPSCheckBox
End Class
