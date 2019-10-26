Imports HSPNotulen.HSP.Data


Public Class FrmMetting
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
    End Sub
    Private Sub ResetForm()
        _SaveMode = enumSaveMode.AddMode
        txttopik.Text = ""
        cboPeriod.SelectedIndex = 0
        cboDept.SelectedIndex = cboDept.Items.Count - 1
        cbkAktif.Checked = True

        If _ID <> "" Then
            txttopik.Text = _ID
            txttopik_Validating(Nothing, Nothing)
            _ID = ""
        End If
        SetEnableCommand()
        btSave.Enabled = False
    End Sub
    Private Sub SetEnableCommand()
        btSave.Enabled = If(txttopik.Text = "", False, True) And _
                        If(cboDept.Text = "-", False, True) And _
                        If(cboPeriod.Text = "-", False, True)
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

                Dim DaftarMetting As New DaftarMetting(ActiveSession)
                Dim Meeting As New Meeting()

                Meeting.Topik = txttopik.Text
                Meeting.Periode = cboPeriod.Text
                Meeting.KodeDepartement = cboDept.SelectedValue
                Meeting.NamaDepartement = cboDept.Text
                Meeting.Status = cbkAktif.Checked

                If _SaveMode = enumSaveMode.AddMode Then
                    DaftarMetting.Add(Meeting)
                    IDData = txttopik.Text
                    ResetForm()
                    txttopik.Focus()
                End If
            Case "btClose"
                Me.Close()
        End Select
    End Sub

    Private Sub FrmMetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        ResetForm()
    End Sub

    Private Sub cmdBrowseDept_Click(sender As Object, e As EventArgs) Handles cmdBrowseDept.Click
        Dim DaftarDept As IDataLookup = New DaftarHRDept()
        Dim Parameter() As String = {1}

        Dim Form As New frmLookup(DaftarDept, Parameter)
        Form.ShowDialog()

        If Form.IDLookup <> "" Then
            cboDept.SelectedValue = Form.IDLookup
            cboDept.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txttopik_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txttopik.Validating
        _SaveMode = enumSaveMode.AddMode
        If txttopik.Text.Trim <> "" Then
            Dim DaftarTopik As New DaftarMetting(ActiveSession)
            Dim Topik As Meeting = DaftarTopik.Find(txttopik.Text)

            If Not IsNothing(Topik) Then
                txttopik.Text = Topik.Topik
                Select Case Topik.Periode
                    Case "Bulanan"
                        cboPeriod.SelectedIndex = 1
                    Case "Bulanan"
                        cboPeriod.SelectedIndex = 2
                    Case "Mingguan"
                        cboPeriod.SelectedIndex = 3
                    Case "InCase"
                        cboPeriod.SelectedIndex = 4
                End Select
                cboDept.SelectedValue = Topik.KodeDepartement
                cbkAktif.Checked = Topik.Status
                txttopik.Enabled = False
                    _SaveMode = enumSaveMode.EditMode
                End If
        End If
    End Sub

    Private Sub Data_TextChanged(sender As Object, e As EventArgs) Handles _
        txttopik.TextChanged,
        cboPeriod.SelectedIndexChanged,
        cboDept.SelectedIndexChanged

        SetEnableCommand()
    End Sub
End Class