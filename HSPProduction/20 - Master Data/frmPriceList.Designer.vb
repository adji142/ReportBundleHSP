<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceList
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btTampilData = New System.Windows.Forms.Button()
        Me.cboKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboDenier = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboBrand = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboJenisKarung = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelompok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Denier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(433, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Merk Dagang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Karung"
        '
        'btTampilData
        '
        Me.btTampilData.Location = New System.Drawing.Point(96, 123)
        Me.btTampilData.Name = "btTampilData"
        Me.btTampilData.Size = New System.Drawing.Size(121, 23)
        Me.btTampilData.TabIndex = 6
        Me.btTampilData.Text = "Tampilkan"
        Me.btTampilData.UseVisualStyleBackColor = True
        '
        'cboKelompok
        '
        Me.cboKelompok.AllowEnterToMoveNext = True
        Me.cboKelompok.DataLocked = False
        Me.cboKelompok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompok.FormattingEnabled = True
        Me.cboKelompok.IndexLocked = False
        Me.cboKelompok.Location = New System.Drawing.Point(96, 73)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(566, 21)
        Me.cboKelompok.TabIndex = 2
        '
        'cboDenier
        '
        Me.cboDenier.AllowEnterToMoveNext = True
        Me.cboDenier.DataLocked = False
        Me.cboDenier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDenier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDenier.FormattingEnabled = True
        Me.cboDenier.IndexLocked = False
        Me.cboDenier.Location = New System.Drawing.Point(319, 98)
        Me.cboDenier.Name = "cboDenier"
        Me.cboDenier.Size = New System.Drawing.Size(96, 21)
        Me.cboDenier.TabIndex = 4
        '
        'cboBrand
        '
        Me.cboBrand.AllowEnterToMoveNext = True
        Me.cboBrand.DataLocked = False
        Me.cboBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.IndexLocked = False
        Me.cboBrand.Location = New System.Drawing.Point(515, 98)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(113, 21)
        Me.cboBrand.TabIndex = 5
        '
        'cboJenisKarung
        '
        Me.cboJenisKarung.AllowEnterToMoveNext = True
        Me.cboJenisKarung.DataLocked = False
        Me.cboJenisKarung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJenisKarung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenisKarung.FormattingEnabled = True
        Me.cboJenisKarung.IndexLocked = False
        Me.cboJenisKarung.Location = New System.Drawing.Point(96, 98)
        Me.cboJenisKarung.Name = "cboJenisKarung"
        Me.cboJenisKarung.Size = New System.Drawing.Size(121, 21)
        Me.cboJenisKarung.TabIndex = 3
        '
        'Grid
        '
        Me.Grid.AllowDeleteRow = False
        Me.Grid.AllowInsertRow = True
        Me.Grid.AlternatingCellFocusBackColor = System.Drawing.SystemColors.Highlight
        Me.Grid.AlternatingCellFocusForeColor = System.Drawing.Color.White
        Me.Grid.AlternatingDataGridBackColor = System.Drawing.Color.White
        Me.Grid.AlternatingDataGridForeColor = System.Drawing.Color.Empty
        Me.Grid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Grid.CellFocusBackColor = System.Drawing.SystemColors.Highlight
        Me.Grid.CellFocusForeColor = System.Drawing.Color.White
        Me.Grid.DataGridBackColor = System.Drawing.Color.White
        Me.Grid.DataGridForeColor = System.Drawing.Color.Empty
        Me.Grid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.GridColor = System.Drawing.Color.Silver
        Me.Grid.HeaderBackColor = System.Drawing.SystemColors.ControlLight
        Me.Grid.HeaderForeColor = System.Drawing.Color.Black
        Me.Grid.Location = New System.Drawing.Point(17, 163)
        Me.Grid.LookupButtonBackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(645, 301)
        Me.Grid.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 471)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(683, 54)
        Me.Panel6.TabIndex = 8
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(683, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(490, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(579, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "No Transaksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tgl. Transaksi"
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(319, 20)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(96, 20)
        Me.txtTglTransaksi.TabIndex = 1
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(96, 20)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(121, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(699, 4)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 525)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.cboJenisKarung)
        Me.Controls.Add(Me.cboBrand)
        Me.Controls.Add(Me.cboDenier)
        Me.Controls.Add(Me.cboKelompok)
        Me.Controls.Add(Me.btTampilData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPriceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Price List Karung"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btTampilData As System.Windows.Forms.Button
    Friend WithEvents cboKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboDenier As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboBrand As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboJenisKarung As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
