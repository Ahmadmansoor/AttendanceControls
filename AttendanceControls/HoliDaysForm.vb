Public Class HoliDaysForm
    Dim Addvalue As Boolean = False
    Private Sub HolidayTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HolidayTableBindingNavigatorSaveItem.Click
        If (DateDayTextBox.Text = "" And Addvalue = True) Then
            MsgBox("Enter value for date")
            Exit Sub
        End If
        Try
            Me.Validate()
            Me.HolidayTableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MonthlySalaryDataSet)
            MsgBox("Done")
            Me.HolidayTableTableAdapter.Fill(Me.MonthlySalaryDataSet.HolidayTable)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub HoliDaysForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MonthlySalaryDataSet.HolidayTable' table. You can move, or remove it, as needed.
        Me.HolidayTableTableAdapter.Fill(Me.MonthlySalaryDataSet.HolidayTable)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateDayTextBox.Text = DateTimePicker1.Value

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Addvalue = True
    End Sub
End Class