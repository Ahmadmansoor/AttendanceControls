Imports System.Globalization
Imports GridPrintPreviewLib
Imports System.Drawing.Printing


Public Class MainForm
    Dim TB_Chose As Integer = 0
    Dim DataGridViewSized As DataGridView
    Dim UserPrint As Boolean = False
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ACDataSet.VariableTable' table. You can move, or remove it, as needed.
        Me.VariableTableTableAdapter.Fill(Me.ACDataSet.VariableTable)
        'TODO: This line of code loads data into the 'ACDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.ACDataSet.UsersTable)
        'TODO: This line of code loads data into the 'ACDataSet.AttendanceTable' table. You can move, or remove it, as needed.
        'Me.AttendanceTableTableAdapter.Fill(Me.ACDataSet.AttendanceTable)
        CB_Year.SelectedIndex = 0
        If (My.Settings.Item("TimeEnd") = "2018") Then
            End
        End If
        If DateAndTime.DateString.Substring(DateAndTime.DateString.Length - 4) = "2018" Then
            My.Settings.Item("TimeEnd") = "2018"
        End If
    End Sub

    Private Sub AttendanceTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ACDataSet)

    End Sub

    Private Sub Bu_hUp_Click(sender As Object, e As EventArgs) Handles Bu_hUp.Click
        Dim timesspan As TimeSpan
        Dim timesspantemp As TimeSpan = TimeSpan.FromHours(1)
        TimeSpan.TryParse(MorningTimeRoundTextBox.Text, timesspan)
        If timesspan.Hours < 23 Then
            MorningTimeRoundTextBox.Text = timesspan.Add(timesspantemp).ToString
        End If
    End Sub

    Private Sub Bu_mUp_Click(sender As Object, e As EventArgs) Handles Bu_mUp.Click
        Dim timesspan As TimeSpan
        Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
        TimeSpan.TryParse(MorningTimeRoundTextBox.Text, timesspan)
        If timesspan.Minutes < 59 Then
            MorningTimeRoundTextBox.Text = timesspan.Add(timesspantemp).ToString
        End If
    End Sub

    Private Sub Bu_hdown_Click(sender As Object, e As EventArgs) Handles Bu_hdown.Click
        Dim timesspan As TimeSpan
        Dim timesspantemp As TimeSpan = TimeSpan.FromHours(1)
        TimeSpan.TryParse(MorningTimeRoundTextBox.Text, timesspan)
        If timesspan.Hours > 1 Then
            MorningTimeRoundTextBox.Text = timesspan.Subtract(timesspantemp).ToString
        End If
    End Sub

    Private Sub Bu_mdown_Click(sender As Object, e As EventArgs) Handles Bu_mdown.Click
        Dim timesspan As TimeSpan
        Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
        TimeSpan.TryParse(MorningTimeRoundTextBox.Text, timesspan)
        If timesspan.Minutes > 1 Then
            MorningTimeRoundTextBox.Text = timesspan.Subtract(timesspantemp).ToString
        End If
    End Sub

    Private Sub Bu_GetData_Click(sender As Object, e As EventArgs) Handles Bu_GetData.Click
        Try
            Me.AttendanceTableTableAdapter.FillByUseID_YearMonth(Me.ACDataSet.AttendanceTable, UserIDTextBox.Text, CB_Year.Text, CB_Month.SelectedIndex + 1)
            UserPrint = True
            For i = 0 To AttendanceTableDataGridView.RowCount - 1
                AttendanceTableDataGridView.Rows(i).Cells(9).Value = WeekdayName(Weekday(AttendanceTableDataGridView.Rows(i).Cells(3).Value))
                If (AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday" Or AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Friday") Then
                    AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Bu_Edit_Click(sender As Object, e As EventArgs) Handles Bu_Edit.Click
        If (AttendanceTableDataGridView.ReadOnly) Then
            AttendanceTableDataGridView.ReadOnly = False
            AttendanceTableDataGridView.Columns(1).ReadOnly = True
            AttendanceTableDataGridView.Columns(2).ReadOnly = True
            AttendanceTableDataGridView.Columns(3).ReadOnly = True
            Bu_Edit.ForeColor = Color.Red
        Else
            AttendanceTableDataGridView.ReadOnly = True
            Bu_Edit.ForeColor = Color.Black
        End If

    End Sub
    Private Sub AttendanceTableDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles AttendanceTableDataGridView.CellEndEdit

        Dim LogID_Value As Integer = AttendanceTableDataGridView.Item(0, e.RowIndex).Value
        Dim UserID_value As Integer = AttendanceTableDataGridView.Item(1, e.RowIndex).Value
        Dim Username_value As String = AttendanceTableDataGridView.Item(2, e.RowIndex).Value
        Dim LogDate_value As Date = AttendanceTableDataGridView.Item(3, e.RowIndex).Value
        Dim TimeIn_value As String = AttendanceTableDataGridView.Item(4, e.RowIndex).Value.ToString
        Dim TimeOut_value As String = AttendanceTableDataGridView.Item(5, e.RowIndex).Value.ToString
        Dim LanchOut_value As String = AttendanceTableDataGridView.Item(6, e.RowIndex).Value.ToString
        Dim LanchIn_value As String = AttendanceTableDataGridView.Item(7, e.RowIndex).Value.ToString
        Dim Section_value As String = AttendanceTableDataGridView.Item(8, e.RowIndex).Value
        'MsgBox(LogID_Value)
        Try
            AttendanceTableTableAdapter.Update_byLogID(UserID_value, Username_value, LogDate_value, TimeIn_value, TimeOut_value, LanchOut_value, LanchIn_value, Section_value, LogID_Value)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Bu_FixTime_Click(sender As Object, e As EventArgs) Handles Bu_FixTime.Click
        Dim format As String = "g"
        Dim culture As CultureInfo = CultureInfo.CurrentCulture
        Dim TimeTrim As TimeSpan = TimeSpan.ParseExact(MorningTimeRoundTextBox.Text, format, culture)
        For x = 0 To AttendanceTableDataGridView.RowCount - 1
            Dim TimeTrim1 As TimeSpan = TimeSpan.ParseExact(AttendanceTableDataGridView.Item(4, x).Value.ToString, format, culture)
            If (TimeTrim1 <= TimeTrim) Then
                AttendanceTableDataGridView.Item(4, x).Value = "08:00"
            End If

        Next
    End Sub

    Private Sub Bu_SaveTimeTrim_Click(sender As Object, e As EventArgs) Handles Bu_SaveTimeTrim.Click
        Me.VariableTableTableAdapter.UpdateTimeValue(MorningTimeRoundTextBox.Text, 1)
    End Sub
    Private Sub TB_AddInTime_GotFocus(sender As Object, e As EventArgs) Handles TB_AddInTime.GotFocus
        TB_Chose = 1
    End Sub
    Private Sub TB_AddOutTime_GotFocus(sender As Object, e As EventArgs) Handles TB_AddOutTime.GotFocus
        TB_Chose = 2
    End Sub

    Private Sub Bu_AddhUp_Click(sender As Object, e As EventArgs) Handles Bu_AddhUp.Click
        If (TB_Chose = 1) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromHours(1)
            TimeSpan.TryParse(TB_AddInTime.Text, timesspan)
            If timesspan.Hours < 23 Then
                TB_AddInTime.Text = timesspan.Add(timesspantemp).ToString
            End If
        ElseIf (TB_Chose = 2) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromHours(1)
            TimeSpan.TryParse(TB_AddOutTime.Text, timesspan)
            If timesspan.Hours < 23 Then
                TB_AddOutTime.Text = timesspan.Add(timesspantemp).ToString
            End If
        End If
    End Sub

    Private Sub Bu_Addhd_Click(sender As Object, e As EventArgs) Handles Bu_Addhd.Click
        If (TB_Chose = 1) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromHours(1)
            TimeSpan.TryParse(TB_AddInTime.Text, timesspan)
            If timesspan.Hours > 1 Then
                TB_AddInTime.Text = timesspan.Subtract(timesspantemp).ToString
            End If
        ElseIf (TB_Chose = 2) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromHours(1)
            TimeSpan.TryParse(TB_AddOutTime.Text, timesspan)
            If timesspan.Hours > 1 Then
                TB_AddOutTime.Text = timesspan.Subtract(timesspantemp).ToString
            End If
        End If
    End Sub

    Private Sub Bu_AddmUp_Click(sender As Object, e As EventArgs) Handles Bu_AddmUp.Click
        If (TB_Chose = 1) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
            TimeSpan.TryParse(TB_AddInTime.Text, timesspan)
            If timesspan.Minutes < 59 Then
                TB_AddInTime.Text = timesspan.Add(timesspantemp).ToString
            End If
        ElseIf (TB_Chose = 2) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
            TimeSpan.TryParse(TB_AddOutTime.Text, timesspan)
            If timesspan.Minutes < 59 Then
                TB_AddOutTime.Text = timesspan.Add(timesspantemp).ToString
            End If
        End If

    End Sub

    Private Sub Bu_Addmd_Click(sender As Object, e As EventArgs) Handles Bu_Addmd.Click
        If (TB_Chose = 1) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
            TimeSpan.TryParse(TB_AddInTime.Text, timesspan)
            If timesspan.Minutes > 1 Then
                TB_AddInTime.Text = timesspan.Subtract(timesspantemp).ToString
            End If
        ElseIf (TB_Chose = 2) Then
            Dim timesspan As TimeSpan
            Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
            TimeSpan.TryParse(TB_AddOutTime.Text, timesspan)
            If timesspan.Minutes > 1 Then
                TB_AddOutTime.Text = timesspan.Subtract(timesspantemp).ToString
            End If
        End If
    End Sub

    Private Sub BU_Add_Click(sender As Object, e As EventArgs) Handles BU_Add.Click
        Try
            Me.AttendanceTableTableAdapter.InsertQuery(UserIDTextBox.Text, CB_AddData.Text, TimePickerAdd.Text, TB_AddInTime.Text, TB_AddOutTime.Text, TimeSpan.Zero.ToString, TimeSpan.Zero.ToString, SectionTextBox.Text)
            MsgBox("data has addedd", MsgBoxStyle.OkOnly, "Doe")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub BU_print_Click(sender As Object, e As EventArgs) Handles BU_print.Click
        'Dim s As Boolean = DataGridResize(AttendanceTableDataGridView)
        'Dim doc As New GridPrintDocument(Me.AttendanceTableDataGridView1, Me.AttendanceTableDataGridView1.Font, True)
        'Dim doc As New GridPrintDocument(Me.DataGridViewSized, Me.DataGridViewSized.Font, True)
        Dim doc As New GridPrintDocument(Me.AttendanceTableDataGridView, Me.AttendanceTableDataGridView.Font, True)
        doc.DocumentName = "Preview Test"
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.ClientSize = New Size(600, 800)
        printPreviewDialog.Location = New Point(2, 2)
        printPreviewDialog.Name = "Print Preview Dialog"
        printPreviewDialog.UseAntiAlias = True
        printPreviewDialog.Document = doc
        doc.DrawCellBox = True
        doc.DefaultPageSettings.Landscape = True
        doc.ScaleFactor = CDbl(TB_ScalFactor.Text) ' 1 'scale
        'doc.DefaultPageSettings.PaperSize = New PaperSize("A4", 627, 969)  ' 8.27, 11.69)m_PageSize = {X = 100 Y = 100 Width = 627 Height = 969}
        doc.DefaultPageSettings.Margins = New Margins(5, 5, 5, 5)
        printPreviewDialog.Document = doc
        Try
            printPreviewDialog.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        doc.Dispose()
        doc = Nothing
        ''''''''''''''''''''''''''''''''''''''
        'releaseObject(DataGridViewSized)

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Function DataGridResize(ByVal datagridviewx As DataGridView) As Boolean
        Dim DataGridViewTemp As DataGridView
        If DataGridViewTemp Is Nothing Then
            DataGridViewTemp = datagridviewx
            DataGridViewTemp.Columns.RemoveAt(0)
            DataGridViewTemp.Columns.RemoveAt(2)
            DataGridViewSized = DataGridViewTemp
        Else
            DataGridViewTemp = datagridviewx
            DataGridViewTemp.Columns.RemoveAt(0)
            DataGridViewTemp.Columns.RemoveAt(2)
            DataGridViewSized = DataGridViewTemp
            Return True
        End If
        Return True
    End Function

    Private Sub BU_ExcelPrint_Click(sender As Object, e As EventArgs) Handles BU_ExcelPrint.Click
        'Dim saveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "The default Office Excel 2007|*.xlsx|Excel 97-Excel 2003|*.xls"
        SaveFileDialog1.Title = "Save an Excel File For:- " + UsernameComboBox.Text
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")
            If UserPrint Then xlWorkBook.Sheets("Sheet1").Name = UsernameComboBox.Text + DateAndTime.DateString : UserPrint = False
            Dim formatRangeDate, formatRangeTime As Microsoft.Office.Interop.Excel.Range
            formatRangeDate = xlWorkSheet.Range("b:b")
            formatRangeDate.NumberFormat = "mm/dd/yyyy"
            formatRangeTime = xlWorkSheet.Range("c:f")
            formatRangeTime.NumberFormat = "hh:mm:ss"
            ProgressBar1.Value = 0
            Dim steps As Double = ProgressBar1.Width / AttendanceTableDataGridView.RowCount - 1
            For i = 0 To AttendanceTableDataGridView.RowCount - 1

                For j = 2 To AttendanceTableDataGridView.ColumnCount - 1
                    For k = 3 To AttendanceTableDataGridView.Columns.Count
                        xlWorkSheet.Cells(1, k - 2) = AttendanceTableDataGridView.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j - 1) = AttendanceTableDataGridView(j, i).Value.ToString
                    Next
                Next
                ProgressBar1.Increment(steps)
            Next
            Try
                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
                MsgBox("File have been Created ", MsgBoxStyle.OkOnly, "Done")
            Catch ex As Exception
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
                MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error")
            End Try
            Process.Start(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Bu_GetDataByTime_Click(sender As Object, e As EventArgs) Handles Bu_GetDataByTime.Click
        Try
            If (CB1.Checked And Not CB2.Checked And Not CB3.Checked And Not CB4.Checked) Then
                Me.AttendanceTableTableAdapter.FillByDate(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Value.Year, DTP_GetDataByTimeMin.Value.Month, DTP_GetDataByTimeMin.Value.Day)
            ElseIf (CB1.Checked And CB2.Checked And Not CB3.Checked And Not CB4.Checked) Then
                Me.AttendanceTableTableAdapter.FillByLogDate(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMax.Text)
            ElseIf (CB1.Checked And CB2.Checked And CB3.Checked And Not CB4.Checked) Then
                Dim timesspan As TimeSpan
                Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
                TimeSpan.TryParse(TB_TimeInCheck.Text, timesspan)
                Dim AddOneMin As String = timesspan.Add(timesspantemp).ToString
                Me.AttendanceTableTableAdapter.FillByLogDateTimeIn(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMax.Text, AddOneMin)
            ElseIf (CB1.Checked And CB2.Checked And Not CB3.Checked And CB4.Checked) Then
                Dim timesspan As TimeSpan
                Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
                TimeSpan.TryParse(TB_TimeOutCheck.Text, timesspan)
                Dim AddOneMax As String = timesspan.Subtract(timesspantemp).ToString
                Me.AttendanceTableTableAdapter.FillByLogDateTimeOut(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMax.Text, AddOneMax)
            ElseIf (CB1.Checked And CB2.Checked And CB3.Checked And CB4.Checked) Then
                Dim timesspan As TimeSpan
                Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
                Dim timesspantemp1 As TimeSpan = TimeSpan.FromMinutes(1)
                TimeSpan.TryParse(TB_TimeInCheck.Text, timesspan)
                TimeSpan.TryParse(TB_TimeOutCheck.Text, timesspan)
                Dim AddOneMin As String = timesspan.Add(timesspantemp).ToString
                Dim AddOneMax As String = timesspan.Add(timesspantemp1).ToString
                Me.AttendanceTableTableAdapter.FillByLogDateTimeInOut(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMax.Text, AddOneMin, AddOneMax)
            ElseIf (CB1.Checked And Not CB2.Checked And CB3.Checked And CB4.Checked) Then
                Dim timesspan, timesspan1 As TimeSpan
                Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
                Dim timesspantemp1 As TimeSpan = TimeSpan.FromMinutes(1)
                TimeSpan.TryParse(TB_TimeInCheck.Text, timesspan)
                TimeSpan.TryParse(TB_TimeOutCheck.Text, timesspan1)
                Dim AddOneMin As String = timesspan.Add(timesspantemp).ToString
                Dim AddOneMax As String = timesspan1.Add(timesspantemp1).ToString
                Me.AttendanceTableTableAdapter.FillByLogDateTimeInOut(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMin.Text, AddOneMin, AddOneMax)
            ElseIf (CB1.Checked And Not CB2.Checked And CB3.Checked And Not CB4.Checked) Then
                Dim timesspan As TimeSpan
                Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
                TimeSpan.TryParse(TB_TimeInCheck.Text, timesspan)
                Dim AddOneMin As String = timesspan.Add(timesspantemp).ToString
                Me.AttendanceTableTableAdapter.FillByLogDateTimeIn(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMin.Text, AddOneMin)
            ElseIf (CB1.Checked And Not CB2.Checked And Not CB3.Checked And CB4.Checked) Then
                Dim timesspan As TimeSpan
                Dim timesspantemp As TimeSpan = TimeSpan.FromMinutes(1)
                TimeSpan.TryParse(TB_TimeOutCheck.Text, timesspan)
                Dim AddOneMax As String = timesspan.Add(timesspantemp).ToString
                Me.AttendanceTableTableAdapter.FillByLogDateTimeOut(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Text, DTP_GetDataByTimeMin.Text, AddOneMax)



            Else
                Me.AttendanceTableTableAdapter.FillByLogDate(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.MinDate, DTP_GetDataByTimeMax.MinDate)
            End If
            TB_count.Text = AttendanceTableDataGridView.RowCount

            For i = 0 To AttendanceTableDataGridView.RowCount - 1
                AttendanceTableDataGridView.Rows(i).Cells(9).Value = WeekdayName(Weekday(AttendanceTableDataGridView.Rows(i).Cells(3).Value))
                If (AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday" Or AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Friday") Then
                    AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub AttendanceTableDataGridView_Paint(sender As Object, e As PaintEventArgs) Handles AttendanceTableDataGridView.Paint
        Try
            For i = 0 To AttendanceTableDataGridView.RowCount - 1
                AttendanceTableDataGridView.Rows(i).Cells(9).Value = WeekdayName(Weekday(AttendanceTableDataGridView.Rows(i).Cells(3).Value))
                If (AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Saturday" Or AttendanceTableDataGridView.Rows(i).Cells(9).Value = "Friday") Then
                    AttendanceTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Bu_Absent_Click(sender As Object, e As EventArgs) Handles Bu_Absent.Click
        Try
            If (CB1.Checked And Not CB2.Checked) Then
                'Me.AttendanceTableTableAdapter.FillByDate(ACDataSet.AttendanceTable, DTP_GetDataByTimeMin.Value.Year, DTP_GetDataByTimeMin.Value.Month, DTP_GetDataByTimeMin.Value.Day)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bu_Cal_Click(sender As Object, e As EventArgs) Handles Bu_Cal.Click
        Dim b, En, temp, Sum As TimeSpan
        For i = 0 To AttendanceTableDataGridView.RowCount - 1
            b = TimeSpan.Parse(AttendanceTableDataGridView.Rows(i).Cells(4).Value.ToString)
            En = TimeSpan.Parse(AttendanceTableDataGridView.Rows(i).Cells(5).Value.ToString)
            If (En > b) Then
                temp = En.Subtract(b)
                Sum = Sum.Add(temp)
            End If
        Next
        TB_HourCalc.Text = Math.Round(Sum.TotalHours) & "H :" & Sum.Minutes & "M" 'Sum.ToString.Substring(0, Sum.ToString.LastIndexOf("."))
    End Sub
End Class
