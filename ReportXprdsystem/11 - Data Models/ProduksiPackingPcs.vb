Imports Dapper

Namespace HSP.Data
    Public Class ProduksiPackingPcs

        Public Enum enumKelompokPackingPcs
            PackingKarung = 1
            PackingCementBag = 2
        End Enum

        Public Property RowID As String
        Public Property Kelompok As enumKelompokPackingPcs
        Public Property NoTransaksi As String
        Public Property TglTransaksi As Date
        Public Property TglPencatatan As Date
        Public Property NomorWO As String
        Public Property KodeUnitSAP As String
        Public Property KodeUnit As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeMesin As String
        Public Property ShiftSebelumnya As Byte

        Public Property FGKodeLokasi As String
        Public Property FGKodeProduksi As String
        Public Property FGKodeItem As String
        Public Property FGNamaItem As String
        Public Property FGPcs As Double
        Public Property FGBeratBrutto As Double
        Public Property FGBeratNetto As Double
        Public Property FGKodeMedia As String
        Public Property FGBeratMedia As Double
        Public Property FGBeratStandar As Double
        Public Property FGKeterangan As String

        Public Property RMKodeLokasi As String
        Public Property RMKodeItem As String
        Public Property RMNamaItem As String
        Public Property RMPemakaianPcs As Double

        Public Property UserID As String
        Public Property TRX As String

        Public Property KodeKaryawan As String

    End Class

    Public Class DaftarProduksiPackingPcs
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiPackingPcs) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksipackingpcs" +
                  "     (RowID, Kelompok, " +
                  "     NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnitSAP, KodeUnit, KodeShift, KodeGrup, KodeMesin, ShiftSebelumnya, " +
                  "     FGKodeLokasi, FGKodeProduksi, FGKodeItem, FGNamaItem, FGPcs, FGBeratBrutto, FGBeratNetto, FGKodeMedia, FGBeratMedia, FGBeratStandar, FGKeterangan, " +
                  "     RMKodeLokasi, RMKodeItem, RMNamaItem, RMPemakaianPcs, KodeKaryawan, " +
                  "     UserID, TRX) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), @Kelompok, " +
                  "     @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnitSAP, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @ShiftSebelumnya, " +
                  "     @FGKodeLokasi, @FGKodeProduksi, @FGKodeItem, @FGNamaItem, @FGPcs, @FGBeratBrutto, @FGBeratNetto, @FGKodeMedia, @FGBeratMedia, @FGBeratStandar, @FGKeterangan, " +
                  "     @RMKodeLokasi, @RMKodeItem, @RMNamaItem, @RMPemakaianPcs, @KodeKaryawan," +
                  "     @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal ID As String) As ProduksiPackingPcs
            Dim SQL As String

            SQL = "SELECT * FROM produksipackingpcs " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ProduksiPackingPcs)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindKodeProduksi(ByVal KodeProduksi As String) As ProduksiPackingPcs
            Dim SQL As String

            SQL = "SELECT * FROM produksipackingpcs " +
                  "WHERE FGKodeProduksi = @FGKodeProduksi AND "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindKodeProduksi = DBX.Query(Of ProduksiPackingPcs)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindQtyHasil(NomorWO As String) As ProduksiPackingPcs
            Dim SQL As String

            SQL = "SELECT IFNULL(SUM(FGPcs),0) AS QtyHasil FROM produksipackingpcs " +
                  "WHERE NomorWO ='" + NomorWO + "' AND StatusTransaksi =1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                Dim Temp As ProduksiPackingPcs = Nothing

                If DR.Read Then
                    Temp = New ProduksiPackingPcs
                    Temp.FGPcs = DR("QtyHasil")
                End If

                DR.Close()

                FindQtyHasil = Temp
            End Using
        End Function

        Public Function FindBahanProduksi(ByVal NoTransaksi As String) As ProduksiPackingPcs
            Dim SQL As String

            SQL = "SELECT * FROM produksipackingpcs " +
                  "WHERE NoTransaksi = @NoTransaksi AND "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindBahanProduksi = DBX.Query(Of ProduksiPackingPcs)(SQL, New With {.NoTransaksi = NoTransaksi}).FirstOrDefault
            End Using
        End Function

        'Read
        Public Function ReadBeratStandarNol() As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM produksipackingpcs WHERE FGBeratStandar = 0  "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadBeratStandarNol = DS
            End Using
        End Function

        Public Sub UpdateBeratStandar(ByVal NoTransaksi As String, BeratStandar As Double)
            Dim SQL As String

            SQL = "UPDATE produksipackingpcs SET " &
                  "FGBeratStandar =  " & BeratStandar & " " &
                  "WHERE NoTransaksi = '" & NoTransaksi & "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                DBX.Execute(SQL)
            End Using

            SQL = "UPDATE stockpacking SET " &
                  "BeratStandar =  " & BeratStandar & " " &
                  "WHERE NoTransaksi = '" & NoTransaksi & "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                DBX.Execute(SQL)
            End Using

        End Sub

        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(Kelompok As ProduksiPackingPcs.enumKelompokPackingPcs, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                If Kelompok = ProduksiPackingPcs.enumKelompokPackingPcs.PackingKarung Then
                    Prefik = "PFBK-" & Periode
                Else
                    Prefik = "PFBC-" & Periode
                End If

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksipackingpcs " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

