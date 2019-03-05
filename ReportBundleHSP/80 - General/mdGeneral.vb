Imports ReportBundleHSP.HSP.Data

Module mdGeneral

    Public ActiveSession As New SessionApp

    Private _DBConnection As DBConnection = New DBConnection()

    Public Enum enumStatusRoll
        enumInspeksi = 0
        enumDisposisi = 1
        enumQCPass = 2
    End Enum

    'Fungsi Tanggal Kosong
    Public Function IsEmptyDate(sDate As String) As Boolean
        Dim DD As Integer
        Dim MM As Integer
        Dim YY As Integer

        DD = Val(Left(sDate, 2))
        MM = Val(Mid(sDate, 4, 2))
        YY = Val(Mid(sDate, 7, 4))

        If DD = 0 And MM = 0 And YY = 0 Then
            IsEmptyDate = True
        Else
            IsEmptyDate = False
        End If
    End Function

    'Mendapatkan Nilai Periode Dari Tanggal
    Public Function GetPeriod(ByVal Data As DateTime) As String
        GetPeriod = Data.ToString("yyyyMM")
    End Function

    'Mendapatkan Nilai Periode Dari Tanggal
    Public Function GetPeriodFull(ByVal Data As DateTime) As String
        GetPeriodFull = Data.ToString("yyMMdd")
    End Function

    'Mendapatkan Tanggal Jika Kosong
    Public Function GetDefaultDate() As DateTime
        GetDefaultDate = "1970-01-01 00:00:00"
    End Function

    'Fungsi Konversi Tipe String Menjadi Date
    Public Function Stod(sDate As String) As Date
        Dim DD As Integer
        Dim MM As Integer
        Dim YY As Integer

        DD = Val(Left(sDate, 2))
        MM = Val(Mid(sDate, 4, 2))
        YY = Val(Mid(sDate, 7, 4))

        If IsEmptyDate(sDate) Then
            Stod = DateSerial(1970, 1, 1)
        Else
            Stod = DateSerial(YY, MM, DD)
        End If
    End Function

    Public Function GetDateTimeServer() As DateTime
        Dim SQL As String

        SQL = "SELECT NOW() AS Waktu"
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader
            DR.Read()

            GetDateTimeServer = DR("Waktu")

            DR.Close()
        End Using
    End Function

    Public Function SetLocalDateTime()
        Microsoft.VisualBasic.DateString = New Date(Year(GetDateTimeServer()), Month(GetDateTimeServer()), GetDateTimeServer().Day)
        Microsoft.VisualBasic.TimeOfDay = GetDateTimeServer().ToString("HH:mm:ss")
    End Function

    'Periode Sebelumnya
    Public Function PreviousPeriod(CurrentPeriod As String) As String
        If Val(Right(CurrentPeriod, 2)) = 1 Then
            PreviousPeriod = Trim(Str(Val(Left(CurrentPeriod, 4)) - 1)) + "12"
        Else
            PreviousPeriod = Trim(Str(Val(CurrentPeriod) - 1))
        End If
    End Function

    'Periode Sesudahnya
    Public Function NextPeriod(CurrentPeriod As String) As String
        If Val(Right(CurrentPeriod, 2)) = 12 Then
            NextPeriod = Trim(Str(Val(Left(CurrentPeriod, 4)) + 1)) + "01"
        Else
            NextPeriod = Trim(Str(Val(CurrentPeriod) + 1))
        End If
    End Function

    'Deskripsi Periode Berdasarkan Periode
    Public Function GetPeriodDescription(ByVal Periode As String) As String
        Dim NamaBulan() As String = {"Januari", "Pebruari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "Nopember", "Desember"}
        GetPeriodDescription = NamaBulan(Val(Right(Periode, 2)) - 1) + " " + Left(Periode, 4)
    End Function

    'Deskripsi Periode Berdasarkan Tanggal
    Public Function GetPeriodDescription(ByVal Data As DateTime) As String
        Dim Periode As String = GetPeriod(Data)
        Dim NamaBulan() As String = {"Januari", "Pebruari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "Nopember", "Desember"}
        GetPeriodDescription = NamaBulan(Val(Right(Periode, 2)) - 1) + " " + Left(Periode, 4)
    End Function

    Public Sub FillMonth(Control As Object, Optional Start As Integer = 0)
        Dim aMonthName As Object
        Dim nMonth As Integer

        aMonthName = {"Januari", "Pebruari", "Maret", "April", _
                           "Mei", "Juni", "Juli", "Agustus", _
                           "September", "Oktober", "Nopember", "Desember"}
        Control.Items.Clear()
        For nMonth = 0 To 11
            Control.Items.Add(aMonthName(nMonth))
        Next

        If Start = 0 Then
            Control.SelectedIndex = Month(Now) - 1
        Else
            Control.SelectedIndex = Start - 1
        End If
    End Sub

    Public Sub FillYear(Control As Object, Optional Start As Integer = 0, _
                    Optional StepDown As Integer = 5, _
                    Optional StepUp As Integer = 2)
        Dim nYear As Integer

        Control.Items.Clear()
        For nYear = Year(Now) - StepDown To Year(Now) + StepUp
            Control.Items.Add(nYear)
        Next

        If Start = 0 Then
            Control.SelectedIndex = StepDown
        Else
            Control.SelectedIndex = Start
        End If
    End Sub

    '---------------------------------------------------------------
    'Fungsi Untuk Merubah Format Nomor Kendaraan Menjadi Valid
    '---------------------------------------------------------------
    Public Function ValidNoKendaraan(NoKendaraan As String) As String
        Dim Temp As String
        Dim Index As Integer
        Dim lSpace1 As Boolean
        Dim lSpace2 As Boolean

        Temp = ""
        For Index = 1 To Len(NoKendaraan)
            If Mid(NoKendaraan, Index, 1) <> " " Then
                Temp = Temp + Mid(NoKendaraan, Index, 1)
            End If
        Next
        NoKendaraan = Temp

        Temp = ""
        lSpace1 = False
        lSpace2 = False
        For Index = 1 To Len(NoKendaraan)
            If Not IsNumeric(Mid(NoKendaraan, Index, 1)) And lSpace1 And Not lSpace2 Then
                Temp = Temp + " "
            End If
            If IsNumeric(Mid(NoKendaraan, Index, 1)) And Not lSpace1 Then
                Temp = Temp + " "
            End If

            If Not IsNumeric(Mid(NoKendaraan, Index, 1)) And lSpace1 Then
                lSpace2 = True
            End If

            If IsNumeric(Mid(NoKendaraan, Index, 1)) Then
                lSpace1 = True
            End If

            Temp = Temp + Mid(NoKendaraan, Index, 1)
        Next
        ValidNoKendaraan = UCase(Temp)

    End Function

    Public Sub SetHeaderView(Obj As Object)
        Obj.EnableHeadersVisualStyles = True
        Obj.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Obj.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
        Obj.ColumnHeadersHeight = 35
    End Sub

End Module
