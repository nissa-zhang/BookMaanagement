Public Class ProjectListForm
    Private Sub ProjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString)

            'データコマンドを作成する
            Using command As SqlClient.SqlCommand = connection.CreateCommand()

                'コネクションを開く
                connection.Open()

                'データリーダーの宣言
                Dim dr As SqlClient.SqlDataReader

                '### 顧客のコンボボックスの設定　###
                '先頭に（すべて）を追加する
                CustomerComboBox.Items.Add("（すべて）")

                'データコマンドの定義
                command.CommandText = "SELECT customer_code, customer_name FROM tbl_customer ORDER BY customer_code"

                'データリーダーからのデータの読み出し
                dr = command.ExecuteReader()
                Do While dr.Read
                    '読み出したデータをコンボボックスに追加する
                    CustomerComboBox.Items.Add(dr("customer_code") & ":" & dr("customer_name"))
                Loop

                'データリーダーを閉じる
                dr.Close()

                'コネクションを閉じる
                connection.Close()

                'コンボボックスで既定の状態として、先頭の（すべて）を選択する
                CustomerComboBox.SelectedIndex = 0
            End Using

        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        'プロジェクト名の条件指定（部分一致）と条件式の作成
        If ProjectNameTextBox.Text <> "" Then
            fs = "project_name Like N'%" & escape_string(ProjectNameTextBox.Text) & "%'"
        End If

        '顧客の条件指定と条件式の作成
        If CustomerComboBox.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "customer_code = '" &
                Strings.Left(CustomerComboBox.Text, 7) & "'"
        End If

        '完了フラグの条件指定と条件式の作成
        If Not CompleteCheckBox.Checked Then
            If fs <> "" Then
                fs &= " AND "
            End If

            '未完了データのみにする
            fs &= "complete_flag = 0"
        End If

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

    Function escape_string(src As String) As String
        Dim s As String = src

        s = s.Replace("'", "''")
        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        '指定された条件でデータベースを読み込む
        LoadDatabase()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'このフォームを閉じる
        Me.Close()
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim frm As New ProjectForm() '［プロジェクト管理］フォーム

        '新規モードの準備を行う
        frm.SetNewMode()

        '［プロジェクト管理］フォームを表示する
        frm.ShowDialog(Me)

        '新規登録の処理から戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub

    Private Sub CardButton_Click(sender As Object, e As EventArgs) Handles CardButton.Click
        'データグリッドビューが空のときは終了する
        If ProjectListDataGridView.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim code As String

        'データグリッドビューの行番号を取得する
        row = ProjectListDataGridView.CurrentRow.Index
        '行番号からプロジェクトコードを取得する
        code = ProjectListDataGridView.Item(0, row).Value.ToString()

        Dim frm As New ProjectForm '［プロジェクト管理］フォーム

        '［プロジェクト管理］フォームのSetEditModeプロシージャを呼び出して、
        '指定したプロジェクトコードのデータを表示する
        frm.SetEditMode(code)

        '［プロジェクト管理］フォームを表示する
        frm.ShowDialog(Me)

        '［プロジェクト管理］フォームから戻ってきたら、このフォームを更新する
        LoadDatabase()
    End Sub
End Class