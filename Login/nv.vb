Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class nhanvien
    Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
    Dim dulieu As New DataTable

    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_1 As String = "insert into NhanVien values (@MaNhanVien,@TenDangNhap,@MatKhau)"
        Dim cmd_1 As New SqlCommand(lenhinsert_1, lienket)
        lienket.Open()
        cmd_1.Parameters.AddWithValue("@MaNhanVien", txt1.Text)
        cmd_1.Parameters.AddWithValue("@TenDangNhap", txt2.Text)
        cmd_1.Parameters.AddWithValue("@MatKhau", txt3.Text)
        cmd_1.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Thêm thành công")
        'Làm mới bảng
        Dim newrf_1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", lienket)
        dulieu.Clear()
        newrf_1.Fill(dulieu)
        thongbaonv.DataSource = dulieu.DefaultView
    End Sub
    'form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim truyvandl As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", truycap)
        truycap.Open()
        truyvandl.Fill(dulieu)
        thongbaonv.DataSource = dulieu
        Timer1.Start()
    End Sub

    

    Private Sub thongbao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles thongbaonv.CellContentClick
        Dim index As Integer = thongbaonv.CurrentCell.RowIndex
        txt1.Text = thongbaonv.Item(0, index).Value
        txt2.Text = thongbaonv.Item(1, index).Value
        txt3.Text = thongbaonv.Item(2, index).Value
       
    End Sub
    'Su kien nút sữa
    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_2 As String = "UPDATE NhanVien Set MaNhanVien=@MaNhanVien, TenDangNhap=@TenDangNhap, MatKhau=@MatKhau"
        Dim cmd_2 As New SqlCommand(lenhinsert_2, lienket)
        lienket.Open()
        cmd_2.Parameters.AddWithValue("@MaNhanVien", txt1.Text)
        cmd_2.Parameters.AddWithValue("@TenDangNhap", txt2.Text)
        cmd_2.Parameters.AddWithValue("@MatKhau", txt3.Text)
        cmd_2.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Sửa xong")
        Dim newrf As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", lienket)
        dulieu.Clear()
        newrf.Fill(dulieu)
        thongbaonv.DataSource = dulieu.DefaultView
    End Sub
    'Sự kiện nút xóa
    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
               Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_3 As String = "delete  from NhanVien Where MaNhanVien=@MaNhanVien"
        Dim cmd_3 As New SqlCommand(lenhinsert_3, lienket)
        lienket.Open()
        cmd_3.Parameters.AddWithValue("@MaNhanVien", txt1.Text)
        cmd_3.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Xóa Xong")
        Dim Newrf As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", lienket)
        dulieu.Clear()
        Newrf.Fill(dulieu)
        thongbaonv.DataSource = dulieu.DefaultView
    End Sub
    'Đồng hồ
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub
End Class