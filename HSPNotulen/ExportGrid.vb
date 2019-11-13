Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports HSPNotulen.HSP.Data
Public Class ExportGrid
    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date

    Public Sub New(Server As Object)
        _Server = Server
    End Sub
    Public Function _Create(Optional ByVal NoTrx As String = "", Optional ByVal Counting As Integer = 0)
        Try
            Dim Server As New ConnectionInfo
            Dim FileName As String = "Attach\Notulen" & Now.Ticks.ToString & "-" & Counting & ".PDF"

            Dim DBX As Object = New DBConnection(ActiveSession).ConnectionSetting()
            'Setting Koneksi Database
            With Server
                .ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=" + DBX.Server + "; PORT = " + DBX.Port.ToString + "; "
                .DatabaseName = "hspnotulen"
                .UserID = DBX.UserID
                .Password = DBX.Password
            End With

            '-----------------------------------------------------------------------------------------

            Dim RPTObject As New ReportDocument
            RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "Attach\Format.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("NoTransaksi").CurrentValues.AddValue(NoTrx)

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
            MessageBox.Show(ex.Message)
        End Try

    End Function
End Class
