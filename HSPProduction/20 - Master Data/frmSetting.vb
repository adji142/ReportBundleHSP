Imports Microsoft.Win32
Imports HSPProduction.HSP.Data

Public Class frmSetting

    Private Sub FillCombo()
        Dim DataRow As DataRow
        Dim DS As DataSet

        'Unit Produksi
        '----------------------------------------------------------------------------
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        DataRow = DS.Tables("View").Rows.Add
        DataRow("Kode") = ""
        DataRow("Unit Produksi") = "-"

        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1

        'Lokasi Produksi
        '----------------------------------------------------------------------------
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        DataRow = DS.Tables("View").Rows.Add
        DataRow("Kode") = ""
        DataRow("Nama Lokasi") = "-"

        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
    End Sub

    Private Sub ResetData()
        Dim myPort As Array

        myPort = IO.Ports.SerialPort.GetPortNames()

        For i = 0 To UBound(myPort)
            cboPort.Items.Add(myPort(i))
        Next
        cboPort.Items.Add("-")

        cboFormID.SelectedIndex = cboFormID.Items.Count - 1
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
        cboPort.SelectedIndex = cboPort.Items.Count - 1
        cboBaudRate.SelectedIndex = cboBaudRate.Items.Count - 1

        SetEnableCommand()
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub Button(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                SaveSetting(cboFormID.SelectedIndex, enumSetting.settingKodeUnit, cboKodeUnit.SelectedValue)
                SaveSetting(cboFormID.SelectedIndex, enumSetting.settingKodeLokasi, cboKodeLokasi.SelectedValue)
                SaveSetting(cboFormID.SelectedIndex, enumSetting.settingPort, cboPort.SelectedItem)
                SaveSetting(cboFormID.SelectedIndex, enumSetting.settingBaudRate, cboBaudRate.SelectedItem)

                ResetData()

            Case "btClose"
                Me.Close()

        End Select

    End Sub

    Private Sub cboFormID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormID.SelectedIndexChanged
        If cboFormID.SelectedIndex <> cboFormID.Items.Count - 1 Then
            If Registry.CurrentUser.OpenSubKey("Software\HSPProduction\Setting") IsNot Nothing Then
                cboKodeUnit.SelectedValue = GetSetting(cboFormID.SelectedIndex, enumSetting.settingKodeUnit)
                cboKodeLokasi.SelectedValue = GetSetting(cboFormID.SelectedIndex, enumSetting.settingKodeLokasi)
                cboPort.SelectedItem = GetSetting(cboFormID.SelectedIndex, enumSetting.settingPort)
                cboBaudRate.SelectedItem = GetSetting(cboFormID.SelectedIndex, enumSetting.settingBaudRate)
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(cboFormID.SelectedIndex = cboFormID.Items.Count - 1, False, True)
    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnit.Click
        Dim DaftarUnit As IDataLookup = New DaftarUnitProduksi(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarUnit, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeUnit.SelectedValue = Form.IDLookup
            cboKodeUnit.Focus()
        End If
    End Sub

    Private Sub btLookupKodeLokasi_Click(sender As Object, e As EventArgs) Handles btLookupKodeLokasi.Click
        Dim DaftarLokasi As IDataLookup = New DaftarLokasi(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarLokasi, Parameter)
        Form.Text = "Lookup Daftar Lokasi Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeLokasi.SelectedValue = Form.IDLookup
            cboKodeLokasi.Focus()
        End If
    End Sub
End Class