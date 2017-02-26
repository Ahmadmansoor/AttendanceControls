<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthlySalary
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlySalary))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bu_Get = New System.Windows.Forms.Button()
        Me.CB_Year = New System.Windows.Forms.ComboBox()
        Me.CB_Month = New System.Windows.Forms.ComboBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.UsersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthlySalaryDataSet = New AttendanceControls.MonthlySalaryDataSet()
        Me.UsernameComboBox = New System.Windows.Forms.ComboBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsersTableTableAdapter = New AttendanceControls.MonthlySalaryDataSetTableAdapters.UsersTableTableAdapter()
        Me.TableAdapterManager = New AttendanceControls.MonthlySalaryDataSetTableAdapters.TableAdapterManager()
        Me.AttendanceTableTableAdapter = New AttendanceControls.MonthlySalaryDataSetTableAdapters.AttendanceTableTableAdapter()
        Me.VariableTableTableAdapter = New AttendanceControls.MonthlySalaryDataSetTableAdapters.VariableTableTableAdapter()
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
        Me.VariableTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MorningTimeRoundTextBox = New System.Windows.Forms.TextBox()
        Me.AttendanceTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MorningLate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EveningLate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumLate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_monthSalary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_DaySalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_HourSalary = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Money = New System.Windows.Forms.TextBox()
        Me.LB_DayAbsent = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_DayAbsent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_TotalLate = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager1 = New AttendanceControls.ACDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bu_LoadSalaryFile = New System.Windows.Forms.Button()
        UserIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlySalaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersTableBindingNavigator.SuspendLayout()
        CType(Me.VariableTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(15, 27)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(55, 14)
        UserIDLabel.TabIndex = 0
        UserIDLabel.Text = "User ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(151, 27)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(70, 14)
        UsernameLabel.TabIndex = 2
        UsernameLabel.Text = "Username:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(15, 60)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(57, 14)
        SectionLabel.TabIndex = 4
        SectionLabel.Text = "Section:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Bu_Get)
        Me.GroupBox1.Controls.Add(Me.CB_Year)
        Me.GroupBox1.Controls.Add(Me.CB_Month)
        Me.GroupBox1.Controls.Add(SectionLabel)
        Me.GroupBox1.Controls.Add(Me.SectionTextBox)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameComboBox)
        Me.GroupBox1.Controls.Add(UserIDLabel)
        Me.GroupBox1.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Users"
        '
        'Bu_Get
        '
        Me.Bu_Get.Location = New System.Drawing.Point(179, 85)
        Me.Bu_Get.Name = "Bu_Get"
        Me.Bu_Get.Size = New System.Drawing.Size(75, 30)
        Me.Bu_Get.TabIndex = 9
        Me.Bu_Get.Text = "Get"
        Me.Bu_Get.UseVisualStyleBackColor = True
        '
        'CB_Year
        '
        Me.CB_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Year.FormattingEnabled = True
        Me.CB_Year.Items.AddRange(New Object() {"2016", "2017", "2018", "2019"})
        Me.CB_Year.Location = New System.Drawing.Point(198, 57)
        Me.CB_Year.Name = "CB_Year"
        Me.CB_Year.Size = New System.Drawing.Size(72, 22)
        Me.CB_Year.TabIndex = 7
        '
        'CB_Month
        '
        Me.CB_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Month.FormattingEnabled = True
        Me.CB_Month.Items.AddRange(New Object() {"1-January", "2-February", "3-March", "4-April", "5-May", "6-June", "7-July", "8-August", "9-September", "10-October", "11-November", "12-December"})
        Me.CB_Month.Location = New System.Drawing.Point(278, 57)
        Me.CB_Month.Name = "CB_Month"
        Me.CB_Month.Size = New System.Drawing.Size(140, 22)
        Me.CB_Month.TabIndex = 8
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(76, 57)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.ReadOnly = True
        Me.SectionTextBox.Size = New System.Drawing.Size(116, 22)
        Me.SectionTextBox.TabIndex = 5
        '
        'UsersTableBindingSource
        '
        Me.UsersTableBindingSource.DataMember = "UsersTable"
        Me.UsersTableBindingSource.DataSource = Me.MonthlySalaryDataSet
        '
        'MonthlySalaryDataSet
        '
        Me.MonthlySalaryDataSet.DataSetName = "MonthlySalaryDataSet"
        Me.MonthlySalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernameComboBox
        '
        Me.UsernameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UsernameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UsernameComboBox.DataSource = Me.UsersTableBindingSource
        Me.UsernameComboBox.DisplayMember = "Username"
        Me.UsernameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsernameComboBox.FormattingEnabled = True
        Me.UsernameComboBox.Location = New System.Drawing.Point(227, 24)
        Me.UsernameComboBox.Name = "UsernameComboBox"
        Me.UsernameComboBox.Size = New System.Drawing.Size(191, 22)
        Me.UsernameComboBox.TabIndex = 3
        Me.UsernameComboBox.ValueMember = "Username"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(77, 24)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.ReadOnly = True
        Me.UserIDTextBox.Size = New System.Drawing.Size(67, 22)
        Me.UserIDTextBox.TabIndex = 1
        '
        'UsersTableTableAdapter
        '
        Me.UsersTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableTableAdapter = Me.AttendanceTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = AttendanceControls.MonthlySalaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfosTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableTableAdapter = Me.UsersTableTableAdapter
        Me.TableAdapterManager.VariableTableTableAdapter = Me.VariableTableTableAdapter
        '
        'AttendanceTableTableAdapter
        '
        Me.AttendanceTableTableAdapter.ClearBeforeFill = True
        '
        'VariableTableTableAdapter
        '
        Me.VariableTableTableAdapter.ClearBeforeFill = True
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
        Me.UsersTableBindingNavigator.Size = New System.Drawing.Size(1277, 25)
        Me.UsersTableBindingNavigator.TabIndex = 1
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'VariableTableBindingSource
        '
        Me.VariableTableBindingSource.DataMember = "VariableTable"
        Me.VariableTableBindingSource.DataSource = Me.MonthlySalaryDataSet
        '
        'MorningTimeRoundTextBox
        '
        Me.MorningTimeRoundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariableTableBindingSource, "MorningTimeRound", True))
        Me.MorningTimeRoundTextBox.Location = New System.Drawing.Point(429, 135)
        Me.MorningTimeRoundTextBox.Name = "MorningTimeRoundTextBox"
        Me.MorningTimeRoundTextBox.Size = New System.Drawing.Size(45, 22)
        Me.MorningTimeRoundTextBox.TabIndex = 3
        '
        'AttendanceTableBindingSource
        '
        Me.AttendanceTableBindingSource.DataMember = "AttendanceTable"
        Me.AttendanceTableBindingSource.DataSource = Me.MonthlySalaryDataSet
        '
        'AttendanceTableDataGridView
        '
        Me.AttendanceTableDataGridView.AllowUserToAddRows = False
        Me.AttendanceTableDataGridView.AllowUserToDeleteRows = False
        Me.AttendanceTableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttendanceTableDataGridView.AutoGenerateColumns = False
        Me.AttendanceTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendanceTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DayName, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.MorningLate, Me.EveningLate, Me.SumLate, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AttendanceTableDataGridView.DataSource = Me.AttendanceTableBindingSource
        Me.AttendanceTableDataGridView.Location = New System.Drawing.Point(8, 135)
        Me.AttendanceTableDataGridView.Name = "AttendanceTableDataGridView"
        Me.AttendanceTableDataGridView.RowHeadersWidth = 25
        Me.AttendanceTableDataGridView.Size = New System.Drawing.Size(1255, 555)
        Me.AttendanceTableDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LogID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LogID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LogDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LogDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DayName
        '
        Me.DayName.HeaderText = "Day"
        Me.DayName.Name = "DayName"
        Me.DayName.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TimeIn"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TimeIn"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TimeOut"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TimeOut"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'MorningLate
        '
        Me.MorningLate.HeaderText = "MorningLate"
        Me.MorningLate.Name = "MorningLate"
        Me.MorningLate.ReadOnly = True
        '
        'EveningLate
        '
        Me.EveningLate.HeaderText = "EveningLate"
        Me.EveningLate.Name = "EveningLate"
        Me.EveningLate.ReadOnly = True
        '
        'SumLate
        '
        Me.SumLate.HeaderText = "SumLate"
        Me.SumLate.Name = "SumLate"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LanchOut"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LanchOut"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LanchIn"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LanchIn"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'TB_monthSalary
        '
        Me.TB_monthSalary.Location = New System.Drawing.Point(121, 21)
        Me.TB_monthSalary.Name = "TB_monthSalary"
        Me.TB_monthSalary.Size = New System.Drawing.Size(91, 22)
        Me.TB_monthSalary.TabIndex = 4
        Me.TB_monthSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Monthly Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Day Salary"
        '
        'TB_DaySalary
        '
        Me.TB_DaySalary.Location = New System.Drawing.Point(121, 49)
        Me.TB_DaySalary.Name = "TB_DaySalary"
        Me.TB_DaySalary.ReadOnly = True
        Me.TB_DaySalary.Size = New System.Drawing.Size(91, 22)
        Me.TB_DaySalary.TabIndex = 6
        Me.TB_DaySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hour Salary"
        '
        'TB_HourSalary
        '
        Me.TB_HourSalary.Location = New System.Drawing.Point(121, 77)
        Me.TB_HourSalary.Name = "TB_HourSalary"
        Me.TB_HourSalary.ReadOnly = True
        Me.TB_HourSalary.Size = New System.Drawing.Size(91, 22)
        Me.TB_HourSalary.TabIndex = 8
        Me.TB_HourSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_monthSalary)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_HourSalary)
        Me.GroupBox2.Controls.Add(Me.TB_DaySalary)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 121)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salary"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TB_Money)
        Me.GroupBox3.Controls.Add(Me.LB_DayAbsent)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TB_DayAbsent)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TB_TotalLate)
        Me.GroupBox3.Location = New System.Drawing.Point(671, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(383, 121)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Money:"
        '
        'TB_Money
        '
        Me.TB_Money.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Money.Location = New System.Drawing.Point(102, 87)
        Me.TB_Money.Name = "TB_Money"
        Me.TB_Money.Size = New System.Drawing.Size(107, 27)
        Me.TB_Money.TabIndex = 13
        Me.TB_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_DayAbsent
        '
        Me.LB_DayAbsent.FormattingEnabled = True
        Me.LB_DayAbsent.ItemHeight = 14
        Me.LB_DayAbsent.Location = New System.Drawing.Point(215, 22)
        Me.LB_DayAbsent.Name = "LB_DayAbsent"
        Me.LB_DayAbsent.Size = New System.Drawing.Size(162, 88)
        Me.LB_DayAbsent.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Day Absent:"
        '
        'TB_DayAbsent
        '
        Me.TB_DayAbsent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DayAbsent.Location = New System.Drawing.Point(102, 54)
        Me.TB_DayAbsent.Name = "TB_DayAbsent"
        Me.TB_DayAbsent.Size = New System.Drawing.Size(107, 27)
        Me.TB_DayAbsent.TabIndex = 2
        Me.TB_DayAbsent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Late:"
        '
        'TB_TotalLate
        '
        Me.TB_TotalLate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TotalLate.Location = New System.Drawing.Point(102, 21)
        Me.TB_TotalLate.Name = "TB_TotalLate"
        Me.TB_TotalLate.ReadOnly = True
        Me.TB_TotalLate.Size = New System.Drawing.Size(107, 27)
        Me.TB_TotalLate.TabIndex = 0
        Me.TB_TotalLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AttendanceTableTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = AttendanceControls.ACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableTableAdapter = Nothing
        Me.TableAdapterManager1.VariableTableTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Get"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Bu_LoadSalaryFile
        '
        Me.Bu_LoadSalaryFile.Location = New System.Drawing.Point(1060, 23)
        Me.Bu_LoadSalaryFile.Name = "Bu_LoadSalaryFile"
        Me.Bu_LoadSalaryFile.Size = New System.Drawing.Size(96, 41)
        Me.Bu_LoadSalaryFile.TabIndex = 12
        Me.Bu_LoadSalaryFile.Text = "Load Salary File"
        Me.Bu_LoadSalaryFile.UseVisualStyleBackColor = True
        '
        'MonthlySalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1281, 702)
        Me.Controls.Add(Me.Bu_LoadSalaryFile)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AttendanceTableDataGridView)
        Me.Controls.Add(Me.UsersTableBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MorningTimeRoundTextBox)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(1088, 38)
        Me.Name = "MonthlySalary"
        Me.Text = "Monthly Salary Calculation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlySalaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersTableBindingNavigator.ResumeLayout(False)
        Me.UsersTableBindingNavigator.PerformLayout()
        CType(Me.VariableTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthlySalaryDataSet As MonthlySalaryDataSet
    Friend WithEvents UsersTableBindingSource As BindingSource
    Friend WithEvents UsersTableTableAdapter As MonthlySalaryDataSetTableAdapters.UsersTableTableAdapter
    Friend WithEvents TableAdapterManager As MonthlySalaryDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents SectionTextBox As TextBox
    Friend WithEvents UsernameComboBox As ComboBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents CB_Year As ComboBox
    Friend WithEvents CB_Month As ComboBox
    Friend WithEvents VariableTableTableAdapter As MonthlySalaryDataSetTableAdapters.VariableTableTableAdapter
    Friend WithEvents VariableTableBindingSource As BindingSource
    Friend WithEvents AttendanceTableTableAdapter As MonthlySalaryDataSetTableAdapters.AttendanceTableTableAdapter
    Friend WithEvents MorningTimeRoundTextBox As TextBox
    Friend WithEvents AttendanceTableBindingSource As BindingSource
    Friend WithEvents AttendanceTableDataGridView As DataGridView
    Friend WithEvents TB_monthSalary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_DaySalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_HourSalary As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bu_Get As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TB_TotalLate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DayName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents MorningLate As DataGridViewTextBoxColumn
    Friend WithEvents EveningLate As DataGridViewTextBoxColumn
    Friend WithEvents SumLate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_DayAbsent As TextBox
    Friend WithEvents LB_DayAbsent As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Money As TextBox
    Friend WithEvents TableAdapterManager1 As ACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Bu_LoadSalaryFile As Button
End Class
