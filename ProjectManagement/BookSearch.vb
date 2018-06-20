Public Class BookSearchForm
    Private Sub Tbl_isbn_bookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_isbn_bookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_isbn_bookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub BookSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_lending' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_lendingTableAdapter.Fill(Me.Project_jobDataSet.tbl_lending)
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_isbn_book' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_isbn_bookTableAdapter.Fill(Me.Project_jobDataSet.tbl_isbn_book)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_isbn_bookTableAdapter.FillBy(Me.Project_jobDataSet.tbl_isbn_book, FilternameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.Tbl_isbn_bookTableAdapter.FillBy1(Me.Project_jobDataSet.tbl_isbn_book, "%" & escape_string(FilternameToolStripTextBox.Text) & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Function escape_string(src As String) As String
        Dim s As String = src
        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Private Sub Tbl_isbn_bookDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_isbn_bookDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString)
            Using command As SqlClient.SqlCommand = connection.CreateCommand()
                connection.Open()
                command.CommandText =
                    "Insert into tbl_lending(book_id, staff_code, start_date, return_date) values(" &
                    Me.Book_idTextBox.Text & "," &
                    Me.Staff_codeTextBox.Text & "," &
                  "FORMAT(GETDATE(),'yyyy/MM/dd') ,null)"
                command.ExecuteNonQuery()
                MsgBox("貸出を成功しました")
                connection.Close()
            End Using
        End Using

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using connection As New SqlClient.SqlConnection(
           My.Settings.project_jobConnectionString)
            Using command As SqlClient.SqlCommand = connection.CreateCommand()
                connection.Open()

                command.CommandText =
                "UPDATE tbl_lending SET return_date =Format(GETDATE(),'yyyy/MM/dd')
                WHERE book_id= " & Me.Book_idTextBox.Text & ""
                command.ExecuteNonQuery()
                MsgBox("返却を成功しました")
                connection.Close()
            End Using
        End Using
    End Sub
End Class