Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class index
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub nv_Click(sender As Object, e As EventArgs)
        nhanvien.Show()
    End Sub

    Private Sub sp_Click(sender As Object, e As EventArgs)
        spham.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
        Me.Opacity = 0.5
    End Sub

    

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        nhanvien.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        nhanvien.Show()
    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        spham.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        spham.Show()
    End Sub

    Private Sub LineShape1_Click(sender As Object, e As EventArgs) Handles LineShape1.Click, LineShape8.Click, LineShape6.Click, LineShape5.Click, LineShape4.Click, LineShape3.Click, LineShape2.Click, LineShape12.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        kh.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MessageBox.Show("Truy cập Bảng Hóa Đơn Thành Công")
        hd.Show()
    End Sub
End Class