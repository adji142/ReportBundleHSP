
Module mdGeneral

    Public ActiveSession As New SessionApp
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
