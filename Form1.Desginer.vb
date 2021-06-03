<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.EquationBox = New System.Windows.Forms.TextBox()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EquationBox
        '
        Me.EquationBox.Location = New System.Drawing.Point(12, 12)
        Me.EquationBox.Name = "EquationBox"
        Me.EquationBox.Size = New System.Drawing.Size(125, 27)
        Me.EquationBox.TabIndex = 0
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Location = New System.Drawing.Point(12, 46)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(97, 20)
        Me.ResultLabel.TabIndex = 3
        Me.ResultLabel.Text = "Result: NONE"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(143, 10)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(94, 29)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 74)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.EquationBox)
        Me.Name = "Form1"
        Me.Text = "Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EquationBox As TextBox
    Friend WithEvents ResultLabel As Label
    Friend WithEvents CalcButton As Button
End Class
