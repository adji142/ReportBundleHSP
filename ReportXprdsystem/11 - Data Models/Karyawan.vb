Imports Dapper

Namespace HSP.Data
    Public Class Karyawan
        Public Property KodeKaryawan As String
        Public Property NamaKaryawan As String
        Public Property KodeUnit As String
        Public Property Kelompok As Byte
        Public Property Aktif As Byte
    End Class

    Public Class DaftarKaryawan : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As Karyawan) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tkaryawan " +
                  "(KodeKaryawan, NamaKaryawan, Kodeunit, Kelompok, Aktif) " +
                  "VALUES " +
                  "(@KodeKaryawan, @NamaKaryawan, @Kodeunit, @Kelompok, @Aktif)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As Karyawan) As Integer
            Dim SQL As String

            SQL = "UPDATE tkaryawan SET " +
                  "KodeKaryawan = @KodeKaryawan, " +
                  "NamaKaryawan = @NamaKaryawan, " +
                  "Kodeunit = @Kodeunit, " +
                  "Kelompok = @Kelompok, " +
                  "Aktif = @Aktif " +
                  "WHERE KodeKaryawan = @KodeKaryawan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tkaryawan " +
                  "WHERE KodeKaryawan = @KodeKaryawan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeKaryawan = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As Karyawan
            Dim SQL As String

            SQL = "SELECT * FROM tkaryawan " +
                  "WHERE KodeKaryawan = @KodeKaryawan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Karyawan)(SQL, New With {.KodeKaryawan = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Find(ByVal ID As String, KodeUnit As String) As Karyawan
            Dim SQL As String

            SQL = "SELECT * FROM tkaryawan " +
                  "WHERE KodeKaryawan = @KodeKaryawan AND KodeUnit = @KodeUnit"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Karyawan)(SQL, New With {.KodeKaryawan = ID, .KodeUnit = KodeUnit}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeKaryawan                                  AS 'Kode', " +
                  "A.NamaKaryawan                                  AS 'Nama Karyawan', " +
                  "B.NamaUnit                                      AS 'Unit Produksi', " +
                  "IF(A.Kelompok=1, 'SUPERVISOR', " +
                  "IF(A.Kelompok=2, 'KEPALA REGU', " +
                  "IF(A.Kelompok=3, 'OPERATOR', '-')))             AS 'Level', " +
                  "IF(A.Aktif=1, 'AKTIF', 'NON AKTIF')             AS 'Status' " +
                  "FROM tkaryawan A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "WHERE CONCAT(A.KodeKaryawan, ' ', A.NamaKaryawan) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += "AND A.KodeUnit = '" + KodeUnit + "' "
            End If

            Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%")

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

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim KodeUnit As String = Parameter(0)

            SQL = "SELECT " +
                  "A.KodeKaryawan                                  AS 'Kode', " +
                  "A.NamaKaryawan                                  AS 'Nama Karyawan', " +
                  "B.NamaUnit                                      AS 'Unit Produksi', " +
                  "IF(A.Kelompok=1, 'SUPERVISOR', " +
                  "IF(A.Kelompok=2, 'KEPALA REGU', " +
                  "IF(A.Kelompok=3, 'OPERATOR', '-')))             AS 'Level', " +
                  "IF(A.Aktif=1, 'AKTIF', 'NON AKTIF')             AS 'Status' " +
                  "FROM tkaryawan A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "WHERE CONCAT(A.KodeKaryawan, ' ', A.NamaKaryawan) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += "AND A.KodeUnit = '" + KodeUnit + "' "
            End If

            TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function

        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function
    End Class
End Namespace

