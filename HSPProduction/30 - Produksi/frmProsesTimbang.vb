Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmProsesTimbang

#Region "Controller"

    Public BeratBrutto As Double = 0
    Public BeratNetto As Double = 0
    Public KodeMedia As String = ""
    Public BeratMedia As Double = 0
    Public KodeLokasi As String = ""
    Public KodeUnit As String = ""
    Public FormID As Byte = 0
    Public Result As String = ""

    Private DataScale As String = 0

    Private Sub frmProsesTimbang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ActiveSession.KodeUser.Trim.ToUpper = "SPVS" Then
            lblTimbangManual.Visible = True
            chkManual.Visible = True
            txtTimbangManual.Visible = True
        Else
            lblTimbangManual.Visible = False
            chkManual.Visible = False
            txtTimbangManual.Visible = False
        End If

        chkManual.Checked = False
        txtTimbangManual.Value = 0
        txtTimbangManual.Enabled = False
        lblTimbangManual.Enabled = False
        lblStabil.Visible = False
        lblIndicator.ForeColor = Color.Black

        Call tmrScale_Tick(Nothing, Nothing)
        BeratBrutto = 0
        BeratNetto = 0
        Result = ""
        ScaleConnection()
        FillCombo()

    End Sub

    Private Sub frmProsesTimbang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ScalePort.Close()
    End Sub

    'Lookup Jika Ditekan F10
    Private Sub cboKodeMedia_KeyDown(sender As Object, e As KeyEventArgs) Handles cboKodeMedia.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupKodeMedia.PerformClick()
        End If
    End Sub

    Private Sub btLookupKodeMedia_Click(sender As Object, e As EventArgs) Handles btLookupKodeMedia.Click
        Dim MediaTimbang As IDataLookup = New DaftarMediaTimbang(ActiveSession)
        Dim Parameter() As String = {KodeLokasi, KodeUnit}

        Dim Form As New frmLookup(MediaTimbang, Parameter)
        Form.Text = "Lookup Daftar Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeMedia.SelectedValue = Form.IDLookup
            cboKodeMedia.Focus()
        End If
    End Sub

    Private Sub FillCombo()
        If KodeLokasi <> "" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", "", KodeUnit)
            cboKodeMedia.DataSource = DS.Tables("View")
            cboKodeMedia.DisplayMember = "Nama Media"
            cboKodeMedia.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            If KodeMedia = "" Then
                cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1
            Else
                cboKodeMedia.SelectedValue = KodeMedia
            End If

        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Media")

            cboKodeMedia.DataSource = DS.Tables("View")
            cboKodeMedia.DisplayMember = "Nama Media"
            cboKodeMedia.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1
        End If
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboKodeMedia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboKodeMedia.SelectedValueChanged
        Try
            Dim Media = New DaftarMediaTimbang(ActiveSession).Find(cboKodeMedia.SelectedValue)
            If IsNothing(Media) Then
                BeratMedia = 0
                txtBeratMedia.Text = 0 & " KG"
            Else                
                BeratMedia = Media.Berat
                txtBeratMedia.Text = Media.Berat & " KG"
            End If
        Catch ex As Exception            
            BeratMedia = 0
            txtBeratMedia.Text = 0 & " KG"
        End Try

        SetEnableCommand()

    End Sub

    Private Sub chkManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        If chkManual.Checked Then
            txtTimbangManual.Enabled = True
            lblTimbangManual.Enabled = True
            lblStabil.Visible = True
            txtTimbangManual.Focus()
        Else
            txtTimbangManual.Value = 0
            txtTimbangManual.Enabled = False
            lblTimbangManual.Enabled = False
            lblStabil.Visible = False
        End If
        SetEnableCommand()
    End Sub

    Private Sub txtTimbangManual_TextChanged(sender As Object, e As EventArgs) Handles txtTimbangManual.TextChanged
        BeratBrutto = txtTimbangManual.Value
        lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
        lblBeratBrutto.Tag = BeratBrutto
        SetEnableCommand()
    End Sub


#End Region

#Region "Scale Comunication"

    Private Sub ScaleConnection()
        Try
            ScalePort.PortName = GetSetting(FormID, enumSetting.settingPort)
            ScalePort.BaudRate = GetSetting(FormID, enumSetting.settingBaudRate)
            ScalePort.Parity = Parity.None
            ScalePort.DataBits = 8
            ScalePort.Open()

            If ScalePort.IsOpen Then
                lblStatus.Text = "ONLINE"
                lblStatus.ForeColor = Color.White
                tmrScale.Enabled = True
            Else
                lblStatus.Text = "OFFLINE"
                lblStatus.ForeColor = Color.Red
                tmrScale.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Dengan Indicator Timbangan Gagal !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DataStreaming(sender As Object, e As SerialDataReceivedEventArgs) Handles ScalePort.DataReceived
        If Not chkManual.Checked Then
            Dim TempScale As String = ""
            While Microsoft.VisualBasic.InStr(TempScale, Chr(3)) = 0 And ScalePort.IsOpen
                Try
                    TempScale += Microsoft.VisualBasic.Chr(ScalePort.ReadChar)
                Catch
                End Try

            End While
            DataScale = TempScale
        End If
    End Sub

    Private Sub tmrScale_Tick(sender As Object, e As EventArgs) Handles tmrScale.Tick
        If Not chkManual.Checked Then

            Static nCounter As Byte
            Static lChange As Boolean

            Dim TempRight As String = ""
            Dim TempLeft As String = ""
            Dim Temp As String = ""
            Dim TempData As String = ""

            Dim Pos As Integer

            If DataScale IsNot Nothing Then
                Temp = DataScale.Trim
            End If

            'TextBox1.Text = Temp
            If Microsoft.VisualBasic.InStr(Temp.Trim, Chr(3)) = 0 And Len(Temp) < 11 Then
                GoTo jump
            End If

            Pos = Microsoft.VisualBasic.InStr(Temp.Trim, Chr(3))

            If Pos <> 0 Then
                Temp = Microsoft.VisualBasic.Left(Temp.Trim, Pos - 4)

                TempData = Microsoft.VisualBasic.Right(Temp, 6)
                TempRight = Microsoft.VisualBasic.Right(TempData, 1)
                TempLeft = Microsoft.VisualBasic.Left(TempData, 5)
                BeratBrutto = Convert.ToDouble(Val(TempLeft) & "." & Val(TempRight))
            Else
                BeratBrutto = 0
            End If

            If BeratBrutto <> Val(lblBeratBrutto.Tag) Then
                nCounter = 0

                lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
                lblBeratBrutto.Tag = BeratBrutto

                If lChange Then
                    lChange = False
                    lblIndicator.ForeColor = Color.Yellow
                Else
                    lChange = True
                    lblIndicator.ForeColor = Color.Green
                End If

            Else

                lblBeratBrutto.Text = BeratBrutto.ToString("###,##0.00")
                lblBeratBrutto.Tag = BeratBrutto

                If lChange Then
                    lChange = False
                    lblIndicator.ForeColor = Color.Yellow
                Else
                    lChange = True
                    lblIndicator.ForeColor = Color.Green
                End If

                nCounter += 1
                If nCounter > 25 Then
                    lblIndicator.ForeColor = Color.Black
                    lblStabil.Visible = True
                    nCounter -= 1
                Else
                    lblStabil.Visible = False
                End If
            End If

        End If


jump:
        SetEnableCommand()
    End Sub
#End Region

#Region "Process"

    Private Sub Proses(sender As Object, e As EventArgs) Handles btProcess.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btProcess"
                KodeMedia = cboKodeMedia.SelectedValue
                Result = "OK"
                Me.Close()
            Case "btClose"
                Result = ""
                Me.Close()
        End Select
    End Sub

    Private Sub SetEnableCommand()

        BeratNetto = BeratBrutto - BeratMedia
        lblBeratNetto.Text = BeratNetto.ToString("###,##0.00")
        lblBeratNetto.Tag = BeratNetto

        btProcess.Enabled = If(BeratNetto <= 0, False, True) And lblStabil.Visible And
                            If(cboKodeMedia.SelectedIndex = cboKodeMedia.Items.Count - 1, False, True)
    End Sub

#End Region

End Class