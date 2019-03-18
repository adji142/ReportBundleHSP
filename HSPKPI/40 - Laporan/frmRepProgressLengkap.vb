Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports HSPKPI.HSP.Data

Public Class frmRepProgressLengkap
    Private Kode As String = GetSetting(enumFormID.frmCircularLoom, enumSetting.settingKodeUnit)

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        'Toolbar.Items.Insert(1, New ToolStripControlHost(txtTanggal))
        'txtTanggal.Format = DateTimePickerFormat.Custom
        'txtTanggal.CustomFormat = "yyyy"
        'txtTanggal.Width = 150
        'txtTanggal.Value = Now
        FillYear(cboTahun)
        FillCombo()

        cboLaporan.SelectedIndex = 0
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim Drow As DataRow
        Dim DS As DataSet

        'Bagian
        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet
        DS = DaftarDept.Read("%")
        cboDept.ComboBox.DataSource = DS.Tables("View")
        cboDept.ComboBox.DisplayMember = "Departemen"
        cboDept.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Departemen") = "<SEMUA DEPARTEMEN>"

        cboDept.ComboBox.SelectedIndex = -1
        cboDept.ComboBox.SelectedValue = ""

    End Sub

    Private Sub FillComboBagian()
        If cboDept.ComboBox.SelectedIndex <> -1 Then
            Dim DS As DataSet
            Dim Drow As DataRow

            'Bagian
            Dim DaftarBagian As New DaftarHRBagian()
            DS = New DataSet
            DS = DaftarBagian.Read("%", cboDept.ComboBox.SelectedValue.ToString)
            cboBagian.ComboBox.DataSource = DS.Tables("View")
            cboBagian.ComboBox.DisplayMember = "Nama Bagian"
            cboBagian.ComboBox.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Bagian") = "<SEMUA BAGIAN>"
        End If
        cboBagian.ComboBox.SelectedIndex = -1
        cboBagian.ComboBox.SelectedValue = ""

    End Sub

    Private Sub FillComboPosisi()
        If cboBagian.ComboBox.SelectedIndex <> -1 Then
            'Posisi
            Dim DaftarPosisi As New DaftarHRPosisi()
            Dim DS As DataSet
            Dim Drow As DataRow

            DS = New DataSet
            DS = DaftarPosisi.Read("%", cboBagian.ComboBox.SelectedValue.ToString)
            cboPosisi.ComboBox.DataSource = DS.Tables("View")
            cboPosisi.ComboBox.DisplayMember = "Nama Posisi"
            cboPosisi.ComboBox.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Posisi") = "<SEMUA POSISI>"
        End If
        cboPosisi.ComboBox.SelectedIndex = -1
        cboPosisi.ComboBox.SelectedValue = ""
    End Sub

    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDept.SelectedIndexChanged
        FillComboBagian()
    End Sub

    Private Sub cboBagian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBagian.SelectedIndexChanged
        FillComboPosisi()
    End Sub

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
        ImportData()
        Dim Server As New ConnectionInfo
        Dim DataTable As Table

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
        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\HSPKPI\rptProgressLengkap_1001.rpt")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\HSPKPI\rptProgressLengkap_1002.rpt")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        'RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTanggal.Value.Date)
        RPTObject.ParameterFields("Tahun").CurrentValues.AddValue(cboTahun.ComboBox.Text)
        RPTObject.ParameterFields("Departemen").CurrentValues.AddValue(cboDept.ComboBox.SelectedValue)
        RPTObject.ParameterFields("Bagian").CurrentValues.AddValue(cboBagian.ComboBox.SelectedValue)
        RPTObject.ParameterFields("Posisi").CurrentValues.AddValue(cboPosisi.ComboBox.SelectedValue)

        'Informasi
        'RPTObject.DataDefinition.FormulaFields("Posisi").Text = "'" + cboPosisi.ComboBox.Text + " " + cboBagian.ComboBox.Text + "'"
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        'RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + txtTanggal.Value.ToString("dd-MM-yyyy") + "'"

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ImportData()
        Dim DR As DataRow
        Dim Row As Integer

        Dim MasterHR As New MasterHR(ActiveSession)
        Dim Dept As New Dept
        Dim Bagian As New Bagian
        Dim Posisi As New Posisi

        'delete tabel temporary master
        MasterHR.DelDept("")
        MasterHR.DelBagian("")
        MasterHR.DelPosisi("")
        '-------------------------------------------------

        'input master dept
        Dim DaftarDept As New DaftarHRDept()
        Dim DT1 As DataTable = DaftarDept.Read("").Tables("View")
        Row = 0

        For Each DR In DT1.Rows

            Dept.KodeDept = DR("Kode")
            Dept.NamaDept = DR("Departemen")

            MasterHR.AddDept(Dept)
            Row += 1
        Next

        'input master bag
        Dim DaftarBagian As New DaftarHRBagian()
        Dim DT2 As DataTable = DaftarBagian.Read("").Tables("View")
        Row = 0

        For Each DR In DT2.Rows

            Bagian.KodeBag = DR("Kode")
            Bagian.NamaBag = DR("Nama Bagian")
            Bagian.KodeDept = DR("Kode Dept")

            MasterHR.AddBagian(Bagian)
            Row += 1
        Next

        'input master posisi
        Dim DaftarPosisi As New DaftarHRPosisi()
        Dim DT3 As DataTable = DaftarPosisi.Read("").Tables("View")
        Row = 0

        For Each DR In DT3.Rows

            Posisi.KodePosisi = DR("Kode")
            Posisi.NamaPosisi = DR("Nama Posisi")
            Posisi.KodeBag = DR("Kode Bagian")

            MasterHR.AddPosisi(Posisi)
            Row += 1
        Next
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

End Class
