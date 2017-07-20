Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class PrintForm
    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Begintime = TimeSpan.Zero, EndTime As TimeSpan = TimeSpan.Zero
        Dim Six As TimeSpan = New TimeSpan(18, 0, 0)
        Dim DaySumHour, TotalSumHour As TimeSpan
        If (ReportPrintDataSet.Tables("AttendancePrintTable").Rows.Count > 0) Then
            ReportPrintDataSet.Tables("AttendancePrintTable").Clear()
        End If
        For i = 0 To MainForm.AttendanceTableDataGridView.RowCount - 1
            Begintime = MainForm.AttendanceTableDataGridView.Rows(i).Cells(4).Value
            EndTime = MainForm.AttendanceTableDataGridView.Rows(i).Cells(5).Value
            If (EndTime.Hours = 18 And EndTime.Minutes >= 30) Or (EndTime.Hours > 18) Or (MainForm.AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday") Then
                If MainForm.AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday" Then
                    DaySumHour = EndTime.Subtract(Begintime)
                Else
                    DaySumHour = EndTime.Subtract(Six)
                End If
                TotalSumHour = TotalSumHour.Add(DaySumHour)
                Dim newRow As DataRow = ReportPrintDataSet.Tables("AttendancePrintTable").NewRow()
                newRow(0) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(0).Value
                newRow(1) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(1).Value
                newRow(2) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(2).Value
                newRow(3) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(3).Value
                newRow(4) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(4).Value
                newRow(5) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(5).Value
                newRow(6) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(6).Value
                newRow(7) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(7).Value
                newRow(8) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(8).Value
                newRow(9) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(9).Value
                newRow(10) = DaySumHour
                ReportPrintDataSet.Tables("AttendancePrintTable").Rows.Add(newRow)
            End If
        Next
        Dim SumHour_Rep As ReportParameter
        SumHour_Rep = New ReportParameter("SumHour", Math.Round(TotalSumHour.TotalHours).ToString & ":" & Math.Round(TotalSumHour.Minutes).ToString)
        ReportViewer1.LocalReport.SetParameters(SumHour_Rep)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_ReportRefresh(sender As Object, e As CancelEventArgs) Handles ReportViewer1.ReportRefresh
        Dim Begintime = TimeSpan.Zero, EndTime As TimeSpan = TimeSpan.Zero
        Dim Six As TimeSpan = New TimeSpan(18, 0, 0)
        Dim DaySumHour, TotalSumHour As TimeSpan
        If (ReportPrintDataSet.Tables("AttendancePrintTable").Rows.Count > 0) Then
            ReportPrintDataSet.Tables("AttendancePrintTable").Clear()
        End If
        For i = 0 To MainForm.AttendanceTableDataGridView.RowCount - 1
            Begintime = MainForm.AttendanceTableDataGridView.Rows(i).Cells(4).Value
            EndTime = MainForm.AttendanceTableDataGridView.Rows(i).Cells(5).Value
            If (EndTime.Hours = 18 And EndTime.Minutes >= 30) Or (EndTime.Hours > 18) Or (MainForm.AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday") Then
                If MainForm.AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday" Then
                    DaySumHour = EndTime.Subtract(Begintime)
                Else
                    DaySumHour = EndTime.Subtract(Six)
                End If
                TotalSumHour = TotalSumHour.Add(DaySumHour)
                Dim newRow As DataRow = ReportPrintDataSet.Tables("AttendancePrintTable").NewRow()
                newRow(0) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(0).Value
                newRow(1) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(1).Value
                newRow(2) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(2).Value
                newRow(3) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(3).Value
                newRow(4) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(4).Value
                newRow(5) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(5).Value
                newRow(6) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(6).Value
                newRow(7) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(7).Value
                newRow(8) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(8).Value
                newRow(9) = MainForm.AttendanceTableDataGridView.Rows(i).Cells(9).Value
                newRow(10) = DaySumHour
                ReportPrintDataSet.Tables("AttendancePrintTable").Rows.Add(newRow)
            End If
        Next
        Dim SumHour_Rep As ReportParameter
        SumHour_Rep = New ReportParameter("SumHour", Math.Round(TotalSumHour.TotalHours).ToString & ":" & Math.Round(TotalSumHour.Minutes).ToString)
        ReportViewer1.LocalReport.SetParameters(SumHour_Rep)
    End Sub
End Class