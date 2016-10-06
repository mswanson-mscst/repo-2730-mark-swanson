' Name:         Ch4 Lesson B, If statements, message boxes
' Purpose:      Currency, Tea, Electric, Quotient
' Programmer:   Mark Swanson on 10/6/2017

Public Class Form1
    Private Sub btnConvertEq_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        ' convert American dollars to the Euro, the
        ' British pound, and the South African rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAmDollar)

            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            lblEuro.Text = dblEuro.ToString("N2")
            lblPound.Text = dblPound.ToString("N2")
            lblRand.Text = dblRand.ToString("N2")
        End If
    End Sub

    Private Sub btnConvertNE_Click(sender As Object, e As EventArgs) Handles btnConvertNE.Click
        ' convert American dollars to the Euro, the
        ' British pound, and the South African rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text <> String.Empty Then
            Double.TryParse(txtAmDollar.Text, dblAmDollar)

            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            lblEuro.Text = dblEuro.ToString("N2")
            lblPound.Text = dblPound.ToString("N2")
            lblRand.Text = dblRand.ToString("N2")
        Else
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click
        ' calculate the total due

        Const dblSHIP_FEE As Double = 15
        Dim dblOrdered As Double
        Dim dblPrice As Double
        Dim dblTotalDue As Double
        Dim dlgButton As DialogResult

        Double.TryParse(txtOrdered.Text, dblOrdered)
        Double.TryParse(txtPrice.Text, dblPrice)

        dblTotalDue = dblOrdered * dblPrice
        dlgButton = MessageBox.Show("Charge for shipping?",
            "Shipping", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.Yes Then
            dblTotalDue = dblTotalDue + dblSHIP_FEE
        End If
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub btnCalcElectric_Click(sender As Object, e As EventArgs) Handles btnCalcElectric.Click
        ' calculates a customer's monthly electric bill
        Dim dblUNIT_CHG As Double = 0.13
        Dim intPrevious As Integer
        Dim intCurrent As Integer
        Dim intUnitsUsed As Integer
        Dim dblBill As Double

        Integer.TryParse(txtPrevious.Text, intPrevious)
        Integer.TryParse(txtCurrent.Text, intCurrent)

        If txtPrevious.Text = String.Empty OrElse txtCurrent.Text = String.Empty OrElse intCurrent < intPrevious Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading.",
                            "Triple County", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            intUnitsUsed = intCurrent - intPrevious
            dblBill = intUnitsUsed * dblUNIT_CHG
        End If
        lblBill.Text = dblBill.ToString("C2")
    End Sub

    Private Sub btnCalcQuot_Click(sender As Object, e As EventArgs) Handles btnCalcQuot.Click
        ' divides the larger number by the smaller number

        Const strMSG As String = "Cannot divide by 0"
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblQuotient As Double

        Double.TryParse(txtNum1.Text, dblNum1)
        Double.TryParse(txtNum2.Text, dblNum2)

        If dblNum1 < dblNum2 Then
            Dim dblTemp As Double = dblNum1
            dblNum1 = dblNum2
            dblNum2 = dblTemp
        End If

        If dblNum2 <> 0 Then
            dblQuotient = dblNum1 / dblNum2
            lblQuotient.Text = dblQuotient.ToString("N2")
        Else
            MessageBox.Show(strMSG, "Division by 0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
