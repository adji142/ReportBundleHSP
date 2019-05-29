Imports Dapper

Namespace HSP.Data

    Public Class ItemBenang
        Public Property KodeProduksi As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Packing As Double
        Public Property Unit As Double
        Public Property Timbang As Double
    End Class

    Public Class DaftarItemBenang
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function ReadItem(Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT DISTINCT " +
                  "A.KodeItem                                       AS 'Kode', " +
                  "A.NamaItem                                       AS 'Nama Item' " +
                  "FROM stockbenang A " +
                  "WHERE A.K_NoTimbang = '' AND " +
                  "      CONCAT(A.KodeItem, ' ', " +
                  "             A.NamaItem) LIKE @Kriteria "
            SQL += " ORDER BY A.NamaItem limit 15"

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadItem = DS
            End Using
        End Function

    End Class
End Namespace
