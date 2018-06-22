Public Class BookReminder
    Private Sub BookReminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.vw_BLR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BLRTableAdapter.Fill(Me.Project_jobDataSet.vw_BLR)


    End Sub

    Private Sub FillnoreToolStripButton_Click(sender As Object, e As EventArgs) Handles FillnoreToolStripButton.Click
        Try
            Me.Vw_BLRTableAdapter.Fillnore(Me.Project_jobDataSet.vw_BLR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class