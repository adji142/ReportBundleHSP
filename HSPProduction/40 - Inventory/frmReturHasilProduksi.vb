Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmReturHasilProduksi
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

    Private KodeLokasiAsal As String = "100"
    Private KodeLokasiTujuan As String

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
            Dim Status As String = "RETUR PRODUKSI"

            Dim DaftarStock As New DaftarPenyerahanHasilProduksi(ActiveSession)
            Dim Data As DetailPenyerahanHasilProduksi = DaftarStock.FindByKodeProduksi(txtKodeProduksi.Text, cboKelompok.SelectedIndex)
            If Not IsNothing(Data) Then
                KodeProduksi = Data.KodeProduksi
                KodeItem = Data.KodeItem
                NamaItem = Data.NamaItem
                Pcs = Data.Pcs
                Timbang = Data.Timbang
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
                KodeLokasiTujuan = "530"
            Case 2
                KodeLokasiTujuan = "530"
            Case 3
                KodeLokasiTujuan = "530"
            Case 4
                KodeLokasiTujuan = "550"
            Case 5
                KodeLokasiTujuan = "511"
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
                    Dim DaftarRHP As New DaftarReturHasilProduksi(ActiveSession)
                    Dim HeaderRHP As New HeaderReturHasilProduksi
                    Dim DetailRHP As New DetailReturHasilProduksi
                    Dim SAPStaging As New SAPStaging

                    'Nomor Transaksi
                    If _SaveMode = enumSaveMode.AddMode Then
                        _NoTransaksi = DaftarRHP.GetNomorTransaksi(Periode)
                    End If

                    'Simpan Header Penyerahan Hasil Produksi
                    '----------------------------------------------------------------------------------------------------
                    HeaderRHP.NoTransaksi = _NoTransaksi
                    HeaderRHP.TglTransaksi = Now
                    HeaderRHP.NoRef = "-"
                    HeaderRHP.KodeLokasiAsal = KodeLokasiAsal
                    HeaderRHP.KodeLokasiTujuan = KodeLokasiTujuan
                    HeaderRHP.Keterangan = ""
                    HeaderRHP.UserID = ActiveSession.KodeUser
                    HeaderRHP.Kelompok = cboKelompok.SelectedIndex

                    DaftarRHP.AddHeader(HeaderRHP)

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
                            DetailRHP.NoTransaksi = _NoTransaksi
                            DetailRHP.NoUrut = NoUrut
                            DetailRHP.KodeProduksi = Grid.Rows(Row).Cells("Kode").Value
                            DetailRHP.KodeItem = Grid.Rows(Row).Cells("KodeItem").Value
                            DetailRHP.NamaItem = Grid.Rows(Row).Cells("NamaItem").Value
                            DetailRHP.Packing = 1
                            DetailRHP.Pcs = Grid.Rows(Row).Cells("Pcs").Value
                            DetailRHP.Timbang = Grid.Rows(Row).Cells("Timbang").Value
                            DetailRHP.Keterangan = ""
                            DetailRHP.Satuan1 = Satuan1
                            DetailRHP.Satuan2 = Satuan2
                            DetailRHP.Satuan3 = Satuan3
                            DetailRHP.Kelompok = cboKelompok.SelectedIndex

                            DaftarRHP.AddDetail(DetailRHP)

                            'Insert Stock Packing
                            '----------------------------------------------------------------------------------------------------
                            Select Case cboKelompok.SelectedIndex
                                Case 1
                                    Dim DaftarStockPacking As New DaftarStockPacking(ActiveSession)
                                    Dim StockPacking As StockPacking = DaftarStockPacking.FindLastID(Grid.Rows(Row).Cells("Kode").Value)
                                    If Not IsNothing(StockPacking) Then
                                        StockPacking.NoTransaksi = _NoTransaksi
                                        StockPacking.TglTransaksi = Now
                                        StockPacking.TglTimbang = Now
                                        StockPacking.StatusStock = 1

                                        DaftarStockPacking.Add(StockPacking)
                                    End If
                                Case 2
                                    Dim DaftarStockPacking As New DaftarStockPacking(ActiveSession)
                                    Dim StockPacking As StockPacking = DaftarStockPacking.FindLastID(Grid.Rows(Row).Cells("Kode").Value)
                                    If Not IsNothing(StockPacking) Then
                                        StockPacking.NoTransaksi = _NoTransaksi
                                        StockPacking.TglTransaksi = Now
                                        StockPacking.TglTimbang = Now
                                        StockPacking.StatusStock = 1

                                        DaftarStockPacking.Add(StockPacking)
                                    End If
                                Case 3
                                    Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                                    Dim StockRoll As StockRoll = DaftarStockRoll.FindLastID(Grid.Rows(Row).Cells("Kode").Value)
                                    If Not IsNothing(StockRoll) Then
                                        StockRoll.NoTransaksi = _NoTransaksi
                                        StockRoll.TglTransaksi = Now
                                        StockRoll.TglTimbang = Now
                                        StockRoll.KodeLokasi = KodeLokasiTujuan
                                        StockRoll.StatusStock = 1

                                        DaftarStockRoll.Add(StockRoll)
                                    End If
                                Case 4
                                    Dim DaftarStockBMF As New DaftarStockBenangMultifilament(ActiveSession)
                                    Dim StockBMF As StockBenangMultifilament = DaftarStockBMF.Find(Grid.Rows(Row).Cells("Kode").Value)
                                    If Not IsNothing(StockBMF) Then
                                        StockBMF.K_NoTimbang = ""
                                        StockBMF.K_TglTransaksi = Now
                                        StockBMF.K_TglTimbang = Now

                                        DaftarStockBMF.Edit(StockBMF)
                                    End If
                                Case 5
                                    Dim DaftarStockBEXT As New DaftarStockBenang(ActiveSession)
                                    Dim StockBEXT As StockBenang = DaftarStockBEXT.Find(Grid.Rows(Row).Cells("Kode").Value)
                                    If Not IsNothing(StockBEXT) Then
                                        StockBEXT.K_NoTimbang = ""
                                        StockBEXT.K_TglTransaksi = Now
                                        StockBEXT.K_TglTimbang = Now

                                        DaftarStockBEXT.Edit(StockBEXT)
                                    End If

                            End Select

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

                    Dim FormAdd As New frmReport(_NoTransaksi, "Retur")
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