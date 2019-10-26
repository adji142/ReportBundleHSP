Imports Dapper

Namespace HSP.Data
    Public Class PesertaMeeting
        Public Property meetingid As String
        Public Property nik As String
        Public Property NamaPeserta As String
        Public Property StatusHadir As String
    End Class
    Public Class _NotulenHeader
        Public Property RowID As String
        Public Property LineNumber As Integer
        Public Property NoTransaksi As String
        Public Property TglTransaksi As Date
        Public Property PeriodeMetting As String
        Public Property TopikMeeting As String
        Public Property Notulen As String
        Public Property Problem As String
        Public Property JamMulai As String
        Public Property JamSelesai As String
        Public Property StausNotulen As String
        Public Property TX As String
        Public Property TXUpd As String
    End Class
    Public Class _NotulenDetail
        Public Property RowID As String
        Public Property HeaderID As String
        Public Property LineNumber As String
        Public Property FollowUp As String
        Public Property StartDate As Date
        Public Property FinishDate As Date
        Public Property TX As String

    End Class
    Public Class _NotulenSubdetail
        Public Property id As Integer
        Public Property headerid As String
        Public Property NIK As String
        Public Property NamaPIC As String
        Public Property TX As String

    End Class
    Public Class NotulenModels
        Private _DBConnection As DBConnection
        Private _activeSession As SessionApp

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function Add(ByVal Data As Meeting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO ttopik " +
                "(Topik,Periode,KodeDepartement,NamaDepartement,Status) " +
                "VALUES " +
                "(@Topik,@Periode,@KodeDepartement,@NamaDepartement,@Status)"
            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Add_Header(ByVal Data As _NotulenHeader) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headernotulen " +
                "VALUES " +
                "(@RowID,@LineNumber,@NoTransaksi,@TglTransaksi,@PeriodeMetting,@TopikMeeting, " +
                "@Notulen,@Problem,@JamMulai,@JamSelesai,@StausNotulen,@TX,@TXUpd)"
            Using DBX As IDbConnection = _DBConnection.Connection
                Add_Header = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Add_Detail(ByVal Data As _NotulenDetail) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailnotulen " +
                "VALUES " +
                "(@RowID,@HeaderID,@LineNumber,@FollowUp,@StartDate,@FinishDate, @TX)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add_Detail = DBX.Execute(SQL, Data)
            End Using

        End Function
        Public Function Add_SubDetail(ByVal Data As _NotulenSubdetail) As Integer
            Dim SQL As String

            SQL = "INSERT INTO subdetailnotulen " +
                "VALUES " +
                "(@id,@HeaderID,@NIK,@NamaPIC, @TX)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add_SubDetail = DBX.Execute(SQL, Data)
            End Using

        End Function


        Public Function Edit(ByVal Data As Meeting) As Integer
            Dim SQL As String

            SQL = "UPDATE ttopik SET " +
                "Topik = @Topik," +
                "Periode = @Periode," +
                "KodeDepartement = @KodeDepartement," +
                "NamaDepartement = @NamaDepartement," +
                "Status = @Status " +
                "WHERE ID = @ID"
            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM ttopik " +
                  "WHERE topik = @Topik"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.Topik = ID})
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "CAST(K.id AS CHAR)                                  AS 'Kode', " +
                  "K.Topik                                                AS 'Topik', " +
                  "K.Periode                                              AS 'Periode', " +
                  "K.KodeDepartement                                      AS 'Kode Departemen', " +
                  "K.NamaDepartement                                      AS 'Nama Departemen', " +
                  "NULL                                                   AS 'Terakhir Meeting', " +
                  "CASE WHEN K.Status = 1 then 'Aktif' else 'Pasif' end   AS 'Status' " +
                  "FROM ttopik K " +
                  "WHERE CONCAT(K.id, ' ', K.Topik) LIKE @Kriteria "

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using
        End Function
        Public Function Find(ByVal ID As String) As Meeting
            Dim SQL As String

            SQL = "SELECT * FROM ttopik " +
                  "WHERE Topik = @ID"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Meeting)(SQL, New With {.ID = ID}).FirstOrDefault
            End Using
        End Function
        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "1001" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headernotulen " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(11 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
        Public Function Read_peserta(ByVal Kriteria As String, ByVal NoMeeting As String) As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM tpesertameeting where CONCAT(nik,' ',NamaPeserta) LIKE @Kriteria " +
                "AND meetingid = '" + NoMeeting + "'"

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read_peserta = DS
            End Using
        End Function
        'Peserta
        Public Function DeletePeserta(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tpesertameeting " +
                  "WHERE meetingid = @id"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeletePeserta = DBX.Execute(SQL, New With {.id = ID})
            End Using
        End Function
        Public Function Add_Peserta(ByVal Data As PesertaMeeting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tpesertameeting " +
                "(meetingid,nik,NamaPeserta,StatusHadir) " +
                "VALUES " +
                "(@meetingid,@nik,@NamaPeserta,@StatusHadir)"
            Using DBX As IDbConnection = _DBConnection.Connection
                Add_Peserta = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function GetLineNumber(ByVal Table As String, ByVal NoTransaksi As String) As String
            Dim SQL As String
            Dim Temp, Nomor As String
            Using DBX As IDbConnection = _DBConnection.Connection()

                SQL = "SELECT COALESCE(MAX(LineNumber),0) AS Line FROM " + Table + " " +
                      "WHERE NoTransaksi = @NoTransaksi "

                Temp = (DBX.Query(SQL, New With {.NoTransaksi = NoTransaksi}).FirstOrDefault.Line + 1).ToString
                Nomor = Temp
                '------------------------------------------------------------------------------------------

            End Using
            GetLineNumber = Nomor

        End Function


        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function


    End Class
End Namespace
