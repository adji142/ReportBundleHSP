Imports HSPProduction.HSP.Data

Public Class frmKaryawan
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

    Private Sub frmKaryawan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        txtKodeKaryawan.Enabled = True

        txtKodeKaryawan.Text = ""
        txtNamaKaryawan.Text = ""
        cboKelompok.SelectedIndex = -1
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        chkAktif.Checked = False

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeKaryawan.Text = _ID
            cboKodeUnit.SelectedValue = _GroupID
            txtKodeKaryawan_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeKaryawan.TextChanged,
                            txtNamaKaryawan.TextChanged,
                            cboKelompok.SelectedValueChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            chkAktif.CheckedChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmKaryawan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeKaryawan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeKaryawan.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeKaryawan.Text.Trim() <> "" Then
            Dim DaftarKaryawan As New DaftarKaryawan(ActiveSession)
            Dim Karyawan As Karyawan = DaftarKaryawan.Find(txtKodeKaryawan.Text)

            If Not IsNothing(Karyawan) Then
                txtNamaKaryawan.Text = Karyawan.NamaKaryawan
                cboKelompok.SelectedIndex = Karyawan.Kelompok - 1
                cboKodeUnit.SelectedValue = Karyawan.KodeUnit
                chkAktif.Checked = If(Karyawan.Aktif = 1, True, False)

                txtKodeKaryawan.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarKaryawan.Locked(txtKodeKaryawan.Text)
            Else
                chkAktif.Checked = True
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

    Private Sub cboKodeunit_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeUnit.KeyDown
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

                Dim DaftarKaryawan As New DaftarKaryawan(ActiveSession)
                Dim Karyawan As New Karyawan()

                Karyawan.KodeKaryawan = txtKodeKaryawan.Text
                Karyawan.NamaKaryawan = txtNamaKaryawan.Text
                Karyawan.Kelompok = cboKelompok.SelectedIndex + 1
                Karyawan.KodeUnit = cboKodeUnit.SelectedValue
                Karyawan.Aktif = If(chkAktif.Checked, 1, 0)

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarKaryawan.Add(Karyawan)
                    IDData = txtKodeKaryawan.Text
                    ResetData()
                    txtKodeKaryawan.Focus()
                Else
                    DaftarKaryawan.Edit(Karyawan)
                    IDData = txtKodeKaryawan.Text
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

        btSave.Enabled = If(txtKodeKaryawan.Text.Trim() = "", False, True) And _
                         If(txtNamaKaryawan.Text.Trim() = "", False, True) And _
                         If(cboKelompok.SelectedIndex = -1, False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class