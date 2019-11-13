Imports HSPNotulen.HSP.Data
Imports System.Transactions
Imports System.Net.Mail
Public Class FrmNotulen
    'text
    Dim tmptext As TextBox
    Dim group As GroupBox
    'flow layout
    Dim tmplayout As FlowLayoutPanel

    Dim KodeDepartement As String
    Dim Data As DataSet

    Dim HeaderOrderCount = 0
    Dim DetailOrderCount = 0

    Public IDData As String

    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum
    Private Enum StartEnd
        Start = 1
        Selesai = 0
    End Enum
    Private Enum Saved
        Saved = 1
        NSaved = 0
    End Enum
    Private _ID As String
    Private _SaveMode As enumSaveMode
    Private _StartEnd As StartEnd
    Private _Saved As Saved

    Private HeaderRowID As String
    Private DetailRowID As String
    Private SubDetailRowID As String

    'Private Var
    ' ----------------------- <Header> -----------------------
    Private _Problem As String
    Private _Status As String
    ' ----------------------- </Header> -----------------------

    ' ----------------------- <Detail> -----------------------
    Private _FU As String
    Private _DateStart As Date
    Private _DateEnd As Date
    Private _Order As Integer
    Private _OrderDetail As Integer
    ' ----------------------- </Detail> -----------------------

    ' ----------------------- <SubDetail> -----------------------
    Private _PIC As String
    Private _PICNIK As String
    ' ----------------------- </SubDetail> -----------------------

    Private _Table As String

    Private _Peserta As Integer
    'Constanta
    Private Const Table_ = 0
    Private Const RowID_ = 1
    Private Const Flag_ = 2
    Private Const Order_ = 3
    Private Const Problem_ = 4
    Private Const DetailRowID_ = 5
    Private Const HeaderID_ = 6
    Private Const OrderDetail_ = 7
    Private Const FU_ = 8
    Private Const PIC_ = 9
    Private Const Startdate_ = 10
    Private Const EndDate_ = 11
    Private Const Status_ = 12
    Private Const PICNik_ = 13

    Public Sub New()
        InitializeComponent()
        _ID = ""
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub

    Private Sub FillCombo()
        Dim DS As DataSet = New DaftarMetting(ActiveSession).Read("%")
        Dim DR As DataRow
        ' Topik
        cboTopik.DataSource = DS.Tables("View")
        cboTopik.DisplayMember = "Topik"
        cboTopik.ValueMember = "Kode"
        DR = DS.Tables("View").Rows.Add
        DR("Kode") = ""
        DR("Topik") = "-"

        ' Notulen
        Dim DS_Not As DataSet = New DaftarNotuler(ActiveSession).Read("%")
        Dim DR_Not As DataRow
        cboNotulen.DataSource = DS_Not.Tables("View")
        cboNotulen.DisplayMember = "Nama Notulen"
        cboNotulen.ValueMember = "NIK"
        DR_Not = DS_Not.Tables("View").Rows.Add
        DR_Not("NIK") = ""
        DR_Not("Nama Notulen") = "-"

        cboTopik.SelectedIndex = cboTopik.Items.Count - 1
        cboNotulen.SelectedIndex = cboNotulen.Items.Count - 1

        ResetForm()
    End Sub
    Private Sub ResetForm()
        _SaveMode = enumSaveMode.AddMode
        Dim Periode = GetPeriod(Date.Now)
        cboTopik.SelectedIndex = cboTopik.Items.Count - 1
        cboNotulen.SelectedIndex = cboNotulen.Items.Count - 1
        cbostatus.SelectedIndex = cbostatus.Items.Count - 1

        Dim Notulen As New NotulenModels(ActiveSession)
        txtNoNotulen.Text = Notulen.GetNomorTransaksi(Periode.ToString())
        txtdate.Enabled = False
        cboNotulen.Enabled = False
        cmdPeserta.Enabled = False
        cmdStart.Enabled = False
        cboEnd.Enabled = False
        cmdAddProblem.Enabled = False
        cmdAddFU.Enabled = False
        cmdDown.Enabled = False
        cmdUp.Enabled = False
        cmdDelete.Enabled = False
        LblJamEnd.Text = ""
        lblJamStart.Text = ""
        txtperiode.Text = ""
        If GridNotulen.Rows.Count > 0 Then
            GridNotulen.DataSource = Nothing
            If Data.Tables(0).Rows.Count > 0 Then
                Data.Tables.Clear()
                Generate_Dataset()
            End If
        End If
        SetEnableCommand()
        btSave.Enabled = False
    End Sub
    Private Sub TimerDone()
        txtdate.Enabled = False
        cboNotulen.Enabled = False
        cmdPeserta.Enabled = False
        cmdStart.Enabled = False
        cboEnd.Enabled = False
        cmdAddProblem.Enabled = False
        cmdAddFU.Enabled = False
        cmdDown.Enabled = False
        cmdUp.Enabled = False
        cmdDelete.Enabled = False
        SetEnableCommand()

    End Sub
    Private Sub OpenForm()
        txtdate.Enabled = True
        cboNotulen.Enabled = True
        cmdPeserta.Enabled = True
        cmdStart.Enabled = True
        SetEnableCommand()
    End Sub
    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtNoNotulen.Text = "", False, True) And _
                        If(cboTopik.Text = "-", False, True) And _
                        If(cboNotulen.Text = "-", False, True) And _
                        If(_StartEnd = StartEnd.Start, False, True) And _
                        If(txtperiode.Text = "", False, True) And _
                        If(GridNotulen.Rows.Count < 1, False, True) And _
                        If(_Peserta <= 0, False, True)
        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If
    End Sub
    Private Sub GetInformation()
        Dim Kode = cboTopik.SelectedValue.ToString

        Dim ListMeeting As New DaftarMetting(ActiveSession)
        Dim Meeting = ListMeeting.Find_ByID(Kode)

        If Not IsNothing(Meeting) Then
            txtperiode.Text = Meeting.Periode
            OpenForm()
            GetLastNotulen(cbostatus.Text)
        Else
            ResetForm()
        End If
        'KodeDepartement = Meeting.KodeDepartement
    End Sub
    Private Sub GetLastNotulen(Optional ByVal Filter As String = "")
        'Get LastMeeting
        If Filter = "-" Then
            Filter = ""
        End If
        If GridNotulen.Rows.Count > 0 Then
            GridNotulen.DataSource = Nothing
            If Data.Tables(0).Rows.Count > 0 Then
                Data.Tables.Clear()
                Generate_Dataset()
            End If
        End If

        Dim DaftarNotulen As New NotulenModels(ActiveSession)
        Dim DS As DataSet = DaftarNotulen.GetLastMeeting(cboTopik.Text)
        If DS.Tables(0).Rows.Count > 0 Then
            'Get hire
            Dim NoTransaksi As String = DS.Tables(0).Rows(0)(0)
            Dim TglTransaksi As Date = DS.Tables(0).Rows(0)(1)

            Dim Header As DataSet = DaftarNotulen.Read_Header(NoTransaksi, Filter)
            If Header.Tables(0).Rows.Count > 0 Then
                'Do Hire
                Dim xHeaderRowID As String
                For Each xrow In Header.Tables(0).Rows
                    xHeaderRowID = System.Guid.NewGuid.ToString
                    Dim DRH As DataRow = Data.Tables(0).NewRow
                    DRH("Table") = "H"
                    DRH("RowID") = xHeaderRowID
                    DRH("HeaderID") = xHeaderRowID
                    DRH("Flag") = 1
                    DRH("Order") = xrow("LineNumber")
                    DRH("Problem") = xrow("Problem")
                    DRH("Status") = xrow("StausNotulen")
                    DRH("OrderDetail") = 0
                    Data.Tables(0).Rows.Add(DRH)

                    Dim Detail As DataSet = DaftarNotulen.Read_Detail(xrow("RowID"))

                    If Detail.Tables(0).Rows.Count > 0 Then
                        'Do hire
                        Dim yDetailRowID As String
                        For Each yrow In Detail.Tables(0).Rows
                            yDetailRowID = System.Guid.NewGuid.ToString
                            Dim DRD As DataRow = Data.Tables(0).NewRow
                            DRD("Table") = "D"
                            DRD("Order") = xrow("LineNumber")
                            DRD("DetailRowID") = yDetailRowID
                            DRD("HeaderID") = xHeaderRowID
                            DRD("OrderDetail") = yrow("LineNumber")
                            DRD("FU") = yrow("FollowUp")
                            DRD("Startdate") = yrow("Startdate")
                            DRD("EndDate") = yrow("FinishDate")
                            'Handle PIC
                            Dim SubDetail As DataSet = DaftarNotulen.Read_SubDetail(yrow("RowID"))
                            If SubDetail.Tables(0).Rows.Count > 0 Then
                                Dim PIC As String = ""
                                Dim PIC_Nik As String = ""
                                For Each zRow In SubDetail.Tables(0).Rows
                                    PIC += zRow("NamaPIC") + ","
                                    PIC_Nik += zRow("NIK") + ","
                                Next
                                DRD("PIC") = PIC
                                DRD("PIC_Nik") = PIC_Nik
                            End If
                            Data.Tables(0).Rows.Add(DRD)
                        Next
                    End If
                Next
            Else
                GoTo Jump
            End If
            ShowData()
        End If
Jump:
    End Sub
    Private Sub GetPesertaCount()
        Dim PesertaCount As New NotulenModels(ActiveSession)
        Dim DS As New DataSet
        DS = PesertaCount.Read_peserta("%", txtNoNotulen.Text)

        JmlPeserta.Text = "Jumlah Peserta: " + DS.Tables("View").Rows.Count.ToString
        _Peserta = DS.Tables("View").Rows.Count
    End Sub
    Private Sub ShowData()

        If Data.Tables(0).Rows.Count > 0 Then
            Dim DV As DataView
            DV = New DataView(Data.Tables(0), "", "Order,OrderDetail,HeaderID asc", DataViewRowState.CurrentRows)
            GridNotulen.DataSource = DV
            FormatCell(1)
        End If
    End Sub
    Private Sub InsertData()

        Select Case _Table
            Case "Header"
                ' Do This
                If _SaveMode = enumSaveMode.AddMode Then
                    HeaderRowID = System.Guid.NewGuid.ToString
                End If
                Dim DR As DataRow = Data.Tables(0).NewRow
                DR("Table") = "H"
                DR("RowID") = HeaderRowID
                DR("HeaderID") = HeaderRowID
                DR("Flag") = 1
                If _Order Then
                    DR("Order") = _Order
                Else
                    'HeaderOrderCount = HeaderOrderCount + 1
                    DR("Order") = getMaxOrder()
                End If
                DR("Problem") = _Problem
                DR("Status") = _Status
                DR("OrderDetail") = 0
                Data.Tables(0).Rows.Add(DR)
            Case "Detail"
                DetailOrderCount = DetailOrderCount + 1
                If _SaveMode = enumSaveMode.AddMode Then
                    DetailRowID = System.Guid.NewGuid.ToString
                End If
                'Do This
                Dim DR As DataRow = Data.Tables(0).NewRow
                DR("Order") = _Order
                DR("Table") = "D"
                DR("DetailRowID") = DetailRowID
                DR("HeaderID") = HeaderRowID
                DR("OrderDetail") = _OrderDetail
                DR("FU") = _FU
                DR("Startdate") = _DateStart
                DR("EndDate") = _DateEnd
                DR("PIC") = _PIC
                DR("PIC_Nik") = _PICNIK
                Data.Tables(0).Rows.Add(DR)
            Case "SubDetail"
                'Do This

        End Select

    End Sub
    Private Sub Generate_Dataset()
        Dim Table As DataTable = New DataTable("Notulen")
        Table.Columns.Add("Table")
        Table.Columns.Add("RowID")
        Table.Columns.Add("Flag")
        Table.Columns.Add("Order")
        Table.Columns.Add("Problem")
        Table.Columns.Add("DetailRowID")
        Table.Columns.Add("HeaderID")
        Table.Columns.Add("OrderDetail")
        Table.Columns.Add("FU")
        Table.Columns.Add("PIC")
        Table.Columns.Add("Startdate").DataType = GetType(Date)
        Table.Columns.Add("EndDate").DataType = GetType(Date)
        Table.Columns.Add("Status")
        Table.Columns.Add("PIC_Nik")

        Data.Tables.Add(Table)
    End Sub
    Private Sub FormatCell(ByVal Param As Integer)
        '1: Show, 0 Hide
        If Param = 1 Then
            GridNotulen.Columns(Table_).Visible = False
            GridNotulen.Columns(RowID_).Visible = False
            GridNotulen.Columns(Order_).Visible = False
            GridNotulen.Columns(HeaderID_).Visible = False
            GridNotulen.Columns(OrderDetail_).Visible = False
            GridNotulen.Columns(Flag_).Visible = False
            GridNotulen.Columns(DetailRowID_).Visible = False
            GridNotulen.Columns(PICNik_).Visible = False
        Else
            GridNotulen.Columns(Table_).Visible = True
            GridNotulen.Columns(RowID_).Visible = True
            GridNotulen.Columns(Order_).Visible = True
            GridNotulen.Columns(HeaderID_).Visible = True
            GridNotulen.Columns(OrderDetail_).Visible = True
            GridNotulen.Columns(Flag_).Visible = True
            GridNotulen.Columns(DetailRowID_).Visible = True
            GridNotulen.Columns(PICNik_).Visible = True
        End If
        GridNotulen.Focus()
        GridNotulen.Columns(Problem_).SortMode = DataGridViewColumnSortMode.NotSortable
        GridNotulen.Columns(FU_).SortMode = DataGridViewColumnSortMode.NotSortable
        GridNotulen.Columns(PIC_).SortMode = DataGridViewColumnSortMode.NotSortable
        GridNotulen.Columns(Startdate_).SortMode = DataGridViewColumnSortMode.NotSortable
        GridNotulen.Columns(EndDate_).SortMode = DataGridViewColumnSortMode.NotSortable
        GridNotulen.Columns(Status_).SortMode = DataGridViewColumnSortMode.NotSortable

        Dim Column As DataColumn
        For Each Column In Data.Tables(0).Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                GridNotulen.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                GridNotulen.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                GridNotulen.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                GridNotulen.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                GridNotulen.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                GridNotulen.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
        'GridNotulen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'GridNotulen.AutoResizeColumn(FU_)
        GridNotulen.Columns.Item(Problem_).Width = 250
        GridNotulen.Columns(Problem_).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        GridNotulen.Columns.Item(FU_).Width = 450
        GridNotulen.Columns(FU_).DefaultCellStyle.WrapMode = DataGridViewTriState.True

        GridNotulen.Columns.Item(PIC_).Width = 150
        GridNotulen.Columns(PIC_).DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    Private Function getMaxOrder() As Integer
        Dim maxVal As Integer = 0

        For Each xd In Data.Tables(0).Rows
            Dim curentVal As Integer
            curentVal = xd("Order")
            If curentVal > maxVal Then
                maxVal = curentVal
            End If
        Next
        Return maxVal + 1
    End Function
    Private Function getMaxOrderDetail() As Integer
        Dim View As DataView = Data.Tables(0).DefaultView
        View.Sort = "HeaderID asc"
        Dim maxVal As Integer = 0
        Dim HeaderID As String = ""
        Dim Tble As String = ""
        For Each xd As DataRowView In View
            Dim CurHeader As String
            Dim curentVal As Integer
            curentVal = xd("OrderDetail")
            CurHeader = xd("HeaderID")
            If curentVal > maxVal And CurHeader = HeaderID Then
                maxVal = curentVal
            Else
                If curentVal < maxVal And Tble = "H" Then
                    maxVal = 0
                End If
            End If
            HeaderID = xd("HeaderID")
            Tble = xd("Table")
        Next
        If maxVal = 0 Then
            maxVal = 0
        Else
            maxVal += 1
        End If
        Return maxVal
    End Function
    Private Sub SendEmail(Optional NoTransaksi As String = "", Optional ByVal EmailReciept As String = "", Optional ByVal Counting As Integer = 0)
        Dim Email As String = My.Settings.EmailAccount
        Dim Password As String = My.Settings.Password_Email
        Dim Attch As String = ""
        'Generate Attachment
        If EmailReciept <> "" Then
            ' Generate File
            Dim Export As New ExportGrid(ActiveSession)
            Try
                Attch = Export._Create(NoTransaksi, Counting)
            Catch ex As Exception
                MessageBox.Show("Gagal Generate Attachment")
                GoTo Jump
            End Try
        End If
Jump:

        Dim Smtp As New SmtpClient
        Dim mail_message As New MailMessage
        Smtp.UseDefaultCredentials = False
        Smtp.Credentials = New Net.NetworkCredential(Email, Password)
        Smtp.Port = 25
        Smtp.EnableSsl = False
        Smtp.Host = "192.168.1.108"

        mail_message = New MailMessage()
        mail_message.From = New MailAddress(Email)
        mail_message.To.Add(EmailReciept)
        mail_message.Subject = "[No Reply] Reminder Notulen [No Reply] This Mail Generated from system"
        mail_message.IsBodyHtml = False
        mail_message.Body = "Trial Send Hasil Notulen"
        If Attch <> "" Then
            mail_message.Attachments.Add(New Attachment(System.AppDomain.CurrentDomain.BaseDirectory & "/" & Attch))
        End If
        Smtp.Send(mail_message)

    End Sub

    Private Sub FrmNotulen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        GetPesertaCount()
        Data = New DataSet
        Generate_Dataset()
        ShowData()
    End Sub
    Private Sub SaveData()
        '_Saved = Saved.Saved
        Me.Cursor = Cursors.WaitCursor
        Dim Scope As New TransactionScope
        lblstatus.Text = "Begin Saving Dadta"
        Dim DaftarNotulen As New NotulenModels(ActiveSession)
        Dim o As Integer = 0
        Try
            Dim Header As _NotulenHeader
            Dim Detail As _NotulenDetail
            Dim SubDetail As _NotulenSubdetail
            ' Header
            For Each row In Data.Tables(0).Rows
                If row("Table") = "H" Then
                    lblstatus.Text = "Saving Header Data"
                    Header = New _NotulenHeader
                    Header.RowID = row("RowID")
                    Header.LineNumber = row("Order")
                    Header.NoTransaksi = txtNoNotulen.Text
                    Header.TglTransaksi = txtdate.Value.Date
                    Header.PeriodeMetting = txtperiode.Text
                    Header.TopikMeeting = cboTopik.Text
                    Header.Notulen = cboNotulen.Text
                    Header.Problem = row("Problem")
                    Header.JamMulai = lblJamStart.Text
                    Header.JamSelesai = LblJamEnd.Text
                    Header.StausNotulen = row("Status")
                    Header.TX = TRX()
                    Header.TXUpd = ""
                    DaftarNotulen.Add_Header(Header)
                Else
                    lblstatus.Text = "Saving Detail Data"
                    Detail = New _NotulenDetail
                    SubDetail = New _NotulenSubdetail
                    Detail.RowID = row("DetailRowID")
                    Detail.HeaderID = row("HeaderID")
                    Detail.LineNumber = row("OrderDetail")
                    Detail.FollowUp = row("FU")
                    Detail.StartDate = row("StartDate")
                    Detail.FinishDate = row("EndDate")
                    Detail.TX = TRX()
                    DaftarNotulen.Add_Detail(Detail)
                    If row("PIC_Nik") <> "" Then
                        Dim splitedPIC As String() = row("PIC_Nik").ToString.Trim().Remove(row("PIC_Nik").ToString.Length - 1).Split(New Char() {","})
                        Dim splitedPIC_Nama As String() = row("PIC").ToString.Trim().Remove(row("PIC").ToString.Length - 1).Split(New Char() {","})
                        Dim x As Integer = 0
                        For Each nik In splitedPIC
                            lblstatus.Text = "Saving Sub Detail Data"
                            SubDetail.id = 0
                            SubDetail.headerid = row("DetailRowID")
                            SubDetail.NIK = nik
                            SubDetail.NamaPIC = splitedPIC_Nama(x)
                            SubDetail.TX = TRX()
                            DaftarNotulen.Add_SubDetail(SubDetail)
                            x += 1
                        Next
                    End If
                End If
                o += 1
            Next
            Scope.Complete()
            lblstatus.Text = "All Commiting Done"
            Scope.Dispose()
            Me.Cursor = Cursors.Default

            Dim DS As DataSet = DaftarNotulen.GetLastMeeting(cboTopik.Text)
            Dim NoTransaksi As String = ""
            If DS.Tables(0).Rows.Count > 0 Then
                'Get hire
                NoTransaksi = DS.Tables(0).Rows(0)(0)
                lblstatus.Text = "Begin Sending Email Reminding"
            End If

            Dim NotulenData As DataSet = DaftarNotulen.GetPICContact(NoTransaksi)
            If NotulenData.Tables(0).Rows.Count > 0 Then
                Dim x As Integer = 0
                lblstatus.Text = "Sending Email"
                For Each xrow In NotulenData.Tables(0).Rows
                    Try
                        SendEmail(NoTransaksi, xrow("Email"), x)
                    Catch ex As Exception
                        lblstatus.Text = "Error Sending : " & ex.Message.ToString
                    End Try
                    x += 1
                Next
            End If
            MessageBox.Show("Data Berhasil Diproses !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblstatus.Text = "All Done!"
            _Saved = Saved.Saved
            ResetForm()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Scope.Dispose()
            MessageBox.Show("Sistem Gagal Melakukan Pemrosesan Data ! " + vbCrLf +
                                   ex.Message, "Peringatan Row " + o.ToString, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            _Saved = Saved.NSaved
            GoTo Jump
        End Try
Jump:

    End Sub
    Private Sub CalcelInput()
        Dim Notulen As New NotulenModels(ActiveSession)
        Dim Exec = Notulen.DeletePeserta(txtNoNotulen.Text)
    End Sub
    Private Sub EpsDataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles GridNotulen.CellPainting
        If GridNotulen.Rows.Count > 1 Then
            If e.RowIndex = 0 Then
                If (GridNotulen.Rows(e.RowIndex).Cells(HeaderID_).Value.ToString() = GridNotulen.Rows(e.RowIndex + 1).Cells(HeaderID_).Value.ToString()) Then
                    If (e.ColumnIndex = Problem_) Then
                        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
                    End If
                End If
            End If

            If e.RowIndex > 0 Then
                If e.RowIndex < GridNotulen.Rows.Count - 1 Then
                    If (GridNotulen.Rows(e.RowIndex - 1).Cells(HeaderID_).Value.ToString() = GridNotulen.Rows(e.RowIndex).Cells(HeaderID_).Value.ToString()) Then
                        If (e.ColumnIndex = Problem_) Then
                            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
                        End If
                    End If

                    If (GridNotulen.Rows(e.RowIndex).Cells(HeaderID_).Value.ToString() = GridNotulen.Rows(e.RowIndex + 1).Cells(HeaderID_).Value.ToString()) Then
                        If (e.ColumnIndex = Problem_) Then
                            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
                        End If
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub tmrjam_Tick(sender As Object, e As EventArgs) Handles tmrjam.Tick

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        _StartEnd = StartEnd.Start
        lblJamStart.Text = Now.ToString("HH:mm:ss")
        LblJamEnd.Text = ""
        cmdStart.Enabled = False
        cboEnd.Enabled = True
        cmdAddProblem.Enabled = True
        cmdAddFU.Enabled = True
        cmdDelete.Enabled = True
    End Sub

    Private Sub cboEnd_Click(sender As Object, e As EventArgs) Handles cboEnd.Click
        _StartEnd = StartEnd.Selesai
        LblJamEnd.Text = Now.ToString("HH:mm:ss")
        cmdStart.Enabled = False
        cboEnd.Enabled = False
        TimerDone()
    End Sub

    Private Sub cmdPeserta_Click(sender As Object, e As EventArgs) Handles cmdPeserta.Click
        Dim Form As New FrmDaftarPeserta(txtNoNotulen.Text)
        Form.ShowDialog()

        If Form._Success Then
            GetPesertaCount()
        End If
    End Sub

    Private Sub Data_Change(sender As Object, e As EventArgs) Handles cboTopik.SelectedIndexChanged, JmlPeserta.TextChanged, GridNotulen.RowsAdded, cboNotulen.SelectedIndexChanged, cbostatus.SelectedIndexChanged
        Dim ObjectName As String = sender.Name.ToString().Trim()

        If ObjectName = "cboTopik" And cboTopik.SelectedIndex <> -1 Then
            GetInformation()
            lblstatus.Text = "Ready"
        End If
        Dim Periode As String = ""
        Dim DS As DataSet = New DaftarMetting(ActiveSession).Read(cboTopik.Text)
        If DS.Tables(0).Rows.Count > 0 Then
            Periode = DS.Tables(0).Rows(0)(0)
        End If
        If ObjectName = "cbostatus" And GridNotulen.Rows.Count > 0 And Periode <> "InCase" Then
            GetLastNotulen(cbostatus.Text)
        End If
Jump:
        SetEnableCommand()
    End Sub

    Private Sub cmdAddProblem_Click(sender As Object, e As EventArgs) Handles cmdAddProblem.Click
        _Order = 0
        _SaveMode = enumSaveMode.AddMode
        Dim Form As New frmProblem()
        Form.ShowDialog()
        If Form._Success = True Then
            _Problem = Form._Problem
            _Status = Form._Status
            _Table = "Header"
            InsertData()
            ShowData()
        End If
    End Sub

    Private Sub cmdAddFU_Click(sender As Object, e As EventArgs) Handles cmdAddFU.Click
        _SaveMode = enumSaveMode.AddMode
        If GridNotulen.Rows.Count > 0 Then
            HeaderRowID = GridNotulen(RowID_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
            Dim Order = GridNotulen(Order_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
            Dim OrderDetail = getMaxOrderDetail()
            If HeaderRowID = "" Then
                MessageBox.Show("Silahkan Pilih Problem atau masalah terlebih dahulu")
                GoTo GoEnd
            End If
            Dim Form As New frmFollowUp(HeaderRowID, Order, OrderDetail)
            'MessageBox.Show(HeaderRowID)
            Form.ShowDialog()
            If Form._Success = True Then
                '_FU = Form._FollowUp
                '_DateStart = Form._Startdate
                '_DateEnd = Form._EndDate
                '_Table = "Detail"
                For Each xRow In Form.Data.Tables(0).Rows
                    Dim DR As DataRow = Data.Tables(0).NewRow
                    DR("Table") = "D"
                    DR("Order") = xRow("Order")
                    DR("DetailRowID") = xRow("DetailRowID")
                    DR("HeaderID") = xRow("HeaderID")
                    DR("OrderDetail") = xRow("OrderDetail")
                    DR("FU") = xRow("FU")
                    DR("Startdate") = xRow("Startdate")
                    DR("EndDate") = xRow("EndDate")
                    DR("PIC") = xRow("PIC")
                    DR("PIC_Nik") = xRow("PIC_Nik")
                    Data.Tables(0).Rows.Add(DR)
                Next
                ShowData()
            End If
GoEnd:
        End If
    End Sub

    Private Sub GridNotulen_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridNotulen.CellMouseDoubleClick
        _SaveMode = enumSaveMode.EditMode
        If _StartEnd = StartEnd.Start Then
            SendKeys.Send("{ESC}")
            Dim x = GridNotulen.CurrentRow.Index
            If GridNotulen(RowID_, GridNotulen.CurrentCell.RowIndex).Value.ToString() <> "" Then

                Dim EProblem = GridNotulen(Problem_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                Dim EStatus = GridNotulen(Status_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                Dim EOrder = GridNotulen(Order_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                HeaderRowID = GridNotulen(HeaderID_, GridNotulen.CurrentCell.RowIndex).Value.ToString()

                Dim Form As New frmProblem(EProblem, EStatus, EOrder)
                Form.ShowDialog()
                If Form._Success = True Then
                    GridNotulen.Rows.Remove(GridNotulen.Rows(x))

                    _Problem = Form._Problem
                    _Status = Form._Status
                    _Order = Form._Order
                    _Table = "Header"
                    InsertData()
                    ShowData()

                End If
            Else
                Dim EFU = GridNotulen(FU_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                Dim EStartDate = GridNotulen(Startdate_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                Dim EEndDate = GridNotulen(EndDate_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                Dim EOrder = GridNotulen(Order_, GridNotulen.CurrentCell.RowIndex).Value.ToString()
                Dim EOrderDetail = GridNotulen(OrderDetail_, GridNotulen.CurrentCell.RowIndex).Value.ToString
                Dim EPIC = GridNotulen(PICNik_, GridNotulen.CurrentCell.RowIndex).Value.ToString
                DetailRowID = GridNotulen(DetailRowID_, GridNotulen.CurrentCell.RowIndex).Value.ToString

                Dim Form As New frmFollowUp(EFU, EStartDate, EEndDate, EPIC, EOrder, EOrderDetail)
                Form.ShowDialog()
                If Form._Success = True Then
                    GridNotulen.Rows.Remove(GridNotulen.Rows(x))
                    _FU = Form._FollowUp
                    _DateStart = Form._Startdate
                    _DateEnd = Form._EndDate
                    _Order = Form._Order
                    _OrderDetail = Form._OrderDetail
                    _PIC = Form._PICNama
                    _PICNIK = Form._PICNik
                    _Table = "Detail"
                    InsertData()
                    ShowData()

                End If
            End If
        Else
            MessageBox.Show("Meeting Belum diMulai")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If GridNotulen.Rows.Count > 0 Then
            Dim x = GridNotulen.CurrentRow.Index

            GridNotulen.Rows.Remove(GridNotulen.Rows(x))
            ShowData()
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btClose.Click, btSave.Click
        If _StartEnd = StartEnd.Selesai Then
            Select Case DirectCast(sender, Button).Name
                Case "btSave"
                    SaveData()
                Case "btClose"
                    If _Saved = Saved.Saved Then
                        Me.Close()
                    Else
                        Dim Result As DialogResult = MessageBox.Show("Apakah data akan di simpan ?", "Question", MessageBoxButtons.YesNo)
                        If Result = DialogResult.OK Then
                            SaveData()
                        Else
                            CalcelInput()
                            Me.Close()
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub cbostatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostatus.SelectedIndexChanged
        GetLastNotulen(cbostatus.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SendEmail("aji.wibowo@hardosoloplast.co.id", 0)
    End Sub
End Class