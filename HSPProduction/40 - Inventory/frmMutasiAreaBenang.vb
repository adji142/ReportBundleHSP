Imports Microsoft.Win32
Imports HSPProduction.HSP.Data
Imports System.Transactions

Public Class frmMutasiAreaBenang
    'Enumerasi
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum

    'Data Private
    Private _SaveMode As enumSaveMode
    Private _NoTransaksi As String

    Private Data As String
    Private DataSet As DataSet
    Private DataTable As DataTable

    Private Sub ResetData()
        txtNoTransaksi.Text = ""
        txtTglTransaksi.Text = ""

        _NoTransaksi = "<AUTO>"

        txtNoTransaksi.Text = _NoTransaksi
        cboKodeAreaAsal.SelectedIndex = cboKodeAreaAsal.Items.Count - 1
        cboKodeAreaTujuan.SelectedIndex = cboKodeAreaTujuan.Items.Count - 1

        'ViewAsal.Columns.Clear()
        'ViewTujuan.Columns.Clear()

        'Default Lokasi Produksi
        '-------------------------------------------------------------------------------------------------------------------
        cboKodeLokasi.SelectedValue = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
        cboKodeLokasi.Enabled = False

    End Sub

    Private Sub FillComboLokasi()
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = New DaftarLokasi(ActiveSession).Read("%")
        cboKodeLokasi.DataSource = DS.Tables("View")
        cboKodeLokasi.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1
    End Sub

    Private Sub FillComboArea()
        If cboKodeLokasi.SelectedIndex <> cboKodeLokasi.Items.Count - 1 Then
            'Area Produksi
            Dim DaftarArea As New DaftarArea(ActiveSession)
            Dim DS As DataSet
            Dim Drow As DataRow

            'Kode Area Asal
            DS = New DataSet
            DS = DaftarArea.Read("%", cboKodeLokasi.SelectedValue.ToString)
            cboKodeAreaAsal.DataSource = DS.Tables("View")
            cboKodeAreaAsal.DisplayMember = "Nama Area"
            cboKodeAreaAsal.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Area") = "-"

            cboKodeAreaAsal.SelectedIndex = cboKodeAreaAsal.Items.Count - 1

            'Kode Area Tujuan
            DS = New DataSet
            DS = DaftarArea.Read("%", cboKodeLokasi.SelectedValue.ToString)
            cboKodeAreaTujuan.DataSource = DS.Tables("View")
            cboKodeAreaTujuan.DisplayMember = "Nama Area"
            cboKodeAreaTujuan.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Area") = "-"

            cboKodeAreaTujuan.SelectedIndex = cboKodeAreaTujuan.Items.Count - 1
        Else
            Dim DS As DataSet
            Dim Drow As DataRow

            DS = New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Area")

            cboKodeAreaAsal.DataSource = DS.Tables("View")
            cboKodeAreaAsal.DisplayMember = "Nama Area"
            cboKodeAreaAsal.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Area") = "-"

            DS = New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Area")

            cboKodeAreaTujuan.DataSource = DS.Tables("View")
            cboKodeAreaTujuan.DisplayMember = "Nama Area"
            cboKodeAreaTujuan.ValueMember = "Kode"

            Drow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Area") = "-"
        End If

    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                                                                txtTglTransaksi.ValueChanged,
                                                                cboKodeLokasi.SelectedIndexChanged,
                                                                cboKodeAreaAsal.SelectedIndexChanged,
                                                                cboKodeAreaTujuan.SelectedIndexChanged
        Dim ObjectName As String = sender.Name.ToString()

        If ObjectName = "cboKodeLokasi" Then
            If cboKodeLokasi.SelectedIndex <> cboKodeLokasi.Items.Count - 1 Then
                FillComboArea()
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub frmMutasiArea_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Refresh()
        ViewAsal.SettingID = Me.Name
        ViewTujuan.SettingID = Me.Name

        SetHeaderView(ViewAsal)
        SetHeaderView(ViewTujuan)

        ViewAsal.SetColumnOrder()
        ViewTujuan.SetColumnOrder()

        SetEnableCommand()
    End Sub

    Private Sub frmMutasiArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboLokasi()
        FillComboArea()
        ResetData()

        If ViewTujuan.Columns.Count = 0 Then
            'Copy Kolom dari View1 ke Vew2
            For Each column As DataGridViewColumn In ViewAsal.Columns
                ViewTujuan.Columns.Add(CType(column.Clone(), DataGridViewColumn))
            Next
        End If
    End Sub

    Private Sub btLookupKodeArea_Click(sender As Object, e As EventArgs) Handles btLookupKodeAreaAsal.Click
        Dim DaftarArea As IDataLookup = New DaftarArea(ActiveSession)

        Dim Parameter() As String = {cboKodeLokasi.SelectedValue}

        Dim Form As New frmLookup(DaftarArea, Parameter)
        Form.Text = "Lookup Daftar Area Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeAreaAsal.SelectedValue = Form.IDLookup
            cboKodeAreaAsal.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btLookupKodeArea2_Click(sender As Object, e As EventArgs) Handles btLookupKodeAreaTujuan.Click
        Dim DaftarArea As IDataLookup = New DaftarArea(ActiveSession)

        Dim Parameter() As String = {cboKodeLokasi.SelectedValue}

        Dim Form As New frmLookup(DaftarArea, Parameter)
        Form.Text = "Lookup Daftar Area Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeAreaTujuan.SelectedValue = Form.IDLookup
            cboKodeAreaTujuan.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btAddAll_Click(sender As Object, e As EventArgs) Handles btAddAll.Click
        If ViewAsal.Rows.Count <> 0 Then
            Dim DataTujuan = New List(Of DataGridViewRow)
            For Each DataAsal As DataGridViewRow In ViewAsal.Rows
                Dim DataTarget = CType(DataAsal.Clone(), DataGridViewRow)
                For Each cell As DataGridViewCell In DataAsal.Cells
                    DataTarget.Cells(cell.ColumnIndex).Value = cell.Value
                Next
                DataTujuan.Add(DataTarget)
            Next

            ViewTujuan.Rows.AddRange(DataTujuan.ToArray())

            ViewAsal.SelectAll()
            For Each row As DataGridViewRow In ViewAsal.SelectedRows
                ViewAsal.Rows.Remove(row)
            Next
        End If
        SetEnableCommand()
    End Sub

    Private Sub btAddOne_Click(sender As Object, e As EventArgs) Handles btAddOne.Click
        Dim DataTujuan = New List(Of DataGridViewRow)
        For Each DataAsal As DataGridViewRow In ViewAsal.SelectedRows
            Dim DataTarget = CType(DataAsal.Clone(), DataGridViewRow)
            For Each cell As DataGridViewCell In DataAsal.Cells
                DataTarget.Cells(cell.ColumnIndex).Value = cell.Value
            Next
            DataTujuan.Add(DataTarget)
        Next

        ViewTujuan.Rows.AddRange(DataTujuan.ToArray())

        For Each row As DataGridViewRow In ViewAsal.SelectedRows
            ViewAsal.Rows.Remove(row)
        Next

        SetEnableCommand()
    End Sub

    Private Sub btRemoveOne_Click(sender As Object, e As EventArgs) Handles btRemoveOne.Click
        'DataTable = New DataTable
        For Row As Integer = 0 To ViewTujuan.SelectedRows.Count - 1
            ViewAsal.Rows.Add(ViewTujuan.SelectedRows(Row).Cells(0).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(1).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(2).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(3).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(4).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(5).Value)
        Next

        For Each row As DataGridViewRow In ViewTujuan.SelectedRows
            ViewTujuan.Rows.Remove(row)
        Next

        SetEnableCommand()
    End Sub

    Private Sub btRemoveAll_Click(sender As Object, e As EventArgs) Handles btRemoveAll.Click
        ViewTujuan.SelectAll()

        For Row As Integer = 0 To ViewTujuan.SelectedRows.Count - 1
            ViewAsal.Rows.Add(ViewTujuan.SelectedRows(Row).Cells(0).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(1).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(2).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(3).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(4).Value, _
                               ViewTujuan.SelectedRows(Row).Cells(5).Value)
        Next

        For Each row As DataGridViewRow In ViewTujuan.SelectedRows
            ViewTujuan.Rows.Remove(row)
        Next

        SetEnableCommand()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    Dim DaftarMutasiAreaBenang As New DaftarMutasiAreaBenang(ActiveSession)
                    Dim HeaderMutasiAreaBenang As HeaderMutasiAreaBenang
                    Dim DetailMutasiAreaBenang As DetailMutasiAreaBenang

                    Periode = GetPeriod(txtTglTransaksi.Value)

                    txtNoTransaksi.Text = DaftarMutasiAreaBenang.GetNomorTransaksi("EXAB", Periode)

                    'Simpan Header Mutasi Area Benang
                    HeaderMutasiAreaBenang = New HeaderMutasiAreaBenang
                    HeaderMutasiAreaBenang.NoTransaksi = txtNoTransaksi.Text
                    HeaderMutasiAreaBenang.TglTransaksi = txtTglTransaksi.Value.Date
                    HeaderMutasiAreaBenang.KodeLokasi = cboKodeLokasi.SelectedValue
                    HeaderMutasiAreaBenang.KodeAreaAsal = cboKodeAreaAsal.SelectedValue
                    HeaderMutasiAreaBenang.KodeAreaTujuan = cboKodeAreaTujuan.SelectedValue
                    HeaderMutasiAreaBenang.Keterangan = txtKeterangan.Text
                    HeaderMutasiAreaBenang.UserID = ActiveSession.KodeUser

                    DaftarMutasiAreaBenang.AddHeader(HeaderMutasiAreaBenang)

                    Dim NoUrut As Integer

                    For i = 0 To ViewTujuan.RowCount - 1
                        If ViewTujuan.Rows(i).Cells("Kode").Value <> "" Then
                            NoUrut += 1

                            DetailMutasiAreaBenang = New DetailMutasiAreaBenang
                            DetailMutasiAreaBenang.NoTransaksi = txtNoTransaksi.Text
                            DetailMutasiAreaBenang.NoUrut = NoUrut
                            DetailMutasiAreaBenang.KodeProduksi = ViewTujuan.Rows(i).Cells("Kode").Value
                            DetailMutasiAreaBenang.KodeItem = ViewTujuan.Rows(i).Cells("KodeItem").Value
                            DetailMutasiAreaBenang.NamaItem = ViewTujuan.Rows(i).Cells("NamaItem").Value
                            DetailMutasiAreaBenang.QtyUnit = New DaftarStockBenang(ActiveSession).Find(ViewTujuan.Rows(i).Cells("Kode").Value).Jumlah2
                            DetailMutasiAreaBenang.QtyTimbang = New DaftarStockBenang(ActiveSession).Find(ViewTujuan.Rows(i).Cells("Kode").Value).BeratNetto
                            DetailMutasiAreaBenang.KodeLokasiAsal = ViewTujuan.Rows(i).Cells("Area").Value
                            DetailMutasiAreaBenang.KodeLokasiTujuan = cboKodeAreaTujuan.SelectedValue

                            DaftarMutasiAreaBenang.AddDetail(DetailMutasiAreaBenang)
                        End If
                    Next

                    Scope.Complete()
                    Scope.Dispose()

                    Me.Cursor = Cursors.Default

                    ResetData()
                    '---------------------------------------------------------------------------------------------------------
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
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtTglTransaksi.Text = "", False, True) And _
                         If(cboKodeAreaTujuan.SelectedIndex = cboKodeAreaTujuan.Items.Count - 1, False, True) And _
                         If(ViewTujuan.Rows.Count = 0, False, True)

        'Tampilkan Jumlah Baris
        ItemAsal.Text = "Total : " + ViewAsal.RowCount.ToString + " Baris"
        JumlahBaris2.Text = "Total : " + ViewTujuan.RowCount.ToString + " Baris"
    End Sub

    Private Sub btShow_Click(sender As Object, e As EventArgs) Handles btShow.Click
        Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
        DataTable = DaftarStockBenang.ReadMutasi(cboKodeAreaAsal.SelectedValue).Tables("View")
        Dim DR As DataRow
        Dim Row As Integer = 0

        ViewAsal.Rows.Clear()
        For Each DR In DataTable.Rows
            ViewAsal.Rows.Add(DR("Kode"), _
                              DR("Kode Item"), _
                              DR("Nama Item"), _
                              DR("Area"), _
                              DR("Jumlah"), _
                              DR("Berat"))
        Next

        SetEnableCommand()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ViewAsal.DataSource = Nothing
            cboKodeAreaAsal.SelectedIndex = cboKodeAreaAsal.Items.Count - 1

            If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() + "\DOWNLOAD.TXT") Then
                System.IO.File.Delete(System.AppDomain.CurrentDomain.BaseDirectory() + "\DOWNLOAD.TXT")
            End If

            Dim Proses As New Process
            Proses.StartInfo.FileName = System.AppDomain.CurrentDomain.BaseDirectory() + "\Download.bat"
            Proses.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            Proses.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Proses.Start()

            Proses.WaitForExit()

            Dim content As String = ""
            Using textReader As New System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory() + "\DOWNLOAD.TXT")
                content = textReader.ReadToEnd
            End Using

            Dim Separator() As String = {vbCrLf}
            Dim Hasil() As String

            Hasil = content.Split(Separator, StringSplitOptions.RemoveEmptyEntries)
            Data = String.Join("','", Hasil)

        Catch
            MessageBox.Show("Data Collector Tidak Ditemukan...")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In ViewTujuan.SelectedRows
            ViewTujuan.Rows.Remove(row)
        Next

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
            Dim StockBenang As StockBenang = DaftarStockBenang.Find(txtKodeProduksi.Text)
            If Not IsNothing(StockBenang) Then
                ViewAsal.Rows.Add(StockBenang.KodeProduksi, _
                              StockBenang.KodeItem, _
                              StockBenang.NamaItem, _
                              StockBenang.KodeArea, _
                              StockBenang.Jumlah2 & Space(1) & StockBenang.Satuan2, _
                              StockBenang.Jumlah3 & Space(1) & StockBenang.Satuan3)
            Else
                MessageBox.Show("Kode Produksi Tidak Valid..." & vbCrLf & "Pastikan Kode Produksi Masih Berada Di Gudang Benang...")
                txtKodeProduksi.Text = ""
                txtKodeProduksi.Focus()
            End If

            txtKodeProduksi.Text = ""
            txtKodeProduksi.Focus()
        End If

        SetEnableCommand()
    End Sub
End Class