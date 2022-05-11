Public Class BaiTapTinhToan
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ngayGio.Text = "Ngay: " & Format$(Microsoft.VisualBasic.Now, "dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles giaTri2_textbox.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles tru_RadioButton.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cong_RadioButton.Checked Then
            ketqua_label.Text = " " & CInt(giaTri1_textbox.Text) + CInt(giaTri2_textbox.Text)

        ElseIf tru_RadioButton.Checked Then
            ketqua_label.Text = " " & CInt(giaTri1_textbox.Text) - CInt(giaTri2_textbox.Text)

        ElseIf nhan_RadioButton.Checked Then
            ketqua_label.Text = " " & CInt(giaTri1_textbox.Text) * CInt(giaTri2_textbox.Text)

        ElseIf chia_RadioButton.Checked Then
            ketqua_label.Text = " " & (CInt(giaTri1_textbox.Text) / CInt(giaTri2_textbox.Text))

        ElseIf chiaLayDu_RadioButton.Checked Then
            Dim b As Double
            b = (CInt(giaTri1_textbox.Text) Mod CInt(giaTri2_textbox.Text))
            ketqua_label.Text = " " & b

        ElseIf luyThua_RadioButton.Checked Then

            Dim b As Double
            b = (CInt(giaTri1_textbox.Text) ^ CInt(giaTri2_textbox.Text))
            ketqua_label.Text = " " & b

        ElseIf chiaLaySoNguyen_RadioButton.Checked Then
            Dim b As Double
            b = (CInt(giaTri1_textbox.Text) \ CInt(giaTri2_textbox.Text))
            ketqua_label.Text = " " & b
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles tinh_btn.Click
        If hinhVuong_RadioButton.Checked Then
            ketqua_label.Text = (CInt(giaTri1_textbox.Text) * CInt(giaTri1_textbox.Text))
        ElseIf hinhChuNhat_RadioButton.Checked Then
            ketqua_label.Text = (CInt(giaTri1_textbox.Text) * CInt(giaTri2_textbox.Text))
        ElseIf hinhTron_RadioButton.Checked Then
            ketqua_label.Text = (CInt(giaTri1_textbox.Text) * CInt(giaTri1_textbox.Text)) * 3.14
        ElseIf hinhTamGiac_RadioButton.Checked Then
            Dim a As Double
            a = (CInt(giaTri1_textbox.Text) + CInt(giaTri2_textbox.Text) + CInt(giaTri3_textbox.Text)) / 2
            ketqua_label.Text = Math.Sqrt(a * (a - (CInt(giaTri1_textbox.Text))) * (a - CInt(giaTri2_textbox.Text)) * (a - CInt(giaTri3_textbox.Text)))
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles hinhChuNhat_RadioButton.CheckedChanged
        MsgBox("Hay nhap:" & vbNewLine & "Chieu rong vao Gia tri 1" & vbNewLine & "Chieu cao vao gia tri 2", vbOKOnly, "Thong bao")
    End Sub

    Private Sub hinhVuong_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles hinhVuong_RadioButton.CheckedChanged
        MsgBox("Hay nhap do dai canh vao Gia tri 1", vbOKOnly, "Thong bao")
    End Sub

    Private Sub hinhTron_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles hinhTron_RadioButton.CheckedChanged
        MsgBox("Hay nhap ban kinh vao Gia tri 1", vbOKOnly, "Thong bao")
    End Sub

    Private Sub hinhTamGiac_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles hinhTamGiac_RadioButton.CheckedChanged
        MsgBox("Hay nhap:" & vbNewLine & " Canh day vao Gia tri 1" & vbNewLine & "Chieu cao vao Gia tri 2" & vbNewLine & "Chieu cao vao Gia tri 3", vbOKOnly, "Thong bao")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles ngayGio.Click

    End Sub
End Class