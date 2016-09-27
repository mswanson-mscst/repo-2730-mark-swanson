' Purpose:      Displays employee, employer, and total contributions
' Programmer:   Mark Swanson on 9-27-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmRetirement
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates employee, employer, and total contributions

        Dim decGrossPay As Decimal
        Dim decEmployeeRate As Decimal
        Dim decEmployerRate As Decimal
        Dim decEmployeeContrib As Decimal
        Dim decEmployerContrib As Decimal
        Dim decTotalContrib As Decimal

        Decimal.TryParse(txtGrossPay.Text, decGrossPay)
        Decimal.TryParse(txtEmployeeRate.Text, decEmployeeRate)
        Decimal.TryParse(txtEmployerRate.Text, decEmployerRate)

        decEmployeeContrib = decGrossPay * decEmployeeRate * 52
        decEmployerContrib = decGrossPay * decEmployerRate * 52
        decTotalContrib = decEmployeeContrib + decEmployerContrib
        lblEmployeeContrib.Text = decEmployeeContrib.ToString("c2")
        lblEmployerContrib.Text = decEmployerContrib.ToString("c2")
        lblTotalContrib.Text = decTotalContrib.ToString("c2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtGrossPay.TextChanged, txtEmployeeRate.TextChanged, txtEmployerRate.TextChanged

        lblEmployeeContrib.Text = String.Empty
        lblEmployerContrib.Text = String.Empty
        lblTotalContrib.Text = String.Empty
    End Sub
End Class