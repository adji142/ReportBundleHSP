Imports Dapper

Namespace HSP.Data
    Public Class ProduksiCBPR

        Public Property RowID As String
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

        Public Property KodeLokasi As String
        Public Property KodeProduksi As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Meter As Double
        Public Property Kilogram As Double

        Public Property UserID As String
        Public Property TRX As String

        Public Property FGKodeItem As String
        Public Property FGNamaItem As String

    End Class

    Public Class PemakaianBahanSBZero
        Public Property NomorWO As String
        Public Property KodeBahan As String
        Public Property NamaBahan As String
        Public Property Qty As Double
    End Class

    Public Class DaftarProduksiCBPR
        Public Enum enumProsesPemakaianBahanutama
            CementBag = 1
        End Enum

        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiCBPR) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksicbpr " +
                  "     (RowID, " +
                  "     NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnitSAP, KodeUnit, KodeShift, KodeGrup, KodeMesin, ShiftSebelumnya, " +
                  "     KodeLokasi, KodeProduksi, KodeItem, NamaItem, Meter, Kilogram, " +
                  "     UserID, TRX, FGKodeItem, FGNamaItem) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), " +
                  "     @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnitSAP, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @ShiftSebelumnya, " +
                  "     @KodeLokasi, @KodeProduksi, @KodeItem, @NamaItem, @Meter, @Kilogram, " +
                  "     @UserID, '" + TRX() + "', @FGKodeItem, @FGNamaItem)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function GetItemZero(ByVal NomorWO As String) As PemakaianBahanSBZero
            Dim SQL As String

            SQL = "SELECT " +
                  "A.NomorWO					AS NomorWO, " +
                  "A.KodeItem					AS KodeItem, " +
                  "A.NamaItem					AS NamaItem, " +
                  "IFNULL(SUM(B.Meter),0)		AS Qty " +
                  "FROM x_pemakaianbahan A " +
                  "LEFT JOIN produksicbpr B ON B.NomorWO = A.NomorWO AND B.KodeItem " +
                  "WHERE A.NomorWO = '" + NomorWO + "' " +
                  "GROUP BY A.NomorWO, A.KodeItem " +
                  "HAVING IFNULL(SUM(B.Meter),0)=0"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                Dim Temp As PemakaianBahanSBZero = Nothing

                If DR.Read Then
                    Temp = New PemakaianBahanSBZero

                    Temp.NomorWO = DR("NomorWO")
                    Temp.KodeBahan = DR("KodeItem")
                    Temp.NamaBahan = DR("NamaItem")
                    Temp.Qty = DR("Qty")
                End If

                DR.Close()
                GetItemZero = Temp

            End Using
        End Function

        Public Function ReadBahanUtama(ByVal NomorWO As String) As DataSet
            Dim SQL As String = ""
            SQL = "SELECT " +
                          "A.KodeItem                                       AS KodeItem, " +
                          "IF(LEFT(A.KodeItem,3)='304','B',B.JenisBahan)    AS JenisBahan, " +
                          "SUM(A.Meter)                                     AS Meter " +
                          "FROM produksicbpr A " +
                          "LEFT JOIN temp_itemslitting B ON B.KodeItem = A.KodeItem " +
                          "WHERE NomorWO='" + NomorWO + "' " +
                          "GROUP BY LEFT(A.KodeItem,3), B.JenisBahan "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadBahanUtama = DS
            End Using
        End Function

        Public Function IsEmptyUtama(ByVal NomorWO As String, Proses As DaftarProduksiCBPR.enumProsesPemakaianBahanutama) As Boolean
            Dim SQL As String = ""

            Select Case Proses
                Case 1
                    SQL = "SELECT " +
                          "A.KodeItem                                       AS KodeItem, " +
                          "IF(LEFT(A.KodeItem,3)='304','B',B.JenisBahan)    AS JenisBahan, " +
                          "SUM(A.Meter)                                     AS Meter " +
                          "FROM produksicbpr A " +
                          "LEFT JOIN temp_itemslitting B ON B.KodeItem = A.KodeItem " +
                          "WHERE NomorWO='" + NomorWO + "' " +
                          "GROUP BY LEFT(A.KodeItem,3), B.JenisBahan "
            End Select

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader

                CMD.Parameters.AddWithValue("@NomorWO", NomorWO)
                DR = CMD.ExecuteReader

                If DR.Read Then
                    IsEmptyUtama = False
                Else
                    IsEmptyUtama = True
                End If

                DR.Close()
            End Using
        End Function

        Public Function IsPemakaianBahanUtama(ByVal NomorWO As String, Proses As DaftarProduksiCBPR.enumProsesPemakaianBahanutama) As Boolean
            Dim SQL As String = ""
            'Dim Status As Boolean

            Select Proses
                Case 1
                    SQL = "SELECT " +
                          "KodeItem, SUM(Meter) AS Jumlah " +
                          "FROM produksicbpr " +
                          "WHERE NomorWO = @NomorWO " +
                          "GROUP BY KodeItem " +
                          "HAVING SUM(Meter)=0 "
            End Select

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader

                CMD.Parameters.AddWithValue("@NomorWO", NomorWO)
                DR = CMD.ExecuteReader

                If DR.Read Then
                    IsPemakaianBahanUtama = False
                Else
                    IsPemakaianBahanUtama = True
                End If

                'Dim XX As New DaftarPemakaianBahan(ActiveSession)
                'If XX.IsEmpty(NomorWO) Then
                '    IsPemakaianBahan = False
                'Else
                '    IsPemakaianBahan = True
                'End If
            End Using
        End Function

        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "PFCR-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksicbpr " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

