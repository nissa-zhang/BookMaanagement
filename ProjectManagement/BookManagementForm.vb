Public Class BookManagementForm
    Private Sub Tbl_isbn_bookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookManageForm.Click

        'データセットが更新されていないときには、以下の処理を実行しない
        If Tbl_isbn_bookBindingSource.Position < Tbl_isbn_bookBindingSource.Count - 1 Then

            'If Me.IdTextBox.Text = [Select](From Tbl_isbn_book) Then
            'EXISTS(SELECT * FROM Table1 WHERE Column1='SomeValue') then
            If MsgBox("これまでの修正内容をデータベースに保存しますか？ ", MsgBoxStyle.YesNo) =
            MsgBoxResult.Yes Then
                Try
                    Using connection As New SqlClient.SqlConnection(
                            My.Settings.project_jobConnectionString)
                        Using command As SqlClient.SqlCommand = connection.CreateCommand()
                            connection.Open()
                            command.CommandText = "UPDATE tbl_isbn_book SET " &
                                    "isbn='" & IsbnTextBox.Text &
                                    "', category_id = " & Category_idTextBox.Text &
                                    ", title = '" & TitleTextBox.Text &
                                    "', author = '" & AuthorTextBox.Text &
                                    "' WHERE id=" & IdTextBox.Text

                            Console.WriteLine(command.CommandText)

                            command.ExecuteNonQuery()
                            connection.Close()
                        End Using
                    End Using
                    MsgBox("データベースに登録しました"）
                    Tbl_isbn_bookDataGridView.Refresh()
                Catch ex As Exception
                    'エラーが発生した場合
                    MsgBox("更新が失敗しました" & vbCrLf & vbCrLf & ex.Message)
                End Try
            End If
        Else
            If MsgBox("これまでの追加内容をデータベースに保存しますか？ ", MsgBoxStyle.YesNo) =
                MsgBoxResult.Yes Then
                Try
                    Tbl_isbn_bookTableAdapter.Insert(Me.IsbnTextBox.Text, Me.Category_idTextBox.Text, Me.TitleTextBox.Text, Me.AuthorTextBox.Text, 0)
                    MsgBox("データベースに登録しました"）

                    Tbl_isbn_bookDataGridView.Refresh()

                Catch ex As Exception
                    'エラーが発生した場合
                    MsgBox("更新が失敗しました" & vbCrLf & vbCrLf & ex.Message)
                End Try
            End If

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



    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        IdTextBox.Enabled = False


    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("データベースからこの書籍を削除しますか？", MsgBoxStyle.YesNo) =
            MsgBoxResult.Yes Then
            Try
                Using connection As New SqlClient.SqlConnection(
                        My.Settings.project_jobConnectionString)
                    Using command As SqlClient.SqlCommand = connection.CreateCommand()
                        connection.Open()
                        command.CommandText = “DELETE FROM tbl_isbn_book WHERE id=" & IdTextBox.Text

                        Console.WriteLine(command.CommandText)

                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using
                MsgBox("データベースから削除しました"）
                Tbl_isbn_bookDataGridView.Refresh()
            Catch ex As Exception
                'エラーが発生した場合
                MsgBox("削除が失敗しました" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If
    End Sub


    Function escape_string(src As String) As String
        Dim s As String = src
        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Tbl_isbn_bookTableAdapter.FillBy(Me.Project_jobDataSet.tbl_isbn_book, "%" & escape_string(FilternameToolStripTextBox1.Text) & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class