<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookSearchForm
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
        Dim Staff_codeLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim Book_idLabel As System.Windows.Forms.Label
        Dim Return_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookSearchForm))
        Me.Tbl_isbn_bookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_isbn_bookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
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
        Me.Tbl_isbn_bookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_isbn_bookDataGridView = New System.Windows.Forms.DataGridView()
        Me.bookid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Staff_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_lendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_isbn_bookTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_isbn_bookTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_lendingTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_lendingTableAdapter()
        Me.Tbl_staffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_staffTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Book_idTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Return_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilternameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FilternameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Staff_codeLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        Book_idLabel = New System.Windows.Forms.Label()
        Return_dateLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_isbn_bookBindingNavigator.SuspendLayout()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_isbn_bookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_lendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Staff_codeLabel
        '
        Staff_codeLabel.AutoSize = True
        Staff_codeLabel.Location = New System.Drawing.Point(0, 44)
        Staff_codeLabel.Name = "Staff_codeLabel"
        Staff_codeLabel.Size = New System.Drawing.Size(59, 12)
        Staff_codeLabel.TabIndex = 19
        Staff_codeLabel.Text = "staff code:"
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Location = New System.Drawing.Point(0, 71)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(57, 12)
        Start_dateLabel.TabIndex = 21
        Start_dateLabel.Text = "start date:"
        '
        'Book_idLabel
        '
        Book_idLabel.AutoSize = True
        Book_idLabel.Location = New System.Drawing.Point(13, 19)
        Book_idLabel.Name = "Book_idLabel"
        Book_idLabel.Size = New System.Drawing.Size(44, 12)
        Book_idLabel.TabIndex = 22
        Book_idLabel.Text = "book id:"
        '
        'Return_dateLabel
        '
        Return_dateLabel.AutoSize = True
        Return_dateLabel.Location = New System.Drawing.Point(0, 102)
        Return_dateLabel.Name = "Return_dateLabel"
        Return_dateLabel.Size = New System.Drawing.Size(63, 12)
        Return_dateLabel.TabIndex = 32
        Return_dateLabel.Text = "return date:"
        '
        'Tbl_isbn_bookBindingNavigator
        '
        Me.Tbl_isbn_bookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_isbn_bookBindingNavigator.BindingSource = Me.Tbl_isbn_bookBindingSource
        Me.Tbl_isbn_bookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_isbn_bookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_isbn_bookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_isbn_bookBindingNavigatorSaveItem})
        Me.Tbl_isbn_bookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_isbn_bookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_isbn_bookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_isbn_bookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_isbn_bookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_isbn_bookBindingNavigator.Name = "Tbl_isbn_bookBindingNavigator"
        Me.Tbl_isbn_bookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_isbn_bookBindingNavigator.Size = New System.Drawing.Size(545, 25)
        Me.Tbl_isbn_bookBindingNavigator.TabIndex = 0
        Me.Tbl_isbn_bookBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_isbn_bookBindingSource
        '
        Me.Tbl_isbn_bookBindingSource.DataMember = "tbl_isbn_book"
        Me.Tbl_isbn_bookBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_isbn_bookBindingNavigatorSaveItem
        '
        Me.Tbl_isbn_bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_isbn_bookBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_isbn_bookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_isbn_bookBindingNavigatorSaveItem.Name = "Tbl_isbn_bookBindingNavigatorSaveItem"
        Me.Tbl_isbn_bookBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_isbn_bookBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Tbl_isbn_bookDataGridView
        '
        Me.Tbl_isbn_bookDataGridView.AutoGenerateColumns = False
        Me.Tbl_isbn_bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_isbn_bookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookid, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Tbl_isbn_bookDataGridView.DataSource = Me.Tbl_isbn_bookBindingSource
        Me.Tbl_isbn_bookDataGridView.Location = New System.Drawing.Point(9, 65)
        Me.Tbl_isbn_bookDataGridView.Name = "Tbl_isbn_bookDataGridView"
        Me.Tbl_isbn_bookDataGridView.RowTemplate.Height = 21
        Me.Tbl_isbn_bookDataGridView.Size = New System.Drawing.Size(516, 118)
        Me.Tbl_isbn_bookDataGridView.TabIndex = 1
        '
        'bookid
        '
        Me.bookid.DataPropertyName = "id"
        Me.bookid.HeaderText = "書籍コード"
        Me.bookid.Name = "bookid"
        Me.bookid.ReadOnly = True
        Me.bookid.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "isbn"
        Me.DataGridViewTextBoxColumn2.HeaderText = "isbn"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "category_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "category_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "title"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "author"
        Me.DataGridViewTextBoxColumn5.HeaderText = "author"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "貸出"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Staff_codeTextBox
        '
        Me.Staff_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_lendingBindingSource, "staff_code", True))
        Me.Staff_codeTextBox.Location = New System.Drawing.Point(69, 41)
        Me.Staff_codeTextBox.Name = "Staff_codeTextBox"
        Me.Staff_codeTextBox.Size = New System.Drawing.Size(134, 19)
        Me.Staff_codeTextBox.TabIndex = 20
        '
        'Tbl_lendingBindingSource
        '
        Me.Tbl_lendingBindingSource.DataMember = "tbl_lending"
        Me.Tbl_lendingBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_lendingBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(69, 66)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(134, 19)
        Me.Start_dateDateTimePicker.TabIndex = 22
        '
        'Tbl_isbn_bookTableAdapter
        '
        Me.Tbl_isbn_bookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_categoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_isbn_bookTableAdapter = Me.Tbl_isbn_bookTableAdapter
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_lendingTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_lendingTableAdapter
        '
        Me.Tbl_lendingTableAdapter.ClearBeforeFill = True
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
        'Book_idTextBox
        '
        Me.Book_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_lendingBindingSource, "book_id", True))
        Me.Book_idTextBox.Location = New System.Drawing.Point(69, 16)
        Me.Book_idTextBox.Name = "Book_idTextBox"
        Me.Book_idTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Book_idTextBox.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Book_idLabel)
        Me.Panel1.Controls.Add(Return_dateLabel)
        Me.Panel1.Controls.Add(Me.Return_dateDateTimePicker)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Book_idTextBox)
        Me.Panel1.Controls.Add(Staff_codeLabel)
        Me.Panel1.Controls.Add(Me.Staff_codeTextBox)
        Me.Panel1.Controls.Add(Start_dateLabel)
        Me.Panel1.Controls.Add(Me.Start_dateDateTimePicker)
        Me.Panel1.Location = New System.Drawing.Point(12, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 147)
        Me.Panel1.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 29)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "返却"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Return_dateDateTimePicker
        '
        Me.Return_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_lendingBindingSource, "return_date", True))
        Me.Return_dateDateTimePicker.Location = New System.Drawing.Point(69, 98)
        Me.Return_dateDateTimePicker.Name = "Return_dateDateTimePicker"
        Me.Return_dateDateTimePicker.Size = New System.Drawing.Size(129, 19)
        Me.Return_dateDateTimePicker.TabIndex = 33
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilternameToolStripLabel, Me.FilternameToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(545, 25)
        Me.FillByToolStrip.TabIndex = 25
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FilternameToolStripLabel
        '
        Me.FilternameToolStripLabel.Name = "FilternameToolStripLabel"
        Me.FilternameToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.FilternameToolStripLabel.Text = "filtername:"
        '
        'FilternameToolStripTextBox
        '
        Me.FilternameToolStripTextBox.Name = "FilternameToolStripTextBox"
        Me.FilternameToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 19)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'BookSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 390)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tbl_isbn_bookDataGridView)
        Me.Controls.Add(Me.Tbl_isbn_bookBindingNavigator)
        Me.Name = "BookSearchForm"
        Me.Text = "BookSearch"
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_isbn_bookBindingNavigator.ResumeLayout(False)
        Me.Tbl_isbn_bookBindingNavigator.PerformLayout()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_isbn_bookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_lendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_staffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Tbl_isbn_bookBindingSource As BindingSource
    Friend WithEvents Tbl_isbn_bookTableAdapter As project_jobDataSetTableAdapters.tbl_isbn_bookTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_isbn_bookBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_isbn_bookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_isbn_bookDataGridView As DataGridView
    Friend WithEvents Tbl_lendingBindingSource As BindingSource
    Friend WithEvents Tbl_lendingTableAdapter As project_jobDataSetTableAdapters.tbl_lendingTableAdapter
    Friend WithEvents Tbl_staffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As project_jobDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Staff_codeTextBox As TextBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents bookid As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Book_idTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Return_dateDateTimePicker As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FilternameToolStripLabel As ToolStripLabel
    Friend WithEvents FilternameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
