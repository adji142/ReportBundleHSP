Imports Dapper

Namespace HSP.Data
    Public Class MediaTimbang
        Public Property KodeMedia As String
        Public Property NamaMedia As String
        Public Property Berat As Double
        Public Property KodeLokasi As String
        Public Property JumlahMedia As Byte
        Public Property KodeSatuan As String
        Public Property KodeUnit As String = ""
    End Class

    Public Class DaftarMediaTimbang : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As MediaTimbang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tmediatimbang " +
                  "(KodeMedia, NamaMedia, Berat, KodeLokasi, JumlahMedia, KodeSatuan, KodeUnit) " +
                  "VALUES " +
                  "(@KodeMedia, @NamaMedia, @Berat, @KodeLokasi, @JumlahMedia, @KodeSatuan, @KodeUnit)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As MediaTimbang) As Integer
            Dim SQL As String

            SQL = "UPDATE tmediatimbang SET " +
                  "KodeMedia = @KodeMedia, " +
                  "NamaMedia = @NamaMedia, " +
                  "Berat = @Berat, " +
                  "KodeLokasi = @KodeLokasi, " +
                  "JumlahMedia = @JumlahMedia, " +
                  "KodeSatuan = @KodeSatuan, " +
                  "KodeUnit = @KodeUnit " +
                  "WHERE KodeMedia = @KodeMedia "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function UpdateStatusProduksi(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "UPDATE tmediatimbang SET " +
                  "JumlahKodeProduksi = 0 " +
                  "WHERE KodeLokasi = @KodeLokasi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateStatusProduksi = DBX.Execute(SQL, New With {.KodeUnit = ID})
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tmediatimbang " +
                  "WHERE KodeMedia = @KodeMedia "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeMedia = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As MediaTimbang
            Dim SQL As String

            SQL = "SELECT * FROM tmediatimbang " +
                  "WHERE KodeMedia = @KodeMedia "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of MediaTimbang)(SQL, New With {.KodeMedia = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeLokasi As String = "", Optional KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "MT.KodeMedia                                      AS 'Kode', " +
                  "MT.NamaMedia                                      AS 'Nama Media', " +
                  "MT.Berat                                          AS 'Berat Media', " +
                  "UP.NamaLokasi                                     AS 'Lokasi Produksi', " +
                  "IFNULL(XP.NamaUnit,'-')                           AS 'Unit Produksi', " +
                  "IF(MT.JumlahMedia=1,'Ijinkan','Tidak Dijinkan')   AS 'Jumlah Media', " +
                  "ST.NamaSatuan                                     AS 'Satuan' " +
                  "FROM tmediatimbang MT " +
                  "LEFT JOIN tlokasiproduksi UP ON UP.KodeLokasi = MT.KodeLokasi " +
                  "LEFT JOIN tsatuan ST ON ST.KodeSatuan = MT.KodeSatuan " +
                  "LEFT JOIN tunitproduksi XP ON XP.KodeUnit = MT.KodeUnit " +
                  "WHERE CONCAT(MT.KodeMedia, ' ', MT.NamaMedia) LIKE @Kriteria "

            If KodeLokasi <> "" Then
                SQL += " AND MT.KodeLokasi ='" + KodeLokasi + "'"
            End If

            If KodeUnit <> "" Then
                SQL += " AND MT.KodeUnit ='" + KodeUnit + "'"
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
            Dim KodeUnit As String

            Try
                KodeUnit = Parameter(1)
            Catch ex As Exception
                KodeUnit = ""
            End Try

            SQL = "SELECT " +
                  "MT.KodeMedia                                      AS 'Kode', " +
                  "MT.NamaMedia                                      AS 'Nama Media', " +
                  "MT.Berat                                          AS 'Berat Media', " +
                  "UP.NamaLokasi                                     AS 'Lokasi Produksi', " +
                  "IF(MT.JumlahMedia=1,'Ijinkan','Tidak Dijinkan')   AS 'Jumlah Media', " +
                  "ST.NamaSatuan                                     AS 'Satuan' " +
                  "FROM tmediatimbang MT " +
                  "LEFT JOIN tlokasiproduksi UP ON UP.KodeLokasi = MT.KodeLokasi " +
                  "LEFT JOIN tsatuan ST ON ST.KodeSatuan = MT.KodeSatuan " +
                  "WHERE CONCAT(MT.KodeMedia, ' ', MT.NamaMedia) LIKE @Kriteria "

            SQL += " AND MT.KodeLokasi ='" + KodeLokasi + "'"

            If KodeUnit <> "" Then
                SQL += " AND MT.KodeUnit ='" + KodeUnit + "'"
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

