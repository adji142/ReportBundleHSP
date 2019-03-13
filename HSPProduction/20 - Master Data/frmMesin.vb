Imports HSPProduction.HSP.Data

Public Class frmMesin
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

    Private Sub frmMesin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboUnitProduksi.DataSource = DS.Tables("View")
        cboUnitProduksi.DisplayMember = "Unit Produksi"
        cboUnitProduksi.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"
    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeMesin.Enabled = True

        txtKodeMesin.Text = ""
        txtNamaMesin.Text = ""
        cboUnitProduksi.SelectedIndex = cboUnitProduksi.Items.Count - 1
        chkAktif.Checked = False
        txtKodeMesinSAP.Text = ""

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeMesin.Text = _ID
            cboUnitProduksi.SelectedValue = _GroupID
            txtKodeMesin_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeMesin.TextChanged,
                            txtNamaMesin.TextChanged,
                            cboUnitProduksi.SelectedIndexChanged,
                            txtKodeMesinSAP.TextChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmMesin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeMesin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeMesin.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeMesin.Text.Trim() <> "" Then
            Dim DaftarMesin As New DaftarMesin(ActiveSession)
            Dim Mesin As Mesin = DaftarMesin.Find(txtKodeMesin.Text)

            If Not IsNothing(Mesin) Then
                txtNamaMesin.Text = Mesin.NamaMesin
                cboUnitProduksi.SelectedValue = Mesin.KodeUnit
                chkAktif.Checked = If(Mesin.Aktif = "1", True, False)
                txtKodeMesinSAP.Text = Mesin.KodeMesinSAP

                txtKodeMesin.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarMesin.Locked(txtKodeMesin.Text)

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
            cboUnitProduksi.SelectedValue = Form.IDLookup
            cboUnitProduksi.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboUnitProduksi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboUnitProduksi.KeyDown
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

                Dim DaftarMesin As New DaftarMesin(ActiveSession)
                Dim Mesin As New Mesin()

                Mesin.KodeMesin = txtKodeMesin.Text
                Mesin.NamaMesin = txtNamaMesin.Text
                Mesin.KodeUnit = cboUnitProduksi.SelectedValue
                Mesin.Aktif = If(chkAktif.Checked, 1, 0)
                Mesin.KodeMesinSAP = txtKodeMesinSAP.Text

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarMesin.Add(Mesin)
                    IDData = txtKodeMesin.Text
                    ResetData()
                    txtKodeMesin.Focus()
                Else
                    DaftarMesin.Edit(Mesin)
                    IDData = txtKodeMesin.Text
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

        btSave.Enabled = If(txtKodeMesin.Text.Trim() = "", False, True) And _
                         If(txtNamaMesin.Text.Trim() = "", False, True) And _
                         If(cboUnitProduksi.SelectedIndex = cboUnitProduksi.Items.Count - 1, False, True) And _
                         If(txtKodeMesinSAP.Text = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class