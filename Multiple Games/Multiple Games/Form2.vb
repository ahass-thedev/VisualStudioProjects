Public Class Form2
    Dim r As Random
    Dim guess1 As Integer
    Dim guess2 As Integer
    Dim dice As Integer
    Dim dice2 As Integer
    Dim pp1 As Integer
    Dim pp2 As Integer
    Dim turns1 As Integer = 0
    Dim turns2 As Integer = 0
    Dim turns3 As Integer = 0
    Dim win1 As String
    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("If you roll doubles in the amount of rolls you guess, you get 3 points. If you are one off, you get 2 points. If you are 2 off, you get 1 point. Then player 2 goes. Two players take 3 turns. The player with the highest score wins.")
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        turns3 = turns3 + 1
        guess1 = InputBox("What is your guess?")
        If (turns3 > 3) And pp1 > pp2 Then
            Button1.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            PictureBox1.Hide()
            PictureBox2.Hide()
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            Label6.Hide()
            Label7.Hide()
            Label8.Hide()
            Label9.Show()
            BackColor = Color.Salmon
            Label9.Text = ("Player 1 wins")
            Label9.Font = New Font("Edwardian Script ITC", 45)
        ElseIf (turns3 > 3) And pp2 > pp1 Then
            Button1.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            PictureBox1.Hide()
            PictureBox2.Hide()
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            Label6.Hide()
            Label7.Hide()
            Label8.Hide()
            Label9.Show()
            BackColor = Color.Salmon
            Label9.Text = ("Player 2 wins")
            Label9.Font = New Font("Edwardian Script ITC", 45)
        ElseIf (turns3 > 3) And pp2 = pp1 Then
            Button1.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            PictureBox1.Hide()
            PictureBox2.Hide()
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            Label6.Hide()
            Label7.Hide()
            Label8.Hide()
            Label9.Show()
            BackColor = Color.Aquamarine
            Label9.Text = ("It's a draw!")
            Label9.Font = New Font("Edwardian Script ITC", 45)
        End If
        turns1 = 0
        turns2 = 0
    End Sub
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        r = New Random()
        PictureBox1.Image = My.Resources.download
        PictureBox2.Image = My.Resources.dice_2
        Label9.Hide()
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        dice = r.Next(1, 7)
        dice2 = r.Next(1, 7)
        If dice = 1 Then
            PictureBox1.Image = My.Resources.download
        ElseIf dice = 2 Then
            PictureBox1.Image = My.Resources.dice_2
        ElseIf dice = 3 Then
            PictureBox1.Image = My.Resources.dice_3
        ElseIf dice = 4 Then
            PictureBox1.Image = My.Resources.dice_4
        ElseIf dice = 5 Then
            PictureBox1.Image = My.Resources.dice_5
        ElseIf dice = 6 Then
            PictureBox1.Image = My.Resources.dice_6
        End If
        If dice2 = 1 Then
            PictureBox2.Image = My.Resources.download
        ElseIf dice2 = 2 Then
            PictureBox2.Image = My.Resources.dice_2
        ElseIf dice2 = 3 Then
            PictureBox2.Image = My.Resources.dice_3
        ElseIf dice2 = 4 Then
            PictureBox2.Image = My.Resources.dice_4
        ElseIf dice2 = 5 Then
            PictureBox2.Image = My.Resources.dice_5
        ElseIf dice2 = 6 Then
            PictureBox2.Image = My.Resources.dice_6
        End If
        turns1 = turns1 + 1
        turns2 = turns2 + 1

        If dice = dice2 And guess1 = turns1 Then
            pp1 = +3
            MessageBox.Show("You receive 3 points")
        ElseIf dice = dice2 And (guess1 = turns1 + 1 Or guess1 = turns1 - 1) Then
            pp1 = +2
            MessageBox.Show("You receive 2 points")
        ElseIf dice = dice2 And (guess1 = turns1 + 2 Or guess1 = turns1 - 2) Then
            pp1 = +1
            MessageBox.Show("You receive 1 points")
        ElseIf dice = dice2 And (guess1 + 3 < turns1 Or guess1 - 3 > turns1) Then
            MessageBox.Show("Doubles too late, You receive no points")
        End If
        Label3.Text = pp1
        Label4.Text = pp2
        Label7.Text = turns1
        Label8.Text = turns2
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        turns3 = turns3 + 1
        guess2 = InputBox("What is your guess?")
        turns1 = 0
        turns2 = 0
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        dice = r.Next(1, 7)
        dice2 = r.Next(1, 7)
        If dice = 1 Then
            PictureBox1.Image = My.Resources.download
        ElseIf dice = 2 Then
            PictureBox1.Image = My.Resources.dice_2
        ElseIf dice = 3 Then
            PictureBox1.Image = My.Resources.dice_3
        ElseIf dice = 4 Then
            PictureBox1.Image = My.Resources.dice_4
        ElseIf dice = 5 Then
            PictureBox1.Image = My.Resources.dice_5
        ElseIf dice = 6 Then
            PictureBox1.Image = My.Resources.dice_6
        End If
        If dice2 = 1 Then
            PictureBox2.Image = My.Resources.download
        ElseIf dice2 = 2 Then
            PictureBox2.Image = My.Resources.dice_2
        ElseIf dice2 = 3 Then
            PictureBox2.Image = My.Resources.dice_3
        ElseIf dice2 = 4 Then
            PictureBox2.Image = My.Resources.dice_4
        ElseIf dice2 = 5 Then
            PictureBox2.Image = My.Resources.dice_5
        ElseIf dice2 = 6 Then
            PictureBox2.Image = My.Resources.dice_6
        End If
        turns1 = turns1 + 1
        turns2 = turns2 + 1
        If dice = dice2 And (guess2 = turns2) Then
            pp2 = +3
            MessageBox.Show("You receive 3 points")
        ElseIf dice = dice2 And (guess2 = turns2 + 1 Or guess2 = turns2 - 1) Then
            pp2 = +2
            MessageBox.Show("You receive 2 points")
        ElseIf dice = dice2 And (guess2 = turns2 + 2 Or guess2 = turns2 - 2) Then
            pp2 = +1
            MessageBox.Show("You receive 1 points")
        ElseIf dice = dice2 And (guess2 + 3 < turns2 Or guess2 - 3 > turns2) Then
            MessageBox.Show("Doubles too late, You receive no points")
        End If
        Label3.Text = pp1
        Label4.Text = pp2
        Label7.Text = turns1
        Label8.Text = turns2
    End Sub
End Class