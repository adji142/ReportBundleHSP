Imports Dapper

Namespace HSP.Data


    Public Class ItemRoll
        Public Property KodeProduksi As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Packing As Double
        Public Property Unit As Double
        Public Property Timbang As Double
        Public Property UnitProduksi As String
        Public Property LokasiProduksi As String
    End Class

    Public Class DaftarItemRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Read(KodeUnit As String, KodeLokasi As String, Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeProduksi                                   AS 'Kode Produksi', " +
                  "A.KodeItem                                       AS 'Kode Item', " +
                  "A.NamaItem                                       AS 'Nama Item', " +
                  "A.Jumlah1                                        AS 'Pcs', " +
                  "A.Jumlah2                                        AS 'Meter', " +
                  "A.Jumlah3                                        AS 'Kg', " +
                  "B.NamaUnit                                       AS 'Unit Produksi', " +
                  "C.NamaLokasi                                     AS 'Lokasi Produksi' " +
                  "FROM stockroll A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "LEFT JOIN tlokasiproduksi C ON C.KodeLokasi = A.KodeLokasi " +
                  "WHERE A.StatusStock = 1 AND " +
                  "      CONCAT(A.KodeProduksi, ' ', " +
                  "             A.KodeItem, ' ', " +
                  "             A.NamaItem) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "' "
            End If

            If KodeLokasi <> "" Then
                SQL += " AND A.KodeLokasi = '" + KodeLokasi + "' "
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

    End Class
End Namespace
