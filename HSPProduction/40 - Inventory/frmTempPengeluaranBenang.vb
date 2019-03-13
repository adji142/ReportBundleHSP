Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmTempPengeluaranBenang
    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _SaveMode As enumSaveMode

    'Variable Declaration
    Private TglTransaksi As DateTime

    Private _NoTransaksi As String
    Private _TRX As String = ""

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
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
        cboKodeGrup.DataSource = DS.Tables("View")
        cboKodeGrup.DisplayMember = "Grup Produksi"
        cboKodeGrup.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Grup Produksi") = "-"
        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTransaksi.Enabled = True
        Locked.Visible = False

        txtNoTransaksi.Text = ""
        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi

        txtTglPengeluaran.Text = ""
        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        txtNoPermintaan.Text = ""
        txtTglPermintaan.Text = ""
        txtItemProduksi.Text = ""
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        txtQtyPermintaan.Text = ""
        txtQtyRealisasi.Text = ""
        txtQtySisa.Text = ""

        txtKodeProduksi.Text = ""
        GridValid.Rows.Clear()
        'GridInvalid.Rows.Clear()
        txtTotalQty.Text = ""

        If _ID <> "" Then
            txtNoPermintaan.Text = _ID
            txtNoPermintaan_Validating(Nothing, Nothing)
            _ID = ""
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
    End Sub

    Private Sub frmPengeluaranBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        ResetData()
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating

    End Sub

    Private Sub txtNoPermintaan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoPermintaan.Validating
        If txtNoTransaksi.Text <> "" Then
            Dim DaftarPermintaanBenang As New DaftarPermintaanBenang(ActiveSession)
            Dim HeaderPermintaanBenang As HeaderPermintaanBenang = DaftarPermintaanBenang.FindHeader(txtNoPermintaan.Text)

            If Not IsNothing(HeaderPermintaanBenang) Then
                txtNoPermintaan.Enabled = False
                txtTglPermintaan.Value = HeaderPermintaanBenang.TglPermintaan
                cboKodeUnit.SelectedValue = HeaderPermintaanBenang.KodeUnit

                txtQtyPermintaan.Text = If(txtKodeShift.Text = "1", HeaderPermintaanBenang.QtyAS1, _
                                           If(txtKodeShift.Text = "2", HeaderPermintaanBenang.QtyAS2, _
                                               If(txtKodeShift.Text = "3", HeaderPermintaanBenang.QtyAS3, 0)))

                txtQtyRealisasi.Text = If(txtKodeShift.Text = "1", HeaderPermintaanBenang.QtyRS1, _
                                           If(txtKodeShift.Text = "2", HeaderPermintaanBenang.QtyRS2, _
                                               If(txtKodeShift.Text = "3", HeaderPermintaanBenang.QtyRS3, 0)))

                txtQtySisa.Text = txtQtyPermintaan.Value - txtQtyRealisasi.Value
                txtItemProduksi.Tag = HeaderPermintaanBenang.KodeItem
                txtItemProduksi.Text = HeaderPermintaanBenang.NamaItem
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
            Dim StockBenang As StockBenang = DaftarStockBenang.Find(txtKodeProduksi.Text)

            If Not IsNothing(StockBenang) Then
                If StockBenang.K_NoTimbang = "" Then
                    If StockBenang.KodeItem = txtItemProduksi.Tag Then
                        Dim FindRow As Integer = -1
                        For Row As Integer = 0 To GridValid.Rows.Count - 1
                            If txtKodeProduksi.Text = GridValid.Rows(Row).Cells("Kode").Value Then
                                FindRow = Row
                                Exit For
                            End If
                        Next
                        If FindRow = -1 Then
                            GridValid.Rows.Add(StockBenang.KodeProduksi, _
                                               StockBenang.NamaItem, _
                                               StockBenang.KodeArea, _
                                               If(StockBenang.KodeStatusQC = 1, "OK", _
                                                  If(StockBenang.KodeStatusQC = 2, "NON OK", _
                                                     If(StockBenang.KodeStatusQC = 3, "OVER", _
                                                        If(StockBenang.KodeStatusQC = 4, "UNDER", "")))), _
                                               StockBenang.Jumlah2 & Space(1) & StockBenang.Satuan2, _
                                               StockBenang.BeratNetto.ToString("##,##0.000"))
                        End If
                    Else
                        Dim FindRow As Integer = -1
                        For Row As Integer = 0 To GridInvalid.Rows.Count - 1
                            If txtKodeProduksi.Text = GridInvalid.Rows(Row).Cells("KodeInvalid").Value Then
                                FindRow = Row
                                Exit For
                            End If
                        Next
                        If FindRow = -1 Then
                            GridInvalid.Rows.Add(StockBenang.KodeProduksi, _
                                               StockBenang.NamaItem)
                        End If
                    End If
                Else
                    Dim FindRowOut As Integer = -1
                    For Row As Integer = 0 To GridInvalid.Rows.Count - 1
                        If txtKodeProduksi.Text = GridInvalid.Rows(Row).Cells("KodeInvalid").Value Then
                            FindRowOut = Row
                            Exit For
                        End If
                    Next
                    If FindRowOut = -1 Then
                        GridInvalid.Rows.Add(StockBenang.KodeProduksi, _
                                           StockBenang.NamaItem)
                    End If
                End If
            End If

            txtKodeProduksi.Text = ""
            txtKodeProduksi.Focus()
        End If

        SetEnableCommand()
    End Sub

    Private Sub TotalQty()
        Dim Total As Double

        For Row As Integer = 0 To GridValid.Rows.Count - 1
            Total += GridValid.Rows(Row).Cells("QtyTimbang").Value
        Next

        txtTotalQty.Text = Total
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTglPengeluaran.Value.Date)
        Dim KodeLokasi As String = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeLokasi

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'Cek Jika Data Telah Berubah
                If _SaveMode = enumSaveMode.EditMode Then
                    If _TRX <> New TempDaftarPengeluaranBenang(ActiveSession).FindHeader(txtNoTransaksi.Text).TRX Then
                        MessageBox.Show("Data Ini Telah Diubah User Lain ! " + vbCrLf + "Proses Simpan Data Dibatalkan Oleh Sistem ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        IDData = txtNoTransaksi.Text
                        Me.Close()
                        GoTo Jump
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Tanggal " + txtTglPengeluaran.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarPengeluaranBenang As New TempDaftarPengeluaranBenang(ActiveSession)
                    Dim HeaderPengeluaranBenang As TempHeaderPengeluaranBenang
                    Dim DetailPengeluaranBenang As TempDetailPengeluaranBenang

                    Dim DaftarStockBenang As New DaftarStockBenangTemp(ActiveSession)
                    Dim StockBenang As StockBenangTemp

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
                    HeaderPengeluaranBenang = New TempHeaderPengeluaranBenang

                    HeaderPengeluaranBenang.NoTransaksi = txtNoTransaksi.Text
                    HeaderPengeluaranBenang.TglTransaksi = TglTransaksi
                    HeaderPengeluaranBenang.TglPengeluaran = txtTglPengeluaran.Value
                    HeaderPengeluaranBenang.KodeShift = txtKodeShift.Text
                    HeaderPengeluaranBenang.KodeGrup = cboKodeGrup.SelectedValue
                    HeaderPengeluaranBenang.NoPermintaan = txtNoPermintaan.Text
                    HeaderPengeluaranBenang.TglPermintaan = txtTglPermintaan.Value.Date
                    HeaderPengeluaranBenang.KodeUnit = cboKodeUnit.SelectedValue
                    HeaderPengeluaranBenang.KodeItem = txtItemProduksi.Tag
                    HeaderPengeluaranBenang.NamaItem = txtItemProduksi.Text
                    HeaderPengeluaranBenang.QtyPermintaan = txtQtyPermintaan.Value
                    HeaderPengeluaranBenang.QtyRealisasi = txtTotalQty.Value
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

                    For Row = 0 To GridValid.Rows.Count - 1
                        If GridValid.Rows(Row).Cells("Kode").Value <> "" Then
                            'Simpan Detail Pengeluaran Benang
                            '-------------------------------------------------------
                            NoUrut += 1

                            DetailPengeluaranBenang = New TempDetailPengeluaranBenang
                            DetailPengeluaranBenang.KodeProduksi = GridValid.Rows(Row).Cells("Kode").Value
                            DetailPengeluaranBenang.NoTransaksi = txtNoTransaksi.Text
                            DetailPengeluaranBenang.NoUrut = NoUrut
                            DetailPengeluaranBenang.Qty = GridValid.Rows(Row).Cells("QtyTimbang").Value

                            DaftarPengeluaranBenang.AddDetail(DetailPengeluaranBenang)

                            'Update Pengeluaran (Produksi Benang)
                            '-------------------------------------------------------
                            StockBenang = New StockBenangTemp
                            StockBenang.KodeProduksi = GridValid.Rows(Row).Cells("Kode").Value
                            StockBenang.K_NoTimbang = NoTimbangKeluar
                            StockBenang.K_TglTransaksi = txtTglPengeluaran.Value.Date
                            StockBenang.K_TglTimbang = txtTglPengeluaran.Value
                            StockBenang.K_KodeShift = txtKodeShift.Text
                            StockBenang.K_KodeGrup = cboKodeGrup.SelectedValue
                            StockBenang.K_KodeUnit = cboKodeUnit.SelectedValue
                            StockBenang.K_UserID = ActiveSession.KodeUser

                            DaftarStockBenang.Edit(StockBenang)

                        End If
                    Next

                    Dim DaftarWO = New DaftarPermintaanBenang(ActiveSession).ReadDetail(txtNoPermintaan.Text)
                    Dim DR As DataRow
                    Dim QtyPerWO As Double
                    Dim NomorWO As String
                    Dim SAPStaging As New SAPStaging

                    For Each DR In DaftarWO.Tables("View").Rows
                        NomorWO = DR("Nomor")
                        QtyPerWO = (txtTotalQty.Value * (DR("Prosentase") / 100))

                        'Posting Staging
                        '---------------------------------------------------------------------------------------------
                        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
                        SAPStaging.PostMaterialIssue(KodeUnitSAP, NomorWO, txtTglPengeluaran.Value.Date, txtItemProduksi.Tag, QtyPerWO, "", txtNoTransaksi.Text, KodeLokasi)
                        'SAPStaging.PostMaterialReceipt(KodeUnitSAP, NomorWO, txtTglPengeluaran.Value.Date, txtItemProduksi.Tag, QtyPerWO, QtyPerWO, "", txtNoTransaksi.Text)
                    Next

                    'Eksekusi Data Staging
                    '---------------------------------------------------------------------------------------------
                    SAPStaging.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)
                    'SAPStaging.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)


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

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            txtNoTransaksi.TextChanged,
                            txtTglPengeluaran.ValueChanged,
                            cboKodeGrup.SelectedIndexChanged,
                            txtNoPermintaan.TextChanged,
                            txtTglPermintaan.ValueChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            txtTotalQty.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        TotalQty()

        CountValid.Text = GridValid.Rows.Count & " Baris Data"
        CountInvalid.Text = GridInvalid.Rows.Count & " Baris Data"

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtTglPengeluaran.Text = "", False, True) And _
                         If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(txtNoPermintaan.Text = "", False, True) And _
                         If(txtTglPermintaan.Text = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(GridValid.Rows.Count = 0, False, True) And _
                         If(txtTotalQty.Text = "", False, True)

    End Sub

    Private Sub btLookupKodeProduksi_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksi.Click
        'Baca Data
        Dim DaftarStockBenangTemp As New DaftarStockBenangTemp(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarStockBenangTemp.ReadByCode(txtItemProduksi.Tag)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        GridValid.RowTemplate.Height = 16
        GridValid.DataSource = BS

        SetEnableCommand()
    End Sub
End Class
