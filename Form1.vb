Public Class Form1
    Dim answer As Double
    Sub calculateSingleRoll(length As Integer, width As Integer, height As Integer, rollcoverage As Double)

        answer = (2 * (width * height + length * height)) / rollcoverage
    End Sub
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
       
        Call calculateSingleRoll(Val(CmbLenght.Text), Val(CmbWidth.Text), Val(CmbHeight.Text), Val(CmbrollCoverage.Text))
        Result.Text = Math.Ceiling(answer)
    End Sub

    Private Sub CmbLenght_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLenght.SelectedIndexChanged
        Result.Text = Nothing
    End Sub

    Private Sub CmbWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbWidth.SelectedIndexChanged
        Result.Text = Nothing
    End Sub

    Private Sub CmbHeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbHeight.SelectedIndexChanged
        Result.Text = Nothing
    End Sub

    Private Sub CmbrollCoverage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbrollCoverage.SelectedIndexChanged
        Result.Text = Nothing
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        Application.Exit()
    End Sub
End Class
