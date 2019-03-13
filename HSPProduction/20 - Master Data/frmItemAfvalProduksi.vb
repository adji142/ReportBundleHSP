Imports HSPProduction.HSP.Data

Public Class frmItemPemakaianProduksi
    'Data Public
    Public IDData As String

    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    'Data Private
    Private _ID As String
    Private _GroupID As String
    Private _SaveMode As enumSaveMode

    'Construktur 
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String, ByVal GroupID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
    End Sub

    'Form Load
    Private Sub frmKelompokEkspedisi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Kelompok Item
        Dim DaftarKelompokItem As New DaftarKelompokItem(ActiveSession)
        DS = New DataSet
        DS = DaftarKelompokItem.Read("%")
        cboKodeKelompok.DataSource = DS.Tables("View")
        cboKodeKelompok.DisplayMember = "Kelompok"
        cboKodeKelompok.ValueMember = "Kode"

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"

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
    End Sub

    'Reset Data
    Private Sub ResetData()
        Locked.Visible = False

        _SaveMode = enumSaveMode.AddMode
        txtKodeItem.Enabled = True

        txtKodeItem.Text = ""
        txtNamaItem.Text = ""

        cboKodeKelompok.SelectedValue = "600"
        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        cboKodeSatuan1.SelectedIndex = cboKodeSatuan1.Items.Count - 1
        cboKodeSatuan2.SelectedIndex = cboKodeSatuan2.Items.Count - 1
        cboKodeSatuan3.SelectedIndex = cboKodeSatuan3.Items.Count - 1

        txtKodeItemSistem.Text = ""
        txtNamaItemSistem.Text = ""

        If _ID <> "" Or _GroupID <> "" Then
            txtKodeItem.Text = _ID
            cboKodeUnit.SelectedValue = _GroupID
            txtKodeItem_Validating(Nothing, Nothing)
            _ID = ""
            _GroupID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtKodeItem.TextChanged,
                            txtNamaItem.TextChanged,
                            cboKodeKelompok.SelectedIndexChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            cboKodeSatuan1.SelectedIndexChanged,
                            cboKodeSatuan2.SelectedIndexChanged,
                            cboKodeSatuan3.SelectedIndexChanged,
                            txtKodeItemSistem.TextChanged,
                            chkAktif.CheckedChanged

        SetEnableCommand()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmItemPemakaianProduksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKodeItem_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeItem.Text.Trim() <> "" Then
            Dim DaftarItem As New DaftarItem(ActiveSession)
            Dim Item As Item = DaftarItem.Find(txtKodeItem.Text)

            If Not IsNothing(Item) Then
                txtNamaItem.Text = Item.NamaItem
                cboKodeKelompok.SelectedValue = Item.KodeKelompok
                cboKodeUnit.SelectedValue = Item.KodeUnit
                cboKodeSatuan1.SelectedValue = Item.KodeSatuan1
                cboKodeSatuan2.SelectedValue = Item.KodeSatuan2
                cboKodeSatuan3.SelectedValue = Item.KodeSatuan3
                txtKodeItemSistem.Text = Item.KodeItemSistem
                chkAktif.Checked = If(Item.Aktif = "1", True, False)

                txtKodeItem.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Locked.Visible = DaftarItem.Locked(txtKodeItem.Text)

            Else
                chkAktif.Checked = True
            End If
        End If

        SetEnableCommand()
    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                Try
                    '---------------------------------------------------------------------------------------------------------
                    btSave.Enabled = False
                    Me.Cursor = Cursors.WaitCursor

                    'Item General
                    Dim DaftarItem As New DaftarItem(ActiveSession)
                    Dim Item As New Item()

                    Item.KodeItem = txtKodeItem.Text
                    Item.NamaItem = txtNamaItem.Text
                    Item.KodeKelompok = cboKodeKelompok.SelectedValue
                    Item.KodeUnit = cboKodeUnit.SelectedValue
                    Item.KodeSatuan1 = cboKodeSatuan1.SelectedValue
                    Item.KodeSatuan2 = cboKodeSatuan2.SelectedValue
                    Item.KodeSatuan3 = cboKodeSatuan3.SelectedValue
                    Item.KodeItemSistem = txtKodeItemSistem.Text
                    Item.Aktif = If(chkAktif.Checked, 1, 0)

                    If _SaveMode = enumSaveMode.AddMode Then
                        DaftarItem.Add(Item)
                        IDData = txtKodeItem.Text
                        ResetData()
                        txtKodeItem.Focus()
                    Else
                        DaftarItem.Edit(Item)
                        IDData = txtKodeItem.Text
                        Me.Close()
                    End If

                    Me.Cursor = Cursors.Default
                    '---------------------------------------------------------------------------------------------------------
                Catch ex As Exception

                End Try
            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

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

    Private Sub cboKodeUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeUnit.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeUnit.PerformClick()
        End If
    End Sub


    Private Sub btLookupKodeSatuan1_Click(sender As Object, e As EventArgs) Handles btLookupKodeSatuan1.Click
        Dim DaftarSatuan As IDataLookup = New DaftarSatuan(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarSatuan, Parameter)
        Form.Text = "Lookup Daftar Satuan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeSatuan1.SelectedValue = Form.IDLookup
            cboKodeSatuan1.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeSatuan2_Click(sender As Object, e As EventArgs) Handles btLookupKodeSatuan2.Click
        Dim DaftarSatuan As IDataLookup = New DaftarSatuan(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarSatuan, Parameter)
        Form.Text = "Lookup Daftar Satuan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeSatuan2.SelectedValue = Form.IDLookup
            cboKodeSatuan2.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeSatuan3_Click(sender As Object, e As EventArgs) Handles btLookupKodeSatuan3.Click
        Dim DaftarSatuan As IDataLookup = New DaftarSatuan(ActiveSession)

        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(DaftarSatuan, Parameter)
        Form.Text = "Lookup Daftar Satuan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeSatuan3.SelectedValue = Form.IDLookup
            cboKodeSatuan3.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboKodeSatuan1_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeSatuan1.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeSatuan1.PerformClick()
        End If
    End Sub

    Private Sub cboKodeSatuan2_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeSatuan2.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeSatuan2.PerformClick()
        End If
    End Sub

    Private Sub cboKodeSatuan3_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeSatuan3.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeSatuan3.PerformClick()
        End If
    End Sub

    'Aktifkan Dan Non Aftifkan Tombol Berdasarkan Data Isian
    Private Sub SetEnableCommand()


        btSave.Enabled = If(txtKodeItem.Text.Trim() = "", False, True) And _
                         If(txtNamaItem.Text.Trim() = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(txtKodeItemSistem.Text.Trim() = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub
End Class