<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookManagementForm
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim IsbnLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim StatflgLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookManagementForm))
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
        Me.BookManageForm = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.IsbnTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.StatflgTextBox = New System.Windows.Forms.TextBox()
        Me.Category_idTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilternameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FilternameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBybiToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BiToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BiToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBybiToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_isbn_bookDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_isbn_bookTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_isbn_bookTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_categoryTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_categoryTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilternameToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FilternameToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        IsbnLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        StatflgLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_isbn_bookBindingNavigator.SuspendLayout()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.FillBybiToolStrip.SuspendLayout()
        CType(Me.Tbl_isbn_bookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(173, 239)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(62, 12)
        IdLabel.TabIndex = 1
        IdLabel.Text = "書籍コード："
        '
        'IsbnLabel
        '
        IsbnLabel.AutoSize = True
        IsbnLabel.Location = New System.Drawing.Point(173, 264)
        IsbnLabel.Name = "IsbnLabel"
        IsbnLabel.Size = New System.Drawing.Size(33, 12)
        IsbnLabel.TabIndex = 3
        IsbnLabel.Text = "ISBN:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(173, 322)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(47, 12)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "書籍名："
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(173, 347)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(35, 12)
        AuthorLabel.TabIndex = 9
        AuthorLabel.Text = "作者："
        '
        'StatflgLabel
        '
        StatflgLabel.AutoSize = True
        StatflgLabel.Location = New System.Drawing.Point(173, 372)
        StatflgLabel.Name = "StatflgLabel"
        StatflgLabel.Size = New System.Drawing.Size(40, 12)
        StatflgLabel.TabIndex = 11
        StatflgLabel.Text = "statflg:"
        '
        'Tbl_isbn_bookBindingNavigator
        '
        Me.Tbl_isbn_bookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_isbn_bookBindingNavigator.BindingSource = Me.Tbl_isbn_bookBindingSource
        Me.Tbl_isbn_bookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_isbn_bookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_isbn_bookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookManageForm})
        Me.Tbl_isbn_bookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_isbn_bookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_isbn_bookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_isbn_bookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_isbn_bookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_isbn_bookBindingNavigator.Name = "Tbl_isbn_bookBindingNavigator"
        Me.Tbl_isbn_bookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_isbn_bookBindingNavigator.Size = New System.Drawing.Size(605, 25)
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
        'BookManageForm
        '
        Me.BookManageForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookManageForm.Image = CType(resources.GetObject("BookManageForm.Image"), System.Drawing.Image)
        Me.BookManageForm.Name = "BookManageForm"
        Me.BookManageForm.Size = New System.Drawing.Size(23, 22)
        Me.BookManageForm.Text = "データの保存"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(243, 236)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 19)
        Me.IdTextBox.TabIndex = 2
        '
        'IsbnTextBox
        '
        Me.IsbnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "isbn", True))
        Me.IsbnTextBox.Location = New System.Drawing.Point(243, 261)
        Me.IsbnTextBox.Name = "IsbnTextBox"
        Me.IsbnTextBox.Size = New System.Drawing.Size(100, 19)
        Me.IsbnTextBox.TabIndex = 4
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(243, 319)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 19)
        Me.TitleTextBox.TabIndex = 8
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(243, 344)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(100, 19)
        Me.AuthorTextBox.TabIndex = 10
        '
        'StatflgTextBox
        '
        Me.StatflgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "statflg", True))
        Me.StatflgTextBox.Location = New System.Drawing.Point(243, 369)
        Me.StatflgTextBox.Name = "StatflgTextBox"
        Me.StatflgTextBox.Size = New System.Drawing.Size(100, 19)
        Me.StatflgTextBox.TabIndex = 12
        '
        'Category_idTextBox
        '
        Me.Category_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "category_id", True))
        Me.Category_idTextBox.Location = New System.Drawing.Point(243, 290)
        Me.Category_idTextBox.Name = "Category_idTextBox"
        Me.Category_idTextBox.Size = New System.Drawing.Size(36, 19)
        Me.Category_idTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = " カテゴリーID:"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilternameToolStripLabel, Me.FilternameToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(593, 25)
        Me.FillBy1ToolStrip.TabIndex = 15
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Visible = False
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
        Me.FilternameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'FillBybiToolStrip
        '
        Me.FillBybiToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BiToolStripLabel, Me.BiToolStripTextBox, Me.FillBybiToolStripButton})
        Me.FillBybiToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillBybiToolStrip.Name = "FillBybiToolStrip"
        Me.FillBybiToolStrip.Size = New System.Drawing.Size(515, 25)
        Me.FillBybiToolStrip.TabIndex = 16
        Me.FillBybiToolStrip.Text = "FillBybiToolStrip"
        Me.FillBybiToolStrip.Visible = False
        '
        'BiToolStripLabel
        '
        Me.BiToolStripLabel.Name = "BiToolStripLabel"
        Me.BiToolStripLabel.Size = New System.Drawing.Size(20, 22)
        Me.BiToolStripLabel.Text = "bi:"
        '
        'BiToolStripTextBox
        '
        Me.BiToolStripTextBox.Name = "BiToolStripTextBox"
        Me.BiToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBybiToolStripButton
        '
        Me.FillBybiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBybiToolStripButton.Name = "FillBybiToolStripButton"
        Me.FillBybiToolStripButton.Size = New System.Drawing.Size(49, 22)
        Me.FillBybiToolStripButton.Text = "FillBybi"
        '
        'Tbl_isbn_bookDataGridView
        '
        Me.Tbl_isbn_bookDataGridView.AutoGenerateColumns = False
        Me.Tbl_isbn_bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_isbn_bookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tbl_isbn_bookDataGridView.DataSource = Me.Tbl_isbn_bookBindingSource
        Me.Tbl_isbn_bookDataGridView.Location = New System.Drawing.Point(0, 57)
        Me.Tbl_isbn_bookDataGridView.Name = "Tbl_isbn_bookDataGridView"
        Me.Tbl_isbn_bookDataGridView.RowTemplate.Height = 21
        Me.Tbl_isbn_bookDataGridView.Size = New System.Drawing.Size(585, 158)
        Me.Tbl_isbn_bookDataGridView.TabIndex = 16
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "statflg"
        Me.DataGridViewTextBoxColumn6.HeaderText = "statflg"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
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
        'Tbl_categoryBindingSource
        '
        Me.Tbl_categoryBindingSource.DataMember = "tbl_category"
        Me.Tbl_categoryBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Tbl_categoryTableAdapter
        '
        Me.Tbl_categoryTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilternameToolStripLabel1, Me.FilternameToolStripTextBox1, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(111, 25)
        Me.FillByToolStrip.TabIndex = 17
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FilternameToolStripLabel1
        '
        Me.FilternameToolStripLabel1.Name = "FilternameToolStripLabel1"
        Me.FilternameToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.FilternameToolStripLabel1.Text = "filtername:"
        '
        'FilternameToolStripTextBox1
        '
        Me.FilternameToolStripTextBox1.Name = "FilternameToolStripTextBox1"
        Me.FilternameToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 19)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'BookManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 420)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Tbl_isbn_bookDataGridView)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillBybiToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(IsbnLabel)
        Me.Controls.Add(Me.IsbnTextBox)
        Me.Controls.Add(Me.Category_idTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(StatflgLabel)
        Me.Controls.Add(Me.StatflgTextBox)
        Me.Controls.Add(Me.Tbl_isbn_bookBindingNavigator)
        Me.Name = "BookManagementForm"
        Me.Text = "書籍管理"
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_isbn_bookBindingNavigator.ResumeLayout(False)
        Me.Tbl_isbn_bookBindingNavigator.PerformLayout()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.FillBybiToolStrip.ResumeLayout(False)
        Me.FillBybiToolStrip.PerformLayout()
        CType(Me.Tbl_isbn_bookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BookManageForm As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents IsbnTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents StatflgTextBox As TextBox
    Friend WithEvents Category_idTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbl_categoryBindingSource As BindingSource
    Friend WithEvents Tbl_categoryTableAdapter As project_jobDataSetTableAdapters.tbl_categoryTableAdapter
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents FilternameToolStripLabel As ToolStripLabel
    Friend WithEvents FilternameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents FillBybiToolStrip As ToolStrip
    Friend WithEvents BiToolStripLabel As ToolStripLabel
    Friend WithEvents BiToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBybiToolStripButton As ToolStripButton
    Friend WithEvents Tbl_isbn_bookDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FilternameToolStripLabel1 As ToolStripLabel
    Friend WithEvents FilternameToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
