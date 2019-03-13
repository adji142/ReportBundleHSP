Imports HSPProduction.HSP.Data

Public Class frmGrupProduksi
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
    Private Sub frmGrupProduksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeGrup.Enabled = True

        txtKodeGrup.Text = ""
        txtNamaGrup.Text = ""

        If _ID <> "" Then
            txtKodeGrup.Text = _ID
            txtKodeGrupProduksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeGrup.TextChanged,
                            txtNamaGrup.TextChanged
        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmGrupProduksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeGrupProduksi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeGrup.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeGrup.Text.Trim() <> "" Then
            Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)
            Dim GrupProduksi As GrupProduksi = DaftarGrupProduksi.Find(txtKodeGrup.Text)

            If Not IsNothing(GrupProduksi) Then
                txtNamaGrup.Text = GrupProduksi.NamaGrup

                txtKodeGrup.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarGrupProduksi.Locked(txtKodeGrup.Text)
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

                Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)
                Dim GrupProduksi As New GrupProduksi()

                GrupProduksi.KodeGrup = txtKodeGrup.Text
                GrupProduksi.NamaGrup = txtNamaGrup.Text

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarGrupProduksi.Add(GrupProduksi)
                    IDData = txtKodeGrup.Text
                    ResetData()
                    txtKodeGrup.Focus()
                Else
                    DaftarGrupProduksi.Edit(GrupProduksi)
                    IDData = txtKodeGrup.Text
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

        btSave.Enabled = If(txtKodeGrup.Text.Trim() = "", False, True) And _
                         If(txtNamaGrup.Text.Trim() = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class