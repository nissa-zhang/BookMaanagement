<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Project_codeLabel As System.Windows.Forms.Label
        Dim Project_nameLabel As System.Windows.Forms.Label
        Dim Customer_codeLabel As System.Windows.Forms.Label
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim End_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Project_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_projectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Project_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Complete_flagCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tbl_projectTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_projectTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_customerTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_customerTableAdapter()
        Me.Tbl_jobTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_jobTableAdapter()
        Me.Tbl_staffTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Tbl_projectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_projectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Tbl_jobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_jobDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_code = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProjectjobDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Project_codeLabel = New System.Windows.Forms.Label()
        Project_nameLabel = New System.Windows.Forms.Label()
        Customer_codeLabel = New System.Windows.Forms.Label()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        End_dateLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_projectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_projectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_projectBindingNavigator.SuspendLayout()
        CType(Me.Tbl_jobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_jobDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectjobDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Project_codeLabel
        '
        Project_codeLabel.AutoSize = True
        Project_codeLabel.Location = New System.Drawing.Point(10, 18)
        Project_codeLabel.Name = "Project_codeLabel"
        Project_codeLabel.Size = New System.Drawing.Size(89, 12)
        Project_codeLabel.TabIndex = 0
        Project_codeLabel.Text = "プロジェクトコード："
        '
        'Project_nameLabel
        '
        Project_nameLabel.AutoSize = True
        Project_nameLabel.Location = New System.Drawing.Point(10, 43)
        Project_nameLabel.Name = "Project_nameLabel"
        Project_nameLabel.Size = New System.Drawing.Size(74, 12)
        Project_nameLabel.TabIndex = 2
        Project_nameLabel.Text = "プロジェクト名："
        '
        'Customer_codeLabel
        '
        Customer_codeLabel.AutoSize = True
        Customer_codeLabel.Location = New System.Drawing.Point(10, 68)
        Customer_codeLabel.Name = "Customer_codeLabel"
        Customer_codeLabel.Size = New System.Drawing.Size(35, 12)
        Customer_codeLabel.TabIndex = 4
        Customer_codeLabel.Text = "顧客："
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(10, 94)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(68, 12)
        Staff_codeLabel.TabIndex = 6
        Staff_codeLabel.Text = "マネージャー："
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Location = New System.Drawing.Point(10, 121)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(47, 12)
        Start_dateLabel.TabIndex = 8
        Start_dateLabel.Text = "開始日："
        '
        'End_dateLabel
        '
        End_dateLabel.AutoSize = True
        End_dateLabel.Location = New System.Drawing.Point(10, 146)
        End_dateLabel.Name = "End_dateLabel"
        End_dateLabel.Size = New System.Drawing.Size(47, 12)
        End_dateLabel.TabIndex = 10
        End_dateLabel.Text = "終了日："
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Project_codeLabel)
        Me.Panel1.Controls.Add(Me.Project_codeTextBox)
        Me.Panel1.Controls.Add(Project_nameLabel)
        Me.Panel1.Controls.Add(Me.Project_nameTextBox)
        Me.Panel1.Controls.Add(Customer_codeLabel)
        Me.Panel1.Controls.Add(Me.Customer_codeComboBox)
        Me.Panel1.Controls.Add(Staff_codeLabel)
        Me.Panel1.Controls.Add(Me.Staff_codeComboBox)
        Me.Panel1.Controls.Add(Start_dateLabel)
        Me.Panel1.Controls.Add(Me.Start_dateDateTimePicker)
        Me.Panel1.Controls.Add(End_dateLabel)
        Me.Panel1.Controls.Add(Me.End_dateDateTimePicker)
        Me.Panel1.Controls.Add(Me.Complete_flagCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 180)
        Me.Panel1.TabIndex = 0
        '
        'Project_codeTextBox
        '
        Me.Project_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_projectBindingSource, "project_code", True))
        Me.Project_codeTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Project_codeTextBox.Location = New System.Drawing.Point(102, 15)
        Me.Project_codeTextBox.Name = "Project_codeTextBox"
        Me.Project_codeTextBox.ReadOnly = True
        Me.Project_codeTextBox.Size = New System.Drawing.Size(61, 19)
        Me.Project_codeTextBox.TabIndex = 1
        '
        'Tbl_projectBindingSource
        '
        Me.Tbl_projectBindingSource.DataMember = "tbl_project"
        Me.Tbl_projectBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Project_nameTextBox
        '
        Me.Project_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_projectBindingSource, "project_name", True))
        Me.Project_nameTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Project_nameTextBox.Location = New System.Drawing.Point(102, 40)
        Me.Project_nameTextBox.Name = "Project_nameTextBox"
        Me.Project_nameTextBox.Size = New System.Drawing.Size(340, 19)
        Me.Project_nameTextBox.TabIndex = 3
        '
        'Customer_codeComboBox
        '
        Me.Customer_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_projectBindingSource, "customer_code", True))
        Me.Customer_codeComboBox.DataSource = Me.Tbl_customerBindingSource
        Me.Customer_codeComboBox.DisplayMember = "customer_name"
        Me.Customer_codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Customer_codeComboBox.FormattingEnabled = True
        Me.Customer_codeComboBox.Location = New System.Drawing.Point(102, 65)
        Me.Customer_codeComboBox.Name = "Customer_codeComboBox"
        Me.Customer_codeComboBox.Size = New System.Drawing.Size(340, 20)
        Me.Customer_codeComboBox.TabIndex = 5
        Me.Customer_codeComboBox.ValueMember = "customer_code"
        '
        'Tbl_customerBindingSource
        '
        Me.Tbl_customerBindingSource.DataMember = "tbl_customer"
        Me.Tbl_customerBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Staff_codeComboBox
        '
        Me.Staff_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_projectBindingSource, "staff_code", True))
        Me.Staff_codeComboBox.DataSource = Me.Tbl_staffBindingSource
        Me.Staff_codeComboBox.DisplayMember = "staff_name"
        Me.Staff_codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Staff_codeComboBox.FormattingEnabled = True
        Me.Staff_codeComboBox.Location = New System.Drawing.Point(102, 91)
        Me.Staff_codeComboBox.Name = "Staff_codeComboBox"
        Me.Staff_codeComboBox.Size = New System.Drawing.Size(139, 20)
        Me.Staff_codeComboBox.TabIndex = 7
        Me.Staff_codeComboBox.ValueMember = "staff_code"
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_projectBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(102, 117)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(122, 19)
        Me.Start_dateDateTimePicker.TabIndex = 9
        '
        'End_dateDateTimePicker
        '
        Me.End_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_projectBindingSource, "end_date", True))
        Me.End_dateDateTimePicker.Location = New System.Drawing.Point(102, 142)
        Me.End_dateDateTimePicker.Name = "End_dateDateTimePicker"
        Me.End_dateDateTimePicker.Size = New System.Drawing.Size(122, 19)
        Me.End_dateDateTimePicker.TabIndex = 11
        '
        'Complete_flagCheckBox
        '
        Me.Complete_flagCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_projectBindingSource, "complete_flag", True))
        Me.Complete_flagCheckBox.Location = New System.Drawing.Point(388, 13)
        Me.Complete_flagCheckBox.Name = "Complete_flagCheckBox"
        Me.Complete_flagCheckBox.Size = New System.Drawing.Size(54, 24)
        Me.Complete_flagCheckBox.TabIndex = 13
        Me.Complete_flagCheckBox.Text = "完了"
        Me.Complete_flagCheckBox.UseVisualStyleBackColor = True
        '
        'Tbl_projectTableAdapter
        '
        Me.Tbl_projectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_categoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerTableAdapter = Me.Tbl_customerTableAdapter
        Me.TableAdapterManager.tbl_isbn_bookTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Me.Tbl_jobTableAdapter
        Me.TableAdapterManager.tbl_lendingTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Me.Tbl_projectTableAdapter
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Me.Tbl_staffTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_customerTableAdapter
        '
        Me.Tbl_customerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_jobTableAdapter
        '
        Me.Tbl_jobTableAdapter.ClearBeforeFill = True
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'Tbl_projectBindingNavigator
        '
        Me.Tbl_projectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_projectBindingNavigator.BindingSource = Me.Tbl_projectBindingSource
        Me.Tbl_projectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_projectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_projectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_projectBindingNavigatorSaveItem})
        Me.Tbl_projectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_projectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_projectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_projectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_projectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_projectBindingNavigator.Name = "Tbl_projectBindingNavigator"
        Me.Tbl_projectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_projectBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.Tbl_projectBindingNavigator.TabIndex = 1
        Me.Tbl_projectBindingNavigator.Text = "BindingNavigator1"
        Me.Tbl_projectBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
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
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_projectBindingNavigatorSaveItem
        '
        Me.Tbl_projectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_projectBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_projectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_projectBindingNavigatorSaveItem.Name = "Tbl_projectBindingNavigatorSaveItem"
        Me.Tbl_projectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_projectBindingNavigatorSaveItem.Text = "データの保存"
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(493, 74)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 7
        Me.DeleteButton.Text = "削除"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(493, 46)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 6
        Me.UpdateButton.Text = "登録"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(493, 17)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "戻る"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Tbl_jobBindingSource
        '
        Me.Tbl_jobBindingSource.DataMember = "tbl_job"
        Me.Tbl_jobBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_jobDataGridView
        '
        Me.Tbl_jobDataGridView.AllowUserToAddRows = False
        Me.Tbl_jobDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_jobDataGridView.AutoGenerateColumns = False
        Me.Tbl_jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_jobDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.staff_code, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_jobDataGridView.DataSource = Me.Tbl_jobBindingSource
        Me.Tbl_jobDataGridView.Location = New System.Drawing.Point(12, 204)
        Me.Tbl_jobDataGridView.Name = "Tbl_jobDataGridView"
        Me.Tbl_jobDataGridView.ReadOnly = True
        Me.Tbl_jobDataGridView.RowTemplate.Height = 21
        Me.Tbl_jobDataGridView.Size = New System.Drawing.Size(458, 145)
        Me.Tbl_jobDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "job_number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 30
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "job_title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ジョブタイトル"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 155
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "staff_code"
        Me.DataGridViewTextBoxColumn4.HeaderText = "スタッフコード"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'staff_code
        '
        Me.staff_code.DataPropertyName = "staff_code"
        Me.staff_code.DataSource = Me.TblstaffBindingSource
        Me.staff_code.DisplayMember = "staff_name"
        Me.staff_code.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.staff_code.HeaderText = "スタッフ名"
        Me.staff_code.Name = "staff_code"
        Me.staff_code.ReadOnly = True
        Me.staff_code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.staff_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.staff_code.ValueMember = "staff_code"
        Me.staff_code.Width = 80
        '
        'TblstaffBindingSource
        '
        Me.TblstaffBindingSource.DataMember = "tbl_staff"
        Me.TblstaffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "complete_flag"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "完了"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'ProjectjobDataSetBindingSource
        '
        Me.ProjectjobDataSetBindingSource.DataSource = Me.Project_jobDataSet
        Me.ProjectjobDataSetBindingSource.Position = 0
        '
        'ProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Tbl_jobDataGridView)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Tbl_projectBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProjectForm"
        Me.Text = "プロジェクト管理"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_projectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_projectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_projectBindingNavigator.ResumeLayout(False)
        Me.Tbl_projectBindingNavigator.PerformLayout()
        CType(Me.Tbl_jobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_jobDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectjobDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_projectBindingSource As BindingSource
    Friend WithEvents Tbl_projectTableAdapter As project_jobDataSetTableAdapters.tbl_projectTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_projectBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_projectBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Project_codeTextBox As TextBox
    Friend WithEvents Project_nameTextBox As TextBox
    Friend WithEvents Customer_codeComboBox As ComboBox
    Friend WithEvents Staff_codeComboBox As ComboBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents End_dateDateTimePicker As DateTimePicker
    Friend WithEvents Complete_flagCheckBox As CheckBox
    Friend WithEvents Tbl_customerTableAdapter As project_jobDataSetTableAdapters.tbl_customerTableAdapter
    Friend WithEvents Tbl_customerBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As project_jobDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_jobTableAdapter As project_jobDataSetTableAdapters.tbl_jobTableAdapter
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Tbl_jobBindingSource As BindingSource
    Friend WithEvents Tbl_jobDataGridView As DataGridView
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents ProjectjobDataSetBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents staff_code As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
