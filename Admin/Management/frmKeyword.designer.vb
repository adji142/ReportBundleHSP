<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyword
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
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtDescription = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.txtKeyword = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboPluginID = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.lblKodeRekeningInduk = New System.Windows.Forms.Label()
        Me.cboPluginKeywordID = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(386, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 9
        Me.btClose.Text = "E&xit"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(297, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(83, 23)
        Me.btSave.TabIndex = 8
        Me.btSave.Text = "[F6] &Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.AllowEnterToMoveNext = True
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(131, 90)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(338, 20)
        Me.txtDescription.TabIndex = 2
        '
        'txtKeyword
        '
        Me.txtKeyword.AllowEnterToMoveNext = True
        Me.txtKeyword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyword.BackColor = System.Drawing.Color.White
        Me.txtKeyword.Location = New System.Drawing.Point(131, 64)
        Me.txtKeyword.MaxLength = 50
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(338, 20)
        Me.txtKeyword.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Description"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Keyword"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 185)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(490, 54)
        Me.panel2.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(490, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(-300, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 10)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'cboPluginID
        '
        Me.cboPluginID.AllowEnterToMoveNext = True
        Me.cboPluginID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPluginID.BackColor = System.Drawing.Color.White
        Me.cboPluginID.DataLocked = False
        Me.cboPluginID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPluginID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPluginID.FormattingEnabled = True
        Me.cboPluginID.IndexLocked = False
        Me.cboPluginID.Location = New System.Drawing.Point(131, 15)
        Me.cboPluginID.Name = "cboPluginID"
        Me.cboPluginID.Size = New System.Drawing.Size(338, 21)
        Me.cboPluginID.TabIndex = 0
        '
        'lblKodeRekeningInduk
        '
        Me.lblKodeRekeningInduk.AutoSize = True
        Me.lblKodeRekeningInduk.ForeColor = System.Drawing.Color.Black
        Me.lblKodeRekeningInduk.Location = New System.Drawing.Point(22, 18)
        Me.lblKodeRekeningInduk.Name = "lblKodeRekeningInduk"
        Me.lblKodeRekeningInduk.Size = New System.Drawing.Size(36, 13)
        Me.lblKodeRekeningInduk.TabIndex = 20
        Me.lblKodeRekeningInduk.Text = "Plugin"
        '
        'cboPluginKeywordID
        '
        Me.cboPluginKeywordID.AllowEnterToMoveNext = True
        Me.cboPluginKeywordID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPluginKeywordID.BackColor = System.Drawing.Color.White
        Me.cboPluginKeywordID.DataLocked = False
        Me.cboPluginKeywordID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPluginKeywordID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPluginKeywordID.FormattingEnabled = True
        Me.cboPluginKeywordID.IndexLocked = False
        Me.cboPluginKeywordID.Location = New System.Drawing.Point(131, 116)
        Me.cboPluginKeywordID.Name = "cboPluginKeywordID"
        Me.cboPluginKeywordID.Size = New System.Drawing.Size(338, 21)
        Me.cboPluginKeywordID.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Module"
        '
        'frmKeyword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(490, 239)
        Me.Controls.Add(Me.cboPluginKeywordID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboPluginID)
        Me.Controls.Add(Me.lblKodeRekeningInduk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(506, 278)
        Me.Name = "frmKeyword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keyword"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtDescription As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtKeyword As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cboPluginID As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents lblKodeRekeningInduk As System.Windows.Forms.Label
    Private WithEvents cboPluginKeywordID As Enerzie.EPSBasicControls.EPSComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
