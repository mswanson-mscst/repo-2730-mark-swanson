' Name:         Multiplication Project, Barclay Price Project w/validation
' Purpose:      1) Display a multiplication table that shows
'                  the multiplicand, multiplier, and product
'               2) Add/remove items in ListBox, calculate totals
' Programmer:   Mark Swanson on 2017/11/21

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Const dblTAXRATE As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim x, product As Integer
        Dim count As Integer = 1
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("While loop:")
        Integer.TryParse(txtNumber.Text, x)
        Do While count <= 9
            product = x * count
            lstMultTable.Items.Add("    " & x.ToString() & " * " & count.ToString & " = " & product)
            count = count + 1
        Loop
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)

        ' --------------------------------------------
        'Sample code
        'count = 1
        'product = x * count
        'Dim strOutput As String = "    " & x.ToString() & " * " & count.ToString & " = " & product.ToString
        'Add strOuput to ListBox
        ' --------------------------------------------

        'For loop
        For count = 1 To 9
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMultTable.Items.Add(strOutput)
        Next
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' load ListBox with test data:
    '     repeat for each number 1 to 4
    '         Add the number to the ListBox
    '     next index

    ' calculate pretax total:
    '     declare dblPretaxTotal and initialize to 0
    '     repeat for each index 0 to lstPrices.Items.Count - 1
    '         set ListBox SelectedIndex to index
    '         set strSelectedItem and to the ListBox SelectedItem
    '         convert strSelectedItem to Double and set dblSelectedPrice
    '         add dblSelectedPrice to dblPretaxTotal
    '     next index

    '     display dblPretaxTotal
    '     calculate and display dblTax
    '     calculate and display dblTotal
    '     deselect ListBox items

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 4
            lstPrices.Items.Add(i.ToString("n2"))
        Next

        Dim dblPretaxTotal As Double = 0.0
        For i As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = i
            Dim strSelectedItem As String = Convert.ToString(lstPrices.SelectedItem)
            Dim dblSelectedPrice As Double = Convert.ToDouble(strSelectedItem)
            dblPretaxTotal += dblSelectedPrice
        Next
        lblPretaxTotal.Text = dblPretaxTotal.ToString("n2")
        Dim dblTax As Double = dblPretaxTotal * dblTAXRATE
        lblTax.Text = dblTax.ToString("n2")
        Dim total As Double = dblPretaxTotal + dblTax
        lblTotal.Text = total.ToString("n2")
        lstPrices.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Const strPROMPT As String =
            "Enter a price. " &
            ControlChars.NewLine &
            "Valid prices: 1.00 to 9.99"
        Const strTITLE As String = "Price Entry"
        Dim strPrice As String
        Dim dblPrice As Double

        ' get strPrice using InputBox
        ' convert strPrice to Double: dblPrice
        ' repeat as long as price is invalid: outside of range 1 to 9.99
        '     get strPrice using InputBox
        '     convert strPrice to Double: dblPrice
        ' end repeat
        ' add dblPrice to ListBox
        ' calculate and display totals
        strPrice = InputBox(strPROMPT, strTITLE, "0.00")
        Double.TryParse(strPrice, dblPrice)

        ' repeat as long as price is invalid
        Do While dblPrice < 1.0 OrElse dblPrice > 9.99
            ' get price again
            strPrice = InputBox(strPROMPT, "Invalid Price", strPrice)
            Double.TryParse(strPrice, dblPrice)
        Loop
        ' display the validated price in the ListBox
        lstPrices.Items.Add(dblPrice.ToString("n2"))

        ' calculate totals
        Dim dblPretaxTotal As Double = 0.0
        For i As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = i
            Dim strSelectedItem As String = Convert.ToString(lstPrices.SelectedItem)
            Dim dblSelectedPrice As Double = Convert.ToDouble(strSelectedItem)
            dblPretaxTotal += dblSelectedPrice
        Next
        lblPretaxTotal.Text = dblPretaxTotal.ToString("n2")
        Dim dblTax As Double = dblPretaxTotal * dblTAXRATE
        lblTax.Text = dblTax.ToString("n2")
        Dim total As Double = dblPretaxTotal + dblTax
        lblTotal.Text = total.ToString("n2")
        lstPrices.SelectedIndex = -1
    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        ' if an item is selected and the user pressed 'Del' or 'Back'
        '     remove the ListBox item at the selected index
        '     calculate and display totals
        ' end if
        If lstPrices.SelectedIndex >= 0 AndAlso (e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back) Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)

            ' calculate totals
            Dim dblPretaxTotal As Double = 0.0
            For i As Integer = 0 To lstPrices.Items.Count - 1
                lstPrices.SelectedIndex = i
                Dim strSelectedItem As String = Convert.ToString(lstPrices.SelectedItem)
                Dim dblSelectedPrice As Double = Convert.ToDouble(strSelectedItem)
                dblPretaxTotal += dblSelectedPrice
            Next
            lblPretaxTotal.Text = dblPretaxTotal.ToString("n2")
            Dim dblTax As Double = dblPretaxTotal * dblTAXRATE
            lblTax.Text = dblTax.ToString("n2")
            Dim total As Double = dblPretaxTotal + dblTax
            lblTotal.Text = total.ToString("n2")
            lstPrices.SelectedIndex = -1
        End If
    End Sub
End Class
