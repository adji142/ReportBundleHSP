Imports System.IO
Imports System.Threading
Imports System.Configuration

Imports HSPBOTBroadcast.BOT

Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Me.WriteToFile("Simple Service started at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        Me.ScheduleService()
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Me.WriteToFile("Simple Service stopped at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        Me.Schedular.Dispose()
    End Sub

    Private Schedular As Timer

    Public Sub ScheduleService()
        Try
            Schedular = New Timer(New TimerCallback(AddressOf SchedularCallback))
            Dim mode As String = My.Settings.Mode.ToUpper()
            Me.WriteToFile((Convert.ToString("Simple Service Mode: ") & mode) + " {0}")

            'Set the Default Time.
            Dim scheduledTime As DateTime = DateTime.MinValue

            If mode = "DAILY" Then
                'Get the Scheduled Time from AppSettings.
                scheduledTime = DateTime.Parse(My.Settings.ScheduledTime)
                If DateTime.Now > scheduledTime Then
                    'If Scheduled Time is passed set Schedule for the next day.
                    scheduledTime = scheduledTime.AddDays(1)
                End If
            End If

            If mode.ToUpper() = "INTERVAL" Then
                'Get the Interval in Minutes from AppSettings.
                Dim intervalMinutes As Integer = Convert.ToInt32(My.Settings.IntervalMinutes)

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

            'Broadcast Message
            Me.SendBroadcast()

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
    End Sub

    Private Sub SchedularCallback(e As Object)
        Me.WriteToFile("Simple Service Log: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        Me.ScheduleService()
    End Sub

    Private Sub WriteToFile(text As String)
        Dim path As String = "C:\ServiceLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(String.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.Close()
        End Using

        'SendBroadcast()
    End Sub

    Private Sub SendBroadcast()
        Dim X As New Plugin_SaldoStockKarung(Nothing)
        X._Create()

        Dim DaftarUser As New UserList(ActiveSession)
        Dim OutboxList As New OutboxList(ActiveSession)
        Dim Outbox As New Outbox

        Dim DT As DataTable = DaftarUser.ReadUser_BC("MKT").Tables("View")
        Dim Row As Double = OutboxList.LastID().UpdateID
        For Each DR As DataRow In DT.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = DR("ID")
            Outbox.ChatText = "Saldo Stock Karung (Uptodate)"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = X.FileName
            Outbox.Status = 0

            OutboxList.Add(Outbox)
        Next

        ' Call Module PTG 1 Akan Jatuh tempo

        Dim PTG01 As New Plugin_saldoAgingPiutangAJT(Nothing)
        PTG01._Create()

        Dim DT_PTG As DataTable = DaftarUser.ReadUser_BC("PTG").Tables("View")
        Dim RowPTG As Double = OutboxList.LastID.UpdateID
        For Each DRX As DataRow In DT_PTG.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = DRX("ID")
            Outbox.ChatText = "Saldo Piutang Akan Jatuh Tempo"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PTG01.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
        Next

        ' Call Module PTG 1 Akan Jatuh tempo
        Dim PTG02 As New Plugin_saldoAgingPiutangJT(Nothing)
        PTG02._Create()

        Dim DT_PTG2 As DataTable = DaftarUser.ReadUser_BC("PTG").Tables("View")
        Dim RowPTG2 As Double = OutboxList.LastID.UpdateID
        For Each DRX2 As DataRow In DT_PTG2.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = DRX2("ID")
            Outbox.ChatText = "Saldo Piutang Jatuh Tempo"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PTG02.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
        Next

        'Call Module Cek sparepart
        Dim DaftarUmurUser As New GetAgeover10days(ActiveSession)
        Dim DTUmur As DataTable = DaftarUmurUser.GetAge().Tables("View")
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
                    Outbox.UpdateID = Row
                    Outbox.ChatID = RowSet("UserIDTelegram")
                    Outbox.ChatText = Message
                    Outbox.ChatTime = Date.Now.ToShortDateString
                    Outbox.ResponseType = Server.ResponseType.Text
                    Outbox.FileName = ""
                    Outbox.Status = 0
                    OutboxList.Add(Outbox)
                End If
            Next
        End If

        'Jump to production
        Dim PIC01 As New Plugin_Laminasi(Nothing)
        PIC01._Create()

        Dim DT_LM As DataTable = DaftarUser.ReadUser_BC("PIC").Tables("View")
        For Each DR As DataRow In DT_LM.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = DR("ID")
            Outbox.ChatText = "Laporan Hasil Laminasi"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PIC01.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
            WriteToFile("End Sending Broadcast Produksi Hasil Laminasi : {0} " + Date.Now)
        Next

        WriteToFile("Start Sending Broadcast Produksi Hasil ADStar: {0} " + Date.Now)
        Dim PIC02 As New Plugin_ADStar(Nothing)
        PIC02._Create()
        For Each DRX2 As DataRow In DT_LM.Rows
            Row += 1
            Outbox.UpdateID = Row
            Outbox.ChatID = DRX2("ID")
            Outbox.ChatText = "Hasil Produksi ADStar"
            Outbox.ChatTime = Date.Now.ToShortDateString
            Outbox.ResponseType = Server.ResponseType.Document
            Outbox.FileName = PIC02.FileName
            Outbox.Status = 0
            OutboxList.Add(Outbox)
            WriteToFile("Start Sending Broadcast Produksi Hasil ADStar: {0} " + Date.Now)
        Next

    End Sub

End Class