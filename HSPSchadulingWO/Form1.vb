Public Class Form1
    Dim SelectedDate As Date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillMonth(CmbMonthPeriod)
        FillYear(cmbYearPeriod)
    End Sub
    Private Sub Toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub
    Public Sub FillMonth(Control As Object, Optional Start As Integer = 0)
        Dim aMonthName As Object
        Dim nMonth As Integer
        Dim Tgl As Date

        Tgl = Format(DateAdd(DateInterval.Month, -1, Now), "yyyy/MM/dd")

        aMonthName = {"Januari", "Pebruari", "Maret", "April", _
                           "Mei", "Juni", "Juli", "Agustus", _
                           "September", "Oktober", "Nopember", "Desember"}
        Control.Items.Clear()
        For nMonth = 0 To 11
            Control.Items.Add(aMonthName(nMonth))
        Next

        If Start = 0 Then
            Control.SelectedIndex = Month(Tgl)
        Else
            Control.SelectedIndex = Start
        End If
    End Sub
    Public Sub FillYear(Control As Object, Optional Start As Integer = 0, _
                    Optional StepDown As Integer = 3, _
                    Optional StepUp As Integer = 5)
        Dim nYear As Integer
        Dim Tgl As Date

        Tgl = Format(DateAdd(DateInterval.Month, -1, Now), "yyyy/MM/dd")

        Control.Items.Clear()
        For nYear = Year(Tgl) - StepDown To Year(Tgl) + StepUp
            Control.Items.Add(nYear)
        Next

        If Start = 0 Then
            Control.SelectedIndex = StepDown
        Else
            Control.SelectedIndex = Start
        End If
    End Sub
    Private Sub Execute(ByVal ID As String)
        Select Case ID
            Case "btRefresh", "btRefreshCTXM"
                '---------------------------------------------------------------------------------------------------------
                'Do Something hire
                Me.AxCalendar1.Month = CShort(CmbMonthPeriod.ComboBox.SelectedIndex + 1)
                Me.AxCalendar1.Year = CShort(cmbYearPeriod.Text)
                '---------------------------------------------------------------------------------------------------------

        End Select
    End Sub

    Private Sub AxCalendar1_OnDayClick(sender As Object, e As AxCALENDARLib._DCalendarEvents_OnDayClickEvent) Handles AxCalendar1.OnDayClick
        SelectedDate = CStr(cmbYearPeriod.Text) + "-" + CStr(CmbMonthPeriod.SelectedIndex + 1) + "-" + CStr(e.iDay)
        GetWO()
    End Sub

    Private Sub GetWO()
        Me.Cursor = Cursors.WaitCursor
        ViewWO.SuspendLayout()

        Dim WO As New SAPWOList()
        Dim BS As New BindingSource

        Dim DataSet As DataSet = WO.ReadWO(SelectedDate)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        ViewWO.DataSource = BS

        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                ViewWO.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                ViewWO.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ViewWO.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                ViewWO.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                ViewWO.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewWO.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If

            If Column.DataType.Name.ToUpper = "DECIMAL" Then
                ViewWO.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##"
                ViewWO.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ViewWO.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        Me.Cursor = Cursors.Default
        ViewWO.ResumeLayout()
    End Sub
End Class
