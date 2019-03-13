

Imports Dapper

Namespace BOTSRV.Data

    'Class Outbox 
    Public Class Outbox

        'Daftar Properti
        Public Property UpdateID As String
        Public Property ChatID As String
        Public Property ChatText As String
        Public Property ChatTime As String
        Public Property ResponseType As Server.ResponseType = 0
        Public Property FileName As String = ""
        Public Property Status As Byte
    End Class

    'Class OutboxList  
    Public Class OutboxList

        Private _DBConnection As DBConnection

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add Outbox  
        Public Function Add(ByVal Data As Outbox) As Boolean
            Dim SQL As String

            SQL = "INSERT INTO outbox " +
                  "(UpdateID, ChatID, ChatText, ChatTime, ResponseType, FileName, Status) " +
                  "VALUES " +
                  "(@UpdateID, @ChatID, @ChatText, @ChatTime, @ResponseType, @FileName, 0)"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Try
                    DBX.Execute(SQL, Data)
                    Add = True
                Catch ex As Exception
                    Add = False
                End Try
            End Using

        End Function

        'Find Berdasarkan ID
        Public Function Find(ByVal ID As String) As Outbox
            Dim SQL As String

            SQL = "SELECT * FROM outbox " +
                  "WHERE UpdateID = @UpdateID "

            Using DBX As IDbConnection = _DBConnection.Connection()
                Find = DBX.Query(Of Outbox)(SQL, New With {.UpdateID = ID}).FirstOrDefault
            End Using

        End Function

        'UpdateStatus Berdasarkan ID
        Public Sub UpdateStatus(ByVal ID As String)
            Dim SQL As String

            SQL = "UPDATE outbox SET Status = 1 " +
                  "WHERE UpdateID = '" + ID + "' "

            Using DBX As IDbConnection = _DBConnection.Connection()
                DBX.Execute(SQL)
            End Using

        End Sub

        'Baca Data
        Public Function Read() As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM outbox WHERE Status = 0"


            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS

            End Using

        End Function

    End Class

End Namespace
