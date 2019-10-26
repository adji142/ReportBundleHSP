Imports Dapper

Namespace HSP.Data
    Public Class Meeting
        Public Property ID As Integer
        Public Property Topik As String
        Public Property Periode As String
        Public Property KodeDepartement As String
        Public Property NamaDepartement As String
        Public Property Status As Boolean
    End Class
    Public Class DaftarMetting
        Private _DBConnection As DBConnection
        Private _activeSession As SessionApp

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function Add(ByVal Data As Meeting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO ttopik " +
                "(Topik,Periode,KodeDepartement,NamaDepartement,Status) " +
                "VALUES " +
                "(@Topik,@Periode,@KodeDepartement,@NamaDepartement,@Status)"
            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Edit(ByVal Data As Meeting) As Integer
            Dim SQL As String

            SQL = "UPDATE ttopik SET " +
                "Topik = @Topik," +
                "Periode = @Periode," +
                "KodeDepartement = @KodeDepartement," +
                "NamaDepartement = @NamaDepartement," +
                "Status = @Status " +
                "WHERE ID = @ID"
            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM ttopik " +
                  "WHERE topik = @Topik"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.Topik = ID})
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "CAST(K.id AS CHAR)                                  AS 'Kode', " +
                  "K.Topik                                                AS 'Topik', " +
                  "K.Periode                                              AS 'Periode', " +
                  "K.KodeDepartement                                      AS 'Kode Departemen', " +
                  "K.NamaDepartement                                      AS 'Nama Departemen', " +
                  "NULL                                                   AS 'Terakhir Meeting', " +
                  "CASE WHEN K.Status = 1 then 'Aktif' else 'Pasif' end   AS 'Status' " +
                  "FROM ttopik K " +
                  "WHERE CONCAT(K.id, ' ', K.Topik) LIKE @Kriteria "

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
        Public Function Find(ByVal ID As String) As Meeting
            Dim SQL As String

            SQL = "SELECT * FROM ttopik " +
                  "WHERE Topik = @ID"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Meeting)(SQL, New With {.ID = ID}).FirstOrDefault
            End Using
        End Function
        Public Function Find_ByID(ByVal ID As String) As Meeting
            Dim SQL As String

            SQL = "SELECT * FROM ttopik " +
                  "WHERE id = @ID"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find_ByID = DBX.Query(Of Meeting)(SQL, New With {.ID = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function

    End Class
End Namespace