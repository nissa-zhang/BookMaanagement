<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim IsbnLabel As System.Windows.Forms.Label
        Dim Category_idLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim StatflgLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookForm))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Tbl_isbn_bookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_isbn_bookTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.tbl_isbn_bookTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
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
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.IsbnTextBox = New System.Windows.Forms.TextBox()
        Me.Category_idTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.StatflgTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        IsbnLabel = New System.Windows.Forms.Label()
        Category_idLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        StatflgLabel = New System.Windows.Forms.Label()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_isbn_bookBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(78, 85)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(16, 12)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IsbnLabel
        '
        IsbnLabel.AutoSize = True
        IsbnLabel.Location = New System.Drawing.Point(78, 110)
        IsbnLabel.Name = "IsbnLabel"
        IsbnLabel.Size = New System.Drawing.Size(28, 12)
        IsbnLabel.TabIndex = 3
        IsbnLabel.Text = "isbn:"
        '
        'Category_idLabel
        '
        Category_idLabel.AutoSize = True
        Category_idLabel.Location = New System.Drawing.Point(78, 135)
        Category_idLabel.Name = "Category_idLabel"
        Category_idLabel.Size = New System.Drawing.Size(64, 12)
        Category_idLabel.TabIndex = 5
        Category_idLabel.Text = "category id:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(78, 160)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(27, 12)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(78, 185)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(39, 12)
        AuthorLabel.TabIndex = 9
        AuthorLabel.Text = "author:"
        '
        'StatflgLabel
        '
        StatflgLabel.AutoSize = True
        StatflgLabel.Location = New System.Drawing.Point(78, 210)
        StatflgLabel.Name = "StatflgLabel"
        StatflgLabel.Size = New System.Drawing.Size(40, 12)
        StatflgLabel.TabIndex = 11
        StatflgLabel.Text = "statflg:"
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_isbn_bookBindingSource
        '
        Me.Tbl_isbn_bookBindingSource.DataMember = "tbl_isbn_book"
        Me.Tbl_isbn_bookBindingSource.DataSource = Me.Project_jobDataSet
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
        Me.Tbl_isbn_bookBindingNavigator.Size = New System.Drawing.Size(403, 25)
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(148, 82)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 19)
        Me.IdTextBox.TabIndex = 2
        '
        'IsbnTextBox
        '
        Me.IsbnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "isbn", True))
        Me.IsbnTextBox.Location = New System.Drawing.Point(148, 107)
        Me.IsbnTextBox.Name = "IsbnTextBox"
        Me.IsbnTextBox.Size = New System.Drawing.Size(100, 19)
        Me.IsbnTextBox.TabIndex = 4
        '
        'Category_idTextBox
        '
        Me.Category_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "category_id", True))
        Me.Category_idTextBox.Location = New System.Drawing.Point(148, 132)
        Me.Category_idTextBox.Name = "Category_idTextBox"
        Me.Category_idTextBox.Size = New System.Drawing.Size(100, 19)
        Me.Category_idTextBox.TabIndex = 6
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(148, 157)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 19)
        Me.TitleTextBox.TabIndex = 8
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(148, 182)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(100, 19)
        Me.AuthorTextBox.TabIndex = 10
        '
        'StatflgTextBox
        '
        Me.StatflgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_isbn_bookBindingSource, "statflg", True))
        Me.StatflgTextBox.Location = New System.Drawing.Point(148, 207)
        Me.StatflgTextBox.Name = "StatflgTextBox"
        Me.StatflgTextBox.Size = New System.Drawing.Size(100, 19)
        Me.StatflgTextBox.TabIndex = 12
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(302, 88)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(74, 22)
        Me.SaveButton.TabIndex = 13
        Me.SaveButton.Text = "登録"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(302, 135)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(72, 22)
        Me.DeleteButton.TabIndex = 14
        Me.DeleteButton.Text = "削除"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(302, 185)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(72, 23)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "戻る"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 375)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(IsbnLabel)
        Me.Controls.Add(Me.IsbnTextBox)
        Me.Controls.Add(Category_idLabel)
        Me.Controls.Add(Me.Category_idTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(StatflgLabel)
        Me.Controls.Add(Me.StatflgTextBox)
        Me.Controls.Add(Me.Tbl_isbn_bookBindingNavigator)
        Me.Name = "BookForm"
        Me.Text = "Book"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_isbn_bookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_isbn_bookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_isbn_bookBindingNavigator.ResumeLayout(False)
        Me.Tbl_isbn_bookBindingNavigator.PerformLayout()
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
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents IsbnTextBox As TextBox
    Friend WithEvents Category_idTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents StatflgTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ExitButton As Button
End Class
