Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmPenyerahanHasilProduksi
    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private Enum enumKelompok
        KelompokPackingKarung = 1
        KelompokPackingCementBag = 2
        KelompokPackingRoll = 3
        KelompokPackingBmf = 4
        KelompokPackingBExt = 5
    End Enum

    'Data Private
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String
    Private _TRX As String = ""

    Private KodeLokasiAsal As String
    Private KodeLokasiTujuan As String = "100"

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        cboKelompok.SelectedIndex = 0
        txtKodeProduksi.Text = ""
        Grid.Rows.Clear()

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim KodeProduksi As String = ""
            Dim KodeItem As String = ""
            Dim NamaItem As String = ""
            Dim Pcs As Double = 0
            Dim Timbang As Double = 0
            Dim Status As String = ""

            Dim DaftarStock As Object = Nothing
            Dim Data As Object = Nothing

            Select Case cboKelompok.SelectedIndex
                Case 1
                    DaftarStock = New DaftarStockPacking(ActiveSession)
                Case 2
                    DaftarStock = New DaftarStockPacking(ActiveSession)
                Case 3
                    DaftarStock = New DaftarStockRoll(ActiveSession)
                Case 4
                    DaftarStock = New DaftarStockBenangMultifilament(ActiveSession)
                Case 5
                    DaftarStock = New DaftarStockBenang(ActiveSession)
            End Select

            Select Case cboKelompok.SelectedIndex
                Case 1
                    Data = DaftarStock.Find(txtKodeProduksi.Text)
                Case 2
                    Data = DaftarStock.Find(txtKodeProduksi.Text)
                Case 3
                    Data = DaftarStock.Find(txtKodeProduksi.Text)
                Case 4
                    Data = DaftarStock.FindExist(txtKodeProduksi.Text)
                Case 5
                    Data = DaftarStock.FindExist(txtKodeProduksi.Text)
            End Select

            If Not IsNothing(Data) Then
                Select Case cboKelompok.SelectedIndex
                    Case 1
                        If Data.StatusQC = 1 Or Data.StatusDisposisi = 1 Then
                            KodeProduksi = Data.KodeProduksi
                            KodeItem = Data.KodeItem
                            NamaItem = Data.NamaItem
                            Pcs = Data.Pcs
                            Timbang = Format(Data.BeratNetto, "##,##0.00")
                            Status = If(Data.StatusDisposisi = 1,
                                        If(Data.StatusQc = 1, "OK", If(Data.StatusQc = 2, "NON OK", If(Data.StatusQc = 3, "OVER", If(Data.StatusQc = 4, "UNDER", "")))) & " >> DISPOSISI",
                                            If(Data.StatusQc = 1, "OK", If(Data.StatusQc = 2, "NON OK", If(Data.StatusQc = 3, "OVER", If(Data.StatusQc = 4, "UNDER", "")))))

                        Else
                            MessageBox.Show("Status Item Barang " &
                                            If(Data.StatusQc = 1, "OK",
                                               If(Data.StatusQc = 2, "NON OK",
                                                  If(Data.StatusQc = 3, "OVER",
                                                     If(Data.StatusQc = 4, "UNDER", "")))) & "!!! Update Status Untuk Melanjutkan Proses Penyerahan...", "Peringatan QC", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Case 2
                        If Data.StatusQC = 1 Or Data.StatusDisposisi = 1 Then
                            KodeProduksi = Data.KodeProduksi
                            KodeItem = Data.KodeItem
                            NamaItem = Data.NamaItem
                            Pcs = Data.Pcs
                            Timbang = Format(Data.BeratNetto, "##,##0.00")
                            Status = If(Data.StatusDisposisi = 1,
                                        If(Data.StatusQc = 1, "OK", If(Data.StatusQc = 2, "NON OK", If(Data.StatusQc = 3, "OVER", If(Data.StatusQc = 4, "UNDER", "")))) & " >> DISPOSISI",
                                            If(Data.StatusQc = 1, "OK", If(Data.StatusQc = 2, "NON OK", If(Data.StatusQc = 3, "OVER", If(Data.StatusQc = 4, "UNDER", "")))))
                        Else
                            MessageBox.Show("Status Item Barang " &
                                            If(Data.StatusQc = 1, "OK",
                                               If(Data.StatusQc = 2, "NON OK",
                                                  If(Data.StatusQc = 3, "OVER",
                                                     If(Data.StatusQc = 4, "UNDER", "")))) & "!!! Update Status Untuk Melanjutkan Proses Penyerahan...", "Peringatan QC", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Case 3
                        If Data.StatusQC = 1 Or Data.StatusDisposisi = 1 Then
                            KodeProduksi = Data.KodeProduksi
                            KodeItem = Data.KodeItem
                            NamaItem = Data.NamaItem
                            Pcs = Data.PanjangRoll
                            Timbang = Format(Data.BeratNetto, "##,##0.00")
                            Status = If(Data.StatusDisposisi = 1,
                                        If(Data.StatusQc = 1, "OK", If(Data.StatusQc = 2, "NON OK", If(Data.StatusQc = 3, "OVER", If(Data.StatusQc = 4, "UNDER", "")))) & " >> DISPOSISI",
                                            If(Data.StatusQc = 1, "OK", If(Data.StatusQc = 2, "NON OK", If(Data.StatusQc = 3, "OVER", If(Data.StatusQc = 4, "UNDER", "")))))

                        Else
                            MessageBox.Show("Status Item Barang " &
                                            If(Data.StatusQc = 1, "OK",
                                               If(Data.StatusQc = 2, "NON OK",
                                                  If(Data.StatusQc = 3, "OVER",
                                                     If(Data.StatusQc = 4, "UNDER", "")))) & "!!! Update Status Untuk Melanjutkan Proses Penyerahan...", "Peringatan QC", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Case 4
                        KodeProduksi = Data.KodeProduksi
                        KodeItem = Data.KodeItem
                        NamaItem = Data.NamaItem
                        Pcs = Data.Jumlah2
                        Timbang = Format(Data.BeratNetto, "##,##0.00")
                        Status = If(Data.KodeStatusQc = 1, "STANDART", If(Data.KodeStatusQc = 2, "TIDAK STANDART", If(Data.KodeStatusQc = 3, "PRODUKSI", "")))

                    Case 5
                        KodeProduksi = Data.KodeProduksi
                        KodeItem = Data.KodeItem
                        NamaItem = Data.NamaItem
                        Pcs = Data.Jumlah2
                        Timbang = Format(Data.BeratNetto, "##,##0.00")
                        Status = If(Data.KodeStatusQc = 1, "OK", If(Data.KodeStatusQc = 2, "NON OK", If(Data.KodeStatusQc = 3, "OVER", If(Data.KodeStatusQc = 4, "UNDER", ""))))

                End Select

            Else
                MessageBox.Show("Kode Produksi Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodeProduksi.Select()
                GoTo Jump
            End If

            Dim FindRow As Integer = -1
            For Row As Integer = 0 To Grid.Rows.Count - 1
                If txtKodeProduksi.Text = Grid.Rows(Row).Cells("Kode").Value Then
                    FindRow = Row
                    Exit For
                End If
            Next

            If FindRow = -1 Then
                Grid.Rows.Add(KodeProduksi, KodeItem, NamaItem, Pcs, Timbang, Status)
                Grid.Rows(Grid.RowCount - 1).Selected = True
            End If

            txtKodeProduksi.Text = ""
            txtKodeProduksi.Focus()

        End If

        SetEnableCommand()

Jump:
        txtKodeProduksi.Text = ""
    End Sub

    Private Sub Grid_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles Grid.UserAddedRow
        SetEnableCommand()
    End Sub

    Private Sub Grid_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles Grid.UserDeletedRow
        SetEnableCommand()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        lblHari.Text = Now.Date.ToString("dd") & " " & GetPeriodDescription(Now.Date).ToUpper & " " & TimeOfDay.ToString("hh:mm:ss")
    End Sub

    Private Sub frmPenyerahanHasilProduksi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Grid.SaveColumnOrder()
        Me.Dispose()
    End Sub

    Private Sub frmPenyerahanHasilProduksi_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Refresh()        
        Grid.SettingID = Me.Name
        Grid.SetColumnOrder()
    End Sub

    Private Sub frmPenyerahanHasilProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()
    End Sub

    Private Sub cboKelompok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKelompok.SelectedIndexChanged
        Select Case cboKelompok.SelectedIndex
            Case 1
                KodeLokasiAsal = "530"
            Case 2
                KodeLokasiAsal = "530"
            Case 3
                KodeLokasiAsal = "530"
            Case 4
                KodeLokasiAsal = "550"
            Case 5
                KodeLokasiAsal = "511"
        End Select

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_TextChanged(sender As Object, e As EventArgs) Handles txtKodeProduksi.TextChanged
        SetEnableCommand()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(Now.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarPHP As New DaftarPenyerahanHasilProduksi(ActiveSession)
                    Dim HeaderPHP As New HeaderPenyerahanHasilProduksi
                    Dim DetailPHP As New DetailPenyerahanHasilProduksi
                    Dim SAPStaging As New SAPStaging

                    'Nomor Transaksi
                    If _SaveMode = enumSaveMode.AddMode Then
                        _NoTransaksi = DaftarPHP.GetNomorTransaksi(Periode)
                    End If

                    'Simpan Header Penyerahan Hasil Produksi
                    '----------------------------------------------------------------------------------------------------
                    HeaderPHP.NoTransaksi = _NoTransaksi
                    HeaderPHP.TglTransaksi = Now
                    HeaderPHP.NoRef = "-"
                    HeaderPHP.KodeLokasiAsal = KodeLokasiAsal
                    HeaderPHP.KodeLokasiTujuan = KodeLokasiTujuan
                    HeaderPHP.Keterangan = ""
                    HeaderPHP.UserID = ActiveSession.KodeUser
                    HeaderPHP.Kelompok = cboKelompok.SelectedIndex

                    DaftarPHP.AddHeader(HeaderPHP)

                    Dim Satuan1 As String = ""
                    Dim Satuan2 As String = ""
                    Dim Satuan3 As String = ""

                    Select Case cboKelompok.SelectedIndex
                        Case 1
                            Satuan1 = "BALL"
                            Satuan2 = "LEMBAR"
                            Satuan3 = "KG"
                        Case 2
                            Satuan1 = "BALL"
                            Satuan2 = "LEMBAR"
                            Satuan3 = "KG"
                        Case 3
                            Satuan1 = "ROLL"
                            Satuan2 = "METER"
                            Satuan3 = "KG"
                        Case 4
                            Satuan1 = "BOX"
                            Satuan2 = "BOBIN"
                            Satuan3 = "KG"
                        Case 5
                            Satuan1 = "DUS"
                            Satuan2 = "BOBIN"
                            Satuan3 = "KG"
                    End Select

                    'Simpan Detail Penyerahan Hasil Produksi
                    '----------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer
                    For Row = 0 To Grid.RowCount - 1
                        NoUrut += 1

                        If Grid.Rows(Row).Cells("Kode").Value <> "" Then
                            DetailPHP.NoTransaksi = _NoTransaksi
                            DetailPHP.NoUrut = NoUrut
                            DetailPHP.KodeProduksi = Grid.Rows(Row).Cells("Kode").Value
                            DetailPHP.KodeItem = Grid.Rows(Row).Cells("KodeItem").Value
                            DetailPHP.NamaItem = Grid.Rows(Row).Cells("NamaItem").Value
                            DetailPHP.Packing = 1
                            DetailPHP.Pcs = Grid.Rows(Row).Cells("Pcs").Value
                            DetailPHP.Timbang = Grid.Rows(Row).Cells("Timbang").Value
                            DetailPHP.Keterangan = ""
                            DetailPHP.Satuan1 = Satuan1
                            DetailPHP.Satuan2 = Satuan2
                            DetailPHP.Satuan3 = Satuan3
                            DetailPHP.Kelompok = cboKelompok.SelectedIndex

                            DaftarPHP.AddDetail(DetailPHP)

                            'Insert SAPInventory Inventory Transfer
                            '----------------------------------------------------------------------------------------------------

                            Select Case cboKelompok.SelectedIndex
                                Case 1
                                    SAPStaging.PostInventoryTransfer(Now.Date, Grid.Rows(Row).Cells("KodeItem").Value, Grid.Rows(Row).Cells("NamaItem").Value, Grid.Rows(Row).Cells("Pcs").Value, Grid.Rows(Row).Cells("Kode").Value, _NoTransaksi, KodeLokasiAsal, KodeLokasiTujuan)
                                Case 2
                                    SAPStaging.PostInventoryTransfer(Now.Date, Grid.Rows(Row).Cells("KodeItem").Value, Grid.Rows(Row).Cells("NamaItem").Value, Grid.Rows(Row).Cells("Pcs").Value, Grid.Rows(Row).Cells("Kode").Value, _NoTransaksi, KodeLokasiAsal, KodeLokasiTujuan)
                                Case 3
                                    SAPStaging.PostInventoryTransfer(Now.Date, Grid.Rows(Row).Cells("KodeItem").Value, Grid.Rows(Row).Cells("NamaItem").Value, Grid.Rows(Row).Cells("Pcs").Value, Grid.Rows(Row).Cells("Kode").Value, _NoTransaksi, KodeLokasiAsal, KodeLokasiTujuan)
                                Case 4
                                    SAPStaging.PostInventoryTransfer(Now.Date, Grid.Rows(Row).Cells("KodeItem").Value, Grid.Rows(Row).Cells("NamaItem").Value, Grid.Rows(Row).Cells("Timbang").Value, Grid.Rows(Row).Cells("Kode").Value, _NoTransaksi, KodeLokasiAsal, KodeLokasiTujuan)
                                Case 5
                                    SAPStaging.PostInventoryTransfer(Now.Date, Grid.Rows(Row).Cells("KodeItem").Value, Grid.Rows(Row).Cells("NamaItem").Value, Grid.Rows(Row).Cells("Timbang").Value, "", _NoTransaksi, KodeLokasiAsal, KodeLokasiTujuan)
                            End Select

                        End If
                    Next

                    'Eksekusi SAPStaging Inventory Transfer
                    '----------------------------------------------------------------------------------------------------
                    SAPStaging.Execute(_NoTransaksi, HSPProduction.SAPStaging.enumTransaction.InventoryTransfer)

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    Dim FormAdd As New frmReport(_NoTransaksi, "Penyerahan")
                    FormAdd.ShowDialog()

                    ResetData()
                    cboKelompok.Focus()

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try

            Case "btClose"
                Me.Close()

        End Select

Jump:
        
    End Sub

    Private Sub SetEnableCommand()

        If cboKelompok.SelectedIndex = 0 Then
            lblKodeProduksi.Enabled = False
            txtKodeProduksi.Enabled = False
            txtKodeProduksi.Text = ""
        Else
            lblKodeProduksi.Enabled = True
            txtKodeProduksi.Enabled = True
        End If

        cboKelompok.Enabled = If(Grid.RowCount = 0, True, False)

        btSave.Enabled = If(cboKelompok.SelectedIndex = 0, False, True) And _
                         If(Grid.RowCount = 0, False, True)

        lblItem.Text = "Total : " & Grid.RowCount & " Baris Data"
        lblJumlah.Text = Grid.RowCount
    End Sub

    
End Class