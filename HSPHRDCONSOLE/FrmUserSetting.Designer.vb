<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserSetting
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btKeluar = New System.Windows.Forms.Button()
        Me.lblidkry = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtNamaKry = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btSave)
        Me.Panel1.Controls.Add(Me.btKeluar)
        Me.Panel1.Controls.Add(Me.lblidkry)
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Controls.Add(Me.txtNamaKry)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtuserid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 156)
        Me.Panel1.TabIndex = 0
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(192, 130)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 10
        Me.btSave.Text = "[F6] &Simpan"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btKeluar
        '
        Me.btKeluar.Location = New System.Drawing.Point(273, 130)
        Me.btKeluar.Name = "btKeluar"
        Me.btKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btKeluar.TabIndex = 8
        Me.btKeluar.Text = "K&eluar"
        Me.btKeluar.UseVisualStyleBackColor = True
        '
        'lblidkry
        '
        Me.lblidkry.AutoSize = True
        Me.lblidkry.Location = New System.Drawing.Point(85, 93)
        Me.lblidkry.Name = "lblidkry"
        Me.lblidkry.Size = New System.Drawing.Size(43, 13)
        Me.lblidkry.TabIndex = 7
        Me.lblidkry.Text = "[CODE]"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(309, 68)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(26, 23)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.Text = "..."
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtNamaKry
        '
        Me.txtNamaKry.Location = New System.Drawing.Point(88, 70)
        Me.txtNamaKry.Name = "txtNamaKry"
        Me.txtNamaKry.Size = New System.Drawing.Size(215, 20)
        Me.txtNamaKry.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Karyawan"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(88, 38)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(157, 20)
        Me.txtusername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "UserName"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(88, 8)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.ReadOnly = True
        Me.txtuserid.Size = New System.Drawing.Size(100, 20)
        Me.txtuserid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserID"
        '
        'FrmUserSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 172)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmUserSetting"
        Me.Text = "FrmUserSetting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaKry As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblidkry As System.Windows.Forms.Label
    Friend WithEvents btKeluar As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
End Class
