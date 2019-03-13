Imports HSPProduction.HSP.Data

Public Class frmKeteranganToleransi
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
    Private Sub frmKeteranganToleransi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeKeterangan.Enabled = True

        txtKodeKeterangan.Text = ""
        txtNamaKeterangan.Text = ""
        txtToleransi.Text = ""

        If _ID <> "" Then
            txtKodeKeterangan.Text = _ID
            txtKodeKeterangan_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeKeterangan.TextChanged,
                            txtNamaKeterangan.TextChanged,
                            txtToleransi.TextChanged
        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmKeteranganToleransi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeKeterangan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeKeterangan.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeKeterangan.Text.Trim() <> "" Then
            Dim DaftarKeteranganToleransi As New DaftarKeteranganToleransi(ActiveSession)
            Dim KeteranganToleransi As KeteranganToleransi = DaftarKeteranganToleransi.Find(txtKodeKeterangan.Text)

            If Not IsNothing(KeteranganToleransi) Then
                txtNamaKeterangan.Text = KeteranganToleransi.NamaKeterangan
                txtToleransi.Text = KeteranganToleransi.Toleransi

                txtKodeKeterangan.Enabled = False
                _SaveMode = enumSaveMode.EditMode

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

                Dim DaftarKeteranganToleransi As New DaftarKeteranganToleransi(ActiveSession)
                Dim KeteranganToleransi As New KeteranganToleransi()

                KeteranganToleransi.KodeKeterangan = txtKodeKeterangan.Text
                KeteranganToleransi.NamaKeterangan = txtNamaKeterangan.Text
                KeteranganToleransi.Toleransi = txtToleransi.Value

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarKeteranganToleransi.Add(KeteranganToleransi)
                    IDData = txtKodeKeterangan.Text
                    ResetData()
                    txtKodeKeterangan.Focus()
                Else
                    DaftarKeteranganToleransi.Edit(KeteranganToleransi)
                    IDData = txtKodeKeterangan.Text
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

        btSave.Enabled = If(txtKodeKeterangan.Text.Trim() = "", False, True) And _
                         If(txtNamaKeterangan.Text.Trim() = "", False, True) And _
                         If(txtToleransi.Text = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub

End Class