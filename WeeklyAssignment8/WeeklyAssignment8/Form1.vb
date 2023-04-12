Public Class Form1

    Private sizeOfArray As Integer = 11
    Private strSavings(sizeOfArray) As String
    Private bill(sizeOfArray) As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim savings As String
        Dim count As Integer = 0
        Dim fill As Integer

        clear()
        Dim strPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        If IO.File.Exists("..\..\static\savings.txt") Then
            objReader = IO.File.OpenText("..\..\static\savings.txt")
            Do While objReader.Peek <> -1
                strSavings(count) = objReader.ReadLine()
                savings = objReader.ReadLine()
                bill(count) = Convert.ToDecimal(savings)
                count += 1
            Loop
            objReader.Close()

            For fill = 0 To (strSavings.Length - 1)
                cbMonth.Items.Add(strSavings(fill))
            Next
        Else
            MsgBox("The file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub
    Private Sub clear()
        lbMonth.Text = ""
        lbAverage.Text = ""
        lbGreat.Text = ""
        btnCalc.Visible = False
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        Dim city As Integer

        city = cbMonth.SelectedIndex
        lbMonth.Text = "The electric savings for " & strSavings(city) & " is $" & bill(city).ToString()
        btnCalc.Visible = True
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Average()
        MaxSavings()
    End Sub

    Private Sub MaxSavings()
        Dim months As Integer
        Dim lgSaving As Integer = 0
        Dim indexValue As Integer = 0
        Dim year As String = ""

        For Each months In bill
            lgSaving = Math.Max(lgSaving, months)
            If (months >= lgSaving) Then
                year = strSavings(indexValue)
            End If
            indexValue += 1
        Next
        lbGreat.Text = year & " had the most significant monthly savings"
    End Sub

    Private Sub Average()
        Dim yearCount As Integer
        Dim years As Integer = 0
        Dim billTotal As Decimal = 0
        Dim billAverage As Decimal = 0D

        For Each yearsCount In bill
            billTotal += bill(years)
            years += 1
        Next
        billAverage = billTotal / Convert.ToDecimal(bill.Length())
        lbAverage.Text = "The average monthly savings: " & billAverage.ToString("C2")
    End Sub
End Class
