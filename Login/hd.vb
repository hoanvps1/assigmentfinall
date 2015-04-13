Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class hd
    Dim dulieu As New DataTable
    Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
    Private Sub hd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lienket As New SqlConnection(ketnoidl_somee)
        Dim truycapdl_1 As New SqlDataAdapter("select * from HoaDon_SP", lienket)
        lienket.Open()
        truycapdl_1.Fill(dulieu)
        thongbaohd.DataSource = dulieu.DefaultView
    End Sub
    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_1 As String = "insert into HoaDon_SP values (@Ma_HD,@NgayThanhToan_HD,@ThanhTien,@Ma_KH,@KH_MaKH,@NV_MaNhanVien)"
        Dim cmd_1 As New SqlCommand(lenhinsert_1, lienket)
        lienket.Open()
        cmd_1.Parameters.AddWithValue("@Ma_HD", txt1.Text)
        cmd_1.Parameters.AddWithValue("@NgayThanhToan_HD", txt2.Text)
        cmd_1.Parameters.AddWithValue("@ThanhTien", txt3.Text)
        cmd_1.Parameters.AddWithValue("@Ma_KH", txt4.Text)
        cmd_1.Parameters.AddWithValue("@KH_MaKH", txt5.Text)
        cmd_1.Parameters.AddWithValue("@NV_MaNhanVien", txt6.Text)
        'Thực Thi
        cmd_1.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Thêm thành công")
        'Làm mới bảng
        Dim newrf_1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon_SP", lienket)
        dulieu.Clear()
        newrf_1.Fill(dulieu)
        thongbaohd.DataSource = dulieu.DefaultView
    End Sub

    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_2 As String = "UPDATE San_Pham Set NgayThanhToan_HD=@NgayThanhToan_HD,ThanhTien=@ThanhTien,Ma_KH=@Ma_KH where Ma_HD=@Ma_HD"
        Dim cmd_2 As New SqlCommand(lenhinsert_2, lienket)
        lienket.Open()
        cmd_2.Parameters.AddWithValue("@Ma_HD", txt1.Text)
        cmd_2.Parameters.AddWithValue("@NgayThanhToan_HD", txt2.Text)
        cmd_2.Parameters.AddWithValue("@ThanhTien", txt3.Text)
        cmd_2.Parameters.AddWithValue("@Ma_KH", txt4.Text)

        'Thực thi lệnh
        cmd_2.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Sửa xong")
        Dim newrf As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", lienket)
        dulieu.Clear()
        newrf.Fill(dulieu)
        thongbaohd.DataSource = dulieu.DefaultView
    End Sub

    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_3 As String = "delete  from HoaDon_SP Where Ma_HD=@Ma_HD"
        Dim cmd_3 As New SqlCommand(lenhinsert_3, lienket)
        lienket.Open()
        cmd_3.Parameters.AddWithValue("@Ma_HD", txt1.Text)
        cmd_3.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Đã Xóa")
        Dim Newrf As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon_SP", lienket)
        dulieu.Clear()
        Newrf.Fill(dulieu)
        thongbaohd.DataSource = dulieu.DefaultView
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        MessageBox.Show("Cảm Ơn bạn đã sử dụng")
        End
    End Sub
    Private Sub thongbaohd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles thongbaohd.CellContentClick
        Dim index As Integer = thongbaohd.CurrentCell.RowIndex
        txt1.Text = thongbaohd.Item(0, index).Value
        txt2.Text = thongbaohd.Item(1, index).Value
        txt3.Text = thongbaohd.Item(2, index).Value
        txt4.Text = thongbaohd.Item(3, index).Value
        txt5.Text = thongbaohd.Item(4, index).Value
    End Sub
End Class