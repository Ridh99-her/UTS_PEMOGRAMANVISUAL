Public Class Form2
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        Form3.lblNama.Text = txtNama.Text.ToUpper
        Form3.lblNIM.Text = "NIM : " & txtNIM.Text
        Form3.lblProdi.Text = txtProdi.Text
        Form3.lblAngkatan.Text = "Angkatan : " & txtAngkatan.Text

        Dim ipk As Double = Val(txtIPK.Text)
        Dim gelar As String = "LULUS DENGAN GELAR SARJANA KOMPUTER (S.KOM)"


        If ipk >= 3.51 Then
            Form3.lblPredikat.Text = gelar & vbCrLf & "(DENGAN PUJIAN / CUMLAUDE)"
        ElseIf ipk >= 3.0 Then
            Form3.lblPredikat.Text = gelar & vbCrLf & "(SANGAT MEMUASKAN)"
        Else
            Form3.lblPredikat.Text = gelar & vbCrLf & "(MEMUASKAN)"
        End If

        Form3.lblTanggal.Text = "Lulus pada tanggal : 21 Maret 2021"

        Form3.Show()
        Me.Hide()
    End Sub


    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProdi.Items.Clear()
        txtProdi.Items.Add("Informatika")
        txtProdi.Items.Add("Multimedia")
        txtProdi.Items.Add("Desain Digital")
        If txtProdi.Items.Count > 0 Then txtProdi.SelectedIndex = 0
    End Sub
End Class