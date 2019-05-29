Imports Dapper

Namespace HSP.Data


    Public Class HeaderTransformBallToPcs
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeLokasi As String
        Public Property Keterangan As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DetailTransformBallToPcs
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeItemBall As String
        Public Property NamaItemBall As String
        Public Property KodeProduksiBall As String
        Public Property QtyBall As Double
        Public Property KodeItemPcs As String
        Public Property NamaItemPcs As String
        Public Property QtyPcs As Double
    End Class

    Public Class DaftarTransformBallToPcs
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddHeader(ByVal Data As HeaderTransformBallToPcs) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headertransformballtopcs " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, KodeShift, KodeGrup, KodeLokasi, Keterangan, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeShift, @KodeGrup, @KodeLokasi, @Keterangan, @UserID, '" + TRX() + "' ) "

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM headertransformballtopcs " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function AddDetail(ByVal Data As DetailTransformBallToPcs) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailtransformballtopcs " +
                  "(RowID, NoTransaksi, NoUrut, KodeItemBall, NamaItemBall, KodeProduksiBall, QtyBall, KodeItemPcs, NamaItemPcs, QtyPcs) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeItemBall, @NamaItemBall, @KodeProduksiBall, @QtyBall, @KodeItemPcs, @NamaItemPcs, @QtyPcs) "

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM detailtransformballtopcs " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "PFJH-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headertransformballtopcs " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace
