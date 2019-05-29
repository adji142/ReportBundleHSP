Imports Dapper

Namespace HSP.Data
    Public Class Area
        Public Property KodeArea As String
        Public Property NamaArea As String
        Public Property KodeLokasi As String
    End Class

    Public Class DaftarArea : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As Area) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tareaproduksi " +
                  "(KodeArea, NamaArea, KodeLokasi) " +
                  "VALUES " +
                  "(@KodeArea, @NamaArea, @KodeLokasi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As Area) As Integer
            Dim SQL As String

            SQL = "UPDATE tareaproduksi SET " +
                  "KodeArea = @KodeArea, " +
                  "NamaArea = @NamaArea, " +
                  "KodeLokasi = @KodeLokasi " +
                  "WHERE KodeArea = @KodeArea "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tareaproduksi " +
                  "WHERE KodeArea = @KodeArea "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeArea = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As Area
            Dim SQL As String

            SQL = "SELECT * FROM tareaproduksi " +
                  "WHERE KodeArea = @KodeArea "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Area)(SQL, New With {.KodeArea = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeLokasi As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeArea                          AS 'Kode', " +
                  "A.NamaArea                          AS 'Nama Area' " +
                  "FROM tarea A " +
                  "WHERE CONCAT(A.KodeArea,' ',A.NamaArea) LIKE @Kriteria"

            'If KodeLokasi <> "" Then
            '    SQL += " AND A.KodeLokasi = '" + KodeLokasi + "'"
            'End If

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
            Dim KodeLokasi As String = Parameter(0)
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeArea                               AS 'Kode', " +
                  "A.NamaArea                               AS 'Nama Area', " +
                  "B.NamaLokasi                             AS 'Lokasi Produksi' " +
                  "FROM tareaproduksi A " +
                  "LEFT JOIN tlokasiproduksi B ON B.KodeLokasi = A.KodeLokasi " +
                  "WHERE CONCAT(A.KodeArea,' ',A.NamaArea) LIKE @Kriteria"

            If KodeLokasi <> "" Then
                SQL += " AND A.KodeLokasi = '" + KodeLokasi + "'"
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

