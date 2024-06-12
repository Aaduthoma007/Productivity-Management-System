Imports MySql.Data.MySqlClient

Public Class wishlist
    Dim connectionString As String = "server=localhost;database=youtube_db;user=root;password="

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define columns for DataGridView
        DataGridView1.Columns.Add("IDColumn", "ID")
        DataGridView1.Columns.Add("WishColumn", "Wish")

        ' Load wishlist items
        LoadWishlistItems()
    End Sub

    Private Sub LoadWishlistItems()
        DataGridView1.Rows.Clear()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID, Wish FROM tbl_wishlist where username=@Username"


            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", curruser)

                Using reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        Dim id As String = reader("ID").ToString()
                        Dim wish As String = reader("Wish").ToString()
                        DataGridView1.Rows.Add(id, wish)
                    End While

                End Using
            End Using

        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text <> "" Then
            Dim newItem As String = TextBox2.Text
            If Not WishlistItemExists(newItem) Then
                InsertWishlistItem(newItem)
                LoadWishlistItems()
            Else
                MsgBox("Item already exists!")
            End If
        Else
            MsgBox("No Item entered!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim id As String = selectedRow.Cells("IDColumn").Value.ToString()
            DeleteWishlistItem(id)
            LoadWishlistItems()
        Else
            MsgBox("Please select a row to delete!")
        End If
    End Sub

    Private Function WishlistItemExists(item As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM tbl_wishlist WHERE Wish = @Item and username = @Username"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Item", item)
                command.Parameters.AddWithValue("@Username", curruser)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub InsertWishlistItem(item As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO tbl_wishlist(Wish, username) VALUES(@Item, @Username)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Item", item)
                command.Parameters.AddWithValue("@Username", curruser)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub DeleteWishlistItem(id As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "DELETE FROM tbl_wishlist WHERE ID = @ID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.Parameters.AddWithValue("@Username", curruser)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Taskhub.Show()

    End Sub
End Class
