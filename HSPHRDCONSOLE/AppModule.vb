Public Class AppModule
    Public Function GetAppModule() As DataTable
        Dim oDS As New DataSet
        Dim oDT As DataTable
        Dim oApp As DataRow

        'Create DataTable & Define Column
        oDT = oDS.Tables.Add("AppModule")
        oDT.Columns.Add("AppID")
        oDT.Columns.Add("AppDescription")

        '*************************************************************************
        'Bot Module
        '*************************************************************************
        oApp = oDT.Rows.Add()
        oApp(0) = "6001"
        oApp(1) = "Informasi Personal Bot"

        oApp = oDT.Rows.Add()
        oApp(0) = "6002"
        oApp(1) = "Kirim Broadcast Telegram"

        oDS.AcceptChanges()
        GetAppModule = oDT
    End Function

    Public Function Form(ByVal AppID As String, ByVal Session As Object) As Object
        Dim AppForm As Object = Nothing
        '*************************************************************************
        'Bot Setting Module
        '*************************************************************************
        Select Case AppID
            Case "6001"
                AppForm = New DaftarUserSettingBrowse
            Case "6002"
                AppForm = New FrmHRBroadcastBrowse
        End Select

        Form = AppForm
    End Function
End Class
