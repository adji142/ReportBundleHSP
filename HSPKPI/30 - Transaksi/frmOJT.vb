Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32
Imports HSPKPI.HSP.Data
Imports System.Text.RegularExpressions

Public Class frmOJT

#Region "Header Section"
    'Konstanta Column Header
    Private Kode As String = GetSetting(enumFormID.frmCircularLoom, enumSetting.settingKodeUnit)
    '-------------------------------------------------------------------------------------------------
    Private Const _KodeAspek = 0
    Private Const _NamaAspek = 1
    Private Const _Bobot = 2
    Private Const _Target = 3
    Private Const _Hasil = 4
    Private Const _Nilai = 5
    Private Const _NXB = 6
    Private Const _Tipe = 7

    Private Const _Minimal = 0
    Private Const _Maksimal = 1
    Private Const _NAspek = 2

    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private Enum enumStatus
        Draft = 0
        Posting = 1
    End Enum

    'Data Private
    Private KodeBagian As String = ""

    Private _ID As String
    Private _GroupID As String
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String
    Private _TRX As String = ""
    Private TglTransaksi As DateTime
    Private Min As Double = 0
    Private Max As Double = 0
    Private Kelompok As String = "OJT"
    Private Tipe As String = "0"
    Private Cek As String = ""

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String, GroupID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet

        'Isi Data Bagian
        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet
        DS = DaftarDept.Read("%")
        cboDept.DataSource = DS.Tables("View")
        cboDept.DisplayMember = "Departemen"
        cboDept.ValueMember = "Kode"

        cboDept.SelectedIndex = -1

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
        'Grid OJT 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        GridOJT.BorderStyle = Windows.Forms.BorderStyle.None
        GridOJT.Rows = 150
        GridOJT.HeadersVisualStyles = True
        GridOJT.AlternatingDataGridBackColor = Color.White

        GridOJT.AddColumnHeader("Kode Aspek", 10, 5, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridOJT.AddColumnHeader("Nama Aspek", 40, 150, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridOJT.AddColumnHeader("Bobot", 9, 5, GridColumnStyle.csFixed, GridColumnType.ctDecimal, GridColumnAlignment.caCenter, True)
        GridOJT.AddColumnHeader("Target", 10, 10, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caCenter, True)
        GridOJT.AddColumnHeader("Hasil", 10, 20, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caCenter, True)
        GridOJT.AddColumnHeader("Nilai", 9, 10, GridColumnStyle.csFixed, GridColumnType.ctDecimal, GridColumnAlignment.caCenter, True)
        GridOJT.AddColumnHeader("NXB", 10, 10, GridColumnStyle.csFixed, GridColumnType.ctDecimal, GridColumnAlignment.caCenter, True)
        GridOJT.AddColumnHeader("Tipe", 0, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caCenter, True)

        GridOJT.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 10
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White

        Grid.AddColumnHeader("Minimal", 30, 30, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Maksimal", 30, 30, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Nilai", 35, 35, GridColumnStyle.csFixed, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, "##,##0.00")

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        txtNoTransaksi.Enabled = True
        txtNoTransaksi.Text = ""
        txtKodeKaryawan.Text = ""
        txtNamaKaryawan.Text = ""

        cboDept.SelectedIndex = -1
        cboBagian.SelectedIndex = -1
        cboPosisi.SelectedIndex = -1

        GridOJT.Clear()
        Grid.Clear()

        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi

        If _ID <> "" Then
            txtNoTransaksi.Text = _ID
            txtNoTransaksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()

Jump:
    End Sub

    Private Sub frmOJT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    Private Sub frmOJT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()
        FillCombo()
        FillMonth(cboBulan)
        FillYear(cboTahun)
        ResetData()

    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                                        cboBulan.SelectedValueChanged,
                                                                        cboTahun.TextChanged,
                                                                        txtNoTransaksi.TextChanged,
                                                                        cboDept.SelectedValueChanged,
                                                                        cboBagian.SelectedValueChanged,
                                                                        cboPosisi.SelectedValueChanged,
                                                                        txtKodeKaryawan.TextChanged,
                                                                        txtNamaKaryawan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboDept" And cboDept.SelectedIndex <> -1 Then
            ComboBagian()
        End If

        If ObjectName = "cboBagian" And cboBagian.SelectedIndex <> -1 Then
            ComboPosisi()
        End If

        SetEnableCommand()
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtNoTransaksi.Text <> "" Then
            Dim DaftarOJT As New DaftarOJT(ActiveSession)
            Dim HeaderOJT As HeaderOJT = DaftarOJT.FindHeader(txtNoTransaksi.Text)

            If Not IsNothing(HeaderOJT) Then
                _SaveMode = enumSaveMode.EditMode
                _TRX = HeaderOJT.TRX
                txtNoTransaksi.Enabled = False


                cboBulan.SelectedIndex = Strings.Right(HeaderOJT.Periode, 2) - 1
                cboTahun.Text = Strings.Left(HeaderOJT.Periode, 4)
                cboDept.SelectedValue = HeaderOJT.KodeDept
                cboBagian.SelectedValue = HeaderOJT.KodeBagian
                cboPosisi.SelectedValue = HeaderOJT.KodePosisi
                txtKodeKaryawan.Text = HeaderOJT.KodeKaryawan
                txtNamaKaryawan.Text = HeaderOJT.NamaKaryawan

                If _SaveMode = enumSaveMode.EditMode Then
                    Dim DT As DataTable = DaftarOJT.ReadDetail(txtNoTransaksi.Text).Tables("View")
                    Dim DR As DataRow
                    Dim Row As Integer = 0

                    GridOJT.Clear()
                    For Each DR In DT.Rows
                        If Row = GridOJT.Rows Then
                            GridOJT.DataGridView.Rows.Add()
                        End If

                        GridOJT.GridValue(_KodeAspek, Row) = DR("Kode Aspek")
                        GridOJT.GridValue(_NamaAspek, Row) = DR("Nama Aspek")
                        GridOJT.GridValue(_Bobot, Row) = DR("Bobot")
                        GridOJT.GridValue(_Target, Row) = DR("Target")
                        GridOJT.GridValue(_Hasil, Row) = DR("Hasil")
                        GridOJT.GridValue(_Nilai, Row) = DR("Nilai")
                        GridOJT.GridValue(_NXB, Row) = DR("NXB")
                        GridOJT.GridValue(_Tipe, Row) = DR("Tipe")

                        Row += 1
                    Next
                End If
            Else
                If _NoTransaksi <> txtNoTransaksi.Text Then
                    MessageBox.Show("Nomor Transaksi Tidak Dikenal ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ResetData()
                    txtNoTransaksi.Focus()
                End If
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btCancel.Click
        Dim Periode As String = Strings.Right(cboTahun.Text, 4) & Strings.Right("0" & cboBulan.SelectedIndex + 1, 2)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'cek isian grid
                JumlahBarisData()
                If Cek = "" Then
                    'Cek Jika Data Telah Berubah
                    If _SaveMode = enumSaveMode.EditMode Then
                        If _TRX <> New DaftarOJT(ActiveSession).FindHeader(txtNoTransaksi.Text).TRX Then
                            MessageBox.Show("Data Ini Telah Diubah User Lain ! " + vbCrLf + "Proses Simpan Data Dibatalkan Oleh Sistem ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            IDData = txtNoTransaksi.Text
                            Me.Close()
                            GoTo Jump
                        End If
                    End If

                    'Konfirmasi Transaksi
                    If MessageBox.Show("Simpan Data Periode " + cboBulan.Text + " " + cboTahun.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        GoTo Jump
                    End If

                    btSave.Enabled = False
                    Me.Cursor = Cursors.WaitCursor

                    '-------------------------------------------------------------------------------------------------------
                    Dim Scope As New TransactionScope

                    Try
                        Dim DaftarOJT As New DaftarOJT(ActiveSession)
                        Dim HeaderOJT As HeaderOJT
                        Dim DetailOJT As DetailOJT

                        'Dim KodeUnitSap As String = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue).KodeUnitSAP

                        'Nomor Transaksi
                        If _SaveMode = enumSaveMode.AddMode Then
                            txtNoTransaksi.Text = DaftarOJT.GetNomorTransaksi(Periode)
                        End If

                        'Baca Pemakaian Bahan
                        '---------------------------------------------------------------------------------------------------
                        HeaderOJT = DaftarOJT.FindHeader(txtNoTransaksi.Text)
                        If Not IsNothing(HeaderOJT) Then
                            'Hapus Detail Pemakaian Bahan Internal
                            DaftarOJT.DeleteDetail(txtNoTransaksi.Text)
                        End If

                        'Simpan Header OJT
                        '----------------------------------------------------------------------------------------------------
                        HeaderOJT = New HeaderOJT
                        HeaderOJT.NoTransaksi = txtNoTransaksi.Text
                        HeaderOJT.TglTransaksi = DateSerial(cboTahun.Text, cboBulan.SelectedIndex + 2, 0)
                        HeaderOJT.TglPencatatan = Now()
                        HeaderOJT.KodeDept = cboDept.SelectedValue
                        HeaderOJT.NamaDept = cboDept.Text
                        HeaderOJT.KodeBagian = cboBagian.SelectedValue
                        HeaderOJT.KodePosisi = cboPosisi.SelectedValue
                        HeaderOJT.NamaBagian = cboBagian.Text
                        HeaderOJT.NamaPosisi = cboPosisi.Text
                        HeaderOJT.KodeKelompok = Kelompok
                        HeaderOJT.KodeKaryawan = txtKodeKaryawan.Text
                        HeaderOJT.NamaKaryawan = txtNamaKaryawan.Text
                        HeaderOJT.UserID = ActiveSession.KodeUser
                        HeaderOJT.Periode = Periode

                        If _SaveMode = enumSaveMode.AddMode Then
                            DaftarOJT.AddHeader(HeaderOJT)
                        Else
                            DaftarOJT.EditHeader(HeaderOJT)
                        End If

                        '----------------------------------------------------------------------------------------------------

                        'Simpan DetailOJT
                        '----------------------------------------------------------------------------------------------------
                        Dim NoUrut As Integer = 0

                        'Dim lReceipt As Boolean = False
                        'Dim lIssue As Boolean = False

                        For Row = 0 To GridOJT.GridLastRow - 1

                            If GridOJT.GridValue(_KodeAspek, Row) <> "" Then

                                'Simpan Transaksi Internal
                                '-----------------------------------------------------------------------------------
                                NoUrut += 1

                                DetailOJT = New DetailOJT
                                DetailOJT.NoTransaksi = txtNoTransaksi.Text
                                DetailOJT.NoUrut = NoUrut
                                DetailOJT.KodeAspek = GridOJT.GridValue(_KodeAspek, Row)
                                DetailOJT.Hasil = GridOJT.GridValue(_Hasil, Row)
                                DetailOJT.Nilai = GridOJT.GridValue(_Nilai, Row)
                                DetailOJT.NXB = GridOJT.GridValue(_NXB, Row)
                                DaftarOJT.AddDetail(DetailOJT)

                            End If
                        Next

                        'For Row = 0 To GridOJT.GridLastRow - 1

                        '    If GridOJT.GridValue(_KodeAspek, Row) <> "" Then
                        '        If GridOJT.GridValue(_Hasil, Row) < 0 Then
                        '            lReceipt = True
                        '        Else
                        '            lIssue = True
                        '        End If

                        '    End If
                        'Next

                        Me.Cursor = Cursors.Default

                        Scope.Complete()
                        Scope.Dispose()
                        '-------------------------------------------------------------------------------------------------

                        If _SaveMode = enumSaveMode.AddMode Then
                            IDData = txtNoTransaksi.Text
                            ResetData()

                            txtNoTransaksi.Focus()
                        Else
                            IDData = txtNoTransaksi.Text
                            Me.Close()
                        End If

                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Scope.Dispose()
                        MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                       ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        GoTo Jump
                    End Try
                Else
                    MessageBox.Show("Data Hasil Belum Lengkap, Silahkan Cek Lagi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            Case "btCancel"
                '---------------------------------------------------------------------------------------------------------
                If MessageBox.Show("Batalkan Perubahan Data...?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    ResetData()
                    cboBulan.Focus()
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                Me.Close()
        End Select

Jump:
        If _SaveMode = enumSaveMode.AddMode Then
            txtNoTransaksi.Text = _NoTransaksi
        End If
    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(cboDept.SelectedIndex = -1, False, True) And _
                         If(cboBagian.SelectedIndex = -1, False, True) And _
                         If(cboPosisi.SelectedIndex = -1, False, True) And _
                         If(txtKodeKaryawan.Text = "", False, True) And _
                         If(txtNamaKaryawan.Text = "", False, True) And _
                         If(JumlahBarisData() = 0, False, True)

        btProses.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(cboDept.SelectedIndex = -1, False, True) And _
                         If(cboBagian.SelectedIndex = -1, False, True) And _
                         If(cboPosisi.SelectedIndex = -1, False, True) And _
                         If(txtKodeKaryawan.Text = "", False, True) And _
                         If(txtNamaKaryawan.Text = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
            cboDept.Enabled = True
            cboBagian.Enabled = True
            'txtKodeKaryawan.Enabled = True
            cboPosisi.Enabled = True
            btnBagian.Enabled = True
            btnPosisi.Enabled = True
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
            btProses.Enabled = False
            cboDept.Enabled = False
            cboBagian.Enabled = False
            'txtKodeKaryawan.Enabled = False
            cboPosisi.Enabled = False
            btnBagian.Enabled = False
            btnPosisi.Enabled = False

        End If

        lblBarisData.Text = JumlahBarisData() & " Baris Data"
    End Sub
#End Region

#Region "Detail Section"
    'Hitung Baris Data
    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        Cek = ""

        For Row = 0 To GridOJT.GridLastRow - 1

            If GridOJT.GridValue(_KodeAspek, Row) <> "" Then
                Jumlah += 1
                If GridOJT.GridValue(_Hasil, Row) = "" Then
                    Cek = "X"
                End If
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub GridOJT_GridCellChange(Col As Integer, Row As Integer, NewData As String, OldData As String) Handles GridOJT.GridCellChange
        btSave.Enabled = False
    End Sub

    Private Sub GridOJT_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles GridOJT.GridCellPostValidation
        SetEnableCommand()
        'menampilkan nilai dan nxb
        If Col = _Hasil And Valid Then
            Dim Baris As Integer
            Dim NAspek As Integer = 0
            Dim NXB As Integer = 0
            For Baris = 0 To Grid.GridLastRow - 1

                If Grid.GridValue(_NAspek, Baris) <> "0" Then 'Grid.GridValue(_Minimal, Baris) <> 0 And Grid.GridValue(_Maksimal, Baris) <> 0 And 
                    If GridOJT.GridValue(_Hasil, Row) >= Grid.GridValue(_Minimal, Baris) And GridOJT.GridValue(_Hasil, Row) <= Grid.GridValue(_Maksimal, Baris) Then
                        NAspek = Grid.GridValue(_NAspek, Baris)
                    End If
                End If
            Next
            NXB = GridOJT.GridValue(_Bobot, Row) * NAspek
            GridOJT.GridValue(_Nilai, Row) = NAspek
            GridOJT.GridValue(_NXB, Row) = NXB
        End If
        '-------------------

        '---validasi inputan hasil
        If Col = _Hasil Then
            Dim m As Match
            If GridOJT.GridValue(_Tipe, Row) = "0" Then
                m = Regex.Match(GridOJT.GridValue(_Hasil, Row), "[^0-9.]", RegexOptions.None)
                If m.Success Then
                    MessageBox.Show("Inputan Harus Angka !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GridOJT.GridValue(_Hasil, Row) = "0"
                End If
            End If
        End If

        If Col = _Hasil Then
            If GridOJT.GridValue(_Tipe, Row) = "0" Then
                If GridOJT.GridValue(_Hasil, Row) >= Min And GridOJT.GridValue(_Hasil, Row) <= Max Then
                    Exit Sub
                Else
                    MessageBox.Show("Hasil Diluar Range Aspek !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GridOJT.GridValue(_Hasil, Row) = 0
                End If
            Else
                Dim baris As Integer = 0
                Dim cek As String = ""
                For baris = 0 To Grid.GridLastRow - 1
                    If GridOJT.GridValue(_Hasil, Row) = Grid.GridValue(_Minimal, baris) Then
                        cek = "X"
                    End If
                Next
                If cek = "" Then
                    MessageBox.Show("Hasil Diluar Range Aspek !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GridOJT.GridValue(_Hasil, Row) = ""
                End If
            End If
            Grid.Clear()
        End If
        '---
    End Sub

    Private Sub GridOJT_GridCellPreValidation(Col As Integer, Row As Integer, ByRef Cancel As Boolean) Handles GridOJT.GridCellPreValidation
        'menampilkan range parameter aspek
        If Col = _Hasil Then 'If Col = _KodeAspek And Valid Then
            Dim DaftarAspek As New DaftarAspek(ActiveSession)
            'Dim HeaderAspek As HeaderAspek = DaftarAspek.FindHeader(txtKodeAspek.Text)
            Dim DT As DataTable = DaftarAspek.ReadDetail(GridOJT.GridValue(_KodeAspek, Row)).Tables("View")
            Dim DR As DataRow
            Dim Baris As Integer = 0
            Min = 0
            Max = 0
            Grid.Clear()
            For Each DR In DT.Rows
                If Baris = Grid.Rows Then
                    Grid.DataGridView.Rows.Add()
                End If

                Grid.GridValue(_Minimal, Baris) = DR("Minimal")
                Grid.GridValue(_Maksimal, Baris) = DR("Maksimal")
                Grid.GridValue(_NAspek, Baris) = DR("Nilai")

                'mencari nilai min dan max parameter
                If GridOJT.GridValue(_Tipe, Row) = "0" Then
                    If DR("Minimal") <= Min Then
                        Min = DR("Minimal")
                    End If
                    If DR("Maksimal") >= Max Then
                        Max = DR("Maksimal")
                    End If
                End If
                '------------------

                Baris += 1
            Next
            'Label6.Text = Min
            'Label7.Text = Max
        End If
        '---------------
    End Sub

    Private Sub GridOJT_GridChange() Handles GridOJT.GridChange
        SetEnableCommand()
    End Sub
#End Region

    Private Sub btProses_Click(sender As Object, e As EventArgs) Handles btProses.Click
        Dim Periode As String = Strings.Right(cboTahun.Text, 2) & Strings.Right("0" & cboBulan.SelectedIndex + 1, 2)
        Dim Kriteria As String = Periode & cboBagian.SelectedValue & cboPosisi.SelectedValue & Kelompok & txtKodeKaryawan.Text

        Dim DaftarOJT As New DaftarOJT(ActiveSession)
        Dim HeaderOJT As HeaderOJT

        HeaderOJT = DaftarOJT.CekData(Kriteria)
        If Not IsNothing(HeaderOJT) And txtNoTransaksi.Enabled = True Then
            MessageBox.Show("Data " & txtNamaKaryawan.Text & " Bulan Ini Sudah Diinput !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ResetData()
            txtNoTransaksi.Text = HeaderOJT.NoTransaksi
            txtNoTransaksi.Focus()
            SendKeys.Send("{TAB}")
        Else
            ShowGrid()
        End If
    End Sub

    Private Sub ShowGrid()
        Dim DT As DataTable
        Dim Row As Integer = 0

        _NoTransaksi = cboPosisi.SelectedValue & Kelompok

        'pnHeader.Enabled = False
        'pnData.Enabled = True

        Dim DaftarAspek As New DaftarAspek(ActiveSession)
        Dim HeaderAspek As HeaderAspek = DaftarAspek.Cek(_NoTransaksi)

        If Not IsNothing(HeaderAspek) Then
            DT = New HSPKPI.HSP.Data.DaftarAspek(ActiveSession).ShowAspek(_NoTransaksi).Tables("View")
            GridOJT.Clear()
            For Each DR As DataRow In DT.Rows
                If Row = GridOJT.Rows Then
                    GridOJT.DataGridView.Rows.Add()
                End If

                GridOJT.GridValue(_KodeAspek, Row) = DR("KodeAspek")
                GridOJT.GridValue(_NamaAspek, Row) = DR("NamaAspek")
                GridOJT.GridValue(_Bobot, Row) = DR("Bobot")
                GridOJT.GridValue(_Target, Row) = DR("Target")
                GridOJT.GridValue(_Tipe, Row) = DR("Tipe")

                Row += 1
            Next
        End If

        JumlahBarisData()
        lblBarisData.Text = JumlahBarisData() & " Baris Data"
    End Sub

    Private Sub btnLookupKaryawan_Click(sender As Object, e As EventArgs) Handles btnLookupKaryawan.Click
        Dim Periode As String = Strings.Right(cboTahun.Text, 4) & Strings.Right("0" & cboBulan.SelectedIndex + 1, 2)
        Dim DaftarKaryawan As IDataLookup = New DaftarHRKaryawan()
        Dim Parameter() As String = {DaftarHRKaryawan.enumLookupKaryawan.DaftarKaryawan, cboPosisi.SelectedValue, Periode}

        Dim Form As New frmLookup(DaftarKaryawan, Parameter)
        Form.Text = "Lookup Daftar Karyawan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            txtKodeKaryawan.Text = ""
            txtNamaKaryawan.Text = ""
            txtKodeKaryawan.SelectedText = Form.IDLookup
            txtNamaKaryawan.SelectedText = Form.IDLookup1
            'cboKelompok.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnPosisi_Click(sender As Object, e As EventArgs) Handles btnPosisi.Click
        Dim DaftarPosisi As IDataLookup = New DaftarHRPosisi()
        Dim Parameter() As String = {DaftarHRPosisi.enumLookupPosisi.DaftarPosisi, cboBagian.SelectedValue}

        Dim Form As New frmLookup(DaftarPosisi, Parameter)
        Form.Text = "Lookup Daftar Posisi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboPosisi.SelectedValue = Form.IDLookup
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnBagian_Click(sender As Object, e As EventArgs) Handles btnBagian.Click
        Dim DaftarBagian As IDataLookup = New DaftarHRBagian()
        Dim Parameter() As String = {DaftarHRBagian.enumLookupBagian.DaftarBagian, cboDept.SelectedValue}

        Dim Form As New frmLookup(DaftarBagian, Parameter)
        Form.Text = "Lookup Daftar Bagian"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboBagian.SelectedValue = Form.IDLookup
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        Dim DaftarDept As IDataLookup = New DaftarHRDept()
        Dim Parameter() As String = {DaftarHRDept.enumLookupDept.DaftarDept}

        Dim Form As New frmLookup(DaftarDept, Parameter)
        Form.Text = "Lookup Daftar Departemen"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboDept.SelectedValue = Form.IDLookup
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class