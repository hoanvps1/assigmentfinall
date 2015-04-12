Imports System.Data.SqlClient
Imports System.Data.DataTable
Class kh
    Dim dulieu As New DataTable
    Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
    Private Sub spham_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truycap As New SqlConnection(ketnoidl_somee)
        Dim truyvandl1 As New SqlDataAdapter("select * from Khach_Hang", truycap)

        truycap.Open()
        truyvandl1.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView

   
   

  

    End Sub
    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
        'ket noi toi DB Somee qua chuoi Connectstr)
        Dim truycap As New SqlConnection(ketnoidl_somee)
        'truy van de sua chua du lieu theo ma
        Dim stradd As String = "Insert into Khach_hang Values (@Ma_KH, @HoTen_KH, @SoDT_KH , @DiaChi_KH)"
        Dim dl1 As New SqlCommand(stradd, truycap)
        'add du lieu vao
        dl1.Parameters.AddWithValue("@Ma_KH", txt1.Text)
        dl1.Parameters.AddWithValue("@HoTen_KH", txt2.Text)
        dl1.Parameters.AddWithValue("@SoDT_KH", txt3.Text)
        dl1.Parameters.AddWithValue("@DiaChi_KH", txt4.Text)
        'Thuc Thi cau lenh va sua chua trong DB
        dl1.ExecuteNonQuery()
        MessageBox.Show("Đã thêm")
        Dim dl2 As SqlDataAdapter = New SqlDataAdapter(" select * from Khach_hang", truycap)

        'Load sp
        dulieu.Clear()
        dl2.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView
    End Sub

    Private Sub thongbao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles thongbao.CellContentClick
        Dim index As Integer = thongbao.CurrentCell.RowIndex

        txt1.Text = thongbao.Item(1, index).Value
        txt2.Text = thongbao.Item(2, index).Value
        txt3.Text = thongbao.Item(3, index).Value
        txt4.Text = thongbao.Item(4, index).Value
    End Sub

    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        'ket noi toi DB Somee qua chuoi Connectstr)
        Dim truycap As New SqlConnection(ketnoidl_somee)
        'truy van de sua chua du lieu theo ma
        Dim stradd As String = "UPDATE Khach_Hang =@Ma_KH, HoTen_KH = @HoTen_KH, SoDT_KH = @SoDT_KH, DiaChi_KH = @DiaChi_KH"
        Dim dl2 As New SqlCommand(stradd, truycap)
        'add du lieu vao
        dl2.Parameters.AddWithValue("@Ma_KH", txt1.Text)
        dl2.Parameters.AddWithValue("@HoTen_KH", txt2.Text)
        dl2.Parameters.AddWithValue("@SoDT_KH", txt3.Text)
        dl2.Parameters.AddWithValue("@DiaChi_KH", txt4.Text)


        'Thuc Thi cau lenh va sua chua trong DB
        dl2.ExecuteNonQuery()
        'close ket noi
        MessageBox.Show("Sửa xong")
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter("select * from Khach_Hang", truycap)
        dulieu.Clear()
        lammoi.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        MessageBox.Show("Cam On Ban Da Tin Dung San Pham")
        End
    End Sub

    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim chitietdl4 As String = "delete  from Khach_Hang Where Ma_KH=@MMa_KH"
        Dim dl3 As New SqlCommand(chitietdl4, truycap)
        truycap.Open()
        dl3.Parameters.AddWithValue("@Ma_KH", txt1.Text)
        dl3.ExecuteNonQuery()
        MessageBox.Show("Đã Xóa")
        'làm mới
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", truycap)
        dulieu.Clear()
        lammoi.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView
    End Sub
End Class