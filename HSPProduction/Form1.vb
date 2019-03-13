Imports HSPProduction.HSP.Data

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BatasBawah As Double = 0
        Dim BatasAtas As Double = 0

        BatasBawah = txtBahan.Value - ((1.5 / 100) * txtBahan.Value)
        BatasAtas = txtBahan.Value + ((1.5 / 100) * txtBahan.Value)

        If txtHasil.Value <= BatasBawah Or txtHasil.Value >= BatasAtas Then
            MessageBox.Show("Bahan = " & txtBahan.Value & " Batas Bawah = " & BatasBawah & " Batas Atas = " & BatasAtas & " Hasil = " & txtHasil.Value & " | Data Melebihi Toleranasi")
        Else
            MessageBox.Show("Normal")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SAP As New SAPInventory()
        Dim DS As DataSet

        DS = SAP.ReadStockBatchRoll("530")

        Dim DaftarStockBacth As New DaftarTempStockBatch(ActiveSession)
        Dim TempStockBatch As New TempStockBatch

        Dim Record As Integer = DS.Tables("View").Rows.Count
        ProgressBar.Value = 0
        ProgressBar.Maximum = Record

        For Each DR As DataRow In DS.Tables("View").Rows
            TempStockBatch.KodeItem = DR("KodeItem")
            TempStockBatch.NamaItem = DR("NamaItem")
            TempStockBatch.KodeProduksi = DR("KodeProduksi")
            TempStockBatch.Qty = DR("Qty")
            TempStockBatch.KodeUnitSAP = DR("KodeUnit")
            TempStockBatch.KodeLokasi = DR("KodeLokasi")

            DaftarStockBacth.Add(TempStockBatch)

            ProgressBar.Value += 1
        Next
        If ProgressBar.Value = Record Then
            ProgressBar.Visible = False
        End If
    End Sub
End Class