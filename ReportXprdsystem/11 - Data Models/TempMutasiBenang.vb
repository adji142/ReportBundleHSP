Imports Dapper

Namespace HSP.Data
    Public Class TempMutasiBenang
        Public Property ID As String
        Public Property Tanggal As Date
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeMesin As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeStatusQC As Byte
        Public Property NamaStatusQC As String
        Public Property SaldoAwalKG As Double
        Public Property SaldoAwalBB As Double
        Public Property ReturKG As Double
        Public Property ReturBB As Double
        Public Property HasilKG As Double
        Public Property HasilBB As Double
        Public Property SaldoKG As Double
        Public Property SaldoBB As Double
        Public Property KeluarCLKG As Double
        Public Property KeluarCLBB As Double
        Public Property KeluarFNKG As Double
        Public Property KeluarFNBB As Double
        Public Property KeluarLLKG As Double
        Public Property KeluarLLBB As Double
        Public Property TotalKeluarKG As Double
        Public Property TotalKeluarBB As Double
        Public Property SaldoAkhirKG As Double
        Public Property SaldoAkhirBB As Double
    End Class

    Public Class DaftarMutasiBenang
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TempMutasiBenang) As Integer
            Dim SQL As String

            SQL = "INSERT into temp_kartustockbenang " +
                  "(ID, Tanggal, KodeShift, KodeGrup, KodeMesin, KodeItem, NamaItem, KodeStatusQC, NamaStatusQC, " +
                  "SaldoAwalKG, SaldoAwalBB, ReturKG, ReturBB, HasilKG, HasilBB, " +
                  "SaldoKG, SaldoBB, KeluarCLKG, KeluarCLBB, KeluarFNKG, KeluarFNBB, KeluarLLKG, KeluarLLBB, " +
                  "TotalKeluarKG, TotalKeluarBB, SaldoAkhirKG, SaldoAkhirBB) " +
                  "VALUES " +
                  "(@ID, @Tanggal, @KodeShift, @KodeGrup, @KodeMesin, @KodeItem, @NamaItem, @KodeStatusQC, @NamaStatusQC, " +
                  "@SaldoAwalKG, @SaldoAwalBB, @ReturKG, @ReturBB, @HasilKG, @HasilBB, " +
                  "@SaldoKG, @SaldoBB, @KeluarCLKG, @KeluarCLBB, @KeluarFNKG, @KeluarFNBB, @KeluarLLKG, @KeluarLLBB, " +
                  "@TotalKeluarKG, @TotalKeluarBB, @SaldoAkhirKG, @SaldoAkhirBB)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM temp_kartustockbenang " +
                  "WHERE ID = @ID "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.ID = ID})
            End Using
        End Function
    End Class
End Namespace

