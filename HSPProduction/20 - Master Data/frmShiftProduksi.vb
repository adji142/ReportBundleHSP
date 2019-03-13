Imports HSPProduction.HSP.Data

Public Class frmShiftProduksi
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
    Private Sub frmShiftProduksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeShift.Enabled = True

        txtKodeShift.Text = ""
        txtNamaShift.Text = ""
        txtShiftMulai.Text = ""
        txtShiftSelesai.Text = ""

        If _ID <> "" Then
            txtKodeShift.Text = _ID
            txtKodeShift_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeShift.TextChanged,
                            txtNamaShift.TextChanged
        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmShiftProduksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeShift_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeShift.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeShift.Text.Trim() <> "" Then
            Dim DaftarShiftProduksi As New DaftarShiftProduksi(ActiveSession)
            Dim ShiftProduksi As ShiftProduksi = DaftarShiftProduksi.Find(txtKodeShift.Text)

            If Not IsNothing(ShiftProduksi) Then
                txtNamaShift.Text = ShiftProduksi.NamaShift
                txtShiftMulai.Value = ShiftProduksi.Mulai
                txtShiftSelesai.Value = ShiftProduksi.Selesai

                txtKodeShift.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarShiftProduksi.Locked(txtKodeShift.Text)
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

                Dim DaftarShiftProduksi As New DaftarShiftProduksi(ActiveSession)
                Dim ShiftProduksi As New ShiftProduksi()
                Dim Tanggal1 As Date = "2016-01-01"
                Dim Tanggal2 As Date = Tanggal1

                If txtShiftMulai.Value.TimeOfDay > txtShiftSelesai.Value.TimeOfDay Then
                    Tanggal2 = DateAdd(DateInterval.Day, 1, Tanggal1)
                End If

                ShiftProduksi.KodeShift = txtKodeShift.Text
                ShiftProduksi.NamaShift = txtNamaShift.Text
                ShiftProduksi.Mulai = Tanggal1 + txtShiftMulai.Value.TimeOfDay
                ShiftProduksi.Selesai = Tanggal2 + txtShiftSelesai.Value.TimeOfDay

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarShiftProduksi.Add(ShiftProduksi)
                    IDData = txtKodeShift.Text
                    ResetData()
                    txtKodeShift.Focus()
                Else
                    DaftarShiftProduksi.Edit(ShiftProduksi)
                    IDData = txtKodeShift.Text
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

        btSave.Enabled = If(txtKodeShift.Text.Trim() = "", False, True) And _
                         If(txtNamaShift.Text.Trim() = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class