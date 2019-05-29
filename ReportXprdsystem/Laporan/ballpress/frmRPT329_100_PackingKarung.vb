Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT329_100_PackingKarung

    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        txtTglAwal.Format = DateTimePickerFormat.Custom
        txtTglAwal.CustomFormat = "dd/MM/yyyy"
        txtTglAwal.Width = 95
        txtTglAwal.Value = Now.Date

        Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        txtTglAkhir.Format = DateTimePickerFormat.Custom
        txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        txtTglAkhir.Width = 95
        txtTglAkhir.Value = Now.Date

        FillCombo()

        cboLaporan.SelectedIndex = 0

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Shift Produksi
        Dim DaftarShiftProduksi As New DaftarShiftProduksi(ActiveSession)

        DS = DaftarShiftProduksi.Read("%")
        cboShift.ComboBox.DataSource = DS.Tables("View")
        cboShift.ComboBox.DisplayMember = "Nama Shift"
        cboShift.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Shift") = "-"

        cboShift.SelectedIndex = cboShift.Items.Count - 1

        'Grup Produksi
        Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)

        DS = DaftarGrupProduksi.Read("%")
        cboGrup.ComboBox.DataSource = DS.Tables("View")
        cboGrup.ComboBox.DisplayMember = "Grup Produksi"
        cboGrup.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Grup Produksi") = "-"

        cboGrup.SelectedIndex = cboGrup.Items.Count - 1

    End Sub

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
        Dim Server As New ConnectionInfo
        Dim DataTable As Table

        Me.Cursor = Cursors.WaitCursor
        '-----------------------------------------------------------------------------------------   

        '-----------------------------------------------------------------------------------------   
        Dim DBX As Object = New DBConnection(ActiveSession).ConnectionSetting()

        'Setting Koneksi Database
        With Server
            .ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=" + DBX.Server + "; PORT = " + DBX.Port.ToString + "; "
            .DatabaseName = DBX.Database
            .UserID = DBX.UserID
            .Password = DBX.Password
        End With
        '-----------------------------------------------------------------------------------------

        Dim RPTObject As New ReportDocument

        'Report
        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329101_PackingKarung.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329102_PackingKarung.RPT")
            Case 3
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329103_PackingKarung.RPT")
            Case 4
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329104_PackingKarung.RPT")
            Case 5
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329105_PackingKarung.RPT")
            Case 6
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329106_PackingKarung.RPT")
            Case 7
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT329107_PackingKarung.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("KodeShift").CurrentValues.AddValue(cboShift.ComboBox.SelectedValue.ToString)
        RPTObject.ParameterFields("KodeGrup").CurrentValues.AddValue(cboGrup.ComboBox.SelectedValue.ToString)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        If txtTglAwal.Value.ToString("dd/MM/yy") = txtTglAkhir.Value.ToString("dd/MM/yy") Then
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + txtTglAkhir.Value.ToString("dd-MM-yyyy") + "'"
        Else
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + txtTglAwal.Value.ToString("dd-MM-yy") + " S/D " + txtTglAkhir.Value.ToString("dd-MM-yy") + "'"
        End If
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + UCase(ActiveSession.KodeUser) + "'"

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

        Me.Cursor = Cursors.Default

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
