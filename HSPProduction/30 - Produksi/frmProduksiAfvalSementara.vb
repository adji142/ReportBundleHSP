Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions
Imports System.Drawing.Printing

Public Class frmProduksiAfvalSementara

#Region "Declaration Variable"
    Private BeratBrutto, BeratMedia, BeratNetto As Double
    Private PrefikKodeProduksi As String
    Private DataScale As String

    Private KodeUnitSAP As String
    Private KodeItemSAP As String
    Private NamaItemSAP As String

    Private TglTransaksi As Date
    Private TglPencatatan As Date

#End Region

#Region "Controller"

    Private Sub frmAfvalProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()
        ScaleConnection()
    End Sub

    Private Sub ResetData()
        FillComboGrup()
        FillComboUnitProduksi()
        FillComboItemAfval()
        FillComboMediaTimbang()
        FillNomorSPK()

        'Layar Timbang
        '---------------------------------------------------------------------------------------------------
        lblKodeShift.Text = ""
        lblNamaShift.Text = ""
        lblTglTransaksi.Text = ""
        lblNamaGrup.Text = ""

        lblUnitProduksi.Text = ""
        lblTglTimbang.Text = ""
        lblJamTimbang.Text = ""
        lblItemProduksi.Text = ""

        'Data Timbang
        '---------------------------------------------------------------------------------------------------
        BeratBrutto = 0
        BeratMedia = 0
        BeratNetto = 0

        KodeUnitSAP = ""
        KodeItemSAP = ""
        NamaItemSAP = ""

        cboKodeItem.SelectedIndex = cboKodeItem.Items.Count - 1
        cboKodeMedia.SelectedIndex = cboKodeItem.Items.Count - 1
        txtBeratMedia.Text = 0
        txtKeterangan.Text = ""

        cboKodeMesin.Enabled = False
        btLookupKodeMesin.Enabled = False
        lblKodeMesin.Enabled = False

        lblNomorSPK.Enabled = False
        cboNomorSPK.Enabled = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1
        btLookupNomorSPK.Enabled = False
        cboTanggal.SelectedIndex = 0

        'Default
        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblLokasiAfvalProduksi.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
        lblLokasiAfvalProduksi.Tag = "901"
        If lblLokasiAfvalProduksi.Tag <> "" Then
            Try
                lblLokasiAfvalProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblLokasiAfvalProduksi.Tag).NamaLokasi.ToUpper()
            Catch ex As Exception
                lblLokasiAfvalProduksi.Tag = ""
                lblLokasiAfvalProduksi.Text = "Lokasi Belum Disetting"
            End Try
        Else
            lblLokasiAfvalProduksi.Text = "Lokasi Belum Disetting"
        End If
        '-------------------------------------------------------------------------------------------------------------------


        SetEnableCommand()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) 'Handles tmrJam.Tick
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

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            cboKodeShift.SelectedIndexChanged,
                            cboKodeGrup.SelectedIndexChanged,
                            cboTanggal.SelectedIndexChanged,
                            chkShiftSebelumnya.CheckedChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            cboKodeMesin.SelectedIndexChanged,
                            cboKodeItem.SelectedIndexChanged,
                            cboKodeMedia.SelectedIndexChanged,
                            cboNomorSPK.SelectedIndexChanged,
                            txtKeterangan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        lblItemProduksi.Text = cboKodeItem.Text

        If ObjectName = "cboKodeShift" Then
            lblKodeShift.Text = If(cboKodeShift.SelectedIndex = -1, "", cboKodeShift.SelectedValue.ToString)
        End If

        If ObjectName = "cboKodeGrup" Then
            lblNamaGrup.Text = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, "", cboKodeGrup.Text)
        End If

        If ObjectName = "cboTanggal" Then
            lblTglTransaksi.Text = DateAdd("D", CDbl(cboTanggal.Text), Now.Date).ToString("dd-MM-yyyy")
            TglTransaksi = DateAdd("D", CDbl(cboTanggal.Text), Now.Date)
        End If

        If ObjectName = "cboKodeUnit" Then
            FillComboMesin()
            FillComboItemAfval()
            FillComboMediaTimbang()
            FillNomorSPK()

            lblUnitProduksi.Text = cboKodeUnit.Text
            Dim UnitProduksi As UnitProduksi
            Try
                UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue)
                KodeUnitSAP = UnitProduksi.KodeUnitSAP

                If UnitProduksi.FlagAfval = 0 Then
                    cboKodeMesin.Enabled = False
                    btLookupKodeMesin.Enabled = False
                    lblKodeMesin.Enabled = False
                    cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
                Else
                    If cboKodeUnit.SelectedValue = "001" Then
                        cboKodeMesin.Enabled = False
                        btLookupKodeMesin.Enabled = False
                        lblKodeMesin.Enabled = False
                    Else
                        cboKodeMesin.Enabled = True
                        btLookupKodeMesin.Enabled = True
                        lblKodeMesin.Enabled = True
                    End If
                End If

                If UnitProduksi.FlagAfvalWO = 0 Then
                    lblNomorSPK.Enabled = False
                    cboNomorSPK.Enabled = False
                    cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1
                    btLookupNomorSPK.Enabled = False
                Else
                    lblNomorSPK.Enabled = True
                    cboNomorSPK.Enabled = True
                    btLookupNomorSPK.Enabled = True
                End If

            Catch ex As Exception
                KodeUnitSAP = ""
            End Try
        End If

        If ObjectName = "cboKodeMedia" Then
            Dim MediaTimbang = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia.SelectedValue)
            If IsNothing(MediaTimbang) Then
                BeratMedia = 0
            Else
                BeratMedia = MediaTimbang.Berat
            End If
        End If

        If ObjectName = "cboNomorSPK" Then
            If cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1 Then
                Dim KodeMesin As String = New SAPWorkOrder().FindMesin(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, cboNomorSPK.SelectedValue).KodeMesin
                cboKodeMesin.SelectedValue = New DaftarMesin(ActiveSession).FindBySAP(KodeMesin).KodeMesin
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmAfvalProduksi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ScalePort.Close()
    End Sub

    Private Sub btLookupKodeMesin_Click(sender As Object, e As EventArgs) Handles btLookupKodeMesin.Click
        Dim DaftarMesin As IDataLookup = New DaftarMesin(ActiveSession)
        Dim Parameter() As String = {cboKodeUnit.SelectedValue}

        Dim Form As New frmLookup(DaftarMesin, Parameter)
        Form.Text = "Lookup Daftar Mesin Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMesin.SelectedValue = Form.IDLookup
            cboKodeMesin.Focus()
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

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnit.Click
        Dim DaftarUnitProduksi As IDataLookup = New DaftarUnitProduksiAfval(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarUnitProduksi, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeUnit.SelectedValue = Form.IDLookup
            cboKodeUnit.Focus()
        End If
    End Sub

    Private Sub btLookupMedia_Click(sender As Object, e As EventArgs) Handles btLookupKodeMedia.Click
        Dim MediaTimbang As IDataLookup = New DaftarMediaTimbang(ActiveSession)
        Dim Parameter() As String = {lblLokasiAfvalProduksi.Tag}

        Dim Form As New frmLookup(MediaTimbang, Parameter)
        Form.Text = "Lookup Daftar Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMedia.SelectedValue = Form.IDLookup
            cboKodeMedia.Focus()
        End If
    End Sub
#End Region

#Region "FillCombo"
    Private Sub FillComboGrup()
        Dim DS As DataSet
        Dim DaftarShift As New DaftarShiftProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarShift.Read("%")
        cboKodeShift.DataSource = DS.Tables("View")
        cboKodeShift.DisplayMember = "Nama Shift"
        cboKodeShift.ValueMember = "Kode"
        cboKodeShift.SelectedIndex = -1

        Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)
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

    Private Sub FillComboUnitProduksi()
        Dim DaftarUnitProduksi As New DaftarUnitProduksiAfval(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit"
        cboKodeUnit.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit") = "-"

        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
    End Sub

    Private Sub FillComboMesin()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            Dim DaftarMesin As New DaftarMesin(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMesin.Read("%", cboKodeUnit.SelectedValue.ToString)
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

    Private Sub FillComboItemAfval()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            Dim DaftarItem As New DaftarItem(ActiveSession)
            Dim DS As DataSet

            Dim KodeUnit As String
            Try
                KodeUnit = cboKodeUnit.SelectedValue
            Catch ex As Exception
                KodeUnit = "!"
            End Try

            DS = New DataSet
            DS = DaftarItem.Read("%", "600", KodeUnit)
            cboKodeItem.DataSource = DS.Tables("View")
            cboKodeItem.DisplayMember = "Nama Item"
            cboKodeItem.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Item") = "-"

            cboKodeItem.SelectedIndex = cboKodeItem.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Item")

            cboKodeItem.DataSource = DS.Tables("View")
            cboKodeItem.DisplayMember = "Nama Item"
            cboKodeItem.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Item") = "-"

            cboKodeItem.SelectedIndex = cboKodeItem.Items.Count - 1
        End If
    End Sub

    Private Sub FillComboMediaTimbang()
        If lblLokasiAfvalProduksi.Tag <> "" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", lblLokasiAfvalProduksi.Tag)
            cboKodeMedia.DataSource = DS.Tables("View")
            cboKodeMedia.DisplayMember = "Nama Media"
            cboKodeMedia.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Media")

            cboKodeMedia.DataSource = DS.Tables("View")
            cboKodeMedia.DisplayMember = "Nama Media"
            cboKodeMedia.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1
        End If
    End Sub

    Private Sub FillNomorSPK()
        Try
            If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
                Dim SAPWorkOrder As New SAPWorkOrder
                Dim DS As DataSet

                DS = New DataSet
                DS = SAPWorkOrder.ReadFGWorkOrderByUnit(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, TglPencatatan)
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

#End Region

#Region "Scale Comunication"

    Private Sub ScaleConnection()
        Dim PortName As String
        Dim BaudRate As String

        Try
            PortName = GetSetting(enumFormID.frmGudang, enumSetting.settingPort)
            BaudRate = GetSetting(enumFormID.frmGudang, enumSetting.settingBaudRate)

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

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Penerimaan Afval Produksi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
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


                    Dim DaftarProduksiAfval As New DaftarAfvalProduksi(ActiveSession)
                    Dim ProduksiAfval As New ProduksiAfval

                    Dim NoTransaksi As String = DaftarProduksiAfval.GetNomorTransaksi(Periode)
                    With ProduksiAfval
                        .NoTransaksi = NoTransaksi
                        .TglTransaksi = TglTransaksi
                        .TglPencatatan = TglPencatatan
                        .NomorWO = cboNomorSPK.SelectedValue
                        .KodeUnit = cboKodeUnit.SelectedValue
                        .KodeShift = lblKodeShift.Text
                        .KodeGrup = cboKodeGrup.SelectedValue
                        .KodeMesin = cboKodeMesin.SelectedValue
                        .KodeItemAfval = cboKodeItem.SelectedValue
                        .NamaItemAfval = cboKodeItem.Text
                        .KodeMedia = cboKodeMedia.SelectedValue
                        .BeratBrutto = BeratBrutto
                        .BeratMedia = BeratMedia
                        .BeratNetto = BeratNetto
                        .Keterangan = txtKeterangan.Text
                        .ShiftSebelumnya = chkShiftSebelumnya.Checked
                        .UserID = ActiveSession.KodeUser
                        .KodeLokasi = lblLokasiAfvalProduksi.Tag
                        .KodeUnitSAP = KodeUnitSAP
                        .KodeItemSAP = KodeItemSAP
                        .NamaItemSAP = NamaItemSAP
                    End With
                    DaftarProduksiAfval.Add(ProduksiAfval)

                    'Simpan Ke Staging Database
                    Dim STG As New SAPStaging
                    KodeItemSAP = New DaftarItem(ActiveSession).Find(cboKodeItem.SelectedValue).KodeItemSistem
                    NamaItemSAP = ""

                    'Posting Ke Staging
                    STG.PostAfvalReceiptWWO(KodeUnitSAP, TglTransaksi, KodeItemSAP, NamaItemSAP, lblLokasiAfvalProduksi.Tag, BeratNetto, NoTransaksi)

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        STG.Execute(NoTransaksi, SAPStaging.enumTransaction.AfvalReceiptWWO)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        STG.RemoveStagingData(NoTransaksi)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************

                    'Cetak Transaksi
                    '------------------------------------------------------------------------------------------------------
                    CetakStruk(NoTransaksi)

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
                CetakStruk(New DaftarAfvalProduksi(ActiveSession).FindLastID().NoTransaksi, True)
            Case "btClose"
                Me.Close()

        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, Not cboKodeMesin.Enabled, True) And _
                         If(cboKodeItem.SelectedIndex = cboKodeItem.Items.Count - 1, False, True) And _
                         If(lblLokasiAfvalProduksi.Tag = "", False, True) And _
                         If(BeratNetto <= 0, False, True) And _
                         If(cboNomorSPK.Enabled, cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1, True)

        BeratNetto = BeratBrutto - BeratMedia
        lblBeratNetto.Text = BeratNetto.ToString("###,##0.00") & " KG"

        txtBeratBrutto.Text = BeratBrutto.ToString("###,##0.00") & " KG"
        txtBeratMedia.Text = BeratMedia.ToString("###,##0.00") & " KG"
        txtBeratNetto.Text = BeratNetto.ToString("###,##0.00") & " KG"

    End Sub
#End Region

#Region "Print Transaksi"

    Private Sub CetakStruk(ByVal NoTransaksi As String, Optional Reprint As Boolean = False)
        Dim DaftarProduksiAfval As New DaftarAfvalProduksi(ActiveSession)
        Dim ProduksiAfval As ProduksiAfval

        ProduksiAfval = DaftarProduksiAfval.Find(NoTransaksi)
        If Not IsNothing(ProduksiAfval) Then
            Dim DataPrint As String
            Const BarisBaru As String = ControlChars.CrLf
            Dim PrintDialog As New PrintDialog
            Dim SettingPrint As New System.Drawing.Printing.PrinterSettings

            DataPrint = "========================================" & BarisBaru
            If Reprint = True Then
                DataPrint &= "              CETAK ULANG              " & BarisBaru
            End If
            DataPrint &= "******** BUKTI PENERIMAAN AFVAL ********" & BarisBaru
            DataPrint &= "----------------------------------------" & BarisBaru
            DataPrint &= "NOMOR             : " & ProduksiAfval.NoTransaksi & BarisBaru
            DataPrint &= "TGL. TIMBANG      : " & Format(ProduksiAfval.TglPencatatan, "dd-MM-yy HH:mm:ss") & BarisBaru
            DataPrint &= "TGL. PRODUKSI     : " & Format(ProduksiAfval.TglTransaksi, "dd-MM-yy") & BarisBaru
            DataPrint &= "SHIFT             : " & ProduksiAfval.KodeShift & BarisBaru
            DataPrint &= "GRUP              : " & ProduksiAfval.KodeGrup & BarisBaru
            DataPrint &= "NO. MESIN         : " & If(ProduksiAfval.KodeMesin = "", "-", New DaftarMesin(ActiveSession).Find(ProduksiAfval.KodeMesin).NamaMesin) & BarisBaru
            DataPrint &= "ITEM AFVAL        : " & ProduksiAfval.NamaItemAfval & BarisBaru
            DataPrint &= "----------------------------------------" & BarisBaru
            DataPrint &= "BERAT BRUTTO      : " & Format(ProduksiAfval.BeratBrutto, "##,##0.00") & " KG" & BarisBaru
            DataPrint &= "BERAT NETTO       : " & Format(ProduksiAfval.BeratNetto, "##,##0.00") & " KG" & BarisBaru
            DataPrint &= "----------------------------------------" & BarisBaru
            DataPrint &= "OPEARTOR TIMBANG  : " & ProduksiAfval.UserID & BarisBaru
            If ProduksiAfval.ShiftSebelumnya = 1 Then
                DataPrint &= "CATATAN       : AFVAL SHIFT SEBELUMNYA"
            End If
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru

            PrintDialog.PrinterSettings = New PrinterSettings
            PrinterSet.SendStringToPrinter(SettingPrint.PrinterName, DataPrint)
        End If
    End Sub

    'Private Sub CetakTransaksi(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
    '    Dim DaftarAfvalProduksi As New DaftarAfvalProduksi(ActiveSession)
    '    Dim DaftarItemAfval As New DaftarItem(ActiveSession)

    '    Dim AfvalProduksi = DaftarItemAfval.Find(NoTransaksi)
    '    Dim ItemAfval = DaftarItemAfval.Find(AfvalProduksi.KodeItem)


    '    '--------------------------------------------------------------------------------------------------------
    '    'Cetak Struk
    '    '--------------------------------------------------------------------------------------------------------
    '    Dim PrintBuffer As String = ""

    '    'oData.GetLastData oConnection.Server

    '    'oShift.Fields.KodeShift = oData.Fields.KodeShift
    '    'oShift.Find oConnection.Server

    '    'oGrup.Fields.KodeGrup = oData.Fields.KodeGrup
    '    'oGrup.Find oConnection.Server

    '    'oUnit.Fields.KodeKelompok = oData.Fields.KodeKelompok
    '    'oUnit.Find oConnection.Server

    '    'oMesin.Fields.KodeMesin = oData.Fields.KodeMesin
    '    'oMesin.Find oConnection.Server

    '    'oItem.Fields.KodeItem = oData.Fields.KodeItem
    '    'oItem.Find oConnection.Server

    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "===================================" + vbCrLf
    '    'If CetakUlang Then
    '    '    PrintBuffer = PrintBuffer + "           CETAK ULANG             " + vbCrLf
    '    'End If
    '    'PrintBuffer = PrintBuffer + "****** BUKTI PENERIMAAN AVAL ******" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "-----------------------------------" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NOMOR         : " + Trim(Str(oData.Fields.RowID)) + vbCrLf
    '    'PrintBuffer = PrintBuffer + "TGL. TIMBANG  : " + Format(oData.Fields.TglPencatatan, "DD-MM-YY hh:mm:ss") + vbCrLf
    '    'PrintBuffer = PrintBuffer + "TGL. PRODUKSI : " + Format(oData.Fields.TglTransaksi, "DD-MM-YY") + vbCrLf
    '    'PrintBuffer = PrintBuffer + "SHIFT         : " + oShift.Fields.NamaShift + vbCrLf
    '    'PrintBuffer = PrintBuffer + "GRUP          : " + oGrup.Fields.NamaGrup + vbCrLf
    '    'PrintBuffer = PrintBuffer + "UNIT          : " + oUnit.Fields.NamaKelompok + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NO.MESIN      : " + IIf(oData.Fields.KodeMesin = "", "-", oMesin.Fields.NamaMesin) + vbCrLf
    '    'PrintBuffer = PrintBuffer + "ITEM          : " + oItem.Fields.NamaItem + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NIK           : " + oData.Fields.NoKaryawan + vbCrLf
    '    'PrintBuffer = PrintBuffer + "-----------------------------------" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "BRUTTO        : " + Format(oData.Fields.Timbang, "#,##0.00") + " KG" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NETTO         : " + Format(oData.Fields.Timbang - oData.Fields.BeratMedia, "#,##0.00") + " KG" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "-----------------------------------" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "OPERATOR TIMBANG" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + UCase(oData.Fields.UserID) + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'If oData.Fields.PrevShift = 1 Then
    '    '    PrintBuffer = PrintBuffer + ">> CATATAN : Afval Shift Sebelumnya" + vbCrLf
    '    'Else
    '    '    PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'End If

    '    'Dim FF As Integer
    '    'Dim SP As Integer

    '    'If CetakUlang Then
    '    '    SP = 8
    '    'Else
    '    '    SP = 9
    '    'End If

    '    'For FF = 1 To SP
    '    '    PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'Next

    '    '--------------------------------------------------------------------------------------------------------
    '    'Cetak Ke Printer
    '    '--------------------------------------------------------------------------------------------------------
    '    'Dim PrinterConnection As Integer
    '    'Dim PortPrinter As String
    '    'Dim DeviceName As String

    '    'PrinterConnection = cboPrinterConnection.ListIndex + 1
    '    'PortPrinter = cboPortPrinter.Text

    '    'DeviceName = ""
    '    'Select Case PrinterConnection
    '    '    Case 1 ' Pararel
    '    '        DeviceName = "LPT" + Trim(PortPrinter)
    '    '        LPTDirectPrint(DeviceName, PrintBuffer)
    '    '    Case 2 ' Serial
    '    '        DeviceName = "COM" + Trim(PortPrinter)
    '    '        COMDirectPrint(DeviceName, PrintBuffer)
    '    '    Case 3 ' USB
    '    '        DeviceName = cboDeviceName.Text
    '    '        USBDirectPrint(DeviceName, PrintBuffer, "")
    '    'End Select

    'End Sub

#End Region


    Private Sub btLookupNomorSPK_Click(sender As Object, e As EventArgs) Handles btLookupNomorSPK.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, TglPencatatan}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSPK.SelectedValue = Form.IDLookup
            cboNomorSPK.Focus()
        End If
    End Sub

End Class