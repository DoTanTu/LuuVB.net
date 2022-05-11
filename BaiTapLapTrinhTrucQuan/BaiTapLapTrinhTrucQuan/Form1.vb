Public Class Form1
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TanTu_49_ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TanTu_49_Button1.Click

        If TanTu49_ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Vui long chon tem")
        Else
            Dim selectedItems = (From i In TanTu49_ListBox1.SelectedItems).ToList
            For Each selectedItem In selectedItems
                TanTu_49_ListBox2.Items.Add(selectedItem)
                TanTu49_ListBox1.Items.Remove(selectedItem)
            Next
        End If

    End Sub

    Private Sub TanTu324_ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TanTu49_ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles TanTu_49_Button3.Click
        If TanTu_49_ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Vui long chon tem")
        Else
            Dim selectedItems = (From i In TanTu_49_ListBox2.SelectedItems).ToList
            For Each selectedItem In selectedItems
                TanTu49_ListBox1.Items.Add(selectedItem)
                TanTu_49_ListBox2.Items.Remove(selectedItem)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TanTu_49_Button2.Click
        TanTu_49_ListBox2.Items.Clear()
        For Each but As Object In TanTu49_ListBox1.Items
            TanTu_49_ListBox2.Items.Add(but)
        Next
        TanTu49_ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles TanTu_49_Button4.Click
        TanTu49_ListBox1.Items.Clear()
        For Each but As Object In TanTu_49_ListBox2.Items
            TanTu49_ListBox1.Items.Add(but)
        Next
        TanTu_49_ListBox2.Items.Clear()
    End Sub
End Class
