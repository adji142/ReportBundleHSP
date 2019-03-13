Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmPembatalanPackingCementBag
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    Private Sub FillCombo()
        'Unit Produksi
        '------------------------------------------------------------------------------------------
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        'Lokasi Produksi
        '------------------------------------------------------------------------------------------
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtKodeProduksi.Enabled = True

        If _ID <> "" Then
            txtKodeProduksi.Text = _ID
            txtKodeProduksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmPembatalanPackingKarung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged
        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockBall As New DaftarStockPacking(ActiveSession)
            Dim StockBall As StockPacking = DaftarStockBall.Find(txtKodeProduksi.Text, True)

            If Not IsNothing(StockBall) Then
                _SaveMode = enumSaveMode.EditMode

                txtNoTransaksi.Text = StockBall.NoTransaksi
                txtKodeProduksi.Text = StockBall.KodeProduksi
                txtNomorWO.Text = StockBall.NomorWO
                txtTglProduksi.Text = StockBall.TglTimbang.ToString("dd/MM/yyyy hh:mm:ss")
                txtKodeItem.Text = StockBall.KodeItem
                txtNamaItem.Text = StockBall.NamaItem

                cboKodeUnit.SelectedValue = StockBall.KodeUnit
                cboKodeLokasi.SelectedValue = StockBall.KodeLokasi

                txtBeratBall.Value = StockBall.BeratNetto
                txtPcsBall.Value = StockBall.Pcs

                cboStatusQCOld.SelectedIndex = StockBall.StatusQc

                Dim _PanjangPotong As Long
                Dim _Lebar As Long
                Dim _Denier As Long
                Dim _MeshLusi As Long
                Dim _MeshPakan As Long

                Dim WO As New SAPWorkOrder
                Dim WOItem = WO.FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(StockBall.KodeUnit).KodeUnitSAP, StockBall.NomorWO)
                If Not IsNothing(WOItem) Then
                    _PanjangPotong = WOItem.PanjangPotongCutting
                    _Lebar = WOItem.Lebar
                    _Denier = WOItem.Denier
                    _MeshLusi = WOItem.MeshLusi
                    _MeshPakan = WOItem.MeshPakan

                    txtBeratStandar.Value = (WOItem.BeratStandar / 1000) * StockBall.Pcs
                    lblSpesifikasi.Text = "L" & _Lebar & " P" & _PanjangPotong & " D" & _Denier & " M" & _MeshPakan & "X" & _MeshLusi

                Else
                    MessageBox.Show("Proses Pembatalan Tidak Dapat Dilakukan. Pastikan Nomor WO Masih Dalam Kondisi Aktif...!" + vbCrLf +
                                    "Hubungi PPIC.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()
                End If

            Else
                'MessageBox.Show("Kode Produksi Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'ResetData()
                'txtKodeProduksi.Focus()
            End If
        End If

        SetEnableCommand()

    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

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

                    Dim DaftarPembatalanProduksi As New DaftarPembatalanProduksi(ActiveSession)
                    Dim PembatalanProduksi As PembatalanProduksi

                    Dim ProduksiPackingPcs = New DaftarProduksiPackingPcs(ActiveSession).Find(txtNoTransaksi.Text)

                    'Simpan Data Transaksi
                    PembatalanProduksi = New PembatalanProduksi

                    PembatalanProduksi.TglPembatalan = Now
                    PembatalanProduksi.IDProduksi = 101
                    PembatalanProduksi.NoTransaksi = ProduksiPackingPcs.NoTransaksi
                    PembatalanProduksi.KodeProduksi = ProduksiPackingPcs.FGKodeProduksi
                    PembatalanProduksi.KodeUnit = ProduksiPackingPcs.KodeUnit
                    PembatalanProduksi.KodeLokasi = ProduksiPackingPcs.FGKodeLokasi
                    PembatalanProduksi.Keterangan = txtKeterangan.Text
                    PembatalanProduksi.UserID = ActiveSession.KodeUser
                    DaftarPembatalanProduksi.Add(PembatalanProduksi)

                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging
                    Dim KodeUnitSAP As String = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

                    '--------------------------------------------------------------------------------------------------
                    'Pembatalan Pemakaian Bahan Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostMaterialReceipt(KodeUnitSAP,
                                                     ProduksiPackingPcs.NomorWO,
                                                     PembatalanProduksi.TglPembatalan.Date,
                                                     ProduksiPackingPcs.RMKodeItem,
                                                     ProduksiPackingPcs.RMPemakaianPcs,
                                                     0,
                                                     "",
                                                     ProduksiPackingPcs.NoTransaksi,
                                                     cboKodeLokasi.SelectedValue)

                    'Eksekusi Data Staging
                    SAPStaging.Execute(ProduksiPackingPcs.NoTransaksi, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)

                    '--------------------------------------------------------------------------------------------------
                    'Pembatalan Hasil Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostFinishedGoodIssue(KodeUnitSAP,
                                                       ProduksiPackingPcs.NomorWO,
                                                       PembatalanProduksi.TglPembatalan.Date,
                                                       ProduksiPackingPcs.FGKodeItem,
                                                       ProduksiPackingPcs.FGPcs,
                                                       ProduksiPackingPcs.FGBeratNetto,
                                                       ProduksiPackingPcs.FGKodeProduksi,
                                                       "",
                                                       ProduksiPackingPcs.NoTransaksi,
                                                       cboKodeLokasi.SelectedValue)

                    'Eksekusi Data Staging
                    SAPStaging.Execute(ProduksiPackingPcs.NoTransaksi, HSPProduction.SAPStaging.enumTransaction.FinishedGoodIssue)

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
        btSave.Enabled = If(txtKeterangan.Text.Length < 10, False, True) And
                         If(ActiveSession.Supervisor, True, False)

        lblSupervisor.Visible = Not ActiveSession.Supervisor
    End Sub

End Class