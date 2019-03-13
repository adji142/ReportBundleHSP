Imports HSPProduction.HSP.Data

Public Class frmRPTStock

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAP As New SAPInventory()
        Dim DS As DataSet

        DS = SAP.ReadStock("MULTIFILAMENT", "100")

        Dim DaftarTempStock As New DaftarTempStock(ActiveSession)
        Dim TempStock As New TempStockSAP

        For Each DR As DataRow In DS.Tables("View").Rows
            TempStock.KodeItem = DR("KodeItem")
            TempStock.NamaItem = DR("NamaItem")
            TempStock.KodeProduksi = DR("KodeProduksi")
            TempStock.Qty = DR("Qty")

            DaftarTempStock.Add(TempStock)
        Next

        MessageBox.Show("OK")
    End Sub
End Class