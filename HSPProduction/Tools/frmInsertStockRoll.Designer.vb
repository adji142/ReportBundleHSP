<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertStockRoll
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTanggal = New Enerzie.EPSBasicControls.EPSDateTime()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.btProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'txtTanggal
        '
        Me.txtTanggal.AllowEnterToMoveNext = True
        Me.txtTanggal.CustomFormat = "dd/MM/yyyy"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(64, 17)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(99, 20)
        Me.txtTanggal.TabIndex = 1
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(15, 91)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(437, 23)
        Me.Progress.TabIndex = 2
        '
        'btProses
        '
        Me.btProses.Location = New System.Drawing.Point(195, 120)
        Me.btProses.Name = "btProses"
        Me.btProses.Size = New System.Drawing.Size(75, 23)
        Me.btProses.TabIndex = 3
        Me.btProses.Text = "Proses"
        Me.btProses.UseVisualStyleBackColor = True
        '
        'frmInsertStockRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 155)
        Me.Controls.Add(Me.btProses)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsertStockRoll"
        Me.Text = "Import Stock Roll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As Enerzie.EPSBasicControls.EPSDateTime
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents btProses As System.Windows.Forms.Button
End Class
