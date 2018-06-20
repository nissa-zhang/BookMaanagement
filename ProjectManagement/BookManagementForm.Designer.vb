<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookManagementForm))
        Me.Tbl_isbn_bookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_isbn_bookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BookManagement = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsbnTextBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category_idTextBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleTextBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorTextBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_isbn_bookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_isbn_bookTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_isbn_bookTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_categoryTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_categoryTableAdapter()
        Me.CardButton = New System.Windows.Forms.Button()
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_isbn_bookBindingNavigator.SuspendLayout()
        CType(Me.BookManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Tbl_isbn_bookBindingNavigator.Size = New System.Drawing.Size(639, 25)
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
        'BookManagement
        '
        Me.BookManagement.AutoGenerateColumns = False
        Me.BookManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookManagement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IsbnTextBox, Me.Category_idTextBox, Me.TitleTextBox, Me.AuthorTextBox, Me.DataGridViewTextBoxColumn6})
        Me.BookManagement.DataSource = Me.Tbl_isbn_bookBindingSource
        Me.BookManagement.Location = New System.Drawing.Point(12, 28)
        Me.BookManagement.Name = "BookManagement"
        Me.BookManagement.RowTemplate.Height = 21
        Me.BookManagement.Size = New System.Drawing.Size(615, 363)
        Me.BookManagement.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 19)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "新規追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IsbnTextBox
        '
        Me.IsbnTextBox.DataPropertyName = "isbn"
        Me.IsbnTextBox.HeaderText = "isbn"
        Me.IsbnTextBox.Name = "IsbnTextBox"
        '
        'Category_idTextBox
        '
        Me.Category_idTextBox.DataPropertyName = "category_id"
        Me.Category_idTextBox.HeaderText = "category_id"
        Me.Category_idTextBox.Name = "Category_idTextBox"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataPropertyName = "title"
        Me.TitleTextBox.HeaderText = "title"
        Me.TitleTextBox.Name = "TitleTextBox"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataPropertyName = "author"
        Me.AuthorTextBox.HeaderText = "author"
        Me.AuthorTextBox.Name = "AuthorTextBox"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "statflg"
        Me.DataGridViewTextBoxColumn6.HeaderText = "statflg"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
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
        'CardButton
        '
        Me.CardButton.Location = New System.Drawing.Point(536, 397)
        Me.CardButton.Name = "CardButton"
        Me.CardButton.Size = New System.Drawing.Size(81, 17)
        Me.CardButton.TabIndex = 17
        Me.CardButton.Text = "カード表示"
        Me.CardButton.UseVisualStyleBackColor = True
        '
        'BookManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 420)
        Me.Controls.Add(Me.CardButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BookManagement)
        Me.Controls.Add(Me.Tbl_isbn_bookBindingNavigator)
        Me.Name = "BookManagementForm"
        Me.Text = "書籍管理"
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_isbn_bookBindingNavigator.ResumeLayout(False)
        Me.Tbl_isbn_bookBindingNavigator.PerformLayout()
        CType(Me.BookManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Tbl_categoryBindingSource As BindingSource
    Friend WithEvents Tbl_categoryTableAdapter As project_jobDataSetTableAdapters.tbl_categoryTableAdapter
    Friend WithEvents BookManagement As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IsbnTextBox As DataGridViewTextBoxColumn
    Friend WithEvents Category_idTextBox As DataGridViewTextBoxColumn
    Friend WithEvents TitleTextBox As DataGridViewTextBoxColumn
    Friend WithEvents AuthorTextBox As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents CardButton As Button
End Class
