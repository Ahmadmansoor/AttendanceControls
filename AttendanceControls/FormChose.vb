Public Class FormChose
    Private Sub Bu_Attendane_Click(sender As Object, e As EventArgs) Handles Bu_Attendane.Click
        If (Application.OpenForms().OfType(Of MainForm).Any) Then
            Exit Sub
        Else
            MainForm.Show()
            MainForm.Left = Me.Left + Me.Width
            MainForm.Top = Me.Top
        End If
    End Sub

    Private Sub FormChose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 100
        Me.Top = 100
    End Sub

    Private Sub Bu_UserInfos_Click(sender As Object, e As EventArgs) Handles Bu_UserInfos.Click
        If (Application.OpenForms().OfType(Of UsersInfos).Any) Then
            Exit Sub
        Else
            UsersInfos.Show()
            UsersInfos.Left = Me.Left + Me.Width
            UsersInfos.Top = Me.Top
        End If
    End Sub

    Private Sub Bu_CanceledUsers_Click(sender As Object, e As EventArgs) Handles Bu_CanceledUsers.Click
        If (Application.OpenForms().OfType(Of CanceledUsers).Any) Then
            Exit Sub
        Else
            CanceledUsers.Show()
            CanceledUsers.Left = Me.Left + Me.Width
            CanceledUsers.Top = Me.Top
        End If
    End Sub

    Private Sub Bu_Salary_Click(sender As Object, e As EventArgs) Handles Bu_Salary.Click
        If (Application.OpenForms().OfType(Of MonthlySalary).Any) Then
            Exit Sub
        Else
            MonthlySalary.Show()
            MonthlySalary.Left = Me.Left + Me.Width
            MonthlySalary.Top = Me.Top
        End If
    End Sub
End Class