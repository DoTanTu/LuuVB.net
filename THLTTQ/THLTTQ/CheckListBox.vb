Public Class CheckListBox
    Private Sub CheckedListBox1_Load(sender As Object, e As EventArgs) Handles List_checkBox.SelectedIndexChanged

    End Sub

    Private Sub CheckListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, lop As Integer
        lop = 17
        For i = 1 To 3
            List_checkBox.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T1")
            List_checkBox.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T2")
            List_checkBox.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T3")
            List_checkBox.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T4")
            List_checkBox.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T5")
            lop = lop + 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buton1.Click
        If List_checkBox.SelectedItem <> " " Then
            Dim st As String = ""
            For Each ptu As Object In List_checkBox.CheckedItems
                st = st + ptu.ToString() + vbNewLine
            Next
            soThich_Label.Text = st
        End If

    End Sub

    Private Sub soThich_Label_Click(sender As Object, e As EventArgs) Handles soThich_Label.Click

    End Sub
End Class