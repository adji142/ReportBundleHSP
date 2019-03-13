Imports HSPProduction.HSP.Data
Imports System.IO.Ports
Imports System.Transactions

Public Class frmPenerimaanBenang
    Private BeratBrutto, BeratMedia, BeratNetto As Double
    Private DataScale, _NoTransaksi, KodeProduksi, KodeUnitSAP, KodeLokasi As String
    Private TglTransaksi As DateTime

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
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
        cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1
        cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
        cboKodePolaMedia.SelectedIndex = cboKodePolaMedia.Items.Count - 1
        cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1
        cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1
        cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1

        txtJumlahMedia1.Text = ""
        txtJumlahMedia2.Text = ""
        txtJumlahMedia3.Text = ""
        txtBeratMedia1.Text = ""
        txtBeratMedia2.Text = ""
        txtBeratMedia3.Text = ""
        txtTotalMedia1.Text = ""
        txtTotalMedia2.Text = ""
        txtTotalMedia3.Text = ""
        txtTotalMedia.Text = ""
        txtKeterangan.Text = ""

        chkTimbangManual.Checked = False
        txtTimbangManual.Text = ""

        'Default Unit Produksi
        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblUnitProduksi.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeUnit)
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
        lblLokasiProduksi.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
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

        SetEnableCommand()
    End Sub

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

    Private Sub FillComboUnit()
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%", "001")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"

        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
    End Sub

    Private Sub FillComboNomorSPK()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            DS = SAPWorkOrder.ReadFGWorkOrderByUnit(KodeUnitSAP, TglTransaksi)
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

        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1
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

    Private Sub FillComboArea()
        If lblLokasiProduksi.Tag <> "" Then
            Dim DaftarArea As New DaftarArea(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarArea.Read("%", lblLokasiProduksi.Tag)
            cboKodeArea.DataSource = DS.Tables("View")
            cboKodeArea.DisplayMember = "Nama Area"
            cboKodeArea.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Area") = "-"

            cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Area")

            cboKodeArea.DataSource = DS.Tables("View")
            cboKodeArea.DisplayMember = "Nama Area"
            cboKodeArea.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Area") = "-"

            cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1
        End If
    End Sub

    Private Sub FillComboPolaMedia()
        If lblLokasiProduksi.Tag <> "" Then
            Dim DaftarPolaMediaTimbang As New DaftarPolaMediaTimbang(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarPolaMediaTimbang.Read("%", lblLokasiProduksi.Tag)
            cboKodePolaMedia.DataSource = DS.Tables("View")
            cboKodePolaMedia.DisplayMember = "Nama Pola"
            cboKodePolaMedia.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Pola") = "-"

            cboKodePolaMedia.SelectedIndex = cboKodePolaMedia.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Pola")

            cboKodePolaMedia.DataSource = DS.Tables("View")
            cboKodePolaMedia.DisplayMember = "Nama Pola"
            cboKodePolaMedia.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Pola") = "-"

            cboKodePolaMedia.SelectedIndex = cboKodePolaMedia.Items.Count - 1
        End If
    End Sub

    Private Sub FillComboMediaTimbang()
        Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        'Media Timbang 1
        DS = New DataSet
        DS = DaftarMediaTimbang.Read("%", lblLokasiProduksi.Tag)
        cboKodeMedia1.DataSource = DS.Tables("View")
        cboKodeMedia1.DisplayMember = "Nama Media"
        cboKodeMedia1.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Media") = "-"

        cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1

        'Media Timbang 2
        DS = New DataSet
        DS = DaftarMediaTimbang.Read("%", lblLokasiProduksi.Tag)
        cboKodeMedia2.DataSource = DS.Tables("View")
        cboKodeMedia2.DisplayMember = "Nama Media"
        cboKodeMedia2.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Media") = "-"

        cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1

        'Media Timbang 3
        DS = New DataSet
        DS = DaftarMediaTimbang.Read("%", lblLokasiProduksi.Tag)
        cboKodeMedia3.DataSource = DS.Tables("View")
        cboKodeMedia3.DisplayMember = "Nama Media"
        cboKodeMedia3.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Media") = "-"

        cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1
    End Sub

    Private Sub frmPenerimaanBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboGrup()
        FillComboUnit()

        ResetData()

        ScaleConnection()
    End Sub

    Private Sub ScaleConnection()
        Dim PortName As String
        Dim BaudRate As String

        Try
            'Default Port Timbang
            '-------------------------------------------------------------------------------------------------------------------
            Dim Setting As New frmSetting
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
                tmrTimbangan.Enabled = True
            Else
                lblStatus.Text = "OFFLINE"
                lblStatus.ForeColor = Color.Red
                tmrTimbangan.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Timbangan Benang Gagal...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                                        cboKodeGrup.SelectedIndexChanged,
                                                                        chkShiftSebelumnya.CheckedChanged,
                                                                        cboKodeUnit.SelectedIndexChanged,
                                                                        cboNomorSPK.SelectedIndexChanged,
                                                                        cboKodeMesin.SelectedIndexChanged,
                                                                        cboKodeArea.SelectedIndexChanged,
                                                                        cboKodeStatus.SelectedIndexChanged,
                                                                        cboKodePolaMedia.SelectedIndexChanged,
                                                                        cboKodeMedia1.SelectedIndexChanged,
                                                                        cboKodeMedia2.SelectedIndexChanged,
                                                                        cboKodeMedia3.SelectedIndexChanged,
                                                                        txtTimbangManual.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeGrup" Then
            lblNamaGrup.Text = cboKodeGrup.Text
        End If

        If ObjectName = "cboKodeUnit" Then
            Try
                KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue.ToString).KodeUnitSAP
            Catch
            End Try

            FillComboNomorSPK()
            FillComboMesin()
            FillComboArea()
            FillComboPolaMedia()

        End If

        If ObjectName = "cboNomorSPK" Then
            Try
                lblItemProduksi.Text = New SAPWorkOrder().FindFGByWO(KodeUnitSAP, cboNomorSPK.SelectedValue).NamaItem
                lblItemProduksi.Tag = New SAPWorkOrder().FindFGByWO(KodeUnitSAP, cboNomorSPK.SelectedValue).KodeItem

                CekPemakaianBahan(ActiveSession.KodeUser + Now.ToString("yyyyMMddHHmmss") + cboKodeUnit.Tag)

                If cboKodeUnit.SelectedValue = "001" Then
                    Dim KodeMesin As String = New SAPWorkOrder().FindMesin(KodeUnitSAP, cboNomorSPK.SelectedValue).KodeMesin
                    cboKodeMesin.SelectedValue = New DaftarMesin(ActiveSession).FindBySAP(KodeMesin).KodeMesin
                End If
            Catch
                lblItemProduksi.Text = ""
                lblItemProduksi.Tag = ""
            End Try
        End If

        If ObjectName = "cboKodeArea" Then
            lblAreaProduksi.Text = cboKodeArea.Text
        End If

        If ObjectName = "cboKodePolaMedia" Then
            FillComboMediaTimbang()
            Try
                Dim DaftarPolaMediaTimbang As New DaftarPolaMediaTimbang(ActiveSession)
                Dim PolaMediaTimbang As PolaMediaTimbang = DaftarPolaMediaTimbang.Find(cboKodePolaMedia.SelectedValue)
                If Not IsNothing(PolaMediaTimbang) Then
                    cboKodeMedia1.SelectedValue = PolaMediaTimbang.KodeMedia1
                    cboKodeMedia2.SelectedValue = PolaMediaTimbang.KodeMedia2
                    cboKodeMedia3.SelectedValue = PolaMediaTimbang.KodeMedia3
                    txtJumlahMedia1.Value = PolaMediaTimbang.JumlahDefault1
                    txtJumlahMedia2.Value = PolaMediaTimbang.JumlahDefault2
                    txtJumlahMedia3.Value = PolaMediaTimbang.JumlahDefault3
                Else
                    cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1
                    cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1
                    cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1
                    txtJumlahMedia1.Value = 0
                    txtJumlahMedia2.Value = 0
                    txtJumlahMedia3.Value = 0
                End If
            Catch
            End Try
        End If

        If ObjectName = "cboKodeMedia1" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMedia1.SelectedValue.ToString)

            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia1.Value = MediaTimbang.Berat

                If MediaTimbang.JumlahMedia = 1 Then
                    txtJumlahMedia1.ReadOnly = False
                    txtJumlahMedia1.TabStop = True
                Else
                    txtJumlahMedia1.ReadOnly = True
                    txtJumlahMedia1.TabStop = False
                End If
            Else
                txtBeratMedia1.Value = 0
            End If
        End If

        If ObjectName = "cboKodeMedia2" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMedia2.SelectedValue.ToString)
            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia2.Value = MediaTimbang.Berat

                If MediaTimbang.JumlahMedia = 1 Then
                    txtJumlahMedia2.ReadOnly = False
                    txtJumlahMedia2.TabStop = True
                Else
                    txtJumlahMedia2.ReadOnly = True
                    txtJumlahMedia2.TabStop = False
                End If
            Else
                txtBeratMedia2.Value = 0
            End If
        End If

        If ObjectName = "cboKodeMedia3" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMedia3.SelectedValue.ToString)
            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia3.Value = MediaTimbang.Berat

                If MediaTimbang.JumlahMedia = 1 Then
                    txtJumlahMedia3.ReadOnly = False
                    txtJumlahMedia3.TabStop = True
                Else
                    txtJumlahMedia3.ReadOnly = True
                    txtJumlahMedia3.TabStop = False
                End If
            Else
                txtBeratMedia3.Value = 0
            End If
        End If

        If ObjectName = "txtTimbangManual" Then
            If chkTimbangManual.Checked = True Then
                BeratBrutto = txtTimbangManual.Value
                lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
                lblBeratBrutto.Tag = BeratBrutto
                SetEnableCommand()
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
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

    Private Sub tmrTimbangan_Tick(sender As Object, e As EventArgs) Handles tmrTimbangan.Tick
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

    Private Sub SetEnableCommand()

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, Not cboKodeMesin.Enabled, True) And _
                         If(cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1, False, True) And _
                         If(cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1, False, True) And _
                         If(cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1, False, True) And _
                         If(cboKodePolaMedia.SelectedIndex = cboKodePolaMedia.Items.Count - 1, False, True) And _
                         If((cboKodeMedia1.SelectedIndex <> cboKodeMedia1.Items.Count - 1 And txtTotalMedia1.Value = 0), False, True) And _
                         If((cboKodeMedia2.SelectedIndex <> cboKodeMedia2.Items.Count - 1 And txtTotalMedia2.Value = 0), False, True) And _
                         If((cboKodeMedia3.SelectedIndex <> cboKodeMedia3.Items.Count - 1 And txtTotalMedia3.Value = 0), False, True) And _
                         If(txtTotalMedia.Value <= 0, False, True) And lblStabil.Visible And _
                         If(BeratNetto <= 0, False, True)

        txtTotalMedia1.Value = txtJumlahMedia1.Value
        txtTotalMedia2.Value = txtJumlahMedia2.Value * txtJumlahMedia1.Value
        txtTotalMedia3.Value = txtJumlahMedia3.Value * txtJumlahMedia2.Value

        BeratMedia = (txtTotalMedia1.Value * txtBeratMedia1.Value) + (txtTotalMedia2.Value * txtBeratMedia2.Value) + (txtTotalMedia3.Value * txtBeratMedia3.Value)

        txtTotalMedia.Value = BeratMedia.ToString("###,##0.00")

        BeratNetto = BeratBrutto - BeratMedia
        lblBeratNetto.Text = BeratNetto.ToString("###,##0.00")
        lblBeratNetto.Tag = BeratNetto

        chkTimbangManual.Visible = ActiveSession.Supervisor
        txtTimbangManual.Visible = ActiveSession.Supervisor
    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnit.Click
        Dim DaftarUnitProduksi As IDataLookup = New DaftarUnitProduksi(ActiveSession)
        Dim Parameter() As String = {"001"}

        Dim Form As New frmLookup(DaftarUnitProduksi, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeUnit.SelectedValue = Form.IDLookup
            cboKodeUnit.Focus()
        End If
    End Sub

    Private Sub btLookupNomorSPK_Click(sender As Object, e As EventArgs) Handles btLookupNomorSPK.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, Now}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSPK.SelectedValue = Form.IDLookup
            cboNomorSPK.Focus()
        End If
    End Sub

    Private Sub btLookupPolaMedia_Click(sender As Object, e As EventArgs) Handles btLookupPolaMedia.Click
        Dim DaftarPola As IDataLookup = New DaftarPolaMediaTimbang(ActiveSession)
        Dim Parameter() As String = {lblLokasiProduksi.Tag}

        Dim Form As New frmLookup(DaftarPola, Parameter)
        Form.Text = "Lookup Daftar Pola Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodePolaMedia.SelectedValue = Form.IDLookup
            cboKodePolaMedia.Focus()
        End If
    End Sub

    Private Sub frmPenerimaanBenang_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'FillComboGrup()
        'FillComboUnit()
        'FillComboNomorSPK()
        'FillComboMediaTimbang()
    End Sub

    Private Function CekPemakaianBahan(NoTransaksi As String) As Boolean
        'Simpan Data Item Bahan dan Cek Pemakaian Bahan By WO
        Dim SAP As New SAPWorkOrder
        Dim DS As DataSet

        Dim X_DPB As New X_DaftarPemakaianBahan(ActiveSession)
        Dim X_PB As New X_PemakaianBahan

        DS = SAP.ReadRMByWONonBatch(cboNomorSpk.SelectedValue, cboKodeUnit.Tag)
        For Each DR As DataRow In DS.Tables("View").Rows
            X_PB.NoTransaksi = NoTransaksi
            X_PB.NomorWO = cboNomorSpk.SelectedValue
            X_PB.KodeItem = DR("Kode Item")
            X_PB.NamaItem = DR("Nama Item")

            X_DPB.Add(X_PB)
        Next

        CekPemakaianBahan = True

        Dim DPB As New DaftarPemakaianBahan(ActiveSession)
        Dim PB As PemakaianBahanZero = DPB.GetItemZero(cboNomorSpk.SelectedValue)
        If Not IsNothing(PB) Then
            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSpk.SelectedValue + " Belum Dimasukkan...!" + vbCrLf +
                            PB.KodeBahan + " - " + PB.NamaBahan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            CekPemakaianBahan = False
        End If

        X_DPB.Delete(NoTransaksi)
    End Function

    Private Sub chkTimbangManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkTimbangManual.CheckedChanged
        If chkTimbangManual.Checked Then
            txtTimbangManual.Enabled = True
            lblStabil.Visible = True
            txtTimbangManual.Focus()
        Else
            txtTimbangManual.Value = 0
            txtTimbangManual.Enabled = False
            lblStabil.Visible = False
        End If
        SetEnableCommand()
    End Sub

    Private Sub PrintBarcode(NoTimbang As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
        Dim Data = DaftarStockBenang.ReadByTimbang(NoTimbang).Tables("View")
        Dim DR As DataRow

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeGB.btw", False, "")

        For Each DR In Data.Rows

            'Deklarasi Barcode Application
            FormatBt.SetNamedSubStringValue("Tanggal", Convert.ToDateTime(DR("Tanggal")).ToString("dd-MM-yy"))
            FormatBt.SetNamedSubStringValue("KodeGrup", UCase(DR("Grup")))
            FormatBt.SetNamedSubStringValue("KodeMesin", UCase(DR("Mesin")))
            FormatBt.SetNamedSubStringValue("NamaItem", UCase(DR("Item")))
            FormatBt.SetNamedSubStringValue("StatusQc", UCase(DR("Status")))
            FormatBt.SetNamedSubStringValue("KodeArea", UCase(DR("Area")))
            FormatBt.SetNamedSubStringValue("BeratNetto", Convert.ToDouble(DR("Berat Netto")).ToString("#,##0.000"))
            FormatBt.SetNamedSubStringValue("NamaMedia", UCase(DR("Media")))
            FormatBt.SetNamedSubStringValue("JumlahMedia", DR("Jumlah"))
            FormatBt.SetNamedSubStringValue("Kode", DR("Kode Produksi"))
            FormatBt.SetNamedSubStringValue("Status", "A")
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(DR("Keterangan")) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

        Next
        AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btReprint.Click
        Dim Periode, PeriodeTransaksi, PrefikKodeProduksi As String

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    'CLASS PRODUKSI BENANG EXTRUDER
                    '========================================================================================
                    Dim DaftarProduksiBenangExtruder As New DaftarProduksiBenangExtruder(ActiveSession)
                    Dim ProduksiBenangExtruder As New ProduksiBenangExtruder
                    Dim DaftarStockBenangExtruder As New DaftarStockBenangExtruder(ActiveSession)
                    Dim StockBenangExtruder As New StockBenangExtruder

                    'DEKLARASI VARIABLE
                    '========================================================================================
                    Dim FlagKodeProduksi1, FlagKodeProduksi2, FlagKodeProduksi3 As Integer
                    Dim FlagIsiJumlah1, FlagIsiJumlah2, FlagIsiJumlah3 As Integer
                    Dim JumlahBagiMedia As Double
                    Dim JumlahMedia1, JumlahMedia2, JumlahMedia3 As Double
                    Dim BeratBruttoSave, BeratNettoSave As Double
                    Dim Satuan1, Satuan2, Satuan3 As String
                    Dim Jumlah1, Jumlah2, Jumlah3 As Double

                    'CEK PEMAKAIAN BAHAN
                    '========================================================================================
                    If New DaftarPemakaianBahan(ActiveSession).IsEmpty(cboNomorSPK.SelectedValue) Then
                        MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GoTo Jump
                    Else
                        If Not New DaftarPemakaianBahan(ActiveSession).IsPemakaianBahan(cboNomorSPK.SelectedValue) Then
                            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo Jump
                        End If
                    End If
                    '========================================================================================

                    'Menentukan FlagKodeProduksi Pola Media Timbang
                    '--------------------------------------------------------------------------------------------------
                    Dim PolaMediaTimbang As PolaMediaTimbang = New DaftarPolaMediaTimbang(ActiveSession).Find(cboKodePolaMedia.SelectedValue)
                    If Not IsNothing(PolaMediaTimbang) Then
                        FlagKodeProduksi1 = PolaMediaTimbang.FlagJumlahMedia1
                        FlagKodeProduksi2 = PolaMediaTimbang.FlagJumlahMedia2
                        FlagKodeProduksi3 = PolaMediaTimbang.FlagJumlahMedia3
                    End If

                    'Menentukan FlagIsiJumlah Media Timbang
                    '--------------------------------------------------------------------------------------------------
                    Try
                        FlagIsiJumlah1 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia1.SelectedValue).JumlahMedia
                        FlagIsiJumlah2 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia2.SelectedValue).JumlahMedia
                        FlagIsiJumlah3 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia3.SelectedValue).JumlahMedia
                    Catch
                    End Try

                    'Menentukan JumlahMedia(Pembagi) >> Satuan pokok penghitung kode produksi
                    '--------------------------------------------------------------------------------------------------
                    If FlagKodeProduksi1 = 1 And FlagIsiJumlah1 = 1 Then
                        JumlahBagiMedia += txtJumlahMedia1.Value
                        Satuan1 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia1.SelectedValue).KodeSatuan 'Menentukan Satuan1
                    End If
                    If FlagKodeProduksi2 = 1 And FlagIsiJumlah2 = 1 Then
                        JumlahBagiMedia += txtJumlahMedia2.Value
                        Satuan1 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia2.SelectedValue).KodeSatuan 'Menentukan Satuan1
                    End If
                    If FlagKodeProduksi3 = 1 And FlagIsiJumlah3 = 1 Then
                        JumlahBagiMedia += txtJumlahMedia3.Value
                        Satuan1 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia3.SelectedValue).KodeSatuan 'Menentukan Satuan1
                    End If

                    'Menentukan JumlahMedia(Pembagi) >> Satuan pokok penghitung kode produksi
                    'Kriteria   : Jika FlagKodeProduksi(Dasar Hitung Kode Produksi)=True DAN FlagIsiJumlah(Ijinkan Pengisian Jumlah)=True
                    '             ATAU FlagKodeProduksi(Dasar Hitung Kode Produksi)=True DAN FlagIsiJumlah(Ijinkan Pengisian Jumlah)=False
                    '--------------------------------------------------------------------------------------------------
                    If (FlagKodeProduksi1 = 1 And FlagIsiJumlah1 = 1) Or (FlagKodeProduksi1 = 1 And FlagIsiJumlah1 = 0) Then
                        If JumlahBagiMedia <> 0 Then
                            JumlahMedia1 = txtJumlahMedia1.Value / JumlahBagiMedia
                            Jumlah1 = txtJumlahMedia1.Value / JumlahBagiMedia 'Menentukan Jumlah1
                        End If
                    Else
                        JumlahMedia1 = txtJumlahMedia1.Value
                    End If
                    If (FlagKodeProduksi2 = 1 And FlagIsiJumlah2 = 1) Or (FlagKodeProduksi2 = 1 And FlagIsiJumlah2 = 0) Then
                        If JumlahBagiMedia <> 0 Then
                            JumlahMedia2 = txtJumlahMedia2.Value / JumlahBagiMedia
                            Jumlah1 = txtJumlahMedia2.Value / JumlahBagiMedia 'Menentukan Jumlah1
                        End If
                    Else
                        JumlahMedia2 = txtJumlahMedia2.Value
                    End If
                    If (FlagKodeProduksi3 = 1 And FlagIsiJumlah3 = 1) Or (FlagKodeProduksi3 = 1 And FlagIsiJumlah3 = 0) Then
                        If JumlahBagiMedia <> 0 Then
                            JumlahMedia3 = txtJumlahMedia3.Value / JumlahBagiMedia
                            Jumlah1 = txtJumlahMedia3.Value / JumlahBagiMedia 'Menentukan Jumlah1
                        End If
                    Else
                        JumlahMedia3 = txtJumlahMedia3.Value
                    End If

                    'Menentukan Satuan Unit (Satuan2)
                    '--------------------------------------------------------------------------------------------------
                    If FlagKodeProduksi1 = 0 And FlagIsiJumlah1 = 1 Then
                        Satuan2 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia1.SelectedValue).KodeSatuan 'Menentukan Satuan2
                        Jumlah2 = txtJumlahMedia1.Value
                    End If
                    If FlagKodeProduksi2 = 0 And FlagIsiJumlah2 = 1 Then
                        Satuan2 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia2.SelectedValue).KodeSatuan 'Menentukan Satuan2
                        Jumlah2 = txtJumlahMedia2.Value
                    End If
                    If FlagKodeProduksi3 = 0 And FlagIsiJumlah3 = 1 Then
                        Satuan2 = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia3.SelectedValue).KodeSatuan 'Menentukan Satuan2
                        Jumlah2 = txtJumlahMedia3.Value
                    End If

                    BeratBruttoSave = BeratBrutto / JumlahBagiMedia
                    BeratNettoSave = BeratNetto / JumlahBagiMedia

                    'Menentukan Satuan Timbang (Satuan3)
                    '--------------------------------------------------------------------------------------------------
                    Satuan3 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan3
                    Jumlah3 = BeratNettoSave

                    If JumlahBagiMedia = 0 Then
                        MessageBox.Show("Pengaturan Dasar Perhitungan Jumlah Kode Produksi Tidak Valid. " + vbCr +
                                        "Periksa Pengaturan Pola Media Timbang...!!!", "Peringatan", MessageBoxButtons.OK)
                        GoTo Jump
                    End If

                    'GetNomorTransaksisIn(Nomor Timbang)
                    '--------------------------------------------------------------------------------------------------
                    Periode = GetPeriod(TglTransaksi)
                    PeriodeTransaksi = GetPeriodFull(TglTransaksi)

                    _NoTransaksi = DaftarProduksiBenangExtruder.GetNomorTransaksi("EXHP", Periode)

                    Dim LastNumber As Integer
                    Dim Nomor, Prefik As String

                    Prefik = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).PrefikKodeProduksi.Trim() + PeriodeTransaksi
                    LastNumber = DaftarProduksiBenangExtruder.GetLastKodeProduksi(cboKodeUnit.SelectedValue, cboKodeMesin.SelectedValue, PeriodeTransaksi)

                    For oData As Integer = 1 To JumlahBagiMedia
                        LastNumber += 1
                        Nomor = (LastNumber.ToString).PadLeft(13 - Prefik.Length).Replace(" ", "0")
                        KodeProduksi = Prefik + cboKodeMesin.SelectedValue + Nomor

                        ProduksiBenangExtruder.NoTransaksi = _NoTransaksi
                        ProduksiBenangExtruder.TglTransaksi = TglTransaksi
                        ProduksiBenangExtruder.TglTimbang = Now
                        ProduksiBenangExtruder.NomorWO = cboNomorSPK.SelectedValue
                        ProduksiBenangExtruder.KodeUnitSAP = KodeUnitSAP
                        ProduksiBenangExtruder.KodeItem = lblItemProduksi.Tag
                        ProduksiBenangExtruder.NamaItem = lblItemProduksi.Text
                        ProduksiBenangExtruder.KodeShift = lblKodeShift.Text
                        ProduksiBenangExtruder.KodeGrup = cboKodeGrup.SelectedValue
                        ProduksiBenangExtruder.KodeUnit = cboKodeUnit.SelectedValue
                        ProduksiBenangExtruder.KodeMesin = cboKodeMesin.SelectedValue
                        ProduksiBenangExtruder.Keterangan = txtKeterangan.Text
                        ProduksiBenangExtruder.KodeLokasi = lblLokasiProduksi.Tag
                        ProduksiBenangExtruder.KodeProduksi = KodeProduksi
                        ProduksiBenangExtruder.BeratBrutto = BeratBruttoSave
                        ProduksiBenangExtruder.KodeMedia1 = cboKodeMedia1.SelectedValue
                        ProduksiBenangExtruder.KodeMedia2 = cboKodeMedia2.SelectedValue
                        ProduksiBenangExtruder.KodeMedia3 = cboKodeMedia3.SelectedValue
                        ProduksiBenangExtruder.JumlahMedia1 = JumlahMedia1
                        ProduksiBenangExtruder.JumlahMedia2 = JumlahMedia2
                        ProduksiBenangExtruder.JumlahMedia3 = JumlahMedia3
                        ProduksiBenangExtruder.BeratMedia1 = txtBeratMedia1.Value
                        ProduksiBenangExtruder.BeratMedia2 = txtBeratMedia2.Value
                        ProduksiBenangExtruder.BeratMedia3 = txtBeratMedia3.Value
                        ProduksiBenangExtruder.BeratNetto = BeratNettoSave
                        ProduksiBenangExtruder.KodeArea = cboKodeArea.SelectedValue
                        ProduksiBenangExtruder.StatusQC = cboKodeStatus.SelectedIndex + 1
                        ProduksiBenangExtruder.InputData = 0
                        ProduksiBenangExtruder.UserID = ActiveSession.KodeUser
                        ProduksiBenangExtruder.PrevShift = If(chkShiftSebelumnya.Checked, 1, 0)

                        DaftarProduksiBenangExtruder.Add(ProduksiBenangExtruder)

                        'SIMPAN STOCK BENANG
                        '=================================================================================================
                        StockBenangExtruder.NoTransaksi = _NoTransaksi
                        StockBenangExtruder.TglTransaksi = TglTransaksi
                        StockBenangExtruder.TglTimbang = Now
                        StockBenangExtruder.NomorWO = cboNomorSPK.SelectedValue
                        StockBenangExtruder.KodeItem = lblItemProduksi.Tag
                        StockBenangExtruder.NamaItem = lblItemProduksi.Text
                        StockBenangExtruder.KodeShift = lblKodeShift.Text
                        StockBenangExtruder.KodeGrup = cboKodeGrup.SelectedValue
                        StockBenangExtruder.KodeUnit = cboKodeUnit.SelectedValue
                        StockBenangExtruder.KodeMesin = cboKodeMesin.SelectedValue
                        StockBenangExtruder.KodeLokasi = lblLokasiProduksi.Tag
                        StockBenangExtruder.KodeProduksi = KodeProduksi
                        StockBenangExtruder.BeratNetto = BeratNettoSave
                        StockBenangExtruder.StatusQC = cboKodeStatus.SelectedIndex + 1
                        StockBenangExtruder.Satuan1 = Satuan1
                        StockBenangExtruder.Satuan2 = Satuan2
                        StockBenangExtruder.Satuan3 = Satuan3
                        StockBenangExtruder.Jumlah1 = Jumlah1
                        StockBenangExtruder.Jumlah2 = Jumlah2
                        StockBenangExtruder.Jumlah3 = Jumlah3
                        StockBenangExtruder.Keterangan = txtKeterangan.Text
                        StockBenangExtruder.KodeArea = cboKodeArea.SelectedValue
                        StockBenangExtruder.InputData = 0
                        StockBenangExtruder.UserID = ActiveSession.KodeUser

                        DaftarStockBenangExtruder.Add(StockBenangExtruder)
                    Next

                    'Simpan Data Penerimaan Benang Staging
                    '------------------------------------------------------------------------------------------------------
                    Dim SAPStaging As New SAPStaging

                    SAPStaging.PostFinishedGoodReceipt(cboKodeUnit.Tag, cboNomorSPK.SelectedValue, TglTransaksi, lblItemProduksi.Tag, BeratNetto, BeratNetto, "", "", _NoTransaksi, lblLokasiProduksi.Tag)

                    'Eksekusi Staging
                    '------------------------------------------------------------------------------------------------------
                    SAPStaging.Execute(_NoTransaksi, HSPProduction.SAPStaging.enumTransaction.FinishedGoodReceipt)

                    Scope.Complete()
                    Scope.Dispose()

                    'Cetak Barcode
                    '-----------------------------------------------------------------------------------------------------
                    PrintBarcode(_NoTransaksi)
                    '-----------------------------------------------------------------------------------------------------

                    Me.Cursor = Cursors.Default

                    MessageBox.Show("Transaksi Penerimaan Benang Hasil Extruder Telah Disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                PrintBarcode(New DaftarStockBenang(ActiveSession).FindLastID().M_NoTimbang, True)
                '---------------------------------------------------------------------------------------------------------
            Case "btClose"
                Me.Close()
        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub
End Class