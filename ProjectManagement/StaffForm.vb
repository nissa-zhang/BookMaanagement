Public Class StaffForm
    Private Sub Tbl_staffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_staffBindingNavigatorSaveItem.Click
        'データの検査と編集中のデータの登録（エラーのときには処理を終了する）
        If Not CheckEditData() Then Return

        'データセットが更新されていないときには、以下の処理を実行しない
        If Not Project_jobDataSet.HasChanges() Then Return

        If MsgBox("これまでの修正内容をデータベースに保存しますか？ ", MsgBoxStyle.YesNo) =
            MsgBoxResult.Yes Then
            Try
                '入力日を自動更新する
                For Each drw As DataRow In Me.Project_jobDataSet.tbl_staff.Rows()
                    'データが修正または追加されている場合には、入力日にシステム日をセットする
                    If drw.RowState = DataRowState.Modified OrElse
                        drw.RowState = DataRowState.Added Then
                        drw("input_date") = Today()
                    End If
                Next

                'データセットのtbl_staffテーブルを更新する
                Tbl_staffTableAdapter.Update(Project_jobDataSet.tbl_staff)

                MsgBox("データベースに登録しました"）

            Catch ex As Exception
                'エラーが発生した場合
                MsgBox("更新が失敗しました" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_section' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_sectionTableAdapter.Fill(Me.Project_jobDataSet.tbl_section)
        'TODO: このコード行はデータを 'Project_jobDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

    End Sub

    Private Sub MaleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MaleRadioButton.CheckedChanged, FemaleRadioButton.CheckedChanged
        Dim rb As RadioButton = sender

        'ラジオボタンがオンでないときは以降の処理をしない
        If Not rb.Checked Then Return

        'バインディングソースから現在のデータを取得する
        Dim drv As DataRowView = Me.Tbl_staffBindingSource.Current
        Dim value As Object = drv("staff_sex")

        'Null値または現在の値と違う場合にはTagプロパティの値をセットする
        If IsDBNull(value) OrElse value <> rb.Tag Then
            drv("staff_sex") = rb.Tag
        End If
    End Sub

    Private Sub Tbl_staffBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_staffBindingSource.PositionChanged
        '移動時に性別のラジオボタンを設定する

        '現在の行を変数drvに格納する
        Dim drv As DataRowView = Me.Tbl_staffBindingSource.Current

        '現在の行がないときには、何もせずに処理を終了する
        If drv Is Nothing Then Return

        '性別の値を取り出す（Nullのときは0として扱う）
        Dim value As Byte = 0
        If Not IsDBNull(drv("staff_sex")) Then
            value = drv("staff_sex")
        End If

        '性別の値によって、ラジオボタンを制御する
        Select Case value
            Case 1
                '男性
                MaleRadioButton.Checked = True
            Case 2
                '女性
                FemaleRadioButton.Checked = True
            Case Else
                '設定なし
                MaleRadioButton.Checked = False
                FemaleRadioButton.Checked = False
        End Select
    End Sub

    Private Sub MoveFirstMenuItem_Click(sender As Object, e As EventArgs) Handles MoveFirstMenuItem.Click
        '［データ］メニューの［最初に移動］コマンド
        BindingNavigatorMoveFirstItem.PerformClick()
    End Sub

    Private Sub MovePrevMenuItem_Click(sender As Object, e As EventArgs) Handles MovePrevMenuItem.Click
        '［データ］メニューの［前に戻る］コマンド
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub MoveNextMenuItem_Click(sender As Object, e As EventArgs) Handles MoveNextMenuItem.Click
        '［データ］メニューの［次に移動］コマンド
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub MoveLastMenuItem_Click(sender As Object, e As EventArgs) Handles MoveLastMenuItem.Click
        '［データ］メニューの［最後に移動］コマンド
        BindingNavigatorMoveLastItem.PerformClick()
    End Sub

    Private Sub NewMenuItem_Click(sender As Object, e As EventArgs) Handles NewMenuItem.Click
        '［データ］メニューの［新規追加］コマンド
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMenuItem.Click
        '［データ］メニューの［削除］コマンド
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub SaveMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMenuItem.Click
        '［データ］メニューの［データの保存］コマンド
        Tbl_staffBindingNavigatorSaveItem.PerformClick()
    End Sub

    Private Sub BackMenuItem_Click(sender As Object, e As EventArgs) Handles BackMenuItem.Click
        '［データ］メニューの［メニューに戻る］コマンド
        Me.Close()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        '［最初に移動］ボタンの処理
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_staffBindingSource.MoveFirst()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        '［前に移動］ボタンの処理
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_staffBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        '［次に移動］ボタンの処理
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_staffBindingSource.MoveNext()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        '［最後に移動］ボタンの処理
        'データの検査と編集中のデータの登録
        If Not CheckEditData() Then Return

        Tbl_staffBindingSource.MoveLast()
    End Sub

    Private Function CheckEditData() As Boolean
        'カレント行が存在しない場合には、何もせずに戻る
        If Tbl_staffBindingSource.Current Is Nothing Then Return True

        'データの検査（スタッフ名）
        With Staff_nameTextBox
            '未入力のとき
            If .Text = "" Then
                MsgBox("スタッフ名を入力してください"）
                'テキストボックスを選択する
                .Select()
                Return False
            End If

            'サイズチェック
            If Not CheckMaxLengthUnicode("staff_name", .Text) Then
                MsgBox("スタッフ名は20文字以内で入力してください"）
                'テキストボックスを選択する
                .Select()
                Return False
            End If
        End With

        'データの検査（スタッフ名カナ）
        With Staff_kanaTextBox
            '未入力のとき
            If .Text = "" Then
                MsgBox("スタッフ名カナを入力してください"）
                'テキストボックスを選択する
                .Select()
                Return False
            End If

            'サイズチェック
            If Not CheckMaxLengthUnicode("staff_kana", .Text) Then
                MsgBox("スタッフ名カナは20文字以内で入力してください"）
                'テキストボックスを選択する
                .Select()
                Return False
            End If
        End With

        'データの検査（所属部署）
        With Staff_sectionComboBox
            '未選択のとき
            If .Text = "" Then
                MsgBox("所属部署を選択してください"）
                'コンボボックスを選択する
                .Select()
                Return False
            End If
        End With

        'データの検査（電子メールアドレス）
        With EmailTextBox
            'サイズチェック
            If Not CheckMaxLength("email", .Text) Then
                MsgBox("電子メールアドレスは半角50文字以内で入力してください"）
                'テキストボックスを選択する
                .Select()
                Return False
            End If

            '@（アットマーク）と.（ピリオド）が含まれていることを確認する（未入力は許可）
            If .Text <> "" Then
                If .Text.IndexOf("@") = -1 OrElse .Text.IndexOf(".") = -1 Then
                    '@または.が含まれていないとき
                    MsgBox("電子メールアドレスに@または.が含まれていません")
                    'テキストボックスを選択する
                    .Select()
                    Return False
                End If
            End If
        End With

        'データの検査（内線番号）
        With Ext_phoneTextBox
            'サイズチェック
            If Not CheckMaxLength("ext_phone", .Text) Then
                MsgBox("内線番号は半角10文字以内で入力してください"）
                'テキストボックスを選択する
                .Select()
                Return False
            End If

            '数字のみであることを確認する（未入力は許可）
            If Not System.Text.RegularExpressions.Regex.IsMatch(.Text, "^[0-9]*$") Then
                '数字以外の文字が含まれているとき
                MsgBox("内線番号に数字以外の文字が含まれています")
                'テキストボックスを選択する
                .Select()
                Return False
            End If
        End With

        Try
            '編集中の場合があるため、変更内容を保存する
            Tbl_staffBindingSource.EndEdit()
        Catch ex As Exception
            'エラーが発生した場合
            MsgBox("データセットへの保存が失敗しました" & vbCrLf & vbCrLf & ex.Message)
            Return False
        End Try

        'すべての検査を通過した
        Return True
    End Function

    'サイズチェック（指定された列のサイズと文字列の比較）
    Private Function CheckMaxLength(fieldname As String, value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn =
            Project_jobDataSet.tbl_staff.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer =
            System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときにはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    'サイズチェックUnicode版（指定された列のサイズと文字列の比較）
    Private Function CheckMaxLengthUnicode(fieldname As String, value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn =
            Project_jobDataSet.tbl_staff.Columns(fieldname)
        '文字数を取得する（Unicode対応）
        Dim length As Integer = value.Length

        '指定された文字数を超えたときにはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'データの検査と編集中のデータの登録（エラーのときには処理を終了する）
        If Not CheckEditData() Then Return

        Dim staff_code As String

        'スタッフコードの入力
        Do
            staff_code = InputBox("スタッフコードを入力してください（半角6文字）")
            '［キャンセル］がクリックされたときには終了する（未入力も同じ）
            If staff_code = "" Then
                MsgBox("新規登録を中止します"）
                Return
            End If

            '半角数字6桁が入力されるまで処理を繰り返す（再入力）
            If System.Text.RegularExpressions.Regex.IsMatch(
            staff_code, "^[0-9]{6}$") Then
                Exit Do
            End If
        Loop

        '既存のスタッフコードとの重複を検査する
        For Each drw As DataRow In Project_jobDataSet.tbl_staff.Rows()
            '行の状態が"削除"のデータを除外する
            If drw.RowState <> DataRowState.Deleted Then
                'この行のスタッフコードと、入力されたスタッフコードを比較する
                If drw("staff_code") = staff_code Then
                    '重複の場合には終了する
                    MsgBox("スタッフコードが既存のデータと重複しています"）
                    Return
                End If
            End If
        Next

        '新規行に移動する
        Tbl_staffBindingSource.AddNew()

        'スタッフコードに入力された値をセットする
        Staff_codeTextBox.Text = staff_code

        '退社フラグの既定値をFalseにする
        Resign_flagCheckBox.Checked = False

        'スタッフ名のテキストボックスにフォーカスをセットする
        Staff_nameTextBox.Select()
    End Sub

    Private Sub StaffForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'フォームを閉じてよいかどうかを確認する
        If MsgBox("保存処理を実行していない場合には、作業内容がクリアされてしまいます。" &
                  vbCrLf & vbCrLf & "このままフォームを閉じてもよろしいですか？ ",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
            'イベントをキャンセルする
            e.Cancel = True
        End If
    End Sub
End Class
