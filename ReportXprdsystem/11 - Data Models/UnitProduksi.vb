Imports Dapper

Namespace HSP.Data
    Public Class UnitProduksi
        Public Property KodeUnit As String
        Public Property NamaUnit As String
        Public Property KodeSatuan1 As String
        Public Property KodeSatuan2 As String
        Public Property KodeSatuan3 As String
        Public Property KodeUnitSAP As String
        Public Property FlagProduksi As Byte
        Public Property FlagAfval As Byte
        Public Property FlagPemakaian As Byte
        Public Property FlagAfvalWO As Byte = 0
        Public Property PrefikKodeProduksi As String
        Public Property KodeLokasi As String
    End Class

    Public Class UnitProduksiPeruntukan
        Public Property KodeUnit As String
        Public Property KodeUnitPeruntukan As String
    End Class

    Public Class DaftarUnitProduksi : Implements IDataLookup

        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As UnitProduksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tunitproduksi " +
                  "(KodeUnit, NamaUnit, KodeSatuan1, KodeSatuan2, KodeSatuan3, KodeUnitSAP, FlagProduksi, FlagAfval, FlagPemakaian, FlagAfvalWO, PrefikKodeProduksi, KodeLokasi) " +
                  "VALUES " +
                  "(@KodeUnit, @NamaUnit, @KodeSatuan1, @KodeSatuan2, @KodeSatuan3, @KodeUnitSAP, @FlagProduksi, @FlagAfval, @FlagPemakaian, @FlagAfvalWO, @PrefikKodeProduksi, @KodeLokasi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function AddDetail(ByVal Data As UnitProduksiPeruntukan) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tunitproduksi_peruntukan " +
                  "(KodeUnit, KodeUnitPeruntukan) " +
                  "VALUES " +
                  "(@KodeUnit, @KodeUnitPeruntukan)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As UnitProduksi) As Integer
            Dim SQL As String

            SQL = "UPDATE tunitproduksi SET " +
                  "KodeUnit = @KodeUnit, " +
                  "NamaUnit = @NamaUnit, " +
                  "KodeSatuan1 = @KodeSatuan1, " +
                  "KodeSatuan2 = @KodeSatuan2, " +
                  "KodeSatuan3 = @KodeSatuan3, " +
                  "KodeUnitSAP = @KodeUnitSAP, " +
                  "FlagProduksi = @FlagProduksi, " +
                  "FlagAfval = @FlagAfval, " +
                  "FlagPemakaian = @FlagPemakaian, " +
                  "FlagAfvalWO = @FlagAfvalWO, " +
                  "PrefikKodeProduksi = @PrefikKodeProduksi, " +
                  "KodeLokasi = @KodeLokasi " +
                  "WHERE KodeUnit = @KodeUnit"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tunitproduksi " +
                  "WHERE KodeUnit = @KodeUnit"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeUnit = ID})
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tunitproduksi_peruntukan " +
                  "WHERE KodeUnit = @KodeUnit"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.KodeUnit = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As UnitProduksi
            Dim SQL As String

            SQL = "SELECT * FROM tunitproduksi " +
                  "WHERE KodeUnit = @KodeUnit"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of UnitProduksi)(SQL, New With {.KodeUnit = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindByLokasi(ByVal ID As String) As UnitProduksi
            Dim SQL As String

            SQL = "SELECT * FROM tunitproduksi " +
                  "WHERE KodeLokasi = @KodeLokasi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindByLokasi = DBX.Query(Of UnitProduksi)(SQL, New With {.KodeLokasi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional KodeUnit As String = "", Optional FlagProduksi As Byte = 0, Optional FlagPemakaian As Byte = 0, Optional FlagAfval As Byte = 0) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "UP.KodeUnit                                      AS 'Kode', " +
                  "UP.NamaUnit                                      AS 'Unit Produksi', " +
                  "UP.KodeUnitSAP                                   AS 'Unit Produksi SAP', " +
                  "IFNULL(LP.NamaLokasi,'-')                        AS 'Lokasi', " +
                  "UP.PrefikKodeProduksi                            AS 'Prefik' " +
                  "FROM tunitproduksi UP "

            If KodeUnit <> "" Then
                SQL += " AND UP.KodeUnit = '" & KodeUnit & "' "
            End If

            If FlagPemakaian = 1 Then
                SQL += "LEFT JOIN tlokasi LP ON LP.KodeLokasi = UP.KodeLokasiBahan "
            Else
                SQL += "LEFT JOIN tlokasi LP ON LP.KodeLokasi = UP.KodeLokasiHasil "
            End If
            SQL += "WHERE CONCAT(UP.KodeUnit, ' ', UP.NamaUnit) LIKE @Kriteria "
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

        Public Function ReadDetail(ByVal KodeUnit As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "UK.KodeUnit                              AS 'Kode', " +
                  "UK.KodeUnitPeruntukan                    AS 'Peruntukan', " +
                  "UP.NamaUnit                              AS 'Nama Unit Peruntukan' " +
                  "FROM tunitproduksi_peruntukan UK " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = UK.KodeUnitPeruntukan " +
                  "WHERE UK.KodeUnit='" + KodeUnit + "'"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim KodeUnit As String = Parameter(0)

            SQL = "SELECT " +
                  "UP.KodeUnit                                      AS 'Kode', " +
                  "UP.NamaUnit                                      AS 'Unit Produksi', " +
                  "UP.KodeUnitSAP                                   AS 'Unit Produksi SAP', " +
                  "UP.PrefikKodeProduksi                            AS 'Prefik', " +
                  "IF(UP.FlagProduksi=1,'YES','NO')                 AS 'Produksi', " +
                  "IF(UP.FlagAfval=1,'YES','NO')                    AS 'Afval', " +
                  "IF(UP.FlagAfvalWO=1,'YES','NO')                       AS 'WO' " +
                  "FROM tunitproduksi UP " +
                  "WHERE CONCAT(UP.KodeUnit, ' ', UP.NamaUnit) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND UP.KodeUnit = '" & KodeUnit & "' "
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

            SQL = "SELECT KodeUnit FROM titemproduksi WHERE KodeUnit = @KodeUnit LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Locked = If(IsNothing(DBX.Query(SQL, New With {.KodeUnit = ID}).FirstOrDefault), False, True)
            End Using
        End Function
    End Class
End Namespace

