Imports System.IO
Imports Dapper
Imports HSPHRDCONSOLE.HSP.Data
Public Class FrmBroadcastAdd
    Private _DBConnection As New DBConnection
    Private Filename As String
    Private _ext As String
    Public iData As String = ""
    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Filter = "Image Files (*.png *.jpg *.bmp *jpeg) |*.png; *.jpg; *.bmp; *.jpeg|Document Files (*.PDF)|*.PDF"
        End With
        Dim result As DialogResult = dlg.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            ' Do something.
            Filename = Path.GetFileName(dlg.FileName)
            txtpath.Text = dlg.FileName
            _ext = Path.GetExtension(Filename)
        End If
    End Sub
    Private Sub Copy()
        Dim p As New Process
        Try
            If (txtpath.Text <> "") Then
                p.StartInfo.FileName = "cmd.exe"
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardInput = True
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardError = True
                p.StartInfo.CreateNoWindow = True
                p.Start()
                p.StandardInput.WriteLine("net use \\192.168.1.112 password:H4rd05050/user:administrator" + vbCrLf +
                                          "copy " + txtpath.Text + " \\192.168.1.112\c$\Windows\SysWOW64")
                p.StandardInput.WriteLine("exit")
                p.Close()
                Threading.Thread.Sleep(4000)
                Dim strPathFrom, strPathTo, strGet As String
                strPathFrom = txtpath.Text
                strPathTo = "\\192.168.1.112\c$\Windows\SysWOW64"
                strGet = txtpath.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        Dim Core As New BroadcastCore(ActiveSession)
        Try
            Copy()
            Core.Broadcast_Start(txtsubject.Text, Filename, txtbody.Text, _ext)
            txtsubject.Text = ""
            txtbody.Text = ""
            txtpath.Text = ""
            iData = "Success"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class