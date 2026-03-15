Public Class Form2
    ' Kodingan untuk tombol Cetak
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' 1. Sinkronisasi data ke Form 3
        Form3.lblNama.Text = txtNama.Text & ", S.Kom."
        Form3.lblNIM.Text = txtNIM.Text

        ' --- TAMBAHKAN DUA BARIS INI ---
        Form3.lblProdi.Text = txtProdi.Text
        Form3.lblAngkatan.Text = txtAngkatan.Text
        ' -------------------------------

        ' 2. Logika Predikat (Instruksi UTS)
        Dim ipk As Double = Val(txtIPK.Text)
        If ipk > 3.5 Then
            Form3.lblPredikat.Text = "CUMLAUDE"
        Else
            Form3.lblPredikat.Text = "SANGAT MEMUASKAN"
        End If

        ' 3. Pindah Form
        Form3.Show()
        Me.Hide()
    End Sub

    ' Bagian ini biarkan saja atau hapus jika tidak digunakan
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class