Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class nhanvien
    Dim ketnoidl_somee As String = "workstation id=ps02238.mssql.somee.com;packet size=4096;user id=hoanvps02238;pwd=Hoa0908164259;data source=ps02238.mssql.somee.com;persist security info=False;initial catalog=ps02238"
    Dim dulieu As New DataTable

    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
          Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim chitietdl4 As String = " insert into from NhanVien values(@MaNhanVien, @TenDangNhap, @MatKhau) "
        Dim Executequery1 As New SqlCommand(chitietdl4, truycap)
        truycap.Open()
        Executequery1.Parameters.AddWithValue("@MaNhanVien", txt1.Text)
        Executequery1.Parameters.AddWithValue("@TenDangNhap",txt2.Text)
        Executequery1.Parameters.AddWithValue("@MatKhau", txt3.Text)
        Executequery1.ExecuteNonQuery()
        MessageBox.Show("Đã Thêm")
        'làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", truycap)
        dulieu.Clear()
        refresh.Fill(dulieu)
        thongbaonv.DataSource = dulieu

    End Sub

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

    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim chitietdl3 As String = "Update NhanVien Set values MaNhanVIen=@MaNhanVien,TenDangNhap=@TenDangNhap,MatKhau=@MatKhau"
        Dim Executetruyvan2 As New SqlCommand(chitietdl3, truycap)
        truycap.Open()
        ExecuteTruyvan2.Parameters.AddWithValue("@MaNhanVien", txt1.Text)
        ExecuteTruyvan2.Parameters.AddWithValue("@TenDangNhap", txt2.Text)
        ExecuteTruyvan2.Parameters.AddWithValue("@MatKhau", txt3.Text)

        'Chạy các câu truy vấn
        MessageBox.Show("Sửa thành công")
        'Làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", truycap)
        dulieu.Clear()
        refresh.Fill(dulieu)
        thongbaonv.DataSource = dulieu

    End Sub

    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim truycap As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim chitietdl4 As String = " delete from NhanVien Where MaNhanVien=@MaNhanVien"
        Dim Executequery3 As New SqlCommand(chitietdl4, truycap)
        truycap.Open()
        Executequery3.Parameters.AddWithValue("@MaNhanVien", txt1.Text)
        Executequery3.ExecuteNonQuery()
        MessageBox.Show("Đã Xóa")
        'làm mới
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", truycap)
        dulieu.Clear()
        refresh.Fill(dulieu)
        thongbaonv.DataSource = dulieu

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = TimeOfDay
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub
End Class