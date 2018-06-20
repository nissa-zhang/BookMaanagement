<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookLendingForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Book_idLabel As System.Windows.Forms.Label
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim Return_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookLendingForm))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_lendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_lendingTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_lendingTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_lendingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_lendingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Book_idTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Return_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbl_lendingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Book_idLabel = New System.Windows.Forms.Label()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        Return_dateLabel = New System.Windows.Forms.Label()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_lendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_lendingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_lendingBindingNavigator.SuspendLayout()
        CType(Me.Tbl_lendingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_idLabel
        '
        Book_idLabel.AutoSize = True
        Book_idLabel.Location = New System.Drawing.Point(45, 66)
        Book_idLabel.Name = "Book_idLabel"
        Book_idLabel.Size = New System.Drawing.Size(62, 12)
        Book_idLabel.TabIndex = 3
        Book_idLabel.Text = "書籍コード："
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(45, 100)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(64, 12)
        Staff_codeLabel.TabIndex = 5
        Staff_codeLabel.Text = "スタッフコード"
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Location = New System.Drawing.Point(45, 126)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(47, 12)
        Start_dateLabel.TabIndex = 7
        Start_dateLabel.Text = "貸出日："
        '
        'Return_dateLabel
        '
        Return_dateLabel.AutoSize = True
        Return_dateLabel.Location = New System.Drawing.Point(45, 151)
        Return_dateLabel.Name = "Return_dateLabel"
        Return_dateLabel.Size = New System.Drawing.Size(47, 12)
        Return_dateLabel.TabIndex = 9
        Return_dateLabel.Text = "返却日："
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_lendingBindingSource
        '
        Me.Tbl_lendingBindingSource.DataMember = "tbl_lending"
        Me.Tbl_lendingBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_lendingTableAdapter
        '
        Me.Tbl_lendingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_categoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_isbn_bookTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_lendingTableAdapter = Me.Tbl_lendingTableAdapter
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_lendingBindingNavigator
        '
        Me.Tbl_lendingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_lendingBindingNavigator.BindingSource = Me.Tbl_lendingBindingSource
        Me.Tbl_lendingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_lendingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_lendingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_lendingBindingNavigatorSaveItem})
        Me.Tbl_lendingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_lendingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_lendingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_lendingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_lendingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_lendingBindingNavigator.Name = "Tbl_lendingBindingNavigator"
        Me.Tbl_lendingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_lendingBindingNavigator.Size = New System.Drawing.Size(651, 25)
        Me.Tbl_lendingBindingNavigator.TabIndex = 0
        Me.Tbl_lendingBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_lendingBindingNavigatorSaveItem
        '
        Me.Tbl_lendingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_lendingBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_lendingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_lendingBindingNavigatorSaveItem.Name = "Tbl_lendingBindingNavigatorSaveItem"
        Me.Tbl_lendingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_lendingBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Book_idTextBox
        '
        Me.Book_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_lendingBindingSource, "book_id", True))
        Me.Book_idTextBox.Location = New System.Drawing.Point(114, 63)
        Me.Book_idTextBox.Name = "Book_idTextBox"
        Me.Book_idTextBox.Size = New System.Drawing.Size(200, 19)
        Me.Book_idTextBox.TabIndex = 4
        '
        'Staff_codeTextBox
        '
        Me.Staff_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_lendingBindingSource, "staff_code", True))
        Me.Staff_codeTextBox.Location = New System.Drawing.Point(114, 97)
        Me.Staff_codeTextBox.Name = "Staff_codeTextBox"
        Me.Staff_codeTextBox.Size = New System.Drawing.Size(200, 19)
        Me.Staff_codeTextBox.TabIndex = 6
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_lendingBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(114, 122)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(200, 19)
        Me.Start_dateDateTimePicker.TabIndex = 8
        '
        'Return_dateDateTimePicker
        '
        Me.Return_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_lendingBindingSource, "return_date", True))
        Me.Return_dateDateTimePicker.Location = New System.Drawing.Point(114, 147)
        Me.Return_dateDateTimePicker.Name = "Return_dateDateTimePicker"
        Me.Return_dateDateTimePicker.Size = New System.Drawing.Size(200, 19)
        Me.Return_dateDateTimePicker.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "貸出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tbl_lendingDataGridView
        '
        Me.Tbl_lendingDataGridView.AutoGenerateColumns = False
        Me.Tbl_lendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_lendingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Tbl_lendingDataGridView.DataSource = Me.Tbl_lendingBindingSource
        Me.Tbl_lendingDataGridView.Location = New System.Drawing.Point(34, 189)
        Me.Tbl_lendingDataGridView.Name = "Tbl_lendingDataGridView"
        Me.Tbl_lendingDataGridView.RowTemplate.Height = 21
        Me.Tbl_lendingDataGridView.Size = New System.Drawing.Size(548, 218)
        Me.Tbl_lendingDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "book_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "book_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "staff_code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "staff_code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "start_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "return_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "return_date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'BookLendingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 466)
        Me.Controls.Add(Me.Tbl_lendingDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Book_idLabel)
        Me.Controls.Add(Me.Book_idTextBox)
        Me.Controls.Add(Staff_codeLabel)
        Me.Controls.Add(Me.Staff_codeTextBox)
        Me.Controls.Add(Start_dateLabel)
        Me.Controls.Add(Me.Start_dateDateTimePicker)
        Me.Controls.Add(Return_dateLabel)
        Me.Controls.Add(Me.Return_dateDateTimePicker)
        Me.Controls.Add(Me.Tbl_lendingBindingNavigator)
        Me.Name = "BookLendingForm"
        Me.Text = "書籍貸出"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_lendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_lendingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_lendingBindingNavigator.ResumeLayout(False)
        Me.Tbl_lendingBindingNavigator.PerformLayout()
        CType(Me.Tbl_lendingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_lendingBindingSource As BindingSource
    Friend WithEvents Tbl_lendingTableAdapter As project_jobDataSetTableAdapters.tbl_lendingTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_lendingBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_lendingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Book_idTextBox As TextBox
    Friend WithEvents Staff_codeTextBox As TextBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Return_dateDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Tbl_lendingDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
