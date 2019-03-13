Imports System.Text.RegularExpressions
Imports HSPProduction.HSP.Data

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DataMiss As New DaftarPengeluaranBenang(ActiveSession)
        Dim DT As DataTable = DataMiss.ReadMiss().Tables("View")
        Dim DR As DataRow

        Dim SAP As New SAPStaging()
        For Each DR In DT.Rows
            SAP.PostInventoryTransfer(DR("TglTransaksi"), DR("KodeItem"), DR("NamaItem"), DR("QtyRealisasi"), "", DR("NoTransaksi"), "511", "520")

            'Eksekusi Data Staging
            '---------------------------------------------------------------------------------------------
            SAP.Execute(DR("NoTransaksi"), HSPProduction.SAPStaging.enumTransaction.InventoryTransfer)
        Next
    End Sub
End Class