<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BLR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BLR))
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Vw_BLRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_BLRTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.vw_BLRTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.Vw_BLRBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_BLRBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Vw_BLRDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilternameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FilternameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByn2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByn2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_BLRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_BLRBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vw_BLRBindingNavigator.SuspendLayout()
        CType(Me.Vw_BLRDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByNameToolStrip.SuspendLayout()
        Me.FillByn2ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Project_jobDataSet
        '
        Me.Project_jobDataSet.DataSetName = "project_jobDataSet"
        Me.Project_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_BLRBindingSource
        '
        Me.Vw_BLRBindingSource.DataMember = "vw_BLR"
        Me.Vw_BLRBindingSource.DataSource = Me.Project_jobDataSet
        '
        'Vw_BLRTableAdapter
        '
        Me.Vw_BLRTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_categoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_customerTableAdapter = Nothing
        Me.TableAdapterManager.tbl_isbn_bookTableAdapter = Nothing
        Me.TableAdapterManager.tbl_jobTableAdapter = Nothing
        Me.TableAdapterManager.tbl_lendingTableAdapter = Nothing
        Me.TableAdapterManager.tbl_projectTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Vw_BLRBindingNavigator
        '
        Me.Vw_BLRBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vw_BLRBindingNavigator.BindingSource = Me.Vw_BLRBindingSource
        Me.Vw_BLRBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vw_BLRBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vw_BLRBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vw_BLRBindingNavigatorSaveItem})
        Me.Vw_BLRBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vw_BLRBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vw_BLRBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vw_BLRBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vw_BLRBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vw_BLRBindingNavigator.Name = "Vw_BLRBindingNavigator"
        Me.Vw_BLRBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vw_BLRBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Vw_BLRBindingNavigator.TabIndex = 0
        Me.Vw_BLRBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'Vw_BLRBindingNavigatorSaveItem
        '
        Me.Vw_BLRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vw_BLRBindingNavigatorSaveItem.Enabled = False
        Me.Vw_BLRBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vw_BLRBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vw_BLRBindingNavigatorSaveItem.Name = "Vw_BLRBindingNavigatorSaveItem"
        Me.Vw_BLRBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vw_BLRBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Vw_BLRDataGridView
        '
        Me.Vw_BLRDataGridView.AutoGenerateColumns = False
        Me.Vw_BLRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_BLRDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Vw_BLRDataGridView.DataSource = Me.Vw_BLRBindingSource
        Me.Vw_BLRDataGridView.Location = New System.Drawing.Point(12, 76)
        Me.Vw_BLRDataGridView.Name = "Vw_BLRDataGridView"
        Me.Vw_BLRDataGridView.RowTemplate.Height = 21
        Me.Vw_BLRDataGridView.Size = New System.Drawing.Size(764, 220)
        Me.Vw_BLRDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "貸出コード"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "book_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "書籍コード："
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "staff_code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "スタッフコード"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "貸出日"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "return_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "返却日"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn6.HeaderText = "書籍名"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "staff_name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "スタッフ名"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FillByNameToolStrip
        '
        Me.FillByNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilternameToolStripLabel, Me.FilternameToolStripTextBox, Me.FillByNameToolStripButton})
        Me.FillByNameToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByNameToolStrip.Name = "FillByNameToolStrip"
        Me.FillByNameToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillByNameToolStrip.TabIndex = 2
        Me.FillByNameToolStrip.Text = "FillByNameToolStrip"
        '
        'FilternameToolStripLabel
        '
        Me.FilternameToolStripLabel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FilternameToolStripLabel.Name = "FilternameToolStripLabel"
        Me.FilternameToolStripLabel.Size = New System.Drawing.Size(65, 22)
        Me.FilternameToolStripLabel.Text = "スタッフ名前"
        '
        'FilternameToolStripTextBox
        '
        Me.FilternameToolStripTextBox.Name = "FilternameToolStripTextBox"
        Me.FilternameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByNameToolStripButton
        '
        Me.FillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNameToolStripButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FillByNameToolStripButton.Name = "FillByNameToolStripButton"
        Me.FillByNameToolStripButton.Size = New System.Drawing.Size(59, 22)
        Me.FillByNameToolStripButton.Text = "貸出履歴"
        '
        'FillByn2ToolStrip
        '
        Me.FillByn2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByn2ToolStripButton})
        Me.FillByn2ToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillByn2ToolStrip.Name = "FillByn2ToolStrip"
        Me.FillByn2ToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillByn2ToolStrip.TabIndex = 3
        Me.FillByn2ToolStrip.Text = "FillByn2ToolStrip"
        '
        'FillByn2ToolStripButton
        '
        Me.FillByn2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByn2ToolStripButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FillByn2ToolStripButton.Name = "FillByn2ToolStripButton"
        Me.FillByn2ToolStripButton.Size = New System.Drawing.Size(93, 22)
        Me.FillByn2ToolStripButton.Text = "未返却本の一覧"
        '
        'BLR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FillByn2ToolStrip)
        Me.Controls.Add(Me.FillByNameToolStrip)
        Me.Controls.Add(Me.Vw_BLRDataGridView)
        Me.Controls.Add(Me.Vw_BLRBindingNavigator)
        Me.Name = "BLR"
        Me.Text = "BLR"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_BLRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_BLRBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vw_BLRBindingNavigator.ResumeLayout(False)
        Me.Vw_BLRBindingNavigator.PerformLayout()
        CType(Me.Vw_BLRDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByNameToolStrip.ResumeLayout(False)
        Me.FillByNameToolStrip.PerformLayout()
        Me.FillByn2ToolStrip.ResumeLayout(False)
        Me.FillByn2ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Vw_BLRBindingSource As BindingSource
    Friend WithEvents Vw_BLRTableAdapter As project_jobDataSetTableAdapters.vw_BLRTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vw_BLRBindingNavigator As BindingNavigator
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
    Friend WithEvents Vw_BLRBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Vw_BLRDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents FillByNameToolStrip As ToolStrip
    Friend WithEvents FilternameToolStripLabel As ToolStripLabel
    Friend WithEvents FilternameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByNameToolStripButton As ToolStripButton
    Friend WithEvents FillByn2ToolStrip As ToolStrip
    Friend WithEvents FillByn2ToolStripButton As ToolStripButton
End Class
