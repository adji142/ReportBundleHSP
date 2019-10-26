<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFollowUp
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStartdate = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.txtEndDate = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtFollowup = New System.Windows.Forms.RichTextBox()
        Me.GridUser = New Enerzie.EPSGridControls.EPSTableEdit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(12, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(361, 27)
        Me.Label19.TabIndex = 169
        Me.Label19.Text = "FOLLOW UP"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Follow Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Tgl Mulai"
        '
        'txtStartdate
        '
        Me.txtStartdate.AllowEnterToMoveNext = True
        Me.txtStartdate.CustomFormat = "dd/MM/yyyy"
        Me.txtStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtStartdate.Location = New System.Drawing.Point(72, 148)
        Me.txtStartdate.Name = "txtStartdate"
        Me.txtStartdate.Size = New System.Drawing.Size(106, 20)
        Me.txtStartdate.TabIndex = 2
        '
        'txtEndDate
        '
        Me.txtEndDate.AllowEnterToMoveNext = True
        Me.txtEndDate.CustomFormat = "dd/MM/yyyy"
        Me.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtEndDate.Location = New System.Drawing.Point(72, 174)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(106, 20)
        Me.txtEndDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Tgl Selesai"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 27)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "PIC"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 371)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(385, 54)
        Me.panel2.TabIndex = 178
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(385, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(277, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 6
        Me.btClose.Text = "K&eluar"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(188, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtFollowup
        '
        Me.txtFollowup.Location = New System.Drawing.Point(72, 47)
        Me.txtFollowup.Name = "txtFollowup"
        Me.txtFollowup.Size = New System.Drawing.Size(301, 96)
        Me.txtFollowup.TabIndex = 1
        Me.txtFollowup.Text = ""
        '
        'GridUser
        '
        Me.GridUser.AllowDeleteRow = False
        Me.GridUser.AllowInsertRow = False
        Me.GridUser.AlternatingCellFocusBackColor = System.Drawing.Color.PowderBlue
        Me.GridUser.AlternatingCellFocusForeColor = System.Drawing.Color.Black
        Me.GridUser.AlternatingDataGridBackColor = System.Drawing.Color.White
        Me.GridUser.AlternatingDataGridForeColor = System.Drawing.Color.Empty
        Me.GridUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridUser.CellFocusBackColor = System.Drawing.Color.LightBlue
        Me.GridUser.CellFocusForeColor = System.Drawing.Color.Black
        Me.GridUser.DataGridBackColor = System.Drawing.Color.Empty
        Me.GridUser.DataGridForeColor = System.Drawing.Color.Empty
        Me.GridUser.GridColor = System.Drawing.Color.Gainsboro
        Me.GridUser.HeaderBackColor = System.Drawing.Color.WhiteSmoke
        Me.GridUser.HeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.GridUser.Location = New System.Drawing.Point(12, 227)
        Me.GridUser.LookupButtonBackColor = System.Drawing.SystemColors.Control
        Me.GridUser.Name = "GridUser"
        Me.GridUser.RowHeaderBackColor = System.Drawing.Color.White
        Me.GridUser.RowHeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.GridUser.SingleRowMode = False
        Me.GridUser.Size = New System.Drawing.Size(361, 138)
        Me.GridUser.TabIndex = 4
        '
        'frmFollowUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 425)
        Me.Controls.Add(Me.GridUser)
        Me.Controls.Add(Me.txtFollowup)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtStartdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFollowUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notulen"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStartdate As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents txtEndDate As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtFollowup As System.Windows.Forms.RichTextBox
    Friend WithEvents GridUser As Enerzie.EPSGridControls.EPSTableEdit
End Class
