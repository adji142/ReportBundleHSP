<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKPI))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.lblKet = New System.Windows.Forms.Label()
        Me.GridKpi = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.pnHeader = New System.Windows.Forms.Panel()
        Me.txtTglPencatatan = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTahun = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboBulan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboDept = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboPosisi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboBagian = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.btnDept = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPosisi = New System.Windows.Forms.Button()
        Me.btnBagian = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblBarisData = New System.Windows.Forms.Label()
        Me.btFinish = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.pnAspek = New System.Windows.Forms.Panel()
        Me.btReproses = New System.Windows.Forms.Button()
        Me.lboAspek = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btProses = New System.Windows.Forms.Button()
        Me.txtBobot = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtTarget = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnParameter = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.pnData.SuspendLayout()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnHeader.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnAspek.SuspendLayout()
        Me.pnParameter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.BlueViolet
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(595, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "#Rincian Hasil Penilaian"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Posisi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Bagian"
        '
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.Color.Transparent
        Me.pnData.Controls.Add(Me.lblKet)
        Me.pnData.Controls.Add(Me.GridKpi)
        Me.pnData.Controls.Add(Me.Label8)
        Me.pnData.Location = New System.Drawing.Point(6, 176)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(616, 306)
        Me.pnData.TabIndex = 2
        '
        'lblKet
        '
        Me.lblKet.AutoSize = True
        Me.lblKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet.ForeColor = System.Drawing.Color.Crimson
        Me.lblKet.Location = New System.Drawing.Point(66, 150)
        Me.lblKet.Name = "lblKet"
        Me.lblKet.Size = New System.Drawing.Size(0, 25)
        Me.lblKet.TabIndex = 2
        Me.lblKet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridKpi
        '
        Me.GridKpi.AllowDeleteRow = False
        Me.GridKpi.AllowInsertRow = False
        Me.GridKpi.AlternatingCellFocusBackColor = System.Drawing.Color.PowderBlue
        Me.GridKpi.AlternatingCellFocusForeColor = System.Drawing.Color.Black
        Me.GridKpi.AlternatingDataGridBackColor = System.Drawing.Color.White
        Me.GridKpi.AlternatingDataGridForeColor = System.Drawing.Color.Empty
        Me.GridKpi.CellFocusBackColor = System.Drawing.Color.LightBlue
        Me.GridKpi.CellFocusForeColor = System.Drawing.Color.Black
        Me.GridKpi.DataGridBackColor = System.Drawing.Color.Empty
        Me.GridKpi.DataGridForeColor = System.Drawing.Color.Empty
        Me.GridKpi.GridColor = System.Drawing.Color.Gainsboro
        Me.GridKpi.HeaderBackColor = System.Drawing.Color.WhiteSmoke
        Me.GridKpi.HeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.GridKpi.Location = New System.Drawing.Point(8, 47)
        Me.GridKpi.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.GridKpi.Name = "GridKpi"
        Me.GridKpi.RowHeaderBackColor = System.Drawing.Color.White
        Me.GridKpi.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.GridKpi.SingleRowMode = False
        Me.GridKpi.Size = New System.Drawing.Size(594, 256)
        Me.GridKpi.TabIndex = 0
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.AllowEnterToMoveNext = True
        Me.txtNoTransaksi.BackColor = System.Drawing.Color.White
        Me.txtNoTransaksi.Location = New System.Drawing.Point(118, 14)
        Me.txtNoTransaksi.MaxLength = 15
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(95, 20)
        Me.txtNoTransaksi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periode"
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(222, 15)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 26
        Me.Locked.TabStop = False
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.txtTglPencatatan)
        Me.pnHeader.Controls.Add(Me.Label11)
        Me.pnHeader.Controls.Add(Me.cboTahun)
        Me.pnHeader.Controls.Add(Me.cboBulan)
        Me.pnHeader.Controls.Add(Me.cboDept)
        Me.pnHeader.Controls.Add(Me.cboPosisi)
        Me.pnHeader.Controls.Add(Me.cboBagian)
        Me.pnHeader.Controls.Add(Me.btnDept)
        Me.pnHeader.Controls.Add(Me.Label3)
        Me.pnHeader.Controls.Add(Me.btnPosisi)
        Me.pnHeader.Controls.Add(Me.btnBagian)
        Me.pnHeader.Controls.Add(Me.Label5)
        Me.pnHeader.Controls.Add(Me.Label4)
        Me.pnHeader.Controls.Add(Me.Locked)
        Me.pnHeader.Controls.Add(Me.txtNoTransaksi)
        Me.pnHeader.Controls.Add(Me.Label2)
        Me.pnHeader.Controls.Add(Me.Label1)
        Me.pnHeader.Location = New System.Drawing.Point(6, 6)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(513, 164)
        Me.pnHeader.TabIndex = 0
        '
        'txtTglPencatatan
        '
        Me.txtTglPencatatan.AllowEnterToMoveNext = True
        Me.txtTglPencatatan.CustomFormat = "dd/MM/yyyy"
        Me.txtTglPencatatan.Enabled = False
        Me.txtTglPencatatan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglPencatatan.Location = New System.Drawing.Point(371, 14)
        Me.txtTglPencatatan.Name = "txtTglPencatatan"
        Me.txtTglPencatatan.Size = New System.Drawing.Size(95, 20)
        Me.txtTglPencatatan.TabIndex = 130
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(273, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 14)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Tgl Pencatatan"
        '
        'cboTahun
        '
        Me.cboTahun.AllowEnterToMoveNext = True
        Me.cboTahun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTahun.BackColor = System.Drawing.Color.White
        Me.cboTahun.DataLocked = False
        Me.cboTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTahun.IndexLocked = False
        Me.cboTahun.Location = New System.Drawing.Point(218, 40)
        Me.cboTahun.Name = "cboTahun"
        Me.cboTahun.Size = New System.Drawing.Size(63, 21)
        Me.cboTahun.TabIndex = 2
        '
        'cboBulan
        '
        Me.cboBulan.AllowEnterToMoveNext = True
        Me.cboBulan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBulan.BackColor = System.Drawing.Color.White
        Me.cboBulan.DataLocked = False
        Me.cboBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBulan.IndexLocked = False
        Me.cboBulan.Location = New System.Drawing.Point(117, 40)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(95, 21)
        Me.cboBulan.TabIndex = 1
        '
        'cboDept
        '
        Me.cboDept.AllowEnterToMoveNext = True
        Me.cboDept.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDept.BackColor = System.Drawing.Color.White
        Me.cboDept.DataLocked = False
        Me.cboDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.IndexLocked = False
        Me.cboDept.Location = New System.Drawing.Point(117, 67)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(349, 21)
        Me.cboDept.TabIndex = 3
        '
        'cboPosisi
        '
        Me.cboPosisi.AllowEnterToMoveNext = True
        Me.cboPosisi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPosisi.BackColor = System.Drawing.Color.White
        Me.cboPosisi.DataLocked = False
        Me.cboPosisi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPosisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosisi.IndexLocked = False
        Me.cboPosisi.Location = New System.Drawing.Point(117, 123)
        Me.cboPosisi.Name = "cboPosisi"
        Me.cboPosisi.Size = New System.Drawing.Size(349, 21)
        Me.cboPosisi.TabIndex = 7
        '
        'cboBagian
        '
        Me.cboBagian.AllowEnterToMoveNext = True
        Me.cboBagian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBagian.BackColor = System.Drawing.Color.White
        Me.cboBagian.DataLocked = False
        Me.cboBagian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBagian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBagian.IndexLocked = False
        Me.cboBagian.Location = New System.Drawing.Point(117, 96)
        Me.cboBagian.Name = "cboBagian"
        Me.cboBagian.Size = New System.Drawing.Size(349, 21)
        Me.cboBagian.TabIndex = 5
        '
        'btnDept
        '
        Me.btnDept.Location = New System.Drawing.Point(473, 66)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(25, 23)
        Me.btnDept.TabIndex = 4
        Me.btnDept.TabStop = False
        Me.btnDept.Text = "..."
        Me.btnDept.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Departemen"
        '
        'btnPosisi
        '
        Me.btnPosisi.Location = New System.Drawing.Point(473, 122)
        Me.btnPosisi.Name = "btnPosisi"
        Me.btnPosisi.Size = New System.Drawing.Size(25, 23)
        Me.btnPosisi.TabIndex = 8
        Me.btnPosisi.TabStop = False
        Me.btnPosisi.Text = "..."
        Me.btnPosisi.UseVisualStyleBackColor = True
        '
        'btnBagian
        '
        Me.btnBagian.Location = New System.Drawing.Point(473, 95)
        Me.btnBagian.Name = "btnBagian"
        Me.btnBagian.Size = New System.Drawing.Size(25, 23)
        Me.btnBagian.TabIndex = 6
        Me.btnBagian.TabStop = False
        Me.btnBagian.Text = "..."
        Me.btnBagian.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.lblBarisData)
        Me.Panel6.Controls.Add(Me.btFinish)
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 488)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1034, 54)
        Me.Panel6.TabIndex = 4
        '
        'lblBarisData
        '
        Me.lblBarisData.AutoSize = True
        Me.lblBarisData.Location = New System.Drawing.Point(11, 15)
        Me.lblBarisData.Name = "lblBarisData"
        Me.lblBarisData.Size = New System.Drawing.Size(54, 13)
        Me.lblBarisData.TabIndex = 102
        Me.lblBarisData.Text = "Kelompok"
        '
        'btFinish
        '
        Me.btFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btFinish.Location = New System.Drawing.Point(841, 10)
        Me.btFinish.Name = "btFinish"
        Me.btFinish.Size = New System.Drawing.Size(83, 23)
        Me.btFinish.TabIndex = 1
        Me.btFinish.Text = "&Selesai"
        Me.btFinish.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1034, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(752, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(930, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'pnAspek
        '
        Me.pnAspek.Controls.Add(Me.btReproses)
        Me.pnAspek.Controls.Add(Me.lboAspek)
        Me.pnAspek.Controls.Add(Me.Label10)
        Me.pnAspek.Controls.Add(Me.btProses)
        Me.pnAspek.Controls.Add(Me.txtBobot)
        Me.pnAspek.Controls.Add(Me.txtTarget)
        Me.pnAspek.Controls.Add(Me.Label7)
        Me.pnAspek.Controls.Add(Me.Label9)
        Me.pnAspek.Controls.Add(Me.Label6)
        Me.pnAspek.Location = New System.Drawing.Point(525, 6)
        Me.pnAspek.Name = "pnAspek"
        Me.pnAspek.Size = New System.Drawing.Size(503, 164)
        Me.pnAspek.TabIndex = 1
        '
        'btReproses
        '
        Me.btReproses.Location = New System.Drawing.Point(383, 96)
        Me.btReproses.Name = "btReproses"
        Me.btReproses.Size = New System.Drawing.Size(105, 23)
        Me.btReproses.TabIndex = 0
        Me.btReproses.Text = "Proses Ulang"
        Me.btReproses.UseVisualStyleBackColor = True
        '
        'lboAspek
        '
        Me.lboAspek.FormattingEnabled = True
        Me.lboAspek.Location = New System.Drawing.Point(10, 41)
        Me.lboAspek.Name = "lboAspek"
        Me.lboAspek.Size = New System.Drawing.Size(312, 121)
        Me.lboAspek.TabIndex = 0
        Me.lboAspek.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(10, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(312, 121)
        Me.Label10.TabIndex = 153
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btProses
        '
        Me.btProses.Location = New System.Drawing.Point(514, 71)
        Me.btProses.Name = "btProses"
        Me.btProses.Size = New System.Drawing.Size(105, 23)
        Me.btProses.TabIndex = 3
        Me.btProses.Text = "Proses"
        Me.btProses.UseVisualStyleBackColor = True
        '
        'txtBobot
        '
        Me.txtBobot.AllowEnterToMoveNext = True
        Me.txtBobot.CheckIsValid = False
        Me.txtBobot.DataFormat = "###,##0.00"
        Me.txtBobot.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBobot.Enabled = False
        Me.txtBobot.Location = New System.Drawing.Point(386, 6)
        Me.txtBobot.Name = "txtBobot"
        Me.txtBobot.Size = New System.Drawing.Size(105, 20)
        Me.txtBobot.TabIndex = 1
        Me.txtBobot.Text = "0,00"
        Me.txtBobot.Value = 0.0R
        '
        'txtTarget
        '
        Me.txtTarget.AllowEnterToMoveNext = True
        Me.txtTarget.CheckIsValid = False
        Me.txtTarget.DataFormat = "###,##0.00"
        Me.txtTarget.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTarget.Enabled = False
        Me.txtTarget.Location = New System.Drawing.Point(386, 33)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(105, 20)
        Me.txtTarget.TabIndex = 2
        Me.txtTarget.Text = "0,00"
        Me.txtTarget.Value = 0.0R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 14)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Bobot"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(330, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 14)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Target"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 32)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "#Daftar Aspek"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnParameter
        '
        Me.pnParameter.Controls.Add(Me.Label12)
        Me.pnParameter.Controls.Add(Me.Grid)
        Me.pnParameter.Location = New System.Drawing.Point(627, 176)
        Me.pnParameter.Name = "pnParameter"
        Me.pnParameter.Size = New System.Drawing.Size(401, 306)
        Me.pnParameter.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Orchid
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(9, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(380, 32)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "#Norma Penilaian"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Grid
        '
        Me.Grid.AllowDeleteRow = False
        Me.Grid.AllowInsertRow = False
        Me.Grid.AlternatingCellFocusBackColor = System.Drawing.Color.PowderBlue
        Me.Grid.AlternatingCellFocusForeColor = System.Drawing.Color.Black
        Me.Grid.AlternatingDataGridBackColor = System.Drawing.Color.White
        Me.Grid.AlternatingDataGridForeColor = System.Drawing.Color.Empty
        Me.Grid.CellFocusBackColor = System.Drawing.Color.LightBlue
        Me.Grid.CellFocusForeColor = System.Drawing.Color.Black
        Me.Grid.DataGridBackColor = System.Drawing.Color.Empty
        Me.Grid.DataGridForeColor = System.Drawing.Color.Empty
        Me.Grid.GridColor = System.Drawing.Color.Gainsboro
        Me.Grid.HeaderBackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.HeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.Location = New System.Drawing.Point(9, 48)
        Me.Grid.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(380, 255)
        Me.Grid.TabIndex = 7
        '
        'frmKPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 542)
        Me.Controls.Add(Me.pnParameter)
        Me.Controls.Add(Me.pnAspek)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pnData)
        Me.Controls.Add(Me.pnHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKPI"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Key Performance Indicator ( KPI )"
        Me.pnData.ResumeLayout(False)
        Me.pnData.PerformLayout()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnAspek.ResumeLayout(False)
        Me.pnAspek.PerformLayout()
        Me.pnParameter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents GridKpi As Enerzie.EPSGridControls.EPSTableEdit
    Private WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents btnPosisi As System.Windows.Forms.Button
    Friend WithEvents btnBagian As System.Windows.Forms.Button
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents lblBarisData As System.Windows.Forms.Label
    Private WithEvents btFinish As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboTahun As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents cboBulan As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents cboDept As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents cboPosisi As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents cboBagian As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents pnAspek As System.Windows.Forms.Panel
    Friend WithEvents btProses As System.Windows.Forms.Button
    Friend WithEvents txtBobot As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtTarget As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnParameter As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents lboAspek As System.Windows.Forms.ListBox
    Private WithEvents lblKet As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btReproses As System.Windows.Forms.Button
    Friend WithEvents txtTglPencatatan As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
