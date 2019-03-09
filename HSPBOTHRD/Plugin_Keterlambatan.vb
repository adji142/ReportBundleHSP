Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Plugin_Keterlambatan

    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date

    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Sub Execute()
        Dim FileName As String = _Create()
        Dim Title = "Laporan Keterlambatan" + vbCrLf + "Per " + _Date.ToString("dd/MM/yyyy hh:mm")
        If FileName <> "ERROR" Then
            _Server.Response(Title, 1, FileName)
        Else
            _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 1, FileName)
        End If
    End Sub

    Public Function _Create()
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            Dim FileName As String = "HRD04" & Now.Ticks.ToString & ".PDF"
            Dim Periode As String = GetPeriode(_Date)
            Dim tglAwal As String = Format(Stod("26/" & Format(DateAdd(DateInterval.Month, -1, _Date), "MM/yyyy")), "yyyy/MM/dd")
            Dim tglAkhir As String = Format(Stod("25/" & Format(_Date, "MM/yyyy")), "yyyy/MM/dd")

            'Setting Koneksi Database
            With Server
                '.ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=192.168.1.112; PORT = 3306; "
                .ServerName = "Driver={SQL Server};Server=192.168.1.115; " 'Database=myDataBase;Uid=myUsername;Pwd=myPassword"
                .DatabaseName = "MIP_HARDO"
                .UserID = "sa"
                .Password = "H@Rd0Admin2017@"
            End With
            '-----------------------------------------------------------------------------------------

            Dim RPTObject As New ReportDocument
            RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\HRDKeterlambatan.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(tglAwal)
            RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(tglAkhir)

            RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'PT.HARDO SOLOPLAST'"
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + GetPeriodDescription(Periode).ToUpper + "'"
            'RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + GetPeriodDescription(Periode).ToUpper + "'"
            'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'AUTO'"
            RPTObject.ExportToDisk(ExportFormatType.PortableDocFormat, FileName)

            _Create = FileName
        Catch ex As Exception
            _Create = "ERROR"
        End Try

    End Function

End Class
