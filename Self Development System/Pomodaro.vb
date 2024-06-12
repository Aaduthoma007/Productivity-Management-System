Public Class pomodaro
    Dim workDuration As Integer = 25 ' Work duration in minutes
    Dim breakDuration As Integer = 5 ' Break duration in minutes
    Dim secondsRemaining As Integer ' Variable to store remaining seconds
    Dim isWorking As Boolean = True ' Variable to track if it's a work session or a break



    Private Sub pomodaro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTimerLabel()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If secondsRemaining > 0 Then
            secondsRemaining -= 1
            UpdateTimerLabel()
        Else
            ' Timer has reached zero, switch between work and break sessions
            If isWorking Then
                secondsRemaining = breakDuration * 60
                MessageBox.Show(" Take a Break,Motivate yourselevs,And Be Ready in 5 mins", "Pomodoro Timer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                secondsRemaining = workDuration * 60
                MessageBox.Show("Break session is over! Get back to the work.", "Pomodoro Timer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            isWorking = Not isWorking ' Switch between work and break
            UpdateTimerLabel()
        End If
    End Sub

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
    End Sub
    Private Sub UpdateTimerLabel()
        ' Calculate minutes and seconds from the remaining seconds
        Dim minutes As Integer = secondsRemaining \ 60
        Dim seconds As Integer = secondsRemaining Mod 60

        ' Update the labels with the formatted time
        lblremainingtime.Text = $"{minutes.ToString("D2")}:{seconds.ToString("D2")}"

        ' Update the session label based on whether it's a work or break session
        If isWorking Then
            lblsession.Text = "Work Session"
        Else
            lblsession.Text = "Break Session"
        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Hide()
        timeboard.Show()

    End Sub
End Class