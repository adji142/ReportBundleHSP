Imports HSPKPI.HSP.Data

Public Class frmKelompok
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
    Private Sub frmKelompok_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeKelompok.Enabled = True

        txtKodeKelompok.Text = ""
        txtNamaKelompok.Text = ""

        If _ID <> "" Then
            txtKodeKelompok.Text = _ID
            txtKodeKelompok_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeKelompok.TextChanged,
                            txtNamaKelompok.TextChanged
        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmKelompok_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeKelompok_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeKelompok.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeKelompok.Text.Trim() <> "" Then
            Dim DaftarKelompok As New DaftarKelompok(ActiveSession)
            Dim Kelompok As Kelompok = DaftarKelompok.Find(txtKodeKelompok.Text)

            If Not IsNothing(Kelompok) Then
                txtNamaKelompok.Text = Kelompok.NamaKelompok

                txtKodeKelompok.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarKelompok.Locked(txtKodeKelompok.Text)
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

                Dim DaftarKelompok As New DaftarKelompok(ActiveSession)
                Dim Kelompok As New Kelompok()

                Kelompok.KodeKelompok = txtKodeKelompok.Text
                Kelompok.NamaKelompok = txtNamaKelompok.Text

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarKelompok.Add(Kelompok)
                    IDData = txtKodeKelompok.Text
                    ResetData()
                    txtKodeKelompok.Focus()
                Else
                    DaftarKelompok.Edit(Kelompok)
                    IDData = txtKodeKelompok.Text
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

        btSave.Enabled = If(txtKodeKelompok.Text.Trim() = "", False, True) And _
                         If(txtNamaKelompok.Text.Trim() = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class