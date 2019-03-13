Imports Dapper

Namespace HSP.Data
    Public Class ParameterRollLaminasi
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property FlagBOPP As Byte
        Public Property BeratKarung As Double
        Public Property PP As Double
        Public Property PE As Double
        Public Property Vist As Double
        Public Property Bopp As Double
        Public Property Total As Double
        Public Property BeratTeoritis As Double
    End Class

    Public Class DaftarParameterRollLaminasi
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As ParameterRollLaminasi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO parameterrolllaminasi " +
                  "     (KodeItem, NamaItem, FlagBOPP, BeratKarung, PP, PE, Vist, Bopp, Total, BeratTeoritis) " +
                  "VALUES " +
                  "     (@KodeItem, @NamaItem, @FlagBOPP, @BeratKarung, @PP, @PE, @Vist, @Bopp, @Total, @BeratTeoritis)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As ParameterRollLaminasi) As Integer
            Dim SQL As String

            SQL = "UPDATE parameterrolllaminasi SET " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "FlagBOPP = @FlagBOPP, " +
                  "BeratKarung = @BeratKarung, " +
                  "PP = @PP, " +
                  "PE = @PE, " +
                  "Vist = @Vist, " +
                  "Bopp = @Bopp, " +
                  "Total = @Total, " +
                  "BeratTeoritis = @BeratTeoritis " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM parameterrolllaminasi " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeItem = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As ParameterRollLaminasi
            Dim SQL As String

            SQL = "SELECT * FROM parameterrolllaminasi " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ParameterRollLaminasi)(SQL, New With {.KodeItem = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeItem                             AS 'Kode', " +
                  "NamaItem                             AS 'Nama Item', " +
                  "BeratKarung                          AS 'Berat Karung', " +
                  "PP                                   AS 'Bahan PP', " +
                  "PE                                   AS 'Bahan PE', " +
                  "Vist                                 AS 'Bahan Vistamax', " +
                  "Bopp                                 AS 'Bahan Bopp', " +
                  "Total                                AS 'Total Bahan', " +
                  "BeratTeoritis                        AS 'Berat Teoritis' " +
                  "FROM parameterrolllaminasi " +
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

