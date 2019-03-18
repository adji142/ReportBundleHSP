<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOJT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOJT))
        Me.pnHeader = New System.Windows.Forms.Panel()
        Me.cboTahun = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.cboBulan = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDept = New System.Windows.Forms.Button()
        Me.cboDept = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPosisi = New System.Windows.Forms.Button()
        Me.btnBagian = New System.Windows.Forms.Button()
        Me.btnLookupKaryawan = New System.Windows.Forms.Button()
        Me.txtNamaKaryawan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.btProses = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKodeKaryawan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.cboPosisi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBagian = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.txtNoTransaksi = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblBarisData = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GridOJT = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnHeader.SuspendLayout()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnData.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.cboTahun)
        Me.pnHeader.Controls.Add(Me.cboBulan)
        Me.pnHeader.Controls.Add(Me.Label6)
        Me.pnHeader.Controls.Add(Me.btnDept)
        Me.pnHeader.Controls.Add(Me.cboDept)
        Me.pnHeader.Controls.Add(Me.Label3)
        Me.pnHeader.Controls.Add(Me.btnPosisi)
        Me.pnHeader.Controls.Add(Me.btnBagian)
        Me.pnHeader.Controls.Add(Me.btnLookupKaryawan)
        Me.pnHeader.Controls.Add(Me.txtNamaKaryawan)
        Me.pnHeader.Controls.Add(Me.btProses)
        Me.pnHeader.Controls.Add(Me.Label10)
        Me.pnHeader.Controls.Add(Me.txtKodeKaryawan)
        Me.pnHeader.Controls.Add(Me.cboPosisi)
        Me.pnHeader.Controls.Add(Me.Label5)
        Me.pnHeader.Controls.Add(Me.cboBagian)
        Me.pnHeader.Controls.Add(Me.Label4)
        Me.pnHeader.Controls.Add(Me.Locked)
        Me.pnHeader.Controls.Add(Me.txtNoTransaksi)
        Me.pnHeader.Controls.Add(Me.Label2)
        Me.pnHeader.Location = New System.Drawing.Point(6, 3)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1012, 167)
        Me.pnHeader.TabIndex = 0
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
        Me.cboTahun.Location = New System.Drawing.Point(219, 39)
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
        Me.cboBulan.Location = New System.Drawing.Point(118, 39)
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(95, 21)
        Me.cboBulan.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Periode"
        '
        'btnDept
        '
        Me.btnDept.Location = New System.Drawing.Point(473, 64)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(25, 23)
        Me.btnDept.TabIndex = 4
        Me.btnDept.TabStop = False
        Me.btnDept.Text = "..."
        Me.btnDept.UseVisualStyleBackColor = True
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
        Me.cboDept.Location = New System.Drawing.Point(118, 66)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(349, 21)
        Me.cboDept.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Departemen"
        '
        'btnPosisi
        '
        Me.btnPosisi.Location = New System.Drawing.Point(473, 118)
        Me.btnPosisi.Name = "btnPosisi"
        Me.btnPosisi.Size = New System.Drawing.Size(25, 23)
        Me.btnPosisi.TabIndex = 8
        Me.btnPosisi.TabStop = False
        Me.btnPosisi.Text = "..."
        Me.btnPosisi.UseVisualStyleBackColor = True
        '
        'btnBagian
        '
        Me.btnBagian.Location = New System.Drawing.Point(473, 91)
        Me.btnBagian.Name = "btnBagian"
        Me.btnBagian.Size = New System.Drawing.Size(25, 23)
        Me.btnBagian.TabIndex = 6
        Me.btnBagian.TabStop = False
        Me.btnBagian.Text = "..."
        Me.btnBagian.UseVisualStyleBackColor = True
        '
        'btnLookupKaryawan
        '
        Me.btnLookupKaryawan.Location = New System.Drawing.Point(675, 12)
        Me.btnLookupKaryawan.Name = "btnLookupKaryawan"
        Me.btnLookupKaryawan.Size = New System.Drawing.Size(25, 23)
        Me.btnLookupKaryawan.TabIndex = 10
        Me.btnLookupKaryawan.TabStop = False
        Me.btnLookupKaryawan.Text = "..."
        Me.btnLookupKaryawan.UseVisualStyleBackColor = True
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.AllowEnterToMoveNext = True
        Me.txtNamaKaryawan.BackColor = System.Drawing.Color.White
        Me.txtNamaKaryawan.Enabled = False
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(571, 40)
        Me.txtNamaKaryawan.MaxLength = 3
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(329, 20)
        Me.txtNamaKaryawan.TabIndex = 11
        '
        'btProses
        '
        Me.btProses.Location = New System.Drawing.Point(571, 69)
        Me.btProses.Name = "btProses"
        Me.btProses.Size = New System.Drawing.Size(95, 23)
        Me.btProses.TabIndex = 12
        Me.btProses.Text = "Proses"
        Me.btProses.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(497, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Karyawan"
        '
        'txtKodeKaryawan
        '
        Me.txtKodeKaryawan.AllowEnterToMoveNext = True
        Me.txtKodeKaryawan.BackColor = System.Drawing.Color.White
        Me.txtKodeKaryawan.Enabled = False
        Me.txtKodeKaryawan.Location = New System.Drawing.Point(571, 14)
        Me.txtKodeKaryawan.MaxLength = 3
        Me.txtKodeKaryawan.Name = "txtKodeKaryawan"
        Me.txtKodeKaryawan.Size = New System.Drawing.Size(95, 20)
        Me.txtKodeKaryawan.TabIndex = 9
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
        Me.cboPosisi.Location = New System.Drawing.Point(118, 120)
        Me.cboPosisi.Name = "cboPosisi"
        Me.cboPosisi.Size = New System.Drawing.Size(349, 21)
        Me.cboPosisi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Posisi"
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
        Me.cboBagian.Location = New System.Drawing.Point(118, 93)
        Me.cboBagian.Name = "cboBagian"
        Me.cboBagian.Size = New System.Drawing.Size(349, 21)
        Me.cboBagian.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Bagian"
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
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "No Transaksi"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.lblBarisData)
        Me.Panel6.Controls.Add(Me.btCancel)
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 488)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1030, 54)
        Me.Panel6.TabIndex = 1
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
        'btCancel
        '
        Me.btCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancel.Location = New System.Drawing.Point(837, 10)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(83, 23)
        Me.btCancel.TabIndex = 1
        Me.btCancel.Text = "&Batal"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1030, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(748, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(926, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
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
        Me.Grid.Location = New System.Drawing.Point(688, 47)
        Me.Grid.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(315, 243)
        Me.Grid.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Orchid
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(688, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(315, 32)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "#Norma Penilaian"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridOJT
        '
        Me.GridOJT.AllowDeleteRow = False
        Me.GridOJT.AllowInsertRow = False
        Me.GridOJT.AlternatingCellFocusBackColor = System.Drawing.Color.PowderBlue
        Me.GridOJT.AlternatingCellFocusForeColor = System.Drawing.Color.Black
        Me.GridOJT.AlternatingDataGridBackColor = System.Drawing.Color.White
        Me.GridOJT.AlternatingDataGridForeColor = System.Drawing.Color.Empty
        Me.GridOJT.CellFocusBackColor = System.Drawing.Color.LightBlue
        Me.GridOJT.CellFocusForeColor = System.Drawing.Color.Black
        Me.GridOJT.DataGridBackColor = System.Drawing.Color.Empty
        Me.GridOJT.DataGridForeColor = System.Drawing.Color.Empty
        Me.GridOJT.GridColor = System.Drawing.Color.Gainsboro
        Me.GridOJT.HeaderBackColor = System.Drawing.Color.WhiteSmoke
        Me.GridOJT.HeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.GridOJT.Location = New System.Drawing.Point(8, 47)
        Me.GridOJT.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.GridOJT.Name = "GridOJT"
        Me.GridOJT.RowHeaderBackColor = System.Drawing.Color.White
        Me.GridOJT.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.GridOJT.SingleRowMode = False
        Me.GridOJT.Size = New System.Drawing.Size(673, 243)
        Me.GridOJT.TabIndex = 1
        '
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.Color.Transparent
        Me.pnData.Controls.Add(Me.Grid)
        Me.pnData.Controls.Add(Me.Label12)
        Me.pnData.Controls.Add(Me.GridOJT)
        Me.pnData.Controls.Add(Me.Label8)
        Me.pnData.Location = New System.Drawing.Point(6, 176)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(1012, 306)
        Me.pnData.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.BlueViolet
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(674, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "#Rincian Hasil Penilaian"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOJT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 542)
        Me.Controls.Add(Me.pnHeader)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pnData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOJT"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "On The Job Training ( OJT )"
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents btnPosisi As System.Windows.Forms.Button
    Friend WithEvents btnBagian As System.Windows.Forms.Button
    Friend WithEvents btnLookupKaryawan As System.Windows.Forms.Button
    Private WithEvents txtNamaKaryawan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents btProses As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents txtKodeKaryawan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents cboPosisi As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cboBagian As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents txtNoTransaksi As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents lblBarisData As System.Windows.Forms.Label
    Private WithEvents btCancel As System.Windows.Forms.Button
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GridOJT As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Private WithEvents cboDept As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboTahun As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents cboBulan As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
