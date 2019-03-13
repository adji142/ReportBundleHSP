
' ---------------------------------------------------------------------------------------------------------
' Nama File   : frmUser.vb
' Deskripsi   : Form Untuk Menambah Dan Mengubah Data User
' Author      : Yudy Patrianto
' Tool        : VB.NET
' Database    : MySQL 5.x  
' Tanggal     : 27 Januari 2011
' ----------------------------------------------------------------------------------------------------------- 

Imports BOTSRV.Data

Public Class frmUser
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
    Private Sub frmUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    'Menampilkan Daftar Modul
    Private Sub FillCombo()

        Dim KeywordList As New KeywordList(ActiveSession)
        Dim Keyword As DataRow
        Dim Item As ListViewItem
        Dim Group As ListViewGroup


        For Each Keyword In KeywordList.ReadUserAccess().Tables("View").Rows
            If Keyword("KeywordID") = "" Then
                Item = lsvAccessRights.Items.Add(Keyword("Keyword"), Keyword("Keyword"), 0)
                Item.SubItems.Add(Keyword("Description"))
                Item.ForeColor = Color.Red
                Item.BackColor = Color.LightGray
            Else
                Item = lsvAccessRights.Items.Add(Keyword("Keyword"), Keyword("Keyword"), 0)
                Item.SubItems.Add(Space(10) + Keyword("Description"))
            End If
        Next

    End Sub

    'Reset Data
    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtUserID.Enabled = True

        txtUserID.Text = ""
        txtUserName.Text = ""
        chkActive.Checked = False

        If _ID <> "" Then
            txtUserID.Text = _ID
            txtUserID_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                             txtUserID.TextChanged,
                             txtUserName.TextChanged,
                             chkActive.CheckedChanged
        SetEnableCommand()
    End Sub


    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtUserID_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserID.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtUserID.Text.Trim() <> "" Then
            Dim UserList As New UserList(ActiveSession)
            Dim User As User = UserList.Find(txtUserID.Text)

            If Not IsNothing(User) Then
                txtUserName.Text = User.UserName
                chkActive.Checked = If(User.Active = 1, True, False)

                txtUserID.Enabled = False
                _SaveMode = enumSaveMode.EditMode

                Dim UserAccessList As New UserAccessList(ActiveSession)
                Dim Item As ListViewItem

                For Each Item In lsvAccessRights.Items
                    If Not IsNothing(UserAccessList.Find(txtUserID.Text, Item.Text)) Then
                        Item.Checked = True
                    End If
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

                Dim UserList As New UserList(ActiveSession)
                Dim UserAccessList As New UserAccessList(ActiveSession)
                Dim User As New User()
                Dim UserAccess As BOTSRV.Data.UserAccess

                User.UserID = txtUserID.Text
                User.UserName = txtUserName.Text
                User.Active = If(chkActive.Checked, 1, 0)

                If _SaveMode = enumSaveMode.AddMode Then
                    UserList.Add(User)
                    IDData = txtUserID.Text                    
                Else
                    UserList.Edit(User)
                    IDData = txtUserID.Text                    
                End If

                Dim Index As Integer = 0
                UserAccessList.Delete(txtUserID.Text)
                For Index = 0 To lsvAccessRights.Items.Count - 1

                    If lsvAccessRights.Items(Index).Checked Then
                        UserAccess = New BOTSRV.Data.UserAccess()
                        UserAccess.UserID = txtUserID.Text
                        UserAccess.Keyword = lsvAccessRights.Items(Index).Text
                        UserAccessList.Add(UserAccess)
                    End If

                Next

                'Simpan Inbox
                If chkActive.Checked Then
                    Dim _OutboxList As New OutboxList(ActiveSession)
                    Dim _Outbox As Outbox = Nothing
                    Dim _Text As String = ">>" + vbCrLf +
                                          "Selamat datang di layanan BOT" + vbCrLf +
                                          "**PT. Hardo Soloplast**" + vbCrLf +
                                          "Ketik Q atau pilih /MODUL untuk melihat daftar modul yang tersedia pada BOT Server" + vbCrLf +
                                          "<<"
                    _Outbox = New Outbox
                    _Outbox.UpdateID = txtUserID.Text.Trim()
                    _Outbox.ChatID = txtUserID.Text
                    _Outbox.ChatText = _Text
                    _Outbox.ChatTime = ""
                    _OutboxList.Add(_Outbox)
                End If

                Me.Close()



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
        btSave.Enabled = If(txtUserID.Text.Trim() = "", False, True) And _
                         If(txtUserName.Text.Trim() = "", False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** New **"
        Else
            Me.Text = Me.Tag + " | ** Edit **"
        End If

    End Sub

    Private Sub lsvAccessRights_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lsvAccessRights.ItemCheck
        SetEnableCommand()
    End Sub

    Private Sub lsvAccessRights_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lsvAccessRights.ItemChecked
        SetEnableCommand()
    End Sub
End Class