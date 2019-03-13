Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmKoreksiStockRoll
    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private Enum enumTransaksi
        HasilProduksi = 1
        InventoryTransfer = 2
    End Enum

    Private Enum enumStock
        Masuk = 1
        Keluar = 0
    End Enum

    'Data Private
    Private _ID As String
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String
    Private _TRX As String = ""

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet

        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnitAsal.DataSource = DS.Tables("View")
        cboKodeUnitAsal.DisplayMember = "Unit Produksi"
        cboKodeUnitAsal.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboUnitPeruntukan.DataSource = DS.Tables("View")
        cboUnitPeruntukan.DisplayMember = "Unit Produksi"
        cboUnitPeruntukan.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboUnitPeruntukanBaru.DataSource = DS.Tables("View")
        cboUnitPeruntukanBaru.DisplayMember = "Unit Produksi"
        cboUnitPeruntukanBaru.ValueMember = "Kode"

        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"
    End Sub

    Private Sub FillComboMesin()
        Dim DaftarMesin As New DaftarMesin(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarMesin.Read("%", cboKodeUnitAsal.SelectedValue.ToString)
        cboKodeMesinLama.DataSource = DS.Tables("View")
        cboKodeMesinLama.DisplayMember = "Nama Mesin"
        cboKodeMesinLama.ValueMember = "Kode"
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTimbang.Enabled = True

        cboUnitPeruntukanBaru.SelectedIndex = -1

        If _ID <> "" Then
            txtKodeProduksi.Text = _ID
            txtKodeProduksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmKoreksiStockBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()


        ResetData()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
            Dim StockRoll As StockRoll = DaftarStockRoll.FindExist(txtKodeProduksi.Text, "LMHP")
            If Not IsNothing(StockRoll) Then
                txtNoTimbang.Text = StockRoll.NoTransaksi
                txtTglTransaksi.Text = StockRoll.TglTransaksi.ToString("dd/MM/yyyy")
                txtTglTimbang.Text = StockRoll.TglTimbang.ToString("dd/MM/yyyy")
                txtNomorWO.Text = StockRoll.NomorWO
                txtKodeItem.Text = StockRoll.KodeItem
                txtNamaItem.Text = StockRoll.NamaItem
                cboKodeUnitAsal.SelectedValue = StockRoll.KodeUnit
                cboKodeLokasi.SelectedValue = StockRoll.KodeLokasi
                cboKodeMesinLama.SelectedValue = StockRoll.KodeMesin
                cboKodeStatusLama.SelectedIndex = StockRoll.StatusQc
                txtQtyPacking.Value = StockRoll.Jumlah1
                txtQtyPcs.Value = StockRoll.PanjangRoll
                txtBeratBrutto.Value = StockRoll.BeratBrutto
                txtBeratNetto.Value = StockRoll.BeratNetto
                cboUnitPeruntukan.SelectedValue = StockRoll.KodeUnitPeruntukan
                txtKeteranganLama.Text = StockRoll.Keterangan

                cboUnitPeruntukanBaru.SelectedValue = StockRoll.KodeUnitPeruntukan
                txtKeteranganBaru.Text = StockRoll.Keterangan

                FillComboMesin()
            End If
        End If
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                cboUnitPeruntukanBaru.SelectedIndexChanged,
                                txtKeteranganBaru.TextChanged,
                                txtAlasanPerubahan.TextChanged
        SetEnableCommand()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(Now.Date)

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------
                'Konfirmasi Transaksi
                If MessageBox.Show("Proses Pembatalan Data Produksi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarKoreksiRoll As New DaftarKoreksiStockRoll(ActiveSession)
                    Dim KoreksiStockRoll As New KoreksiStockRoll

                    _NoTransaksi = DaftarKoreksiRoll.GetNomorTransaksi(Periode)
                    KoreksiStockRoll.NoTransaksi = _NoTransaksi
                    KoreksiStockRoll.TglTransaksi = Now
                    KoreksiStockRoll.NoRef = txtNoTimbang.Text
                    KoreksiStockRoll.KodeProduksi = txtKodeProduksi.Text
                    KoreksiStockRoll.UnitPeruntukanLama = cboUnitPeruntukan.SelectedValue
                    KoreksiStockRoll.KeteranganLama = txtKeteranganLama.Text
                    KoreksiStockRoll.UnitPeruntukanBaru = cboUnitPeruntukanBaru.SelectedValue
                    KoreksiStockRoll.KeteranganBaru = txtKeteranganBaru.Text
                    KoreksiStockRoll.AlasanPerubahan = txtAlasanPerubahan.Text
                    KoreksiStockRoll.UserID = ActiveSession.KodeUser

                    DaftarKoreksiRoll.Add(KoreksiStockRoll)

                    IDData = txtKodeProduksi.Text

                    Me.Cursor = Cursors.Default
                    Scope.Complete()
                    Scope.Dispose()

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
                Me.Close()
        End Select

Jump:
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtAlasanPerubahan.TextLength < 10, False, True) And
                         If(ActiveSession.Supervisor, True, False)

        lblSupervisor.Visible = Not ActiveSession.Supervisor
    End Sub

End Class