Imports System.IO
Imports System.Threading
Imports System.Configuration

Imports HSPBOTBroadcast.BOT

Public Class SrvBroadcast
    Dim Time As String
    Dim role As String
    Dim userid As String
    Dim inteval As String
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Dim Var_Seting As New GetSetting(ActiveSession)
        Dim dataset As DataSet = Var_Seting.GetSetting_BC()

        For Each DR As DataRow In dataset.Tables(0).Rows
            If TimeOfDay.ToString("hh:mm:ss") = DR("time").ToString Then
                Me.WriteToFile("Callback Simple Service started at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
                Me.ScheduleService(DR("time").ToString, DR("rolename").ToString, DR("userid").ToString, DR("intervalset").ToString)
            Else
                Me.WriteToFile("Start Simple Service started at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
                Me.ScheduleService(DR("time").ToString, DR("rolename").ToString, DR("userid").ToString, DR("intervalset").ToString)
            End If
        Next
        'Me.ScheduleService_Alert()
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Me.WriteToFile("Simple Service stopped at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        Me.Schedular.Dispose()
    End Sub

    Private Schedular As Timer

    Public Sub ScheduleService(ByVal time As String, ByVal rolename As String, ByVal userid As String, ByVal intervalset As String)
        Schedular = New Timer(New TimerCallback(AddressOf SchedularCallback))
        Dim mode As String = My.Settings.Mode.ToUpper()
        Me.WriteToFile((Convert.ToString("Simple Service Mode: ") & mode) + " {0}")
        Dim scheduledTime As DateTime = DateTime.MinValue

        If (time <> "" And rolename <> "" And userid <> "" And intervalset <> "") Then
            Try
                If (intervalset = "DAILY") Then
                    WriteToFile("Daily")
                    'Get the Scheduled Time from AppSettings.
                    scheduledTime = DateTime.Parse(time)
                    If DateTime.Now > scheduledTime Then
                        WriteToFile("Kalau Udah Lewat Jam")
                        'If Scheduled Time is passed set Schedule for the next day.
                        scheduledTime = scheduledTime.AddDays(1)
                    End If
                    WriteToFile("Belum Lewat Jam")
                End If
                If (intervalset.ToUpper() = "INTERVAL") Then
                    'Get the Interval in Minutes from AppSettings.
                    Dim intervalMinutes As Integer = Convert.ToInt32(time.ToString())

                    'Set the Scheduled Time by adding the Interval to Current Time.
                    scheduledTime = DateTime.Now.AddMinutes(intervalMinutes)
                    If DateTime.Now > scheduledTime Then
                        'If Scheduled Time is passed set Schedule for the next Interval.
                        scheduledTime = scheduledTime.AddMinutes(intervalMinutes)
                    End If
                End If

                Dim timeSpan As TimeSpan = scheduledTime.Subtract(DateTime.Now)
                Dim schedule As String = String.Format("{0} day(s) {1} hour(s) {2} minute(s) {3} seconds(s)", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)

                Me.WriteToFile((Convert.ToString("Simple Service scheduled to run after: ") & schedule) + " {0}")
                WriteToFile("Prepare Exec Plugin")
                'Broadcast Message
                If rolename = "MKT" Then 'Marketing
                    Me.SendBroadcast(userid)
                ElseIf rolename = "PTG" Then 'Piutang
                    Me.SendBroadcast_PTG(userid)
                ElseIf rolename = "PIC" Then 'PPIC
                    Me.SendBroadcast_PIC(userid)
                ElseIf rolename = "SPR" Then 'Sparepart
                    Me.SendBroadcast_SPR(userid)
                End If

                'Get the difference in Minutes between the Scheduled and Current Time.
                Dim dueTime As Integer = Convert.ToInt32(timeSpan.TotalMilliseconds)

                'Change the Timer's Due Time.
                Schedular.Change(dueTime, Timeout.Infinite)
            Catch ex As Exception
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace)

                'Stop the Windows Service.
                Using serviceController As New System.ServiceProcess.ServiceController("SimpleService")
                    serviceController.[Stop]()
                End Using
            End Try
        End If
    End Sub
    Private Sub SchedularCallback(e As Object)
        Dim Var_Seting As New GetSetting(ActiveSession)
        'Set the Default Time.
        Dim dataset As DataSet = Var_Seting.GetSetting_BC()
        For Each DR As DataRow In dataset.Tables(0).Rows
            Me.WriteToFile("Simple Callback Service Log: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
            Me.ScheduleService(DR("time").ToString, DR("rolename").ToString, DR("userid").ToString, DR("intervalset").ToString)
        Next
    End Sub

    Private Sub WriteToFile(text As String)
        Dim path As String = "C:\ServiceLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(String.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.Close()
        End Using

        'SendBroadcast()
    End Sub

    Private Sub SendBroadcast(ByVal User As String)
        Try
            WriteToFile("Start Sending Broadcast Stock: {0} " + Date.Now)
            Dim X As New Plugin_SaldoStockKarung(Nothing)
            X._Create()
            Dim DaftarUser As New UserList(ActiveSession)
            Dim OutboxList As New OutboxList(ActiveSession)
            Dim Outbox As New Outbox
            'Dim DT As DataTable = DaftarUser.ReadUser("/MKT").Tables("View")
            Dim Row As Double = OutboxList.LastID().UpdateID
            'For Each DR As DataRow In DT.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = User
            Outbox.ChatText = "Saldo Stock Karung (Uptodate)"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = X.FileName
            Outbox.Status = 0

            OutboxList.Add(Outbox)
            WriteToFile("End Sending Broadcast Stock: {0} " + Date.Now)
        Catch ex As Exception
            WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace)

            'Stop the Windows Service.
            Using serviceController As New System.ServiceProcess.ServiceController("SimpleService")
                serviceController.[Stop]()
            End Using
        End Try
        'Next

    End Sub
    Private Sub SendBroadcast_PTG(ByVal UserID As String)
        Try
            WriteToFile("Start Sending Broadcast Piutang AJT: {0} " + Date.Now)
            Dim PTG01 As New Plugin_saldoAgingPiutangAJT(Nothing)
            PTG01._Create()
            Dim OutboxList As New OutboxList(ActiveSession)
            Dim Outbox As New Outbox
            Dim Row As Double = OutboxList.LastID().UpdateID
            ' Call Module PTG 1 Akan Jatuh tempo
            'For Each DRX As DataRow In DT_PTG.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = UserID
            Outbox.ChatText = "Saldo Piutang Akan Jatuh Tempo"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PTG01.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
            WriteToFile("End Sending Broadcast Piutang AJT: {0} " + Date.Now)
            'Next

            ' Call Module PTG 1 Akan Jatuh tempo
            WriteToFile("Start Sending Broadcast Piutang JT: {0} " + Date.Now)
            Dim PTG02 As New Plugin_saldoAgingPiutangJT(Nothing)
            PTG02._Create()
            'For Each DRX2 As DataRow In DT_PTG2.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = UserID
            Outbox.ChatText = "Saldo Piutang Jatuh Tempo"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PTG02.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
            WriteToFile("End Sending Broadcast Piutang JT: {0} " + Date.Now)
        Catch ex As Exception
            WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace)

            'Stop the Windows Service.
            Using serviceController As New System.ServiceProcess.ServiceController("SimpleService")
                serviceController.[Stop]()
            End Using
        End Try

        'Next
    End Sub
    Private Sub SendBroadcast_SPR(ByVal UserID As String)
        Try
            WriteToFile("Start Sending Broadcast Informasi Sparepart: {0} " + Date.Now)
            Dim OutboxList As New OutboxList(ActiveSession)
            Dim Outbox As New Outbox
            Dim Row As Double = OutboxList.LastID().UpdateID
            ' Notif jika ada saldo stok sparepart > 10 hari
            Dim DaftarUmurUser As New GetAgeover10days(ActiveSession)
            Dim DTUmur As DataTable = DaftarUmurUser.GetAge(UserID).Tables("View")
            Dim Message = "=========================" + vbCrLf +
                            "[NoReplay] Info Stock Sparepart [NoReplay]" + vbCrLf +
                            "=========================" + vbCrLf +
                            "PERHATIAN!!!" + vbCrLf +
                            "Umur Stock Sparepart anda sudah mendekati 2 minggu setelah pengambilan terakhir. " + vbCrLf +
                            "Silahkan Melakukan refreshment atau Retur ke Gudang Sparepart dan melakukan Bon Sparepart lagi" + vbCrLf +
                            vbCrLf + vbCrLf + "=========================" + vbCrLf +
                            "This Message Generated by Telegram Bot Server"

            If (DTUmur.Rows.Count > 0) Then
                For Each RowSet As DataRow In DTUmur.Rows
                    If (RowSet("UserIDTelegram") <> "") Then
                        Row += 1
                        WriteToFile("Send Broadcast SPR" + Row.ToString())
                        Outbox.UpdateID = Row
                        Outbox.ChatID = RowSet("UserIDTelegram")
                        Outbox.ChatText = Message
                        Outbox.ResponseType = Server.ResponseType.Text
                        Outbox.ChatTime = Date.Now.ToShortDateString
                        Outbox.Status = 0
                        OutboxList.Add(Outbox)
                    End If
                Next
            End If
            WriteToFile("End Sending Broadcast Informasi Sparepart: {0} " + Date.Now)
        Catch ex As Exception
            WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace)

            'Stop the Windows Service.
            Using serviceController As New System.ServiceProcess.ServiceController("SimpleService")
                serviceController.[Stop]()
            End Using
        End Try

    End Sub

    Private Sub SendBroadcast_PIC(ByVal UserID As String)
        WriteToFile("Start Sending Broadcast Produksi Hasil Laminasi: {0} " + Date.Now)
        Try
            Dim OutboxList As New OutboxList(ActiveSession)
            Dim Outbox As New Outbox
            Dim Row As Double = OutboxList.LastID().UpdateID
            ' Call Module PTG 1 Akan Jatuh tempo

            Dim PIC01 As New Plugin_Laminasi(Nothing)
            PIC01._Create()
            'For Each DRX As DataRow In DT_PTG.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = UserID
            Outbox.ChatText = "Laporan Hasil Laminasi"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PIC01.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
            WriteToFile("End Sending Broadcast Produksi Hasil Laminasi : {0} " + Date.Now)
            'Next

            ' Call Module PTG 1 Akan Jatuh tempo
            WriteToFile("Start Sending Broadcast Produksi Hasil ADStar: {0} " + Date.Now)
            Dim PIC02 As New Plugin_ADStar(Nothing)
            PIC02._Create()
            'For Each DRX2 As DataRow In DT_PTG2.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = UserID
            Outbox.ChatText = "Hasil Produksi ADStar"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PIC02.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
            WriteToFile("Start Sending Broadcast Produksi Hasil ADStar: {0} " + Date.Now)
        Catch ex As Exception
            WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace)

            'Stop the Windows Service.
            Using serviceController As New System.ServiceProcess.ServiceController("SimpleService")
                serviceController.[Stop]()
            End Using
        End Try

    End Sub
End Class
