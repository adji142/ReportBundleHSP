Public Class SDKConnection
    Public oCompany As New SAPbobsCOM.Company

    Public Function OpenConnectionSDK() As Boolean
        oCompany.SLDServer = "192.168.1.222:40000"
        oCompany.Server = My.Settings.HanaServer
        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB
        oCompany.CompanyDB = My.Settings.HanaSAPDatabaseName
        If IP() = "192.168.1.163" Then
            oCompany.UserName = "IT"
            oCompany.Password = "hspHSP5050"
        End If

        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

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
