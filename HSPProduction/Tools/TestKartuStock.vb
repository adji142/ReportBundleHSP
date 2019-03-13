Imports HSPProduction.HSP.Data

Public Class TestKartuStock
    Private _DBConnection As New DBConnection
    Private ID As String = "123"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SAKG1 As Double = 0
        Dim SABB1 As Double = 0
        Dim SAKG2 As Double = 0
        Dim SABB2 As Double = 0
        Dim SAKGLL As Double = 0
        Dim SABBLL As Double = 0

        Dim DaftarMutasiBenang As New DaftarMutasiBenang(ActiveSession)
        Dim TempMutasiBenang As New TempMutasiBenang()

        'Saldo Awal
        Using DBX As IDbConnection = _DBConnection.Connection

            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("sp_SaldoAwalBenang", DBX)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("Tanggal", EpsDateTime1.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("Item", EpsTextBox1.Text)
            CMD.Parameters.AddWithValue("KodeStatus", EpsTextBox2.Text)

            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader

            DR.Read()

            SAKG1 = DR("SAKG1")
            SABB1 = DR("SABB1")
            SAKG2 = DR("SAKG2")
            SABB2 = DR("SABB2")
            SAKGLL = DR("SAKGL")
            SABBLL = DR("SABBL")

            DR.Close()
        End Using

        'Mutasi
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("sp_MutasiBenang", DBX)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("TglAwal", EpsDateTime1.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("TglAkhir", EpsDateTime2.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("Item", EpsTextBox1.Text)
            CMD.Parameters.AddWithValue("KodeStatus", EpsTextBox2.Text)

            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader

            Do While DR.Read()
                TempMutasiBenang.ID = ID
                TempMutasiBenang.Tanggal = DR("Tanggal")
                TempMutasiBenang.KodeShift = DR("KodeShift")
                TempMutasiBenang.KodeGrup = DR("KodeGrup")
                TempMutasiBenang.KodeMesin = DR("KodeMesin")
                TempMutasiBenang.KodeItem = EpsTextBox1.Text.Trim
                TempMutasiBenang.NamaItem = ""
                TempMutasiBenang.KodeStatusQC = EpsTextBox2.Text.Trim
                TempMutasiBenang.NamaStatusQC = ""

                If (DR("KodeMesin") = "1001") Then
                    TempMutasiBenang.SaldoAwalKG = SAKG1
                    TempMutasiBenang.SaldoAwalBB = SABB1
                ElseIf (DR("KodeMesin") = "1002") Then
                    TempMutasiBenang.SaldoAwalKG = SAKG2
                    TempMutasiBenang.SaldoAwalBB = SABB2
                ElseIf (DR("KodeMesin") = "LAIN-LAIN") Then
                    TempMutasiBenang.SaldoAwalKG = SAKGLL
                    TempMutasiBenang.SaldoAwalBB = SABBLL
                End If

                TempMutasiBenang.HasilKG = DR("HASIL_KG")
                TempMutasiBenang.HasilBB = DR("HASIL_BB")
                TempMutasiBenang.ReturKG = DR("RETUR_KG")
                TempMutasiBenang.ReturBB = DR("RETUR_BB")
                TempMutasiBenang.SaldoKG = TempMutasiBenang.SaldoAwalKG + TempMutasiBenang.HasilKG + TempMutasiBenang.ReturKG
                TempMutasiBenang.SaldoBB = TempMutasiBenang.SaldoAwalBB + TempMutasiBenang.HasilBB + TempMutasiBenang.ReturBB
                TempMutasiBenang.KeluarCLKG = DR("KELUAR_CL_KG")
                TempMutasiBenang.KeluarCLBB = DR("KELUAR_CL_BB")
                TempMutasiBenang.KeluarLLKG = DR("KELUAR_LL_KG")
                TempMutasiBenang.KeluarLLBB = DR("KELUAR_LL_BB")
                TempMutasiBenang.TotalKeluarKG = TempMutasiBenang.KeluarCLKG + TempMutasiBenang.KeluarLLKG
                TempMutasiBenang.TotalKeluarBB = TempMutasiBenang.KeluarCLBB + TempMutasiBenang.KeluarLLBB
                TempMutasiBenang.SaldoAkhirKG = TempMutasiBenang.SaldoKG - TempMutasiBenang.TotalKeluarKG
                TempMutasiBenang.SaldoAkhirBB = TempMutasiBenang.SaldoBB - TempMutasiBenang.TotalKeluarBB

                If (DR("KodeMesin") = "1001") Then
                    SAKG1 = TempMutasiBenang.SaldoAkhirKG
                    SABB1 = TempMutasiBenang.SaldoAkhirBB
                ElseIf (DR("KodeMesin") = "1002") Then
                    SAKG2 = TempMutasiBenang.SaldoAkhirKG
                    SABB2 = TempMutasiBenang.SaldoAkhirBB
                ElseIf (DR("KodeMesin") = "LAIN-LAIN") Then
                    SAKGLL = TempMutasiBenang.SaldoAkhirKG
                    SABBLL = TempMutasiBenang.SaldoAkhirBB
                End If

                DaftarMutasiBenang.Add(TempMutasiBenang)
            Loop
        End Using
    End Sub
End Class