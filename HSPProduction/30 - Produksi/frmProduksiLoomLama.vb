Imports System
Imports System.IO
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmProduksiLoomLama

#Region "Variable Declaration"
    Private Enum enumTransaksi
        HasilProduksi = 1
        InventoryTransfer = 2
    End Enum

    Private Enum enumStock
        Masuk = 1
        Keluar = 0
    End Enum

    Private Enum enumStatusQc
        None = 0
        OK = 1
        NonOK = 2
        Over = 3
        Under = 4
    End Enum

    Private Enum enumPeruntukanJahit
        JahitMulut = 1
        TidakJahitMulut = 2
    End Enum

    Private _PrefikKodeProduksi As String
    Private TglTransaksi As DateTime
    Private _NoTransaksi As String
    Private _KodeProduksi As String

    Private TempScale As String
    Private BeratBrutto As Double
    Private BeratMedia As Double
    Private BeratNetto As Double

    Private BeratMeter As Double
    Private Lebar As Double
    Private MeshPakan As Double
    Private MeshLusi As Double
    Private Denier As Double

#End Region

#Region "Fill ComboBox"

    Private Sub FillComboMesin()
        If lblKodeUnit.Tag <> "" Then
            'Mesin Produksi
            Dim DaftarMesin As New DaftarMesin(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMesin.Read("%", lblKodeUnit.Tag)
            cboKodeMesin.DataSource = DS.Tables("View")
            cboKodeMesin.DisplayMember = "Nama Mesin"
            cboKodeMesin.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Mesin") = "-"

            cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1

        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Mesin")

            cboKodeMesin.DataSource = DS.Tables("View")
            cboKodeMesin.DisplayMember = "Nama Mesin"
            cboKodeMesin.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Mesin") = "-"

            cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        End If
    End Sub

    Private Sub FillNomorSPK()
        Try
            If lblKodeUnit.Tag <> "" Then
                Dim SAPWorkOrder As New SAPWorkOrder
                Dim DS As DataSet

                DS = New DataSet
                DS = SAPWorkOrder.ReadFGWorkOrderByUnit(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, Stod(txtTglTransaksi.Text), cboKodeMesin.SelectedValue)
                cboNomorSpk.DataSource = DS.Tables("View")
                cboNomorSpk.DisplayMember = "Nomor"
                cboNomorSpk.ValueMember = "Nomor"

                Dim Drow As DataRow = DS.Tables("View").Rows.Add
                Drow("Nomor") = ""
                Drow("Nomor") = "-"
            Else
                Dim DS As New DataSet
                DS.Tables.Add("View")
                DS.Tables("View").Columns.Add("Nomor")

                cboNomorSpk.DataSource = DS.Tables("View")
                cboNomorSpk.DisplayMember = "Nomor"
                cboNomorSpk.ValueMember = "Nomor"

                Dim Drow As DataRow = DS.Tables("View").Rows.Add
                Drow("Nomor") = ""
                Drow("Nomor") = "-"
            End If

            cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
        Catch
        End Try
    End Sub

    Private Sub FillComboMediaTimbang()
        If lblKodeLokasiProduksi.Tag <> "" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", lblKodeLokasiProduksi.Tag)
            cboKodeMediaTimbang.DataSource = DS.Tables("View")
            cboKodeMediaTimbang.DisplayMember = "Nama Media"
            cboKodeMediaTimbang.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1

        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Media")

            cboKodeMediaTimbang.DataSource = DS.Tables("View")
            cboKodeMediaTimbang.DisplayMember = "Nama Media"
            cboKodeMediaTimbang.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"
        End If
    End Sub

    Private Sub FillComboPeruntukan()
        If lblKodeUnit.Tag <> "" Then
            'Unit Produksi Peruntukan
            Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarUnitProduksi.ReadDetail(lblKodeUnit.Tag)
            cboKodeUnitPeruntukan.DataSource = DS.Tables("View")
            cboKodeUnitPeruntukan.DisplayMember = "Nama Unit Peruntukan"
            cboKodeUnitPeruntukan.ValueMember = "Peruntukan"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Peruntukan") = ""
            Drow("Nama Unit Peruntukan") = "-"

            cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Peruntukan")
            DS.Tables("View").Columns.Add("Nama Unit Peruntukan")

            cboKodeUnitPeruntukan.DataSource = DS.Tables("View")
            cboKodeUnitPeruntukan.DisplayMember = "Nama Unit Peruntukan"
            cboKodeUnitPeruntukan.ValueMember = "Peruntukan"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Peruntukan") = ""
            Drow("Nama Unit Peruntukan") = "-"

            cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1
        End If
    End Sub

    Private Sub FillComboStatusQC()
        Dim DaftarQCStatus As New DaftarQCStatus(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarQCStatus.Read("%", lblKodeUnit.Tag)
        cboKodeStatus.DataSource = DS.Tables("View")
        cboKodeStatus.DisplayMember = "Keterangan"
        cboKodeStatus.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Keterangan") = "-"

        cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1

    End Sub

#End Region

#Region "Controller"
    Private Sub ResetData()
        BeratBrutto = 0
        BeratMedia = 0
        BeratNetto = 0
        TempScale = 0

        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
        lblItemProduksi.Text = ""
        cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1
        txtBeratMedia.Text = ""
        txtBeratNetto.Text = ""
        txtPanjangRoll.Text = ""
        cboStatusQC.SelectedIndex = 0
        cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1
        txtKeterangan.Text = ""

        chkManual.Checked = False
        txtTimbangManual.Text = ""

        'Default Unit Produksi
        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnit.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeUnit)
        If lblKodeUnit.Tag <> "" Then
            Try
                lblKodeUnit.Text = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).NamaUnit.ToUpper()
            Catch ex As Exception
                lblKodeUnit.Tag = ""
                lblKodeUnit.Text = "UNIT PRODUKSI BELUM DISETTING"
            End Try
        Else
            lblKodeUnit.Text = "UNIT PRODUKSI BELUM DISETTING"
        End If
        '-------------------------------------------------------------------------------------------------------------------

        'Default Lokasi Produksi
        '-------------------------------------------------------------------------------------------------------------------
        lblKodeLokasiProduksi.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
        If lblKodeLokasiProduksi.Tag <> "" Then
            Try
                lblKodeLokasiProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblKodeLokasiProduksi.Tag).NamaLokasi.ToUpper()
            Catch ex As Exception
                lblKodeLokasiProduksi.Tag = ""
                lblKodeLokasiProduksi.Text = "LOKASI BELUM DISETTING"
            End Try
        Else
            lblKodeLokasiProduksi.Text = "LOKASI BELUM DISETTING"
        End If
        '-------------------------------------------------------------------------------------------------------------------

        lblStatusTimbang.Text = ""

        lblWarning.Visible = False

        FillComboStatusQC()
        SetEnableCommand()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeMesin.SelectedIndexChanged,
        cboNomorSpk.SelectedIndexChanged,
        cboKodeMediaTimbang.SelectedIndexChanged,
        txtPanjangRoll.TextChanged,
        txtKeterangan.TextChanged,
        cboKodeUnitPeruntukan.SelectedIndexChanged,
        txtKeterangan.TextChanged,
        lblKodeLokasiProduksi.TextChanged,
        cboKodeStatus.SelectedIndexChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeMesin" Then
            If cboKodeMesin.SelectedIndex <> cboKodeMesin.Items.Count - 1 Then
                FillNomorSPK()
            End If

        End If

        '-------------------------------------------------------------------------------------------------------
        If ObjectName = "cboNomorSpk" Then
            If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
                Try
                    lblItemProduksi.Text = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).NamaItem
                    lblItemProduksi.Tag = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).KodeItem
                    Lebar = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).Lebar
                    MeshPakan = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).MeshPakan
                    MeshLusi = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).MeshLusi
                    Denier = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).Denier
                Catch
                End Try
            Else
                lblItemProduksi.Text = ""
                lblItemProduksi.Tag = ""

            End If
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodeMediaTimbang" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMediaTimbang.SelectedValue.ToString)

            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia.Text = MediaTimbang.Berat
            Else
                txtBeratMedia.Text = ""
            End If
        End If
        '-------------------------------------------------------------------------------------------------------

        SetEnableCommand()
    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtPanjangRoll.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Transaksi
        If lblTransaksi.ForeColor = Color.Yellow Then
            lblTransaksi.ForeColor = Color.Blue
        Else
            lblTransaksi.ForeColor = Color.Yellow
        End If

        'Tanggal & Jam Timbang
        lblTglTimbang.Text = Now.Date.ToString("dd") & " " & GetPeriodDescription(Now.Date).ToUpper()
        lblJamTimbang.Text = Now.ToString("HH:mm:ss")

        'Shift & Tanggal Transaksi
        Dim Jam = Now.ToLongTimeString
        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                txtKodeShift.Text = 3
                TglTransaksi = DateAdd("D", -1, Now.Date)
                txtTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
            Else
                txtKodeShift.Text = 1
                TglTransaksi = Now.Date
                txtTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                txtKodeShift.Text = 1
                TglTransaksi = Now.Date
                txtTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                txtKodeShift.Text = 2
                TglTransaksi = Now.Date
                txtTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
            Else
                txtKodeShift.Text = 3
                TglTransaksi = Now.Date
                txtTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
            End If
        End If

        'Keterangan
        Select Case txtKodeShift.Text
            Case 1
                KeteranganShift.Text = "PAGI"
            Case 2
                KeteranganShift.Text = "SIANG"
            Case 3
                KeteranganShift.Text = "MALAM"
        End Select
    End Sub

    Private Sub CalculateWeight()
        'Data diambil dari SAP
        Dim BeratStandard As Double
        Dim BeratStandardMin As Double
        Dim BeratStandardMax As Double

        Dim BeratNettoGram As Double
        Dim BeratActual As Double

        Dim BeratValidasiMax As Double
        Dim BeratValidasiMin As Double

        'Berat Standard Per Meter
        '--------------------------------------------------------------------------------------
        BeratStandard = ((Lebar * 2) * (MeshPakan + MeshLusi) * Denier) / 22860
        BeratStandardMin = BeratStandard - ((3.7 / 100) * BeratStandard)
        BeratStandardMax = BeratStandard
        '--------------------------------------------------------------------------------------

        'Berat u/ validasi input
        '--------------------------------------------------------------------------------------
        BeratValidasiMin = BeratStandardMin - ((5 / 100) * BeratStandard)
        BeratValidasiMax = BeratStandardMax + ((5 / 100) * BeratStandard)

        'Berat Aktual Per Meter
        '--------------------------------------------------------------------------------------
        BeratNettoGram = BeratNetto * 1000
        BeratActual = (BeratNettoGram / txtPanjangRoll.Value)
        BeratMeter = BeratActual

        'Status Normal
        If BeratActual >= BeratStandardMin And BeratActual <= BeratStandardMax Then
            lblStatusTimbang.Text = ""
            lblStatusTimbang.Tag = 0
        End If

        'Status OVER
        If BeratActual > BeratStandardMax Then
            lblStatusTimbang.Text = "BERAT OVER"
            lblStatusTimbang.Tag = 3
        End If

        'Status UNDER
        If BeratActual < BeratStandardMin Then
            lblStatusTimbang.Text = "BERAT UNDER"
            lblStatusTimbang.Tag = 4
        End If

        Label16.Text = BeratStandardMin
        Label18.Text = BeratActual

        'Warning ketika berat standart +- 5%
        If txtPanjangRoll.Value <> 0 Then
            'Standar
            If BeratActual >= BeratValidasiMin And BeratActual <= BeratValidasiMax Then
                tmrWarning.Enabled = False
                lblWarning.Visible = False
            End If

            'Status OVER
            If BeratActual > BeratValidasiMax Then
                tmrWarning.Enabled = True
                lblWarning.Visible = True
                lblWarning.Text = "PERIKSA INPUT DATA PANJANG ROLL (OVER)"
            End If

            'Status UNDER
            If BeratActual < BeratValidasiMin Then
                tmrWarning.Enabled = True
                lblWarning.Visible = True
                lblWarning.Text = "PERIKSA INPUT DATA PANJANG ROLL (UNDER)"
            End If
        End If

    End Sub

    Private Sub frmProduksiLoom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Porttimbangan.Close()
    End Sub

    Private Sub frmPenerimaanRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        ResetData()

        FillComboMesin()
        FillNomorSPK()
        FillComboMediaTimbang()
        FillComboPeruntukan()

        PortConnection()
    End Sub

    Private Sub btLookupKodeMesin_Click(sender As Object, e As EventArgs) Handles btLookupKodeMesin.Click
        Dim DaftarMesinProduksi As IDataLookup = New DaftarMesin(ActiveSession)

        Dim Parameter() As String = {lblKodeUnit.Tag}

        Dim Form As New frmLookup(DaftarMesinProduksi, Parameter)
        Form.Text = "Lookup Daftar Mesin Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMesin.SelectedValue = Form.IDLookup
            cboKodeMesin.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeMediaTimbang_Click(sender As Object, e As EventArgs) Handles btLookupKodeMediaTimbang.Click
        Dim DaftarMediaTimbang As IDataLookup = New DaftarMediaTimbang(ActiveSession)

        Dim Parameter() As String = {lblKodeLokasiProduksi.Tag}

        Dim Form As New frmLookup(DaftarMediaTimbang, Parameter)
        Form.Text = "Lookup Daftar Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMediaTimbang.SelectedValue = Form.IDLookup
            cboKodeMediaTimbang.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeUnitPeruntukan_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnitPeruntukan.Click
        Dim DaftarUnitProduksiPeruntukan As IDataLookup = New DaftarUnitProduksiPeruntukan(ActiveSession)

        Dim Parameter() As String = {lblKodeUnit.Tag}

        Dim Form As New frmLookup(DaftarUnitProduksiPeruntukan, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi Peruntukan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeUnitPeruntukan.SelectedValue = Form.IDLookup
            cboKodeUnitPeruntukan.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupNomorSpk_Click(sender As Object, e As EventArgs) Handles btLookupNomorSpk.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktifByMesin, KodeUnitSAP, Now, cboKodeMesin.SelectedValue}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSpk.SelectedValue = Form.IDLookup
            cboNomorSpk.Focus()
        End If
    End Sub

    Private Sub cboKodeMesin_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeMesin.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeMesin.PerformClick()
        End If
    End Sub

    Private Sub cboKodeMediaTimbang_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeMediaTimbang.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeMediaTimbang.PerformClick()
        End If
    End Sub

    Private Sub cboKodeUnitTo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeUnitPeruntukan.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeUnitPeruntukan.PerformClick()
        End If
    End Sub
#End Region

#Region "Save To Database"
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btReprint.Click
        Dim Periode As String
        Dim PeriodeTransaksi As String
        Dim Satuan1 As String = ""
        Dim Satuan2 As String = ""
        Dim Satuan3 As String = ""

        'Simpan Data Penerimaan Roll
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    Dim DaftarProduksiLoom As New DaftarProduksiLoom(ActiveSession)
                    Dim ProduksiLoom As New ProduksiLoom

                    Dim DaftarStatusQc As New DaftarQCUpdateStatusRoll(ActiveSession)
                    Dim StatusQc As New QCUpdateStatusRoll

                    Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                    Dim StockRoll As New StockRoll

                    Dim TanggalTransaksi As DateTime
                    TanggalTransaksi = DateAdd(DateInterval.Day, -1, TglTransaksi.Date)

                    Periode = GetPeriod(Now)
                    PeriodeTransaksi = GetPeriodFull(Now)

                    'Nomor Timbang
                    _NoTransaksi = DaftarProduksiLoom.GetNomorTransaksi("LMHP", Periode)

                    'Get Kode Produksi
                    _KodeProduksi = DaftarStockRoll.GetKodeProduksi(lblKodeUnit.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)

                    'Ambil data satuan default
                    Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
                    Dim UnitProduksi As UnitProduksi = DaftarUnitProduksi.Find(lblKodeUnit.Tag)
                    If Not IsNothing(UnitProduksi) Then
                        Satuan1 = UnitProduksi.KodeSatuan1
                        Satuan2 = UnitProduksi.KodeSatuan2
                        Satuan3 = UnitProduksi.KodeSatuan3
                    End If

                    'Simpan Transaksi Produksi Loom
                    '-----------------------------------------------------------------------------------------------------
                    ProduksiLoom.NoTransaksi = _NoTransaksi
                    ProduksiLoom.TglTransaksi = TanggalTransaksi
                    ProduksiLoom.TglTimbang = Now
                    ProduksiLoom.NomorWO = cboNomorSpk.SelectedValue
                    ProduksiLoom.KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP
                    ProduksiLoom.KodeItem = lblItemProduksi.Tag
                    ProduksiLoom.NamaItem = lblItemProduksi.Text
                    ProduksiLoom.KodeShift = txtKodeShift.Text
                    ProduksiLoom.KodeGrup = ""
                    ProduksiLoom.KodeUnit = lblKodeUnit.Tag
                    ProduksiLoom.KodeMesin = cboKodeMesin.SelectedValue
                    ProduksiLoom.KodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                    ProduksiLoom.Keterangan = txtKeterangan.Text
                    ProduksiLoom.KodeLokasi = lblKodeLokasiProduksi.Tag
                    ProduksiLoom.KodeProduksi = _KodeProduksi
                    ProduksiLoom.BeratBrutto = BeratBrutto
                    ProduksiLoom.KodeMedia = cboKodeMediaTimbang.SelectedValue
                    ProduksiLoom.JumlahMedia = 1
                    ProduksiLoom.BeratMedia = txtBeratMedia.Value
                    ProduksiLoom.BeratNetto = BeratNetto
                    ProduksiLoom.PanjangRoll = txtPanjangRoll.Value
                    ProduksiLoom.Pcs = 0
                    ProduksiLoom.BeratPerMeter = BeratMeter
                    ProduksiLoom.Transaksi = enumTransaksi.HasilProduksi
                    ProduksiLoom.StatusStock = enumStock.Masuk
                    ProduksiLoom.StatusQC = If(lblStatusTimbang.Tag = 0, cboStatusQC.SelectedIndex, lblStatusTimbang.Tag)
                    ProduksiLoom.KodeStatus = cboKodeStatus.SelectedValue
                    ProduksiLoom.StatusDisposisi = 0
                    ProduksiLoom.KodeDisposisi = ""
                    ProduksiLoom.InputData = 0
                    ProduksiLoom.UserID = ActiveSession.KodeUser
                    ProduksiLoom.StatusTransaksi = 1
                    DaftarProduksiLoom.Add(ProduksiLoom)

                    'Simpan Stock Roll
                    StockRoll.NoTransaksi = _NoTransaksi
                    StockRoll.TglTransaksi = TanggalTransaksi
                    StockRoll.TglTimbang = Now
                    StockRoll.NomorWO = cboNomorSpk.SelectedValue
                    StockRoll.KodeItem = lblItemProduksi.Tag
                    StockRoll.NamaItem = lblItemProduksi.Text
                    StockRoll.KodeShift = txtKodeShift.Text
                    StockRoll.KodeGrup = ""
                    StockRoll.KodeUnit = lblKodeUnit.Tag
                    StockRoll.KodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                    StockRoll.KodeMesin = cboKodeMesin.SelectedValue
                    StockRoll.KodeLokasi = lblKodeLokasiProduksi.Tag
                    StockRoll.KodeProduksi = _KodeProduksi
                    StockRoll.BeratBrutto = BeratBrutto
                    StockRoll.KodeMedia = cboKodeMediaTimbang.SelectedValue
                    StockRoll.JumlahMedia = 1
                    StockRoll.BeratMedia = txtBeratMedia.Value
                    StockRoll.BeratNetto = BeratNetto
                    StockRoll.PanjangRoll = txtPanjangRoll.Value
                    StockRoll.Pcs = 0
                    StockRoll.Transaksi = enumTransaksi.HasilProduksi         ' Hasil Produksi
                    StockRoll.StatusStock = enumStock.Masuk       ' Stock Aktif
                    StockRoll.StatusQc = If(lblStatusTimbang.Tag = 0, cboStatusQC.SelectedIndex, lblStatusTimbang.Tag)
                    StockRoll.KodeStatus = cboKodeStatus.SelectedValue
                    StockRoll.StatusDisposisi = 0
                    StockRoll.KodeDisposisi = ""
                    StockRoll.Satuan1 = UnitProduksi.KodeSatuan1
                    StockRoll.Satuan2 = UnitProduksi.KodeSatuan2
                    StockRoll.Satuan3 = UnitProduksi.KodeSatuan3
                    StockRoll.Jumlah1 = 1
                    StockRoll.Jumlah2 = txtPanjangRoll.Value
                    StockRoll.Jumlah3 = BeratNetto
                    StockRoll.Keterangan = txtKeterangan.Text
                    StockRoll.InputData = 0
                    StockRoll.UserID = ActiveSession.KodeUser
                    DaftarStockRoll.Add(StockRoll)

                    'Simpan Transaksi Status Quality Control
                    '--------------------------------------------------------------------------------------------------------
                    StatusQc.TglUpdate = TglTransaksi
                    StatusQc.KodeProduksi = _KodeProduksi
                    StatusQc.StatusQcLama = 0
                    StatusQc.StatusQcBaru = If(lblStatusTimbang.Tag = 0, cboStatusQC.SelectedIndex, lblStatusTimbang.Tag)
                    StatusQc.KodeStatus = cboKodeStatus.SelectedValue
                    StatusQc.KodeUnitLama = ""
                    StatusQc.KodeUnitBaru = lblKodeUnit.Tag
                    StatusQc.KetPeruntukanLama = ""
                    StatusQc.KetPeruntukanBaru = txtKeterangan.Text
                    StatusQc.KodeDisposisi = ""
                    StatusQc.UserID = ActiveSession.KodeUser

                    DaftarStatusQc.Add(StatusQc)
                    '--------------------------------------------------------------------------------------------------------

                    'Simpan Data Penerimaan Benang Staging
                    '------------------------------------------------------------------------------------------------------
                    Dim SAPStaging As New SAPStaging
                    SAPStaging.PostFinishedGoodReceipt(New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnit.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue, TanggalTransaksi, lblItemProduksi.Tag, txtPanjangRoll.Value, BeratNetto, _KodeProduksi, "", _NoTransaksi, lblKodeLokasiProduksi.Tag)

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        SAPStaging.Execute(_NoTransaksi, HSPProduction.SAPStaging.enumTransaction.FinishedGoodReceipt)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        SAPStaging.RemoveStagingData(_NoTransaksi)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************

                    PrintBarcode(_NoTransaksi)

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
            Case "btReprint"
                '---------------------------------------------------------------------------------------------------------
                PrintBarcode(New DaftarStockRoll(ActiveSession).LastID().NoTransaksi, True)
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------

        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintBarcode(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarProduksiLoom As New DaftarProduksiLoom(ActiveSession)
        Dim ProduksiLoom As ProduksiLoom = DaftarProduksiLoom.FindTimbang(NoTransaksi)

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeRoll.btw", False, "")

        If Not IsNothing(ProduksiLoom) Then
            FormatBt.SetNamedSubStringValue("NoTransaksi", ProduksiLoom.NoTransaksi)
            FormatBt.SetNamedSubStringValue("Tanggal", ProduksiLoom.TglTransaksi)
            FormatBt.SetNamedSubStringValue("NomorSpk", ProduksiLoom.NomorWO)
            FormatBt.SetNamedSubStringValue("NamaItem", ProduksiLoom.NamaItem)
            FormatBt.SetNamedSubStringValue("Unit", New DaftarUnitProduksi(ActiveSession).Find(ProduksiLoom.KodeUnit).NamaUnit)
            If ProduksiLoom.KodeUnitPeruntukan.Trim = "" Then
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", "")
            Else
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", New DaftarUnitProduksi(ActiveSession).Find(ProduksiLoom.KodeUnitPeruntukan).NamaUnit)
            End If
            FormatBt.SetNamedSubStringValue("Kode", ProduksiLoom.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeMesin", ProduksiLoom.KodeMesin)
            FormatBt.SetNamedSubStringValue("BeratNetto", ProduksiLoom.BeratNetto)
            FormatBt.SetNamedSubStringValue("PanjangRoll", ProduksiLoom.PanjangRoll)
            FormatBt.SetNamedSubStringValue("Pcs", ProduksiLoom.Pcs)
            FormatBt.SetNamedSubStringValue("BeratPerMeter", ProduksiLoom.BeratPerMeter)
            FormatBt.SetNamedSubStringValue("Status", "A")
            FormatBt.SetNamedSubStringValue("KodeStatus", If(ProduksiLoom.StatusQC = 0, "NONE", If(ProduksiLoom.StatusQC = 1, "OK", If(ProduksiLoom.StatusQC = 2, "NON OK", If(ProduksiLoom.StatusQC = 3, "OVER", If(ProduksiLoom.StatusQC = 4, "UNDER", ""))))))
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(ProduksiLoom.Keterangan) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub SetEnableCommand()

        If BeratBrutto <> 0 Then
            CalculateWeight()

            txtBeratMeter.Value = BeratMeter
        End If

        If lblStatusTimbang.Tag <> 0 Then
            cboStatusQC.Enabled = False
        Else
            cboStatusQC.Enabled = True
        End If

        If cboStatusQC.SelectedIndex <> 2 Then
            cboKodeStatus.Enabled = False
            cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
            btLookupKodeStatus.Enabled = False
        Else
            cboKodeStatus.Enabled = True
            btLookupKodeStatus.Enabled = True
        End If

        If cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1 Then
            cboKodeMesin.Enabled = True
            cboNomorSpk.Enabled = True
            btLookupKodeMesin.Enabled = True
            btLookupNomorSpk.Enabled = True
        Else
            cboKodeMesin.Enabled = False
            cboNomorSpk.Enabled = False
            btLookupKodeMesin.Enabled = False
            btLookupNomorSpk.Enabled = False
        End If

        btSave.Enabled = If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1, False, True) And _
                         If(cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1, False, True) And _
                         If(txtPanjangRoll.Value = 0, False, True) And _
                         If(BeratBrutto <= 0, False, True) And lblStabil.Visible

        BeratMedia = txtBeratMedia.Value
        BeratNetto = BeratBrutto - BeratMedia

        lblBeratBrutto.Text = BeratBrutto.ToString("##,##0.00")
        lblBeratNetto.Text = BeratNetto.ToString("##,##0.00")
        txtBeratNetto.Text = BeratNetto.ToString("##,##0.00")


    End Sub
#End Region

#Region "Scale Communication"

    'Status Koneksi Timbangan
    Private Sub PortConnection()

        Dim PortName As String
        Dim BaudRate As String

        Try
            PortName = GetSetting(enumFormID.frmGudang, enumSetting.settingPort)
            BaudRate = GetSetting(enumFormID.frmGudang, enumSetting.settingBaudRate)

            Porttimbangan.PortName = PortName
            Porttimbangan.BaudRate = BaudRate
            Porttimbangan.Parity = Ports.Parity.None
            Porttimbangan.DataBits = 8

            Porttimbangan.Open()

            If Porttimbangan.IsOpen Then
                lblConnectionStatus.Text = "ONLINE"
                tmrStabil.Enabled = True
            Else
                lblConnectionStatus.Text = "OFFLINE"
                tmrStabil.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi Timbangan Roll Gagal...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Status Timbangan
    Private Sub tmrStabil_Tick(sender As Object, e As EventArgs) Handles tmrStabil.Tick
        Static nCounter As Byte
        Static lChange As Boolean

        Dim TempRight As String = ""
        Dim TempLeft As String = ""
        Dim Temp As String = ""
        Dim TempData As String = ""

        Dim Pos As Integer

        Temp = TempScale.Trim

        'TextBox1.Text = Temp

        If Microsoft.VisualBasic.InStr(Temp.Trim, Chr(3)) = 0 And Len(Temp) < 11 Then
            GoTo jump
        End If

        Pos = Microsoft.VisualBasic.InStr(Temp.Trim, Chr(3))

        If Pos <> 0 Then
            Temp = Microsoft.VisualBasic.Left(Temp.Trim, Pos - 4)

            TempData = Microsoft.VisualBasic.Right(Temp, 6)
            TempRight = Microsoft.VisualBasic.Right(TempData, 1)
            TempLeft = Microsoft.VisualBasic.Left(TempData, 5)
            BeratBrutto = Convert.ToDouble(TempLeft & "." & TempRight)
        Else
            BeratBrutto = 0
        End If

        If BeratBrutto <> Val(lblBeratBrutto.Tag) Then
            nCounter = 0

            lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
            lblBeratBrutto.Tag = BeratBrutto

            If lChange Then
                lChange = False
                lblIndicator.ForeColor = Color.Yellow
            Else
                lChange = True
                lblIndicator.ForeColor = Color.Green
            End If

        Else

            lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
            lblBeratBrutto.Tag = BeratBrutto

            If lChange Then
                lChange = False
                lblIndicator.ForeColor = Color.Yellow
            Else
                lChange = True
                lblIndicator.ForeColor = Color.Green
            End If

            nCounter += 1
            If nCounter > 25 Then
                lblIndicator.ForeColor = Color.Black
                lblStabil.Visible = True
                nCounter -= 1
            Else
                lblStabil.Visible = False
            End If
        End If

jump:
        SetEnableCommand()

    End Sub

    Private Sub Porttimbangan_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles Porttimbangan.DataReceived
        Dim Temp As String = ""
        While Microsoft.VisualBasic.InStr(Temp, Chr(3)) = 0 And Porttimbangan.IsOpen
            Try
                Temp += Microsoft.VisualBasic.Chr(Porttimbangan.ReadChar)
            Catch
            End Try

        End While
        TempScale = Temp
    End Sub

#End Region

    Private Sub tmrWarning_Tick(sender As Object, e As EventArgs) Handles tmrWarning.Tick
        If lblWarning.BackColor = Color.Blue Then
            lblWarning.BackColor = Color.Yellow
            lblWarning.ForeColor = Color.Red
        Else
            lblWarning.BackColor = Color.Blue
            lblWarning.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub chkManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        If chkManual.Checked Then
            txtTimbangManual.Enabled = True
            lblTimbangManual.Enabled = True
            lblStabil.Visible = True
            txtTimbangManual.Focus()
        Else
            txtTimbangManual.Value = 0
            txtTimbangManual.Enabled = False
            lblTimbangManual.Enabled = False
            lblStabil.Visible = False
        End If
        SetEnableCommand()
    End Sub

    Private Sub txtTimbangManual_TextChanged(sender As Object, e As EventArgs) Handles txtTimbangManual.TextChanged
        BeratBrutto = txtTimbangManual.Value
        lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
        lblBeratBrutto.Tag = BeratBrutto
        SetEnableCommand()
    End Sub
End Class