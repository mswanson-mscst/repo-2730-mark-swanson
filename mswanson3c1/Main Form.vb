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

    '------------------------------------------------------------------------
    'Add planets to cboPlanets
    'Set selected item to Earth
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    'Allow only numbers and the Backspace
    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        ' allows only numbers and the Backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    'Select all text in txtEarthWeight
    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub

    'Set dblGravity according to selected text in cboPlanets
    'Calculate and return weight
    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double
        Dim dblGravity As Double = 0.0

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        Return intWeight * dblGravity
    End Function

    'Set dblGravity according to selected text in cboPlanets
    'Calculate weight
    Private Sub CalcWeightSub(ByVal intWeight As Integer, ByRef dblWeightOnPlanet As Double)
        Dim dblGravity As Double = 0.0

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        dblWeightOnPlanet = intWeight * dblGravity
    End Sub

    'Parse value in txtEarthWeight
    'If user selected "sub" radio button
    '    Use Sub to calculate weight
    'ElseIf user selected "func" radio button
    '    Use Function to calculate weight
    'End If
    'Display weight
    Private Sub WeightInputChanged(sender As Object, e As EventArgs) _
            Handles txtEarthWeight.TextChanged, cboPlanets.TextChanged,
            rdoPlanetFunc.CheckedChanged, rdoPlanetSub.CheckedChanged

        ' converts earth weight to the weight on another planet
        Dim intEarthWeight As Integer
        Dim dblPlanetWeight As Double

        Integer.TryParse(txtEarthWeight.Text, intEarthWeight)
        If rdoPlanetSub.Checked Then
            CalcWeightSub(intEarthWeight, dblPlanetWeight)
        ElseIf rdoPlanetFunc.Checked Then
            dblPlanetWeight = CalcWeightFunc(intEarthWeight)
        End If
        lblWeight.Text = dblPlanetWeight.ToString("N2")
    End Sub
End Class
