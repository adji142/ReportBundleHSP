<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengeluaranBarang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHari = New System.Windows.Forms.Label()
        Me.cboKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblKodeProduksi = New System.Windows.Forms.Label()
        Me.txtKodeProduksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.EpsComboBox1 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EpsTextBox1 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EpsTextBox2 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grid = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EpsDataGridView1 = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pcs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timbang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHasilMeter = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(159, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENGELUARAN BARANG"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblHari)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboKelompok)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 105)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.HSPProduction.My.Resources.Resources.barcode
        Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(734, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 88)
        Me.Panel2.TabIndex = 2
        '
        'lblHari
        '
        Me.lblHari.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHari.ForeColor = System.Drawing.Color.Lime
        Me.lblHari.Location = New System.Drawing.Point(162, 58)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(287, 32)
        Me.lblHari.TabIndex = 1
        Me.lblHari.Text = "27/02/2017 09:00:00"
        Me.lblHari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboKelompok
        '
        Me.cboKelompok.AllowEnterToMoveNext = True
        Me.cboKelompok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKelompok.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKelompok.DataLocked = False
        Me.cboKelompok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompok.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKelompok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboKelompok.FormattingEnabled = True
        Me.cboKelompok.IndexLocked = False
        Me.cboKelompok.Items.AddRange(New Object() {"<Pilih Kelompok Produksi>", "Karung", "Cement Bag", "Roll", "Benang Multifilament", "Benang Extruder"})
        Me.cboKelompok.Location = New System.Drawing.Point(743, 50)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(475, 30)
        Me.cboKelompok.TabIndex = 0
        Me.cboKelompok.TabStop = False
        '
        'lblKodeProduksi
        '
        Me.lblKodeProduksi.AutoSize = True
        Me.lblKodeProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeProduksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblKodeProduksi.Location = New System.Drawing.Point(19, 259)
        Me.lblKodeProduksi.Name = "lblKodeProduksi"
        Me.lblKodeProduksi.Size = New System.Drawing.Size(130, 23)
        Me.lblKodeProduksi.TabIndex = 4
        Me.lblKodeProduksi.Text = "Batch / Barcode"
        '
        'txtKodeProduksi
        '
        Me.txtKodeProduksi.AllowEnterToMoveNext = True
        Me.txtKodeProduksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeProduksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeProduksi.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProduksi.Location = New System.Drawing.Point(166, 259)
        Me.txtKodeProduksi.Name = "txtKodeProduksi"
        Me.txtKodeProduksi.Size = New System.Drawing.Size(551, 29)
        Me.txtKodeProduksi.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.pictureBox2)
        Me.Panel3.Controls.Add(Me.btSave)
        Me.Panel3.Controls.Add(Me.btClose)
        Me.Panel3.Controls.Add(Me.lblItem)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 551)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1245, 54)
        Me.Panel3.TabIndex = 3
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1245, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(1046, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(1135, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'lblItem
        '
        Me.lblItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(23, 10)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(27, 13)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "Item"
        Me.lblItem.Visible = False
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.lblJumlah)
        Me.Panel4.Location = New System.Drawing.Point(743, 82)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(475, 206)
        Me.Panel4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Navy
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(463, 54)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "1000"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJumlah
        '
        Me.lblJumlah.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblJumlah.Font = New System.Drawing.Font("Tahoma", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlah.ForeColor = System.Drawing.Color.White
        Me.lblJumlah.Location = New System.Drawing.Point(6, 6)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(463, 138)
        Me.lblJumlah.TabIndex = 1
        Me.lblJumlah.Text = "1000"
        Me.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EpsComboBox1
        '
        Me.EpsComboBox1.AllowEnterToMoveNext = True
        Me.EpsComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EpsComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EpsComboBox1.DataLocked = False
        Me.EpsComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EpsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EpsComboBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.EpsComboBox1.ForeColor = System.Drawing.Color.Red
        Me.EpsComboBox1.FormattingEnabled = True
        Me.EpsComboBox1.IndexLocked = False
        Me.EpsComboBox1.Items.AddRange(New Object() {"<Pilih Kelompok Produksi>", "Karung", "Cement Bag", "Roll", "Benang Multifilament", "Benang Extruder"})
        Me.EpsComboBox1.Location = New System.Drawing.Point(166, 127)
        Me.EpsComboBox1.Name = "EpsComboBox1"
        Me.EpsComboBox1.Size = New System.Drawing.Size(521, 26)
        Me.EpsComboBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(19, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "No.Perintah / Pick"
        '
        'EpsTextBox1
        '
        Me.EpsTextBox1.AllowEnterToMoveNext = True
        Me.EpsTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EpsTextBox1.BackColor = System.Drawing.Color.White
        Me.EpsTextBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.EpsTextBox1.Location = New System.Drawing.Point(166, 155)
        Me.EpsTextBox1.Name = "EpsTextBox1"
        Me.EpsTextBox1.ReadOnly = True
        Me.EpsTextBox1.Size = New System.Drawing.Size(551, 25)
        Me.EpsTextBox1.TabIndex = 12
        Me.EpsTextBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(19, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Transaksi"
        '
        'EpsTextBox2
        '
        Me.EpsTextBox2.AllowEnterToMoveNext = True
        Me.EpsTextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EpsTextBox2.BackColor = System.Drawing.Color.White
        Me.EpsTextBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.EpsTextBox2.Location = New System.Drawing.Point(166, 182)
        Me.EpsTextBox2.Name = "EpsTextBox2"
        Me.EpsTextBox2.ReadOnly = True
        Me.EpsTextBox2.Size = New System.Drawing.Size(551, 25)
        Me.EpsTextBox2.TabIndex = 14
        Me.EpsTextBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(19, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Item Barang"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.BackgroundColor = System.Drawing.Color.Black
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.ColumnHeadersHeight = 50
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO, Me.Kode, Me.KodeItem, Me.Pcs, Me.Timbang})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle5
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.White
        Me.Grid.Location = New System.Drawing.Point(166, 294)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.ShowEditingIcon = False
        Me.Grid.Size = New System.Drawing.Size(551, 241)
        Me.Grid.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(689, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 27)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EpsDataGridView1
        '
        Me.EpsDataGridView1.AllowUserToAddRows = False
        Me.EpsDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EpsDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.EpsDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EpsDataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.EpsDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EpsDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.EpsDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EpsDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.EpsDataGridView1.ColumnHeadersHeight = 50
        Me.EpsDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EpsDataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.EpsDataGridView1.EnableHeadersVisualStyles = False
        Me.EpsDataGridView1.GridColor = System.Drawing.Color.White
        Me.EpsDataGridView1.Location = New System.Drawing.Point(743, 294)
        Me.EpsDataGridView1.MultiSelect = False
        Me.EpsDataGridView1.Name = "EpsDataGridView1"
        Me.EpsDataGridView1.ReadOnly = True
        Me.EpsDataGridView1.RowHeadersVisible = False
        Me.EpsDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EpsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EpsDataGridView1.ShowEditingIcon = False
        Me.EpsDataGridView1.Size = New System.Drawing.Size(476, 240)
        Me.EpsDataGridView1.TabIndex = 19
        '
        'NO
        '
        Me.NO.HeaderText = "NO"
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        Me.NO.Width = 75
        '
        'Kode
        '
        Me.Kode.FillWeight = 380.7107!
        Me.Kode.HeaderText = "BARCODE"
        Me.Kode.Name = "Kode"
        Me.Kode.ReadOnly = True
        Me.Kode.Width = 150
        '
        'KodeItem
        '
        Me.KodeItem.FillWeight = 29.82233!
        Me.KodeItem.HeaderText = "KODE"
        Me.KodeItem.Name = "KodeItem"
        Me.KodeItem.ReadOnly = True
        '
        'Pcs
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Pcs.DefaultCellStyle = DataGridViewCellStyle3
        Me.Pcs.FillWeight = 29.82233!
        Me.Pcs.HeaderText = "QTY"
        Me.Pcs.Name = "Pcs"
        Me.Pcs.ReadOnly = True
        '
        'Timbang
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Timbang.DefaultCellStyle = DataGridViewCellStyle4
        Me.Timbang.FillWeight = 29.82233!
        Me.Timbang.HeaderText = "KILOGRAM"
        Me.Timbang.Name = "Timbang"
        Me.Timbang.ReadOnly = True
        Me.Timbang.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 380.7107!
        Me.DataGridViewTextBoxColumn1.HeaderText = "BARCODE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.FillWeight = 29.82233!
        Me.DataGridViewTextBoxColumn4.HeaderText = "KETERANGAN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(19, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Jumlah"
        '
        'txtHasilMeter
        '
        Me.txtHasilMeter.AllowEnterToMoveNext = True
        Me.txtHasilMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHasilMeter.CheckIsValid = False
        Me.txtHasilMeter.DataFormat = "###,##0"
        Me.txtHasilMeter.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasilMeter.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasilMeter.ForeColor = System.Drawing.Color.Blue
        Me.txtHasilMeter.Location = New System.Drawing.Point(166, 211)
        Me.txtHasilMeter.Name = "txtHasilMeter"
        Me.txtHasilMeter.Size = New System.Drawing.Size(101, 35)
        Me.txtHasilMeter.TabIndex = 21
        Me.txtHasilMeter.Text = "3,000"
        Me.txtHasilMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHasilMeter.Value = 3000.0R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(273, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Pcs"
        '
        'frmPengeluaranBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHasilMeter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EpsDataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EpsTextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.EpsTextBox1)
        Me.Controls.Add(Me.EpsComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtKodeProduksi)
        Me.Controls.Add(Me.lblKodeProduksi)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1140, 611)
        Me.Name = "frmPengeluaranBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengeluaran Barang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHari As System.Windows.Forms.Label
    Friend WithEvents lblKodeProduksi As System.Windows.Forms.Label
    Friend WithEvents txtKodeProduksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents cboKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents EpsComboBox1 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EpsTextBox1 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EpsTextBox2 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EpsDataGridView1 As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pcs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timbang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHasilMeter As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
