Public Class LogonForm
    Private Sub LogonButton_Click(sender As Object, e As EventArgs) Handles LogonButton.Click
        Dim sql As String
        Using connection As New SqlClient.SqlConnection(
            My.Settings.project_jobConnectionString)

            sql = "SELECT password, admin_flag FROM tbl_staff WHERE userID='" &
                UserIDTextBox.Text.Replace("'", "''") & "'"
            Using command As New SqlClient.SqlCommand(sql, connection)
                connection.Open()

                Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()
                If dr.Read() Then
                    If RTrim(dr("password")) = PasswordTextBox.Text Then
                        MsgBox("正しいユーザーであることを認証できました。システムにログオンします。")

                        If IsDBNull(dr("admin_flag")) OrElse Not dr("admin_flag") Then
                            AdminFlag = False
                        Else
                            AdminFlag = True
                        End If

                        Dim frm_mn As New MenuForm
                        frm_mn.Show()

                        Me.Close()

                    Else
                        MsgBox("正しいパスワードを指定してください")
                    End If
                Else

                    MsgBox("正しいユーザーIDを指定してください")
                End If

                dr.Close()
                connection.Close()

            End Using

        End Using
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()

    End Sub
End Class