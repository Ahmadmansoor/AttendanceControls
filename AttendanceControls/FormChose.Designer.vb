<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChose
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Bu_Attendane = New System.Windows.Forms.Button()
        Me.Bu_UserInfos = New System.Windows.Forms.Button()
        Me.Bu_CanceledUsers = New System.Windows.Forms.Button()
        Me.Bu_Salary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bu_Attendane
        '
        Me.Bu_Attendane.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Bu_Attendane.Location = New System.Drawing.Point(3, 6)
        Me.Bu_Attendane.Name = "Bu_Attendane"
        Me.Bu_Attendane.Size = New System.Drawing.Size(241, 149)
        Me.Bu_Attendane.TabIndex = 0
        Me.Bu_Attendane.Text = "Attendane"
        Me.Bu_Attendane.UseVisualStyleBackColor = True
        '
        'Bu_UserInfos
        '
        Me.Bu_UserInfos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Bu_UserInfos.Location = New System.Drawing.Point(3, 161)
        Me.Bu_UserInfos.Name = "Bu_UserInfos"
        Me.Bu_UserInfos.Size = New System.Drawing.Size(241, 149)
        Me.Bu_UserInfos.TabIndex = 1
        Me.Bu_UserInfos.Text = "Users Info"
        Me.Bu_UserInfos.UseVisualStyleBackColor = True
        '
        'Bu_CanceledUsers
        '
        Me.Bu_CanceledUsers.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Bu_CanceledUsers.Location = New System.Drawing.Point(3, 316)
        Me.Bu_CanceledUsers.Name = "Bu_CanceledUsers"
        Me.Bu_CanceledUsers.Size = New System.Drawing.Size(241, 149)
        Me.Bu_CanceledUsers.TabIndex = 2
        Me.Bu_CanceledUsers.Text = "Cancel Users"
        Me.Bu_CanceledUsers.UseVisualStyleBackColor = True
        '
        'Bu_Salary
        '
        Me.Bu_Salary.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Bu_Salary.Location = New System.Drawing.Point(3, 471)
        Me.Bu_Salary.Name = "Bu_Salary"
        Me.Bu_Salary.Size = New System.Drawing.Size(241, 149)
        Me.Bu_Salary.TabIndex = 3
        Me.Bu_Salary.Text = "Monthly Salary"
        Me.Bu_Salary.UseVisualStyleBackColor = True
        '
        'FormChose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(248, 625)
        Me.Controls.Add(Me.Bu_Salary)
        Me.Controls.Add(Me.Bu_CanceledUsers)
        Me.Controls.Add(Me.Bu_UserInfos)
        Me.Controls.Add(Me.Bu_Attendane)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormChose"
        Me.Text = "FormChose"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bu_Attendane As Button
    Friend WithEvents Bu_UserInfos As Button
    Friend WithEvents Bu_CanceledUsers As Button
    Friend WithEvents Bu_Salary As Button
End Class
