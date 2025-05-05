Public Class GradeCalculatorControl
    Inherits UserControl

    Private lblName As Label
    Private txtName As TextBox
    Private lblSubjects(4) As Label
    Private txtSubjects(4) As TextBox
    Private btnCalculate As Button
    Private lblResult As Label

    Public Sub New()
        ' Initialize all components from code
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        ' Set size of UserControl
        Me.Size = New Size(400, 400)


        ' Student Name
        lblName = New Label With {.Text = "Student Name", .Location = New Point(20, 20)}
        txtName = New TextBox With {.Location = New Point(150, 20), .Width = 200}
        Me.Controls.Add(lblName)
        Me.Controls.Add(txtName)

        ' Subject marks
        For i As Integer = 0 To 4
            lblSubjects(i) = New Label With {
                .Text = $"Subject {i + 1} Marks",
                .Location = New Point(20, 60 + (i * 40))
            }
            txtSubjects(i) = New TextBox With {
                .Location = New Point(150, 60 + (i * 40)),
                .Width = 100
            }
            Me.Controls.Add(lblSubjects(i))
            Me.Controls.Add(txtSubjects(i))
        Next

        ' Calculate Button
        btnCalculate = New Button With {
            .Text = "Calculate",
            .Location = New Point(150, 280),
            .Width = 100
        }
        AddHandler btnCalculate.Click, AddressOf btnCalculate_Click
        Me.Controls.Add(btnCalculate)

        ' Result Label
        lblResult = New Label With {
            .Text = "",
            .Location = New Point(20, 320),
            .Size = New Size(360, 60),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .ForeColor = Color.DarkBlue
        }
        Me.Controls.Add(lblResult)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        Try
            Dim name As String = txtName.Text.Trim()
            Dim total As Integer = 0
            For Each txt In txtSubjects
                total += Integer.Parse(txt.Text)
            Next
            Dim percentage As Double = total / 5.0
            Dim grade As String
            If percentage >= 90 Then
                grade = "A"
            ElseIf percentage >= 75 Then
                grade = "B"
            ElseIf percentage >= 50 Then
                grade = "C"
            Else
                grade = "Fail"
            End If

            lblResult.Text = $"Student: {name}" & vbCrLf &
                             $"Total: {total}" & vbCrLf &
                             $"Percentage: {percentage:F2}%" & vbCrLf &
                             $"Grade: {grade}"
        Catch ex As Exception
            MessageBox.Show("Please enter valid numeric marks.", "Input Error")
        End Try
    End Sub
End Class

