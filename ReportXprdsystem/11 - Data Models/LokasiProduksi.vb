Imports Dapper

Namespace HSP.Data
    Public Class Lokasi
        Public Property Kodelokasi As String
        Public Property NamaLokasi As String
        Public Property PrefikKodeTransaksi As String
        Public Property Lokasi As Byte
        Public Property Benang As Byte
        Public Property Roll As Byte
    End Class

    Public Class DaftarLokasi : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As Lokasi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tlokasiproduksi " +
                  "(KodeLokasi, NamaLokasi, PrefikKodeTransaksi, Lokasi, Benang, Roll) " +
                  "VALUES " +
                  "(@KodeLokasi, @NamaLokasi, @PrefikKodeTransaksi, @Lokasi, @Benang, @Roll)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As Lokasi) As Integer
            Dim SQL As String

            SQL = "UPDATE tlokasiproduksi SET " +
                  "KodeLokasi = @KodeLokasi, " +
                  "NamaLokasi = @NamaLokasi, " +
                  "PrefikKodeTransaksi = @PrefikKodeTransaksi, " +
                  "Lokasi = @Lokasi, " +
                  "Benang = @Benang, " +
                  "Roll = @Roll " +
                  "WHERE KodeLokasi = @KodeLokasi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tlokasiproduksi " +
                  "WHERE KodeLokasi = @KodeLokasi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeLokasi = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As Lokasi
            Dim SQL As String

            SQL = "SELECT * FROM tlokasi " +
                  "WHERE KodeLokasi = @KodeLokasi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Lokasi)(SQL, New With {.KodeLokasi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional LokasiBenang As Boolean = False, Optional LokasiRoll As Boolean = False) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeLokasi                                         AS 'Kode', " +
                  "NamaLokasi                                         AS 'Nama Lokasi' " +
                  "FROM tlokasi " +
                  "WHERE CONCAT(KodeLokasi, ' ', NamaLokasi) LIKE @Kriteria "

            If LokasiBenang = 1 Then
                SQL += "AND KodeLokasi IN ('100','101','301','366','510','511','520','521','530','550','900','901')"
            End If

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

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim LokasiBenang As Boolean
            Dim LokasiRoll As Boolean

            If IsNothing(Parameter(0)) Then
                LokasiBenang = False
                LokasiRoll = False
            Else
                LokasiBenang = If(Parameter(0) = 1, True, False)
                LokasiRoll = If(Parameter(0) = 2, True, False)
            End If

            SQL = "SELECT " +
                  "KodeLokasi                                         AS 'Kode', " +
                  "NamaLokasi                                         AS 'Nama Lokasi', " +
                  "PrefikKodeTransaksi                                AS 'Prefik', " +
                  "IF(Lokasi=1,'Produksi',IF(Lokasi=2,'Gudang','-'))  AS 'Lokasi' " +
                  "FROM tlokasiproduksi " +
                  "WHERE CONCAT(KodeLokasi, ' ', NamaLokasi) LIKE @Kriteria "

            If LokasiBenang Then
                SQL += " AND Benang = 1 "
            End If

            If LokasiRoll Then
                SQL += " AND Roll = 1 "
            End If

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

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
            Dim SQL As String

            SQL = "SELECT KodeLokasi FROM tareaproduksi WHERE KodeLokasi = @KodeLokasi LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Locked = If(IsNothing(DBX.Query(SQL, New With {.KodeLokasi = ID}).FirstOrDefault), False, True)
            End Using
        End Function
    End Class
End Namespace

