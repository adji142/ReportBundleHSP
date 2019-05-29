Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmProduksiExtruder

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
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
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

    Private Sub DaftarRM()
        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        Dim SAP As New SAPWorkOrder()
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

        Dim BS As New BindingSource
        Dim DataSet As DataSet = SAP.ReadRMByWO(cboNomorSpk.SelectedValue.ToString, KodeUnitSAP)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        View.RowTemplate.Height = 16
        View.DataSource = BS

        View.Columns("ID").Visible = False
        View.Columns("Nomor").Visible = False
        View.Columns("Tanggal").Visible = False
        View.Columns("Qty").Visible = False
        View.Columns("Satuan").Visible = False

        Me.Cursor = Cursors.Default
        View.ResumeLayout()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            cboKodeGrup.SelectedIndexChanged,
                            chkShiftSebelumnya.CheckedChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            cboKodeMesin.SelectedIndexChanged,
                            cboNomorSpk.SelectedIndexChanged,
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

        If ObjectName = "cboKodeArea" Then
            lblAreaProduksi.Text = If(cboKodeArea.SelectedIndex = cboKodeArea.Items.Count - 1, "", "AREA " & cboKodeArea.Text.ToUpper())
        End If
        '-------------------------------------------------------------------------------------------------------

        If ObjectName = "cboKodeUnit" Then
            Try
                cboKodeUnit.Tag = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

                FillComboMesin()
                FillNomorSPK()

                lblUnitProduksi.Text = cboKodeUnit.Text
                Dim UnitProduksi As UnitProduksi

                UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue)

                If UnitProduksi.FlagPemakaian = 0 Then
                    cboKodeMesin.Enabled = False
                    btLookupKodeMesin.Enabled = False
                    cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
                Else
                    cboKodeMesin.Enabled = True
                    btLookupKodeMesin.Enabled = True
                End If

                If cboKodeUnit.SelectedValue = "001" Then
                    cboKodeMesin.Enabled = False
                    cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
                End If
            Catch
            End Try

        End If

        If ObjectName = "cboNomorSpk" Then
            If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
                Try
                    lblItemProduksi.Text = New SAPWorkOrder().FindFGByWO(cboKodeUnit.Tag, cboNomorSpk.SelectedValue).NamaItem
                    lblItemProduksi.Tag = New SAPWorkOrder().FindFGByWO(cboKodeUnit.Tag, cboNomorSpk.SelectedValue).KodeItem

                    CekPemakaianBahan(ActiveSession.KodeUser + Now.ToString("yyyyMMddHHmmss") + cboKodeUnit.Tag)

                    If cboKodeUnit.SelectedValue <> "001" Then
                        DaftarRM()
                    End If

                    If cboKodeUnit.SelectedValue = "001" Then
                        Dim KodeMesin As String = New SAPWorkOrder().FindMesin(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, cboNomorSpk.SelectedValue).KodeMesin
                        cboKodeMesin.SelectedValue = New DaftarMesin(ActiveSession).FindBySAP(KodeMesin).KodeMesin
                    End If
                Catch
                    View.DataSource = Nothing
                End Try
            Else
                View.DataSource = Nothing
                lblItemProduksi.Text = ""
                lblItemProduksi.Tag = ""

            End If

        End If

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
        View.SaveColumnOrder()
    End Sub

    Private Sub frmPenerimaanBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()

        FillComboGrup()
        FillComboUnitProduksi()
        FillComboMesin()
        FillComboArea()
        FillNomorSPK()
        FillComboArea()
        FillComboPolaMedia()
        FillComboMediaTimbang()

        ScaleConnection()
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

    Private Sub btLookupNomorSpk_Click(sender As Object, e As EventArgs) Handles btLookupNomorSpk.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
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
        Dim Parameter() As String = {lblLokasiProduksi.Tag}

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

    Private Sub FillNomorSPK()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            DS = SAPWorkOrder.ReadFGWorkOrderByUnit(cboKodeUnit.Tag, TglTransaksi)
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
                    If cboKodeUnit.SelectedValue = "001" Then
                        If New DaftarPemakaianBahan(ActiveSession).IsEmpty(cboNomorSpk.SelectedValue) Then
                            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSpk.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo Jump
                        Else
                            If Not New DaftarPemakaianBahan(ActiveSession).IsPemakaianBahan(cboNomorSpk.SelectedValue) Then
                                MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSpk.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                GoTo Jump
                            End If
                        End If
                    End If

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
                    Satuan3 = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeSatuan3
                    Jumlah3 = BeratNettoSave

                    If JumlahBagiMedia = 0 Then
                        MessageBox.Show("Pengaturan Dasar Perhitungan Jumlah Kode Produksi Tidak Valid. " + vbCr +
                                        "Periksa Pengaturan Pola Media Timbang...!!!", "Peringatan", MessageBoxButtons.OK)
                        GoTo Jump
                    End If

                    'GetNomorTransaksisIn(Nomor Timbang)
                    '--------------------------------------------------------------------------------------------------
                    NomorTimbang = DaftarProduksiBenang.GetNomorTransaksiIn(Periode)

                    'Simpan Data Penerimaan Benang Internal
                    '------------------------------------------------------------------------------------------------------
                    Dim nKodeProduksi As Integer
                    For nKodeProduksi = 1 To JumlahBagiMedia
                        'GetKodeProduksi(Kode Produksi/Barcode)
                        '--------------------------------------------------------------------------------------------------
                        KodeProduksi = DaftarProduksiBenang.GetKodeProduksi(cboKodeUnit.SelectedValue, cboKodeMesin.SelectedValue, PeriodeTransaksi)

                        ProduksiBenang.KodeProduksi = KodeProduksi
                        ProduksiBenang.KodeProduksiLama = ""
                        ProduksiBenang.StatusProduksi = 1 'Hasil Produksi
                        ProduksiBenang.NomorWO = cboNomorSpk.SelectedValue
                        If cboKodeUnit.SelectedValue <> "001" Then
                            ProduksiBenang.KodeItem = txtRMNamaItem.Tag
                            ProduksiBenang.NamaItem = txtRMNamaItem.Text
                        Else
                            ProduksiBenang.KodeItem = lblItemProduksi.Tag
                            ProduksiBenang.NamaItem = lblItemProduksi.Text
                        End If

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
                        ProduksiBenang.M_KodeUnit = cboKodeUnit.SelectedValue
                        ProduksiBenang.M_KodeMesin = cboKodeMesin.SelectedValue
                        ProduksiBenang.M_UserID = ActiveSession.KodeUser

                        DaftarProduksiBenang.Add(ProduksiBenang)
                    Next

                    'Simpan Data Penerimaan Benang Staging
                    '------------------------------------------------------------------------------------------------------
                    Dim SAPStaging As New SAPStaging
                    If cboKodeUnit.SelectedValue = "001" Then
                        SAPStaging.PostFinishedGoodReceipt(cboKodeUnit.Tag, cboNomorSpk.SelectedValue, Stod(lblTglTransaksi.Text), lblItemProduksi.Tag, BeratNetto, BeratNetto, "", "", NomorTimbang, lblLokasiProduksi.Tag)

                        'Eksekusi Staging
                        '------------------------------------------------------------------------------------------------------
                        SAPStaging.Execute(NomorTimbang, HSPProduction.SAPStaging.enumTransaction.FinishedGoodReceipt)
                    Else
                        SAPStaging.PostMaterialReceipt(cboKodeUnit.Tag, cboNomorSpk.SelectedValue, Stod(lblTglTransaksi.Text), txtRMNamaItem.Tag, BeratNetto, BeratNetto, "", NomorTimbang, lblLokasiProduksi.Tag)

                        'Eksekusi Staging
                        '------------------------------------------------------------------------------------------------------
                        SAPStaging.Execute(NomorTimbang, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)
                    End If

                    'Simpan Media Timbang
                    'RegKey = Registry.CurrentUser.OpenSubKey("Software\Timbangan", True)
                    'RegKey.SetValue("PolaMedia", cboKodePolaMediaTimbang.SelectedValue)
                    'RegKey.Close()

                    Scope.Complete()
                    Scope.Dispose()

                    'Cetak Barcode
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

    Private Sub View_SelectionChanged(sender As Object, e As EventArgs) Handles View.SelectionChanged
        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        'lblItemRetur.Visible = False
        'Try
        '    If cboKodeUnit.SelectedValue <> "001" Then
        '        View.Enabled = True
        '        lblItemRetur.Visible = True
        '    Else
        '        View.Enabled = False
        '    End If
        'Catch
        '    View.Enabled = False
        '    lblItemRetur.Visible = False
        'End Try

        If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
            If View.SelectedRows.Count <> 0 Then
                txtRMNamaItem.Tag = View.SelectedRows.Item(0).Cells("Kode Item").Value
                txtRMNamaItem.Text = View.SelectedRows.Item(0).Cells("Nama Item").Value
            Else
                txtRMNamaItem.Tag = ""
                txtRMNamaItem.Text = ""
            End If
        Else
            txtRMNamaItem.Tag = ""
            txtRMNamaItem.Text = ""
        End If

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, Not cboKodeMesin.Enabled, True) And _
                         If(cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1, False, True) And _
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

    'Private Sub frmProduksiExtruder_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    'FillComboUnitProduksi()
    'cboKodeUnit.SelectedValue = GetSetting(enumFormID.frmExtruder, enumSetting.settingKodeUnit)
    'FillComboMesin()
    'FillComboArea()
    'FillNomorSPK()
    'FillComboArea()
    'FillComboPolaMedia()
    'FillComboMediaTimbang()


    'End Sub
End Class