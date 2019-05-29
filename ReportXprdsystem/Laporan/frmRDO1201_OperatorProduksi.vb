Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports ReportXprdsystem.HSP.Data

Public Class frmRDO1201_OperatorProduksi

    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Private Sub frmRDO1201_OperatorProduksi_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        txtTglAwal.Format = DateTimePickerFormat.Custom
        txtTglAwal.CustomFormat = "dd/MM/yyyy"
        txtTglAwal.Width = 95

        Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        txtTglAkhir.Format = DateTimePickerFormat.Custom
        txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        txtTglAkhir.Width = 95

        FillCombo()
        FillComboMesin()

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
        Drow("Nama Shift") = "<SEMUA>"

        cboShift.ComboBox.SelectedIndex = cboShift.Items.Count - 1

    End Sub

    Private Sub FillComboMesin()
            'Mesin Produksi
            Dim DaftarMesin As New DaftarMesin(ActiveSession)
            Dim DS As DataSet
            Dim Drow As DataRow

            DS = New DataSet
        DS = DaftarMesin.Read("%", "001")
            cboMesin.ComboBox.DataSource = DS.Tables("View")
            cboMesin.ComboBox.DisplayMember = "Nama Mesin"
            cboMesin.ComboBox.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Mesin") = "<SEMUA>"

        cboMesin.ComboBox.SelectedIndex = cboMesin.Items.Count - 1
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs)
        FillComboMesin()
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
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rptRDO1201_Extruder_OperatorProduksi.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("KodeShift").CurrentValues.AddValue(cboShift.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodeMesin").CurrentValues.AddValue(cboMesin.ComboBox.SelectedValue)

        'Informasi
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
