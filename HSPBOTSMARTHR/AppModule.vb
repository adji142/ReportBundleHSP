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
        oApp(0) = "CUTI"
        oApp(1) = "CUTI - Sisa Cuti Anda"
        '-----------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LATE"
        oApp(1) = "LATE - Keterlambatan Anda"
        '-----------------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "CUTI-X"
        oApp(1) = "CUTI-X - Informasi Cuti Subordinat Anda"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Execute Plugin
    Public Sub Execute(ByVal ID As String, Server As Object)
        Dim Modul As Object = Nothing
        '-------------------------------------------------------------------------
        Select Case ID
            Case "CUTI"
                Modul = New Plugin_CutiPerUser(Server)
                'Modul.Execute_FirstStep()
                Modul.Execute()
            Case "LATE"
                Modul = New PluginKeterlambatan(Server)
                Modul.Execute()
            Case "CUTI-X"
                Modul = New Plugin_MultilevelAnualLeave(Server)
                Modul.Execute()

        End Select
        '-------------------------------------------------------------------------

    End Sub

End Class
