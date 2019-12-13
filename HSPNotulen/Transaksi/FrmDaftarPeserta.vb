Imports HSPNotulen.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports Microsoft.Win32

Imports System.Text.RegularExpressions

Public Class FrmDaftarPeserta
    Public _ID As String
    Public _Success As Boolean

    Public _DataPeserta As DataSet
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub
    Public Sub New(ByVal ID As String, Data As DataSet)
        Me.New()
        Me.Tag = Me.Text
        _DataPeserta = New DataSet
        _ID = ID
        _DataPeserta = Data
    End Sub

    Dim XStatus As String = ""
    'Form Load
    Private Sub FrmTambahLokasiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColumnHeader()
    End Sub
    Private Sub SetColumnHeader()
        GridUser.BorderStyle = Windows.Forms.BorderStyle.None
        GridUser.Rows = 30
        GridUser.HeadersVisualStyles = True
        GridUser.AlternatingDataGridBackColor = Color.White

        GridUser.AddColumnHeader("NIK", 15, 15, GridColumnStyle.csInputWithLookup, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.AddColumnHeader("Nama Peserta", 35, 35, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.ShowHeader()
    End Sub
    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown

        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Form Show
    Private Sub FrmTambahLokasiUser_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        'View.SettingID = Me.Name

        'etHeaderView(View)

        ShowData()
        'View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub FrmTambahLokasiUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'View.SaveColumnOrder()
    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowData(Optional ByVal ID As String = "")
        'Baca Data
        Dim Row As Integer = 0
        Dim DaftarPeserta As New NotulenModels(ActiveSession)
        Dim BS As New BindingSource
        'Dim DataSet As DataSet = DaftarPeserta.Read_peserta(txtCariData.Text, _ID.ToString)
        Dim DataSet As DataSet = _DataPeserta
        GridUser.Clear()
        For Each DR As DataRow In DataSet.Tables(0).Rows
            If Row = GridUser.Rows Then
                GridUser.DataGridView.Rows.Add()
            End If

            GridUser.GridValue(0, Row) = DR("nik")
            GridUser.GridValue(1, Row) = DR("NamaPeserta")

            Row += 1
        Next
    End Sub

    'Jika Kriteria Selesai Diisikan            
    Private Sub txtCariData_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCariData.Enter
        txtCariData.SelectAll()
    End Sub

    'Jika Toolbar Di Click
    Private Sub Toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked, PopupMenu.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub
    'Jika Ditekan Tombol Tertentu
    Private Sub FrmTambahLokasiUser_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
        End Select
    End Sub

    'Jika Area View Ditekan Tombol Tertentu
    Private Sub View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Select Case e.KeyCode
            Case Keys.Enter
                '---------------------------------------------------------------------------------------------------------
                'If View.RowCount > 0 Then
                '    e.Handled = True
                '    Execute("btEdit")
                'End If
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Eksekusi Menu
    Private Sub Execute(ByVal ID As String)

        'Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
        ''Dim GroupKey As String = cboUnitProduksi.ComboBox.SelectedValue

        'PopupMenu.Hide()

        Select Case ID
            Case "btRefresh", "btRefreshCTXM"

                '---------------------------------------------------------------------------------------------------------
                ShowData()
            Case "btDatangCTXM"
                MessageBox.Show(GridUser.Rows)
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    Private Sub View_EditModeChanged(sender As Object, e As EventArgs)
        'If (View(2, View.CurrentCell.RowIndex).Value) Then
        '    MessageBox.Show("")
        'End If
    End Sub

    Private Sub View_CellLeave(sender As Object, e As DataGridViewCellEventArgs)
        'If (View(2, View.CurrentCell.RowIndex).Value <> "") Then
        '    Dim GetDataWH As New SAPLokasi()
        '    Dim BS As New BindingSource
        '    Dim DataSet As DataSet = GetDataWH.Read(View(3, View.CurrentCell.RowIndex).Value.ToString)
        '    'View.Columns(4).Visible = False
        '    If (DataSet.Tables(0).Rows.Count > 0) Then

        '        View(3, View.CurrentCell.RowIndex).Value = DataSet.Tables(0).Rows(0)(0).ToString()
        '        View(4, View.CurrentCell.RowIndex).Value = DataSet.Tables(0).Rows(0)(1).ToString()
        '    End If
        'End If
    End Sub

    Private Sub GridUser_GridCellLookup(Col As Integer, Row As Integer) Handles GridUser.GridCellLookup
        Dim DaftarKry As IDataLookup = New DaftarHRKaryawan()
        Dim Parameter() As String = {DaftarHRKaryawan.enumLookupKaryawan.DaftarKaryawan, "", ""}

        Dim Form As New frmLookup(DaftarKry, Parameter)
        Form.Text = "Lookup Karyawan"
        Form.ShowDialog()

        If Form.IDLookup Then
            GridUser.SetGridCellLookupResult(Col, Row, Form.IDLookup)
            Dim NIK As String = GridUser.GridValue(0, Row)

            Dim DaftarKaryawan As New DaftarHRKaryawan()
            Dim ListKaryawan As HRKaryawan = DaftarKaryawan.FindKaryawan(NIK)

            If Not IsNothing(ListKaryawan) Then
                GridUser.SetGridCellLookupResult(1, Row, ListKaryawan.NamaKaryawan)
                GridUser.Focus()
                SendKeys.Send("{ENTER}")
            Else
                MessageBox.Show(NIK + "Tidak Valid")
            End If

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub GridUser_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles GridUser.GridCellPostValidation

    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name

            Case "btSave"
                Dim Notulen As New NotulenModels(ActiveSession)
                Dim Exec = Notulen.DeletePeserta(_ID)
                Dim _Peserta As PesertaMeeting
                _DataPeserta.Clear()
                For Row = 0 To GridUser.GridLastRow - 1
                    Dim DR As DataRow = _DataPeserta.Tables(0).NewRow

                    DR("meetingid") = _ID
                    DR("nik") = GridUser.GridValue(0, Row)
                    DR("NamaPeserta") = GridUser.GridValue(1, Row)
                    DR("StatusHadir") = "Hadir"
                    _DataPeserta.Tables(0).Rows.Add(DR)
                    '_Peserta = New PesertaMeeting()
                    '_Peserta.meetingid = _ID
                    '_Peserta.nik = GridUser.GridValue(0, Row)
                    '_Peserta.NamaPeserta = GridUser.GridValue(1, Row)
                    '_Peserta.StatusHadir = "Hadir"
                    'Try
                    '    Notulen.Add_Peserta(_Peserta)
                    '    _Success = True
                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message)
                    '    _Success = False
                    'End Try
                Next
                _Success = True
                Me.Close()
            Case "btClose"
                Me.Close()
        End Select
    End Sub

    Private Sub GridUser_GridKeyDown(ByRef KeyCode As Integer) Handles GridUser.GridKeyDown

    End Sub

    Private Sub GridUser_KeyDown(sender As Object, e As KeyEventArgs) Handles GridUser.KeyDown
        Select Case e.KeyCode
            Case Keys.F10

        End Select
    End Sub

    Private Sub GridUser_MouseDown(sender As Object, e As MouseEventArgs) Handles GridUser.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim P As Point = New Point(e.X, e.Y)
            PopupMenu.Show(GridUser, P)
        End If
    End Sub
End Class