Imports HSPProduction.HSP.Data
Imports System.Linq

Public Class frmLINQ

    Private Sub UnitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitToolStripMenuItem.Click
        Dim UP As New DaftarUnitProduksi(ActiveSession)

        Dim DT As DataTable = UP.Read("%").Tables("View")

        Dim query = From test In DT.Rows Select test

        EpsDataGridView1.DataSource = query



    End Sub

    Private Sub frmLINQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTanggal.Value = GetDateTimeServer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = GetDateTimeServer().Date.ToString("dd") & " " & GetPeriodDescription(Now.Date).ToUpper()
        Label2.Text = GetDateTimeServer().ToString("HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Microsoft.VisualBasic.DateString = New Date(Year(GetDateTimeServer()), Month(GetDateTimeServer()), GetDateTimeServer().Day)
        Microsoft.VisualBasic.TimeOfDay = GetDateTimeServer().ToString("HH:mm:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If New DaftarPemakaianBahan(ActiveSession).IsEmpty("123") Then
            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : 123 Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MsgBox("OK")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If New DaftarProduksiCBPR(ActiveSession).IsEmptyUtama("123", DaftarProduksiCBPR.enumProsesPemakaianBahanutama.CementBag) Then
            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : 123 Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MsgBox("OK")
        End If
    End Sub
End Class