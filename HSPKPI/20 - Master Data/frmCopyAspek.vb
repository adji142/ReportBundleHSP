Imports HSPKPI.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32

Public Class frmCopyAspek
    Private Const _KodeAspek = 0
    Private Const _NamaAspek = 1
    Private Const _KodeBaru = 2

    Private _NoTransaksi As String

    Private Sub frmCopyAspek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()
        FillCombo()
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet

        'Isi Data Dept
        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet
        DS = DaftarDept.Read("%")
        cboDept.DataSource = DS.Tables("View")
        cboDept.DisplayMember = "Departemen"
        cboDept.ValueMember = "Kode"

        cboDept.SelectedIndex = -1

        'Isi Data Kelompok
        Dim DaftarKelompok As New DaftarKelompok(ActiveSession)
        DS = New DataSet
        DS = DaftarKelompok.Read("%")
        cboKelompok.DataSource = DS.Tables("View")
        cboKelompok.DisplayMember = "Kelompok"
        cboKelompok.ValueMember = "Kode"

        cboKelompok.SelectedIndex = -1

    End Sub

    Private Sub ComboDeptKe()
        Dim DS As DataSet

        'Isi Data Dept
        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet
        DS = DaftarDept.Read("%")
        cboDeptKe.DataSource = DS.Tables("View")
        cboDeptKe.DisplayMember = "Departemen"
        cboDeptKe.ValueMember = "Kode"

        cboDeptKe.SelectedIndex = -1
    End Sub

    Private Sub ComboBagian()
        Dim DS As DataSet

        'Isi Data Bagian
        Dim DaftarBagian As New DaftarHRBagian()
        DS = New DataSet
        DS = DaftarBagian.Read("%", cboDept.SelectedValue.ToString)
        cboBagian.DataSource = DS.Tables("View")
        cboBagian.DisplayMember = "Nama Bagian"
        cboBagian.ValueMember = "Kode"

        cboBagian.SelectedIndex = -1
    End Sub

    Private Sub ComboBagianKe()
        Dim DS As DataSet

        'Isi Data Bagian
        Dim DaftarBagian As New DaftarHRBagian()
        DS = New DataSet
        DS = DaftarBagian.Read("%", cboDeptKe.SelectedValue.ToString)
        cboBagianKe.DataSource = DS.Tables("View")
        cboBagianKe.DisplayMember = "Nama Bagian"
        cboBagianKe.ValueMember = "Kode"

        cboBagianKe.SelectedIndex = -1
    End Sub

    Private Sub ComboPosisi()
        Dim DS As DataSet
        'Isi Data Posisi
        Dim DaftarPosisi As New DaftarHRPosisi()
        DS = New DataSet
        DS = DaftarPosisi.Read("%", cboBagian.SelectedValue.ToString)
        cboPosisi.DataSource = DS.Tables("View")
        cboPosisi.DisplayMember = "Nama Posisi"
        cboPosisi.ValueMember = "Kode"

        cboPosisi.SelectedIndex = -1

    End Sub

    Private Sub ComboPosisiKe()
        Dim DS As DataSet
        'Isi Data Posisi
        Dim DaftarPosisi As New DaftarHRPosisi()
        DS = New DataSet
        DS = DaftarPosisi.Read("%", cboBagianKe.SelectedValue.ToString)
        cboPosisiKe.DataSource = DS.Tables("View")
        cboPosisiKe.DisplayMember = "Nama Posisi"
        cboPosisiKe.ValueMember = "Kode"

        cboPosisiKe.SelectedIndex = -1

    End Sub

    Private Sub SetKolomHeader()

        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 10
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White

        Grid.AddColumnHeader("Kode Aspek", 20, 20, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Nama Aspek", 50, 50, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Kode Baru", 25, 5, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caLeft, True)

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                        cboDept.SelectedValueChanged,
                        cboDeptKe.SelectedValueChanged,
                        cboPosisi.SelectedValueChanged,
                        cboBagian.SelectedValueChanged,
                        cboKelompok.SelectedValueChanged,
                        cboBagianKe.SelectedValueChanged,
                        cboPosisiKe.SelectedValueChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboBagian" And cboBagian.SelectedIndex <> -1 Then
            ComboPosisi()
        End If

        If (ObjectName = "cboDept" Or ObjectName = "cboBagian" Or ObjectName = "cboPosisi" Or ObjectName = "cboKelompok") And cboDept.SelectedIndex <> -1 And cboBagian.SelectedIndex <> -1 And cboPosisi.SelectedIndex <> -1 And cboKelompok.SelectedIndex <> -1 Then
            ShowGrid()
        End If

        If ObjectName = "cboDept" And cboDept.SelectedIndex <> -1 Then
            ComboBagian()
            ComboDeptKe()
        End If

        If ObjectName = "cboDeptKe" And cboDeptKe.SelectedIndex <> -1 Then
            ComboBagianKe()
        End If

        If ObjectName = "cboBagianKe" And cboBagianKe.SelectedIndex <> -1 Then
            ComboPosisiKe()
        End If

        SetEnableCommand()
    End Sub

    Private Sub ShowGrid()
        Dim DT As DataTable
        Dim Row As Integer = 0

        _NoTransaksi = cboPosisi.SelectedValue & cboKelompok.SelectedValue

        Dim DaftarAspek As New DaftarAspek(ActiveSession)
        Dim HeaderAspek As HeaderAspek = DaftarAspek.Cek(_NoTransaksi)

        If Not IsNothing(HeaderAspek) Then
            DT = New HSPKPI.HSP.Data.DaftarAspek(ActiveSession).ShowAspek(_NoTransaksi).Tables("View")
            Grid.Clear()
            For Each DR As DataRow In DT.Rows
                If Row = Grid.Rows Then
                    Grid.DataGridView.Rows.Add()
                End If

                Grid.GridValue(_KodeAspek, Row) = DR("KodeAspek")
                Grid.GridValue(_NamaAspek, Row) = DR("NamaAspek")

                Row += 1
            Next
        End If

        'JumlahBarisData()
        'lblBarisData.Text = JumlahBarisData() & " Baris Data"
    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()
        btSave.Enabled = If(cboPosisi.SelectedIndex = -1, False, True) And _
                         If(cboBagian.SelectedIndex = -1, False, True) And _
                         If(cboDept.SelectedIndex = -1, False, True) And _
                         If(cboKelompok.SelectedIndex = -1, False, True) And _
                         If(cboDeptKe.SelectedIndex = -1, False, True) And _
                         If(cboBagianKe.SelectedIndex = -1, False, True) And _
                         If(cboPosisiKe.SelectedIndex = -1, False, True) And _
                         If(JumlahBarisData() = 0, False, True)

    End Sub

    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        For Row = 0 To Grid.GridLastRow - 1

            If Grid.GridValue(_KodeBaru, Row) <> "" Then
                Jumlah += 1
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub Grid_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles Grid.GridCellPostValidation
        SetEnableCommand()
        If Col = _KodeBaru And Valid Then
            Dim DaftarAspek As New DaftarAspek(ActiveSession)
            Dim HeaderAspek As HeaderAspek

            HeaderAspek = DaftarAspek.CekData(Grid.GridValue(_KodeBaru, Row))
            If Not IsNothing(HeaderAspek) Then
                MessageBox.Show("Kode Tersebut sudah Ada !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Grid.GridValue(_KodeBaru, Row) = ""
            End If
        End If
    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                'Simpan 
                '----------------------------------------------------------------------------------------------------
                Dim DaftarAspek As New DaftarAspek(ActiveSession)
                Dim HeaderAspek As HeaderAspek

                For Row = 0 To Grid.GridLastRow - 1

                    If Grid.GridValue(_KodeBaru, Row) <> "" Then

                        'Simpan Transaksi 
                        '-----------------------------------------------------------------------------------
                        'NoUrut += 1

                        HeaderAspek = New HeaderAspek
                        HeaderAspek.KodeAspek = Grid.GridValue(_KodeAspek, Row)
                        HeaderAspek.NamaAspek = Grid.GridValue(_KodeBaru, Row)
                        HeaderAspek.KodeKelompok = cboKelompok.SelectedValue
                        HeaderAspek.KodeDept = cboDeptKe.SelectedValue
                        HeaderAspek.NamaDept = cboDeptKe.Text
                        HeaderAspek.KodeBagian = cboBagianKe.SelectedValue
                        HeaderAspek.NamaBagian = cboBagianKe.Text
                        HeaderAspek.KodePosisi = cboBagianKe.SelectedValue
                        HeaderAspek.NamaPosisi = cboPosisiKe.Text

                        DaftarAspek.CopyAspek(HeaderAspek)

                    End If
                Next

                Me.Close()
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

    End Sub

End Class