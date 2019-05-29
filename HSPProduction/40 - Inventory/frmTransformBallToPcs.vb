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
    Private KodeLokasi As String

    Private Shared oCompany As New SAPbobsCOM.Company

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

    Private Sub frmTransformBallToPcs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        DissconnectToDatabase()
    End Sub

    'Form Load
    Private Sub frmTransformBallToPcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        ResetData()

    End Sub

    'Form Shown
    Private Sub frmHasilProduksiLoom_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not ConnectToDatabase() Then
            MessageBox.Show("Koneksi Ke Server SAP Gagal !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            If Not ActiveSession.KodeUser.ToUpper = "SPVS" Then
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    'Reset data
    Private Sub ResetData()

        KodeLokasi = GetSetting(enumFormID.frmPackingKarung, enumSetting.settingKodeLokasi)

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
    Private Sub ProsesData(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(Now)
        Dim NoTransaksi As String = ""

        Dim TXTglTransaksi = TglTransaksi.Date
        Dim TXTglPencatatan = TglPencatatan

        Dim KodeItemPcs As String
        Dim NamaItemPcs As String

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                Dim Scope As New TransactionScope

                Dim DaftarTransformBallToPcs As New DaftarTransformBallToPcs(ActiveSession)
                Dim Stock As New SAPInventory()

                'Dim DaftarStockBall As New DaftarStockBall(ActiveSession)

                '*******************************************************************************************************
                'Simpan Ke Database Internal
                '*******************************************************************************************************
                Try
                    Dim HeaderTransformBallToPcs As HeaderTransformBallToPcs

                    'Nomor Transaksi
                    NoTransaksi = DaftarTransformBallToPcs.GetNomorTransaksi(Periode)

                    'Simpan HeaderTransformBallToPcs
                    '----------------------------------------------------------------------------------------------------
                    HeaderTransformBallToPcs = New HeaderTransformBallToPcs
                    HeaderTransformBallToPcs.NoTransaksi = NoTransaksi
                    HeaderTransformBallToPcs.TglTransaksi = TXTglTransaksi
                    HeaderTransformBallToPcs.TglPencatatan = TXTglPencatatan
                    HeaderTransformBallToPcs.KodeShift = lblKodeShift.Text.Trim()
                    HeaderTransformBallToPcs.KodeGrup = ""
                    HeaderTransformBallToPcs.KodeLokasi = cboKodeLokasi.SelectedValue
                    HeaderTransformBallToPcs.Keterangan = txtKeterangan.Text
                    HeaderTransformBallToPcs.UserID = ActiveSession.KodeUser

                    DaftarTransformBallToPcs.AddHeader(HeaderTransformBallToPcs)
                    '----------------------------------------------------------------------------------------------------

                    'Simpan DetailTransformBallToPcs
                    '----------------------------------------------------------------------------------------------------
                    Dim DetailTransformBallToPcs As DetailTransformBallToPcs = Nothing

                    Dim DataPcs = New DaftarProduksiPackingPcs(ActiveSession).FindBahanProduksi(txtKodeProduksi.Tag)
                    KodeItemPcs = DataPcs.RMKodeItem
                    NamaItemPcs = DataPcs.RMNamaItem

                    '------------------------------------------------------------------------------------------------
                    DetailTransformBallToPcs = New DetailTransformBallToPcs
                    DetailTransformBallToPcs.NoTransaksi = NoTransaksi
                    DetailTransformBallToPcs.NoUrut = 0
                    DetailTransformBallToPcs.KodeItemBall = txtKodeItem.Text
                    DetailTransformBallToPcs.NamaItemBall = txtNamaItem.Text
                    DetailTransformBallToPcs.KodeProduksiBall = txtKodeProduksi.Text
                    DetailTransformBallToPcs.QtyBall = txtPcs.Value
                    DetailTransformBallToPcs.KodeItemPcs = KodeItemPcs
                    DetailTransformBallToPcs.NamaItemPcs = NamaItemPcs
                    DetailTransformBallToPcs.QtyPcs = txtPcsAktual.Value

                    DaftarTransformBallToPcs.AddDetail(DetailTransformBallToPcs)
                    '------------------------------------------------------------------------------------------------

                    '----------------------------------------------------------------------------------------------------
                    Scope.Complete()
                    Scope.Dispose()
                    '----------------------------------------------------------------------------------------------------

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Internal Error : " + vbCrLf + "Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try
                '*******************************************************************************************************

                '*******************************************************************************************************
                'Simpan Ke Database SAP
                '*******************************************************************************************************
                Try
                    'Good Issue
                    'Cek Stock Batch
                    If Not Stock.GetCurrentStock(cboKodeLokasi.SelectedValue, txtKodeProduksi.Text) Then
                        DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
                        DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
                        Me.Cursor = Cursors.Default

                        MessageBox.Show("SAP Error : " + vbCrLf + "Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                       "Kode Produksi Tidak Valid/ Stock Tidak Ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        GoTo Jump
                    End If

                    Dim SeriesIssue = New DaftarSAPKelompokTransaksi().Find(enumObjectTransaction.GoodsIssue, Year(Now))

                    Dim oGoodsIssue As SAPbobsCOM.Documents
                    oGoodsIssue = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit)

                    'Header
                    '**********************************************************************************************************************************
                    oGoodsIssue.Series = SeriesIssue.KodeKelompok                            'Numbering Series : 19GII
                    oGoodsIssue.DocDate = TXTglTransaksi
                    oGoodsIssue.TaxDate = TXTglTransaksi
                    oGoodsIssue.Comments = "GOOD ISSUE BALL #" & NoTransaksi

                    'Detail
                    '**********************************************************************************************************************************
                    oGoodsIssue.Lines.ItemCode = txtKodeItem.Text
                    oGoodsIssue.Lines.ItemDescription = txtNamaItem.Text
                    oGoodsIssue.Lines.Quantity = txtPcs.Value
                    oGoodsIssue.Lines.WarehouseCode = cboKodeLokasi.SelectedValue

                    oGoodsIssue.Lines.Add()

                    Dim nStatus As Long = oGoodsIssue.Add()
                    Dim nError As Long = 0
                    Dim sError As String = ""

                    If nStatus <> 0 Then
                        oCompany.GetLastError(nError, sError)

                        DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
                        DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
                        Me.Cursor = Cursors.Default

                        MessageBox.Show("SAP Error : Goods Issue " + vbCrLf + "Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                       nError & " : " & sError, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        GoTo Jump
                    End If

                    'Good Receipt
                    Dim SeriesReceipt = New DaftarSAPKelompokTransaksi().Find(enumObjectTransaction.GoodsReceipt, Year(Now))

                    Dim oGoodsReceipt As SAPbobsCOM.Documents
                    oGoodsReceipt = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry)

                    oGoodsReceipt.Series = SeriesReceipt.KodeKelompok                                  'Numbering Series : 19GRI
                    oGoodsReceipt.DocDate = TXTglTransaksi
                    oGoodsReceipt.TaxDate = TXTglTransaksi
                    oGoodsReceipt.Comments = "GOOD RECEIPT/BAHAN BALL #" & NoTransaksi

                    'Detail
                    '**********************************************************************************************************************************
                    oGoodsReceipt.Lines.ItemCode = KodeItemPcs
                    oGoodsReceipt.Lines.ItemDescription = NamaItemPcs
                    oGoodsReceipt.Lines.Quantity = txtPcsAktual.Value
                    oGoodsReceipt.Lines.WarehouseCode = cboKodeLokasi.SelectedValue

                    oGoodsReceipt.Lines.Add()

                    Dim nStatusReceipt As Long = oGoodsReceipt.Add()
                    Dim nErrorReceipt As Long = 0
                    Dim sErrorReceipt As String = ""

                    If nStatusReceipt <> 0 Then
                        oCompany.GetLastError(nErrorReceipt, sErrorReceipt)

                        DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
                        DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
                        Me.Cursor = Cursors.Default

                        MessageBox.Show("SAP Error : Goods Receipt " + vbCrLf + "Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                       nErrorReceipt & " : " & sErrorReceipt, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        GoTo Jump
                    End If

                    Me.Cursor = Cursors.Default

                    ResetData()
                    txtKodeProduksi.Focus()

                    GoTo Jump

                Catch ex As Exception
                    DaftarTransformBallToPcs.DeleteHeader(NoTransaksi)
                    DaftarTransformBallToPcs.DeleteDetail(NoTransaksi)
                    Me.Cursor = Cursors.Default

                    MessageBox.Show("SAP Error : " + vbCrLf + "Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try
                '*******************************************************************************************************

            Case "btClose"
                Me.Close()
        End Select

Jump:

    End Sub

    'Enable / Disable Button
    Private Sub SetEnableCommand()
        btSave.Enabled = txtKodeProduksi.Text.Trim <> "" And
                         cboKodeLokasi.SelectedIndex <> cboKodeLokasi.Items.Count - 1 And
                         txtKeterangan.Text.Trim.Length >= 10
    End Sub

    Private Function ConnectToDatabase() As Boolean
        oCompany.SLDServer = "192.168.1.222:40000"
        oCompany.Server = My.Settings.HanaServer
        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB
        oCompany.CompanyDB = My.Settings.HanaSAPDatabaseName
        MsgBox(IP())
        If IP() = "192.168.1.11" Then
            oCompany.UserName = "RMD"
            oCompany.Password = "1234"
        End If
        If IP() = "192.168.1.208" Then
            oCompany.UserName = "NND"
            oCompany.Password = "1234"
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