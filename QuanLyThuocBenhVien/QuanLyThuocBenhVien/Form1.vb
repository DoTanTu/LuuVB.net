Public Class QuanLyThuocBenhVien
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
    Dim table1 As New DataTable("table1")
    Dim table2 As New DataTable("table2")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table1.Columns.Add("Nhóm thuốc", Type.GetType("System.String"))
        table1.Columns.Add("Mã thuốc", Type.GetType("System.String"))
        table1.Columns.Add("Tên thuốc", Type.GetType("System.String"))
        'table.Columns.Add("Tên thuốc", Type.GetType("System.String"))
        table1.Columns.Add("Giá bán", Type.GetType("System.Double"))
        table1.Columns.Add("Tổng số lượng", Type.GetType("System.Double"))
        table1.Columns.Add("Tống giá trị", Type.GetType("System.Double"))
        table1.Columns.Add("Ngày nhập", Type.GetType("System.String"))
        table1.Columns.Add("Hạn sử dụng", Type.GetType("System.String"))
        table1.Columns.Add("Số lượng còn", Type.GetType("System.Double"))
        table1.Columns.Add("Số lượng đã bán", Type.GetType("System.Double"))
        table1.Columns.Add("Giá nhập", Type.GetType("System.Double"))

        table1.Rows.Add("Mắt", "MP001", "Bổ sung thị lực cho mắt ", 50000, 240, 4400000, "25 / 06 / 2002", 2 / 12 / 2023, 50, 250, 200000)
        table1.Rows.Add("Phổi", "MP002", "Điều trị phổi mảng tính", 60000, 450, 560000, "27 / 04 / 2000", 2 / 12 / 2023, 65, 250, 340000)
        tabledata.DataSource = table1

        table2.Columns.Add("Ngày", Type.GetType("System.String"))
        table2.Columns.Add("Mã thuốc", Type.GetType("System.String"))
        table2.Columns.Add("Tên thuốc", Type.GetType("System.String"))
        'table.Columns.Add("Tên thuốc", Type.GetType("System.String"))
        table2.Columns.Add("Số lượng", Type.GetType("System.Double"))
        table2.Columns.Add("Tổng tiền", Type.GetType("System.Double"))
        table2.Columns.Add("Lợi nhuận", Type.GetType("System.Double"))


        table2.Rows.Add("23/06/2021", "SN201", "Tiêu hóa Aconcare", 50, 2000000, 103000)
        table2.Rows.Add("23/01/2022", "SN231", "Nhất thận hư", 70, 2500000, 126005)
        tableQuanLyMatHang.DataSource = table2
    End Sub


    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableQuanLyMatHang.CellContentClick

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class
