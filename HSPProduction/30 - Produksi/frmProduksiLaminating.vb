Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiLaminating

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
    Private RMKodeUnit As String
    Private RMRataRata1 As Double
    Private RMRataRata2 As Double

    Private SBBeratBrutto As Double
    Private SBBeratNetto As Double
    Private SBKodeMedia As String
    Private SBBeratMedia As Double

    Private TRX1Bahan As String
    Private TRX2Bahan As String

    Private QtyPlan As Double
    Private QtyHasil As Double

    'Private CekComboSPK As Boolean = False
#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnitProduksi.Tag = GetSetting(enumFormID.frmLaminating, enumSetting.settingKodeUnit)
        lblKodeLokasiHasilProduksi.Tag = GetSetting(enumFormID.frmLaminating, enumSetting.settingKodeLokasi)
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

        'Unit Produksi Peruntukan
        Dim DaftarKetToleransi As New DaftarKeteranganToleransi(ActiveSession)

        DS = New DataSet
        DS = DaftarKetToleransi.Read("%")
        cboKeterangan.DataSource = DS.Tables("View")
        cboKeterangan.DisplayMember = "Keterangan"
        cboKeterangan.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = "N"
        Drow("Keterangan") = "NORMAL"

        cboKeterangan.SelectedIndex = cboKeterangan.Items.Count - 1

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
    Private Sub frmHasilProduksiLaminasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLocalDateTime()
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()
    End Sub

    'Form Close
    Private Sub frmHasilProduksiLaminasi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
        cboKeterangan.SelectedIndex = cboKeterangan.Items.Count - 1
        txtKeterangan.Text = ""

        txtKodeProduksiBahan1.Text = ""
        txtKodeProduksiBahan2.Text = ""
        txtKodeProduksiBahan1.Tag = ""
        txtKodeProduksiBahan2.Tag = ""

        txtKodeItemBahan1.Text = ""
        txtKodeItemBahan2.Text = ""
        lblNamaItemBahan1.Text = ""
        lblNamaItemBahan2.Text = ""
        txtStockBahan1.Value = 0
        txtStockBahan2.Value = 0
        txtPemakaianBahan1.Value = 0
        txtPemakaianBahan2.Value = 0
        txtSisaBahan1.Value = 0
        txtSisaBahan2.Value = 0
        txtTotalStockBahan.Value = 0
        txtTotalPemakaianBahan.Value = 0
        txtTotalSisaBahan.Value = 0
        txtSisaBahanMeter.Value = 0
        txtSisaBahanTimbang.Value = 0

        txtNIKOperator.Text = ""
        txtNamaOperator.Text = ""

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        chkLokasiMesin.Checked = False

        FGBeratBrutto = 0
        FGBeratNetto = 0
        FGKodeMedia = ""
        FGBeratMedia = 0

        RM1StockBahan = 0
        RM2StockBahan = 0
        RMKodeUnit = ""

        RMRataRata1 = 0
        RMRataRata2 = 0

        SBBeratBrutto = 0
        SBBeratNetto = 0
        SBKodeMedia = ""
        SBBeratMedia = 0

        TRX1Bahan = 0
        TRX2Bahan = 0

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
        txtKodeItemBahan1.TextChanged,
        txtKodeItemBahan2.TextChanged,
        txtStockBahan1.TextChanged,
        txtStockBahan2.TextChanged,
        txtPemakaianBahan1.TextChanged,
        txtPemakaianBahan2.TextChanged,
        txtSisaBahan1.TextChanged,
        txtSisaBahan2.TextChanged,
        txtTotalStockBahan.TextChanged,
        txtTotalPemakaianBahan.TextChanged,
        txtTotalSisaBahan.TextChanged,
        txtSisaBahanMeter.TextChanged,
        txtSisaBahanTimbang.TextChanged,
        chkShiftSebelumnya.CheckedChanged,
        chkLokasiMesin.CheckedChanged,
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

                CekPemakaianBahan(ActiveSession.KodeUser + Now.ToString("yyyyMMddHHmmss") + lblKodeUnitProduksi.Tag)

                If CekWO(cboNomorSPK.SelectedValue.ToString) Then
                    If MessageBox.Show("Hasil Produksi Laminasi Nomor SPK : " + cboNomorSPK.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                   "Plan    = " + QtyPlan.ToString("##,##0") + " METER" + vbCrLf +
                                   "Hasil   = " + QtyHasil.ToString("##,##0") + " METER" + vbCrLf +
                                   "Apakah Akan Melanjutkan Proses Laminasi...?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
                        ResetData()
                    End If
                End If
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
    Private Sub CariDataBahanProduksi(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeProduksiBahan1.Validating, txtKodeProduksiBahan2.Validating
        Dim StockRoll As StockRoll
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
        Dim RM As New RMWorkOrder

        TRX1Bahan = ""
        TRX2Bahan = ""

        Select Case sender.Name
            Case "txtKodeProduksiBahan1"

                If Not (KodeLokasi = "" Or txtKodeProduksiBahan1.Text.Trim = "") Then

                    StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan1.Text, KodeLokasi)
                    If Not IsNothing(StockRoll) Then
                        lblNamaItemBahan1.Text = StockRoll.NamaItem
                        txtKodeItemBahan1.Text = StockRoll.KodeItem
                        RMKodeUnit = StockRoll.KodeUnit

                        If StockRoll.PanjangRoll <> 0 Then
                            RMRataRata1 = StockRoll.BeratNetto / StockRoll.PanjangRoll
                        Else
                            RMRataRata1 = 0
                        End If

                        If txtKodeProduksiBahan1.Text.Trim() = txtKodeProduksiBahan2.Text.Trim() Then
                            MessageBox.Show("Roll Dengan Kode Produksi : " + txtKodeProduksiBahan1.Text.Trim() + " , Sudah Digunakan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan1.Focus()
                            GoTo ResetBahan1
                        End If

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan1.Text)
                        If Not IsNothing(RM) Then

                            If txtKodeProduksiBahan1.Tag.ToString.Trim() <> txtKodeProduksiBahan1.Text.Trim() Then
                                txtStockBahan1.Value = StockRoll.PanjangRoll
                                'txtPemakaianBahan1.Value = txtStockBahan1.Value
                                txtPemakaianBahan1.Value = 0
                                txtSisaBahan1.Value = 0
                            End If
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

                        If StockRoll.PanjangRoll <> 0 Then
                            RMRataRata2 = StockRoll.BeratNetto / StockRoll.PanjangRoll
                        Else
                            RMRataRata2 = 0
                        End If

                        If txtKodeProduksiBahan1.Text.Trim() = txtKodeProduksiBahan2.Text.Trim() Then
                            MessageBox.Show("Roll Dengan Kode Produksi : " + txtKodeProduksiBahan1.Text.Trim() + " , Sudah Digunakan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtKodeProduksiBahan2.Focus()
                            GoTo ResetBahan2
                        End If

                        RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan2.Text)
                        If Not IsNothing(RM) Then

                            If txtKodeProduksiBahan2.Tag.ToString.Trim() <> txtKodeProduksiBahan2.Text.Trim() Then
                                txtStockBahan2.Value = StockRoll.PanjangRoll
                                'txtPemakaianBahan2.Value = txtStockBahan2.Value
                                txtPemakaianBahan2.Value = 0
                                txtSisaBahan2.Value = 0
                            End If
                            txtKodeProduksiBahan2.Tag = txtKodeProduksiBahan2.Text.Trim()
                            RM1StockBahan = StockRoll.BeratNetto
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
        RMRataRata1 = 0
        GoTo ExitProcedure

ResetBahan2:
        txtKodeProduksiBahan2.Tag = ""
        lblNamaItemBahan2.Text = ""
        txtKodeProduksiBahan2.Text = ""
        txtKodeItemBahan2.Text = ""
        txtStockBahan2.Value = 0
        txtPemakaianBahan2.Value = 0
        txtSisaBahan2.Value = 0
        RMRataRata2 = 0
        GoTo ExitProcedure


ExitProcedure:
        SetEnableCommand()
    End Sub

    'Hitung Habis Bahan
    Private Sub HabisBahan(sender As Object, e As EventArgs) Handles btHabisBahan1.Click, btHabisBahan2.Click

        Select Case sender.Name
            Case "btHabisBahan1"
                txtPemakaianBahan1.Value = txtStockBahan1.Value
            Case "btHabisBahan2"
                txtPemakaianBahan2.Value = txtStockBahan2.Value
        End Select
        HitungProduksi()

    End Sub

    'Hitung Sisa Bahan
    Private Sub SisaBahan(sender As Object, e As EventArgs) Handles btSisaBahan1.Click, btSisaBahan2.Click

        If txtHasilMeter.Value <> 0 Then
            Select Case sender.Name
                Case "btSisaBahan1"

                    If txtKodeProduksiBahan1.Text.Trim() <> "" Then
                        txtPemakaianBahan2.Value = txtStockBahan2.Value
                        txtPemakaianBahan1.Value = txtHasilMeter.Value - txtPemakaianBahan2.Value
                        If txtPemakaianBahan1.Value > txtStockBahan1.Value Then
                            txtPemakaianBahan1.Value = txtStockBahan1.Value
                        End If
                    End If

                Case "btSisaBahan2"

                    If txtKodeProduksiBahan2.Text.Trim() <> "" Then
                        txtPemakaianBahan1.Value = txtStockBahan1.Value
                        txtPemakaianBahan2.Value = txtHasilMeter.Value - txtPemakaianBahan1.Value
                        If txtPemakaianBahan2.Value > txtStockBahan2.Value Then
                            txtPemakaianBahan2.Value = txtStockBahan2.Value
                        End If
                    End If

            End Select
        End If
        HitungProduksi()

    End Sub

    'Proses Timbang Hasil Produksi
    Private Sub btTimbangHasilProduksi_Click(sender As Object, e As EventArgs) Handles btTimbangHasilProduksi.Click
        Dim F As New frmProsesTimbang
        F.FormID = enumFormID.frmLaminating
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

            txtSisaBahanTimbang.Value = SBBeratNetto
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Hitung Produksi
    Private Sub HitungProduksi()
        txtSisaBahan1.Value = txtStockBahan1.Value - txtPemakaianBahan1.Value
        txtSisaBahan2.Value = txtStockBahan2.Value - txtPemakaianBahan2.Value

        txtTotalStockBahan.Value = txtStockBahan1.Value + txtStockBahan2.Value
        txtTotalPemakaianBahan.Value = txtPemakaianBahan1.Value + txtPemakaianBahan2.Value
        txtTotalSisaBahan.Value = txtSisaBahan1.Value + txtSisaBahan2.Value

        txtSisaBahanMeter.Value = txtTotalSisaBahan.Value
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
                If CekWO(cboNomorSPK.SelectedValue.ToString) Then
                    If MessageBox.Show("Hasil Produksi Laminasi Nomor SPK : " + cboNomorSPK.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                   "Plan    = " + QtyPlan.ToString("##,##0") + " METER" + vbCrLf +
                                   "Hasil   = " + QtyHasil.ToString("##,##0") + " METER" + vbCrLf +
                                   "Apakah Akan Melanjutkan Proses Laminasi...?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
                        ResetData()
                    End If
                End If

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

                'Cek Toleransi
                If Not ActiveSession.Supervisor Then
                    If cboKeterangan.SelectedIndex = cboKeterangan.Items.Count - 1 Then
                        If txtSisaBahanMeter.Value = 0 Then
                            Dim BatasBawah As Double = 0
                            Dim BatasAtas As Double = 0

                            BatasBawah = txtTotalPemakaianBahan.Value - ((1.5 / 100) * txtTotalPemakaianBahan.Value)
                            BatasAtas = txtTotalPemakaianBahan.Value + ((1.5 / 100) * txtTotalPemakaianBahan.Value)

                            If txtHasilMeter.Value <= BatasBawah Then
                                MessageBox.Show("Hasil Laminasi Kurang Dari Batas Toleransi 1,5 % " + vbCrLf + "Hubungi Supervisor...!")
                                GoTo Jump
                            End If
                            If txtHasilMeter.Value >= BatasAtas Then
                                MessageBox.Show("Hasil Laminasi Melebihi Dari Batas Toleransi 1,5 % " + vbCrLf + "Hubungi Supervisor...!")
                                GoTo Jump
                            End If
                        End If
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Produksi Laminasi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try

                    If New DaftarPemakaianBahan(ActiveSession).IsEmpty(cboNomorSPK.SelectedValue) Then
                        MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GoTo Jump
                    Else
                        If Not New DaftarPemakaianBahan(ActiveSession).IsPemakaianBahan(cboNomorSPK.SelectedValue) Then
                            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo Jump
                        End If
                    End If

                    Dim DaftarProduksiLaminasi As New DaftarProduksiLaminasi(ActiveSession)
                    Dim ProduksiLaminasi As ProduksiLaminasi
                    Dim PrefikKodeProduksi As String = New DaftarLokasi(ActiveSession).Find(KodeLokasi).PrefikKodeTransaksi
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    NoTransaksi = DaftarProduksiLaminasi.GetNomorTransaksi(PeriodeTransaksi)
                    KodeProduksi = DaftarStockRoll.GetKodeProduksi(lblKodeUnitProduksi.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)

                    'Hitung Berat Standar Jika Sisa Roll Ada Dimesin
                    If txtSisaBahanMeter.Value = 0 Or chkLokasiMesin.Checked Then

                        If txtSisaBahan1.Value <> 0 Then
                            SBBeratBrutto = txtSisaBahan1.Value * RMRataRata1
                            SBBeratMedia = 0
                            SBBeratNetto = SBBeratBrutto
                            SBKodeMedia = ""
                        End If

                        If txtSisaBahan2.Value <> 0 Then
                            SBBeratBrutto = txtSisaBahan2.Value * RMRataRata2
                            SBBeratMedia = 0
                            SBBeratNetto = SBBeratBrutto
                            SBKodeMedia = ""
                        End If

                    End If

                    'Simpan Data Transaksi Produksi
                    ProduksiLaminasi = New ProduksiLaminasi
                    With ProduksiLaminasi

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
                        .KetToleransi = cboKeterangan.SelectedValue

                        If txtKodeProduksiBahan1.Text.Trim() <> "" Then
                            .RM1KodeLokasi = KodeLokasi
                            .RM1KodeProduksi = txtKodeProduksiBahan1.Text
                            .RM1KodeItem = txtKodeItemBahan1.Text
                            .RM1NamaItem = lblNamaItemBahan1.Text
                            .RM1StockPanjang = txtStockBahan1.Value
                            .RM1StockBerat = RM1StockBahan
                            .RM1PemakaianPanjang = txtPemakaianBahan1.Value
                            .RM1PemakaianBerat = If(txtSisaBahan1.Value = 0, .RM1StockBerat, .RM1StockBerat - SBBeratNetto)
                            .RM1SisaPanjang = txtSisaBahan1.Value
                            .RM1SisaBerat = .RM1StockBerat - .RM1PemakaianBerat
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
                            .RM2PemakaianBerat = If(txtSisaBahan2.Value = 0, .RM2StockBerat, .RM2StockBerat - SBBeratNetto)
                            .RM2SisaPanjang = txtSisaBahan2.Value
                            .RM2SisaBerat = .RM2StockBerat - .RM2PemakaianBerat
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

                        .SBKodeProduksi = If(txtSisaBahan1.Value = 0 And txtSisaBahan2.Value = 0, "", If(txtSisaBahan1.Value <> 0, txtKodeProduksiBahan1.Text, If(txtSisaBahan2.Value <> 0, txtKodeProduksiBahan2.Text, "")))
                        .SBPanjang = txtSisaBahanMeter.Value
                        .SBBeratBrutto = SBBeratBrutto
                        .SBBeratNetto = SBBeratNetto
                        .SBKodeMedia = SBKodeMedia
                        .SBBeratMedia = SBBeratMedia

                        .SisaDiMesin = If(chkLokasiMesin.Checked, 1, 0)

                        .UserID = ActiveSession.KodeUser
                    End With
                    DaftarProduksiLaminasi.Add(ProduksiLaminasi)

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

                    'Simpan Data Stock Roll Sisa Bahan Produksi
                    If txtSisaBahanMeter.Value <> 0 Then

                        Dim RMKodeProduksi As String = If(txtSisaBahan1.Value = 0, txtKodeProduksiBahan2.Text, txtKodeProduksiBahan1.Text)
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
                        StockRoll.PanjangRoll = txtSisaBahanMeter.Value
                        StockRoll.StatusStock = 1
                        StockRoll.Jumlah1 = 1
                        StockRoll.Jumlah2 = txtSisaBahanMeter.Value
                        StockRoll.Jumlah3 = txtSisaBahanTimbang.Value
                        StockRoll.UserID = ActiveSession.KodeUser
                        DaftarStockRoll.Add(StockRoll)

                    End If


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
                    MessageBox.Show("Siapkan Label Untuk Mencetak Struk Hasil Roll Produksi Printing", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrintBarcode(KodeProduksi)

                    If txtSisaBahanTimbang.Value <> 0 Then
                        If Not chkLokasiMesin.Checked Then
                            MessageBox.Show("Siapkan Label Untuk Mencetak Struk Sisa Roll Bahan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            PrintBarcode(If(txtSisaBahan1.Value = 0, txtKodeProduksiBahan2.Text, txtKodeProduksiBahan1.Text))
                        End If
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
        Else
            btLookupKodeProduksiBahan1.Visible = False
        End If

        If cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        If (txtKodeProduksiBahan1.Text.Trim() + txtKodeProduksiBahan2.Text.Trim()).Length = 0 Then
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

        If txtSisaBahanMeter.Value = 0 Then
            chkLokasiMesin.Enabled = False
            chkLokasiMesin.Checked = False
        Else
            chkLokasiMesin.Enabled = True
        End If

        If txtSisaBahanMeter.Value = 0 Or chkLokasiMesin.Checked Then
            btTimbangSisaBahan.Enabled = False
            txtSisaBahanTimbang.Value = 0
        Else
            btTimbangSisaBahan.Enabled = True
        End If

        HitungProduksi()

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(txtHasilMeter.Value = 0, False, True) And _
                         If(txtHasilTimbang.Value = 0, False, True) And _
                         If(txtTotalPemakaianBahan.Value = 0, False, True) And _
                         If(txtTotalSisaBahan.Value = 0, True, If(chkLokasiMesin.Checked, True, If(txtSisaBahanTimbang.Value = 0, False, True))) And _
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
    Private Sub CekPemakaianBahan(NoTransaksi As String)
        'Simpan Data Item Bahan dan Cek Pemakaian Bahan By WO
        Dim SAP As New SAPWorkOrder
        Dim DS As DataSet

        Dim X_DPB As New X_DaftarPemakaianBahan(ActiveSession)
        Dim X_PB As New X_PemakaianBahan

        DS = SAP.ReadRMByWONonBatch(cboNomorSPK.SelectedValue, KodeUnitSAP)
        For Each DR As DataRow In DS.Tables("View").Rows
            X_PB.NoTransaksi = NoTransaksi
            X_PB.NomorWO = cboNomorSPK.SelectedValue
            X_PB.KodeItem = DR("Kode Item")
            X_PB.NamaItem = DR("Nama Item")

            X_DPB.Add(X_PB)
        Next

        Dim DPB As New DaftarPemakaianBahan(ActiveSession)
        Dim PB As PemakaianBahanZero = DPB.GetItemZero(cboNomorSPK.SelectedValue)
        If Not IsNothing(PB) Then
            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!" + vbCrLf +
                            PB.KodeBahan + " - " + PB.NamaBahan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ResetData()
        End If

        X_DPB.Delete(NoTransaksi)
    End Sub

    Private Function CekWO(NomorWO As String) As Boolean
        Dim SAPWorkOrder As New SAPWorkOrder
        QtyPlan = SAPWorkOrder.FindFGByWO(KodeUnitSAP, NomorWO).QtyBOM
        QtyHasil = New DaftarProduksiLaminasi(ActiveSession).FindQtyHasil(NomorWO).FGPanjang + txtHasilMeter.Value

        CekWO = If(QtyPlan < QtyHasil, True, False)
    End Function

    Private Sub txtHasilMeter_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtHasilMeter.Validating
        If txtHasilMeter.Text <> "" Then
            If CekWO(cboNomorSPK.SelectedValue.ToString) Then
                If MessageBox.Show("Hasil Produksi Laminasi Nomor SPK : " + cboNomorSPK.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                   "Plan    = " + QtyPlan.ToString("##,##0") + " METER" + vbCrLf +
                                   "Hasil   = " + QtyHasil.ToString("##,##0") + " METER" + vbCrLf +
                                   "Apakah Akan Melanjutkan Proses Laminasi...?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
                    ResetData()
                End If
            End If
        End If
    End Sub

    Private Sub tmrStabil_Tick(sender As Object, e As EventArgs) Handles tmrStabil.Tick

    End Sub
End Class