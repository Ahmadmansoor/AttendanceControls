Public Class UsersInfos
    Private Sub UsersTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CancelUsersDataSet)

    End Sub

    Private Sub UsersInfos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UserInfos' table. You can move, or remove it, as needed.
        Me.UserInfosTableAdapter.Fill(Me.CancelUsersDataSet.UserInfos)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UserInfos' table. You can move, or remove it, as needed.
        Me.UserInfosTableAdapter.Fill(Me.CancelUsersDataSet.UserInfos)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.CancelUsersDataSet.UsersTable)

    End Sub

    Private Sub Bu_Add_Click(sender As Object, e As EventArgs) Handles Bu_Add.Click
        Dim s = UserInfosTableAdapter.GetDataBy_UserID(UserIDTextBox.Text)
        If (s.Any) Then
            MsgBox("you can't add more info", MsgBoxStyle.OkOnly, "Error")
        Else
            UserInfosBindingSource.AddNew()
            UserIDTextBox1.Text = UserIDTextBox.Text
            UserNameTextBox.Text = UsernameComboBox.Text

        End If
    End Sub

    Private Sub Bu_Cancel_Click(sender As Object, e As EventArgs) Handles Bu_Cancel.Click
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UserInfos' table. You can move, or remove it, as needed.
        Me.UserInfosTableAdapter.Fill(Me.CancelUsersDataSet.UserInfos)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UserInfos' table. You can move, or remove it, as needed.
        Me.UserInfosTableAdapter.Fill(Me.CancelUsersDataSet.UserInfos)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.CancelUsersDataSet.UsersTable)
    End Sub

    Private Sub Bu_Save_Click(sender As Object, e As EventArgs) Handles Bu_Save.Click
        Try
            Me.Validate()
            UserInfosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CancelUsersDataSet)
            MsgBox("Done")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class