Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If picLogo.Image IsNot Nothing Then
                picLogo.Image = SetOpacity(picLogo.Image, 0.3)
            End If


            AturTransparan(lblKementrian)
            AturTransparan(lblUniv)
            AturTransparan(lblIjazah)
            AturTransparan(lblNama)
            AturTransparan(lblNIM)
            AturTransparan(lblProdi)
            AturTransparan(lblAngkatan)
            AturTransparan(lblTanggal)
            AturTransparan(lblPredikat)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub AturTransparan(ByVal lbl As Label)
        Try
            lbl.Parent = picLogo
            lbl.BackColor = Color.Transparent
        Catch

        End Try
    End Sub


    Private Function SetOpacity(ByVal img As Image, ByVal opacity As Single) As Image
        Dim bmp As New Bitmap(img.Width, img.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim matrix As New Drawing.Imaging.ColorMatrix()
            matrix.Matrix33 = opacity
            Dim attributes As New Drawing.Imaging.ImageAttributes()
            attributes.SetColorMatrix(matrix, Drawing.Imaging.ColorMatrixFlag.Default, Drawing.Imaging.ColorAdjustType.Bitmap)
            g.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes)
        End Using
        Return bmp
    End Function

End Class