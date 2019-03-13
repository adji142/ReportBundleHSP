Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports Enerzie.EPSGridControls.EPSTableEdit

Imports HSPProduction.HSP.Data

Public Class frmTransformBallToPcs

    Private TglTransaksi As Date
    Private TglPencatatan As Date
    Private KodeGrup As String

    Private SAPStaging As SAPStaging = Nothing

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(SAPStagingObject As Object)
        Me.New()
        SAPStaging = SAPStagingObject
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Lokasi Asal
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

    End Sub

    'Form Load
    Private Sub frmTransformBallToPcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        ResetData()

    End Sub

    'Form Shown
    Private Sub frmHasilProduksiLoom_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not New SAPDBConnection().OpenConnectionSDK() Then
            MessageBox.Show("Koneksi Ke Server SAP Gagal !", "Peingatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            If Not ActiveSession.KodeUser.ToUpper = "SPVS" Then
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    'Reset data
    Private Sub ResetData()

        Dim KodeLokasi As String = GetSetting(enumFormID.frmPackingKarung, enumSetting.settingKodeLokasi)

        If KodeLokasi <> "" Then
            cboKodeLokasi.SelectedValue = KodeLokasi
        Else
            cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
        End If

        txtKodeProduksi.Text = ""

        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtPcs.Value = 0
        txtBerat.Value = 0
        lblStatus.Text = "-"
        txtPcsAktual.Value = 0
        txtKeterangan.Text = ""

        SetEnableCommand()

    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        txtKodeProduksi.Text = txtKodeProduksi.Text.Trim
        If txtKodeProduksi.Text <> "" Then

            Dim DaftarStockBall As New DaftarStockPacking(ActiveSession)
            Dim StockBall = DaftarStockBall.Find(txtKodeProduksi.Text)

            If IsNothing(StockBall) Then
                MessageBox.Show("Kode Produksi Tidak Valid !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ResetData()
                txtKodeProduksi.Focus()
            Else
                If StockBall.KodeLokasi = cboKodeLokasi.SelectedValue Then
                    txtKodeProduksi.Tag = StockBall.NoTransaksi
                    txtKodeItem.Text = StockBall.KodeItem
                    txtNamaItem.Text = StockBall.NamaItem
                    txtPcs.Value = StockBall.Pcs
                    txtPcsAktual.Value = txtPcs.Value
                    txtBerat.Value = StockBall.BeratNetto
                    lblStatus.Text = If(StockBall.StatusQc = 1, "OK", _
                                        If(StockBall.StatusQc = 2, "NON OK", _
                                           If(StockBall.StatusQc = 3, "OVER", _
                                              If(StockBall.StatusQc = 4, "UNDER", ""))))

                    Else
                        MessageBox.Show("Lokasi Tidak Valid !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ResetData()
                        txtKodeProduksi.Focus()
                    End If
                End If

        End If

        SetEnableCommand()
    End Sub

    'Jika Data Berubah
    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeLokasi.SelectedIndexChanged,
        txtKodeProduksi.TextChanged,
        txtPcsAktual.TextChanged,
        txtKeterangan.TextChanged

        lblNamaLokasi.Text = cboKodeLokasi.Text.ToUpper

        SetEnableCommand()
    End Sub

    'Timer Shift Produksi
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick

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

    'Simpan Data
    '    Private Sub ProsesData(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
    '        Dim Periode As String = GetPeriod(Now)
    '        Dim NoTransaksi As String = ""

    '        Dim TXTglTransaksi = TglTransaksi.Date
    '        Dim TXTglPencatatan = TglPencatatan

    '        Dim KodeItemPcs As String
    '        Dim NamaItemPcs As String

    '        SaveXASetting("TBKodeLokasi", cboKodeLokasi.SelectedValue)

    '        sender.Focus()
    '        DirectCast(sender, Button).Enabled = False

    '        Select Case DirectCast(sender, Button).Name
    '            Case "btSave"

    '                'Konfirmasi Transaksi
    '                Dim F As New frmKonfirmasiTransaksi
    '                F.ShowDialog()
    '                If F.Result = "" Then
    '                    GoTo Jump
    '                End If

    '                btSave.Enabled = False
    '                Me.Cursor = Cursors.WaitCursor
    '                Dim Scope As New TransactionScope

    '                Dim DaftarTransformBallToPcs As New DaftarTransformBallToPcs(ActiveSession)
    '                Dim DaftarStockBall As New DaftarStockBall(ActiveSession)

    '                '*******************************************************************************************************
    '                'Simpan Ke Database Internal
    '                '*******************************************************************************************************
    '                Try
    '                    Dim HeaderTransformBallToPcs As HeaderTransformBallToPcs

    '                    'Nomor Transaksi
    '                    NoTransaksi = DaftarTransformBallToPcs.GetNomorTransaksi(Periode)

    '                    'Simpan HeaderTransformBallToPcs
    '                    '----------------------------------------------------------------------------------------------------
    '                    HeaderTransformBallToPcs = New HeaderTransformBallToPcs
    '                    HeaderTransformBallToPcs.NoTransaksi = NoTransaksi
    '                    HeaderTransformBallToPcs.TglTransaksi = TXTglTransaksi
    '                    HeaderTransformBallToPcs.TglPencatatan = TXTglPencatatan
    '                    HeaderTransformBallToPcs.KodeShift = lblKodeShift.Text.Trim()
    '                    HeaderTransformBallToPcs.KodeLokasi = cboKodeLokasi.SelectedValue
    '                    HeaderTransformBallToPcs.Keterangan = txtKeterangan.Text
    '                    HeaderTransformBallToPcs.UserID = ActiveSession.KodeUser

    '                    DaftarTransformBallToPcs.AddHeader(HeaderTransformBallToPcs)
    '                    '----------------------------------------------------------------------------------------------------

    '                    'Simpan DetailTransformBallToPcs
    '                    '----------------------------------------------------------------------------------------------------
    '                    Dim DetailTransformBallToPcs As DetailTransformBallToPcs = Nothing

    '                    Dim DataPcs = New DaftarProduksiBallPress(ActiveSession).FindBahanProduksi(txtKodeProduksi.Tag)
    '                    KodeItemPcs = DataPcs.KodeItemRM
    '                    NamaItemPcs = DataPcs.NamaItemRM

    '                    '------------------------------------------------------------------------------------------------
    '                    DetailTransformBallToPcs = New DetailTransformBallToPcs
    '                    DetailTransformBallToPcs.NoTransaksi = NoTransaksi
    '                    DetailTransformBallToPcs.NoUrut = 0
    '                    DetailTransformBallToPcs.KodeItemBall = txtKodeItem.Text
    '                    DetailTransformBallToPcs.NamaItemBall = txtNamaItem.Text
    '                    DetailTransformBallToPcs.KodeProduksiBall = txtKodeProduksi.Text
    '                    DetailTransformBallToPcs.QtyBall = txtPcs.Value
    '                    DetailTransformBallToPcs.KodeItemPcs = KodeItemPcs
    '                    DetailTransformBallToPcs.NamaItemPcs = NamaItemPcs
    '                    DetailTransformBallToPcs.QtyPcs = txtPcsAktual.Value

    '                    DaftarTransformBallToPcs.AddDetail(DetailTransformBallToPcs)
    '                    '------------------------------------------------------------------------------------------------

    '                    '----------------------------------------------------------------------------------------------------
    '                    Scope.Complete()
    '                    Scope.Dispose()
    '                    '----------------------------------------------------------------------------------------------------

    '                Catch ex As Exception
    '                    Me.Cursor = Cursors.Default
    '                    Scope.Dispose()
    '                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
    '                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '                    GoTo Jump
    '                End Try
    '                '*******************************************************************************************************

    '                '*******************************************************************************************************
    '                'Simpan Ke Database SAP
    '                '*******************************************************************************************************
    '                Try


    '                    Dim ITData As STGTransform = Nothing

    '                    'Simpan Staging Bahan Transform
    '                    '------------------------------------------------------------------------------------------------
    '                    ITData = New STGTransform
    '                    ITData.NoTransaksi = NoTransaksi
    '                    ITData.TglTransaksi = TXTglTransaksi
    '                    ITData.NoUrut = 0
    '                    ITData.KodeItem = txtKodeItem.Text
    '                    ITData.NamaItem = txtNamaItem.Text
    '                    ITData.Batch = "Y"
    '                    ITData.Qty = txtPcs.Value
    '                    ITData.KodeProduksi = txtKodeProduksi.Text
    '                    ITData.QtyTimbang = txtBerat.Value
    '                    ITData.KodeLokasi = cboKodeLokasi.SelectedValue
    '                    ITData.Keterangan = "BAHAN TRANSFORM BALL TO PCS"

    '                    If Not SAPStaging.PostTransform(2, ITData) Then
    '                        SAPStaging.Remove(TRSProduction.SAPStaging.enumSAPTransaction.Transform, NoTransaksi)
    '                        DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
    '                        DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
    '                        Me.Cursor = Cursors.Default
    '                        MessageBox.Show("Posting Data Ke Database Staging SAP Gagal Dilakukan.." + vbCrLf + "Transaksi Tidak Tersimpan, Ulangi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '                        GoTo Jump
    '                    End If
    '                    '----------------------------------------------------------------------------------------------------

    '                    'Simpan Staging Hasil Transform
    '                    '----------------------------------------------------------------------------------------------------                    
    '                    ITData = New STGTransform
    '                    ITData.NoTransaksi = NoTransaksi
    '                    ITData.TglTransaksi = TXTglTransaksi
    '                    ITData.NoUrut = 0
    '                    ITData.KodeItem = KodeItemPcs
    '                    ITData.NamaItem = NamaItemPcs
    '                    ITData.Batch = "N"
    '                    ITData.Qty = txtPcsAktual.Value
    '                    ITData.KodeProduksi = ""
    '                    ITData.KodeLokasi = cboKodeLokasi.SelectedValue
    '                    ITData.Keterangan = "HASIL TRANSFORM BALL TO PCS"

    '                    If Not SAPStaging.PostTransform(1, ITData) Then
    '                        SAPStaging.Remove(TRSProduction.SAPStaging.enumSAPTransaction.Transform, NoTransaksi)
    '                        DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
    '                        DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
    '                        Me.Cursor = Cursors.Default
    '                        MessageBox.Show("Posting Data Ke Database Staging SAP Gagal Dilakukan.." + vbCrLf + "Transaksi Tidak Tersimpan, Ulangi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '                        GoTo Jump
    '                    End If
    '                    '----------------------------------------------------------------------------------------------------


    '                    'Posting Staging -> Database SAP
    '                    '----------------------------------------------------------------------------------------------------                    
    '                    Dim STX = SAPStaging.Execute(TRSProduction.SAPStaging.enumSAPTransaction.Transform, NoTransaksi)
    '                    If STX.ResultStatus.Trim.ToUpper = "FAILED" Then
    '                        SAPStaging.Remove(TRSProduction.SAPStaging.enumSAPTransaction.Transform, NoTransaksi)
    '                        DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
    '                        DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
    '                        Me.Cursor = Cursors.Default
    '                        MessageBox.Show("Eksekusi Data Staging Ke Database SAP Gagal Dilakukan.." + vbCrLf + "Transaksi Tidak Tersimpan, Ulangi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '                        GoTo Jump
    '                    Else
    '                        Me.Cursor = Cursors.Default
    '                        MessageBox.Show("Transaksi Berhasil Diproses !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End If
    '                    '----------------------------------------------------------------------------------------------------

    '                    Me.Cursor = Cursors.Default

    '                    ResetData()
    '                    txtKodeProduksi.Focus()

    '                    GoTo Jump

    '                Catch ex As Exception
    '                    SAPStaging.Remove(TRSProduction.SAPStaging.enumSAPTransaction.Transform, NoTransaksi)
    '                    DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
    '                    DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
    '                    Me.Cursor = Cursors.Default

    '                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
    '                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '                    GoTo Jump
    '                End Try
    '                '*******************************************************************************************************

    '            Case "btClose"
    '                Me.Close()
    '        End Select

    'Jump:

    '    End Sub

    'Enable / Disable Button
    Private Sub SetEnableCommand()
        btSave.Enabled = txtKodeProduksi.Text.Trim <> "" And
                         cboKodeLokasi.SelectedIndex <> cboKodeLokasi.Items.Count - 1 And
                         txtKeterangan.Text.Trim.Length >= 10
    End Sub

End Class