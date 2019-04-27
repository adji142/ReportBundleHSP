Imports Dapper

Namespace BOT

    'Class Inbox 
    Public Class Inbox

        'Daftar Properti
        Public Property UpdateID As String
        Public Property ChatID As String
        Public Property FullName As String
        Public Property ChatText As String
        Public Property ChatTime As String
        Public Property Status As Byte
    End Class

    'Class InboxList
    Public Class InboxList

        Private _DBConnection As DBConnection

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add Inbox  
        Public Function Add(ByVal Data As Inbox) As Boolean
            Dim SQL As String

            SQL = "INSERT INTO inbox " +
                  "(UpdateID, ChatID, FullName, ChatText, ChatTime, Status) " +
                  "VALUES " +
                  "(@UpdateID, @ChatID, @FullName, @ChatText, @ChatTime, 0)"

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
        Public Function Find(ByVal ID As String) As Inbox
            Dim SQL As String

            SQL = "SELECT * FROM inbox " +
                  "WHERE UpdateID = @UpdateID "

            Using DBX As IDbConnection = _DBConnection.Connection()
                Find = DBX.Query(Of Inbox)(SQL, New With {.UpdateID = ID}).FirstOrDefault
            End Using

        End Function

        'LastID
        Public Function LastID() As Inbox
            Dim SQL As String

            SQL = "SELECT * FROM inbox " +
                  "ORDER BY UpdateID ASC Limit 1 "

            Using DBX As IDbConnection = _DBConnection.Connection()
                LastID = DBX.Query(Of Inbox)(SQL).FirstOrDefault
            End Using

        End Function


        'UpdateStatus Berdasarkan ID
        Public Function UpdateStatus(ByVal ID As String) As Boolean
            Dim SQL As String

            SQL = "UPDATE inbox SET Status = 1 " +
                  "WHERE UpdateID = @UpdateID "

            Using DBX As IDbConnection = _DBConnection.Connection()
                Try
                    DBX.Execute(SQL, New With {.UpdateUD = ID})
                    UpdateStatus = True
                Catch ex As Exception
                    UpdateStatus = False
                End Try
            End Using

        End Function

        'Baca Data
        Public Function Read() As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM inbox WHERE Status = 0"


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
