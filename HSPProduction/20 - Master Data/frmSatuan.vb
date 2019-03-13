Imports HSPProduction.HSP.Data

Public Class frmSatuan
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
    Private Sub frmSatuan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeSatuan.Enabled = True

        txtKodeSatuan.Text = ""
        txtNamaSatuan.Text = ""

        If _ID <> "" Then
            txtKodeSatuan.Text = _ID
            txtKodeSatuan_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeSatuan.TextChanged,
                            txtNamaSatuan.TextChanged
        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmSatuan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeSatuan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeSatuan.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeSatuan.Text.Trim() <> "" Then
            Dim DaftarSatuan As New DaftarSatuan(ActiveSession)
            Dim Satuan As Satuan = DaftarSatuan.Find(txtKodeSatuan.Text)

            If Not IsNothing(Satuan) Then
                txtNamaSatuan.Text = Satuan.NamaSatuan

                txtKodeSatuan.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarSatuan.Locked(txtKodeSatuan.Text)
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

                Dim DaftarSatuan As New DaftarSatuan(ActiveSession)
                Dim Satuan As New Satuan()

                Satuan.KodeSatuan = txtKodeSatuan.Text
                Satuan.NamaSatuan = txtNamaSatuan.Text

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarSatuan.Add(Satuan)
                    IDData = txtKodeSatuan.Text
                    ResetData()
                    txtKodeSatuan.Focus()
                Else
                    DaftarSatuan.Edit(Satuan)
                    IDData = txtKodeSatuan.Text
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

        btSave.Enabled = If(txtKodeSatuan.Text.Trim() = "", False, True) And _
                         If(txtNamaSatuan.Text.Trim() = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class