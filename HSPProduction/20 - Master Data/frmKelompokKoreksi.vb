Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmKelompokKoreksi
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        Dim DT As DataTable
        DT = New DataTable
        DT.Columns.Add("KodeLokasi")
        DT.Columns.Add("NamaLokasi")

        lstLokasi.DataSource = DT
        lstLokasi.DisplayMember = "NamaLokasi"
        lstLokasi.ValueMember = "KodeLokasi"

        txtKodeKelompok.Enabled = True
        txtKodeKelompok.Text = ""
        txtNamaKelompok.Text = ""
        cboKelompok.SelectedIndex = -1
        chkKodeProduksi.Checked = False

        If _ID <> "" Then
            txtKodeKelompok.Text = _ID
            txtKodeKelompok_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub btAddLokasi_Click(sender As Object, e As EventArgs) Handles btAddLokasi.Click
        Dim Lookup As IDataLookup = New DaftarLokasi(ActiveSession)
        Dim Parameter() As String = {0}

        Dim Form As New frmLookup(Lookup, Parameter)
        Form.Text = "Daftar Lokasi Produksi"
        Form.ShowDialog()

        If Form.IDLookup <> "" Then
            Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
            Dim Lokasi As Lokasi = DaftarLokasi.Find(Form.IDLookup)

            lstLokasi.SelectedValue = Lokasi.Kodelokasi
            If lstLokasi.SelectedIndex = -1 Then

                Dim DR As DataRow
                DR = lstLokasi.DataSource.Rows.Add()

                DR("KodeLokasi") = Lokasi.Kodelokasi
                DR("NamaLokasi") = Lokasi.NamaLokasi

                lstLokasi.SelectedValue = Lokasi.Kodelokasi
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub DeleteList_Click(sender As Object, e As EventArgs) Handles DeleteList.Click
        Dim DT As DataTable

        If lstLokasi.SelectedValue <> "" Then
            DT = lstLokasi.DataSource
            DT.Rows(lstLokasi.SelectedIndex).Delete()

            lstLokasi.DataSource.AcceptChanges()

            SetEnableCommand()
        End If
    End Sub

    Private Sub frmKelompokKoreksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()
    End Sub

    Private Sub txtKodeKelompok_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeKelompok.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeKelompok.Text <> "" Then
            Dim DaftarKelompokKoreksi As New DaftarKelompokKoreksi(ActiveSession)
            Dim KelompokKoreksi As KelompokKoreksi = DaftarKelompokKoreksi.Find(txtKodeKelompok.Text)
            If Not IsNothing(KelompokKoreksi) Then
                _SaveMode = enumSaveMode.EditMode

                txtKodeKelompok.Enabled = False

                txtNamaKelompok.Text = KelompokKoreksi.NamaKelompok
                cboKelompok.SelectedIndex = KelompokKoreksi.Kelompok - 1
                chkKodeProduksi.Checked = If(KelompokKoreksi.KodeProduksi = 1, True, False)

                Dim DR As DataRow
                Dim oLokasi As DataRow
                Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
                Dim Lokasi As Lokasi

                For Each DR In DaftarKelompokKoreksi.ReadLokasi(txtKodeKelompok.Text).Tables("View").Rows
                    Lokasi = DaftarLokasi.Find(DR("KodeLokasi"))

                    oLokasi = lstLokasi.DataSource.Rows.Add()

                    oLokasi("KodeLokasi") = Lokasi.Kodelokasi
                    oLokasi("NamaLokasi") = Lokasi.NamaLokasi
                Next

            End If
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try

                    Dim DaftarKelompokKoreksi As New DaftarKelompokKoreksi(ActiveSession)
                    Dim KelompokKoreksi As KelompokKoreksi = DaftarKelompokKoreksi.Find(txtKodeKelompok.Text)
                    If Not IsNothing(KelompokKoreksi) Then
                        DaftarKelompokKoreksi.Delete(txtKodeKelompok.Text)
                    End If

                    For Each DR In lstLokasi.DataSource.Rows
                        KelompokKoreksi = New KelompokKoreksi
                        KelompokKoreksi.KodeKelompok = txtKodeKelompok.Text
                        KelompokKoreksi.NamaKelompok = txtNamaKelompok.Text
                        KelompokKoreksi.Kelompok = cboKelompok.SelectedIndex + 1
                        KelompokKoreksi.KodeProduksi = If(chkKodeProduksi.Checked, 1, 0)
                        KelompokKoreksi.KodeLokasi = DR("KodeLokasi")

                        DaftarKelompokKoreksi.Add(KelompokKoreksi)
                    Next

                    If _SaveMode = enumSaveMode.AddMode Then
                        IDData = txtKodeKelompok.Text
                        ResetData()
                        txtKodeKelompok.Focus()
                    Else
                        IDData = txtKodeKelompok.Text
                        Me.Close()
                    End If

                    Me.Cursor = Cursors.Default
                    '---------------------------------------------------------------------------------------------------------

                    Scope.Complete()
                    Scope.Dispose()

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try
            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

Jump:
        txtKodeKelompok.Focus()
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtKodeKelompok.Text = "", False, True) And _
            If(txtNamaKelompok.Text = "", False, True) And _
            If(cboKelompok.SelectedIndex = -1, False, True)

    End Sub
End Class