Public Class CanceledUsers
    Private Sub UsersTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CancelUsersDataSet)

    End Sub

    Private Sub TerminationUsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TerminationUsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TerminationUsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CancelUsersDataSet)

    End Sub

    Private Sub CanceledUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UserInfos' table. You can move, or remove it, as needed.
        Me.UserInfosTableAdapter.Fill(Me.CancelUsersDataSet.UserInfos)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.CancelUsersDataSet.UsersTable)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.TerminationUsers' table. You can move, or remove it, as needed.
        Me.TerminationUsersTableAdapter.Fill(Me.CancelUsersDataSet.TerminationUsers)

    End Sub

    Private Sub Bu_Terminate_Click(sender As Object, e As EventArgs) Handles Bu_Terminate.Click
        If (MsgBox("are you sure ?!", MsgBoxStyle.OkCancel, "confirm") = MsgBoxResult.Ok) Then
            Dim s = TerminationUsersTableAdapter.GetDataBy_UserID(UserIDTextBox1.Text)
            If s.Any Then
                MsgBox("This user already Terminatied", MsgBoxStyle.OkOnly, "Erro")
                Exit Sub
            Else
                TerminationUsersBindingSource.AddNew()
                UsernameTextBox.Text = UsernameComboBox.Text
                JointDateDateTimePicker.Value = JoiningDateDateTimePicker.Value
                UserIDTextBox.Text = UserIDTextBox1.Text
                SectionTextBox.Text = SectionTextBox1.Text
                PasswordTextBox.Text = PasswordTextBox1.Text
                UserLevelTextBox.Text = UserLevelTextBox1.Text
                StampTextBox.Text = StampTextBox1.Text
                Bu_Terminate.Enabled = False
            End If
        End If
    End Sub

    Private Sub Bu_Save_Click(sender As Object, e As EventArgs) Handles Bu_Save.Click
        If (Bu_Terminate.Enabled = False) Then
            Try
                Me.Validate()
                Me.TerminationUsersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.CancelUsersDataSet)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            Try
                UsersTableBindingSource.RemoveCurrent()
                Me.Validate()
                Me.UsersTableBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.CancelUsersDataSet)

            Catch ex1 As Exception
                MsgBox(ex1.Message.ToString)
            End Try

            Bu_Terminate.Enabled = True
            MsgBox("Done")
        Else
            MsgBox("Edit something First", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
    End Sub

    Private Sub Bu_refresh_Click(sender As Object, e As EventArgs) Handles Bu_refresh.Click
        Me.UserInfosTableAdapter.Fill(Me.CancelUsersDataSet.UserInfos)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.CancelUsersDataSet.UsersTable)
        'TODO: This line of code loads data into the 'CancelUsersDataSet.TerminationUsers' table. You can move, or remove it, as needed.
        Me.TerminationUsersTableAdapter.Fill(Me.CancelUsersDataSet.TerminationUsers)
        Bu_Terminate.Enabled = True
    End Sub

    Private Sub Bu_Cancel_Click(sender As Object, e As EventArgs) Handles Bu_Cancel.Click
        If (Bu_Terminate.Enabled = False) Then
            TerminationUsersBindingSource.RemoveCurrent()
            Bu_Terminate.Enabled = True
        Else
            MsgBox("Edit something First", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
    End Sub
End Class