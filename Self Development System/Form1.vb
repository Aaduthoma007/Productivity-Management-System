Imports MySql.Data.MySqlClient

Public Class Form1
    ' Global variable to store the logged-in username
    Public Shared LoggedInUsername As String = ""

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim Username As String = TextBox1.Text.Trim()
        Dim Password As String = TextBox2.Text.Trim()

        ' Establish a connection to the MySQL database
        Using conn As New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()

                ' Construct the SQL query to check login credentials
                Dim query As String = "SELECT * FROM users_tb WHERE username = @username AND upassword = @password"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", Username)
                cmd.Parameters.AddWithValue("@password", Password)

                ' Execute the query
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if any rows are returned (i.e., if login is successful)
                If reader.Read() Then
                    ' Set the logged-in username to the global variable
                    Form1.LoggedInUsername = Username

                    ' Close the database connection
                    reader.Close()
                    conn.Close()

                    ' Show a success message
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    curruser = Username
                    ' Redirect the user to the dashboard form
                    Me.Hide()
                    dashboard.Show()
                Else
                    ' Close the database connection
                    reader.Close()
                    conn.Close()

                    ' Show an error message for incorrect credentials
                    MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                ' Show an error message for any database-related errors
                MessageBox.Show("An error occurred while attempting to log in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
