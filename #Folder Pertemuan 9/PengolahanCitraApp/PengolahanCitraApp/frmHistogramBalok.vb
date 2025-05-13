Public Class frmHistogramBalok
    Private Sub frmHistogramBalok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r, g, b, max As Integer
        Dim hR, hG, hB As Integer
        Dim bmp = New Bitmap(frmUtama.PictureBox1.Image)
        Dim frekR(256), frekG(512), frekB(768) As Integer

        ' Initialize frequency arrays
        For i As Integer = 0 To 255
            frekR(i) = 0
            frekG(i) = 0
            frekB(i) = 0
        Next

        ' Calculate frequencies
        For bar As Integer = 1 To bmp.Height - 2
            For kol As Integer = 1 To bmp.Width - 2
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                frekR(r) += 1
                frekG(g) += 1
                frekB(b) += 1
            Next
        Next

        ' Find maximum frequency for normalization
        max = 0
        For i As Integer = 0 To 255
            If frekR(i) > max Then max = frekR(i)
            If frekG(i) > max Then max = frekG(i)
            If frekB(i) > max Then max = frekB(i)
        Next

        ' Create bitmap for histogram
        Dim histoWidth As Integer = 256 ' Total width (1 bar per intensity value)
        Dim histoHeight As Integer = 200
        Dim histo = New Bitmap(histoWidth, histoHeight)

        ' Create graphics object for drawing
        Using gHisto As Graphics = Graphics.FromImage(histo)
            ' Clear with white background
            gHisto.Clear(Color.White)

            ' Draw interleaved RGB bars (each intensity gets 3 mini-bars: R, G, B)
            Dim miniBarWidth As Integer = 1 ' Width of each color segment

            For i As Integer = 0 To 255
                ' Calculate heights for each channel
                hR = Math.Round(frekR(i) / max * (histoHeight - 1))
                hG = Math.Round(frekG(i) / max * (histoHeight - 1))
                hB = Math.Round(frekB(i) / max * (histoHeight - 1))

                ' Draw Red mini-bar (left third)
                gHisto.FillRectangle(Brushes.Red, i, histoHeight - hR, miniBarWidth, hR)

                ' Draw Green mini-bar (middle third)
                gHisto.FillRectangle(Brushes.Green, i, histoHeight - hG, miniBarWidth, hG)

                ' Draw Blue mini-bar (right third)
                gHisto.FillRectangle(Brushes.Blue, i, histoHeight - hB, miniBarWidth, hB)
            Next
        End Using



        ' Display the histogram
        PictureBox1.Image = histo

    End Sub
End Class