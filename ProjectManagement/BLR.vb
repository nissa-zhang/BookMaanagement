Public Class BLR
    Private Sub BLR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.vw_BLR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BLRTableAdapter.Fill(Me.Project_jobDataSet.vw_BLR)

    End Sub

    Private Sub FillByNameToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNameToolStripButton.Click
        Try
            Me.Vw_BLRTableAdapter.FillByName(Me.Project_jobDataSet.vw_BLR, FilternameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) 



    End Sub

    Private Sub FillByNULLToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Vw_BLRTableAdapter.FillByNULL(Me.Project_jobDataSet.vw_BLR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByNToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Vw_BLRTableAdapter.FillByN(Me.Project_jobDataSet.vw_BLR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub FillByn2ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByn2ToolStripButton.Click
        Try
            Me.Vw_BLRTableAdapter.FillByn2(Me.Project_jobDataSet.vw_BLR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class