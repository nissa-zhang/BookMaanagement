Public Class Reminder
    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.vw_BLR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BLRTableAdapter.Fill(Me.Project_jobDataSet.vw_BLR)

    End Sub

    Private Sub FillByNULL1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNULL1ToolStripButton.Click
        Try
            Me.Vw_BLRTableAdapter.FillByNULL1(Me.Project_jobDataSet.vw_BLR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Vw_BLRBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Vw_BLRBindingNavigatorSaveItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As New SqlClient.SqlConnection(
           My.Settings.project_jobConnectionString)
            Using command As SqlClient.SqlCommand = connection.CreateCommand()
                connection.Open()

                command.CommandText =
                "UPDATE tbl_Reminder SET reminder_flag =1
                WHERE staff_code= " & Vw_BLRDataGridView.SelectedCells.ToString & ""
                command.ExecuteNonQuery()
                MsgBox("返却を成功しました")
                connection.Close()
            End Using
        End Using
    End Sub
End Class