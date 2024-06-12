Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub registerdb_Click(sender As Object, e As EventArgs) Handles registerdb.Click
        Dim firstname As String = fnamedb.Text.Trim()
        Dim lastname As String = lnamedb.Text.Trim()
        Dim username As String = usedb.Text.Trim()
        Dim password As String = passdb.Text.Trim()

        ' Check if all fields are filled
        For Each item As Control In Me.Controls
            If TypeOf item Is TextBox AndAlso item.Text = "" Then
                MsgBox("All fields are required!", vbExclamation)
                Return
            End If
        Next

        ' Check if first name or last name contains numbers
        If ContainsNumbers(firstname) Then
            MsgBox("First name cannot contain numbers!", vbExclamation)
            Return
        End If

        If ContainsNumbers(lastname) Then
            MsgBox("Last name cannot contain numbers!", vbExclamation)
            Return
        End If

        ' Insert record into users_tb
        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO users_tb(firstname, lastname, username, upassword) VALUES(@fname, @lname, @uname, @upass)", conn)

                With cmd.Parameters
                    .AddWithValue("@fname", firstname)
                    .AddWithValue("@lname", lastname)
                    .AddWithValue("@uname", username)
                    .AddWithValue("@upass", password)
                End With

                Dim status As Integer = cmd.ExecuteNonQuery()
                If status > 0 Then
                    MsgBox("Record inserted", vbInformation)
                Else
                    MsgBox("Record not inserted", vbExclamation)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Function ContainsNumbers(input As String) As Boolean
        For Each ch As Char In input
            If Char.IsDigit(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
