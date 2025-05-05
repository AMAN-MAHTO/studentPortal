
Public Class Form1
    ' Multiple hardcoded users using Dictionary (Username → Password)
    Private ReadOnly validUsers As New Dictionary(Of String, String) From {
        {"admin", "1234"},
        {"student1", "pass123"},
        {"teacher1", "teachpass"},
        {"guest", "guest123"}
    }
    Private lblMessage As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text

        If validUsers.ContainsKey(username) AndAlso validUsers(username) = password Then
            'MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the next form
            Dim dashboard As New DashboardForm() ' Replace with your actual form
            dashboard.Show()
            Me.Hide()
        Else
            Label1.Text = "Invalid username or password."
            Label1.ForeColor = Color.Red
            Label1.Show()

        End If
    End Sub


End Class
