Public Class Form2
    Dim sqlQuery As String

    'check the enterdata once the register button is clicked and create new user entry to database once the data validation is applied
    Private Sub btnreg_Click(sender As System.Object, e As System.EventArgs) Handles regbtn.Click
        Dim email_check As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(email_tb.Text)
            email_check = True
        Catch ex As Exception
            email_check = False
        End Try
        If (username_tb.Text = "" Or fname_tb.Text = "" Or lname_tb.Text = "") Then
            MsgBox("please fill the required fields")
        ElseIf (email_check = False) Then
            MsgBox("please enter correct email address")
        ElseIf (password_tb.Text.Length < 8) Then
            MsgBox("password needs to be 8 character long")
        Else
            sqlQuery = "INSERT INTO users ( `first_name`, `last_name`, `username`, `password`, `email`) VALUES"
            sqlQuery &= "('" & fname_tb.Text & "','" & lname_tb.Text & "','" & username_tb.Text & "','" & password_tb.Text & "','" & email_tb.Text & "')"
            Form1.register(sqlQuery)

        End If

    End Sub

    'init register form
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        password_tb.UseSystemPasswordChar = True
    End Sub

    'button event to show or hide the password
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles passbtn.Click
        If password_tb.UseSystemPasswordChar = True Then
            password_tb.UseSystemPasswordChar = False
            passbtn.Text = "Hide Password"
        Else
            password_tb.UseSystemPasswordChar = True
            passbtn.Text = "Show Password"
        End If
    End Sub

    'cancel button to stop new registration
    Private Sub cancelbtn_Click(sender As System.Object, e As System.EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub
End Class