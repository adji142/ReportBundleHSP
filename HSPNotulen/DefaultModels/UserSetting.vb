Imports Dapper

Namespace HSP.Data
    Public Class _Setting
        Public Property ID As Integer
        Public Property NIK As String
        Public Property NamaKaryawan As String
        Public Property Email As String
        Public Property TeleGramID As String
        Public Property PhoneNumber As String

    End Class
    Public Class UserSetting
        Private _DBConnection As DBConnection
        Private _activeSession As SessionApp

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function Add(ByVal Data As Meeting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO usersetting " +
                "(NIK,NamaKaryawan,Email,TeleGramID,PhoneNumber) " +
                "VALUES " +
                "(@NIK,@NamaKaryawan,@Email,@TeleGramID,@PhoneNumber)"
            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Edit(ByVal Data As Meeting) As Integer
            Dim SQL As String

            SQL = "UPDATE usersetting SET " +
                "NIK = @NIK," +
                "NamaKaryawan = @NamaKaryawan," +
                "Email = @Email," +
                "TeleGramID = @TeleGramID," +
                "PhoneNumber = @PhoneNumber " +
                "WHERE ID = @ID"
            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM usersetting " +
                  "WHERE ID = @ID"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.Topik = ID})
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "CAST(K.id AS CHAR)                                     AS 'Kode', " +
                  "K.NIK                                                           ,  " +
                  "K.NamaKaryawan                                         AS 'Nama', " +
                  "K.Email                                                         , " +
                  "K.TeleGramID                                           AS 'Telegram ID', " +
                  "PhoneNumber                                            AS 'Phone' " +
                  "FROM usersetting K " +
                  "WHERE CONCAT(K.id, ' ', K.NIK , ' ' , K.NamaKaryawan) LIKE @Kriteria "

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

            SQL = "SELECT * FROM usersetting " +
                  "WHERE ID = @ID"

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