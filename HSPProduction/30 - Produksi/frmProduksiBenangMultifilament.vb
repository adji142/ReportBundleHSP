Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmProduksiBenangMultifilament

#Region "Declaration Variable"
    Private BeratBrutto, BeratMedia, BeratNetto As Double
    Private PrefikKodeProduksi As String
    Private DataScale As String

    Private NomorTimbang As String
    Private KodeProduksi As String

    Private TglTransaksi As DateTime

#End Region

#Region "Controller"
    Private Sub ResetData()
        'Layar Timbang
        '---------------------------------------------------------------------------------------------------
        lblKodeShift.Text = ""
        lblNamaShift.Text = ""
        lblTglTransaksi.Text = ""
        lblNamaGrup.Text = ""

        lblUnitProduksi.Text = "BELUM SETTING"
        lblTglTimbang.Text = ""
        lblJamTimbang.Text = ""
        lblLokasiProduksi.Text = ""
        lblAreaProduksi.Text = ""
        lblItemProduksi.Text = ""

        'Data Timbang
        '---------------------------------------------------------------------------------------------------
        BeratBrutto = 0
        BeratMedia = 0
        BeratNetto = 0

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
        cboStatusQc.SelectedIndex = cboStatusQc.Items.Count - 1
        cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1

        txtBeratMedia.Text = ""
        txtKeterangan.Text = ""

        'Default Unit Produksi
        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblUnitProduksi.Tag = GetSetting(enumFormID.frmBenangMultifilament, enumSetting.settingKodeUnit)
        If lblUnitProduksi.Tag <> "" Then
            Try
                lblUnitProduksi.Text = New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).NamaUnit.ToUpper()
            Catch ex As Exception
                lblUnitProduksi.Tag = ""
                lblUnitProduksi.Text = "Unit Produksi Belum Disetting"
            End Try
        Else
            lblUnitProduksi.Text = "Unit Produksi Belum Disetting"
        End If
        '-------------------------------------------------------------------------------------------------------------------

        'Default Lokasi Produksi
        '-------------------------------------------------------------------------------------------------------------------
        lblLokasiProduksi.Tag = GetSetting(enumFormID.frmBenangMultifilament, enumSetting.settingKodeLokasi)
        If lblLokasiProduksi.Tag <> "" Then
            Try
                lblLokasiProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblLokasiProduksi.Tag).NamaLokasi.ToUpper()
            Catch ex As Exception
                lblLokasiProduksi.Tag = ""
                lblLokasiProduksi.Text = "Lokasi Belum Disetting"
            End Try
        Else
            lblLokasiProduksi.Text = "Lokasi Belum Disetting"
        End If
        '-------------------------------------------------------------------------------------------------------------------

        txtTimbangManual.Value = 0
        txtTimbangManual.Enabled = False
        lblTimbangManual.Enabled = False
        lblStabil.Visible = False

        SetEnableCommand()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Transaksi
        '---------------------------------------------------------------------------------------------------
        If lblTransaksi.ForeColor = Color.Yellow Then
            lblTransaksi.ForeColor = Color.Blue
        Else
            lblTransaksi.ForeColor = Color.Yellow
        End If

        'Tanggal & Jam Timbang
        '---------------------------------------------------------------------------------------------------
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

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            cboKodeGrup.SelectedIndexChanged,
                            chkShiftSebelumnya.CheckedChanged,
                            cboKodeMesin.SelectedIndexChanged,
                            cboNomorSpk.SelectedIndexChanged,
                            cboStatusQc.SelectedIndexChanged,
                            cboKodeMediaTimbang.SelectedIndexChanged,
                            txtJumlahCones.TextChanged,
                            txtKeterangan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeGrup" Then
            lblNamaGrup.Text = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, "", cboKodeGrup.Text)
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboNomorSpk" Then
            If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
                Try

                    lblItemProduksi.Text = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).NamaItem
                    lblItemProduksi.Tag = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue).KodeItem

                    CekPemakaianBahan(ActiveSession.KodeUser + Now.ToString("yyyyMMddHHmmss") + lblUnitProduksi.Tag)
                Catch
                End Try
            Else
                lblItemProduksi.Text = ""
                lblItemProduksi.Tag = ""

            End If
        End If

        '-------------------------------------------------------------------------------------------------------

        SetEnableCommand()
    End Sub

    Private Sub frmPenerimaanBenang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ScalePort.Close()
    End Sub

    Private Sub frmPenerimaanBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        ResetData()

        FillComboGrup()
        FillComboMesin()
        FillNomorSPK()
        FillComboMediaTimbang()

        ScaleConnection()
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
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, Now}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSpk.SelectedValue = Form.IDLookup
            cboNomorSpk.Focus()
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

    Private Sub btLookupKodePolaMediaTimbang_Click(sender As Object, e As EventArgs) Handles btLookupKodePolaMediaTimbang.Click
        Dim DaftarPola As IDataLookup = New DaftarPolaMediaTimbang(ActiveSession)
        Dim Parameter() As String = {lblLokasiProduksi.Tag}

        Dim Form As New frmLookup(DaftarPola, Parameter)
        Form.Text = "Lookup Daftar Pola Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMediaTimbang.SelectedValue = Form.IDLookup
            cboKodeMediaTimbang.Focus()
        End If
    End Sub
#End Region

#Region "FillCombo"
    Private Sub FillComboGrup()
        Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

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
        If lblUnitProduksi.Tag <> "" Then
            Dim DaftarMesin As New DaftarMesin(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMesin.Read("%", lblUnitProduksi.Tag)
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
        If lblUnitProduksi.Tag <> "" Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            Dim KodeUnitSAP As String = New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).KodeUnitSAP
            DS = SAPWorkOrder.ReadFGWorkOrderByUnit(KodeUnitSAP, TglTransaksi)
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
    End Sub

    Private Sub FillComboMediaTimbang()
        If lblUnitProduksi.Tag <> "" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim DS As DataSet
            Dim Drow As DataRow

            'Media Timbang 1
            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", lblLokasiProduksi.Tag)
            cboKodeMediaTimbang.DataSource = DS.Tables("View")
            cboKodeMediaTimbang.DisplayMember = "Nama Media"
            cboKodeMediaTimbang.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Nomor")

            cboNomorSpk.DataSource = DS.Tables("View")
            cboNomorSpk.DisplayMember = "Nama Media"
            cboNomorSpk.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Kode") = "-"
        End If

        cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1

    End Sub


#End Region

#Region "Scale Comunication"

    Private Sub ScaleConnection()
        Dim PortName As String
        Dim BaudRate As String

        Try
            PortName = GetSetting(enumFormID.frmBenangMultifilament, enumSetting.settingPort)
            BaudRate = GetSetting(enumFormID.frmBenangMultifilament, enumSetting.settingBaudRate)

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
            MessageBox.Show("Koneksi Timbangan Benang Multifilament Gagal...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DataStreaming(sender As Object, e As SerialDataReceivedEventArgs) Handles ScalePort.DataReceived
        Dim TempScale As String = ""
        While Microsoft.VisualBasic.InStr(TempScale, Chr(3)) = 0 And ScalePort.IsOpen
            Try
                TempScale += Microsoft.VisualBasic.Chr(ScalePort.ReadChar)
            Catch
            End Try

        End While
        DataScale = TempScale
    End Sub

    Private Sub tmrScale_Tick(sender As Object, e As EventArgs) Handles tmrScale.Tick
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
#End Region

#Region "Save To Database"

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btReprint.Click
        Dim Periode As String
        Dim PeriodeTransaksi As String
        Dim RegKey As RegistryKey

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    If New DaftarPemakaianBahan(ActiveSession).IsEmpty(cboNomorSpk.SelectedValue) Then
                        MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSpk.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GoTo Jump
                    Else
                        If Not New DaftarPemakaianBahan(ActiveSession).IsPemakaianBahan(cboNomorSpk.SelectedValue) Then
                            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSpk.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo Jump
                        End If
                    End If

                    Dim DaftarProduksiBenang As New DaftarStockBenangMultifilament(ActiveSession)
                    Dim ProduksiBenang As New StockBenangMultifilament

                    Periode = GetPeriod(Now)
                    PeriodeTransaksi = GetPeriodFull(Now)

                    PrefikKodeProduksi = New DaftarLokasi(ActiveSession).Find(lblLokasiProduksi.Tag).PrefikKodeTransaksi

                    'GetNomorTransaksisIn(Nomor Timbang)
                    '--------------------------------------------------------------------------------------------------
                    NomorTimbang = DaftarProduksiBenang.GetNomorTransaksiIn("BMHP", Periode)

                    'Simpan Data Penerimaan Benang Internal
                    '------------------------------------------------------------------------------------------------------
                    'GetKodeProduksi(Kode Produksi/Barcode)
                    '--------------------------------------------------------------------------------------------------
                    KodeProduksi = DaftarProduksiBenang.GetKodeProduksi(lblUnitProduksi.Tag, cboKodeMesin.SelectedValue, PeriodeTransaksi)
                    ProduksiBenang.KodeProduksi = KodeProduksi
                    ProduksiBenang.KodeProduksiLama = ""
                    ProduksiBenang.StatusProduksi = 1 'Hasil Produksi
                    ProduksiBenang.NomorWO = cboNomorSpk.SelectedValue
                    ProduksiBenang.KodeItem = lblItemProduksi.Tag
                    ProduksiBenang.NamaItem = lblItemProduksi.Text
                    ProduksiBenang.KodeStatusQC = cboStatusQc.SelectedIndex + 1
                    ProduksiBenang.NamaStatusQC = cboStatusQc.SelectedItem
                    ProduksiBenang.KodeDisposisi = 0
                    ProduksiBenang.NamaDisposisi = ""
                    ProduksiBenang.BeratBrutto = BeratBrutto
                    ProduksiBenang.KodePola = ""
                    ProduksiBenang.KodeMedia1 = cboKodeMediaTimbang.SelectedValue
                    ProduksiBenang.BeratMedia1 = txtBeratMedia.Value
                    ProduksiBenang.JumlahMedia1 = 1
                    ProduksiBenang.KodeMedia2 = ""
                    ProduksiBenang.BeratMedia2 = 0
                    ProduksiBenang.JumlahMedia2 = 0
                    ProduksiBenang.KodeMedia3 = ""
                    ProduksiBenang.BeratMedia3 = 0
                    ProduksiBenang.JumlahMedia3 = 0
                    ProduksiBenang.BeratNetto = BeratNetto
                    ProduksiBenang.Satuan1 = "DUS"
                    ProduksiBenang.Satuan2 = "CONES"
                    ProduksiBenang.Satuan3 = "KG"
                    ProduksiBenang.Jumlah1 = 1
                    ProduksiBenang.Jumlah2 = txtJumlahCones.Value
                    ProduksiBenang.Jumlah3 = BeratNetto
                    ProduksiBenang.KodeLokasi = lblLokasiProduksi.Tag
                    ProduksiBenang.KodeArea = ""
                    ProduksiBenang.Keterangan = txtKeterangan.Text
                    ProduksiBenang.InputData = 0
                    ProduksiBenang.M_NoTimbang = NomorTimbang
                    ProduksiBenang.M_TglTransaksi = TglTransaksi
                    ProduksiBenang.M_TglTimbang = Now
                    ProduksiBenang.M_KodeShift = lblKodeShift.Text
                    ProduksiBenang.M_KodeGrup = cboKodeGrup.SelectedValue
                    ProduksiBenang.M_PrevShift = If(chkShiftSebelumnya.Checked, 1, 0)
                    ProduksiBenang.M_KodeUnit = lblUnitProduksi.Tag
                    ProduksiBenang.M_KodeMesin = cboKodeMesin.SelectedValue
                    ProduksiBenang.M_UserID = ActiveSession.KodeUser

                    DaftarProduksiBenang.Add(ProduksiBenang)

                    'Simpan Data Penerimaan Benang Staging
                    '------------------------------------------------------------------------------------------------------
                    Dim SAPStaging As New SAPStaging
                    SAPStaging.PostFinishedGoodReceipt(New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).KodeUnitSAP, cboNomorSpk.SelectedValue, Stod(lblTglTransaksi.Text), lblItemProduksi.Tag, BeratNetto, BeratNetto, KodeProduksi, "", NomorTimbang, lblLokasiProduksi.Tag)

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        SAPStaging.Execute(NomorTimbang, HSPProduction.SAPStaging.enumTransaction.FinishedGoodReceipt)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        SAPStaging.RemoveStagingData(NomorTimbang)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************

                    'Cetak Barcode
                    '------------------------------------------------------------------------------------------------------
                    MessageBox.Show("Siapkan Label Untuk Mencetak Barcode Produksi ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PrintBarcode(NomorTimbang)

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
                '---------------------------------------------------------------------------------------------------------
                PrintBarcode(New DaftarStockBenangMultifilament(ActiveSession).FindLastID().M_NoTimbang, True)
                '---------------------------------------------------------------------------------------------------------
            Case "btClose"
                Me.Close()

        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboStatusQc.SelectedIndex = cboStatusQc.Items.Count - 1, False, True) And _
                         If(cboKodeMediaTimbang.SelectedIndex = cboKodeMediaTimbang.Items.Count - 1, False, True) And _
                         If(txtJumlahCones.Text = "", False, True) And _
                         If(BeratNetto <= 0, False, True)

        'BeratMedia = (txtTotalMedia1.Value * txtBeratMedia1.Value) + (txtTotalMedia2.Value * txtBeratMedia2.Value) + (txtTotalMedia3.Value * txtBeratMedia3.Value)

        txtBeratMedia.Text = BeratMedia.ToString("###,##0.00")

        BeratNetto = BeratBrutto - BeratMedia
        lblBeratNetto.Text = BeratNetto.ToString("###,##0.00")
        lblBeratNetto.Tag = BeratNetto
    End Sub
#End Region

#Region "Barcode Printing"

    Private Sub PrintBarcode(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarProduksiBenang As New DaftarStockBenangMultifilament(ActiveSession)
        Dim ProduksiBenang As StockBenangMultifilament = DaftarProduksiBenang.FindByNoTransaksi(NoTransaksi)
        Dim KodeBall As String = ""

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeBmf.btw", False, "")

        If Not IsNothing(ProduksiBenang) Then

            For i = 1 To ProduksiBenang.BeratNetto.ToString.Length
                KodeBall += GetFormat(Mid(ProduksiBenang.BeratNetto.ToString, i, 1))
            Next

            FormatBt.SetNamedSubStringValue("Tanggal", ProduksiBenang.M_TglTransaksi)
            FormatBt.SetNamedSubStringValue("KodeProduksi", ProduksiBenang.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeItem", ProduksiBenang.NamaItem)
            FormatBt.SetNamedSubStringValue("Pcs", ProduksiBenang.Jumlah2)
            FormatBt.SetNamedSubStringValue("Shift", ProduksiBenang.M_KodeShift)
            FormatBt.SetNamedSubStringValue("Berat", KodeBall)
            FormatBt.SetNamedSubStringValue("Status", "")

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

#End Region

#Region "Timbang Manual"
    Private Sub cboKodeMediaTimbang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboKodeMediaTimbang.SelectedValueChanged
        Try
            Dim Media = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMediaTimbang.SelectedValue)
            If IsNothing(Media) Then
                BeratMedia = 0
                txtBeratMedia.Text = 0 & " KG"
            Else
                BeratMedia = Media.Berat
                txtBeratMedia.Text = Media.Berat & " KG"
            End If
        Catch ex As Exception
            BeratMedia = 0
            txtBeratMedia.Text = 0 & " KG"
        End Try

        SetEnableCommand()
    End Sub

    Private Sub txtTimbangManual_TextChanged(sender As Object, e As EventArgs) Handles txtTimbangManual.TextChanged
        BeratBrutto = txtTimbangManual.Value
        lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
        lblBeratBrutto.Tag = BeratBrutto
        SetEnableCommand()
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
#End Region

    Private Sub CekPemakaianBahan(NoTransaksi As String)
        'Simpan Data Item Bahan dan Cek Pemakaian Bahan By WO
        Dim SAP As New SAPWorkOrder
        Dim DS As DataSet

        Dim X_DPB As New X_DaftarPemakaianBahan(ActiveSession)
        Dim X_PB As New X_PemakaianBahan

        DS = SAP.ReadRMByWONonBatch(cboNomorSpk.SelectedValue, New DaftarUnitProduksi(ActiveSession).Find(lblUnitProduksi.Tag).KodeUnitSAP)
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
    
End Class