Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Dapper
Imports HSPBOTSMARTHR.HSP.Data
Public Class Plugin_CutiPerUser
    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date
    Public _NIK As String = ""
    Public _Userid As String
    Public _Rs As String = ""
    Public _file As String = ""
    Dim _UpdateID As String
    Private _DBConnection As New DBConnection
    Public Sub New(Server As Object)
        _Server = Server
    End Sub
    Public Sub Execute()
        'Start Check for response
        Dim DS As New DataSet
        Dim DT As DataTable
        Dim DR As DataRow
        Dim SQL As String
        Dim Modul As Object = Nothing

        SQL = "select b.*,a.UpdateID from inbox a" +
            " inner join userkaryawan b on a.ChatID = b.UserID " +
            " inner join outbox c on c.UpdateID = a.UpdateID " +
            " where a.ChatText = '/CUTI'" +
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
                'Console.WriteLine(DR("ColName"))
                _NIK = DR("karyawanid").ToString
                _UpdateID = DR("UpdateID").ToString
                Dim exec As New MExecute
                Dim DataSet As DataSet = exec.GetData(_Date.Year, DR("karyawanid").ToString)

                'fill column
                If (DataSet.Tables(1).Rows.Count > 0) Then
                    Dim FileName As String = ""
                    Dim Title = "Informasi Sisa Cuti Anda " + vbCrLf + "Per " + _Date.ToString("dd/MM/yyyy hh:mm") + vbCrLf +
                        "NIK        : " + DataSet.Tables(1).Rows(0)("EmpNo").ToString() + vbCrLf +
                        "Nama       : " + DataSet.Tables(1).Rows(0)("FullName").ToString() + vbCrLf +
                        "Bagian     : " + DataSet.Tables(1).Rows(0)("NMDEPT").ToString() + vbCrLf +
                        "Saldo Awal : " + DataSet.Tables(1).Rows(0)("Quota").ToString() + vbCrLf +
                        "Pemakaian  : " + DataSet.Tables(1).Rows(0)("totalpakai").ToString() + vbCrLf +
                        "Saldo Akhir: " + DataSet.Tables(1).Rows(0)("sisa").ToString() + vbCrLf +
                        "Detail Terlampir"
                    _Rs = "Success"
                    If FileName <> "ERROR" Then
                        _Server.Response(Title, 0, FileName)

                        Modul = New Plugin_SendAnualLeaveDetail(_Server)
                        Modul.Execute(_NIK)
                        _file = Modul._FileName
                        '_Server.Response(_file, 0)
                        'MessageBox.Show(Title)
                    Else
                        _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 0, FileName)
                        'MessageBox.Show("Gagal")
                    End If
                Else
                    Dim Title = "Anda Belum Memiliki Saldo Cuti.."
                    _Server.Response(Title, 0, "")
                    'MessageBox.Show(Title)
                End If
                _Userid = DR("userid").ToString
            Next
        Else
            _Server.Response("Anda Belum Terdaftar Sebagai Karyawan HardoSoloPlast, Silahkan Hubungi Administrator", 0, "")

        End If
            SQL = "UPDATE inbox SET " +
                  "flag = 1 " +
                  " WHERE chatid = '" + _Userid + "'" +
                  " and Chattext = '/CUTI' and Flag = 0"
            Try
                Using DBX As IDbConnection = _DBConnection.Connection
                    DBX.Execute(SQL)
                End Using
            Catch ex As Exception
            _Server.Response(ex.Message, 0, "")
        End Try
        'SQL = "Update outbox set status = 0" +
        '       " where chatid = '" + _Userid + "'" +
        '      " and updateid = '" + _UpdateID + "' and Chattext = 'Generating..'"

        SQL = "update outbox set status = 0 where Filename = '" + _file + "' and Chattext = 'Generating..'"
        Try
            Using DBX As IDbConnection = _DBConnection.Connection
                DBX.Execute(SQL)
            End Using
        Catch ex As Exception
            _Server.Response(ex.Message, 0, "")
        End Try
    End Sub

    Public Function _Create()
        Try
            Dim Server As New CrystalDecisions.Shared.ConnectionInfo
            Dim FileName As String = "CUTI" & Now.Ticks.ToString & ".PDF"
            Dim Periode As String = GetPeriod(_Date)

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
            RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Plugin_PemakaianCuti.rpt")

            Dim DataTable As Table
            For Each DataTable In RPTObject.Database.Tables
                DataTable.LogOnInfo.ConnectionInfo = Server
                DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
            Next

            RPTObject.ParameterFields("@TAHUN").CurrentValues.AddValue(_Date.Year)
            RPTObject.ParameterFields("@EmpNo").CurrentValues.AddValue(_NIK)

            RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'PT.HARDO SOLOPLAST'"
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + GetPeriodDescription(Periode).ToUpper + "'"
            'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'AUTO'"
            RPTObject.ExportToDisk(ExportFormatType.PortableDocFormat, FileName)

            _Create = FileName
        Catch ex As Exception
            _Create = "ERROR"
        End Try

    End Function
End Class
