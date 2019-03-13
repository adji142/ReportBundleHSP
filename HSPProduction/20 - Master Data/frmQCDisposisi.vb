Imports HSPProduction.HSP.Data

Public Class frmQCDisposisi

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

    Private Sub frmQCDisposisi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"
    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeDisposisi.Enabled = True

        txtKodeDisposisi.Text = ""
        txtDisposisi.Text = ""
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeDisposisi.Text = _ID
            cboKodeUnit.SelectedValue = _GroupID
            txtKodeDisposisi_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeDisposisi.TextChanged,
                            txtDisposisi.TextChanged,
                            cboKodeUnit.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmQCDisposisi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeDisposisi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeDisposisi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeDisposisi.Text.Trim() <> "" Then
            Dim DaftarQCDisposisi As New DaftarQCDisposisi(ActiveSession)
            Dim Disposisi As QCDisposisi = DaftarQCDisposisi.Find(txtKodeDisposisi.Text)

            If Not IsNothing(Disposisi) Then
                txtDisposisi.Text = Disposisi.Disposisi
                cboKodeUnit.SelectedValue = Disposisi.KodeUnit

                txtKodeDisposisi.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarQCDisposisi.Locked(txtKodeDisposisi.Text)
            End If
        End If

        SetEnableCommand()
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

    Private Sub cboUnitProduksi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeUnit.KeyDown
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

                Dim DaftarQCDisposisi As New DaftarQCDisposisi(ActiveSession)
                Dim Disposisi As New QCDisposisi

                Disposisi.KodeDisposisi = txtKodeDisposisi.Text
                Disposisi.Disposisi = txtDisposisi.Text
                Disposisi.KodeUnit = cboKodeUnit.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarQCDisposisi.Add(Disposisi)
                    IDData = txtKodeDisposisi.Text
                    ResetData()
                    txtKodeDisposisi.Focus()
                Else
                    DaftarQCDisposisi.Edit(Disposisi)
                    IDData = txtKodeDisposisi.Text
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

        btSave.Enabled = If(txtKodeDisposisi.Text.Trim() = "", False, True) And _
                         If(txtDisposisi.Text.Trim() = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class