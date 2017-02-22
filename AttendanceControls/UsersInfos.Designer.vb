<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersInfos
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
        Me.components = New System.ComponentModel.Container()
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim UserInfoIDLabel As System.Windows.Forms.Label
        Dim UserIDLabel1 As System.Windows.Forms.Label
        Dim UserNameLabel1 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersInfos))
        Me.CancelUsersDataSet = New AttendanceControls.CancelUsersDataSet()
        Me.UsersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableTableAdapter = New AttendanceControls.CancelUsersDataSetTableAdapters.UsersTableTableAdapter()
        Me.TableAdapterManager = New AttendanceControls.CancelUsersDataSetTableAdapters.TableAdapterManager()
        Me.UserInfosTableAdapter = New AttendanceControls.CancelUsersDataSetTableAdapters.UserInfosTableAdapter()
        Me.UsersTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UsersTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameComboBox = New System.Windows.Forms.ComboBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.UserInfosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bu_Cancel = New System.Windows.Forms.Button()
        Me.Bu_Save = New System.Windows.Forms.Button()
        Me.Bu_Add = New System.Windows.Forms.Button()
        Me.UserInfoIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        UserIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        UserInfoIDLabel = New System.Windows.Forms.Label()
        UserIDLabel1 = New System.Windows.Forms.Label()
        UserNameLabel1 = New System.Windows.Forms.Label()
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
        CType(Me.CancelUsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersTableBindingNavigator.SuspendLayout()
        CType(Me.UserInfosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(6, 25)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(47, 13)
        UserIDLabel.TabIndex = 1
        UserIDLabel.Text = "User ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(165, 25)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(59, 13)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "Username:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(6, 57)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(46, 13)
        SectionLabel.TabIndex = 5
        SectionLabel.Text = "Section:"
        '
        'UserInfoIDLabel
        '
        UserInfoIDLabel.AutoSize = True
        UserInfoIDLabel.Location = New System.Drawing.Point(58, 26)
        UserInfoIDLabel.Name = "UserInfoIDLabel"
        UserInfoIDLabel.Size = New System.Drawing.Size(70, 13)
        UserInfoIDLabel.TabIndex = 0
        UserInfoIDLabel.Text = "User Info ID:"
        '
        'UserIDLabel1
        '
        UserIDLabel1.AutoSize = True
        UserIDLabel1.Location = New System.Drawing.Point(58, 52)
        UserIDLabel1.Name = "UserIDLabel1"
        UserIDLabel1.Size = New System.Drawing.Size(47, 13)
        UserIDLabel1.TabIndex = 2
        UserIDLabel1.Text = "User ID:"
        '
        'UserNameLabel1
        '
        UserNameLabel1.AutoSize = True
        UserNameLabel1.Location = New System.Drawing.Point(58, 78)
        UserNameLabel1.Name = "UserNameLabel1"
        UserNameLabel1.Size = New System.Drawing.Size(63, 13)
        UserNameLabel1.TabIndex = 4
        UserNameLabel1.Text = "User Name:"
        '
        'BirthLabel
        '
        BirthLabel.AutoSize = True
        BirthLabel.Location = New System.Drawing.Point(58, 105)
        BirthLabel.Name = "BirthLabel"
        BirthLabel.Size = New System.Drawing.Size(33, 13)
        BirthLabel.TabIndex = 6
        BirthLabel.Text = "Birth:"
        '
        'JoiningDateLabel
        '
        JoiningDateLabel.AutoSize = True
        JoiningDateLabel.Location = New System.Drawing.Point(58, 131)
        JoiningDateLabel.Name = "JoiningDateLabel"
        JoiningDateLabel.Size = New System.Drawing.Size(70, 13)
        JoiningDateLabel.TabIndex = 8
        JoiningDateLabel.Text = "Joining Date:"
        '
        'SallaryLabel
        '
        SallaryLabel.AutoSize = True
        SallaryLabel.Location = New System.Drawing.Point(58, 156)
        SallaryLabel.Name = "SallaryLabel"
        SallaryLabel.Size = New System.Drawing.Size(43, 13)
        SallaryLabel.TabIndex = 10
        SallaryLabel.Text = "Sallary:"
        '
        'JoBLabel
        '
        JoBLabel.AutoSize = True
        JoBLabel.Location = New System.Drawing.Point(58, 182)
        JoBLabel.Name = "JoBLabel"
        JoBLabel.Size = New System.Drawing.Size(31, 13)
        JoBLabel.TabIndex = 12
        JoBLabel.Text = "Jo B:"
        '
        'PassportNumLabel
        '
        PassportNumLabel.AutoSize = True
        PassportNumLabel.Location = New System.Drawing.Point(58, 208)
        PassportNumLabel.Name = "PassportNumLabel"
        PassportNumLabel.Size = New System.Drawing.Size(77, 13)
        PassportNumLabel.TabIndex = 14
        PassportNumLabel.Text = "Passport Num:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Location = New System.Drawing.Point(58, 234)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(62, 13)
        NationalityLabel.TabIndex = 16
        NationalityLabel.Text = "Nationality:"
        '
        'VisaExpiredLabel
        '
        VisaExpiredLabel.AutoSize = True
        VisaExpiredLabel.Location = New System.Drawing.Point(58, 261)
        VisaExpiredLabel.Name = "VisaExpiredLabel"
        VisaExpiredLabel.Size = New System.Drawing.Size(69, 13)
        VisaExpiredLabel.TabIndex = 18
        VisaExpiredLabel.Text = "Visa Expired:"
        '
        'LaberCardNumLabel
        '
        LaberCardNumLabel.AutoSize = True
        LaberCardNumLabel.Location = New System.Drawing.Point(58, 286)
        LaberCardNumLabel.Name = "LaberCardNumLabel"
        LaberCardNumLabel.Size = New System.Drawing.Size(88, 13)
        LaberCardNumLabel.TabIndex = 20
        LaberCardNumLabel.Text = "Laber Card Num:"
        '
        'LaberCardExpiredLabel
        '
        LaberCardExpiredLabel.AutoSize = True
        LaberCardExpiredLabel.Location = New System.Drawing.Point(58, 313)
        LaberCardExpiredLabel.Name = "LaberCardExpiredLabel"
        LaberCardExpiredLabel.Size = New System.Drawing.Size(103, 13)
        LaberCardExpiredLabel.TabIndex = 22
        LaberCardExpiredLabel.Text = "Laber Card Expired:"
        '
        'MobilephoneLabel
        '
        MobilephoneLabel.AutoSize = True
        MobilephoneLabel.Location = New System.Drawing.Point(58, 338)
        MobilephoneLabel.Name = "MobilephoneLabel"
        MobilephoneLabel.Size = New System.Drawing.Size(71, 13)
        MobilephoneLabel.TabIndex = 24
        MobilephoneLabel.Text = "Mobilephone:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(58, 364)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 26
        PhoneLabel.Text = "phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(58, 390)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 28
        EmailLabel.Text = "Email:"
        '
        'CancelUsersDataSet
        '
        Me.CancelUsersDataSet.DataSetName = "CancelUsersDataSet"
        Me.CancelUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableBindingSource
        '
        Me.UsersTableBindingSource.DataMember = "UsersTable"
        Me.UsersTableBindingSource.DataSource = Me.CancelUsersDataSet
        '
        'UsersTableTableAdapter
        '
        Me.UsersTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TerminationUsersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AttendanceControls.CancelUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfosTableAdapter = Me.UserInfosTableAdapter
        Me.TableAdapterManager.UsersTableTableAdapter = Me.UsersTableTableAdapter
        '
        'UserInfosTableAdapter
        '
        Me.UserInfosTableAdapter.ClearBeforeFill = True
        '
        'UsersTableBindingNavigator
        '
        Me.UsersTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersTableBindingNavigator.BindingSource = Me.UsersTableBindingSource
        Me.UsersTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersTableBindingNavigatorSaveItem})
        Me.UsersTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsersTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersTableBindingNavigator.Name = "UsersTableBindingNavigator"
        Me.UsersTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersTableBindingNavigator.Size = New System.Drawing.Size(744, 25)
        Me.UsersTableBindingNavigator.TabIndex = 0
        Me.UsersTableBindingNavigator.Text = "BindingNavigator1"
        Me.UsersTableBindingNavigator.Visible = False
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
        'UsersTableBindingNavigatorSaveItem
        '
        Me.UsersTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersTableBindingNavigatorSaveItem.Name = "UsersTableBindingNavigatorSaveItem"
        Me.UsersTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(59, 22)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.ReadOnly = True
        Me.UserIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIDTextBox.TabIndex = 2
        '
        'UsernameComboBox
        '
        Me.UsernameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.UsernameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UsernameComboBox.DataSource = Me.UsersTableBindingSource
        Me.UsernameComboBox.DisplayMember = "Username"
        Me.UsernameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsernameComboBox.FormattingEnabled = True
        Me.UsernameComboBox.Location = New System.Drawing.Point(230, 22)
        Me.UsernameComboBox.Name = "UsernameComboBox"
        Me.UsernameComboBox.Size = New System.Drawing.Size(181, 21)
        Me.UsernameComboBox.TabIndex = 4
        Me.UsernameComboBox.ValueMember = "Username"
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(58, 54)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.ReadOnly = True
        Me.SectionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SectionTextBox.TabIndex = 6
        '
        'UserInfosBindingSource
        '
        Me.UserInfosBindingSource.DataMember = "UsersTable_UserInfos"
        Me.UserInfosBindingSource.DataSource = Me.UsersTableBindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox1.Controls.Add(UserIDLabel)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameComboBox)
        Me.GroupBox1.Controls.Add(SectionLabel)
        Me.GroupBox1.Controls.Add(Me.SectionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 89)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chose User"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bu_Cancel)
        Me.GroupBox2.Controls.Add(Me.Bu_Save)
        Me.GroupBox2.Controls.Add(Me.Bu_Add)
        Me.GroupBox2.Controls.Add(UserInfoIDLabel)
        Me.GroupBox2.Controls.Add(Me.UserInfoIDTextBox)
        Me.GroupBox2.Controls.Add(UserIDLabel1)
        Me.GroupBox2.Controls.Add(Me.UserIDTextBox1)
        Me.GroupBox2.Controls.Add(UserNameLabel1)
        Me.GroupBox2.Controls.Add(Me.UserNameTextBox)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 478)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Info"
        '
        'Bu_Cancel
        '
        Me.Bu_Cancel.Location = New System.Drawing.Point(259, 428)
        Me.Bu_Cancel.Name = "Bu_Cancel"
        Me.Bu_Cancel.Size = New System.Drawing.Size(81, 34)
        Me.Bu_Cancel.TabIndex = 32
        Me.Bu_Cancel.Text = "Cancel"
        Me.Bu_Cancel.UseVisualStyleBackColor = True
        '
        'Bu_Save
        '
        Me.Bu_Save.Location = New System.Drawing.Point(172, 428)
        Me.Bu_Save.Name = "Bu_Save"
        Me.Bu_Save.Size = New System.Drawing.Size(81, 34)
        Me.Bu_Save.TabIndex = 31
        Me.Bu_Save.Text = "Save"
        Me.Bu_Save.UseVisualStyleBackColor = True
        '
        'Bu_Add
        '
        Me.Bu_Add.Location = New System.Drawing.Point(85, 428)
        Me.Bu_Add.Name = "Bu_Add"
        Me.Bu_Add.Size = New System.Drawing.Size(81, 34)
        Me.Bu_Add.TabIndex = 30
        Me.Bu_Add.Text = "Add"
        Me.Bu_Add.UseVisualStyleBackColor = True
        '
        'UserInfoIDTextBox
        '
        Me.UserInfoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "UserInfoID", True))
        Me.UserInfoIDTextBox.Location = New System.Drawing.Point(167, 23)
        Me.UserInfoIDTextBox.Name = "UserInfoIDTextBox"
        Me.UserInfoIDTextBox.ReadOnly = True
        Me.UserInfoIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UserInfoIDTextBox.TabIndex = 1
        '
        'UserIDTextBox1
        '
        Me.UserIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "UserID", True))
        Me.UserIDTextBox1.Location = New System.Drawing.Point(167, 49)
        Me.UserIDTextBox1.Name = "UserIDTextBox1"
        Me.UserIDTextBox1.ReadOnly = True
        Me.UserIDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.UserIDTextBox1.TabIndex = 3
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(167, 75)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.ReadOnly = True
        Me.UserNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UserNameTextBox.TabIndex = 5
        '
        'BirthDateTimePicker
        '
        Me.BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "Birth", True))
        Me.BirthDateTimePicker.Location = New System.Drawing.Point(167, 101)
        Me.BirthDateTimePicker.Name = "BirthDateTimePicker"
        Me.BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BirthDateTimePicker.TabIndex = 7
        '
        'JoiningDateDateTimePicker
        '
        Me.JoiningDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "JoiningDate", True))
        Me.JoiningDateDateTimePicker.Location = New System.Drawing.Point(167, 127)
        Me.JoiningDateDateTimePicker.Name = "JoiningDateDateTimePicker"
        Me.JoiningDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.JoiningDateDateTimePicker.TabIndex = 9
        '
        'SallaryTextBox
        '
        Me.SallaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Sallary", True))
        Me.SallaryTextBox.Location = New System.Drawing.Point(167, 153)
        Me.SallaryTextBox.Name = "SallaryTextBox"
        Me.SallaryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SallaryTextBox.TabIndex = 11
        '
        'JoBTextBox
        '
        Me.JoBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "JoB", True))
        Me.JoBTextBox.Location = New System.Drawing.Point(167, 179)
        Me.JoBTextBox.Name = "JoBTextBox"
        Me.JoBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JoBTextBox.TabIndex = 13
        '
        'PassportNumTextBox
        '
        Me.PassportNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "PassportNum", True))
        Me.PassportNumTextBox.Location = New System.Drawing.Point(167, 205)
        Me.PassportNumTextBox.Name = "PassportNumTextBox"
        Me.PassportNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PassportNumTextBox.TabIndex = 15
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(167, 231)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NationalityTextBox.TabIndex = 17
        '
        'VisaExpiredDateTimePicker
        '
        Me.VisaExpiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "VisaExpired", True))
        Me.VisaExpiredDateTimePicker.Location = New System.Drawing.Point(167, 257)
        Me.VisaExpiredDateTimePicker.Name = "VisaExpiredDateTimePicker"
        Me.VisaExpiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.VisaExpiredDateTimePicker.TabIndex = 19
        '
        'LaberCardNumTextBox
        '
        Me.LaberCardNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "LaberCardNum", True))
        Me.LaberCardNumTextBox.Location = New System.Drawing.Point(167, 283)
        Me.LaberCardNumTextBox.Name = "LaberCardNumTextBox"
        Me.LaberCardNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LaberCardNumTextBox.TabIndex = 21
        '
        'LaberCardExpiredDateTimePicker
        '
        Me.LaberCardExpiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UserInfosBindingSource, "LaberCardExpired", True))
        Me.LaberCardExpiredDateTimePicker.Location = New System.Drawing.Point(167, 309)
        Me.LaberCardExpiredDateTimePicker.Name = "LaberCardExpiredDateTimePicker"
        Me.LaberCardExpiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.LaberCardExpiredDateTimePicker.TabIndex = 23
        '
        'MobilephoneTextBox
        '
        Me.MobilephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Mobilephone", True))
        Me.MobilephoneTextBox.Location = New System.Drawing.Point(167, 335)
        Me.MobilephoneTextBox.Name = "MobilephoneTextBox"
        Me.MobilephoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MobilephoneTextBox.TabIndex = 25
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(167, 361)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 27
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(167, 387)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 29
        '
        'UsersInfos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(444, 592)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UsersTableBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UsersInfos"
        Me.Text = "UsersInfos"
        CType(Me.CancelUsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersTableBindingNavigator.ResumeLayout(False)
        Me.UsersTableBindingNavigator.PerformLayout()
        CType(Me.UserInfosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelUsersDataSet As CancelUsersDataSet
    Friend WithEvents UsersTableBindingSource As BindingSource
    Friend WithEvents UsersTableTableAdapter As CancelUsersDataSetTableAdapters.UsersTableTableAdapter
    Friend WithEvents TableAdapterManager As CancelUsersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersTableBindingNavigator As BindingNavigator
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
    Friend WithEvents UsersTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents UsernameComboBox As ComboBox
    Friend WithEvents SectionTextBox As TextBox
    Friend WithEvents UserInfosTableAdapter As CancelUsersDataSetTableAdapters.UserInfosTableAdapter
    Friend WithEvents UserInfosBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bu_Add As Button
    Friend WithEvents UserInfoIDTextBox As TextBox
    Friend WithEvents UserIDTextBox1 As TextBox
    Friend WithEvents UserNameTextBox As TextBox
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
    Friend WithEvents Bu_Save As Button
    Friend WithEvents Bu_Cancel As Button
End Class
