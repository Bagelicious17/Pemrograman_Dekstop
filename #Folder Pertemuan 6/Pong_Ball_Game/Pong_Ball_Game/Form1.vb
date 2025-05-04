Imports System.Drawing.Drawing2D
Public Class Form1
    Dim Balls_X As Integer = 15
    Dim Balls_Y As Integer = 10

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Right AndAlso Kotak.Right < 780 Then
            Kotak.Left += 30
        End If
        If keyData = Keys.Left AndAlso Kotak.Left > 0 Then
            Kotak.Left -= 30
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Balls_Movement()
        Game_Over()
    End Sub
    Private Sub Balls_Movement()
        Balls.Left += Balls_X
        Balls.Top += Balls_Y
        If Balls.Left + Balls.Width > ClientSize.Width OrElse Balls.Left < 0 Then
            Balls_X = -Balls_X
        End If

        If Balls.Top < 0 OrElse Balls.Bounds.IntersectsWith(Kotak.Bounds) Then
            Balls_Y = -Balls_Y
        End If
    End Sub
    Private Sub Game_Over()
        If Balls.Top + Balls.Height > ClientSize.Height Then
            Timer1.Stop()
            MessageBox.Show("Game Over Bitch")
            Balls.Location = New Point(841, 419)
            Kotak.Location = New Point(800, 468)
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Timer1.Stop()
        Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Timer1.Start()
    End Sub
End Class
