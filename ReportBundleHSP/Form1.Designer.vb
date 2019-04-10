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
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GudangBenangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranBonSparepartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerimaanSparepartReturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahLokasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribusiSparepartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.FormToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ApplicationToolStripMenuItem.Text = "Application"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GudangBenangToolStripMenuItem, Me.PengeluaranBonSparepartToolStripMenuItem, Me.PenerimaanSparepartReturToolStripMenuItem, Me.DistribusiSparepartToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'GudangBenangToolStripMenuItem
        '
        Me.GudangBenangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengeluaranBarangToolStripMenuItem})
        Me.GudangBenangToolStripMenuItem.Name = "GudangBenangToolStripMenuItem"
        Me.GudangBenangToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.GudangBenangToolStripMenuItem.Text = "Gudang Benang"
        '
        'PengeluaranBarangToolStripMenuItem
        '
        Me.PengeluaranBarangToolStripMenuItem.Name = "PengeluaranBarangToolStripMenuItem"
        Me.PengeluaranBarangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PengeluaranBarangToolStripMenuItem.Text = "Pengeluaran Barang"
        '
        'PengeluaranBonSparepartToolStripMenuItem
        '
        Me.PengeluaranBonSparepartToolStripMenuItem.Name = "PengeluaranBonSparepartToolStripMenuItem"
        Me.PengeluaranBonSparepartToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.PengeluaranBonSparepartToolStripMenuItem.Text = "Pengeluaran Bon Sparepart"
        '
        'PenerimaanSparepartReturToolStripMenuItem
        '
        Me.PenerimaanSparepartReturToolStripMenuItem.Name = "PenerimaanSparepartReturToolStripMenuItem"
        Me.PenerimaanSparepartReturToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.PenerimaanSparepartReturToolStripMenuItem.Text = "Penerimaan Sparepart(Retur)"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahLokasiToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'TambahLokasiToolStripMenuItem
        '
        Me.TambahLokasiToolStripMenuItem.Name = "TambahLokasiToolStripMenuItem"
        Me.TambahLokasiToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TambahLokasiToolStripMenuItem.Text = "Tambah Lokasi"
        '
        'DistribusiSparepartToolStripMenuItem
        '
        Me.DistribusiSparepartToolStripMenuItem.Name = "DistribusiSparepartToolStripMenuItem"
        Me.DistribusiSparepartToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DistribusiSparepartToolStripMenuItem.Text = "DistribusiSparepart"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GudangBenangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengeluaranBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahLokasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengeluaranBonSparepartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenerimaanSparepartReturToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DistribusiSparepartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
