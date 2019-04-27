Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Plugin_SaldoStockKarung

    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date
    Public FileName As String = ""

    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Sub Execute()
        Dim FileName As String = _Create()
        Dim Title = "Laporan Saldo Stock Karung" + vbCrLf + "Per " + _Date.ToString("dd/MM/yyyy hh:mm")
        If FileName <> "ERROR" Then
            _Server.Response(Title, 1, FileName)
        Else
            _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 1, FileName)
        End If
    End Sub

    Public Function _Create()
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            FileName = "SALDOSTOCK" & Now.Ticks.ToString & ".PDF"
            Dim Periode As String = GetPeriod(_Date)

            'Setting Koneksi Database
            With Server
                .ServerName = "192.168.1.222:30015"
                .DatabaseName = "HARDO_LIVE"
                .UserID = "SYSTEM"
                .Password = "sys825050SYS"
            End With
            '-----------------------------------------------------------------------------------------

            Dim RPTObject As New ReportDocument
            'RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\MKTStockKarung.rpt")
            RPTObject.Load("C:\BOT\MKTStockKarung.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            'RPTObject.ParameterFields("Periode").CurrentValues.AddValue(Periode)

            RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'PT.HARDO SOLOPLAST'"
            'RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + GetPeriodDescription(Periode).ToUpper + "'"
            'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'AUTO'"
            RPTObject.ExportToDisk(ExportFormatType.PortableDocFormat, FileName)

            _Create = FileName
        Catch ex As Exception
            _Create = "ERROR"
        End Try

    End Function

End Class
