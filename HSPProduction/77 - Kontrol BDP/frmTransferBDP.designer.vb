<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferBDP
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
        Me.btLookupNomorWO = New System.Windows.Forms.Button()
        Me.cboNomorWO = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtKodeItemFG = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.lblBarisData = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.txtKodeShift = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtKodeSatuanFGTransfer = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtKodeItemFGTransfer = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btLookupNomorWOTransfer = New System.Windows.Forms.Button()
        Me.cboNomorWOTransfer = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btShow = New System.Windows.Forms.Button()
        Me.txtKodeSatuanFG = New System.Windows.Forms.Label()
        Me.txtNilaiBDP = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTotalProduksi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtReturProduksi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtHasilProduksi = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboKodeUnit = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblTanggalWO = New System.Windows.Forms.Label()
        Me.lblTanggalWOTransfer = New System.Windows.Forms.Label()
        Me.lstMaterialTransfer = New System.Windows.Forms.ListBox()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl. Transfer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(477, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Grup Produksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(721, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mesin Produksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Nomor SPK"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 166)
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
        Me.Panel6.Location = New System.Drawing.Point(0, 512)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1077, 54)
        Me.Panel6.TabIndex = 2
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1077, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(884, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(973, 10)
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
        Me.Grid.Location = New System.Drawing.Point(12, 314)
        Me.Grid.LookupButtonBackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(1044, 169)
        Me.Grid.TabIndex = 1
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.Location = New System.Drawing.Point(104, 52)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(141, 20)
        Me.txtNoTransaksi.TabIndex = 1
        '
        'txtTglPencatatan
        '
        Me.txtTglPencatatan.AllowEnterToMoveNext = True
        Me.txtTglPencatatan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPencatatan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPencatatan.Location = New System.Drawing.Point(343, 52)
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
        Me.cboKodeGrup.Location = New System.Drawing.Point(570, 52)
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
        Me.cboKodeMesin.Location = New System.Drawing.Point(806, 52)
        Me.cboKodeMesin.Name = "cboKodeMesin"
        Me.cboKodeMesin.Size = New System.Drawing.Size(114, 21)
        Me.cboKodeMesin.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(686, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 95
        Me.Button2.TabStop = False
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(922, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 96
        Me.Button3.TabStop = False
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btLookupNomorWO
        '
        Me.btLookupNomorWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btLookupNomorWO.Location = New System.Drawing.Point(476, 136)
        Me.btLookupNomorWO.Name = "btLookupNomorWO"
        Me.btLookupNomorWO.Size = New System.Drawing.Size(25, 21)
        Me.btLookupNomorWO.TabIndex = 98
        Me.btLookupNomorWO.TabStop = False
        Me.btLookupNomorWO.Text = ".."
        Me.btLookupNomorWO.UseVisualStyleBackColor = True
        '
        'cboNomorWO
        '
        Me.cboNomorWO.AllowEnterToMoveNext = True
        Me.cboNomorWO.BackColor = System.Drawing.Color.White
        Me.cboNomorWO.DataLocked = False
        Me.cboNomorWO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorWO.DropDownHeight = 105
        Me.cboNomorWO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboNomorWO.ForeColor = System.Drawing.Color.Red
        Me.cboNomorWO.IndexLocked = False
        Me.cboNomorWO.IntegralHeight = False
        Me.cboNomorWO.Location = New System.Drawing.Point(104, 136)
        Me.cboNomorWO.Name = "cboNomorWO"
        Me.cboNomorWO.Size = New System.Drawing.Size(372, 21)
        Me.cboNomorWO.TabIndex = 5
        '
        'txtKodeItemFG
        '
        Me.txtKodeItemFG.AllowEnterToMoveNext = True
        Me.txtKodeItemFG.BackColor = System.Drawing.Color.White
        Me.txtKodeItemFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtKodeItemFG.Location = New System.Drawing.Point(104, 163)
        Me.txtKodeItemFG.Name = "txtKodeItemFG"
        Me.txtKodeItemFG.ReadOnly = True
        Me.txtKodeItemFG.Size = New System.Drawing.Size(420, 20)
        Me.txtKodeItemFG.TabIndex = 6
        Me.txtKodeItemFG.TabStop = False
        '
        'lblBarisData
        '
        Me.lblBarisData.AutoSize = True
        Me.lblBarisData.BackColor = System.Drawing.Color.Transparent
        Me.lblBarisData.Location = New System.Drawing.Point(9, 486)
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
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'txtKodeShift
        '
        Me.txtKodeShift.BackColor = System.Drawing.Color.Teal
        Me.txtKodeShift.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtKodeShift.ForeColor = System.Drawing.Color.White
        Me.txtKodeShift.Location = New System.Drawing.Point(994, 53)
        Me.txtKodeShift.Name = "txtKodeShift"
        Me.txtKodeShift.Size = New System.Drawing.Size(61, 20)
        Me.txtKodeShift.TabIndex = 122
        Me.txtKodeShift.Text = "3"
        Me.txtKodeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lstMaterialTransfer)
        Me.Panel1.Controls.Add(Me.lblTanggalWOTransfer)
        Me.Panel1.Controls.Add(Me.lblTanggalWO)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtKodeSatuanFGTransfer)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtKodeItemFGTransfer)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.btLookupNomorWOTransfer)
        Me.Panel1.Controls.Add(Me.cboNomorWOTransfer)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtKodeShift)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btShow)
        Me.Panel1.Controls.Add(Me.txtKodeSatuanFG)
        Me.Panel1.Controls.Add(Me.txtNilaiBDP)
        Me.Panel1.Controls.Add(Me.txtTotalProduksi)
        Me.Panel1.Controls.Add(Me.txtReturProduksi)
        Me.Panel1.Controls.Add(Me.txtHasilProduksi)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cboKodeUnit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNoTransaksi)
        Me.Panel1.Controls.Add(Me.txtTglPencatatan)
        Me.Panel1.Controls.Add(Me.txtKodeItemFG)
        Me.Panel1.Controls.Add(Me.btLookupNomorWO)
        Me.Panel1.Controls.Add(Me.cboKodeGrup)
        Me.Panel1.Controls.Add(Me.cboNomorWO)
        Me.Panel1.Controls.Add(Me.cboKodeMesin)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 297)
        Me.Panel1.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(542, 190)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 159
        Me.Label20.Text = "Material"
        '
        'txtKodeSatuanFGTransfer
        '
        Me.txtKodeSatuanFGTransfer.AutoSize = True
        Me.txtKodeSatuanFGTransfer.BackColor = System.Drawing.SystemColors.Control
        Me.txtKodeSatuanFGTransfer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeSatuanFGTransfer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtKodeSatuanFGTransfer.Location = New System.Drawing.Point(1000, 163)
        Me.txtKodeSatuanFGTransfer.Name = "txtKodeSatuanFGTransfer"
        Me.txtKodeSatuanFGTransfer.Size = New System.Drawing.Size(64, 19)
        Me.txtKodeSatuanFGTransfer.TabIndex = 158
        Me.txtKodeSatuanFGTransfer.Text = "XXXXX"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(542, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Item Produksi"
        '
        'txtKodeItemFGTransfer
        '
        Me.txtKodeItemFGTransfer.AllowEnterToMoveNext = True
        Me.txtKodeItemFGTransfer.BackColor = System.Drawing.Color.White
        Me.txtKodeItemFGTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtKodeItemFGTransfer.Location = New System.Drawing.Point(621, 163)
        Me.txtKodeItemFGTransfer.Name = "txtKodeItemFGTransfer"
        Me.txtKodeItemFGTransfer.ReadOnly = True
        Me.txtKodeItemFGTransfer.Size = New System.Drawing.Size(377, 20)
        Me.txtKodeItemFGTransfer.TabIndex = 8
        Me.txtKodeItemFGTransfer.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(542, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "Nomor SPK"
        '
        'btLookupNomorWOTransfer
        '
        Me.btLookupNomorWOTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btLookupNomorWOTransfer.Location = New System.Drawing.Point(1030, 136)
        Me.btLookupNomorWOTransfer.Name = "btLookupNomorWOTransfer"
        Me.btLookupNomorWOTransfer.Size = New System.Drawing.Size(25, 21)
        Me.btLookupNomorWOTransfer.TabIndex = 154
        Me.btLookupNomorWOTransfer.TabStop = False
        Me.btLookupNomorWOTransfer.Text = ".."
        Me.btLookupNomorWOTransfer.UseVisualStyleBackColor = True
        '
        'cboNomorWOTransfer
        '
        Me.cboNomorWOTransfer.AllowEnterToMoveNext = True
        Me.cboNomorWOTransfer.BackColor = System.Drawing.Color.White
        Me.cboNomorWOTransfer.DataLocked = False
        Me.cboNomorWOTransfer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNomorWOTransfer.DropDownHeight = 105
        Me.cboNomorWOTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNomorWOTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboNomorWOTransfer.ForeColor = System.Drawing.Color.Red
        Me.cboNomorWOTransfer.IndexLocked = False
        Me.cboNomorWOTransfer.IntegralHeight = False
        Me.cboNomorWOTransfer.Location = New System.Drawing.Point(621, 136)
        Me.cboNomorWOTransfer.Name = "cboNomorWOTransfer"
        Me.cboNomorWOTransfer.Size = New System.Drawing.Size(406, 21)
        Me.cboNomorWOTransfer.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label16.Location = New System.Drawing.Point(541, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(514, 20)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "TRANSFER BDP KE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(960, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Shift"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Location = New System.Drawing.Point(11, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(514, 20)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "WORK ORDER"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(0, 93)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1200, 1)
        Me.PictureBox3.TabIndex = 148
        Me.PictureBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "Nilai BDP"
        '
        'btShow
        '
        Me.btShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btShow.Location = New System.Drawing.Point(500, 136)
        Me.btShow.Name = "btShow"
        Me.btShow.Size = New System.Drawing.Size(25, 21)
        Me.btShow.TabIndex = 146
        Me.btShow.TabStop = False
        Me.btShow.Text = ">>"
        Me.btShow.UseVisualStyleBackColor = True
        '
        'txtKodeSatuanFG
        '
        Me.txtKodeSatuanFG.AutoSize = True
        Me.txtKodeSatuanFG.BackColor = System.Drawing.SystemColors.Control
        Me.txtKodeSatuanFG.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeSatuanFG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtKodeSatuanFG.Location = New System.Drawing.Point(454, 257)
        Me.txtKodeSatuanFG.Name = "txtKodeSatuanFG"
        Me.txtKodeSatuanFG.Size = New System.Drawing.Size(64, 19)
        Me.txtKodeSatuanFG.TabIndex = 145
        Me.txtKodeSatuanFG.Text = "XXXXX"
        '
        'txtNilaiBDP
        '
        Me.txtNilaiBDP.AllowEnterToMoveNext = True
        Me.txtNilaiBDP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNilaiBDP.CheckIsValid = False
        Me.txtNilaiBDP.DataFormat = "###,##0.00"
        Me.txtNilaiBDP.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtNilaiBDP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilaiBDP.ForeColor = System.Drawing.Color.Black
        Me.txtNilaiBDP.Location = New System.Drawing.Point(104, 186)
        Me.txtNilaiBDP.Name = "txtNilaiBDP"
        Me.txtNilaiBDP.ReadOnly = True
        Me.txtNilaiBDP.Size = New System.Drawing.Size(344, 32)
        Me.txtNilaiBDP.TabIndex = 142
        Me.txtNilaiBDP.Text = "9,999,999,999.99"
        Me.txtNilaiBDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNilaiBDP.Value = 9999999999.99R
        '
        'txtTotalProduksi
        '
        Me.txtTotalProduksi.AllowEnterToMoveNext = True
        Me.txtTotalProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalProduksi.CheckIsValid = False
        Me.txtTotalProduksi.DataFormat = "###,##0.00"
        Me.txtTotalProduksi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotalProduksi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalProduksi.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalProduksi.Location = New System.Drawing.Point(334, 255)
        Me.txtTotalProduksi.Name = "txtTotalProduksi"
        Me.txtTotalProduksi.ReadOnly = True
        Me.txtTotalProduksi.Size = New System.Drawing.Size(114, 25)
        Me.txtTotalProduksi.TabIndex = 141
        Me.txtTotalProduksi.Text = "0.00"
        Me.txtTotalProduksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalProduksi.Value = 0.0R
        '
        'txtReturProduksi
        '
        Me.txtReturProduksi.AllowEnterToMoveNext = True
        Me.txtReturProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReturProduksi.CheckIsValid = False
        Me.txtReturProduksi.DataFormat = "###,##0.00"
        Me.txtReturProduksi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtReturProduksi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtReturProduksi.ForeColor = System.Drawing.Color.Blue
        Me.txtReturProduksi.Location = New System.Drawing.Point(217, 255)
        Me.txtReturProduksi.Name = "txtReturProduksi"
        Me.txtReturProduksi.ReadOnly = True
        Me.txtReturProduksi.Size = New System.Drawing.Size(114, 25)
        Me.txtReturProduksi.TabIndex = 140
        Me.txtReturProduksi.Text = "0.00"
        Me.txtReturProduksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtReturProduksi.Value = 0.0R
        '
        'txtHasilProduksi
        '
        Me.txtHasilProduksi.AllowEnterToMoveNext = True
        Me.txtHasilProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilProduksi.CheckIsValid = False
        Me.txtHasilProduksi.DataFormat = "###,##0.00"
        Me.txtHasilProduksi.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilProduksi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtHasilProduksi.ForeColor = System.Drawing.Color.Blue
        Me.txtHasilProduksi.Location = New System.Drawing.Point(101, 255)
        Me.txtHasilProduksi.Name = "txtHasilProduksi"
        Me.txtHasilProduksi.ReadOnly = True
        Me.txtHasilProduksi.Size = New System.Drawing.Size(114, 25)
        Me.txtHasilProduksi.TabIndex = 139
        Me.txtHasilProduksi.Text = "0.00"
        Me.txtHasilProduksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilProduksi.Value = 0.0R
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(373, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "Total Produksi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(228, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Retur Hasil Produksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(141, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "Hasil Produksi"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(101, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(420, 22)
        Me.Label4.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Volume Produksi"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1200, 1)
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
        Me.cboKodeUnit.Size = New System.Drawing.Size(951, 21)
        Me.cboKodeUnit.TabIndex = 0
        Me.cboKodeUnit.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(0, 299)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1500, 1)
        Me.PictureBox4.TabIndex = 153
        Me.PictureBox4.TabStop = False
        '
        'lblTanggalWO
        '
        Me.lblTanggalWO.AutoSize = True
        Me.lblTanggalWO.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTanggalWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalWO.ForeColor = System.Drawing.Color.Red
        Me.lblTanggalWO.Location = New System.Drawing.Point(443, 110)
        Me.lblTanggalWO.Name = "lblTanggalWO"
        Me.lblTanggalWO.Size = New System.Drawing.Size(75, 13)
        Me.lblTanggalWO.TabIndex = 160
        Me.lblTanggalWO.Text = "99/99/9999"
        '
        'lblTanggalWOTransfer
        '
        Me.lblTanggalWOTransfer.AutoSize = True
        Me.lblTanggalWOTransfer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTanggalWOTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalWOTransfer.ForeColor = System.Drawing.Color.Red
        Me.lblTanggalWOTransfer.Location = New System.Drawing.Point(969, 110)
        Me.lblTanggalWOTransfer.Name = "lblTanggalWOTransfer"
        Me.lblTanggalWOTransfer.Size = New System.Drawing.Size(75, 13)
        Me.lblTanggalWOTransfer.TabIndex = 161
        Me.lblTanggalWOTransfer.Text = "99/99/9999"
        '
        'lstMaterialTransfer
        '
        Me.lstMaterialTransfer.FormattingEnabled = True
        Me.lstMaterialTransfer.Location = New System.Drawing.Point(622, 190)
        Me.lstMaterialTransfer.Name = "lstMaterialTransfer"
        Me.lstMaterialTransfer.Size = New System.Drawing.Size(433, 95)
        Me.lstMaterialTransfer.TabIndex = 162
        '
        'frmTransferBDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 566)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblBarisData)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmTransferBDP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Barang Dalam Proses (BDP)"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btLookupNomorWO As System.Windows.Forms.Button
    Private WithEvents cboNomorWO As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtKodeItemFG As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents lblBarisData As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents txtKodeShift As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboKodeUnit As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalProduksi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtReturProduksi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtHasilProduksi As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtNilaiBDP As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtKodeSatuanFG As System.Windows.Forms.Label
    Friend WithEvents btShow As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtKodeItemFGTransfer As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btLookupNomorWOTransfer As System.Windows.Forms.Button
    Private WithEvents cboNomorWOTransfer As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSatuanFGTransfer As System.Windows.Forms.Label
    Friend WithEvents lblTanggalWOTransfer As System.Windows.Forms.Label
    Friend WithEvents lblTanggalWO As System.Windows.Forms.Label
    Friend WithEvents lstMaterialTransfer As System.Windows.Forms.ListBox
End Class
