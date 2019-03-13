Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions
Imports VB = Microsoft.VisualBasic

Public Class frmProduksiPackingKarung

#Region "Declaration Variable"
    Private BeratBrutto, BeratMedia, BeratNetto As Double
    Private PrefikKodeProduksi As String
    Private DataScale As String

    Private KodeUnitSAP As String
    Private FGKodeItem As String
    Private FGNamaItem As String
    Private RMKodeItem As String
    Private RMNamaItem As String

    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private _PanjangPotong As Double
    Private _Lebar As Double
    Private _MeshPakan As Double
    Private _MeshLusi As Double
    Private _Denier As Double

    Private _BeratStandar As Double
    Private _ToleransiOver As Double
    Private _ToleransiUnder As Double

    Private QtyPlan As Double
    Private QtyHasil As Double

#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblUnitProduksi.Tag = GetSetting(enumFormID.frmPackingKarung, enumSetting.settingKodeUnit)
        lblLokasiProduksi.Tag = GetSetting(enumFormID.frmPackingKarung, enumSetting.settingKodeLokasi)
        lblLokasiProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblLokasiProduksi.Tag).NamaLokasi.ToUpper

        KodeUnitSAP = ""
        If lblUnitProduksi.Tag <> "" Then
            Try
                Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag)
                lblUnitProduksi.Text = "PROSES " & UnitProduksi.NamaUnit.ToUpper
                KodeUnitSAP = UnitProduksi.KodeUnitSAP

            Catch ex As Exception
                lblUnitProduksi.Tag = ""
                lblUnitProduksi.Text = "Unit Produksi Belum Disetting"
            End Try
        Else
            lblUnitProduksi.Text = "Unit Produksi Belum Disetting"
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

        'Mesin Produksi
        Dim DaftarMesin As New DaftarMesin(ActiveSession)

        DS = New DataSet
        DS = DaftarMesin.Read("%", lblUnitProduksi.Tag)
        cboKodeMesin.DataSource = DS.Tables("View")
        cboKodeMesin.DisplayMember = "Nama Mesin"
        cboKodeMesin.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Mesin") = "-"

        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1

        'Media Timbang
        Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)

        DS = New DataSet
        DS = DaftarMediaTimbang.Read("%", lblLokasiProduksi.Tag, lblUnitProduksi.Tag)
        cboKodeMedia.DataSource = DS.Tables("View")
        cboKodeMedia.DisplayMember = "Nama Media"
        cboKodeMedia.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Media") = "-"

        cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1

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

    Private Sub frmProduksiPackingKarung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()

        ResetData()
        ScaleConnection()
    End Sub

    Private Sub ResetData()

        'Layar Timbang
        '---------------------------------------------------------------------------------------------------
        lblKodeShift.Text = ""
        lblNamaShift.Text = ""
        lblTglTransaksi.Text = ""
        lblNamaGrup.Text = ""

        lblTglTimbang.Text = ""
        lblJamTimbang.Text = ""
        lblItemProduksi.Text = ""

        'Data Timbang
        '---------------------------------------------------------------------------------------------------
        BeratBrutto = 0
        BeratMedia = 0
        BeratNetto = 0

        FGKodeItem = ""
        FGNamaItem = ""
        RMKodeItem = ""
        RMNamaItem = ""

        cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1

        txtBeratBrutto.Value = 0
        txtBeratMedia.Value = 0
        txtBeratNetto.Value = 0
        txtHasilPcs.Value = 0

        txtKeterangan.Text = ""

        txtNIKOperator.Text = ""
        txtNamaOperator.Text = ""

        cboStatusQC.SelectedIndex = 0

        txtTimbangManual.Value = 0
        txtTimbangManual.Enabled = False
        lblTimbangManual.Enabled = False
        lblStabil.Visible = False

        Call chkShiftSebelumnya_CheckedChanged(Nothing, Nothing)

        SetEnableCommand()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Peringatan Bahan
        If lblItemBahanBerbeda.Visible Then
            If lblItemBahanBerbeda.BackColor = Color.Red Then
                lblItemBahanBerbeda.BackColor = Color.DarkGreen
            Else
                lblItemBahanBerbeda.BackColor = Color.Red
            End If
        End If

        'Transaksi
        '---------------------------------------------------------------------------------------------------
        If lblTransaksi.ForeColor = Color.Yellow Then
            lblTransaksi.ForeColor = Color.Blue
        Else
            lblTransaksi.ForeColor = Color.Yellow
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

    'Cek Jika Ditekan F10
    Private Sub cboKodeGrup_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeGrup.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeGrup.PerformClick()
        End If
    End Sub

    'Cek Jika Ditekan F10
    Private Sub cboKodeMesin_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeMesin.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeMesin.PerformClick()
        End If
    End Sub

    'Cek Jika Ditekan F10
    Private Sub cboNomorSpk_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNomorSpk.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupNomorSpk.PerformClick()
        End If
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            cboNomorSpk.SelectedIndexChanged,
                            cboKodeGrup.SelectedIndexChanged,
                            cboKodeMesin.SelectedIndexChanged,
                            txtHasilPcs.TextChanged,
                            txtKeterangan.TextChanged,
                            txtTimbangManual.TextChanged,
                            chkManual.CheckedChanged,
                            chkShiftSebelumnya.CheckedChanged,
                            txtNIKOperator.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeGrup" Then
            lblNamaGrup.Text = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, "", cboKodeGrup.Text)
        End If

        If ObjectName = "cboKodeMedia" Then


        End If

        SetEnableCommand()
    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtHasilPcs.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboKodeMedia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboKodeMedia.SelectedValueChanged

        txtBeratMedia.Text = " 0 KG"
        BeratMedia = 0

        If cboKodeMedia.SelectedIndex <> cboKodeMedia.Items.Count - 1 Then
            Try
                Dim MediaTimbang = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia.SelectedValue)
                If Not IsNothing(MediaTimbang) Then
                    txtBeratMedia.Text = MediaTimbang.Berat & " KG"
                    BeratMedia = MediaTimbang.Berat
                End If
            Catch ex As Exception
            End Try
        End If
        SetEnableCommand()

    End Sub

    'Cek Jika Data Berubah
    Private Sub cboNomorSPK_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNomorSpk.SelectedValueChanged

        lblItemProduksi.Tag = ""
        lblItemProduksi.Text = "SPK / Work Order Belum Ditentukan"

        lblItemBahan.Tag = ""
        lblItemBahan.Text = ""

        lblItemBahanBerbeda.Visible = False

        FGKodeItem = ""
        FGNamaItem = ""
        RMKodeItem = ""
        RMNamaItem = ""

        _PanjangPotong = 0
        _Lebar = 0
        _Denier = 0
        _MeshLusi = 0
        _MeshPakan = 0

        _BeratStandar = 0
        _ToleransiOver = 0
        _ToleransiUnder = 0

        If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
            Try
                Dim WO As New SAPWorkOrder
                Dim WOItem = WO.FindFGByWO(KodeUnitSAP, cboNomorSpk.SelectedValue)
                lblItemProduksi.Tag = WOItem.KodeItem
                lblItemProduksi.Text = WOItem.NamaItem.Trim.ToUpper()

                FGKodeItem = WOItem.KodeItem
                FGNamaItem = WOItem.NamaItem

                _PanjangPotong = WOItem.PanjangPotongCutting
                _Lebar = WOItem.Lebar
                _Denier = WOItem.Denier
                _MeshLusi = WOItem.MeshLusi
                _MeshPakan = WOItem.MeshPakan

                _BeratStandar = WOItem.BeratStandar

                Dim ParameterSistem = New DaftarParameterSistem(ActiveSession).GetParameterSistem()
                _ToleransiOver = ParameterSistem.PackingPcsToleransiOver / 100
                _ToleransiUnder = ParameterSistem.PackingPcsToleransiUnder / 100

                'Item Bahan Produksi
                Dim DT As DataTable = New SAPWorkOrder().ReadRMByWO(cboNomorSpk.SelectedValue, KodeUnitSAP).Tables("View")
                Dim DR As DataRow = DT.Rows(0)

                RMKodeItem = DR("Kode Item")
                RMNamaItem = DR("Nama Item").ToString.ToUpper

                lblItemBahan.Tag = RMKodeItem
                lblItemBahan.Text = RMNamaItem.Trim.ToUpper()

                'Cek Kesesuaian Bahan
                If Microsoft.VisualBasic.InStr(lblItemProduksi.Text, lblItemBahan.Text) = 0 Then
                    lblItemBahanBerbeda.Visible = True
                End If

            Catch
            End Try
        End If

        SetEnableCommand()

    End Sub

    'Cek Jika Data Berubah
    Private Sub chkShiftSebelumnya_CheckedChanged(sender As Object, e As EventArgs) Handles chkShiftSebelumnya.CheckedChanged
        FillComboNomorSPK()
        SetEnableCommand()
    End Sub

    Private Sub frmProduksiPackingKarung_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ScalePort.Close()
    End Sub

    Private Sub btLookupKodeMesin_Click(sender As Object, e As EventArgs) Handles btLookupKodeMesin.Click
        Dim DaftarMesin As IDataLookup = New DaftarMesin(ActiveSession)
        Dim Parameter() As String = {lblUnitProduksi.Tag}

        Dim Form As New frmLookup(DaftarMesin, Parameter)
        Form.Text = "Lookup Daftar Mesin Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMesin.SelectedValue = Form.IDLookup
            cboKodeMesin.Focus()
        End If
    End Sub

    Private Sub btLookupNomorSpk_Click(sender As Object, e As EventArgs) Handles btLookupNomorSpk.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, Stod(lblTglTransaksi.Text)}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar SPK Aktif"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSpk.SelectedValue = Form.IDLookup
            cboNomorSpk.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeGrup_Click(sender As Object, e As EventArgs) Handles btLookupKodeGrup.Click
        Dim DaftarGrup As IDataLookup = New DaftarGrupProduksi(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarGrup, Parameter)
        Form.Text = "Lookup Daftar Grup Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeGrup.SelectedValue = Form.IDLookup
            cboKodeGrup.Focus()
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
        txtBeratBrutto.Value = BeratBrutto
        SetEnableCommand()
    End Sub


#End Region

#Region "Scale Comunication"

    Private Sub ScaleConnection()

        Dim PortName As String
        Dim BaudRate As String

        Try
            PortName = GetSetting(enumFormID.frmPackingKarung, enumSetting.settingPort)
            BaudRate = GetSetting(enumFormID.frmPackingKarung, enumSetting.settingBaudRate)

            ScalePort.PortName = PortName
            ScalePort.BaudRate = BaudRate
            ScalePort.Parity = Parity.None
            ScalePort.DataBits = 8

            ScalePort.Open()

            If ScalePort.IsOpen Then
                lblStatus.Text = "ONLINE"
                lblStatus.ForeColor = Color.Blue
                tmrScale.Enabled = True
            Else
                lblStatus.Text = "OFFLINE"
                lblStatus.ForeColor = Color.Red
                tmrScale.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Ke Mesin Timbangan Gagal...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub DataStreaming(sender As Object, e As SerialDataReceivedEventArgs) Handles ScalePort.DataReceived
        If Not chkManual.Checked Then
            Dim TempScale As String = ""
            While Microsoft.VisualBasic.InStr(TempScale, Chr(3)) = 0 And ScalePort.IsOpen
                Try
                    TempScale += Microsoft.VisualBasic.Chr(ScalePort.ReadChar)
                Catch
                End Try

            End While
            DataScale = TempScale
        End If
    End Sub

    Private Sub tmrScale_Tick(sender As Object, e As EventArgs) Handles tmrScale.Tick
        If Not chkManual.Checked Then
            Static nCounter As Byte
            Static lChange As Boolean

            Dim TempRight As String = ""
            Dim TempLeft As String = ""
            Dim Temp As String = ""
            Dim TempData As String = ""

            Dim Pos As Integer

            If DataScale IsNot Nothing Then
                Temp = DataScale.Trim
            End If

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

                txtBeratBrutto.Value = BeratBrutto

            Else
                BeratBrutto = 0
                txtBeratBrutto.Value = 0
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
                txtBeratBrutto.Value = BeratBrutto

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

            txtBeratNetto.Value = txtBeratBrutto.Value - txtBeratMedia.Value
        End If


jump:
        SetEnableCommand()
    End Sub
#End Region

#Region "Save To Database"

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btReprint.Click

        Dim KodeLokasi As String = lblLokasiProduksi.Tag.ToString.Trim()
        Dim Periode As String
        Dim PeriodeTransaksi As String

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------
                If ActiveSession.Supervisor = False Then
                    If CekWO(cboNomorSpk.SelectedValue.ToString) Then
                        MessageBox.Show("Hasil Produksi Ballpress Nomor SPK : " + cboNomorSpk.SelectedValue.ToString + " Sudah Melampaui Quantity Plan PPIC." + vbCrLf +
                                         "Plan    = " + QtyPlan.ToString("##,##0") + " METER" + vbCrLf +
                                         "Hasil   = " + QtyHasil.ToString("##,##0") + " METER" + vbCrLf +
                                         "Anda Tidak Bisa Melanjutkan Proses Ballpress !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GoTo Jump
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Proses Packing Karung ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    Periode = GetPeriod(Now)
                    PeriodeTransaksi = GetPeriodFull(Now)

                    Dim DaftarStockPacking = New DaftarStockPacking(ActiveSession)
                    Dim StockPacking As StockPacking
                    Dim KodeProduksi As String = DaftarStockPacking.GetKodeProduksi(lblUnitProduksi.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)
                    Dim DaftarProduksiPackingPcs As New DaftarProduksiPackingPcs(ActiveSession)
                    Dim ProduksiPackingPcs As New ProduksiPackingPcs

                    Dim NoTransaksi As String = DaftarProduksiPackingPcs.GetNomorTransaksi(HSP.Data.ProduksiPackingPcs.enumKelompokPackingPcs.PackingKarung, Periode)

                    'Cek Lokasi Gudang Stock


                    Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorSpk.SelectedValue, RMKodeItem).KodeLokasi

                    If LokasiStockWO <> KodeLokasi Then

                        Me.Cursor = Cursors.Default
                        MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                        Scope.Dispose()
                        GoTo Jump
                    End If

                    'Cek Stock Bahan
                    Dim Stock As Double = New SAPInventory().GetCurrentStock(KodeLokasi, RMKodeItem, "")

                    If Stock < txtHasilPcs.Value Then
                        Me.Cursor = Cursors.Default
                        Scope.Dispose()

                        MsgBox("Stock Bahan " & RMNamaItem & " Tidak Mencukupi...!!!")

                        GoTo Jump
                    End If

                    With ProduksiPackingPcs
                        .Kelompok = HSP.Data.ProduksiPackingPcs.enumKelompokPackingPcs.PackingKarung
                        .NoTransaksi = NoTransaksi
                        .TglTransaksi = TglTransaksi
                        .TglPencatatan = TglPencatatan
                        .NomorWO = cboNomorSpk.SelectedValue
                        .KodeUnit = lblUnitProduksi.Tag
                        .KodeShift = lblKodeShift.Text
                        .KodeGrup = cboKodeGrup.SelectedValue
                        .KodeMesin = cboKodeMesin.SelectedValue
                        .ShiftSebelumnya = chkShiftSebelumnya.Checked

                        .FGKodeLokasi = KodeLokasi
                        .FGKodeProduksi = KodeProduksi
                        .FGKodeItem = FGKodeItem
                        .FGNamaItem = FGNamaItem
                        .FGPcs = txtHasilPcs.Value
                        .FGBeratBrutto = txtBeratBrutto.Value
                        .FGBeratNetto = txtBeratNetto.Value
                        .FGKodeMedia = cboKodeMedia.SelectedValue
                        .FGBeratMedia = txtBeratMedia.Value
                        .FGBeratStandar = txtBeratStandarPerPacking.Value

                        .FGKeterangan = txtKeterangan.Text
                        .KodeKaryawan = txtNIKOperator.Text

                        .RMKodeLokasi = KodeLokasi
                        .RMKodeItem = RMKodeItem
                        .RMNamaItem = RMNamaItem
                        .RMPemakaianPcs = txtHasilPcs.Value
                        .UserID = ActiveSession.KodeUser

                        .KodeUnitSAP = KodeUnitSAP
                    End With
                    DaftarProduksiPackingPcs.Add(ProduksiPackingPcs)

                    'Simpan Data Stock Packing Hasil Produksi
                    StockPacking = New StockPacking
                    StockPacking.Kelompok = HSP.Data.StockPacking.enumKelompokPackingPcs.PackingKarung
                    StockPacking.NoTransaksi = NoTransaksi
                    StockPacking.TglTransaksi = TglTransaksi.Date
                    StockPacking.TglTimbang = TglPencatatan
                    StockPacking.NomorWO = cboNomorSpk.SelectedValue
                    StockPacking.KodeItem = FGKodeItem
                    StockPacking.NamaItem = FGNamaItem
                    StockPacking.KodeShift = lblKodeShift.Text
                    StockPacking.KodeGrup = cboKodeGrup.SelectedValue
                    StockPacking.KodeUnit = lblUnitProduksi.Tag
                    StockPacking.KodeMesin = cboKodeMesin.SelectedValue
                    StockPacking.KodeLokasi = KodeLokasi
                    StockPacking.KodeProduksi = KodeProduksi
                    StockPacking.BeratBrutto = BeratBrutto
                    StockPacking.KodeMedia = cboKodeMedia.SelectedValue
                    StockPacking.BeratMedia = txtBeratMedia.Value
                    StockPacking.BeratNetto = txtBeratNetto.Value
                    StockPacking.BeratStandar = txtBeratStandarPerPacking.Value
                    StockPacking.Pcs = txtHasilPcs.Value
                    StockPacking.StatusStock = 1       ' Stock Aktif
                    StockPacking.StatusQc = cboStatusQC.SelectedIndex
                    StockPacking.KodeStatus = ""
                    StockPacking.StatusDisposisi = 0
                    StockPacking.KodeDisposisi = ""
                    StockPacking.Keterangan = txtKeterangan.Text
                    StockPacking.UserID = ActiveSession.KodeUser
                    DaftarStockPacking.Add(StockPacking)

                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging

                    '--------------------------------------------------------------------------------------------------
                    'Bahan Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostMaterialIssue(KodeUnitSAP,
                                                 cboNomorSpk.SelectedValue,
                                                 TglTransaksi,
                                                 RMKodeItem,
                                                 txtHasilPcs.Value,
                                                 "",
                                                 NoTransaksi,
                                                 KodeLokasi)

                    'Eksekusi Data Staging
                    SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)

                    '--------------------------------------------------------------------------------------------------
                    'Hasil Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostFinishedGoodReceipt(KodeUnitSAP,
                                                       cboNomorSpk.SelectedValue,
                                                       TglTransaksi,
                                                       FGKodeItem,
                                                       txtHasilPcs.Value,
                                                       txtBeratNetto.Value,
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

                    'Cetak Barcode
                    '------------------------------------------------------------------------------------------------------
                    MessageBox.Show("Siapkan Label Untuk Mencetak Barcode Produksi ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrintBarcode(KodeProduksi)

                    Me.Cursor = Cursors.Default
                    ResetData()

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try

            Case "btReprint"
                MessageBox.Show("Siapkan Label Untuk Mencetak Barcode Produksi ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PrintBarcode(New DaftarStockPacking(ActiveSession).FindLastProductionID(lblUnitProduksi.Tag).KodeProduksi, True)
            Case "btClose"
                Me.Close()

        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetEnableCommand()

        If cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        If ActiveSession.KodeUser.Trim.ToUpper = "SPVS" Then
            lblTimbangManual.Visible = True
            chkManual.Visible = True
            txtTimbangManual.Visible = True
        Else
            lblTimbangManual.Visible = False
            chkManual.Visible = False
            txtTimbangManual.Visible = False
        End If

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1, False, True) And _
                         If(lblLokasiProduksi.Tag = "", False, True) And _
                         If(BeratNetto <= 0, False, True) And _
                         If(txtHasilPcs.Value <= 0, False, True) And _
                         If(txtBeratStandarPerPacking.Value <= 0, False, True) And _
                         If(cboStatusQC.SelectedIndex = 0, False, True) And _
                         lblStabil.Visible And _
                         If(txtNIKOperator.Text = "", False, True) 

        BeratNetto = BeratBrutto - BeratMedia
        txtBeratNetto.Value = BeratNetto
        lblBeratNetto.Text = BeratNetto.ToString("###,##0.00")
        lblBeratNetto.Tag = BeratNetto

        HitungBeratStandar()
    End Sub

    Private Sub HitungBeratStandar()

        txtBeratStandarPerPCS.Value = _BeratStandar
        txtBeratStandarPerPacking.Value = ((_BeratStandar / 1000) * txtHasilPcs.Value)
        Dim Selisih As Double = txtBeratNetto.Value - txtBeratStandarPerPacking.Value

        Dim BeratStandarOver As Double = txtBeratStandarPerPacking.Value + (_ToleransiOver * txtBeratStandarPerPacking.Value)
        Dim BeratStandarUnder As Double = txtBeratStandarPerPacking.Value - (_ToleransiUnder * txtBeratStandarPerPacking.Value)

        If txtHasilPcs.Value > 0 And txtBeratNetto.Value > 0 And txtBeratStandarPerPacking.Value > 0 Then
            If Selisih > 0 Then
                'Berat Over
                If txtBeratNetto.Value > BeratStandarOver Then
                    cboStatusQC.SelectedIndex = 3
                Else
                    cboStatusQC.SelectedIndex = 1
                End If
            ElseIf Selisih < 0 Then
                'Berat Under
                If txtBeratNetto.Value < BeratStandarUnder Then
                    cboStatusQC.SelectedIndex = 4
                Else
                    cboStatusQC.SelectedIndex = 1
                End If
            Else
                'Berat OK
                cboStatusQC.SelectedIndex = 1
            End If
        Else
            If cboStatusQC.Items.Count > 0 Then
                cboStatusQC.SelectedIndex = 0
            End If
        End If


    End Sub

#End Region

#Region "Barcode Printing"

    Private Sub PrintBarcode(KodeProduksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockPacking As New DaftarStockPacking(ActiveSession)
        Dim StockPacking As StockPacking = DaftarStockPacking.Find(KodeProduksi)
        Dim KodeBall As String

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodePacking.btw", False, "")

        If Not IsNothing(StockPacking) Then

            KodeBall = ""
            For i = 1 To StockPacking.BeratNetto.ToString.Length
                KodeBall += GetFormat(Mid(StockPacking.BeratNetto.ToString, i, 1))
            Next

            FormatBt.SetNamedSubStringValue("Tanggal", StockPacking.TglTransaksi)
            FormatBt.SetNamedSubStringValue("KodeProduksi", StockPacking.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeItem", SwapUkuranKarung(StockPacking.NamaItem))
            FormatBt.SetNamedSubStringValue("Pcs", StockPacking.Pcs)
            FormatBt.SetNamedSubStringValue("Berat", KodeBall & " " & If(StockPacking.StatusQc < 3, "", If(StockPacking.StatusQc = 3, " /O", If(StockPacking.StatusQc = 4, " /U", ""))))
            FormatBt.SetNamedSubStringValue("Status", "")

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If
    End Sub

    Private Function SwapUkuranKarung(Data As String) As String
        Data = Data.Trim.ToUpper()
        Dim nPos As Integer = VB.InStr(Data, "X")
        Dim nPosLeft As Integer = 0
        Dim nPosRight As Integer = 0
        Dim LeftData As String = ""
        Dim RightData As String = ""

        If nPos <> 0 Then
            LeftData = VB.Mid(Data, nPos - 5, 5)
            nPosLeft = VB.InStr(LeftData, " ")
            LeftData = VB.Right(LeftData, VB.Len(LeftData) - nPosLeft)

            RightData = VB.Mid(Data, nPos + 1, 5)
            Me.Text = RightData


            nPosRight = VB.InStr(RightData, " ")
            RightData = VB.Left(RightData, VB.Len(nPosRight) - 1)

            LeftData = LeftData.Trim()
            RightData = RightData.Trim()

            Dim TempOriginal As String = LeftData & "X" & RightData
            Dim TempReplace As String = RightData & LeftData

            SwapUkuranKarung = VB.Replace(Data, TempOriginal, TempReplace)
        Else
            SwapUkuranKarung = Data
        End If

    End Function


#End Region

    Private Function CekWO(NomorWO As String) As Boolean
        Dim SAPWorkOrder As New SAPWorkOrder
        QtyPlan = SAPWorkOrder.FindFGByWO(KodeUnitSAP, NomorWO).QtyBOM
        QtyHasil = New DaftarProduksiPackingPcs(ActiveSession).FindQtyHasil(NomorWO).FGPcs + txtHasilPcs.Value

        CekWO = If(QtyPlan < QtyHasil, True, False)
    End Function

    Private Sub txtNIKOperator_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtNIKOperator.Validating
        If txtNIKOperator.Text <> "" Then
            Dim DaftarKaryawan As New DaftarKaryawan(ActiveSession)
            Dim Karyawan As Karyawan = DaftarKaryawan.Find(txtNIKOperator.Text.Trim, lblUnitProduksi.Tag)
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
End Class