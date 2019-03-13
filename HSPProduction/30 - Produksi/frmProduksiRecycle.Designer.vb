<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduksiRecycle
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTglTransaksi = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKodeShift = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboKodeGrup = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKodeLokasi = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.txtKeterangan = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Grid = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.lblBarisData = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.tmrJam = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl Transaksi"
        '
        'txtTglTransaksi
        '
        Me.txtTglTransaksi.AllowEnterToMoveNext = True
        Me.txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        Me.txtTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTglTransaksi.Location = New System.Drawing.Point(106, 25)
        Me.txtTglTransaksi.Name = "txtTglTransaksi"
        Me.txtTglTransaksi.Size = New System.Drawing.Size(95, 20)
        Me.txtTglTransaksi.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtKodeShift)
        Me.Panel2.Location = New System.Drawing.Point(748, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 46)
        Me.Panel2.TabIndex = 134
        '
        'txtKodeShift
        '
        Me.txtKodeShift.Font = New System.Drawing.Font("Arial Black", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeShift.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtKodeShift.Location = New System.Drawing.Point(7, -16)
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
        Me.lblShift.Location = New System.Drawing.Point(748, 24)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(82, 23)
        Me.lblShift.TabIndex = 133
        Me.lblShift.Text = " SHIFT"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(517, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Grup Produksi"
        '
        'cboKodeGrup
        '
        Me.cboKodeGrup.AllowEnterToMoveNext = True
        Me.cboKodeGrup.DataLocked = False
        Me.cboKodeGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeGrup.FormattingEnabled = True
        Me.cboKodeGrup.IndexLocked = False
        Me.cboKodeGrup.Location = New System.Drawing.Point(602, 24)
        Me.cboKodeGrup.Name = "cboKodeGrup"
        Me.cboKodeGrup.Size = New System.Drawing.Size(114, 21)
        Me.cboKodeGrup.TabIndex = 127
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(718, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 131
        Me.Button2.TabStop = False
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Lokasi"
        '
        'cboKodeLokasi
        '
        Me.cboKodeLokasi.AllowEnterToMoveNext = True
        Me.cboKodeLokasi.DataLocked = False
        Me.cboKodeLokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKodeLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboKodeLokasi.FormattingEnabled = True
        Me.cboKodeLokasi.IndexLocked = True
        Me.cboKodeLokasi.Location = New System.Drawing.Point(106, 50)
        Me.cboKodeLokasi.Name = "cboKodeLokasi"
        Me.cboKodeLokasi.Size = New System.Drawing.Size(637, 21)
        Me.cboKodeLokasi.TabIndex = 135
        Me.cboKodeLokasi.TabStop = False
        '
        'txtKeterangan
        '
        Me.txtKeterangan.AllowEnterToMoveNext = True
        Me.txtKeterangan.Location = New System.Drawing.Point(106, 76)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(637, 20)
        Me.txtKeterangan.TabIndex = 137
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Keterangan"
        '
        'Grid
        '
        Me.Grid.AllowDeleteRow = True
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
        Me.Grid.Location = New System.Drawing.Point(21, 120)
        Me.Grid.LookupButtonBackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaderBackColor = System.Drawing.Color.White
        Me.Grid.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.Grid.SingleRowMode = False
        Me.Grid.Size = New System.Drawing.Size(809, 206)
        Me.Grid.TabIndex = 140
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.AllowEnterToMoveNext = True
        Me.txtTotal.CheckIsValid = False
        Me.txtTotal.DataFormat = "###,##0.00"
        Me.txtTotal.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtTotal.Location = New System.Drawing.Point(477, 329)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(79, 20)
        Me.txtTotal.TabIndex = 142
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.Value = 0.0R
        '
        'lblBarisData
        '
        Me.lblBarisData.AutoSize = True
        Me.lblBarisData.Location = New System.Drawing.Point(18, 329)
        Me.lblBarisData.Name = "lblBarisData"
        Me.lblBarisData.Size = New System.Drawing.Size(27, 13)
        Me.lblBarisData.TabIndex = 143
        Me.lblBarisData.Text = "Item"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel6.Controls.Add(Me.pictureBox2)
        Me.Panel6.Controls.Add(Me.btSave)
        Me.Panel6.Controls.Add(Me.btClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 375)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(851, 54)
        Me.Panel6.TabIndex = 144
        '
        'pictureBox2
        '
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(851, 4)
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(658, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 0
        Me.btSave.Text = "[F6] &Proses"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(747, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'tmrJam
        '
        Me.tmrJam.Enabled = True
        '
        'frmProduksiRecycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 429)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.lblBarisData)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboKodeLokasi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboKodeGrup)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtTglTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProduksiRecycle"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi Recycle"
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTglTransaksi As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeShift As System.Windows.Forms.Label
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboKodeGrup As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboKodeLokasi As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents txtKeterangan As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Grid As Enerzie.EPSGridControls.EPSTableEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents lblBarisData As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
End Class
