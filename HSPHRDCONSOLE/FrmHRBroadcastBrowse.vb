Imports HSPHRDCONSOLE.HSP.Data
Public Class FrmHRBroadcastBrowse

    Private Sub FrmHRBroadcastBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmHRBroadcastBrowse_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub
    Private Sub ShowData(Optional ByVal ID As String = "")
        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Baca Data
        Dim Core As New BroadcastCore(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = Core.ShowData()

        BS.DataSource = DataSet
        BS.DataMember = "View"

        View.RowTemplate.Height = 16
        View.DataSource = BS

        'View.Columns("RowID").Visible = False

        'Format Kolom
        Dim Column As DataColumn
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
        Next

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + View.RowCount.ToString + " Baris"

        Me.Cursor = Cursors.Default
        View.ResumeLayout()

    End Sub
    Private Sub Execute(ByVal ID As String)

        'PopupMenu.Hide()

        Select Case ID
            Case "btAdd", "btAddCTXM"
                Dim FormAdd As New FrmBroadcastAdd()
                FormAdd.ShowDialog()

                If FormAdd.iData <> "" Then
                    ShowData()
                End If
                'If FormEdit.IDData <> "" Then
                '    ShowData(FormEdit.IDData)
                'End If
            Case "btRefresh", "btRefreshCTXM"
                ShowData()
                If View.RowCount > 0 Then
                    View.Focus()
                End If
            Case "btnresend", "btnresendCTXM"
                Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
                Dim Core As New BroadcastCore(ActiveSession)
                Try
                    Core.Resend(DataKey)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub FrmHRBroadcastBrowse_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                Execute("btRefresh")
            Case Keys.F6
                If View.RowCount > 0 Then
                    Execute("btAdd")
                End If
            Case Keys.F4
                Execute("btnresend")
        End Select
    End Sub

    Private Sub View_KeyDown(sender As Object, e As KeyEventArgs) Handles View.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                Execute("btRefresh")
            Case Keys.F6
                If View.RowCount > 0 Then
                    Execute("btAdd")
                End If
            Case Keys.F4
                Execute("btnresend")
        End Select
    End Sub

    Private Sub Toolbar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub
End Class