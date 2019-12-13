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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeetingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotulenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotulenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MeetingToolStripMenuItem, Me.NotulenToolStripMenuItem1, Me.UserSettingToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'MeetingToolStripMenuItem
        '
        Me.MeetingToolStripMenuItem.Name = "MeetingToolStripMenuItem"
        Me.MeetingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MeetingToolStripMenuItem.Text = "Meeting"
        '
        'NotulenToolStripMenuItem1
        '
        Me.NotulenToolStripMenuItem1.Name = "NotulenToolStripMenuItem1"
        Me.NotulenToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NotulenToolStripMenuItem1.Text = "Notulen"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotulenToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'NotulenToolStripMenuItem
        '
        Me.NotulenToolStripMenuItem.Name = "NotulenToolStripMenuItem"
        Me.NotulenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NotulenToolStripMenuItem.Text = "Notulen"
        '
        'UserSettingToolStripMenuItem
        '
        Me.UserSettingToolStripMenuItem.Name = "UserSettingToolStripMenuItem"
        Me.UserSettingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserSettingToolStripMenuItem.Text = "User Setting"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeetingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotulenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotulenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
