Imports Enerzie.EPSGridControls.EPSTableEdit
Imports Microsoft.Win32
Imports HSPHRDCONSOLE.HSP.Data
Imports System.Text.RegularExpressions
Public Class FrmUserSetting
    Public IDData As String

    'Data Private
    Private KodeBagian As String = ""
    Private _ID As String
    Private _UserName As String
    Private Cek As String = ""
    Private _KryID As String = ""

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        '_KryID = ID_Kry
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        txtUserID.Enabled = True

        If _ID <> "" Then
            txtUserID.Text = _ID
            txtUserID_Validating(Nothing, Nothing)
            _ID = ""
        Else
            txtUserID.Text = ""
            txtUserName.Text = ""
            txtNik.Text = ""
            txtNamaKaryawan.Text = ""
            txtUserID.Focus()

        End If

        SetEnableCommand()
        btSave.Enabled = False
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtNik.Text.Trim() = "", False, True)
        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If

    End Sub

    Private Sub txtNik_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNik.KeyDown
        Select Case e.KeyCode
            Case Keys.F10
                Dim DaftarKry As IDataLookup = New DaftarHRKaryawan_HRD()
                Dim Parameter() As String = {DaftarHRKaryawan_HRD.enumLookupKaryawan.DaftarKaryawan, txtNik.Text}

                Dim Form As New frmLookup_HRIS(DaftarKry, Parameter)
                Form.Text = "Lookup Daftar Karyawan"
                Form.ShowDialog()
                If Form.IDLookup <> "" Then
                    txtNik.Text = Form.IDLookup
                    txtNamaKaryawan.Text = Form.NamaKaryawan
                    btSave.Focus()
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            txtNik.TextChanged
        SetEnableCommand()
    End Sub

    Private Sub FrmUserSetting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F6
                If btSave.Enabled Then
                    btSave.PerformClick()
                End If
        End Select
    End Sub

    Private Sub FrmUserSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If (_KryID <> "") Then
        '    Dim DarftarUserkry As New UserKaryawan(ActiveSession)
        '    Dim DataSet As DataSet = DarftarUserkry.CheckValidation("", _KryID)
        '    txtNamaKaryawan.Text = DataSet.Tables(0).Rows(0)(1).ToString()
        '    txtNik.Text = _KryID
        'End If
        'txtUserID.Text = _ID
        'txtUserName.Text = _UserName
        ResetData()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs)
        Dim DaftarKry As IDataLookup = New DaftarHRKaryawan_HRD()
        Dim Parameter() As String = {DaftarHRKaryawan_HRD.enumLookupKaryawan.DaftarKaryawan, txtNamaKaryawan.Text}

        Dim Form As New frmLookup_HRIS(DaftarKry, Parameter)
        Form.Text = "Lookup Daftar Karyawan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            txtNik.Text = Form.IDLookup
            txtNamaKaryawan.Text = Form.NamaKaryawan
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Validasi()
        Dim DarftarUserkry As New UserKaryawan(ActiveSession)
        Dim DataSet As DataSet = DarftarUserkry.CheckValidation(txtUserID.Text, txtNik.Text)

        If (DataSet.Tables(0).Rows.Count > 0) Then
            MessageBox.Show("Karyawan Sudah di daftarkan di user " + DataSet.Tables(0).Rows(0)(1).ToString)
            Cek = "Error"
            btSave.Enabled = True
            Return
        Else
            Cek = ""
        End If
    End Sub

    Private Sub txtNamaKry_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtNamaKry_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                Dim DaftarKry As IDataLookup = New DaftarHRKaryawan_HRD()
                Dim Parameter() As String = {DaftarHRKaryawan_HRD.enumLookupKaryawan.DaftarKaryawan, txtNamaKaryawan.Text}

                Dim Form As New frmLookup_HRIS(DaftarKry, Parameter)
                Form.Text = "Lookup Daftar Karyawan"
                Form.ShowDialog()
                If Form.IDLookup <> "" Then
                    txtNik.Text = Form.IDLookup
                    txtNamaKaryawan.Text = Form.NamaKaryawan
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub

    Private Sub txtUserID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUserID.Validating
        If (txtUserID.Text.Trim <> "") Then
            Dim DaftarKry As New UserKaryawan(ActiveSession)
            Dim Kry As User = DaftarKry.Find(txtUserID.Text)

            If Not IsNothing(Kry) Then
                txtUserName.Text = Kry.UserName
                txtNik.Text = Kry.NIK
                txtNamaKaryawan.Text = Kry.NamaKaryawan
            End If
            If (txtNik.Text <> "") Then
                _SaveMode = enumSaveMode.EditMode
                txtUserID.Enabled = False
                txtUserName.Enabled = False
            Else
                _SaveMode = enumSaveMode.AddMode
                txtUserID.Enabled = True
                txtUserName.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtNik_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNik.Validating
        If (txtNik.Text <> "") Then

            Dim HRISKry As New DaftarHRKaryawan_HRD()
            Dim Kry As DataSet = HRISKry.Find(txtNik.Text)

            If Kry.Tables(0).Rows.Count > 0 Then
                txtNamaKaryawan.Text = Kry.Tables(0).Rows(0)(1).ToString()
                btSave.Enabled = True
                btSave.Focus()
            Else
                MessageBox.Show("NIK Tidak Ditemukan")
                txtNik.Text = ""
                txtNamaKaryawan.Text = ""
                txtNik.Focus()
                btSave.Enabled = False
            End If

        End If
    End Sub

    Private Sub btLookupNik_Click(sender As Object, e As EventArgs) Handles btLookupNik.Click
        Dim DaftarKry As IDataLookup = New DaftarHRKaryawan_HRD()
        Dim Parameter() As String = {DaftarHRKaryawan_HRD.enumLookupKaryawan.DaftarKaryawan, txtNamaKaryawan.Text}

        Dim Form As New frmLookup_HRIS(DaftarKry, Parameter)
        Form.Text = "Lookup Daftar Karyawan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            txtNik.Text = Form.IDLookup
            txtNamaKaryawan.Text = Form.NamaKaryawan
            btSave.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btClose.Click, btSave.Click
        sender.Focus()
        DirectCast(sender, Button).Enabled = False
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                'Code Hire
                btSave.Enabled = False
                Validasi()
                Dim DaftarKry As New UserKaryawan(ActiveSession)
                Dim Insert As KryUpdate
                Insert = New KryUpdate
                Insert.userid = txtUserID.Text
                Insert.karyawanid = Integer.Parse(txtNik.Text.ToString)
                Insert.NamaKaryawan = txtNamaKaryawan.Text

                If (_SaveMode = enumSaveMode.AddMode) Then
                    If (Cek) = "" Then
                        Try
                            DaftarKry.AddUser(Insert)
                            IDData = txtUserID.Text
                            _ID = ""
                            ResetData()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                Else
                    'Edit
                    DaftarKry.Edit(Insert)
                    IDData = txtUserID.Text
                    Me.Close()
                End If
            Case "btClose"
                Me.Close()
        End Select
    End Sub
End Class