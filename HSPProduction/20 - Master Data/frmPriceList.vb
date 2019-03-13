Imports HSPProduction.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports System.Transactions

Public Class frmPriceList
    Private Const _Lebar = 0
    Private Const _Panjang = 1
    Private Const _Warna = 2
    Private Const _Printing = 3
    Private Const _Grosir = 4
    Private Const _SG1 = 5
    Private Const _SG2 = 6
    Private Const _Eceran = 7

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

    Private Sub SetKolomHeader()

        'Grid 
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Grid.BorderStyle = Windows.Forms.BorderStyle.None
        Grid.Rows = 11
        Grid.HeadersVisualStyles = True

        Grid.AddColumnHeader("Lebar", 12, 0, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caCenter, False)
        Grid.AddColumnHeader("Panjang Karung", 15, 0, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caCenter, False)
        Grid.AddColumnHeader("Warna", 10, 0, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caCenter, False)
        Grid.AddColumnHeader("Print", 10, 0, GridColumnStyle.csInput, GridColumnType.ctText, GridColumnAlignment.caCenter, False)
        Grid.AddColumnHeader("Harga" + vbCrLf + "Grosir", 12, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Harga" + vbCrLf + "SG I", 12, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Harga" + vbCrLf + "SG II", 12, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")
        Grid.AddColumnHeader("Harga" + vbCrLf + "Eceran", 12, 0, GridColumnStyle.csInput, GridColumnType.ctDecimal, GridColumnAlignment.caRight, False, Color.LightYellow, Color.Black, "##,##0.00")

        Grid.ShowHeader()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet

        'Kelompok Item Karung
        Dim DaftarSAPKelompokItem As New DaftarSAPKelompokItem()
        DS = New DataSet
        DS = DaftarSAPKelompokItem.ReadKelompok("200,201")
        cboKelompok.DataSource = DS.Tables("View")
        cboKelompok.DisplayMember = "Kelompok"
        cboKelompok.ValueMember = "Kode"

        cboKelompok.SelectedIndex = -1

        'Jenis Karung
        Dim DaftarSAPItem As New DaftarSAPItemBarang()
        DS = New DataSet
        DS = DaftarSAPItem.ReadJenisBenang()
        cboJenisKarung.DataSource = DS.Tables("View")
        cboJenisKarung.DisplayMember = "Kode"
        cboJenisKarung.ValueMember = "Kode"

        cboJenisKarung.SelectedIndex = -1

        'Denier Karung
        DS = New DataSet
        DS = DaftarSAPItem.ReadDenier()
        cboDenier.DataSource = DS.Tables("View")
        cboDenier.DisplayMember = "Kode"
        cboDenier.ValueMember = "Kode"

        cboDenier.SelectedIndex = -1

        'Brand Karung
        DS = New DataSet
        DS = DaftarSAPItem.ReadBrand()
        cboBrand.DataSource = DS.Tables("View")
        cboBrand.DisplayMember = "Kode"
        cboBrand.ValueMember = "Kode"

        cboBrand.SelectedIndex = -1

    End Sub

    Private Sub ResetData()
        _SaveMode = enumSaveMode.AddMode
        txtNoTransaksi.Enabled = True

        _NoTransaksi = "<AUTO>"
        txtNoTransaksi.Text = _NoTransaksi
        cboKelompok.SelectedIndex = -1
        cboJenisKarung.SelectedIndex = -1
        cboDenier.SelectedIndex = -1
        cboBrand.SelectedIndex = -1

        If _ID <> "" Then
            txtNoTransaksi.Text = _ID
            txtNoTransaksi_Validating(Nothing, Nothing)
            _ID = ""
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmPriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetKolomHeader()

        FillCombo()
        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                txtNoTransaksi.TextChanged,
                                txtTglTransaksi.ValueChanged,
                                cboKelompok.SelectedIndexChanged,
                                cboJenisKarung.SelectedIndexChanged,
                                cboDenier.SelectedIndexChanged,
                                cboBrand.SelectedIndexChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        'If _SaveMode = enumSaveMode.AddMode Then
        If ObjectName = "cboKelompok" Or _
                   ObjectName = "cboJenisKarung" Or _
                   ObjectName = "cboDenier" Or _
                   ObjectName = "cboBrand" Then

            Grid.Clear()
        End If
        'End If

        SetEnableCommand()

    End Sub

    Private Sub btTampilData_Click(sender As Object, e As EventArgs) Handles btTampilData.Click
        Dim TPL As New DaftarTransaksiPricelist(ActiveSession)
        Dim PL As TransaksiPricelist = TPL.Find(cboKelompok.SelectedValue, cboJenisKarung.SelectedValue, cboDenier.SelectedValue, cboBrand.SelectedValue)
        If Not IsNothing(PL) Then
            Dim DT As DataTable
            Dim Row As Integer

            DT = TPL.ReadDetail(PL.NoTransaksi).Tables("View")
            Grid.Clear()

            For Each DR As DataRow In DT.Rows
                If Row >= Grid.Rows Then
                    Grid.DataGridView.Rows.Add()
                End If

                Grid.GridValue(_Lebar, Row) = DR("Lebar")
                Grid.GridValue(_Panjang, Row) = DR("Panjang")
                Grid.GridValue(_Warna, Row) = DR("Warna")
                Grid.GridValue(_Printing, Row) = DR("Printing")
                Grid.GridValue(_Grosir, Row) = DR("Harga1")
                Grid.GridValue(_SG1, Row) = DR("Harga2")
                Grid.GridValue(_SG2, Row) = DR("Harga3")
                Grid.GridValue(_Eceran, Row) = DR("Harga4")

                Row += 1
            Next
        Else
            Dim DaftarSAPItemBarang As New DaftarSAPItemBarang()
            Dim DT As DataTable
            Dim Row As Integer

            DT = DaftarSAPItemBarang.Read(cboKelompok.SelectedValue, cboJenisKarung.SelectedValue, cboDenier.SelectedValue, cboBrand.SelectedValue).Tables("View")
            Grid.Clear()

            For Each DR As DataRow In DT.Rows
                If Row >= Grid.Rows Then
                    Grid.DataGridView.Rows.Add()
                End If

                Grid.GridValue(_Lebar, Row) = DR("Lebar")
                Grid.GridValue(_Panjang, Row) = DR("PjgKarung")
                Grid.GridValue(_Warna, Row) = DR("Warna")
                Grid.GridValue(_Printing, Row) = DR("Printing")
                Row += 1
            Next
        End If

        SetEnableCommand()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Periode As String = GetPeriod(txtTglTransaksi.Value.Date)

                Dim Scope As New TransactionScope
                Dim nRow As Integer = 0

                Try
                    Dim SAPItemBarang As New DaftarSAPItemBarang()
                    Dim DaftarTransaksiPricelist As New DaftarTransaksiPricelist(ActiveSession)
                    Dim TransaksiPricelist As TransaksiPricelist
                    Dim DaftarPricelist As New DaftarPriceList(ActiveSession)
                    Dim Pricelist As PriceList
                    Dim CekPricelist As Boolean

                    If _SaveMode = enumSaveMode.AddMode Then
                        txtNoTransaksi.Text = DaftarTransaksiPricelist.GetNomorTransaksi(Periode)
                    End If

                    TransaksiPricelist = DaftarTransaksiPricelist.Find(txtNoTransaksi.Text)
                    If Not IsNothing(TransaksiPricelist) Then
                        DaftarTransaksiPricelist.Delete(txtNoTransaksi.Text)
                    End If

                    For nRow = 0 To Grid.GridLastRow - 1
                        If Grid.GridValue(_Lebar, nRow) <> "" Then

                            'Ambil Data Item Barang dari SAP
                            Dim DT As DataTable = SAPItemBarang.ReadItem(cboKelompok.SelectedValue, _
                                                                         cboJenisKarung.SelectedValue, _
                                                                         cboDenier.SelectedValue, _
                                                                         cboBrand.SelectedValue, _
                                                                         Grid.GridValue(_Lebar, nRow), _
                                                                         Grid.GridValue(_Panjang, nRow), _
                                                                         Grid.GridValue(_Warna, nRow), _
                                                                         Grid.GridValue(_Printing, nRow)).Tables("View")
                            Dim DR As DataRow
                            Dim Row As Integer = 0

                            For Each DR In DT.Rows
                                'Transaksi
                                TransaksiPricelist = New TransaksiPricelist
                                TransaksiPricelist.NoTransaksi = txtNoTransaksi.Text
                                TransaksiPricelist.TglTransaksi = txtTglTransaksi.Value
                                TransaksiPricelist.KodeItem = DR("KodeItem")
                                TransaksiPricelist.NamaItem = DR("NamaItem")
                                TransaksiPricelist.Harga1 = Grid.GridValue(_Grosir, nRow)
                                TransaksiPricelist.Harga2 = Grid.GridValue(_SG1, nRow)
                                TransaksiPricelist.Harga3 = Grid.GridValue(_SG2, nRow)
                                TransaksiPricelist.Harga4 = Grid.GridValue(_Eceran, nRow)
                                TransaksiPricelist.Kelompok = cboKelompok.SelectedValue
                                TransaksiPricelist.Jenis = cboJenisKarung.SelectedValue
                                TransaksiPricelist.Denier = cboDenier.SelectedValue
                                TransaksiPricelist.Merek = cboBrand.SelectedValue
                                TransaksiPricelist.Lebar = Grid.GridValue(_Lebar, nRow)
                                TransaksiPricelist.Panjang = Grid.GridValue(_Panjang, nRow)
                                TransaksiPricelist.Warna = Grid.GridValue(_Warna, nRow)
                                TransaksiPricelist.Printing = Grid.GridValue(_Printing, nRow)

                                DaftarTransaksiPricelist.Add(TransaksiPricelist)

                                'Tabel Pricelist
                                Pricelist = DaftarPricelist.Find(DR("KodeItem"))
                                If Not IsNothing(Pricelist) Then
                                    CekPricelist = True
                                Else
                                    CekPricelist = False
                                End If

                                Pricelist = New PriceList
                                Pricelist.KodeItem = DR("KodeItem")
                                Pricelist.NamaItem = DR("NamaItem")
                                Pricelist.Harga1 = Grid.GridValue(_Grosir, nRow)
                                Pricelist.Harga2 = Grid.GridValue(_SG1, nRow)
                                Pricelist.Harga3 = Grid.GridValue(_SG2, nRow)
                                Pricelist.Harga4 = Grid.GridValue(_Eceran, nRow)

                                If CekPricelist = False Then
                                    DaftarPricelist.Add(Pricelist)
                                Else
                                    DaftarPricelist.Edit(Pricelist)
                                End If
                            Next
                        End If
                    Next

                    If _SaveMode = enumSaveMode.AddMode Then
                        IDData = txtNoTransaksi.Text
                        ResetData()
                        txtNoTransaksi.Focus()
                    Else
                        IDData = txtNoTransaksi.Text
                        Me.Close()
                    End If

                    Me.Cursor = Cursors.Default
                    '---------------------------------------------------------------------------------------------------------

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
            Case "btClose"
                '---------------------------------------------------------------------------------------------------------
                Me.Close()
                '---------------------------------------------------------------------------------------------------------
        End Select

Jump:
        txtNoTransaksi.Focus()
    End Sub

    Private Sub SetEnableCommand()
        JumlahBarisData()

        btTampilData.Enabled = If(cboKelompok.SelectedIndex = -1, False, True) And _
                               If(cboJenisKarung.SelectedIndex = -1, False, True) And _
                               If(cboDenier.SelectedIndex = -1, False, True) And _
                               If(cboBrand.SelectedIndex = -1, False, True)

        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                               If(cboKelompok.SelectedIndex = -1, False, True) And _
                               If(cboJenisKarung.SelectedIndex = -1, False, True) And _
                               If(cboDenier.SelectedIndex = -1, False, True) And _
                               If(cboBrand.SelectedIndex = -1, False, True) And _
                               If(JumlahBarisData() = 0, False, True)
    End Sub

    Private Function JumlahBarisData() As Integer

        Dim Row As Integer
        Dim Jumlah As Integer = 0
        For Row = 0 To Grid.GridLastRow - 1

            If Grid.GridValue(_Lebar, Row) <> "" Then
                Jumlah += 1
            End If
        Next
        JumlahBarisData = Jumlah

    End Function

    Private Sub Grid_GridChange() Handles Grid.GridChange
        SetEnableCommand()
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        _SaveMode = enumSaveMode.AddMode

        If txtNoTransaksi.Text <> "" Then
            Dim DaftarTransaksiPricelist As New DaftarTransaksiPricelist(ActiveSession)
            Dim TransaksiPricelist As TransaksiPricelist = DaftarTransaksiPricelist.Find(txtNoTransaksi.Text)
            If Not IsNothing(TransaksiPricelist) Then
                _SaveMode = enumSaveMode.EditMode

                txtTglTransaksi.Value = TransaksiPricelist.TglTransaksi
                cboKelompok.SelectedValue = TransaksiPricelist.Kelompok
                cboJenisKarung.SelectedValue = TransaksiPricelist.Jenis
                cboDenier.SelectedValue = TransaksiPricelist.Denier
                cboBrand.SelectedValue = TransaksiPricelist.Merek

                If _SaveMode = enumSaveMode.EditMode Then
                    Dim DT As DataTable = DaftarTransaksiPricelist.ReadDetail(txtNoTransaksi.Text).Tables("View")
                    Dim DR As DataRow
                    Dim Row As Integer = 0

                    Grid.Clear()
                    For Each DR In DT.Rows
                        If Row >= Grid.Rows Then
                            Grid.DataGridView.Rows.Add()
                        End If

                        Grid.GridValue(_Lebar, Row) = DR("Lebar")
                        Grid.GridValue(_Panjang, Row) = DR("Panjang")
                        Grid.GridValue(_Warna, Row) = DR("Warna")
                        Grid.GridValue(_Printing, Row) = DR("Printing")
                        Grid.GridValue(_Grosir, Row) = DR("Harga1")
                        Grid.GridValue(_SG1, Row) = DR("Harga2")
                        Grid.GridValue(_SG2, Row) = DR("Harga3")
                        Grid.GridValue(_Eceran, Row) = DR("Harga4")

                        Row += 1
                    Next
                End If
            Else
                        If _NoTransaksi <> txtNoTransaksi.Text Then
                            MessageBox.Show("Nomor Transaksi Tidak Dikenal ! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            ResetData()
                            txtNoTransaksi.Focus()
                        End If
            End If
        End If
    End Sub
End Class