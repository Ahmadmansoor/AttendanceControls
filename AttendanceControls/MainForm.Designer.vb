<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim LogDateLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bu_SaveTimeTrim = New System.Windows.Forms.Button()
        Me.Bu_FixTime = New System.Windows.Forms.Button()
        Me.MorningTimeRoundTextBox = New System.Windows.Forms.TextBox()
        Me.VariableTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACDataSet = New AttendanceControls.ACDataSet()
        Me.Bu_mdown = New System.Windows.Forms.Button()
        Me.Bu_hdown = New System.Windows.Forms.Button()
        Me.Bu_mUp = New System.Windows.Forms.Button()
        Me.Bu_hUp = New System.Windows.Forms.Button()
        Me.AttendanceTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableTableAdapter = New AttendanceControls.ACDataSetTableAdapters.AttendanceTableTableAdapter()
        Me.TableAdapterManager = New AttendanceControls.ACDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableTableAdapter = New AttendanceControls.ACDataSetTableAdapters.UsersTableTableAdapter()
        Me.AttendanceTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AttendanceTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AttendanceTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.LogID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernameComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Bu_Absent = New System.Windows.Forms.Button()
        Me.TB_count = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_TimeOutCheck = New System.Windows.Forms.TextBox()
        Me.CB4 = New System.Windows.Forms.CheckBox()
        Me.TB_TimeInCheck = New System.Windows.Forms.TextBox()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.CB2 = New System.Windows.Forms.CheckBox()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.DTP_GetDataByTimeMin = New System.Windows.Forms.DateTimePicker()
        Me.Bu_GetDataByTime = New System.Windows.Forms.Button()
        Me.DTP_GetDataByTimeMax = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bu_OverTime = New System.Windows.Forms.Button()
        Me.BU_ExcelPrint = New System.Windows.Forms.Button()
        Me.BU_print = New System.Windows.Forms.Button()
        Me.BU_Add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_AddOutTime = New System.Windows.Forms.TextBox()
        Me.TB_AddInTime = New System.Windows.Forms.TextBox()
        Me.Bu_Addmd = New System.Windows.Forms.Button()
        Me.Bu_Addhd = New System.Windows.Forms.Button()
        Me.Bu_AddmUp = New System.Windows.Forms.Button()
        Me.Bu_AddhUp = New System.Windows.Forms.Button()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.TimePickerAdd = New System.Windows.Forms.DateTimePicker()
        Me.CB_AddData = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Bu_Cal = New System.Windows.Forms.Button()
        Me.TB_HourCalc = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Bu_Edit = New System.Windows.Forms.Button()
        Me.CB_Year = New System.Windows.Forms.ComboBox()
        Me.Bu_GetData = New System.Windows.Forms.Button()
        Me.CB_Month = New System.Windows.Forms.ComboBox()
        Me.VariableTableTableAdapter = New AttendanceControls.ACDataSetTableAdapters.VariableTableTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ReportPrintDataSet = New AttendanceControls.ReportPrintDataSet()
        Me.AttendancePrintTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        UsernameLabel = New System.Windows.Forms.Label()
        LogDateLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VariableTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendanceTableBindingNavigator.SuspendLayout()
        CType(Me.AttendanceTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ReportPrintDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendancePrintTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(8, 28)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(77, 16)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "Username:"
        '
        'LogDateLabel
        '
        LogDateLabel.AutoSize = True
        LogDateLabel.Location = New System.Drawing.Point(6, 58)
        LogDateLabel.Name = "LogDateLabel"
        LogDateLabel.Size = New System.Drawing.Size(71, 16)
        LogDateLabel.TabIndex = 5
        LogDateLabel.Text = "Log Date:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(7, 85)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(61, 16)
        SectionLabel.TabIndex = 6
        SectionLabel.Text = "Section:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bu_SaveTimeTrim)
        Me.GroupBox1.Controls.Add(Me.Bu_FixTime)
        Me.GroupBox1.Controls.Add(Me.MorningTimeRoundTextBox)
        Me.GroupBox1.Controls.Add(Me.Bu_mdown)
        Me.GroupBox1.Controls.Add(Me.Bu_hdown)
        Me.GroupBox1.Controls.Add(Me.Bu_mUp)
        Me.GroupBox1.Controls.Add(Me.Bu_hUp)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(146, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Trim"
        '
        'Bu_SaveTimeTrim
        '
        Me.Bu_SaveTimeTrim.Location = New System.Drawing.Point(74, 75)
        Me.Bu_SaveTimeTrim.Name = "Bu_SaveTimeTrim"
        Me.Bu_SaveTimeTrim.Size = New System.Drawing.Size(63, 34)
        Me.Bu_SaveTimeTrim.TabIndex = 11
        Me.Bu_SaveTimeTrim.Text = "Save"
        Me.Bu_SaveTimeTrim.UseVisualStyleBackColor = True
        '
        'Bu_FixTime
        '
        Me.Bu_FixTime.Location = New System.Drawing.Point(74, 26)
        Me.Bu_FixTime.Name = "Bu_FixTime"
        Me.Bu_FixTime.Size = New System.Drawing.Size(63, 34)
        Me.Bu_FixTime.TabIndex = 10
        Me.Bu_FixTime.Text = "FixTime"
        Me.Bu_FixTime.UseVisualStyleBackColor = True
        '
        'MorningTimeRoundTextBox
        '
        Me.MorningTimeRoundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariableTableBindingSource, "MorningTimeRound", True))
        Me.MorningTimeRoundTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MorningTimeRoundTextBox.Location = New System.Drawing.Point(13, 26)
        Me.MorningTimeRoundTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MorningTimeRoundTextBox.Name = "MorningTimeRoundTextBox"
        Me.MorningTimeRoundTextBox.ReadOnly = True
        Me.MorningTimeRoundTextBox.Size = New System.Drawing.Size(54, 27)
        Me.MorningTimeRoundTextBox.TabIndex = 10
        Me.MorningTimeRoundTextBox.Text = "08:00"
        '
        'VariableTableBindingSource
        '
        Me.VariableTableBindingSource.DataMember = "VariableTable"
        Me.VariableTableBindingSource.DataSource = Me.ACDataSet
        '
        'ACDataSet
        '
        Me.ACDataSet.DataSetName = "ACDataSet"
        Me.ACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bu_mdown
        '
        Me.Bu_mdown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_mdown.Location = New System.Drawing.Point(42, 87)
        Me.Bu_mdown.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_mdown.Name = "Bu_mdown"
        Me.Bu_mdown.Size = New System.Drawing.Size(24, 22)
        Me.Bu_mdown.TabIndex = 9
        Me.Bu_mdown.Text = "˅"
        Me.Bu_mdown.UseVisualStyleBackColor = True
        '
        'Bu_hdown
        '
        Me.Bu_hdown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_hdown.Location = New System.Drawing.Point(13, 87)
        Me.Bu_hdown.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_hdown.Name = "Bu_hdown"
        Me.Bu_hdown.Size = New System.Drawing.Size(24, 22)
        Me.Bu_hdown.TabIndex = 8
        Me.Bu_hdown.Text = "˅"
        Me.Bu_hdown.UseVisualStyleBackColor = True
        '
        'Bu_mUp
        '
        Me.Bu_mUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_mUp.Location = New System.Drawing.Point(42, 61)
        Me.Bu_mUp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_mUp.Name = "Bu_mUp"
        Me.Bu_mUp.Size = New System.Drawing.Size(24, 22)
        Me.Bu_mUp.TabIndex = 7
        Me.Bu_mUp.Text = "^"
        Me.Bu_mUp.UseVisualStyleBackColor = True
        '
        'Bu_hUp
        '
        Me.Bu_hUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_hUp.Location = New System.Drawing.Point(13, 61)
        Me.Bu_hUp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_hUp.Name = "Bu_hUp"
        Me.Bu_hUp.Size = New System.Drawing.Size(24, 22)
        Me.Bu_hUp.TabIndex = 6
        Me.Bu_hUp.Text = "^"
        Me.Bu_hUp.UseVisualStyleBackColor = True
        '
        'AttendanceTableBindingSource
        '
        Me.AttendanceTableBindingSource.DataMember = "AttendanceTable"
        Me.AttendanceTableBindingSource.DataSource = Me.ACDataSet
        '
        'AttendanceTableTableAdapter
        '
        Me.AttendanceTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableTableAdapter = Me.AttendanceTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = AttendanceControls.ACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableTableAdapter = Me.UsersTableTableAdapter
        Me.TableAdapterManager.VariableTableTableAdapter = Nothing
        '
        'UsersTableTableAdapter
        '
        Me.UsersTableTableAdapter.ClearBeforeFill = True
        '
        'AttendanceTableBindingNavigator
        '
        Me.AttendanceTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AttendanceTableBindingNavigator.BindingSource = Me.AttendanceTableBindingSource
        Me.AttendanceTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AttendanceTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AttendanceTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AttendanceTableBindingNavigatorSaveItem})
        Me.AttendanceTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AttendanceTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AttendanceTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AttendanceTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AttendanceTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AttendanceTableBindingNavigator.Name = "AttendanceTableBindingNavigator"
        Me.AttendanceTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AttendanceTableBindingNavigator.Size = New System.Drawing.Size(1185, 25)
        Me.AttendanceTableBindingNavigator.TabIndex = 1
        Me.AttendanceTableBindingNavigator.Text = "BindingNavigator1"
        Me.AttendanceTableBindingNavigator.Visible = False
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
        'AttendanceTableBindingNavigatorSaveItem
        '
        Me.AttendanceTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendanceTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendanceTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendanceTableBindingNavigatorSaveItem.Name = "AttendanceTableBindingNavigatorSaveItem"
        Me.AttendanceTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AttendanceTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AttendanceTableDataGridView
        '
        Me.AttendanceTableDataGridView.AllowUserToAddRows = False
        Me.AttendanceTableDataGridView.AllowUserToDeleteRows = False
        Me.AttendanceTableDataGridView.AllowUserToOrderColumns = True
        Me.AttendanceTableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttendanceTableDataGridView.AutoGenerateColumns = False
        Me.AttendanceTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceTableDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.AttendanceTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendanceTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DayName})
        Me.AttendanceTableDataGridView.DataSource = Me.AttendanceTableBindingSource
        Me.AttendanceTableDataGridView.Location = New System.Drawing.Point(12, 175)
        Me.AttendanceTableDataGridView.Name = "AttendanceTableDataGridView"
        Me.AttendanceTableDataGridView.ReadOnly = True
        Me.AttendanceTableDataGridView.RowHeadersWidth = 10
        Me.AttendanceTableDataGridView.Size = New System.Drawing.Size(1221, 467)
        Me.AttendanceTableDataGridView.TabIndex = 2
        '
        'LogID
        '
        Me.LogID.DataPropertyName = "LogID"
        Me.LogID.HeaderText = "LogID"
        Me.LogID.Name = "LogID"
        Me.LogID.ReadOnly = True
        Me.LogID.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LanchOut"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LanchOut"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LanchIn"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LanchIn"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DayName
        '
        Me.DayName.HeaderText = "Day"
        Me.DayName.Name = "DayName"
        Me.DayName.ReadOnly = True
        '
        'UsersTableBindingSource
        '
        Me.UsersTableBindingSource.DataMember = "UsersTable"
        Me.UsersTableBindingSource.DataSource = Me.ACDataSet
        '
        'UsernameComboBox
        '
        Me.UsernameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UsernameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UsernameComboBox.DataSource = Me.UsersTableBindingSource
        Me.UsernameComboBox.DisplayMember = "Username"
        Me.UsernameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsernameComboBox.DropDownWidth = 250
        Me.UsernameComboBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameComboBox.FormattingEnabled = True
        Me.UsernameComboBox.Location = New System.Drawing.Point(131, 25)
        Me.UsernameComboBox.Name = "UsernameComboBox"
        Me.UsernameComboBox.Size = New System.Drawing.Size(147, 24)
        Me.UsernameComboBox.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.AttendanceTableDataGridView)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1239, 684)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 648)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1221, 30)
        Me.ProgressBar1.TabIndex = 24
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Bu_Absent)
        Me.GroupBox5.Controls.Add(Me.TB_count)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.TB_TimeOutCheck)
        Me.GroupBox5.Controls.Add(Me.CB4)
        Me.GroupBox5.Controls.Add(Me.TB_TimeInCheck)
        Me.GroupBox5.Controls.Add(Me.CB3)
        Me.GroupBox5.Controls.Add(Me.CB2)
        Me.GroupBox5.Controls.Add(Me.CB1)
        Me.GroupBox5.Controls.Add(Me.DTP_GetDataByTimeMin)
        Me.GroupBox5.Controls.Add(Me.Bu_GetDataByTime)
        Me.GroupBox5.Controls.Add(Me.DTP_GetDataByTimeMax)
        Me.GroupBox5.Location = New System.Drawing.Point(955, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(275, 151)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Get Data By Day"
        '
        'Bu_Absent
        '
        Me.Bu_Absent.Location = New System.Drawing.Point(168, 61)
        Me.Bu_Absent.Name = "Bu_Absent"
        Me.Bu_Absent.Size = New System.Drawing.Size(101, 36)
        Me.Bu_Absent.TabIndex = 32
        Me.Bu_Absent.Text = "Get Absent"
        Me.Bu_Absent.UseVisualStyleBackColor = True
        '
        'TB_count
        '
        Me.TB_count.Location = New System.Drawing.Point(168, 114)
        Me.TB_count.Name = "TB_count"
        Me.TB_count.Size = New System.Drawing.Size(101, 23)
        Me.TB_count.TabIndex = 7
        Me.TB_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "IN"
        '
        'TB_TimeOutCheck
        '
        Me.TB_TimeOutCheck.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TimeOutCheck.Location = New System.Drawing.Point(28, 109)
        Me.TB_TimeOutCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_TimeOutCheck.Name = "TB_TimeOutCheck"
        Me.TB_TimeOutCheck.Size = New System.Drawing.Size(54, 26)
        Me.TB_TimeOutCheck.TabIndex = 29
        Me.TB_TimeOutCheck.Text = "18:00"
        Me.TB_TimeOutCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB4
        '
        Me.CB4.AutoSize = True
        Me.CB4.Location = New System.Drawing.Point(6, 116)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(15, 14)
        Me.CB4.TabIndex = 28
        Me.CB4.UseVisualStyleBackColor = True
        '
        'TB_TimeInCheck
        '
        Me.TB_TimeInCheck.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TimeInCheck.Location = New System.Drawing.Point(28, 79)
        Me.TB_TimeInCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_TimeInCheck.Name = "TB_TimeInCheck"
        Me.TB_TimeInCheck.Size = New System.Drawing.Size(54, 26)
        Me.TB_TimeInCheck.TabIndex = 27
        Me.TB_TimeInCheck.Text = "08:25"
        Me.TB_TimeInCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.Location = New System.Drawing.Point(6, 86)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(15, 14)
        Me.CB3.TabIndex = 26
        Me.CB3.UseVisualStyleBackColor = True
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.Location = New System.Drawing.Point(6, 56)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(15, 14)
        Me.CB2.TabIndex = 25
        Me.CB2.UseVisualStyleBackColor = True
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.Location = New System.Drawing.Point(6, 28)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(15, 14)
        Me.CB1.TabIndex = 24
        Me.CB1.UseVisualStyleBackColor = True
        '
        'DTP_GetDataByTimeMin
        '
        Me.DTP_GetDataByTimeMin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_GetDataByTimeMin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_GetDataByTimeMin.Location = New System.Drawing.Point(27, 20)
        Me.DTP_GetDataByTimeMin.Name = "DTP_GetDataByTimeMin"
        Me.DTP_GetDataByTimeMin.Size = New System.Drawing.Size(135, 22)
        Me.DTP_GetDataByTimeMin.TabIndex = 23
        '
        'Bu_GetDataByTime
        '
        Me.Bu_GetDataByTime.Location = New System.Drawing.Point(168, 22)
        Me.Bu_GetDataByTime.Name = "Bu_GetDataByTime"
        Me.Bu_GetDataByTime.Size = New System.Drawing.Size(101, 36)
        Me.Bu_GetDataByTime.TabIndex = 22
        Me.Bu_GetDataByTime.Text = "Get"
        Me.Bu_GetDataByTime.UseVisualStyleBackColor = True
        '
        'DTP_GetDataByTimeMax
        '
        Me.DTP_GetDataByTimeMax.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_GetDataByTimeMax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_GetDataByTimeMax.Location = New System.Drawing.Point(27, 50)
        Me.DTP_GetDataByTimeMax.Name = "DTP_GetDataByTimeMax"
        Me.DTP_GetDataByTimeMax.Size = New System.Drawing.Size(135, 22)
        Me.DTP_GetDataByTimeMax.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BU_Add)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TB_AddOutTime)
        Me.GroupBox3.Controls.Add(Me.TB_AddInTime)
        Me.GroupBox3.Controls.Add(Me.Bu_Addmd)
        Me.GroupBox3.Controls.Add(Me.Bu_Addhd)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Bu_AddmUp)
        Me.GroupBox3.Controls.Add(Me.Bu_AddhUp)
        Me.GroupBox3.Controls.Add(SectionLabel)
        Me.GroupBox3.Controls.Add(Me.SectionTextBox)
        Me.GroupBox3.Controls.Add(LogDateLabel)
        Me.GroupBox3.Controls.Add(Me.TimePickerAdd)
        Me.GroupBox3.Controls.Add(Me.CB_AddData)
        Me.GroupBox3.Location = New System.Drawing.Point(309, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 152)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Value"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Bu_OverTime)
        Me.GroupBox4.Controls.Add(Me.BU_ExcelPrint)
        Me.GroupBox4.Controls.Add(Me.BU_print)
        Me.GroupBox4.Location = New System.Drawing.Point(800, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(149, 151)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Print"
        '
        'Bu_OverTime
        '
        Me.Bu_OverTime.Location = New System.Drawing.Point(8, 78)
        Me.Bu_OverTime.Name = "Bu_OverTime"
        Me.Bu_OverTime.Size = New System.Drawing.Size(133, 23)
        Me.Bu_OverTime.TabIndex = 3
        Me.Bu_OverTime.Text = "TrimOverTime"
        Me.Bu_OverTime.UseVisualStyleBackColor = True
        '
        'BU_ExcelPrint
        '
        Me.BU_ExcelPrint.Location = New System.Drawing.Point(8, 49)
        Me.BU_ExcelPrint.Name = "BU_ExcelPrint"
        Me.BU_ExcelPrint.Size = New System.Drawing.Size(135, 23)
        Me.BU_ExcelPrint.TabIndex = 2
        Me.BU_ExcelPrint.Text = "Print/Excel"
        Me.BU_ExcelPrint.UseVisualStyleBackColor = True
        '
        'BU_print
        '
        Me.BU_print.Enabled = False
        Me.BU_print.Location = New System.Drawing.Point(8, 20)
        Me.BU_print.Name = "BU_print"
        Me.BU_print.Size = New System.Drawing.Size(135, 23)
        Me.BU_print.TabIndex = 0
        Me.BU_print.Text = "Print/Printer"
        Me.BU_print.UseVisualStyleBackColor = True
        '
        'BU_Add
        '
        Me.BU_Add.Location = New System.Drawing.Point(105, 112)
        Me.BU_Add.Name = "BU_Add"
        Me.BU_Add.Size = New System.Drawing.Size(94, 23)
        Me.BU_Add.TabIndex = 19
        Me.BU_Add.Text = "Add"
        Me.BU_Add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "OutTime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "InTime"
        '
        'TB_AddOutTime
        '
        Me.TB_AddOutTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AddOutTime.Location = New System.Drawing.Point(266, 41)
        Me.TB_AddOutTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_AddOutTime.Name = "TB_AddOutTime"
        Me.TB_AddOutTime.ReadOnly = True
        Me.TB_AddOutTime.Size = New System.Drawing.Size(54, 27)
        Me.TB_AddOutTime.TabIndex = 16
        Me.TB_AddOutTime.Text = "18:00"
        '
        'TB_AddInTime
        '
        Me.TB_AddInTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AddInTime.Location = New System.Drawing.Point(206, 41)
        Me.TB_AddInTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_AddInTime.Name = "TB_AddInTime"
        Me.TB_AddInTime.ReadOnly = True
        Me.TB_AddInTime.Size = New System.Drawing.Size(54, 27)
        Me.TB_AddInTime.TabIndex = 15
        Me.TB_AddInTime.Text = "08:00"
        '
        'Bu_Addmd
        '
        Me.Bu_Addmd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_Addmd.Location = New System.Drawing.Point(265, 102)
        Me.Bu_Addmd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_Addmd.Name = "Bu_Addmd"
        Me.Bu_Addmd.Size = New System.Drawing.Size(24, 22)
        Me.Bu_Addmd.TabIndex = 14
        Me.Bu_Addmd.Text = "˅"
        Me.Bu_Addmd.UseVisualStyleBackColor = True
        '
        'Bu_Addhd
        '
        Me.Bu_Addhd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_Addhd.Location = New System.Drawing.Point(236, 102)
        Me.Bu_Addhd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_Addhd.Name = "Bu_Addhd"
        Me.Bu_Addhd.Size = New System.Drawing.Size(24, 22)
        Me.Bu_Addhd.TabIndex = 13
        Me.Bu_Addhd.Text = "˅"
        Me.Bu_Addhd.UseVisualStyleBackColor = True
        '
        'Bu_AddmUp
        '
        Me.Bu_AddmUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_AddmUp.Location = New System.Drawing.Point(265, 76)
        Me.Bu_AddmUp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_AddmUp.Name = "Bu_AddmUp"
        Me.Bu_AddmUp.Size = New System.Drawing.Size(24, 22)
        Me.Bu_AddmUp.TabIndex = 12
        Me.Bu_AddmUp.Text = "^"
        Me.Bu_AddmUp.UseVisualStyleBackColor = True
        '
        'Bu_AddhUp
        '
        Me.Bu_AddhUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_AddhUp.Location = New System.Drawing.Point(236, 76)
        Me.Bu_AddhUp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Bu_AddhUp.Name = "Bu_AddhUp"
        Me.Bu_AddhUp.Size = New System.Drawing.Size(24, 22)
        Me.Bu_AddhUp.TabIndex = 11
        Me.Bu_AddhUp.Text = "^"
        Me.Bu_AddhUp.UseVisualStyleBackColor = True
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "Section", True))
        Me.SectionTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionTextBox.Location = New System.Drawing.Point(74, 84)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.ReadOnly = True
        Me.SectionTextBox.Size = New System.Drawing.Size(124, 22)
        Me.SectionTextBox.TabIndex = 7
        '
        'TimePickerAdd
        '
        Me.TimePickerAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TimePickerAdd.Location = New System.Drawing.Point(83, 56)
        Me.TimePickerAdd.Name = "TimePickerAdd"
        Me.TimePickerAdd.Size = New System.Drawing.Size(115, 22)
        Me.TimePickerAdd.TabIndex = 6
        '
        'CB_AddData
        '
        Me.CB_AddData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_AddData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_AddData.DataSource = Me.UsersTableBindingSource
        Me.CB_AddData.DisplayMember = "Username"
        Me.CB_AddData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_AddData.DropDownWidth = 250
        Me.CB_AddData.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_AddData.FormattingEnabled = True
        Me.CB_AddData.Location = New System.Drawing.Point(10, 24)
        Me.CB_AddData.Name = "CB_AddData"
        Me.CB_AddData.Size = New System.Drawing.Size(189, 24)
        Me.CB_AddData.TabIndex = 5
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Bu_Cal)
        Me.GroupBox6.Controls.Add(Me.TB_HourCalc)
        Me.GroupBox6.Controls.Add(UsernameLabel)
        Me.GroupBox6.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox6.Controls.Add(Me.Bu_Edit)
        Me.GroupBox6.Controls.Add(Me.UsernameComboBox)
        Me.GroupBox6.Controls.Add(Me.CB_Year)
        Me.GroupBox6.Controls.Add(Me.Bu_GetData)
        Me.GroupBox6.Controls.Add(Me.CB_Month)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(291, 151)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Get Data By Name"
        '
        'Bu_Cal
        '
        Me.Bu_Cal.Location = New System.Drawing.Point(11, 120)
        Me.Bu_Cal.Name = "Bu_Cal"
        Me.Bu_Cal.Size = New System.Drawing.Size(67, 27)
        Me.Bu_Cal.TabIndex = 26
        Me.Bu_Cal.Text = "Hour"
        Me.Bu_Cal.UseVisualStyleBackColor = True
        '
        'TB_HourCalc
        '
        Me.TB_HourCalc.Location = New System.Drawing.Point(86, 122)
        Me.TB_HourCalc.Name = "TB_HourCalc"
        Me.TB_HourCalc.Size = New System.Drawing.Size(180, 23)
        Me.TB_HourCalc.TabIndex = 25
        Me.TB_HourCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersTableBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(89, 25)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.ReadOnly = True
        Me.UserIDTextBox.Size = New System.Drawing.Size(36, 23)
        Me.UserIDTextBox.TabIndex = 8
        Me.UserIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bu_Edit
        '
        Me.Bu_Edit.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_Edit.Location = New System.Drawing.Point(188, 85)
        Me.Bu_Edit.Name = "Bu_Edit"
        Me.Bu_Edit.Size = New System.Drawing.Size(78, 33)
        Me.Bu_Edit.TabIndex = 9
        Me.Bu_Edit.Text = "Edit"
        Me.Bu_Edit.UseVisualStyleBackColor = True
        '
        'CB_Year
        '
        Me.CB_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Year.FormattingEnabled = True
        Me.CB_Year.Items.AddRange(New Object() {"2016", "2017", "2018", "2019"})
        Me.CB_Year.Location = New System.Drawing.Point(89, 55)
        Me.CB_Year.Name = "CB_Year"
        Me.CB_Year.Size = New System.Drawing.Size(62, 24)
        Me.CB_Year.TabIndex = 5
        '
        'Bu_GetData
        '
        Me.Bu_GetData.Location = New System.Drawing.Point(86, 84)
        Me.Bu_GetData.Name = "Bu_GetData"
        Me.Bu_GetData.Size = New System.Drawing.Size(96, 34)
        Me.Bu_GetData.TabIndex = 7
        Me.Bu_GetData.Text = "Get Data"
        Me.Bu_GetData.UseVisualStyleBackColor = True
        '
        'CB_Month
        '
        Me.CB_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Month.FormattingEnabled = True
        Me.CB_Month.Items.AddRange(New Object() {"1-January", "2-February", "3-March", "4-April", "5-May", "6-June", "7-July", "8-August", "9-September", "10-October", "11-November", "12-December"})
        Me.CB_Month.Location = New System.Drawing.Point(157, 55)
        Me.CB_Month.Name = "CB_Month"
        Me.CB_Month.Size = New System.Drawing.Size(121, 24)
        Me.CB_Month.TabIndex = 6
        '
        'VariableTableTableAdapter
        '
        Me.VariableTableTableAdapter.ClearBeforeFill = True
        '
        'ReportPrintDataSet
        '
        Me.ReportPrintDataSet.DataSetName = "ReportPrintDataSet"
        Me.ReportPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendancePrintTableBindingSource
        '
        Me.AttendancePrintTableBindingSource.DataMember = "AttendancePrintTable"
        Me.AttendancePrintTableBindingSource.DataSource = Me.ReportPrintDataSet
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1253, 701)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AttendanceTableBindingNavigator)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "MainForm"
        Me.Text = "Edit Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VariableTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendanceTableBindingNavigator.ResumeLayout(False)
        Me.AttendanceTableBindingNavigator.PerformLayout()
        CType(Me.AttendanceTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ReportPrintDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendancePrintTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bu_mdown As Button
    Friend WithEvents Bu_hdown As Button
    Friend WithEvents Bu_mUp As Button
    Friend WithEvents Bu_hUp As Button
    Friend WithEvents ACDataSet As ACDataSet
    Friend WithEvents AttendanceTableBindingSource As BindingSource
    Friend WithEvents AttendanceTableTableAdapter As ACDataSetTableAdapters.AttendanceTableTableAdapter
    Friend WithEvents TableAdapterManager As ACDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AttendanceTableBindingNavigator As BindingNavigator
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
    Friend WithEvents AttendanceTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AttendanceTableDataGridView As DataGridView
    Friend WithEvents UsersTableTableAdapter As ACDataSetTableAdapters.UsersTableTableAdapter
    Friend WithEvents UsersTableBindingSource As BindingSource
    Friend WithEvents UsernameComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MorningTimeRoundTextBox As TextBox
    Friend WithEvents Bu_GetData As Button
    Friend WithEvents CB_Month As ComboBox
    Friend WithEvents CB_Year As ComboBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents Bu_Edit As Button
    Friend WithEvents Bu_FixTime As Button
    Friend WithEvents Bu_SaveTimeTrim As Button
    Friend WithEvents VariableTableBindingSource As BindingSource
    Friend WithEvents VariableTableTableAdapter As ACDataSetTableAdapters.VariableTableTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CB_AddData As ComboBox
    Friend WithEvents TimePickerAdd As DateTimePicker
    Friend WithEvents SectionTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_AddOutTime As TextBox
    Friend WithEvents TB_AddInTime As TextBox
    Friend WithEvents Bu_Addmd As Button
    Friend WithEvents Bu_Addhd As Button
    Friend WithEvents Bu_AddmUp As Button
    Friend WithEvents Bu_AddhUp As Button
    Friend WithEvents BU_Add As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BU_print As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BU_ExcelPrint As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DTP_GetDataByTimeMax As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Bu_GetDataByTime As Button
    Friend WithEvents DTP_GetDataByTimeMin As DateTimePicker
    Friend WithEvents TB_TimeInCheck As TextBox
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents CB2 As CheckBox
    Friend WithEvents CB1 As CheckBox
    Friend WithEvents TB_TimeOutCheck As TextBox
    Friend WithEvents CB4 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_count As TextBox
    Friend WithEvents LogID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DayName As DataGridViewTextBoxColumn
    Friend WithEvents Bu_Absent As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Bu_Cal As Button
    Friend WithEvents TB_HourCalc As TextBox
    Friend WithEvents ReportPrintDataSet As ReportPrintDataSet
    Friend WithEvents AttendancePrintTableBindingSource As BindingSource
    Friend WithEvents Bu_OverTime As Button
End Class
