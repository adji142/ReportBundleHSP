<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtBahan = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.txtHasil = New Enerzie.EPSBasicControls.EPSTextBoxNum()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBahan
        '
        Me.txtBahan.AllowEnterToMoveNext = True
        Me.txtBahan.CheckIsValid = False
        Me.txtBahan.DataFormat = "###,##0.00"
        Me.txtBahan.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtBahan.Location = New System.Drawing.Point(63, 33)
        Me.txtBahan.Name = "txtBahan"
        Me.txtBahan.Size = New System.Drawing.Size(100, 20)
        Me.txtBahan.TabIndex = 1
        Me.txtBahan.Text = "0.00"
        Me.txtBahan.Value = 0.0R
        '
        'txtHasil
        '
        Me.txtHasil.AllowEnterToMoveNext = True
        Me.txtHasil.CheckIsValid = False
        Me.txtHasil.DataFormat = "###,##0.00"
        Me.txtHasil.DataType = Enerzie.EPSBasicControls.EPSTextBoxNum.enumDataType.dtDecimal
        Me.txtHasil.Location = New System.Drawing.Point(63, 59)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(100, 20)
        Me.txtHasil.TabIndex = 2
        Me.txtHasil.Text = "0.00"
        Me.txtHasil.Value = 0.0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bahan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasil"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(63, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Import Data StockBacth"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(63, 239)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(210, 23)
        Me.ProgressBar.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 282)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.txtBahan)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBahan As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents txtHasil As Enerzie.EPSBasicControls.EPSTextBoxNum
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
End Class
