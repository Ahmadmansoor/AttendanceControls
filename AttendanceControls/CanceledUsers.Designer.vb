<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CanceledUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TerminationIDLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim UserLevelLabel As System.Windows.Forms.Label
        Dim StampLabel As System.Windows.Forms.Label
        Dim JointDateLabel As System.Windows.Forms.Label
        Dim TerminationDateLabel As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Dim UserIDLabel1 As System.Windows.Forms.Label
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim SectionLabel1 As System.Windows.Forms.Label
        Dim UserLevelLabel1 As System.Windows.Forms.Label
        Dim StampLabel1 As System.Windows.Forms.Label
        Dim BirthLabel As System.Windows.Forms.Label
        Dim JoiningDateLabel As System.Windows.Forms.Label
        Dim SallaryLabel As System.Windows.Forms.Label
        Dim JoBLabel As System.Windows.Forms.Label
        Dim PassportNumLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim VisaExpiredLabel As System.Windows.Forms.Label
        Dim LaberCardNumLabel As System.Windows.Forms.Label
        Dim LaberCardExpiredLabel As System.Windows.Forms.Label
        Dim MobilephoneLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CanceledUsers))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TerminationIDTextBox = New System.Windows.Forms.TextBox()
        Me.TerminationUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CancelUsersDataSet = New AttendanceControls.CancelUsersDataSet()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.UserLevelTextBox = New System.Windows.Forms.TextBox()
        Me.StampTextBox = New System.Windows.Forms.TextBox()
        Me.JointDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TerminationDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReasonTextBox = New System.Windows.Forms.TextBox()
        Me.TerminationUsersTableAdapter = New AttendanceControls.CancelUsersDataSetTableAdapters.TerminationUsersTableAdapter()
        Me.TableAdapterManager = New AttendanceControls.CancelUsersDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableTableAdapter = New AttendanceControls.CancelUsersDataSetTableAdapters.UsersTableTableAdapter()
        Me.TerminationUsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TerminationUsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UserInfosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoiningDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SallaryTextBox = New System.Windows.Forms.TextBox()
        Me.JoBTextBox = New System.Windows.Forms.TextBox()
        Me.PassportNumTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.VisaExpiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LaberCardNumTextBox = New System.Windows.Forms.TextBox()
        Me.LaberCardExpiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MobilephoneTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Bu_Terminate = New System.Windows.Forms.Button()
        Me.UserIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.UsersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernameComboBox = New System.Windows.Forms.ComboBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.SectionTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserLevelTextBox1 = New System.Windows.Forms.TextBox()
        Me.StampTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserInfosTableAdapter = New AttendanceControls.CancelUsersDataSetTableAdapters.UserInfosTableAdapter()
        Me.Bu_refresh = New System.Windows.Forms.Button()
        Me.Bu_Save = New System.Windows.Forms.Button()
        Me.Bu_Cancel = New System.Windows.Forms.Button()
        TerminationIDLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        UserLevelLabel = New System.Windows.Forms.Label()
        StampLabel = New System.Windows.Forms.Label()
        JointDateLabel = New System.Windows.Forms.Label()
        TerminationDateLabel = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        UserIDLabel1 = New System.Windows.Forms.Label()
        UsernameLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        SectionLabel1 = New System.Windows.Forms.Label()
        UserLevelLabel1 = New System.Windows.Forms.Label()
        StampLabel1 = New System.Windows.Forms.Label()
        BirthLabel = New System.Windows.Forms.Label()
        JoiningDateLabel = New System.Windows.Forms.Label()
        SallaryLabel = New System.Windows.Forms.Label()
        JoBLabel = New System.Windows.Forms.Label()
        PassportNumLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        VisaExpiredLabel = New System.Windows.Forms.Label()
        LaberCardNumLabel = New System.Windows.Forms.Label()
        LaberCardExpiredLabel = New System.Windows.Forms.Label()
        MobilephoneLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TerminationUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelUsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TerminationUsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TerminationUsersBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UserInfosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TerminationIDLabel
        '
        TerminationIDLabel.AutoSize = True
        TerminationIDLabel.Location = New System.Drawing.Point(6, 28)
        TerminationIDLabel.Name = "TerminationIDLabel"
        TerminationIDLabel.Size = New System.Drawing.Size(81, 13)
        TerminationIDLabel.TabIndex = 0
        TerminationIDLabel.Text = "Termination ID:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(6, 53)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(47, 13)
        UserIDLabel.TabIndex = 2
        UserIDLabel.Text = "User ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(158, 28)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(59, 13)
        UsernameLabel.TabIndex = 4
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(166, 229)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(57, 13)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "Password:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(158, 53)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(46, 13)
        SectionLabel.TabIndex = 8
        SectionLabel.Text = "Section:"
        '
        'UserLevelLabel
        '
        UserLevelLabel.AutoSize = True
        UserLevelLabel.Location = New System.Drawing.Point(166, 255)
        UserLevelLabel.Name = "UserLevelLabel"
        UserLevelLabel.Size = New System.Drawing.Size(61, 13)
        UserLevelLabel.TabIndex = 10
        UserLevelLabel.Text = "User Level:"
        '
        'StampLabel
        '
        StampLabel.AutoSize = True
        StampLabel.Location = New System.Drawing.Point(166, 281)
        StampLabel.Name = "StampLabel"
        StampLabel.Size = New System.Drawing.Size(41, 13)
        StampLabel.TabIndex = 12
        StampLabel.Text = "Stamp:"
        '
        'JointDateLabel
        '
        JointDateLabel.AutoSize = True
        JointDateLabel.Location = New System.Drawing.Point(453, 28)
        JointDateLabel.Name = "JointDateLabel"
        JointDateLabel.Size = New System.Drawing.Size(60, 13)
        JointDateLabel.TabIndex = 14
        JointDateLabel.Text = "Joint Date:"
        '
        'TerminationDateLabel
        '
        TerminationDateLabel.AutoSize = True
        TerminationDateLabel.Location = New System.Drawing.Point(453, 57)
        TerminationDateLabel.Name = "TerminationDateLabel"
        TerminationDateLabel.Size = New System.Drawing.Size(93, 13)
        TerminationDateLabel.TabIndex = 16
        TerminationDateLabel.Text = "Termination Date:"
        '
        'ReasonLabel
        '
        ReasonLabel.AutoSize = True
        ReasonLabel.Location = New System.Drawing.Point(6, 82)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(47, 13)
        ReasonLabel.TabIndex = 18
        ReasonLabel.Text = "Reason:"
        '
        'UserIDLabel1
        '
        UserIDLabel1.AutoSize = True
        UserIDLabel1.Location = New System.Drawing.Point(6, 26)
        UserIDLabel1.Name = "UserIDLabel1"
        UserIDLabel1.Size = New System.Drawing.Size(47, 13)
        UserIDLabel1.TabIndex = 0
        UserIDLabel1.Text = "User ID:"
        '
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.Location = New System.Drawing.Point(105, 26)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(59, 13)
        UsernameLabel1.TabIndex = 2
        UsernameLabel1.Text = "Username:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(842, 28)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(57, 13)
        PasswordLabel1.TabIndex = 4
        PasswordLabel1.Text = "Password:"
        '
        'SectionLabel1
        '
        SectionLabel1.AutoSize = True
        SectionLabel1.Location = New System.Drawing.Point(366, 26)
        SectionLabel1.Name = "SectionLabel1"
        SectionLabel1.Size = New System.Drawing.Size(46, 13)
        SectionLabel1.TabIndex = 6
        SectionLabel1.Text = "Section:"
        '
        'UserLevelLabel1
        '
        UserLevelLabel1.AutoSize = True
        UserLevelLabel1.Location = New System.Drawing.Point(841, 54)
        UserLevelLabel1.Name = "UserLevelLabel1"
        UserLevelLabel1.Size = New System.Drawing.Size(61, 13)
        UserLevelLabel1.TabIndex = 8
        UserLevelLabel1.Text = "User Level:"
        '
        'StampLabel1
        '
        StampLabel1.AutoSize = True
        StampLabel1.Location = New System.Drawing.Point(841, 80)
        StampLabel1.Name = "StampLabel1"
        StampLabel1.Size = New System.Drawing.Size(41, 13)
        StampLabel1.TabIndex = 10
        StampLabel1.Text = "Stamp:"
        '
        'BirthLabel
        '
        BirthLabel.AutoSize = True
        BirthLabel.Location = New System.Drawing.Point(3, 53)
        BirthLabel.Name = "BirthLabel"
        BirthLabel.Size = New System.Drawing.Size(33, 13)
        BirthLabel.TabIndex = 19
        BirthLabel.Text = "Birth:"
        '
        'JoiningDateLabel
        '
        JoiningDateLabel.AutoSize = True
        JoiningDateLabel.Location = New System.Drawing.Point(3, 79)
        JoiningDateLabel.Name = "JoiningDateLabel"
        JoiningDateLabel.Size = New System.Drawing.Size(70, 13)
        JoiningDateLabel.TabIndex = 21
        JoiningDateLabel.Text = "Joining Date:"
        '
        'SallaryLabel
        '
        SallaryLabel.AutoSize = True
        SallaryLabel.Location = New System.Drawing.Point(186, 53)
        SallaryLabel.Name = "SallaryLabel"
        SallaryLabel.Size = New System.Drawing.Size(43, 13)
        SallaryLabel.TabIndex = 23
        SallaryLabel.Text = "Sallary:"
        '
        'JoBLabel
        '
        JoBLabel.AutoSize = True
        JoBLabel.Location = New System.Drawing.Point(186, 82)
        JoBLabel.Name = "JoBLabel"
        JoBLabel.Size = New System.Drawing.Size(28, 13)
        JoBLabel.TabIndex = 25
        JoBLabel.Text = "JoB:"
        '
        'PassportNumLabel
        '
        PassportNumLabel.AutoSize = True
        PassportNumLabel.Location = New System.Drawing.Point(7, 111)
        PassportNumLabel.Name = "PassportNumLabel"
        PassportNumLabel.Size = New System.Drawing.Size(77, 13)
        PassportNumLabel.TabIndex = 27
        PassportNumLabel.Text = "Passport Num:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Location = New System.Drawing.Point(22, 139)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(62, 13)
        NationalityLabel.TabIndex = 29
        NationalityLabel.Text = "Nationality:"
        '
        'VisaExpiredLabel
        '
        VisaExpiredLabel.AutoSize = True
        VisaExpiredLabel.Location = New System.Drawing.Point(441, 56)
        VisaExpiredLabel.Name = "VisaExpiredLabel"
        VisaExpiredLabel.Size = New System.Drawing.Size(69, 13)
        VisaExpiredLabel.TabIndex = 31
        VisaExpiredLabel.Text = "Visa Expired:"
        '
        'LaberCardNumLabel
        '
        LaberCardNumLabel.AutoSize = True
        LaberCardNumLabel.Location = New System.Drawing.Point(296, 111)
        LaberCardNumLabel.Name = "LaberCardNumLabel"
        LaberCardNumLabel.Size = New System.Drawing.Size(88, 13)
        LaberCardNumLabel.TabIndex = 33
        LaberCardNumLabel.Text = "Laber Card Num:"
        '
        'LaberCardExpiredLabel
        '
        LaberCardExpiredLabel.AutoSize = True
        LaberCardExpiredLabel.Location = New System.Drawing.Point(296, 140)
        LaberCardExpiredLabel.Name = "LaberCardExpiredLabel"
        LaberCardExpiredLabel.Size = New System.Drawing.Size(103, 13)
        LaberCardExpiredLabel.TabIndex = 35
        LaberCardExpiredLabel.Text = "Laber Card Expired:"
        '
        'MobilephoneLabel
        '
        MobilephoneLabel.AutoSize = True
        MobilephoneLabel.Location = New System.Drawing.Point(13, 162)
        MobilephoneLabel.Name = "MobilephoneLabel"
        MobilephoneLabel.Size = New System.Drawing.Size(71, 13)
        MobilephoneLabel.TabIndex = 37
        MobilephoneLabel.Text = "Mobilephone:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(43, 188)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 39
        PhoneLabel.Text = "phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(49, 214)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 41
        EmailLabel.Text = "Email:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TerminationIDLabel)
        Me.GroupBox1.Controls.Add(Me.TerminationIDTextBox)
        Me.GroupBox1.Controls.Add(UserIDLabel)
        Me.GroupBox1.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(SectionLabel)
        Me.GroupBox1.Controls.Add(Me.SectionTextBox)
        Me.GroupBox1.Controls.Add(UserLevelLabel)
        Me.GroupBox1.Controls.Add(Me.UserLevelTextBox)
        Me.GroupBox1.Controls.Add(StampLabel)
        Me.GroupBox1.Controls.Add(Me.StampTextBox)
        Me.GroupBox1.Controls.Add(JointDateLabel)
        Me.GroupBox1.Controls.Add(Me.JointDateDateTimePicker)
        Me.GroupBox1.Controls.Add(TerminationDateLabel)
        Me.GroupBox1.Controls.Add(Me.TerminationDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ReasonLabel)
        Me.GroupBox1.Controls.Add(Me.ReasonTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Termination"
        '
        'TerminationIDTextBox
        '
        Me.TerminationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "TerminationID", True))
        Me.TerminationIDTextBox.Location = New System.Drawing.Point(93, 25)
        Me.TerminationIDTextBox.Name = "TerminationIDTextBox"
        Me.TerminationIDTextBox.ReadOnly = True
        Me.TerminationIDTextBox.Size = New System.Drawing.Size(44, 20)
        Me.TerminationIDTextBox.TabIndex = 1
        '
        'TerminationUsersBindingSource
        '
        Me.TerminationUsersBindingSource.DataMember = "TerminationUsers"
        Me.TerminationUsersBindingSource.DataSource = Me.CancelUsersDataSet
        '
        'CancelUsersDataSet
        '
        Me.CancelUsersDataSet.DataSetName = "CancelUsersDataSet"
        Me.CancelUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(93, 50)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.ReadOnly = True
        Me.UserIDTextBox.Size = New System.Drawing.Size(44, 20)
        Me.UserIDTextBox.TabIndex = 3
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(223, 25)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.UsernameTextBox.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(265, 226)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 7
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(223, 53)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.ReadOnly = True
        Me.SectionTextBox.Size = New System.Drawing.Size(224, 20)
        Me.SectionTextBox.TabIndex = 9
        '
        'UserLevelTextBox
        '
        Me.UserLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "UserLevel", True))
        Me.UserLevelTextBox.Location = New System.Drawing.Point(265, 252)
        Me.UserLevelTextBox.Name = "UserLevelTextBox"
        Me.UserLevelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UserLevelTextBox.TabIndex = 11
        '
        'StampTextBox
        '
        Me.StampTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "Stamp", True))
        Me.StampTextBox.Location = New System.Drawing.Point(265, 278)
        Me.StampTextBox.Name = "StampTextBox"
        Me.StampTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StampTextBox.TabIndex = 13
        '
        'JointDateDateTimePicker
        '
        Me.JointDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TerminationUsersBindingSource, "JointDate", True))
        Me.JointDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.JointDateDateTimePicker.Location = New System.Drawing.Point(552, 25)
        Me.JointDateDateTimePicker.Name = "JointDateDateTimePicker"
        Me.JointDateDateTimePicker.Size = New System.Drawing.Size(93, 20)
        Me.JointDateDateTimePicker.TabIndex = 15
        '
        'TerminationDateDateTimePicker
        '
        Me.TerminationDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TerminationUsersBindingSource, "TerminationDate", True))
        Me.TerminationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TerminationDateDateTimePicker.Location = New System.Drawing.Point(552, 53)
        Me.TerminationDateDateTimePicker.Name = "TerminationDateDateTimePicker"
        Me.TerminationDateDateTimePicker.Size = New System.Drawing.Size(93, 20)
        Me.TerminationDateDateTimePicker.TabIndex = 17
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TerminationUsersBindingSource, "Reason", True))
        Me.ReasonTextBox.Location = New System.Drawing.Point(105, 79)
        Me.ReasonTextBox.Multiline = True
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(540, 67)
        Me.ReasonTextBox.TabIndex = 19
        '
        'TerminationUsersTableAdapter
        '
        Me.TerminationUsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TerminationUsersTableAdapter = Me.TerminationUsersTableAdapter
        Me.TableAdapterManager.UpdateOrder = AttendanceControls.CancelUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfosTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableTableAdapter = Me.UsersTableTableAdapter
        '
        'UsersTableTableAdapter
        '
        Me.UsersTableTableAdapter.ClearBeforeFill = True
        '
        'TerminationUsersBindingNavigator
        '
        Me.TerminationUsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TerminationUsersBindingNavigator.BindingSource = Me.TerminationUsersBindingSource
        Me.TerminationUsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TerminationUsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TerminationUsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TerminationUsersBindingNavigatorSaveItem})
        Me.TerminationUsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TerminationUsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TerminationUsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TerminationUsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TerminationUsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TerminationUsersBindingNavigator.Name = "TerminationUsersBindingNavigator"
        Me.TerminationUsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TerminationUsersBindingNavigator.Size = New System.Drawing.Size(1167, 25)
        Me.TerminationUsersBindingNavigator.TabIndex = 1
        Me.TerminationUsersBindingNavigator.Text = "BindingNavigator1"
        Me.TerminationUsersBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TerminationUsersBindingNavigatorSaveItem
        '
        Me.TerminationUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TerminationUsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("TerminationUsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TerminationUsersBindingNavigatorSaveItem.Name = "TerminationUsersBindingNavigatorSaveItem"
        Me.TerminationUsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TerminationUsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(BirthLabel)
        Me.GroupBox2.Controls.Add(Me.BirthDateTimePicker)
        Me.GroupBox2.Controls.Add(JoiningDateLabel)
        Me.GroupBox2.Controls.Add(Me.JoiningDateDateTimePicker)
        Me.GroupBox2.Controls.Add(SallaryLabel)
        Me.GroupBox2.Controls.Add(Me.SallaryTextBox)
        Me.GroupBox2.Controls.Add(JoBLabel)
        Me.GroupBox2.Controls.Add(Me.JoBTextBox)
        Me.GroupBox2.Controls.Add(PassportNumLabel)
        Me.GroupBox2.Controls.Add(Me.PassportNumTextBox)
        Me.GroupBox2.Controls.Add(NationalityLabel)
        Me.GroupBox2.Controls.Add(Me.NationalityTextBox)
        Me.GroupBox2.Controls.Add(VisaExpiredLabel)
        Me.GroupBox2.Controls.Add(Me.VisaExpiredDateTimePicker)
        Me.GroupBox2.Controls.Add(LaberCardNumLabel)
        Me.GroupBox2.Controls.Add(Me.LaberCardNumTextBox)
        Me.GroupBox2.Controls.Add(LaberCardExpiredLabel)
        Me.GroupBox2.Controls.Add(Me.LaberCardExpiredDateTimePicker)
        Me.GroupBox2.Controls.Add(MobilephoneLabel)
        Me.GroupBox2.Controls.Add(Me.MobilephoneTextBox)
        Me.GroupBox2.Controls.Add(PhoneLabel)
        Me.GroupBox2.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox2.Controls.Add(EmailLabel)
        Me.GroupBox2.Controls.Add(Me.EmailTextBox)
        Me.GroupBox2.Controls.Add(Me.Bu_Terminate)
        Me.GroupBox2.Controls.Add(UserIDLabel1)
        Me.GroupBox2.Controls.Add(Me.UserIDTextBox1)
        Me.GroupBox2.Controls.Add(UsernameLabel1)
        Me.GroupBox2.Controls.Add(Me.UsernameComboBox)
        Me.GroupBox2.Controls.Add(PasswordLabel1)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox1)
        Me.GroupBox2.Controls.Add(SectionLabel1)
        Me.GroupBox2.Controls.Add(Me.SectionTextBox1)
        Me.GroupBox2.Controls.Add(UserLevelLabel1)
        Me.GroupBox2.Controls.Add(Me.UserLevelTextBox1)
        Me.GroupBox2.Controls.Add(StampLabel1)
        Me.GroupBox2.Controls.Add(Me.StampTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 257)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User To Termination"
        '
        'BirthDateTimePicker
        '
        Me.BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "Birth", True))
        Me.BirthDateTimePicker.Enabled = False
        Me.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDateTimePicker.Location = New System.Drawing.Point(79, 50)
        Me.BirthDateTimePicker.Name = "BirthDateTimePicker"
        Me.BirthDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.BirthDateTimePicker.TabIndex = 20
        '
        'UserInfosBindingSource
        '
        Me.UserInfosBindingSource.DataMember = "UserInfos"
        Me.UserInfosBindingSource.DataSource = Me.CancelUsersDataSet
        '
        'JoiningDateDateTimePicker
        '
        Me.JoiningDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "JoiningDate", True))
        Me.JoiningDateDateTimePicker.Enabled = False
        Me.JoiningDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.JoiningDateDateTimePicker.Location = New System.Drawing.Point(79, 76)
        Me.JoiningDateDateTimePicker.Name = "JoiningDateDateTimePicker"
        Me.JoiningDateDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.JoiningDateDateTimePicker.TabIndex = 22
        '
        'SallaryTextBox
        '
        Me.SallaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Sallary", True))
        Me.SallaryTextBox.Location = New System.Drawing.Point(235, 50)
        Me.SallaryTextBox.Name = "SallaryTextBox"
        Me.SallaryTextBox.ReadOnly = True
        Me.SallaryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SallaryTextBox.TabIndex = 24
        '
        'JoBTextBox
        '
        Me.JoBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "JoB", True))
        Me.JoBTextBox.Location = New System.Drawing.Point(235, 82)
        Me.JoBTextBox.Name = "JoBTextBox"
        Me.JoBTextBox.ReadOnly = True
        Me.JoBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JoBTextBox.TabIndex = 26
        '
        'PassportNumTextBox
        '
        Me.PassportNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "PassportNum", True))
        Me.PassportNumTextBox.Location = New System.Drawing.Point(90, 108)
        Me.PassportNumTextBox.Name = "PassportNumTextBox"
        Me.PassportNumTextBox.ReadOnly = True
        Me.PassportNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PassportNumTextBox.TabIndex = 28
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(90, 136)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.ReadOnly = True
        Me.NationalityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NationalityTextBox.TabIndex = 30
        '
        'VisaExpiredDateTimePicker
        '
        Me.VisaExpiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "VisaExpired", True))
        Me.VisaExpiredDateTimePicker.Enabled = False
        Me.VisaExpiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VisaExpiredDateTimePicker.Location = New System.Drawing.Point(511, 53)
        Me.VisaExpiredDateTimePicker.Name = "VisaExpiredDateTimePicker"
        Me.VisaExpiredDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.VisaExpiredDateTimePicker.TabIndex = 32
        '
        'LaberCardNumTextBox
        '
        Me.LaberCardNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "LaberCardNum", True))
        Me.LaberCardNumTextBox.Location = New System.Drawing.Point(405, 108)
        Me.LaberCardNumTextBox.Name = "LaberCardNumTextBox"
        Me.LaberCardNumTextBox.ReadOnly = True
        Me.LaberCardNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LaberCardNumTextBox.TabIndex = 34
        '
        'LaberCardExpiredDateTimePicker
        '
        Me.LaberCardExpiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "LaberCardExpired", True))
        Me.LaberCardExpiredDateTimePicker.Enabled = False
        Me.LaberCardExpiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LaberCardExpiredDateTimePicker.Location = New System.Drawing.Point(405, 136)
        Me.LaberCardExpiredDateTimePicker.Name = "LaberCardExpiredDateTimePicker"
        Me.LaberCardExpiredDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.LaberCardExpiredDateTimePicker.TabIndex = 36
        '
        'MobilephoneTextBox
        '
        Me.MobilephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Mobilephone", True))
        Me.MobilephoneTextBox.Location = New System.Drawing.Point(90, 159)
        Me.MobilephoneTextBox.Name = "MobilephoneTextBox"
        Me.MobilephoneTextBox.ReadOnly = True
        Me.MobilephoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MobilephoneTextBox.TabIndex = 38
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(90, 185)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 40
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(90, 211)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 42
        '
        'Bu_Terminate
        '
        Me.Bu_Terminate.Location = New System.Drawing.Point(533, 18)
        Me.Bu_Terminate.Name = "Bu_Terminate"
        Me.Bu_Terminate.Size = New System.Drawing.Size(79, 28)
        Me.Bu_Terminate.TabIndex = 12
        Me.Bu_Terminate.Text = "Terminate"
        Me.Bu_Terminate.UseVisualStyleBackColor = True
        '
        'UserIDTextBox1
        '
        Me.UserIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserID", True))
        Me.UserIDTextBox1.Location = New System.Drawing.Point(59, 23)
        Me.UserIDTextBox1.Name = "UserIDTextBox1"
        Me.UserIDTextBox1.ReadOnly = True
        Me.UserIDTextBox1.Size = New System.Drawing.Size(40, 20)
        Me.UserIDTextBox1.TabIndex = 1
        '
        'UsersTableBindingSource
        '
        Me.UsersTableBindingSource.DataMember = "UsersTable"
        Me.UsersTableBindingSource.DataSource = Me.CancelUsersDataSet
        '
        'UsernameComboBox
        '
        Me.UsernameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.UsernameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UsernameComboBox.DataSource = Me.UsersTableBindingSource
        Me.UsernameComboBox.DisplayMember = "Username"
        Me.UsernameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsernameComboBox.FormattingEnabled = True
        Me.UsernameComboBox.Location = New System.Drawing.Point(172, 23)
        Me.UsernameComboBox.Name = "UsernameComboBox"
        Me.UsernameComboBox.Size = New System.Drawing.Size(188, 21)
        Me.UsernameComboBox.TabIndex = 3
        Me.UsernameComboBox.ValueMember = "Username"
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Password", True))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(715, 24)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.PasswordTextBox1.TabIndex = 5
        '
        'SectionTextBox1
        '
        Me.SectionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Section", True))
        Me.SectionTextBox1.Location = New System.Drawing.Point(418, 24)
        Me.SectionTextBox1.Name = "SectionTextBox1"
        Me.SectionTextBox1.ReadOnly = True
        Me.SectionTextBox1.Size = New System.Drawing.Size(109, 20)
        Me.SectionTextBox1.TabIndex = 7
        '
        'UserLevelTextBox1
        '
        Me.UserLevelTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserLevel", True))
        Me.UserLevelTextBox1.Location = New System.Drawing.Point(714, 50)
        Me.UserLevelTextBox1.Name = "UserLevelTextBox1"
        Me.UserLevelTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.UserLevelTextBox1.TabIndex = 9
        '
        'StampTextBox1
        '
        Me.StampTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Stamp", True))
        Me.StampTextBox1.Location = New System.Drawing.Point(714, 76)
        Me.StampTextBox1.Name = "StampTextBox1"
        Me.StampTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.StampTextBox1.TabIndex = 11
        '
        'UserInfosTableAdapter
        '
        Me.UserInfosTableAdapter.ClearBeforeFill = True
        '
        'Bu_refresh
        '
        Me.Bu_refresh.Location = New System.Drawing.Point(212, 435)
        Me.Bu_refresh.Name = "Bu_refresh"
        Me.Bu_refresh.Size = New System.Drawing.Size(79, 28)
        Me.Bu_refresh.TabIndex = 20
        Me.Bu_refresh.Text = "Refresh"
        Me.Bu_refresh.UseVisualStyleBackColor = True
        '
        'Bu_Save
        '
        Me.Bu_Save.Location = New System.Drawing.Point(297, 435)
        Me.Bu_Save.Name = "Bu_Save"
        Me.Bu_Save.Size = New System.Drawing.Size(79, 28)
        Me.Bu_Save.TabIndex = 21
        Me.Bu_Save.Text = "Save"
        Me.Bu_Save.UseVisualStyleBackColor = True
        '
        'Bu_Cancel
        '
        Me.Bu_Cancel.Location = New System.Drawing.Point(382, 435)
        Me.Bu_Cancel.Name = "Bu_Cancel"
        Me.Bu_Cancel.Size = New System.Drawing.Size(79, 28)
        Me.Bu_Cancel.TabIndex = 22
        Me.Bu_Cancel.Text = "Cancel"
        Me.Bu_Cancel.UseVisualStyleBackColor = True
        '
        'CanceledUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(672, 478)
        Me.Controls.Add(Me.Bu_Cancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Bu_Save)
        Me.Controls.Add(Me.TerminationUsersBindingNavigator)
        Me.Controls.Add(Me.Bu_refresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CanceledUsers"
        Me.Text = "CanceledUsers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TerminationUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelUsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TerminationUsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TerminationUsersBindingNavigator.ResumeLayout(False)
        Me.TerminationUsersBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UserInfosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CancelUsersDataSet As CancelUsersDataSet
    Friend WithEvents TerminationUsersBindingSource As BindingSource
    Friend WithEvents TerminationUsersTableAdapter As CancelUsersDataSetTableAdapters.TerminationUsersTableAdapter
    Friend WithEvents TableAdapterManager As CancelUsersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TerminationUsersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TerminationUsersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TerminationIDTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SectionTextBox As TextBox
    Friend WithEvents UserLevelTextBox As TextBox
    Friend WithEvents StampTextBox As TextBox
    Friend WithEvents JointDateDateTimePicker As DateTimePicker
    Friend WithEvents TerminationDateDateTimePicker As DateTimePicker
    Friend WithEvents ReasonTextBox As TextBox
    Friend WithEvents UsersTableTableAdapter As CancelUsersDataSetTableAdapters.UsersTableTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UsersTableBindingSource As BindingSource
    Friend WithEvents UserIDTextBox1 As TextBox
    Friend WithEvents UsernameComboBox As ComboBox
    Friend WithEvents PasswordTextBox1 As TextBox
    Friend WithEvents SectionTextBox1 As TextBox
    Friend WithEvents UserLevelTextBox1 As TextBox
    Friend WithEvents StampTextBox1 As TextBox
    Friend WithEvents Bu_Terminate As Button
    Friend WithEvents UserInfosBindingSource As BindingSource
    Friend WithEvents UserInfosTableAdapter As CancelUsersDataSetTableAdapters.UserInfosTableAdapter
    Friend WithEvents BirthDateTimePicker As DateTimePicker
    Friend WithEvents JoiningDateDateTimePicker As DateTimePicker
    Friend WithEvents SallaryTextBox As TextBox
    Friend WithEvents JoBTextBox As TextBox
    Friend WithEvents PassportNumTextBox As TextBox
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents VisaExpiredDateTimePicker As DateTimePicker
    Friend WithEvents LaberCardNumTextBox As TextBox
    Friend WithEvents LaberCardExpiredDateTimePicker As DateTimePicker
    Friend WithEvents MobilephoneTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Bu_refresh As Button
    Friend WithEvents Bu_Save As Button
    Friend WithEvents Bu_Cancel As Button
End Class
