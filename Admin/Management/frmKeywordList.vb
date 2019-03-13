
' ---------------------------------------------------------------------------------------------------------
' Nama File   : frmKeywordList.vb
' Deskripsi   : Form Untuk Menampilkan Daftar Keyword
' Author      : Yudy Patrianto
' Tool        : VB.NET 
' Database    : MySQL 5.x  
' Tanggal     : 27 Januari 2011
' ----------------------------------------------------------------------------------------------------------- 

Imports BOTSRV.Data

Public Class frmKeywordList

    'Form Load
    Private Sub frmKeywordList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        FillCombo()
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim PluginList As New PluginList(ActiveSession)

        Dim DS As DataSet = PluginList.Read("%")
        cboPluginID.ComboBox.DataSource = DS.Tables("View")
        cboPluginID.ComboBox.DisplayMember = "Description"
        cboPluginID.ComboBox.ValueMember = "ID"
        cboPluginID.ComboBox.SelectedValue = ""

        Dim Drow As DataRow = DS.Tables("View").Rows.Add()
        Drow("ID") = ""
        Drow("Description") = "<All>"

        cboPluginID.ComboBox.SelectedIndex = cboPluginID.ComboBox.Items.Count - 1
    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Form Show
    Private Sub frmKeywordList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmKeywordList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
        Dim KeywordList As New KeywordList(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = KeywordList.Read(txtCariData.Text, cboPluginID.ComboBox.SelectedValue)

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
            BS.Position = BS.Find("Keyword", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Record : " + View.RowCount.ToString + " Rows"

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
    Private Sub Toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolBar.ItemClicked, PopupMenu.ItemClicked
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
    Private Sub frmKeywordList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F6, Keys.Insert
                '---------------------------------------------------------------------------------------------------------
                Execute("btAdd")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F7
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F8, Keys.Delete
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    Execute("btDelete")
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

        Me.Cursor = Cursors.WaitCursor
        PopupMenu.Hide()

        Select Case ID
            Case "btAdd", "btAddCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim FormAdd As New frmKeyword("", cboPluginID.ComboBox.SelectedValue)
                FormAdd.ShowDialog()

                If FormAdd.IDData <> "" Then
                    ShowData(FormAdd.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btEdit", "btEditCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim FormEdit As New frmKeyword(DataKey, cboPluginID.ComboBox.SelectedValue)
                FormEdit.ShowDialog()

                If FormEdit.IDData <> "" Then
                    ShowData(FormEdit.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btDelete", "btDeleteCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim DKP As New KeywordList(ActiveSession)

                If DKP.Locked(View(0, View.CurrentCell.RowIndex).Value) Then
                    MessageBox.Show("Data Ini Telah Digunakan Data Lain, Hapus Tidak Dapat Dilakukan ! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    SendKeys.Send("{RIGHT}")
                    If MessageBox.Show("Delete This Row ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        DKP.Delete(View(0, View.CurrentCell.RowIndex).Value)
                        View.Rows.RemoveAt(View.CurrentCell.RowIndex)

                        If View.RowCount = 0 Then
                            ShowData()
                        Else
                            If View.CurrentCell.RowIndex > 1 Then
                                SendKeys.Send("{UP}+{DOWN}")
                            End If
                            Status.Text = "Record : " + View.RowCount.ToString + " Rows"
                        End If
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

        Me.Cursor = Cursors.Default
    End Sub

End Class