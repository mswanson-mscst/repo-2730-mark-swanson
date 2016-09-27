' Name:         Cranston Berries Project
' Purpose:      Calculates projected sales
' Programmer:   Mark Swanson on 9/27/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate projected sales for three types of berries
        'lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        'lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        'lblProjRas.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRas.Text), "currency")
        Dim decProjIncrease As Decimal = 0D
        Dim decCurStraw As Decimal = 0D
        Dim decCurRasp As Decimal = 0D
        Dim decCurBlue As Decimal = 0D

        Decimal.TryParse(txtProjIncrease.Text, decProjIncrease)
        Decimal.TryParse(txtStraw.Text, decCurStraw)
        Decimal.TryParse(txtRas.Text, decCurRasp)
        Decimal.TryParse(txtBlue.Text, decCurBlue)

        Dim decProjStraw As Decimal = (1 + decProjIncrease) * decCurStraw
        Dim decProjRasp As Decimal = (1 + decProjIncrease) * decCurRasp
        Dim decProjBlue As Decimal = (1 + decProjIncrease) * decCurBlue

        lblProjStraw.Text = decProjStraw.ToString("c2")
        lblProjRas.Text = decProjRasp.ToString("c2")
        lblProjBlue.Text = decProjBlue.ToString("c2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the form's user entries
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRas.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRas.Text = String.Empty
        txtProjIncrease.Text = "0.05"

        'place the focus to the projected increase text box
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRetirementForm_Click(sender As Object, e As EventArgs) Handles btnRetirementForm.Click
        frmRetirement.Show()
    End Sub
End Class
