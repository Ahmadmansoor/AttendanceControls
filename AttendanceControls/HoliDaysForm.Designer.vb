<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoliDaysForm
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
        Dim ReasonLabel As System.Windows.Forms.Label
        Dim DateDayLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HoliDaysForm))
        Me.MonthlySalaryDataSet = New AttendanceControls.MonthlySalaryDataSet()
        Me.HolidayTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HolidayTableTableAdapter = New AttendanceControls.MonthlySalaryDataSetTableAdapters.HolidayTableTableAdapter()
        Me.TableAdapterManager = New AttendanceControls.MonthlySalaryDataSetTableAdapters.TableAdapterManager()
        Me.HolidayTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HolidayTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ReasonTextBox = New System.Windows.Forms.TextBox()
        Me.DateDayTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.HolidayTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ReasonLabel = New System.Windows.Forms.Label()
        DateDayLabel1 = New System.Windows.Forms.Label()
        CType(Me.MonthlySalaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HolidayTableBindingNavigator.SuspendLayout()
        CType(Me.HolidayTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReasonLabel
        '
        ReasonLabel.AutoSize = True
        ReasonLabel.Location = New System.Drawing.Point(12, 66)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(44, 13)
        ReasonLabel.TabIndex = 5
        ReasonLabel.Text = "reason:"
        '
        'DateDayLabel1
        '
        DateDayLabel1.AutoSize = True
        DateDayLabel1.Location = New System.Drawing.Point(6, 42)
        DateDayLabel1.Name = "DateDayLabel1"
        DateDayLabel1.Size = New System.Drawing.Size(56, 13)
        DateDayLabel1.TabIndex = 6
        DateDayLabel1.Text = "Date Day:"
        '
        'MonthlySalaryDataSet
        '
        Me.MonthlySalaryDataSet.DataSetName = "MonthlySalaryDataSet"
        Me.MonthlySalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HolidayTableBindingSource
        '
        Me.HolidayTableBindingSource.DataMember = "HolidayTable"
        Me.HolidayTableBindingSource.DataSource = Me.MonthlySalaryDataSet
        '
        'HolidayTableTableAdapter
        '
        Me.HolidayTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HolidayTableTableAdapter = Me.HolidayTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = AttendanceControls.MonthlySalaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfosTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableTableAdapter = Nothing
        Me.TableAdapterManager.VariableTableTableAdapter = Nothing
        '
        'HolidayTableBindingNavigator
        '
        Me.HolidayTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HolidayTableBindingNavigator.BindingSource = Me.HolidayTableBindingSource
        Me.HolidayTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HolidayTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HolidayTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HolidayTableBindingNavigatorSaveItem})
        Me.HolidayTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HolidayTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HolidayTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HolidayTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HolidayTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HolidayTableBindingNavigator.Name = "HolidayTableBindingNavigator"
        Me.HolidayTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HolidayTableBindingNavigator.Size = New System.Drawing.Size(382, 25)
        Me.HolidayTableBindingNavigator.TabIndex = 0
        Me.HolidayTableBindingNavigator.Text = "BindingNavigator1"
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
        'HolidayTableBindingNavigatorSaveItem
        '
        Me.HolidayTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HolidayTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("HolidayTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HolidayTableBindingNavigatorSaveItem.Name = "HolidayTableBindingNavigatorSaveItem"
        Me.HolidayTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HolidayTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidayTableBindingSource, "reason", True))
        Me.ReasonTextBox.Location = New System.Drawing.Point(68, 66)
        Me.ReasonTextBox.Multiline = True
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(306, 69)
        Me.ReasonTextBox.TabIndex = 6
        '
        'DateDayTextBox
        '
        Me.DateDayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidayTableBindingSource, "DateDay", True))
        Me.DateDayTextBox.Location = New System.Drawing.Point(68, 39)
        Me.DateDayTextBox.Name = "DateDayTextBox"
        Me.DateDayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateDayTextBox.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(174, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'HolidayTableDataGridView
        '
        Me.HolidayTableDataGridView.AllowUserToAddRows = False
        Me.HolidayTableDataGridView.AllowUserToDeleteRows = False
        Me.HolidayTableDataGridView.AutoGenerateColumns = False
        Me.HolidayTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HolidayTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HolidayTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.HolidayTableDataGridView.DataSource = Me.HolidayTableBindingSource
        Me.HolidayTableDataGridView.Location = New System.Drawing.Point(9, 141)
        Me.HolidayTableDataGridView.Name = "HolidayTableDataGridView"
        Me.HolidayTableDataGridView.RowHeadersWidth = 25
        Me.HolidayTableDataGridView.Size = New System.Drawing.Size(365, 154)
        Me.HolidayTableDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDHoliday"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDHoliday"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DateDay"
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "DateDay"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "reason"
        Me.DataGridViewTextBoxColumn3.HeaderText = "reason"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'HoliDaysForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 299)
        Me.Controls.Add(Me.HolidayTableDataGridView)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(DateDayLabel1)
        Me.Controls.Add(Me.DateDayTextBox)
        Me.Controls.Add(ReasonLabel)
        Me.Controls.Add(Me.ReasonTextBox)
        Me.Controls.Add(Me.HolidayTableBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HoliDaysForm"
        Me.Text = "HoliDaysForm"
        CType(Me.MonthlySalaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HolidayTableBindingNavigator.ResumeLayout(False)
        Me.HolidayTableBindingNavigator.PerformLayout()
        CType(Me.HolidayTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthlySalaryDataSet As MonthlySalaryDataSet
    Friend WithEvents HolidayTableBindingSource As BindingSource
    Friend WithEvents HolidayTableTableAdapter As MonthlySalaryDataSetTableAdapters.HolidayTableTableAdapter
    Friend WithEvents TableAdapterManager As MonthlySalaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HolidayTableBindingNavigator As BindingNavigator
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
    Friend WithEvents HolidayTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ReasonTextBox As TextBox
    Friend WithEvents DateDayTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents HolidayTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
