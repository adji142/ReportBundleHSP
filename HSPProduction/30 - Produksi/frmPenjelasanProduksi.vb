Imports HSPProduction.HSP.Data

Public Class frmPenjelasanProduksi
    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _GroupID As String
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String

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

    Private Sub FillComboUnitProduksi()
        Dim DS As DataSet

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%", _GroupID)
        cboUnitProduksi.DataSource = DS.Tables("View")
        cboUnitProduksi.DisplayMember = "Unit Produksi"
        cboUnitProduksi.ValueMember = "Kode"
    End Sub

    Private Sub FillNomorSPK()
        If cboUnitProduksi.SelectedIndex <> cboUnitProduksi.Items.Count - 1 Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            DS = SAPWorkOrder.ReadFGWorkOrderByUnit(New DaftarUnitProduksi(ActiveSession).Find(cboUnitProduksi.SelectedValue).KodeUnitSAP, txtTanggal.Value.Date)
            cboNomorWO.DataSource = DS.Tables("View")
            cboNomorWO.DisplayMember = "Nomor"
            cboNomorWO.ValueMember = "Nomor"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Nomor") = ""
            Drow("Nomor") = "-"
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Nomor")

            cboNomorWO.DataSource = DS.Tables("View")
            cboNomorWO.DisplayMember = "Nomor"
            cboNomorWO.ValueMember = "Nomor"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Nomor") = ""
            Drow("Nomor") = "-"
        End If

        cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTransaksi.Enabled = True

        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi
        cboUnitProduksi.SelectedValue = _GroupID
        cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtQtyPlan.Text = ""
        txtHasilProduksi.Text = ""
        txtProsentase.Text = ""
        txtKeterangan.Text = ""

        If _ID <> "" Then
            txtNoTransaksi.Text = _ID
            txtNoTransaksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmPenjelasanProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboUnitProduksi()
        FillNomorSPK()

        ResetData()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmPenjelasanProduksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        If txtNoTransaksi.Text <> "" Then
            Dim DaftarPenjelasanProduksi As New DaftarPenjelasanProduksi(ActiveSession)
            Dim PenjelasanProduksi As PenjelasanProduksi = DaftarPenjelasanProduksi.Find(txtNoTransaksi.Text)
            If Not IsNothing(PenjelasanProduksi) Then
                _SaveMode = enumSaveMode.EditMode

                txtNoTransaksi.Enabled = False

                txtTanggal.Value = PenjelasanProduksi.TglTransaksi
                cboUnitProduksi.SelectedValue = PenjelasanProduksi.KodeUnit
                cboNomorWO.SelectedValue = PenjelasanProduksi.NomorWO
                txtKodeItem.Text = PenjelasanProduksi.KodeItem
                txtNamaItem.Text = PenjelasanProduksi.NamaItem
                txtTglMulai.Text = Format(PenjelasanProduksi.TglMulai, "dd/MM/yyyy")
                txtTglSelesai.Text = Format(PenjelasanProduksi.TglSelesai, "dd/MM/yyyy")
                txtQtyPlan.Value = PenjelasanProduksi.QtyPlan
                txtHasilProduksi.Value = PenjelasanProduksi.QtyHasilProduksi
                txtProsentase.Value = PenjelasanProduksi.Prosentase
                txtKeterangan.Text = PenjelasanProduksi.Keterangan
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btLookupNomorWO_Click(sender As Object, e As EventArgs) Handles btLookupNomorWO.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboUnitProduksi.SelectedValue).KodeUnitSAP
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, txtTanggal.Value.Date}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorWO.SelectedValue = Form.IDLookup
            cboNomorWO.Focus()
        End If
    End Sub

    Private Sub cboNomorWO_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNomorWO.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupNomorWO.PerformClick()
        End If
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                                        txtNoTransaksi.TextChanged,
                                                                        txtTanggal.ValueChanged,
                                                                        cboUnitProduksi.SelectedIndexChanged,
                                                                        cboNomorWO.SelectedIndexChanged,
                                                                        txtKeterangan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboNomorWO" Then
            If cboNomorWO.SelectedIndex <> cboNomorWO.Items.Count - 1 Then
                Try
                    Dim SAP As New SAPWorkOrder()
                    Dim Data As DataWorkOrder = SAP.FindFGByWOWithStartDate(New DaftarUnitProduksi(ActiveSession).Find(cboUnitProduksi.SelectedValue).KodeUnitSAP, cboNomorWO.SelectedValue)
                    If Not IsNothing(Data) Then
                        txtKodeItem.Text = Data.KodeItem
                        txtNamaItem.Text = Data.NamaItem
                        txtTglMulai.Text = Format(Data.TglMulai, "dd/MM/yyyy")
                        txtTglSelesai.Text = Format(Data.TglSelesai, "dd/MM/yyyy")
                        txtQtyPlan.Value = Data.QtyPlan
                    End If

                    Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
                    Dim HasilBenang As Double = DaftarStockBenang.FindByNoWO(cboNomorWO.SelectedValue).BeratNetto
                    txtHasilProduksi.Value = HasilBenang
                Catch
                End Try
            Else
                txtKodeItem.Text = ""
                txtNamaItem.Tag = ""
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim PeriodeTransaksi As String = GetPeriod(txtTanggal.Value.Date)

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Hasil Penjelasan Proses Produksi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DaftarPenjelasanProduksi As New DaftarPenjelasanProduksi(ActiveSession)
                Dim PenjelasanProduksi As New PenjelasanProduksi

                If _SaveMode = enumSaveMode.AddMode Then
                    txtNoTransaksi.Text = DaftarPenjelasanProduksi.GetNomorTransaksi(PeriodeTransaksi)
                End If

                'Simpan Transaksi Penjelasan Produksi
                PenjelasanProduksi.NoTransaksi = txtNoTransaksi.Text
                PenjelasanProduksi.TglTransaksi = txtTanggal.Value.Date
                PenjelasanProduksi.KodeUnit = cboUnitProduksi.SelectedValue
                PenjelasanProduksi.NomorWO = cboNomorWO.SelectedValue
                PenjelasanProduksi.KodeItem = txtKodeItem.Text
                PenjelasanProduksi.NamaItem = txtNamaItem.Text
                PenjelasanProduksi.TglMulai = Stod(txtTglMulai.Text)
                PenjelasanProduksi.TglSelesai = Stod(txtTglSelesai.Text)
                PenjelasanProduksi.QtyPlan = txtQtyPlan.Value
                PenjelasanProduksi.QtyHasilProduksi = txtHasilProduksi.Value
                PenjelasanProduksi.Prosentase = txtProsentase.Value
                PenjelasanProduksi.Keterangan = Trim(txtKeterangan.Text)
                PenjelasanProduksi.UserID = ActiveSession.KodeUser

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarPenjelasanProduksi.Add(PenjelasanProduksi)
                    IDData = txtNoTransaksi.Text
                    ResetData()
                    txtNoTransaksi.Focus()
                Else
                    DaftarPenjelasanProduksi.Edit(PenjelasanProduksi)
                    IDData = txtNoTransaksi.Text
                    Me.Close()
                End If

                Me.Cursor = Cursors.Default
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '----------------------------------------------------------------------------------
                Me.Close()
                '----------------------------------------------------------------------------------
        End Select

Jump:
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetEnableCommand()
        'Hitung Prosentase
        Dim Prosentase As Double
        Dim QtyPlan As Double = txtQtyPlan.Value
        Dim QtyHasil As Double = txtHasilProduksi.Value

        If QtyPlan <> 0 And QtyHasil <> 0 Then
            Prosentase = (QtyHasil / QtyPlan) * 100
        End If

        txtProsentase.Value = Prosentase

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(txtTanggal.Text = "", False, True) And _
                         If(cboUnitProduksi.SelectedIndex = -1, False, True) And _
                         If(cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1, False, True) And _
                         If(txtKodeItem.Text = "", False, True) And _
                         If(txtKeterangan.Text = "", False, True) And _
                         If(txtKeterangan.TextLength < 20, False, True)

    End Sub
End Class