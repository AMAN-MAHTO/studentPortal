<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        panalSidebar = New Panel()
        btnNotepad = New Button()
        btnCalculator = New Button()
        btnGradeCalc = New Button()
        panelContent = New Panel()
        panalSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' panalSidebar
        ' 
        panalSidebar.AccessibleName = ""
        panalSidebar.BackColor = SystemColors.ControlDark
        panalSidebar.Controls.Add(btnNotepad)
        panalSidebar.Controls.Add(btnCalculator)
        panalSidebar.Controls.Add(btnGradeCalc)
        panalSidebar.Location = New Point(1, 1)
        panalSidebar.Name = "panalSidebar"
        panalSidebar.Size = New Size(176, 446)
        panalSidebar.TabIndex = 0
        ' 
        ' btnNotepad
        ' 
        btnNotepad.Location = New Point(2, 96)
        btnNotepad.Name = "btnNotepad"
        btnNotepad.Size = New Size(171, 37)
        btnNotepad.TabIndex = 2
        btnNotepad.Text = "Notepad"
        btnNotepad.UseVisualStyleBackColor = True
        ' 
        ' btnCalculator
        ' 
        btnCalculator.Location = New Point(2, 153)
        btnCalculator.Name = "btnCalculator"
        btnCalculator.Size = New Size(171, 37)
        btnCalculator.TabIndex = 1
        btnCalculator.Text = "Basic Calculator"
        btnCalculator.UseVisualStyleBackColor = True
        ' 
        ' btnGradeCalc
        ' 
        btnGradeCalc.Location = New Point(2, 41)
        btnGradeCalc.Name = "btnGradeCalc"
        btnGradeCalc.Size = New Size(171, 37)
        btnGradeCalc.TabIndex = 0
        btnGradeCalc.Text = "Grade Calculator"
        btnGradeCalc.UseVisualStyleBackColor = True
        ' 
        ' panelContent
        ' 
        panelContent.AutoSize = True
        panelContent.BackColor = SystemColors.Info
        panelContent.Location = New Point(180, 1)
        panelContent.Name = "panelContent"
        panelContent.Size = New Size(619, 446)
        panelContent.TabIndex = 1
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelContent)
        Controls.Add(panalSidebar)
        Name = "DashboardForm"
        Text = "DashboardForm"
        panalSidebar.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panalSidebar As Panel
    Friend WithEvents btnGradeCalc As Button
    Friend WithEvents btnNotepad As Button
    Friend WithEvents btnCalculator As Button
    Friend WithEvents panelContent As Panel
End Class
