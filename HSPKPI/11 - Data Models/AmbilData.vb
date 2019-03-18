Imports Dapper

Namespace HSP.Data
    Public Class AmbilData
        Public Property ID As String
        Public Property Keterangan As String
    End Class

    Public Class DaftarData
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "ID                                         AS 'ID', " +
                  "Keterangan                                 AS 'Keterangan' " +
                  "FROM tAmbilData " +
                  "WHERE CONCAT(ID, ' ', Keterangan) LIKE @Kriteria "

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


    End Class
End Namespace

