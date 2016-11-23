' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Mark Swanson on 11/23/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
           Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged,
           radSubInches.CheckedChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged
        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            'dblResult = 1.11
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            'dblResult = 2.22
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            'dblResult = 3.33
            dblResult = CalcCentimetersFunc(dblMeasurement)
        ElseIf radFuncInches.Checked Then
            'dblResult = 4.44
            dblResult = CalcInchesFunc(dblMeasurement)
        End If

        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        Return dblMeas * 2.54
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double
        Return dblMeas / 2.54
    End Function
End Class
