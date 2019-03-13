Imports HSPProduction.HSP.Data

Public Class frmDaftarPembatalanPackingCementBag

    'Form Load
    Private Sub frmDaftarPembatalanPackingCementBag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False

        FillCombo()

        Try
            cboKodeLokasi.ComboBox.SelectedValue = GetSetting(enumFormID.frmPackingCementBag, enumSetting.settingKodeLokasi)
        Catch ex As Exception
            cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
        End Try

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        Dim DaftarUnit As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        'Lokasi
        DS = DaftarLokasi.Read("%", False, True)
        cboKodeLokasi.ComboBox.DataSource = DS.Tables("View")
        cboKodeLokasi.ComboBox.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ComboBox.ValueMember = "Kode"
        cboKodeLokasi.ComboBox.SelectedValue = ""

        Drow = DS.Tables("View").Rows.Add()
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "<Seluruh Lokasi Produksi>"

    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        cboKodeLokasi.KeyDown,
        txtCariData.KeyDown

        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        Execute("btRefresh")
    End Sub

    'Form Show
    Private Sub frmDaftarPembatalanPackingCementBag_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmDaftarPembatalanPackingCementBag_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        View.SaveColumnOrder()
    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowData(Optional ByVal ID As String = "")

        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False

        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Baca Data
        Dim DaftarStockPacking As New DaftarStockPacking(ActiveSession)
        Dim BS As New BindingSource

        Dim KodeLokasi As String
        Try
            KodeLokasi = cboKodeLokasi.ComboBox.SelectedValue
        Catch
            KodeLokasi = ""
        End Try
        Dim DataSet As DataSet = DaftarStockPacking.ReadStock(txtCariData.Text, 2, KodeLokasi)

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
            BS.Position = BS.Find("Kode Produksi", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + View.RowCount.ToString + " Baris"

        'Enable/Disable Menu
        If View.RowCount = 0 Then
            Toolbar.Items(0).Enabled = False
            PopupMenu.Items(0).Enabled = False

            If txtCariData.Focused Then
                txtCariData.SelectAll()
            End If
        Else
            Toolbar.Items(0).Enabled = True
            PopupMenu.Items(0).Enabled = True
        End If

        Toolbar.Items(1).Enabled = True

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

    'Jika Ditekan Tombol Tertentu
    Private Sub frmDaftarPembatalanPackingCementBag_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Eksekusi Menu
    Private Sub Execute(ByVal ID As String)

        Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())

        PopupMenu.Hide()

        Select Case ID
            Case "btDelete", "btDeleteCTXM"

                'Penghapusan Data Produksi
                '---------------------------------------------------------------------------------------------------------
                Dim FormDelete As New frmPembatalanPackingCementBag(DataKey)
                FormDelete.ShowDialog()

                If FormDelete.IDData <> "" Then
                    ShowData()
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