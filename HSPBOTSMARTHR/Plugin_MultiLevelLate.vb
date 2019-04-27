Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Dapper
Imports HSPBOTSMARTHR.HSP.Data
Public Class Plugin_MultiLevelLate
    Dim _Server As Object = Nothing
    'GlobalVar
    Dim _EmpNo As String = ""
    Dim _Dept As String = ""
    Dim _Bag As String = ""
    Dim _Superior As String = ""

    Dim _Date As Date = Now.Date
    Public _Userid As String
    Private _DBConnection As New DBConnection
    Public Sub New(Server As Object)
        _Server = Server
    End Sub
    Public Sub Execute()
        Dim DS As New DataSet
        Dim DT As DataTable
        Dim DR As DataRow
        Dim SQL As String
        Dim Modul As Object = Nothing

        SQL = "select b.*,a.UpdateID from inbox a" +
            " inner join userkaryawan b on a.ChatID = b.UserID " +
            " inner join outbox c on c.UpdateID = a.UpdateID " +
            " where a.ChatText = '/LATE_ALL'" +
            " and a.Flag = 0"
        Try
            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")
            End Using
        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            _Server.Response(ex.Message, 0, "")
        End Try

        If (DS.Tables(0).Rows.Count > 0) Then
            DT = DS.Tables(0)

            For Each DR In DT.Rows
                Dim exec As New MExecute
                Dim DataSet As DataSet = exec.GetData_LateAll(DR("karyawanid").ToString, DR("dept").ToString, DR("bagian").ToString, DR("Superior").ToString)

                If (DataSet.Tables(0).Rows.Count > 0) Then
                    _EmpNo = DR("karyawanid")
                    _Dept = DR("dept")
                    _Bag = DR("bagian")
                    _Superior = DR("Superior")
                    Dim FileName As String = _Create()
                    Dim Title = "Informasi Keterlambatan Subordinat " + DR("NamaKaryawan").ToString + " " + vbCrLf + "Per " + _Date.ToString("dd/MM/yyyy hh:mm")

                    If FileName <> "ERROR" Then
                        _Server.Response(Title, 1, FileName)
                        'Console.WriteLine(Title)
                    Else
                        _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 1, FileName)
                        'Console.WriteLine("Gagal")
                    End If
                Else
                    Dim Title = "Apresiasi Besar!!. Anda Belum Pernah Terlambat Sampai Sekarang"
                    _Server.Response(Title, 0, "")
                    'Console.WriteLine("Ga Telat")
                End If
                _Userid = DR("userid").ToString
            Next
        Else
            _Server.Response("Anda Belum Terdaftar sebagai pemakai layanan ini", 0, "Silahkan Hubungi administrator")
            'Console.WriteLine("Blm Terdaftar")
        End If
        SQL = "UPDATE inbox SET " +
                  "flag = 1 " +
                  " WHERE chatid = '" + _Userid + "'" +
                  " and Chattext = '/LATE_ALL' and Flag = 0"
        Try
            Using DBX As IDbConnection = _DBConnection.Connection
                DBX.Execute(SQL)
            End Using
        Catch ex As Exception
            _Server.Response(ex.Message, 0, "")
            'Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Function _Create()
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            Dim FileName As String = "Keterlambatan" & Now.Ticks.ToString & ".PDF"

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
            RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Plugin_KeterlambatanPerKryHirarki.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("@EmpNo").CurrentValues.AddValue(_EmpNo)
            RPTObject.ParameterFields("@dept").CurrentValues.AddValue(_Dept)
            RPTObject.ParameterFields("@Bag").CurrentValues.AddValue(_Bag)
            RPTObject.ParameterFields("@Superior").CurrentValues.AddValue(_Superior)

            RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'PT.HARDO SOLOPLAST'"
            'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'AUTO'"
            RPTObject.ExportToDisk(ExportFormatType.PortableDocFormat, FileName)

            _Create = FileName
        Catch ex As Exception
            _Create = ex.Message
        End Try

    End Function
End Class
