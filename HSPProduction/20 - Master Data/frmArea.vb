Imports HSPProduction.HSP.Data

Public Class frmArea
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

    Private Sub frmArea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        'Unit Produksi
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboLokasi.DataSource = DS.Tables("View")
        cboLokasi.DisplayMember = "Nama Lokasi"
        cboLokasi.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"
    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeArea.Enabled = True

        txtKodeArea.Text = ""
        txtNamaArea.Text = ""
        cboLokasi.SelectedIndex = cboLokasi.Items.Count - 1

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeArea.Text = _ID
            cboLokasi.SelectedValue = _GroupID
            txtKodeArea_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeArea.TextChanged,
                            txtNamaArea.TextChanged,
                            cboLokasi.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmArea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeArea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeArea.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeArea.Text.Trim() <> "" Then
            Dim DaftarArea As New DaftarArea(ActiveSession)
            Dim Area As Area = DaftarArea.Find(txtKodeArea.Text)

            If Not IsNothing(Area) Then
                txtNamaArea.Text = Area.NamaArea
                cboLokasi.SelectedValue = Area.KodeLokasi

                txtKodeArea.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarArea.Locked(txtKodeArea.Text)
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
            cboLokasi.SelectedValue = Form.IDLookup
            cboLokasi.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboLokasi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboLokasi.KeyDown
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

                Dim DaftarArea As New DaftarArea(ActiveSession)
                Dim Area As New Area()

                Area.KodeArea = txtKodeArea.Text
                Area.NamaArea = txtNamaArea.Text
                Area.KodeLokasi = cboLokasi.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarArea.Add(Area)
                    IDData = txtKodeArea.Text
                    ResetData()
                    txtKodeArea.Focus()
                Else
                    DaftarArea.Edit(Area)
                    IDData = txtKodeArea.Text
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

        btSave.Enabled = If(txtKodeArea.Text.Trim() = "", False, True) And _
                         If(txtNamaArea.Text.Trim() = "", False, True) And _
                         If(cboLokasi.SelectedIndex = cboLokasi.Items.Count - 1, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class