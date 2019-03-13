Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmPengakuanStockRoll
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _SaveMode As enumSaveMode
    Private Status As Byte
    Private KodeProduksi As String
    Private NoTransaksi As String
    Private KodeShift As String
    Private KodeLokasi As String

    Private Sub FillCombo()
        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnitPeruntukan.DataSource = DS.Tables("View")
        cboKodeUnitPeruntukan.DisplayMember = "Unit Produksi"
        cboKodeUnitPeruntukan.ValueMember = "Kode"

        'Lokasi Produksi
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboLokasi.DataSource = DS.Tables("View")
        cboLokasi.DisplayMember = "Nama Lokasi"
        cboLokasi.ValueMember = "Kode"
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtPanjangLama.Text = ""
        txtBeratLama.Text = ""
        txtPanjangBaru.Text = ""
        txtBeratBaru.Text = ""
        cboLokasi.SelectedIndex = -1
        cboKodeUnit.SelectedIndex = -1
        cboKodeUnitPeruntukan.SelectedIndex = -1
        txtKeterangan.Text = ""

        lblStatus.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
            Dim StockRoll As StockRoll = DaftarStockRoll.FindExist(txtKodeProduksi.Text.Trim)
            If Not IsNothing(StockRoll) Then
                txtKodeItem.Text = StockRoll.KodeItem
                txtNamaItem.Text = StockRoll.NamaItem
                txtKodeItem.ReadOnly = True

                cboKodeUnit.SelectedValue = StockRoll.KodeUnit

                If StockRoll.StatusStock = 0 Then
                    _SaveMode = enumSaveMode.AddMode
                    Status = 0

                    txtPanjangLama.Value = 0
                    txtBeratLama.Value = 0

                    lblStatus.Text = "OUT"
                    lblStatus.ForeColor = Color.Red
                End If
                If StockRoll.StatusStock = 1 Then
                    _SaveMode = enumSaveMode.EditMode
                    Status = 1

                    txtPanjangLama.Value = StockRoll.PanjangRoll
                    txtBeratLama.Value = StockRoll.BeratNetto

                    lblStatus.Text = "AVALAIBLE"
                    lblStatus.ForeColor = Color.Blue
                End If
            Else
                _SaveMode = enumSaveMode.AddMode
                Status = 2

                txtKodeItem.Text = ""
                txtNamaItem.Text = ""
                txtKodeItem.ReadOnly = False

                lblStatus.Text = "NOTHING"
                lblStatus.ForeColor = Color.Black

                cboKodeUnit.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub frmPengakuanStockRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        If txtKodeItem.Text <> "" Then
            If Status = 2 Then
                Dim SAP As New SAPInventory
                Dim Item As String = SAP.GetItem(txtKodeItem.Text)

                If Item <> "" Then
                    txtNamaItem.Text = SAP.GetItem(txtKodeItem.Text)
                Else
                    txtKodeItem.Text = ""
                    txtKodeItem.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                Dim Periode As String = GetPeriodFull(Now)
                Dim PeriodeTransaksi As String = GetPeriod(Now)
                Dim TglTransaksi As DateTime = Now

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarPengakuanRoll As New DaftarPengakuanRoll(ActiveSession)
                    Dim PengakuanRoll As New PengakuanRoll

                    Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                    Dim StockRoll As New StockRoll

                    Dim DaftarStatusQc As New DaftarQCUpdateStatusRoll(ActiveSession)
                    Dim StatusQc As New QCUpdateStatusRoll


                    If _SaveMode = enumSaveMode.AddMode Then
                        KodeProduksi = DaftarStockRoll.GetKodeProduksiNew("99", cboKodeUnit.SelectedValue, Periode)
                    Else
                        KodeProduksi = txtKodeProduksi.Text.Trim
                    End If

                    NoTransaksi = DaftarPengakuanRoll.GetNomorTransaksi("PROP", PeriodeTransaksi)

                    'Simpan Data Pengakuan Roll
                    PengakuanRoll.NoTransaksi = NoTransaksi
                    PengakuanRoll.TglTransaksi = TglTransaksi
                    PengakuanRoll.KodeProduksiInput = txtKodeProduksi.Text
                    PengakuanRoll.KodeProduksi = KodeProduksi
                    PengakuanRoll.KodeItem = txtKodeItem.Text
                    PengakuanRoll.NamaItem = txtNamaItem.Text
                    PengakuanRoll.PanjangOld = txtPanjangLama.Value
                    PengakuanRoll.BeratOld = txtBeratLama.Value
                    PengakuanRoll.PanjangNew = txtPanjangBaru.Value
                    PengakuanRoll.BeratNew = txtBeratBaru.Value
                    PengakuanRoll.KodeUnit = cboKodeUnit.SelectedValue
                    PengakuanRoll.KodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                    PengakuanRoll.Keterangan = txtKeterangan.Text
                    PengakuanRoll.UserID = ActiveSession.KodeUser
                    DaftarPengakuanRoll.Add(PengakuanRoll)

                    'Simpan Data StockRoll
                    StockRoll.NoTransaksi = NoTransaksi
                    StockRoll.TglTransaksi = TglTransaksi.Date
                    StockRoll.TglTimbang = TglTransaksi
                    StockRoll.NomorWO = "STOCK OPNAME"
                    StockRoll.KodeItem = txtKodeItem.Text
                    StockRoll.NamaItem = txtNamaItem.Text
                    StockRoll.KodeShift = KodeShift
                    StockRoll.KodeGrup = ""
                    StockRoll.KodeUnit = cboKodeUnit.SelectedValue
                    StockRoll.KodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                    StockRoll.KodeMesin = ""
                    StockRoll.KodeLokasi = cboLokasi.SelectedValue
                    StockRoll.KodeProduksi = KodeProduksi
                    StockRoll.BeratBrutto = txtBeratBaru.Value
                    StockRoll.KodeMedia = ""
                    StockRoll.JumlahMedia = 0
                    StockRoll.BeratMedia = 0
                    StockRoll.BeratNetto = txtBeratBaru.Value
                    StockRoll.PanjangRoll = txtPanjangBaru.Value
                    StockRoll.Pcs = 0
                    StockRoll.Transaksi = 1         ' Hasil Produksi
                    StockRoll.StatusStock = 1       ' Stock Aktif
                    StockRoll.StatusQc = 1
                    StockRoll.KodeStatus = ""
                    StockRoll.StatusDisposisi = 0
                    StockRoll.KodeDisposisi = ""
                    StockRoll.Satuan1 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan1
                    StockRoll.Satuan2 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan2
                    StockRoll.Satuan3 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan3
                    StockRoll.Jumlah1 = 1
                    StockRoll.Jumlah2 = txtPanjangBaru.Value
                    StockRoll.Jumlah3 = txtBeratBaru.Value
                    StockRoll.Keterangan = txtKeterangan.Text
                    StockRoll.InputData = 0
                    StockRoll.UserID = ActiveSession.KodeUser
                    DaftarStockRoll.Add(StockRoll)

                    ''Simpan Transaksi Status Quality Control
                    '--------------------------------------------------------------------------------------------------------
                    StatusQc.TglUpdate = TglTransaksi
                    StatusQc.KodeProduksi = KodeProduksi
                    StatusQc.StatusQcLama = 0
                    StatusQc.StatusQcBaru = 1
                    StatusQc.KodeStatus = ""
                    StatusQc.KodeUnitLama = ""
                    StatusQc.KodeUnitBaru = cboKodeUnit.SelectedValue
                    StatusQc.KetPeruntukanLama = ""
                    StatusQc.KetPeruntukanBaru = txtKeterangan.Text
                    StatusQc.KodeDisposisi = ""
                    StatusQc.UserID = ActiveSession.KodeUser

                    DaftarStatusQc.Add(StatusQc)
                    '--------------------------------------------------------------------------------------------------------

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    PrintBarcode(NoTransaksi)

                    Me.Cursor = Cursors.Default

                    ResetData()
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
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtKodeProduksi.Text = "", False, True) And _
                         If(txtKodeItem.Text = "", False, True) And _
                         If(txtNamaItem.Text = "", False, True) And _
                         If(txtPanjangBaru.Value = 0, False, True) And _
                         If(txtBeratBaru.Value = 0, False, True) And _
                         If(cboLokasi.SelectedIndex = -1, False, True) And _
                         If(cboKodeUnit.SelectedIndex = -1, False, True) And _
                         If(cboKodeUnitPeruntukan.SelectedIndex = -1, False, True)
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                        txtKodeProduksi.TextChanged,
                        txtKodeItem.TextChanged,
                        txtPanjangBaru.TextChanged,
                        txtBeratBaru.TextChanged,
                        cboLokasi.SelectedIndexChanged,
                        cboKodeUnit.SelectedIndexChanged,
                        cboKodeUnitPeruntukan.SelectedIndexChanged,
                        txtKeterangan.TextChanged

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
End Class