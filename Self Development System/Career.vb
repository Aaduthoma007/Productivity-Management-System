Imports MySql.Data.MySqlClient

Public Class Career
    Private Sub Career_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView1()
    End Sub

    Private Sub LoadDataIntoDataGridView1()
        Try
            Dim conn = New MySqlConnection(My.Settings.connString)
            conn.Open()

            Dim cmd = New MySqlCommand("SELECT * FROM tbl_career WHERE username = @username", conn)
            With cmd.Parameters
                .AddWithValue("@username", curruser)
            End With

            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()

            da.Fill(ds, "tbl_career")

            DataGridView1.DataSource = ds.Tables("tbl_career")
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
        Dim Name As String = txt_namee.Text.Trim()
        Dim Company As String = txt_company.Text.Trim()
        Dim Designation As String = txt_des.Text.Trim()
        Dim Location As String = txt_loca.Text.Trim()
        Dim NetworkingGoal As String = txt_netgoal.Text.Trim()
        Dim PhoneNo As String = txt_phnnumber.Text.Trim()

        For Each item As Control In Me.Controls
            If TypeOf item Is TextBox Then
                If item.Text = "" Then
                    MsgBox("All fields are required!", vbExclamation)
                    Return
                End If
            End If
        Next

        If Not ValidatePhoneNumber(PhoneNo) Then
            Return
        End If

        Dim conn = New MySqlConnection(My.Settings.connString)
        Try
            conn.Open()
            Using conn
                Dim cmd = New MySqlCommand("INSERT INTO tbl_career(Name, Company, Designation, Location, NetworkingGoal, PhoneNo, username) VALUES(@fname, @com, @des, @loc, @ngoal, @phn, @username)", conn)
                With cmd.Parameters
                    .AddWithValue("@fname", Name)
                    .AddWithValue("@com", Company)
                    .AddWithValue("@des", Designation)
                    .AddWithValue("@loc", Location)
                    .AddWithValue("@ngoal", NetworkingGoal)
                    .AddWithValue("@phn", PhoneNo)
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
                    LoadDataIntoDataGridView1()
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

    'clear selection
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        DataGridView1.ClearSelection()
    End Sub

    'update
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Ensure a row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Retrieve existing values from the selected row
            Dim currentName As String = selectedRow.Cells("Name").Value.ToString()
            Dim currentCompany As String = selectedRow.Cells("Company").Value.ToString()
            Dim currentDesignation As String = selectedRow.Cells("Designation").Value.ToString()
            Dim currentLocation As String = selectedRow.Cells("Location").Value.ToString()
            Dim currentNetworkingGoal As String = selectedRow.Cells("NetworkingGoal").Value.ToString()
            Dim currentPhoneNo As String = selectedRow.Cells("PhoneNo").Value.ToString() ' Assuming PhoneNo is the primary key

            ' Prompt the user to enter updated values
            Dim updatedName As String = InputBox($"Enter updated name (current value: {currentName}):", "Update Name", currentName)
            Dim updatedCompany As String = InputBox($"Enter updated company (current value: {currentCompany}):", "Update Company", currentCompany)
            Dim updatedDesignation As String = InputBox($"Enter updated designation (current value: {currentDesignation}):", "Update Designation", currentDesignation)
            Dim updatedLocation As String = InputBox($"Enter updated location (current value: {currentLocation}):", "Update Location", currentLocation)
            Dim updatedNetworkingGoal As String = InputBox($"Enter updated networking goal (current value: {currentNetworkingGoal}):", "Update Networking Goal", currentNetworkingGoal)
            Dim updatedPhoneNo As String = InputBox($"Enter updated phone number (current value: {currentPhoneNo}):", "Update Phone Number", currentPhoneNo)

            If Not ValidatePhoneNumber(updatedPhoneNo) Then
                Return
            End If

            ' Update the record in the database
            Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE tbl_career SET Name = @name, Company = @company, Designation = @designation, Location = @location, NetworkingGoal = @networkingGoal, PhoneNo = @phoneNo WHERE PhoneNo = @currentPhoneNo"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", updatedName)
                cmd.Parameters.AddWithValue("@company", updatedCompany)
                cmd.Parameters.AddWithValue("@designation", updatedDesignation)
                cmd.Parameters.AddWithValue("@location", updatedLocation)
                cmd.Parameters.AddWithValue("@networkingGoal", updatedNetworkingGoal)
                cmd.Parameters.AddWithValue("@phoneNo", updatedPhoneNo)
                cmd.Parameters.AddWithValue("@currentPhoneNo", currentPhoneNo) ' Use the current PhoneNo for identification
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Record updated successfully.", MsgBoxStyle.Information)
                    ' Reload the data into the DataGridView
                    LoadDataIntoDataGridView1()
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
            ' Prompt the user for confirmation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the primary key value (PhoneNo) of the selected row
                Dim phoneNoToDelete As String = selectedRow.Cells("PhoneNo").Value.ToString()

                ' Delete the record from the database
                Dim conn As MySqlConnection = New MySqlConnection(My.Settings.connString)
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM tbl_career WHERE PhoneNo = @phoneNo"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNoToDelete)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Record deleted successfully.", MsgBoxStyle.Information)
                        ' Reload the data into the DataGridView
                        LoadDataIntoDataGridView1()
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
End Class


























































































































































