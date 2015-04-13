Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class index
    Dim openMediaFile As New DataTable

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        kh.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        hd.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub

    Private Function File() As OpenFileDialog
        Throw New NotImplementedException
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        nhanvien.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        spham.Show()
    End Sub

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class