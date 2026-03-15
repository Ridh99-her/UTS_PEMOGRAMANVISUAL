Public Class Form3
    ' 1. Tombol Kembali
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form2.Show()
        Me.Close()
    End Sub

    ' 2. Tombol Keluar
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' 3. Event Load
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' 4. Label Angkatan (Jika tidak sengaja ter-klik, biarkan saja atau hapus)
    Private Sub lblAngkatan_Click(sender As Object, e As EventArgs) Handles lblAngkatan.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class ' <-- Pastikan End Class berada di baris baru sendiri