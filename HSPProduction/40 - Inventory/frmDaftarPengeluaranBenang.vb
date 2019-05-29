Imports HSPProduction.HSP.Data

Public Class frmDaftarPengeluaranBenang
    Private WithEvents txtTglSistem As New DateTimePicker
    Private WithEvents txtTglTransaksi As New DateTimePicker

    'Fill Combo
    Private Sub FillCombo()
        Dim DaftarShift As New DaftarShiftProduksi(ActiveSession)

        Dim DS As DataSet = DaftarShift.Read("%")
        cboKodeShift.ComboBox.DataSource = DS.Tables("View")
        cboKodeShift.ComboBox.DisplayMember = "Nama Shift"
        cboKodeShift.ComboBox.ValueMember = "Kode"
    End Sub

    'Form Load
    Private Sub frmDaftarPemakaianBahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        Toolbar.Items.Insert(6, New ToolStripControlHost(txtTglSistem))
        txtTglSistem.Format = DateTimePickerFormat.Custom
        txtTglSistem.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        txtTglSistem.Width = 150
        txtTglSistem.Value = Now
        txtTglSistem.Enabled = False

        Toolbar.Items.Insert(8, New ToolStripControlHost(txtTglTransaksi))
        txtTglTransaksi.Format = DateTimePickerFormat.Custom
        txtTglTransaksi.CustomFormat = "dd/MM/yyyy"
        txtTglTransaksi.Width = 95
        txtTglTransaksi.Value = Now.Date
        txtTglTransaksi.Enabled = False

        FillCombo()
    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Form Show
    Private Sub frmDaftarPemakaianBahan_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call tmrJam_Tick(Nothing, Nothing)

        'Permintaan
        Me.Refresh()
        ViewPermintaan.SettingID = Me.Name + "Permintaan"
        SetHeaderView(ViewPermintaan)
        ShowDataPermintaan()
        ViewPermintaan.SetColumnOrder()

        'Pengeluaran
        ViewPengeluaran.SettingID = Me.Name + "Pengeluaran"
        SetHeaderView(ViewPengeluaran)
        ShowDataPengeluaran()
        ViewPengeluaran.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmDaftarPemakaianBahan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ViewPermintaan.SaveColumnOrder()
        ViewPengeluaran.SaveColumnOrder()
    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowDataPermintaan(Optional ByVal ID As String = "")

        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        Me.Cursor = Cursors.WaitCursor
        ViewPermintaan.SuspendLayout()

        'Baca Data
        Dim DaftarPermintaanBenang As New DaftarPermintaanBenang(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarPermintaanBenang.Read(txtCariData.Text, txtTglSistem.Value.Date, cboKodeShift.ComboBox.SelectedValue)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        ViewPermintaan.RowTemplate.Height = 16
        ViewPermintaan.DataSource = BS

        'Format Kolom
        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                ViewPermintaan.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                ViewPermintaan.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ViewPermintaan.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                ViewPermintaan.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                ViewPermintaan.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewPermintaan.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        'Set Posisi Baris Aktif
        If ID <> "" Then
            BS.Position = BS.Find("Nomor", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + ViewPermintaan.RowCount.ToString + " Baris"

        'Enable/Disable Menu
        If ViewPermintaan.RowCount = 0 Then
            Toolbar.Items(1).Enabled = False
            Toolbar.Items(2).Enabled = False
            PopupMenu.Items(1).Enabled = False
            PopupMenu.Items(2).Enabled = False

            If txtCariData.Focused Then
                txtCariData.SelectAll()
            End If
        Else
            Toolbar.Items(1).Enabled = True
            Toolbar.Items(2).Enabled = True
            PopupMenu.Items(1).Enabled = True
            PopupMenu.Items(2).Enabled = True
        End If

        Toolbar.Items(0).Enabled = True
        Toolbar.Items(3).Enabled = True

        Me.Cursor = Cursors.Default
        ViewPermintaan.ResumeLayout()

    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowDataPengeluaran(Optional ByVal ID As String = "")
        Me.Cursor = Cursors.WaitCursor
        ViewPengeluaran.SuspendLayout()

        'Baca Data
        Dim DaftarPengeluaranBenang As New DaftarPengeluaranBenang(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarPengeluaranBenang.Read(txtCariData.Text, txtTglTransaksi.Value.Date, cboKodeShift.ComboBox.SelectedValue)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        ViewPengeluaran.RowTemplate.Height = 16
        ViewPengeluaran.DataSource = BS

        'Format Kolom
        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                ViewPengeluaran.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                ViewPengeluaran.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ViewPengeluaran.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                ViewPengeluaran.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                ViewPengeluaran.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewPengeluaran.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + ViewPengeluaran.RowCount.ToString + " Baris"

        Me.Cursor = Cursors.Default
        ViewPengeluaran.ResumeLayout()

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
    Private Sub View_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ViewPermintaan.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim P As Point = New Point(e.X, e.Y)
            PopupMenu.Show(ViewPermintaan, P)
        End If
    End Sub

    'Jika Ditekan DoubleClick
    Private Sub View_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewPermintaan.DoubleClick
        If ViewPermintaan.RowCount > 0 Then
            Execute("btEdit")
        End If
    End Sub

    'Jika Ditekan Tombol Tertentu
    Private Sub frmDaftarPemakaianBahan_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F7
                '---------------------------------------------------------------------------------------------------------
                If ViewPermintaan.RowCount > 0 Then
                    Execute("btEdit")
                End If
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Jika Area View Ditekan Tombol Tertentu
    Private Sub View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ViewPermintaan.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                '---------------------------------------------------------------------------------------------------------
                If ViewPermintaan.RowCount > 0 Then
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
                'Dim FormAdd As New frmPengeluaranBenang("")
                'FormAdd.ShowDialog()

                'If FormAdd.IDData <> "" Then
                '    ShowDataPengeluaran(FormAdd.IDData)
                'End If
                '---------------------------------------------------------------------------------------------------------
            Case "btEdit", "btEditCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim DataKey As String = If(ViewPermintaan.Rows.Count = 0, "", ViewPermintaan(0, ViewPermintaan.CurrentCell.RowIndex).Value.ToString())

                'Dim FormEdit As New frmPengeluaranBenang(DataKey)
                Dim FormEdit As New frmTransferBenangKeluar(DataKey)
                FormEdit.ShowDialog()

                If FormEdit.IDData <> "" Then
                    ShowDataPengeluaran(FormEdit.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btRefresh", "btRefreshCTXM"

                '---------------------------------------------------------------------------------------------------------
                ShowDataPermintaan()
                If ViewPermintaan.RowCount > 0 Then
                    ViewPermintaan.Focus()
                End If
                '---------------------------------------------------------------------------------------------------------

                '---------------------------------------------------------------------------------------------------------
                ShowDataPengeluaran()
                If ViewPengeluaran.RowCount > 0 Then
                    ViewPengeluaran.Focus()
                End If
                '---------------------------------------------------------------------------------------------------------

        End Select
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = Now.ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                cboKodeShift.ComboBox.SelectedValue = 3
                txtTglTransaksi.Value = DateAdd("D", -1, Now.Date)
            Else
                cboKodeShift.ComboBox.SelectedValue = 1
                txtTglTransaksi.Value = Now.Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                cboKodeShift.ComboBox.SelectedValue = 1
                txtTglTransaksi.Value = Now.Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                cboKodeShift.ComboBox.SelectedValue = 2
                txtTglTransaksi.Value = Now.Date
            Else
                cboKodeShift.ComboBox.SelectedValue = 3
                txtTglTransaksi.Value = Now.Date
            End If
        End If
    End Sub
End Class