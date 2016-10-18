Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnCalc14And_Click(sender As Object, e As EventArgs) Handles btnCalc14And.Click
        ' calculate the shipping
        Dim dblOrder As Double
        Dim strCard As String
        Dim intShipping As Integer

        Double.TryParse(txtOrder.Text, dblOrder)
        strCard = txtCard.Text.ToUpper

        ' calculate and display shipping
        If dblOrder >= 100 AndAlso strCard = "Y" Then
            intShipping = 0
        Else
            intShipping = 9
        End If
        lblShipping.Text = intShipping.ToString("C0")
    End Sub

    Private Sub btnCalc14Or_Click(sender As Object, e As EventArgs) Handles btnCalc14Or.Click
        ' calculate the shipping
        Dim dblOrder As Double
        Dim strCard As String
        Dim intShipping As Integer

        Double.TryParse(txtOrder.Text, dblOrder)
        strCard = txtCard.Text.ToUpper

        ' calculate and display shipping
        If dblOrder < 100 OrElse strCard <> "Y" Then
            intShipping = 9
        Else
            intShipping = 0
        End If
        lblShipping.Text = intShipping.ToString("C0")
    End Sub

    Private Sub ClearShipping(sender As Object, e As EventArgs) _
            Handles txtOrder.TextChanged, txtCard.TextChanged
        lblShipping.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc17eq_Click(sender As Object, e As EventArgs) Handles btnCalc17eq.Click
        ' calculate the commission
        Dim strId As String
        Dim dblSales As Double
        Dim dblCommission As Double

        strId = txtId.Text.ToUpper
        Double.TryParse(txtSales.Text, dblSales)

        ' calculate and display commission
        If (strId = "A1" OrElse strId = "B2" OrElse strId = "C3") AndAlso dblSales >= 25000 Then
            dblCommission = dblSales * 0.15
        Else
            dblCommission = dblSales * 0.12
        End If
        lblCommission.Text = dblCommission.ToString("C2")
    End Sub

    Private Sub btnCalc17ne_Click(sender As Object, e As EventArgs) Handles btnCalc17ne.Click
        ' calculate the commission
        Dim strId As String
        Dim dblSales As Double
        Dim dblCommission As Double

        strId = txtId.Text.ToUpper
        Double.TryParse(txtSales.Text, dblSales)

        ' calculate and display commission
        If (strId <> "A1" AndAlso strId <> "B2" AndAlso strId <> "C3") OrElse dblSales < 25000 Then
            dblCommission = dblSales * 0.12
        Else
            dblCommission = dblSales * 0.15
        End If
        lblCommission.Text = dblCommission.ToString("C2")
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) _
            Handles txtId.TextChanged, txtSales.TextChanged
        lblCommission.Text = String.Empty
    End Sub
End Class
