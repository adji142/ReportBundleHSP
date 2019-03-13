Imports HSPProduction.HSP.Data

Public Class frmMediaTimbang
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _GroupID As String
    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String, ByVal GroupID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
    End Sub

    Private Sub frmMediaTimbang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        'Lokasi Produksi
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

        'Satuan
        Dim DaftarSatuan As New DaftarSatuan(ActiveSession)
        DS = New DataSet
        DS = DaftarSatuan.Read("%")
        cboKodeSatuan.DataSource = DS.Tables("View")
        cboKodeSatuan.DisplayMember = "Satuan"
        cboKodeSatuan.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Satuan") = "-"

        'Unit Produksi
        Dim DaftarUnit As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnit.Read("%")

        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"

    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeMedia.Enabled = True

        txtKodeMedia.Text = ""
        txtNamaMedia.Text = ""
        txtBeratMedia.Text = ""
        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
        cboKodeSatuan.SelectedIndex = cboKodeSatuan.Items.Count - 1
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1


        If _ID <> "" Or _GroupID <> "" Then
            txtKodeMedia.Text = _ID
            cboKodeLokasi.SelectedValue = _GroupID
            txtKodeMedia_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeMedia.TextChanged,
                            txtNamaMedia.TextChanged,
                            txtBeratMedia.TextChanged,
                            cboKodeLokasi.SelectedIndexChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            cboKodeSatuan.SelectedIndexChanged,
                            chkAktif.CheckedChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmMediaTimbang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeMedia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeMedia.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeMedia.Text.Trim() <> "" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim MediaTimbang As MediaTimbang = DaftarMediaTimbang.Find(txtKodeMedia.Text)

            If Not IsNothing(MediaTimbang) Then
                txtNamaMedia.Text = MediaTimbang.NamaMedia
                txtBeratMedia.Text = MediaTimbang.Berat
                cboKodeLokasi.SelectedValue = MediaTimbang.KodeLokasi
                cboKodeUnit.SelectedValue = MediaTimbang.KodeUnit
                chkAktif.Checked = If(MediaTimbang.JumlahMedia = "1", True, False)
                cboKodeSatuan.SelectedValue = MediaTimbang.KodeSatuan

                txtKodeMedia.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarMediaTimbang.Locked(txtKodeMedia.Text)
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btLookupKodeLokasi_Click(sender As Object, e As EventArgs) Handles btLookupKodeLokasi.Click
        Dim DaftarLokasiProduksi As IDataLookup = New DaftarLokasi(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarLokasiProduksi, Parameter)
        Form.Text = "Lookup Daftar Lokasi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeLokasi.SelectedValue = Form.IDLookup
            cboKodeLokasi.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnit.Click
        Dim DaftarUnitProduksi As IDataLookup = New DaftarUnitProduksi(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarUnitProduksi, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeUnit.SelectedValue = Form.IDLookup
            cboKodeUnit.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeSatuan_Click(sender As Object, e As EventArgs) Handles btLookupKodeSatuan.Click
        Dim DaftarSatuan As IDataLookup = New DaftarSatuan(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarSatuan, Parameter)
        Form.Text = "Lookup Daftar Satuan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeSatuan.SelectedValue = Form.IDLookup
            cboKodeSatuan.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboKodeLokasi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeLokasi.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeLokasi.PerformClick()
        End If
    End Sub

    Private Sub cboKodeUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeUnit.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeUnit.PerformClick()
        End If
    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
                Dim MediaTimbang As New MediaTimbang()

                MediaTimbang.KodeMedia = txtKodeMedia.Text
                MediaTimbang.NamaMedia = txtNamaMedia.Text
                MediaTimbang.Berat = txtBeratMedia.Value
                MediaTimbang.KodeLokasi = cboKodeLokasi.SelectedValue
                MediaTimbang.KodeUnit = cboKodeUnit.SelectedValue
                MediaTimbang.JumlahMedia = If(chkAktif.Checked, 1, 0)
                MediaTimbang.KodeSatuan = cboKodeSatuan.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarMediaTimbang.Add(MediaTimbang)
                    IDData = txtKodeMedia.Text
                    ResetData()
                    txtKodeMedia.Focus()
                Else
                    DaftarMediaTimbang.Edit(MediaTimbang)
                    IDData = txtKodeMedia.Text
                    Me.Close()
                End If

                Me.Cursor = Cursors.Default
                '---------------------------------------------------------------------------------------------------------

            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

    End Sub

    'Aktifkan Dan Non Aftifkan Tombol Berdasarkan Data Isian
    Private Sub SetEnableCommand()

        btSave.Enabled = If(txtKodeMedia.Text.Trim() = "", False, True) And _
                         If(txtNamaMedia.Text.Trim() = "", False, True) And _
                         If(txtBeratMedia.Text.Trim() = "", False, True) And _
                         If(cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1, False, True) And _
                         If(cboKodeSatuan.SelectedIndex = cboKodeSatuan.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub

End Class