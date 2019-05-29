Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions
Imports SAPbobsCOM

Public Class frmTransferBenangMasuk

#Region "Declaration Variable"
    Private BeratBrutto, BeratMedia, BeratNetto As Double
    Private PrefikKodeProduksi As String
    Private DataScale As String

    Private NomorTimbang As String
    Private KodeProduksi As String

    Private TglTransaksi As DateTime

    Private Shared oCompany As New SAPbobsCOM.Company

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
        cboLokasiAsal.SelectedIndex = cboLokasiAsal.Items.Count - 1
        cboLokasiTujuan.SelectedIndex = cboLokasiTujuan.Items.Count - 1
        cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1
        cboStatusQc.SelectedIndex = cboStatusQc.Items.Count - 1
        cboKodePolaMediaTimbang.SelectedIndex = cboKodePolaMediaTimbang.Items.Count - 1
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
        txtTotalBeratMedia.Text = ""
        txtKeterangan.Text = ""

        chkManual.Checked = False
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
        'cboLokasiTujuan.SelectedValue = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
        If lblLokasiProduksi.Tag <> "" Then
            Try
                lblLokasiProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblLokasiProduksi.Tag).NamaLokasi.ToUpper()
                'cboLokasiTujuan.SelectedValue = lblLokasiProduksi.Tag
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
                            cboLokasiAsal.SelectedIndexChanged,
                            cboLokasiTujuan.SelectedIndexChanged,
                            cboItemBenang.SelectedIndexChanged,
                            cboKodeArea.SelectedIndexChanged,
                            cboStatusQc.SelectedIndexChanged,
                            cboKodePolaMediaTimbang.SelectedIndexChanged,
                            cboKodeMedia1.SelectedIndexChanged,
                            cboKodeMedia2.SelectedIndexChanged,
                            cboKodeMedia3.SelectedIndexChanged,
                            txtJumlahMedia1.TextChanged,
                            txtJumlahMedia2.TextChanged,
                            txtJumlahMedia3.TextChanged,
                            txtKeterangan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeGrup" Then
            lblNamaGrup.Text = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, "", cboKodeGrup.Text)
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboItemBenang" Then
            lblItemProduksi.Text = If(cboItemBenang.SelectedIndex = cboItemBenang.Items.Count - 1, "", cboItemBenang.Text)
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodeArea" Then
            lblAreaProduksi.Text = If(cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1, "", "AREA " & cboKodeArea.Text.ToUpper())
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodePolaMediaTimbang" Then
            Try
                Dim DaftarPolaMediaTimbang As New DaftarPolaMediaTimbang(ActiveSession)
                Dim PolaMediaTimbang As PolaMediaTimbang = DaftarPolaMediaTimbang.Find(cboKodePolaMediaTimbang.SelectedValue)
                If Not IsNothing(PolaMediaTimbang) Then
                    cboKodeMedia1.SelectedValue = PolaMediaTimbang.KodeMedia1
                    cboKodeMedia2.SelectedValue = PolaMediaTimbang.KodeMedia2
                    cboKodeMedia3.SelectedValue = PolaMediaTimbang.KodeMedia3
                    txtJumlahMedia1.Text = PolaMediaTimbang.JumlahDefault1
                    txtJumlahMedia2.Text = PolaMediaTimbang.JumlahDefault2
                    txtJumlahMedia3.Text = PolaMediaTimbang.JumlahDefault3
                Else
                    cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1
                    cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1
                    cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1
                    txtJumlahMedia1.Text = ""
                    txtJumlahMedia2.Text = ""
                    txtJumlahMedia3.Text = ""
                End If
            Catch
            End Try
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodeMedia1" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMedia1.SelectedValue.ToString)

            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia1.Text = MediaTimbang.Berat

                If MediaTimbang.JumlahMedia = 1 Then
                    txtJumlahMedia1.ReadOnly = False
                    txtJumlahMedia1.TabStop = True
                Else
                    txtJumlahMedia1.ReadOnly = True
                    txtJumlahMedia1.TabStop = False
                End If
            Else
                txtBeratMedia1.Text = ""
            End If
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodeMedia2" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMedia2.SelectedValue.ToString)
            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia2.Text = MediaTimbang.Berat

                If MediaTimbang.JumlahMedia = 1 Then
                    txtJumlahMedia2.ReadOnly = False
                    txtJumlahMedia2.TabStop = True
                Else
                    txtJumlahMedia2.ReadOnly = True
                    txtJumlahMedia2.TabStop = False
                End If
            Else
                txtBeratMedia2.Text = ""
            End If
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodeMedia3" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(cboKodeMedia3.SelectedValue.ToString)
            If Not IsNothing(MediaTimbang) Then
                txtBeratMedia3.Text = MediaTimbang.Berat

                If MediaTimbang.JumlahMedia = 1 Then
                    txtJumlahMedia3.ReadOnly = False
                    txtJumlahMedia3.TabStop = True
                Else
                    txtJumlahMedia3.ReadOnly = True
                    txtJumlahMedia3.TabStop = False
                End If
            Else
                txtBeratMedia3.Text = ""
            End If
        End If
        '-------------------------------------------------------------------------------------------------------

        SetEnableCommand()
    End Sub

    Private Sub frmPenerimaanBenang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ScalePort.Close()
        DissconnectToDatabase()
    End Sub

    Private Sub frmPenerimaanBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()

        FillComboGrup()
        FillComboItem()
        FillComboUnitProduksi()
        FillComboArea()
        FillComboPolaMedia()
        FillComboMediaTimbang()

        cboLokasiTujuan.SelectedValue = lblLokasiProduksi.Tag

        ScaleConnection()
    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupLokasiAsal.Click
        Dim DaftarLokasi As IDataLookup = New DaftarLokasi(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarLokasi, Parameter)
        Form.Text = "Lookup Daftar Lokasi Asal"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboLokasiAsal.SelectedValue = Form.IDLookup
            cboLokasiAsal.Focus()
        End If
    End Sub

    Private Sub btLookupKodeMesin_Click(sender As Object, e As EventArgs) Handles btLookupLokasiTujuan.Click
        Dim DaftarLokasi As IDataLookup = New DaftarLokasi(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarLokasi, Parameter)
        Form.Text = "Lookup Daftar Lokasi Tujuan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboLokasiTujuan.SelectedValue = Form.IDLookup
            cboLokasiTujuan.Focus()
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

    Private Sub btLookupKodeArea_Click(sender As Object, e As EventArgs) Handles btLookupKodeArea.Click
        Dim DaftarArea As IDataLookup = New DaftarArea(ActiveSession)
        Dim Parameter() As String = {lblLokasiProduksi.Tag}

        Dim Form As New frmLookup(DaftarArea, Parameter)
        Form.Text = "Lookup Daftar Area Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeArea.SelectedValue = Form.IDLookup
            cboKodeArea.Focus()
        End If
    End Sub

    Private Sub btLookupKodePolaMediaTimbang_Click(sender As Object, e As EventArgs) Handles btLookupKodePolaMediaTimbang.Click
        Dim DaftarPola As IDataLookup = New DaftarPolaMediaTimbang(ActiveSession)
        Dim Parameter() As String = {"511"}

        Dim Form As New frmLookup(DaftarPola, Parameter)
        Form.Text = "Lookup Daftar Pola Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodePolaMediaTimbang.SelectedValue = Form.IDLookup
            cboKodePolaMediaTimbang.Focus()
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

    Private Sub FillComboUnitProduksi()
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboLokasiAsal.DataSource = DS.Tables("View")
        cboLokasiAsal.DisplayMember = "Nama Lokasi"
        cboLokasiAsal.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

        cboLokasiAsal.SelectedIndex = cboLokasiAsal.Items.Count - 1

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboLokasiTujuan.DataSource = DS.Tables("View")
        cboLokasiTujuan.DisplayMember = "Nama Lokasi"
        cboLokasiTujuan.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

        cboLokasiTujuan.SelectedIndex = cboLokasiTujuan.Items.Count - 1
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
            cboKodePolaMediaTimbang.DataSource = DS.Tables("View")
            cboKodePolaMediaTimbang.DisplayMember = "Nama Pola"
            cboKodePolaMediaTimbang.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Pola") = "-"

            cboKodePolaMediaTimbang.SelectedIndex = cboKodePolaMediaTimbang.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Pola")

            cboKodePolaMediaTimbang.DataSource = DS.Tables("View")
            cboKodePolaMediaTimbang.DisplayMember = "Nama Pola"
            cboKodePolaMediaTimbang.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Pola") = "-"

            cboKodePolaMediaTimbang.SelectedIndex = cboKodePolaMediaTimbang.Items.Count - 1
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

    Private Sub FillComboItem()
        Dim DaftarItem As New DaftarSAPItemBarang()
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarItem.ReadItemAll("", "187")
        cboItemBenang.DataSource = DS.Tables("View")
        cboItemBenang.DisplayMember = "Nama Item"
        cboItemBenang.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Item") = "-"

        cboItemBenang.SelectedIndex = cboItemBenang.Items.Count - 1
    End Sub
#End Region

#Region "Scale Comunication"

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
                tmrScale.Enabled = True
            Else
                lblStatus.Text = "OFFLINE"
                lblStatus.ForeColor = Color.Red
                tmrScale.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Timbangan Benang Gagal...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

                    Dim DaftarProduksiBenang As New DaftarStockBenang(ActiveSession)
                    Dim ProduksiBenang As New StockBenang

                    Periode = GetPeriod(Now)
                    PeriodeTransaksi = GetPeriodFull(Now)

                    PrefikKodeProduksi = New DaftarLokasi(ActiveSession).Find(lblLokasiProduksi.Tag).PrefikKodeTransaksi

                    Dim FlagKodeProduksi1, FlagKodeProduksi2, FlagKodeProduksi3 As Integer
                    Dim FlagIsiJumlah1, FlagIsiJumlah2, FlagIsiJumlah3 As Integer
                    Dim JumlahBagiMedia As Double
                    Dim JumlahMedia1, JumlahMedia2, JumlahMedia3 As Double
                    Dim BeratBruttoSave, BeratNettoSave As Double
                    Dim Satuan1, Satuan2, Satuan3 As String
                    Dim Jumlah1, Jumlah2, Jumlah3 As Double

                    'Menentukan FlagKodeProduksi Pola Media Timbang
                    '--------------------------------------------------------------------------------------------------
                    Dim PolaMediaTimbang As PolaMediaTimbang = New DaftarPolaMediaTimbang(ActiveSession).Find(cboKodePolaMediaTimbang.SelectedValue)
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
                    Satuan3 = New DaftarUnitProduksi(ActiveSession).FindByLokasi(cboLokasiAsal.SelectedValue).KodeSatuan3
                    Jumlah3 = BeratNettoSave

                    If JumlahBagiMedia = 0 Then
                        MessageBox.Show("Pengaturan Dasar Perhitungan Jumlah Kode Produksi Tidak Valid. " + vbCr +
                                        "Periksa Pengaturan Pola Media Timbang...!!!", "Peringatan", MessageBoxButtons.OK)
                        GoTo Jump
                    End If

                    'GetNomorTransaksisIn(Nomor Timbang)
                    '--------------------------------------------------------------------------------------------------
                    NomorTimbang = DaftarProduksiBenang.GetNomorTransaksiIn(Periode)

                    'Simpan Transfer Benang Masuk
                    'START
                    '======================================================================================================
                    Dim DaftarTransferBenangMasuk As New DaftarTransferBenangMasuk(ActiveSession)
                    Dim TransferBenangMasuk As New TransferBenangMasuk

                    TransferBenangMasuk.NoTransaksi = NomorTimbang
                    TransferBenangMasuk.TglTransaksi = TglTransaksi
                    TransferBenangMasuk.TglPencatatan = Now
                    TransferBenangMasuk.KodeShift = lblKodeShift.Text
                    TransferBenangMasuk.KodeGrup = cboKodeGrup.SelectedValue
                    TransferBenangMasuk.PrevShift = If(chkShiftSebelumnya.Checked, 1, 0)
                    TransferBenangMasuk.KodeItem = cboItemBenang.SelectedValue
                    TransferBenangMasuk.NamaItem = cboItemBenang.Text
                    TransferBenangMasuk.KodeArea = cboKodeArea.SelectedValue
                    TransferBenangMasuk.KodeStatus = cboStatusQc.SelectedIndex + 1
                    TransferBenangMasuk.KodeLokasiAsal = cboLokasiAsal.SelectedValue
                    TransferBenangMasuk.KodeLokasiTujuan = cboLokasiTujuan.SelectedValue
                    TransferBenangMasuk.BeratBrutto = BeratBruttoSave
                    TransferBenangMasuk.KodeMedia1 = cboKodeMedia1.SelectedValue
                    TransferBenangMasuk.KodeMedia2 = cboKodeMedia2.SelectedValue
                    TransferBenangMasuk.KodeMedia3 = cboKodeMedia3.SelectedValue
                    TransferBenangMasuk.BeratMedia1 = txtBeratMedia1.Value
                    TransferBenangMasuk.BeratMedia2 = txtBeratMedia2.Value
                    TransferBenangMasuk.BeratMedia3 = txtBeratMedia3.Value
                    TransferBenangMasuk.JumlahMedia1 = JumlahMedia1
                    TransferBenangMasuk.JumlahMedia2 = JumlahMedia2
                    TransferBenangMasuk.JumlahMedia3 = JumlahMedia3
                    TransferBenangMasuk.BeratNetto = BeratNettoSave
                    TransferBenangMasuk.Jumlah1 = Jumlah1
                    TransferBenangMasuk.Jumlah2 = Jumlah2
                    TransferBenangMasuk.Jumlah3 = Jumlah3
                    TransferBenangMasuk.Satuan1 = Satuan1
                    TransferBenangMasuk.Satuan2 = Satuan2
                    TransferBenangMasuk.Satuan3 = Satuan3
                    TransferBenangMasuk.Keterangan = txtKeterangan.Text
                    TransferBenangMasuk.UserID = ActiveSession.KodeUser

                    DaftarTransferBenangMasuk.Add(TransferBenangMasuk)

                    'Simpan Transfer Benang Masuk
                    'FINISH
                    '======================================================================================================


                    'Simpan Data Stock Benang Internal
                    '------------------------------------------------------------------------------------------------------
                    Dim nKodeProduksi As Integer
                    For nKodeProduksi = 1 To JumlahBagiMedia
                        'GetKodeProduksi(Kode Produksi/Barcode)
                        '--------------------------------------------------------------------------------------------------
                        KodeProduksi = DaftarProduksiBenang.GetKodeProduksi("001", cboLokasiTujuan.SelectedValue, PeriodeTransaksi)

                        ProduksiBenang.KodeProduksi = KodeProduksi
                        ProduksiBenang.KodeProduksiLama = ""
                        ProduksiBenang.StatusProduksi = 1 'Hasil Produksi
                        ProduksiBenang.NomorWO = "-"
                        ProduksiBenang.KodeItem = cboItemBenang.SelectedValue
                        ProduksiBenang.NamaItem = cboItemBenang.Text

                        ProduksiBenang.KodeStatusQC = cboStatusQc.SelectedIndex + 1
                        ProduksiBenang.NamaStatusQC = cboStatusQc.SelectedItem
                        ProduksiBenang.KodeDisposisi = 0
                        ProduksiBenang.NamaDisposisi = ""
                        ProduksiBenang.BeratBrutto = BeratBruttoSave
                        ProduksiBenang.KodePola = cboKodePolaMediaTimbang.SelectedValue
                        ProduksiBenang.KodeMedia1 = cboKodeMedia1.SelectedValue
                        ProduksiBenang.BeratMedia1 = txtBeratMedia1.Value
                        ProduksiBenang.JumlahMedia1 = JumlahMedia1
                        ProduksiBenang.KodeMedia2 = cboKodeMedia2.SelectedValue
                        ProduksiBenang.BeratMedia2 = txtBeratMedia2.Value
                        ProduksiBenang.JumlahMedia2 = JumlahMedia2
                        ProduksiBenang.KodeMedia3 = cboKodeMedia3.SelectedValue
                        ProduksiBenang.BeratMedia3 = txtBeratMedia3.Value
                        ProduksiBenang.JumlahMedia3 = JumlahMedia3
                        ProduksiBenang.BeratNetto = BeratNettoSave
                        ProduksiBenang.Satuan1 = Satuan1
                        ProduksiBenang.Satuan2 = Satuan2
                        ProduksiBenang.Satuan3 = Satuan3
                        ProduksiBenang.Jumlah1 = Jumlah1
                        ProduksiBenang.Jumlah2 = Jumlah2
                        ProduksiBenang.Jumlah3 = Jumlah3
                        ProduksiBenang.KodeLokasi = lblLokasiProduksi.Tag
                        ProduksiBenang.KodeArea = cboKodeArea.SelectedValue
                        ProduksiBenang.Keterangan = txtKeterangan.Text
                        ProduksiBenang.InputData = 0
                        ProduksiBenang.M_NoTimbang = NomorTimbang
                        ProduksiBenang.M_TglTransaksi = TglTransaksi
                        ProduksiBenang.M_TglTimbang = Now
                        ProduksiBenang.M_KodeShift = lblKodeShift.Text
                        ProduksiBenang.M_KodeGrup = cboKodeGrup.SelectedValue
                        ProduksiBenang.M_PrevShift = If(chkShiftSebelumnya.Checked, 1, 0)
                        ProduksiBenang.M_KodeUnit = cboLokasiAsal.SelectedValue
                        ProduksiBenang.M_KodeMesin = cboLokasiTujuan.SelectedValue
                        ProduksiBenang.M_UserID = ActiveSession.KodeUser

                        DaftarProduksiBenang.Add(ProduksiBenang)
                    Next

                    'Simpan Transfer Benang Masuk Staging
                    'START
                    '======================================================================================================
                    Dim SAPStaging As New SAPStaging

                    'Proses Good Issue
                    '>>======================================================================================================
                    Dim StockBahan As Double
                    Dim TimbangBahan As Double = BeratNetto

                    'Cek Stock Bahan
                    '---------------------------------------------------------------------------------------------
                    StockBahan = New SAPInventory().GetCurrentStock(cboLokasiAsal.SelectedValue, cboItemBenang.SelectedValue, "")

                    'Jika stock kurang dari qty Good Issue
                    'Good Issue sebanyak sisa stock
                    '---------------------------------------------------------------------------------------------
                    If BeratNetto > StockBahan Then
                        TimbangBahan = Math.Abs(StockBahan)
                    End If

                    'SAPConnectionSDK.oCompany.StartTransaction()
                    If Not oCompany.Connected Then
                        ConnectToDatabase()
                    End If

                    'Posting Staging
                    '>>---------------------------------------------------------------------------------------------
                    'GOODS ISSUE
                    'START
                    '===============================================================================================
                    Dim oGoodsIssue As SAPbobsCOM.Documents
                    oGoodsIssue = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit)

                    'Header
                    '**********************************************************************************************************************************
                    oGoodsIssue.Series = 516                              'Numbering Series : 19GII
                    oGoodsIssue.DocDate = TglTransaksi
                    oGoodsIssue.TaxDate = TglTransaksi
                    oGoodsIssue.Comments = "GOOD ISSUE/TRANSFER BENANG KELUAR #" & NomorTimbang

                    'Detail
                    '**********************************************************************************************************************************
                    oGoodsIssue.Lines.ItemCode = cboItemBenang.SelectedValue
                    oGoodsIssue.Lines.ItemDescription = cboItemBenang.Text
                    oGoodsIssue.Lines.Quantity = TimbangBahan
                    oGoodsIssue.Lines.WarehouseCode = cboLokasiAsal.SelectedValue

                    oGoodsIssue.Lines.Add()

                    Dim nStatus As Long = oGoodsIssue.Add()
                    Dim nError As Long = 0
                    Dim sError As String = ""

                    If nStatus <> 0 Then
                        oCompany.GetLastError(nError, sError)
                        MsgBox(nError & " : " & sError)
                    End If

                    'GOODS ISSUE
                    'FINISH
                    '===============================================================================================

                    'GOODS RECEIPT
                    'START
                    '===============================================================================================

                    'Header
                    '**********************************************************************************************************************************
                    Dim oGoodsReceipt As SAPbobsCOM.Documents
                    oGoodsReceipt = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry)

                    oGoodsReceipt.Series = 517                                  'Numbering Series : 19GRI
                    oGoodsReceipt.DocDate = Now.Date
                    oGoodsReceipt.TaxDate = Now.Date
                    oGoodsReceipt.Comments = "GOOD RECEIPT/TRANSFER BENANG MASUK #" & NomorTimbang

                    'Detail
                    '**********************************************************************************************************************************
                    oGoodsReceipt.Lines.ItemCode = cboItemBenang.SelectedValue
                    oGoodsReceipt.Lines.ItemDescription = cboItemBenang.Text
                    oGoodsReceipt.Lines.Quantity = BeratNetto
                    oGoodsReceipt.Lines.WarehouseCode = cboLokasiTujuan.SelectedValue

                    oGoodsReceipt.Lines.Add()

                    Dim nStatusReceipt As Long = oGoodsReceipt.Add()
                    Dim nErrorReceipt As Long = 0
                    Dim sErrorReceipt As String = ""

                    If nStatusReceipt <> 0 Then
                        oCompany.GetLastError(nErrorReceipt, sErrorReceipt)
                        MsgBox(nErrorReceipt & " : " & sErrorReceipt)
                    End If

                    'GOODS RECEIPT
                    'FINISH
                    '===============================================================================================
                    'SAPConnectionSDK.oCompany.EndTransaction(BoWfTransOpt.wf_Commit)

                    Scope.Complete()
                    Scope.Dispose()

                    'Cetak BarCode
                    '------------------------------------------------------------------------------------------------------
                    PrintBarcode(NomorTimbang)

                    Me.Cursor = Cursors.Default

                    MsgBox("Transaksi Penerimaan Benang Berhasil Disimpan...")
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

    Private Sub View_SelectionChanged(sender As Object, e As EventArgs)
        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboItemBenang.SelectedIndex = cboItemBenang.Items.Count - 1, False, True) And _
                         If(cboLokasiAsal.SelectedIndex = cboLokasiAsal.Items.Count - 1, False, True) And _
                         If(cboLokasiTujuan.SelectedIndex = cboLokasiTujuan.Items.Count - 1, False, True) And _
                         If(cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1, False, True) And _
                         If(cboStatusQc.SelectedIndex = cboStatusQc.Items.Count - 1, False, True) And _
                         If(cboKodePolaMediaTimbang.SelectedIndex = cboKodePolaMediaTimbang.Items.Count - 1, False, True) And _
                         If((cboKodeMedia1.SelectedIndex <> cboKodeMedia1.Items.Count - 1 And txtTotalMedia1.Value = 0), False, True) And _
                         If((cboKodeMedia2.SelectedIndex <> cboKodeMedia2.Items.Count - 1 And txtTotalMedia2.Value = 0), False, True) And _
                         If((cboKodeMedia3.SelectedIndex <> cboKodeMedia3.Items.Count - 1 And txtTotalMedia3.Value = 0), False, True) And _
                         If(txtTotalBeratMedia.Value <= 0, False, True) And lblStabil.Visible And _
                         If(BeratNetto <= 0, False, True)

        txtTotalMedia1.Text = txtJumlahMedia1.Value
        txtTotalMedia2.Text = txtJumlahMedia2.Value * txtJumlahMedia1.Value
        txtTotalMedia3.Text = txtJumlahMedia3.Value * txtJumlahMedia2.Value

        BeratMedia = (txtTotalMedia1.Value * txtBeratMedia1.Value) + (txtTotalMedia2.Value * txtBeratMedia2.Value) + (txtTotalMedia3.Value * txtBeratMedia3.Value)

        txtTotalBeratMedia.Text = BeratMedia.ToString("###,##0.00")

        BeratNetto = BeratBrutto - BeratMedia
        lblBeratNetto.Text = BeratNetto.ToString("###,##0.00")
        lblBeratNetto.Tag = BeratNetto

        chkManual.Visible = ActiveSession.Supervisor
        lblTimbangManual.Visible = ActiveSession.Supervisor
        txtTimbangManual.Visible = ActiveSession.Supervisor
        lblSatuanTimbangManual.Visible = ActiveSession.Supervisor
    End Sub
#End Region

#Region "Barcode Printing"

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

#End Region

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
        SetEnableCommand()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DaftarTransferBenangMasuk As New DaftarTransferBenangMasuk(ActiveSession)
        Dim TransferBenangMasuk As New TransferBenangMasuk

        TransferBenangMasuk.NoTransaksi = "#001"
        TransferBenangMasuk.TglTransaksi = TglTransaksi
        TransferBenangMasuk.TglPencatatan = Now
        TransferBenangMasuk.KodeShift = lblKodeShift.Text
        TransferBenangMasuk.KodeGrup = cboKodeGrup.SelectedValue
        TransferBenangMasuk.PrevShift = If(chkShiftSebelumnya.Checked, 1, 0)
        TransferBenangMasuk.KodeItem = "301.0001"
        TransferBenangMasuk.NamaItem = "575 PT"
        TransferBenangMasuk.KodeArea = cboKodeArea.SelectedValue
        TransferBenangMasuk.KodeStatus = cboStatusQc.SelectedIndex + 1
        TransferBenangMasuk.KodeLokasiAsal = cboLokasiAsal.SelectedValue
        TransferBenangMasuk.KodeLokasiTujuan = cboLokasiTujuan.SelectedValue
        TransferBenangMasuk.BeratBrutto = 100
        TransferBenangMasuk.KodeMedia1 = cboKodeMedia1.SelectedValue
        TransferBenangMasuk.KodeMedia2 = cboKodeMedia2.SelectedValue
        TransferBenangMasuk.KodeMedia3 = cboKodeMedia3.SelectedValue
        TransferBenangMasuk.BeratMedia1 = txtBeratMedia1.Value
        TransferBenangMasuk.BeratMedia2 = txtBeratMedia2.Value
        TransferBenangMasuk.BeratMedia3 = txtBeratMedia3.Value
        TransferBenangMasuk.JumlahMedia1 = 1
        TransferBenangMasuk.JumlahMedia2 = 2
        TransferBenangMasuk.JumlahMedia3 = 3
        TransferBenangMasuk.BeratNetto = 100
        TransferBenangMasuk.Jumlah1 = 0
        TransferBenangMasuk.Jumlah2 = 0
        TransferBenangMasuk.Jumlah3 = 100
        TransferBenangMasuk.Satuan1 = ""
        TransferBenangMasuk.Satuan2 = ""
        TransferBenangMasuk.Satuan3 = ""
        TransferBenangMasuk.Keterangan = txtKeterangan.Text
        TransferBenangMasuk.UserID = ActiveSession.KodeUser

        DaftarTransferBenangMasuk.Add(TransferBenangMasuk)
    End Sub

    Private Sub btLookupItemBenang_Click(sender As Object, e As EventArgs) Handles btLookupItemBenang.Click
        Dim DaftarItem As IDataLookup = New DaftarSAPItemBarang()
        Dim Parameter() As String = {"187"}

        Dim Form As New frmLookup(DaftarItem, Parameter)
        Form.Text = "Lookup Daftar Item Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboItemBenang.SelectedValue = Form.IDLookup
            cboItemBenang.Focus()
        End If
    End Sub

    Private Sub frmTransferBenangMasuk_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not ConnectToDatabase() Then
            MessageBox.Show("Koneksi Ke Server SAP Gagal !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            If Not ActiveSession.KodeUser.ToUpper = "SPVS" Then
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If oCompany.Connected Then
            MsgBox("Koneksi OK")
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        If oCompany.Connected Then
            MsgBox("Koneksi OK || " + IP() + " || " + oCompany.UserName)
        Else
            MsgBox("Koneksi Gagal || " + IP() + " || " + oCompany.UserName)
        End If
    End Sub

    Private Function ConnectToDatabase() As Boolean
        oCompany.SLDServer = "192.168.1.222:40000"
        oCompany.Server = My.Settings.HanaServer
        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB
        oCompany.CompanyDB = My.Settings.HanaSAPDatabaseName
        If IP() = "192.168.1.163" Then
            oCompany.UserName = "IT"
            oCompany.Password = "hspHSP5050"
        End If

        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

        Dim nStatus As Long
        nStatus = oCompany.Connect

        If nStatus <> 0 Then
            ConnectToDatabase = False
        Else
            ConnectToDatabase = True
        End If
    End Function

    Private Function DissconnectToDatabase() As Boolean
        oCompany.Disconnect()
        DissconnectToDatabase = True
    End Function
End Class