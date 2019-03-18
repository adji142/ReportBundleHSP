
Module General

    'Mendapatkan Nilai Periode Dari Tanggal
    Public Function GetPeriod(ByVal Data As DateTime) As String
        GetPeriod = Data.ToString("yyyyMM")
    End Function

    Public Function GetPeriode(ByVal Data As DateTime) As String
        GetPeriode = Data.ToString("yyyy/MM/dd")
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

End Module
