Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT_FR_Persediaan
    Private WithEvents chkFilter As New Enerzie.EPSBasicControls.EPSCheckBox

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(8, New ToolStripControlHost(chkFilter))
        chkFilter.Text = "Abaikan Qty 0"

        FillCombo()
        cboLaporan.SelectedIndex = 0
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        FillMonth(cboPeriode, 0)
        FillYear(cboTahun)

        Dim DaftarAccount As New SAPInventory()
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarAccount.ReadAccount()
        cboAccount.ComboBox.DataSource = DS.Tables("View")
        cboAccount.ComboBox.DisplayMember = "NamaPerkiraan"
        cboAccount.ComboBox.ValueMember = "KodePerkiraan"
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
            .ServerName = "192.168.1.222:30015"
            .DatabaseName = "HARDO_LIVE"
            .UserID = "SYSTEM"
            .Password = "sys825050SYS"
        End With
        '-----------------------------------------------------------------------------------------

        Dim RPTObject As New ReportDocument

        'Report
        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rptFR_Persediaan.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("BULAN").CurrentValues.AddValue(cboPeriode.ComboBox.SelectedValue)
        RPTObject.ParameterFields("TAHUN").CurrentValues.AddValue(cboTahun.ComboBox.SelectedValue)
        RPTObject.ParameterFields("Perkiraan").CurrentValues.AddValue("")
        If chkFilter.Checked = True Then
            RPTObject.ParameterFields("Filter").CurrentValues.AddValue(1)
        Else
            RPTObject.ParameterFields("Filter").CurrentValues.AddValue(0)
        End If

        'Informasi
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + UCase(cboPeriode.Text) & " " & cboTahun.Text + "'"
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
