Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT800_100_CostAccounting

    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Class AccountWIP
        Property Kode As String
        Property NamaWIP As String
    End Class

    Private Sub FillCombo()

        Dim _WIP As New List(Of AccountWIP)

        _WIP.Add(New AccountWIP With {.Kode = "", .NamaWIP = "<SEMUA KELOMPOK WIP>"})
        _WIP.Add(New AccountWIP With {.Kode = "1163001", .NamaWIP = "Persediaan BDP Extruder"})
        _WIP.Add(New AccountWIP With {.Kode = "1163002", .NamaWIP = "Persediaan BDP Loom"})
        _WIP.Add(New AccountWIP With {.Kode = "1163003", .NamaWIP = "Persediaan BDP Laminasi"})
        _WIP.Add(New AccountWIP With {.Kode = "1163004", .NamaWIP = "Persediaan BDP Printing"})
        _WIP.Add(New AccountWIP With {.Kode = "1163005", .NamaWIP = "Persediaan BDP Slitting"})
        _WIP.Add(New AccountWIP With {.Kode = "1163006", .NamaWIP = "Persediaan BDP Cutting"})
        _WIP.Add(New AccountWIP With {.Kode = "1163007", .NamaWIP = "Persediaan BDP Cement Bag"})
        _WIP.Add(New AccountWIP With {.Kode = "1163008", .NamaWIP = "Persediaan BDP Jahit"})
        _WIP.Add(New AccountWIP With {.Kode = "1163009", .NamaWIP = "Persediaan BDP Inner"})
        _WIP.Add(New AccountWIP With {.Kode = "1163010", .NamaWIP = "Persediaan BDP Packing"})
        _WIP.Add(New AccountWIP With {.Kode = "1163011", .NamaWIP = "Persediaan BDP Recycle"})
        _WIP.Add(New AccountWIP With {.Kode = "1163012", .NamaWIP = "Persediaan BDP Multifilament"})
        _WIP.Add(New AccountWIP With {.Kode = "1169001", .NamaWIP = "Persediaan BDP Makloon"})

        cboKelompokWIP.ComboBox.DataSource = _WIP
        cboKelompokWIP.ComboBox.DisplayMember = "NamaWIP"
        cboKelompokWIP.ComboBox.ValueMember = "Kode"

    End Sub

    Private Sub frmRPTJurnal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

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

        cboTipeLaporan.SelectedIndex = 0
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
        Select Case cboTipeLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt800101_CostAccounting.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt800102_CostAccounting.RPT")
            Case 3
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt800103_CostAccounting.RPT")
            Case 4
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt800104_CostAccounting.RPT")
            Case 5
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt800105_CostAccounting.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("TGLAWAL").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("TGLAKHIR").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("ACCOUNT").CurrentValues.AddValue(cboKelompokWIP.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        If txtTglAwal.Value.ToString("dd/MM/yy") = txtTglAkhir.Value.ToString("dd/MM/yy") Then
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + txtTglAkhir.Value.ToString("dd-MM-yyyy") + "'"
        Else
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + txtTglAwal.Value.ToString("dd-MM-yy") + " S/D " + txtTglAkhir.Value.ToString("dd-MM-yy") + "'"
        End If

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
