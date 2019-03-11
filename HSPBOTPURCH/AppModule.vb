Public Class AppModule

    'Get Plugin Modul List
    Public Function GetAppModule() As DataTable
        Dim oDS As New DataSet
        Dim oDT As DataTable
        Dim oApp As DataRow

        oDT = oDS.Tables.Add("AppModule")
        oDT.Columns.Add("PluginKeywordID")
        oDT.Columns.Add("AppDescription")

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "PRC01"
        oApp(1) = "PRC01 - Pembelian 3 Bulan Terakhir"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "PRC02"
        oApp(1) = "PRC02 - Kedatangan Barang"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "PRC03"
        oApp(1) = "PRC03 - Saldo Stock Gudang Induk"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Execute Plugin
    Public Sub Execute(ByVal ID As String, Server As Object)
        Dim Modul As Object = Nothing

        '-------------------------------------------------------------------------
        Select Case ID
            Case "PRC01"
                Modul = New Plugin_Pembelian3Month(Server)
                Modul.Execute()
            Case "PRC02"
                Modul = New Plugin_KedatanganBarang(Server)
                Modul.Execute()
            Case "PRC03"
                Modul = New Plugin_SaldoStock(Server)
                Modul.Execute()
        End Select
        '-------------------------------------------------------------------------

    End Sub

End Class
