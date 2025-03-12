Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Form1

    Dim arrFile As List(Of String) = New List(Of String) 'untuk menampung semua file original sebelum direname
    Dim arrFile2 As List(Of String) = New List(Of String) 'untuk menampung semua file hasil setelah direname
    Dim arrExt As List(Of String) = New List(Of String) 'untuk menampung semua extension file original sebelum direname
    Dim arrExt2 As List(Of String) = New List(Of String) 'untuk menampung semua extension file setelah direname
    Dim arrUndo As List(Of String) = New List(Of String) 'untuk menampung data file dan ext sebelumnya
    Dim mode As String

    Sub MuatUlang()
        lvOri.Items.Clear()
        lvOri.View = View.Details
        lvOri.BeginUpdate()
        lvPreview.Items.Clear()
        lvPreview.View = View.Details
        lvPreview.BeginUpdate()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblExt.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tpFileName.Click

    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click

    End Sub
End Class
