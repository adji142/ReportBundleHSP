<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopyAspek
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
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.cboPosisi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBagian = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboKelompok = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPosisiKe = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBagianKe = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDept = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDeptKe = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnData.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 318)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(881, 54)
        Me.panel2.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(881, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(774, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(685, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
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
        Me.cboPosisi.Location = New System.Drawing.Point(116, 66)
        Me.cboPosisi.Name = "cboPosisi"
        Me.cboPosisi.Size = New System.Drawing.Size(342, 21)
        Me.cboPosisi.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 104
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
        Me.cboBagian.Items.AddRange(New Object() {"Supervisor", "Kepala Regu", "Operator", "Teknisi"})
        Me.cboBagian.Location = New System.Drawing.Point(116, 39)
        Me.cboBagian.Name = "cboBagian"
        Me.cboBagian.Size = New System.Drawing.Size(342, 21)
        Me.cboBagian.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Bagian"
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
        Me.cboKelompok.Location = New System.Drawing.Point(116, 94)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(342, 21)
        Me.cboKelompok.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Kelompok"
        '
        'pnData
        '
        Me.pnData.BackColor = System.Drawing.Color.Transparent
        Me.pnData.Controls.Add(Me.Grid)
        Me.pnData.Controls.Add(Me.Label12)
        Me.pnData.Location = New System.Drawing.Point(480, 12)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(389, 297)
        Me.pnData.TabIndex = 7
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
        Me.Grid.Location = New System.Drawing.Point(16, 47)
        Me.Grid.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(361, 229)
        Me.Grid.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.BlueViolet
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(361, 32)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "#Daftar Aspek"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPosisiKe
        '
        Me.cboPosisiKe.AllowEnterToMoveNext = True
        Me.cboPosisiKe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPosisiKe.BackColor = System.Drawing.Color.White
        Me.cboPosisiKe.DataLocked = False
        Me.cboPosisiKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPosisiKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosisiKe.IndexLocked = False
        Me.cboPosisiKe.Location = New System.Drawing.Point(116, 226)
        Me.cboPosisiKe.Name = "cboPosisiKe"
        Me.cboPosisiKe.Size = New System.Drawing.Size(342, 21)
        Me.cboPosisiKe.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Posisi"
        '
        'cboBagianKe
        '
        Me.cboBagianKe.AllowEnterToMoveNext = True
        Me.cboBagianKe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBagianKe.BackColor = System.Drawing.Color.White
        Me.cboBagianKe.DataLocked = False
        Me.cboBagianKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBagianKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBagianKe.IndexLocked = False
        Me.cboBagianKe.Items.AddRange(New Object() {"Supervisor", "Kepala Regu", "Operator", "Teknisi"})
        Me.cboBagianKe.Location = New System.Drawing.Point(116, 199)
        Me.cboBagianKe.Name = "cboBagianKe"
        Me.cboBagianKe.Size = New System.Drawing.Size(342, 21)
        Me.cboBagianKe.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Bagian"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Plum
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(443, 32)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Salin Ke :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.cboDept.Location = New System.Drawing.Point(116, 12)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(342, 21)
        Me.cboDept.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Departemen"
        '
        'cboDeptKe
        '
        Me.cboDeptKe.AllowEnterToMoveNext = True
        Me.cboDeptKe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeptKe.BackColor = System.Drawing.Color.White
        Me.cboDeptKe.DataLocked = False
        Me.cboDeptKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDeptKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptKe.IndexLocked = False
        Me.cboDeptKe.Items.AddRange(New Object() {"Supervisor", "Kepala Regu", "Operator", "Teknisi"})
        Me.cboDeptKe.Location = New System.Drawing.Point(116, 172)
        Me.cboDeptKe.Name = "cboDeptKe"
        Me.cboDeptKe.Size = New System.Drawing.Size(342, 21)
        Me.cboDeptKe.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Departemen"
        '
        'frmCopyAspek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 372)
        Me.Controls.Add(Me.cboDeptKe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboDept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboPosisiKe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboBagianKe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnData)
        Me.Controls.Add(Me.cboPosisi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboBagian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKelompok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Name = "frmCopyAspek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salin Aspek dari :"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnData.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents cboPosisi As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cboBagian As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboKelompok As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnData As System.Windows.Forms.Panel
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents cboPosisiKe As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cboBagianKe As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents cboDept As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboDeptKe As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
