Public Class BookLendingRecordForm
    Private Sub Tbl_lendingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_lendingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_lendingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub BookLenging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet1.vw_BookLendingRecord_text' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BookLendingRecord_textTableAdapter.Fill(Me.Project_jobDataSet1.vw_BookLendingRecord_text)
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_lending' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_lendingTableAdapter.Fill(Me.Project_jobDataSet.tbl_lending)

    End Sub
End Class