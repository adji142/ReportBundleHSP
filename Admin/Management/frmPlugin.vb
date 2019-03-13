
' ---------------------------------------------------------------------------------------------------------
' Nama File   : frmPlugin.vb
' Deskripsi   : Form Untuk Menambah Dan Mengubah Data Plugin
' Author      : Yudy Patrianto
' Tool        : VB.NET
' Database    : MySQL 5.x  
' Tanggal     : 27 Januari 2011
' ----------------------------------------------------------------------------------------------------------- 

Imports BOTSRV.Data

Public Class frmPlugin
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
    Private Sub frmPlugin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetData()
    End Sub

    'Reset Data
    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtPluginID.Enabled = True

        txtPluginID.Text = ""
        txtDescription.Text = ""
        txtFileName.Text = ""
        txtKeyword.Text = ""

        If _ID <> "" Then
            txtPluginID.Text = _ID
            txtPluginID_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
        btSave.Enabled = False

    End Sub

    'Cek Jika Data Berubah
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                             txtPluginID.TextChanged,
                             txtDescription.TextChanged,
                             txtFileName.TextChanged,
                             txtKeyword.TextChanged
        SetEnableCommand()
    End Sub


    'Jika Ada Penekanan Tombol Pada Form
    Private Sub frmPlugin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtPluginID_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPluginID.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtPluginID.Text.Trim() <> "" Then
            Dim PluginList As New PluginList(ActiveSession)
            Dim Plugin As Plugin = PluginList.Find(txtPluginID.Text)

            If Not IsNothing(Plugin) Then
                txtDescription.Text = Plugin.Description
                txtFileName.Text = Plugin.FileName
                txtKeyword.Text = Plugin.Keyword

                txtPluginID.Enabled = False
                btTest.PerformClick()
                _SaveMode = enumSaveMode.EditMode
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        Dim RuntimeObject As Enerzie.Component.DynaClassInfo
        Dim Folder As String
        Dim DT As DataTable
        Dim AssemblyFileName As String

        Folder = Application.StartupPath
        AssemblyFileName = Folder + "\" + txtFileName.Text

        lstPluginKeywordList.DataSource = Nothing

        Try
            RuntimeObject = Enerzie.Component.GetClassReference(AssemblyFileName, "AppModule")
            DT = RuntimeObject.ClassObject.GetAppModule()
            Dim NR As Integer = DT.Rows.Count
            Dim DR As DataRow = DT.Rows.Add()

            DR = DT.Rows.Add()
            DR("PluginKeywordID") = " "
            DR("AppDescription") = "OK"

            lstPluginKeywordList.DataSource = DT
            lstPluginKeywordList.DisplayMember = "AppDescription"
            lstPluginKeywordList.ValueMember = "PluginKeywordID"
            lstPluginKeywordList.Refresh()

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    'Evaluasi Jika Button Dipilih
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim KeywordList As New KeywordList(ActiveSession)
                Dim Keyword As Keyword = Nothing

                KeywordList.Delete(txtKeyword.Text.Trim.ToUpper)
                Keyword = New Keyword
                Keyword.PluginID = txtPluginID.Text
                Keyword.PluginKeywordID = ""
                Keyword.Keyword = txtKeyword.Text.Trim.ToUpper
                Keyword.Description = txtDescription.Text
                Keyword.KeywordParameter = ""
                KeywordList.Add(Keyword)

                Dim PluginList As New PluginList(ActiveSession)
                Dim Plugin As New Plugin()

                Plugin.PluginID = txtPluginID.Text
                Plugin.Description = txtDescription.Text
                Plugin.FileName = txtFileName.Text
                Plugin.Keyword = txtKeyword.Text.Trim.ToUpper

                If _SaveMode = enumSaveMode.AddMode Then
                    PluginList.Add(Plugin)
                    IDData = txtPluginID.Text
                    ResetData()
                    txtPluginID.Focus()
                Else
                    PluginList.Edit(Plugin)
                    IDData = txtPluginID.Text
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
        btSave.Enabled = If(txtPluginID.Text.Trim() = "", False, True) And _
                         If(txtDescription.Text.Trim() = "", False, True) And _
                         If(txtFileName.Text.Trim() = "", False, True) And _
                         If(txtKeyword.Text.Trim() = "", False, True) And _
                         If(lstPluginKeywordList.Items.Count = 0, False, True)

        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** New **"
        Else
            Me.Text = Me.Tag + " | ** Edit **"
        End If

    End Sub

End Class