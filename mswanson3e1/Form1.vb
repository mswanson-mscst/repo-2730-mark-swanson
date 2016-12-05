' Name:         mswanson3e1
' Purpose:      Display counts of salespeople commissions
' Programmer:   Mark Swanson on 12/6/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750, 900,
            150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
        cboSearchValues.SelectedIndex = 0
        cboSearchRanges.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommissions()
        For Each intComm As Integer In intCommission
            lblCommissions.Text &= intComm.ToString() & ", "
        Next
        If lblCommissions.Text.EndsWith(", ") Then
            lblCommissions.Text = lblCommissions.Text.Substring(0, lblCommissions.Text.Length - 2)
        End If
    End Sub

    ' Convert input to intSearchValue
    ' If intSearchValue is valid
    '     Call CountValue, display result in lblValueCount
    ' Otherwise
    '     Display message box
    ' End If
    Private Sub cboSearchValues_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValues.TextChanged
        Dim intSearchValue As Integer = 0
        Int32.TryParse(cboSearchValues.Text, intSearchValue)
        If intSearchValue >= 0 AndAlso intSearchValue <= 1000 Then
            lblValueCount.Text = CountValue(intSearchValue).ToString
        Else
            MessageBox.Show("Input Error", "Value must be in range 0 - 1000")
        End If
    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer
        Dim intCount As Integer = 0
        For Each intComm As Integer In intCommission
            If intComm = intSearchValue Then
                intCount += 1
            End If
        Next
        Return intCount
    End Function

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intCount As Integer = 0
        For Each intComm As Integer In intCommission
            If intComm >= intSearchMin AndAlso intComm <= intSearchMax Then
                intCount += 1
            End If
        Next
        Return intCount
    End Function

    Private Sub cboSearchRanges_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If
    End Sub
End Class
