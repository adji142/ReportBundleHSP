Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiCutting

#Region "Variable Declaration"
    Private KodeUnitSAP As String
    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private RMStockBahan As Double

    Private SBBeratBrutto As Double
    Private SBBeratNetto As Double
    Private SBKodeMedia As String
    Private SBBeratMedia As Double

    Private TRXBahan As String
    Private RMKodeUnit As String

    Private QtyPlan As Double
    Private Qtyhasil As Double

    Private CekComboSPK As Boolean = False
#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnitProduksi.Tag = GetSetting(enumFormID.frmCutting, enumSetting.settingKodeUnit)
        lblKodeLokasiHasilProduksi.Tag = GetSetting(enumFormID.frmCutting, enumSetting.settingKodeLokasi)
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
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnitPeruntukan.DataSource = DS.Tables("View")
        cboKodeUnitPeruntukan.DisplayMember = "Unit Produksi"
        cboKodeUnitPeruntukan.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"

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
    Private Sub frmHasilProduksiCutting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()
    End Sub

    'Form Close
    Private Sub frmHasilProduksiCutting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PortTimbangan.Close()
    End Sub

    'Reset data
    Private Sub ResetData()

        lblGrupProduksi.Text = ""

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1

        txtHasilPcs.Value = 0
        txtHasilBS.Value = 0
        txtHasilTotal.Value = 0

        cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1
        txtKeterangan.Text = ""

        txtKodeProduksiBahan.Text = ""
        txtKodeProduksiBahan.Tag = ""

        txtKodeItemBahan.Text = ""
        lblNamaItemBahan.Text = ""

        txtPanjangPotong.Value = 0
        lblJenisRoll.Text = ""

        txtStockBahanMeter.Value = 0
        txtPemakaianBahanMeter.Value = 0
        txtSisaBahanMeter.Value = 0

        txtStockBahanPcs.Value = 0
        txtPemakaianBahanPcs.Value = 0
        txtSisaBahanPcs.Value = 0


        txtTotalSisaBahanPcs.Value = 0
        txtTotalSisaBahanMeter.Value = 0
        txtTotalSisaBahanTimbang.Value = 0

        chkLokasiMesin.Checked = False

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        RMStockBahan = 0
        RMKodeUnit = ""

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
        txtHasilPcs.TextChanged,
        txtHasilBS.TextChanged,
        txtKodeProduksiBahan.TextChanged,
        txtKodeItemBahan.TextChanged,
        txtStockBahanMeter.TextChanged,
        txtPemakaianBahanMeter.TextChanged,
        txtSisaBahanMeter.TextChanged,
        txtTotalSisaBahanMeter.TextChanged,
        txtTotalSisaBahanTimbang.TextChanged,
        chkLokasiMesin.CheckedChanged,
        chkShiftSebelumnya.CheckedChanged

        HitungProduksi()
        SetEnableCommand()

    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtHasilPcs.Enter, txtHasilBS.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

    'Cek Jika Data Berubah
    Private Sub chkShiftSebelumnya_CheckedChanged(sender As Object, e As EventArgs) Handles chkShiftSebelumnya.CheckedChanged
        CekComboSPK = True
        FillComboNomorSPK()
        CekComboSPK = False

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
        If Not CekComboSPK = True Then
            lblKodeItemHasilProduksi.Text = ""
            lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"
            txtPanjangPotong.Value = 0

            If cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1 Then
                Try
                    Dim SAPWorkOrder As New SAPWorkOrder
                    Dim WO As FGWorkOrder = SAPWorkOrder.FindFGByWO(KodeUnitSAP, cboNomorSPK.SelectedValue)

                    lblKodeItemHasilProduksi.Text = WO.KodeItem
                    lblNamaItemHasilProduksi.Text = WO.NamaItem.ToUpper
                    txtPanjangPotong.Value = WO.PanjangPotongCutting

                    If CekWO(cboNomorSPK.SelectedValue.ToString) Then
                        If MessageBox.Show("Hasil Produksi Cutting Nomor SPK : " + cboNomorSPK.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                           "Plan    = " + QtyPlan.ToString("##,##0") + " PCS" + vbCrLf +
                                           "Hasil   = " + Qtyhasil.ToString("##,##0") + " PCS" + vbCrLf +
                                           "Apakah Akan Melanjutkan Proses Cutting...?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
                            ResetData()
                        End If
                    End If
                Catch
                End Try
            End If
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
                lblNamaItemBahan.Text = StockRoll.NamaItem
                txtKodeItemBahan.Text = StockRoll.KodeItem
                RMKodeUnit = StockRoll.KodeUnit

                RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan.Text)
                If Not IsNothing(RM) Then

                    If txtKodeProduksiBahan.Tag.ToString.Trim() <> txtKodeProduksiBahan.Text.Trim() Then
                        txtStockBahanMeter.Value = StockRoll.PanjangRoll
                        'txtPemakaianBahanMeter.Value = txtStockBahanMeter.Value
                        txtPemakaianBahanMeter.Value = 0
                        txtSisaBahanMeter.Value = 0

                        txtStockBahanPcs.Value = StockRoll.Pcs
                        'txtPemakaianBahanPcs.Value = StockRoll.Pcs
                        txtPemakaianBahanPcs.Value = 0
                        txtSisaBahanPcs.Value = 0

                        If StockRoll.Pcs = 0 Then
                            lblJenisRoll.Text = "ROLL POLOS"
                        Else
                            lblJenisRoll.Text = "ROLL PRINTING"
                        End If
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
        lblNamaItemBahan.Text = ""
        txtKodeProduksiBahan.Text = ""
        txtKodeItemBahan.Text = ""
        txtStockBahanMeter.Value = 0
        txtPemakaianBahanMeter.Value = 0
        txtSisaBahanMeter.Value = 0

        txtStockBahanPcs.Value = 0
        txtPemakaianBahanPcs.Value = 0
        txtSisaBahanPcs.Value = 0

        lblJenisRoll.Text = ""

        GoTo ExitProcedure

ExitProcedure:
        SetEnableCommand()
    End Sub

    'Hitung Habis Bahan
    Private Sub btHabisBahan_Click(sender As Object, e As EventArgs) Handles btHabisBahan.Click

        txtPemakaianBahanMeter.Value = txtStockBahanMeter.Value
        txtPemakaianBahanPcs.Value = txtStockBahanPcs.Value
        HitungProduksi()

    End Sub

    'Hitung Sisa Bahan
    Private Sub btSisaBahan_Click(sender As Object, e As EventArgs) Handles btSisaBahan.Click

        If txtStockBahanPcs.Value <> 0 Then
            txtPemakaianBahanPcs.Value = txtHasilPcs.Value + txtHasilBS.Value
        Else
            txtPemakaianBahanPcs.Value = 0
        End If

        txtPemakaianBahanMeter.Value = ((txtHasilPcs.Value + txtHasilBS.Value) * txtPanjangPotong.Value) / 100
        If txtPemakaianBahanMeter.Value > txtStockBahanMeter.Value Then
            txtPemakaianBahanMeter.Value = txtStockBahanMeter.Value
        End If

        HitungProduksi()

    End Sub

    'Proses Timbang Sisa Bahan
    Private Sub btTimbangSisaBahan_Click(sender As Object, e As EventArgs) Handles btTimbangSisaBahan.Click
        Dim F As New frmProsesTimbang
        F.FormID = enumFormID.frmCutting
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
        txtHasilTotal.Value = txtHasilPcs.Value + txtHasilBS.Value
        txtSisaBahanMeter.Value = txtStockBahanMeter.Value - txtPemakaianBahanMeter.Value
        txtSisaBahanPcs.Value = txtStockBahanPcs.Value - txtPemakaianBahanPcs.Value

        txtTotalSisaBahanMeter.Value = txtSisaBahanMeter.Value
        txtTotalSisaBahanPcs.Value = txtSisaBahanPcs.Value

        If txtPanjangPotong.Value <> 0 Then
            txtTargetPotong.Value = Math.Round((txtPemakaianBahanMeter.Value / txtPanjangPotong.Value) * 100)
        Else
            txtTargetPotong.Value = 0
        End If

        txtHasilPotong.Value = txtHasilTotal.Value

        If txtHasilTotal.Value > 0 Then
            If txtTargetPotong.Value = txtHasilTotal.Value Then
                lblStatus.Text = ""
            End If

            If txtTargetPotong.Value > txtHasilTotal.Value Then
                lblStatus.Text = "KURANG"
            End If

            If txtTargetPotong.Value < txtHasilTotal.Value Then
                lblStatus.Text = "LEBIH"
            End If
        Else
            lblStatus.Text = ""
        End If


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
                If CekWO(cboNomorSPK.SelectedValue.ToString) Then
                    If MessageBox.Show("Hasil Produksi Cutting Nomor SPK : " + cboNomorSPK.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                       "Plan    = " + QtyPlan.ToString("##,##0") + " PCS" + vbCrLf +
                                       "Hasil   = " + Qtyhasil.ToString("##,##0") + " PCS" + vbCrLf +
                                       "Apakah Akan Melanjutkan Proses Cutting...?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
                        ResetData()
                    End If
                End If

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

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Produksi Cutting ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try

                    Dim DaftarProduksiCutting As New DaftarProduksiCutting(ActiveSession)
                    Dim ProduksiCutting As ProduksiCutting
                    Dim PrefikKodeProduksi As String = New DaftarLokasi(ActiveSession).Find(KodeLokasi).PrefikKodeTransaksi
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    NoTransaksi = DaftarProduksiCutting.GetNomorTransaksi(PeriodeTransaksi)

                    'Simpan Data Transaksi Produksi
                    ProduksiCutting = New ProduksiCutting
                    With ProduksiCutting

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
                        .FGPcs = txtHasilPcs.Value
                        .FGBs = txtHasilBS.Value
                        .FGTotal = txtHasilPcs.Value + txtHasilBS.Value
                        .FGKodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                        .FGKeterangan = txtKeterangan.Text


                        .RMKodeLokasi = KodeLokasi
                        .RMKodeProduksi = txtKodeProduksiBahan.Text
                        .RMKodeItem = txtKodeItemBahan.Text
                        .RMNamaItem = lblNamaItemBahan.Text
                        .RMPanjangPotong = txtPanjangPotong.Value
                        .RMStockPanjang = txtStockBahanMeter.Value
                        .RMStockBerat = RMStockBahan
                        .RMStockPcs = txtStockBahanPcs.Value
                        .RMPemakaianPanjang = txtPemakaianBahanMeter.Value
                        .RMPemakaianBerat = If(txtSisaBahanMeter.Value = 0, .RMStockBerat, .RMStockBerat - SBBeratNetto)
                        .RMPemakaianPcs = txtPemakaianBahanPcs.Value
                        .RMSisaPanjang = txtSisaBahanMeter.Value
                        .RMSisaBerat = .RMStockBerat - .RMPemakaianBerat
                        .RMSisaPcs = txtSisaBahanPcs.Value

                        .SBKodeProduksi = txtKodeProduksiBahan.Text
                        .SBPanjang = txtTotalSisaBahanMeter.Value
                        .SBPcs = txtTotalSisaBahanPcs.Value
                        .SBBeratBrutto = SBBeratBrutto
                        .SBBeratNetto = SBBeratNetto
                        .SBKodeMedia = SBKodeMedia
                        .SBBeratMedia = SBBeratMedia

                        .UserID = ActiveSession.KodeUser
                    End With
                    DaftarProduksiCutting.Add(ProduksiCutting)

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
                        StockRoll.Pcs = txtTotalSisaBahanPcs.Value
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
                    SAPStaging.PostFinishedGoodReceipt(KodeUnitSAP,
                                                       cboNomorSPK.SelectedValue,
                                                       TglTransaksi,
                                                       lblKodeItemHasilProduksi.Text,
                                                       txtHasilPcs.Value,
                                                       0,
                                                       "",
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
                    If txtTotalSisaBahanTimbang.Value <> 0 Then
                        If Not chkLokasiMesin.Checked Then
                            MessageBox.Show("Siapkan Label Untuk Mencetak Struk Sisa Roll Bahan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            PrintBarcode(txtKodeProduksiBahan.Text)
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
            btLookupKodeProduksiBahan.Visible = True
        Else
            btLookupKodeProduksiBahan.Visible = False
        End If

        If cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        If txtKodeProduksiBahan.Text.Trim().Length = 0 Then
            cboNomorSPK.Enabled = True
            btLookupNomorSPK.Enabled = True
            txtHasilPcs.Enabled = True
            txtHasilBS.Enabled = True
        Else
            cboNomorSPK.Enabled = False
            btLookupNomorSPK.Enabled = False
            txtHasilPcs.Enabled = False
            txtHasilBS.Enabled = False
        End If

        If txtTotalSisaBahanMeter.Value = 0 Or chkLokasiMesin.Checked Then
            btTimbangSisaBahan.Enabled = False
            txtTotalSisaBahanTimbang.Value = 0
        Else
            btTimbangSisaBahan.Enabled = True
        End If

        HitungProduksi()


        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(txtKodeProduksiBahan.Text.Trim() = "", False, True) And _
                         If(txtHasilPcs.Value = 0, False, True) And _
                         If(txtPemakaianBahanMeter.Value = 0, False, True) And _
                         If(txtSisaBahanMeter.Value = 0, True, If(chkLokasiMesin.Checked, True, If(txtTotalSisaBahanTimbang.Value = 0, False, True)))

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

#End Region

    Private Function CekWO(NomorWO As String) As Boolean
        Dim SAPWorkOrder As New SAPWorkOrder
        QtyPlan = SAPWorkOrder.FindFGByWO(KodeUnitSAP, NomorWO).QtyBOM
        Qtyhasil = New DaftarProduksiCutting(ActiveSession).FindQtyHasil(NomorWO).FGPcs + txtHasilPcs.Value

        CekWO = If(QtyPlan < QtyHasil, True, False)
    End Function

    Private Sub txtHasilPcs_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtHasilPcs.Validating
        If txtHasilPcs.Text <> "" Then
            If CekWO(cboNomorSPK.SelectedValue.ToString) Then
                If MessageBox.Show("Hasil Produksi Cutting Nomor SPK : " + cboNomorSPK.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                   "Plan    = " + QtyPlan.ToString("##,##0") + " PCS" + vbCrLf +
                                   "Hasil   = " + Qtyhasil.ToString("##,##0") + " PCS" + vbCrLf +
                                   "Apakah Akan Melanjutkan Proses Cutting...?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
                    ResetData()
                End If
            End If
        End If
    End Sub
End Class