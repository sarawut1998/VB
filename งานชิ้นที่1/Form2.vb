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
        Sumsales = Computer + Printer
        Commitmentx5 = Computer * 0.05
        Commitmentx10 = Printer * 0.1
        CommitmentSum = Commitmentx5 + Commitmentx10

        lblSales.Text = Computer
        lblSales2.Text = Printer
        lblSumSales.Text = Sumsales
        lblCommitmentx5.Text = Commitmentx5
        lblCommitmentx10.Text = Commitmentx10
        lblCommitmentSum.Text = CommitmentSum
    End Sub
End Class