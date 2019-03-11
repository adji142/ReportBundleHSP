Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Plugin_SaldoStock
    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date

    Public Sub New(Server As Object)
        _Server = Server
    End Sub
    Public Sub Execute()
        Dim FileName As String = _Create()
        Dim Title = "Laporan Saldo Stock " + vbCrLf + "Per " + _Date.ToString("dd/MM/yyyy hh:mm")
        If FileName <> "ERROR" Then
            _Server.Response(Title, 1, FileName)
        Else
            _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 1, FileName)
        End If
    End Sub

    Public Function _Create()
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            Dim FileName As String = "PRC03" & Now.Ticks.ToString & ".PDF"
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
            RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Rpt_PluginLaporanSaldoStock.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("TANGGAL@").CurrentValues.AddValue(_Date)
            RPTObject.ParameterFields("LOKASI@").CurrentValues.AddValue(100)
            RPTObject.ParameterFields("KODEITEMAWAL@").CurrentValues.AddValue("202.1002")
            RPTObject.ParameterFields("KODEITEMAKHIR@").CurrentValues.AddValue("214.1027")

            'RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'PT.HARDO SOLOPLAST'"
            'RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + GetPeriodDescription(Periode).ToUpper + "'"
            'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'AUTO'"
            RPTObject.ExportToDisk(ExportFormatType.PortableDocFormat, FileName)

            'Dim X As New Form1()
            'X.CrystalReportViewer1.ReportSource = RPTObject
            'X.CrystalReportViewer1.Refresh()

            _Create = FileName
        Catch ex As Exception
            _Create = "ERROR"
        End Try

    End Function
End Class
