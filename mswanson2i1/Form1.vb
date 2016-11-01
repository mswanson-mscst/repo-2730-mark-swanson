Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04Substring.Text
        Dim strColor As String = strItem.Substring(2, 4)
        lbl04Substring.Text = strColor

        '#05a: Length
        Dim intLength As Integer = txt05aLength.Text.Length
        lbl05aLength.Text = intLength.ToString()

        '#05b: Trim
        Dim strState As String = txt05bTrim.Text
        strState = strState.Trim()
        lbl05bTrim.Text = strState

        '05c: Remove/insert
        strWord = txt05cRemoveInsert.Text
        strWord = strWord.Remove(1, 1)
        strWord = strWord.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strWord

        '05d: Insert
        strWord = txt05dInsert.Text
        strWord = strWord.Insert(0, "Mon")
        lbl05dInsert.Text = strWord

        '05e: PadLeft
        Dim strPay As String = txt05ePad.Text
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '06: Remove
        Dim strAmount As String = txt06Remove.Text
        strAmount = strAmount.Remove(5, 1)
        strAmount = strAmount.Remove(1, 1)
        lbl06Remove.Text = strAmount

        '07: Contains
        Const searchFor As String = "JEFFERSON STREET"
        Dim strAddress As String = txt07Contains.Text.ToUpper
        If strAddress.Contains(searchFor) Then
            lbl07Contains.Text = "Jeff St. Found"
        Else
            lbl07Contains.Text = "Jeff St. Not Found"
        End If

        '12: Length, Remove
        Dim strTaxRate As String = txt12LenRemove.Text
        strTaxRate = strTaxRate.Trim()
        Dim length As Integer = strTaxRate.Length
        If strTaxRate.Substring(length - 1) = "%" Then
            strTaxRate = strTaxRate.Remove(length - 2)
        End If
        Dim dblTaxRate As Double = 0
        Double.TryParse(strTaxRate, dblTaxRate)
        Dim dblTax As Double = 1000.0 * dblTaxRate * 0.01
        lbl12LenRemove.Text = dblTax.ToString

        '13: Like w/wildcard
        Dim strZip As String = txt13Like.Text
        If strZip Like "605##" Then
            lbl13Like.Text = "Shipping: $25"
        ElseIf strZip Like "606##" Then
            lbl13Like.Text = "Shipping: $30"
        Else
            lbl13Like.Text = "Invalid zip"
        End If
    End Sub
End Class
