Imports Dapper

Namespace HSP.Data
    Public Class PolaMediaTimbang
        Public Property KodePola As String
        Public Property NamaPola As String
        Public Property KodeLokasi As String
        Public Property KodeMedia1 As String
        Public Property FlagJumlahMedia1 As Byte
        Public Property JumlahDefault1 As Double
        Public Property KodeMedia2 As String
        Public Property FlagJumlahMedia2 As Byte
        Public Property JumlahDefault2 As Double
        Public Property KodeMedia3 As String
        Public Property FlagJumlahMedia3 As Byte
        Public Property JumlahDefault3 As Double
    End Class

    Public Class DaftarPolaMediaTimbang : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection
        End Sub

        Public Function Add(ByVal Data As PolaMediaTimbang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tpolamediatimbang " +
                  "(KodePola, NamaPola, KodeLokasi, KodeMedia1, FlagJumlahMedia1, JumlahDefault1, KodeMedia2, FlagJumlahMedia2, JumlahDefault2, KodeMedia3, FlagJumlahMedia3, JumlahDefault3) " +
                  "VALUES " +
                  "(@KodePola, @NamaPola, @KodeLokasi, @KodeMedia1, @FlagJumlahMedia1, @JumlahDefault1, @KodeMedia2, @FlagJumlahMedia2, @JumlahDefault2, @KodeMedia3, @FlagJumlahMedia3, @JumlahDefault3)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As PolaMediaTimbang) As Integer
            Dim SQL As String

            SQL = "UPDATE tpolamediatimbang SET " +
                  "KodePola = @KodePola, " +
                  "NamaPola = @NamaPola, " +
                  "KodeLokasi = @KodeLokasi, " +
                  "KodeMedia1 = @KodeMedia1, " +
                  "FlagJumlahMedia1 = @FlagJumlahMedia1, " +
                  "JumlahDefault1 = @JumlahDefault1, " +
                  "KodeMedia2 = @KodeMedia2, " +
                  "FlagJumlahMedia2 = @FlagJumlahMedia2, " +
                  "JumlahDefault2 = @JumlahDefault2, " +
                  "KodeMedia3 = @KodeMedia3, " +
                  "FlagJumlahMedia3 = @FlagJumlahMedia3, " +
                  "JumlahDefault3 = @JumlahDefault3 " +
                  "WHERE KodePola = @KodePola"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tpolamediatimbang " +
                  "WHERE KodePola = @KodePola "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodePola = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As PolaMediaTimbang
            Dim SQL As String

            SQL = "SELECT * FROM tpolamediatimbang " +
                  "WHERE KodePola = @KodePola "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of PolaMediaTimbang)(SQL, New With {.KodePola = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeLokasi As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodePola                                   AS 'Kode', " +
                  "A.NamaPola                                   AS 'Nama Pola', " +
                  "B.NamaLokasi                                 AS 'Lokasi Produksi', " +
                  "C.NamaMedia                                  AS 'Media Timbang 1', " +
                  "IF(A.FlagJumlahMedia1=1,'Ya','Tidak')        AS 'Produksi', " +
                  "JumlahDefault1                               AS 'Default 1', " +
                  "D.NamaMedia                                  AS 'Media Timbang 2', " +
                  "IF(A.FlagJumlahMedia2=1,'Ya','Tidak')        AS 'Produksi', " +
                  "JumlahDefault2                               AS 'Default 2', " +
                  "E.NamaMedia                                  AS 'Media Timbang 3', " +
                  "IF(A.FlagJumlahMedia1=1,'Ya','Tidak')        AS 'Produksi', " +
                  "JumlahDefault3                               AS 'Default 3' " +
                  "FROM tpolamediatimbang A " +
                  "LEFT JOIN tlokasiproduksi B ON B.KodeLokasi = A.KodeLokasi " +
                  "LEFT JOIN tmediatimbang C ON C.KodeMedia = A.KodeMedia1 " +
                  "LEFT JOIN tmediatimbang D ON D.KodeMedia = A.KodeMedia2 " +
                  "LEFT JOIN tmediatimbang E ON E.KodeMedia = A.KodeMedia3 " +
                  "WHERE CONCAT(KodePola, ' ', NamaPola) LIKE @Kriteria "

            If KodeLokasi <> "" Then
                SQL += " AND A.KodeLokasi = '" + KodeLokasi + "'"
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
            Dim KodeLokasi As String = Parameter(0)

            SQL = "SELECT " +
                  "A.KodePola                                   AS 'Kode', " +
                  "A.NamaPola                                   AS 'Nama Pola', " +
                  "B.NamaLokasi                                 AS 'Lokasi Produksi', " +
                  "C.NamaMedia                                  AS 'Media Timbang 1', " +
                  "IF(A.FlagJumlahMedia1=1,'Ya','Tidak')        AS 'Produksi', " +
                  "JumlahDefault1                               AS 'Default 1', " +
                  "D.NamaMedia                                  AS 'Media Timbang 2', " +
                  "IF(A.FlagJumlahMedia2=1,'Ya','Tidak')        AS 'Produksi', " +
                  "JumlahDefault2                               AS 'Default 2', " +
                  "E.NamaMedia                                  AS 'Media Timbang 3', " +
                  "IF(A.FlagJumlahMedia1=1,'Ya','Tidak')        AS 'Produksi', " +
                  "JumlahDefault3                               AS 'Default 3' " +
                  "FROM tpolamediatimbang A " +
                  "LEFT JOIN tlokasiproduksi B ON B.KodeLokasi = A.KodeLokasi " +
                  "LEFT JOIN tmediatimbang C ON C.KodeMedia = A.KodeMedia1 " +
                  "LEFT JOIN tmediatimbang D ON D.KodeMedia = A.KodeMedia2 " +
                  "LEFT JOIN tmediatimbang E ON E.KodeMedia = A.KodeMedia2 " +
                  "WHERE CONCAT(KodePola, ' ', NamaPola) LIKE @Kriteria "

            If KodeLokasi <> "" Then
                SQL += " AND A.KodeLokasi = '" + KodeLokasi + "'"
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
            Locked = False
        End Function
    End Class
End Namespace

