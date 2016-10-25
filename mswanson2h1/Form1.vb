Public Class Form1
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalc_IfThen_Click(sender As Object, e As EventArgs) Handles btnCalc_IfThen.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommisssion.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommisssion.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalc_NestedIf_Click(sender As Object, e As EventArgs) Handles btnCalc_NestedIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommisssion.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If dblSales < 1.0 Then
                dblCommissionOnly = 0.0
            Else
                If dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
                    dblCommissionOnly = dblSales * 0.1
                Else
                    If dblSales < 30000.0 Then
                        dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                    Else
                        dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
                    End If
                End If
            End If

            If chkMoreThan10.Checked Then
                dblAdditional = dblAdditional + 500.0
            End If

            If chkTravel.Checked Then
                dblAdditional = dblAdditional + 700.0
            End If

            dblTotalCommission = dblCommissionOnly + dblAdditional

            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommisssion.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalc_IfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalc_IfElseIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommisssion.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If dblSales < 1.0 Then
                dblCommissionOnly = 0.0
            ElseIf dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
                dblCommissionOnly = dblSales * 0.1
            ElseIf dblSales < 30000.0 Then
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
            Else
                dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
            End If

            If chkMoreThan10.Checked Then
                dblAdditional = dblAdditional + 500.0
            End If

            If chkTravel.Checked Then
                dblAdditional = dblAdditional + 700.0
            End If

            dblTotalCommission = dblCommissionOnly + dblAdditional

            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommisssion.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalcSelectCase_Click(sender As Object, e As EventArgs) Handles btnCalcSelectCase.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommisssion.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case dblSales
                Case Is < 1.0
                    dblCommissionOnly = 0.0
                Case Is < 6000.0
                    dblCommissionOnly = dblSales * 0.1
                Case Is < 30000.0
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Case Else
                    dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
            End Select

            If chkMoreThan10.Checked Then
                dblAdditional = dblAdditional + 500.0
            End If

            If chkTravel.Checked Then
                dblAdditional = dblAdditional + 700.0
            End If

            dblTotalCommission = dblCommissionOnly + dblAdditional

            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommisssion.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkMoreThan10.CheckedChanged, chkTravel.CheckedChanged
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommisssion.Text = String.Empty
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub
End Class
