<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btLookupKodeUnit = New System.Windows.Forms.Button()
        Me.btLookupKodeLokasi = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.cboFormID = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPort = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBaudRate = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit Produksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lokasi Produksi"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = False
        Me.cboKodeUnit.Location = New System.Drawing.Point(120, 49)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(363, 21)
        Me.cboKodeUnit.TabIndex = 1
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = False
        Me.cboKodeLokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = False
        Me.cboKodeLokasi.Location = New System.Drawing.Point(120, 75)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(363, 21)
        Me.cboKodeLokasi.TabIndex = 2
        '
        'btLookupKodeUnit
        '
        Me.btLookupKodeUnit.Location = New System.Drawing.Point(485, 48)
        Me.btLookupKodeUnit.Name = "btLookupKodeUnit"
        Me.btLookupKodeUnit.Size = New System.Drawing.Size(27, 23)
        Me.btLookupKodeUnit.TabIndex = 4
        Me.btLookupKodeUnit.TabStop = False
        Me.btLookupKodeUnit.Text = "..."
        Me.btLookupKodeUnit.UseVisualStyleBackColor = True
        '
        'btLookupKodeLokasi
        '
        Me.btLookupKodeLokasi.Location = New System.Drawing.Point(485, 74)
        Me.btLookupKodeLokasi.Name = "btLookupKodeLokasi"
        Me.btLookupKodeLokasi.Size = New System.Drawing.Size(27, 23)
        Me.btLookupKodeLokasi.TabIndex = 5
        Me.btLookupKodeLokasi.TabStop = False
        Me.btLookupKodeLokasi.Text = "..."
        Me.btLookupKodeLokasi.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Location = New System.Drawing.Point(0, 222)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(535, 54)
        Me.panel2.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(535, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(428, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(339, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'cboFormID
        '
        Me.cboFormID.AllowEnterToMoveNext = True
        Me.cboFormID.DataLocked = False
        Me.cboFormID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboFormID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormID.FormattingEnabled = True
        Me.cboFormID.IndexLocked = False
        Me.cboFormID.Items.AddRange(New Object() {"Gudang ", "Extruder", "Circular Loom ", "Laminating", "Printing Roll", "Cutting Sewing", "Jahit Manual", "Inner", "Printing Lembar", "Slitting", "Semen Bag", "Benang Multifilament", "Recycle", "Packing Karung", "Packing Cement Bag", "Makloon", "Rewind", "<Pilih FormID>"})
        Me.cboFormID.Location = New System.Drawing.Point(120, 23)
        Me.cboFormID.Name = "cboFormID"
        Me.cboFormID.Size = New System.Drawing.Size(363, 21)
        Me.cboFormID.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Form ID"
        '
        'cboPort
        '
        Me.cboPort.AllowEnterToMoveNext = True
        Me.cboPort.DataLocked = False
        Me.cboPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.IndexLocked = False
        Me.cboPort.Location = New System.Drawing.Point(120, 153)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(102, 21)
        Me.cboPort.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Port"
        '
        'cboBaudRate
        '
        Me.cboBaudRate.AllowEnterToMoveNext = True
        Me.cboBaudRate.DataLocked = False
        Me.cboBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaudRate.FormattingEnabled = True
        Me.cboBaudRate.IndexLocked = False
        Me.cboBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "-"})
        Me.cboBaudRate.Location = New System.Drawing.Point(120, 179)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(102, 21)
        Me.cboBaudRate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Baud Rate"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label14.Location = New System.Drawing.Point(-2, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(538, 21)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Communication Setting"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 276)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboBaudRate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboFormID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btLookupKodeLokasi)
        Me.Controls.Add(Me.btLookupKodeUnit)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.cboKodeUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmSetting"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Production | Setting"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents btLookupKodeUnit As System.Windows.Forms.Button
    Friend WithEvents btLookupKodeLokasi As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents cboFormID As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPort As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboBaudRate As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
End Class
