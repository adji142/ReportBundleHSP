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

        Public oCompany As New SAPbobsCOM.Company

        Public Function OpenConnectionSDK() As Boolean
            oCompany.SLDServer = "192.168.1.222:40000"
            oCompany.Server = My.Settings.HanaServer
            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB
            oCompany.CompanyDB = My.Settings.HanaSAPDatabaseName
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
            If IP() = "192.168.1.11" Then
                oCompany.UserName = "IT"
                oCompany.Password = "hspHSP5050"
            End If

            Dim nStatus As Long
            nStatus = oCompany.Connect

            If nStatus <> 0 Then
                OpenConnectionSDK = False
            Else
                OpenConnectionSDK = True
            End If
        End Function

        Public Function CloseConnectionSDK() As Boolean
            oCompany.Disconnect()
            CloseConnectionSDK = True
        End Function

    End Class

End Namespace