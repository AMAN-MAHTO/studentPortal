Public Class DashboardForm
    Private gradeCalc As New GradeCalculatorControl()
    Private notepad As New NotepadControl()
    Private calculator As New BasicCalculatorControl()

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowControl(gradeCalc)
    End Sub

    Private Sub btnGradeCalc_Click(sender As Object, e As EventArgs) Handles btnGradeCalc.Click
        btnGradeCalc.BackColor = Color.AliceBlue
        btnNotepad.BackColor = Color.White
        btnCalculator.BackColor = Color.White
        ShowControl(gradeCalc)
    End Sub

    Private Sub btnNotepad_Click(sender As Object, e As EventArgs) Handles btnNotepad.Click
        btnGradeCalc.BackColor = Color.White
        btnNotepad.BackColor = Color.AliceBlue
        btnCalculator.BackColor = Color.White
        ShowControl(notepad)
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        btnGradeCalc.BackColor = Color.White
        btnNotepad.BackColor = Color.White
        btnCalculator.BackColor = Color.AliceBlue
        ShowControl(calculator)
    End Sub

    Private Sub ShowControl(ctrl As UserControl)
        panelContent.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        panelContent.Controls.Add(ctrl)
        ctrl.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGradeCalc.Click

    End Sub
End Class