Public Class BookManagementForm
    Private Sub Tbl_isbn_bookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_isbn_bookBindingNavigatorSaveItem.Click
        'データセットが更新されていないときには、以下の処理を実行しない
        If Tbl_isbn_bookBindingSource.Position > 0 Then
            If MsgBox("これまでの修正内容をデータベースに保存しますか？ ", MsgBoxStyle.YesNo) =
            MsgBoxResult.Yes Then
                Try
                    Me.Validate()
                    Tbl_categoryBindingSource.EndEdit()
                    'Tbl_isbn_bookTableAdapter.Update(Me.IsbnTextBox.Displayed, Me.Category_idTextBox.Displayed, Me.TitleTextBox.Displayed, Me.AuthorTextBox.Displayed, 0)
                    MsgBox("データベースに登録しました"）
                Catch ex As Exception
                    'エラーが発生した場合
                    MsgBox("更新が失敗しました" & vbCrLf & vbCrLf & ex.Message)
                End Try
            End If

        ElseIf MsgBox("これまでの追加内容をデータベースに保存しますか？ ", MsgBoxStyle.YesNo) =
            MsgBoxResult.Yes Then
            Try
                Tbl_isbn_bookTableAdapter.Insert(Me.IsbnTextBox.Displayed, Me.Category_idTextBox.Displayed, Me.TitleTextBox.Displayed, Me.AuthorTextBox.Displayed, 0)
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
        LoadDatabase()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Tbl_isbn_bookDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookManagement.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim brm As New BookForm() '［プロジェクト管理］フォーム

        '新規モードの準備を行う
        brm.SetNewMode()

        '［book］フォームを表示する
        brm.ShowDialog(Me)

        '新規登録の処理から戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub
    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String
        'SQLステートメントの定義
        sql = "SELECT * FROM vw_projectlist"

        '条件が指定されているときにはWHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs
        End If

        'データアダプターにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(
            sql, My.Settings.project_jobConnectionString)

        'データテーブルをクリアする
        Me.Project_jobDataSet.vw_projectlist.Clear()

        'データテーブルにデータアダプターを介してデータをセットする
        da.Fill(Me.Project_jobDataSet.vw_projectlist)
    End Sub

    Private Sub CardButton_Click(sender As Object, e As EventArgs) Handles CardButton.Click

        If BookManagement.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim code As String

        row = BookManagement.CurrentRow.Index
        code = BookManagement.Item(0, row).Value.ToString()

        Dim brm As New BookForm
        brm.SetEditMode(code)
        brm.ShowDialog(Me)
        LoadDatabase()
    End Sub
End Class