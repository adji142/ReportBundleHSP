Public Class Form1

    Private Sub PemakaianBahanExtruderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaianBahanExtruderToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT100_120_PemakaianBahanExtruder
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R100100LapStockBahanFloorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R100100LapStockBahanFloorToolStripMenuItem.Click
        Dim ifrmChild As New frmRPTPro_SaldoStockBahan
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110130LapPenerimaanGudangBenangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110130LapPenerimaanGudangBenangToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_130_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R100110LapInventoryTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R100110LapInventoryTransferToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT100_110_InventoryTransferExtruder
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R100150LapPenyelesaianWOExtruderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R100150LapPenyelesaianWOExtruderToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT100_150_Extruder
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub RDP1310LapRekapHasilProduksiExtruderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDP1310LapRekapHasilProduksiExtruderToolStripMenuItem.Click
        Dim ifrmChild As New frmRPTRekap_ProExtruder
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub RDP1200LapDowntimeProduksiExtruderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDP1200LapDowntimeProduksiExtruderToolStripMenuItem.Click
        Dim ifrmChild As New frmRPTDowntime_ProExtruder
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub RDP1300LapRangkumanProduksiExtruderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDP1300LapRangkumanProduksiExtruderToolStripMenuItem.Click

    End Sub

    Private Sub R110100LapPenerimaanBenangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110100LapPenerimaanBenangToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_100_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110110LapPengeluaranBenangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110110LapPengeluaranBenangToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_110_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110120LapStockBenangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110120LapStockBenangToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_120_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110140LapStockGudangBenangPerAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110140LapStockGudangBenangPerAreaToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_140_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110150LapKartuStockSupportPPICToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110150LapKartuStockSupportPPICToolStripMenuItem.Click

    End Sub

    Private Sub R110160LapKartuStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110160LapKartuStockToolStripMenuItem.Click

    End Sub

    Private Sub R110190LapPenerimaanBenangSummaryByMesinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110190LapPenerimaanBenangSummaryByMesinToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_190_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110200LapPenerimaanBenangSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110200LapPenerimaanBenangSummaryToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_200_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110220LapPengeluaranBenangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110220LapPengeluaranBenangToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_220_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R110230LapDetailPengeluaranBenangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R110230LapDetailPengeluaranBenangToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT110_230_GudangBenang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub RDP1400LapPersonnelProduksiExtruderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDP1400LapPersonnelProduksiExtruderToolStripMenuItem.Click
        Dim ifrmChild As New frmRDO1201_OperatorProduksi
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200130LapAnalisaProduksiLoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200130LapAnalisaProduksiLoomToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_130_CircularLoom
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200140LapAnalisaProduksiLoomByMesinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200140LapAnalisaProduksiLoomByMesinToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_140_AnalisaProduksiLoomByMesin
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200180LapPemakaianBahanLoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200180LapPemakaianBahanLoomToolStripMenuItem.Click
        'frmRPTSAP_LaporanFloorLoom
        Dim ifrmChild As New frmRPTSAP_LaporanFloorLoom
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub RDP2200LapOperasionalCircularLoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDP2200LapOperasionalCircularLoomToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_140_AnalisaProduksiLoomByMesin
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub RDP2100LapHasilProduksiCircularLoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDP2100LapHasilProduksiCircularLoomToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT2100_HasilCircularLoom
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R210100LapPenerimaanRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R210100LapPenerimaanRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT210_100_GudangRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R210110LapStockRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R210110LapStockRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT210_110_StockRollGudangRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R210120LapMutasiRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R210120LapMutasiRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT210_120_TransferGudangRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200150LapPenyelesaianWOLoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200150LapPenyelesaianWOLoomToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_150_Loom
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200160LapPenyelesaianWOLoomSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200160LapPenyelesaianWOLoomSummaryToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_160_Loom
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200160bLapPenyelesaianWOLoomSummaryBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200160bLapPenyelesaianWOLoomSummaryBToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_160b_CircularLoom
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R200170LapAnalisaBeratRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R200170LapAnalisaBeratRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT200_170_AnalisaBerat
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R500110LapPemakaianBahanBenangMultifilamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R500110LapPemakaianBahanBenangMultifilamentToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT500_110_PemakaianBahanBmf
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R500100LapProduksiBenangMultifilamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R500100LapProduksiBenangMultifilamentToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT500_100_BenangMultifilament
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R500160LapRekapHasilBenangMultifilamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R500160LapRekapHasilBenangMultifilamentToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT500_160_Bmf
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R320100LapHasilPrintingRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R320100LapHasilPrintingRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT320_100_PrintingRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R320120LapPemakaianBahanPembantuPrintingRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R320120LapPemakaianBahanPembantuPrintingRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT320_120_PemakaianBPPrintingRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R320110LapStockRollPrintingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R320110LapStockRollPrintingToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT320_110_StockRollPrinting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R320150LapPenyelesaianWOPrintingRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R320150LapPenyelesaianWOPrintingRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT320_150_PrintingRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R321100LapHasilCuttingKarungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R321100LapHasilCuttingKarungToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT321_100_Cutting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R321110LapStockHasilCuttingKarungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R321110LapStockHasilCuttingKarungToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT321_110_StockHasilCutting_1
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R321150LapPenyelesaianWOCuttingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R321150LapPenyelesaianWOCuttingToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT321_150_Cutting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R322100LapHasilJahitKarungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R322100LapHasilJahitKarungToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT322_100_Jahit
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R322110LapStockHasilJahitKarungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R322110LapStockHasilJahitKarungToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT322_110_StockHasilJahit
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R322150LapPenyelesaianWOJahitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R322150LapPenyelesaianWOJahitToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT322_150_Jahit
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub
End Class
