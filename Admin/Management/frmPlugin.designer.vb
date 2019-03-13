<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlugin
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
        Me.txtPluginID = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtFileName = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeyword = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btTest = New System.Windows.Forms.Button()
        Me.lstPluginKeywordList = New System.Windows.Forms.ListBox()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(342, 10)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 23)
        Me.btClose.TabIndex = 9
        Me.btClose.Text = "E&xit"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(253, 10)
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
        Me.txtDescription.Location = New System.Drawing.Point(131, 47)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(294, 20)
        Me.txtDescription.TabIndex = 1
        '
        'txtPluginID
        '
        Me.txtPluginID.AllowEnterToMoveNext = True
        Me.txtPluginID.BackColor = System.Drawing.Color.White
        Me.txtPluginID.Location = New System.Drawing.Point(131, 22)
        Me.txtPluginID.MaxLength = 6
        Me.txtPluginID.Name = "txtPluginID"
        Me.txtPluginID.Size = New System.Drawing.Size(294, 20)
        Me.txtPluginID.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(92, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Plugin Description"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label1.Location = New System.Drawing.Point(22, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(59, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Plugin ID"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.btClose)
        Me.panel2.Controls.Add(Me.btSave)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 233)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(446, 54)
        Me.panel2.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(446, 4)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'txtFileName
        '
        Me.txtFileName.AllowEnterToMoveNext = True
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.BackColor = System.Drawing.Color.White
        Me.txtFileName.Location = New System.Drawing.Point(131, 71)
        Me.txtFileName.MaxLength = 50
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(294, 20)
        Me.txtFileName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "File Name"
        '
        'txtKeyword
        '
        Me.txtKeyword.AllowEnterToMoveNext = True
        Me.txtKeyword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyword.BackColor = System.Drawing.Color.White
        Me.txtKeyword.Location = New System.Drawing.Point(131, 198)
        Me.txtKeyword.MaxLength = 50
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(294, 20)
        Me.txtKeyword.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Keyword"
        '
        'btTest
        '
        Me.btTest.Location = New System.Drawing.Point(87, 97)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(38, 25)
        Me.btTest.TabIndex = 3
        Me.btTest.TabStop = False
        Me.btTest.Text = "Test"
        Me.btTest.UseVisualStyleBackColor = True
        '
        'lstPluginKeywordList
        '
        Me.lstPluginKeywordList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPluginKeywordList.FormattingEnabled = True
        Me.lstPluginKeywordList.Location = New System.Drawing.Point(131, 97)
        Me.lstPluginKeywordList.Name = "lstPluginKeywordList"
        Me.lstPluginKeywordList.Size = New System.Drawing.Size(294, 95)
        Me.lstPluginKeywordList.TabIndex = 4
        '
        'frmPlugin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(446, 287)
        Me.Controls.Add(Me.btTest)
        Me.Controls.Add(Me.lstPluginKeywordList)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPluginID)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(462, 326)
        Me.Name = "frmPlugin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plugin"
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btClose As System.Windows.Forms.Button
    Private WithEvents btSave As System.Windows.Forms.Button
    Private WithEvents txtDescription As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents txtPluginID As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents txtFileName As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtKeyword As Enerzie.EPSBasicControls.EPSTextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btTest As System.Windows.Forms.Button
    Friend WithEvents lstPluginKeywordList As System.Windows.Forms.ListBox
End Class
