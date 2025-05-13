Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Class frmUtama
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim history As New List(Of Bitmap) ' Stores each state of the drawing
    Dim currentHistoryIndex As Integer = -1 ' Tracks current position in history


    Private Sub frmUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioBebas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBebas.CheckedChanged
        modegambar = "bebas"
    End Sub
    Private Sub RadioGaris_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioKotak.CheckedChanged
        modegambar = "kotak"
    End Sub
    Private Sub RadioElips_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioElips.CheckedChanged
        modegambar = "elips"
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub
    Private Sub RadioElipsIsi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                    TextBox1.AppendText("o " + "ukuran garis tepi" + " " + tepi.Width.ToString & vbNewLine)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine)
            TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
            TextBox1.AppendText("o " + "ukuran garis tepi" + " " + tepi.Width.ToString & vbNewLine)
        End If

        SaveCurrentState()
    End Sub
    Private Sub Undo()
        If currentHistoryIndex > 0 Then
            currentHistoryIndex -= 1
            PictureBox1.Image = New Bitmap(history(currentHistoryIndex))
            PictureBox1.Invalidate()
        End If
    End Sub
    Private Sub Redo()
        If currentHistoryIndex < history.Count - 1 Then
            currentHistoryIndex += 1
            PictureBox1.Image = New Bitmap(history(currentHistoryIndex))
            PictureBox1.Invalidate()
        End If
    End Sub
    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna1.BackColor
            ShapeTepian.BackColor = warnatepi
        Else
            warnaisian = Warna1.BackColor
            ShapeIsi.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna2.BackColor
            ShapeTepian.BackColor = warnatepi
        Else
            warnaisian = Warna2.BackColor
            ShapeIsi.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna3.BackColor
            ShapeTepian.BackColor = warnatepi
        Else
            warnaisian = Warna3.BackColor
            ShapeIsi.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna4.BackColor
            ShapeTepian.BackColor = warnatepi
        Else
            warnaisian = Warna4.BackColor
            ShapeIsi.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna5.BackColor
            ShapeTepian.BackColor = warnatepi
        Else
            warnaisian = Warna5.BackColor
            ShapeIsi.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna6.BackColor
            ShapeTepian.BackColor = warnatepi
        Else
            warnaisian = Warna6.BackColor
            ShapeIsi.BackColor = warnaisian
        End If
    End Sub
    Private Sub SaveCurrentState()
        ' Remove any states after current position (if we undo and then draw)
        If currentHistoryIndex < history.Count - 1 Then
            history.RemoveRange(currentHistoryIndex + 1, history.Count - currentHistoryIndex - 1)
        End If

        ' Save current image state
        Dim newState As New Bitmap(PictureBox1.Image)
        history.Add(newState)
        currentHistoryIndex = history.Count - 1


        btnUndo.Enabled = currentHistoryIndex > 0
    End Sub
    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp

        ' Clear history and add initial state
        history.Clear()
        SaveCurrentState()
    End Sub

    Private Sub gbrUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGbrUlang.Click
        btnBersihkan.PerformClick()
        Dim a As Integer = TextBox1.Lines.Count
        For i As Integer = 0 To a
            Dim teksbaris As String = TextBox1.Lines(i)
            Dim pecah() As String
            pecah = teksbaris.Split(" "c)
            On Error Resume Next
            pecah(1) = pecah(1).Trim(" "c)
            Select Case pecah(1)
                Case "warnatepi"
                    warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)),
                   CByte(pecah(4)))
                    tepi.Color = warnatepi
                Case "warnaisian"
                    warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)),
                   CByte(pecah(4)))
                    isian.Color = warnaisian
                Case "garis"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)),
                       CInt(pecah(4)), CInt(pecah(5)))
                    End Using
                Case "kotak"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elips"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotakisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                    End Using
                Case "elipsisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillEllipse(isian, rect)
                    End Using
            End Select
        Next
        PictureBox1.Invalidate()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Undo()
    End Sub

    Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        Redo()
    End Sub

    ' First, add these declarations at the class level (right after the existing declarations)
    Private OpenFileDialog1 As New OpenFileDialog With {
    .Filter = "Drawing Files (*.draw)|*.draw|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
    .Title = "Open Drawing"
}

    Private SaveFileDialog1 As New SaveFileDialog With {
    .Filter = "Drawing Files (*.draw)|*.draw|Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
    .Title = "Save Drawing",
    .DefaultExt = "draw"
}

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                TextBox1.Clear()
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                btnBersihkan.PerformClick()
                btnGbrUlang.PerformClick()
            Catch ex As Exception
                MessageBox.Show("Error opening file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                MessageBox.Show("File saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
