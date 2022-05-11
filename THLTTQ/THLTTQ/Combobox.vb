Public Class Combobox
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Them_Button_Click(sender As Object, e As EventArgs) Handles Them_Button.Click
        ChonMH_ComboBox.Items.Add(Nhap_TextBox.Text)
        Nhap_TextBox.Text = ""
    End Sub

    Private Sub Chon_Button_Click(sender As Object, e As EventArgs) Handles Chon_Button.Click
        ChonMH_ListBox.Items.Add(ChonMH_ComboBox.SelectedItem)
        SoL_Label.Text = ChonMH_ListBox.Items.Count
    End Sub

    Private Sub Xoa_Button_Click(sender As Object, e As EventArgs) Handles Xoa_Button.Click
        Dim index As Integer = ChonMH_ComboBox.SelectedIndex
        ChonMH_ComboBox.Items.RemoveAt(index:=index)
        Nhap_TextBox.Text = ""
    End Sub

    Private Sub Huy_Button_Click(sender As Object, e As EventArgs) Handles Huy_Button.Click
        Dim index As Integer = ChonMH_ListBox.SelectedIndex
        ChonMH_ListBox.Items.RemoveAt(index)
    End Sub

    Private Sub SoL_Label_Load(sender As Object, e As EventArgs) Handles SoL_Label.Click

    End Sub
End Class