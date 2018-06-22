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
        Me.Project_jobDataSet = New ProjectManagement.project_jobDataSet()
        Me.Vw_BLRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_BLRTableAdapter = New ProjectManagement.project_jobDataSetTableAdapters.vw_BLRTableAdapter()
        Me.TableAdapterManager = New ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager()
        Me.FillByNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilternameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FilternameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByn2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByn2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Vw_BLRDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_BLRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByNameToolStrip.SuspendLayout()
        Me.FillByn2ToolStrip.SuspendLayout()
        CType(Me.Vw_BLRDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.tbl_reminderTableAdapter = Nothing
        Me.TableAdapterManager.tbl_sectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectManagement.project_jobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FillByNameToolStrip
        '
        Me.FillByNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilternameToolStripLabel, Me.FilternameToolStripTextBox, Me.FillByNameToolStripButton})
        Me.FillByNameToolStrip.Location = New System.Drawing.Point(0, 0)
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
        Me.FillByn2ToolStrip.Location = New System.Drawing.Point(0, 25)
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
        'Vw_BLRDataGridView
        '
        Me.Vw_BLRDataGridView.AutoGenerateColumns = False
        Me.Vw_BLRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_BLRDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5})
        Me.Vw_BLRDataGridView.DataSource = Me.Vw_BLRBindingSource
        Me.Vw_BLRDataGridView.Location = New System.Drawing.Point(12, 65)
        Me.Vw_BLRDataGridView.Name = "Vw_BLRDataGridView"
        Me.Vw_BLRDataGridView.RowTemplate.Height = 21
        Me.Vw_BLRDataGridView.Size = New System.Drawing.Size(686, 220)
        Me.Vw_BLRDataGridView.TabIndex = 3
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "staff_name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "staff_name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "start_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn6.HeaderText = "title"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "return_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "return_date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'BLR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Vw_BLRDataGridView)
        Me.Controls.Add(Me.FillByn2ToolStrip)
        Me.Controls.Add(Me.FillByNameToolStrip)
        Me.Name = "BLR"
        Me.Text = "BLR"
        CType(Me.Project_jobDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_BLRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByNameToolStrip.ResumeLayout(False)
        Me.FillByNameToolStrip.PerformLayout()
        Me.FillByn2ToolStrip.ResumeLayout(False)
        Me.FillByn2ToolStrip.PerformLayout()
        CType(Me.Vw_BLRDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Project_jobDataSet As project_jobDataSet
    Friend WithEvents Vw_BLRBindingSource As BindingSource
    Friend WithEvents Vw_BLRTableAdapter As project_jobDataSetTableAdapters.vw_BLRTableAdapter
    Friend WithEvents TableAdapterManager As project_jobDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FillByNameToolStrip As ToolStrip
    Friend WithEvents FilternameToolStripLabel As ToolStripLabel
    Friend WithEvents FilternameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByNameToolStripButton As ToolStripButton
    Friend WithEvents FillByn2ToolStrip As ToolStrip
    Friend WithEvents FillByn2ToolStripButton As ToolStripButton
    Friend WithEvents Vw_BLRDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
