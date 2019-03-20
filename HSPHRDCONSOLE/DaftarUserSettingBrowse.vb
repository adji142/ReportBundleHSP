Imports HSPHRDCONSOLE.HSP.Data
Public Class DaftarUserSettingBrowse
    Private Sub FrmUserSettingBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Toolbar.Items(0).Enabled = False
        'Toolbar.Items(1).Enabled = False
        'Toolbar.Items(2).Enabled = False
        'Toolbar.Items(3).Enabled = False
        'FillCombo()
    End Sub


    Private Sub FrmUserSettingBrowse_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    Private Sub FrmUserSettingBrowse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        View.SaveColumnOrder()
    End Sub
    Private Sub ShowData(Optional ByVal ID As String = "")
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        'Toolbar.Items(3).Enabled = False

        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Baca Data
        Dim DarftarUserkry As New UserKaryawan(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DarftarUserkry.ReadTransaction(txtCariData.Text, "", "")

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

        'Set Posisi Baris Aktif
        If ID <> "" Then
            BS.Position = BS.Find("UserID", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + View.RowCount.ToString + " Baris"

        'Enable/Disable Menu
        If View.RowCount = 0 Then
            Toolbar.Items(1).Enabled = False
            'Toolbar.Items(2).Enabled = False
            'PopupMenu.Items(1).Enabled = False
            'PopupMenu.Items(2).Enabled = False

            If txtCariData.Focused Then
                txtCariData.SelectAll()
            End If
        Else
            Toolbar.Items(0).Enabled = False
            Toolbar.Items(1).Enabled = True
            Toolbar.Items(2).Enabled = True
            Toolbar.Items(3).Enabled = True
            'PopupMenu.Items(1).Enabled = True
            'PopupMenu.Items(2).Enabled = True
        End If

        Toolbar.Items(0).Enabled = False
        Toolbar.Items(2).Enabled = True

        Me.Cursor = Cursors.Default
        View.ResumeLayout()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtCariData_Enter(sender As Object, e As EventArgs) Handles txtCariData.Enter
        txtCariData.SelectAll()
    End Sub

    Private Sub View_MouseDown(sender As Object, e As MouseEventArgs) Handles View.MouseDown
        'If e.Button = MouseButtons.Right Then
        '    Dim P As Point = New Point(e.X, e.Y)
        '    PopupMenu.Show(View, P)
        'End If
    End Sub

    Private Sub View_DoubleClick(sender As Object, e As EventArgs) Handles View.DoubleClick
        If View.RowCount > 0 Then
            Execute("btEdit")
        End If
    End Sub

    Private Sub FrmUserSettingBrowse_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.F5
                Execute("btRefresh")
            Case Keys.F7
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
            Case Keys.F8
                Execute("btDelete")
        End Select
    End Sub

    Private Sub View_KeyDown(sender As Object, e As KeyEventArgs) Handles View.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                Execute("btRefresh")
            Case Keys.F7
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
            Case Keys.F8
                Execute("btDelete")
            Case Keys.Enter
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
        End Select
    End Sub
    Private Sub Execute(ByVal ID As String)

        'PopupMenu.Hide()

        Select Case ID
            Case "btEdit", "btEditCTXM"
                Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
                'Dim UserName As String = If(View.Rows.Count = 0, "", View(1, View.CurrentCell.RowIndex).Value.ToString())
                'Dim Karyawanid As String = If(View.Rows.Count = 0, "", View(3, View.CurrentCell.RowIndex).Value.ToString())
                Dim FormEdit As New FrmUserSetting(DataKey)

                FormEdit.ShowDialog()
                If FormEdit.IDData <> "" Then
                    ShowData(FormEdit.IDData)
                End If
            Case "btAdd", "btAddCTXM"
                Dim FormAdd As New FrmUserSetting("")
                FormAdd.ShowDialog()

                If FormAdd.IDData <> "" Then
                    ShowData(FormAdd.IDData)
                End If
                'If FormEdit.IDData <> "" Then
                '    ShowData(FormEdit.IDData)
                'End If
            Case "btRefresh", "btRefreshCTXM"
                ShowData()
                If View.RowCount > 0 Then
                    View.Focus()
                End If
            Case "btDelete", "btRefreshCTXM"
                Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
                Dim DarftarUserkry As New UserKaryawan(ActiveSession)
                DarftarUserkry.Delete(DataKey)
                ShowData()
        End Select
    End Sub

    Private Sub cboDept_KeyUp(sender As Object, e As KeyEventArgs)
        'ComboBagian()
    End Sub
    Private Sub cboDept_LostFocus(sender As Object, e As EventArgs)
        'ComboBagian()
    End Sub
    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs)
        ShowData()
    End Sub

    Private Sub txtCariData_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariData.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ShowData()
        End Select
    End Sub

    Private Sub View_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles View.KeyPress

    End Sub

    Private Sub FrmUserSettingBrowse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.F5)
                Execute("btRefresh")
            Case Microsoft.VisualBasic.ChrW(Keys.F7)
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
        End Select
    End Sub

    Private Sub Toolbar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub
End Class