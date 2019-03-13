Imports HSPProduction.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32

Public Class frmPemakaianBahan

#Region "Header Section"
    'Konstanta Column Header
    '-------------------------------------------------------------------------------------------------
    Private Const _KodeItem = 0
    Private Const _NamaItem = 1
    Private Const _Qty = 2
    Private Const _Satuan = 3
    Private Const _Keterangan = 4

    'Data Public
    Public IDData As String


    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private Enum enumStatus
        Draft = 0
        Posting = 1
    End Enum

    'Data Private
    Private KodeLokasi As String = ""

    Private _ID As String
    Private _GroupID As String
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String
    Private _TRX As String = ""
    Private TglTransaksi As DateTime

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
                Dim DS As DataSet

                DS = New DataSet
                DS = SAPWorkOrder.ReadFGWorkOrderByUnit(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, txtTglPencatatan.Value.Date)
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

    Private Sub SetKolomHeader()

        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 7
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White
        Grid.DataGridView.AllowUserToDeleteRows = False

        Grid.AddColumnHeader("Kode Item", 15, 15, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Nama Item", 40, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Qty", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightCyan, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Satuan", 10, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, False)
        Grid.AddColumnHeader("Keterangan", 26, 50, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caLeft, False)

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtTglPencatatan.Enabled = False

        txtNoTransaksi.Enabled = True
        txtNoTransaksi.Text = ""
        txtTglPencatatan.Text = ""
        txtItemProduksi.Text = ""
        txtKeterangan.Text = ""

        cboKodeUnit.SelectedValue = _GroupID

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
            txtNoTransaksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()

Jump:
    End Sub

    Private Sub frmPemakaianBahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()
        FillCombo()

        ResetData()

        FillComboMesin()
        FillNomorSPK()

        If cboKodeUnit.SelectedValue = "001" Then
            cboKodeMesin.DataLocked = True
            cboKodeMesin.IndexLocked = True
            cboKodeMesin.DropDownStyle = ComboBoxStyle.Simple
        Else
            cboKodeMesin.DataLocked = False
            cboKodeMesin.IndexLocked = False
            cboKodeMesin.DropDownStyle = ComboBoxStyle.DropDownList
        End If

    End Sub

    Private Sub ReadDetailSpk()
        Dim DT As DataTable = New SAPWorkOrder().ReadRMByWO(cboNomorSpk.SelectedValue, New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP).Tables("View")
        Dim DR As DataRow
        Dim Row As Integer = 0

        Grid.Clear()
        For Each DR In DT.Rows

            If Microsoft.VisualBasic.Left(DR("Kode Item"), 3) <> "302" And
               Microsoft.VisualBasic.Left(DR("Kode Item"), 3) <> "303" And
               Microsoft.VisualBasic.Left(DR("Kode Item"), 3) <> "304" And
               Microsoft.VisualBasic.Left(DR("Kode Item"), 3) <> "305" Then

                If Row = Grid.Rows Then
                    Grid.DataGridView.Rows.Add()
                End If

                Grid.GridValue(_KodeItem, Row) = DR("Kode Item")
                Grid.GridValue(_NamaItem, Row) = DR("Nama Item")
                Grid.GridValue(_Qty, Row) = 0
                Grid.GridValue(_Satuan, Row) = DR("Satuan")

                Row += 1

            End If
        Next
    End Sub

    Private Sub ReadDetailSpkLocal()
        Dim DT As DataTable = New DaftarPemakaianBahan(ActiveSession).ReadDetail(txtNoTransaksi.Text).Tables("View")
        Dim DR As DataRow
        Dim Row As Integer = 0

        Grid.Clear()
        For Each DR In DT.Rows

            If Row = Grid.Rows Then
                Grid.DataGridView.Rows.Add()
            End If

            Grid.GridValue(_KodeItem, Row) = DR("KodeItemRM")
            Grid.GridValue(_NamaItem, Row) = DR("NamaItemRM")
            Grid.GridValue(_Qty, Row) = DR("Qty")
            Grid.GridValue(_Satuan, Row) = DR("Satuan")

            Row += 1
        Next
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles txtNoTransaksi.TextChanged,
        cboKodeUnit.SelectedIndexChanged,
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        cboNomorSpk.SelectedIndexChanged,
        txtKeterangan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeUnit" Then
            FillComboMesin()
            FillNomorSPK()
        End If

        If ObjectName = "cboNomorSpk" Then
            If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
                Try
                    Dim WO = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, cboNomorSpk.SelectedValue)

                    txtItemProduksi.Text = WO.NamaItem
                    txtItemProduksi.Tag = WO.KodeItem

                    If cboKodeUnit.SelectedValue = "001" Then
                        Dim KodeMesin As String = New SAPWorkOrder().FindMesin(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, cboNomorSpk.SelectedValue).KodeMesin
                        cboKodeMesin.SelectedValue = New DaftarMesin(ActiveSession).FindBySAP(KodeMesin).KodeMesin
                    End If

                    ReadDetailSpk()
                Catch
                End Try
            Else
                txtItemProduksi.Text = ""
                txtItemProduksi.Tag = ""
                cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1

                Grid.Clear()
            End If
        End If


        SetEnableCommand()
    End Sub

    Private Sub btLookupNomorSpk_Click(sender As Object, e As EventArgs) Handles btLookupNomorSpk.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, txtTglPencatatan.Value.Date}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSpk.SelectedValue = Form.IDLookup
            cboNomorSpk.Focus()
        End If
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        '_SaveMode = enumSaveMode.AddMode

        ''Cek Status SAPStaging
        ''-----------------------------------------------------------------------------------------
        'Dim Status As Integer = New SAPStaging().IsOpen(txtNoTransaksi.Text, SAPStaging.enumTransaction.MaterialIssue)
        'If Status = True Then
        '    Status = 0
        'Else
        '    Status = 1
        'End If

        'If txtNoTransaksi.Text <> "" Then
        '    Dim DaftarPemakaianBahan As New DaftarPemakaianBahan(ActiveSession)
        '    Dim HeaderPemakaianBahan As HeaderPemakaianBahan = DaftarPemakaianBahan.FindHeader(txtNoTransaksi.Text)

        '    If Not IsNothing(HeaderPemakaianBahan) Then
        '        _SaveMode = enumSaveMode.EditMode
        '        _TRX = HeaderPemakaianBahan.TRX
        '        txtNoTransaksi.Enabled = False

        '        txtTglPencatatan.Value = HeaderPemakaianBahan.TglPencatatan
        '        cboKodeUnit.SelectedValue = HeaderPemakaianBahan.KodeUnit
        '        cboKodeGrup.SelectedValue = HeaderPemakaianBahan.KodeGrup
        '        cboKodeMesin.SelectedValue = HeaderPemakaianBahan.KodeMesin
        '        cboNomorSpk.SelectedValue = HeaderPemakaianBahan.NomorWO
        '        txtItemProduksi.Tag = HeaderPemakaianBahan.KodeItemFG
        '        txtItemProduksi.Text = HeaderPemakaianBahan.NamaItemFG
        '        txtKeterangan.Text = HeaderPemakaianBahan.Keterangan

        '        If _SaveMode = enumSaveMode.EditMode Then
        '            Dim DT As DataTable = DaftarPemakaianBahan.ReadDetail(txtNoTransaksi.Text).Tables("View")
        '            Dim DR As DataRow
        '            Dim Row As Integer = 0

        '            Grid.Clear()
        '            For Each DR In DT.Rows
        '                If Row = Grid.Rows Then
        '                    Grid.DataGridView.Rows.Add()
        '                End If

        '                Grid.GridValue(_KodeItem, Row) = DR("KodeItemRM")
        '                Grid.GridValue(_NamaItem, Row) = DR("NamaItemRM")
        '                Grid.GridValue(_Qty, Row) = DR("Qty")
        '                Grid.GridValue(_Satuan, Row) = DR("Satuan")
        '                Grid.GridValue(_Keterangan, Row) = DR("Keterangan")

        '                Row += 1
        '            Next
        '        End If
        '    Else
        '        If _NoTransaksi <> txtNoTransaksi.Text Then
        '            MessageBox.Show("Nomor Transaksi Tidak Dikenal ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            ResetData()
        '            txtNoTransaksi.Focus()
        '        End If
        '    End If
        'End If

        'SetEnableCommand()
    End Sub

    'Private Sub cboNomorSpk_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboNomorSpk.Validating
    '    If cboNomorSpk.SelectedIndex <> cboNomorSpk.Items.Count - 1 Then
    '        Try
    '            Dim WO = New SAPWorkOrder().FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP, cboNomorSpk.SelectedValue)

    '            txtItemProduksi.Text = WO.NamaItem
    '            txtItemProduksi.Tag = WO.KodeItem
    '            KodeLokasi = WO.KodeLokasi

    '            ReadDetailSpk()

    '            cboKodeUnit.Enabled = False
    '        Catch
    '        End Try
    '    Else
    '        cboKodeUnit.Enabled = True

    '        txtItemProduksi.Text = ""
    '        txtItemProduksi.Tag = ""

    '        Grid.Clear()
    '    End If

    '    SetEnableCommand()
    'End Sub

    Private Sub txtKeterangan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKeterangan.Validating
        'Grid.GridCellFocus(_Qty, 0)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTglPencatatan.Value.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'Cek Jika Data Telah Berubah
                If _SaveMode = enumSaveMode.EditMode Then
                    If _TRX <> New DaftarPemakaianBahan(ActiveSession).FindHeader(txtNoTransaksi.Text).TRX Then
                        MessageBox.Show("Data Ini Telah Diubah User Lain ! " + vbCrLf + "Proses Simpan Data Dibatalkan Oleh Sistem ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        IDData = txtNoTransaksi.Text
                        Me.Close()
                        GoTo Jump
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Tanggal " + txtTglPencatatan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarPemakaianBahan As New DaftarPemakaianBahan(ActiveSession)
                    Dim HeaderPemakaianBahan As HeaderPemakaianBahan
                    Dim DetailPemakaianBahan As DetailPemakaianBahan
                    Dim SAPStaging As New SAPStaging

                    Dim KodeUnitSap As String = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

                    'Nomor Transaksi
                    If _SaveMode = enumSaveMode.AddMode Then
                        txtNoTransaksi.Text = DaftarPemakaianBahan.GetNomorTransaksi(Periode)
                    End If

                    'Baca Pemakaian Bahan
                    '---------------------------------------------------------------------------------------------------
                    HeaderPemakaianBahan = DaftarPemakaianBahan.FindHeader(txtNoTransaksi.Text)
                    If Not IsNothing(HeaderPemakaianBahan) Then
                        'Hapus Detail Pemakaian Bahan Internal
                        DaftarPemakaianBahan.DeleteDetail(txtNoTransaksi.Text)

                        'Hapus Detail Staging
                        '(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)
                        'SAPStaging.DeleteTransaction(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)
                    End If

                    'Simpan Header PemakaianBahan
                    '----------------------------------------------------------------------------------------------------
                    HeaderPemakaianBahan = New HeaderPemakaianBahan
                    HeaderPemakaianBahan.NoTransaksi = txtNoTransaksi.Text
                    HeaderPemakaianBahan.TglTransaksi = TglTransaksi.Date
                    HeaderPemakaianBahan.TglPencatatan = txtTglPencatatan.Value
                    HeaderPemakaianBahan.NomorWO = cboNomorSpk.SelectedValue
                    HeaderPemakaianBahan.KodeUnit = cboKodeUnit.SelectedValue
                    HeaderPemakaianBahan.KodeShift = txtKodeShift.Text
                    HeaderPemakaianBahan.KodeGrup = cboKodeGrup.SelectedValue
                    HeaderPemakaianBahan.KodeMesin = cboKodeMesin.SelectedValue
                    HeaderPemakaianBahan.KodeItemFG = txtItemProduksi.Tag
                    HeaderPemakaianBahan.NamaItemFG = txtItemProduksi.Text
                    HeaderPemakaianBahan.Keterangan = txtKeterangan.Text
                    HeaderPemakaianBahan.UserID = ActiveSession.KodeUser

                    If _SaveMode = enumSaveMode.AddMode Then
                        DaftarPemakaianBahan.AddHeader(HeaderPemakaianBahan)
                    Else
                        DaftarPemakaianBahan.EditHeader(HeaderPemakaianBahan)
                    End If

                    '----------------------------------------------------------------------------------------------------

                    'Simpan DetailPemakaianBahan
                    '----------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer = 0
                    Dim Row As Integer = 0

                    For Row = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_KodeItem, Row) <> "" Then

                            'Cek Lokasi Gudang Stock
                            'Dim LokasiStockWO As String = New SAPWorkOrder().FindRMByWO(KodeUnitSap, cboNomorSpk.SelectedValue, Grid.GridValue(_KodeItem, Row)).KodeLokasi
                            'If LokasiStockWO <> KodeLokasi Then
                            '    Me.Cursor = Cursors.Default
                            '    MsgBox("Lokasi Stock Bahan Menurut Work Order Tidak Sesuai...!!! " & vbCrLf & "Hubungi PPIC...!!!")
                            '    Scope.Dispose()
                            '    GoTo Jump
                            'End If

                            'Cek Stock Bahan
                            Dim Stock As Double = New SAPInventory().GetCurrentStock(KodeLokasi, Grid.GridValue(_KodeItem, Row), "")

                            If Stock < Grid.GridValue(_Qty, Row) Then
                                Me.Cursor = Cursors.Default
                                Scope.Dispose()

                                MsgBox("Stock Bahan " & Grid.GridValue(_NamaItem, Row) & " Tidak Mencukupi...!!!")

                                GoTo Jump
                            End If

                        End If
                    Next

                    Dim lReceipt As Boolean = False
                    Dim lIssue As Boolean = False

                    For Row = 0 To Grid.GridLastRow - 1

                        If Grid.GridValue(_KodeItem, Row) <> "" Then

                            'Simpan Transaksi Internal
                            '-----------------------------------------------------------------------------------
                            NoUrut += 1

                            DetailPemakaianBahan = New DetailPemakaianBahan
                            DetailPemakaianBahan.NoTransaksi = txtNoTransaksi.Text
                            DetailPemakaianBahan.NoUrut = NoUrut
                            DetailPemakaianBahan.KodeItemRM = Grid.GridValue(_KodeItem, Row)
                            DetailPemakaianBahan.NamaItemRM = Grid.GridValue(_NamaItem, Row)
                            DetailPemakaianBahan.Qty = Grid.GridValue(_Qty, Row)
                            DetailPemakaianBahan.Satuan = Grid.GridValue(_Satuan, Row)
                            DetailPemakaianBahan.Keterangan = Grid.GridValue(_Keterangan, Row)

                            DaftarPemakaianBahan.AddDetail(DetailPemakaianBahan)

                        End If
                    Next

                    For Row = 0 To Grid.GridLastRow - 1

                        If Grid.GridValue(_KodeItem, Row) <> "" Then

                            'Simpan Transaksi Staging
                            '-----------------------------------------------------------------------------------

                            If Grid.GridValue(_Qty, Row) < 0 Then
                                SAPStaging.PostMaterialReceipt(KodeUnitSap, cboNomorSpk.SelectedValue, TglTransaksi.Date, Grid.GridValue(_KodeItem, Row), Math.Abs(Grid.GridValue(_Qty, Row)), Math.Abs(Grid.GridValue(_Qty, Row)), "", txtNoTransaksi.Text, KodeLokasi)
                            Else
                                SAPStaging.PostMaterialIssue(KodeUnitSap, cboNomorSpk.SelectedValue, TglTransaksi.Date, Grid.GridValue(_KodeItem, Row), Grid.GridValue(_Qty, Row), "", txtNoTransaksi.Text, KodeLokasi)
                            End If

                            If Grid.GridValue(_Qty, Row) < 0 Then
                                lReceipt = True
                            Else
                                lIssue = True
                            End If

                        End If
                    Next

                    'Eksekusi Database STAGING
                    '------------------------------------------------------------------------------------------
                    If lIssue Then
                        SAPStaging.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialIssue)
                    End If
                    If lReceipt Then
                        SAPStaging.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)
                    End If

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    If _SaveMode = enumSaveMode.AddMode Then
                        IDData = txtNoTransaksi.Text
                        ResetData()

                        txtNoTransaksi.Focus()
                    Else
                        IDData = txtNoTransaksi.Text
                        Me.Close()
                    End If

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
        If _SaveMode = enumSaveMode.AddMode Then
            txtNoTransaksi.Text = _NoTransaksi
        End If
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = GetDateTimeServer().ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                txtKodeShift.Text = "3"
                TglTransaksi = DateAdd("D", -1, GetDateTimeServer().Date)
            Else
                txtKodeShift.Text = "1"
                TglTransaksi = GetDateTimeServer().Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                txtKodeShift.Text = "1"
                TglTransaksi = GetDateTimeServer().Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                txtKodeShift.Text = "2"
                TglTransaksi = GetDateTimeServer().Date
            Else
                txtKodeShift.Text = "3"
                TglTransaksi = GetDateTimeServer().Date
            End If
        End If

        'Me.Text = Jam
    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtTglPencatatan.Text = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1, False, True) And _
                         If(txtItemProduksi.Text = "", False, True) And _
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
        SetEnableCommand()
    End Sub

    Private Sub Grid_GridChange() Handles Grid.GridChange
        SetEnableCommand()
    End Sub
#End Region
End Class