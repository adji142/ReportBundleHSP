Public Class AppModule
    'Get Application Modul List
    Public Function GetAppModule() As DataTable
        Dim oDS As New DataSet
        Dim oDT As DataTable
        Dim oApp As DataRow

        'Create DataTable & Define Column
        oDT = oDS.Tables.Add("AppModule")
        oDT.Columns.Add("AppID")
        oDT.Columns.Add("AppDescription")

        '*************************************************************************
        'Master Data
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "1001"
        oApp(1) = "Master Shift Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1002"
        oApp(1) = "Master Grup Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1003"
        oApp(1) = "Master Satuan"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1004"
        oApp(1) = "Master Unit Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1005"
        oApp(1) = "Master Mesin Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1006"
        oApp(1) = "Master Lokasi Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1007"
        oApp(1) = "Master Area Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1008"
        oApp(1) = "Master Media Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1009"
        oApp(1) = "Master Pola Media Timbang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1010"
        oApp(1) = "Master Disposisi QC"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1011"
        oApp(1) = "Setting Form"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1012"
        oApp(1) = "Master Item Pemakaian"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1013"
        oApp(1) = "Master Status QC"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1014"
        oApp(1) = "Master Data Item Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1015"
        oApp(1) = "Parameter Roll Laminasi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "1016"
        oApp(1) = "Master Karyawan"
        '-----------------------------------------------------------------------------------

        '*************************************************************************
        'Produksi
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "2000"
        oApp(1) = "Produksi Pemakaian"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2001"
        oApp(1) = "Pemakaian Bahan Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2002"
        oApp(1) = "Produksi Extruder"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2003"
        oApp(1) = "Produksi Loom"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2004"
        oApp(1) = "Produksi Laminating"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2005"
        oApp(1) = "Produksi Printing Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2006"
        oApp(1) = "Produksi Cutting"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2007"
        oApp(1) = "Produksi Jahit"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2008"
        oApp(1) = "Produksi Printing Pcs"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2009"
        oApp(1) = "Update Status Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2010"
        oApp(1) = "Cetak Barcode Opname"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2011"
        oApp(1) = "Hasil Produksi Cement Bag"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2012"
        oApp(1) = "Pemakaian Roll Bahan Cement Bag"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2013"
        oApp(1) = "Produksi Slitting"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2014"
        oApp(1) = "Packing Karung"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2015"
        oApp(1) = "Packing Cement Bag"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2016"
        oApp(1) = "Update QC Ball"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2017"
        oApp(1) = "Produksi Recycle"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2018"
        oApp(1) = "Produksi Benang Multifilament"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2019"
        oApp(1) = "Produksi Inner"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2020"
        oApp(1) = "Proses Timbang Sisa Roll Bahan Cement Bag"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2021"
        oApp(1) = "Proses Pengakuan Makloon Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2022"
        oApp(1) = "Proses Pengakuan Roll Stock Opname"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2023"
        oApp(1) = "Proses Transfer BDP"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2024"
        oApp(1) = "Pemakaian Bahan Ex"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2025"
        oApp(1) = "Produksi Rewind"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2026"
        oApp(1) = "Produksi Afval (Manual)"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "2027"
        oApp(1) = "Penjelasan Proses Produksi"
        '-----------------------------------------------------------------------------------

        oApp = oDT.Rows.Add()
        oApp(0) = "9000"
        oApp(1) = "Pembatalan Data Produksi Packing Karung"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "9001"
        oApp(1) = "Pembatalan Data Produksi Packing Cement Bag"
        '-----------------------------------------------------------------------------------

        '*************************************************************************
        'Inventory
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "3001"
        oApp(1) = "Permintaan Benang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3002"
        oApp(1) = "Pengeluaran Benang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3003"
        oApp(1) = "Mutasi Benang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3004"
        oApp(1) = "Mutasi Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3005"
        oApp(1) = "Penyerahan Hasil Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3006"
        oApp(1) = "Reprint Barcode Laminasi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3007"
        oApp(1) = "Reprint Barcode Printing"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3008"
        oApp(1) = "Reprint Barcode Packing"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3009"
        oApp(1) = "Retur Hasil Produksi"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3010"
        oApp(1) = "Koreksi Stock Benang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3011"
        oApp(1) = "Reprint Barcode Benang Multifilament"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3012"
        oApp(1) = "Reprint Barcode Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3013"
        oApp(1) = "Koreksi Stock Roll"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "3014"
        oApp(1) = "Koreksi Stock Benang Multifilament"
        '-----------------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 100 - Extruder
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R100100"
        oApp(1) = "Lap. Stock Bahan Floor"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R100110"
        oApp(1) = "Lap. Inventory Transfer"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R100120"
        oApp(1) = "Lap. Pemakaian Bahan"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R100140"
        oApp(1) = "Lap. Anlaisa Produksi Extruder"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R100150"
        oApp(1) = "Lap. Penyelesaian WO Extruder"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 110 - Gudang Benang
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R110100"
        oApp(1) = "Lap. Penerimaan Benang"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110110"
        oApp(1) = "Lap. Pengeluaran Benang"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110120"
        oApp(1) = "Lap. Stock Benang"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110130"
        oApp(1) = "Lap. Penerimaan Gudang Benang"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110140"
        oApp(1) = "Lap. Stock Gudang Benang Per Area"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110150"
        oApp(1) = "Lap. Kartu Stock (Support PPIC)"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110160"
        oApp(1) = "Lap. Kartu Stock"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110170"
        oApp(1) = "Lap. Stock Benang Per Area"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110180"
        oApp(1) = "Lap. Performa Gudang Benang"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110190"
        oApp(1) = "Lap. Penerimaan Benang (Summary By Mesin)"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R110200"
        oApp(1) = "Lap. Penerimaan Benang (Summary)"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 200 - Circular Loom
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R200130"
        oApp(1) = "Lap. Analisa Produksi Loom"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R200140"
        oApp(1) = "Lap. Analisa Produksi Loom By Mesin"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R200150"
        oApp(1) = "Lap. Penyelesaian WO Loom"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R200160"
        oApp(1) = "Lap. Penyelesaian WO Loom Summary"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R200160b"
        oApp(1) = "Lap. Penyelesaian WO Loom Summary - B"
        '-------------------------------------------------------------------------


        '*************************************************************************
        'Laporan 210 - Gudang Roll
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R210100"
        oApp(1) = "Lap. Penerimaan Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R210110"
        oApp(1) = "Lap. Stock Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R210120"
        oApp(1) = "Lap. Mutasi Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R210130"
        oApp(1) = "Lap. Daftar Item Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R210190"
        oApp(1) = "Lap. Penerimaan Roll Makloon"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 310 - Produksi Laminating
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R310100"
        oApp(1) = "Lap. Hasil Laminasi"

        oApp = oDT.Rows.Add()
        oApp(0) = "R310110"
        oApp(1) = "Lap. Stock Roll Laminasi"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R310120"
        oApp(1) = "Lap. Pemakaian Bahan Pembantu Laminasi"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R310130"
        oApp(1) = "Lap. Laminating - Analisa Roll Ke Roll "
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R310150"
        oApp(1) = "Lap. Penyelesaian WO Laminasi"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 311 - Produksi Slitting
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R311100"
        oApp(1) = "Lap. Hasil Slitting"

        oApp = oDT.Rows.Add()
        oApp(0) = "R311110"
        oApp(1) = "Lap. Stock Roll Slitting"

        oApp = oDT.Rows.Add()
        oApp(0) = "R311120"
        oApp(1) = "Lap. Slitting - Analisa Roll Ke Roll"

        oApp = oDT.Rows.Add()
        oApp(0) = "R311150"
        oApp(1) = "Lap. Penyelesaian WO Slitting"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 312 - Produksi Cement Bag
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R312100"
        oApp(1) = "Lap. Hasil Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312110"
        oApp(1) = "Lap. Stock Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312120"
        oApp(1) = "Lap. Pemakaian Bahan Roll Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312140"
        oApp(1) = "Lap. Sisa Pemakaian Bahan Roll Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R312150"
        oApp(1) = "Lap. Penyelesaian WO Cement Bag"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 319 - Packing Cement Bag
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R319100"
        oApp(1) = "Lap. Hasil Ballpress Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R319110"
        oApp(1) = "Lap. Stock Ballpress Cement Bag"

        oApp = oDT.Rows.Add()
        oApp(0) = "R319150"
        oApp(1) = "Lap. Penyelesaian WO Packing Cement Bag"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 329 - Packing Karung
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R329100"
        oApp(1) = "Lap. Hasil Ballpress Karung"

        oApp = oDT.Rows.Add()
        oApp(0) = "R329110"
        oApp(1) = "Lap. Stock Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R329120"
        oApp(1) = "Daftar Item Produksi"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R329150"
        oApp(1) = "Lap. Penyelesaian WO Packing Karung"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 321 - Cutting
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R321100"
        oApp(1) = "Lap. Hasil Cutting Karung"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R321110"
        oApp(1) = "Lap. Stock Hasil Cutting Karung"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R321120"
        oApp(1) = "Lap. Analisa Hasil Cutting"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R321150"
        oApp(1) = "Lap. Penyelesaian WO Cutting"
        '-------------------------------------------------------------------------


        '*************************************************************************
        'Laporan 322 - Jahit
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R322100"
        oApp(1) = "Lap. Hasil Jahit Karung"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R322110"
        oApp(1) = "Lap. Stock Hasil Jahit Karung"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R322150"
        oApp(1) = "Lap. Penyelesaian WO Jahit"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 323 - Printing Pcs
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R323100"
        oApp(1) = "Lap. Hasil Printing Pcs"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R323110"
        oApp(1) = "Lap. Stock Hasil Printing Pcs"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 324 - Inner
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R324100"
        oApp(1) = "Lap. Hasil Inner"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R324110"
        oApp(1) = "Lap. Stock Hasil Inner"
        '-------------------------------------------------------------------------


        '*************************************************************************
        'Laporan 320 - Printing Roll
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R320100"
        oApp(1) = "Lap. Hasil Printing Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R320110"
        oApp(1) = "Lap. Stock Roll Printing"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R320120"
        oApp(1) = "Lap. Pemakaian Bahan Pembantu Printing Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R320130"
        oApp(1) = "Lap. Printing Analisa Rool Ke Roll"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R320150"
        oApp(1) = "Lap. Penyelesaian WO Printing Roll"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 400 - Penyerahan Hasil Produksi
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R400100"
        oApp(1) = "Lap. Penyerahan Hasil Produksi"
        '-------------------------------------------------------------------------

        oApp = oDT.Rows.Add()
        oApp(0) = "R400110"
        oApp(1) = "Lap. Analisa Berat Hasil Produksi"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 410 - Retur Hasil Produksi
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R410100"
        oApp(1) = "Lap. Retur Hasil Produksi"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 500 - Produksi Benang Multifilament
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R500100"
        oApp(1) = "Lap. Produksi Benang Multifilament"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R500110"
        oApp(1) = "Lap. Pemakaian Bahan Benang Multifilament"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R500130"
        oApp(1) = "Lap. Stock Benang Multifilament"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 600 - Gudang Afval
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R600100"
        oApp(1) = "Daftar Item Afval Produksi"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R600110"
        oApp(1) = "Lap. Penerimaan Afval Produksi"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 610 - Recycle
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R610100"
        oApp(1) = "Lap. Hasil Recycle"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 700 - Quality Control
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R700100"
        oApp(1) = "Lap. Inspeksi Roll"
        '-------------------------------------------------------------------------

        oApp = oDT.Rows.Add()
        oApp(0) = "R710100"
        oApp(1) = "Lap. Inspeksi Ball"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 900 - Produksi
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R900100"
        oApp(1) = "Lap. Monitoring Work Order"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R900110"
        oApp(1) = "Lap. Stock Comparison"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 770 - Transfer BDP
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R770100"
        oApp(1) = "Lap. Transfer BDP"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 800 - Cost Accounting
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R800100"
        oApp(1) = "Lap. Produksi (Cost Accounting)"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R800110"
        oApp(1) = "Lap. Produksi (Cost Accounting) - WO Period"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R800120"
        oApp(1) = "Lap. Produksi (Cost Accounting) - WO"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 810 - Laporan Keuangan
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R810100"
        oApp(1) = "Lap. Persediaan"
        '-------------------------------------------------------------------------

        '*************************************************************************
        'Laporan 910 - Produksi Rewind
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "R910100"
        oApp(1) = "Lap. Hasil Rewind"
        '-------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "R910110"
        oApp(1) = "Lap. Stock Roll Rewind"
        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------
        

        '*************************************************************************
        'Laporan
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "5001"
        oApp(1) = "Lap. Penerimaan Benang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "5002"
        oApp(1) = "Lap. Pengeluaran Benang"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "5003"
        oApp(1) = "Lap. Pemakaian Bahan"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "5004"
        oApp(1) = "Lap. Saldo Stock Bahan"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "5005"
        oApp(1) = "Lap. Saldo Stock Benang"
        '-----------------------------------------------------------------------------------

        oApp = oDT.Rows.Add()
        oApp(0) = "00"
        oApp(1) = "----------------------------------------"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Application Modul 
    Public Function Form(ByVal AppID As String, ByVal Session As Object) As Object
        Dim AppForm As Object = Nothing

        ActiveSession.KodePerusahaan = Session.KodePerusahaan
        ActiveSession.NamaPerusahaan = Session.NamaPerusahaan
        ActiveSession.Alamat1 = Session.Alamat1
        ActiveSession.Alamat2 = Session.Alamat2
        ActiveSession.Kota = Session.Kota
        ActiveSession.Propinsi = Session.Propinsi
        ActiveSession.NoTelpon = Session.NoTelpon
        ActiveSession.NoFax = Session.NoFax
        ActiveSession.KodeUser = Session.KodeUser
        ActiveSession.NamaUser = Session.NamaUser
        ActiveSession.HakAkses = Session.HakAkses
        ActiveSession.Supervisor = Session.Supervisor
        ActiveSession.HakUbahTanggal = Session.HakUbahTanggal
        ActiveSession.DBConnection = Session.DBConnection

        '*************************************************************************
        'Master Data
        '*************************************************************************
        Select Case AppID
            Case "1001"
                AppForm = New frmDaftarShiftProduksi
            Case "1002"
                AppForm = New frmDaftarGrupProduksi
            Case "1003"
                AppForm = New frmDaftarSatuan
            Case "1004"
                AppForm = New frmDaftarUnitProduksi
            Case "1005"
                AppForm = New frmDaftarMesinProduksi
            Case "1006"
                AppForm = New frmDaftarLokasiProduksi
            Case "1007"
                AppForm = New frmDaftarAreaProduksi
            Case "1008"
                AppForm = New frmDaftarMediaTimbang
            Case "1009"
                AppForm = New frmDaftarPolaMediaTimbang
            Case "1010"
                AppForm = New frmDaftarQCDisposisi
            Case "1011"
                AppForm = New frmSetting
            Case "1012"
                AppForm = New frmDaftarItemPemakaianProduksi
            Case "1013"
                AppForm = New frmDaftarPenjelasanProduksi
            Case "1014"
                AppForm = New frmDaftarItem
            Case "1015"
                AppForm = New frmDaftarParameterRollLaminasi
            Case "1016"
                AppForm = New frmDaftarKaryawan
        End Select

        '*************************************************************************
        'Produksi
        '*************************************************************************
        Select Case AppID
            Case "2000"
                AppForm = New frmProduksiAfval
            Case "2001"
                AppForm = New frmDaftarPemakaianBahan
            Case "2002"
                AppForm = New frmProduksiExtruder
            Case "2003"
                AppForm = New frmProduksiLoom
            Case "2004"
                AppForm = New frmProduksiLaminating
            Case "2005"
                AppForm = New frmProduksiPrintingRoll
            Case "2006"
                AppForm = New frmProduksiCutting
            Case "2007"
                AppForm = New frmProduksiJahit
            Case "2008"
                AppForm = New frmProduksiPrintingPcs
            Case "2009"
                AppForm = New frmDaftarQCUpdateStatusRoll
            Case "2010"
                AppForm = New frmCetakBarcodeRoll
            Case "2011"
                AppForm = New frmProduksiCBHP
            Case "2012"
                AppForm = New frmProduksiCBPR
            Case "2013"
                AppForm = New frmProduksiSlitting
            Case "2014"
                AppForm = New frmProduksiPackingKarung
            Case "2015"
                AppForm = New frmProduksiPackingCementBag
            Case "2016"
                AppForm = New frmDaftarQCUpdateStatusBall
            Case "2017"
                AppForm = New frmProduksiRecycle
            Case "2018"
                AppForm = New frmProduksiBenangMultifilament
            Case "2019"
                AppForm = New frmProduksiInner
            Case "2020"
                AppForm = New frmProduksiCBSP
            Case "2021"
                AppForm = New frmProduksiMakloonRoll
            Case "2022"
                AppForm = New frmPengakuanStockRoll
            Case "2023"
                AppForm = New frmDaftarTransferBDP
            Case "2024"
                AppForm = New frmDaftarPemakaianBahanEx
            Case "2025"
                AppForm = New frmProduksiRewind
            Case "2026"
                AppForm = New frmProduksiAfvalManual
            Case "2027"
                AppForm = New frmDaftarPenjelasanProduksi
            Case "9000"
                AppForm = New frmDaftarPembatalanPackingKarung
            Case "9001"
                AppForm = New frmDaftarPembatalanPackingCementBag
        End Select

        '*************************************************************************
        'Inventory
        '*************************************************************************
        Select Case AppID
            Case "3001"
                AppForm = New frmDaftarPermintaanBenang
            Case "3002"
                AppForm = New frmDaftarPengeluaranBenang
            Case "3003"
                AppForm = New frmMutasiAreaBenang
            Case "3004"
                AppForm = New frmDaftarMutasiRoll
            Case "3005"
                AppForm = New frmPenyerahanHasilProduksi
            Case "3006"
                AppForm = New frmReprintBarcodeLaminasi
            Case "3007"
                AppForm = New frmReprintBarcodePrinting
            Case "3008"
                AppForm = New frmReprintBarcodeBall
            Case "3009"
                AppForm = New frmReturHasilProduksi
            Case "3010"
                AppForm = New frmDaftarStockBenang
            Case "3011"
                AppForm = New frmReprintBarcodeBmf
            Case "3012"
                AppForm = New frmReprintBarcodeRoll
            Case "3013"
                AppForm = New frmDaftarStockRoll
            Case "3014"
                AppForm = New frmDaftarStockBMF
        End Select

        '*************************************************************************
        'Laporan 100 - Extruder
        '*************************************************************************
        Select Case AppID
            Case "R100100"
                AppForm = New frmRPT100_100_StockBahanExtruder
            Case "R100110"
                AppForm = New frmRPT100_110_InventoryTransferExtruder
            Case "R100120"
                AppForm = New frmRPT100_120_PemakaianBahanExtruder
            Case "R100140"
                AppForm = New frmRPT100_140_Extruder
            Case "R100150"
                AppForm = New frmRPT100_150_Extruder
        End Select

        '*************************************************************************
        'Laporan 110 - Gudang Benang
        '*************************************************************************
        Select Case AppID
            Case "R110100"
                AppForm = New frmRPT110_100_GudangBenang
            Case "R110110"
                AppForm = New frmRPT110_110_GudangBenang
            Case "R110120"
                AppForm = New frmRPT110_120_GudangBenang
            Case "R110130"
                AppForm = New frmRPT110_130_GudangBenang
            Case "R110140"
                AppForm = New frmRPT110_140_GudangBenang
            Case "R110150"
                AppForm = New frmRPT110_150_GudangBenang
            Case "R110160"
                AppForm = New frmRPT110_160_GudangBenang
            Case "R110170"
                AppForm = New frmRPT110_170_GudangBenang
            Case "R110180"
                AppForm = New frmRPT110_180_GudangBenang
            Case "R110190"
                AppForm = New frmRPT110_190_GudangBenang
            Case "R110200"
                AppForm = New frmRPT110_200_GudangBenang
        End Select

        '*************************************************************************
        'Laporan 200 - Circular Loom
        '*************************************************************************
        Select Case AppID
            Case "R200130"
                AppForm = New frmRPT200_130_CircularLoom
            Case "R200140"
                AppForm = New frmRPT200_140_AnalisaProduksiLoomByMesin
            Case "R200150"
                AppForm = New frmRPT200_150_Loom
            Case "R200160"
                AppForm = New frmRPT200_160_Loom
            Case "R200160b"
                AppForm = New frmRPT200_160b_CircularLoom
        End Select

        '*************************************************************************
        'Laporan 210 - Gudang Roll
        '*************************************************************************
        Select Case AppID
            Case "R210100"
                AppForm = New frmRPT210_100_GudangRoll
            Case "R210110"
                AppForm = New frmRPT210_110_StockRollGudangRoll
            Case "R210120"
                AppForm = New frmRPT210_120_TransferGudangRoll
            Case "R210130"
                AppForm = New frmRPT210_130_GudangRoll
            Case "R210190"
                AppForm = New frmRPT210_190_GudangRoll
        End Select

        '*************************************************************************
        'Laporan 310 - Produksi Laminasi
        '*************************************************************************
        Select Case AppID
            Case "R310100"
                AppForm = New frmRPT310_100_Laminating
            Case "R310110"
                AppForm = New frmRPT310_110_StockRollLaminating
            Case "R310120"
                AppForm = New frmRPT310_120_PemakaianBPLaminating
            Case "R310130"
                AppForm = New frmRPT310_130_Laminating_AnalisaRollKeRoll
            Case "R310150"
                AppForm = New frmRPT310_150_Laminasi
        End Select

        '*************************************************************************
        'Laporan 311 - Produksi Slitting
        '*************************************************************************
        Select Case AppID
            Case "R311100"
                AppForm = New frmRPT311_100_Slitting
            Case "R311110"
                AppForm = New frmRPT311_110_StockRollSlitting
            Case "R311120"
                AppForm = New frmRPT311_120_Slitting_AnalisaRollKeRoll
            Case "R311150"
                AppForm = New frmRPT311_150_Slitting
        End Select

        '*************************************************************************
        'Laporan 312 - Produksi Cement Bag
        '*************************************************************************
        Select Case AppID
            Case "R312100"
                AppForm = New frmRPT312_100_HasilCementBag
            Case "R312110"
                AppForm = New frmRPT312_110_StockCementBag
            Case "R312120"
                AppForm = New frmRPT312_120_BahanRollCementBag
            Case "R312140"
                AppForm = New frmRPT312_140_SisaRollCementBag
            Case "R312150"
                AppForm = New frmRPT312_150_CementBag
        End Select

        '*************************************************************************
        'Laporan 319 - Packing Cement Bag
        '*************************************************************************
        Select Case AppID
            Case "R319100"
                AppForm = New frmRPT319_100_PackingCementBag
            Case "R319110"
                AppForm = New frmRPT319_110_StockBallCementBag
            Case "R319150"
                AppForm = New frmRPT319_150_PackingCementBag
        End Select

        '*************************************************************************
        'Laporan 329 - Packing Karung
        '*************************************************************************
        Select Case AppID
            Case "R329100"
                AppForm = New frmRPT329_100_PackingKarung
            Case "R329110"
                AppForm = New frmRPT329_110_StockBallKarung
            Case "R329120"
                AppForm = New frmRPT329_120_DaftarItem
            Case "R329150"
                AppForm = New frmRPT329_150_PackingKarung
        End Select

        '*************************************************************************
        'Laporan 321 - Cutting
        '*************************************************************************
        Select Case AppID
            Case "R321100"
                AppForm = New frmRPT321_100_Cutting
            Case "R321110"
                AppForm = New frmRPT321_110_StockHasilCutting_1
            Case "R321120"
                AppForm = New frmRPT321_121_Cutting_AnalisaRollKePcs
            Case "R321150"
                AppForm = New frmRPT321_150_Cutting
        End Select

        '*************************************************************************
        'Laporan 322 - Jahit
        '*************************************************************************
        Select Case AppID
            Case "R322100"
                AppForm = New frmRPT322_100_Jahit
            Case "R322110"
                AppForm = New frmRPT322_110_StockHasilJahit
            Case "R322150"
                AppForm = New frmRPT322_150_Jahit
        End Select

        '*************************************************************************
        'Laporan 323 - Printing Pcs
        '*************************************************************************
        Select Case AppID
            Case "R323100"
                AppForm = New frmRPT323_100_PrintingPcs
            Case "R323110"
                AppForm = New frmRPT323_110_StockHasilPrintingPcs
        End Select

        '*************************************************************************
        'Laporan 324 - Inner
        '*************************************************************************
        Select Case AppID
            Case "R324100"
                AppForm = New frmRPT324_100_Inner
            Case "R324110"
                AppForm = New frmRPT324_110_StockHasilInner
        End Select

        '*************************************************************************
        'Laporan 320 - Printing Roll
        '*************************************************************************
        Select Case AppID
            Case "R320100"
                AppForm = New frmRPT320_100_PrintingRoll
            Case "R320110"
                AppForm = New frmRPT320_110_StockRollPrinting
            Case "R320120"
                AppForm = New frmRPT320_120_PemakaianBPPrintingRoll
            Case "R320130"
                AppForm = New frmRPT320_130_PrintingRoll_AnalisaRollKeRoll
            Case "R320150"
                AppForm = New frmRPT320_150_PrintingRoll
        End Select

        '*************************************************************************
        'Laporan 400 - Penyerahan Hasil Produksi
        '*************************************************************************
        Select Case AppID
            Case "R400100"
                AppForm = New frmRPT400_100_PenyerahanHasilProduksi
            Case "R400110"
                AppForm = New frmRPT400_110_AnalisaBeratHasilProduksi
        End Select

        '*************************************************************************
        'Laporan 410 - Retur Hasil Produksi
        '*************************************************************************
        Select Case AppID
            Case "R410100"
                AppForm = New frmRPT410_100_ReturHasilProduksi
        End Select

        '*************************************************************************
        'Laporan 500 - Produksi Benang Multifilament
        '*************************************************************************
        Select Case AppID
            Case "R500100"
                AppForm = New frmRPT500_100_BenangMultifilament
            Case "R500110"
                AppForm = New frmRPT500_110_PemakaianBahanBmf
            Case "R500130"
                AppForm = New frmRPT500_130_StockHasilBenangMultifilament
        End Select

        '*************************************************************************
        'Laporan 600 - Gudang Afval
        '*************************************************************************
        Select Case AppID
            Case "R600100"
                AppForm = New frmRPT600_100_GudangAfval
            Case "R600110"
                AppForm = New frmRPT600_110_GudangAfval
        End Select

        '*************************************************************************
        'Laporan 610 - Recycle
        '*************************************************************************
        Select Case AppID
            Case "R610100"
                AppForm = New frmRPT610100_Recycle
        End Select

        '*************************************************************************
        'Laporan 700 - Quality Control
        '*************************************************************************
        Select Case AppID
            Case "R700100"
                AppForm = New frmRPT210_140_StockRoll
            Case "R710100"
                AppForm = New frmRPT329_140_StockPacking
        End Select

        '*************************************************************************
        'Laporan 900 - Produksi
        '*************************************************************************
        Select Case AppID
            Case "R900100"
                AppForm = New frmRPT900_100_Produksi
        End Select
        Select Case AppID
            Case "R900110"
                AppForm = New frmRPT900_110_StockBatch
        End Select

        '*************************************************************************
        'Laporan 77 - Transfer BDP
        '*************************************************************************
        Select Case AppID
            Case "R770100"
                AppForm = New frmRPT770_100_TransferBDP
        End Select

        '*************************************************************************
        'Laporan 800 - Cost Accounting
        '*************************************************************************
        Select Case AppID
            Case "R800100"
                AppForm = New frmRPT800_100_CostAccounting
        End Select
        Select Case AppID
            Case "R800110"
                AppForm = New frmRPT800_110_CostAccounting
        End Select
        Select Case AppID
            Case "R800120"
                AppForm = New frmRPT800_120_CostAccounting
        End Select

        '*************************************************************************
        'Laporan 810 - Laporan Keuangan
        '*************************************************************************
        Select Case AppID
            Case "R810100"
                AppForm = New frmRPT_FR_Persediaan
        End Select

        '*************************************************************************
        'Laporan 910 - Produksi Rewind
        '*************************************************************************
        Select Case AppID
            Case "R910100"
                AppForm = New frmRPT910_100_Rewind
        End Select
        Select Case AppID
            Case "R910110"
                AppForm = New frmRPT910_110_StockRollRewind
        End Select

        '*************************************************************************
        'Laporan
        '*************************************************************************
        Select Case AppID
            Case "5001"
                AppForm = New frmRPT110_100_GudangBenang
            Case "5002"
                AppForm = New frmRPT110_110_GudangBenang
            Case "5003"
            Case "5004"
            Case "5005"
                AppForm = New frmRPT110_120_GudangBenang
        End Select

        Select Case AppID
            Case "00"
        End Select

        Form = AppForm

    End Function

End Class