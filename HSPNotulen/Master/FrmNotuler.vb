Imports HSPNotulen.HSP.Data
Public Class FrmNotuler
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
        _ID = ""
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        Dim DaftarDept As New DaftarHRDept()
        DS = New DataSet()
        DS = DaftarDept.Read("%")

        cboDept.DataSource = DS.Tables("View")
        cboDept.DisplayMember = "Departemen"
        cboDept.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Departemen") = "-"

        '---------------------------- Karyawan ----------------------------
        Dim DaftarKry As New DaftarHRKaryawan()
        DS = New DataSet()
        DS = DaftarKry.Read()

        cboKry.DataSource = DS.Tables("View")
        cboKry.DisplayMember = "Nama Karyawan"
        cboKry.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Karyawan") = ""
    End Sub
    Private Sub ResetForm()
        _SaveMode = enumSaveMode.AddMode
        cboDept.SelectedIndex = cboDept.Items.Count - 1
        cboKry.SelectedIndex = cboDept.Items.Count - 1
        'If _ID <> "" Then
        'txttopik.Text = _ID
        '            txttopik_Validating(Nothing, Nothing)
        '_ID = ""
        'End If
        SetEnableCommand()
        btSave.Enabled = False
    End Sub
    Private Sub SetEnableCommand()
        btSave.Enabled = If(cboDept.Text = "-", False, True) And _
                        If(cboKry.Text = "-", False, True)
        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btClose.Click, btSave.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                ' Save Triger
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim DaftarNotulen As New DaftarNotuler(ActiveSession)
                Dim Notuler As New Notuler()

                Notuler.KodeDept = cboDept.SelectedValue
                Notuler.Departement = cboDept.Text
                Notuler.NIK = cboKry.SelectedValue
                Notuler.NamaNotulen = cboKry.Text

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarNotulen.Add(Notuler)
                    Dim dn As New DaftarNotuler(ActiveSession)
                    Dim LastID As Notuler = dn.GetMaxID()
                    IDData = LastID.id
                    ResetForm()
                    cboDept.Focus()
                End If


            Case "btClose"
                Me.Close()
        End Select
    End Sub

    Private Sub FrmMetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _SaveMode = enumSaveMode.AddMode
        FillCombo()
        ResetForm()
        If _ID.Trim <> "" Then
            Dim DaftarNotuler As New DaftarNotuler(ActiveSession)
            Dim LsNotuler As Notuler = DaftarNotuler.Find(_ID.Trim)

            If Not IsNothing(LsNotuler) Then
                cboDept.SelectedValue = LsNotuler.KodeDept
                cboKry.SelectedValue = LsNotuler.NIK
                _SaveMode = enumSaveMode.EditMode
            End If
        End If
    End Sub


    Private Sub Data_TextChanged(sender As Object, e As EventArgs) Handles _
        cboKry.SelectedIndexChanged,
        cboDept.SelectedIndexChanged

        SetEnableCommand()
    End Sub

    Private Sub cmdlookup_Click(sender As Object, e As EventArgs) Handles cmdlookup.Click
        Dim DaftarKry As IDataLookup = New DaftarHRKaryawan()
        Dim Parameter() As String = {DaftarHRKaryawan.enumLookupKaryawan.DaftarKaryawan, "", ""}

        Dim Form As New frmLookup(DaftarKry, Parameter)
        Form.Text = "Lookup Karyawan"
        Form.ShowDialog()

        If Form.IDLookup Then
            cboKry.SelectedValue = Form.IDLookup
            cboKry.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
