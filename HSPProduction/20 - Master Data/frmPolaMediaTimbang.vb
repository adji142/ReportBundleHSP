Imports HSPProduction.HSP.Data

Public Class frmPolaMediaTimbang
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

    Private Sub frmPolaMediaTimbang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        'Lokasi Produksi
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"
    End Sub

    Private Sub FillComboMedia()
        Try
            'Media Timbang 1
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim DS As DataSet
            Dim Drow As DataRow

            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", cboKodeLokasi.SelectedValue)
            cboKodeMedia1.DataSource = DS.Tables("View")
            cboKodeMedia1.DisplayMember = "Nama Media"
            cboKodeMedia1.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            'Media Timbang 2
            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", cboKodeLokasi.SelectedValue)
            cboKodeMedia2.DataSource = DS.Tables("View")
            cboKodeMedia2.DisplayMember = "Nama Media"
            cboKodeMedia2.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", cboKodeLokasi.SelectedValue)
            cboKodeMedia3.DataSource = DS.Tables("View")
            cboKodeMedia3.DisplayMember = "Nama Media"
            cboKodeMedia3.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1
            cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1
            cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1
        Catch
        End Try
    End Sub

    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodePola.Enabled = True

        txtKodePola.Text = ""
        txtNamaPola.Text = ""
        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
        cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1
        cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1
        cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1
        chkMedia1.Checked = False
        chkMedia2.Checked = False
        chkMedia3.Checked = False
        txtJumlahDefault1.Text = ""
        txtJumlahDefault2.Text = ""
        txtJumlahDefault3.Text = ""
        'txtJumlahDefault1.Visible = False
        'txtJumlahDefault2.Visible = False
        'txtJumlahDefault3.Visible = False

        If _ID <> "" Or _GroupID <> "" Then
            txtKodePola.Text = _ID
            cboKodeLokasi.SelectedValue = _GroupID
            txtKodePola_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodePola.TextChanged,
                            txtNamaPola.TextChanged,
                            cboKodeMedia1.SelectedIndexChanged,
                            cboKodeMedia2.SelectedIndexChanged,
                            cboKodeMedia3.SelectedIndexChanged,
                            chkMedia1.CheckedChanged,
                            chkMedia2.CheckedChanged,
                            chkMedia3.CheckedChanged,
                            txtJumlahDefault1.TextChanged,
                            txtJumlahDefault2.TextChanged,
                            txtJumlahDefault3.TextChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmPolaMediaTimbang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodePola_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodePola.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodePola.Text.Trim() <> "" Then
            Dim DaftarPolaMediaTimbang As New DaftarPolaMediaTimbang(ActiveSession)
            Dim PolaMediaTimbang As PolaMediaTimbang = DaftarPolaMediaTimbang.Find(txtKodePola.Text)

            If Not IsNothing(PolaMediaTimbang) Then
                txtNamaPola.Text = PolaMediaTimbang.NamaPola
                cboKodeLokasi.SelectedValue = PolaMediaTimbang.KodeLokasi
                cboKodeMedia1.SelectedValue = PolaMediaTimbang.KodeMedia1
                cboKodeMedia2.SelectedValue = PolaMediaTimbang.KodeMedia2
                cboKodeMedia3.SelectedValue = PolaMediaTimbang.KodeMedia3
                chkMedia1.Checked = If(PolaMediaTimbang.FlagJumlahMedia1 = 1, True, False)
                chkMedia2.Checked = If(PolaMediaTimbang.FlagJumlahMedia2 = 1, True, False)
                chkMedia3.Checked = If(PolaMediaTimbang.FlagJumlahMedia3 = 1, True, False)
                txtJumlahDefault1.Text = PolaMediaTimbang.JumlahDefault1
                txtJumlahDefault2.Text = PolaMediaTimbang.JumlahDefault2
                txtJumlahDefault3.Text = PolaMediaTimbang.JumlahDefault3

                txtKodePola.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarPolaMediaTimbang.Locked(txtKodePola.Text)
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btLookupKodeUnit_Click(sender As Object, e As EventArgs) Handles btLookupKodeUnit.Click
        Dim DaftarLokasiProduksi As IDataLookup = New DaftarLokasi(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarLokasiProduksi, Parameter)
        Form.Text = "Lookup Daftar Lokasi Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeLokasi.SelectedValue = Form.IDLookup
            cboKodeLokasi.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboUnitProduksi_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeLokasi.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeUnit.PerformClick()
        End If
    End Sub

    Private Sub cboUnitProduksi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKodeLokasi.SelectedIndexChanged
        FillComboMedia()
        SetEnableCommand()
    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DaftarPolaMediaTimbang As New DaftarPolaMediaTimbang(ActiveSession)
                Dim PolaMediaTimbang As New PolaMediaTimbang()

                PolaMediaTimbang.KodePola = txtKodePola.Text
                PolaMediaTimbang.NamaPola = txtNamaPola.Text
                PolaMediaTimbang.KodeLokasi = cboKodeLokasi.SelectedValue
                PolaMediaTimbang.KodeMedia1 = cboKodeMedia1.SelectedValue
                PolaMediaTimbang.KodeMedia2 = cboKodeMedia2.SelectedValue
                PolaMediaTimbang.KodeMedia3 = cboKodeMedia3.SelectedValue
                PolaMediaTimbang.FlagJumlahMedia1 = If(chkMedia1.Checked, 1, 0)
                PolaMediaTimbang.FlagJumlahMedia2 = If(chkMedia2.Checked, 1, 0)
                PolaMediaTimbang.FlagJumlahMedia3 = If(chkMedia3.Checked, 1, 0)
                PolaMediaTimbang.JumlahDefault1 = txtJumlahDefault1.Value
                PolaMediaTimbang.JumlahDefault2 = txtJumlahDefault2.Value
                PolaMediaTimbang.JumlahDefault3 = txtJumlahDefault3.Value

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarPolaMediaTimbang.Add(PolaMediaTimbang)
                    IDData = txtKodePola.Text
                    ResetData()
                    txtKodePola.Focus()
                Else
                    DaftarPolaMediaTimbang.Edit(PolaMediaTimbang)
                    IDData = txtKodePola.Text
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

        btSave.Enabled = If(txtKodePola.Text.Trim() = "", False, True) And _
                         If(txtNamaPola.Text.Trim() = "", False, True) And _
                         If(cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1, False, True) And _
                         (If(cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1, False, True) Or _
                         If(cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1, False, True) Or _
                         If(cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1, False, True)) And _
                         (If(chkMedia1.Checked = False, False, True) Or _
                          If(chkMedia2.Checked = False, False, True) Or _
                          If(chkMedia3.Checked = False, False, True)) And _
                         (If(txtJumlahDefault1.Value = 0, False, True) Or _
                         If(txtJumlahDefault2.Value = 0, False, True) Or _
                         If(txtJumlahDefault3.Value = 0, False, True))

        If cboKodeMedia1.SelectedIndex = cboKodeMedia1.Items.Count - 1 Then
            chkMedia1.Enabled = False
        Else
            chkMedia1.Enabled = True
        End If

        If cboKodeMedia2.SelectedIndex = cboKodeMedia2.Items.Count - 1 Then
            chkMedia2.Enabled = False
        Else
            chkMedia2.Enabled = True
        End If

        If cboKodeMedia3.SelectedIndex = cboKodeMedia3.Items.Count - 1 Then
            chkMedia3.Enabled = False
        Else
            chkMedia3.Enabled = True
        End If

        If chkMedia1.Checked Then
            chkMedia1.Text = "Aktif"
            'txtJumlahDefault1.Visible = True
            'txtJumlahDefault2.Visible = True
        Else
            chkMedia1.Text = "Non Aktif"
            'txtJumlahDefault1.Visible = False
            'txtJumlahDefault1.Text = ""
            'txtJumlahDefault2.Visible = False
            'txtJumlahDefault2.Text = ""
        End If

        If chkMedia2.Checked Then
            chkMedia2.Text = "Aktif"
            'txtJumlahDefault2.Visible = True
            'txtJumlahDefault3.Visible = True
        Else
            chkMedia2.Text = "Non Aktif"
            'txtJumlahDefault2.Visible = False
            'txtJumlahDefault2.Text = ""
            'txtJumlahDefault3.Visible = False
            'txtJumlahDefault3.Text = ""
        End If

        If chkMedia3.Checked Then
            chkMedia3.Text = "Aktif"
            'txtJumlahDefault3.Visible = True
        Else
            chkMedia3.Text = "Non Aktif"
            'txtJumlahDefault3.Visible = False
            'txtJumlahDefault3.Text = ""
        End If

        lblSatuan1.Text = cboKodeMedia1.Text
        lblSatuan2.Text = cboKodeMedia2.Text & "/" & cboKodeMedia1.Text
        lblSatuan3.Text = cboKodeMedia3.Text & "/" & cboKodeMedia2.Text

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class