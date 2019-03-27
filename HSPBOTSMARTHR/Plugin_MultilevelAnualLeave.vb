Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Dapper
Imports HSPBOTSMARTHR.HSP.Data
Public Class Plugin_MultilevelAnualLeave
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
            " where a.ChatText = '/CUTI_ALL'" +
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
                _NIK = DR("karyawanid").ToString
                _UpdateID = DR("UpdateID").ToString
                Dim exec As New MExecute
                Dim DataSet As DataSet = exec.GetData_CutiAll(_Date.Year, DR("karyawanid").ToString, DR("bagian").ToString, DR("dept").ToString, DR("Superior").ToString)

                If (DataSet.Tables(0).Rows.Count > 0) Then
                    Modul = New Plugin_SendAnualLeaveDetail(_Server)
                    Modul.Execute(_NIK, DR("dept"), DR("bagian"), DR("Superior"))

                    _file = Modul._FileName
                    Dim Title = "Informasi Cuti Subordinat " + DR("NamaKaryawan").ToString + "Per " + _Date
                    If _file <> "ERROR" Then
                        _Server.Response(Title, 0, _file)
                        'MessageBox.Show(Title)
                    Else
                        _Server.Response("Permintaan " + Title + ", Gagal diproses oleh Sistem!. Hubungi Administrator...", 0, _file)
                        'MessageBox.Show("Gagal")
                    End If
                Else
                    _Server.Response("Belum Ada Cuti di Departemen Anda", 0, "")
                    'MessageBox.Show("Belum Ada Cuti di Departemen Anda")
                End If
                _Userid = DR("userid").ToString
            Next
        Else
            _Server.Response("Anda Belum Terdaftar Sebagai Karyawan HardoSoloPlast, Silahkan Hubungi Administrator", 0, "")
            'MessageBox.Show("Anda Belum Terdaftar Sebagai Karyawan HardoSoloPlast, Silahkan Hubungi Administrator")
        End If
        SQL = "UPDATE inbox SET " +
              "flag = 1 " +
              " WHERE chatid = '" + _Userid + "'" +
              " and Chattext = '/CUTI_ALL' and Flag = 0"
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
