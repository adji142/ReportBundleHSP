Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32
Imports HSPKPI.HSP.Data
Imports System.Text.RegularExpressions

Public Class frmKPI

#Region "Header Section"
    'Konstanta Column Header
    Private Kode As String = GetSetting(enumFormID.frmCircularLoom, enumSetting.settingKodeUnit)
    '-------------------------------------------------------------------------------------------------
    Private Const _KodeKaryawan = 0
    Private Const _NamaKaryawan = 1
    Private Const _Hasil = 2
    Private Const _Nilai = 3
    Private Const _NXB = 4

    Private Const _Minimal = 0
    Private Const _Maksimal = 1
    Private Const _NAspek = 2

    Private lReady As Boolean = False
    Private lChange As Boolean = False  'perubahan grid
    Private linput As Boolean = False   'perubahan per posisi
    Private lAspek As Boolean = False

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
    Private Kelompok As String = "KPI"
    Private Tipe As String = 0
    Private Cek As String = ""
    Dim Brs As Integer
    Dim Jenis As String = ""
    Dim Aspek As String = ""
    Dim nDate As String = ""

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
        btProses.Enabled = False
    End Sub

    Private Sub Period()
        Dim Periode1 As String = Strings.Right("0" & cboBulan.SelectedIndex + 2, 2) & "/" & Strings.Right(cboTahun.Text, 4) 'yyyy/MM+1
        Dim tgl As Date = Format(Stod("01/" & Periode1), "yyyy/MM/dd") 'Format(Stod("01/" & Format(txtTglTransaksi.Value, "MM/yyyy")), "yyyy/MM/dd")
        nDate = Format(DateAdd(DateInterval.Day, -1, tgl), "yyyy/MM/dd")
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
        lboAspek.Visible = False
        Dim DS As DataSet
        'Isi Data Posisi
        Dim DaftarPosisi As New DaftarHRPosisi()
        DS = New DataSet
        DS = DaftarPosisi.Read("%", cboBagian.SelectedValue.ToString)
        cboPosisi.DataSource = DS.Tables("View")
        cboPosisi.DisplayMember = "Nama Posisi"
        cboPosisi.ValueMember = "Kode"

        cboPosisi.SelectedIndex = -1
        lboAspek.Visible = False
    End Sub

    Private Sub SetKolomHeader()
        'Grid Kpi 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        GridKpi.BorderStyle = Windows.Forms.BorderStyle.None
        GridKpi.Rows = 150
        GridKpi.HeadersVisualStyles = True
        GridKpi.AlternatingDataGridBackColor = Color.White

        GridKpi.AddColumnHeader("Kode Karyawan", 13, 13, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridKpi.AddColumnHeader("Nama Karyawan", 40, 40, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridKpi.AddColumnHeader("Hasil", 15, 20, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caCenter, True)
        GridKpi.AddColumnHeader("Nilai", 10, 10, GridColumnStyle.csFixed, GridColumnType.ctDecimal, GridColumnAlignment.caCenter, True)
        GridKpi.AddColumnHeader("NXB", 15, 10, GridColumnStyle.csFixed, GridColumnType.ctDecimal, GridColumnAlignment.caCenter, True)

        GridKpi.ShowHeader()
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

    Private Sub HariIni()
        Dim x As Date
        x = Format(DateAdd(DateInterval.Month, -1, Now), "yyyy/MM/dd")
        cboTahun.Text = Year(x)
        cboBulan.SelectedIndex = Month(x) - 1
    End Sub

    Private Sub Bobot()
        Dim DaftarAspek As New DaftarAspek(ActiveSession)
        Dim HeaderAspek As HeaderAspek

        HeaderAspek = DaftarAspek.Bobot(lboAspek.SelectedValue.ToString)
        If Not IsNothing(HeaderAspek) Then
            txtBobot.Text = HeaderAspek.Bobot
            txtTarget.Text = HeaderAspek.Target
            Tipe = HeaderAspek.Tipe
            Jenis = HeaderAspek.Jenis
        End If
    End Sub

    Private Sub ResetData()
        lChange = False
        _SaveMode = enumSaveMode.AddMode

        txtNoTransaksi.Enabled = True
        BtTrue()
        txtNoTransaksi.Text = ""

        lblKet.Text = ""

        lboAspek.SelectedIndex = -1
        cboPosisi.SelectedIndex = -1
        cboBagian.SelectedIndex = -1
        cboDept.SelectedIndex = -1

        'lboAspek.Visible = False

        txtBobot.Text = ""
        txtTarget.Text = ""

        GridKpi.Clear()
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

    Private Sub frmKPI_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    Private Sub frmKPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SetKolomHeader()
        FillCombo()
        FillMonth(cboBulan)
        FillYear(cboTahun)
        ResetData()

    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtNoTransaksi.Text <> "" Then
            Dim DaftarKPI As New DaftarKPI(ActiveSession)
            Dim HeaderKPI As HeaderKPI = DaftarKPI.FindHeader(txtNoTransaksi.Text)

            If Not IsNothing(HeaderKPI) Then
                linput = True
                lboAspek.Visible = True
                _SaveMode = enumSaveMode.EditMode
                _TRX = HeaderKPI.TRX
                txtNoTransaksi.Enabled = False

                cboBulan.SelectedIndex = Strings.Right(HeaderKPI.Periode, 2) - 1  'Month(HeaderKPI.TglTransaksi) - 1
                cboTahun.Text = Strings.Left(HeaderKPI.Periode, 4)  'Year(HeaderKPI.TglTransaksi)
                cboDept.SelectedValue = HeaderKPI.KodeDept
                cboBagian.SelectedValue = HeaderKPI.KodeBagian
                cboPosisi.SelectedValue = HeaderKPI.KodePosisi
                lboAspek.SelectedValue = HeaderKPI.KodeAspek
                txtTglPencatatan.Value = HeaderKPI.TglPencatatan

                Aspek = lboAspek.SelectedValue

                If _SaveMode = enumSaveMode.EditMode Then
                    Dim DT As DataTable = DaftarKPI.ReadDetail(txtNoTransaksi.Text).Tables("View")
                    Dim DR As DataRow
                    Dim Row As Integer = 0

                    GridKpi.Clear()
                    For Each DR In DT.Rows
                        If Row = GridKpi.Rows Then
                            GridKpi.DataGridView.Rows.Add()
                        End If

                        GridKpi.GridValue(_KodeKaryawan, Row) = DR("Kode Karyawan")
                        GridKpi.GridValue(_NamaKaryawan, Row) = DR("Nama Karyawan")
                        GridKpi.GridValue(_Hasil, Row) = DR("Hasil")
                        GridKpi.GridValue(_Nilai, Row) = DR("Nilai")
                        GridKpi.GridValue(_NXB, Row) = DR("NXB")

                        Row += 1
                    Next
                    Bobot()
                    ShowGrid()
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

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click, btFinish.Click
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
                        If _TRX <> New DaftarKPI(ActiveSession).FindHeader(txtNoTransaksi.Text).TRX Then
                            MessageBox.Show("Data Ini Telah Diubah User Lain ! " + vbCrLf + "Proses Simpan Data Dibatalkan Oleh Sistem ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            IDData = txtNoTransaksi.Text
                            'Me.Close()
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
                        Dim DaftarKPI As New DaftarKPI(ActiveSession)
                        Dim HeaderKPI As HeaderKPI
                        Dim DetailKPI As DetailKPI

                        'Nomor Transaksi
                        If _SaveMode = enumSaveMode.AddMode Then
                            txtNoTransaksi.Text = DaftarKPI.GetNomorTransaksi(Periode)
                        End If

                        'Baca transaksi
                        '---------------------------------------------------------------------------------------------------
                        HeaderKPI = DaftarKPI.FindHeader(txtNoTransaksi.Text)
                        If Not IsNothing(HeaderKPI) Then
                            'Hapus Detail 
                            DaftarKPI.DeleteDetail(txtNoTransaksi.Text)
                        End If

                        'Simpan Header KPI
                        '----------------------------------------------------------------------------------------------------
                        HeaderKPI = New HeaderKPI
                        HeaderKPI.NoTransaksi = txtNoTransaksi.Text
                        HeaderKPI.TglTransaksi = DateSerial(cboTahun.Text, cboBulan.SelectedIndex + 2, 0)
                        HeaderKPI.TglPencatatan = Now()
                        HeaderKPI.KodeDept = cboDept.SelectedValue
                        HeaderKPI.NamaDept = cboDept.Text
                        HeaderKPI.KodeBagian = cboBagian.SelectedValue
                        HeaderKPI.NamaBagian = cboBagian.Text
                        HeaderKPI.KodePosisi = cboPosisi.SelectedValue
                        HeaderKPI.NamaPosisi = cboPosisi.Text
                        HeaderKPI.KodeKelompok = Kelompok
                        HeaderKPI.KodeAspek = lboAspek.SelectedValue
                        HeaderKPI.UserID = ActiveSession.KodeUser
                        HeaderKPI.Periode = Periode

                        If _SaveMode = enumSaveMode.AddMode Then
                            DaftarKPI.AddHeader(HeaderKPI)
                        Else
                            DaftarKPI.EditHeader(HeaderKPI)
                        End If

                        '----------------------------------------------------------------------------------------------------

                        'Simpan DetailKPI
                        '----------------------------------------------------------------------------------------------------
                        Dim NoUrut As Integer = 0

                        For Row = 0 To GridKpi.GridLastRow - 1

                            If GridKpi.GridValue(_KodeKaryawan, Row) <> "" Then

                                'Simpan Transaksi
                                '-----------------------------------------------------------------------------------
                                NoUrut += 1

                                DetailKPI = New DetailKPI
                                DetailKPI.NoTransaksi = txtNoTransaksi.Text
                                DetailKPI.NoUrut = NoUrut
                                DetailKPI.KodeKaryawan = GridKpi.GridValue(_KodeKaryawan, Row)
                                DetailKPI.NamaKaryawan = GridKpi.GridValue(_NamaKaryawan, Row)
                                DetailKPI.Hasil = GridKpi.GridValue(_Hasil, Row)
                                DetailKPI.Nilai = GridKpi.GridValue(_Nilai, Row)
                                DetailKPI.NXB = GridKpi.GridValue(_NXB, Row)
                                DaftarKPI.AddDetail(DetailKPI)

                            End If
                        Next

                        Me.Cursor = Cursors.Default

                        Scope.Complete()
                        Scope.Dispose()
                        '-------------------------------------------------------------------------------------------------
                        lChange = False
                        btSave.Enabled = False
                        BtFalse()
                        'btProses.PerformClick()
                        'lboAspek.SelectedIndex = -1
                        'txtNoTransaksi.Text = "AUTO"
                        'GridKpi.Clear()
                        'ShowGridKPI()
                        'ShowGrid()
                        'txtBobot.Text = ""
                        'txtTarget.Text = ""
                        'IDData = txtNoTransaksi.Text

                        'If _SaveMode = enumSaveMode.AddMode Then
                        '    IDData = txtNoTransaksi.Text
                        'Else
                        '    IDData = txtNoTransaksi.Text
                        '    'Me.Close()
                        'End If

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

            Case "btFinish"
                '---------------------------------------------------------------------------------------------------------
                If MessageBox.Show("Selesai Input Data...?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    linput = False
                    Aspek = ""
                    lboAspek.Visible = False
                    ResetData()
                    cboBulan.Focus()
                    lboAspek.DataSource = Nothing
                    ResetData()
                    lboAspek.DataSource = Nothing

                Else
                    btFinish.Enabled = True
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                Me.Close()
        End Select

Jump:
        If _SaveMode = enumSaveMode.AddMode Then
            txtNoTransaksi.Text = _NoTransaksi
            btSave.Enabled = False
        End If

    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(cboDept.SelectedIndex = -1, False, True) And _
                         If(cboBagian.SelectedIndex = -1, False, True) And _
                         If(cboPosisi.SelectedIndex = -1, False, True) And _
                         If(lboAspek.SelectedIndex = -1, False, True) And _
                         If(Cek = "X", False, True) 'If(JumlahBarisData() = 0, False, True)

        btFinish.Enabled = True

        'If(txtNoTransaksi.Text = "", False, True) And _
        '                 If(cboDept.SelectedIndex = -1, False, True) And _
        '                 If(cboBagian.SelectedIndex = -1, False, True) And _
        '                 If(cboPosisi.SelectedIndex = -1, False, True) And _
        '                 If(lboAspek.SelectedIndex = -1, False, True) And _
        btProses.Enabled = If(linput = False, False, True) And _
                           If(lboAspek.SelectedIndex = -1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
            BtTrue()
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
            BtFalse()
        End If

        lblBarisData.Text = JumlahBarisData() & " Baris Data"

        If Aspek <> "" Then
            cboDept.Enabled = False
            cboBagian.Enabled = False
            cboPosisi.Enabled = False
            btnDept.Enabled = False
            btnBagian.Enabled = False
            btnPosisi.Enabled = False
            cboTahun.Enabled = False
            cboBulan.Enabled = False
        End If
    End Sub

#End Region

#Region "Detail Section"
    'Hitung Baris Data
    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        Cek = ""

        For Row = 0 To GridKpi.GridLastRow - 1
            If GridKpi.GridValue(_KodeKaryawan, Row) <> "" Then
                Jumlah += 1
                If GridKpi.GridValue(_Hasil, Row) = "" Then
                    Cek = "X"
                End If
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub BtTrue()
        cboDept.Enabled = True
        cboBagian.Enabled = True
        cboPosisi.Enabled = True
        btnDept.Enabled = True
        btnBagian.Enabled = True
        btnPosisi.Enabled = True
        cboTahun.Enabled = True
        cboBulan.Enabled = True
    End Sub

    Private Sub BtFalse()
        cboDept.Enabled = False
        cboBagian.Enabled = False
        cboPosisi.Enabled = False
        btnDept.Enabled = False
        btnBagian.Enabled = False
        btnPosisi.Enabled = False
        cboTahun.Enabled = False
        cboBulan.Enabled = False
    End Sub

    Private Sub GridKpi_GridCellChange(Col As Integer, Row As Integer, NewData As String, OldData As String) Handles GridKpi.GridCellChange
        btSave.Enabled = True
        lChange = True
        BtFalse()
    End Sub

    Private Sub GridKpi_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles GridKpi.GridCellPostValidation
        'SetEnableCommand()
        If Col = _Hasil Then
            Brs = Row
            Nilai()
        End If

        'validasi tipe inputan (angka/huruf)
        If Tipe = "0" Then
            Dim m As Match
            If Col = _Hasil Then
                m = Regex.Match(GridKpi.GridValue(_Hasil, Row), "[^0-9.]", RegexOptions.None)
                If m.Success Then
                    MessageBox.Show("Inputan Harus Angka !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GridKpi.GridValue(_Hasil, Row) = OldData
                End If
            End If
        End If

        '---validasi inputan hasil berdasar parameter
        If Col = _Hasil Then
            If Tipe = "0" Then 'jika inputan angka
                If Val(GridKpi.GridValue(_Hasil, Row)) >= Min And Val(GridKpi.GridValue(_Hasil, Row)) <= Max Then
                    Exit Sub
                Else
                    MessageBox.Show("Hasil Diluar Range Aspek !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GridKpi.GridValue(_Hasil, Row) = 0
                End If
            Else 'jika inputan huruf
                Dim baris As Integer = 0
                Dim cek As String = ""
                Dim cekT As String = ""
                For baris = 0 To Grid.GridLastRow - 1
                    If GridKpi.GridValue(_Hasil, Row) = Grid.GridValue(_Minimal, baris) Then
                        cek = "X"
                    End If
                Next
                If cek = "" Then
                    MessageBox.Show("Hasil Diluar Range Aspek !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GridKpi.GridValue(_Hasil, Row) = ""
                End If
            End If
        End If
        '---
    End Sub

    Private Sub GridKpi_GridChange() Handles GridKpi.GridChange 
        SetEnableCommand()
    End Sub
#End Region

    Private Sub btProses_Click(sender As Object, e As EventArgs) Handles btProses.Click
        If lboAspek.Text <> "System.Data.DataRowView" Then
            'MsgBox(lboAspek.Text)
            GridKpi.Clear()
            Dim Periode As String = Strings.Right(cboTahun.Text, 2) & Strings.Right("0" & cboBulan.SelectedIndex + 1, 2)
            Dim Kriteria As String = Periode & cboBagian.SelectedValue & cboPosisi.SelectedValue & Kelompok & lboAspek.SelectedValue

            Dim DaftarKPI As New DaftarKPI(ActiveSession)
            Dim HeaderKPI As HeaderKPI

            HeaderKPI = DaftarKPI.CekData(Kriteria)
            If Not IsNothing(HeaderKPI) Then 'txtNoTransaksi.Enabled = True
                MessageBox.Show("Aspek " & lboAspek.Text & " Posisi " & cboPosisi.SelectedText & " Bulan Ini Sudah Diinput !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ResetData()
                txtNoTransaksi.Text = HeaderKPI.NoTransaksi
                txtNoTransaksi.Focus()
                SendKeys.Send("{TAB}")
            Else
                ShowGridKPI()
                _SaveMode = enumSaveMode.AddMode
                txtNoTransaksi.Text = "<AUTO>"
            End If
            ShowGrid()
            SetEnableCommand()
            'btProses.Enabled = False
            cboDept.Enabled = False
            cboBagian.Enabled = False
            cboPosisi.Enabled = False
            cboTahun.Enabled = False
            cboBulan.Enabled = False
            linput = True
        End If
    End Sub

    Private Sub btreproses_Click(sender As Object, e As EventArgs)
        GridKpi.Clear()
        ShowGridKPI()
        ShowGrid()
    End Sub

    Private Sub ShowGridKPI() 'menampilkan daftar karyawan
        Period()
        'Dim Periode As String = Strings.Right(cboTahun.Text, 4) & Strings.Right("0" & cboBulan.SelectedIndex + 1, 2)
        Dim DT As DataTable
        Dim Row As Integer = 0

        Dim DaftarKaryawan As New DaftarHRKaryawan()
        Dim Karyawan As HRKaryawan = DaftarKaryawan.Cek(cboPosisi.SelectedValue)

        If Not IsNothing(Karyawan) Then
            If Jenis <> "" Then
                lblKet.Text = "Mohon Tunggu, Proses Pengambilan Data...!"
                MessageBox.Show("Mohon Tunggu, Proses Akan Membutuhkan Beberapa Waktu. . .", _
                           "Perhatian")

            End If
            DT = New HSPKPI.HSP.Data.DaftarHRKaryawan().ShowKaryawan(cboPosisi.SelectedValue, nDate).Tables("View")
            GridKpi.Clear()
            For Each DR As DataRow In DT.Rows
                If Row = GridKpi.Rows Then
                    GridKpi.DataGridView.Rows.Add()
                End If

                GridKpi.GridValue(_KodeKaryawan, Row) = DR("Kode")
                GridKpi.GridValue(_NamaKaryawan, Row) = DR("Nama Karyawan")

                Brs = Row
                DataOtomatis()
                If GridKpi.GridValue(_Hasil, Row) <> "" Then
                    ShowGrid()
                    Nilai()
                    btSave.Enabled = True
                Else
                    btSave.Enabled = False
                End If


                Row += 1
            Next
        End If

        lblKet.Text = ""

        JumlahBarisData()
        lblBarisData.Text = JumlahBarisData() & " Baris Data"

    End Sub

    Private Sub DataOtomatis()
        Dim Periode As String = Strings.Right("0" & cboBulan.SelectedIndex + 1, 2) & "/" & Strings.Right(cboTahun.Text, 4) 'yyyy/MM
        Dim Periode1 As String = Strings.Right("0" & cboBulan.SelectedIndex + 2, 2) & "/" & Strings.Right(cboTahun.Text, 4) 'yyyy/MM+1
        Dim Periode2 As String = Strings.Right("0" & cboBulan.SelectedIndex, 2) & "/" & Strings.Right(cboTahun.Text, 4) 'yyyy/MM-1

        'exp ==> tgl = 2018/02/09, tgl1 = 2018/02/01, tgl2 = 2018/02/28, tgl3 = 2018/01/26, tgl4 = 2018/02/25
        Dim tgl1 As String = Format(Stod("01/" & Periode), "yyyy/MM/dd")
        Dim tgl As Date = Format(Stod("01/" & Periode1), "yyyy/MM/dd") 'Format(Stod("01/" & Format(txtTglTransaksi.Value, "MM/yyyy")), "yyyy/MM/dd")
        Dim tgl2 As String = Format(DateAdd(DateInterval.Day, -1, tgl), "yyyy/MM/dd")

        Dim tgl3 As String = Format(Stod("26/" & Periode2), "yyyy/MM/dd")
        Dim tgl4 As String = Format(Stod("25/" & Periode), "yyyy/MM/dd")

        'MsgBox(tgl & " - " & tgl1 & " - " & tgl2 & " - " & tgl3 & " - " & tgl4)

        Dim DaftarOtomatis As New DaftarHROtomatis()

        If Jenis = "ABS" Then 'absensi
            Dim Otomatis As HROtomatis = DaftarOtomatis.Absensi(tgl3, tgl4, GridKpi.GridValue(_KodeKaryawan, Brs))

            If Not IsNothing(Otomatis) Then
                GridKpi.GridValue(_Hasil, Brs) = Otomatis.Absensi
            End If

        ElseIf Jenis = "TLT" Then ' telat
            Dim Otomatis As HROtomatis = DaftarOtomatis.Telat(tgl3, tgl4, GridKpi.GridValue(_KodeKaryawan, Brs))

            If Not IsNothing(Otomatis) Then
                GridKpi.GridValue(_Hasil, Brs) = Otomatis.Telat
            End If

        ElseIf Jenis = "SP" Then 'pelanggaran kerja
            Dim Otomatis As HROtomatis = DaftarOtomatis.SP(tgl1, tgl2, GridKpi.GridValue(_KodeKaryawan, Brs))

            If Not IsNothing(Otomatis) Then
                GridKpi.GridValue(_Hasil, Brs) = Otomatis.SP
            Else
                GridKpi.GridValue(_Hasil, Brs) = "0"
            End If

        ElseIf Jenis = "JH" Then ' Jam hilang
            Dim Otomatis As HROtomatis = DaftarOtomatis.JH(tgl3, tgl4, GridKpi.GridValue(_KodeKaryawan, Brs))

            If Not IsNothing(Otomatis) Then
                GridKpi.GridValue(_Hasil, Brs) = Otomatis.JH
            End If

        ElseIf Jenis = "EFF" Or Jenis = "PRD" Or Jenis = "AFV" Then ' efisiensi produksi afal
            Dim x As String = Strings.Right(GridKpi.GridValue(_KodeKaryawan, Brs), 4)
            Dim y As String = Strings.Left(x, 1)
            Dim NIK As String
            If y = "0" Then
                NIK = Strings.Right(x, 3)
            Else
                NIK = x
            End If
            Dim DaftarDataOtomatis As New DaftarDataOtomatis(ActiveSession)
            If Jenis = "EFF" Or Jenis = "PRD" Then
                Dim DataOtomatis As DataOtomatis = DaftarDataOtomatis.Eff(tgl1, tgl2, NIK)

                If Not IsNothing(DataOtomatis) Then
                    If Jenis = "EFF" Then
                        GridKpi.GridValue(_Hasil, Brs) = DataOtomatis.Eff
                    ElseIf Jenis = "PRD" Then
                        GridKpi.GridValue(_Hasil, Brs) = DataOtomatis.Hasil
                    End If
                End If
            ElseIf Jenis = "AFV" Then
                Dim DataOtomatis As DataOtomatis = DaftarDataOtomatis.Afv(tgl1, tgl2, NIK)

                If Not IsNothing(DataOtomatis) Then
                    GridKpi.GridValue(_Hasil, Brs) = DataOtomatis.Afval
                End If
            End If

        End If
    End Sub

    Private Sub Nilai() 'menampilkan nilai dan nxb
        Dim Baris As Integer
        Dim NAspek As Integer = 0
        Dim NXB As Integer = 0
        For Baris = 0 To Grid.GridLastRow - 1

            If Grid.GridValue(_NAspek, Baris) <> 0 Then 'Grid.GridValue(_Minimal, Baris) <> 0 And Grid.GridValue(_Maksimal, Baris) <> 0 And 
                If Tipe = "0" Then 'ANGKA
                    If Val(GridKpi.GridValue(_Hasil, Brs)) >= Val(Grid.GridValue(_Minimal, Baris)) And Val(GridKpi.GridValue(_Hasil, Brs)) <= Val(Grid.GridValue(_Maksimal, Baris)) Then
                        NAspek = Val(Grid.GridValue(_NAspek, Baris))
                    End If
                Else 'HURUF
                    If GridKpi.GridValue(_Hasil, Brs) = Grid.GridValue(_Minimal, Baris) Then
                        NAspek = Val(Grid.GridValue(_NAspek, Baris))
                    End If
                End If
            End If
        Next
        NXB = txtBobot.Text * NAspek
        GridKpi.GridValue(_Nilai, Brs) = NAspek
        GridKpi.GridValue(_NXB, Brs) = NXB
    End Sub

    Private Sub ShowGrid() 'validasi hasil 
        Dim DaftarAspek As New DaftarAspek(ActiveSession)
        Dim DT As DataTable = DaftarAspek.ReadDetail(lboAspek.SelectedValue).Tables("View")
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

            If Tipe = 0 Then
                'mencari nilai min dan max parameter
                If DR("Minimal") <= Min Then
                    Min = DR("Minimal")
                End If
                If DR("Maksimal") >= Max Then
                    Max = DR("Maksimal")
                End If
                '------------------
            End If
            Baris += 1
        Next
        cboDept.Enabled = False
        cboBagian.Enabled = False
        cboPosisi.Enabled = False
        cboTahun.Enabled = False
        cboBulan.Enabled = False
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

    Private Sub ListAspek()
        If cboPosisi.SelectedIndex <> -1 Then
            Dim DS As DataSet
            Dim DaftarAspek As New DaftarAspek(ActiveSession)
            DS = New DataSet
            DS = DaftarAspek.ReadHeader("%", "", Kelompok, cboPosisi.SelectedValue.ToString)
            lboAspek.DataSource = DS.Tables("View")
            lboAspek.DisplayMember = "Aspek"
            lboAspek.ValueMember = "Kode"

            lboAspek.SelectedIndex = -1
        Else

            lboAspek.DataSource = Nothing
            txtTarget.Text = ""
            txtBobot.Text = ""
            Grid.Clear()
            GridKpi.Clear()
        End If

    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                                         cboBulan.SelectedValueChanged,
                                                                         cboTahun.TextChanged,
                                                                         txtNoTransaksi.TextChanged,
                                                                         cboDept.SelectedValueChanged,
                                                                         cboBagian.SelectedValueChanged,
                                                                         cboPosisi.SelectedValueChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboDept" And cboDept.SelectedIndex <> -1 Then
            ComboBagian()
        End If

        If ObjectName = "cboBagian" And cboBagian.SelectedIndex <> -1 Then
            ComboPosisi()
        End If

        If ObjectName = "cboPosisi" Then
            lboAspek.Visible = False
            ListAspek()
            lboAspek.Visible = True
            Bersih()
        End If
        SetEnableCommand()
    End Sub

    Private Sub Bersih()
        txtBobot.Text = ""
        txtTarget.Text = ""
        Grid.Clear()
        GridKpi.Clear()
    End Sub

    Private Sub lboAspek_KeyDown(sender As Object, e As KeyEventArgs) Handles lboAspek.KeyDown
        Aspek = lboAspek.SelectedValue
    End Sub

    Private Sub lboAspek_SelectedValueChanged(sender As Object, e As EventArgs) Handles lboAspek.SelectedValueChanged
        If lboAspek.SelectedIndex <> -1 And lboAspek.Visible = True Then 'And lboAspek.SelectedValue <> Aspek 
            If lboAspek.SelectedIndex <> -1 Then
                linput = True
                Bobot()

                SetEnableCommand()
            End If

            JumlahBarisData()
            If lChange = True And lboAspek.SelectedValue <> Aspek And linput = True Then 'And lboAspek.SelectedIndex <> Aspek And lboAspek.SelectedIndex <> -1 And JumlahBarisData() <> 0 And btSave.Enabled = True
                If MessageBox.Show("Batalkan Perubahan Data...?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    lChange = False
                    btProses.PerformClick()
                Else
                    lboAspek.SelectedValue = Aspek

                End If
            End If

            'untuk pertama show edit data
            If lReady And btProses.Enabled And cboDept.SelectedIndex <> -1 And cboBagian.SelectedIndex <> -1 And cboPosisi.SelectedIndex <> -1 And lboAspek.SelectedIndex <> -1 Then 'And 
                If Not lChange Then
                    btProses.PerformClick()
                End If
            End If
        End If

    End Sub

    Private Sub frmKPI_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lReady = True
    End Sub

    Private Sub btReproses_Click_1(sender As Object, e As EventArgs) Handles btReproses.Click
        GridKpi.Clear()
        ShowGridKPI()
        lChange = True
    End Sub

    Private Sub lboAspek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboAspek.SelectedIndexChanged

    End Sub
End Class