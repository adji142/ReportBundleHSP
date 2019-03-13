Imports HSPProduction.HSP.Data

Public Class frmPengakuanStockBenang

    Private Sub FillArea()
        Dim DaftarArea As New DaftarArea(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarArea.Read("%", "511")
        cboArea.DataSource = DS.Tables("View")
        cboArea.DisplayMember = "Nama Area"
        cboArea.ValueMember = "Kode"
    End Sub

    Private Sub ResetData()
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtBeratNetto.Text = ""
        txtJumlahBox.Text = ""
        txtBeratBox.Text = ""
        cboStatus.SelectedIndex = -1
        cboArea.SelectedIndex = -1

        SetEnableCommand()
    End Sub

    Private Sub frmPengakuanStockBenang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillArea()
        ResetData()
    End Sub

    Private Sub DataChange(sender As Object, e As EventArgs) Handles _
                                                                        txtKodeItem.TextChanged,
                                                                        txtBeratNetto.TextChanged,
                                                                        txtBeratBox.TextChanged,
                                                                        cboStatus.SelectedIndexChanged,
                                                                        cboArea.SelectedIndexChanged
        SetEnableCommand()
    End Sub

    Private Sub SetEnableCommand()
        If txtJumlahBox.Value > 0 Then
            txtBeratBox.Value = txtBeratNetto.Value / txtJumlahBox.Value
        End If

        btProcess.Enabled = If(txtKodeItem.Text = "", False, True) And _
                            If(txtNamaItem.Text = "", False, True) And _
                            If(txtBeratNetto.Text = "", False, True) And _
                            If(txtJumlahBox.Text = "", False, True) And _
                            If(txtBeratBox.Text = "", False, True) And _
                            If(cboStatus.SelectedIndex = -1, False, True) And _
                            If(cboArea.SelectedIndex = -1, False, True)
    End Sub

    Private Sub btLookupKodeArea_Click(sender As Object, e As EventArgs) Handles btLookupKodeArea.Click
        Dim DaftarArea As IDataLookup = New DaftarArea(ActiveSession)
        Dim Parameter() As String = {"511"}

        Dim Form As New frmLookup(DaftarArea, Parameter)
        Form.Text = "Lookup Daftar Area Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboArea.SelectedValue = Form.IDLookup
            cboArea.Focus()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btProcess.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btProcess"
                Dim NoTransaksi As String
                Dim KodeProduksi As String
                Dim Periode, PeriodeTransaksi As String

                Dim Box As Integer

                Periode = GetPeriodFull(txtTglProduksi.Value)
                PeriodeTransaksi = GetPeriod(txtTglProduksi.Value)

                Dim DaftarProduksiBenang As New DaftarStockBenang(ActiveSession)
                Dim ProduksiBenang As New StockBenang

                NoTransaksi = DaftarProduksiBenang.GetNomorTransaksiIn(PeriodeTransaksi)
                KodeProduksi = DaftarProduksiBenang.GetKodeProduksi(Periode)

                For Box = 1 To txtJumlahBox.Value
                    KodeProduksi += 1

                    ProduksiBenang.KodeProduksi = KodeProduksi
                    ProduksiBenang.KodeProduksiLama = ""
                    ProduksiBenang.StatusProduksi = 1 'Hasil Produksi
                    ProduksiBenang.NomorWO = "-"
                    ProduksiBenang.KodeItem = txtKodeItem.Text
                    ProduksiBenang.NamaItem = txtNamaItem.Text
                    ProduksiBenang.KodeStatusQC = cboStatus.SelectedIndex + 1
                    ProduksiBenang.NamaStatusQC = cboStatus.SelectedItem
                    ProduksiBenang.KodeDisposisi = 0
                    ProduksiBenang.NamaDisposisi = ""
                    ProduksiBenang.BeratBrutto = 0
                    ProduksiBenang.KodePola = "1001"
                    ProduksiBenang.KodeMedia1 = "1001"
                    ProduksiBenang.BeratMedia1 = 60
                    ProduksiBenang.JumlahMedia1 = 1
                    ProduksiBenang.KodeMedia2 = "1003"
                    ProduksiBenang.BeratMedia2 = 1.9
                    ProduksiBenang.JumlahMedia2 = 1
                    ProduksiBenang.KodeMedia3 = "1004"
                    ProduksiBenang.BeratMedia3 = 0.164
                    ProduksiBenang.JumlahMedia3 = 9
                    ProduksiBenang.BeratNetto = txtBeratBox.Value
                    ProduksiBenang.Satuan1 = "BOX"
                    ProduksiBenang.Satuan2 = "BOBIN"
                    ProduksiBenang.Satuan3 = "KG"
                    ProduksiBenang.Jumlah1 = 1
                    ProduksiBenang.Jumlah2 = 9
                    ProduksiBenang.Jumlah3 = txtBeratBox.Value
                    ProduksiBenang.KodeLokasi = "511"
                    ProduksiBenang.KodeArea = cboArea.SelectedValue
                    ProduksiBenang.Keterangan = ""
                    ProduksiBenang.InputData = 0
                    ProduksiBenang.M_NoTimbang = NoTransaksi
                    ProduksiBenang.M_TglTransaksi = txtTglProduksi.Value
                    ProduksiBenang.M_TglTimbang = Now
                    ProduksiBenang.M_KodeShift = "1"
                    ProduksiBenang.M_KodeGrup = "A"
                    ProduksiBenang.M_PrevShift = 0
                    ProduksiBenang.M_KodeUnit = "001"
                    ProduksiBenang.M_KodeMesin = "1001"
                    ProduksiBenang.M_UserID = ActiveSession.KodeUser

                    DaftarProduksiBenang.Add(ProduksiBenang)

                Next

                'Cetak Barcode
                '------------------------------------------------------------------------------------------------------
                PrintBarcode(NoTransaksi)

                MessageBox.Show("Proses Pengakuan Benang Selesai")

                ResetData()
            Case "btClose"
                Me.Close()
        End Select
    End Sub

    Private Sub txtKodeItem_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeItem.Validating
        If txtKodeItem.Text <> "" Then
            Dim SAPInventory As New SAPInventory()
            txtNamaItem.Text = SAPInventory.GetItem(txtKodeItem.Text)
        End If
    End Sub

    Private Sub PrintBarcode(NoTimbang As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockBenang As New DaftarStockBenang(ActiveSession)
        Dim Data = DaftarStockBenang.ReadByTimbang(NoTimbang).Tables("View")
        Dim DR As DataRow

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeGB.btw", False, "")

        For Each DR In Data.Rows

            'Deklarasi Barcode Application
            FormatBt.SetNamedSubStringValue("Tanggal", Convert.ToDateTime(DR("Tanggal")).ToString("dd-MM-yy"))
            FormatBt.SetNamedSubStringValue("KodeGrup", UCase(DR("Grup")))
            FormatBt.SetNamedSubStringValue("KodeMesin", UCase(DR("Mesin")))
            FormatBt.SetNamedSubStringValue("NamaItem", UCase(DR("Item")))
            FormatBt.SetNamedSubStringValue("StatusQc", UCase(DR("Status")))
            FormatBt.SetNamedSubStringValue("KodeArea", UCase(DR("Area")))
            FormatBt.SetNamedSubStringValue("BeratNetto", Convert.ToDouble(DR("Berat Netto")).ToString("#,##0.000"))
            FormatBt.SetNamedSubStringValue("NamaMedia", UCase(DR("Media")))
            FormatBt.SetNamedSubStringValue("JumlahMedia", DR("Jumlah"))
            FormatBt.SetNamedSubStringValue("Kode", DR("Kode Produksi"))
            FormatBt.SetNamedSubStringValue("Status", "A")
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(DR("Keterangan")) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

        Next
        AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)

    End Sub
End Class