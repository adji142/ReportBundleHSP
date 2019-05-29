Imports System
Imports System.IO.Ports
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Transactions
Imports HSPProduction.HSP.Data

Public Class frmProduksiCBHP

#Region "Variable Declaration"
    Private KodeUnitSAP As String
    Private TglTransaksi As Date
    Private TglPencatatan As Date

    Private CekComboSPK As Boolean = False
#End Region

#Region "Fill Data To Combobox"

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblKodeUnitProduksi.Tag = GetSetting(enumFormID.frmSemenBag, enumSetting.settingKodeUnit)
        lblKodeLokasiHasilProduksi.Tag = GetSetting(enumFormID.frmSemenBag, enumSetting.settingKodeLokasi)
        lblKodeLokasiHasilProduksi.Text = New DaftarLokasi(ActiveSession).Find(lblKodeLokasiHasilProduksi.Tag).NamaLokasi.ToUpper

        KodeUnitSAP = ""
        If lblKodeUnitProduksi.Tag <> "" Then
            Try
                Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)
                lblKodeUnitProduksi.Text = "PROSES " & UnitProduksi.NamaUnit.ToUpper
                KodeUnitSAP = UnitProduksi.KodeUnitSAP
            Catch ex As Exception
                lblKodeUnitProduksi.Tag = ""
                lblKodeUnitProduksi.Text = "Unit Produksi Belum Disetting"
            End Try
        Else
            lblKodeUnitProduksi.Text = "Unit Produksi Belum Disetting"
        End If
        '-------------------------------------------------------------------------------------------------------------------

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

    Private Sub FillComboMesin()

        'Mesin Produksi
        Dim DaftarMesin As New DaftarMesin(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarMesin.Read("%", lblKodeUnitProduksi.Tag)
        cboKodeMesin.DataSource = DS.Tables("View")
        cboKodeMesin.DisplayMember = "Nama Mesin"
        cboKodeMesin.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Mesin") = "-"

        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1

    End Sub

    Private Sub FillComboNomorSPK()
        If KodeUnitSAP.Trim() <> "" Then
            Dim SAPWorkOrder As New SAPWorkOrder
            Dim DS As DataSet

            DS = New DataSet
            DS = SAPWorkOrder.ReadFGWorkOrderByUnit(KodeUnitSAP, TglTransaksi.Date)
            cboNomorSPK.DataSource = DS.Tables("View")
            cboNomorSPK.DisplayMember = "Nomor"
            cboNomorSPK.ValueMember = "Nomor"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Nomor") = ""
            Drow("Nomor") = "-"
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Nomor")

            cboNomorSPK.DataSource = DS.Tables("View")
            cboNomorSPK.DisplayMember = "Nomor"
            cboNomorSPK.ValueMember = "Nomor"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Nomor") = ""
            Drow("Nomor") = "-"
        End If

        cboNomorSpk.SelectedIndex = cboNomorSpk.Items.Count - 1
    End Sub


#End Region

#Region "Controller"

    'Form Load
    Private Sub frmHasilProduksiCBHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tmrJam_Tick(Nothing, Nothing)

        FillCombo()
        FillComboMesin()

        ResetData()

        If Not ActiveSession.KodeUser = "SPVS" Then
            btTest.Visible = False
        Else
            btTest.Visible = True
        End If
    End Sub

    'Form Close
    Private Sub frmHasilProduksiCBHP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PortTimbangan.Close()
    End Sub

    'Reset data
    Private Sub ResetData()

        lblGrupProduksi.Text = ""

        cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        chkShiftSebelumnya.Checked = False
        cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1

        txtHasilPcs.Value = 0
        txtHasilBS.Value = 0
        txtHasilTotal.Value = 0

        txtKeterangan.Text = ""

        cboKodeGrup.Focus()

        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        Call chkShiftSebelumnya_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub EnterWithBlank(sender As Object, e As EventArgs) Handles txtHasilPcs.Enter, txtHasilBS.Enter
        sender.Text = If(sender.Value = 0, "", sender.Value)
    End Sub

    'Jika Data Berubah
    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
        cboKodeGrup.SelectedIndexChanged,
        cboKodeMesin.SelectedIndexChanged,
        txtHasilPcs.TextChanged,
        txtHasilBS.TextChanged
        SetEnableCommand()

    End Sub

    'Cek Jika Data Berubah
    Private Sub chkShiftSebelumnya_CheckedChanged(sender As Object, e As EventArgs) Handles chkShiftSebelumnya.CheckedChanged
        FillComboNomorSPK()

        SetEnableCommand()
    End Sub


    'Timer Shift Produksi
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick

        'Transaksi
        '---------------------------------------------------------------------------------------------------
        If lblKodeUnitProduksi.ForeColor = Color.Yellow Then
            lblKodeUnitProduksi.ForeColor = Color.Blue
        Else
            lblKodeUnitProduksi.ForeColor = Color.Yellow
        End If

        'Tanggal & Jam Timbang
        '---------------------------------------------------------------------------------------------------
        TglPencatatan = Now

        lblTglTimbang.Text = Now.Date.ToString("dd") & " " & GetPeriodDescription(Now.Date).ToUpper()
        lblJamTimbang.Text = Now.ToString("HH:mm:ss")

        'Shift & Tanggal Transaksi
        '---------------------------------------------------------------------------------------------------
        Dim Jam = Now.ToLongTimeString

        If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
            If Jam < TimeSerial(7, 0, 0) Then
                lblKodeShift.Text = 3
                lblTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
                TglTransaksi = DateAdd("D", -1, Now.Date)
            Else
                lblKodeShift.Text = 1
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            End If
        Else
            If Jam < TimeSerial(15, 0, 0) Then
                lblKodeShift.Text = 1
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            ElseIf Jam >= TimeSerial(15, 0, 0) And Jam < TimeSerial(23, 0, 0) Then
                lblKodeShift.Text = 2
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            Else
                lblKodeShift.Text = 3
                lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                TglTransaksi = Now.Date
            End If
        End If

        'Jika Hasil lblKodeShift Sebelumnya
        '---------------------------------------------------------------------------------------------------
        If chkShiftSebelumnya.Checked = True Then
            Select Case lblKodeShift.Text
                Case 1
                    lblKodeShift.Text = 3
                    lblTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
                    TglTransaksi = DateAdd("D", -1, Now.Date)
                Case 2
                    lblKodeShift.Text = 1
                    lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                    TglTransaksi = Now.Date
                Case 3
                    lblKodeShift.Text = 2
                    If Microsoft.VisualBasic.Right(Jam, 2) = "AM" Then
                        lblTglTransaksi.Text = DateAdd("D", -1, Now.Date).ToString("dd-MM-yyyy")
                        TglTransaksi = DateAdd("D", -1, Now.Date)
                    Else
                        lblTglTransaksi.Text = Now.Date.ToString("dd-MM-yyyy")
                        TglTransaksi = Now.Date
                    End If
            End Select
        End If

        'Keterangan
        '---------------------------------------------------------------------------------------------------
        Select Case lblKodeShift.Text
            Case 1
                lblNamaShift.Text = "PAGI"
            Case 2
                lblNamaShift.Text = "SIANG"
            Case 3
                lblNamaShift.Text = "MALAM"
        End Select

    End Sub

    'Lookup Jika Ditekan F10
    Private Sub cboNomorSPK_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNomorSPK.KeyDown
        If e.KeyCode = Keys.F10 Then
            btLookupNomorSPK.PerformClick()
        End If
    End Sub

    'Cek Jika Data Berubah
    Private Sub cboNomorSPK_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNomorSPK.SelectedValueChanged
        lblKodeItemHasilProduksi.Text = ""
        lblNamaItemHasilProduksi.Text = "Work Order / SPK Belum Ditentukan"

        If cboNomorSPK.SelectedIndex <> cboNomorSPK.Items.Count - 1 Then
            Try
                Dim SAPWorkOrder As New SAPWorkOrder
                Dim WO As FGWorkOrder = SAPWorkOrder.FindFGByWO(KodeUnitSAP, cboNomorSPK.SelectedValue.ToString)

                lblKodeItemHasilProduksi.Text = WO.KodeItem
                lblNamaItemHasilProduksi.Text = WO.NamaItem.ToUpper

            Catch
            End Try
        End If
        SetEnableCommand()
    End Sub

    'Lookup WO
    Private Sub btLookupNomorSPK_Click(sender As Object, e As EventArgs) Handles btLookupNomorSPK.Click
        Dim DaftarNomorSpk As IDataLookup = New SAPWorkOrder
        Dim Parameter() As String = {SAPWorkOrder.enumLookupWorkOrder.woDaftarFGAktif, KodeUnitSAP, TglTransaksi.Date}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar SPK Aktif"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorSPK.SelectedValue = Form.IDLookup
            cboNomorSPK.Focus()
        End If
    End Sub


#End Region

#Region "Save To Database"

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim KodeLokasi As String = lblKodeLokasiHasilProduksi.Tag.ToString.Trim()
        Dim NoTransaksi As String
        Dim PeriodeTransaksi As String = GetPeriod(TglTransaksi)

        Select Case DirectCast(sender, Button).Name
            Case "btSave"

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Hasil Produksi Karung Semen ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                '---------------------------------------------------------------------------------------------------------
                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope
                Try
                    Dim DPB As New DaftarProduksiCBPR(ActiveSession)
                    Dim DT As DataTable = DPB.ReadBahanUtama(cboNomorSPK.SelectedValue).Tables("View")
                    Dim JenisBahan As String = ""
                    Dim QtyBahan As Double = 0

                    If DT.Rows.Count < 3 Then
                        MessageBox.Show("Internal Error : " + vbCrLf + "Pemakaian Bahan Utama Tidak Lengkap. " + vbCrLf +
                                        cboNomorSPK.SelectedValue + vbCrLf +
                                        "Pastikan Bahan Utama (BODY, PATCH, VALVE) Sudah Dimasukkan. ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        GoTo Jump
                    End If

                    'Cek Pemakaian Bahan Utama
                    'If New DaftarProduksiCBPR(ActiveSession).IsEmptyUtama(cboNomorSPK.SelectedValue, DaftarProduksiCBPR.enumProsesPemakaianBahanutama.CementBag) Then
                    '    MessageBox.Show("Pemakaian Bahan Utama Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '    GoTo Jump
                    'Else
                    '    If Not New DaftarProduksiCBPR(ActiveSession).IsPemakaianBahanUtama(cboNomorSPK.SelectedValue, DaftarProduksiCBPR.enumProsesPemakaianBahanutama.CementBag) Then
                    '        MessageBox.Show("Pemakaian Bahan Utama Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '        GoTo Jump
                    '    End If
                    'End If

                    Dim DaftarProduksiCBHP As New DaftarProduksiCBHP(ActiveSession)
                    Dim ProduksiCBHP As ProduksiCBHP
                    Dim UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(lblKodeUnitProduksi.Tag)

                    NoTransaksi = DaftarProduksiCBHP.GetNomorTransaksi(PeriodeTransaksi)

                    'Simpan Data Transaksi Produksi
                    ProduksiCBHP = New ProduksiCBHP
                    With ProduksiCBHP

                        .NoTransaksi = NoTransaksi
                        .TglTransaksi = TglTransaksi.Date
                        .TglPencatatan = TglPencatatan
                        .NomorWO = cboNomorSPK.SelectedValue
                        .KodeUnitSAP = KodeUnitSAP
                        .KodeUnit = lblKodeUnitProduksi.Tag
                        .KodeShift = lblKodeShift.Text
                        .KodeGrup = lblGrupProduksi.Text
                        .KodeMesin = cboKodeMesin.SelectedValue
                        .ShiftSebelumnya = chkShiftSebelumnya.Checked

                        .KodeLokasi = KodeLokasi
                        .KodeItem = lblKodeItemHasilProduksi.Text
                        .NamaItem = lblNamaItemHasilProduksi.Text
                        .Pcs = txtHasilPcs.Value
                        .Bs = txtHasilBS.Value
                        .Total = txtHasilPcs.Value + txtHasilBS.Value
                        .Keterangan = txtKeterangan.Text

                        .UserID = ActiveSession.KodeUser
                    End With
                    DaftarProduksiCBHP.Add(ProduksiCBHP)

                    'Posting Ke SAP Data Staging
                    Dim SAPStaging As New SAPStaging

                    '--------------------------------------------------------------------------------------------------
                    'Hasil Produksi
                    '--------------------------------------------------------------------------------------------------
                    SAPStaging.PostFinishedGoodReceipt(KodeUnitSAP,
                                                       cboNomorSPK.SelectedValue,
                                                       TglTransaksi,
                                                       lblKodeItemHasilProduksi.Text,
                                                       txtHasilPcs.Value,
                                                       0,
                                                       "",
                                                       "",
                                                       NoTransaksi, KodeLokasi)

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        SAPStaging.Execute(NoTransaksi, HSPProduction.SAPStaging.enumTransaction.FinishedGoodReceipt)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        SAPStaging.RemoveStagingData(NoTransaksi)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************

                    Me.Cursor = Cursors.Default
                    Me.Close()
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

    'Enable / Disable Button
    Private Sub SetEnableCommand()

        txtHasilTotal.Value = txtHasilPcs.Value + txtHasilBS.Value
        If cboNomorSPK.SelectedIndex = cboNomorSPK.Items.Count - 1 Then
            chkShiftSebelumnya.Enabled = True
        Else
            chkShiftSebelumnya.Enabled = False
        End If

        btSave.Enabled = If(cboKodeGrup.SelectedIndex = cboKodeGrup.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, False, True) And _
                         If(cboNomorSPK.Text = "", False, True) And _
                         If(txtHasilTotal.Value = 0, False, True)

        lblGrupProduksi.Text = cboKodeGrup.Text
    End Sub

#End Region

    Private Sub CekPemakaianBahan(NoTransaksi As String)
        'Simpan Data Item Bahan dan Cek Pemakaian Bahan By WO
        Dim SAP As New SAPWorkOrder
        Dim DS As DataSet

        Dim X_DPB As New X_DaftarPemakaianBahan(ActiveSession)
        Dim X_PB As New X_PemakaianBahan

        DS = SAP.ReadRMByWONonBatch(cboNomorSPK.SelectedValue, KodeUnitSAP, True)
        For Each DR As DataRow In DS.Tables("View").Rows
            X_PB.NoTransaksi = NoTransaksi
            X_PB.NomorWO = cboNomorSPK.SelectedValue
            X_PB.KodeItem = DR("Kode Item")
            X_PB.NamaItem = DR("Nama Item")

            X_DPB.Add(X_PB)
        Next

        Dim DPB As New DaftarProduksiCBPR(ActiveSession)
        Dim PB As PemakaianBahanSBZero = DPB.GetItemZero(cboNomorSPK.SelectedValue)
        If Not IsNothing(PB) Then
            MessageBox.Show("Pemakaian Bahan Atas Nomor SPK : " + cboNomorSPK.SelectedValue + " Belum Dimasukkan...!" + vbCrLf +
                            PB.KodeBahan + " - " + PB.NamaBahan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ResetData()
        End If

        X_DPB.Delete(NoTransaksi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btTest.Click
        Dim DPB As New DaftarProduksiCBPR(ActiveSession)
        Dim DT As DataTable = DPB.ReadBahanUtama("001").Tables("View")
        Dim JenisBahan As String = ""
        Dim QtyBahan As Double = 0

        If DT.Rows.Count < 3 Then
            MessageBox.Show("Internal Error : " + vbCrLf + "Pemakaian Bahan Utama Tidak Lengkap. " + vbCrLf +
                            cboNomorSPK.SelectedValue + vbCrLf +
                            "Pastikan Bahan Utama (BODY, PATCH, VALVE) Sudah Dimasukkan. ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            GoTo Jump
        End If

Jump:

    End Sub
End Class