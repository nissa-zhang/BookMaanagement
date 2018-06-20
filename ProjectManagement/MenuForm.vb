Public Class MenuForm

    Dim frm_st As StaffForm
    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        Me.Cursor = Cursors.WaitCursor

        If frm_st Is Nothing OrElse frm_st.IsDisposed() Then
            frm_st = New StaffForm()
        End If

        frm_st.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If AdminFlag <> True Then

        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Dim frm_cs As CustomerForm

    Private Sub CustomerButton_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor

        If frm_cs Is Nothing OrElse frm_cs.IsDisposed() Then
            frm_cs = New CustomerForm()
        End If

        frm_cs.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UserButton_Click(sender As Object, e As EventArgs)

    End Sub

    Dim frm_lending As BookSearchForm
    Private Sub LendButton_Click(sender As Object, e As EventArgs) Handles LendButton.Click
        Me.Cursor = Cursors.WaitCursor

        If frm_lending Is Nothing OrElse frm_lending.IsDisposed() Then
            frm_lending = New BookSearchForm()
        End If

        frm_lending.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Me.Cursor = Cursors.WaitCursor

        If frm_lending Is Nothing OrElse frm_lending.IsDisposed() Then
            frm_lending = New BookSearchForm()
        End If

        frm_lending.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub
End Class