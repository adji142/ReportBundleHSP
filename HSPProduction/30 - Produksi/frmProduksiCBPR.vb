Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiCBPR

#Region "Variable Declaration"
    Private KodeUnitSAP As String
    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private RMKodeUnit As String
    Private TRXBahan As String
#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnitProduksi.Tag = GetSetting(enumFormID.frmSemenBag, enumSetting.settingKodeUnit)
        lblKodeLokasiHasilProduksi.Tag = GetSetting(enumFormID.frmSemenBag, enumSetting.settingKodeLokasi)
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
    Private Sub frmHasilProduksiCBPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()
    End Sub

    'Form Close
    Private Sub frmHasilProduksiCBPR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PortTimbangan.Close()
    End Sub

    'Reset data
    Private Sub ResetData()

        lblGrupProduksi.Text = ""

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1

        txtKodeProduksiBahan.Text = ""
        txtKodeProduksiBahan.Tag = ""

        txtKodeItemBahan.Text = ""
        lblNamaItemBahan.Text = ""

        txtMeter.Value = 0
        txtKilogram.Value = 0

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        Call chkShiftSebelumnya_CheckedChanged(Nothing, Nothing)

    End Sub

    'Jika Data Berubah
    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        txtKodeProduksiBahan.TextChanged

        SetEnableCommand()
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
    Private Sub txtKodeProduksiBahan_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeProduksiBahan.Validating
        Dim StockRoll As StockRoll
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
        Dim RM As New RMWorkOrder

        If Not (KodeLokasi = "" Or txtKodeProduksiBahan.Text.Trim = "") Then
            StockRoll = New DaftarStockRoll(ActiveSession).Find(txtKodeProduksiBahan.Text, KodeLokasi)
            If Not IsNothing(StockRoll) Then

                lblNamaItemBahan.Text = StockRoll.NamaItem
                txtKodeItemBahan.Text = StockRoll.KodeItem
                RMKodeUnit = StockRoll.KodeUnit

                RM = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSPK.SelectedValue, txtKodeItemBahan.Text)
                If Not IsNothing(RM) Then

                    If txtKodeProduksiBahan.Tag.ToString.Trim() <> txtKodeProduksiBahan.Text.Trim() Then
                        txtMeter.Value = StockRoll.PanjangRoll
                        txtKilogram.Value = StockRoll.BeratNetto
                    End If

                    txtKodeProduksiBahan.Tag = txtKodeProduksiBahan.Text.Trim()
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
        txtMeter.Value = 0
        txtKilogram.Value = 0

        GoTo ExitProcedure

ExitProcedure:
        SetEnableCommand()
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

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Pemakaian Roll Bahan ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try

                    Dim DaftarProduksiCBPR As New DaftarProduksiCBPR(ActiveSession)
                    Dim ProduksiCBPR As ProduksiCBPR
                    Dim PrefikKodeProduksi As String = New DaftarLokasi(ActiveSession).Find(KodeLokasi).PrefikKodeTransaksi
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    NoTransaksi = DaftarProduksiCBPR.GetNomorTransaksi(PeriodeTransaksi)

                    'Simpan Data Transaksi Produksi
                    ProduksiCBPR = New ProduksiCBPR
                    With ProduksiCBPR

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

                        .KodeLokasi = KodeLokasi
                        .KodeProduksi = txtKodeProduksiBahan.Text
                        .KodeItem = txtKodeItemBahan.Text
                        .NamaItem = lblNamaItemBahan.Text
                        .Meter = txtMeter.Value
                        .Kilogram = txtKilogram.Value

                        .UserID = ActiveSession.KodeUser

                        .FGKodeItem = lblKodeItemHasilProduksi.Text
                        .FGNamaItem = lblNamaItemHasilProduksi.Text

                    End With
                    DaftarProduksiCBPR.Add(ProduksiCBPR)

                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging

                    '--------------------------------------------------------------------------------------------------
                    'Bahan Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                    cboNomorSPK.SelectedValue,
                                                    TglTransaksi,
                                                    txtKodeItemBahan.Text,
                                                    txtMeter.Value,
                                                    txtKodeProduksiBahan.Text,
                                                    NoTransaksi, KodeLokasi)

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        SAPStaging.RemoveStagingData(NoTransaksi)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************

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
        Else
            cboNomorSPK.Enabled = False
            btLookupNomorSPK.Enabled = False
        End If

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(txtKodeProduksiBahan.Text.Trim() = "", False, True)

        lblGrupProduksi.Text = cboKodeGrup.Text
    End Sub

#End Region

End Class