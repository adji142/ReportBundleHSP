Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports ReportBundleHSP.HSP.Data
Public Class FrmPengeluaranBonSparepart
    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker
    Private Sub FrmPengeluaranBonSparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RPT.ShowGroupTreeButton = False

        'Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        'txtTglAwal.Format = DateTimePickerFormat.Custom
        'txtTglAwal.CustomFormat = "dd/MM/yyyy"
        'txtTglAwal.Width = 95

        'Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        'txtTglAkhir.Format = DateTimePickerFormat.Custom
        'txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        'txtTglAkhir.Width = 95

        cboTipeLaporan.SelectedIndex = 0
    End Sub
End Class