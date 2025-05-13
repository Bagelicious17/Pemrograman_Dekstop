Imports System.Reflection.Emit

Public Class frmUtama
    Dim namafile As String
    Dim originalImage As Bitmap
    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "C:\Users\ASUS\Pictures"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namafile = openFileDialog1.FileName
            ' Store the original image when loading a new one
            originalImage = New Bitmap(PictureBox1.Image)
            ' Reset trackbars to default position (middle)
            TrackBar1.Value = 50
            TrackBar2.Value = 50
            TrackBar3.Value = 50
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim SaveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image
        SaveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If SaveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If SaveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If

    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click
        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next
        'Dim img As Image
        'img = CType(bmp, Image)
        'PictureBox1.Image = img
        PictureBox1.Image = bmp
    End Sub

    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KurangiKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(namafile)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp

    End Sub

    Private Sub Putar90DerajatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Putar90DerajatToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
        Dim bmp As New Bitmap(PictureBox1.Image)
        Dim flipp As New Bitmap(bmp.Width, bmp.Height)

        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim pixelColor As Color = bmp.GetPixel(x, y)
                flipp.SetPixel(bmp.Width - x - 1, y, pixelColor)
            Next
        Next
        PictureBox1.Image = flipp
    End Sub

    Private Sub PictureBox1_ImageChanged(sender As Object, e As EventArgs) Handles PictureBox1.Paint
        FlipHorizontalToolStripMenuItem.Enabled = (PictureBox1.Image IsNot Nothing)
    End Sub

    Private Sub FlipVertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TampilkanHIstogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanHIstogramToolStripMenuItem.Click
        frmHistogram.ShowDialog()

    End Sub

    Private Sub GaussianBlurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GaussianBlurToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 2, 1, 2, 4, 2, 1, 2, 1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 16)
                g = Math.Floor(g / 16)
                b = Math.Floor(b / 16)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ApplyColorBalance()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        ApplyColorBalance()
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        ApplyColorBalance()
    End Sub

    Private Sub ApplyColorBalance()
        ' If there's no original image, do nothing
        If originalImage Is Nothing Then
            MessageBox.Show("Please load an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Start with the original image
        Dim bmpOriginal As New Bitmap(originalImage)
        Dim bmpBalanced As New Bitmap(bmpOriginal.Width, bmpOriginal.Height)

        ' Get the balance values from trackbars (0-100)
        Dim redBalance As Double = TrackBar1.Value / 100.0
        Dim greenBalance As Double = TrackBar2.Value / 100.0
        Dim blueBalance As Double = TrackBar3.Value / 100.0

        For y As Integer = 0 To bmpOriginal.Height - 1
            For x As Integer = 0 To bmpOriginal.Width - 1
                Dim original As Color = bmpOriginal.GetPixel(x, y)

                ' Calculate new color values
                Dim r As Integer = CInt(original.R * (1 + redBalance))
                Dim g As Integer = CInt(original.G * (1 + greenBalance))
                Dim b As Integer = CInt(original.B * (1 + blueBalance))

                ' Ensure values stay within valid range
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255

                bmpBalanced.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmpBalanced
    End Sub

    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        ' If there's no original image, do nothing
        If originalImage Is Nothing Then
            MessageBox.Show("Please load an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Start with the original image
        Dim bmpOriginal As New Bitmap(originalImage)
        Dim bmpBalanced As New Bitmap(bmpOriginal.Width, bmpOriginal.Height)

        ' Get the balance values from trackbars (0-100)


        For y As Integer = 0 To bmpOriginal.Height - 1
            For x As Integer = 0 To bmpOriginal.Width - 1
                Dim original As Color = bmpOriginal.GetPixel(x, y)

                ' Calculate new color values
                Dim r As Integer = CInt(original.R * 101)
                Dim g As Integer = CInt(original.G * 1)
                Dim b As Integer = CInt(original.B * 1)

                ' Ensure values stay within valid range
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255

                bmpBalanced.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmpBalanced
    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        If originalImage Is Nothing Then
            MessageBox.Show("Please load an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Start with the original image
        Dim bmpOriginal As New Bitmap(originalImage)
        Dim bmpBalanced As New Bitmap(bmpOriginal.Width, bmpOriginal.Height)

        ' Get the balance values from trackbars (0-100)


        For y As Integer = 0 To bmpOriginal.Height - 1
            For x As Integer = 0 To bmpOriginal.Width - 1
                Dim original As Color = bmpOriginal.GetPixel(x, y)

                ' Calculate new color values
                Dim r As Integer = CInt(original.R * 1)
                Dim g As Integer = CInt(original.G * 101)
                Dim b As Integer = CInt(original.B * 1)

                ' Ensure values stay within valid range
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255

                bmpBalanced.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmpBalanced
    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please load an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bmp As New Bitmap(PictureBox1.Image)
        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim pixel As Color = bmp.GetPixel(x, y)
                Dim inverted As Color = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B)
                bmp.SetPixel(x, y, inverted)
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please load an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bmp As New Bitmap(PictureBox1.Image)
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim watermarkText As String = "Tugas 3"
        Dim font As New Font("Arial", 12, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.FromArgb(128, Color.White)) ' semi-transparent

        Dim textSize As SizeF = g.MeasureString(watermarkText, font)
        Dim xStep As Integer = CInt(textSize.Width) + 20
        Dim yStep As Integer = CInt(textSize.Height) + 20

        For y As Integer = 0 To bmp.Height Step yStep
            For x As Integer = 0 To bmp.Width Step xStep
                g.DrawString(watermarkText, font, brush, x, y)
            Next
        Next

        g.Dispose()
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click
        ' If there's no original image, do nothing
        If originalImage Is Nothing Then
            MessageBox.Show("Please load an image first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Start with the original image
        Dim bmpOriginal As New Bitmap(originalImage)
        Dim bmpBalanced As New Bitmap(bmpOriginal.Width, bmpOriginal.Height)

        ' Get the balance values from trackbars (0-100)


        For y As Integer = 0 To bmpOriginal.Height - 1
            For x As Integer = 0 To bmpOriginal.Width - 1
                Dim original As Color = bmpOriginal.GetPixel(x, y)

                ' Calculate new color values
                Dim r As Integer = CInt(original.R * 1)
                Dim g As Integer = CInt(original.G * 1)
                Dim b As Integer = CInt(original.B * 101)

                ' Ensure values stay within valid range
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255

                bmpBalanced.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = bmpBalanced
    End Sub

    Private Sub HistogramBalokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramBalokToolStripMenuItem.Click
        frmHistogramBalok.ShowDialog()
    End Sub
End Class
