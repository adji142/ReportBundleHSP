Imports Sap.Data.Hana
Imports System.ComponentModel

Namespace HSP.Data

    Public Class SAPDBConnection

        Private _ConnectionString As String = ""

        Sub New(Optional DatabaseName As String = "")
            Dim Temp As New HanaConnectionStringBuilder

            Temp.Server = My.Settings.HanaServer
            Temp.UserName = My.Settings.HanaUserName
            Temp.Password = My.Settings.HanaPassword
            Temp.CurrentSchema = If(DatabaseName.Trim() = "", My.Settings.HanaSAPDatabaseName, My.Settings.HanaSTGDatabaseName)

            _ConnectionString = Temp.ConnectionString
        End Sub

        'Koneksi Dengan Database Server
        Public Function Connection() As HanaConnection
            Dim DBX As New HanaConnection

            DBX.ConnectionString = _ConnectionString
            DBX.Open()
            Connection = DBX
        End Function

        Public Function ConnectionSetting() As Object
            Dim Temp As New HanaConnectionStringBuilder
            Temp.ConnectionString = _ConnectionString
            ConnectionSetting = Temp
        End Function

    End Class

End Namespace