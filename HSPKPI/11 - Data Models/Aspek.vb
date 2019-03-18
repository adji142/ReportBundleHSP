Imports Dapper

Namespace HSP.Data
    Public Class HeaderAspek
        Public Property KodeAspek As String
        Public Property NamaAspek As String
        Public Property Bobot As Double
        Public Property KodeKelompok As String
        Public Property KodeBagian As String
        Public Property KodePosisi As String
        Public Property Target As String
        Public Property Keterangan As String
        Public Property NamaBagian As String
        Public Property NamaPosisi As String
        Public Property Tipe As String
        Public Property Jenis As String
        Public Property KodeDept As String
        Public Property NamaDept As String
    End Class

    Public Class DetailAspek
        Public Property KodeAspek As String
        Public Property RowID As Integer
        Public Property Minimal As String
        Public Property Maksimal As String
        Public Property Nilai As Double
    End Class

    Public Class DaftarAspek : Implements IDataLookup
        Private _DBConnection As DBConnection

        Public Enum enumLookupAspek
            DaftarAspek = 1
        End Enum

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddHeader(ByVal Data As HeaderAspek) As Integer
            Dim SQL As String

            SQL = "INSERT INTO taspekheader " +
                  "(KodeAspek, NamaAspek, Bobot, Kodekelompok, KodeBagian, KodePosisi, Target, Keterangan, NamaBagian, NamaPosisi, Tipe, Jenis, KodeDept, NamaDept) " +
                  "VALUES " +
                  "(@KodeAspek, @NamaAspek, @Bobot, @Kodekelompok, @KodeBagian, @KodePosisi, @Target, @Keterangan, @NamaBagian, @NamaPosisi, @Tipe, @Jenis, @KodeDept, @NamaDept)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function AddDetail(ByVal Data As DetailAspek) As Integer
            Dim SQL As String

            SQL = "INSERT INTO taspekdetail " +
                  "(KodeAspek, RowID, Minimal, Maksimal, Nilai) " +
                  "VALUES " +
                  "(@KodeAspek, @RowID, @Minimal, @Maksimal, @Nilai)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderAspek) As Integer
            Dim SQL As String

            SQL = "UPDATE taspekheader SET " +
                  "KodeAspek = @KodeAspek, " +
                  "NamaAspek = @NamaAspek, " +
                  "Bobot = @Bobot, " +
                  "KodeKelompok = @KodeKelompok, " +
                  "KodeBagian = @KodeBagian, " +
                  "KodePosisi = @KodePosisi, " +
                  "NamaBagian = @NamaBagian, " +
                  "NamaPosisi = @NamaPosisi, " +
                  "Target = @Target, " +
                  "Tipe = @Tipe, " +
                  "Jenis = @Jenis, " +
                  "KodeDept = @KodeDept, " +
                  "NamaDept = @NamaDept, " +
                  "Keterangan = @Keterangan " +
                  "WHERE KodeAspek = @KodeAspek "
            Using DBX As IDbConnection = _DBConnection.Connection
                EditHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM taspekheader " +
                  "WHERE KodeAspek = @KodeAspek "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.KodeAspek = ID})
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM taspekdetail " +
                  "WHERE KodeAspek = @KodeAspek "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.KodeAspek = ID})
            End Using
        End Function

        Public Function CopyAspek(ByVal Data As HeaderAspek) As Integer '@namaAspek disi kodeaspek yg baru
            Dim SQL As String

            SQL = "insert into taspekheader select @NamaAspek ,NamaAspek,@KodeKelompok,@KodeDept,@NamaDept,@KodeBagian,@NamaBagian,@KodePosisi,@NamaPosisi,Bobot,Target,Keterangan,Tipe,Jenis from taspekheader where KodeAspek=@KodeAspek"

            Using DBX As IDbConnection = _DBConnection.Connection
                CopyAspek = DBX.Execute(SQL, Data)
            End Using

            SQL = "insert into taspekdetail select @NamaAspek,RowID,Minimal,Maksimal,Nilai from taspekdetail where KodeAspek=@KodeAspek"

            Using DBX As IDbConnection = _DBConnection.Connection
                CopyAspek = DBX.Execute(SQL, Data)
            End Using

        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderAspek
            Dim SQL As String

            SQL = "SELECT * FROM taspekheader " +
                  "WHERE KodeAspek = @KodeAspek "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderAspek)(SQL, New With {.KodeAspek = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindDetail(ByVal ID As String) As HeaderAspek
            Dim SQL As String

            SQL = "SELECT * FROM taspekdetail " +
                  "WHERE KodeAspek = @KodeAspek "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindDetail = DBX.Query(Of HeaderAspek)(SQL, New With {.KodeAspek = ID}).FirstOrDefault
            End Using
        End Function

        Public Function ReadHeader(ByVal Kriteria As String, Optional KodeBagian As String = "", Optional KodeKelompok As String = "", Optional KodePosisi As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeAspek                          AS 'Kode', " +
                  "A.NamaAspek                          AS 'Aspek', " +
                  "A.KodeKelompok                       AS 'Kelompok', " +
                  "A.NamaDept                           AS 'Departemen', " +
                  "A.NamaBagian                         AS 'Bagian', " +
                  "A.NamaPosisi                         AS 'Posisi', " +
                  "A.Bobot                              AS 'Bobot', " +
                  "A.Target                             AS 'Target', " +
                  "A.Keterangan			                AS 'Ket', " +
                  "A.Jenis      		                AS 'Data' " +
                  "FROM taspekheader A " +
                  "WHERE CONCAT(A.KodeAspek,' ',A.NamaAspek) LIKE @Kriteria"

            If KodeBagian <> "" Then
                SQL += " AND A.KodeBagian = '" + KodeBagian + "'"
            End If

            If KodeKelompok <> "" Then
                SQL += " AND A.KodeKelompok = '" + KodeKelompok + "'"
            End If

            If KodePosisi <> "" Then
                SQL += " AND A.KodePosisi = '" + KodePosisi + "'"
            End If

            Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadHeader = DS
            End Using

        End Function

        Public Function ReadDetail(ByVal KodeAspek As String) As DataSet
            Dim SQL As String

            SQL = "SELECT*FROM taspekdetail " +
                  "WHERE KodeAspek = @KodeAspek " +
                  "ORDER BY RowID"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@KodeAspek", KodeAspek)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS
            End Using
        End Function

        Public Function ShowAspek(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT KodeAspek, NamaAspek, Bobot, CONCAT(Target,' ',Keterangan) as Target, Tipe, Jenis FROM taspekheader " +
                  "WHERE CONCAT(kodeposisi,kodeKelompok) like @Kriteria"

            Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ShowAspek = DS
            End Using

        End Function

        Public Function Cek(ByVal ID As String) As HeaderAspek
            Dim SQL As String

            SQL = "SELECT * FROM taspekheader " +
                  "WHERE CONCAT(kodeposisi,kodeKelompok) = @KodeAspek "

            Using DBX As IDbConnection = _DBConnection.Connection
                Cek = DBX.Query(Of HeaderAspek)(SQL, New With {.KodeAspek = ID}).FirstOrDefault
            End Using
        End Function

        Public Function CekData(ByVal ID As String) As HeaderAspek
            Dim SQL As String

            SQL = "SELECT * FROM taspekheader " +
                  "WHERE KodeAspek = @Kriteria "

            Using DBX As IDbConnection = _DBConnection.Connection
                CekData = DBX.Query(Of HeaderAspek)(SQL, New With {.Kriteria = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Range(ByVal ID As String) As HeaderAspek
            Dim SQL As String
            SQL = "select min(Minimal) as Minimal,max(Maksimal) as Maksimal from taspekdetail where KodeAspek=@KodeAspek"

            Using DBX As IDbConnection = _DBConnection.Connection
                Range = DBX.Query(Of HeaderAspek)(SQL, New With {.KodeAspek = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Bobot(ByVal ID As String) As HeaderAspek
            Dim SQL As String
            SQL = "select * from taspekheader where KodeAspek=@KodeAspek"

            Using DBX As IDbConnection = _DBConnection.Connection
                Bobot = DBX.Query(Of HeaderAspek)(SQL, New With {.KodeAspek = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Locked(ByVal ID As String) As Boolean
            Dim SQL As String

            SQL = "SELECT KodeAspek FROM KpiHeader WHERE KodeAspek = @KodeAspek LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Locked = If(IsNothing(DBX.Query(SQL, New With {.KodeAspek = ID}).FirstOrDefault), False, True)
            End Using
        End Function

        Public Function Parameter(ByVal KodeAspek As String) As DataSet
            Dim SQL As String

            SQL = "select DISTINCT Minimal from taspekdetail where KodeAspek=@KodeAspek ORDER BY RowID"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@KodeAspek", KodeAspek)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Parameter = DS
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Lookup As String = Parameter(0)
            Dim KodePosisi As String = Parameter(1)

            Select Case Lookup
                Case enumLookupAspek.DaftarAspek

                    SQL = "SELECT " +
                          "A.KodeAspek                              AS 'Kode', " +
                          "A.NamaAspek                              AS 'Nama Karyawan' " +
                          "FROM taspekheader A " +
                          "WHERE A.kodePosisi = '" + KodePosisi + "' AND " +
                          "CONCAT(A.KodeAspek,' ',A.NamaAspek) LIKE @Kriteria"

                    TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            End Select

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function

    End Class
End Namespace

