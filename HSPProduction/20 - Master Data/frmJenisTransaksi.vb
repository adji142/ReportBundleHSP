Imports HSPProduction.HSP.Data

Public Class frmJenisKoreksi
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

    Private Sub frmJenisKoreksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        'Unit Produksi
        Dim DaftarKelompokKoreksi As New DaftarKelompokKoreksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarKelompokKoreksi.Read("%")
        cboKelompok.DataSource = DS.Tables("View")
        cboKelompok.DisplayMember = "Nama Kelompok"
        cboKelompok.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Kelompok") = "-"
    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeJenisKoreksi.Enabled = True

        txtKodeJenisKoreksi.Text = ""
        txtNamaJenisKoreksi.Text = ""
        cboKelompok.SelectedIndex = cboKelompok.Items.Count - 1

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeJenisKoreksi.Text = _ID
            cboKelompok.SelectedValue = _GroupID
            txtKodeJenisKoreksi_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeJenisKoreksi.TextChanged,
                            txtNamaJenisKoreksi.TextChanged,
                            cboKelompok.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmJenisKoreksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeJenisKoreksi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeJenisKoreksi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeJenisKoreksi.Text.Trim() <> "" Then
            Dim DaftarJenisKoreksi As New DaftarJenisKoreksi(ActiveSession)
            Dim JenisKoreksi As JenisKoreksi = DaftarJenisKoreksi.Find(txtKodeJenisKoreksi.Text)

            If Not IsNothing(JenisKoreksi) Then
                txtNamaJenisKoreksi.Text = JenisKoreksi.Keterangan
                cboKelompok.SelectedValue = JenisKoreksi.KodeKelompok

                txtKodeJenisKoreksi.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarJenisKoreksi.Locked(txtKodeJenisKoreksi.Text)
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeLokasi.Click
        Dim DaftarLokasi As IDataLookup = New DaftarLokasi(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarLokasi, Parameter)
        Form.Text = "Lookup Daftar Unit Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKelompok.SelectedValue = Form.IDLookup
            cboKelompok.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboLokasi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKelompok.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeLokasi.PerformClick()
        End If
    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DaftarJenisKoreksi As New DaftarJenisKoreksi(ActiveSession)
                Dim JenisKoreksi As New JenisKoreksi()

                JenisKoreksi.Kode = txtKodeJenisKoreksi.Text
                JenisKoreksi.Keterangan = txtNamaJenisKoreksi.Text
                JenisKoreksi.KodeKelompok = cboKelompok.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarJenisKoreksi.Add(JenisKoreksi)
                    IDData = txtKodeJenisKoreksi.Text
                    ResetData()
                    txtKodeJenisKoreksi.Focus()
                Else
                    DaftarJenisKoreksi.Edit(JenisKoreksi)
                    IDData = txtKodeJenisKoreksi.Text
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

        btSave.Enabled = If(txtKodeJenisKoreksi.Text.Trim() = "", False, True) And _
                         If(txtNamaJenisKoreksi.Text.Trim() = "", False, True) And _
                         If(cboKelompok.SelectedIndex = cboKelompok.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class