' Name:         Photo Project
' Purpose:      Displays the gross pay, FWT, FICA, state income tax, and net pay
' Programmer:   Mark Swanson on 9/8/2017

Option Strict On

Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate gross, withholdings, and net pay
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFwt.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFica.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFwt.Text) - Val(lblFica.Text) - Val(lblState.Text), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear screen
        txtName.Text = String.Empty
        txtHours.Text = "0.00"
        txtPayRate.Text = "0.00"
        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFica.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
