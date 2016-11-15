Public Class Form1
    Private Sub pretestDoWhileButton_Click(sender As Object, e As EventArgs) Handles pretestDoWhileButton.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub pretestDoUntilButton_Click(sender As Object, e As EventArgs) Handles pretestDoUntilButton.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text &= i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub posttestLoopWhileButton_Click(sender As Object, e As EventArgs) Handles posttestLoopWhileButton.Click
        lblEven.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text &= i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub posttestLoopUntilButton_Click(sender As Object, e As EventArgs) Handles posttestLoopUntilButton.Click
        lblEven.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text &= i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub forLoopButton_Click(sender As Object, e As EventArgs) Handles forLoopButton.Click
        lblEven.Text = "For Loop" & ControlChars.NewLine
        Dim i As Integer = 0
        For i = 2 To 20 Step 2
            lblEven.Text &= i.ToString & ControlChars.NewLine
        Next
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a nuber. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first number
        strNum = InputBox(strPROMPT, strTITLE, "0")
        ' repeat as long as input is not empty
        Do While strNum <> String.Empty
            ' convert the input to a number
            Int32.TryParse(strNum, intNum)

            ' display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' get the next number
            strNum = InputBox(strPROMPT, strTITLE)
        Loop

        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPROMPT As String =
            "Enter a nuber. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' repeat as long as input is not empty
        Do
            ' convert the input to a number
            Int32.TryParse(strNum, intNum)

            ' display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' get next number
            strNum = InputBox(strPROMPT, strTITLE)
        Loop Until strNum = String.Empty

        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter #"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        Dim intQuant As Integer
        Dim strInputCount As String = InputBox("Enter quantity of numbers", "Quantity", "0")
        Integer.TryParse(strInputCount, intQuant)

        For intCount = 1 To intQuant
            ' get next input
            strNum = InputBox(strPROMPT & intCount.ToString, strTITLE)
            ' convert the input to a number
            Int32.TryParse(strNum, intNum)

            ' display the number in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intSum = intSum + intNum
        Next

        lblCount.Text = intQuant.ToString
        ' verify that the counter is greater than 0
        If intQuant > 0 Then
            dblAvg = intSum / intQuant
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
