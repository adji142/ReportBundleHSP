Imports HSPProduction.HSP.Data

Public Class frmMonitoringHasilProduksi
    Private WithEvents txtTglMulai As New DateTimePicker

    'Form Load
    Private Sub frmDaftarMutasiRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items.Insert(10, New ToolStripControlHost(txtTglMulai))
        txtTglMulai.Format = DateTimePickerFormat.Custom
        txtTglMulai.CustomFormat = "dd/MM/yyyy"
        txtTglMulai.Width = 95
        txtTglMulai.Value = New Date(Now.Year, Now.Month, 1)
        txtTglMulai.TabStop = True

        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        cboStatus.SelectedIndex = 0
        FillCombo()
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet

        Dim DaftarUnit As New DaftarUnitProduksi(ActiveSession)

        DS = DaftarUnit.Read("%")
        cboProduksi.ComboBox.DataSource = DS.Tables("View")
        cboProduksi.ComboBox.DisplayMember = "Unit Produksi"
        cboProduksi.ComboBox.ValueMember = "Kode"
    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Form Show
    Private Sub frmDaftarMutasiRoll_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmDaftarMutasiRoll_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
        Dim KodeUnitSAP = New DaftarUnitProduksi(ActiveSession).Find(cboProduksi.ComboBox.SelectedValue).KodeUnitSAP

        Dim MonPPIC As New SAPPPIC()
        Dim BS As New BindingSource
        Dim DataSet As DataSet = MonPPIC.ReadMonitoringHasilProduksiWO(txtCariData.Text, KodeUnitSAP, cboStatus.ComboBox.Text, txtTglMulai.Value.Date)

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
            BS.Position = BS.Find("Nomor", ID)
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
            Toolbar.Items(1).Enabled = True
            Toolbar.Items(2).Enabled = True
            PopupMenu.Items(1).Enabled = True
            PopupMenu.Items(2).Enabled = True
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
        If e.ClickedItem.Name = "btExcel" Then
            ExportToExcel()
        Else
            Execute(e.ClickedItem.Name)
        End If
    End Sub

    'Tampilkan Popupmenu Jika Klik Kanan
    Private Sub View_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles View.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim P As Point = New Point(e.X, e.Y)
            PopupMenu.Show(View, P)
        End If
    End Sub

    'Jika Ditekan Tombol Tertentu
    Private Sub frmDaftarMutasiRoll_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F12
                '---------------------------------------------------------------------------------------------------------
                ExportToExcel()
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Eksekusi Menu
    Private Sub Execute(ByVal ID As String)

        PopupMenu.Hide()

        Select Case ID
            Case "btRefresh", "btRefreshCTXM"

                '---------------------------------------------------------------------------------------------------------
                ShowData()
                If View.RowCount > 0 Then
                    View.Focus()
                End If
                '---------------------------------------------------------------------------------------------------------

        End Select
    End Sub

    Private Sub View_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles View.RowPostPaint

        If Me.View.Rows(e.RowIndex).Cells("Kebutuhan").Value = 0 Then
            Me.View.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        End If

        If Me.View.Rows(e.RowIndex).Cells("Order").Value < Me.View.Rows(e.RowIndex).Cells("Penyelesaian").Value Then
            Me.View.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(254, 202, 201)
        End If

    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If cboStatus.SelectedIndex > 0 Then
            Toolbar.Items(9).Visible = True
            Toolbar.Items(10).Visible = True
            Toolbar.Items(11).Visible = True
        Else
            Toolbar.Items(9).Visible = False
            Toolbar.Items(10).Visible = False
            Toolbar.Items(11).Visible = False
        End If
    End Sub

    Private Sub ExportToExcel()
        Dim App_xls As Object
        Dim Lig_cpt, Col_cpt As Integer

        Me.Cursor = Cursors.WaitCursor

        Try
            App_xls = CreateObject("Excel.Application")
            App_xls.workbooks.add()

            App_xls.visible = True

            For Col_cpt = 0 To View.ColumnCount - 1
                App_xls.ActiveSheet.cells(1, Col_cpt + 1).value = View.Columns(Col_cpt).HeaderText
            Next
            For Lig_cpt = 0 To View.Rows.Count - 1
                For Col_cpt = 0 To View.ColumnCount - 1
                    If Col_cpt = 0 Or Col_cpt = 1 Then
                        App_xls.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = "'" & View.Item(Col_cpt, Lig_cpt).Value
                    Else
                        If IsNumeric(View.Item(Col_cpt, Lig_cpt).Value) Then
                            App_xls.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = CDbl(View.Item(Col_cpt, Lig_cpt).Value)
                        Else
                            App_xls.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = View.Item(Col_cpt, Lig_cpt).Value
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub
End Class