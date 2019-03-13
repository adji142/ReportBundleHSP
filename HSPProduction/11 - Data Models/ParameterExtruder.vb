Imports Dapper

Namespace HSP.Data
    Public Class ParameterExtruder
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property DenierAktual As Double
        Public Property JmlBenang As Double
        Public Property Kecepatan As Double
        Public Property Kapasitas As Double
        Public Property Konstanta As Double
    End Class

    Public Class DaftarParameterExtruder
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As ParameterExtruder) As Integer
            Dim SQL As String

            SQL = "INSERT INTO parameterextruder " +
                  "(KodeItem, NamaItem, DenierAktual, JmlBenang, Kecepatan, Kapasitas, Konstanta) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @DenierAktual, @JmlBenang, @Kecepatan, @Kapasitas, @Konstanta)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As ParameterExtruder) As Integer
            Dim SQL As String

            SQL = "UPDATE parameterextruder SET " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "DenierAktual = @DenierAktual, " +
                  "JmlBenang = @JmlBenang, " +
                  "Kecepatan = @Kecepatan, " +
                  "Kapasitas = @Kapasitas, " +
                  "Konstanta = @Konstanta " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM parameterextruder " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeItem = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As ParameterExtruder
            Dim SQL As String

            SQL = "SELECT * FROM parameterextruder " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ParameterExtruder)(SQL, New With {.KodeItem = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeItem                         AS 'Kode', " +
                  "NamaItem                         AS 'Nama Item', " +
                  "DenierAktual                     AS 'Denier Aktual', " +
                  "JmlBenang                        AS 'Jumlah Benang', " +
                  "Kecepatan                        As 'Speed', " +
                  "Kapasitas                        AS 'Kapasitas', " +
                  "Konstanta                        AS 'Pembagi' " +
                  "FROM parameterextruder " +
                  "WHERE CONCAT(KodeItem, ' ', NamaItem) LIKE @Kriteria "

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

