Imports HSPProduction.HSP.Data

Public Class frmLokasi
    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    'Data Private
    Private _ID As String
    Private _SaveMode As enumSaveMode

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    'Form Load
    Private Sub frmLokasi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeLokasi.Enabled = True

        txtKodeLokasi.Text = ""
        txtNamaLokasi.Text = ""
        txtPrefiks.Text = ""
        cboLokasi.SelectedIndex = -1
        chkBenang.Checked = False
        chkRoll.Checked = False

        If _ID <> "" Then
            txtKodeLokasi.Text = _ID
            txtKodeLokasi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeLokasi.TextChanged,
                            txtNamaLokasi.TextChanged,
                            txtPrefiks.TextChanged,
                            cboLokasi.SelectedIndexChanged,
                            chkBenang.CheckedChanged,
                            chkRoll.CheckedChanged
        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmLokasi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeLokasi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeLokasi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeLokasi.Text.Trim() <> "" Then
            Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
            Dim Lokasi As Lokasi = DaftarLokasi.Find(txtKodeLokasi.Text)

            If Not IsNothing(Lokasi) Then
                txtNamaLokasi.Text = Lokasi.NamaLokasi
                txtPrefiks.Text = Lokasi.PrefikKodeTransaksi
                cboLokasi.SelectedIndex = Lokasi.Lokasi - 1
                chkBenang.Checked = If(Lokasi.Benang = 1, True, False)
                chkRoll.Checked = If(Lokasi.Roll = 1, True, False)

                txtKodeLokasi.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarLokasi.Locked(txtKodeLokasi.Text)
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

                Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
                Dim Lokasi As New Lokasi()

                Lokasi.Kodelokasi = txtKodeLokasi.Text
                Lokasi.NamaLokasi = txtNamaLokasi.Text
                Lokasi.PrefikKodeTransaksi = txtPrefiks.Text
                Lokasi.Lokasi = cboLokasi.SelectedIndex + 1
                Lokasi.Benang = If(chkBenang.Checked, 1, 0)
                Lokasi.Roll = If(chkRoll.Checked, 1, 0)

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarLokasi.Add(Lokasi)
                    IDData = txtKodeLokasi.Text
                    ResetData()
                    txtKodeLokasi.Focus()
                Else
                    DaftarLokasi.Edit(Lokasi)
                    IDData = txtKodeLokasi.Text
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

        btSave.Enabled = If(txtKodeLokasi.Text.Trim() = "", False, True) And _
                         If(txtNamaLokasi.Text.Trim() = "", False, True) And _
                         If(txtPrefiks.Text.Trim() = "", False, True) And _
                         If(cboLokasi.SelectedIndex = -1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class