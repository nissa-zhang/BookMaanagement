<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Staff_nameLabel As System.Windows.Forms.Label
        Dim Staff_kanaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Ext_phoneLabel As System.Windows.Forms.Label
        Dim MemoLabel As System.Windows.Forms.Label
        Dim Input_dateLabel As System.Windows.Forms.Label
        Dim Staff_sectionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_staffTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_staffTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_staffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_staffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Staff_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_kanaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Resign_flagCheckBox = New System.Windows.Forms.CheckBox()
        Me.MemoTextBox = New System.Windows.Forms.TextBox()
        Me.Input_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexGroupBox = New System.Windows.Forms.GroupBox()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Staff_sectionComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_sectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_sectionTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_sectionTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.データDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFirstMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovePrevMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveNextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveLastMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Staff_nameLabel = New System.Windows.Forms.Label()
        Staff_kanaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Ext_phoneLabel = New System.Windows.Forms.Label()
        MemoLabel = New System.Windows.Forms.Label()
        Input_dateLabel = New System.Windows.Forms.Label()
        Staff_sectionLabel = New System.Windows.Forms.Label()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_staffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_staffBindingNavigator.SuspendLayout()
        Me.SexGroupBox.SuspendLayout()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(12, 39)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(70, 12)
        Staff_codeLabel.TabIndex = 1
        Staff_codeLabel.Text = "スタッフコード："
        '
        'Staff_nameLabel
        '
        Staff_nameLabel.AutoSize = True
        Staff_nameLabel.Location = New System.Drawing.Point(12, 64)
        Staff_nameLabel.Name = "Staff_nameLabel"
        Staff_nameLabel.Size = New System.Drawing.Size(55, 12)
        Staff_nameLabel.TabIndex = 3
        Staff_nameLabel.Text = "スタッフ名："
        '
        'Staff_kanaLabel
        '
        Staff_kanaLabel.AutoSize = True
        Staff_kanaLabel.Location = New System.Drawing.Point(12, 89)
        Staff_kanaLabel.Name = "Staff_kanaLabel"
        Staff_kanaLabel.Size = New System.Drawing.Size(74, 12)
        Staff_kanaLabel.TabIndex = 5
        Staff_kanaLabel.Text = "スタッフ名カナ："
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 164)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(99, 12)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "電子メールアドレス："
        '
        'Ext_phoneLabel
        '
        Ext_phoneLabel.AutoSize = True
        Ext_phoneLabel.Location = New System.Drawing.Point(12, 189)
        Ext_phoneLabel.Name = "Ext_phoneLabel"
        Ext_phoneLabel.Size = New System.Drawing.Size(59, 12)
        Ext_phoneLabel.TabIndex = 13
        Ext_phoneLabel.Text = "内線番号："
        '
        'MemoLabel
        '
        MemoLabel.AutoSize = True
        MemoLabel.Location = New System.Drawing.Point(12, 214)
        MemoLabel.Name = "MemoLabel"
        MemoLabel.Size = New System.Drawing.Size(35, 12)
        MemoLabel.TabIndex = 21
        MemoLabel.Text = "備考："
        '
        'Input_dateLabel
        '
        Input_dateLabel.AutoSize = True
        Input_dateLabel.Location = New System.Drawing.Point(12, 297)
        Input_dateLabel.Name = "Input_dateLabel"
        Input_dateLabel.Size = New System.Drawing.Size(47, 12)
        Input_dateLabel.TabIndex = 25
        Input_dateLabel.Text = "入力日："
        '
        'Staff_sectionLabel
        '
        Staff_sectionLabel.AutoSize = True
        Staff_sectionLabel.Location = New System.Drawing.Point(12, 124)
        Staff_sectionLabel.Name = "Staff_sectionLabel"
        Staff_sectionLabel.Size = New System.Drawing.Size(59, 12)
        Staff_sectionLabel.TabIndex = 27
        Staff_sectionLabel.Text = "所属部署："
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_staffBindingSource
        '
        Me.Tbl_staffBindingSource.DataMember = "tbl_staff"
        Me.Tbl_staffBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Me.Tbl_staffTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_staffBindingNavigator
        '
        Me.Tbl_staffBindingNavigator.AddNewItem = Nothing
        Me.Tbl_staffBindingNavigator.BindingSource = Me.Tbl_staffBindingSource
        Me.Tbl_staffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_staffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_staffBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tbl_staffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_staffBindingNavigatorSaveItem})
        Me.Tbl_staffBindingNavigator.Location = New System.Drawing.Point(0, 334)
        Me.Tbl_staffBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_staffBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_staffBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_staffBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_staffBindingNavigator.Name = "Tbl_staffBindingNavigator"
        Me.Tbl_staffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_staffBindingNavigator.Size = New System.Drawing.Size(342, 25)
        Me.Tbl_staffBindingNavigator.TabIndex = 0
        Me.Tbl_staffBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.ReadOnly = True
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
        'Tbl_staffBindingNavigatorSaveItem
        '
        Me.Tbl_staffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_staffBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_staffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_staffBindingNavigatorSaveItem.Name = "Tbl_staffBindingNavigatorSaveItem"
        Me.Tbl_staffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_staffBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Staff_codeTextBox
        '
        Me.Staff_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_code", True))
        Me.Staff_codeTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Staff_codeTextBox.Location = New System.Drawing.Point(113, 36)
        Me.Staff_codeTextBox.Name = "Staff_codeTextBox"
        Me.Staff_codeTextBox.ReadOnly = True
        Me.Staff_codeTextBox.Size = New System.Drawing.Size(50, 19)
        Me.Staff_codeTextBox.TabIndex = 1
        '
        'Staff_nameTextBox
        '
        Me.Staff_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_name", True))
        Me.Staff_nameTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Staff_nameTextBox.Location = New System.Drawing.Point(113, 61)
        Me.Staff_nameTextBox.Name = "Staff_nameTextBox"
        Me.Staff_nameTextBox.Size = New System.Drawing.Size(102, 19)
        Me.Staff_nameTextBox.TabIndex = 2
        '
        'Staff_kanaTextBox
        '
        Me.Staff_kanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "staff_kana", True))
        Me.Staff_kanaTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Staff_kanaTextBox.Location = New System.Drawing.Point(113, 86)
        Me.Staff_kanaTextBox.Name = "Staff_kanaTextBox"
        Me.Staff_kanaTextBox.Size = New System.Drawing.Size(102, 19)
        Me.Staff_kanaTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "email", True))
        Me.EmailTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.EmailTextBox.Location = New System.Drawing.Point(113, 161)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 19)
        Me.EmailTextBox.TabIndex = 5
        '
        'Ext_phoneTextBox
        '
        Me.Ext_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "ext_phone", True))
        Me.Ext_phoneTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Ext_phoneTextBox.Location = New System.Drawing.Point(113, 186)
        Me.Ext_phoneTextBox.Name = "Ext_phoneTextBox"
        Me.Ext_phoneTextBox.Size = New System.Drawing.Size(50, 19)
        Me.Ext_phoneTextBox.TabIndex = 6
        '
        'Resign_flagCheckBox
        '
        Me.Resign_flagCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_staffBindingSource, "resign_flag", True))
        Me.Resign_flagCheckBox.Location = New System.Drawing.Point(268, 292)
        Me.Resign_flagCheckBox.Name = "Resign_flagCheckBox"
        Me.Resign_flagCheckBox.Size = New System.Drawing.Size(54, 24)
        Me.Resign_flagCheckBox.TabIndex = 10
        Me.Resign_flagCheckBox.TabStop = False
        Me.Resign_flagCheckBox.Text = "退社"
        Me.Resign_flagCheckBox.UseVisualStyleBackColor = True
        '
        'MemoTextBox
        '
        Me.MemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_staffBindingSource, "memo", True))
        Me.MemoTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MemoTextBox.Location = New System.Drawing.Point(113, 211)
        Me.MemoTextBox.Multiline = True
        Me.MemoTextBox.Name = "MemoTextBox"
        Me.MemoTextBox.Size = New System.Drawing.Size(200, 76)
        Me.MemoTextBox.TabIndex = 7
        '
        'Input_dateDateTimePicker
        '
        Me.Input_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_staffBindingSource, "input_date", True))
        Me.Input_dateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Input_dateDateTimePicker.Location = New System.Drawing.Point(113, 293)
        Me.Input_dateDateTimePicker.Name = "Input_dateDateTimePicker"
        Me.Input_dateDateTimePicker.Size = New System.Drawing.Size(128, 19)
        Me.Input_dateDateTimePicker.TabIndex = 8
        '
        'SexGroupBox
        '
        Me.SexGroupBox.Controls.Add(Me.FemaleRadioButton)
        Me.SexGroupBox.Controls.Add(Me.MaleRadioButton)
        Me.SexGroupBox.Location = New System.Drawing.Point(247, 47)
        Me.SexGroupBox.Name = "SexGroupBox"
        Me.SexGroupBox.Size = New System.Drawing.Size(65, 58)
        Me.SexGroupBox.TabIndex = 9
        Me.SexGroupBox.TabStop = False
        Me.SexGroupBox.Text = "性別"
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(10, 36)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(47, 16)
        Me.FemaleRadioButton.TabIndex = 1
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Tag = "2"
        Me.FemaleRadioButton.Text = "女性"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(10, 15)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(47, 16)
        Me.MaleRadioButton.TabIndex = 0
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Tag = "1"
        Me.MaleRadioButton.Text = "男性"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'Staff_sectionComboBox
        '
        Me.Staff_sectionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_staffBindingSource, "staff_section", True))
        Me.Staff_sectionComboBox.DataSource = Me.Tbl_sectionBindingSource
        Me.Staff_sectionComboBox.DisplayMember = "section_name"
        Me.Staff_sectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Staff_sectionComboBox.FormattingEnabled = True
        Me.Staff_sectionComboBox.Location = New System.Drawing.Point(113, 121)
        Me.Staff_sectionComboBox.Name = "Staff_sectionComboBox"
        Me.Staff_sectionComboBox.Size = New System.Drawing.Size(121, 20)
        Me.Staff_sectionComboBox.TabIndex = 4
        Me.Staff_sectionComboBox.ValueMember = "section_code"
        '
        'Tbl_sectionBindingSource
        '
        Me.Tbl_sectionBindingSource.DataMember = "tbl_section"
        Me.Tbl_sectionBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_sectionTableAdapter
        '
        Me.Tbl_sectionTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.データDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(342, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'データDToolStripMenuItem
        '
        Me.データDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveFirstMenuItem, Me.MovePrevMenuItem, Me.MoveNextMenuItem, Me.MoveLastMenuItem, Me.ToolStripSeparator1, Me.NewMenuItem, Me.DeleteMenuItem, Me.SaveMenuItem, Me.ToolStripSeparator2, Me.BackMenuItem})
        Me.データDToolStripMenuItem.Name = "データDToolStripMenuItem"
        Me.データDToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.データDToolStripMenuItem.Text = "データ(&D)"
        '
        'MoveFirstMenuItem
        '
        Me.MoveFirstMenuItem.Name = "MoveFirstMenuItem"
        Me.MoveFirstMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MoveFirstMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MoveFirstMenuItem.Text = "最初に移動(&F)"
        '
        'MovePrevMenuItem
        '
        Me.MovePrevMenuItem.Name = "MovePrevMenuItem"
        Me.MovePrevMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MovePrevMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MovePrevMenuItem.Text = "前に戻る(&P)"
        '
        'MoveNextMenuItem
        '
        Me.MoveNextMenuItem.Name = "MoveNextMenuItem"
        Me.MoveNextMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.MoveNextMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MoveNextMenuItem.Text = "次に移動(&N)"
        '
        'MoveLastMenuItem
        '
        Me.MoveLastMenuItem.Name = "MoveLastMenuItem"
        Me.MoveLastMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.MoveLastMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MoveLastMenuItem.Text = "最後に移動(&L)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'NewMenuItem
        '
        Me.NewMenuItem.Name = "NewMenuItem"
        Me.NewMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NewMenuItem.Text = "新規追加(&A)"
        '
        'DeleteMenuItem
        '
        Me.DeleteMenuItem.Name = "DeleteMenuItem"
        Me.DeleteMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DeleteMenuItem.Text = "削除(&D)"
        '
        'SaveMenuItem
        '
        Me.SaveMenuItem.Name = "SaveMenuItem"
        Me.SaveMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.SaveMenuItem.Text = "データの保存(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(197, 6)
        '
        'BackMenuItem
        '
        Me.BackMenuItem.Name = "BackMenuItem"
        Me.BackMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.BackMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BackMenuItem.Text = "メニューに戻る(&M)"
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 359)
        Me.Controls.Add(Staff_sectionLabel)
        Me.Controls.Add(Me.Staff_sectionComboBox)
        Me.Controls.Add(Me.SexGroupBox)
        Me.Controls.Add(Staff_codeLabel)
        Me.Controls.Add(Me.Staff_codeTextBox)
        Me.Controls.Add(Staff_nameLabel)
        Me.Controls.Add(Me.Staff_nameTextBox)
        Me.Controls.Add(Staff_kanaLabel)
        Me.Controls.Add(Me.Staff_kanaTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Ext_phoneLabel)
        Me.Controls.Add(Me.Ext_phoneTextBox)
        Me.Controls.Add(Me.Resign_flagCheckBox)
        Me.Controls.Add(MemoLabel)
        Me.Controls.Add(Me.MemoTextBox)
        Me.Controls.Add(Input_dateLabel)
        Me.Controls.Add(Me.Input_dateDateTimePicker)
        Me.Controls.Add(Me.Tbl_staffBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StaffForm"
        Me.Text = "スタッフマスター管理"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_staffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_staffBindingNavigator.ResumeLayout(False)
        Me.Tbl_staffBindingNavigator.PerformLayout()
        Me.SexGroupBox.ResumeLayout(False)
        Me.SexGroupBox.PerformLayout()
        CType(Me.Tbl_sectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As project_jobDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_staffBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_staffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Staff_codeTextBox As TextBox
    Friend WithEvents Staff_nameTextBox As TextBox
    Friend WithEvents Staff_kanaTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Ext_phoneTextBox As TextBox
    Friend WithEvents Resign_flagCheckBox As CheckBox
    Friend WithEvents MemoTextBox As TextBox
    Friend WithEvents Input_dateDateTimePicker As DateTimePicker
    Friend WithEvents SexGroupBox As GroupBox
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents Staff_sectionComboBox As ComboBox
    Friend WithEvents Tbl_sectionBindingSource As BindingSource
    Friend WithEvents Tbl_sectionTableAdapter As project_jobDataSetTableAdapters.tbl_sectionTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents データDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveFirstMenuItem As ToolStripMenuItem
    Friend WithEvents MovePrevMenuItem As ToolStripMenuItem
    Friend WithEvents MoveNextMenuItem As ToolStripMenuItem
    Friend WithEvents MoveLastMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NewMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMenuItem As ToolStripMenuItem
    Friend WithEvents SaveMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BackMenuItem As ToolStripMenuItem
End Class
