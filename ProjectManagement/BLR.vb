Public Class BLR
    Private Sub BLR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.vw_BLR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BLRTableAdapter.Fill(Me.Project_jobDataSet.vw_BLR)

    End Sub

    Private Sub FillBycodeToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBycodeToolStripButton.Click
        Try
            Me.Vw_BLRTableAdapter.FillBycode(Me.Project_jobDataSet.vw_BLR, CType(FilterToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class