Imports MySql.Data.MySqlClient

Public Class common
    Private Sub common_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            Dim conn = New MySqlConnection(My.Settings.connString)
            conn.Open()

            Dim cmd = New MySqlCommand("SELECT * FROM tbl_curd where username = @username", conn)
            With cmd.Parameters
                .AddWithValue("@username", curruser)
            End With

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()

            da.Fill(ds, "tbl_curd")

            DataGridView1.DataSource = ds.Tables("tbl_curd")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Function ValidatePhoneNumber(phoneNumber As String) As Boolean
        If phoneNumber.Length <> 10 OrElse Not IsNumeric(phoneNumber) Then
            MsgBox("Phone number must be exactly 10 digits.", MsgBoxStyle.Exclamation, "Validation Error")
            Return False
        End If
        Return True
    End Function

    Private Function ValidatePincode(pincode As String) As Boolean
        If pincode.Length <> 6 OrElse Not IsNumeric(pincode) Then
            MsgBox("Pincode must be exactly 6 digits.", MsgBoxStyle.Exclamation, "Validation Error")
            Return False
        End If
        Return True
    End Function

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Hide()
        Netwrkbrd.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim name As String = txt_name.Text.Trim()
        Dim phoneno As String = txt_phone.Text.Trim()
        Dim location As String = txt_loc.Text.Trim()
        Dim Pincode As String = txt_pin.Text.Trim()
        Dim HouseNo As String = txtt_dob.Text.Trim()

        For Each item As Control In Me.Controls
            If TypeOf item Is TextBox Then
                If item.Text = "" Then
                    MsgBox("All fields are required!", vbExclamation)
                    Return
                End If
            End If
        Next

        If Not ValidatePhoneNumber(phoneno) OrElse Not ValidatePincode(Pincode) Then
            Return
        End If

        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO tbl_curd(Name, phoneno, Location, Pincode, HouseNo, username) VALUES(@fname, @phnno, @loc, @pin, @hno, @username)", conn)
                With cmd.Parameters
                    .AddWithValue("@fname", name)
                    .AddWithValue("@phnno", phoneno)
                    .AddWithValue("@loc", location)
                    .AddWithValue("@pin", Pincode)
                    .AddWithValue("@hno", HouseNo)
                    .AddWithValue("@username", curruser)
                End With
                Dim status As Integer = cmd.ExecuteNonQuery()
                If status > 0 Then
                    MsgBox("Record inserted", vbInformation)
                    ' Clear the text in TextBox controls
                    For Each ctrl As Control In Me.Controls
                        If TypeOf ctrl Is TextBox Then
                            CType(ctrl, TextBox).Text = String.Empty
                        End If
                    Next
                    ' Update the DataGridView in real-time
                    LoadDataIntoDataGridView()
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

    'clear
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        DataGridView1.ClearSelection()
    End Sub

    'update
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim nameColumnIndex As Integer = DataGridView1.Columns("Name").Index
            Dim phonenoColumnIndex As Integer = DataGridView1.Columns("phoneno").Index
            Dim locationColumnIndex As Integer = DataGridView1.Columns("Location").Index
            Dim pincodeColumnIndex As Integer = DataGridView1.Columns("Pincode").Index
            Dim houseNoColumnIndex As Integer = DataGridView1.Columns("HouseNo").Index

            Dim currentName As String = selectedRow.Cells(nameColumnIndex).Value.ToString()
            Dim currentPhoneno As String = selectedRow.Cells(phonenoColumnIndex).Value.ToString()
            Dim currentLocation As String = selectedRow.Cells(locationColumnIndex).Value.ToString()
            Dim currentPincode As String = selectedRow.Cells(pincodeColumnIndex).Value.ToString()
            Dim currentHouseNo As String = selectedRow.Cells(houseNoColumnIndex).Value.ToString()

            Dim updatedName As String = InputBox($"Enter updated name (current value: {currentName}):", "Update Name", currentName)
            Dim updatedPhoneno As String = InputBox($"Enter updated phone number (current value: {currentPhoneno}):", "Update Phone Number", currentPhoneno)
            Dim updatedLocation As String = InputBox($"Enter updated location (current value: {currentLocation}):", "Update Location", currentLocation)
            Dim updatedPincode As String = InputBox($"Enter updated pincode (current value: {currentPincode}):", "Update Pincode", currentPincode)

            If Not ValidatePhoneNumber(updatedPhoneno) OrElse Not ValidatePincode(updatedPincode) Then
                Return
            End If

            Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE tbl_curd SET Name = @name, phoneno = @phoneno, Location = @location, Pincode = @pincode WHERE HouseNo = @houseNo"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", updatedName)
                cmd.Parameters.AddWithValue("@phoneno", updatedPhoneno)
                cmd.Parameters.AddWithValue("@location", updatedLocation)
                cmd.Parameters.AddWithValue("@pincode", updatedPincode)
                cmd.Parameters.AddWithValue("@houseNo", currentHouseNo)
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

    'delete
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim houseNoColumnIndex As Integer = DataGridView1.Columns("HouseNo").Index
            Dim houseNo As String = selectedRow.Cells(houseNoColumnIndex).Value.ToString()

            DataGridView1.Rows.Remove(selectedRow)

            Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Dim sql As String = "DELETE FROM tbl_curd WHERE HouseNo = @houseNo"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@houseNo", houseNo)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Record deleted successfully.", MsgBoxStyle.Information)
                Else
                    MsgBox("Failed to delete record.", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("An error occurred while deleting the record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("Please select a row to delete.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
