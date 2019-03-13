Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiCBSP

#Region "Variable Declaration"
    Private KodeUnitSAP As String
    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private BeratBrutto As Double
    Private BeratNetto As Double
    Private KodeMedia As String
    Private BeratMedia As Double
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

    Private Sub FillComboItemProduksi()
        If cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1 Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            DS = SAPWorkOrder.ReadRMByWO(cboNomorSPK.SelectedValue, KodeUnitSAP)
            cboKodeItem.DataSource = DS.Tables("View")
            cboKodeItem.DisplayMember = "Nama Item"
            cboKodeItem.ValueMember = "Kode Item"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode Item") = ""
            Drow("Kode Item") = "-"
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode Item")

            cboKodeItem.DataSource = DS.Tables("View")
            cboKodeItem.DisplayMember = "Kode Item"
            cboKodeItem.ValueMember = "Kode Item"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode Item") = ""
            Drow("Kode Item") = "-"
        End If

        cboKodeItem.SelectedIndex = cboKodeItem.Items.Count - 1
    End Sub
#End Region

#Region "Controller"

    'Form Load
    Private Sub frmHasilProduksiCBSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()
    End Sub

    'Form Close
    Private Sub frmHasilProduksiCBSP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PortTimbangan.Close()
    End Sub

    'Reset data
    Private Sub ResetData()

        lblGrupProduksi.Text = ""

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1
        txtSisaMeter.Value = 0
        txtSisaTimbang.Value = 0

        cboKodeUnitPeruntukan.SelectedValue = lblKodeUnitProduksi.Tag
        txtKeterangan.Text = ""

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        BeratBrutto = 0
        BeratNetto = 0
        KodeMedia = ""
        BeratMedia = 0

        Call chkShiftSebelumnya_CheckedChanged(Nothing, Nothing)

    End Sub

    'Jika Data Berubah
    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        txtSisaMeter.TextChanged,
        txtSisaTimbang.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtSisaMeter.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

    'Cek Jika Data Berubah
    Private Sub chkShiftSebelumnya_CheckedChanged(sender As Object, e As EventArgs) Handles chkShiftSebelumnya.CheckedChanged
        FillComboNomorSPK()
        FillComboItemProduksi()
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
        TglPencatatan = GetDateTimeServer()

        lblTglTimbang.Text = GetDateTimeServer().Date.ToString("dd") & " " & GetPeriodDescription(GetDateTimeServer().Date).ToUpper()
        lblJamTimbang.Text = GetDateTimeServer().ToString("HH:mm:ss")

        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = GetDateTimeServer().ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                lblKodeShift.Text = 3
                lblTglTransaksi.Text = DateAdd("D", -1, GetDateTimeServer().Date).ToString("dd-MM-yyyy")
                TglTransaksi = DateAdd("D", -1, GetDateTimeServer().Date)
            Else
                lblKodeShift.Text = 1
                lblTglTransaksi.Text = GetDateTimeServer().Date.ToString("dd-MM-yyyy")
                TglTransaksi = GetDateTimeServer().Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                lblKodeShift.Text = 1
                lblTglTransaksi.Text = GetDateTimeServer().Date.ToString("dd-MM-yyyy")
                TglTransaksi = GetDateTimeServer().Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                lblKodeShift.Text = 2
                lblTglTransaksi.Text = GetDateTimeServer().Date.ToString("dd-MM-yyyy")
                TglTransaksi = GetDateTimeServer().Date
            Else
                lblKodeShift.Text = 3
                lblTglTransaksi.Text = GetDateTimeServer().Date.ToString("dd-MM-yyyy")
                TglTransaksi = GetDateTimeServer().Date
            End If
        End If

        'Jika Hasil lblKodeShift Sebelumnya
        '---------------------------------------------------------------------------------------------------
        If chkShiftSebelumnya.Checked = True Then
            Select Case lblKodeShift.Text
                Case 1
                    lblKodeShift.Text = 3
                    lblTglTransaksi.Text = DateAdd("D", -1, GetDateTimeServer().Date).ToString("dd-MM-yyyy")
                    TglTransaksi = DateAdd("D", -1, GetDateTimeServer().Date)
                Case 2
                    lblKodeShift.Text = 1
                    lblTglTransaksi.Text = GetDateTimeServer().Date.ToString("dd-MM-yyyy")
                    TglTransaksi = GetDateTimeServer().Date
                Case 3
                    lblKodeShift.Text = 2
                    If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
                        lblTglTransaksi.Text = DateAdd("D", -1, GetDateTimeServer().Date).ToString("dd-MM-yyyy")
                        TglTransaksi = DateAdd("D", -1, GetDateTimeServer().Date)
                    Else
                        lblTglTransaksi.Text = GetDateTimeServer().Date.ToString("dd-MM-yyyy")
                        TglTransaksi = GetDateTimeServer().Date
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

                FillComboItemProduksi()

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

    Private Sub btLookupKodeItem_Click(sender As Object, e As EventArgs) Handles btLookupKodeItem.Click
        Dim DaftarRMItem As IDataLookup = New SAPWorkOrder
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarRMAktifByWO, KodeUnitSAP, TglTransaksi.Date, cboNomorSPK.SelectedValue}

        Dim Form As New frmLookup(DaftarRMItem, Parameter)
        Form.Text = "Lookup Daftar Raw Material Aktif"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeItem.SelectedValue = Form.IDLookup
            cboKodeItem.Focus()
        End If
    End Sub

    'Proses Timbang Hasil Produksi
    Private Sub btTimbangSisaRoll_Click(sender As Object, e As EventArgs) Handles btTimbangSisaRoll.Click
        Dim F As New frmProsesTimbang
        F.FormID = enumFormID.frmLaminating
        F.KodeLokasi = lblKodeLokasiHasilProduksi.Tag
        F.KodeUnit = lblKodeUnitProduksi.Tag
        F.KodeMedia = KodeMedia
        F.Text = "Proses Timbang -> Roll Sisa Produksi"
        F.ShowDialog()
        If F.Result = "OK" Then
            BeratBrutto = F.BeratBrutto
            BeratNetto = F.BeratNetto
            KodeMedia = F.KodeMedia
            BeratMedia = F.BeratMedia

            txtSisaTimbang.Value = BeratNetto
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "Save To Database"

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btReprint.Click
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()

        Dim NoTransaksi As String
        Dim KodeProduksi As String

        Dim PeriodeTransaksi As String = GetPeriod(TglTransaksi)

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                Dim StockRoll As StockRoll

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Sisa Roll Bahan Produksi  ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try

                    Dim DaftarProduksiCBSP As New DaftarProduksiCBSP(ActiveSession)
                    Dim ProduksiCBSP As ProduksiCBSP
                    Dim PrefikKodeProduksi As String = New DaftarLokasi(ActiveSession).Find(KodeLokasi).PrefikKodeTransaksi
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    NoTransaksi = DaftarProduksiCBSP.GetNomorTransaksi(PeriodeTransaksi)
                    KodeProduksi = DaftarStockRoll.GetKodeProduksi(lblKodeUnitProduksi.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)

                    'Simpan Data Transaksi Produksi
                    ProduksiCBSP = New ProduksiCBSP
                    With ProduksiCBSP

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
                        .KodeProduksi = KodeProduksi
                        .KodeItem = cboKodeItem.SelectedValue
                        .NamaItem = cboKodeItem.Text
                        .Meter = txtSisaMeter.Value
                        .Kilogram = txtSisaTimbang.Value

                        .UserID = ActiveSession.KodeUser

                        .FGKodeItem = lblKodeItemHasilProduksi.Text
                        .FGNamaItem = lblNamaItemHasilProduksi.Text
                    End With

                    DaftarProduksiCBSP.Add(ProduksiCBSP)

                    'Simpan Data Stock Roll Hasil Produksi
                    StockRoll = New StockRoll
                    StockRoll.NoTransaksi = NoTransaksi
                    StockRoll.TglTransaksi = TglTransaksi.Date
                    StockRoll.TglTimbang = TglPencatatan
                    StockRoll.NomorWO = cboNomorSPK.SelectedValue
                    StockRoll.KodeItem = cboKodeItem.SelectedValue
                    StockRoll.NamaItem = cboKodeItem.Text
                    StockRoll.KodeShift = lblKodeShift.Text
                    StockRoll.KodeGrup = cboKodeGrup.SelectedValue
                    StockRoll.KodeUnit = lblKodeUnitProduksi.Tag
                    StockRoll.KodeUnitPeruntukan = cboKodeUnitPeruntukan.SelectedValue
                    StockRoll.KodeMesin = cboKodeMesin.SelectedValue
                    StockRoll.KodeLokasi = KodeLokasi
                    StockRoll.KodeProduksi = KodeProduksi
                    StockRoll.BeratBrutto = BeratBrutto
                    StockRoll.KodeMedia = KodeMedia
                    StockRoll.JumlahMedia = 1
                    StockRoll.BeratMedia = BeratMedia
                    StockRoll.BeratNetto = BeratNetto
                    StockRoll.PanjangRoll = txtSisaMeter.Value
                    StockRoll.Pcs = 0
                    StockRoll.Transaksi = 1         ' Hasil Produksi
                    StockRoll.StatusStock = 1       ' Stock Aktif
                    StockRoll.StatusQc = 0          ' Belum Ada Status
                    StockRoll.KodeStatus = ""
                    StockRoll.StatusDisposisi = 0
                    StockRoll.KodeDisposisi = ""
                    StockRoll.Satuan1 = UnitProduksi.KodeSatuan1
                    StockRoll.Satuan2 = UnitProduksi.KodeSatuan2
                    StockRoll.Satuan3 = UnitProduksi.KodeSatuan3
                    StockRoll.Jumlah1 = 1
                    StockRoll.Jumlah2 = txtSisaMeter.Value
                    StockRoll.Jumlah3 = txtSisaTimbang.Value
                    StockRoll.Keterangan = txtKeterangan.Text
                    StockRoll.InputData = 0
                    StockRoll.UserID = ActiveSession.KodeUser
                    DaftarStockRoll.Add(StockRoll)

                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging

                    '--------------------------------------------------------------------------------------------------
                    'Sisa Roll Produksi
                    '--------------------------------------------------------------------------------------------------
                    If cboKodeItem.SelectedValue <> "" Then
                        SAPStaging.PostMaterialReceipt(KodeUnitSAP,
                                                     cboNomorSPK.SelectedValue,
                                                     TglTransaksi,
                                                     cboKodeItem.SelectedValue,
                                                     txtSisaMeter.Value,
                                                     txtSisaTimbang.Value,
                                                     KodeProduksi,
                                                     NoTransaksi,
                                                     KodeLokasi)
                    End If


                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)

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
        If cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        If txtSisaMeter.Value = 0 Then
            btTimbangSisaRoll.Enabled = False
            txtSisaTimbang.Value = 0
        Else
            btTimbangSisaRoll.Enabled = txtSisaMeter.Enabled
        End If

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(cboKodeItem.SelectedIndex = cboKodeItem.Items.Count - 1, False, True) And _
                         If(txtSisaMeter.Value = 0, False, True) And _
                         If(txtSisaTimbang.Value = 0, False, True)

        lblGrupProduksi.Text = cboKodeGrup.Text
    End Sub

#End Region

#Region "Barcode Printing"

    Private Sub PrintBarcode(KodeProduksi As String, Optional ReprintStatus As Boolean = False, Optional RollSisa As Boolean = False)
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
            FormatBt.SetNamedSubStringValue("Status", "A" & If(RollSisa = True, "/S", ""))
            FormatBt.SetNamedSubStringValue("KodeStatus", If(StockRoll.StatusQc = 0, "NONE", If(StockRoll.StatusQc = 1, "OK", If(StockRoll.StatusQc = 2, "NON OK", If(StockRoll.StatusQc = 3, "OVER", If(StockRoll.StatusQc = 4, "UNDER", ""))))))
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(StockRoll.Keterangan) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

#End Region

End Class