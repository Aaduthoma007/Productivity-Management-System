Imports MySql.Data.MySqlClient

Public Class Bookj
    Private Sub Bookj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            Dim conn = New MySqlConnection(My.Settings.connString)
            conn.Open()

            Dim cmd = New MySqlCommand("SELECT * FROM book_tb where username = @username", conn)
            With cmd.Parameters
                .AddWithValue("@username", curruser)
            End With

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()

            da.Fill(ds, "book_tb")

            DataGridView1.DataSource = ds.Tables("book_tb")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim title As String = txt_title.Text.Trim()
        Dim author As String = txt_author.Text.Trim()
        Dim genre As String = txt_genre.Text.Trim()
        Dim publisher As String = txt_publisher.Text.Trim()
        Dim isbn As String = txt_isbn.Text.Trim()
        Dim language As String = txt_language.Text.Trim()

        If title = "" Or author = "" Or genre = "" Or publisher = "" Or isbn = "" Or language = "" Then
            MsgBox("All fields are required!", vbExclamation)
            Return
        End If

        If Not IsTextValid(title) OrElse Not IsTextValid(author) OrElse Not IsTextValid(genre) OrElse Not IsTextValid(publisher) OrElse Not IsTextValid(language) Then
            MsgBox("Fields title, author, genre, publisher, and language must not contain numbers!", vbExclamation)
            Return
        End If

        Try
            Dim conn = New MySqlConnection(My.Settings.connString)
            conn.Open()

            Dim cmd = New MySqlCommand("INSERT INTO book_tb(title, author, genre, publisher, isbn, language,username) VALUES(@title, @author, @genre, @publisher, @isbn, @language,@username)", conn)
            cmd.Parameters.AddWithValue("@title", title)
            cmd.Parameters.AddWithValue("@author", author)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.Parameters.AddWithValue("@publisher", publisher)
            cmd.Parameters.AddWithValue("@isbn", isbn)
            cmd.Parameters.AddWithValue("@language", language)
            cmd.Parameters.AddWithValue("@username", curruser)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Record inserted", vbInformation)
                ClearTextBoxes()
                LoadDataIntoDataGridView()
            Else
                MsgBox("Record not inserted", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles update.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim currentTitle As String = selectedRow.Cells("title").Value.ToString()
            Dim currentAuthor As String = selectedRow.Cells("author").Value.ToString()
            Dim currentGenre As String = selectedRow.Cells("genre").Value.ToString()
            Dim currentPublisher As String = selectedRow.Cells("publisher").Value.ToString()
            Dim currentISBN As String = selectedRow.Cells("isbn").Value.ToString()
            Dim currentLanguage As String = selectedRow.Cells("language").Value.ToString()

            Dim updatedTitle As String = InputBox($"Enter updated title (current value: {currentTitle}):", "Update Title", currentTitle)
            Dim updatedAuthor As String = InputBox($"Enter updated author (current value: {currentAuthor}):", "Update Author", currentAuthor)
            Dim updatedGenre As String = InputBox($"Enter updated genre (current value: {currentGenre}):", "Update Genre", currentGenre)
            Dim updatedPublisher As String = InputBox($"Enter updated publisher (current value: {currentPublisher}):", "Update Publisher", currentPublisher)
            Dim updatedISBN As String = InputBox($"Enter updated ISBN (current value: {currentISBN}):", "Update ISBN", currentISBN)
            Dim updatedLanguage As String = InputBox($"Enter updated language (current value: {currentLanguage}):", "Update Language", currentLanguage)

            If Not IsTextValid(updatedTitle) OrElse Not IsTextValid(updatedAuthor) OrElse Not IsTextValid(updatedGenre) OrElse Not IsTextValid(updatedPublisher) OrElse Not IsTextValid(updatedLanguage) Then
                MsgBox("Fields title, author, genre, publisher, and language must not contain numbers!", vbExclamation)
                Return
            End If

            Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE book_tb SET title = @title, author = @author, genre = @genre, publisher = @publisher, isbn = @isbn, language = @language WHERE isbn = @currentISBN"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@title", updatedTitle)
                cmd.Parameters.AddWithValue("@author", updatedAuthor)
                cmd.Parameters.AddWithValue("@genre", updatedGenre)
                cmd.Parameters.AddWithValue("@publisher", updatedPublisher)
                cmd.Parameters.AddWithValue("@isbn", updatedISBN)
                cmd.Parameters.AddWithValue("@language", updatedLanguage)
                cmd.Parameters.AddWithValue("@currentISBN", currentISBN)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Record updated successfully.", MsgBoxStyle.Information)
                    LoadDataIntoDataGridView()
                Else
                    MsgBox("Failed to update record.", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("An error occurred while updating the record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("Please select a row to update.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim isbnToDelete As String = selectedRow.Cells("isbn").Value.ToString()

                Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM book_tb WHERE isbn = @isbn"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@isbn", isbnToDelete)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Record deleted successfully.", MsgBoxStyle.Information)
                        LoadDataIntoDataGridView()
                    Else
                        MsgBox("Failed to delete record.", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    MsgBox("An error occurred while deleting the record: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MsgBox("Please select a row to delete.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Deselect_Click(sender As Object, e As EventArgs) Handles deselect.Click
        DataGridView1.ClearSelection()
    End Sub

    Private Sub ClearTextBoxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        DailyJournal.Show()
    End Sub

    Private Function IsTextValid(input As String) As Boolean
        ' Check if the input contains any digits
        Return Not input.Any(Function(c) Char.IsDigit(c))
    End Function
End Class
