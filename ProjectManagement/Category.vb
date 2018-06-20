Public Class Category
    Private Sub Tbl_categoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_categoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_categoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_category' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_categoryTableAdapter.Fill(Me.Project_jobDataSet.tbl_category)

    End Sub
End Class