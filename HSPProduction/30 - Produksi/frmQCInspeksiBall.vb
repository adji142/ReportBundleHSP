Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmQCInspeksiBall
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

        FillComboStatusQC()

    End Sub

    Private Sub FillComboStatusQC()
        Dim DaftarQCStatus As New DaftarQCStatus(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarQCStatus.Read("%", cboKodeUnit.SelectedValue)
        cboKodeStatus.DataSource = DS.Tables("View")
        cboKodeStatus.DisplayMember = "Keterangan"
        cboKodeStatus.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Keterangan") = "-"

        cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1

    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtKodeProduksi.Enabled = True

        cboStatusQCNew.SelectedIndex = -1
        cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
        cboKodeStatus.Enabled = False
        btLookupKodeStatus.Enabled = False

        If _ID <> "" Then
            txtKodeProduksi.Text = _ID
            txtKodeProduksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmQCInspeksiBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            cboStatusQCNew.SelectedIndexChanged,
                            cboKodeStatus.SelectedValueChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboStatusQCNew" Then
            Select Case cboStatusQCNew.SelectedIndex + 1
                Case 1
                    cboKodeStatus.Enabled = False
                    btLookupKodeStatus.Enabled = False
                    cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
                Case 2
                    cboKodeStatus.Enabled = True
                    btLookupKodeStatus.Enabled = True
                    cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
                Case 3
                    cboKodeStatus.Enabled = False
                    btLookupKodeStatus.Enabled = False
                    cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
                Case 4
                    cboKodeStatus.Enabled = False
                    btLookupKodeStatus.Enabled = False
                    cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1
            End Select
        End If

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockBall As New DaftarStockPacking(ActiveSession)
            Dim StockBall As StockPacking = DaftarStockBall.Find(txtKodeProduksi.Text)

            If Not IsNothing(StockBall) Then
                _SaveMode = enumSaveMode.EditMode
                txtKodeProduksi.Enabled = False

                txtKodeItem.Text = StockBall.KodeItem
                txtNamaItem.Text = StockBall.NamaItem

                cboKodeUnit.SelectedValue = StockBall.KodeUnit
                cboKodeLokasi.SelectedValue = StockBall.KodeLokasi
                txtBeratBall.Text = StockBall.BeratNetto
                txtPcsBall.Text = StockBall.Pcs
                cboStatusQCOld.SelectedIndex = StockBall.StatusQc

                FillComboStatusQC()
            Else
                MessageBox.Show("Kode Produksi Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ResetData()
                txtKodeProduksi.Focus()
            End If
        End If

        SetEnableCommand()

    End Sub

    'Cek Jika Ditekan F10
    Private Sub cboKodeStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeStatus.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeStatus.PerformClick()
        End If
    End Sub

    'Lookup
    Private Sub btLookupKodeStatus_Click(sender As Object, e As EventArgs) Handles btLookupKodeStatus.Click
        Dim DaftarQCStatus As IDataLookup = New DaftarQCStatus(ActiveSession)

        Dim Parameter() As String = {cboKodeUnit.SelectedValue}

        Dim Form As New frmLookup(DaftarQCStatus, Parameter)
        Form.Text = "Lookup Daftar Status"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeStatus.SelectedValue = Form.IDLookup
            cboKodeStatus.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub
    
    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                'Konfirmasi Transaksi
                If MessageBox.Show("Proses Perubahan Data Status QC ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try

                    'Simpan Data Update Status
                    Dim DaftarQCUpdateStatusBall As New DaftarQCUpdateStatusBall(ActiveSession)
                    Dim QCUpdateStatusBall As QCUpdateStatusBall

                    QCUpdateStatusBall = New QCUpdateStatusBall
                    QCUpdateStatusBall.TglUpdate = Now.Date
                    QCUpdateStatusBall.KodeProduksi = txtKodeProduksi.Text
                    QCUpdateStatusBall.StatusQcLama = cboStatusQCOld.SelectedIndex
                    QCUpdateStatusBall.StatusQcBaru = cboStatusQCNew.SelectedIndex + 1
                    QCUpdateStatusBall.KodeStatus = cboKodeStatus.SelectedValue
                    QCUpdateStatusBall.KodeDisposisi = ""
                    QCUpdateStatusBall.UserID = ActiveSession.KodeUser
                    DaftarQCUpdateStatusBall.Add(QCUpdateStatusBall)

                    'Update Data Status QC
                    Dim DaftarStockBall As New DaftarStockPacking(ActiveSession)
                    DaftarStockBall.UpdateQCInspeksi(txtKodeProduksi.Text, _
                                                     cboStatusQCNew.SelectedIndex + 1, _
                                                     cboKodeStatus.SelectedValue)

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
        btSave.Enabled = If(txtKodeProduksi.Text = "", False, True) And _
                         If(cboStatusQCNew.SelectedIndex = -1, False, True) And _
                         If(cboKodeStatus.Enabled, If(cboKodeStatus.SelectedIndex = cboKodeStatus.Items.Count - 1, False, True), True)
    End Sub

End Class