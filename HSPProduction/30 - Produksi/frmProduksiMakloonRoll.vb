Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmProduksiMakloonRoll
    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _SaveMode As enumSaveMode

    Private _NoTransaksi As String
    Private _KodeProduksi As String

    Private KodeShift As String
    Private KodeLokasi As String
    Private Panjang As Double = 0
    Private Berat As Double = 0

    Private Sub FillCombo()
        Dim DS As DataSet

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"
    End Sub

    Private Sub ResetData()
        Call tmrJam_Tick(Nothing, Nothing)
        _NoTransaksi = "<AUTO>"

        txtNoTransaksi.Text = _NoTransaksi
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtKodeProduksi.Text = ""
        txtPanjangRoll.Text = ""
        txtBeratRoll.Text = ""

        cboKodeUnit.SelectedValue = GetSetting(enumFormID.frmMakloon, enumSetting.settingKodeUnit)
        KodeLokasi = GetSetting(enumFormID.frmMakloon, enumSetting.settingKodeLokasi)

        SetEnableCommand()
    End Sub

    Private Sub frmProduksiMakloon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        If txtKodeItem.Text <> "" Then
            Dim SAP As New SAPInventory
            Dim Item As String = SAP.GetItem(txtKodeItem.Text)

            If Item <> "" Then
                txtNamaItem.Text = SAP.GetItem(txtKodeItem.Text)
            Else
                txtKodeItem.Text = ""
                txtKodeItem.Focus()
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim SAP As New SAPInventory
            Dim Stock As Stock = SAP.FindStockByItem(KodeLokasi, txtKodeItem.Text, txtKodeProduksi.Text)
            If Not IsNothing(Stock) Then
                txtPanjangRoll.Text = Stock.Panjang
                txtBeratRoll.Text = Stock.Berat
            Else
                txtPanjangRoll.Text = ""
                txtBeratRoll.Text = ""
                MessageBox.Show("Kode Produksi Tidak Terdaftar...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodeProduksi.Focus()
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Shift & Tanggal Transaksi
        Dim Jam = Now.ToLongTimeString
        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                KodeShift = 3
            Else
                KodeShift = 1
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                KodeShift = 1
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                KodeShift = 2
            Else
                KodeShift = 3
            End If
        End If
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                        cboKodeUnit.SelectedIndexChanged,
                        txtNoTransaksi.TextChanged,
                        txtTglPencatatan.ValueChanged,
                        txtKodeItem.TextChanged,
                        txtKodeProduksi.TextChanged,
                        txtKeterangan.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTglPencatatan.Value.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Tanggal " + txtTglPencatatan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try

                    Dim DaftarProduksiMakloonRoll As New DaftarProduksiMakloonRoll(ActiveSession)
                    Dim ProduksiMakloonRoll As New ProduksiMakloonRoll

                    Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                    Dim StockRoll As New StockRoll

                    'Nomor Timbang
                    txtNoTransaksi.Text = DaftarProduksiMakloonRoll.GetNomorTransaksi("LMEX", Periode)

                    'Simpan Pengakuan Makloon
                    ProduksiMakloonRoll.NoTransaksi = txtNoTransaksi.Text
                    ProduksiMakloonRoll.TglTransaksi = txtTglPencatatan.Value.Date
                    ProduksiMakloonRoll.TglPencatatan = txtTglPencatatan.Value
                    ProduksiMakloonRoll.KodeItem = txtKodeItem.Text
                    ProduksiMakloonRoll.NamaItem = txtNamaItem.Text
                    ProduksiMakloonRoll.KodeShift = KodeShift
                    ProduksiMakloonRoll.KodeUnit = cboKodeUnit.SelectedValue
                    ProduksiMakloonRoll.KodeUnitPeruntukan = cboKodeUnit.SelectedValue
                    ProduksiMakloonRoll.Keterangan = txtKeterangan.Text
                    ProduksiMakloonRoll.KodeLokasi = KodeLokasi
                    ProduksiMakloonRoll.KodeProduksi = UCase(txtKodeProduksi.Text)
                    ProduksiMakloonRoll.BeratNetto = txtBeratRoll.Value
                    ProduksiMakloonRoll.Panjang = txtPanjangRoll.Value
                    ProduksiMakloonRoll.StatusQC = 1
                    ProduksiMakloonRoll.UserID = ActiveSession.KodeUser
                    ProduksiMakloonRoll.StatusTransaksi = 1

                    DaftarProduksiMakloonRoll.Add(ProduksiMakloonRoll)

                    'Simpan Stock Roll
                    StockRoll.NoTransaksi = txtNoTransaksi.Text
                    StockRoll.TglTransaksi = txtTglPencatatan.Value.Date
                    StockRoll.TglTimbang = txtTglPencatatan.Value
                    StockRoll.NomorWO = "MAKLOON"
                    StockRoll.KodeItem = txtKodeItem.Text
                    StockRoll.NamaItem = txtNamaItem.Text
                    StockRoll.KodeShift = KodeShift
                    StockRoll.KodeGrup = ""
                    StockRoll.KodeUnit = cboKodeUnit.SelectedValue
                    StockRoll.KodeUnitPeruntukan = cboKodeUnit.SelectedValue
                    StockRoll.KodeMesin = ""
                    StockRoll.KodeLokasi = KodeLokasi
                    StockRoll.KodeProduksi = UCase(txtKodeProduksi.Text)
                    StockRoll.BeratBrutto = txtBeratRoll.Value
                    StockRoll.KodeMedia = ""
                    StockRoll.JumlahMedia = 0
                    StockRoll.BeratMedia = 0
                    StockRoll.BeratNetto = txtBeratRoll.Value
                    StockRoll.PanjangRoll = txtPanjangRoll.Value
                    StockRoll.Pcs = 0
                    StockRoll.Transaksi = 3         ' Makloon
                    StockRoll.StatusStock = 1       ' Stock Aktif
                    StockRoll.StatusQc = 1
                    StockRoll.KodeStatus = ""
                    StockRoll.StatusDisposisi = 0
                    StockRoll.KodeDisposisi = ""
                    StockRoll.Satuan1 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan1
                    StockRoll.Satuan2 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan2
                    StockRoll.Satuan3 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan3
                    StockRoll.Jumlah1 = 1
                    StockRoll.Jumlah2 = txtPanjangRoll.Value
                    StockRoll.Jumlah3 = txtBeratRoll.Value
                    StockRoll.Keterangan = txtKeterangan.Text
                    StockRoll.InputData = 0
                    StockRoll.UserID = ActiveSession.KodeUser
                    DaftarStockRoll.Add(StockRoll)

                    Scope.Complete()
                    Scope.Dispose()

                    PrintBarcode(txtNoTransaksi.Text.Trim)

                    Me.Cursor = Cursors.Default

                    ResetData()
                    '---------------------------------------------------------------------------------------------------------
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

    Private Sub SetEnableCommand()
        btSave.Enabled = If(cboKodeUnit.Text = "", False, True) And _
                         If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtKodeItem.Text = "", False, True) And _
                         If(txtNamaItem.Text = "", False, True) And _
                         If(txtKodeProduksi.Text = "", False, True) And _
                         If(txtPanjangRoll.Value = 0, False, True) And _
                         If(txtBeratRoll.Value = 0, False, True)
    End Sub

    Private Sub PrintBarcode(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
        Dim StockRoll As StockRoll = DaftarStockRoll.FindTimbang(NoTransaksi)

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeRoll.btw", False, "")

        If Not IsNothing(StockRoll) Then
            FormatBt.SetNamedSubStringValue("NoTransaksi", StockRoll.NoTransaksi)
            FormatBt.SetNamedSubStringValue("Tanggal", StockRoll.TglTransaksi)
            FormatBt.SetNamedSubStringValue("NomorSpk", StockRoll.NomorWO)
            FormatBt.SetNamedSubStringValue("NamaItem", StockRoll.NamaItem)
            FormatBt.SetNamedSubStringValue("Unit", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnit).NamaUnit)
            FormatBt.SetNamedSubStringValue("UnitPeruntukan", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnitPeruntukan).NamaUnit)
            FormatBt.SetNamedSubStringValue("Kode", StockRoll.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeMesin", StockRoll.KodeMesin)
            FormatBt.SetNamedSubStringValue("BeratNetto", StockRoll.BeratNetto)
            FormatBt.SetNamedSubStringValue("PanjangRoll", StockRoll.PanjangRoll)
            FormatBt.SetNamedSubStringValue("Pcs", StockRoll.Pcs)
            FormatBt.SetNamedSubStringValue("BeratPerMeter", StockRoll.BeratPerMeter)
            FormatBt.SetNamedSubStringValue("Status", "A")
            FormatBt.SetNamedSubStringValue("KodeStatus", If(StockRoll.StatusQc = 0, "NONE", If(StockRoll.StatusQc = 1, "OK", If(StockRoll.StatusQc = 2, "NON OK", If(StockRoll.StatusQc = 3, "OVER", If(StockRoll.StatusQc = 4, "UNDER", ""))))))
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(StockRoll.Keterangan) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtPanjangRoll.Enter, txtBeratRoll.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

End Class