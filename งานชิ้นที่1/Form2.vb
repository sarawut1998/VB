Public Class Form2
    Private Sub Bt1_Click(sender As Object, e As EventArgs) Handles Bt1.Click
        Dim Computer As Double
        Dim Printer As Double
        Dim Sumsales As Double
        Dim Commitmentx5 As Double
        Dim Commitmentx10 As Double
        Dim CommitmentSum As Double

        Computer = txtcomputer.Text
        Printer = txtprinter.Text
        lblSales.Text = Computer
        lblSales2.Text = Printer

        Sumsales = Computer + Printer
        lblSumSales.Text = Sumsales

        Commitmentx5 = Sumsales * 0.05
        lblCommitmentx5.Text = Commitmentx5

        Commitmentx10 = Sumsales * 0.1
        lblCommitmentx10.Text = Commitmentx10

        CommitmentSum = Commitmentx5 + Commitmentx10
        lblCommitmentSum.Text = CommitmentSum


    End Sub
End Class