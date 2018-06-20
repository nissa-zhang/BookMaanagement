Public Class CustomerForm
    Private Sub Tbl_customerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_customerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_customerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_customer' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_customerTableAdapter.Fill(Me.Project_jobDataSet.tbl_customer)

    End Sub

    Private Sub FillByNameToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNameToolStripButton.Click
        Try
            Me.Tbl_customerTableAdapter.FillByName(Me.Project_jobDataSet.tbl_customer,
                                                   "%" & escape_string(FilternameToolStripTextBox.Text) & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Tbl_customerDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_customerDataGridView.DataError
        MsgBox("データの登録時にエラーが発生しました。" & vbCrLf & vbCrLf &
               e.Exception.Message)
    End Sub

    Function escape_string(src As String) As String
        Dim s As String = src

        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            With Tbl_customerDataGridView
                'データグリッドビューのセルの選択を解除する
                .ClearSelection()
                'データグリッドビューの最終行の先頭列に移動する
                .CurrentCell = .Rows(.NewRowIndex).Cells(0)
                '編集モードに遷移する
                .BeginEdit(False)
            End With

        Catch ex As Exception
            '例外時のエラーメッセージ
            MsgBox(ex.Message)
            Return
        End Try
    End Sub
End Class