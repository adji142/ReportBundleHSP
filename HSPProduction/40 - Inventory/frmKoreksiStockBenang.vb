Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmKoreksiStockBenang
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

        Dim DaftarShift As New DaftarShiftProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarShift.Read("%")
        cboKodeShift.DataSource = DS.Tables("View")
        cboKodeShift.DisplayMember = "Nama Shift"
        cboKodeShift.ValueMember = "Kode"

        Dim DaftarGrup As New DaftarGrupProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarGrup.Read("%")
        cboKodeGrupLama.DataSource = DS.Tables("View")
        cboKodeGrupLama.DisplayMember = "Grup Produksi"
        cboKodeGrupLama.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarGrup.Read("%")
        cboKodeGrupBaru.DataSource = DS.Tables("View")
        cboKodeGrupBaru.DisplayMember = "Grup Produksi"
        cboKodeGrupBaru.ValueMember = "Kode"

        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnitAsal.DataSource = DS.Tables("View")
        cboKodeUnitAsal.DisplayMember = "Unit Produksi"
        cboKodeUnitAsal.ValueMember = "Kode"

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

        DS = New DataSet
        DS = DaftarMesin.Read("%", cboKodeUnitAsal.SelectedValue.ToString)
        cboKodeMesinBaru.DataSource = DS.Tables("View")
        cboKodeMesinBaru.DisplayMember = "Nama Mesin"
        cboKodeMesinBaru.ValueMember = "Kode"
    End Sub

    Private Sub FillComboArea()
        Dim DaftarArea As New DaftarArea(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarArea.Read("%", cboKodeLokasi.SelectedValue.ToString)
        cboKodeArea.DataSource = DS.Tables("View")
        cboKodeArea.DisplayMember = "Nama Area"
        cboKodeArea.ValueMember = "Kode"
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTimbang.Enabled = True

        cboKodeStatusBaru.SelectedIndex = cboKodeStatusBaru.Items.Count - 1

        If _ID <> "" Then
            txtNoTimbang.Text = _ID
            txtNoTimbang_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub txtNoTimbang_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTimbang.Validating
        If txtNoTimbang.Text <> "" Then
            Dim DaftarSB As New DaftarStockBenang(ActiveSession)
            Dim SB As StockBenang = DaftarSB.FindByNoTimbang(txtNoTimbang.Text)
            If Not IsNothing(SB) Then
                txtTglTransaksi.Text = SB.M_TglTransaksi.ToString("dd/MM/yyyy")
                txtTglTimbang.Text = SB.M_TglTimbang.ToString("dd/MM/yyyy HH:mm:ss")
                cboKodeShift.SelectedValue = SB.M_KodeShift
                cboKodeGrupLama.SelectedValue = SB.M_KodeGrup
                txtNomorWO.Text = SB.NomorWO
                txtKodeItem.Text = SB.KodeItem
                txtNamaItem.Text = SB.NamaItem
                cboKodeUnitAsal.SelectedValue = SB.M_KodeUnit
                cboKodeLokasi.SelectedValue = SB.KodeLokasi
                FillComboArea()
                cboKodeArea.SelectedValue = SB.KodeArea
                FillComboMesin()
                cboKodeMesinLama.SelectedValue = SB.M_KodeMesin
                cboKodeStatusLama.SelectedIndex = SB.KodeStatusQC - 1
                txtQtyPacking.Text = SB.Jumlah1
                txtQtyPcs.Text = SB.Jumlah2
                txtBeratBrutto.Text = SB.BeratBrutto
                txtBeratNetto.Text = SB.BeratNetto
                txtKeteranganLama.Text = SB.Keterangan

                cboKodeGrupBaru.SelectedValue = SB.M_KodeGrup
                cboKodeMesinBaru.SelectedValue = SB.M_KodeMesin
                cboKodeStatusBaru.SelectedIndex = SB.KodeStatusQC - 1
                txtKeteranganBaru.Text = SB.Keterangan
            End If
        End If
    End Sub

    Private Sub frmKoreksiStockBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        FillComboMesin()
        FillComboArea()

        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            cboKodeGrupBaru.SelectedIndexChanged,
                            cboKodeMesinBaru.SelectedIndexChanged,
                            cboKodeStatusBaru.SelectedIndexChanged,
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
                    Dim DaftarKoreksiBenang As New DaftarKoreksiBenang(ActiveSession)
                    Dim KoreksiStockBenang As New KoreksiStockBenang

                    _NoTransaksi = DaftarKoreksiBenang.GetNomorTransaksi(Periode)
                    KoreksiStockBenang.NoTransaksi = _NoTransaksi
                    KoreksiStockBenang.TglTransaksi = Now
                    KoreksiStockBenang.NoRef = txtNoTimbang.Text
                    KoreksiStockBenang.KodeGrupLama = cboKodeGrupLama.SelectedValue
                    KoreksiStockBenang.KodeMesinLama = cboKodeMesinLama.SelectedValue
                    KoreksiStockBenang.KodeStatusLama = cboKodeStatusLama.SelectedIndex + 1
                    KoreksiStockBenang.KeteranganLama = txtKeteranganLama.Text
                    KoreksiStockBenang.KodeGrupBaru = cboKodeGrupBaru.SelectedValue
                    KoreksiStockBenang.KodeMesinBaru = cboKodeMesinBaru.SelectedValue
                    KoreksiStockBenang.KodeStatusBaru = cboKodeStatusBaru.SelectedIndex + 1
                    KoreksiStockBenang.KeteranganBaru = txtKeteranganBaru.Text
                    KoreksiStockBenang.AlasanPerubahan = txtAlasanPerubahan.Text
                    KoreksiStockBenang.UserID = ActiveSession.KodeUser

                    DaftarKoreksiBenang.Add(KoreksiStockBenang)
                    
                    IDData = txtNoTimbang.Text

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