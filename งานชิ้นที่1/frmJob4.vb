Public Class frmJob4
    Dim datNowDate As DateTime
    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07


        dblYearSalary = Val(txtSalary.Text * 12)
        dblBonus = Val(txtSale.Text * decR_BONUS)
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = Val(dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = dblYearSalary
        lblBonus.Text = dblBonus
        lblAllIncome.Text = dblAllIncome
        lblAllowance.Text = dblAllowance
        lblTax.Text = dblTax

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToShortDateString
    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radShorDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShorDate.CheckedChanged
        lblDate.Text = Format(Now, "Short Date")
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Format(Now, "Long Date")
    End Sub
End Class