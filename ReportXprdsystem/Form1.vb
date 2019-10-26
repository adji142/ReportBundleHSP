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

    Private Sub R323100LapHasilPrintingPcsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R323100LapHasilPrintingPcsToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT323_100_PrintingPcs
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R323110LapStockHasilPrintingPcsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R323110LapStockHasilPrintingPcsToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT323_110_StockHasilPrintingPcs
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R324100LapHasilInnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R324100LapHasilInnerToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT324_100_Inner
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R329100LapHasilBallpressKarungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R329100LapHasilBallpressKarungToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT329_100_PackingKarung
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R329110LapStockRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R329110LapStockRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT329_110_StockBallKarung
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R329150LapPenyelesaianWOPackingKarungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R329150LapPenyelesaianWOPackingKarungToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT329_150_PackingKarung
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R329120DaftarItemProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R329120DaftarItemProduksiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT210_130_GudangRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapAfvalProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapAfvalProduksiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT600_100_GudangAfval
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapHasilRecycleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapHasilRecycleToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT610100_Recycle
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapPenerimaanAfvalProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapPenerimaanAfvalProduksiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT600_110_GudangAfval
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub BALLPRESSCEMENTBAGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BALLPRESSCEMENTBAGToolStripMenuItem.Click
        
    End Sub

    Private Sub LapHasilBallpressCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapHasilBallpressCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT319_100_PackingCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapStockBallpressCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapStockBallpressCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT319_110_StockBallCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub LapPenyerahanHasilProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapPenyerahanHasilProduksiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT400_100_PenyerahanHasilProduksi
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapReturHasilProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapReturHasilProduksiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT410_100_ReturHasilProduksi
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapHasilCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapHasilCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT312_100_HasilCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub LapStockCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapStockCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT312_110_StockCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R310100LapHasilLaminasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R310100LapHasilLaminasiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT310_100_Laminating
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R310110LapStockRollLaminasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R310110LapStockRollLaminasiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT310_110_StockRollLaminating
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R310120LapPemakaianBahanPembantuLaminasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R310120LapPemakaianBahanPembantuLaminasiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT310_120_PemakaianBPLaminating
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R310150LapPenyelesaianWOLaminasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R310150LapPenyelesaianWOLaminasiToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT310_150_Laminasi
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R311100LapHasilSlittingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R311100LapHasilSlittingToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT311_100_Slitting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R311110LapStockRollSlittingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R311110LapStockRollSlittingToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT311_110_StockRollSlitting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R311120LapSlittingAnalisaRollKeRollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R311120LapSlittingAnalisaRollKeRollToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT311_120_Slitting_AnalisaRollKeRoll
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R311150LapPenyelesaianWOSlittingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R311150LapPenyelesaianWOSlittingToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT311_150_Slitting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R312120LapPemakaianBahanRollCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R312120LapPemakaianBahanRollCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT312_120_BahanRollCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R312130LapHasilProduksiCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R312130LapHasilProduksiCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT312_130_HasilCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R312110LapStockCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R312110LapStockCementBagToolStripMenuItem.Click

    End Sub

    Private Sub R312150LapPenyelesaianWOCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R312150LapPenyelesaianWOCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT312_150_CementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub R319150LapPenyelesaianWOPackingCementBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R319150LapPenyelesaianWOPackingCementBagToolStripMenuItem.Click
        Dim ifrmChild As New frmRPT319_150_PackingCementBag
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub
End Class
