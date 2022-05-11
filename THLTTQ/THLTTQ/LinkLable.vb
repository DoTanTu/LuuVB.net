Public Class LinkLable
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("https://ute.udn.vn/default.aspx")
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://ute.udn.vn/default.aspx")
    End Sub

    Private Sub PanelGenaral_Paint(sender As Object, e As PaintEventArgs) Handles PanelGenaral.Paint

    End Sub
End Class
