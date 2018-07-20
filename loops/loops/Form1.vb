Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        For x = 6 To 0 Step -1
            MessageBox.Show("This is message " & x)
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim question, score As Integer
        Dim answer As String
        For question = 1 To 3 Step 1
            If question = 1 Then
                answer = InputBox("What is 2+3?")
                If answer = "5" Then
                    MessageBox.Show("Nicely Done!")
                    score = score + 1
                Else
                    MessageBox.Show("Wrong")
                End If
            End If
            If question = 2 Then
                answer = InputBox("Solve 2x-18=16")
                If answer = "17" Then
                    MessageBox.Show("Good Job!")
                    score = score + 1
                Else
                    MessageBox.Show("Incorrect")
                End If
            End If
            If question = 3 Then
                answer = InputBox("How many students are in this class?")
                If answer = "23" Then
                    MessageBox.Show("Excellent")
                    score = score + 1
                Else
                    MessageBox.Show("No, there are 23")
                End If
            End If
        Next
        MessageBox.Show("Your score is " & score)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x, y As Integer
        y = InputBox("What number do you want to count to? (Must be positive)")
        MessageBox.Show("Counting by 2's")
        For x = 0 To y Step 2
            MessageBox.Show(x)
        Next

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim x, y As Integer
        y = InputBox("What number do you want to count down from?")
        MessageBox.Show("Counting down by 3")
        For x = y To 0 Step -3
            MessageBox.Show(x)
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim x, y, z As Integer
        y = InputBox("Please input a number to count to")
        For z = 1 To y Step +1
            x += z
        Next
        MessageBox.Show(x)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim y, x As Integer
        For y = 3 To 1 Step -1
            x = InputBox("What is 2+2")
            If x = 4 Then
                MessageBox.Show("Correct")
            Else
                MessageBox.Show("That is wrong")
            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
