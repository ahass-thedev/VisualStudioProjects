Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim choice As String
        choice = InputBox("What color do you want the label to be? Green, blue or red")
        choice = choice.ToLower()
        If choice = "blue" Then
            Label1.Show()
            MessageBox.Show("Ok, changing the color to blue")
            Label1.ForeColor = Color.Blue
        ElseIf choice = "green" Then
            Label1.Show()
            MessageBox.Show("Ok, changing the color to green")
            Label1.ForeColor = Color.Green
        ElseIf choice = "red" Then
            Label1.Show()
            MessageBox.Show("Ok, changing the color to red")
            Label1.ForeColor = Color.Red
        Else
            MessageBox.Show("This is not a valid color")
            Label1.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        a = InputBox("Please enter a value of a number")
        Select Case a
            Case Is < 0
                MessageBox.Show("Your number is negative")
            Case 0
                MessageBox.Show("Your number is zero")
            Case 1 To 99
                MessageBox.Show("Your number is a smaller positive number")
            Case Is > 100
                MessageBox.Show("Your number is a bigger positive number")
        End Select
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim answer As String
        answer = InputBox("Do you want to take the challenge?")
        answer = answer.ToLower()
        If answer = "yes" Then
            Me.BackColor = DefaultBackColor
            MessageBox.Show("Ok, lets begin.")
            answer = InputBox("What is 2+3?")
            If answer = "5" Then
                MessageBox.Show("You are correct!")
                answer = InputBox("Solve the equation: 2x+8=32")
                If answer = "12" Then
                    MessageBox.Show("You are correct, you win the challenge")
                    Me.BackColor = Color.White
                    Label1.Text = "Congratulations"
                    Label1.Font = New Font("Microsoft Sans Serif", 40)
                Else
                    MessageBox.Show("You are wrong, the answer is 12. You lose.")
                    Me.BackColor = Color.Black
                End If
            Else
                MessageBox.Show("You are wrong, the answer was 5. You lose")
                Me.BackColor = Color.Black
            End If
        Else
            MessageBox.Show("Ok, dont be scared")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim answer As String
        answer = InputBox("Which one do you want to change backcolor, fontsize, or forecolor?")
        answer = answer.ToLower()
        If answer = "backcolor" Then
            Label1.Show()
            MessageBox.Show("Okay, changing the backcolor")
            Label1.BackColor = Color.GreenYellow
        ElseIf answer = "forecolor" Then
            Label1.Show()
            MessageBox.Show("Okay, changing the forecolor")
            Label1.ForeColor = Color.Aquamarine
        ElseIf answer = "fontsize" Then
            Label1.Show()
            MessageBox.Show("Okay changing fontsize")
            Label1.Font = New Font("Microsoft Sans Serif", 20)
        Else
            MessageBox.Show("That is okay")
            Label1.Text = "Label1"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim grade As Integer
        grade = InputBox("Input your score")
        Select Case grade
            Case Is < 59
                MessageBox.Show("Your grade is: F")
            Case Is > 90
                MessageBox.Show("Your grade is: A")
            Case 80 To 89
                MessageBox.Show("Your grade is: B")
            Case 70 To 79
                MessageBox.Show("Your grade is: C")
            Case 60 To 69
                MessageBox.Show("Your grade is: D")
        End Select
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim answer As String
        answer = InputBox("Do you want to change the color to Red or Blue?")
        answer = answer.ToLower()
        If answer = "red" Then
            MessageBox.Show("Okay, changing to red")
            Button6.BackColor = Color.Red
        ElseIf answer = "blue" Then
            MessageBox.Show("Okay, changing to blue")
            Button6.ForeColor = Color.Blue
        Else
            MessageBox.Show("That is okay")
            Label1.Text = "Label1"
        End If
    End Sub
End Class
