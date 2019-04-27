Imports Dapper

Namespace BOT

    Public Class Server

        Private _Session As Object
        Private _UpdateID As String
        Private _ChatID As String

        Public Enum ResponseType
            Text = 0
            Document = 1
            Photo = 2
        End Enum

        Sub New(ByVal Session As Object, UpdateID As String, ChatID As String)
            _Session = Session
            _UpdateID = UpdateID
            _ChatID = ChatID
        End Sub

        Public Sub Response(TextResponse As String)
            Dim OutboxList As New OutboxList(_Session)
            Dim Outbox As New Outbox

            Outbox.UpdateID = _UpdateID
            Outbox.ChatID = _ChatID
            Outbox.ChatText = TextResponse
            Outbox.ChatTime = ""
            Outbox.Status = 0
            OutboxList.Add(Outbox)
        End Sub

        Public Sub Response(TextResponse As String, ResponseType As ResponseType, FileName As String)
            Dim OutboxList As New OutboxList(_Session)
            Dim Outbox As New Outbox

            Outbox.UpdateID = _UpdateID
            Outbox.ChatID = _ChatID
            Outbox.ChatText = TextResponse
            Outbox.ChatTime = ""
            Outbox.ResponseType = ResponseType
            Outbox.FileName = FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
        End Sub

    End Class

End Namespace