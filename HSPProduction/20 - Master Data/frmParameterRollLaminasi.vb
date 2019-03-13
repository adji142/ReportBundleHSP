Imports HSPProduction.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit

Public Class frmParameterRollLaminasi
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

    Private Const _PP = 0
    Private Const _PE = 1
    Private Const _Vist = 2
    Private Const _Bopp = 3
    Private Const _Total = 4

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtKodeItem.Enabled = True

        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        OptionBopp.Checked = True
        OptionNonBopp.Checked = False
        txtBahanPP.Text = ""
        txtBahanPE.Text = ""
        txtBahanVist.Text = ""
        txtBahanBopp.Text = ""
        txtTotalBahan.Text = ""

        If _ID <> "" Then
            txtKodeItem.Text = _ID
            txtKodeItem_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmParameterRollLaminasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                        txtKodeItem.TextChanged,
                        txtNamaItem.TextChanged,
                        txtBeratKarung.TextChanged,
                        OptionBopp.CheckedChanged,
                        OptionNonBopp.CheckedChanged,
                        txtBahanPP.TextChanged,
                        txtBahanPE.TextChanged,
                        txtBahanVist.TextChanged,
                        txtBahanBopp.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub Grid_GridCellPreValidation(Col As Integer, Row As Integer, ByRef Cancel As Boolean)
        If OptionNonBopp.Checked = True And Col = _Bopp Then
            Cancel = True
        End If
    End Sub

    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKodeItem.Text <> "" Then
            Dim DPRL As New DaftarParameterRollLaminasi(ActiveSession)
            Dim PRL As ParameterRollLaminasi = DPRL.Find(txtKodeItem.Text)
            If Not IsNothing(PRL) Then
                _SaveMode = enumSaveMode.EditMode
                txtKodeItem.Enabled = False

                txtNamaItem.Text = PRL.NamaItem
                txtBeratKarung.Value = PRL.BeratKarung
                OptionBopp.Checked = If(PRL.FlagBOPP = 1, True, False)
                OptionNonBopp.Checked = If(PRL.FlagBOPP = 0, True, False)
                txtBahanPP.Value = PRL.PP
                txtBahanPE.Value = PRL.PE
                txtBahanVist.Value = PRL.Vist
                txtBahanBopp.Value = PRL.Bopp
            Else
                Dim SAP As New SAPInventory()
                Dim Item As ItemSAP = SAP.FindItem(txtKodeItem.Text)
                If Not IsNothing(Item) Then
                    txtNamaItem.Text = Item.NamaItem
                    txtBeratKarung.Value = Item.BeratStandar
                Else
                    MessageBox.Show("Kode Item Tidak Terdaftar...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNamaItem.Text = ""
                    txtBeratKarung.Text = ""

                    txtKodeItem.Focus()
                End If
            End If

        End If

        SetEnableCommand()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DPRL As New DaftarParameterRollLaminasi(ActiveSession)
                Dim PRL As New ParameterRollLaminasi

                PRL.KodeItem = txtKodeItem.Text
                PRL.NamaItem = txtNamaItem.Text
                PRL.FlagBOPP = If(OptionBopp.Checked, 1, 0)
                PRL.BeratKarung = txtBeratKarung.Value
                PRL.PP = txtBahanPP.Value
                PRL.PE = txtBahanPE.Value
                PRL.Vist = txtBahanVist.Value
                PRL.Bopp = txtBahanBopp.Value
                PRL.Total = txtTotalBahan.Value
                PRL.BeratTeoritis = txtBeratTeoritis.Value

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
        If OptionNonBopp.Checked Then
            txtBahanBopp.Enabled = False
        Else
            txtBahanBopp.Enabled = True
        End If

        txtTotalBahan.Value = txtBahanPP.Value + txtBahanPE.Value + txtBahanVist.Value + txtBahanBopp.Value

        txtBeratTeoritis.Value = txtBeratKarung.Value + txtTotalBahan.Value

        btSave.Enabled = If(txtKodeItem.Text = "", False, True) And
                         If(txtNamaItem.Text = "", False, True) And
                         If((OptionBopp.Checked = False And OptionNonBopp.Checked = False), False, True)
    End Sub
End Class