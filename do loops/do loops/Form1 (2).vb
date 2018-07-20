Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim answer As String
        Do
            answer = InputBox("Do you want to see this message again")
            answer = answer.ToLower()
        Loop While (answer = "yes")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim answer As Integer
        answer = InputBox("Input a number.")
        If answer > 100 Then
            MessageBox.Show("Your number is greater than 100, no loop")
        End If
        Do Until (answer > 100)
            answer = answer + 10
            MessageBox.Show("Your new number is " & answer)
        Loop
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim answer, question As Integer
        answer = InputBox("what is 2+2?")
        If answer = "4" Then
            MessageBox.Show("True")
        End If
        Do Until (answer = "4")
            answer = InputBox("what is 2+2?")
            question = question + 1
        Loop
        MessageBox.Show("You got it correct, your total number of tries: " & question)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim answer, count As Integer
        count = 0
        answer = InputBox("How many times would you like this to be repeated?")
        Do Until answer = count
            MessageBox.Show("Repeated " & count)
            count = count + 1
        Loop
    End Sub
End Class
