Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x, y, sum As Integer
        x = InputBox("Input one integer")
        y = InputBox("Input another integer")
        sum = x + y
        MessageBox.Show("The sum of " & x & " and " & y & " is " & sum)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim x, y, Total As Integer
        x = InputBox("Input first integer")
        y = InputBox("Input second integer")
        Total = x * y
        MessageBox.Show("The total of " & x & " and " & y & " is " & Total)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x, y, Total As Integer
        x = InputBox("Input first integer")
        y = InputBox("Input second integer")
        Total = x / y
        MessageBox.Show("The total of " & x & " and " & y & " is " & Total)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x, y, Difference As Integer
        x = InputBox("Input first integer")
        y = InputBox("Input second integer")
        Difference = x - y
        MessageBox.Show("The difference of " & x & " and " & y & " is " & Difference)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim x, y, z, Total As Integer
        x = InputBox("Input first integer")
        y = InputBox("Input second integer")
        z = InputBox("Input third integer")
        Total = (x + y) * z
        Label1.Text = Total
        MessageBox.Show("The total of " & x & " and " & y & " multiplied by " & z & " is " & Total)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
