Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Namespace HSP.Data
    Public Class DBConnection
        Private _ConnectionString As String = ""

        Sub New()
            Dim Temp As New MySqlConnectionStringBuilder

            Temp.Server = My.Settings.Server
            Temp.UserID = My.Settings.UserID
            Temp.Password = My.Settings.Password
            Temp.Database = My.Settings.DatabaseName
            Temp.Port = My.Settings.Port

            _ConnectionString = Temp.ConnectionString
        End Sub

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            If Session.DBConnection.Trim() <> "" Then
                _ConnectionString = Session.DBConnection
            Else
                Dim Temp As New MySqlConnectionStringBuilder

                Temp.Server = My.Settings.Server
                Temp.UserID = My.Settings.UserID
                Temp.Password = My.Settings.Password
                Temp.Database = My.Settings.DatabaseName
                Temp.Port = My.Settings.Port

                _ConnectionString = Temp.ConnectionString
            End If
        End Sub

        'Koneksi Dengan Database Server
        Public Function Connection() As MySqlConnection
            Dim DBX As New MySqlConnection

            DBX.ConnectionString = _ConnectionString
            DBX.Open()
            Connection = DBX

        End Function

        Public Function ConnectionSetting() As Object
            Dim Temp As New MySqlConnectionStringBuilder
            Temp.ConnectionString = _ConnectionString
            ConnectionSetting = Temp
        End Function

    End Class

End Namespace