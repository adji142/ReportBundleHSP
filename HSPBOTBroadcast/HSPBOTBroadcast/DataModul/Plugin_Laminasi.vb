Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Plugin_Laminasi
    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date
    Public FileName As String = ""
    Public Sub New(Server As Object)
        _Server = Server
    End Sub
    Public Sub Execute()
        Dim FileName As String = _Create()
        Dim Title = "LAPORAN HASIL LAMINASI" + vbCrLf + "Per " + _Date.ToString("dd/MM/yyyy hh:mm")
        If FileName <> "ERROR" Then
            _Server.Response(Title, 1, FileName)
        Else
            _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 1, FileName)
        End If
    End Sub
    Public Function _Create()
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            FileName = "Lap.HasilLaminasi" & Now.Ticks.ToString & ".PDF"
            Dim Periode As String = GetPeriod(_Date)

            'Setting Koneksi Database
            With Server
                .ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=192.168.1.112; PORT = 3306; "
                .DatabaseName = "hspproduction"
                .UserID = "root"
                .Password = "dbxroothsp123"
            End With
            '-----------------------------------------------------------------------------------------

            Dim RPTObject As New ReportDocument
            'RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\MKTStockKarung.rpt")
            RPTObject.Load("C:\BOT\rpt310105_Laminating.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(Date.Now.AddDays(-1))
            RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(Date.Now)
            RPTObject.ParameterFields("KodeGrup").CurrentValues.AddValue("")
            RPTObject.ParameterFields("KodeShift").CurrentValues.AddValue("")

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
