Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Security.Cryptography
Imports System.Text
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dangnhap.Click
        Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim truyvandl As New SqlDataAdapter("select * from NhanVien where TenDangNhap='" & user.Text & "' and MatKhau='" & pass.Text & "' ", truycap)
        Dim dulieu As New DataTable

        Try
            truycap.Open()
            truyvandl.Fill(dulieu)
            If dulieu.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                index.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài Khoản hoặc Mật Khẩu")

            End If
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles thoat.Click
        MessageBox.Show("Cảm ơn bạn đã sử dụng chương trình!^^")
        End
    End Sub

    Private Function Main() As Object
        Throw New NotImplementedException
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Private Function trangchu() As Object
        Throw New NotImplementedException
    End Function

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub
End Class
