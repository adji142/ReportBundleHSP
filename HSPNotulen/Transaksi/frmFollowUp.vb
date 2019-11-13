Imports HSPNotulen.HSP.Data
Imports Enerzie.EPSGridControls.EPSTableEdit
Imports Microsoft.Win32

Imports System.Text.RegularExpressions

Public Class frmFollowUp
    Public _ID As String
    Public _Order As Integer
    Public _OrderDetail As Integer
    Public _Success As Boolean
    Public _FollowUp As String
    Public _Startdate As Date
    Public _EndDate As Date
    Public _PICNik As String
    Public _PICNama As String
    Private _DR As DataRow
    Public Data As DataSet
    Private Enum enumSaveMode
        AddMode = 1
        EditMode = 2
    End Enum
    Private _SaveMode As enumSaveMode
    Private DetailRowID As String
    Private SubDetailRowID As String
    Dim DetailOrderCount = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ID As String)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
    End Sub
    Public Sub New(ByVal ID As String, ByVal Order As Integer, ByVal OrderDetail As Integer)
        Me.New()
        Me.Tag = Me.Text
        _ID = ID
        _Order = Order
        _OrderDetail = OrderDetail
    End Sub

    Public Sub New(ByVal FollowUp As String, ByVal StartDate As Date, ByVal EndDate As Date, PIC As String, ByVal Order As Integer, ByVal OrderDetail As Integer)
        Me.New()
        _FollowUp = FollowUp
        _Startdate = StartDate
        _EndDate = EndDate
        _Order = Order
        _OrderDetail = OrderDetail
        _PICNik = PIC
        _SaveMode = enumSaveMode.EditMode
    End Sub
    Private Sub ResetForm()
        _SaveMode = enumSaveMode.AddMode
        txtFollowup.Text = ""

        Dim Row = GridUser.GridLastRow
        'If Row <> 0 Then
        '    Row = GridUser.GridLastRow - 1
        '    For x = 0 To Row
        '        GridUser.GridValue(0, x) = ""
        '        GridUser.GridValue(1, x) = ""
        '    Next
        'End If
        If _FollowUp <> "" Then
            _SaveMode = enumSaveMode.EditMode
        End If
        SetEnableCommand()
        btSave.Enabled = False
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub Generate_Dataset()
        Data = New DataSet
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
        Table.Columns.Add("Startdate")
        Table.Columns.Add("EndDate")
        Table.Columns.Add("Status")
        Table.Columns.Add("PIC_Nik")

        Data.Tables.Add(Table)
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtFollowup.Text = "", False, True) And _
            If(GridUser.GridLastRow = 0, False, True)
        If _SaveMode = enumSaveMode.AddMode Then
            Me.Text = Me.Tag + " | ** Data Baru **"
        Else
            Me.Text = Me.Tag + " | ** Edit Data **"
        End If
    End Sub
    Private Sub SetColumnHeader()
        GridUser.BorderStyle = Windows.Forms.BorderStyle.None
        GridUser.Rows = 4
        GridUser.HeadersVisualStyles = True
        GridUser.AlternatingDataGridBackColor = Color.White

        GridUser.AddColumnHeader("NIK", 35, 35, GridColumnStyle.csInputWithLookup, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.AddColumnHeader("Nama", 45, 45, GridColumnStyle.csFixed, GridColumnType.ctText, GridColumnAlignment.caLeft, True)
        GridUser.ShowHeader()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btClose.Click, btSave.Click
        Select Case DirectCast(sender, Button).Name
            Case "btSave"
                _Success = True
                '_FollowUp = txtFollowup.Text
                '_Startdate = txtStartdate.Value.Date
                '_EndDate = txtEndDate.Value.Date
                'Me.Close()

                ' Proses Peserta
                Dim PICNik As String
                Dim PICNama As String
                For Row = 0 To GridUser.GridLastRow - 1
                    PICNik += GridUser.GridValue(0, Row).ToString + ","
                    PICNama += GridUser.GridValue(1, Row).ToString + ","
                Next
                ' End Proses peserta
                DetailOrderCount = DetailOrderCount + 1
                DetailRowID = System.Guid.NewGuid.ToString
                'Do This
                If _SaveMode = enumSaveMode.AddMode Then

                    Dim DR As DataRow = Data.Tables(0).NewRow
                    DR("Table") = "D"
                    DR("Order") = _Order
                    DR("DetailRowID") = DetailRowID
                    DR("HeaderID") = _ID
                    DR("OrderDetail") = _OrderDetail
                    DR("FU") = txtFollowup.Text
                    DR("Startdate") = txtStartdate.Value.Date
                    DR("EndDate") = txtEndDate.Value.Date
                    DR("PIC") = PICNama
                    DR("PIC_Nik") = PICNik
                    Data.Tables(0).Rows.Add(DR)
                    ResetForm()
                Else
                    _FollowUp = txtFollowup.Text
                    _Startdate = txtStartdate.Value.Date
                    _EndDate = txtEndDate.Value.Date
                    _PICNik = PICNik
                    _PICNama = PICNama
                    Me.Close()
                End If
                ' Save Triger
            Case "btClose"
                If Data.Tables(0).Rows.Count > 0 Then
                    _Success = True
                End If
                Me.Close()
        End Select
    End Sub
    Private Function getMaxOrder() As Integer
        Dim maxVal As Integer = 0
        If Data.Tables(0).Rows.Count > 0 Then
            For Each xd In Data.Tables(0).Rows
                Dim curentVal As Integer
                curentVal = xd("OrderDetail")
                If curentVal > maxVal Then
                    maxVal = curentVal
                End If
            Next
        Else
            maxVal = 0
        End If
        Return maxVal + 1

    End Function

    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                     txtFollowup.TextChanged,GridUser.Validated
        SetEnableCommand()
    End Sub

    Private Sub frmFollowUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
        Generate_Dataset()
        SetColumnHeader()
    End Sub
    Private Sub GridUser_GridCellLookup(Col As Integer, Row As Integer) Handles GridUser.GridCellLookup
        Dim DaftarKry As IDataLookup = New DaftarHRKaryawan()
        Dim Parameter() As String = {DaftarHRKaryawan.enumLookupKaryawan.DaftarKaryawan, "", ""}

        Dim Form As New frmLookup(DaftarKry, Parameter)
        Form.Text = "Lookup Karyawan"
        Form.ShowDialog()

        If Form.IDLookup Then
            GridUser.SetGridCellLookupResult(Col, Row, Form.IDLookup)
            Dim NIK As String = GridUser.GridValue(0, Row)

            Dim DaftarKaryawan As New DaftarHRKaryawan()
            Dim ListKaryawan As HRKaryawan = DaftarKaryawan.FindKaryawan(NIK)

            If Not IsNothing(ListKaryawan) Then
                GridUser.SetGridCellLookupResult(1, Row, ListKaryawan.NamaKaryawan)
                GridUser.Focus()
                SendKeys.Send("{ENTER}")
            Else
                MessageBox.Show(NIK + "Tidak Valid")
            End If

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ResetForm()
    End Sub

    Private Sub frmFollowUp_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If _FollowUp <> "" Then
            txtFollowup.Text = _FollowUp
            txtStartdate.Value = _Startdate
            txtEndDate.Value = _EndDate
            'excec PIC
            Dim splitedPIC As String() = _PICNik.Split(New Char() {","})
            Dim rowx As Integer = 0

            For Each sp In splitedPIC
                GridUser.GridValue(0, rowx) = sp
                Dim DaftarKaryawan As New DaftarHRKaryawan()
                Dim ListKaryawan As HRKaryawan = DaftarKaryawan.FindKaryawan(sp)

                If Not IsNothing(ListKaryawan) Then
                    GridUser.SetGridCellLookupResult(1, rowx, ListKaryawan.NamaKaryawan)
                    GridUser.Focus()
                    SendKeys.Send("{ENTER}")
                Else
                    MessageBox.Show(sp + "Tidak Valid")
                End If

                rowx += 1
            Next
        End If
        If _OrderDetail = 0 Then
            _OrderDetail = getMaxOrder()
        End If

    End Sub
End Class