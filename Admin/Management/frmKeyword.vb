
' ---------------------------------------------------------------------------------------------------------
' Nama File   : frmKeyword.vb
' Deskripsi   : Form Untuk Menambah Dan Mengubah Data Keyword
' Author      : Yudy Patrianto
' Tool        : VB.NET
' Database    : MySQL 5.x  
' Tanggal     : 27 Januari 2011
' ----------------------------------------------------------------------------------------------------------- 

Imports BOTSRV.Data

Public Class frmKeyword
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
    Public Sub New(ByVal ID As String, GroupID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _GroupID = GroupID
    End Sub

    'Form Load
    Private Sub frmKeyword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCombo()
        ResetData()
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim PluginList As New PluginList(ActiveSession)

        Dim DS As DataSet = PluginList.Read("%")
        cboPluginID.DataSource = DS.Tables("View")
        cboPluginID.DisplayMember = "Description"
        cboPluginID.ValueMember = "ID"
        cboPluginID.SelectedValue = ""

        Dim Drow As DataRow = DS.Tables("View").Rows.Add()
        Drow("ID") = ""
        Drow("Description") = "<Select Plugin>"

        cboPluginID.SelectedIndex = cboPluginID.Items.Count - 1
    End Sub

    'Menampilkan Daftar Modul
    Private Sub ModulList()

        Try
            Dim RuntimeObject As Enerzie.Component.DynaClassInfo
            Dim Folder As String
            Dim AssemblyFileName As String

            Folder = Application.StartupPath
            AssemblyFileName = Folder + "\" + New PluginList(ActiveSession).Find(cboPluginID.SelectedValue).FileName

            RuntimeObject = Enerzie.Component.GetClassReference(AssemblyFileName, "AppModule")
            cboPluginKeywordID.DataSource = RuntimeObject.ClassObject.GetAppModule()
            cboPluginKeywordID.DisplayMember = "AppDescription"
            cboPluginKeywordID.ValueMember = "PluginKeywordID"

            Dim Drow As DataRow = cboPluginKeywordID.DataSource.Rows.Add()
            Drow("PluginKeywordID") = ""
            Drow("AppDescription") = "<Select Module>"

            cboPluginKeywordID.SelectedIndex = cboPluginKeywordID.Items.Count - 1
            cboPluginKeywordID.Enabled = True

        Catch ex As Exception
            cboPluginKeywordID.DataSource = Nothing
            cboPluginKeywordID.Enabled = False
        End Try

    End Sub

    'Reset Data
    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtKeyword.Enabled = True

        txtKeyword.Text = ""
        txtDescription.Text = ""

        If _ID <> "" Or _GroupID <> "" Then
            cboPluginID.SelectedValue = _GroupID

            txtKeyword.Text = _ID
            txtKeyword_Validating(Nothing, Nothing)

            _ID = ""
            _GroupID = ""

            SendKeys.Send("{TAB}")
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                             cboPluginID.SelectedIndexChanged,
                             txtKeyword.TextChanged,
                             txtDescription.TextChanged,
                             cboPluginKeywordID.SelectedIndexChanged
        SetEnableCommand()
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboPluginID_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPluginID.SelectedValueChanged
        ModulList()
    End Sub

    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtKeyword_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKeyword.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtKeyword.Text.Trim() <> "" Then
            Dim KeywordList As New KeywordList(ActiveSession)
            Dim Keyword As Keyword = KeywordList.Find(txtKeyword.Text)

            If Not IsNothing(Keyword) Then
                txtDescription.Text = Keyword.Description
                cboPluginID.SelectedValue = Keyword.PluginID
                cboPluginKeywordID.SelectedValue = Keyword.PluginKeywordID
                txtKeyword.Enabled = False
                _SaveMode = enumSaveMode.EditMode
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

                Dim KeywordList As New KeywordList(ActiveSession)
                Dim Keyword As New Keyword()

                Keyword.Keyword = txtKeyword.Text
                Keyword.Description = txtDescription.Text
                Keyword.KeywordParameter = ""
                Keyword.PluginID = cboPluginID.SelectedValue
                Keyword.PluginKeywordID = cboPluginKeywordID.SelectedValue

                If _SaveMode = enumSaveMode.AddMode Then
                    KeywordList.Add(Keyword)
                    IDData = txtKeyword.Text
                    ResetData()
                    txtKeyword.Focus()
                Else
                    KeywordList.Edit(Keyword)
                    IDData = txtKeyword.Text
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
        btSave.Enabled = txtKeyword.Text.Trim() <> "" And _
                         txtDescription.Text.Trim() <> "" And _
                         cboPluginID.SelectedIndex <> cboPluginID.Items.Count - 1 And _
                         cboPluginKeywordID.Enabled

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** New **"
        Else
            Me.Text = Me.Tag + " | ** Edit **"
        End If

    End Sub
    
End Class