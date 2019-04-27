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
        oApp(0) = "MKT01"
        oApp(1) = "MKT01 - Performa Penjualan"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "MKT02"
        oApp(1) = "MKT02 - Simulasi Komisi Penjualan"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "PTG01"
        oApp(1) = "PTG01 - Piutang Akan Jatuh Tempo"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "PTG02"
        oApp(1) = "PTG02 - Piutang Jatuh Tempo"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Execute Plugin
    Public Sub Execute(ByVal ID As String, Server As Object)
        Dim Modul As Object = Nothing

        '-------------------------------------------------------------------------
        Select Case ID
            Case "MKT01"
                'Modul = New Plugin_PerformaPenjualan(Server)
                'Modul.Execute()
            Case "MKT02"
                'Modul = New Plugin_SimulasiKomisiPenjualan(Server)
                'Modul.Execute()
            Case "PTG01"
                Modul = New Plugin_saldoAgingPiutangAJT(Server)
                Modul.Execute()
            Case "PTG02"
                Modul = New Plugin_saldoAgingPiutangJT(Server)
                Modul.Execute()
        End Select
        '-------------------------------------------------------------------------

    End Sub

End Class