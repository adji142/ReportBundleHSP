<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAspek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAspek))
        Me.txtNamaAspek = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKodeAspek = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Locked = New System.Windows.Forms.PictureBox()
        Me.cboBagian = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPosisi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblBarisData = New System.Windows.Forms.Label()
        Me.txtBobot = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.chkTipe = New Enerzie.EPSBasicControls.EPSCheckBox()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.cboDept = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboJenis = New Enerzie.EPSBasicControls.EPSComboBox()
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnData.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNamaAspek
        '
        Me.txtNamaAspek.AllowEnterToMoveNext = True
        Me.txtNamaAspek.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaAspek.BackColor = System.Drawing.Color.White
        Me.txtNamaAspek.Location = New System.Drawing.Point(123, 47)
        Me.txtNamaAspek.MaxLength = 100
        Me.txtNamaAspek.Name = "txtNamaAspek"
        Me.txtNamaAspek.Size = New System.Drawing.Size(320, 20)
        Me.txtNamaAspek.TabIndex = 1
        '
        'txtKodeAspek
        '
        Me.txtKodeAspek.AllowEnterToMoveNext = True
        Me.txtKodeAspek.BackColor = System.Drawing.Color.White
        Me.txtKodeAspek.Location = New System.Drawing.Point(123, 22)
        Me.txtKodeAspek.MaxLength = 5
        Me.txtKodeAspek.Name = "txtKodeAspek"
        Me.txtKodeAspek.Size = New System.Drawing.Size(77, 20)
        Me.txtKodeAspek.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(68, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Nama Aspek"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Kode Aspek"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Kelompok"
        '
        'cboKelompok
        '
        Me.cboKelompok.AllowEnterToMoveNext = True
        Me.cboKelompok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKelompok.BackColor = System.Drawing.Color.White
        Me.cboKelompok.DataLocked = False
        Me.cboKelompok.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKelompok.IndexLocked = False
        Me.cboKelompok.Location = New System.Drawing.Point(123, 155)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(319, 21)
        Me.cboKelompok.TabIndex = 5
        '
        'Locked
        '
        Me.Locked.Image = CType(resources.GetObject("Locked.Image"), System.Drawing.Image)
        Me.Locked.Location = New System.Drawing.Point(206, 23)
        Me.Locked.Name = "Locked"
        Me.Locked.Size = New System.Drawing.Size(21, 19)
        Me.Locked.TabIndex = 23
        Me.Locked.TabStop = False
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
        Me.cboBagian.Items.AddRange(New Object() {"Supervisor", "Kepala Regu", "Operator", "Teknisi"})
        Me.cboBagian.Location = New System.Drawing.Point(123, 100)
        Me.cboBagian.Name = "cboBagian"
        Me.cboBagian.Size = New System.Drawing.Size(319, 21)
        Me.cboBagian.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Bagian"
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
        Me.cboPosisi.Location = New System.Drawing.Point(123, 127)
        Me.cboPosisi.Name = "cboPosisi"
        Me.cboPosisi.Size = New System.Drawing.Size(319, 21)
        Me.cboPosisi.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Posisi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Bobot"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Location = New System.Drawing.Point(123, 235)
        Me.txtKeterangan.MaxLength = 50
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(190, 20)
        Me.txtKeterangan.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Keterangan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Target"
        '
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.Color.Transparent
        Me.pnData.Controls.Add(Me.Grid)
        Me.pnData.Controls.Add(Me.Label12)
        Me.pnData.Location = New System.Drawing.Point(449, 12)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(346, 270)
        Me.pnData.TabIndex = 11
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
        Me.Grid.Location = New System.Drawing.Point(14, 47)
        Me.Grid.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(315, 220)
        Me.Grid.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.BlueViolet
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(14, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(315, 32)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "#Norma Penilaian"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(611, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(700, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(807, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 296)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(807, 54)
        Me.panel2.TabIndex = 12
        '
        'lblBarisData
        '
        Me.lblBarisData.AutoSize = True
        Me.lblBarisData.Location = New System.Drawing.Point(330, 238)
        Me.lblBarisData.Name = "lblBarisData"
        Me.lblBarisData.Size = New System.Drawing.Size(62, 13)
        Me.lblBarisData.TabIndex = 112
        Me.lblBarisData.Text = "Keterangan"
        '
        'txtBobot
        '
        Me.txtBobot.AllowEnterToMoveNext = True
        Me.txtBobot.CheckIsValid = False
        Me.txtBobot.DataFormat = "###,##0.00"
        Me.txtBobot.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBobot.Location = New System.Drawing.Point(123, 184)
        Me.txtBobot.Name = "txtBobot"
        Me.txtBobot.Size = New System.Drawing.Size(190, 20)
        Me.txtBobot.TabIndex = 6
        Me.txtBobot.Text = "0.00"
        Me.txtBobot.Value = 0.0R
        '
        'chkTipe
        '
        Me.chkTipe.AllowEnterToMoveNext = True
        Me.chkTipe.AutoSize = True
        Me.chkTipe.Location = New System.Drawing.Point(340, 187)
        Me.chkTipe.Name = "chkTipe"
        Me.chkTipe.Size = New System.Drawing.Size(103, 17)
        Me.chkTipe.TabIndex = 7
        Me.chkTipe.Text = "Parameter Huruf"
        Me.chkTipe.UseVisualStyleBackColor = True
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(123, 210)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(190, 20)
        Me.txtTarget.TabIndex = 8
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
        Me.cboDept.Items.AddRange(New Object() {"Supervisor", "Kepala Regu", "Operator", "Teknisi"})
        Me.cboDept.Location = New System.Drawing.Point(124, 73)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(319, 21)
        Me.cboDept.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Departemen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Pengambilan Data"
        '
        'cboJenis
        '
        Me.cboJenis.AllowEnterToMoveNext = True
        Me.cboJenis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboJenis.BackColor = System.Drawing.Color.White
        Me.cboJenis.DataLocked = False
        Me.cboJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenis.IndexLocked = False
        Me.cboJenis.Location = New System.Drawing.Point(123, 261)
        Me.cboJenis.Name = "cboJenis"
        Me.cboJenis.Size = New System.Drawing.Size(190, 21)
        Me.cboJenis.TabIndex = 10
        '
        'frmAspek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(807, 350)
        Me.Controls.Add(Me.cboJenis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboDept)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.chkTipe)
        Me.Controls.Add(Me.txtBobot)
        Me.Controls.Add(Me.lblBarisData)
        Me.Controls.Add(Me.pnData)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPosisi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboBagian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKelompok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Locked)
        Me.Controls.Add(Me.txtNamaAspek)
        Me.Controls.Add(Me.txtKodeAspek)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 205)
        Me.Name = "frmAspek"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aspek"
        CType(Me.Locked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnData.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtNamaAspek As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKodeAspek As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Locked As System.Windows.Forms.PictureBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents cboBagian As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboPosisi As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents lblBarisData As System.Windows.Forms.Label
    Friend WithEvents txtBobot As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents chkTipe As Enerzie.EPSBasicControls.EPSCheckBox
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Private WithEvents cboDept As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents cboJenis As Enerzie.EPSBasicControls.EPSComboBox
End Class
