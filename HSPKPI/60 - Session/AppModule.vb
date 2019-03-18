Public Class AppModule
    'Get Application Modul List
    Public Function GetAppModule() As DataTable
        Dim oDS As New DataSet
        Dim oDT As DataTable
        Dim oApp As DataRow

        'Create DataTable & Define Column
        oDT = oDS.Tables.Add("AppModule")
        oDT.Columns.Add("AppID")
        oDT.Columns.Add("AppDescription")

        '*************************************************************************
        'Master Data
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "MKPI001"
        oApp(1) = "Master Data Kelompok"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "MKPI002"
        oApp(1) = "Master Data Aspek"
        '-----------------------------------------------------------------------------------

        '*************************************************************************
        'Transaksi
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "TKPI001"
        oApp(1) = "Key Performance Indicators ( KPI )"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "TKPI002"
        oApp(1) = "On The Job Training ( OJT )"
        '-----------------------------------------------------------------------------------

        '*************************************************************************
        'Laporan
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI001"
        oApp(1) = "Laporan KPI"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI002"
        oApp(1) = "Laporan KPI Bulanan"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI003"
        oApp(1) = "Laporan KPI Tahunan"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI004"
        oApp(1) = "Laporan Progress Ketepatan Input Data"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI005"
        oApp(1) = "Laporan Progress Kelengkapan Data"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI006"
        oApp(1) = "Laporan Indeks Prestasi Kerja < 2.5"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "LKPI007"
        oApp(1) = "Laporan Indeks Prestasi Kerja > 3.5"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function


    'Application Modul 
    Public Function Form(ByVal AppID As String, ByVal Session As Object) As Object
        Dim AppForm As Object = Nothing

        ActiveSession.KodePerusahaan = Session.KodePerusahaan
        ActiveSession.NamaPerusahaan = Session.NamaPerusahaan
        ActiveSession.Alamat1 = Session.Alamat1
        ActiveSession.Alamat2 = Session.Alamat2
        ActiveSession.Kota = Session.Kota
        ActiveSession.Propinsi = Session.Propinsi
        ActiveSession.NoTelpon = Session.NoTelpon
        ActiveSession.NoFax = Session.NoFax
        ActiveSession.KodeUser = Session.KodeUser
        ActiveSession.NamaUser = Session.NamaUser
        ActiveSession.HakAkses = Session.HakAkses
        ActiveSession.Supervisor = Session.Supervisor
        ActiveSession.HakUbahTanggal = Session.HakUbahTanggal
        ActiveSession.DBConnection = Session.DBConnection

        '*************************************************************************
        'Master Data
        '*************************************************************************
        Select Case AppID
            Case "MKPI001"
                AppForm = New frmDaftarKelompok
            Case "MKPI002"
                AppForm = New frmDaftarAspek
        End Select

        '*************************************************************************
        'Transaksi
        '*************************************************************************
        Select Case AppID
            Case "TKPI001"
                AppForm = New frmDaftarKPI
            Case "TKPI002"
                AppForm = New frmDaftarOJT
        End Select

        '*************************************************************************
        'Laporan
        '*************************************************************************
        Select Case AppID
            Case "LKPI001"
                AppForm = New frmReport
            Case "LKPI002"
                AppForm = New frmRepKPIBulanan
            Case "LKPI003"
                AppForm = New frmRepKPITahunan
            Case "LKPI004"
                AppForm = New frmRepProgressInput
            Case "LKPI005"
                AppForm = New frmRepProgressLengkap
            Case "LKPI006"
                AppForm = New frmRepIPKUnder
            Case "LKPI007"
                AppForm = New frmRepIPKOver
        End Select

        Select Case AppID
            Case "00"
        End Select

        Form = AppForm

    End Function

End Class