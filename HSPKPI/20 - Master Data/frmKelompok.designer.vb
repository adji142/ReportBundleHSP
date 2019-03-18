<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKelompok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKelompok))
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtNamaKelompok = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeKelompok = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(459, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(370, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtNamaKelompok
        '
        Me.txtNamaKelompok.AllowEnterToMoveNext = True
        Me.txtNamaKelompok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaKelompok.BackColor = System.Drawing.Color.White
        Me.txtNamaKelompok.Location = New System.Drawing.Point(125, 47)
        Me.txtNamaKelompok.MaxLength = 50
        Me.txtNamaKelompok.Name = "txtNamaKelompok"
        Me.txtNamaKelompok.Size = New System.Drawing.Size(429, 20)
        Me.txtNamaKelompok.TabIndex = 1
        '
        'txtKodeKelompok
        '
        Me.txtKodeKelompok.AllowEnterToMoveNext = True
        Me.txtKodeKelompok.BackColor = System.Drawing.Color.White
        Me.txtKodeKelompok.Location = New System.Drawing.Point(125, 22)
        Me.txtKodeKelompok.MaxLength = 6
        Me.txtKodeKelompok.Name = "txtKodeKelompok"
        Me.txtKodeKelompok.Size = New System.Drawing.Size(69, 20)
        Me.txtKodeKelompok.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Kelompok"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Kelompok"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(200, 22)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 23
        Me.Locked.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 90)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(566, 54)
        Me.panel2.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(566, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'frmKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(566, 144)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaKelompok)
        Me.Controls.Add(Me.txtKodeKelompok)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 182)
        Me.Name = "frmKelompok"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kelompok"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtNamaKelompok As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeKelompok As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
