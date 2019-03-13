<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestKartuStock
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
        Me.EpsDateTime1 = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.EpsDateTime2 = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.EpsTextBox1 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.EpsTextBox2 = New Enerzie.EPSBasicControls.EPSTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EpsDateTime1
        '
        Me.EpsDateTime1.AllowEnterToMoveNext = True
        Me.EpsDateTime1.CustomFormat = "dd/MM/yyyy"
        Me.EpsDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EpsDateTime1.Location = New System.Drawing.Point(0, 0)
        Me.EpsDateTime1.Name = "EpsDateTime1"
        Me.EpsDateTime1.Size = New System.Drawing.Size(200, 20)
        Me.EpsDateTime1.TabIndex = 0
        '
        'EpsDateTime2
        '
        Me.EpsDateTime2.AllowEnterToMoveNext = True
        Me.EpsDateTime2.CustomFormat = "dd/MM/yyyy"
        Me.EpsDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EpsDateTime2.Location = New System.Drawing.Point(206, 0)
        Me.EpsDateTime2.Name = "EpsDateTime2"
        Me.EpsDateTime2.Size = New System.Drawing.Size(200, 20)
        Me.EpsDateTime2.TabIndex = 1
        '
        'EpsTextBox1
        '
        Me.EpsTextBox1.AllowEnterToMoveNext = True
        Me.EpsTextBox1.Location = New System.Drawing.Point(412, 0)
        Me.EpsTextBox1.Name = "EpsTextBox1"
        Me.EpsTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EpsTextBox1.TabIndex = 2
        '
        'EpsTextBox2
        '
        Me.EpsTextBox2.AllowEnterToMoveNext = True
        Me.EpsTextBox2.Location = New System.Drawing.Point(518, 0)
        Me.EpsTextBox2.Name = "EpsTextBox2"
        Me.EpsTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.EpsTextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TestKartuStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EpsTextBox2)
        Me.Controls.Add(Me.EpsTextBox1)
        Me.Controls.Add(Me.EpsDateTime2)
        Me.Controls.Add(Me.EpsDateTime1)
        Me.Name = "TestKartuStock"
        Me.Text = "TestKartuStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EpsDateTime1 As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents EpsDateTime2 As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents EpsTextBox1 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents EpsTextBox2 As Enerzie.EPSBasicControls.EPSTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
