Public Class BookManagementForm
    Private Sub Tbl_isbn_bookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_isbn_bookBindingNavigatorSaveItem.Click


        If MsgBox("これまでの追加内容をデータベースに保存しますか？ ", MsgBoxStyle.YesNo) =
            MsgBoxResult.Yes Then
            Try
                Tbl_isbn_bookTableAdapter.Insert(Me.IsbnTextBox.Text, Me.Category_idTextBox.Text, Me.TitleTextBox.Text, Me.AuthorTextBox.Text, 0)
                MsgBox("データベースに登録しました"）
            Catch ex As Exception
                'エラーが発生した場合
                MsgBox("更新が失敗しました" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
    Private Sub BookManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_category' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_categoryTableAdapter.Fill(Me.Project_jobDataSet.tbl_category)
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_category' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_categoryTableAdapter.Fill(Me.Project_jobDataSet.tbl_category)
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_isbn_book' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_isbn_bookTableAdapter.Fill(Me.Project_jobDataSet.tbl_isbn_book)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged

    End Sub

    Private Sub Tbl_isbn_bookDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Tbl_isbn_bookTableAdapter.Delete()

    End Sub
End Class