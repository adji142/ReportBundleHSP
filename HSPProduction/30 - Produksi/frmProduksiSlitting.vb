Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiSlitting

#Region "Variable Declaration"
    Private KodeUnitSAP As String
    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private RMStockBahan As Double
    Private RMLebarRoll As Double

    Private FGBeratBrutto As Double
    Private FGBeratNetto As Double
    Private FGKodeMedia As String
    Private FGBeratMedia As Double
    Private FGLebarRoll As Double

    Private SBBeratBrutto As Double
    Private SBBeratNetto As Double
    Private SBKodeMedia As String
    Private SBBeratMedia As Double

    Private TRXBahan As String
    Private RMKodeUnit As String
#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnitProduksi.Tag = GetSetting(enumFormID.frmSlitting, enumSetting.settingKodeUnit)
        lblKodeLokasiHasilProduksi.Tag = GetSetting(enumFormID.frmSlitting, enumSetting.settingKodeLokasi)
        lblKodeLokasiHasilProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblKodeLokasiHasilProduksi.Tag).NamaLokasi.ToUpper

        KodeUnitSAP = ""
        If lblKodeUnitProduksi.Tag <> "" Then
            Try
                Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)
                lblKodeUnitProduksi.Text = "PROSES " & UnitProduksi.NamaUnit.ToUpper
                KodeUnitSAP = UnitProduksi.KodeUnitSAP
            Catch ex As Exception
                lblKodeUnitProduksi.Tag = ""
                lblKodeUnitProduksi.Text = "Unit Produksi Belum Disetting"
            End Try
        Else
            lblKodeUnitProduksi.Text = "Unit Produksi Belum Disetting"
        End If
        '-------------------------------------------------------------------------------------------------------------------

        'Grup Produksi
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

    End Sub

    Private Sub FillComboMesin()

        'Mesin Produksi
        Dim DaftarMesin As New DaftarMesin(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarMesin.Read("%", lblKodeUnitProduksi.Tag)
        cboKodeMesin.DataSource = DS.Tables("View")
        cboKodeMesin.DisplayMember = "Nama Mesin"
        cboKodeMesin.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Mesin") = "-"

        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1

    End Sub

    Private Sub FillComboNomorSPK()
        If KodeUnitSAP.Trim() <> "" Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            DS = SAPWorkOrder.ReadFGWorkOrderByUnit(KodeUnitSAP, TglTransaksi.Date)
            cboNomorSPK.DataSource = DS.Tables("View")
            cboNomorSPK.DisplayMember = "Nomor"
            cboNomorSPK.ValueMember = "Nomor"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Nomor") = ""
            Drow("Nomor") = "-"
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Nomor")

            cboNomorSPK.DataSource = DS.Tables("View")
            cboNomorSPK.DisplayMember = "Nomor"
            cboNomorSPK.ValueMember = "Nomor"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Nomor") = ""
            Drow("Nomor") = "-"
        End If

        cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
    End Sub


#End Region

#Region "Controller"

    'Form Load
    Private Sub frmHasilProduksiSlitting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()
    End Sub

    'Form Close
    Private Sub frmHasilProduksiSlitting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PortTimbangan.Close()
    End Sub

    'Reset data
    Private Sub ResetData()

        lblGrupProduksi.Text = ""

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1

        txtHasilRoll.Value = 0
        txtHasilMeter.Value = 0
        txtHasilTimbang.Value = 0

        txtKeterangan.Text = ""

        txtKodeProduksiBahan.Text = ""
        txtKodeProduksiBahan.Tag = ""

        txtKodeItemBahan.Text = ""
        lblNamaItemBahan1.Text = ""

        txtStockBahanMeter.Value = 0
        txtPemakaianBahanMeter.Value = 0
        txtSisaBahanMeter.Value = 0

        txtTotalSisaBahanMeter.Value = 0
        txtTotalSisaBahanTimbang.Value = 0

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        RMStockBahan = 0
        RMKodeUnit = ""

        FGBeratBrutto = 0
        FGBeratNetto = 0
        FGKodeMedia = ""
        FGBeratMedia = 0

        SBBeratBrutto = 0
        SBBeratNetto = 0
        SBKodeMedia = ""
        SBBeratMedia = 0

        TRXBahan = 0

        Call chkShiftSebelumnya_CheckedChanged(Nothing, Nothing)

    End Sub

    'Jika Data Berubah
    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        txtHasilRoll.TextChanged,
        txtHasilMeter.TextChanged,
        txtHasilTimbang.TextChanged,
        txtKodeProduksiBahan.TextChanged,
        txtKodeItemBahan.TextChanged,
        txtStockBahanMeter.TextChanged,
        txtPemakaianBahanMeter.TextChanged,
        txtSisaBahanMeter.TextChanged,
        txtTotalSisaBahanMeter.TextChanged,
        txtTotalSisaBahanTimbang.TextChanged

        HitungProduksi()
        SetEnableCommand()

    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtHasilRoll.Enter, txtHasilMeter.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

    'Cek Jika Data Berubah
    Private Sub txtHasilRoll_Vaidating(sender As Object, e As EventArgs) Handles txtHasilRoll.Validating
        If txtHasilRoll.Value < 0 Or txtHasilRoll.Value > 6 Then
            MessageBox.Show("Jumlah Roll Hasil Slitting Harus Bernilai 1 - 6 ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtHasilRoll.Focus()
        End If
    End Sub

    'Cek Jika Data Berubah
    Private Sub chkShiftSebelumnya_CheckedChanged(sender As Object, e As EventArgs) Handles chkShiftSebelumnya.CheckedChanged
        FillComboNomorSPK()
        SetEnableCommand()
    End Sub


    'Timer Shift Produksi
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick

        'Transaksi
        '---------------------------------------------------------------------------------------------------
        If lblKodeUnitProduksi.ForeColor = Color.Yellow Then
            lblKodeUnitProduksi.ForeColor = Color.Blue
        Else
            lblKodeUnitProduksi.ForeColor = Color.Yellow
        End If

        'Tanggal & Jam Timbang
        '---------------------------------------------------------------------------------------------------
        TglPencatatan = Now

        lblTglTimbang.Text = Now.Date.ToString("dd") & " " & GetPeriodDescription(Now.Date).ToUpper()
        lblJamTimbang.Text = Now.ToString("HH:mm:ss")

        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = Now.ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                lblKodeShift.Text = 3
                lblTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
                TglTransaksi = DateAdd("D", -1, Now.Date)
            Else
                lblKodeShift.Text = 1
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                lblKodeShift.Text = 1
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                lblKodeShift.Text = 2
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            Else
                lblKodeShift.Text = 3
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            End If
        End If

        'Jika Hasil lblKodeShift Sebelumnya
        '---------------------------------------------------------------------------------------------------
        If chkShiftSebelumnya.Checked = True Then
            Select Case lblKodeShift.Text
                Case 1
                    lblKodeShift.Text = 3
                    lblTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
                    TglTransaksi = DateAdd("D", -1, Now.Date)
                Case 2
                    lblKodeShift.Text = 1
                    lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                    TglTransaksi = Now.Date
                Case 3
                    lblKodeShift.Text = 2
                    If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
                        lblTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
                        TglTransaksi = DateAdd("D", -1, Now.Date)
                    Else
                        lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                        TglTransaksi = Now.Date
                    End If
            End Select
        End If

        'Keterangan
        '---------------------------------------------------------------------------------------------------
        Select Case lblKodeShift.Text
            Case 1
                lblNamaShift.Text = "PAGI"
            Case 2
                lblNamaShift.Text = "SIANG"
            Case 3
                lblNamaShift.Text = "MALAM"
        End Select

    End Sub

    'Lookup Jika Ditekan F10
    Private Sub cboNomorSPK_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNomorSPK.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupNomorSPK.PerformClick()
        End If
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboNomorSPK_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNomorSPK.SelectedValueChanged

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        If cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1 Then
            Try
                Dim SAPWorkOrder As New SAPWorkOrder
                Dim WO As FGWorkOrder = SAPWorkOrder.FindFGByWO(KodeUnitSAP, cboNomorSPK.SelectedValue)

                lblKodeItemHasilProduksi.Text = WO.KodeItem
                lblNamaItemHasilProduksi.Text = WO.NamaItem.ToUpper
                FGLebarRoll = WO.Lebar

            Catch
            End Try
        End If

        SetEnableCommand()
    End Sub

    'Lookup WO
    Private Sub btLookupNomorSPK_Click(sender As Object, e As EventArgs) Handles btLookupNomorSPK.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, TglTransaksi.Date}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar SPK Aktif"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSPK.SelectedValue = Form.IDLookup
            cboNomorSPK.Focus()
        End If
    End Sub

    'Cari Data Roll Bahan
    Private Sub txtKodeProduksiBahan_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeProduksiBahan.Validating
        Dim StockRoll As StockRoll
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
        Dim RM As New RMWorkOrder

        TRXBahan = ""

        If Not (KodeLokasi = "" Or txtKodeProduksiBahan.Text.Trim = "") Then

            StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan.Text, KodeLokasi)
            If Not IsNothing(StockRoll) Then
                lblNamaItemBahan1.Text = StockRoll.NamaItem
                txtKodeItemBahan.Text = StockRoll.KodeItem
                RMKodeUnit = StockRoll.KodeUnit

                RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan.Text)
                If Not IsNothing(RM) Then

                    If txtKodeProduksiBahan.Tag.ToString.Trim() <> txtKodeProduksiBahan.Text.Trim() Then
                        txtStockBahanMeter.Value = StockRoll.PanjangRoll
                        'txtPemakaianBahanMeter.Value = txtStockBahanMeter.Value
                        txtPemakaianBahanMeter.Value = 0
                        txtSisaBahanMeter.Value = 0
                    End If

                    txtKodeProduksiBahan.Tag = txtKodeProduksiBahan.Text.Trim()

                    RMStockBahan = StockRoll.BeratNetto
                    TRXBahan = StockRoll.TRX

                Else
                    MessageBox.Show("Item Roll Tidak Terdaftar Pada SPK/Work Order ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtKodeProduksiBahan.Focus()
                    GoTo ResetBahan
                End If

            Else
                MessageBox.Show("Kode Produksi Tidak Valid ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodeProduksiBahan.Focus()
                GoTo ResetBahan
            End If

        Else
            GoTo ResetBahan
        End If

        GoTo ExitProcedure

ResetBahan:
        txtKodeProduksiBahan.Tag = ""
        lblNamaItemBahan1.Text = ""
        txtKodeProduksiBahan.Text = ""
        txtKodeItemBahan.Text = ""
        txtStockBahanMeter.Value = 0
        txtPemakaianBahanMeter.Value = 0
        txtSisaBahanMeter.Value = 0


        GoTo ExitProcedure

ExitProcedure:
        SetEnableCommand()
    End Sub

    'Hitung Habis Bahan
    Private Sub btHabisBahan_Click(sender As Object, e As EventArgs) Handles btHabisBahan.Click

        txtPemakaianBahanMeter.Value = txtStockBahanMeter.Value
        HitungProduksi()

    End Sub

    'Hitung Sisa Bahan
    Private Sub btSisaBahan_Click(sender As Object, e As EventArgs) Handles btSisaBahan.Click

        txtPemakaianBahanMeter.Value = txtHasilMeter.Value
        If txtPemakaianBahanMeter.Value > txtStockBahanMeter.Value Then
            txtPemakaianBahanMeter.Value = txtStockBahanMeter.Value
        End If

        HitungProduksi()

    End Sub

    'Proses Timbang Hasil Produksi
    Private Sub btTimbangHasilProduksi_Click(sender As Object, e As EventArgs) Handles btTimbangHasilProduksi.Click
        Dim F As New frmProsesTimbang
        F.FormID = enumFormID.frmSlitting
        F.KodeLokasi = lblKodeLokasiHasilProduksi.Tag
        F.KodeUnit = lblKodeUnitProduksi.Tag
        F.KodeMedia = FGKodeMedia
        F.Text = "Proses Timbang -> Roll Hasil Produksi"
        F.ShowDialog()
        If F.Result = "OK" Then
            FGBeratBrutto = F.BeratBrutto
            FGBeratNetto = F.BeratNetto
            FGKodeMedia = F.KodeMedia
            FGBeratMedia = F.BeratMedia

            txtHasilTimbang.Value = FGBeratNetto
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Proses Timbang Sisa Bahan
    Private Sub btTimbangSisaBahan_Click(sender As Object, e As EventArgs) Handles btTimbangSisaBahan.Click
        Dim F As New frmProsesTimbang
        F.FormID = enumFormID.frmLaminating
        F.KodeLokasi = lblKodeLokasiHasilProduksi.Tag
        F.KodeUnit = RMKodeUnit
        F.KodeMedia = SBKodeMedia
        F.Text = "Proses Timbang -> Sisa Roll Bahan Produksi"
        F.ShowDialog()
        If F.Result = "OK" Then
            SBBeratBrutto = F.BeratBrutto
            SBBeratNetto = F.BeratNetto
            SBKodeMedia = F.KodeMedia
            SBBeratMedia = F.BeratMedia

            txtTotalSisaBahanTimbang.Value = SBBeratNetto
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Hitung Produksi
    Private Sub HitungProduksi()
        txtSisaBahanMeter.Value = txtStockBahanMeter.Value - txtPemakaianBahanMeter.Value
        txtTotalSisaBahanMeter.Value = txtSisaBahanMeter.Value
    End Sub

    'Lookup Daftar Kode Produksi
    Private Sub btLookupKodeProduksiBahan_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksiBahan.Click

        If cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1 Then

            Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
            Dim DaftarStockRoll As IDataLookup = New DaftarStockRoll(ActiveSession)

            Dim DT As DataTable = New SAPWorkOrder().ReadRMByWO(cboNomorSPK.SelectedValue, KodeUnitSAP).Tables("View")
            Dim DR As DataRow

            Dim ItemList As String = ""
            For Each DR In DT.Rows
                ItemList += "'" + DR("Kode Item") + "', "
            Next

            ItemList = Microsoft.VisualBasic.Left(ItemList.Trim, ItemList.Trim.Length - 1)

            Dim Parameter() As String = {KodeLokasi, ItemList}

            Dim Form As New frmLookup(DaftarStockRoll, Parameter)
            Form.Text = "Lookup Daftar Kode Produksi"
            Form.ShowDialog()
            If Form.IDLookup <> "" Then
                txtKodeProduksiBahan.Text = Form.IDLookup
                txtKodeProduksiBahan.Focus()
                SendKeys.Send("{TAB}")
            End If
        End If

    End Sub


#End Region

#Region "Save To Database"

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
        Dim NoTransaksi As String
        Dim PeriodeTransaksi As String = GetPeriod(TglTransaksi)

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                Dim StockRoll As StockRoll

                'Cek Lokasi Gudang Stock
                If txtKodeProduksiBahan.Text.Trim() <> "" Then
                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan.Text).KodeLokasi
                    If LokasiStockWO <> KodeLokasi Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        GoTo Jump
                    End If
                End If

                If CekJumlahRoll() Then
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Jumlah Roll Hasil Slitting Tidak Sesuai Dengan Lebar Bahan Roll...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GoTo Jump
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Produksi Slitting ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try

                    Dim DaftarProduksiSlitting As New DaftarProduksiSlitting(ActiveSession)
                    Dim ProduksiSlitting As ProduksiSlitting
                    Dim PrefikKodeProduksi As String = New DaftarLokasi(ActiveSession).Find(KodeLokasi).PrefikKodeTransaksi
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    Dim KodeProduksi As String = DaftarStockRoll.GetKodeProduksi(lblKodeUnitProduksi.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)

                    NoTransaksi = DaftarProduksiSlitting.GetNomorTransaksi(PeriodeTransaksi)

                    'Simpan Data Transaksi Produksi
                    ProduksiSlitting = New ProduksiSlitting
                    With ProduksiSlitting

                        .NoTransaksi = NoTransaksi
                        .TglTransaksi = TglTransaksi.Date
                        .TglPencatatan = TglPencatatan
                        .NomorWO = cboNomorSPK.SelectedValue
                        .KodeUnitSAP = KodeUnitSAP
                        .KodeUnit = lblKodeUnitProduksi.Tag
                        .KodeShift = lblKodeShift.Text
                        .KodeGrup = lblGrupProduksi.Text
                        .KodeMesin = cboKodeMesin.SelectedValue
                        .ShiftSebelumnya = chkShiftSebelumnya.Checked

                        .FGKodeLokasi = KodeLokasi
                        .FGKodeItem = lblKodeItemHasilProduksi.Text
                        .FGNamaItem = lblNamaItemHasilProduksi.Text
                        .FGRoll = txtHasilRoll.Value
                        .FGPanjang = txtHasilMeter.Value
                        .FGBeratBrutto = FGBeratBrutto
                        .FGBeratNetto = FGBeratNetto
                        .FGKodeMedia = FGKodeMedia
                        .FGBeratMedia = FGBeratMedia
                        .FGKeterangan = txtKeterangan.Text

                        .RMKodeLokasi = KodeLokasi
                        .RMKodeProduksi = txtKodeProduksiBahan.Text
                        .RMKodeItem = txtKodeItemBahan.Text
                        .RMNamaItem = lblNamaItemBahan1.Text
                        .RMStockPanjang = txtStockBahanMeter.Value
                        .RMStockBerat = RMStockBahan
                        .RMPemakaianPanjang = txtPemakaianBahanMeter.Value
                        .RMPemakaianBerat = If(txtSisaBahanMeter.Value = 0, .RMStockBerat, .RMStockBerat - SBBeratNetto)
                        .RMSisaPanjang = txtSisaBahanMeter.Value
                        .RMSisaBerat = .RMStockBerat - .RMPemakaianBerat

                        .SBKodeProduksi = txtKodeProduksiBahan.Text
                        .SBPanjang = txtTotalSisaBahanMeter.Value
                        .SBBeratBrutto = SBBeratBrutto
                        .SBBeratNetto = SBBeratNetto
                        .SBKodeMedia = SBKodeMedia
                        .SBBeratMedia = SBBeratMedia

                        .UserID = ActiveSession.KodeUser
                    End With
                    DaftarProduksiSlitting.Add(ProduksiSlitting)

                    'Simpan Data Stock Roll Hasil Produksi
                    Dim nRoll As Byte
                    For nRoll = 1 To txtHasilRoll.Value

                        StockRoll = New StockRoll
                        StockRoll.NoTransaksi = NoTransaksi
                        StockRoll.TglTransaksi = TglTransaksi.Date
                        StockRoll.TglTimbang = TglPencatatan
                        StockRoll.NomorWO = cboNomorSPK.SelectedValue
                        StockRoll.KodeItem = lblKodeItemHasilProduksi.Text
                        StockRoll.NamaItem = lblNamaItemHasilProduksi.Text
                        StockRoll.KodeShift = lblKodeShift.Text
                        StockRoll.KodeGrup = cboKodeGrup.SelectedValue
                        StockRoll.KodeUnit = lblKodeUnitProduksi.Tag
                        StockRoll.KodeUnitPeruntukan = ""
                        StockRoll.KodeMesin = cboKodeMesin.SelectedValue
                        StockRoll.KodeLokasi = KodeLokasi
                        StockRoll.KodeProduksi = KodeProduksi & nRoll.ToString.Trim
                        StockRoll.BeratBrutto = FGBeratBrutto
                        StockRoll.KodeMedia = FGKodeMedia
                        StockRoll.JumlahMedia = 1
                        StockRoll.BeratMedia = FGBeratMedia
                        StockRoll.BeratNetto = FGBeratNetto
                        StockRoll.PanjangRoll = txtHasilMeter.Value
                        StockRoll.Pcs = 0
                        StockRoll.Transaksi = 1         ' Hasil Produksi
                        StockRoll.StatusStock = 1       ' Stock Aktif
                        StockRoll.StatusQc = 1          ' Status OK
                        StockRoll.KodeStatus = ""
                        StockRoll.StatusDisposisi = 0
                        StockRoll.KodeDisposisi = ""
                        StockRoll.Satuan1 = UnitProduksi.KodeSatuan1
                        StockRoll.Satuan2 = UnitProduksi.KodeSatuan2
                        StockRoll.Satuan3 = UnitProduksi.KodeSatuan3
                        StockRoll.Jumlah1 = 1
                        StockRoll.Jumlah2 = txtHasilMeter.Value
                        StockRoll.Jumlah3 = txtHasilTimbang.Value
                        StockRoll.Keterangan = txtKeterangan.Text
                        StockRoll.InputData = 0
                        StockRoll.UserID = ActiveSession.KodeUser
                        DaftarStockRoll.Add(StockRoll)
                    Next

                    'Simpan Data Stock Roll Sisa Bahan Produksi
                    If txtTotalSisaBahanMeter.Value <> 0 Then

                        Dim RMKodeProduksi As String = txtKodeProduksiBahan.Text
                        StockRoll = DaftarStockRoll.FindLastID(RMKodeProduksi)

                        StockRoll.NoTransaksi = NoTransaksi
                        StockRoll.TglTransaksi = TglTransaksi.Date
                        StockRoll.TglTimbang = TglPencatatan
                        StockRoll.NomorWO = cboNomorSPK.SelectedValue
                        StockRoll.KodeShift = lblKodeShift.Text
                        StockRoll.KodeGrup = cboKodeGrup.SelectedValue
                        StockRoll.KodeLokasi = KodeLokasi
                        StockRoll.BeratBrutto = SBBeratBrutto
                        StockRoll.KodeMedia = SBKodeMedia
                        StockRoll.JumlahMedia = 1
                        StockRoll.BeratMedia = SBBeratMedia
                        StockRoll.BeratNetto = SBBeratNetto
                        StockRoll.PanjangRoll = txtTotalSisaBahanMeter.Value
                        StockRoll.StatusStock = 1
                        StockRoll.Jumlah1 = 1
                        StockRoll.Jumlah2 = txtTotalSisaBahanMeter.Value
                        StockRoll.Jumlah3 = txtTotalSisaBahanTimbang.Value
                        StockRoll.UserID = ActiveSession.KodeUser
                        DaftarStockRoll.Add(StockRoll)

                    End If

                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging

                    '--------------------------------------------------------------------------------------------------
                    'Bahan Produksi
                    '--------------------------------------------------------------------------------------------------
                    'Bahan #1
                    If txtKodeProduksiBahan.Text.Trim() <> "" Then
                        SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     txtKodeItemBahan.Text,
                                                     txtPemakaianBahanMeter.Value,
                                                     txtKodeProduksiBahan.Text,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If

                    'Eksekusi Data Staging
                    SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)

                    '--------------------------------------------------------------------------------------------------
                    'Hasil Produksi
                    '--------------------------------------------------------------------------------------------------                    
                    For nRoll = 1 To txtHasilRoll.Value
                        SAPStaging.PostFinishedGoodReceipt(KodeUnitSAP,
                                                           cboNomorSPK.SelectedValue,
                                                           TglTransaksi,
                                                           lblKodeItemHasilProduksi.Text,
                                                           txtHasilMeter.Value,
                                                           txtHasilTimbang.Value,
                                                           KodeProduksi & nRoll.ToString.Trim,
                                                           "",
                                                           NoTransaksi,
                                                           KodeLokasi)
                    Next

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.FinishedGoodReceipt)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        SAPStaging.RemoveStagingData(NoTransaksi)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************


                    'Cetak Struk
                    MessageBox.Show("Siapkan Label Untuk Mencetak Struk Hasil Produksi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrintBarcodeHasilProduksi(NoTransaksi)

                    If txtTotalSisaBahanTimbang.Value <> 0 Then
                        MessageBox.Show("Siapkan Label Untuk Mencetak Struk Sisa Roll Bahan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        PrintBarcodeSisaBahan(txtKodeProduksiBahan.Text)
                    End If

                    Me.Cursor = Cursors.Default
                    Me.Close()
                    '---------------------------------------------------------------------------------------------------------

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    Private Function CekJumlahRoll() As Boolean
        'Ambil Data Lebar Bahan Roll
        '----------------------------------------------------------------------------------------
        Dim RM As New ItemSAP
        RM = New SAPInventory().FindItem(txtKodeItemBahan.Text)
        If Not IsNothing(RM) Then
            RMLebarRoll = RM.Lebar
        Else
            RMLebarRoll = 0
        End If

        'Ambil Data Lebar Finish Good
        '----------------------------------------------------------------------------------------
        Dim FG As New ItemSAP
        FG = New SAPInventory().FindItemSlitting(lblKodeItemHasilProduksi.Text)
        If Not IsNothing(FG) Then
            FGLebarRoll = FG.Lebar
        Else
            FGLebarRoll = 0
        End If

        Dim JumlahRollCalculate As Double
        Dim JumlahRollActual As Double

        JumlahRollCalculate = Math.Floor(RMLebarRoll / FGLebarRoll)

        JumlahRollActual = txtHasilRoll.Value

        If JumlahRollActual > JumlahRollCalculate Then
            CekJumlahRoll = True
        Else
            CekJumlahRoll = False
        End If

        'MsgBox("LEBAR BHN : " & RMLebarRoll & "LEBAR HASIL : " & FGLebarRoll & " AKTUAL : " & JumlahRollActual & " CALCULATE : " & JumlahRollCalculate)
    End Function

    'Enable / Disable Button
    Private Sub SetEnableCommand()

        If ActiveSession.KodeUser.ToUpper = "SPVS" Then
            btLookupKodeProduksiBahan.Visible = True
        Else
            btLookupKodeProduksiBahan.Visible = False
        End If

        HitungProduksi()

        If cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        If txtKodeProduksiBahan.Text.Trim().Length = 0 Then
            cboNomorSPK.Enabled = True
            btLookupNomorSPK.Enabled = True
            txtHasilRoll.Enabled = True
            txtHasilMeter.Enabled = True
        Else
            cboNomorSPK.Enabled = False
            btLookupNomorSPK.Enabled = False
            txtHasilRoll.Enabled = False
            txtHasilMeter.Enabled = False
        End If

        If txtTotalSisaBahanMeter.Value = 0 Then
            btTimbangSisaBahan.Enabled = False
            txtTotalSisaBahanTimbang.Value = 0
        Else
            btTimbangSisaBahan.Enabled = True
        End If

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(txtKodeProduksiBahan.Text.Trim() = "", False, True) And _
                         If(txtHasilRoll.Value = 0, False, True) And _
                         If(txtHasilMeter.Value = 0, False, True) And _
                         If(txtHasilTimbang.Value = 0, False, True) And _
                         If(txtPemakaianBahanMeter.Value = 0, False, True) And _
                         If(txtSisaBahanMeter.Value = 0, True, If(txtTotalSisaBahanTimbang.Value = 0, False, True))

        lblGrupProduksi.Text = cboKodeGrup.Text
    End Sub

#End Region

#Region "Barcode Printing"

    Private Sub PrintBarcodeHasilProduksi(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeRoll.btw", False, "")

        Dim DaftarKodeProduksi As DataTable = DaftarStockRoll.ReadHasilProduksiSlitting(NoTransaksi).Tables("View")
        Dim DR As DataRow
        For Each DR In DaftarKodeProduksi.Rows
            Dim StockRoll As StockRoll = DaftarStockRoll.Find(DR("KodeProduksi"))

            If Not IsNothing(StockRoll) Then
                FormatBt.SetNamedSubStringValue("NoTransaksi", StockRoll.NoTransaksi)
                FormatBt.SetNamedSubStringValue("Tanggal", StockRoll.TglTransaksi)
                FormatBt.SetNamedSubStringValue("NomorSpk", StockRoll.NomorWO)
                FormatBt.SetNamedSubStringValue("NamaItem", StockRoll.NamaItem)
                FormatBt.SetNamedSubStringValue("Unit", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnit).NamaUnit)
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", "-")
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

            End If

        Next
        AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)

    End Sub

    Private Sub PrintBarcodeSisaBahan(KodeProduksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
        Dim StockRoll As StockRoll = DaftarStockRoll.Find(KodeProduksi)

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

#End Region

End Class