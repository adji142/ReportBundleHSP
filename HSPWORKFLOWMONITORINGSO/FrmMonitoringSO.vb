Imports HSPWORKFLOWMONITORINGSO.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Public Class FrmMonitoringSO
    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker
    ' Local Var
    Dim _NoSO As String = ""
    Dim _KdItem As String = ""

    Private Sub FrmMonitoringSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        txtTglAwal.Format = DateTimePickerFormat.Custom
        txtTglAwal.CustomFormat = "dd/MM/yyyy"
        txtTglAwal.Width = 95

        Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        txtTglAkhir.Format = DateTimePickerFormat.Custom
        txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        txtTglAkhir.Width = 95

        CmbStatus.SelectedIndex = 0

        CallSO()
    End Sub
    Private Sub CallSO()
        Dim Status As String = ""
        Select Case CmbStatus.SelectedIndex
            Case 0
                Status = "O"
            Case 1
                Status = "1"
        End Select
        Dim Row As Integer = 0
        Dim DaftarSO As New MasterClass()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarSO.ReadSO(txtTglAwal.Value.ToString("yyyy-MM-dd"), txtTglAkhir.Value.ToString("yyyy-MM-dd"), Status)
        BS.DataSource = DataSet
        BS.DataMember = "View"

        View.DataSource = BS

        Dim Column As DataColumn
        If (DataSet.Tables(0).Rows.Count > 0) Then
            For Each Column In DataSet.Tables("View").Columns
                If Column.DataType.Name.ToUpper = "DATETIME" Then
                    View.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                    View.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    View.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If Column.DataType.Name.ToUpper = "DOUBLE" Then
                    View.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                    View.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    View.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
                If Column.DataType.Name.ToUpper = "DECIMAL" Then
                    View.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##"
                    View.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    View.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Next
        End If
    End Sub
    Private Sub Toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub
    Private Sub CallOP()
        Dim Row As Integer = 0
        Dim DaftarSO As New MasterClass()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarSO.ReadOP(_NoSO, _KdItem)
        BS.DataSource = DataSet
        BS.DataMember = "View"

        GridOP.DataSource = BS

        Dim Column As DataColumn
        If (DataSet.Tables(0).Rows.Count > 0) Then
            For Each Column In DataSet.Tables("View").Columns
                If Column.DataType.Name.ToUpper = "DATETIME" Then
                    GridOP.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                    GridOP.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    GridOP.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If Column.DataType.Name.ToUpper = "DOUBLE" Then
                    GridOP.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                    GridOP.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    GridOP.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
                If Column.DataType.Name.ToUpper = "DECIMAL" Then
                    GridOP.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##"
                    GridOP.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    GridOP.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Next
        End If
    End Sub
    Private Sub CallWO()
        Dim Row As Integer = 0
        Dim DaftarSO As New MasterClass()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarSO.ReadWO(_NoSO, _KdItem)
        BS.DataSource = DataSet
        BS.DataMember = "View"

        GridWO.DataSource = BS

        Dim Column As DataColumn
        If (DataSet.Tables(0).Rows.Count > 0) Then
            For Each Column In DataSet.Tables("View").Columns
                If Column.DataType.Name.ToUpper = "DATETIME" Then
                    GridWO.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                    GridWO.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    GridWO.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If Column.DataType.Name.ToUpper = "DOUBLE" Then
                    GridWO.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                    GridWO.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    GridWO.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Next
        End If
    End Sub
    Private Sub CallStkProd()
        Dim Row As Integer = 0
        Dim DaftarSO As New MasterClass()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarSO.ReadStkProd(_NoSO, _KdItem)
        BS.DataSource = DataSet
        BS.DataMember = "View"

        GridStockProd.DataSource = BS

        Dim Column As DataColumn
        If (DataSet.Tables(0).Rows.Count > 0) Then
            For Each Column In DataSet.Tables("View").Columns
                If Column.DataType.Name.ToUpper = "DATETIME" Then
                    GridStockProd.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                    GridStockProd.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    GridStockProd.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If Column.DataType.Name.ToUpper = "DOUBLE" Then
                    GridStockProd.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                    GridStockProd.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    GridStockProd.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Next
        End If
    End Sub
    Private Sub CallStkWH()
        Dim Row As Integer = 0
        Dim DaftarSO As New MasterClass()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarSO.ReadStkWH(_NoSO, _KdItem)
        BS.DataSource = DataSet
        BS.DataMember = "View"

        GridStockWHS.DataSource = BS

        Dim Column As DataColumn
        If (DataSet.Tables(0).Rows.Count > 0) Then
            For Each Column In DataSet.Tables("View").Columns
                If Column.DataType.Name.ToUpper = "DATETIME" Then
                    GridStockWHS.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                    GridStockWHS.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    GridStockWHS.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If Column.DataType.Name.ToUpper = "DOUBLE" Then
                    GridStockWHS.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                    GridStockWHS.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    GridStockWHS.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Next
        End If
    End Sub
    Private Sub CallDelivering()
        Dim Row As Integer = 0
        Dim DaftarSO As New MasterClass()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarSO.ReadDeliv(_NoSO, _KdItem)
        BS.DataSource = DataSet
        BS.DataMember = "View"

        GridDeliv.DataSource = BS

        Dim Column As DataColumn
        If (DataSet.Tables(0).Rows.Count > 0) Then
            For Each Column In DataSet.Tables("View").Columns
                If Column.DataType.Name.ToUpper = "DATETIME" Then
                    GridDeliv.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                    GridDeliv.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    GridDeliv.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If Column.DataType.Name.ToUpper = "DOUBLE" Then
                    GridDeliv.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                    GridDeliv.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    GridDeliv.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Next
        End If
    End Sub
    Private Sub Execute(ByVal ID As String)

        'PopupMenu.Hide()

        Select Case ID
            Case "btRefresh", "btRefreshCTXM"
                CallSO()
                If View.RowCount > 0 Then
                    View.Focus()
                End If
        End Select
    End Sub

    Private Sub View_SelectionChanged(sender As Object, e As EventArgs) Handles View.SelectionChanged
        _NoSO = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
        _KdItem = If(View.Rows.Count = 0, "", View(4, View.CurrentCell.RowIndex).Value.ToString())
        CallOP()
        CallWO()
        CallStkProd()
        CallStkWH()
        CallDelivering()
    End Sub
End Class