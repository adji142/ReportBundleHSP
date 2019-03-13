Imports HSPProduction.HSP.Data

Public Class frmQCStatus

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

    Private Sub frmQCStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        txtKodeStatus.Enabled = True

        txtKodeStatus.Text = ""
        txtKeterangan.Text = ""
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeStatus.Text = _ID
            cboKodeUnit.SelectedValue = _GroupID
            txtKodeStatus_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeStatus.TextChanged,
                            txtKeterangan.TextChanged,
                            cboKodeUnit.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmQCStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeStatus_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeStatus.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeStatus.Text.Trim() <> "" Then
            Dim DaftarQCStatus As New DaftarQCStatus(ActiveSession)
            Dim Status As QCStatus = DaftarQCStatus.Find(txtKodeStatus.Text)

            If Not IsNothing(Status) Then
                txtKeterangan.Text = Status.Keterangan
                cboKodeUnit.SelectedValue = Status.KodeUnit

                txtKodeStatus.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarQCStatus.Locked(txtKodeStatus.Text)
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

                Dim DaftarQCStatus As New DaftarQCStatus(ActiveSession)
                Dim Status As New QCStatus

                Status.KodeStatus = txtKodeStatus.Text
                Status.Keterangan = txtKeterangan.Text
                Status.KodeUnit = cboKodeUnit.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarQCStatus.Add(Status)
                    IDData = txtKodeStatus.Text
                    ResetData()
                    txtKodeStatus.Focus()
                Else
                    DaftarQCStatus.Edit(Status)
                    IDData = txtKodeStatus.Text
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

        btSave.Enabled = If(txtKodeStatus.Text.Trim() = "", False, True) And _
                         If(txtKeterangan.Text.Trim() = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class