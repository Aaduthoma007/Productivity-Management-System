Imports MySql.Data.MySqlClient

Public Class MovieJournal
    Private Sub MovieJournal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            Dim conn = New MySqlConnection(My.Settings.connString)
            conn.Open()

            Dim cmd = New MySqlCommand("SELECT * FROM tbl_movie WHERE username = @username", conn)
            With cmd.Parameters
                .AddWithValue("@username", curruser)
            End With

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()

            da.Fill(ds, "tbl_movie")

            DataGridView1.DataSource = ds.Tables("tbl_movie")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim title As String = txt_title.Text.Trim()
        Dim director As String = txt_director.Text.Trim()
        Dim genre As String = txt_genre.Text.Trim()
        Dim releaseYear As String = txt_release.Text.Trim()
        Dim rating As String = txt_rating.Text.Trim()
        Dim notes As String = txt_notes.Text.Trim()

        If title = "" Or director = "" Or genre = "" Or releaseYear = "" Or rating = "" Then
            MsgBox("All fields are required except notes!", vbExclamation)
            Return
        End If

        If Not IsValidYear(releaseYear) Then
            MsgBox("Please enter a valid 4-digit release year.", vbExclamation)
            Return
        End If

        If Not IsValidRating(rating) Then
            MsgBox("Please enter a rating between 0 and 10.", vbExclamation)
            Return
        End If

        If Not IsValidGenre(genre) Then
            MsgBox("Genre should not contain numbers.", vbExclamation)
            Return
        End If

        Try
            Dim conn = New MySqlConnection(My.Settings.connString)
            conn.Open()

            Dim cmd = New MySqlCommand("INSERT INTO tbl_movie(MovieTitle, Director, Genre, Release_year, Rating, Notes, username) VALUES(@title, @director, @genre, @releaseYear, @rating, @notes, @username)", conn)
            cmd.Parameters.AddWithValue("@title", title)
            cmd.Parameters.AddWithValue("@director", director)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.Parameters.AddWithValue("@releaseYear", releaseYear)
            cmd.Parameters.AddWithValue("@rating", rating)
            cmd.Parameters.AddWithValue("@notes", notes)
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
            Dim currentTitle As String = selectedRow.Cells("MovieTitle").Value.ToString()
            Dim currentDirector As String = selectedRow.Cells("Director").Value.ToString()
            Dim currentGenre As String = selectedRow.Cells("Genre").Value.ToString()
            Dim currentReleaseYear As String = selectedRow.Cells("Release_year").Value.ToString()
            Dim currentRating As String = selectedRow.Cells("Rating").Value.ToString()
            Dim currentNotes As String = selectedRow.Cells("Notes").Value.ToString()

            Dim updatedTitle As String = InputBox($"Enter updated title (current value: {currentTitle}):", "Update Title", currentTitle)
            Dim updatedDirector As String = InputBox($"Enter updated director (current value: {currentDirector}):", "Update Director", currentDirector)
            Dim updatedGenre As String = InputBox($"Enter updated genre (current value: {currentGenre}):", "Update Genre", currentGenre)
            Dim updatedReleaseYear As String = InputBox($"Enter updated release year (current value: {currentReleaseYear}):", "Update Release Year", currentReleaseYear)
            Dim updatedRating As String = InputBox($"Enter updated rating (current value: {currentRating}):", "Update Rating", currentRating)
            Dim updatedNotes As String = InputBox($"Enter updated notes (current value: {currentNotes}):", "Update Notes", currentNotes)

            If Not IsValidYear(updatedReleaseYear) Then
                MsgBox("Please enter a valid 4-digit release year.", vbExclamation)
                Return
            End If

            If Not IsValidRating(updatedRating) Then
                MsgBox("Please enter a rating between 0 and 10.", vbExclamation)
                Return
            End If

            If Not IsValidGenre(updatedGenre) Then
                MsgBox("Genre should not contain numbers.", vbExclamation)
                Return
            End If

            Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE tbl_movie SET MovieTitle = @title, Director = @director, Genre = @genre, Release_year = @releaseYear, Rating = @rating, Notes = @notes WHERE MovieTitle = @currentTitle"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@title", updatedTitle)
                cmd.Parameters.AddWithValue("@director", updatedDirector)
                cmd.Parameters.AddWithValue("@genre", updatedGenre)
                cmd.Parameters.AddWithValue("@releaseYear", updatedReleaseYear)
                cmd.Parameters.AddWithValue("@rating", updatedRating)
                cmd.Parameters.AddWithValue("@notes", updatedNotes)
                cmd.Parameters.AddWithValue("@currentTitle", currentTitle)
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
                Dim titleToDelete As String = selectedRow.Cells("MovieTitle").Value.ToString()

                Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM tbl_movie WHERE MovieTitle = @title"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@title", titleToDelete)
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
        Me.Hide()
        DailyJournal.Show()
    End Sub

    Private Function IsValidYear(year As String) As Boolean
        If year.Length = 4 AndAlso IsNumeric(year) Then
            Return True
        End If
        Return False
    End Function

    Private Function IsValidRating(rating As String) As Boolean
        Dim ratingValue As Double
        If Double.TryParse(rating, ratingValue) AndAlso ratingValue >= 0 And ratingValue <= 10 Then
            Return True
        End If
        Return False
    End Function

    Private Function IsValidGenre(genre As String) As Boolean
        For Each ch As Char In genre
            If Char.IsDigit(ch) Then
                Return False
            End If
        Next
        Return True
    End Function
End Class

