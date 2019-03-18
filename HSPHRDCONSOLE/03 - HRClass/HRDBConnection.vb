Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.ComponentModel

Namespace HSP.Data
    Public Class HRDBConnection

        Private _ConnectionString As String = ""

        Sub New(Optional DatabaseName As String = "")
            Dim Temp As New SqlConnectionStringBuilder

            Temp.DataSource = My.Settings.HRserver
            Temp.UserID = My.Settings.HRusername
            Temp.Password = My.Settings.HRpassword
            Temp.InitialCatalog = My.Settings.HRDatabase

            _ConnectionString = Temp.ConnectionString
        End Sub

        'Koneksi Dengan Database Server
        Public Function Connection() As SqlConnection
            Dim DBX As New SqlConnection

            DBX.ConnectionString = _ConnectionString
            DBX.Open()
            Connection = DBX
        End Function

        Public Function ConnectionSetting() As Object
            Dim Temp As New SqlConnectionStringBuilder
            Temp.ConnectionString = _ConnectionString
            ConnectionSetting = Temp
        End Function
    End Class


End Namespace