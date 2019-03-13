
Module mdGeneral

    Public lChange As Boolean

    'Mendapatkan Nilai Periode Dari Tanggal
    Public Function GetPeriod(ByVal Data As DateTime) As String
        GetPeriod = Data.ToString("yyyyMM")
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

   
End Module
