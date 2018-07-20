Public Class Form1
    Dim r As Random
    Dim wager1 As Integer
    Dim wager2 As Integer
    Dim pp1 As Integer = 10
    Dim pp2 As Integer = 10
    Dim coin As Integer
    Dim r2 As Random
    Dim r3 As Random
    Dim guess1 As Integer
    Dim guess2 As Integer
    Dim dice As Integer
    Dim dice2 As Integer
    Dim pp3 As Integer
    Dim pp4 As Integer
    Dim turns1 As Integer = 0
    Dim turns2 As Integer = 0
    Dim turns3 As Integer = 0
    Dim win1 As String
    Dim r7 As Random
    Dim computerchoice As Integer
    Dim tie As Integer
    Dim winr As Integer
    Dim loss As Integer
    Dim r8 As Random
    Dim colors As Integer
    Dim color As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox6.Hide()
        PictureBox1.Image = My.Resources.head_coin_vb
        PictureBox1.Image = My.Resources.tail_coin_vb
        r = New Random()
        Me.BackColor = DefaultBackColor
        Label3.Text = 10
        Label4.Text = 10
        r3 = New Random()
        PictureBox2.Image = My.Resources.download
        PictureBox3.Image = My.Resources.dice_2
        r7 = New Random()
        PictureBox4.Image = My.Resources.rock_vb
        PictureBox5.Image = My.Resources.paper_vb
        PictureBox6.Image = My.Resources.scissors_vb
        Me.BackColor = DefaultBackColor
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        wager1 = InputBox("What is your wager?")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        wager2 = InputBox("What is your wager?")

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        coin = r.Next(1, 3)
        color = r.Next(1, 6)
        If coin = 1 Then
            PictureBox1.Image = My.Resources.head_coin_vb
        ElseIf coin = 2 Then
            PictureBox1.Image = My.Resources.tail_coin_vb
        End If
        If RadioButton1.Checked And coin = 1 Then
            pp1 = pp1 + wager1
        ElseIf RadioButton1.Checked And coin = 2 Then
            pp1 = pp1 - wager1
        End If
        If RadioButton2.Checked And coin = 2 Then
            pp1 = pp1 + wager1
        ElseIf RadioButton2.Checked And coin = 1 Then
            pp1 = pp1 - wager1
        End If

        If pp1 <= 0 Then
            MessageBox.Show("Player 1 loses")
        End If
        If pp1 >= 100 Then
            MessageBox.Show("Player 1 wins")
        End If
        If RadioButton3.Checked And coin = 1 Then
            pp2 = pp2 + wager2
        ElseIf RadioButton3.Checked And coin = 2 Then
            pp2 = pp2 - wager2
        End If
        If RadioButton4.Checked And coin = 2 Then
            pp2 = pp2 + wager2
        ElseIf RadioButton4.Checked And coin = 1 Then
            pp2 = pp2 - wager2
        End If
        If pp2 <= 0 Then
            MessageBox.Show("Player 2 loses")
        End If
        If pp2 >= 100 Then
            MessageBox.Show("Player 2 wins")
        End If
        If pp1 <= 0 Or pp1 >= 100 Then
            pp1 = 10
            pp2 = 10
            MessageBox.Show("New Game")
        End If
        If pp2 <= 0 Or pp1 >= 100 Then
            pp2 = 10
            pp1 = 10
            MessageBox.Show("New Game")
        End If
        If color = 1 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 2 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 3 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 4 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 5 Then
            Me.BackColor = DefaultBackColor
        End If


        Label3.Text = pp1
        Label4.Text = pp2

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        MessageBox.Show(". If you roll doubles in the amount of rolls you guess, you get 3 points. If you are one off, you get 2 points. If you are 2 off, you get 1 point. Then player 2 goes. Two players take 3 turns. The player with the highest score wins.")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        turns3 = turns3 + 1
        guess1 = InputBox("What is your guess?")
        If (turns3 > 3) And pp3 > pp4 Then
            Button1.Hide()
            Button2.Hide()
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
            BackColor = DefaultBackColor
            Label9.Text = ("Player 1 wins")
            Label9.Font = New Font("Edwardian Script ITC", 45)
        ElseIf (turns3 > 3) And pp4 > pp3 Then
            Button1.Hide()
            Button2.Hide()
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
            BackColor = DefaultBackColor
            Label9.Text = ("Player 2 wins")
            Label9.Font = New Font("Edwardian Script ITC", 45)
        ElseIf (turns3 > 3) And pp4 = pp3 Then
            Button1.Hide()
            Button2.Hide()
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
            BackColor = DefaultBackColor
            Label9.Text = ("It's a draw!")
            Label9.Font = New Font("Edwardian Script ITC", 45)
        End If
        turns1 = 0
        turns2 = 0
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        dice = r3.Next(1, 7)
        dice2 = r3.Next(1, 7)
        If dice = 1 Then
            PictureBox2.Image = My.Resources.download
        ElseIf dice = 2 Then
            PictureBox2.Image = My.Resources.dice_2
        ElseIf dice = 3 Then
            PictureBox2.Image = My.Resources.dice_3
        ElseIf dice = 4 Then
            PictureBox2.Image = My.Resources.dice_4
        ElseIf dice = 5 Then
            PictureBox2.Image = My.Resources.dice_5
        ElseIf dice = 6 Then
            PictureBox2.Image = My.Resources.dice_6
        End If

        If dice2 = 1 Then
            PictureBox3.Image = My.Resources.download
        ElseIf dice2 = 2 Then
            PictureBox3.Image = My.Resources.dice_2
        ElseIf dice2 = 3 Then
            PictureBox3.Image = My.Resources.dice_3
        ElseIf dice2 = 4 Then
            PictureBox3.Image = My.Resources.dice_4
        ElseIf dice2 = 5 Then
            PictureBox3.Image = My.Resources.dice_5
        ElseIf dice2 = 6 Then
            PictureBox3.Image = My.Resources.dice_6
        End If

        turns1 = turns1 + 1
        turns2 = turns2 + 1

        If dice = dice2 And guess1 = turns1 Then
            pp3 = +3
            MessageBox.Show("You receive 3 points")
        ElseIf dice = dice2 And (guess1 = turns1 + 1 Or guess1 = turns1 - 1) Then
            pp3 = +2
            MessageBox.Show("You receive 2 points")
        ElseIf dice = dice2 And (guess1 = turns1 + 2 Or guess1 = turns1 - 2) Then
            pp3 = +1
            MessageBox.Show("You receive 1 points")
        ElseIf dice = dice2 And (guess1 + 3 < turns1 Or guess1 - 3 > turns1) Then
            MessageBox.Show("You receive no points")
        End If

        Label7.Text = pp3
        Label9.Text = pp4

        Label11.Text = turns1
        Label13.Text = turns2
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        turns3 = turns3 + 1
        guess2 = InputBox("What is your guess?")
        turns1 = 0
        turns2 = 0
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        dice = r3.Next(1, 7)
        dice2 = r3.Next(1, 7)


        If dice = 1 Then
            PictureBox2.Image = My.Resources.download
        ElseIf dice = 2 Then
            PictureBox2.Image = My.Resources.dice_2
        ElseIf dice = 3 Then
            PictureBox2.Image = My.Resources.dice_3
        ElseIf dice = 4 Then
            PictureBox2.Image = My.Resources.dice_4
        ElseIf dice = 5 Then
            PictureBox2.Image = My.Resources.dice_5
        ElseIf dice = 6 Then
            PictureBox2.Image = My.Resources.dice_6
        End If

        If dice2 = 1 Then
            PictureBox3.Image = My.Resources.download
        ElseIf dice2 = 2 Then
            PictureBox3.Image = My.Resources.dice_2
        ElseIf dice2 = 3 Then
            PictureBox3.Image = My.Resources.dice_3
        ElseIf dice2 = 4 Then
            PictureBox3.Image = My.Resources.dice_4
        ElseIf dice2 = 5 Then
            PictureBox3.Image = My.Resources.dice_5
        ElseIf dice2 = 6 Then
            PictureBox3.Image = My.Resources.dice_6
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
            MessageBox.Show("You receive no points")
        End If
        Label7.Text = pp1
        Label9.Text = pp2

        Label11.Text = turns1
        Label13.Text = turns2
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox3.Show()
        Else
            GroupBox3.Hide()
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            GroupBox4.Show()
        Else
            GroupBox4.Hide()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            GroupBox6.Show()
        Else
            GroupBox6.Hide()
        End If
    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        colors = r7.Next(1, 6)
        Label20.Text = tie
        Label18.Text = winr
        Label22.Text = loss
        If RadioButton5.Checked Then
            PictureBox7.Image = My.Resources.rock_vb
        ElseIf RadioButton6.Checked Then
            PictureBox7.Image = My.Resources.paper_vb
        ElseIf RadioButton7.Checked Then
            PictureBox7.Image = My.Resources.scissors_vb
        End If

        computerchoice = r7.Next(1, 4)
        If computerchoice = 1 Then
            PictureBox8.Image = My.Resources.rock_vb
        ElseIf computerchoice = 2 Then
            PictureBox8.Image = My.Resources.paper_vb
        ElseIf computerchoice = 3 Then
            PictureBox8.Image = My.Resources.scissors_vb
        End If

        If computerchoice = 1 And RadioButton5.Checked Then
            tie = tie + 1
        ElseIf computerchoice = 2 And RadioButton6.Checked Then
            tie = tie + 1
        ElseIf computerchoice = 3 And RadioButton7.Checked Then
            tie = tie + 1
        End If
        If RadioButton5.Checked And computerchoice = 3 Then
            winr = winr + 1
        ElseIf RadioButton6.Checked And computerchoice = 1 Then
            winr = winr + 1
        ElseIf RadioButton7.Checked And computerchoice = 2 Then
            winr = winr + 1
        End If
        If RadioButton5.Checked And computerchoice = 2 Then
            loss = loss + 1
        ElseIf RadioButton6.Checked And computerchoice = 3 Then
            loss = loss + 1
        ElseIf RadioButton7.Checked And computerchoice = 1 Then
            loss = loss + 1
        End If
        If color = 1 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 2 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 3 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 4 Then
            Me.BackColor = DefaultBackColor
        ElseIf color = 5 Then
            Me.BackColor = DefaultBackColor
        End If
    End Sub
End Class


