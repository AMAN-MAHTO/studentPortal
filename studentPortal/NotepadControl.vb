Imports System.IO

Public Class NotepadControl
    Inherits UserControl

    Private txtNotes As TextBox
    Private btnSave As Button
    Private btnLoad As Button

    Private filePath As String = "student_notes.txt"

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        ' Size
        Me.Size = New Size(400, 400)

        ' Notes TextBox
        txtNotes = New TextBox With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Location = New Point(20, 20),
            .Size = New Size(350, 250)
        }

        ' Save Button
        btnSave = New Button With {
            .Text = "Save",
            .Location = New Point(70, 290),
            .Size = New Size(100, 40)
        }
        AddHandler btnSave.Click, AddressOf SaveNotes

        ' Load Button
        btnLoad = New Button With {
            .Text = "Load",
            .Location = New Point(220, 290),
            .Size = New Size(100, 40)
        }
        AddHandler btnLoad.Click, AddressOf LoadNotes

        ' Add controls to UI
        Me.Controls.Add(txtNotes)
        Me.Controls.Add(btnSave)
        Me.Controls.Add(btnLoad)
    End Sub

    Private Sub SaveNotes(sender As Object, e As EventArgs)
        Try
            File.WriteAllText(filePath, txtNotes.Text)


            MessageBox.Show("Notes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save notes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadNotes(sender As Object, e As EventArgs)
        Try
            If File.Exists(filePath) Then
                txtNotes.Text = File.ReadAllText(filePath)
            Else
                MessageBox.Show("No saved notes found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load notes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotepadControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

