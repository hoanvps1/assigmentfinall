Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class spham
    Dim dulieu As New DataTable
    Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
    Private Sub spham_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truycap As New SqlConnection(ketnoidl_somee)
        Dim truyvandl1 As New SqlDataAdapter("select * from SanPham", truycap)

        truycap.Open()
        truyvandl1.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView

    End Sub



    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
        'ket noi toi DB Somee qua chuoi Connectstr)
        Dim truycap As New SqlConnection(ketnoidl_somee)
        'truy van de sua chua du lieu theo ma
        Dim stradd As String = "Insert into SanPham Values (@Ten_SP, @GiaCa_SP, @SoLuong_SP, @ChiTiet_SP , @MaSo_SP , @Loai_Sanpham_MaSo_SP)"
        Dim dl1 As New SqlCommand(stradd, truycap)
        'add du lieu vao
        dl1.Parameters.AddWithValue("@MaSo_SP", cbx.SelectedItem)
        dl1.Parameters.AddWithValue("@Ten_SP", txt2.Text)
        dl1.Parameters.AddWithValue("@Don_Gia", txt3.Text)
        dl1.Parameters.AddWithValue("@SoLuong_SP", txt4.Text)
        dl1.Parameters.AddWithValue("@ChiTiet_SP", txt5.Text)
        dl1.Parameters.AddWithValue("@Loai_Sanpham_MaSo_SP", txt6.Text)
        'Thuc Thi cau lenh va sua chua trong DB
        dl1.ExecuteNonQuery()
        MessageBox.Show("Đã thêm")
        Dim dl2 As SqlDataAdapter = New SqlDataAdapter(" select * from SanPham", truycap)

        'Load sp
        dulieu.Clear()
        dl2.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView
    End Sub

    Private Sub thongbao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles thongbao.CellContentClick
        Dim index As Integer = thongbao.CurrentCell.RowIndex
        cbx.Text = thongbao.Item(0, index).Value
        txt2.Text = thongbao.Item(1, index).Value
        txt3.Text = thongbao.Item(2, index).Value
        txt4.Text = thongbao.Item(3, index).Value
        txt5.Text = thongbao.Item(4, index).Value
        txt6.Text = thongbao.Item(5, index).Value
    End Sub

    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        'ket noi toi DB Somee qua chuoi Connectstr)
        Dim truycap As New SqlConnection(ketnoidl_somee)
        'truy van de sua chua du lieu theo ma
        Dim stradd As String = "UPDATE SanPham =@Ten_SP, GiaCa_SP = GiaCa_SP, SoLuong_SP = @SoLuong_SP, ChiTiet_SP = @ChiTiet_SP , MaSo_SP = @MaSo_SP where Loai_SanPham_MaSo_SP=@Loai_SanPham_MaSo"
        Dim dl2 As New SqlCommand(stradd, truycap)
            'add du lieu vao
            dl2.Parameters.AddWithValue("@MaSo_SP", cbx.Text)
            dl2.Parameters.AddWithValue("@Ten_SP", txt2.Text)
            dl2.Parameters.AddWithValue("@GiaCa_SP", txt3.Text)
            dl2.Parameters.AddWithValue("@SoLuong_SP", txt4.Text)
            dl2.Parameters.AddWithValue("@ChiTiet_SP", txt5.Text)
        dl2.Parameters.AddWithValue("@Loai_SanPham_MaSo_SP", txt6.Text)


            'Thuc Thi cau lenh va sua chua trong DB
            dl2.ExecuteNonQuery()
            'close ket noi
            MessageBox.Show("Sửa xong")
            Dim lammoi As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", truycap)
            dulieu.Clear()
            lammoi.Fill(dulieu)
            thongbao.DataSource = dulieu.DefaultView
    End Sub
    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim chitietdl4 As String = "delete  from SanPham Where MaSo_SP=@MaSo_SP"
        Dim dl3 As New SqlCommand(chitietdl4, truycap)
        truycap.Open()
        dl3.Parameters.AddWithValue("@MaSo_SP", cbx.Text)
        dl3.ExecuteNonQuery()
        MessageBox.Show("Đã Xóa")
        'làm mới
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", truycap)
        dulieu.Clear()
        lammoi.Fill(dulieu)
        thongbao.DataSource = dulieu.DefaultView

    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        MessageBox.Show("Cảm ơn bạn đã tin dùng sản phẩm")
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub
End Class