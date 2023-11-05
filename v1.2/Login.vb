Public Class Login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Username.Text = "210103004" And Password.Text = "admin" Or Username.Text = "210103022" And Password.Text = "admin" Or Username.Text = "210103028" And Password.Text = "admin" Then
            Awal_Admin.Show()
            Me.Hide()
        ElseIf Username.Text = "210103004" And Password.Text = "user" Or Username.Text = "210103022" And Password.Text = "user" Or Username.Text = "210103028" And Password.Text = "user" Then
            Awal_User.Show()
            Me.Hide()
        Else
            MsgBox("Silahkan login dengan benar")
            Username.Focus()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class