Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
'Imports HSPProduction.HSP.Data
Imports HSPKPI.HSP.Data

Public Class frmReport
    Private Kode As String = GetSetting(enumFormID.frmCircularLoom, enumSetting.settingKodeUnit)
    'Private WithEvents txtTanggal As New DateTimePicker
    Private nDate As String

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        'Toolbar.Items.Insert(1, New ToolStripControlHost(txtTanggal))
        'txtTanggal.Format = DateTimePickerFormat.Custom
        'txtTanggal.CustomFormat = "MMMM yyyy"
        'txtTanggal.Width = 125
        'txtTanggal.Value = Now

        FillCombo()
        FillMonth(cboBulan)
        FillYear(cboTahun)
        txtKodeKaryawan.Text = ""
        txtNamaKaryawan.Text = ""
    End Sub

    Private Sub Periode()
        nDate = Strings.Right(cboTahun.Text, 4) & Strings.Right("0" & cboBulan.ComboBox.SelectedIndex + 1, 2)
    End Sub

    Private Sub FillCombo()
        'Dim Drow As DataRow
        Dim DS As DataSet

        'Bagian
        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet
        DS = DaftarDept.Read("%")
        cboDept.ComboBox.DataSource = DS.Tables("View")
        cboDept.ComboBox.DisplayMember = "Departemen"
        cboDept.ComboBox.ValueMember = "Kode"

        'Drow = DS.Tables("View").Rows.Add
        'Drow("Kode") = ""
        'Drow("Departemen") = "<SEMUA DEPARTEMEN>"

        cboDept.ComboBox.SelectedIndex = -1
        'cboDept.ComboBox.SelectedValue = ""

    End Sub

    Private Sub FillComboBagian()
        If cboDept.ComboBox.SelectedIndex <> -1 Then
            Dim DS As DataSet
            'Dim Drow As DataRow

            'Bagian
            Dim DaftarBagian As New DaftarHRBagian()
            DS = New DataSet
            DS = DaftarBagian.Read("%", cboDept.ComboBox.SelectedValue.ToString)
            cboBagian.ComboBox.DataSource = DS.Tables("View")
            cboBagian.ComboBox.DisplayMember = "Nama Bagian"
            cboBagian.ComboBox.ValueMember = "Kode"

            'Drow = DS.Tables("View").Rows.Add
            'Drow("Kode") = ""
            'Drow("Nama Bagian") = "<SEMUA BAGIAN>"
        End If
        cboBagian.ComboBox.SelectedIndex = -1
        'cboBagian.ComboBox.SelectedValue = ""

    End Sub

    Private Sub FillComboPosisi()
        If cboBagian.ComboBox.SelectedIndex <> -1 Then
            'Posisi
            Dim DaftarPosisi As New DaftarHRPosisi()
            Dim DS As DataSet
            'Dim Drow As DataRow

            DS = New DataSet
            DS = DaftarPosisi.Read("%", cboBagian.ComboBox.SelectedValue.ToString)
            cboPosisi.ComboBox.DataSource = DS.Tables("View")
            cboPosisi.ComboBox.DisplayMember = "Nama Posisi"
            cboPosisi.ComboBox.ValueMember = "Kode"

            'Drow = DS.Tables("View").Rows.Add
            'Drow("Kode") = ""
            'Drow("Nama Posisi") = "<SEMUA POSISI>"
        End If
        cboPosisi.ComboBox.SelectedIndex = -1
        'cboPosisi.ComboBox.SelectedValue = ""
    End Sub

    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDept.SelectedIndexChanged
        FillComboBagian()
    End Sub

    Private Sub cboBagian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBagian.SelectedIndexChanged
        FillComboPosisi()
    End Sub

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click

        'If cboBagian.ComboBox.SelectedIndex <> -1 And cboPosisi.ComboBox.SelectedIndex <> -1 And txtKodeKaryawan.Text <> "" Then
        Dim Server As New ConnectionInfo
        Dim DataTable As Table
        Dim period As String = cboBulan.SelectedIndex + 1 & Microsoft.VisualBasic.Right(cboTahun.SelectedText, 2)

        Me.Cursor = Cursors.WaitCursor
        '-----------------------------------------------------------------------------------------   

        '-----------------------------------------------------------------------------------------   
        Dim DBX As Object = New HSPKPI.HSP.Data.DBConnection(ActiveSession).ConnectionSetting()

        'Setting Koneksi Database
        With Server
            .ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=" + DBX.Server + "; PORT = " + DBX.Port.ToString + "; "
            .DatabaseName = DBX.Database
            .UserID = DBX.UserID
            .Password = DBX.Password
        End With
        '-----------------------------------------------------------------------------------------

        Dim RPTObject As New ReportDocument

        ' MsgBox(System.AppDomain.CurrentDomain.BaseDirectory() + "Reports\rptReport.rpt")

        'Report
        RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\HSPKPI\rptReport.rpt")

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        Periode()

        'Parameter
        RPTObject.ParameterFields("Periode").CurrentValues.AddValue(nDate)
        RPTObject.ParameterFields("KodeBagian").CurrentValues.AddValue(cboBagian.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodePosisi").CurrentValues.AddValue(cboPosisi.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodeKaryawan").CurrentValues.AddValue(txtKodeKaryawan.Text)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        'RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + UCase(ActiveSession.KodeUser) + "'"

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

        Me.Cursor = Cursors.Default
        'Else
        'MessageBox.Show("Filter Data Masih Ada Yang Kosong !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub

    Private Sub HideTabControl(ByVal RPT As Object)
        For Each control As Control In RPT.Controls
            If TypeOf control Is CrystalDecisions.Windows.Forms.PageView Then
                Dim tab As TabControl = DirectCast(DirectCast(control, CrystalDecisions.Windows.Forms.PageView).Controls(0), TabControl)
                tab.ItemSize = New Size(0, 1)
                tab.SizeMode = TabSizeMode.Fixed
                tab.Appearance = TabAppearance.Buttons
            End If
        Next
    End Sub

    'Private Sub btnLookupKayawan_Click(sender As Object, e As EventArgs) Handles btnLookupKayawan.Click
    '    Dim DaftarKaryawan As HSPKPI.HSP.Data.IDataLookup = New HSPKPI.HSP.Data.DaftarKPI(ActiveSession)
    '    'Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
    '    Periode()
    '    Dim Parameter() As String = {DaftarKPI.enumLookupKaryawan.DaftarKaryawan, cboBagian.ComboBox.SelectedValue, cboPosisi.ComboBox.SelectedValue, nDate}

    '    Dim Form As New frmLookup(DaftarKaryawan, Parameter)
    '    Form.Text = "Lookup Daftar Karyawan"
    '    Form.ShowDialog()
    '    If Form.IDLookup <> "" Then
    '        txtKodeKaryawan.Text = ""
    '        txtNamaKaryawan.Text = ""
    '        txtKodeKaryawan.SelectedText = Form.IDLookup
    '        txtNamaKaryawan.SelectedText = Form.IDLookup1
    '        'cboKelompok.Focus()
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub

    Private Sub btnLookupKaryawan_Click(sender As Object, e As EventArgs) Handles btnLookupKaryawan.Click
        Periode()
        Dim DaftarKaryawan As IDataLookup = New DaftarHRKaryawan()
        Dim Parameter() As String = {DaftarHRKaryawan.enumLookupKaryawan.DaftarKaryawan, cboPosisi.ComboBox.SelectedValue, nDate}

        Dim Form As New frmLookup(DaftarKaryawan, Parameter)
        Form.Text = "Lookup Daftar Karyawan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            txtKodeKaryawan.Text = ""
            txtNamaKaryawan.Text = ""
            txtKodeKaryawan.SelectedText = Form.IDLookup
            txtNamaKaryawan.SelectedText = Form.IDLookup1
            'cboKelompok.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class
