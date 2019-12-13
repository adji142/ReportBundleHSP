<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotulen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotulen))
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.txtNoNotulen = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTopik = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdate = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdPeserta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblJamEnd = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblJamStart = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cboEnd = New System.Windows.Forms.Button()
        Me.cmdAddProblem = New System.Windows.Forms.Button()
        Me.cmdAddFU = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cboNotulen = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtperiode = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.tmrjam = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbostatus = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.JmlPeserta = New System.Windows.Forms.Label()
        Me.GridNotulen = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridNotulen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(209, 13)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 26
        Me.Locked.TabStop = False
        '
        'txtNoNotulen
        '
        Me.txtNoNotulen.AllowEnterToMoveNext = True
        Me.txtNoNotulen.BackColor = System.Drawing.Color.White
        Me.txtNoNotulen.Location = New System.Drawing.Point(101, 12)
        Me.txtNoNotulen.MaxLength = 6
        Me.txtNoNotulen.Name = "txtNoNotulen"
        Me.txtNoNotulen.ReadOnly = True
        Me.txtNoNotulen.Size = New System.Drawing.Size(102, 20)
        Me.txtNoNotulen.TabIndex = 24
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(8, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Nomor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Topik Meeting"
        '
        'cboTopik
        '
        Me.cboTopik.AllowEnterToMoveNext = True
        Me.cboTopik.DataLocked = False
        Me.cboTopik.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTopik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTopik.FormattingEnabled = True
        Me.cboTopik.IndexLocked = False
        Me.cboTopik.Location = New System.Drawing.Point(101, 42)
        Me.cboTopik.Name = "cboTopik"
        Me.cboTopik.Size = New System.Drawing.Size(129, 21)
        Me.cboTopik.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Periode Meeting"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.lblstatus)
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 623)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1281, 54)
        Me.panel2.TabIndex = 31
        '
        'lblstatus
        '
        Me.lblstatus.Location = New System.Drawing.Point(841, 15)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(237, 13)
        Me.lblstatus.TabIndex = 8
        Me.lblstatus.Text = "Ready"
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1281, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(1173, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(1084, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Tanggal"
        '
        'txtdate
        '
        Me.txtdate.AllowEnterToMoveNext = True
        Me.txtdate.CustomFormat = "dd/MM/yyyy"
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(326, 12)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(160, 20)
        Me.txtdate.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Notulen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Peserta Meeting"
        '
        'cmdPeserta
        '
        Me.cmdPeserta.Location = New System.Drawing.Point(326, 75)
        Me.cmdPeserta.Name = "cmdPeserta"
        Me.cmdPeserta.Size = New System.Drawing.Size(48, 23)
        Me.cmdPeserta.TabIndex = 8
        Me.cmdPeserta.Text = "Show"
        Me.cmdPeserta.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(552, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 104)
        Me.Panel1.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LblJamEnd)
        Me.Panel3.Location = New System.Drawing.Point(163, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(154, 65)
        Me.Panel3.TabIndex = 92
        '
        'LblJamEnd
        '
        Me.LblJamEnd.BackColor = System.Drawing.Color.Silver
        Me.LblJamEnd.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJamEnd.ForeColor = System.Drawing.Color.Red
        Me.LblJamEnd.Location = New System.Drawing.Point(-9, 8)
        Me.LblJamEnd.Name = "LblJamEnd"
        Me.LblJamEnd.Size = New System.Drawing.Size(171, 51)
        Me.LblJamEnd.TabIndex = 87
        Me.LblJamEnd.Text = "15:00:00"
        Me.LblJamEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(163, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 31)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "SELESAI"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 31)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "MULAI"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblJamStart)
        Me.Panel5.Location = New System.Drawing.Point(3, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(154, 65)
        Me.Panel5.TabIndex = 90
        '
        'lblJamStart
        '
        Me.lblJamStart.BackColor = System.Drawing.Color.Silver
        Me.lblJamStart.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamStart.ForeColor = System.Drawing.Color.Teal
        Me.lblJamStart.Location = New System.Drawing.Point(-8, 9)
        Me.lblJamStart.Name = "lblJamStart"
        Me.lblJamStart.Size = New System.Drawing.Size(170, 51)
        Me.lblJamStart.TabIndex = 87
        Me.lblJamStart.Text = "15:00:00"
        Me.lblJamStart.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(492, 11)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(54, 23)
        Me.cmdStart.TabIndex = 38
        Me.cmdStart.Text = "Mulai"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cboEnd
        '
        Me.cboEnd.Location = New System.Drawing.Point(492, 43)
        Me.cboEnd.Name = "cboEnd"
        Me.cboEnd.Size = New System.Drawing.Size(54, 23)
        Me.cboEnd.TabIndex = 39
        Me.cboEnd.Text = "Selesai"
        Me.cboEnd.UseVisualStyleBackColor = True
        '
        'cmdAddProblem
        '
        Me.cmdAddProblem.Location = New System.Drawing.Point(11, 125)
        Me.cmdAddProblem.Name = "cmdAddProblem"
        Me.cmdAddProblem.Size = New System.Drawing.Size(96, 23)
        Me.cmdAddProblem.TabIndex = 40
        Me.cmdAddProblem.Text = "Tambah Problem"
        Me.cmdAddProblem.UseVisualStyleBackColor = True
        '
        'cmdAddFU
        '
        Me.cmdAddFU.Location = New System.Drawing.Point(113, 125)
        Me.cmdAddFU.Name = "cmdAddFU"
        Me.cmdAddFU.Size = New System.Drawing.Size(104, 23)
        Me.cmdAddFU.TabIndex = 41
        Me.cmdAddFU.Text = "Tambah Follow Up"
        Me.cmdAddFU.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.Location = New System.Drawing.Point(283, 125)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(33, 23)
        Me.cmdUp.TabIndex = 42
        Me.cmdUp.Text = "Up"
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.Location = New System.Drawing.Point(322, 125)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(45, 23)
        Me.cmdDown.TabIndex = 43
        Me.cmdDown.Text = "Down"
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cboNotulen
        '
        Me.cboNotulen.AllowEnterToMoveNext = True
        Me.cboNotulen.DataLocked = False
        Me.cboNotulen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNotulen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNotulen.FormattingEnabled = True
        Me.cboNotulen.IndexLocked = False
        Me.cboNotulen.Location = New System.Drawing.Point(326, 43)
        Me.cboNotulen.Name = "cboNotulen"
        Me.cboNotulen.Size = New System.Drawing.Size(160, 21)
        Me.cboNotulen.TabIndex = 44
        '
        'txtperiode
        '
        Me.txtperiode.AllowEnterToMoveNext = True
        Me.txtperiode.Location = New System.Drawing.Point(100, 73)
        Me.txtperiode.Name = "txtperiode"
        Me.txtperiode.ReadOnly = True
        Me.txtperiode.Size = New System.Drawing.Size(103, 20)
        Me.txtperiode.TabIndex = 46
        '
        'tmrjam
        '
        Me.tmrjam.Enabled = True
        Me.tmrjam.Interval = 500
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbostatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(373, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 44)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cbostatus
        '
        Me.cbostatus.AllowEnterToMoveNext = True
        Me.cbostatus.DataLocked = False
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.IndexLocked = False
        Me.cbostatus.Items.AddRange(New Object() {"Done", "Open", "Pending", "Cancel", "-"})
        Me.cbostatus.Location = New System.Drawing.Point(53, 17)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(107, 21)
        Me.cbostatus.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Status"
        '
        'JmlPeserta
        '
        Me.JmlPeserta.AutoSize = True
        Me.JmlPeserta.Location = New System.Drawing.Point(380, 81)
        Me.JmlPeserta.Name = "JmlPeserta"
        Me.JmlPeserta.Size = New System.Drawing.Size(85, 13)
        Me.JmlPeserta.TabIndex = 48
        Me.JmlPeserta.Text = "Jumlah Peserta :"
        '
        'GridNotulen
        '
        Me.GridNotulen.AllowUserToAddRows = False
        Me.GridNotulen.AllowUserToDeleteRows = False
        Me.GridNotulen.AllowUserToResizeColumns = False
        Me.GridNotulen.AllowUserToResizeRows = False
        Me.GridNotulen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridNotulen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridNotulen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridNotulen.Location = New System.Drawing.Point(12, 154)
        Me.GridNotulen.Name = "GridNotulen"
        Me.GridNotulen.ReadOnly = True
        Me.GridNotulen.Size = New System.Drawing.Size(1257, 463)
        Me.GridNotulen.TabIndex = 4
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(223, 125)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(59, 23)
        Me.cmdDelete.TabIndex = 49
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(552, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(885, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hint"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(6, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Double Click = Edit Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(6, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "CTRL + D = Delete Data terpilih"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "CTRL + W = Add Follow UP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "CTRL + Q = Add Problem"
        '
        'FrmNotulen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.JmlPeserta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtperiode)
        Me.Controls.Add(Me.cboNotulen)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.cmdAddFU)
        Me.Controls.Add(Me.cmdAddProblem)
        Me.Controls.Add(Me.cboEnd)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdPeserta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTopik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNoNotulen)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GridNotulen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNotulen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notulen"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridNotulen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents txtNoNotulen As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTopik As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdate As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents cmdPeserta As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents cmdStart As System.Windows.Forms.Button
    Private WithEvents cboEnd As System.Windows.Forms.Button
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents lblJamStart As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents LblJamEnd As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents cmdAddProblem As System.Windows.Forms.Button
    Private WithEvents cmdAddFU As System.Windows.Forms.Button
    Private WithEvents cmdUp As System.Windows.Forms.Button
    Private WithEvents cmdDown As System.Windows.Forms.Button
    Friend WithEvents cboNotulen As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtperiode As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents tmrjam As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbostatus As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents JmlPeserta As System.Windows.Forms.Label
    Friend WithEvents GridNotulen As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
