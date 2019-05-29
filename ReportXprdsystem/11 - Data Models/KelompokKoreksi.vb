Imports Dapper

Namespace HSP.Data
    Public Class KelompokKoreksi
        Public Property KodeKelompok As String
        Public Property NamaKelompok As String
        Public Property Kelompok As Byte
        Public Property KodeProduksi As Byte
        Public Property KodeLokasi As String
    End Class

    Public Class DaftarKelompokKoreksi : Implements IDataLookup

        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KelompokKoreksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tkelompokkoreksi " +
                  "(KodeKelompok, NamaKelompok, Kelompok, KodeProduksi, KodeLokasi) " +
                  "VALUES " +
                  "(@KodeKelompok, @NamaKelompok, @Kelompok, @KodeProduksi, @KodeLokasi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As KelompokKoreksi) As Integer
            Dim SQL As String

            SQL = "UPDATE tkelompokkoreksi SET " +
                  "KodeKelompok = @KodeKelompok, " +
                  "NamaKelompok = @NamaKelompok, " +
                  "Kelompok = @Kelompok, " +
                  "KodeProduksi =@KodeProduksi, " +
                  "KodeLokasi = @KodeLokasi " +
                  "WHERE KodeKelompok = @KodeKelompok "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tkelompokkoreksi " +
                  "WHERE KodeKelompok = @KodeKelompok "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeKelompok = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As KelompokKoreksi
            Dim SQL As String

            SQL = "SELECT * FROM tkelompokkoreksi " +
                  "WHERE KodeKelompok = @KodeKelompok "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of KelompokKoreksi)(SQL, New With {.KodeKelompok = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQl As String

            SQl = "SELECT " +
                  "A.KodeKelompok                             AS 'Kode', " +
                  "A.NamaKelompok                             AS 'Nama Kelompok', " +
                  "IF(A.Kelompok=1,'ROLL', " +
                  "IF(A.Kelompok=2,'BALL', " +
                  "IF(A.Kelompok=3,'BENANG MULTIFILAMENT', " +
                  "IF(A.Kelompok=4,'BENANG EXTRUDER',''))))   AS 'Kelompok', " +
                  "IF(A.KodeProduksi=1,'YA','TIDAK')          AS 'Batch' " +
                  "FROM tkelompokkoreksi A " +
                  "WHERE CONCAT(A.KodeKelompok, ' ', A.NamaKelompok) LIKE @Kriteria " +
                  "GROUP BY A.KodeKelompok, A.NamaKelompok, A.Kelompok, A.KodeProduksi "

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQl, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using
        End Function

        Public Function ReadLokasi(ByVal KodeKelompok As String) As DataSet
            Dim SQl As String

            SQl = "SELECT " +
                  "A.KodeLokasi                     AS 'KodeLokasi' , " +
                  "B.NamaLokasi                     AS 'NamaLokasi' " +
                  "FROM tkelompokkoreksi A " +
                  "LEFT JOIN tlokasiproduksi B ON B.KodeLokasi = A.KodeLokasi " +
                  "WHERE KodeKelompok = '" + KodeKelompok + "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQl, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadLokasi = DS
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQl As String

            SQl = "SELECT " +
                  "A.KodeKelompok                             AS 'Kode', " +
                  "A.NamaKelompok                             AS 'Nama Kelompok', " +
                  "IF(A.Kelompok=1,'ROLL', " +
                  "IF(A.Kelompok=2,'BALL', " +
                  "IF(A.Kelompok=3,'BENANG MULTIFILAMENT', " +
                  "IF(A.Kelompok=4,'BENANG EXTRUDER',''))))   AS 'Kelompok', " +
                  "IF(A.KodeProduksi=1,'YA','TIDAK')          AS 'Batch', " +
                  "B.NamaLokasi                               AS 'Lokasi Koreksi' " +
                  "FROM tkelompokkoreksi A " +
                  "LEFT JOIN tlokasiproduksi B ON B.KodeLokasi = A.KodeLokasi " +
                  "WHERE CONCAT(KodeKelompok, ' ', NamaKelompok) LIKE @Kriteria "

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQl, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function
    End Class
End Namespace

