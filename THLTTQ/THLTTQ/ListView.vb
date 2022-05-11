Public Class ListView
    Private Sub ListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Số thứ tự", 105, HorizontalAlignment.Left) ' set the name of column  
        ListView1.Columns.Add("Mã sinh viên", 103, HorizontalAlignment.Left) ' set the name of column  
        ListView1.Columns.Add("Họ và tên", 105, HorizontalAlignment.Left) ' set the name of column  
        ListView1.Columns.Add("Quê quán", 101, HorizontalAlignment.Left) ' set the name of column  
        ListView1.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class