Imports HSPProduction.HSP.Data

Public Class frmStagingFGExtruder

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowDataStaging()
        Me.Cursor = Cursors.WaitCursor
        ViewStaging.SuspendLayout()

        'Baca Data
        Dim SAP As New SAPStaging
        Dim BS As New BindingSource
        Dim DataSet As DataSet = SAP.Read(txtTanggal.Value.Date, SAPStaging.enumTransaksiStaging.HasilExtruder)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        ViewStaging.RowTemplate.Height = 16
        ViewStaging.DataSource = BS

        'Format Kolom
        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                ViewStaging.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                ViewStaging.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ViewStaging.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                ViewStaging.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                ViewStaging.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewStaging.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        'Tampilkan Jumlah Baris
        DataStaging.Text = "Total : " + ViewStaging.RowCount.ToString + " Baris"

        TotalStaging()

        Me.Cursor = Cursors.Default
        ViewStaging.ResumeLayout()

    End Sub

    Private Sub ShowDataConsole()
        Me.Cursor = Cursors.WaitCursor
        ViewConsole.SuspendLayout()

        'Baca Data
        Dim DataC As New DaftarStockBenang(ActiveSession)
        Dim BS1 As New BindingSource
        Dim DataSet As DataSet = DataC.ReadConsole(txtTanggal.Value.Date)

        BS1.DataSource = DataSet
        BS1.DataMember = "View"

        ViewConsole.RowTemplate.Height = 16
        ViewConsole.DataSource = BS1

        'Format Kolom
        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                ViewConsole.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                ViewConsole.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ViewConsole.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                ViewConsole.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                ViewConsole.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewConsole.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        'Tampilkan Jumlah Baris
        DataConsole.Text = "Total : " + ViewConsole.RowCount.ToString + " Baris"

        TotalConsole()

        Me.Cursor = Cursors.Default
        ViewConsole.ResumeLayout()

    End Sub

    Private Sub ShowDataSAP()
        Me.Cursor = Cursors.WaitCursor
        ViewSAP.SuspendLayout()

        'Baca Data
        Dim DataC As New SAPStaging()
        Dim BS1 As New BindingSource
        Dim DataSet As DataSet = DataC.ReadSAPExtruder(txtTanggal.Value.Date)

        BS1.DataSource = DataSet
        BS1.DataMember = "View"

        ViewSAP.RowTemplate.Height = 16
        ViewSAP.DataSource = BS1

        'Format Kolom
        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                ViewSAP.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                ViewSAP.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ViewSAP.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                ViewSAP.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                ViewSAP.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewSAP.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        'Tampilkan Jumlah Baris
        DataConsole.Text = "Total : " + ViewSAP.RowCount.ToString + " Baris"

        TotalSAP()

        Me.Cursor = Cursors.Default
        ViewSAP.ResumeLayout()

    End Sub

    Private Sub TotalStaging()
        Dim Total As Double

        For i = 0 To ViewStaging.Rows.Count - 1
            Total += ViewStaging.Rows(i).Cells("Qty").Value
        Next

        txtTotalStaging.Value = Total
    End Sub

    Private Sub TotalConsole()
        Dim Total As Double
        Dim QtyCancel As Double

        For i = 0 To ViewConsole.Rows.Count - 1
            Total += ViewConsole.Rows(i).Cells("Qty").Value
            QtyCancel += ViewConsole.Rows(i).Cells("Qty Cancel").Value
        Next

        txtTotalConsole.Value = Total
        txtQtyCancel.Value = QtyCancel
    End Sub

    Private Sub TotalSAP()
        Dim Total As Double

        For i = 0 To ViewSAP.Rows.Count - 1
            Total += ViewSAP.Rows(i).Cells("Qty").Value
        Next

        txtTotalSAP.Value = Total
        txtSAP.Value = Total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowDataConsole()
        ShowDataStaging()
        ShowDataSAP()

        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        txtTotal.Value = txtTotalConsole.Value - txtQtyCancel.Value
        txtSelisih.Value = txtTotalConsole.Value - txtTotalStaging.Value
        txtSelisihSAp.Value = txtTotal.Value - txtTotalSAP.Value
    End Sub
End Class