<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPemakaianBahanEx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPemakaianBahanEx))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtTglPencatatan = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboKodeMesin = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btLookupNomorSpk = New System.Windows.Forms.Button()
        Me.cboNomorSpk = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtItemProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.lblBarisData = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKodeShift = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl. Transaksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(647, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Grup Produksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(647, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mesin Produksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Nomor SPK"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Item Produksi"
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
        Me.Panel6.Size = New System.Drawing.Size(983, 54)
        Me.Panel6.TabIndex = 2
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(983, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(790, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(879, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Grid
        '
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
        Me.Grid.Location = New System.Drawing.Point(12, 269)
        Me.Grid.LookupButtonBackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(950, 169)
        Me.Grid.TabIndex = 1
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(104, 86)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(141, 20)
        Me.txtNoTransaksi.TabIndex = 1
        '
        'txtTglPencatatan
        '
        Me.txtTglPencatatan.AllowEnterToMoveNext = True
        Me.txtTglPencatatan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPencatatan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPencatatan.Location = New System.Drawing.Point(375, 86)
        Me.txtTglPencatatan.Name = "txtTglPencatatan"
        Me.txtTglPencatatan.Size = New System.Drawing.Size(101, 20)
        Me.txtTglPencatatan.TabIndex = 2
        '
        'cboKodeGrup
        '
        Me.cboKodeGrup.AllowEnterToMoveNext = True
        Me.cboKodeGrup.DataLocked = False
        Me.cboKodeGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeGrup.FormattingEnabled = True
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(732, 86)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(114, 21)
        Me.cboKodeGrup.TabIndex = 3
        '
        'cboKodeMesin
        '
        Me.cboKodeMesin.AllowEnterToMoveNext = True
        Me.cboKodeMesin.DataLocked = False
        Me.cboKodeMesin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeMesin.FormattingEnabled = True
        Me.cboKodeMesin.IndexLocked = False
        Me.cboKodeMesin.Location = New System.Drawing.Point(732, 112)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(114, 21)
        Me.cboKodeMesin.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(848, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 95
        Me.Button2.TabStop = False
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(848, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 96
        Me.Button3.TabStop = False
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btLookupNomorSpk
        '
        Me.btLookupNomorSpk.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLookupNomorSpk.Location = New System.Drawing.Point(558, 126)
        Me.btLookupNomorSpk.Name = "btLookupNomorSpk"
        Me.btLookupNomorSpk.Size = New System.Drawing.Size(63, 39)
        Me.btLookupNomorSpk.TabIndex = 98
        Me.btLookupNomorSpk.TabStop = False
        Me.btLookupNomorSpk.Text = "DAFTAR"
        Me.btLookupNomorSpk.UseVisualStyleBackColor = True
        '
        'cboNomorSpk
        '
        Me.cboNomorSpk.AllowEnterToMoveNext = True
        Me.cboNomorSpk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNomorSpk.DataLocked = False
        Me.cboNomorSpk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorSpk.DropDownHeight = 105
        Me.cboNomorSpk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorSpk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNomorSpk.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomorSpk.ForeColor = System.Drawing.Color.Red
        Me.cboNomorSpk.IndexLocked = False
        Me.cboNomorSpk.IntegralHeight = False
        Me.cboNomorSpk.Location = New System.Drawing.Point(104, 128)
        Me.cboNomorSpk.Name = "cboNomorSpk"
        Me.cboNomorSpk.Size = New System.Drawing.Size(448, 39)
        Me.cboNomorSpk.TabIndex = 5
        '
        'txtItemProduksi
        '
        Me.txtItemProduksi.AllowEnterToMoveNext = True
        Me.txtItemProduksi.BackColor = System.Drawing.Color.White
        Me.txtItemProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemProduksi.Location = New System.Drawing.Point(104, 173)
        Me.txtItemProduksi.Name = "txtItemProduksi"
        Me.txtItemProduksi.ReadOnly = True
        Me.txtItemProduksi.Size = New System.Drawing.Size(857, 29)
        Me.txtItemProduksi.TabIndex = 6
        Me.txtItemProduksi.TabStop = False
        '
        'lblBarisData
        '
        Me.lblBarisData.AutoSize = True
        Me.lblBarisData.BackColor = System.Drawing.Color.Transparent
        Me.lblBarisData.Location = New System.Drawing.Point(9, 441)
        Me.lblBarisData.Name = "lblBarisData"
        Me.lblBarisData.Size = New System.Drawing.Size(71, 13)
        Me.lblBarisData.TabIndex = 100
        Me.lblBarisData.Text = "12 Baris Data"
        Me.lblBarisData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Unit Produksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(104, 208)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(857, 20)
        Me.txtKeterangan.TabIndex = 7
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(248, 87)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 104
        Me.Locked.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtKodeShift)
        Me.Panel2.Location = New System.Drawing.Point(879, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 58)
        Me.Panel2.TabIndex = 126
        '
        'txtKodeShift
        '
        Me.txtKodeShift.Font = New System.Drawing.Font("Arial Black", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeShift.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKodeShift.Location = New System.Drawing.Point(7, -17)
        Me.txtKodeShift.Name = "txtKodeShift"
        Me.txtKodeShift.Size = New System.Drawing.Size(74, 72)
        Me.txtKodeShift.TabIndex = 122
        Me.txtKodeShift.Text = "3"
        Me.txtKodeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShift
        '
        Me.lblShift.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblShift.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblShift.Location = New System.Drawing.Point(879, 86)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(82, 20)
        Me.lblShift.TabIndex = 125
        Me.lblShift.Text = " SHIFT"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cboKodeUnit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblShift)
        Me.Panel1.Controls.Add(Me.Locked)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtKeterangan)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNoTransaksi)
        Me.Panel1.Controls.Add(Me.txtTglPencatatan)
        Me.Panel1.Controls.Add(Me.txtItemProduksi)
        Me.Panel1.Controls.Add(Me.btLookupNomorSpk)
        Me.Panel1.Controls.Add(Me.cboKodeGrup)
        Me.Panel1.Controls.Add(Me.cboNomorSpk)
        Me.Panel1.Controls.Add(Me.cboKodeMesin)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 252)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(983, 1)
        Me.PictureBox1.TabIndex = 130
        Me.PictureBox1.TabStop = False
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.AllowEnterToMoveNext = True
        Me.cboKodeUnit.DataLocked = False
        Me.cboKodeUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeUnit.FormattingEnabled = True
        Me.cboKodeUnit.IndexLocked = True
        Me.cboKodeUnit.Location = New System.Drawing.Point(104, 24)
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(857, 21)
        Me.cboKodeUnit.TabIndex = 0
        Me.cboKodeUnit.TabStop = False
        '
        'frmPemakaianBahanEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblBarisData)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmPemakaianBahanEx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemakaian Bahan"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents txtTglPencatatan As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents cboKodeMesin As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btLookupNomorSpk As System.Windows.Forms.Button
    Private WithEvents cboNomorSpk As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtItemProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents lblBarisData As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeShift As System.Windows.Forms.Label
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
