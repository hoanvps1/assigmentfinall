Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Private Sub dangnhap_Click(sender As Object, e As EventArgs) Handles dangnhap.Click
        Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim truyvandl As New SqlDataAdapter("select * from NhanVien where TenDangNhap='" & user.Text & "' and MatKhau='" & pass.Text & "' ", truycap)
        Dim dulieu As New DataTable

        Try
            truycap.Open()
            truyvandl.Fill(dulieu)
            If dulieu.Rows.Count > 0 Then
                MessageBox.Show("Hoàn Tất ")
                index.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài Khoản hoặc Mật Khẩu")

            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        MessageBox.Show("Cảm ơn bạn đã sử dụng chương trình!^^")
        End
    End Sub


    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
