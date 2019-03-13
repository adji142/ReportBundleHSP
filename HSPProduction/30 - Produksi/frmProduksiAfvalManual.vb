Imports HSPProduction.HSP.Data
Imports System.Transactions
Imports System.Drawing.Printing

Public Class frmProduksiAfvalManual
    Private _NoTransaksi As String

    Private KodeUnitSAP As String
    Private KodeItemSAP As String
    Private NamaItemSAP As String

    Private BeratBruto As Double
    Private BeratMedia As Double
    Private BeratNetto As Double

#Region "FillCombo"
    Private Sub FillComboShift()
        Dim DaftarShiftProduksi As New DaftarShiftProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarShiftProduksi.Read("%")
        cboKodeShift.DataSource = DS.Tables("View")
        cboKodeShift.DisplayMember = "Nama Shift"
        cboKodeShift.ValueMember = "Kode"
        cboKodeShift.SelectedIndex = -1
    End Sub

    Private Sub FillComboGrup()
        Dim DaftarGrupProduksi As New DaftarGrupProduksi(ActiveSession)
        Dim DS As DataSet

        DS = New DataSet
        DS = DaftarGrupProduksi.Read("%")
        cboKodeGrup.DataSource = DS.Tables("View")
        cboKodeGrup.DisplayMember = "Grup Produksi"
        cboKodeGrup.ValueMember = "Kode"

        cboKodeGrup.SelectedIndex = -1
    End Sub

    Private Sub FillComboUnitProduksi()
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)
        Dim DS As DataSet
        Dim Drow As DataRow

        DS = New DataSet
        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.DataSource = DS.Tables("View")
        cboKodeUnit.DisplayMember = "Unit Produksi"
        cboKodeUnit.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"

        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
    End Sub

    Private Sub FillComboMesin()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            Dim DaftarMesin As New DaftarMesin(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMesin.Read("%", cboKodeUnit.SelectedValue.ToString)
            cboKodeMesin.DataSource = DS.Tables("View")
            cboKodeMesin.DisplayMember = "Nama Mesin"
            cboKodeMesin.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Mesin") = "-"

            cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Mesin")

            cboKodeMesin.DataSource = DS.Tables("View")
            cboKodeMesin.DisplayMember = "Nama Mesin"
            cboKodeMesin.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Mesin") = "-"

            cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        End If
    End Sub

    Private Sub FillComboItemAfval()
        If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
            Dim DaftarItem As New DaftarItem(ActiveSession)
            Dim DS As DataSet

            Dim KodeUnit As String
            Try
                KodeUnit = cboKodeUnit.SelectedValue
            Catch ex As Exception
                KodeUnit = "!"
            End Try

            DS = New DataSet
            DS = DaftarItem.Read("%", "600", KodeUnit)
            cboItemAfval.DataSource = DS.Tables("View")
            cboItemAfval.DisplayMember = "Nama Item"
            cboItemAfval.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Item") = "-"

            cboItemAfval.SelectedIndex = cboItemAfval.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Item")

            cboItemAfval.DataSource = DS.Tables("View")
            cboItemAfval.DisplayMember = "Nama Item"
            cboItemAfval.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Item") = "-"

            cboItemAfval.SelectedIndex = cboItemAfval.Items.Count - 1
        End If
    End Sub

    Private Sub FillComboMediaTimbang()
        If lblLokasi.Tag <> "" Then
            Dim DaftarMediaTimbang As New DaftarMediaTimbang(ActiveSession)
            Dim DS As DataSet

            DS = New DataSet
            DS = DaftarMediaTimbang.Read("%", lblLokasi.Tag)
            cboMediaTimbang.DataSource = DS.Tables("View")
            cboMediaTimbang.DisplayMember = "Nama Media"
            cboMediaTimbang.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboMediaTimbang.SelectedIndex = cboMediaTimbang.Items.Count - 1
        Else
            Dim DS As New DataSet
            DS.Tables.Add("View")
            DS.Tables("View").Columns.Add("Kode")
            DS.Tables("View").Columns.Add("Nama Media")

            cboMediaTimbang.DataSource = DS.Tables("View")
            cboMediaTimbang.DisplayMember = "Nama Media"
            cboMediaTimbang.ValueMember = "Kode"

            Dim Drow As DataRow = DS.Tables("View").Rows.Add
            Drow("Kode") = ""
            Drow("Nama Media") = "-"

            cboMediaTimbang.SelectedIndex = cboMediaTimbang.Items.Count - 1
        End If
    End Sub

    Private Sub FillNomorSPK()
        Try
            If cboKodeUnit.SelectedIndex <> cboKodeUnit.Items.Count - 1 Then
                Dim DaftarProduksi As New DaftarProduksi(ActiveSession)
                Dim DS As DataSet

                DS = New DataSet
                DS = DaftarProduksi.ReadForAfvalManual(txtTglTransaksi.Value.Date, cboKodeUnit.SelectedValue)
                cboNomorWO.DataSource = DS.Tables("View")
                cboNomorWO.DisplayMember = "Nomor WO"
                cboNomorWO.ValueMember = "Nomor WO"

                Dim Drow As DataRow = DS.Tables("View").Rows.Add
                Drow("Nomor WO") = ""
                Drow("Nomor WO") = "-"
            Else
                Dim DS As New DataSet
                DS.Tables.Add("View")
                DS.Tables("View").Columns.Add("Nomor WO")

                cboNomorWO.DataSource = DS.Tables("View")
                cboNomorWO.DisplayMember = "Nomor WO"
                cboNomorWO.ValueMember = "Nomor WO"

                Dim Drow As DataRow = DS.Tables("View").Rows.Add
                Drow("Nomor WO") = ""
                Drow("Nomor WO") = "-"
            End If

            cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
        Catch
        End Try
    End Sub

#End Region

    Private Sub ResetData()
        FillComboShift()
        FillComboGrup()
        FillComboUnitProduksi()
        FillComboItemAfval()
        FillComboMediaTimbang()
        FillNomorSPK()

        KodeUnitSAP = ""
        KodeItemSAP = ""
        NamaItemSAP = ""

        _NoTransaksi = "<AUTO>"

        txtNoTransaksi.Text = _NoTransaksi
        txtTglTimbang.Value = Now
        txtTglTransaksi.Value = Now.Date

        cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1
        cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
        cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
        cboItemAfval.SelectedIndex = cboItemAfval.Items.Count - 1
        cboKodeShift.SelectedIndex = -1
        cboKodeGrup.SelectedIndex = -1
        chkShiftSebelumnya.Checked = False
        cboMediaTimbang.SelectedIndex = cboMediaTimbang.Items.Count - 1

        txtBeratBrutto.Text = ""
        txtBeratMedia.Text = ""
        txtBeratNetto.Text = ""
        txtKeterangan.Text = ""

        lblMesin.Enabled = False
        cboKodeMesin.Enabled = False

        lblNomorWO.Enabled = False
        cboNomorWO.Enabled = False
        cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
        btLookupNomorWO.Enabled = False

        'Default
        '-------------------------------------------------------------------------------------------------------------------
        Dim Setting As New frmSetting
        lblLokasi.Tag = GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi)
        If lblLokasi.Tag <> "" Then
            Try
                lblLokasi.Text = New DaftarLokasi(ActiveSession).Find(lblLokasi.Tag).NamaLokasi.ToUpper()
            Catch ex As Exception
                lblLokasi.Tag = ""
                lblLokasi.Text = "Lokasi Belum Disetting"
            End Try
        Else
            lblLokasi.Text = "Lokasi Belum Disetting"
        End If
        '-------------------------------------------------------------------------------------------------------------------

        SetEnableCommand()
    End Sub

    Private Sub btLookupMediaTimbang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetData()
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles _
                            txtNoTransaksi.TextChanged,
                            txtTglTimbang.ValueChanged,
                            txtTglTransaksi.ValueChanged,
                            cboKodeUnit.SelectedIndexChanged,
                            cboKodeMesin.SelectedIndexChanged,
                            cboItemAfval.SelectedIndexChanged,
                            cboKodeShift.SelectedIndexChanged,
                            cboKodeGrup.SelectedIndexChanged,
                            cboMediaTimbang.SelectedIndexChanged,
                            txtBeratBrutto.TextChanged,
                            txtKeterangan.TextChanged

        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboKodeUnit" Then
            FillComboMesin()
            FillComboItemAfval()
            FillComboMediaTimbang()
            FillNomorSPK()

            Dim UnitProduksi As UnitProduksi
            Try
                UnitProduksi = New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.SelectedValue)
                KodeUnitSAP = UnitProduksi.KodeUnitSAP

                If UnitProduksi.FlagAfval = 0 Then
                    lblMesin.Enabled = False
                    cboKodeMesin.Enabled = False
                    cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1
                Else
                    lblMesin.Enabled = True
                    cboKodeMesin.Enabled = True
                End If

                If UnitProduksi.FlagAfvalWO = 0 Then
                    lblNomorWO.Enabled = False
                    cboNomorWO.Enabled = False
                    cboNomorWO.SelectedIndex = cboNomorWO.Items.Count - 1
                    btLookupNomorWO.Enabled = False
                Else
                    lblNomorWO.Enabled = True
                    cboNomorWO.Enabled = True
                    btLookupNomorWO.Enabled = True
                End If

            Catch ex As Exception
                KodeUnitSAP = ""
            End Try
        End If

        If ObjectName = "txtTglTransaksi" Then
            FillNomorSPK()
        End If

        If ObjectName = "cboMediaTimbang" Then
            Dim MediaTimbang = New DaftarMediaTimbang(ActiveSession).Find(cboMediaTimbang.SelectedValue)
            If IsNothing(MediaTimbang) Then
                txtBeratMedia.Value = 0
            Else
                txtBeratMedia.Value = MediaTimbang.Berat
            End If
        End If

        SetEnableCommand()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btLookupMediaTimbang.Click
        Dim MediaTimbang As IDataLookup = New DaftarMediaTimbang(ActiveSession)
        Dim Parameter() As String = {lblLokasi.Tag}

        Dim Form As New frmLookup(MediaTimbang, Parameter)
        Form.Text = "Lookup Daftar Media Timbang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboMediaTimbang.SelectedValue = Form.IDLookup
            cboMediaTimbang.Focus()
        End If
    End Sub

    Private Sub btLookupNomorWO_Click(sender As Object, e As EventArgs) Handles btLookupNomorWO.Click
        Dim DaftarNomorSpk As IDataLookup = New DaftarProduksi(ActiveSession)
        Dim Parameter() As String = {txtTglTransaksi.Value.Date, cboKodeUnit.SelectedValue}

        Dim Form As New frmLookup(DaftarNomorSpk, Parameter)
        Form.Text = "Lookup Daftar Work Order Produksi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboNomorWO.SelectedValue = Form.IDLookup
            cboNomorWO.Focus()
        End If
    End Sub

    Private Sub btLookupItemAfval_Click(sender As Object, e As EventArgs) Handles btLookupItemAfval.Click
        Dim ItemAfval As IDataLookup = New DaftarItem(ActiveSession)
        Dim Parameter() As String = {"600", cboKodeUnit.SelectedValue}

        Dim Form As New frmLookup(ItemAfval, Parameter)
        Form.Text = "Lookup Daftar Item Afval"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboItemAfval.SelectedValue = Form.IDLookup
            cboItemAfval.Focus()
        End If
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtNoTransaksi.Text = "", False, True) And _
                         If(cboKodeUnit.SelectedIndex = cboKodeUnit.Items.Count - 1, False, True) And _
                         If(cboKodeMesin.SelectedIndex = cboKodeMesin.Items.Count - 1, Not cboKodeMesin.Enabled, True) And _
                         If(cboNomorWO.Enabled, cboNomorWO.SelectedIndex <> cboNomorWO.Items.Count - 1, True) And _
                         If(cboItemAfval.SelectedIndex = cboItemAfval.Items.Count - 1, False, True) And _
                         If(cboKodeShift.SelectedIndex = -1, False, True) And _
                         If(cboKodeGrup.SelectedIndex = -1, False, True) And _
                         If(cboMediaTimbang.SelectedIndex = cboMediaTimbang.Items.Count - 1, False, True) And _
                         If(txtBeratNetto.Value <= 0, False, True) And _
                         If(txtKeterangan.Text.Length < 10, False, True) And _
                         If(ActiveSession.Supervisor, True, False)

        lblSupervisor.Visible = Not ActiveSession.Supervisor

        BeratBruto = txtBeratBrutto.Value
        BeratMedia = txtBeratMedia.Value
        BeratNetto = BeratBruto - BeratMedia

        txtBeratNetto.Value = BeratNetto
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click, btClose.Click
        Dim Periode As String
        Dim PeriodeTransaksi As String

        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                '---------------------------------------------------------------------------------------------------------

                'Konfirmasi Transaksi
                If MessageBox.Show("Simpan Data Penerimaan Afval Produksi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    GoTo Jump
                End If

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                btSave.Enabled = False
                Me.Cursor = Cursors.WaitCursor

                Dim Scope As New TransactionScope

                Try
                    Periode = GetPeriod(Now)
                    PeriodeTransaksi = GetPeriodFull(Now)


                    Dim DaftarProduksiAfval As New DaftarAfvalProduksi(ActiveSession)
                    Dim ProduksiAfval As New ProduksiAfval

                    txtNoTransaksi.Text = DaftarProduksiAfval.GetNomorTransaksi(Periode)

                    With ProduksiAfval
                        .NoTransaksi = txtNoTransaksi.Text
                        .TglTransaksi = txtTglTransaksi.Value.Date
                        .TglPencatatan = txtTglTimbang.Value
                        .NomorWO = cboNomorWO.SelectedValue
                        .KodeUnit = cboKodeUnit.SelectedValue
                        .KodeShift = cboKodeShift.SelectedValue
                        .KodeGrup = cboKodeGrup.SelectedValue
                        .KodeMesin = cboKodeMesin.SelectedValue
                        .KodeItemAfval = cboItemAfval.SelectedValue
                        .NamaItemAfval = cboItemAfval.Text
                        .KodeMedia = cboMediaTimbang.SelectedValue
                        .BeratBrutto = txtBeratBrutto.Value
                        .BeratMedia = txtBeratMedia.Value
                        .BeratNetto = txtBeratNetto.Value
                        .Keterangan = txtKeterangan.Text
                        .ShiftSebelumnya = chkShiftSebelumnya.Checked
                        .UserID = ActiveSession.KodeUser
                        .KodeLokasi = lblLokasi.Tag
                        .KodeUnitSAP = KodeUnitSAP
                        .KodeItemSAP = KodeItemSAP
                        .NamaItemSAP = NamaItemSAP
                    End With
                    DaftarProduksiAfval.Add(ProduksiAfval)

                    'Simpan Ke Staging Database
                    Dim STG As New SAPStaging
                    KodeItemSAP = New DaftarItem(ActiveSession).Find(cboItemAfval.SelectedValue).KodeItemSistem
                    NamaItemSAP = ""

                    'Posting Ke Staging
                    STG.PostAfvalReceiptWWO(KodeUnitSAP, txtTglTransaksi.Value.Date, KodeItemSAP, NamaItemSAP, lblLokasi.Tag, txtBeratNetto.Value, txtNoTransaksi.Text)

                    '**************************************************************************************************
                    'Eksekusi Data Staging
                    '**************************************************************************************************
                    Try
                        'Eksekusi
                        STG.Execute(txtNoTransaksi.Text, SAPStaging.enumTransaction.AfvalReceiptWWO)

                        Scope.Complete()
                        Scope.Dispose()

                    Catch ex2 As Exception
                        'Remove Staging Data
                        STG.RemoveStagingData(txtNoTransaksi.Text)

                        Scope.Dispose()
                    End Try
                    '**************************************************************************************************

                    'Cetak Transaksi
                    '------------------------------------------------------------------------------------------------------
                    CetakStruk(txtNoTransaksi.Text)

                    Me.Cursor = Cursors.Default
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
        Me.Cursor = Cursors.Default
    End Sub

#Region "Print Transaksi"

    Private Sub CetakStruk(ByVal NoTransaksi As String, Optional Reprint As Boolean = False)
        Dim DaftarProduksiAfval As New DaftarAfvalProduksi(ActiveSession)
        Dim ProduksiAfval As ProduksiAfval

        ProduksiAfval = DaftarProduksiAfval.Find(NoTransaksi)
        If Not IsNothing(ProduksiAfval) Then
            Dim DataPrint As String
            Const BarisBaru As String = ControlChars.CrLf
            Dim PrintDialog As New PrintDialog
            Dim SettingPrint As New System.Drawing.Printing.PrinterSettings

            DataPrint = "========================================" & BarisBaru
            If Reprint = True Then
                DataPrint &= "              CETAK ULANG              " & BarisBaru
            End If
            DataPrint &= "******** BUKTI PENERIMAAN AFVAL ********" & BarisBaru
            DataPrint &= "----------------------------------------" & BarisBaru
            DataPrint &= "NOMOR             : " & ProduksiAfval.NoTransaksi & BarisBaru
            DataPrint &= "TGL. TIMBANG      : " & Format(ProduksiAfval.TglPencatatan, "dd-MM-yy HH:mm:ss") & BarisBaru
            DataPrint &= "TGL. PRODUKSI     : " & Format(ProduksiAfval.TglTransaksi, "dd-MM-yy") & BarisBaru
            DataPrint &= "SHIFT             : " & ProduksiAfval.KodeShift & BarisBaru
            DataPrint &= "GRUP              : " & ProduksiAfval.KodeGrup & BarisBaru
            DataPrint &= "NO. MESIN         : " & If(ProduksiAfval.KodeMesin = "", "-", New DaftarMesin(ActiveSession).Find(ProduksiAfval.KodeMesin).NamaMesin) & BarisBaru
            DataPrint &= "ITEM AFVAL        : " & ProduksiAfval.NamaItemAfval & BarisBaru
            DataPrint &= "----------------------------------------" & BarisBaru
            DataPrint &= "BERAT BRUTTO      : " & Format(ProduksiAfval.BeratBrutto, "##,##0.00") & " KG" & BarisBaru
            DataPrint &= "BERAT NETTO       : " & Format(ProduksiAfval.BeratNetto, "##,##0.00") & " KG" & BarisBaru
            DataPrint &= "----------------------------------------" & BarisBaru
            DataPrint &= "OPEARTOR TIMBANG  : " & ProduksiAfval.UserID & BarisBaru
            If ProduksiAfval.ShiftSebelumnya = 1 Then
                DataPrint &= "CATATAN       : AFVAL SHIFT SEBELUMNYA"
            End If
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru
            DataPrint &= StrDup(40, " ") & BarisBaru

            PrintDialog.PrinterSettings = New PrinterSettings
            PrinterSet.SendStringToPrinter(SettingPrint.PrinterName, DataPrint)
        End If
    End Sub

    'Private Sub CetakTransaksi(NoTransaksi As String, Optional ReprintStatus As Boolean = False)
    '    Dim DaftarAfvalProduksi As New DaftarAfvalProduksi(ActiveSession)
    '    Dim DaftarItemAfval As New DaftarItem(ActiveSession)

    '    Dim AfvalProduksi = DaftarItemAfval.Find(NoTransaksi)
    '    Dim ItemAfval = DaftarItemAfval.Find(AfvalProduksi.KodeItem)


    '    '--------------------------------------------------------------------------------------------------------
    '    'Cetak Struk
    '    '--------------------------------------------------------------------------------------------------------
    '    Dim PrintBuffer As String = ""

    '    'oData.GetLastData oConnection.Server

    '    'oShift.Fields.KodeShift = oData.Fields.KodeShift
    '    'oShift.Find oConnection.Server

    '    'oGrup.Fields.KodeGrup = oData.Fields.KodeGrup
    '    'oGrup.Find oConnection.Server

    '    'oUnit.Fields.KodeKelompok = oData.Fields.KodeKelompok
    '    'oUnit.Find oConnection.Server

    '    'oMesin.Fields.KodeMesin = oData.Fields.KodeMesin
    '    'oMesin.Find oConnection.Server

    '    'oItem.Fields.KodeItem = oData.Fields.KodeItem
    '    'oItem.Find oConnection.Server

    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "===================================" + vbCrLf
    '    'If CetakUlang Then
    '    '    PrintBuffer = PrintBuffer + "           CETAK ULANG             " + vbCrLf
    '    'End If
    '    'PrintBuffer = PrintBuffer + "****** BUKTI PENERIMAAN AVAL ******" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "-----------------------------------" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NOMOR         : " + Trim(Str(oData.Fields.RowID)) + vbCrLf
    '    'PrintBuffer = PrintBuffer + "TGL. TIMBANG  : " + Format(oData.Fields.TglPencatatan, "DD-MM-YY hh:mm:ss") + vbCrLf
    '    'PrintBuffer = PrintBuffer + "TGL. PRODUKSI : " + Format(oData.Fields.TglTransaksi, "DD-MM-YY") + vbCrLf
    '    'PrintBuffer = PrintBuffer + "SHIFT         : " + oShift.Fields.NamaShift + vbCrLf
    '    'PrintBuffer = PrintBuffer + "GRUP          : " + oGrup.Fields.NamaGrup + vbCrLf
    '    'PrintBuffer = PrintBuffer + "UNIT          : " + oUnit.Fields.NamaKelompok + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NO.MESIN      : " + IIf(oData.Fields.KodeMesin = "", "-", oMesin.Fields.NamaMesin) + vbCrLf
    '    'PrintBuffer = PrintBuffer + "ITEM          : " + oItem.Fields.NamaItem + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NIK           : " + oData.Fields.NoKaryawan + vbCrLf
    '    'PrintBuffer = PrintBuffer + "-----------------------------------" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "BRUTTO        : " + Format(oData.Fields.Timbang, "#,##0.00") + " KG" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "NETTO         : " + Format(oData.Fields.Timbang - oData.Fields.BeratMedia, "#,##0.00") + " KG" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "-----------------------------------" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "OPERATOR TIMBANG" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'PrintBuffer = PrintBuffer + UCase(oData.Fields.UserID) + vbCrLf
    '    'PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'If oData.Fields.PrevShift = 1 Then
    '    '    PrintBuffer = PrintBuffer + ">> CATATAN : Afval Shift Sebelumnya" + vbCrLf
    '    'Else
    '    '    PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'End If

    '    'Dim FF As Integer
    '    'Dim SP As Integer

    '    'If CetakUlang Then
    '    '    SP = 8
    '    'Else
    '    '    SP = 9
    '    'End If

    '    'For FF = 1 To SP
    '    '    PrintBuffer = PrintBuffer + "" + vbCrLf
    '    'Next

    '    '--------------------------------------------------------------------------------------------------------
    '    'Cetak Ke Printer
    '    '--------------------------------------------------------------------------------------------------------
    '    'Dim PrinterConnection As Integer
    '    'Dim PortPrinter As String
    '    'Dim DeviceName As String

    '    'PrinterConnection = cboPrinterConnection.ListIndex + 1
    '    'PortPrinter = cboPortPrinter.Text

    '    'DeviceName = ""
    '    'Select Case PrinterConnection
    '    '    Case 1 ' Pararel
    '    '        DeviceName = "LPT" + Trim(PortPrinter)
    '    '        LPTDirectPrint(DeviceName, PrintBuffer)
    '    '    Case 2 ' Serial
    '    '        DeviceName = "COM" + Trim(PortPrinter)
    '    '        COMDirectPrint(DeviceName, PrintBuffer)
    '    '    Case 3 ' USB
    '    '        DeviceName = cboDeviceName.Text
    '    '        USBDirectPrint(DeviceName, PrintBuffer, "")
    '    'End Select

    'End Sub

#End Region
End Class