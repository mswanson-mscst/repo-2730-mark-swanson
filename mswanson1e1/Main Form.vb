' Name:         Richardson County Property Tax Project
' Purpose:      Calculates property tax
' Programmer:   Mark Swanson on 9/1/2017

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTax.Text = Format(Val(txtAssessed.Text) * 0.015, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        txtAssessed.Focus()
    End Sub
End Class