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
        oApp(0) = "MTN01"
        oApp(1) = "MTN01 - Pemakaian Obat"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "MTN02"
        oApp(1) = "MTN02 - Pemakaian ATK"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Execute Plugin
    Public Sub Execute(ByVal ID As String, Server As Object)
        Dim Modul As Object = Nothing

        '-------------------------------------------------------------------------
        Select Case ID
            Case "MTN01"
                Modul = New Plugin_PemakaianObat(Server)
                Modul.Execute()
            Case "MTN02"
                Modul = New Plugin_PemakaianATK(Server)
                Modul.Execute()
        End Select
        '-------------------------------------------------------------------------

    End Sub

End Class
