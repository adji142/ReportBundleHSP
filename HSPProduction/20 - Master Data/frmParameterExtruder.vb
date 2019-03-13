Imports HSPProduction.HSP.Data

Public Class frmParameterExtruder
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

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtKodeItem.Enabled = True

        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtDenierAktual.Text = ""
        txtJmlBenang.Text = ""
        txtKecepatan.Text = ""
        txtKapasitas.Text = ""

        If _ID <> "" Then
            txtKodeItem.Text = _ID
            txtKodeItem_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmParameterExtruder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()
    End Sub

    Private Sub frmParameterExtruder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeItem.Text <> "" Then
            Dim DPRL As New DaftarParameterExtruder(ActiveSession)
            Dim PRL As ParameterExtruder = DPRL.Find(txtKodeItem.Text)
            If Not IsNothing(PRL) Then
                _SaveMode = enumSaveMode.EditMode
                txtKodeItem.Enabled = False

                txtNamaItem.Text = PRL.NamaItem
                txtDenierAktual.Value = PRL.DenierAktual
                txtJmlBenang.Value = PRL.JmlBenang
                txtKecepatan.Value = PRL.Kecepatan
                txtKapasitas.Value = PRL.Kapasitas
                txtKonstanta.Value = PRL.Konstanta
            Else
                Dim SAP As New SAPInventory()
                Dim Item As ItemSAP = SAP.FindItem(txtKodeItem.Text)
                If Not IsNothing(Item) Then
                    txtNamaItem.Text = Item.NamaItem
                Else
                    MessageBox.Show("Kode Item Tidak Terdaftar...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNamaItem.Text = ""

                    txtKodeItem.Focus()
                End If
            End If

        End If

        SetEnableCommand()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                        txtKodeItem.TextChanged,
                        txtNamaItem.TextChanged,
                        txtDenierAktual.TextChanged,
                        txtJmlBenang.TextChanged,
                        txtKecepatan.TextChanged,
                        txtKapasitas.TextChanged,
                        txtKonstanta.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DPRL As New DaftarParameterExtruder(ActiveSession)
                Dim PRL As New ParameterExtruder

                PRL.KodeItem = txtKodeItem.Text
                PRL.NamaItem = txtNamaItem.Text
                PRL.DenierAktual = txtDenierAktual.Value
                PRL.JmlBenang = txtJmlBenang.Value
                PRL.Kecepatan = txtKecepatan.Value
                PRL.Kapasitas = txtKapasitas.Value
                PRL.Konstanta = txtKonstanta.Value

                If _SaveMode = enumSaveMode.AddMode Then
                    DPRL.Add(PRL)
                    IDData = txtKodeItem.Text
                    ResetData()
                    txtKodeItem.Focus()
                Else
                    DPRL.Edit(PRL)
                    IDData = txtKodeItem.Text
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

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtKodeItem.Text = "", False, True) And
                         If(txtNamaItem.Text = "", False, True) 
    End Sub

    
End Class