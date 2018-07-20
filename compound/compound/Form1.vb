Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Ans1, Ans2 As String
        Ans1 = InputBox("What class is this?")
        Ans2 = InputBox("How many computers are in the room?")
        Ans1 = Ans1.ToLower()
        If (Ans1 = "visual basic" And Ans2 = "25") Then
            MessageBox.Show("You are correct")
        ElseIf (Ans1 = "vb" And Ans2 = "25") Then
            MessageBox.Show("You are correct")
        ElseIf Ans1 = "visual basic" Then
            MessageBox.Show("There are 25 computers in the room")
        ElseIf Ans2 = "25" Then
            MessageBox.Show("The class is visual basic")
        Else
            MessageBox.Show("You got both wrong")
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Ans1 As String
        Ans1 = InputBox("What is the product of 2 and 3?")
        Ans1 = Ans1.ToLower()
        If (Ans1 = "six" Or Ans1 = "6") Then
            MessageBox.Show("You are correct")
        Else
            MessageBox.Show("You are wrong")
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim one As String
        one = InputBox("How can you make 10 cents?")
        one = one.ToLower()
        If (one = "2 nickels" Or one = "1 dime") Then
            MessageBox.Show("You are correct")
        Else
            MessageBox.Show("There is another way")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim one, two, three As String
        one = InputBox("What is 2+2?")
        two = InputBox("What company made these computers?")
        three = InputBox("What company made visual basic?")
        two = two.ToLower()
        three = three.ToLower()
        If (one = "4" And two = "dell" And three = "microsoft") Then
            MessageBox.Show("You are smart")
        ElseIf one = "4" And two = "dell" Then
            MessageBox.Show("You got number three wrong, its Microsoft ")
        ElseIf one = "4" And three = "microsoft" Then
            MessageBox.Show("You got number two wrong, its Dell")
        ElseIf two = "dell" And three = "microsoft" Then
            MessageBox.Show("You got number one wrong, the answer is 4")
        ElseIf one = "4" Then
            MessageBox.Show("You got numbers two and three incorrect, the answers are Dell, and Microsoft")
        ElseIf two = "Dell" Then
            MessageBox.Show("You got numbers one and three incorrect, the answers are 4 and Microsoft")
        ElseIf two = "Microsoft" Then
            MessageBox.Show("You got numbers one and two incorrect, the answers are 4 and Dell")
        Else
            MessageBox.Show("You got all wrong =(")
        End If
    End Sub
End Class
