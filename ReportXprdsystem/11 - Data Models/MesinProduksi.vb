Imports Dapper

Namespace HSP.Data
    Public Class Mesin
        Public Property KodeMesin As String
        Public Property NamaMesin As String
        Public Property KodeUnit As String
        Public Property Aktif As Byte
        Public Property KodeMesinSAP As String
        Public Property JenisMesin As String
    End Class

    Public Class DaftarMesin : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As Mesin) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tmesinproduksi " +
                  "(KodeMesin, NamaMesin, KodeUnit, Aktif, KodeMesinSAP, JenisMesin) " +
                  "VALUES " +
                  "(@KodeMesin, @NamaMesin, @KodeUnit, @Aktif, @KodeMesinSAP, @JenisMesin)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As Mesin) As Integer
            Dim SQL As String

            SQL = "UPDATE tmesinproduksi SET " +
                  "KodeMesin = @KodeMesin, " +
                  "NamaMesin = @NamaMesin, " +
                  "KodeUnit = @KodeUnit, " +
                  "Aktif = @Aktif, " +
                  "KodeMesinSAP = @KodeMesinSAP, " +
                  "JenisMesin = @JenisMesin " +
                  "WHERE KodeMesin = @KodeMesin "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tmesinproduksi " +
                  "WHERE KodeMesin = @KodeMesin "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeMesin = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As Mesin
            Dim SQL As String

            SQL = "SELECT * FROM tmesinproduksi " +
                  "WHERE KodeMesin = @KodeMesin "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Mesin)(SQL, New With {.KodeMesin = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Find(ByVal ID As String, Unit As String) As Mesin
            Dim SQL As String

            SQL = "SELECT * FROM tmesinproduksi " +
                  "WHERE KodeMesin = @KodeMesin AND KodeUnit = @KodeUnit"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Mesin)(SQL, New With {.KodeMesin = ID, .KodeUnit = Unit}).FirstOrDefault
            End Using
        End Function

        Public Function FindBySAP(ByVal ID As String) As Mesin
            Dim SQL As String

            SQL = "SELECT * FROM tmesinproduksi " +
                  "WHERE KodeMesinSAP = @KodeMesinSAP "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindBySAP = DBX.Query(Of Mesin)(SQL, New With {.KodeMesinSAP = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeMesin                          AS 'Kode', " +
                  "A.NamaMesin                          AS 'Nama Mesin', " +
                  "B.NamaUnit                           AS 'Unit Produksi', " +
                  "A.KodeMesinSAP                       AS 'Kode Mesin SAP', " +
                  "IF(A.Aktif=1,'Aktif','Non Aktif')    AS 'Status' " +
                  "FROM tmesinproduksi A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "WHERE CONCAT(A.KodeMesin,' ',A.NamaMesin) LIKE @Kriteria"

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "'"
            End If

            SQL += " ORDER BY A.KodeMesin "

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
            Dim KodeUnit As String = Parameter(0)
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeMesin                          AS 'Kode', " +
                  "A.NamaMesin                          AS 'Nama Mesin', " +
                  "B.NamaUnit                           AS 'Unit Produksi', " +
                  "A.KodeMesinSAP                       AS 'Kode Mesin SAP', " +
                  "C.NamaJenis                          AS 'Jenis Mesin', " +
                  "IF(A.Aktif=1,'Aktif','Non Aktif')    AS 'Status' " +
                  "FROM tmesinproduksi A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "LEFT JOIN tjenismesin C ON C.KodeJenis = A.JenisMesin " +
                  "WHERE CONCAT(A.KodeMesin,' ',A.NamaMesin) LIKE @Kriteria"

            If KodeUnit <> "" Then
                SQL += " AND A.KodeUnit = '" + KodeUnit + "'"
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

