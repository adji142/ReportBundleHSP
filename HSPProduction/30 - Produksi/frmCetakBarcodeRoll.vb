Imports HSPProduction.HSP.Data

Public Class frmCetakBarcodeRoll
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _GroupID As String
    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String, ByVal GroupID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
    End Sub

    Private _NoTransaksi As String

    Private Sub FillCombo()
        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "<Pilih Unit Produksi>"

        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtPanjang.Text = ""
        txtBerat.Text = ""
        txtKeterangan.Text = ""

        cboStatus.SelectedIndex = cboStatus.Items.Count - 1

        SetEnableCommand()
    End Sub

    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        Dim SAP As New SAPInventory
        Dim KodeItem As String = SAP.GetItem(txtKodeItem.Text.Trim)
        If KodeItem = "" Then
            txtKodeItem.Focus()
            txtNamaItem.Clear()
        Else
            txtNamaItem.Text = SAP.GetItem(txtKodeItem.Text.Trim)
        End If

    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles cboKodeUnit.SelectedIndexChanged,
                                                                      txtKodeItem.TextChanged,
                                                                      txtNamaItem.TextChanged,
                                                                      txtPanjang.TextChanged,
                                                                      txtBerat.TextChanged,
                                                                      cboStatus.SelectedIndexChanged
        SetEnableCommand()
    End Sub

    Private Sub frmCetakBarcodeRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Select DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DaftarCetakBarcode As New DaftarCetakBarcode(ActiveSession)
                Dim CetakBarcode As New CetakBarcode()

                _NoTransaksi = New DaftarCetakBarcode(ActiveSession).GetNomorTransaksi(cboKodeUnit.SelectedValue, GetPeriod(Now))
                CetakBarcode.NoTransaksi = _NoTransaksi
                CetakBarcode.TglTransaksi = Now.Date
                CetakBarcode.KodeUnit = cboKodeUnit.SelectedValue
                CetakBarcode.KodeProduksi = New DaftarCetakBarcode(ActiveSession).GetKodeProduksi(cboKodeUnit.SelectedValue, GetPeriodFull(Now))
                CetakBarcode.KodeItem = txtKodeItem.Text
                CetakBarcode.NamaItem = txtNamaItem.Text
                CetakBarcode.Unit = txtPanjang.Value
                CetakBarcode.Timbang = txtBerat.Value
                CetakBarcode.Status = cboStatus.SelectedIndex + 1
                CetakBarcode.Keterangan = txtKeterangan.Text

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarCetakBarcode.Add(CetakBarcode)
                    ResetData()
                    cboKodeUnit.Focus()
                Else
                    Me.Close()
                End If

                If cboKodeUnit.SelectedValue = "011" Or cboKodeUnit.SelectedValue = "012" Then
                    PrintBarcodeBall(_NoTransaksi)
                ElseIf cboKodeUnit.SelectedValue = "015" Then
                    PrintBarcodeBall(_NoTransaksi)
                Else
                    PrintBarcodeRoll(_NoTransaksi)
                End If

                Me.Cursor = Cursors.Default
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

    End Sub

    Private Sub PrintBarcodeRoll(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarCetakbarcode As New DaftarCetakBarcode(ActiveSession)
        Dim CetakBarcode As CetakBarcode = DaftarCetakbarcode.Find(_NoTransaksi)

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeOpnameRoll.btw", False, "")

        If Not IsNothing(CetakBarcode) Then
            FormatBt.SetNamedSubStringValue("Tanggal", CetakBarcode.TglTransaksi)
            FormatBt.SetNamedSubStringValue("UnitProduksi", New DaftarUnitProduksi(ActiveSession).Find(CetakBarcode.KodeUnit).NamaUnit)
            FormatBt.SetNamedSubStringValue("KodeProduksi", CetakBarcode.KodeProduksi)
            FormatBt.SetNamedSubStringValue("ItemProduksi", CetakBarcode.NamaItem)
            FormatBt.SetNamedSubStringValue("Panjang", CetakBarcode.Unit)
            FormatBt.SetNamedSubStringValue("Berat", CetakBarcode.Timbang)
            FormatBt.SetNamedSubStringValue("Status", If(CetakBarcode.Status = 0, "NONE", If(CetakBarcode.Status = 1, "OK", If(CetakBarcode.Status = 2, "NON OK", If(CetakBarcode.Status = 3, "OVER", If(CetakBarcode.Status = 4, "UNDER", ""))))))
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(CetakBarcode.Keterangan) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub PrintBarcodeBall(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarCetakbarcode As New DaftarCetakBarcode(ActiveSession)
        Dim CetakBarcode As CetakBarcode = DaftarCetakbarcode.Find(_NoTransaksi)
        Dim KodeBall As String = ""

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeOpnameBall.btw", False, "")

        If Not IsNothing(CetakBarcode) Then

            For i = 1 To CetakBarcode.Timbang.ToString.Length
                KodeBall += GetFormat(Mid(CetakBarcode.Timbang.ToString, i, 1))
            Next

            FormatBt.SetNamedSubStringValue("Tanggal", CetakBarcode.TglTransaksi)
            FormatBt.SetNamedSubStringValue("KodeProduksi", CetakBarcode.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeItem", CetakBarcode.NamaItem)
            FormatBt.SetNamedSubStringValue("Pcs", CetakBarcode.Unit)
            FormatBt.SetNamedSubStringValue("Berat", KodeBall & " " & If(CetakBarcode.Status = 0, "", If(CetakBarcode.Status = 1, "", If(CetakBarcode.Status = 2, "", If(CetakBarcode.Status = 3, " /O", If(CetakBarcode.Status = 4, " /U", ""))))))
            FormatBt.SetNamedSubStringValue("Status", "")

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub PrintBarcodeBmf(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarCetakbarcode As New DaftarCetakBarcode(ActiveSession)
        Dim CetakBarcode As CetakBarcode = DaftarCetakbarcode.Find(_NoTransaksi)
        Dim KodeBall As String = ""

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeOpnameBmf.btw", False, "")

        If Not IsNothing(CetakBarcode) Then
            FormatBt.SetNamedSubStringValue("Tanggal", CetakBarcode.TglTransaksi)
            FormatBt.SetNamedSubStringValue("KodeProduksi", CetakBarcode.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeItem", CetakBarcode.NamaItem)
            FormatBt.SetNamedSubStringValue("Pcs", CetakBarcode.Unit)
            FormatBt.SetNamedSubStringValue("Berat", CetakBarcode.Timbang)

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnit.Click
        Dim DaftarUnitProduksi As IDataLookup = New DaftarUnitProduksi(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarUnitProduksi, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeUnit.SelectedValue = Form.IDLookup
            cboKodeUnit.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SetEnableCommand()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            If cboKodeUnit.SelectedValue.ToString = "011" Or cboKodeUnit.SelectedValue.ToString = "012" Then
                lblUnit.Text = "Lembar"
                lblSatuanUnit.Text = "Pcs"
            ElseIf cboKodeUnit.SelectedValue.ToString = "015" Then
                lblUnit.Text = "Cones"
                lblSatuanUnit.Text = "Pcs"
            Else
                lblUnit.Text = "Panjang"
                lblSatuanUnit.Text = "Meter"
            End If
        End If

        btSave.Enabled = If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(txtKodeItem.Text = "", False, True) And _
                         If(txtNamaItem.Text = "", False, True) And _
                         If(txtPanjang.Text = "", False, True) And _
                         If(txtBerat.Text = "", False, True) And _
                         If(cboStatus.SelectedIndex = cboStatus.Items.Count - 1, False, True)
    End Sub
End Class