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
        thongbaokh.DataSource = dulieu.DefaultView

    End Sub
    Private Sub them_Click(sender As Object, e As EventArgs) Handles them.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_1 As String = "insert into Khach_Hang values (@Ma_KH,@HoTen_KH,@SoDT_KH,@DiaChi_KH)"
        Dim cmd_1 As New SqlCommand(lenhinsert_1, lienket)
        lienket.Open()
        cmd_1.Parameters.AddWithValue("@Ma_KH", txt1.Text)
        cmd_1.Parameters.AddWithValue("@HoTen_KH", txt2.Text)
        cmd_1.Parameters.AddWithValue("@SoDT_KH", txt3.Text)
        cmd_1.Parameters.AddWithValue("@DiaChi_KH", txt4.Text)
        cmd_1.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Thêm thành công")
        'Làm mới bảng
        Dim newrf_1 As SqlDataAdapter = New SqlDataAdapter("select * from Khach_Hang", lienket)
        dulieu.Clear()
        newrf_1.Fill(dulieu)
        thongbaokh.DataSource = dulieu.DefaultView
    End Sub

    Private Sub thongbaokh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles thongbaokh.CellContentClick
        Dim index As Integer = thongbaokh.CurrentCell.RowIndex
        txt1.Text = thongbaokh.Item(0, index).Value
        txt2.Text = thongbaokh.Item(1, index).Value
        txt3.Text = thongbaokh.Item(2, index).Value
        txt4.Text = thongbaokh.Item(3, index).Value
    End Sub

    Private Sub sua_Click(sender As Object, e As EventArgs) Handles sua.Click
         Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_2 As String = "UPDATE Khach_Hang Set HoTen_KH=@HoTen_KH,SoDT_KH=@SoDT_KH,DiaChi_KH=@DiaChi_KH where Ma_KH=@Ma_KH"
        Dim cmd_2 As New SqlCommand(lenhinsert_2, lienket)
        lienket.Open()
        cmd_2.Parameters.AddWithValue("@Ma_KH", txt1.Text)
        cmd_2.Parameters.AddWithValue("@HoTen_KH", txt2.Text)
        cmd_2.Parameters.AddWithValue("@SoDT_KH", txt3.Text)
        cmd_2.Parameters.AddWithValue("@DiaChi_KH", txt4.Text)
        cmd_2.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Sửa xong")
        Dim newrf As SqlDataAdapter = New SqlDataAdapter("select * from Khac_Hang", lienket)
        dulieu.Clear()
        newrf.Fill(dulieu)
        thongbaokh.DataSource = dulieu.DefaultView
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        MessageBox.Show("Cam On Ban Da Tin Dung San Pham")
        End
    End Sub

    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Dim lienket As SqlConnection = New SqlConnection(ketnoidl_somee)
        Dim lenhinsert_3 As String = "delete  from Khach_Hang Where Ma_KH=@Ma_KH"
        Dim cmd_3 As New SqlCommand(lenhinsert_3, lienket)
        lienket.Open()
        cmd_3.Parameters.AddWithValue("@Ma_KH", txt1.Text)
        cmd_3.ExecuteNonQuery()
        lienket.Close()
        MessageBox.Show("Xóa Xong")
        Dim Newrf As SqlDataAdapter = New SqlDataAdapter("select * from Ma_KH", lienket)
        dulieu.Clear()
        Newrf.Fill(dulieu)
        thongbaokh.DataSource = dulieu.DefaultView
    End Sub
End Class