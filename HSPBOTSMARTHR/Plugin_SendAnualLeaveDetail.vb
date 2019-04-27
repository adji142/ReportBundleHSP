Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Dapper
Imports HSPBOTSMARTHR.HSP.Data
Public Class Plugin_SendAnualLeaveDetail
    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date
    Public _NIK As String
    Public _Userid As String
    Public _FileName As String = ""
    Private _DBConnection As New DBConnection
    'Private
    Dim _Dept As String = ""
    Dim _Bag As String = ""
    Dim _Superior As String = ""
    Public Sub New(Server As Object)
        _Server = Server
    End Sub
    Public Sub Execute(ByVal nik As String, ByVal dept As String, ByVal Bag As String, ByVal Superior As String)
        _NIK = nik
        _Dept = dept
        _Bag = Bag
        _Superior = Superior
        Dim FileName As String = _Create()
        Dim Title = "Generating.."
        If FileName <> "ERROR" Then
            _Server.Response(Title, 1, FileName)
            'MessageBox.Show(Title)
            _FileName = FileName
        Else
            _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 1, FileName)
            'MessageBox.Show("Gagal")
        End If
    End Sub

    Public Function _Create()
        Dim FileName As String
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            If (_Bag <> "" And _Dept <> "" And _Superior <> "") Then
                FileName = "CUTI_ALL" & Now.Ticks.ToString & ".PDF"
            Else
                FileName = "CUTI" & Now.Ticks.ToString & ".PDF"
            End If
            Dim Periode As String = GetPeriod(_Date)

            'Setting Koneksi Database
            With Server
                '.ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=192.168.1.112; PORT = 3306; "
                .ServerName = "Driver={SQL Server};Server=192.168.1.113; " 'Database=myDataBase;Uid=myUsername;Pwd=myPassword"
                .DatabaseName = "MIP_HARDO"
                .UserID = "sa"
                .Password = "h4rd0MIP"
            End With
            '-----------------------------------------------------------------------------------------

            Dim RPTObject As New ReportDocument
            If (_Bag <> "" And _Dept <> "" And _Superior <> "") Then
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Plugin_PemakaianCutiHirarki.rpt")
            Else
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Plugin_PemakaianCuti.rpt")
            End If

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("@TAHUN").CurrentValues.AddValue(_Date.Year)
            RPTObject.ParameterFields("@EmpNo").CurrentValues.AddValue(_NIK)
            If (_Bag <> "" And _Dept <> "" And _Superior <> "") Then
                RPTObject.ParameterFields("@dept").CurrentValues.AddValue(_Dept)
                RPTObject.ParameterFields("@Bag").CurrentValues.AddValue(_Bag)
                RPTObject.ParameterFields("@Superior").CurrentValues.AddValue(_Superior)
            End If
            RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'PT.HARDO SOLOPLAST'"
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + GetPeriodDescription(Periode).ToUpper + "'"
            'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'AUTO'"
            RPTObject.ExportToDisk(ExportFormatType.PortableDocFormat, FileName)

            _Create = FileName
        Catch ex As Exception
            _Create = ex.Message
        End Try

    End Function

End Class
