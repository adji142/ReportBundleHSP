Imports HSPProduction.HSP.Data

Public Class frmJenisMesin
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

    Private Sub frmJenisMesin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeJenisMesin.Enabled = True

        txtKodeJenisMesin.Text = ""
        txtNamaJenisMesin.Text = ""
        cboKodeUnit.SelectedIndex = -1

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeJenisMesin.Text = _ID
            cboKodeUnit.SelectedValue = _GroupID
            txtKodeJenisMesin_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeJenisMesin.TextChanged,
                            txtNamaJenisMesin.TextChanged,
                            cboKodeUnit.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmJenisMesin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeJenisMesin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeJenisMesin.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeJenisMesin.Text.Trim() <> "" Then
            Dim DaftarJenisMesin As New DaftarJenisMesin(ActiveSession)
            Dim JenisMesin As JenisMesin = DaftarJenisMesin.Find(txtKodeJenisMesin.Text)

            If Not IsNothing(JenisMesin) Then
                txtNamaJenisMesin.Text = JenisMesin.NamaJenis
                cboKodeUnit.SelectedValue = JenisMesin.KodeUnit

                txtKodeJenisMesin.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarJenisMesin.Locked(txtKodeJenisMesin.Text)
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
            cboKodeUnit.SelectedValue = Form.IDLookup
            cboKodeUnit.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboLokasi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeUnit.KeyDown
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

                Dim DaftarJenisMesin As New DaftarJenisMesin(ActiveSession)
                Dim JenisMesin As New JenisMesin()

                JenisMesin.KodeJenis = txtKodeJenisMesin.Text
                JenisMesin.NamaJenis = txtNamaJenisMesin.Text
                JenisMesin.KodeUnit = cboKodeUnit.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarJenisMesin.Add(JenisMesin)
                    IDData = txtKodeJenisMesin.Text
                    ResetData()
                    txtKodeJenisMesin.Focus()
                Else
                    DaftarJenisMesin.Edit(JenisMesin)
                    IDData = txtKodeJenisMesin.Text
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

        btSave.Enabled = If(txtKodeJenisMesin.Text.Trim() = "", False, True) And _
                         If(txtNamaJenisMesin.Text.Trim() = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class