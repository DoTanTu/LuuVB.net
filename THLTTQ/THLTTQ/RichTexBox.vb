Public Class RichTexBox
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start("Chrome.exe", e.LinkText)
    End Sub
End Class