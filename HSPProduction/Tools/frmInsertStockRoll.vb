Imports HSPProduction.HSP.Data

Public Class frmInsertStockRoll

    Private Sub btProses_Click(sender As Object, e As EventArgs) Handles btProses.Click
        Dim DT As New DataTable

        Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
        Dim StockRoll As StockRoll

        Dim DataCount As Integer = 0


        DT = New SAPStaging().ReadStagingFGReceiptRoll(txtTanggal.Value.Date).Tables("View")
        DataCount = DT.Rows.Count

        Progress.Value = 0
        Progress.Maximum = DataCount

        For Each DR In DT.Rows
            StockRoll = DaftarStockRoll.FindExist(DR("KodeProduksi"))
            If IsNothing(StockRoll) Then
                StockRoll = New StockRoll

                StockRoll.NoTransaksi = DR("NoTransaksi")
                StockRoll.TglTransaksi = DR("TglTransaksi")
                StockRoll.TglTimbang = DR("TglTimbang")
                StockRoll.NomorWO = DR("NomorWO")
                StockRoll.KodeItem = DR("KodeItem")
                StockRoll.NamaItem = DR("NamaItem")
                StockRoll.KodeShift = DR("KodeShift")
                StockRoll.KodeGrup = DR("KodeGrup")
                StockRoll.KodeUnit = DR("KodeUnit")
                StockRoll.KodeUnitPeruntukan = DR("KodeUnitPeruntukan")
                StockRoll.KodeMesin = DR("KodeMesin")
                StockRoll.KodeLokasi = DR("KodeLokasi")
                StockRoll.KodeProduksi = DR("KodeProduksi")
                StockRoll.BeratBrutto = DR("Berat")
                StockRoll.KodeMedia = ""
                StockRoll.JumlahMedia = 1
                StockRoll.BeratMedia = 0
                StockRoll.BeratNetto = DR("Berat")

                If DR("Sisa") = 0 Then
                    StockRoll.PanjangRoll = DR("PanjangRoll")
                Else
                    StockRoll.PanjangRoll = DR("Sisa")
                End If

                StockRoll.Pcs = 0
                StockRoll.BeratPerMeter = 0
                StockRoll.Transaksi = 1

                If DR("Sisa") = 0 Then
                    StockRoll.StatusStock = 0
                Else
                    StockRoll.StatusStock = 1
                End If

                StockRoll.StatusQc = 1
                StockRoll.KodeStatus = ""
                StockRoll.StatusDisposisi = 0
                StockRoll.KodeDisposisi = ""
                StockRoll.Satuan1 = "ROLL"
                StockRoll.Satuan2 = "METER"
                StockRoll.Satuan3 = "KG"
                StockRoll.Jumlah1 = 1

                If DR("Sisa") = 0 Then
                    StockRoll.Jumlah2 = DR("PanjangRoll")
                Else
                    StockRoll.Jumlah2 = DR("Sisa")
                End If

                StockRoll.Jumlah3 = DR("Berat")
                StockRoll.Keterangan = ""
                StockRoll.InputData = 0
                StockRoll.UserID = "SPVS"
                'StockRoll.StatusData = "MNL"

                DaftarStockRoll.Add(StockRoll)

                Progress.Value += 1
            End If
        Next

        MsgBox("Import Data Selesai")
    End Sub
End Class