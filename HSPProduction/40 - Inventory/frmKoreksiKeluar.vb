Imports HSPProduction.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions

Public Class frmKoreksiKeluar
    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    Private _ID As String
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    Private Const _Satuan = 0
    Private Const _QtyAwal = 1
    Private Const _QtyKoreksi = 2
    Private Const _QtyAkhir = 3

    Private Sub SetKolomHeader()

        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 3
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White
        Grid.DataGridView.AllowUserToDeleteRows = False

        Grid.AddColumnHeader("SATUAN", 25, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, False)
        Grid.AddColumnHeader("STOCK AWAL", 25, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, "##,##0.00")
        Grid.AddColumnHeader("ADJUSTMENT", 25, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("STOCK AKHIR", 25, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, "##,##0.00")

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub FillCombo()
        Dim DaftarKelompokKoreksi As New DaftarKelompokKoreksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarKelompokKoreksi.Read("%")
        cboKelompokKoreksi.DataSource = DS.Tables("View")
        cboKelompokKoreksi.DisplayMember = "Nama Kelompok"
        cboKelompokKoreksi.ValueMember = "Kode"

    End Sub

    Private Sub FillComboLokasi()
        Dim DaftarKelompokKoreksi As New DaftarKelompokKoreksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarKelompokKoreksi.ReadLokasi(cboKelompokKoreksi.SelectedValue.ToString)
        cboLokasiStock.DataSource = DS.Tables("View")
        cboLokasiStock.DisplayMember = "NamaLokasi"
        cboLokasiStock.ValueMember = "KodeLokasi"

        cboLokasiStock.SelectedIndex = -1
    End Sub

    Private Sub FillComboJenis()
        Dim DaftarJenisKoreksi As New DaftarJenisKoreksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarJenisKoreksi.Read(cboKelompokKoreksi.SelectedValue.ToString)
        cboJenisKoreksi.DataSource = DS.Tables("View")
        cboJenisKoreksi.DisplayMember = "Keterangan"
        cboJenisKoreksi.ValueMember = "Kode"

        cboJenisKoreksi.SelectedIndex = -1
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        txtNoTransaksi.Enabled = True
        _NoTransaksi = "<AUTO>"

        txtNoTransaksi.Text = _NoTransaksi
        cboKelompokKoreksi.SelectedIndex = -1
        cboLokasiStock.SelectedIndex = -1
        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        cboJenisKoreksi.SelectedIndex = -1
        txtKeterangan.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub frmKoreksiKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()

        FillCombo()
        FillComboLokasi()
        FillComboJenis()
        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                               txtNoTransaksi.TextChanged,
                                                               txtTglTransaksi.ValueChanged,
                                                               cboKelompokKoreksi.SelectedIndexChanged,
                                                               cboLokasiStock.SelectedIndexChanged,
                                                               cboJenisKoreksi.SelectedIndexChanged,
                                                               txtKeterangan.TextChanged,
                                                               txtKodeProduksi.TextChanged,
                                                               txtKodeItem.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKelompokKoreksi" Then
            If cboKelompokKoreksi.SelectedIndex <> -1 Then
                Try
                    FillComboLokasi()
                    FillComboJenis()

                    Dim DaftarKelompokKoreksi As New DaftarKelompokKoreksi(ActiveSession)
                    Dim Batch As Boolean = If(DaftarKelompokKoreksi.Find(cboKelompokKoreksi.SelectedValue).KodeProduksi = 1, True, False)
                    If Batch = True Then
                        txtKodeProduksi.Text = ""
                        txtKodeItem.Text = ""
                        txtNamaItem.Text = ""
                        txtKodeProduksi.Enabled = True
                        txtKodeItem.ReadOnly = True
                    Else
                        txtKodeProduksi.Text = ""
                        txtKodeItem.Text = ""
                        txtNamaItem.Text = ""
                        txtKodeProduksi.Enabled = False
                        txtKodeItem.ReadOnly = False
                    End If
                Catch
                End Try

            End If

        End If

        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        JumlahKoreksi()

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(cboKelompokKoreksi.SelectedIndex = -1, False, True) And _
                         If(cboLokasiStock.SelectedIndex = -1, False, True) And _
                         If(cboJenisKoreksi.SelectedIndex = -1, False, True) And _
                         If(JumlahKoreksi() = 0, False, True)

    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DT As DataTable = New Inventory(ActiveSession).ReadData(txtKodeProduksi.Text, _
                                                                        "", _
                                                                        enumKoreksi.enumRoll, _
                                                                        cboLokasiStock.SelectedValue).Tables("View")

            If DT.Rows.Count <> 0 Then
                Dim DR As DataRow
                Dim Row As Integer

                Grid.Clear()
                For Each DR In DT.Rows
                    If Row >= Grid.Rows Then
                        Grid.DataGridView.Rows.Add()
                    End If

                    txtKodeItem.Text = DR("KodeItem")
                    txtNamaItem.Text = DR("NamaItem")

                    Grid.GridValue(_Satuan, Row) = DR("Satuan")
                    Grid.GridValue(_QtyAwal, Row) = DR("Stock")
                    Grid.GridValue(_QtyAkhir, Row) = Grid.GridValue(_QtyAwal, Row) - Grid.GridValue(_QtyKoreksi, Row)

                    Row += 1
                Next

                txtKodeItem.Tag = New SAPInventory().FindItem(txtKodeItem.Text).Satuan
            Else
                MessageBox.Show("Kode Produksi Tidak Valid...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodeProduksi.Text = ""
                txtKodeProduksi.Focus()
            End If

        End If

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    Dim QtyAdjustment As Double = 0
                    Dim Row As Integer = 0

                    For Row = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_Satuan, Row) = txtKodeItem.Tag Then
                            QtyAdjustment = Grid.GridValue(_QtyKoreksi, Row)
                        End If
                    Next

                    MsgBox(QtyAdjustment)

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try

                Me.Cursor = Cursors.Default
                '---------------------------------------------------------------------------------------------------------
            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

Jump:
        txtNoTransaksi.Focus()
    End Sub

    Private Function JumlahKoreksi() As Integer

        Dim Row As Integer
        Dim Jumlah As Double = 0
        For Row = 0 To Grid.GridLastRow - 1
            Jumlah += Grid.GridValue(_QtyKoreksi, Row)
        Next

        JumlahKoreksi = Jumlah

    End Function

    Private Sub TotalBarisTransaksi(Col As Integer, Row As Integer, NewData As String)
        If Col = _QtyKoreksi Then
            Grid.GridValue(_QtyAkhir, Row) = Grid.GridValue(_QtyAwal, Row) - Val(NewData)
        End If

        SetEnableCommand()
    End Sub

    Private Sub Grid_GridCellChange(Col As Integer, Row As Integer, NewData As String, OldData As String) Handles Grid.GridCellChange
        TotalBarisTransaksi(Col, Row, NewData)
        If Col = _QtyKoreksi Then
            If Grid.GridValue(_QtyAkhir, Row) < 0 Then
                MessageBox.Show("Quantity Adjustment Melebihi Stock...!", "Peringatan", MessageBoxButtons.OK)
                Grid.GridValue(_QtyKoreksi, Row) = ""
            End If
        End If
    End Sub

    Private Sub Grid_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles Grid.GridCellPostValidation
        SetEnableCommand()
    End Sub

    Private Sub Grid_GridCellPreValidation(Col As Integer, Row As Integer, ByRef Cancel As Boolean) Handles Grid.GridCellPreValidation
        'If Col = _QtyKoreksi Then
        '    If Grid.GridValue(_Satuan, Row) <> txtKodeItem.Tag Then
        '        Cancel = True
        '    End If
        'End If

        SetEnableCommand()
    End Sub

    Private Sub Grid_GridChange() Handles Grid.GridChange
        SetEnableCommand()
    End Sub
End Class