Imports AppUserSetting.HSP.Data

Public Class frmLookup
    'Data Public
    Public IDLookup As String = ""
    Public IDLookupALT As String = ""

    'Data Private
    Private _LookupDataService As IDataLookup = Nothing
    Private _LookupParameter() As Object
    Private _ColumnKey As Byte

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal LookupDataService As Object, Optional ByVal LookupParameter() As Object = Nothing)
        Me.New()
        _LookupDataService = LookupDataService
        _LookupParameter = LookupParameter
    End Sub

    'Form Load
    Private Sub frmLookup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Toolbar.Visible Then
            View.Location = New Point(0, 0)
            View.Size = New Size(836, Toolbar.Height + 215)
        End If
        View.SettingID = FormID(Me.Text)
    End Sub

    'Menampilkan Form
    Private Sub frmLookup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Refresh()

        View.EnableHeadersVisualStyles = True
        View.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised

        ShowData()
        View.SetColumnOrder()
        If View.Columns(0).HeaderText = "RowID" Then
            View.Columns(0).Visible = False
        End If

    End Sub

    'Form ID
    Private Function FormID(Text As String) As String
        Dim nPos As Integer = Text.IndexOf("|")
        Return If(nPos = -1, Text, Text.Substring(0, nPos)).Trim()
    End Function

    'Form Deactivate
    Private Sub frmLookup_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        View.SaveColumnOrder()
        Me.Dispose()
    End Sub

    'Jika Ditekan Escape
    Private Sub frmLookup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    'Tampilkan Data
    Private Sub ShowData()
        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Cek Kriteria
        Dim Kriteria As String = txtCariData.Text.Trim()

        Kriteria = Space(1) + Kriteria.Trim() + Space(1)
        Kriteria = Kriteria.Replace(" ", "%")

        'Tampilkan Data
        Dim DataTable As DataTable = _LookupDataService.GetLookup(Kriteria, _LookupParameter).Tables("Lookup")

        View.DataSource = Nothing
        View.RowTemplate.Height = 16
        View.DataSource = DataTable

        Dim Column As DataColumn
        For Each Column In DataTable.Columns
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

        Me.Refresh()

        'Tampilkan Jumlah Baris
        lblStatus.Text = "Total : " + View.RowCount.ToString() + " Baris"

        View.ResumeLayout()

        'Cek Jumlah Data
        If View.RowCount = 0 Then
            btOK.Enabled = False
            txtCariData.Focus()
            txtCariData.SelectAll()
        Else
            btOK.Enabled = True
            SendKeys.Send("{UP}")
            View.Focus()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    'Jika Double Click
    Private Sub View_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles View.DoubleClick
        If btOK.Enabled Then
            btOK.PerformClick()
        End If
    End Sub

    'Jika Ditekan Enter, F5 Atau F9
    Private Sub View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles View.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                _LookupParameter = Nothing
                If btOK.Enabled Then btOK.PerformClick()
            Case Keys.F5
                _LookupParameter = Nothing
                Toolbar.Items("btRefresh").PerformClick()
            Case Keys.F9
                txtCariData.Focus()
        End Select

    End Sub

    'Jika Tombol Refresh Di Click
    Private Sub Toolbar_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked
        If e.ClickedItem.Name = "btRefresh" Then
            _LookupParameter = Nothing
            View.SaveColumnOrder()
            ShowData()
            View.SetColumnOrder()
        End If
    End Sub

    'Jika Kriteria Aktif/Focus
    Private Sub txtCariData_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCariData.Enter
        txtCariData.SelectAll()
    End Sub

    'Jika Enter Ditekan
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Toolbar.Items("btRefresh").PerformClick()
        End If
    End Sub

    'Jika Dipilih
    Private Sub btOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btOK.Click
        IDLookup = View(0, View.CurrentCell.RowIndex).Value
        If View.Columns(0).HeaderText = "RowID" Then
            IDLookupALT = View(1, View.CurrentCell.RowIndex).Value
        Else
            IDLookupALT = IDLookup
        End If
    End Sub

    'Jika Batal
    Private Sub btClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btClose.Click
        IDLookup = ""
        IDLookupALT = ""
        Me.Close()
    End Sub

End Class