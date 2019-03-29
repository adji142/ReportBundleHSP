Imports AppUserSetting.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports Microsoft.Win32
Imports HSPKPI.HSP.Data
Imports System.Text.RegularExpressions

Public Class FrmTambahLokasiUser
    Dim XStatus As String = ""
    'Form Load
    Private Sub FrmTambahLokasiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColumnHeader()
    End Sub
    Private Sub SetColumnHeader()
        GridUser.BorderStyle = Windows.Forms.BorderStyle.None
        GridUser.Rows = 150
        GridUser.HeadersVisualStyles = True
        GridUser.AlternatingDataGridBackColor = Color.White

        GridUser.AddColumnHeader("UserName", 13, 13, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.AddColumnHeader("Nama User", 35, 35, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.AddColumnHeader("Kode Lokasi", 15, 20, GridColumnStyle.csInputWithLookup, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.AddColumnHeader("Nama Lokasi", 25, 25, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)

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
        Dim DaftarStatus As New GetAllUser(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarStatus.Read(txtCariData.Text)
        GridUser.Clear()
        For Each DR As DataRow In DataSet.Tables(0).Rows
            If Row = GridUser.Rows Then
                GridUser.DataGridView.Rows.Add()
            End If

            GridUser.GridValue(0, Row) = DR("KodeUser")
            GridUser.GridValue(1, Row) = DR("NamaUser")
            GridUser.GridValue(2, Row) = DR("KodeLokasi")
            GridUser.GridValue(3, Row) = DR("NamaLokasi")

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

        Select ID
            Case "btRefresh", "btRefreshCTXM"

                '---------------------------------------------------------------------------------------------------------
                ShowData()
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
        Dim DaftarLokasi As AppUserSetting.HSP.Data.IDataLookup = New SAPLokasi()
        Dim Parameter() As String = {GridUser.GridValue(2, Row)}

        Dim Form As New frmLookupLokasi(DaftarLokasi, Parameter)
        Form.Text = "Lookup Lokasi"
        Form.ShowDialog()

        If Form.IDLookup <> "" Then
            GridUser.SetGridCellLookupResult(Col, Row, Form.IDLookup)
            GridUser.SetGridCellLookupResult(3, Row, Form.NamaLokasi)
        End If
    End Sub

    Private Sub GridUser_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles GridUser.GridCellPostValidation
        Dim Lokasi As New SAPLokasi()
        Dim Dataset As DataSet = Lokasi.Read(GridUser.GridValue(2, Row))

        If Dataset.Tables(0).Rows.Count > 0 Then
            GridUser.GridValue(2, Row) = Dataset.Tables(0).Rows(0)(0).ToString()
            GridUser.GridValue(3, Row) = Dataset.Tables(0).Rows(0)(1).ToString()
        ElseIf GridUser.GridValue(2, Row) = "" Then
            GridUser.GridValue(3, Row) = ""
        Else
            MessageBox.Show("Lokasi Tidak ditemukan.")
            GridUser.GridValue(2, Row) = ""
            GridUser.GridValue(3, Row) = ""
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name

            Case "btSave"
                Dim Delete As New GetAllUser(ActiveSession)
                Delete.Delete()
                Dim Adduser As New GetAllUser(ActiveSession)
                Dim userdata As UserLokasi
                For Row = 0 To GridUser.GridLastRow - 1
                    If GridUser.GridValue(3, Row) <> "" Then
                        userdata = New UserLokasi()
                        userdata.KodeLokasi = GridUser.GridValue(2, Row)
                        userdata.KodeUser = GridUser.GridValue(0, Row)
                        userdata.NamaLokasi = GridUser.GridValue(3, Row)
                        Try
                            Adduser.Add(userdata)
                            XStatus = "Complate"
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            XStatus = ex.Message
                        End Try
                    End If
                Next
                If XStatus = "Complate" Then
                    MessageBox.Show("Data Sudah Tersimpan")
                    btRefresh.PerformClick()
                Else
                    MessageBox.Show(XStatus)
                End If
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
End Class