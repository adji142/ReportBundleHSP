Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmTransferBenangKeluar
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _SaveMode As enumSaveMode

    Private TglTransaksi As DateTime
    Private _NoTransaksi As String
    Private _TRX As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    Private Sub FillCombo()
        'Grup Produksi
        Dim DS As DataSet
        Dim Drow As DataRow

        Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)

        DS = New DataSet
        DS = DaftarGrupProduksi.Read("%")
        cboGrup.DataSource = DS.Tables("View")
        cboGrup.DisplayMember = "Grup Produksi"
        cboGrup.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Grup Produksi") = "-"
        cboGrup.SelectedIndex = cboGrup.Items.Count - 1

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboUnitProduksi.DataSource = DS.Tables("View")
        cboUnitProduksi.DisplayMember = "Unit Produksi"
        cboUnitProduksi.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"
        cboUnitProduksi.SelectedIndex = cboUnitProduksi.Items.Count - 1
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTransaksi.Enabled = True

        _NoTransaksi = "<AUTO>"

        txtNoTransaksi.Text = ""
        txtNoTransaksi.Text = _NoTransaksi
        txtTanggal.Value = Now
        cboGrup.SelectedIndex = cboGrup.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        txtItem.Tag = ""
        txtItem.Text = ""

        txtNoPermintaan.Text = ""
        txtTglPermintaan.Text = ""
        cboUnitProduksi.SelectedIndex = cboUnitProduksi.Items.Count - 1
        txtQtyBon.Text = ""
        txtQtyRealisasi.Text = ""
        txtQtySisa.Text = ""

        txtLokasiAsal.Tag = ""
        txtLokasiAsal.Text = ""
        txtLokasiTujuan.Tag = ""
        txtLokasiTujuan.Text = ""

        txtKodeProduksi.Text = ""
        txtJumlahBox.Text = ""

        Grid1.Rows.Clear()
        Grid2.Rows.Clear()

        txtTotalBobin.Text = ""
        txtTotalTimbang.Text = ""

        If _ID <> "" Then
            txtNoPermintaan.Text = _ID
            txtNoPermintaan_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmInventoryTransferBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        ResetData()
    End Sub

    Private Sub txtNoPermintaan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoPermintaan.Validating
        If txtNoTransaksi.Text <> "" Then
            Dim DaftarPermintaanBenang As New DaftarPermintaanBenang(ActiveSession)
            Dim HeaderPermintaanBenang As HeaderPermintaanBenang = DaftarPermintaanBenang.FindHeader(txtNoPermintaan.Text)

            If Not IsNothing(HeaderPermintaanBenang) Then
                txtNoPermintaan.Enabled = False
                txtTglPermintaan.Value = HeaderPermintaanBenang.TglPermintaan
                cboUnitProduksi.SelectedValue = HeaderPermintaanBenang.KodeUnit

                txtQtyBon.Value = If(txtKodeShift.Text = "1", HeaderPermintaanBenang.QtyAS1, _
                                           If(txtKodeShift.Text = "2", HeaderPermintaanBenang.QtyAS2, _
                                               If(txtKodeShift.Text = "3", HeaderPermintaanBenang.QtyAS3, 0)))

                txtQtyRealisasi.Value = If(txtKodeShift.Text = "1", HeaderPermintaanBenang.QtyRS1, _
                                           If(txtKodeShift.Text = "2", HeaderPermintaanBenang.QtyRS2, _
                                               If(txtKodeShift.Text = "3", HeaderPermintaanBenang.QtyRS3, 0)))

                txtQtySisa.Value = txtQtyBon.Value - txtQtyRealisasi.Value
                txtItem.Tag = HeaderPermintaanBenang.KodeItem
                txtItem.Text = " >> " & HeaderPermintaanBenang.NamaItem

                txtLokasiAsal.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
                txtLokasiAsal.Text = New DaftarLokasi(ActiveSession).Find(txtLokasiAsal.Tag).NamaLokasi

                txtLokasiTujuan.Tag = New DaftarUnitProduksi(ActiveSession).Find(cboUnitProduksi.SelectedValue).KodeLokasi
                txtLokasiTujuan.Text = New DaftarLokasi(ActiveSession).Find(txtLokasiTujuan.Tag).NamaLokasi
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        Dim Jam = Now.ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                txtKodeShift.Text = 3
                TglTransaksi = DateAdd("D", -1, Now.Date)
            Else
                txtKodeShift.Text = 1
                TglTransaksi = Now.Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                txtKodeShift.Text = 1
                TglTransaksi = Now.Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                txtKodeShift.Text = 2
                TglTransaksi = Now.Date
            Else
                txtKodeShift.Text = 3
                TglTransaksi = Now.Date
            End If
        End If

        'Jika Hasil lblKodeShift Sebelumnya
        '---------------------------------------------------------------------------------------------------
        If chkShiftSebelumnya.Checked = True Then
            Select Case txtKodeShift.Text
                Case 1
                    txtKodeShift.Text = 3
                    TglTransaksi = DateAdd("D", -1, Now.Date)
                Case 2
                    txtKodeShift.Text = 1
                    TglTransaksi = Now.Date
                Case 3
                    txtKodeShift.Text = 2
                    If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
                        TglTransaksi = DateAdd("D", -1, Now.Date)
                    Else
                        TglTransaksi = Now.Date
                    End If
            End Select
        End If
    End Sub

    Private Sub TotalQty()
        Dim TotalBobin As Double
        Dim TotalTimbang As Double

        For Row As Integer = 0 To Grid1.Rows.Count - 1
            TotalBobin += Grid1.Rows(Row).Cells("Jumlah").Value
            TotalTimbang += Grid1.Rows(Row).Cells("BeratNetto").Value
        Next

        txtTotalBobin.Text = TotalBobin
        txtTotalTimbang.Text = TotalTimbang
    End Sub

    Private Sub SetEnableCommand()
        TotalQty()

        CountValid.Text = Grid1.Rows.Count & " Baris Data"
        CountInvalid.Text = Grid2.Rows.Count & " Baris Data"

        txtJumlahBox.Text = Grid1.Rows.Count

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtTanggal.Text = "", False, True) And _
                         If(cboGrup.SelectedIndex = cboGrup.Items.Count - 1, False, True) And _
                         If(txtNoPermintaan.Text = "", False, True) And _
                         If(txtTglPermintaan.Text = "", False, True) And _
                         If(cboUnitProduksi.SelectedIndex = cboUnitProduksi.Items.Count - 1, False, True) And _
                         If(Grid1.Rows.Count = 0, False, True) And _
                         If(txtTotalTimbang.Text = "", False, True)

    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
            Dim StockBenang As StockBenang = DaftarStockBenang.Find(txtKodeProduksi.Text)

            If Not IsNothing(StockBenang) Then
                If StockBenang.K_NoTimbang = "" Then
                    If StockBenang.KodeItem = txtItem.Tag Then
                        Dim FindRow As Integer = -1
                        For Row As Integer = 0 To Grid1.Rows.Count - 1
                            If txtKodeProduksi.Text = Grid1.Rows(Row).Cells("KodeProduksi").Value Then
                                FindRow = Row
                                Exit For
                            End If
                        Next
                        If FindRow = -1 Then
                            Grid1.Rows.Add(StockBenang.KodeProduksi, _
                                               StockBenang.NamaItem, _
                                               StockBenang.KodeArea, _
                                               If(StockBenang.KodeStatusQC = 1, "OK", _
                                                  If(StockBenang.KodeStatusQC = 2, "NON OK", _
                                                     If(StockBenang.KodeStatusQC = 3, "OVER", _
                                                        If(StockBenang.KodeStatusQC = 4, "UNDER", "")))), _
                                               StockBenang.Jumlah2, _
                                               StockBenang.BeratNetto.ToString("##,##0.000"))
                        End If
                    Else
                        Dim FindRow As Integer = -1
                        For Row As Integer = 0 To Grid2.Rows.Count - 1
                            If txtKodeProduksi.Text = Grid2.Rows(Row).Cells("KodeProduksiWrong").Value Then
                                FindRow = Row
                                Exit For
                            End If
                        Next
                        If FindRow = -1 Then
                            Grid2.Rows.Add(StockBenang.KodeProduksi, _
                                               StockBenang.NamaItem)
                        End If
                    End If
                Else
                    Dim FindRowOut As Integer = -1
                    For Row As Integer = 0 To Grid2.Rows.Count - 1
                        If txtKodeProduksi.Text = Grid2.Rows(Row).Cells("KodeProduksiWrong").Value Then
                            FindRowOut = Row
                            Exit For
                        End If
                    Next
                    If FindRowOut = -1 Then
                        Grid2.Rows.Add(StockBenang.KodeProduksi, _
                                           StockBenang.NamaItem)
                    End If
                End If
            End If

            txtKodeProduksi.Text = ""
            txtKodeProduksi.Focus()
        End If

        SetEnableCommand()

        'Jump:
        '        txtKodeProduksi.Text = ""
        '        txtKodeProduksi.Focus()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTanggal.Value.Date)
        Dim KodeLokasi As String = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'Cek Jika Data Telah Berubah
                If _SaveMode = enumSaveMode.EditMode Then
                    If _TRX <> New DaftarPengeluaranBenang(ActiveSession).FindHeader(txtNoTransaksi.Text).TRX Then
                        MessageBox.Show("Data Ini Telah Diubah User Lain ! " + vbCrLf + "Proses Simpan Data Dibatalkan Oleh Sistem ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        IDData = txtNoTransaksi.Text
                        Me.Close()
                        GoTo Jump
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Tanggal " + txtTanggal.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarPengeluaranBenang As New DaftarPengeluaranBenang(ActiveSession)
                    Dim HeaderPengeluaranBenang As HeaderPengeluaranBenang
                    Dim DetailPengeluaranBenang As DetailPengeluaranBenang

                    Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
                    Dim StockBenang As StockBenang

                    Dim TotalWO As Double = 0

                    'Nomor Transaksi
                    If _SaveMode = enumSaveMode.AddMode Then
                        txtNoTransaksi.Text = DaftarPengeluaranBenang.GetNomorTransaksi(Periode)
                    End If

                    'Baca Pemakaian Bahan
                    '---------------------------------------------------------------------------------------------------
                    HeaderPengeluaranBenang = DaftarPengeluaranBenang.FindHeader(txtNoTransaksi.Text)
                    If Not IsNothing(HeaderPengeluaranBenang) Then
                        'Hapus Detail Pemakaian Bahan Internal
                        DaftarPengeluaranBenang.DeleteDetail(txtNoTransaksi.Text)
                    End If

                    'Simpan Header Pengeluaran Benang
                    '----------------------------------------------------------------------------------------------------
                    HeaderPengeluaranBenang = New HeaderPengeluaranBenang

                    HeaderPengeluaranBenang.NoTransaksi = txtNoTransaksi.Text
                    HeaderPengeluaranBenang.TglTransaksi = TglTransaksi
                    HeaderPengeluaranBenang.TglPengeluaran = txtTanggal.Value
                    HeaderPengeluaranBenang.KodeShift = txtKodeShift.Text
                    HeaderPengeluaranBenang.KodeGrup = cboGrup.SelectedValue
                    HeaderPengeluaranBenang.NoPermintaan = txtNoPermintaan.Text
                    HeaderPengeluaranBenang.TglPermintaan = txtTglPermintaan.Value.Date
                    HeaderPengeluaranBenang.KodeUnit = cboUnitProduksi.SelectedValue
                    HeaderPengeluaranBenang.KodeItem = txtItem.Tag
                    HeaderPengeluaranBenang.NamaItem = Replace(txtItem.Text, " >> ", "")
                    HeaderPengeluaranBenang.QtyPermintaan = txtQtyBon.Value
                    HeaderPengeluaranBenang.QtyRealisasi = txtTotalTimbang.Value
                    HeaderPengeluaranBenang.UserID = ActiveSession.KodeUser

                    If _SaveMode = enumSaveMode.AddMode Then
                        DaftarPengeluaranBenang.AddHeader(HeaderPengeluaranBenang)
                    Else
                        DaftarPengeluaranBenang.EditHeader(HeaderPengeluaranBenang)
                    End If

                    'Simpan Detail Pengeluaran Benang
                    '------------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer = 0
                    Dim Row As Integer = 0
                    Dim NoTimbangKeluar As String = DaftarStockBenang.GetNomorTransaksiOut(Periode)

                    For Row = 0 To Grid1.Rows.Count - 1
                        If Grid1.Rows(Row).Cells("KodeProduksi").Value <> "" Then
                            'Simpan Detail Pengeluaran Benang
                            '-------------------------------------------------------
                            NoUrut += 1

                            DetailPengeluaranBenang = New DetailPengeluaranBenang
                            DetailPengeluaranBenang.KodeProduksi = Grid1.Rows(Row).Cells("KodeProduksi").Value
                            DetailPengeluaranBenang.NoTransaksi = txtNoTransaksi.Text
                            DetailPengeluaranBenang.NoUrut = NoUrut
                            DetailPengeluaranBenang.Qty = Grid1.Rows(Row).Cells("BeratNetto").Value

                            DaftarPengeluaranBenang.AddDetail(DetailPengeluaranBenang)

                            'Update Pengeluaran (Produksi Benang)
                            '-------------------------------------------------------
                            StockBenang = New StockBenang
                            StockBenang.KodeProduksi = Grid1.Rows(Row).Cells("KodeProduksi").Value
                            StockBenang.K_NoTimbang = NoTimbangKeluar
                            StockBenang.K_TglTransaksi = TglTransaksi
                            StockBenang.K_TglTimbang = txtTanggal.Value
                            StockBenang.K_KodeShift = txtKodeShift.Text
                            StockBenang.K_KodeGrup = cboGrup.SelectedValue
                            StockBenang.K_KodeUnit = cboUnitProduksi.SelectedValue
                            StockBenang.K_UserID = ActiveSession.KodeUser

                            DaftarStockBenang.Edit(StockBenang)

                            TotalWO += DetailPengeluaranBenang.Qty

                        End If
                    Next

                    'Inventory Transfer
                    '=================================================================================================
                    Dim SAPStaging As New SAPStaging
                    SAPStaging.PostInventoryTransfer(TglTransaksi, txtItem.Tag, Replace(txtItem.Text, " >> ", ""), txtTotalTimbang.Value, "", txtNoTransaksi.Text, txtLokasiAsal.Tag, txtLokasiTujuan.Tag)

                    'Eksekusi Data Staging
                    '---------------------------------------------------------------------------------------------
                    SAPStaging.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.InventoryTransfer)


                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    If _SaveMode = enumSaveMode.AddMode Then
                        IDData = txtNoPermintaan.Text
                        ResetData()

                        txtNoTransaksi.Focus()
                    Else
                        IDData = txtNoPermintaan.Text
                        Me.Close()
                    End If

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
        If _SaveMode = enumSaveMode.AddMode Then
            txtNoTransaksi.Text = _NoTransaksi
        End If

    End Sub
End Class