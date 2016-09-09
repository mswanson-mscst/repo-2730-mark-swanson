' Name:         Average Project
' Purpose:      Displays the average of 3 test scores
' Programmer:   Mark Swanson on 9/8/2017

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the average of 3 test scores
        lblAvg.Text = Format((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3, "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTest1.Text = "0"
        txtTest2.Text = "0"
        txtTest3.Text = "0"
        lblAvg.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
