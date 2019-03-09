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
        oApp(0) = "HRD01"
        oApp(1) = "HRD01 - Sisa Cuti"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "HRD02"
        oApp(1) = "HRD02 - Data Karyawan"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "HRD03"
        oApp(1) = "HRD03 - Ketidakhadiran"
        '-----------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "HRD04"
        oApp(1) = "HRD04 - Keterlambatan"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Execute Plugin
    Public Sub Execute(ByVal ID As String, Server As Object)
        Dim Modul As Object = Nothing

        '-------------------------------------------------------------------------
        Select Case ID
            Case "HRD01"
                Modul = New Plugin_CutiAll(Server)
                Modul.Execute()
            Case "HRD02"
                Modul = New Plugin_DataKaryawan(Server)
                Modul.Execute()
            Case "HRD03"
                Modul = New Plugin_Ketidakhadiran(Server)
                Modul.Execute()
            Case "HRD04"
                Modul = New Plugin_Keterlambatan(Server)
                Modul.Execute()
        End Select
        '-------------------------------------------------------------------------

    End Sub

End Class
