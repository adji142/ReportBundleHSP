<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLINQ
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpsDataGridView1 = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EpsTextBox1 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.EpsTextBox2 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.EpsTextBox3 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.EpsComboBox1 = New Enerzie.EPSBasicControls.EPSComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTanggal = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EpsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UnitToolStripMenuItem
        '
        Me.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem"
        Me.UnitToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.UnitToolStripMenuItem.Text = "Unit"
        '
        'EpsDataGridView1
        '
        Me.EpsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EpsDataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.EpsDataGridView1.Name = "EpsDataGridView1"
        Me.EpsDataGridView1.Size = New System.Drawing.Size(619, 213)
        Me.EpsDataGridView1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(377, 277)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'EpsTextBox1
        '
        Me.EpsTextBox1.AllowEnterToMoveNext = True
        Me.EpsTextBox1.Location = New System.Drawing.Point(12, 277)
        Me.EpsTextBox1.Name = "EpsTextBox1"
        Me.EpsTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EpsTextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(377, 303)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(377, 329)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'EpsTextBox2
        '
        Me.EpsTextBox2.AllowEnterToMoveNext = True
        Me.EpsTextBox2.Location = New System.Drawing.Point(12, 303)
        Me.EpsTextBox2.Name = "EpsTextBox2"
        Me.EpsTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.EpsTextBox2.TabIndex = 1
        '
        'EpsTextBox3
        '
        Me.EpsTextBox3.AllowEnterToMoveNext = True
        Me.EpsTextBox3.Location = New System.Drawing.Point(12, 329)
        Me.EpsTextBox3.Name = "EpsTextBox3"
        Me.EpsTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.EpsTextBox3.TabIndex = 2
        '
        'EpsComboBox1
        '
        Me.EpsComboBox1.AllowEnterToMoveNext = True
        Me.EpsComboBox1.DataLocked = False
        Me.EpsComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EpsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EpsComboBox1.FormattingEnabled = True
        Me.EpsComboBox1.IndexLocked = False
        Me.EpsComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.EpsComboBox1.Location = New System.Drawing.Point(13, 356)
        Me.EpsComboBox1.Name = "EpsComboBox1"
        Me.EpsComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.EpsComboBox1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(377, 356)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'txtTanggal
        '
        Me.txtTanggal.AllowEnterToMoveNext = True
        Me.txtTanggal.CustomFormat = "dd/MM/yyyy"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(171, 255)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(200, 20)
        Me.txtTanggal.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(540, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(540, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmLINQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 451)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.EpsComboBox1)
        Me.Controls.Add(Me.EpsTextBox3)
        Me.Controls.Add(Me.EpsTextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.EpsTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.EpsDataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLINQ"
        Me.Text = "frmLINQ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EpsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EpsDataGridView1 As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EpsTextBox1 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents EpsTextBox2 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents EpsTextBox3 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents EpsComboBox1 As Enerzie.EPSBasicControls.EPSComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTanggal As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
