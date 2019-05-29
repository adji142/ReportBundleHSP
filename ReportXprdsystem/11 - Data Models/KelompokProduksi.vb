Imports Dapper

Namespace HSP.Data
    Public Class KelompokProduksi
        Public Property KodeKelompok As String
        Public Property NamaKelompok As String
        Public Property Grup As Byte
    End Class

    Public Class DaftarKelompokProduksi : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KelompokProduksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tkelompokproduksi " +
                  "(KodeKelompok, NamaKelompok, Grup) " +
                  "VALUES " +
                  "(@KodeKelompok, @NamaKelompok, @Grup)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As KelompokProduksi) As Integer
            Dim SQL As String

            SQL = "UPDATE tkelompokproduksi SET " +
                  "KodeKelompok = @KodeKelompok, " +
                  "NamaKelompok = @NamaKelompok, " +
                  "Grup = @Grup " +
                  "WHERE KodeKelompok = @KodeKelompok "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tkelompokproduksi " +
                  "WHERE KodeKelompok = @KodeKelompok "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeKelompok = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As KelompokProduksi
            Dim SQL As String

            SQL = "SELECT * FROM tkelompokproduksi " +
                  "WHERE KodeKelompok = @KodeKelompok "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of KelompokProduksi)(SQL, New With {.KodeKelompok = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal Grup As Byte = 0) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeKelompok                          AS 'Kode', " +
                  "NamaKelompok                          AS 'Nama Kelompok' " +
                  "FROM tkelompokproduksi " +
                  "WHERE CONCAT(KodeKelompok,' ',NamaKelompok) LIKE @Kriteria "

            If Grup <> 0 Then
                SQL += " AND Grup = " + Grup.ToString() + ""
            End If

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
            Dim Grup As String = Parameter(0)
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeKelompok                          AS 'Kode', " +
                  "NamaKelompok                          AS 'Nama Kelompok' " +
                  "FROM tkelompokproduksi " +
                  "WHERE CONCAT(KodeKelompok,' ',NamaKelompok) LIKE @Kriteria "

            If Grup <> "" Then
                SQL += " AND Grup = " + Grup.ToString() + ""
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

