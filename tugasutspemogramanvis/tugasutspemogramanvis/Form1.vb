Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Gunakan ToLower agar login tidak error karena huruf besar/kecil
        If txtUsername.Text.ToLower() = "admin" And txtPassword.Text = "123" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear() ' Bersihkan password jika salah
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    ' Pastikan End Sub dan End Class terpisah baris
End Class