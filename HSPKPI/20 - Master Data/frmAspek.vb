Imports HSPKPI.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class frmAspek
    Public IDData As String
    Private Const _Minimal = 0
    Private Const _Maksimal = 1
    Private Const _Nilai = 2

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private Enum enumStatus
        Draft = 0
        Posting = 1
    End Enum

    Private _SaveMode As enumSaveMode
    Private _ID As String           'kodeaspek
    Private _GroupID As String      'kodebagian
    'Private _GroupID1 As String     'kodeposisi
    Private _GroupID2 As String     'kodekomponen

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ID As String, GroupID As String, GroupID2 As String) ', GroupID1 As String
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
        '_GroupID1 = GroupID1
        _GroupID2 = GroupID2
    End Sub

    Private Sub frmAspek_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetKolomHeader()
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Isi Data Departemen
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

        'Isi Data Jenis
        Dim DaftarData As New DaftarData(ActiveSession)
        DS = New DataSet
        DS = DaftarData.Read("%")
        cboJenis.DataSource = DS.Tables("View")
        cboJenis.DisplayMember = "Keterangan"
        cboJenis.ValueMember = "ID"

        Drow = DS.Tables("View").Rows.Add
        Drow("ID") = ""
        Drow("Keterangan") = "<TIDAK ADA>"

        cboJenis.SelectedValue = ""

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

    Private Sub SetKolomHeader()

        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 10
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White

        Grid.AddColumnHeader("Minimal", 30, 30, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Maksimal", 30, 30, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Nilai", 35, 35, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, "##,##0.00")

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeAspek.Enabled = True

        txtKodeAspek.Text = ""
        txtNamaAspek.Text = ""
        cboPosisi.SelectedIndex = -1
        cboBagian.SelectedIndex = -1
        cboDept.SelectedIndex = -1
        cboKelompok.SelectedIndex = -1
        cboJenis.SelectedValue = ""
        txtBobot.Text = ""
        chkTipe.Checked = False
        txtTarget.Text = ""
        txtKeterangan.Text = ""
        Grid.Clear()


        If _ID <> "" Or _GroupID <> "" Or _GroupID2 <> "" Then 'Or _GroupID1 <> ""
            txtKodeAspek.Text = _ID
            cboBagian.SelectedValue = _GroupID
            'cboPosisi.SelectedValue = _GroupID1
            cboKelompok.SelectedValue = _GroupID2
            txtKodeAspek_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
            '_GroupID1 = ""
            _GroupID2 = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeAspek.TextChanged,
                            txtNamaAspek.TextChanged,
                            cboDept.SelectedValueChanged,
                            cboBagian.SelectedValueChanged,
                            cboPosisi.SelectedValueChanged,
                            cboKelompok.SelectedValueChanged,
                            txtBobot.TextChanged,
                            txtKeterangan.TextChanged,
                            chkTipe.CheckedChanged,
                            cboJenis.SelectedValueChanged


        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboDept" And cboDept.SelectedIndex <> -1 Then
            ComboBagian()
        End If

        If ObjectName = "cboBagian" And cboBagian.SelectedIndex <> -1 Then
            ComboPosisi()
        End If

        'If ObjectName = "chkTipe" And chkTipe.Checked = False Then
        '    If Not IsNumeric(txtTarget.Text) Then
        '        txtTarget.Text = ""
        '    Else
        '        txtTarget.Text = txtTarget.Text
        '    End If
        'End If

        SetEnableCommand()
    End Sub

    Public Sub Data_Keypress(ByVal Sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmAspek_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    'Cari Kode Kelompok Pada Database
    Private Sub txtKodeAspek_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeAspek.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeAspek.Text.Trim() <> "" Then
            Dim DaftarAspek As New DaftarAspek(ActiveSession)
            Dim HeaderAspek As HeaderAspek = DaftarAspek.FindHeader(txtKodeAspek.Text)

            If Not IsNothing(HeaderAspek) Then
                _SaveMode = enumSaveMode.EditMode
                txtNamaAspek.Text = HeaderAspek.NamaAspek
                cboDept.SelectedValue = HeaderAspek.KodeDept
                cboBagian.SelectedValue = HeaderAspek.KodeBagian
                cboPosisi.SelectedValue = HeaderAspek.KodePosisi
                cboKelompok.SelectedValue = HeaderAspek.KodeKelompok
                txtBobot.Text = HeaderAspek.Bobot
                txtTarget.Text = HeaderAspek.Target
                txtKeterangan.Text = HeaderAspek.Keterangan
                chkTipe.Checked = If(HeaderAspek.Tipe = 1, True, False)
                cboJenis.SelectedValue = HeaderAspek.Jenis

                txtKodeAspek.Enabled = False

                If _SaveMode = enumSaveMode.EditMode Then
                    Dim DT As DataTable = DaftarAspek.ReadDetail(txtKodeAspek.Text).Tables("View")
                    Dim DR As DataRow
                    Dim Row As Integer = 0

                    Grid.Clear()
                    For Each DR In DT.Rows
                        If Row = Grid.Rows Then
                            Grid.DataGridView.Rows.Add()
                        End If

                        Grid.GridValue(_Minimal, Row) = DR("Minimal")
                        Grid.GridValue(_Maksimal, Row) = DR("Maksimal")
                        Grid.GridValue(_Nilai, Row) = DR("Nilai")

                        Row += 1
                    Next
                End If
            End If
        End If

        SetEnableCommand()
    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor
                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarAspek As New DaftarAspek(ActiveSession)
                    Dim HeaderAspek As HeaderAspek
                    Dim DetailAspek As DetailAspek

                    'Baca aSPEK
                    '---------------------------------------------------------------------------------------------------
                    HeaderAspek = DaftarAspek.FindHeader(txtKodeAspek.Text)
                    If Not IsNothing(HeaderAspek) Then
                        'Hapus Detail Pemakaian Bahan Internal
                        DaftarAspek.DeleteDetail(txtKodeAspek.Text)
                    End If

                    HeaderAspek = New HeaderAspek
                    HeaderAspek.KodeAspek = txtKodeAspek.Text
                    HeaderAspek.NamaAspek = txtNamaAspek.Text
                    HeaderAspek.KodeDept = cboDept.SelectedValue
                    HeaderAspek.KodeBagian = cboBagian.SelectedValue
                    HeaderAspek.KodePosisi = cboPosisi.SelectedValue
                    HeaderAspek.NamaDept = cboDept.Text
                    HeaderAspek.NamaBagian = cboBagian.Text
                    HeaderAspek.NamaPosisi = cboPosisi.Text
                    HeaderAspek.KodeKelompok = cboKelompok.SelectedValue
                    HeaderAspek.Bobot = txtBobot.Text
                    HeaderAspek.Target = txtTarget.Text
                    HeaderAspek.Keterangan = txtKeterangan.Text
                    HeaderAspek.Tipe = If(chkTipe.Checked, 1, 0)
                    HeaderAspek.Jenis = cboJenis.SelectedValue

                    If _SaveMode = enumSaveMode.AddMode Then
                        DaftarAspek.AddHeader(HeaderAspek)
                    Else
                        DaftarAspek.EditHeader(HeaderAspek)
                    End If

                    '----------------------------------------------------------------------------------------------------

                    'Simpan Detail
                    '----------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer = 0

                    For Row = 0 To Grid.GridLastRow - 1

                        If Grid.GridValue(_Nilai, Row) <> 0 Then

                            'Simpan Transaksi Internal
                            '-----------------------------------------------------------------------------------
                            NoUrut += 1

                            DetailAspek = New DetailAspek
                            DetailAspek.KodeAspek = txtKodeAspek.Text
                            DetailAspek.RowID = NoUrut
                            DetailAspek.Minimal = Grid.GridValue(_Minimal, Row)
                            DetailAspek.Maksimal = Grid.GridValue(_Maksimal, Row)
                            DetailAspek.Nilai = Grid.GridValue(_Nilai, Row)
                            DaftarAspek.AddDetail(DetailAspek)

                        End If
                    Next

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    If _SaveMode = enumSaveMode.AddMode Then
                        IDData = txtKodeAspek.Text
                        ResetData()
                        txtKodeAspek.Focus()
                    Else
                        IDData = txtKodeAspek.Text
                        Me.Close()
                    End If

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select
Jump:
        If _SaveMode = enumSaveMode.AddMode Then
            txtKodeAspek.Text = txtKodeAspek.Text
        End If
    End Sub

    'Aktifkan Dan Non Aftifkan Tombol Berdasarkan Data Isian
    Private Sub SetEnableCommand()
        JumlahBarisData()
        btSave.Enabled = If(txtKodeAspek.Text.Trim() = "", False, True) And _
                         If(txtNamaAspek.Text.Trim() = "", False, True) And _
                         If(cboDept.SelectedIndex = -1, False, True) And _
                         If(cboBagian.SelectedIndex = -1, False, True) And _
                         If(cboPosisi.SelectedIndex = -1, False, True) And _
                         If(cboKelompok.SelectedIndex = -1, False, True) And _
                         If(cboJenis.SelectedIndex = -1, False, True) And _
                         If(txtBobot.Text.Trim() = "", False, True) And _
                         If(txtTarget.Text.Trim() = "", False, True) And _
                         If(JumlahBarisData() = 0, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

        'lblBarisData.Text = JumlahBarisData() & " Baris Data"
        lblBarisData.Text = ""
    End Sub

    Private Sub btnLookupKelompok_Click(sender As Object, e As EventArgs)
        Dim DaftarKelompok As IDataLookup = New DaftarKelompok(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarKelompok, Parameter)
        Form.Text = "Lookup Daftar Kelompok"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKelompok.SelectedValue = Form.IDLookup
            cboKelompok.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        For Row = 0 To Grid.GridLastRow - 1

            If Grid.GridValue(_Nilai, Row) <> 0 Then
                Jumlah += 1
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub Grid_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles Grid.GridCellPostValidation
        If Col = _Minimal And Valid Then
            If chkTipe.Checked = True Then
                Grid.GridValue(_Maksimal, Row) = Grid.GridValue(_Minimal, Row)
            End If
        End If


        If chkTipe.Checked = False Then
            Dim m As Match

            If Col = _Minimal Then
                m = Regex.Match(Grid.GridValue(_Minimal, Row), "[^0-9.]", RegexOptions.None)
                If m.Success Then
                    MessageBox.Show("Inputan Harus Angka !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Grid.GridValue(_Minimal, Row) = "0"
                End If
            ElseIf Col = _Maksimal Then
                m = Regex.Match(Grid.GridValue(_Maksimal, Row), "[^0-9.]", RegexOptions.None)
                If m.Success Then
                    MessageBox.Show("Inputan Harus Angka !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Grid.GridValue(_Maksimal, Row) = "0"
                End If
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub Grid_GridChange() Handles Grid.GridChange
        SetEnableCommand()
    End Sub

    'Private Sub txtTarget_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarget.KeyPress
    'If chkTipe.Checked = False Then
    '    If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    'End If
    'End Sub

End Class