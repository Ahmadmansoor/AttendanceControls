Imports Microsoft.Reporting.WinForms

Public Class MonthlySalary
    Private Sub UsersTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MonthlySalaryDataSet)

    End Sub

    Private Sub MonthlySalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MonthlySalaryDataSet.AttendanceTable' table. You can move, or remove it, as needed.
        'Me.AttendanceTableTableAdapter.Fill(Me.MonthlySalaryDataSet.AttendanceTable)
        'TODO: This line of code loads data into the 'MonthlySalaryDataSet.VariableTable' table. You can move, or remove it, as needed.
        Me.VariableTableTableAdapter.Fill(Me.MonthlySalaryDataSet.VariableTable)
        'TODO: This line of code loads data into the 'MonthlySalaryDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.MonthlySalaryDataSet.UsersTable)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Bu_Get_Click(sender As Object, e As EventArgs) Handles Bu_Get.Click
        Me.AttendanceTableTableAdapter.FillBy_UserMonthly(Me.MonthlySalaryDataSet.AttendanceTable, CB_Year.Text, CB_Month.SelectedIndex + 1, UserIDTextBox.Text)
        FillDGV()
    End Sub
    Sub FillDGV()
        Dim InUser, OutUser, TotalLate As TimeSpan

        For i = 0 To AttendanceTableDataGridView.RowCount - 1
            InUser = AttendanceTableDataGridView.Rows(i).Cells(5).Value
            OutUser = AttendanceTableDataGridView.Rows(i).Cells(6).Value
            AttendanceTableDataGridView.Rows(i).Cells(4).Value = WeekdayName(Weekday(AttendanceTableDataGridView.Rows(i).Cells(3).Value))
            Dim MorningLValue As TimeSpan = MorningLateCalc(InUser)
            Dim EvningLValue As TimeSpan = evningLateCalc(OutUser)
            If (AttendanceTableDataGridView.Rows(i).Cells(4).Value <> "Saturday" And AttendanceTableDataGridView.Rows(i).Cells(4).Value <> "Friday") Then
                AttendanceTableDataGridView.Rows(i).Cells(7).Value = MorningLValue.ToString
                If (MorningLValue.Hours > 0) Then AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                AttendanceTableDataGridView.Rows(i).Cells(8).Value = EvningLValue.ToString
                If (EvningLValue.Hours = 0 And EvningLValue.Minutes = 30) Then
                    AttendanceTableDataGridView.Rows(i).Cells(9).Value = EvningLValue.Add(MorningLValue)
                    AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                ElseIf (OutUser.Hours = 0 And OutUser.Minutes = 0 And OutUser.Seconds = 0) Then 'here he didn't punsh
                    AttendanceTableDataGridView.Rows(i).Cells(9).Value = 9
                    AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                ElseIf (MorningLValue.Hours > 0) Then
                    AttendanceTableDataGridView.Rows(i).Cells(9).Value = EvningLValue.Add(MorningLValue)
                    AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                Else
                    AttendanceTableDataGridView.Rows(i).Cells(9).Value = 0
                End If
            Else
                AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                AttendanceTableDataGridView.Rows(i).Cells(9).Value = 0
            End If
            TotalLate = TotalLate.Add(TimeSpan.Parse(AttendanceTableDataGridView.Rows(i).Cells(9).Value.ToString))
        Next
        TB_TotalLate.Text = TotalLate.ToString
        DayAbsentCalc()
    End Sub
    Function MorningLateCalc(ByVal MTime As TimeSpan) As TimeSpan
        Dim AllowTime As TimeSpan = TimeSpan.Parse(MorningTimeRoundTextBox.Text)
        Dim tempTime As TimeSpan = New TimeSpan(0, 0, 0)
        If (MTime.Hours = 8 And MTime.Minutes > 23) Then
            tempTime = New TimeSpan(1, 0, 0)
            Return tempTime
        ElseIf (MTime.Hours = 9 Or MTime.Hours = 10) Then
            tempTime = New TimeSpan(2, 0, 0)
            Return tempTime
        ElseIf (MTime.Hours >= 10 And MTime.Hours <= 15) Then
            tempTime = New TimeSpan(4, 0, 0)
            Return tempTime
        ElseIf (MTime.Hours > 15) Then
            tempTime = New TimeSpan(9, 0, 0)
            Return tempTime
        End If
    End Function
    Function evningLateCalc(ByVal ETime As TimeSpan) As TimeSpan
        Dim tempTime As TimeSpan = New TimeSpan(0, 0, 0)
        If (ETime.Hours = 17 And ETime.Minutes < 59) Then
            tempTime = New TimeSpan(0, 30, 0)
            Return tempTime
        ElseIf (ETime.Hours = 0) Then
            tempTime = New TimeSpan(9, 0, 0)
        End If
    End Function

    Private Sub AttendanceTableDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AttendanceTableDataGridView.ColumnHeaderMouseClick
        Try
            FillDGV()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TB_monthSalary_TextChanged(sender As Object, e As EventArgs) Handles TB_monthSalary.TextChanged
        If IsNumeric(TB_monthSalary.Text) Then
            TB_DaySalary.Text = Math.Round(TB_monthSalary.Text / 22, 2)
            TB_HourSalary.Text = Math.Round(TB_DaySalary.Text / 9, 2)
            If (TB_TotalLate.Text <> "") Then
                Dim TotaoLateMin As TimeSpan = TimeSpan.Parse(TB_TotalLate.Text)
                If (TB_monthSalary.Text <> "") Then
                    Dim Salarybymin As Double = TB_HourSalary.Text / 60
                    Dim totalmin As Double = TotaoLateMin.TotalMinutes + ((TB_DayAbsent.Text * 9) * 60)
                    TB_Money.Text = Salarybymin * totalmin
                End If
            End If

        Else
            MsgBox("Enter number pls !!", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub DayAbsentCalc()
        LB_DayAbsent.Items.Clear()
        Dim daysinMonth As Integer = System.DateTime.DaysInMonth(CB_Year.Text, CB_Month.SelectedIndex + 1)
        Dim Countdays As Integer = 0
        For i = 1 To daysinMonth
            Dim daydate As Date = New Date(CB_Year.Text, CB_Month.SelectedIndex + 1, i)
            Dim dayname As String = WeekdayName(Weekday(daydate))
            If (dayname <> "Saturday" And dayname <> "Friday") Then
                Dim CheckUserPrisent = AttendanceTableTableAdapter.GetDataBy_CheckUserPresnt(CB_Year.Text, CB_Month.SelectedIndex + 1, UserIDTextBox.Text, i)
                If Not (CheckUserPrisent.Any) Then
                    LB_DayAbsent.Items.Add(daydate & ":" & WeekdayName(Weekday(daydate)))
                    Countdays = Countdays + 1
                End If
            End If
        Next
        TB_DayAbsent.Text = Countdays
    End Sub

    Private Sub TB_DayAbsent_TextChanged(sender As Object, e As EventArgs) Handles TB_DayAbsent.TextChanged
        Dim TotaoLateMin As TimeSpan = TimeSpan.Parse(TB_TotalLate.Text)
        If (TB_monthSalary.Text <> "") Then
            Dim Salarybymin As Double = TB_HourSalary.Text / 60
            Dim totalmin As Double = TotaoLateMin.TotalMinutes + ((TB_DayAbsent.Text * 9) * 60)
            TB_Money.Text = Salarybymin * totalmin
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myAL As New ArrayList()
        Dim row As List(Of String)
        For i As Integer = 0 To AttendanceTableDataGridView.RowCount() - 1
            row = New List(Of String)
            For j As Integer = 0 To AttendanceTableDataGridView.ColumnCount() - 1
                row.Add(AttendanceTableDataGridView.Rows(i).Cells(j).ToString)
            Next j
            myAL.Add(row)
        Next i
        Dim bs = New BindingSource(AttendanceTableDataGridView.DataSource)
        Dim dt As DataTable = New DataTable(bs.DataSource)
        Dim rv As New ReportViewer
        Dim rds As ReportDataSource = New ReportDataSource("test", dt)
        'ReportViewer1.LocalReport.DataSources.Clear()
        'ReportViewer1.LocalReport.DataSources.Add(rds)
        'ReportViewer1.LocalReport.Refresh()
        'Dim Params(0) As ReportParameter
        'Params(0) = New ReportParameter("Ref", CType(myAL.ToArray(GetType(String)), String()))
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class