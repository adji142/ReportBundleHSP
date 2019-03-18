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
    Public Sub New()
        InitializeComponent()
    End Sub

    'Construktur Overloading
    Public Sub New(ByVal ID As String, Username As String, ByVal karyawanid As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _UserName = Username
        _KryID = karyawanid
        'btProses.Enabled = False
    End Sub

    Private Sub FrmUserSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (_KryID <> "") Then
            Dim DarftarUserkry As New UserKaryawan(ActiveSession)
            Dim DataSet As DataSet = DarftarUserkry.CheckValidation("", _KryID)
            txtNamaKry.Text = DataSet.Tables(0).Rows(0)(1).ToString()
            lblidkry.Text = _KryID
        End If
        txtuserid.Text = _ID
        txtusername.Text = _UserName
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim DaftarKry As IDataLookup = New DaftarHRKaryawan_HRD()
        Dim Parameter() As String = {DaftarHRKaryawan_HRD.enumLookupKaryawan.DaftarKaryawan, txtNamaKry.Text}

        Dim Form As New frmLookup_HRIS(DaftarKry, Parameter)
        Form.Text = "Lookup Daftar Karyawan"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            lblidkry.Text = Form.IDLookup
            txtNamaKry.Text = Form.NamaKaryawan
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btKeluar.Click, btSave.Click
        sender.Focus()

        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                Validasi()
                If (Cek = "") Then
                    ' Proses saving

                    Try
                        Dim DaftarKry As New UserKaryawan(ActiveSession)
                        Dim Insert As KryUpdate

                        Insert = New KryUpdate
                        Insert.userid = txtuserid.Text
                        Insert.karyawanid = Integer.Parse(lblidkry.Text.ToString)

                        DaftarKry.AddUser(Insert)
                        IDData = txtuserid.Text
                        Me.Close()
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                       ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End Try
                End If

            Case "btKeluar"
                Me.Close()
        End Select
    End Sub
    Private Sub Validasi()
        Dim DarftarUserkry As New UserKaryawan(ActiveSession)
        Dim DataSet As DataSet = DarftarUserkry.CheckValidation(txtuserid.Text, lblidkry.Text)

        If (DataSet.Tables(0).Rows.Count > 0) Then
            MessageBox.Show("Karyawan Sudah di daftarkan di user " + DataSet.Tables(0).Rows(0)(1).ToString)
            Cek = "Error"
            btSave.Enabled = True
            Return
        Else
            Cek = ""
        End If
    End Sub

    Private Sub txtNamaKry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaKry.KeyPress

    End Sub

    Private Sub txtNamaKry_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNamaKry.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim DaftarKry As IDataLookup = New DaftarHRKaryawan_HRD()
                Dim Parameter() As String = {DaftarHRKaryawan_HRD.enumLookupKaryawan.DaftarKaryawan, txtNamaKry.Text}

                Dim Form As New frmLookup_HRIS(DaftarKry, Parameter)
                Form.Text = "Lookup Daftar Karyawan"
                Form.ShowDialog()
                If Form.IDLookup <> "" Then
                    lblidkry.Text = Form.IDLookup
                    txtNamaKry.Text = Form.NamaKaryawan
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub
End Class