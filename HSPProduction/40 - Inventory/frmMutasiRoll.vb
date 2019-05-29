Imports HSPProduction.HSP.Data
Imports System.Transactions
Imports Microsoft.Win32

Public Class frmMutasiRoll
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

    Private Enum enumStatusQc
        None = 1
        OK = 2
        NonOK = 3
        Over = 4
        Under = 5
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
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboKodeLokasiAsal.DataSource = DS.Tables("View")
        cboKodeLokasiAsal.DisplayMember = "Nama Lokasi"
        cboKodeLokasiAsal.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboKodeLokasiTujuan.DataSource = DS.Tables("View")
        cboKodeLokasiTujuan.DisplayMember = "Nama Lokasi"
        cboKodeLokasiTujuan.ValueMember = "Kode"

    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTransaksi.Enabled = True

        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi
        txtTglTransaksi.Text = ""
        cboKodeLokasiAsal.SelectedIndex = -1
        cboKodeLokasiTujuan.SelectedIndex = -1
        txtKeterangan.Text = ""
        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtQtyUnit.Text = ""
        txtQtyTimbang.Text = ""
        txtPeruntukan.Text = ""
        txtStatus.Text = ""

        Dim KodeLokasi As String
        KodeLokasi = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
        cboKodeLokasiAsal.SelectedValue = KodeLokasi

        Dim RegKey As RegistryKey

        RegKey = Registry.CurrentUser.OpenSubKey("Software", True)
        RegKey.CreateSubKey("Loom")
        RegKey.Close()

        RegKey = Registry.CurrentUser.OpenSubKey("Software\Loom", True)
        cboKodeLokasiTujuan.SelectedValue = RegKey.GetValue("KodeUnitTujuan", "")
        RegKey.Close()

        If _ID <> "" Then
            txtNoTransaksi.Text = _ID
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmMutasiRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
            Dim StockRoll As StockRoll = DaftarStockRoll.Find(txtKodeProduksi.Text, cboKodeLokasiAsal.SelectedValue)
            If Not IsNothing(StockRoll) Then
                txtKodeItem.Text = StockRoll.KodeItem
                txtNamaItem.Text = StockRoll.NamaItem
                txtQtyUnit.Text = StockRoll.Jumlah2
                txtQtyTimbang.Text = StockRoll.Jumlah3
                txtPeruntukan.Text = StockRoll.Keterangan
                txtStatus.Text = If(StockRoll.StatusQc = "0", "NONE", _
                                    If(StockRoll.StatusQc = "1", "OK", _
                                       If(StockRoll.StatusQc = "2", "NON OK", _
                                          If(StockRoll.StatusQc = "3", "OVER", _
                                             If(StockRoll.StatusQc = "4", "UNDER", "-")))))
                txtStatus.Tag = StockRoll.StatusQc
                lblDisposisi.Tag = StockRoll.StatusDisposisi
            Else
                MsgBox("Kode Produksi Tidak Valid...!!!")

                txtKodeProduksi.Text = ""
                txtKodeProduksi.Focus()
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btDefault_Click(sender As Object, e As EventArgs) Handles btDefault.Click
        Dim RegKey As RegistryKey

        RegKey = Registry.CurrentUser.OpenSubKey("Software", True)
        RegKey.CreateSubKey("Loom")
        RegKey.Close()

        RegKey = Registry.CurrentUser.OpenSubKey("Software\Loom", True)
        RegKey.SetValue("KodeUnitTujuan", cboKodeLokasiTujuan.SelectedValue)
        RegKey.Close()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                                txtNoTransaksi.TextChanged,
                                                                txtTglTransaksi.ValueChanged,
                                                                cboKodeLokasiAsal.SelectedIndexChanged,
                                                                cboKodeLokasiTujuan.SelectedIndexChanged,
                                                                txtKeterangan.TextChanged,
                                                                txtKodeProduksi.TextChanged,
                                                                txtKodeItem.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTglTransaksi.Value.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarMutasiRoll As New DaftarMutasiRoll(ActiveSession)
                    Dim MutasiRoll As New MutasiRoll

                    'Nomor Transaksi
                    If _SaveMode = enumSaveMode.AddMode Then
                        txtNoTransaksi.Text = DaftarMutasiRoll.GetNomorTransaksi(Periode)
                    End If

                    'Simpan Mutasi Roll
                    '----------------------------------------------------------------------------------------------------
                    MutasiRoll.NoTransaksi = txtNoTransaksi.Text
                    MutasiRoll.TglTransaksi = txtTglTransaksi.Value.Date
                    MutasiRoll.LokasiAsal = cboKodeLokasiAsal.SelectedValue
                    MutasiRoll.LokasiTujuan = cboKodeLokasiTujuan.SelectedValue
                    MutasiRoll.KodeProduksi = txtKodeProduksi.Text
                    MutasiRoll.KodeItem = txtKodeItem.Text
                    MutasiRoll.NamaItem = txtNamaItem.Text
                    MutasiRoll.UserID = ActiveSession.KodeUser

                    If _SaveMode = enumSaveMode.AddMode Then
                        DaftarMutasiRoll.Add(MutasiRoll)
                    End If

                    'Insert StockRoll
                    '----------------------------------------------------------------------------------------------------
                    Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
                    Dim StockRoll = DaftarStockRoll.Find(txtKodeProduksi.Text, cboKodeLokasiAsal.SelectedValue)
                    If Not IsNothing(StockRoll) Then
                        DaftarStockRoll.UpdateStatus(txtKodeProduksi.Text)

                        StockRoll.NoTransaksi = txtNoTransaksi.Text
                        StockRoll.KodeLokasi = cboKodeLokasiTujuan.SelectedValue
                        StockRoll.StatusStock = 1
                        DaftarStockRoll.Add(StockRoll)
                    End If

                    'Insert SAPInventory Inventory Transfer
                    '----------------------------------------------------------------------------------------------------
                    Dim SAPStaging As New SAPStaging
                    SAPStaging.PostInventoryTransfer(txtTglTransaksi.Value.Date, txtKodeItem.Text, txtNamaItem.Text, txtQtyUnit.Value, txtKodeProduksi.Text, txtNoTransaksi.Text, cboKodeLokasiAsal.SelectedValue, cboKodeLokasiTujuan.SelectedValue)

                    'Eksekusi SAPStaging Inventory Transfer
                    '----------------------------------------------------------------------------------------------------
                    SAPStaging.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.InventoryTransfer)

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    If _SaveMode = enumSaveMode.AddMode Then
                        IDData = txtNoTransaksi.Text
                        ResetData()

                        txtNoTransaksi.Focus()
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

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(cboKodeLokasiAsal.SelectedIndex = -1, False, True) And _
                         If(cboKodeLokasiTujuan.SelectedIndex = -1, False, True) And _
                         If(txtKodeProduksi.Text = "", False, True) And _
                         If(txtKodeItem.Text = "", False, True) And _
                         If(txtStatus.Tag = 1 Or lblDisposisi.Tag = 1, True, False)
    End Sub

    Private Sub btLookupKodeLokasiAsal_Click(sender As Object, e As EventArgs) Handles btLookupKodeLokasiAsal.Click

    End Sub

    Private Sub btLookupKodeLokasiTujuan_Click(sender As Object, e As EventArgs) Handles btLookupKodeLokasiTujuan.Click

    End Sub
End Class