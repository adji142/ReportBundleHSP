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
        oApp(0) = "7701"
        oApp(1) = "Laporan Pengeluaran Bon Sparepart"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "7702"
        oApp(1) = "Laporan Pengeluaran Penerimaan Retur Sparepart"
        '-----------------------------------------------------------------------------------
        oApp = oDT.Rows.Add()
        oApp(0) = "7703"
        oApp(1) = "Laporan Distribusi Sparepart"
        '-----------------------------------------------------------------------------------

        oDS.AcceptChanges()
        GetAppModule = oDT

    End Function

    'Application Modul 
    Public Function Form(ByVal AppID As String, ByVal Session As Object) As Object
        Dim AppForm As Object = Nothing

        'ActiveSession.KodePerusahaan = Session.KodePerusahaan
        'ActiveSession.NamaPerusahaan = Session.NamaPerusahaan
        'ActiveSession.Alamat1 = Session.Alamat1
        'ActiveSession.Alamat2 = Session.Alamat2
        'ActiveSession.Kota = Session.Kota
        'ActiveSession.Propinsi = Session.Propinsi
        'ActiveSession.NoTelpon = Session.NoTelpon
        'ActiveSession.NoFax = Session.NoFax
        'ActiveSession.KodeUser = Session.KodeUser
        'ActiveSession.NamaUser = Session.NamaUser
        'ActiveSession.HakAkses = Session.HakAkses
        'ActiveSession.Supervisor = Session.Supervisor
        'ActiveSession.HakUbahTanggal = Session.HakUbahTanggal
        'ActiveSession.DBConnection = Session.DBConnection

        '*************************************************************************
        'Master Data
        '*************************************************************************
        Select Case AppID
            Case "7701"
                AppForm = New FrmRPT_7701_PengeluaranBarang
            Case "7702"
                AppForm = New FrmRPT_7702_PenerimaanBarangRetur
            Case "7703"
                AppForm = New FrmRPT_7702_PenerimaanBarangRetur
        End Select

        Select Case AppID
            Case "00"
        End Select

        Form = AppForm

    End Function

End Class