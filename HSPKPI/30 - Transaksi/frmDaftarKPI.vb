Imports HSPKPI.HSP.Data

Public Class frmDaftarKPI
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        ComboBagian()

        'Unit Produksi
        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet
        DS = DaftarDept.Read("%")
        cboDept.ComboBox.DataSource = DS.Tables("View")
        cboDept.ComboBox.DisplayMember = "Departemen"
        cboDept.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Departemen") = "<SEMUA DEPARTEMEN>"

        cboDept.ComboBox.SelectedValue = ""

    End Sub

    Private Sub ComboBagian()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Unit Produksi
        Dim DaftarBagian As New DaftarHRBagian()
        DS = New DataSet
        DS = DaftarBagian.Read("%", cboDept.ComboBox.SelectedValue)
        cboBagian.ComboBox.DataSource = DS.Tables("View")
        cboBagian.ComboBox.DisplayMember = "Nama Bagian"
        cboBagian.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Bagian") = "<SEMUA BAGIAN>"

        cboBagian.ComboBox.SelectedValue = ""
    End Sub

    'Form Load
    Private Sub frmDaftarKPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False
        FillMonth(cboBulan)
        FillYear(cboTahun)
        FillCombo()
    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Form Show
    Private Sub frmDaftarKPI_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmDaftarKPI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        View.SaveColumnOrder()
    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowData(Optional ByVal ID As String = "")
        Dim Periode As String = Strings.Right(cboTahun.Text, 4) & Strings.Right("0" & cboBulan.SelectedIndex + 1, 2)
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        'Toolbar.Items(3).Enabled = False

        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Baca Data
        Dim DaftarKPI As New DaftarKPI(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarKPI.ReadTransaction(Periode, txtCariData.Text, cboBagian.ComboBox.SelectedValue.ToString, cboDept.ComboBox.SelectedValue.ToString)

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
            BS.Position = BS.Find("Nomor", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + View.RowCount.ToString + " Baris"

        'Enable/Disable Menu
        If View.RowCount = 0 Then
            Toolbar.Items(1).Enabled = False
            'Toolbar.Items(2).Enabled = False
            PopupMenu.Items(1).Enabled = False
            'PopupMenu.Items(2).Enabled = False

            If txtCariData.Focused Then
                txtCariData.SelectAll()
            End If
        Else
            Toolbar.Items(1).Enabled = True
            'Toolbar.Items(2).Enabled = True
            PopupMenu.Items(1).Enabled = True
            'PopupMenu.Items(2).Enabled = True
        End If

        Toolbar.Items(0).Enabled = True
        Toolbar.Items(2).Enabled = True

        Me.Cursor = Cursors.Default
        View.ResumeLayout()

    End Sub

    'Jika Kriteria Selesai Diisikan            
    Private Sub txtCariData_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCariData.Enter
        txtCariData.SelectAll()
    End Sub

    'Jika Toolbar Di Click
    Private Sub Toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked, PopupMenu.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub

    'Tampilkan Popupmenu Jika Klik Kanan
    Private Sub View_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles View.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim P As Point = New Point(e.X, e.Y)
            PopupMenu.Show(View, P)
        End If
    End Sub

    'Jika Ditekan DoubleClick
    Private Sub View_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles View.DoubleClick
        If View.RowCount > 0 Then
            Execute("btEdit")
        End If
    End Sub

    'Jika Ditekan Tombol Tertentu
    Private Sub frmDaftarKPI_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F7
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Jika Area View Ditekan Tombol Tertentu
    Private Sub View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles View.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    e.Handled = True
                    Execute("btEdit")
                End If
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Eksekusi Menu
    Private Sub Execute(ByVal ID As String)

        PopupMenu.Hide()

        Select Case ID
            Case "btAdd", "btAddCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim FormAdd As New frmKPI("", cboBagian.ComboBox.SelectedValue)
                FormAdd.ShowDialog()

                If FormAdd.IDData <> "" Then
                    ShowData(FormAdd.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------
            Case "btEdit", "btEditCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())

                Dim FormEdit As New frmKPI(DataKey, cboBagian.ComboBox.SelectedValue)

                FormEdit.ShowDialog()

                If FormEdit.IDData <> "" Then
                    ShowData(FormEdit.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btRefresh", "btRefreshCTXM"

                '---------------------------------------------------------------------------------------------------------
                ShowData()
                If View.RowCount > 0 Then
                    View.Focus()
                End If
                '---------------------------------------------------------------------------------------------------------

        End Select
    End Sub

    Private Sub cboDept_KeyUp(sender As Object, e As KeyEventArgs) Handles cboDept.KeyUp
        ComboBagian()
    End Sub

    Private Sub cboDept_LostFocus(sender As Object, e As EventArgs) Handles cboDept.LostFocus
        ComboBagian()
    End Sub

    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDept.SelectedIndexChanged
        ShowData()
    End Sub
End Class