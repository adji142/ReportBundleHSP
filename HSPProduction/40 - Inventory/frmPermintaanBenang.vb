Imports HSPProduction.HSP.Data
Imports System.Transactions
Imports Microsoft.Win32

Public Class frmPermintaanBenang

    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
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
        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

    End Sub

    Private Sub frmPermintaanBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = "Permintaan Benang"
        FillCombo()
        ResetData()
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        Locked.Visible=False

        Dim RegKey As RegistryKey

        RegKey = Registry.CurrentUser.OpenSubKey("Software", True)
        RegKey.CreateSubKey("Loom")
        RegKey.Close()

        RegKey = Registry.CurrentUser.OpenSubKey("Software\Loom", True)
        cboKodeUnit.SelectedValue = RegKey.GetValue("KodeUnit", "")
        RegKey.Close()

        txtNoTransaksi.Enabled = True
        txtNoTransaksi.Text = ""

        txtTglTransaksi.Value = Now.Date
        txtTglPermintaan.Value = Now.Date

        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtJumlahPermintaan.Value = 0

        View.DataSource = Nothing

        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi

        If _ID <> "" Then
            txtNoTransaksi.Text = _ID
            txtNoTransaksi_Validating(Nothing, Nothing)
            _ID = ""
            SendKeys.Send("{TAB}")
        End If

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles txtNoTransaksi.TextChanged,
                                                              cboKodeUnit.SelectedIndexChanged,
                                                              txtNoTransaksi.TextChanged,
                                                              txtTglTransaksi.ValueChanged,
                                                              txtKodeItem.TextChanged,
                                                              txtTglPermintaan.ValueChanged

        btSave.Enabled = False

    End Sub

    Private Sub txtJumlahPermintaan_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahPermintaan.TextChanged
        Kalkulasi()
        SetEnableCommand()
    End Sub

    'Cari Data Item 
    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        If txtKodeItem.Text.Trim() <> "" Then
            txtNamaItem.Text = New SAPWorkOrder().GetRMItemName(txtKodeItem.Text)
            If txtNamaItem.Text.Trim() = "" Then
                MessageBox.Show("Kode Item Tidak Dikenal ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txtKodeItem.Text = ""
                txtKodeItem.Focus()
            End If
        End If
    End Sub

    'Cek Jika Ditekan F10
    Private Sub txtKodeItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeItem.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeItem.PerformClick()
        End If
    End Sub

    'Lookup Item 
    Private Sub btLookupKodeItem_Click_1(sender As Object, e As EventArgs) Handles btLookupKodeItem.Click
        Dim Lookup As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarRMAktif, KodeUnitSAP, txtTglPermintaan.Value.Date}

        Dim Form As New frmLookup(Lookup, Parameter)
        Form.Text = "Lookup Daftar Bahan Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            txtKodeItem.Text = Form.IDLookup
            txtKodeItem_Validating(Nothing, Nothing)
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        Dim DaftarPermintaanBenang As New DaftarPermintaanBenang(ActiveSession)
        Dim HeaderPermintaanBenang As HeaderPermintaanBenang

        _SaveMode = enumSaveMode.AddMode
        Locked.Visible = False

        If txtNoTransaksi.Text <> "" Then
            HeaderPermintaanBenang = DaftarPermintaanBenang.FindHeader(txtNoTransaksi.Text)
            If Not IsNothing(HeaderPermintaanBenang) Then
                _SaveMode = enumSaveMode.EditMode
                txtNoTransaksi.Enabled = False

                'Header Data
                _TRX = HeaderPermintaanBenang.TRX
                txtNoTransaksi.Text = HeaderPermintaanBenang.NoTransaksi
                txtTglTransaksi.Value = HeaderPermintaanBenang.TglTransaksi
                txtTglPermintaan.Value = HeaderPermintaanBenang.TglPermintaan
                cboKodeUnit.SelectedValue = HeaderPermintaanBenang.KodeUnit
                txtKodeItem.Text = HeaderPermintaanBenang.KodeItem
                txtNamaItem.Text = HeaderPermintaanBenang.NamaItem

                txtQtyPS1.Value = HeaderPermintaanBenang.QtyPS1
                txtQtyAS1.Value = HeaderPermintaanBenang.QtyAS1
                txtQtyRS1.Value = HeaderPermintaanBenang.QtyRS1

                txtQtyPS2.Value = HeaderPermintaanBenang.QtyPS2
                txtQtyAS2.Value = HeaderPermintaanBenang.QtyAS2
                txtQtyRS2.Value = HeaderPermintaanBenang.QtyRS2

                txtQtyPS3.Value = HeaderPermintaanBenang.QtyPS3
                txtQtyAS3.Value = HeaderPermintaanBenang.QtyAS3
                txtQtyRS3.Value = HeaderPermintaanBenang.QtyRS3
                txtQtyPTotal.Value = HeaderPermintaanBenang.QtyPS1 + HeaderPermintaanBenang.QtyPS2 + HeaderPermintaanBenang.QtyPS3

                'Detail Data
                'Dim DT As DataTable = DaftarPermintaanBenang.ReadDetail(txtNoTransaksi.Text).Tables("View")
                'View.DataSource = DT

                'Dim Total = Aggregate R As DataRow In DT.Rows
                'Into Sum(Convert.ToDouble(R("Proyeksi")))

                'For Index = 1 To View.ColumnCount - 1
                '    View.Columns(Index).DefaultCellStyle.Format = "#,##0.00"
                '    View.Columns(Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '    View.Columns(Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                'Next

                'txtTotalProyeksi.Value = Total
                txtJumlahPermintaan.Value = HeaderPermintaanBenang.QtyAS1 + HeaderPermintaanBenang.QtyAS2 + HeaderPermintaanBenang.QtyAS3
                Kalkulasi()

                If Math.Abs(HeaderPermintaanBenang.QtyRS1) + Math.Abs(HeaderPermintaanBenang.QtyRS2) + Math.Abs(HeaderPermintaanBenang.QtyRS3) = 0 Then
                    Locked.Visible = False
                Else
                    Locked.Visible = True
                End If

            Else
                If _NoTransaksi <> txtNoTransaksi.Text Then
                    MessageBox.Show("Nomor Transaksi Tidak Dikenal ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ResetData()
                    txtNoTransaksi.Focus()
                End If
            End If

        End If

        SetEnableCommand()
    End Sub

    Private Sub btDaftarWorkOrder_Click(sender As Object, e As EventArgs) Handles btDaftarWorkOrder.Click
        Dim SAP As New SAPWorkOrder

        Dim Total As Double = SAP.ReadRMWorkOrderLoomByItem(txtKodeItem.Text, txtTglPermintaan.Value.Date).Sum(Function(X) X.QtyKebutuhan)
        Dim DataList = SAP.ReadRMWorkOrderLoomByItem(txtKodeItem.Text, txtTglPermintaan.Value.Date)
        Dim RMWO As RMWorkOrder

        Dim RMProyeksiList As New List(Of RMProyeksiLoom)
        Dim RMProyeksi As RMProyeksiLoom

        Dim TotalKebutuhan As Double = 0
        Dim TotalProsentase As Double = 0

        For Each RMWO In DataList
            RMProyeksi = New RMProyeksiLoom
            RMProyeksi.Nomor = RMWO.NomorWO
            RMProyeksi.Proyeksi = RMWO.QtyKebutuhan
            RMProyeksi.Prosentase = (RMWO.QtyKebutuhan / Total) * 100
            RMProyeksi.Kebutuhan = (RMWO.QtyKebutuhan / Total) * txtJumlahPermintaan.Value

            TotalProsentase += RMProyeksi.Prosentase
            TotalKebutuhan += RMProyeksi.Kebutuhan

            RMProyeksiList.Add(RMProyeksi)
        Next

        txtTotalPersen.Value = TotalProsentase
        txtTotalProyeksi.Value = Total
        txtTotalKebutuhan.Value = TotalKebutuhan

        View.DataSource = Nothing
        View.DataSource = RMProyeksiList

        For Index = 1 To View.ColumnCount - 1
            View.Columns(Index).DefaultCellStyle.Format = "#,##0.00"
            View.Columns(Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            View.Columns(Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Next

        Dim ParameterSistem = New DaftarParameterSistem(ActiveSession).GetParameterSistem()
        txtQtyPS1.Value = ParameterSistem.LoomPS1
        txtQtyPS2.Value = ParameterSistem.LoomPS2
        txtQtyPS3.Value = ParameterSistem.LoomPS3
        txtQtyPTotal.Value = ParameterSistem.LoomPS1 + ParameterSistem.LoomPS2 + ParameterSistem.LoomPS3

        txtQtyAS1.Value = If(txtQtyPS1.Value <> 0, (txtJumlahPermintaan.Value * (txtQtyPS1.Value / 100)), 0)
        txtQtyAS2.Value = If(txtQtyPS2.Value <> 0, (txtJumlahPermintaan.Value * (txtQtyPS2.Value / 100)), 0)
        txtQtyAS3.Value = If(txtQtyPS3.Value <> 0, (txtJumlahPermintaan.Value * (txtQtyPS3.Value / 100)), 0)

        SetEnableCommand()
    End Sub

    Private Sub Kalkulasi()
        btDaftarWorkOrder_Click(Nothing, Nothing)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriodFull(txtTglTransaksi.Value.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'Cek Jika Data Telah Berubah
                If _SaveMode = enumSaveMode.EditMode Then
                    If _TRX <> New DaftarPermintaanBenang(ActiveSession).FindHeader(txtNoTransaksi.Text).TRX Then
                        MessageBox.Show("Data Ini Telah Diubah User Lain ! " + vbCrLf + "Proses Simpan Data Dibatalkan Oleh Sistem ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        IDData = txtNoTransaksi.Text
                        Me.Close()
                        GoTo Jump
                    End If
                End If

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Permintaan Benang ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try

                    Dim DaftarPermintaanBenang As New DaftarPermintaanBenang(ActiveSession)
                    Dim HeaderPermintaanBenang As HeaderPermintaanBenang
                    Dim DetailPermintaanBenang As DetailPermintaanBenang

                    If _SaveMode = enumSaveMode.EditMode Then
                        DaftarPermintaanBenang.DeleteDetail(txtNoTransaksi.Text)
                    Else
                        txtNoTransaksi.Text = DaftarPermintaanBenang.GetNomorTransaksi(Periode)
                    End If

                    'Header Data
                    '---------------------------------------------------------------------------------------------------
                    HeaderPermintaanBenang = New HeaderPermintaanBenang
                    HeaderPermintaanBenang.NoTransaksi = txtNoTransaksi.Text
                    HeaderPermintaanBenang.TglTransaksi = txtTglTransaksi.Value.Date
                    HeaderPermintaanBenang.TglPermintaan = txtTglPermintaan.Value.Date
                    HeaderPermintaanBenang.KodeUnit = cboKodeUnit.SelectedValue
                    HeaderPermintaanBenang.KodeItem = txtKodeItem.Text
                    HeaderPermintaanBenang.NamaItem = txtNamaItem.Text
                    HeaderPermintaanBenang.QtyPS1 = txtQtyPS1.Value
                    HeaderPermintaanBenang.QtyAS1 = txtQtyAS1.Value
                    HeaderPermintaanBenang.QtyPS2 = txtQtyPS2.Value
                    HeaderPermintaanBenang.QtyAS2 = txtQtyAS2.Value
                    HeaderPermintaanBenang.QtyPS3 = txtQtyPS3.Value
                    HeaderPermintaanBenang.QtyAS3 = txtQtyAS3.Value
                    HeaderPermintaanBenang.UserID = ActiveSession.KodeUser
                    HeaderPermintaanBenang.KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP
                    If _SaveMode = enumSaveMode.AddMode Then
                        DaftarPermintaanBenang.AddHeader(HeaderPermintaanBenang)
                    Else
                        DaftarPermintaanBenang.EditHeader(HeaderPermintaanBenang)
                    End If
                    Me.Cursor = Cursors.Default

                    'Detail Data
                    '---------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer = 0
                    Dim Row As Integer = 0
                    For Row = 0 To View.Rows.Count - 1

                        'Simpan Transaksi Internal
                        '-----------------------------------------------------------------------------------
                        NoUrut += 1

                        DetailPermintaanBenang = New DetailPermintaanBenang
                        DetailPermintaanBenang.NoTransaksi = txtNoTransaksi.Text
                        DetailPermintaanBenang.NoUrut = NoUrut
                        DetailPermintaanBenang.NomorWO = View.Rows(Row).Cells(0).Value
                        DetailPermintaanBenang.QtyProyeksi = View.Rows(Row).Cells(1).Value
                        
                        DaftarPermintaanBenang.AddDetail(DetailPermintaanBenang)

                    Next

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


    Private Sub SetEnableCommand()

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtTglTransaksi.Text = "", False, True) And _
                         If(cboKodeUnit.Items.Count = 0, False, True) And _
                         If(txtTglTransaksi.Value.Date > txtTglPermintaan.Value.Date, False, True) And _
                         If(txtKodeItem.Text.Trim() = "", False, True) And _
                         If(txtJumlahPermintaan.Value = 0, False, True) And _
                         If(txtTotalKebutuhan.Value = 0, False, True) And _
                         If(View.Rows.Count = 0, False, True) And _
                         Not Locked.Visible

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

        If Locked.Visible Then
            btDaftarWorkOrder.Visible = False
            lblDaftarWorkOrder.Text = "Daftar Work Order"
        Else
            btDaftarWorkOrder.Visible = True
            lblDaftarWorkOrder.Text = ""
        End If

    End Sub

    'Setting Kode Unit
    Private Sub btSettingKodeUnit_Click(sender As Object, e As EventArgs) Handles btSettingKodeUnit.Click
        Dim RegKey As RegistryKey

        RegKey = Registry.CurrentUser.OpenSubKey("Software", True)
        RegKey.CreateSubKey("Loom")
        RegKey.Close()

        RegKey = Registry.CurrentUser.OpenSubKey("Software\Loom", True)
        RegKey.SetValue("KodeUnit", cboKodeUnit.SelectedValue)
        RegKey.Close()
    End Sub
End Class