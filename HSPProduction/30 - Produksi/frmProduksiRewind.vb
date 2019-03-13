Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiRewind

#Region "Variable Declaration"
    Private KodeUnitSAP As String
    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private FGBeratBrutto As Double
    Private FGBeratNetto As Double
    Private FGKodeMedia As String
    Private FGBeratMedia As Double

    Private RM1StockBahan As Double
    Private RM2StockBahan As Double
    Private RM3StockBahan As Double
    Private RM4StockBahan As Double
    Private RM5StockBahan As Double
    Private RMKodeUnit As String

    Private TRX1Bahan As String
    Private TRX2Bahan As String
    Private TRX3Bahan As String
    Private TRX4Bahan As String
    Private TRX5Bahan As String

    Private QtyPlan As Double
    Private QtyHasil As Double

#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnitProduksi.Tag = GetSetting(enumFormID.frmRewind, enumSetting.settingKodeUnit)
        lblKodeLokasiHasilProduksi.Tag = GetSetting(enumFormID.frmRewind, enumSetting.settingKodeLokasi)
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

        'Unit Produksi Peruntukan
        Dim DaftarUnitProduksi As New DaftarUnitProduksiPeruntukan(ActiveSession)

        DS = New DataSet
        DS = DaftarUnitProduksi.ReadDetail(lblKodeUnitProduksi.Tag)
        cboKodeUnitPeruntukan.DataSource = DS.Tables("View")
        cboKodeUnitPeruntukan.DisplayMember = "Nama Unit Peruntukan"
        cboKodeUnitPeruntukan.ValueMember = "Peruntukan"

        Drow = DS.Tables("View").Rows.Add
        Drow("Peruntukan") = ""
        Drow("Nama Unit Peruntukan") = "-"

        cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1

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
    Private Sub frmHasilProduksiRewind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLocalDateTime()
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()
    End Sub

    'Form Close
    Private Sub frmHasilProduksiRewind_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SetLocalDateTime()
        PortTimbangan.Close()
    End Sub

    'Reset data
    Private Sub ResetData()

        lblGrupProduksi.Text = ""

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1
        txtHasilMeter.Value = 0
        txtHasilTimbang.Value = 0

        cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1
        txtKeterangan.Text = ""

        txtKodeProduksiBahan1.Text = ""
        txtKodeProduksiBahan2.Text = ""
        txtKodeProduksiBahan3.Text = ""
        txtKodeProduksiBahan4.Text = ""
        txtKodeProduksiBahan5.Text = ""
        txtKodeProduksiBahan1.Tag = ""
        txtKodeProduksiBahan2.Tag = ""
        txtKodeProduksiBahan3.Tag = ""
        txtKodeProduksiBahan4.Tag = ""
        txtKodeProduksiBahan5.Tag = ""

        txtKodeItemBahan1.Text = ""
        txtKodeItemBahan2.Text = ""
        txtKodeItemBahan3.Text = ""
        txtKodeItemBahan4.Text = ""
        txtKodeItemBahan5.Text = ""
        lblNamaItemBahan1.Text = ""
        lblNamaItemBahan2.Text = ""
        lblNamaItemBahan3.Text = ""
        lblNamaItemBahan4.Text = ""
        lblNamaItemBahan5.Text = ""
        txtStockBahan1.Value = 0
        txtStockBahan2.Value = 0
        txtStockBahan3.Value = 0
        txtStockBahan4.Value = 0
        txtStockBahan5.Value = 0
        txtPemakaianBahan1.Value = 0
        txtPemakaianBahan2.Value = 0
        txtPemakaianBahan3.Value = 0
        txtPemakaianBahan4.Value = 0
        txtPemakaianBahan5.Value = 0
        txtSisaBahan1.Value = 0
        txtSisaBahan2.Value = 0
        txtSisaBahan3.Value = 0
        txtSisaBahan4.Value = 0
        txtSisaBahan5.Value = 0

        txtTotalStockBahan.Value = 0
        txtTotalPemakaianBahan.Value = 0
        txtTotalSisaBahan.Value = 0

        txtNIKOperator.Text = ""
        txtNamaOperator.Text = ""

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        FGBeratBrutto = 0
        FGBeratNetto = 0
        FGKodeMedia = ""
        FGBeratMedia = 0

        RM1StockBahan = 0
        RM2StockBahan = 0
        RM3StockBahan = 0
        RM4StockBahan = 0
        RM5StockBahan = 0
        RMKodeUnit = ""

        TRX1Bahan = 0
        TRX2Bahan = 0
        TRX3Bahan = 0
        TRX4Bahan = 0
        TRX5Bahan = 0

        Call chkShiftSebelumnya_CheckedChanged(Nothing, Nothing)

    End Sub

    'Jika Data Berubah
    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        txtHasilMeter.TextChanged,
        txtHasilTimbang.TextChanged,
        txtKodeProduksiBahan1.TextChanged,
        txtKodeProduksiBahan2.TextChanged,
        txtKodeProduksiBahan3.TextChanged,
        txtKodeProduksiBahan4.TextChanged,
        txtKodeProduksiBahan5.TextChanged,
        txtKodeItemBahan1.TextChanged,
        txtKodeItemBahan2.TextChanged,
        txtKodeItemBahan3.TextChanged,
        txtKodeItemBahan4.TextChanged,
        txtKodeItemBahan5.TextChanged,
        txtStockBahan1.TextChanged,
        txtStockBahan2.TextChanged,
        txtStockBahan3.TextChanged,
        txtStockBahan4.TextChanged,
        txtStockBahan5.TextChanged,
        txtPemakaianBahan1.TextChanged,
        txtPemakaianBahan2.TextChanged,
        txtPemakaianBahan3.TextChanged,
        txtPemakaianBahan4.TextChanged,
        txtPemakaianBahan5.TextChanged,
        txtSisaBahan1.TextChanged,
        txtSisaBahan2.TextChanged,
        txtSisaBahan3.TextChanged,
        txtSisaBahan4.TextChanged,
        txtSisaBahan5.TextChanged,
        txtTotalStockBahan.TextChanged,
        txtTotalPemakaianBahan.TextChanged,
        txtTotalSisaBahan.TextChanged,
        chkShiftSebelumnya.CheckedChanged,
        txtNIKOperator.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtHasilMeter.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
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
    Private Sub CariDataBahanProduksi(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeProduksiBahan1.Validating, txtKodeProduksiBahan2.Validating, txtKodeProduksiBahan3.Validating, txtKodeProduksiBahan4.Validating, txtKodeProduksiBahan5.Validating
        Dim StockRoll As StockRoll
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
        Dim RM As New RMWorkOrder

        TRX1Bahan = ""
        TRX2Bahan = ""
        TRX3Bahan = ""
        TRX4Bahan = ""
        TRX5Bahan = ""

        Select Case sender.Name

            Case "txtKodeProduksiBahan1"

                If Not (KodeLokasi = "" Or txtKodeProduksiBahan1.Text.Trim = "") Then

                    StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan1.Text, KodeLokasi)
                    If Not IsNothing(StockRoll) Then
                        lblNamaItemBahan1.Text = StockRoll.NamaItem
                        txtKodeItemBahan1.Text = StockRoll.KodeItem
                        RMKodeUnit = StockRoll.KodeUnit

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan1.Text)
                        If Not IsNothing(RM) Then

                            txtStockBahan1.Value = StockRoll.PanjangRoll
                            txtPemakaianBahan1.Value = StockRoll.PanjangRoll
                            txtSisaBahan1.Value = 0
                            txtKodeProduksiBahan1.Tag = txtKodeProduksiBahan1.Text.Trim()
                            RM1StockBahan = StockRoll.BeratNetto
                            TRX1Bahan = StockRoll.TRX

                        Else
                            MessageBox.Show("Item Roll Tidak Terdaftar Pada SPK/Work Order ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan1.Focus()
                            GoTo ResetBahan1
                        End If

                    Else
                        MessageBox.Show("Kode Produksi Tidak Valid ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtKodeProduksiBahan1.Focus()
                        GoTo ResetBahan1
                    End If

                Else
                    GoTo ResetBahan1
                End If

            Case "txtKodeProduksiBahan2"

                If Not (KodeLokasi = "" Or txtKodeProduksiBahan2.Text.Trim = "") Then

                    StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan2.Text, KodeLokasi)
                    If Not IsNothing(StockRoll) Then
                        lblNamaItemBahan2.Text = StockRoll.NamaItem
                        txtKodeItemBahan2.Text = StockRoll.KodeItem
                        RMKodeUnit = StockRoll.KodeUnit

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan2.Text)
                        If Not IsNothing(RM) Then

                            txtStockBahan2.Value = StockRoll.PanjangRoll
                            txtPemakaianBahan2.Value = StockRoll.PanjangRoll
                            txtSisaBahan2.Value = 0
                            txtKodeProduksiBahan2.Tag = txtKodeProduksiBahan2.Text.Trim()
                            RM2StockBahan = StockRoll.BeratNetto
                            TRX2Bahan = StockRoll.TRX

                        Else
                            MessageBox.Show("Item Roll Tidak Terdaftar Pada SPK/Work Order ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan2.Focus()
                            GoTo ResetBahan2
                        End If

                    Else
                        MessageBox.Show("Kode Produksi Tidak Valid ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtKodeProduksiBahan2.Focus()
                        GoTo ResetBahan2
                    End If

                Else
                    GoTo ResetBahan2
                End If

            Case "txtKodeProduksiBahan3"

                If Not (KodeLokasi = "" Or txtKodeProduksiBahan3.Text.Trim = "") Then

                    StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan3.Text, KodeLokasi)
                    If Not IsNothing(StockRoll) Then
                        lblNamaItemBahan3.Text = StockRoll.NamaItem
                        txtKodeItemBahan3.Text = StockRoll.KodeItem
                        RMKodeUnit = StockRoll.KodeUnit

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan3.Text)
                        If Not IsNothing(RM) Then

                            txtStockBahan3.Value = StockRoll.PanjangRoll
                            txtPemakaianBahan3.Value = StockRoll.PanjangRoll
                            txtSisaBahan3.Value = 0
                            txtKodeProduksiBahan3.Tag = txtKodeProduksiBahan3.Text.Trim()
                            RM3StockBahan = StockRoll.BeratNetto
                            TRX3Bahan = StockRoll.TRX

                        Else
                            MessageBox.Show("Item Roll Tidak Terdaftar Pada SPK/Work Order ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan3.Focus()
                            GoTo ResetBahan3
                        End If

                    Else
                        MessageBox.Show("Kode Produksi Tidak Valid ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtKodeProduksiBahan3.Focus()
                        GoTo ResetBahan3
                    End If

                Else
                    GoTo ResetBahan3
                End If

            Case "txtKodeProduksiBahan4"

                If Not (KodeLokasi = "" Or txtKodeProduksiBahan4.Text.Trim = "") Then

                    StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan4.Text, KodeLokasi)
                    If Not IsNothing(StockRoll) Then
                        lblNamaItemBahan4.Text = StockRoll.NamaItem
                        txtKodeItemBahan4.Text = StockRoll.KodeItem
                        RMKodeUnit = StockRoll.KodeUnit

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan4.Text)
                        If Not IsNothing(RM) Then

                            txtStockBahan4.Value = StockRoll.PanjangRoll
                            txtPemakaianBahan4.Value = StockRoll.PanjangRoll
                            txtSisaBahan4.Value = 0
                            txtKodeProduksiBahan4.Tag = txtKodeProduksiBahan4.Text.Trim()
                            RM4StockBahan = StockRoll.BeratNetto
                            TRX4Bahan = StockRoll.TRX

                        Else
                            MessageBox.Show("Item Roll Tidak Terdaftar Pada SPK/Work Order ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan4.Focus()
                            GoTo ResetBahan4
                        End If

                    Else
                        MessageBox.Show("Kode Produksi Tidak Valid ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtKodeProduksiBahan4.Focus()
                        GoTo ResetBahan4
                    End If

                Else
                    GoTo ResetBahan4
                End If
            Case "txtKodeProduksiBahan5"

                If Not (KodeLokasi = "" Or txtKodeProduksiBahan5.Text.Trim = "") Then

                    StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan5.Text, KodeLokasi)
                    If Not IsNothing(StockRoll) Then
                        lblNamaItemBahan5.Text = StockRoll.NamaItem
                        txtKodeItemBahan5.Text = StockRoll.KodeItem
                        RMKodeUnit = StockRoll.KodeUnit

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan5.Text)
                        If Not IsNothing(RM) Then

                            txtStockBahan5.Value = StockRoll.PanjangRoll
                            txtPemakaianBahan5.Value = StockRoll.PanjangRoll
                            txtSisaBahan5.Value = 0
                            txtKodeProduksiBahan5.Tag = txtKodeProduksiBahan5.Text.Trim()
                            RM5StockBahan = StockRoll.BeratNetto
                            TRX5Bahan = StockRoll.TRX

                        Else
                            MessageBox.Show("Item Roll Tidak Terdaftar Pada SPK/Work Order ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan5.Focus()
                            GoTo ResetBahan5
                        End If

                    Else
                        MessageBox.Show("Kode Produksi Tidak Valid ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtKodeProduksiBahan5.Focus()
                        GoTo ResetBahan5
                    End If

                Else
                    GoTo ResetBahan5
                End If
        End Select
        GoTo ExitProcedure

ResetBahan1:
        txtKodeProduksiBahan1.Tag = ""
        lblNamaItemBahan1.Text = ""
        txtKodeProduksiBahan1.Text = ""
        txtKodeItemBahan1.Text = ""
        txtStockBahan1.Value = 0
        txtPemakaianBahan1.Value = 0
        txtSisaBahan1.Value = 0
        GoTo ExitProcedure

ResetBahan2:
        txtKodeProduksiBahan2.Tag = ""
        lblNamaItemBahan2.Text = ""
        txtKodeProduksiBahan2.Text = ""
        txtKodeItemBahan2.Text = ""
        txtStockBahan2.Value = 0
        txtPemakaianBahan2.Value = 0
        txtSisaBahan2.Value = 0
        GoTo ExitProcedure

ResetBahan3:
        txtKodeProduksiBahan3.Tag = ""
        lblNamaItemBahan3.Text = ""
        txtKodeProduksiBahan3.Text = ""
        txtKodeItemBahan3.Text = ""
        txtStockBahan3.Value = 0
        txtPemakaianBahan3.Value = 0
        txtSisaBahan3.Value = 0
        GoTo ExitProcedure

ResetBahan4:
        txtKodeProduksiBahan4.Tag = ""
        lblNamaItemBahan4.Text = ""
        txtKodeProduksiBahan4.Text = ""
        txtKodeItemBahan4.Text = ""
        txtStockBahan4.Value = 0
        txtPemakaianBahan4.Value = 0
        txtSisaBahan4.Value = 0
        GoTo ExitProcedure

ResetBahan5:
        txtKodeProduksiBahan5.Tag = ""
        lblNamaItemBahan5.Text = ""
        txtKodeProduksiBahan5.Text = ""
        txtKodeItemBahan5.Text = ""
        txtStockBahan5.Value = 0
        txtPemakaianBahan5.Value = 0
        txtSisaBahan5.Value = 0
        GoTo ExitProcedure

ExitProcedure:
        SetEnableCommand()
    End Sub

    'Proses Timbang Hasil Produksi
    Private Sub btTimbangHasilProduksi_Click(sender As Object, e As EventArgs) Handles btTimbangHasilProduksi.Click
        Dim F As New frmProsesTimbang
        F.FormID = enumFormID.frmRewind
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

    'Hitung Produksi
    Private Sub HitungProduksi()
        txtSisaBahan1.Value = txtStockBahan1.Value - txtPemakaianBahan1.Value
        txtSisaBahan2.Value = txtStockBahan2.Value - txtPemakaianBahan2.Value
        txtSisaBahan3.Value = txtStockBahan3.Value - txtPemakaianBahan3.Value
        txtSisaBahan4.Value = txtStockBahan4.Value - txtPemakaianBahan4.Value
        txtSisaBahan5.Value = txtStockBahan5.Value - txtPemakaianBahan5.Value

        txtTotalStockBahan.Value = txtStockBahan1.Value + txtStockBahan2.Value + txtStockBahan3.Value + txtStockBahan4.Value + txtStockBahan5.Value
        txtTotalPemakaianBahan.Value = txtPemakaianBahan1.Value + txtPemakaianBahan2.Value + txtPemakaianBahan3.Value + txtPemakaianBahan4.Value + txtPemakaianBahan5.Value
        txtTotalSisaBahan.Value = txtSisaBahan1.Value + txtSisaBahan2.Value + txtSisaBahan3.Value + txtSisaBahan4.Value + txtSisaBahan5.Value
    End Sub

    'Lookup Daftar Kode Produksi
    Private Sub btLookupKodeProduksiBahan1_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksiBahan1.Click

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
                txtKodeProduksiBahan1.Text = Form.IDLookup
                txtKodeProduksiBahan1.Focus()
                SendKeys.Send("{TAB}")
            End If
        End If

    End Sub

    'Lookup Daftar Kode Produksi
    Private Sub btLookupKodeProduksiBahan2_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksiBahan2.Click
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
                txtKodeProduksiBahan2.Text = Form.IDLookup
                txtKodeProduksiBahan2.Focus()
                SendKeys.Send("{TAB}")
            End If

        End If

    End Sub

    'Lookup Daftar Kode Produksi
    Private Sub btLookupKodeProduksiBahan3_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksiBahan3.Click
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
                txtKodeProduksiBahan3.Text = Form.IDLookup
                txtKodeProduksiBahan3.Focus()
                SendKeys.Send("{TAB}")
            End If

        End If

    End Sub

    'Lookup Daftar Kode Produksi
    Private Sub btLookupKodeProduksiBahan4_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksiBahan4.Click
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
                txtKodeProduksiBahan4.Text = Form.IDLookup
                txtKodeProduksiBahan4.Focus()
                SendKeys.Send("{TAB}")
            End If

        End If

    End Sub

    'Lookup Daftar Kode Produksi
    Private Sub btLookupKodeProduksiBahan5_Click(sender As Object, e As EventArgs) Handles btLookupKodeProduksiBahan5.Click
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
                txtKodeProduksiBahan5.Text = Form.IDLookup
                txtKodeProduksiBahan5.Focus()
                SendKeys.Send("{TAB}")
            End If

        End If

    End Sub

#End Region

#Region "Save To Database"

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btReprint.Click
        SetLocalDateTime()

        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()

        Dim NoTransaksi As String
        Dim KodeProduksi As String

        Dim PeriodeTransaksi As String = GetPeriod(TglTransaksi)

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                Dim StockRoll As StockRoll

                'Cek Lokasi Gudang Stock
                If txtKodeProduksiBahan1.Text.Trim() <> "" Then
                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan1.Text).KodeLokasi
                    If LokasiStockWO <> KodeLokasi Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        GoTo Jump
                    End If
                End If

                If txtKodeProduksiBahan2.Text.Trim() <> "" Then
                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan2.Text).KodeLokasi
                    If LokasiStockWO <> KodeLokasi Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        GoTo Jump
                    End If
                End If

                If txtKodeProduksiBahan3.Text.Trim() <> "" Then
                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan3.Text).KodeLokasi
                    If LokasiStockWO <> KodeLokasi Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        GoTo Jump
                    End If
                End If

                If txtKodeProduksiBahan4.Text.Trim() <> "" Then
                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan4.Text).KodeLokasi
                    If LokasiStockWO <> KodeLokasi Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        GoTo Jump
                    End If
                End If

                If txtKodeProduksiBahan5.Text.Trim() <> "" Then
                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan5.Text).KodeLokasi
                    If LokasiStockWO <> KodeLokasi Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        GoTo Jump
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Proses Rewind ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try

                    Dim DaftarProduksiRewind As New DaftarProduksiRewind(ActiveSession)
                    Dim ProduksiRewind As ProduksiRewind
                    Dim PrefikKodeProduksi As String = New DaftarLokasi(ActiveSession).Find(KodeLokasi).PrefikKodeTransaksi
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    NoTransaksi = DaftarProduksiRewind.GetNomorTransaksi(PeriodeTransaksi)
                    KodeProduksi = DaftarStockRoll.GetKodeProduksi(lblKodeUnitProduksi.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)


                    'Simpan Data Transaksi Produksi
                    ProduksiRewind = New ProduksiRewind
                    With ProduksiRewind

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
                        .FGKodeProduksi = KodeProduksi
                        .FGKodeItem = lblKodeItemHasilProduksi.Text
                        .FGNamaItem = lblNamaItemHasilProduksi.Text
                        .FGPanjang = txtHasilMeter.Value
                        .FGBeratBrutto = FGBeratBrutto
                        .FGBeratNetto = FGBeratNetto
                        .FGKodeMedia = FGKodeMedia
                        .FGBeratMedia = FGBeratMedia
                        .FGKodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                        .FGKeterangan = txtKeterangan.Text
                        .KodeKaryawan = txtNIKOperator.Text

                        If txtKodeProduksiBahan1.Text.Trim() <> "" Then
                            .RM1KodeLokasi = KodeLokasi
                            .RM1KodeProduksi = txtKodeProduksiBahan1.Text
                            .RM1KodeItem = txtKodeItemBahan1.Text
                            .RM1NamaItem = lblNamaItemBahan1.Text
                            .RM1StockPanjang = txtStockBahan1.Value
                            .RM1StockBerat = RM1StockBahan
                            .RM1PemakaianPanjang = txtPemakaianBahan1.Value
                            .RM1PemakaianBerat = RM1StockBahan
                            .RM1SisaPanjang = 0
                            .RM1SisaBerat = 0
                        Else
                            .RM1KodeLokasi = ""
                            .RM1KodeProduksi = ""
                            .RM1KodeItem = ""
                            .RM1NamaItem = ""
                            .RM1StockPanjang = 0
                            .RM1StockBerat = 0
                            .RM1PemakaianPanjang = 0
                            .RM1PemakaianBerat = 0
                            .RM1SisaPanjang = 0
                            .RM1SisaBerat = 0
                        End If

                        If txtKodeProduksiBahan2.Text.Trim() <> "" Then
                            .RM2KodeLokasi = KodeLokasi
                            .RM2KodeProduksi = txtKodeProduksiBahan2.Text
                            .RM2KodeItem = txtKodeItemBahan2.Text
                            .RM2NamaItem = lblNamaItemBahan2.Text
                            .RM2StockPanjang = txtStockBahan2.Value
                            .RM2StockBerat = RM2StockBahan
                            .RM2PemakaianPanjang = txtPemakaianBahan2.Value
                            .RM2PemakaianBerat = RM2StockBahan
                            .RM2SisaPanjang = 0
                            .RM2SisaBerat = 0
                        Else
                            .RM2KodeLokasi = ""
                            .RM2KodeProduksi = ""
                            .RM2KodeItem = ""
                            .RM2NamaItem = ""
                            .RM2StockPanjang = 0
                            .RM2StockBerat = 0
                            .RM2PemakaianPanjang = 0
                            .RM2PemakaianBerat = 0
                            .RM2SisaPanjang = 0
                            .RM2SisaBerat = 0
                        End If

                        If txtKodeProduksiBahan3.Text.Trim() <> "" Then
                            .RM3KodeLokasi = KodeLokasi
                            .RM3KodeProduksi = txtKodeProduksiBahan3.Text
                            .RM3KodeItem = txtKodeItemBahan3.Text
                            .RM3NamaItem = lblNamaItemBahan3.Text
                            .RM3StockPanjang = txtStockBahan3.Value
                            .RM3StockBerat = RM3StockBahan
                            .RM3PemakaianPanjang = txtPemakaianBahan3.Value
                            .RM3PemakaianBerat = RM3StockBahan
                            .RM3SisaPanjang = 0
                            .RM3SisaBerat = 0
                        Else
                            .RM3KodeLokasi = ""
                            .RM3KodeProduksi = ""
                            .RM3KodeItem = ""
                            .RM3NamaItem = ""
                            .RM3StockPanjang = 0
                            .RM3StockBerat = 0
                            .RM3PemakaianPanjang = 0
                            .RM3PemakaianBerat = 0
                            .RM3SisaPanjang = 0
                            .RM3SisaBerat = 0
                        End If

                        If txtKodeProduksiBahan4.Text.Trim() <> "" Then
                            .RM4KodeLokasi = KodeLokasi
                            .RM4KodeProduksi = txtKodeProduksiBahan4.Text
                            .RM4KodeItem = txtKodeItemBahan4.Text
                            .RM4NamaItem = lblNamaItemBahan4.Text
                            .RM4StockPanjang = txtStockBahan4.Value
                            .RM4StockBerat = RM4StockBahan
                            .RM4PemakaianPanjang = txtPemakaianBahan4.Value
                            .RM4PemakaianBerat = RM4StockBahan
                            .RM4SisaPanjang = 0
                            .RM4SisaBerat = 0
                        Else
                            .RM4KodeLokasi = ""
                            .RM4KodeProduksi = ""
                            .RM4KodeItem = ""
                            .RM4NamaItem = ""
                            .RM4StockPanjang = 0
                            .RM4StockBerat = 0
                            .RM4PemakaianPanjang = 0
                            .RM4PemakaianBerat = 0
                            .RM4SisaPanjang = 0
                            .RM4SisaBerat = 0
                        End If

                        If txtKodeProduksiBahan5.Text.Trim() <> "" Then
                            .RM5KodeLokasi = KodeLokasi
                            .RM5KodeProduksi = txtKodeProduksiBahan5.Text
                            .RM5KodeItem = txtKodeItemBahan5.Text
                            .RM5NamaItem = lblNamaItemBahan5.Text
                            .RM5StockPanjang = txtStockBahan5.Value
                            .RM5StockBerat = RM5StockBahan
                            .RM5PemakaianPanjang = txtPemakaianBahan5.Value
                            .RM5PemakaianBerat = RM5StockBahan
                            .RM5SisaPanjang = 0
                            .RM5SisaBerat = 0
                        Else
                            .RM5KodeLokasi = ""
                            .RM5KodeProduksi = ""
                            .RM5KodeItem = ""
                            .RM5NamaItem = ""
                            .RM5StockPanjang = 0
                            .RM5StockBerat = 0
                            .RM5PemakaianPanjang = 0
                            .RM5PemakaianBerat = 0
                            .RM5SisaPanjang = 0
                            .RM5SisaBerat = 0
                        End If

                        .UserID = ActiveSession.KodeUser
                    End With
                    DaftarProduksiRewind.Add(ProduksiRewind)

                    'Simpan Data Stock Roll Hasil Produksi
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
                    StockRoll.KodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                    StockRoll.KodeMesin = cboKodeMesin.SelectedValue
                    StockRoll.KodeLokasi = KodeLokasi
                    StockRoll.KodeProduksi = KodeProduksi
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

                    
                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging

                    '--------------------------------------------------------------------------------------------------
                    'Bahan Produksi
                    '--------------------------------------------------------------------------------------------------
                    'Bahan #1
                    If txtKodeProduksiBahan1.Text.Trim() <> "" Then
                        SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     txtKodeItemBahan1.Text,
                                                     txtPemakaianBahan1.Value,
                                                     txtKodeProduksiBahan1.Text,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If

                    'Bahan #2
                    If txtKodeProduksiBahan2.Text.Trim() <> "" Then
                        SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     txtKodeItemBahan2.Text,
                                                     txtPemakaianBahan2.Value,
                                                     txtKodeProduksiBahan2.Text,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If

                    'Bahan #3
                    If txtKodeProduksiBahan3.Text.Trim() <> "" Then
                        SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     txtKodeItemBahan3.Text,
                                                     txtPemakaianBahan3.Value,
                                                     txtKodeProduksiBahan3.Text,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If

                    'Bahan #4
                    If txtKodeProduksiBahan4.Text.Trim() <> "" Then
                        SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     txtKodeItemBahan4.Text,
                                                     txtPemakaianBahan4.Value,
                                                     txtKodeProduksiBahan4.Text,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If

                    'Bahan #5
                    If txtKodeProduksiBahan5.Text.Trim() <> "" Then
                        SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     txtKodeItemBahan5.Text,
                                                     txtPemakaianBahan5.Value,
                                                     txtKodeProduksiBahan5.Text,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If

                    'Eksekusi Data Staging
                    SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)

                    '--------------------------------------------------------------------------------------------------
                    'Hasil Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostFinishedGoodReceipt(KodeUnitSAP,
                                                       cboNomorSPK.SelectedValue,
                                                       TglTransaksi,
                                                       lblKodeItemHasilProduksi.Text,
                                                       txtHasilMeter.Value,
                                                       txtHasilTimbang.Value,
                                                       KodeProduksi,
                                                       "",
                                                       NoTransaksi,
                                                       KodeLokasi)

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
                    MessageBox.Show("Siapkan Label Untuk Mencetak Struk Hasil Rewind", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrintBarcode(KodeProduksi)

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

            Case "btReprint"
                '---------------------------------------------------------------------------------------------------------
                PrintBarcode(New DaftarStockRoll(ActiveSession).FindLastProductionID(lblKodeUnitProduksi.Tag).KodeProduksi, True)
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    'Enable / Disable Button
    Private Sub SetEnableCommand()

        If ActiveSession.KodeUser.ToUpper = "SPVS" Then
            btLookupKodeProduksiBahan1.Visible = True
            btLookupKodeProduksiBahan2.Visible = True
            btLookupKodeProduksiBahan3.Visible = True
            btLookupKodeProduksiBahan4.Visible = True
            btLookupKodeProduksiBahan5.Visible = True
        Else
            btLookupKodeProduksiBahan1.Visible = False
            btLookupKodeProduksiBahan2.Visible = False
            btLookupKodeProduksiBahan3.Visible = False
            btLookupKodeProduksiBahan4.Visible = False
            btLookupKodeProduksiBahan5.Visible = False
        End If

        If cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        If (txtKodeProduksiBahan1.Text.Trim() + txtKodeProduksiBahan2.Text.Trim() + txtKodeProduksiBahan3.Text.Trim() + txtKodeProduksiBahan4.Text.Trim() + txtKodeProduksiBahan5.Text.Trim()).Length = 0 Then
            cboNomorSPK.Enabled = True
            btLookupNomorSPK.Enabled = True
            txtHasilMeter.Enabled = True
        Else
            cboNomorSPK.Enabled = False
            btLookupNomorSPK.Enabled = False
            txtHasilMeter.Enabled = False
        End If

        If txtHasilMeter.Value = 0 Then
            btTimbangHasilProduksi.Enabled = False
            txtHasilTimbang.Value = 0
        Else
            btTimbangHasilProduksi.Enabled = txtHasilMeter.Enabled
        End If

        HitungProduksi()

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(txtHasilMeter.Value = 0, False, True) And _
                         If(txtHasilTimbang.Value = 0, False, True) And _
                         If(txtTotalPemakaianBahan.Value = 0, False, True) And _
                         If(txtNIKOperator.Text = "", False, True)

        lblGrupProduksi.Text = cboKodeGrup.Text
    End Sub

#End Region

#Region "Barcode Printing"

    Private Sub PrintBarcode(KodeProduksi As String, Optional ReprintStatus As Boolean = False)
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

            If StockRoll.KodeUnitPeruntukan.Trim <> "" Then
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnitPeruntukan).NamaUnit)
            Else
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", "")
            End If

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

    Private Sub txtNIKOperator_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtNIKOperator.Validating
        If txtNIKOperator.Text <> "" Then
            Dim DaftarKaryawan As New DaftarKaryawan(ActiveSession)
            Dim Karyawan As Karyawan = DaftarKaryawan.Find(txtNIKOperator.Text.Trim, lblKodeUnitProduksi.Tag)
            If Not IsNothing(Karyawan) Then
                If Karyawan.Aktif = 0 Then
                    MessageBox.Show("Karyawan Sudah Tidak Aktif...!!!", "Peringatan", MessageBoxButtons.OK)
                    txtNIKOperator.Text = ""
                    txtNamaOperator.Text = ""

                    txtNIKOperator.Focus()
                Else
                    txtNamaOperator.Text = Karyawan.NamaKaryawan
                End If
            Else
                MessageBox.Show("Nomor Induk Karyawan Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK)
                txtNIKOperator.Text = ""
                txtNamaOperator.Text = ""

                txtNIKOperator.Focus()
            End If
        End If

    End Sub

#End Region
    
    
End Class