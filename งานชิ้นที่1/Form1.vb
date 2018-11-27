Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Income.Text = Val(Salary.Text) * Val(12)
        Tax.Text = Val(Income.Text) * Val(0.05)
        Balance.Text = Val(Income.Text) - Val(Tax.Text)


    End Sub
End Class
