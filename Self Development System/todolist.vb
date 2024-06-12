Public Class todolist


    Private Sub todolist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        ListBox1.Items.Add(TextBox1.Text.Trim)


    End Sub

    Private Sub removebutton_Click(sender As Object, e As EventArgs) Handles removebutton.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Taskhub.Show()

    End Sub
End Class