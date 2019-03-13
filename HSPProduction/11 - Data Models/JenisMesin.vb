Imports Dapper

Namespace HSP.Data
    Public Class JenisMesin
        Public Property KodeUnit As String
        Public Property KodeJenis As String
        Public Property NamaJenis As String
    End Class

    Public Class DaftarJenisMesin : Implements IDataLookup

        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As JenisMesin) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tjenismesin " +
                  "(KodeUnit, KodeJenis, NamaJenis) " +
                  "VALUES " +
                  "(@KodeUnit, @KodeJenis, @NamaJenis)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As JenisMesin) As Integer
            Dim SQL As String

            SQL = "UPDATE tjenismesin SET " +
                  "KodeUnit = @KodeUnit, KodeJenis = @KodeJenis, NamaJenis = @NamaJenis " +
                  "WHERE KodeJenis = @KodeJenis " 

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tjenismesin " +
                  "WHERE KodeJenis = @KodeJenis "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeJenis = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As JenisMesin
            Dim SQL As String

            SQL = "SELECT * FROM tjenismesin " +
                  "WHERE KodeJenis = @KodeJenis "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of JenisMesin)(SQL, New With {.KodeJenis = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeJenis                              'Kode', " +
                  "A.NamaJenis                              'Jenis Mesin', " +
                  "B.NamaUnit                               'Unit Produksi' " +
                  "FROM tjenismesin A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "WHERE CONCAT(A.KodeJenis, ' ', A.NamaJenis) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "' "
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

            Dim KodeUnit As String = Parameter(0)

            SQL = "SELECT " +
                  "A.KodeJenis                              'Kode', " +
                  "A.NamaJenis                              'Jenis Mesin', " +
                  "B.NamaUnit                               'Unit Produksi' " +
                  "FROM tjenismesin A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "WHERE CONCAT(A.KodeJenis, ' ', A.NamaJenis) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "' "
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

