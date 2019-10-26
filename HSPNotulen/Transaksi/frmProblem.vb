Imports HSPNotulen.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports Microsoft.Win32

Imports System.Text.RegularExpressions

Public Class frmProblem
    Public _ID As String
    Public _Order As Integer
    Public _Success As Boolean
    Public _Problem As String
    Public _Status As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum
    Private _SaveMode As enumSaveMode

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub
    Public Sub New(ByVal problem As String, ByVal Status As String, ByVal Order As Integer)
        Me.New()
        _Problem = problem
        _Status = Status
        _Order = Order
        _SaveMode = enumSaveMode.EditMode
    End Sub
    Private Sub ResetForm()
        _SaveMode = enumSaveMode.AddMode
        txtProblem.Text = ""
        cbostatus.SelectedIndex = 1
        If _Problem <> "" Then
            _SaveMode = enumSaveMode.EditMode
            txtProblem.Text = _Problem
            Select Case _Status
                Case "Done"
                    cbostatus.SelectedIndex = 0
                Case "Open"
                    cbostatus.SelectedIndex = 1
                Case "Pending"
                    cbostatus.SelectedIndex = 2
                Case "Cancel"
                    cbostatus.SelectedIndex = 3
            End Select
        End If
        SendKeys.Send("{TAB}")
        SetEnableCommand()
        btSave.Enabled = False
    End Sub
    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtProblem.Text = "", False, True) And _
                        If(cbostatus.Text = "-", False, True)
        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If
    End Sub


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btClose.Click, btSave.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                _Success = True
                _Problem = txtProblem.Text
                _Status = cbostatus.Text
                Me.Close()
                ' Save Triger
            Case "btClose"
                Me.Close()
        End Select
    End Sub
    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                         txtProblem.TextChanged, _
                         cbostatus.SelectedValueChanged

        SetEnableCommand()
    End Sub

    Private Sub frmProblem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub
End Class