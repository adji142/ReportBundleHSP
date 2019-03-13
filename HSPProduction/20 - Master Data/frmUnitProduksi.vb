Imports HSPProduction.HSP.Data

Public Class frmUnitProduksi
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
    Private Sub frmKelompokEkspedisi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Satuan 1
        Dim DaftarSatuan As New DaftarSatuan(ActiveSession)
        DS = New DataSet
        DS = DaftarSatuan.Read("%")
        cboKodeSatuan1.DataSource = DS.Tables("View")
        cboKodeSatuan1.DisplayMember = "Satuan"
        cboKodeSatuan1.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Satuan") = "-"

        'Satuan 2
        DS = New DataSet
        DS = DaftarSatuan.Read("%")
        cboKodeSatuan2.DataSource = DS.Tables("View")
        cboKodeSatuan2.DisplayMember = "Satuan"
        cboKodeSatuan2.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Satuan") = "-"

        'Satuan 3
        DS = New DataSet
        DS = DaftarSatuan.Read("%")
        cboKodeSatuan3.DataSource = DS.Tables("View")
        cboKodeSatuan3.DisplayMember = "Satuan"
        cboKodeSatuan3.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Satuan") = "-"

        'Lokasi Produksi
        '----------------------------------------------------------------------------
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1

    End Sub

    Private Sub ShowData()
        'Baca Data
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim Dataset As DataSet = DaftarUnitProduksi.Read("%")

        For RecData = 0 To Dataset.Tables("View").Rows.Count - 1
            Dim ListItem As New ListViewItem

            ListItem.SubItems.Add(Dataset.Tables("View").Rows(RecData).Item("Kode"))
            ListItem.SubItems.Add(Dataset.Tables("View").Rows(RecData).Item("Unit Produksi"))

            List.Items.Add(ListItem)
        Next
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeUnit.Enabled = True

        txtKodeUnit.Text = ""
        txtNamaUnit.Text = ""
        cboKodeSatuan1.SelectedIndex = cboKodeSatuan1.Items.Count - 1
        cboKodeSatuan2.SelectedIndex = cboKodeSatuan2.Items.Count - 1
        cboKodeSatuan3.SelectedIndex = cboKodeSatuan3.Items.Count - 1
        txtKodeUnitSAP.Text = ""
        txtPrefikKodeProduksi.Text = ""
        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1

        chkProduksi.Checked = False
        chkAfval.Checked = False
        chkPemakaian.Checked = False

        List.Items.Clear()

        ShowData()

        If _ID <> "" Then
            txtKodeUnit.Text = _ID
            txtKodeKelompok_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeUnit.TextChanged,
                            txtNamaUnit.TextChanged,
                            cboKodeSatuan1.SelectedIndexChanged,
                            cboKodeSatuan2.SelectedIndexChanged,
                            cboKodeSatuan3.SelectedIndexChanged,
                            txtKodeUnitSAP.TextChanged,
                            chkProduksi.CheckedChanged,
                            chkAfval.CheckedChanged,
                            chkPemakaian.CheckedChanged,
                            txtPrefikKodeProduksi.TextChanged,
                            cboKodeLokasi.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmKelompokEkspedisi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeKelompok_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeUnit.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeUnit.Text.Trim() <> "" Then
            Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
            Dim UnitProduksi As UnitProduksi = DaftarUnitProduksi.Find(txtKodeUnit.Text)

            If Not IsNothing(UnitProduksi) Then
                txtNamaUnit.Text = UnitProduksi.NamaUnit
                cboKodeSatuan1.SelectedValue = UnitProduksi.KodeSatuan1
                cboKodeSatuan2.SelectedValue = UnitProduksi.KodeSatuan2
                cboKodeSatuan3.SelectedValue = UnitProduksi.KodeSatuan3
                txtKodeUnitSAP.Text = UnitProduksi.KodeUnitSAP
                txtPrefikKodeProduksi.Text = UnitProduksi.PrefikKodeProduksi
                chkProduksi.Checked = If(UnitProduksi.FlagProduksi = 1, True, False)
                chkAfval.Checked = If(UnitProduksi.FlagAfval = 1, True, False)
                chkPemakaian.Checked = If(UnitProduksi.FlagPemakaian = 1, True, False)
                cboKodeLokasi.SelectedValue = UnitProduksi.KodeLokasi

                txtKodeUnit.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarUnitProduksi.Locked(txtKodeUnit.Text)
            End If

            'CheckList KelompokSpesifikasiRelasi
            If _SaveMode = enumSaveMode.EditMode Then
                Dim DT As DataTable = DaftarUnitProduksi.ReadDetail(txtKodeUnit.Text).Tables("View")
                Dim DR As DataRow

                For Each DR In DT.Rows
                    For i = 0 To List.Items.Count - 1
                        If DR("Peruntukan") = List.Items(i).SubItems(1).Text Then
                            List.Items(i).Checked = True
                        End If
                    Next
                Next
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

                Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
                Dim UnitProduksi As UnitProduksi
                Dim UnitProduksiPeruntukan As UnitProduksiPeruntukan

                UnitProduksi = DaftarUnitProduksi.Find(txtKodeUnit.Text)
                If Not IsNothing(UnitProduksi) Then
                    DaftarUnitProduksi.DeleteDetail(txtKodeUnit.Text)
                End If

                UnitProduksi = New UnitProduksi
                UnitProduksi.KodeUnit = txtKodeUnit.Text
                UnitProduksi.NamaUnit = txtNamaUnit.Text
                UnitProduksi.KodeSatuan1 = cboKodeSatuan1.SelectedValue
                UnitProduksi.KodeSatuan2 = cboKodeSatuan2.SelectedValue
                UnitProduksi.KodeSatuan3 = cboKodeSatuan3.SelectedValue
                UnitProduksi.KodeUnitSAP = txtKodeUnitSAP.Text
                UnitProduksi.PrefikKodeProduksi = txtPrefikKodeProduksi.Text
                UnitProduksi.FlagProduksi = If(chkProduksi.Checked, 1, 0)
                UnitProduksi.FlagAfval = If(chkAfval.Checked, 1, 0)
                UnitProduksi.FlagPemakaian = If(chkPemakaian.Checked, 1, 0)
                UnitProduksi.KodeLokasi = cboKodeLokasi.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarUnitProduksi.Add(UnitProduksi)
                Else
                    DaftarUnitProduksi.Edit(UnitProduksi)
                End If

                For baris = 0 To List.CheckedItems.Count - 1
                    UnitProduksiPeruntukan = New UnitProduksiPeruntukan
                    UnitProduksiPeruntukan.KodeUnit = txtKodeUnit.Text
                    UnitProduksiPeruntukan.KodeUnitPeruntukan = List.CheckedItems(baris).SubItems(1).Text

                    DaftarUnitProduksi.AddDetail(UnitProduksiPeruntukan)
                Next

                If _SaveMode = enumSaveMode.AddMode Then
                    IDData = txtKodeUnit.Text
                    ResetData()
                    txtKodeUnit.Focus()
                Else
                    IDData = txtKodeUnit.Text
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

        btSave.Enabled = If(txtKodeUnit.Text.Trim() = "", False, True) And _
                         If(txtNamaUnit.Text.Trim() = "", False, True) And _
                         If(txtKodeUnitSAP.Text = "", False, True) And _
                         If(chkPemakaian.Checked, If(cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1, False, True), True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub

    Private Sub Data_Changed(sender As Object, e As ItemCheckedEventArgs)

    End Sub
End Class