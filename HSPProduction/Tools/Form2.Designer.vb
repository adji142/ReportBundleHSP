<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TglAwal = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.TglAkhir = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 95)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(471, 23)
        Me.ProgressBar.TabIndex = 3
        '
        'TglAwal
        '
        Me.TglAwal.AllowEnterToMoveNext = True
        Me.TglAwal.CustomFormat = "dd/MM/yyyy"
        Me.TglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglAwal.Location = New System.Drawing.Point(12, 27)
        Me.TglAwal.Name = "TglAwal"
        Me.TglAwal.Size = New System.Drawing.Size(99, 20)
        Me.TglAwal.TabIndex = 4
        '
        'TglAkhir
        '
        Me.TglAkhir.AllowEnterToMoveNext = True
        Me.TglAkhir.CustomFormat = "dd/MM/yyyy"
        Me.TglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglAkhir.Location = New System.Drawing.Point(117, 27)
        Me.TglAkhir.Name = "TglAkhir"
        Me.TglAkhir.Size = New System.Drawing.Size(99, 20)
        Me.TglAkhir.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 261)
        Me.Controls.Add(Me.TglAkhir)
        Me.Controls.Add(Me.TglAwal)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TglAwal As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents TglAkhir As Enerzie.EPSBasicControls.EPSDateTime
End Class
