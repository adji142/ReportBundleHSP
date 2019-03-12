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
        oApp(0) = "GA01"
        oApp(1) = "GA01 - Pemakaian Obat"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "GA02"
        oApp(1) = "GA02 - Pemakaian ATK"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "GA03"
        oApp(1) = "GA03 - Rekap Pemakaian ATK"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "GA04"
        oApp(1) = "GA04 - Rekap Pemakaian Obat"
        '-----------------------------------------------------------------------------------
        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Execute Plugin
    Public Sub Execute(ByVal ID As String, Server As Object)
        Dim Modul As Object = Nothing

        '-------------------------------------------------------------------------
        Select Case ID
            Case "GA01"
                Modul = New Plugin_PemakaianObat(Server)
                Modul.Execute()
            Case "GA02"
                Modul = New Plugin_PemakaianATK(Server)
                Modul.Execute()
            Case "GA03"
                Modul = New Plugin_PemakaianATK_Rekap(Server)
                Modul.Execute()
            Case "GA04"
                Modul = New Plugin_PemakaianObat_Rekap(Server)
                Modul.Execute()
        End Select
        '-------------------------------------------------------------------------

    End Sub

End Class
