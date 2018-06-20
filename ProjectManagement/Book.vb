Public Class BookForm
    Private Sub Tbl_isbn_bookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_isbn_bookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_isbn_bookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_isbn_book' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_isbn_bookTableAdapter.Fill(Me.Project_jobDataSet.tbl_isbn_book)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
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
    Public Sub SetNewMode()
        '新規モードにする
        FormMode = 2

        'プロジェクトコードを入力可能にする
        'IdTextBox.ReadOnly = Ture

        '［削除］ボタンを非表示にする
        DeleteButton.Visible = False

        '新規行を追加する
        Tbl_isbn_bookBindingSource.AddNew()
    End Sub
    Public Sub SetEditMode(pcode As String)
        '編集モードにする
        FormMode = 1


    End Sub
    Private FormMode As Integer 'フォームモード（1：編集モード、2：新規モード）

    Private Sub ProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '新規モードのときに一部のコントロールの既定値をセットする
        If FormMode = 2 Then

        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub
End Class