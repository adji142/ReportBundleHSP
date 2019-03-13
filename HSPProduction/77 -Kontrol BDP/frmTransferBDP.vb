Imports HSPProduction.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32

Public Class frmTransferBDP

#Region "Header Section"
    'Konstanta Column Header
    '-------------------------------------------------------------------------------------------------
    Private Const _KodeItem = 0
    Private Const _NamaItem = 1    
    Private Const _PB = 2
    Private Const _RB = 3
    Private Const _HP = 4
    Private Const _RH = 5
    Private Const _BDP = 6
    Private Const _Satuan = 7
    Private Const _QtyTransfer = 8

    'Data Public
    Public IDData As String

    Private Enum enumStatus
        Draft = 0
        Posting = 1
    End Enum

    'Data Private
    Private KodeLokasi As String = ""

    Private _ID As String
    Private _GroupID As String
    Private _NoTransaksi As String
    Private _TRX As String = ""

    Private KodeUnitSAP As String
    Private TglTransaksi As DateTime

    Private _TglFG As Date
    Private _TglFGTransfer As Date

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String, GroupID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%", _GroupID)
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

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
        Try
            If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
                Dim DaftarMesin As New DaftarMesin(ActiveSession)
                Dim DS As DataSet

                DS = New DataSet
                DS = DaftarMesin.Read("%", cboKodeUnit.SelectedValue)
                cboKodeMesin.DataSource = DS.Tables("View")
                cboKodeMesin.DisplayMember = "Nama Mesin"
                cboKodeMesin.ValueMember = "Kode"

                Dim Drow As DataRow = DS.Tables("View").Rows.Add
                Drow("Kode") = ""
                Drow("Nama Mesin") = "-"
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
            End If

            cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        Catch
        End Try
    End Sub

    Private Sub FillNomorSPK()
        Try
            If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
                Dim SAPWorkOrder As New SAPWorkOrder
                Dim Drow As DataRow
                Dim DS As DataSet

                KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

                'WO Asal
                DS = New DataSet
                DS = SAPWorkOrder.ReadFGWorkOrderByUnitEx(KodeUnitSAP)
                cboNomorWO.DataSource = DS.Tables("View")
                cboNomorWO.DisplayMember = "Nomor"
                cboNomorWO.ValueMember = "Nomor"

                Drow = DS.Tables("View").Rows.Add
                Drow("Nomor") = ""
                Drow("Nomor") = "-"

                'WO Tujuan
                DS = New DataSet
                DS = SAPWorkOrder.ReadFGWorkOrderByUnitEx(KodeUnitSAP)
                cboNomorWOTransfer.DataSource = DS.Tables("View")
                cboNomorWOTransfer.DisplayMember = "Nomor"
                cboNomorWOTransfer.ValueMember = "Nomor"

                Drow = DS.Tables("View").Rows.Add
                Drow("Nomor") = ""
                Drow("Nomor") = "-"
            Else
                Dim Drow As DataRow
                Dim DS As DataSet

                'WO Asal
                DS = New DataSet
                DS.Tables.Add("View")
                DS.Tables("View").Columns.Add("Nomor")

                cboNomorWO.DataSource = DS.Tables("View")
                cboNomorWO.DisplayMember = "Nomor"
                cboNomorWO.ValueMember = "Nomor"

                Drow = DS.Tables("View").Rows.Add
                Drow("Nomor") = ""
                Drow("Nomor") = "-"

                'WO Asal
                DS = New DataSet
                DS.Tables.Add("View")
                DS.Tables("View").Columns.Add("Nomor")

                cboNomorWOTransfer.DataSource = DS.Tables("View")
                cboNomorWOTransfer.DisplayMember = "Nomor"
                cboNomorWOTransfer.ValueMember = "Nomor"

                Drow = DS.Tables("View").Rows.Add
                Drow("Nomor") = ""
                Drow("Nomor") = "-"
            End If

            cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
            cboNomorWOTransfer.SelectedIndex = cboNomorWO.Items.Count - 1
        Catch
        End Try
    End Sub

    Private Sub SetKolomHeader()
        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 7
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White

        Grid.AddColumnHeader("Kode Item", 9, 15, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Nama Item", 25, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Pemakaian" + vbCrLf + "Bahan", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightCyan, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Retur" + vbCrLf + "Bahan", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightCyan, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Hasil" + vbCrLf + "Produksi", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Retur" + vbCrLf + "Hasil", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("BDP", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.PeachPuff, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Satuan", 6, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, False)
        Grid.AddColumnHeader("Qty" + vbCrLf + "Transfer", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.Beige, Color.Black, "##,##0.00")

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ResetData()

        cboKodeUnit.SelectedValue = _GroupID
        txtTglPencatatan.Enabled = False

        txtNoTransaksi.Enabled = True
        txtNoTransaksi.Text = ""
        txtTglPencatatan.Text = ""

        txtKodeItemFG.Tag = ""
        txtKodeItemFG.Text = ""
        txtKodeSatuanFG.Text = ""
        lblTanggalWO.Text = ""

        txtKodeItemFGTransfer.Tag = ""
        txtKodeItemFGTransfer.Text = ""
        txtKodeSatuanFGTransfer.Text = ""
        lblTanggalWOTransfer.Text = ""
        lstMaterialTransfer.Items.Clear()

        txtHasilProduksi.Value = 0
        txtReturProduksi.Value = 0
        txtTotalProduksi.Value = 0
        txtNilaiBDP.Value = 0

        KodeUnitSAP = ""

        Grid.Clear()

        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi

        'KodeLokasi
        '-------------------------------------------------------------------------------------------------------------------
        Try
            KodeLokasi = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeLokasi
        Catch ex As Exception
            KodeLokasi = ""
        End Try

        If KodeLokasi = "" Then
            MessageBox.Show("Lokasi Unit Produksi Belum Ditentukan !", "Peringatan", MessageBoxButtons.OK)
            Me.Close()
            GoTo Jump
        End If

        If _ID <> "" Then
            txtNoTransaksi.Text = _ID
            'txtNoTransaksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()

Jump:
    End Sub

    Private Sub frmTransferBDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()
        FillCombo()

        ResetData()

        FillComboMesin()
        FillNomorSPK()

    End Sub

    Private Sub ReadDetailWO()
        Dim DT As DataTable = New SAPWorkOrder().ReadWIPByWO(cboNomorWO.SelectedValue, New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP).Tables("View")
        Dim DR As DataRow
        Dim Row As Integer = 0

        Me.Cursor = Cursors.WaitCursor

        Grid.Clear()

        Dim WO = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP.ToString, cboNomorWO.SelectedValue.ToString)
        lblTanggalWO.Text = WO.Tanggal.ToString("dd/MM/yyyy")
        _TglFG = WO.Tanggal.Date

        For Each DR In DT.Rows

            If Row >= Grid.Rows Then
                Grid.DataGridView.Rows.Add()
            End If

            txtKodeItemFG.Tag = DR("FGKodeItem")
            txtKodeItemFG.Text = DR("FGNamaItem")
            txtKodeSatuanFG.Text = DR("FGSatuan")
            txtHasilProduksi.Value = DR("HPTotal")
            txtReturProduksi.Value = DR("RHTotal")
            txtTotalProduksi.Value = DR("HPTotal") - DR("RHTotal")
            txtNilaiBDP.Value = DR("WIP")

            Grid.GridValue(_KodeItem, Row) = DR("RMKodeItem")
            Grid.GridValue(_NamaItem, Row) = DR("RMNamaItem")
            Grid.GridValue(_Satuan, Row) = DR("RMSatuan")
            Grid.GridValue(_PB, Row) = DR("PB")
            Grid.GridValue(_RB, Row) = DR("RB")
            Grid.GridValue(_HP, Row) = DR("HP")
            Grid.GridValue(_RH, Row) = DR("RH")
            Grid.GridValue(_BDP, Row) = DR("BDP")
            Grid.GridValue(_QtyTransfer, Row) = 0
            Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray

            Row += 1

        Next

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles txtNoTransaksi.TextChanged,
        cboKodeUnit.SelectedIndexChanged,
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        cboNomorWO.SelectedIndexChanged,
        cboNomorWOTransfer.SelectedIndexChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeUnit" Then
            FillComboMesin()
            FillNomorSPK()
        End If

        If ObjectName = "cboNomorWO" Then
            txtKodeItemFG.Text = ""
            txtKodeItemFG.Tag = ""
            txtKodeSatuanFG.Text = ""
            lblTanggalWO.Text = ""

            cboNomorWOTransfer.SelectedIndex = cboNomorWOTransfer.Items.Count - 1
            txtKodeItemFGTransfer.Text = ""
            txtKodeItemFGTransfer.Tag = ""
            txtKodeSatuanFGTransfer.Text = ""
            lblTanggalWOTransfer.Text = ""

            lstMaterialTransfer.Items.Clear()

            txtHasilProduksi.Value = 0
            txtReturProduksi.Value = 0
            txtTotalProduksi.Value = 0
            txtNilaiBDP.Value = 0

            Grid.Clear()
        End If

        If ObjectName = "cboNomorWOTransfer" Then
            If cboNomorWOTransfer.SelectedIndex <> cboNomorWOTransfer.Items.Count - 1 Then
                Dim WO = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP.ToString, cboNomorWOTransfer.SelectedValue.ToString)

                If Not IsNothing(WO) Then
                    txtKodeItemFGTransfer.Text = WO.NamaItem
                    txtKodeItemFGTransfer.Tag = WO.KodeItem
                    txtKodeSatuanFGTransfer.Text = WO.Satuan
                    lblTanggalWOTransfer.Text = WO.Tanggal.ToString("dd/MM/yyyy")
                    _TglFGTransfer = WO.Tanggal.Date

                    Dim Row As Integer = 0
                    For Row = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_KodeItem, Row) <> "" Then
                            If Grid.GridValue(_BDP, Row) > 0 Then
                                Dim Item = New SAPWorkOrder().FindRMByWO(KodeUnitSAP, cboNomorWOTransfer.SelectedValue.ToString, Grid.GridValue(_KodeItem, Row))
                                If Not IsNothing(Item) Then
                                    Grid.GridValue(_QtyTransfer, Row) = Grid.GridValue(_BDP, Row)
                                    Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.White
                                Else
                                    Grid.GridValue(_QtyTransfer, Row) = 0
                                    Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray
                                End If
                            Else
                                Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray
                                Grid.GridValue(_QtyTransfer, Row) = 0
                            End If
                        End If
                    Next

                    'Material
                    Dim DT As DataTable = New SAPWorkOrder().ReadRMByWO(cboNomorWOTransfer.SelectedValue.ToString, KodeUnitSAP).Tables("View")
                    'lblTanggalWOTransfer.Text = WO.Tanggal.ToString("dd/MM/yyyy")

                    lstMaterialTransfer.Items.Clear()
                    For Each DR In DT.Rows
                        lstMaterialTransfer.Items.Add(DR("Nama Item"))
                    Next

                Else
                    txtKodeItemFGTransfer.Text = ""
                    txtKodeItemFGTransfer.Tag = ""
                    txtKodeSatuanFGTransfer.Text = ""
                    lblTanggalWOTransfer.Text = ""
                    lstMaterialTransfer.Items.Clear()

                    Dim Row As Integer = 0
                    For Row = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_KodeItem, Row) <> "" Then
                            Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray
                            Grid.GridValue(_QtyTransfer, Row) = 0
                        End If
                    Next

                End If
            Else
                txtKodeItemFGTransfer.Text = ""
                txtKodeItemFGTransfer.Tag = ""
                txtKodeSatuanFGTransfer.Text = ""
                lblTanggalWOTransfer.Text = ""
                lstMaterialTransfer.Items.Clear()

                Dim Row As Integer = 0
                For Row = 0 To Grid.GridLastRow - 1
                    If Grid.GridValue(_KodeItem, Row) <> "" Then
                        Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray
                        Grid.GridValue(_QtyTransfer, Row) = 0
                    End If
                Next

            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btShow_Click(sender As Object, e As EventArgs) Handles btShow.Click
        If cboNomorWO.SelectedIndex <> cboNomorWO.Items.Count - 1 Then
            Me.Cursor = Cursors.WaitCursor
            ReadDetailWO()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btLookupNomorWO_Click(sender As Object, e As EventArgs) Handles btLookupNomorWO.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorWO.SelectedValue = Form.IDLookup
            cboNomorWO.Focus()
        End If
    End Sub

    Private Sub btLookupNomorWOTransfer_Click(sender As Object, e As EventArgs) Handles btLookupNomorWOTransfer.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorWOTransfer.SelectedValue = Form.IDLookup
            cboNomorWOTransfer.Focus()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTglPencatatan.Value.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                
                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Tanggal " + txtTglPencatatan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarTransferBDP As New DaftarTransferBDP(ActiveSession)
                    Dim HeaderTransferBDP As HeaderTransferBDP
                    Dim DetailTransferBDP As DetailTransferBDP

                    Dim DaftarPemakaianBahan As New DaftarPemakaianBahan(ActiveSession)
                    Dim HeaderPemakaianBahan As HeaderPemakaianBahan
                    Dim DetailPemakaianBahan As DetailPemakaianBahan

                    Dim SAPStaging As New SAPStaging

                    Dim KodeUnitSap As String = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

                    'Nomor Transaksi
                    txtNoTransaksi.Text = DaftarTransferBDP.GetNomorTransaksi(Periode)

                    'Simpan Header TransferBDP
                    '----------------------------------------------------------------------------------------------------
                    HeaderTransferBDP = New HeaderTransferBDP
                    HeaderTransferBDP.NoTransaksi = txtNoTransaksi.Text
                    HeaderTransferBDP.TglTransaksi = TglTransaksi.Date
                    HeaderTransferBDP.TglPencatatan = txtTglPencatatan.Value
                    HeaderTransferBDP.KodeUnit = cboKodeUnit.SelectedValue
                    HeaderTransferBDP.KodeShift = txtKodeShift.Text
                    HeaderTransferBDP.KodeGrup = cboKodeGrup.SelectedValue
                    HeaderTransferBDP.KodeMesin = cboKodeMesin.SelectedValue
                    HeaderTransferBDP.NomorWO = cboNomorWO.SelectedValue
                    HeaderTransferBDP.KodeItemFG = txtKodeItemFG.Tag
                    HeaderTransferBDP.NamaItemFG = txtKodeItemFG.Text
                    HeaderTransferBDP.KodeSatuanFG = txtKodeSatuanFG.Text
                    HeaderTransferBDP.TglFG = _TglFG
                    HeaderTransferBDP.NomorWOTransfer = cboNomorWOTransfer.SelectedValue
                    HeaderTransferBDP.KodeItemFGTransfer = txtKodeItemFGTransfer.Tag
                    HeaderTransferBDP.NamaItemFGTransfer = txtKodeItemFGTransfer.Text
                    HeaderTransferBDP.KodeSatuanFGTransfer = txtKodeSatuanFGTransfer.Text
                    HeaderTransferBDP.TglFGTransfer = _TglFGTransfer
                    HeaderTransferBDP.Keterangan = "#AUTO/TRANSFER BDP"
                    HeaderTransferBDP.TotalProduksi = txtTotalProduksi.Value
                    HeaderTransferBDP.TotalHasilProduksi = txtHasilProduksi.Value
                    HeaderTransferBDP.TotalReturProduksi = txtReturProduksi.Value
                    HeaderTransferBDP.NilaiBDP = txtNilaiBDP.Value
                    HeaderTransferBDP.UserID = ActiveSession.KodeUser
                    DaftarTransferBDP.AddHeader(HeaderTransferBDP)
                    '----------------------------------------------------------------------------------------------------

                    'Simpan Header PemakaianBahan 
                    'WO ASAL (RECEIPT)
                    '----------------------------------------------------------------------------------------------------
                    HeaderPemakaianBahan = New HeaderPemakaianBahan
                    HeaderPemakaianBahan.NoTransaksi = "A" + txtNoTransaksi.Text
                    HeaderPemakaianBahan.TglTransaksi = TglTransaksi.Date
                    HeaderPemakaianBahan.TglPencatatan = txtTglPencatatan.Value
                    HeaderPemakaianBahan.NomorWO = cboNomorWO.SelectedValue
                    HeaderPemakaianBahan.KodeUnit = cboKodeUnit.SelectedValue
                    HeaderPemakaianBahan.KodeShift = txtKodeShift.Text
                    HeaderPemakaianBahan.KodeGrup = cboKodeGrup.SelectedValue
                    HeaderPemakaianBahan.KodeMesin = cboKodeMesin.SelectedValue
                    HeaderPemakaianBahan.KodeItemFG = txtKodeItemFG.Tag
                    HeaderPemakaianBahan.NamaItemFG = txtKodeItemFG.Text
                    HeaderPemakaianBahan.Keterangan = "#AUTO/TRANSFER BDP KE " + cboNomorWOTransfer.SelectedValue
                    HeaderPemakaianBahan.UserID = ActiveSession.KodeUser
                    DaftarPemakaianBahan.AddHeader(HeaderPemakaianBahan)
                    '----------------------------------------------------------------------------------------------------

                    'Simpan Header PemakaianBahan 
                    'WO TUJUAN (ISSUE)
                    '----------------------------------------------------------------------------------------------------
                    HeaderPemakaianBahan = New HeaderPemakaianBahan
                    HeaderPemakaianBahan.NoTransaksi = "B" + txtNoTransaksi.Text
                    HeaderPemakaianBahan.TglTransaksi = TglTransaksi.Date
                    HeaderPemakaianBahan.TglPencatatan = txtTglPencatatan.Value
                    HeaderPemakaianBahan.NomorWO = cboNomorWOTransfer.SelectedValue
                    HeaderPemakaianBahan.KodeUnit = cboKodeUnit.SelectedValue
                    HeaderPemakaianBahan.KodeShift = txtKodeShift.Text
                    HeaderPemakaianBahan.KodeGrup = cboKodeGrup.SelectedValue
                    HeaderPemakaianBahan.KodeMesin = cboKodeMesin.SelectedValue
                    HeaderPemakaianBahan.KodeItemFG = txtKodeItemFGTransfer.Tag
                    HeaderPemakaianBahan.NamaItemFG = txtKodeItemFGTransfer.Text
                    HeaderPemakaianBahan.Keterangan = "#AUTO/TRANSFER BDP DARI " + cboNomorWO.SelectedValue
                    HeaderPemakaianBahan.UserID = ActiveSession.KodeUser
                    DaftarPemakaianBahan.AddHeader(HeaderPemakaianBahan)
                    '----------------------------------------------------------------------------------------------------

                    'Simpan DetailTransferBDP
                    '----------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer = 0
                    Dim Row As Integer = 0

                    For Row = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_KodeItem, Row) <> "" Then

                            If Grid.GridValue(_QtyTransfer, Row) <> 0 Then
                                If Grid.GridValue(_BDP, Row) < Grid.GridValue(_QtyTransfer, Row) Then
                                    Me.Cursor = Cursors.Default
                                    Scope.Dispose()
                                    MessageBox.Show("Qty Transfer Melebihi BDP!, Periksa Kembali ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo Jump
                                End If

                                If Grid.GridValue(_QtyTransfer, Row) < 0 Then
                                    Me.Cursor = Cursors.Default
                                    Scope.Dispose()
                                    MessageBox.Show("Qty Transfer Minus!, Periksa Kembali ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    GoTo Jump
                                End If
                            End If

                        End If
                    Next

                    Dim SAPProses As Boolean = False

                    For Row = 0 To Grid.GridLastRow - 1

                        If Grid.GridValue(_KodeItem, Row) <> "" Then

                            'Simpan Detail Transfer BDP
                            '-----------------------------------------------------------------------------------
                            NoUrut += 1

                            DetailTransferBDP = New DetailTransferBDP
                            DetailTransferBDP.NoTransaksi = txtNoTransaksi.Text
                            DetailTransferBDP.NoUrut = NoUrut
                            DetailTransferBDP.KodeItemRM = Grid.GridValue(_KodeItem, Row)
                            DetailTransferBDP.NamaItemRM = Grid.GridValue(_NamaItem, Row)
                            DetailTransferBDP.Qty = Grid.GridValue(_QtyTransfer, Row)
                            DetailTransferBDP.Satuan = Grid.GridValue(_Satuan, Row)
                            DetailTransferBDP.Keterangan = "#AUTO/TRANSFER BDP"
                            DetailTransferBDP.PB = Grid.GridValue(_PB, Row)
                            DetailTransferBDP.RB = Grid.GridValue(_RB, Row)
                            DetailTransferBDP.HP = Grid.GridValue(_HP, Row)
                            DetailTransferBDP.RH = Grid.GridValue(_RH, Row)
                            If Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray Then
                                DetailTransferBDP.FlagTransfer = 0
                            Else
                                DetailTransferBDP.FlagTransfer = 1
                            End If
                            DaftarTransferBDP.AddDetail(DetailTransferBDP)

                            If Grid.GridValue(_QtyTransfer, Row) <> 0 Then
                                SAPProses = True

                                'Simpan Detail Pemakaian Bahan
                                'WO ASAL (RECEIPT)
                                DetailPemakaianBahan = New DetailPemakaianBahan
                                DetailPemakaianBahan.NoTransaksi = "A" + txtNoTransaksi.Text
                                DetailPemakaianBahan.NoUrut = NoUrut
                                DetailPemakaianBahan.KodeItemRM = Grid.GridValue(_KodeItem, Row)
                                DetailPemakaianBahan.NamaItemRM = Grid.GridValue(_NamaItem, Row)
                                DetailPemakaianBahan.Qty = Grid.GridValue(_QtyTransfer, Row) * -1
                                DetailPemakaianBahan.Satuan = Grid.GridValue(_Satuan, Row)
                                DetailPemakaianBahan.Keterangan = "#AUTO/TRANSFER BDP KE " + cboNomorWOTransfer.SelectedValue
                                DaftarPemakaianBahan.AddDetail(DetailPemakaianBahan)

                                'Simpan Detail Pemakaian Bahan
                                'WO TUJUAN (ISSUE)
                                DetailPemakaianBahan = New DetailPemakaianBahan
                                DetailPemakaianBahan.NoTransaksi = "B" + txtNoTransaksi.Text
                                DetailPemakaianBahan.NoUrut = NoUrut
                                DetailPemakaianBahan.KodeItemRM = Grid.GridValue(_KodeItem, Row)
                                DetailPemakaianBahan.NamaItemRM = Grid.GridValue(_NamaItem, Row)
                                DetailPemakaianBahan.Qty = Grid.GridValue(_QtyTransfer, Row)
                                DetailPemakaianBahan.Satuan = Grid.GridValue(_Satuan, Row)
                                DetailPemakaianBahan.Keterangan = "#AUTO/TRANSFER BDP DARI " + cboNomorWO.SelectedValue
                                DaftarPemakaianBahan.AddDetail(DetailPemakaianBahan)
                            End If


                        End If
                    Next

                    If SAPProses Then
                        For Row = 0 To Grid.GridLastRow - 1

                            If Grid.GridValue(_KodeItem, Row) <> "" Then

                                'Simpan Transaksi Staging
                                '-----------------------------------------------------------------------------------
                                SAPStaging.PostMaterialReceipt(KodeUnitSap, cboNomorWO.SelectedValue, TglTransaksi.Date, Grid.GridValue(_KodeItem, Row), Grid.GridValue(_QtyTransfer, Row), Grid.GridValue(_QtyTransfer, Row), "", _
                                                               "A" + txtNoTransaksi.Text, KodeLokasi)
                                SAPStaging.PostMaterialIssue(KodeUnitSap, cboNomorWOTransfer.SelectedValue, TglTransaksi.Date, Grid.GridValue(_KodeItem, Row), Grid.GridValue(_QtyTransfer, Row), "", _
                                                               "B" + txtNoTransaksi.Text, KodeLokasi)

                            End If
                        Next

                        'Eksekusi Database STAGING
                        '------------------------------------------------------------------------------------------
                        SAPStaging.Execute("A" + txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)
                        SAPStaging.Execute("B" + txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)
                    End If

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    IDData = txtNoTransaksi.Text
                    Me.Close()

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try

            Case "btClose"
                Me.Close()
        End Select

Jump:

        txtNoTransaksi.Text = _NoTransaksi

    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = Now.ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                txtKodeShift.Text = "3"
                TglTransaksi = DateAdd("D", -1, Now.Date)
            Else
                txtKodeShift.Text = "1"
                TglTransaksi = Now.Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                txtKodeShift.Text = "1"
                TglTransaksi = Now.Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                txtKodeShift.Text = "2"
                TglTransaksi = Now.Date
            Else
                txtKodeShift.Text = "3"
                TglTransaksi = Now.Date
            End If
        End If
    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtTglPencatatan.Text = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1, False, True) And _
                         If(txtKodeItemFG.Text = "", False, True) And _
                         If(JumlahBarisData() = 0, False, True)

        lblBarisData.Text = JumlahBarisData() & " Baris Data"
    End Sub
#End Region

#Region "Detail Section"
    'Hitung Baris Data
    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        For Row = 0 To Grid.GridLastRow - 1

            If Grid.GridValue(_KodeItem, Row) <> "" Then
                Jumlah += 1
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub Grid_GridCellChange(Col As Integer, Row As Integer, NewData As String, OldData As String) Handles Grid.GridCellChange
        btSave.Enabled = False
    End Sub

    Private Sub Grid_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles Grid.GridCellPostValidation
        If Col = _QtyTransfer And Valid Then
            If Grid.GridValue(_QtyTransfer, Row) > Grid.GridValue(_BDP, Row) Then
                MessageBox.Show("Jumlah Transfer melebihi BDP !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Grid.Focus()
                Grid.GridValue(_QtyTransfer, Row) = Grid.GridValue(_BDP, Row)
                Grid.GridCellFocus(_QtyTransfer, Row)
            End If
            If Grid.GridValue(_QtyTransfer, Row) < 0 Then
                MessageBox.Show("Jumlah Transfer minus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Grid.Focus()
                Grid.GridValue(_QtyTransfer, Row) = Grid.GridValue(_BDP, Row)
                Grid.GridCellFocus(_QtyTransfer, Row)
            End If
        End If
        SetEnableCommand()
    End Sub

    Private Sub Grid_GridCellPreValidation(Col As Integer, Row As Integer, ByRef Cancel As Boolean) Handles Grid.GridCellPreValidation
        If Col = _QtyTransfer Then
            If Grid.DataGridView.Rows(Row).Cells(_QtyTransfer).Style.BackColor = Color.LightGray Then
                Cancel = True
            End If
        End If
    End Sub

    Private Sub Grid_GridChange() Handles Grid.GridChange
        SetEnableCommand()
    End Sub
#End Region

    
End Class