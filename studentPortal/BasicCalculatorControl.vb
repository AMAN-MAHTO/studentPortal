Public Class BasicCalculatorControl
    Inherits UserControl

    ' Controls for the calculator
    Private txtDisplay As TextBox
    Private btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 As Button
    Private btnAdd, btnSubtract, btnMultiply, btnDivide As Button
    Private btnClear, btnEquals, btnDecimal As Button
    Private currentInput As String = ""
    Private firstNumber As Double = 0
    Private operation As String = ""
    Private result As Double = 0

    Public Sub New()
        InitializeComponents()
    End Sub

    Private displayHeight As Integer = 40 ' Set initial height for display

    Private Sub InitializeComponents()
        ' Size and Background
        Me.Size = New Size(400, 500)

        ' Display Area
        txtDisplay = New TextBox With {
            .Location = New Point(20, 20),
            .Width = 360,
            .Height = 40,
            .Font = New Font("Segoe UI", 20, FontStyle.Bold),
            .TextAlign = HorizontalAlignment.Right,
            .ReadOnly = True
        }


        ' Number Buttons 0-9
        btn0 = CreateButton("0", New Point(20, 380 - displayHeight))
        btn1 = CreateButton("1", New Point(20, 310 - displayHeight))
        btn2 = CreateButton("2", New Point(100, 310 - displayHeight))
        btn3 = CreateButton("3", New Point(180, 310 - displayHeight))
        btn4 = CreateButton("4", New Point(20, 240 - displayHeight))
        btn5 = CreateButton("5", New Point(100, 240 - displayHeight))
        btn6 = CreateButton("6", New Point(180, 240 - displayHeight))
        btn7 = CreateButton("7", New Point(20, 170 - displayHeight))
        btn8 = CreateButton("8", New Point(100, 170 - displayHeight))
        btn9 = CreateButton("9", New Point(180, 170 - displayHeight))

        ' Operation Buttons +, -, *, /
        btnAdd = CreateButton("+", New Point(260, 170 - displayHeight))
        btnSubtract = CreateButton("-", New Point(260, 240 - displayHeight))
        btnMultiply = CreateButton("*", New Point(260, 310 - displayHeight))
        btnDivide = CreateButton("/", New Point(260, 380 - displayHeight))

        ' Other Buttons
        btnClear = CreateButton("C", New Point(100, 380 - displayHeight))
        btnEquals = CreateButton("=", New Point(180, 380 - displayHeight))
        btnDecimal = CreateButton(".", New Point(340, 380 - displayHeight))

        ' Add Controls to the UserControl
        Me.Controls.Add(txtDisplay)
        Me.Controls.AddRange(New Control() {btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
                                            btnAdd, btnSubtract, btnMultiply, btnDivide, btnClear, btnEquals, btnDecimal})
    End Sub

    ' Create a button with its text and location
    Private Function CreateButton(text As String, location As Point) As Button
        Dim button As New Button With {
            .Text = text,
            .Location = location,
            .Size = New Size(60, 60),
            .Font = New Font("Segoe UI", 16),
            .BackColor = Color.LightGray
        }
        AddHandler button.Click, AddressOf Button_Click
        Return button
    End Function

    ' Handle button clicks
    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)

        Select Case button.Text
            Case "C"
                ClearDisplay()
            Case "="
                EvaluateExpression()
            Case "+", "-", "*", "/"
                SetOperation(button.Text)
            Case Else
                AppendToInput(button.Text)
        End Select
    End Sub

    ' Append a digit or decimal to the current input
    Private Sub AppendToInput(input As String)
        currentInput &= input
        txtDisplay.Text = currentInput
    End Sub

    ' Set the current operation (addition, subtraction, etc.)
    Private Sub SetOperation(op As String)
        If Not String.IsNullOrEmpty(currentInput) Then
            firstNumber = Convert.ToDouble(currentInput)
            currentInput = ""
            operation = op
        End If
    End Sub

    ' Evaluate the expression
    Private Sub EvaluateExpression()
        If Not String.IsNullOrEmpty(currentInput) Then
            Dim secondNumber As Double = Convert.ToDouble(currentInput)
            Select Case operation
                Case "+"
                    result = firstNumber + secondNumber
                Case "-"
                    result = firstNumber - secondNumber
                Case "*"
                    result = firstNumber * secondNumber
                Case "/"
                    If secondNumber <> 0 Then
                        result = firstNumber / secondNumber
                    Else
                        MessageBox.Show("Cannot divide by zero", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        result = 0
                    End If
            End Select
            txtDisplay.Text = result.ToString()
            currentInput = result.ToString()
        End If
    End Sub

    ' Clear the display and reset variables
    Private Sub ClearDisplay()
        currentInput = ""
        firstNumber = 0
        operation = ""
        txtDisplay.Text = "0"
    End Sub
End Class
