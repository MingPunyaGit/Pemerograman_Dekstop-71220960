Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            Me.Hide()
            main.Show()
        Else
            MsgBox("Username atau Password Salah")
        End If
    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
