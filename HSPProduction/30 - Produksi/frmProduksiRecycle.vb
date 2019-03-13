Imports HSPProduction.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions
Imports Microsoft.Win32

Public Class frmProduksiRecycle

#Region "Header Section"
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
    Private _NoTransaksi As String
    Private _TRX As String = ""

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

    'Konstanta Column Header
    '-------------------------------------------------------------------------------------------------
    Private Const _KodeItem = 0
    Private Const _NamaItem = 1
    Private Const _Qty = 2
    Private Const _Satuan = 3
    Private Const _Keterangan = 4

    Private Sub FillCombo()
        'Lokasi Produksi
        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarLokasi.Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"
        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1

        'Grup Produksi
        Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)
        DS = New DataSet
        DS = DaftarGrupProduksi.Read("%")
        cboKodeGrup.DataSource = DS.Tables("View")
        cboKodeGrup.DisplayMember = "Grup Produksi"
        cboKodeGrup.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Grup Produksi") = "-"
        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode

        txtTglTransaksi.Text = ""
        txtKeterangan.Text = ""
        txtTotal.Text = ""

        Grid.Clear()

        cboKodeLokasi.SelectedValue = GetSetting(enumFormID.frmRecycle, enumSetting.settingKodeLokasi)

        TotalTransaksi()

        SetEnableCommand()
    End Sub

    Private Sub SetKolomHeader()
        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 7
        Grid.HeadersVisualStyles = True
        Grid.AlternatingDataGridBackColor = Color.White

        Grid.AddColumnHeader("Kode Item", 15, 15, GridColumnStyle.csInputWithLookup, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Nama Item", 40, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        Grid.AddColumnHeader("Qty", 10, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightCyan, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Satuan", 10, 0, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, False)
        Grid.AddColumnHeader("Keterangan", 26, 50, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caLeft, False)

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub frmProduksiRecycle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()

        FillCombo()
        ResetData()
    End Sub

    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = Now.ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                txtKodeShift.Text = "3"
            Else
                txtKodeShift.Text = "1"
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                txtKodeShift.Text = "1"
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                txtKodeShift.Text = "2"
            Else
                txtKodeShift.Text = "3"
            End If
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String = GetPeriod(txtTglTransaksi.Value.Date)

        sender.Focus()
        DirectCast(sender, Button).Enabled = False

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                '-------------------------------------------------------------------------------------------------------
                Dim Scope As New TransactionScope

                Try
                    Dim DaftarPR As New DaftarProduksiRecycle(ActiveSession)
                    Dim HeaderPR As New HeaderProduksiRecycle
                    Dim DetailPR As New DetailProduksiRecycle
                    Dim SAPStaging As New SAPStaging

                    'Simpan Detail Produksi Recycle
                    '--------------------------------------------------------------------------------------------------
                    Dim NoUrut As Integer
                    For Row = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_KodeItem, Row) <> "" Then

                            'Nomor Transaksi
                            If _SaveMode = enumSaveMode.AddMode Then
                                _NoTransaksi = DaftarPR.GetNomorTransaksi(Periode)
                            End If

                            'Simpan Header Produksi Recycle
                            '--------------------------------------------------------------------------------------------------
                            HeaderPR.NoTransaksi = _NoTransaksi
                            HeaderPR.TglTransaksi = txtTglTransaksi.Value.Date
                            HeaderPR.KodeShift = txtKodeShift.Text
                            HeaderPR.KodeGrup = cboKodeGrup.SelectedValue
                            HeaderPR.KodeLokasi = cboKodeLokasi.SelectedValue
                            HeaderPR.Keterangan = txtKeterangan.Text
                            HeaderPR.UserID = ActiveSession.KodeUser

                            DaftarPR.AddHeader(HeaderPR)

                            'Simpan Transaksi Internal
                            '------------------------------------------------------------------------------------------
                            NoUrut += 1

                            DetailPR.NoTransaksi = _NoTransaksi
                            DetailPR.NoUrut = NoUrut
                            DetailPR.KodeItem = Grid.GridValue(_KodeItem, Row)
                            DetailPR.NamaItem = Grid.GridValue(_NamaItem, Row)
                            DetailPR.Qty = Grid.GridValue(_Qty, Row)
                            DetailPR.Satuan = Grid.GridValue(_Satuan, Row)
                            DetailPR.Keterangan = "-"

                            DaftarPR.AddDetail(DetailPR)

                            'Post Staging
                            '------------------------------------------------------------------------------------------------
                            SAPStaging.DirectProcess(txtTglTransaksi.Value.Date, Grid.GridValue(_KodeItem, Row), Grid.GridValue(_NamaItem, Row), cboKodeLokasi.SelectedValue, Grid.GridValue(_Qty, Row), _NoTransaksi)

                            'Execute Recycle
                            '------------------------------------------------------------------------------------------------
                            SAPStaging.Execute(_NoTransaksi, HSPProduction.SAPStaging.enumTransaction.DirectProcess)

                        End If
                    Next

                    Me.Cursor = Cursors.Default

                    Scope.Complete()
                    Scope.Dispose()
                    '-------------------------------------------------------------------------------------------------

                    ResetData()

                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Scope.Dispose()
                    MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    GoTo Jump
                End Try

            Case "btClose"
                Me.Close()

        End Select

Jump:
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            txtTglTransaksi.ValueChanged,
                            cboKodeGrup.SelectedIndexChanged,
                            cboKodeLokasi.SelectedIndexChanged,
                            txtKeterangan.TextChanged

        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1, False, True) And _
                         If(JumlahBarisData() = 0, False, True)

        lblBarisData.Text = JumlahBarisData() & " Baris Data"
    End Sub
#End Region

#Region "Detail Section"
    'Hitung Baris Data
    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        For Row = 0 To Grid.GridLastRow - 1

            If Grid.GridValue(_KodeItem, Row) <> "" Then
                Jumlah += 1
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub TotalTransaksi()
        Dim Total As Double = 0
        For Row = 0 To Grid.GridLastRow() - 1
            Total += Grid.GridValue(_Qty, Row)
        Next

        txtTotal.Value = Total.ToString("##,##0.00")
    End Sub

    Private Sub Grid_GridCellChange(Col As Integer, Row As Integer, NewData As String, OldData As String) Handles Grid.GridCellChange
        btSave.Enabled = False
        If Col = _Qty Then
            Grid.GridValue(Col, Row) = NewData
        End If

        TotalTransaksi()

        SetEnableCommand()
    End Sub

    Private Sub Grid_GridCellLookup(Col As Integer, Row As Integer) Handles Grid.GridCellLookup
        If Col = _KodeItem Then
            Dim DaftarItem As IDataLookup = New SAPInventory
            Dim Parameter() As String = {"196"}

            Dim Form As New frmLookup(DaftarItem, Parameter)
            Form.Text = "Lookup Daftar Item Produksi"
            Form.ShowDialog()
            If Form.IDLookup <> "" Then
                Grid.SetGridCellLookupResult(Col, Row, Form.IDLookup)
                Grid.Focus()
                SendKeys.Send("{ENTER}")
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub Grid_GridCellPostValidation(Col As Integer, Row As Integer, NewData As String, OldData As String, Valid As Boolean, LastKey As Keys) Handles Grid.GridCellPostValidation
        If Col = _KodeItem And Valid Then
            Dim DaftarItemSAP As New SAPInventory()
            Dim ItemSAP As ItemSAP = DaftarItemSAP.FindItem("196", NewData)
            If Not IsNothing(ItemSAP) Then
                Grid.GridValue(_KodeItem, Row) = ItemSAP.KodeItem
                Grid.GridValue(_NamaItem, Row) = ItemSAP.NamaItem
                Grid.GridValue(_Satuan, Row) = ItemSAP.Satuan

                If Not DaftarItemSAP.GetValidBOM(Grid.GridValue(_KodeItem, Row)) Then
                    MessageBox.Show("Bill Of Material (BOM) Item Ini Belum Dibuat..." & vbCrLf & "Hubungi PPIC...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Grid.GridResetRow(Row)
                    GoTo Jump
                End If

                SendKeys.Send("{RIGHT}")
            Else
                MessageBox.Show("Kode Item Tidak valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Grid.GridResetRow(Row)
                GoTo Jump
            End If
        End If

Jump:
        SetEnableCommand()
    End Sub

    Private Sub Grid_GridChange() Handles Grid.GridChange
        TotalTransaksi()
        SetEnableCommand()
    End Sub
#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class