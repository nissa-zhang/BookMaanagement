Public Class ProjectForm
    Private Sub Tbl_projectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_projectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_projectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project_jobDataSet)

    End Sub

    Private FormMode As Integer 'フォームモード（1：編集モード、2：新規モード）

    Private Sub ProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '新規モードのときに一部のコントロールの既定値をセットする
        If FormMode = 2 Then
            Complete_flagCheckBox.Checked = False
            Start_dateDateTimePicker.Value = Today
            End_dateDateTimePicker.Value = Today
        End If
    End Sub

    Public Sub SetEditMode(pcode As String)
        '編集モードにする
        FormMode = 1

        'スタッフマスターのデータをデータテーブルにセットする
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

        '顧客マスターのデータをデータテーブルにセットする
        Me.Tbl_customerTableAdapter.Fill(Me.Project_jobDataSet.tbl_customer)

        '受け取ったプロジェクトコードを使用して、該当するプロジェクトデータをデータテーブルにセットする
        Me.Tbl_projectTableAdapter.FillByPCode(Me.Project_jobDataSet.tbl_project, pcode)

        '受け取ったプロジェクトコードを使用して、該当するジョブデータをデータテーブルにセットする
        Me.Tbl_jobTableAdapter.FillByPcode(Me.Project_jobDataSet.tbl_job, pcode)
    End Sub

    Public Sub SetNewMode()
        '新規モードにする
        FormMode = 2

        'プロジェクトコードを入力可能にする
        Project_codeTextBox.ReadOnly = False

        '［削除］ボタンを非表示にする
        DeleteButton.Visible = False

        'スタッフマスターのデータをデータテーブルにセットする
        Me.Tbl_staffTableAdapter.Fill(Me.Project_jobDataSet.tbl_staff)

        '顧客マスターのデータをデータテーブルにセットする
        Me.Tbl_customerTableAdapter.Fill(Me.Project_jobDataSet.tbl_customer)

        '新規行を追加する
        Tbl_projectBindingSource.AddNew()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        '入力値のエラーチェックを行う
        If Not BeforeCheck() Then
            '入力エラーが見つかったため終了する
            Return
        End If

        '保存確認と保存処理
        If MsgBox("登録内容をデータベースに保存しますか？ ",
                  MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '編集状態を確定する
            Tbl_projectBindingSource.EndEdit()

            'テーブルアダプターを介して、tbl_projectテーブルを更新する
            Me.Tbl_projectTableAdapter.Update(Me.Project_jobDataSet.tbl_project)

            'このフォームを閉じる
            Me.Close()
        End If
    End Sub

    '入力データの検査（新規モードと編集モード兼用）
    Private Function BeforeCheck() As Boolean
        '新規モードのときのみの判定
        If FormMode = 2 Then
            'プロジェクトコードのチェック（必須、入力桁数）
            With Project_codeTextBox
                If Not System.Text.RegularExpressions.Regex.IsMatch(
                .Text, "^[a-zA-Z0-9]{1,5}$") Then
                    MsgBox("プロジェクトコードが入力されていないか、桁数をオーバーしています")
                    .Select()
                    Return False
                End If

                'プロジェクトコードの使用済みチェック
                If IsUsedProjectCode(.Text) Then
                    MsgBox("このプロジェクトコードは既に使用済みです")
                    .Select()
                    Return False
                End If
            End With
        End If

        'プロジェクト名の必須チェック
        With Project_nameTextBox
            If .Text = "" Then
                MsgBox("プロジェクト名を入力してください")
                .Select()
                Return False
            End If
        End With

        '顧客の必須チェック
        With Customer_codeComboBox
            If .SelectedIndex < 0 Then
                MsgBox("顧客を指定してください")
                .Select()
                Return False
            End If
        End With

        'マネージャーの必須チェック
        With Staff_codeComboBox
            If .SelectedIndex < 0 Then
                MsgBox("マネージャーを指定してください")
                .Select()
                Return False
            End If
        End With

        'エラーがないときにはTrueを返す
        Return True
    End Function

    'プロジェクトコードの使用済みチェック
    Private Function IsUsedProjectCode(pcode As String) As Boolean
        '使用済みのときTrue
        Dim used As Boolean = True

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.project_jobConnectionString)

            'データコマンドを作成する
            Using command As SqlClient.SqlCommand = connection.CreateCommand()

                'コネクションを開く
                connection.Open()

                'データリーダーの宣言
                Dim dr As SqlClient.SqlDataReader

                'データコマンドの定義
                command.CommandText = "SELECT COUNT(*) FROM tbl_project WHERE project_code=@pcode"
                command.Parameters.Add("@pcode", SqlDbType.Char).Value = pcode

                'データリーダーからのデータの読み出し
                dr = command.ExecuteReader()

                dr.Read()
                If dr(0) = 0 Then
                    '0件なので使用されていない
                    used = False
                End If

                'データリーダーを閉じる
                dr.Close()

                'コネクションを閉じる
                connection.Close()

            End Using

        End Using

        Return used
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'このフォームを閉じる
        Me.Close()
    End Sub
End Class