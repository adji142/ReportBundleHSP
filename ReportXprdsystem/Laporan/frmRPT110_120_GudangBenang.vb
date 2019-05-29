Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports ReportXprdsystem.HSP.Data

Public Class frmRPT110_120_GudangBenang

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        FillCombo()

        cboKodeItem.ComboBox.SelectedIndex = cboKodeItem.Items.Count - 1
        cboKodeStatus.ComboBox.SelectedIndex = cboKodeStatus.Items.Count - 1
        cboLaporan.ComboBox.SelectedIndex = 0

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Grup Produksi
        Dim DaftarItemBenang As New DaftarSAPItemBarang()

        DS = DaftarItemBenang.ReadItemByWhs("511")
        cboKodeItem.ComboBox.DataSource = DS.Tables("View")
        cboKodeItem.ComboBox.DisplayMember = "Nama Item"
        cboKodeItem.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Item") = "<SEMUA ITEM BENANG AKTIF>"

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
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt110121_GudangBenang.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt110122_GudangBenang.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("KodeItem").CurrentValues.AddValue(cboKodeItem.ComboBox.SelectedValue)
        If cboKodeStatus.ComboBox.SelectedIndex <> cboKodeStatus.Items.Count - 1 Then
            RPTObject.ParameterFields("Status").CurrentValues.AddValue(cboKodeStatus.Text)
        Else
            RPTObject.ParameterFields("Status").CurrentValues.AddValue("")
        End If

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + Now.ToString("dd-MM-yyyy") + "'"

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
