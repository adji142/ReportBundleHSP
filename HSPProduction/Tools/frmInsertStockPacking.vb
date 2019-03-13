Imports HSPProduction.HSP.Data

Public Class frmInsertStockPacking

    Private Sub btProses_Click(sender As Object, e As EventArgs) Handles btProses.Click
        Dim DT As New DataTable

        Dim DaftarStockPacking As New DaftarStockPacking(ActiveSession)
        Dim StockPacking As StockPacking

        Dim DataCount As Integer = 0


        DT = New SAPStaging().ReadStagingFGReceiptBall(txtTanggal.Value.Date).Tables("View")
        DataCount = DT.Rows.Count

        Progress.Value = 0
        Progress.Maximum = DataCount

        For Each DR In DT.Rows
            StockPacking = DaftarStockPacking.FindExist(DR("KodeProduksi"))
            If IsNothing(StockPacking) Then
                StockPacking = New StockPacking

                StockPacking.Kelompok = DR("Kelompok")
                StockPacking.NoTransaksi = DR("NoTransaksi")
                StockPacking.TglTransaksi = DR("TglTransaksi")
                StockPacking.TglTimbang = DR("TglTimbang")
                StockPacking.NomorWO = DR("NomorWO")
                StockPacking.KodeItem = DR("KodeItem")
                StockPacking.NamaItem = DR("NamaItem")
                StockPacking.KodeShift = DR("KodeShift")
                StockPacking.KodeGrup = DR("KodeGrup")
                StockPacking.KodeUnit = DR("KodeUnit")
                StockPacking.KodeMesin = DR("KodeMesin")
                StockPacking.KodeLokasi = DR("KodeLokasi")
                StockPacking.KodeProduksi = DR("KodeProduksi")
                StockPacking.BeratBrutto = DR("Berat")
                StockPacking.KodeMedia = ""
                StockPacking.BeratMedia = 0
                StockPacking.BeratNetto = DR("Berat")
                StockPacking.BeratStandar = 0

                If DR("Sisa") = 0 Then
                    StockPacking.Pcs = DR("Pcs")
                Else
                    StockPacking.Pcs = DR("Sisa")
                End If

                If DR("Sisa") = 0 Then
                    StockPacking.StatusStock = 0
                Else
                    StockPacking.StatusStock = 1
                End If

                StockPacking.StatusQc = 1
                StockPacking.KodeStatus = ""
                StockPacking.StatusDisposisi = 0
                StockPacking.KodeDisposisi = ""
                StockPacking.Keterangan = ""
                StockPacking.UserID = "SPVS"
                'StockPacking.StatusData = "MNL"

                DaftarStockPacking.Add(StockPacking)

                Progress.Value += 1
            End If
        Next

        MsgBox("Import Data Selesai")
    End Sub
End Class