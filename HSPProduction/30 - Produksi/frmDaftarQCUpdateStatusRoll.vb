Imports HSPProduction.HSP.Data

Public Class frmDaftarQCUpdateStatusRoll

    'Form Load
    Private Sub frmDaftarQCUpdateStatusRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        cboStatus.ComboBox.SelectedIndex = 0
        FillCombo()

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        Dim DaftarUnit As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        'Lokasi
        DS = DaftarLokasi.Read("%", False, True)
        cboLokasi.ComboBox.DataSource = DS.Tables("View")
        cboLokasi.ComboBox.DisplayMember = "Nama Lokasi"
        cboLokasi.ComboBox.ValueMember = "Kode"
        cboLokasi.ComboBox.SelectedValue = ""

        Drow = DS.Tables("View").Rows.Add()
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "<Seluruh Lokasi Produksi>"

        cboLokasi.ComboBox.SelectedIndex = cboLokasi.ComboBox.Items.Count - 1

    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
                           cboStatus.KeyDown,
                           cboLokasi.KeyDown,
                           txtCariData.KeyDown

        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        Execute("btRefresh")
    End Sub

    'Form Show
    Private Sub frmDaftarQCUpdateStatusRoll_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmDaftarQCUpdateStatusRoll_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        View.SaveColumnOrder()
    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowData(Optional ByVal ID As String = "")

        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Baca Data
        Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarStockRoll.Read(txtCariData.Text, cboStatus.ComboBox.SelectedIndex, cboLokasi.ComboBox.SelectedValue)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        View.RowTemplate.Height = 16
        View.DataSource = BS

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
            BS.Position = BS.Find("Kode", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + View.RowCount.ToString + " Baris"

        'Enable/Disable Menu
        If View.RowCount = 0 Then
            Toolbar.Items(1).Enabled = False
            Toolbar.Items(2).Enabled = False
            PopupMenu.Items(1).Enabled = False
            PopupMenu.Items(2).Enabled = False

            If txtCariData.Focused Then
                txtCariData.SelectAll()
            End If
        Else
            If cboStatus.SelectedIndex < 2 Then
                Toolbar.Items(1).Enabled = True
                Toolbar.Items(2).Enabled = True
                PopupMenu.Items(1).Enabled = True
                PopupMenu.Items(2).Enabled = True
            Else
                Toolbar.Items(1).Enabled = False
                Toolbar.Items(2).Enabled = False
                PopupMenu.Items(1).Enabled = False
                PopupMenu.Items(2).Enabled = False
            End If
        End If

        Toolbar.Items(0).Enabled = True
        Toolbar.Items(3).Enabled = True

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
    Private Sub frmDaftarQCUpdateStatusRoll_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
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

        Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
        Dim GroupKey As String = cboLokasi.ComboBox.SelectedValue

        PopupMenu.Hide()

        Select Case ID
            Case "btEdit", "btEditCTXM"

                'Inspeksi
                '---------------------------------------------------------------------------------------------------------
                If cboStatus.SelectedIndex + 1 = 1 Then
                    Dim FormEdit As New frmQCInspeksiRoll(DataKey)
                    FormEdit.ShowDialog()

                    If FormEdit.IDData <> "" Then
                        ShowData(FormEdit.IDData)
                    End If
                End If

                'Disposisi
                '---------------------------------------------------------------------------------------------------------
                If cboStatus.SelectedIndex + 1 = 2 Then
                    Dim FormEdit As New frmQCDisposisiRoll(DataKey)
                    FormEdit.ShowDialog()

                    If FormEdit.IDData <> "" Then
                        ShowData(FormEdit.IDData)
                    End If
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

End Class