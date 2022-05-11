Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Public Function TinhDienTich_ChieuCao_CanhDay(ByVal chieuCao#, ByVal Day#)
        Dim dienTich#
        dienTich = (chieuCao * Day) / 2
        Return dienTich

    End Function

    Public Function TinhDienTich_3Canh(ByVal canh1#, ByVal canh2#, ByVal canh3#)
        Dim dienTich#
        Dim p#
        Dim d#
        p = (canh1 + canh2 + canh3) / 2
        d = p * (p - canh1) * (p - canh2) * (p - canh3)
        dienTich = Math.Sqrt(d)
        Return dienTich
    End Function

    Public Function TinhTong_n(ByVal so_n)

    End Function
    Private Sub bt_tinhTong_Click(sender As Object, e As EventArgs) Handles bt_tinhTong.Click
        Dim ThonBao As String = "Khong Duoc De trong"

        If tb_chieuCao.Text = "" Or tb_canhDay.Text = "" Then
            MsgBox(ThonBao, vbOKCancel)
        Else
            lb_ketQua.Text = TinhDienTich_ChieuCao_CanhDay(CDbl(tb_chieuCao.Text), CDbl(tb_canhDay.Text))
        End If

    End Sub


End Class
