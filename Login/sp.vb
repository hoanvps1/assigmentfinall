Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class spham
    Dim dulieu As New DataTable
    Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
    Private Sub spham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lienket As New SqlConnection(ketnoidl_somee)
        Dim truycapdl_1 As New SqlDataAdapter("select * from San_Pham", lienket)
        lienket.Open()
        truycapdl_1.Fill(dulieu)
        thongbaosp.DataSource = dulieu.DefaultView
    End Sub
    ' Sự Kiến Nút thêm
    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_1 As String = "insert into San_Pham values (@MaSo_SP,@Ten_SP,@GiaCa_SP,@SoLuong_SP,@MaLoai_SP)"
        Dim cmd_1 As New SqlCommand(lenhinsert_1, lienket)
        lienket.Open()
        cmd_1.Parameters.AddWithValue("@MaSo_SP", txt1.Text)
        cmd_1.Parameters.AddWithValue("@Ten_SP", txt2.Text)
        cmd_1.Parameters.AddWithValue("@GiaCa_SP", txt3.Text)
        cmd_1.Parameters.AddWithValue("@SoLuong_SP", txt4.Text)
        cmd_1.Parameters.AddWithValue("@MaLoai_SP", txt5.Text)
        'Thực Thi
        cmd_1.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Thêm thành công")
        'Làm mới bảng
        Dim newrf_1 As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", lienket)
        dulieu.Clear()
        newrf_1.Fill(dulieu)
        thongbaosp.DataSource = dulieu.DefaultView
    End Sub
    ' Sự Kiện Nút Sửa
    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_2 As String = "UPDATE San_Pham Set MaSo_SP=@MaSo_SP, Ten_SP=@Ten_SP, GiaCa_SP=@GiaCa_SP, SoLuong_SP=@SoLuong_SP where MaSo_SP=@MaSo_SP"
        Dim cmd_2 As New SqlCommand(lenhinsert_2, lienket)
        lienket.Open()
        cmd_2.Parameters.AddWithValue("@MaSo_SP", txt1.Text)
        cmd_2.Parameters.AddWithValue("@Ten_SP", txt2.Text)
        cmd_2.Parameters.AddWithValue("@GiaCa_SP", txt3.Text)
        cmd_2.Parameters.AddWithValue("@SoLuong_SP", txt4.Text)
        cmd_2.Parameters.AddWithValue("@MaLoai_SP", txt5.Text)
        'Thực thi lệnh
        cmd_2.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Sửa xong")
        Dim newrf As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", lienket)
        dulieu.Clear()
        newrf.Fill(dulieu)
        thongbaosp.DataSource = dulieu.DefaultView
    End Sub
    'Sự Kiện Nút Xóa
    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_3 As String = "delete  from San_Pham Where MaSo_SP=@MaSo_SP"
        Dim cmd_3 As New SqlCommand(lenhinsert_3, lienket)
        lienket.Open()
        cmd_3.Parameters.AddWithValue("@MaSo_SP", txt1.Text)
        cmd_3.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Đã Xóa")
        Dim Newrf As SqlDataAdapter = New SqlDataAdapter("select * from San_Pham", lienket)
        dulieu.Clear()
        Newrf.Fill(dulieu)
        thongbaosp.DataSource = dulieu.DefaultView
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

    Private Sub thongbaosp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles thongbaosp.CellContentClick
        Dim index As Integer = thongbaosp.CurrentCell.RowIndex
        txt1.Text = thongbaosp.Item(0, index).Value
        txt2.Text = thongbaosp.Item(1, index).Value
        txt3.Text = thongbaosp.Item(2, index).Value
        txt4.Text = thongbaosp.Item(3, index).Value
        txt5.Text = thongbaosp.Item(4, index).Value

    End Sub
End Class