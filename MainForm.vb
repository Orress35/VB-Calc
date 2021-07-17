Public Class MainForm
    Dim x, y, z As Integer

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        If EquationBox.Text.Contains("+") Then
            x = Integer.Parse(EquationBox.Text.Split("+")(0))
            y = Integer.Parse(EquationBox.Text.Split("+")(1))
            z = x + y
            ResultLabel.Text = "Result: " + z.ToString()
        ElseIf EquationBox.Text.Contains("-") Then
            x = Integer.Parse(EquationBox.Text.Split("-")(0))
            y = Integer.Parse(EquationBox.Text.Split("-")(1))
            z = x - y
            ResultLabel.Text = "Result: " + z.ToString()
        ElseIf EquationBox.Text.Contains("*") Then
            x = Integer.Parse(EquationBox.Text.Split("*")(0))
            y = Integer.Parse(EquationBox.Text.Split("*")(1))
            z = x * y
            ResultLabel.Text = "Result: " + z.ToString()
        ElseIf EquationBox.Text.Contains("/") Then
            x = Integer.Parse(EquationBox.Text.Split("/")(0))
            y = Integer.Parse(EquationBox.Text.Split("/")(1))
            z = x / y
            ResultLabel.Text = "Result: " + z.ToString()
        Else
            ResultLabel.Text = "Result: No operator found"
        End If
    End Sub
End Class
