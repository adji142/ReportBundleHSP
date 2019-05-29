Imports Dapper

Namespace HSP.Data
    Public Class Item
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeUnit As String
        Public Property KodeKelompok As String
        Public Property KodeSatuan1 As String
        Public Property KodeSatuan2 As String
        Public Property KodeSatuan3 As String
        Public Property KodeItemSistem As String
        Public Property Aktif As Byte
    End Class

    Public Class DaftarItem : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As Item) As Integer
            Dim SQL As String

            SQL = "INSERT INTO titemproduksi " +
                  "(KodeItem, NamaItem, KodeUnit, KodeKelompok, KodeSatuan1, KodeSatuan2, KodeSatuan3, KodeItemSistem, Aktif) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @KodeUnit, @KodeKelompok, @KodeSatuan1, @KodeSatuan2, @KodeSatuan3, @KodeItemSistem, @Aktif)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As Item) As Integer
            Dim SQL As String

            SQL = "UPDATE titemproduksi SET " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeKelompok = @KodeKelompok, " +
                  "KodeSatuan1 = @KodeSatuan1, " +
                  "KodeSatuan2 = @KodeSatuan2, " +
                  "KodeSatuan3 = @KodeSatuan3, " +
                  "KodeItemSistem = @KodeItemSistem, " +
                  "Aktif = @Aktif " +
                  "WHERE KodeItem = @KodeItem"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM titemproduksi " +
                  "WHERE KodeItem = @KodeItem"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeItem = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As Item
            Dim SQL As String

            SQL = "SELECT * FROM titemproduksi " +
                  "WHERE KodeItem = @KodeItem"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Item)(SQL, New With {.KodeItem = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, KodeKelompok As String, Optional KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeItem                                           AS 'Kode', " +
                  "A.NamaItem                                           AS 'Nama Item', " +
                  "B.NamaUnit                                           AS 'Unit Produksi', " +
                  "A.KodeItemSistem                                     AS 'Kode Item Sistem', " +
                  "IF(A.Aktif=1,'Aktif','Non Aktif')                    AS 'Status' " +
                  "FROM titemproduksi A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "LEFT JOIN tkelompokitem C ON C.KodeKelompok = A.KodeKelompok " +
                  "WHERE CONCAT(KodeItem, ' ', NamaItem) LIKE @Kriteria " +
                  "AND A.KodeKelompok = @KodeKelompok "

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "'"
            End If

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@KodeKelompok", KodeKelompok)
                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim KodeKelompok As String = Parameter(0)
            Dim KodeUnit As String = Parameter(1)

            SQL = "SELECT " +
                  "A.KodeItem                                           AS 'Kode', " +
                  "A.NamaItem                                           AS 'Nama Item', " +
                  "B.NamaUnit                                           AS 'Unit Produksi', " +
                  "A.KodeItemSistem                                     AS 'Kode Item Sistem', " +
                  "IF(A.Aktif=1,'Aktif','Non Aktif')                    AS 'Status' " +
                  "FROM titemproduksi A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "LEFT JOIN tkelompokitem C ON C.KodeKelompok = A.KodeKelompok " +
                  "WHERE CONCAT(KodeItem, ' ', NamaItem) LIKE @Kriteria AND A.KodeKelompok = @KodeKelompok "

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "'"
            End If

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@KodeKelompok", KodeKelompok)
                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function

        Public Function Locked(ByVal ID As String) As Boolean
            'Dim SQL As String

            'SQL = "SELECT KodeItem FROM mutasibenang WHERE KodeItem = @KodeItem LIMIT 1"

            'Using DBX As IDbConnection = _DBConnection.Connection
            '    Locked = If(IsNothing(DBX.Query(SQL, New With {.KodeItem = ID}).FirstOrDefault), False, True)
            'End Using
            Locked = False

        End Function
    End Class
End Namespace

