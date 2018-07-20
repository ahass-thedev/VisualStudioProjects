Public Class o
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Form2.Show()
            MessageBox.Show("Let the user guess how many turns it will take to roll doubles. If they roll doubles in the amount of rolls they guess, they get 3 points. If they are one off, they get 2 points. If they are 3 off, they get 1 point. Then player 2 goes. The two players take 3 turns. The player with the highest score wins.")
        Else
            Form2.Hide()
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Form3.Show()
            MessageBox.Show("Both players will start with 10 points.You will enter wagers, after these are entered, the coin is flipped. If the player is right, the wager amount of points is awarded.")
        Else
            Form3.Hide()
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Form4.Show()
            MessageBox.Show("Classic game of rock, paper or scissors against the computer")
        Else
            Form4.Hide()
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Form5.Show()
            MessageBox.Show("Battleship – Two game boards and each player place will move a number of war ships to spots they choose. Each player can’t see the other person’s board. They then take turns firing at one another by guessing one of the board squares. If the square they guess contains part of a ship, it is a hit. Otherwise it is a miss. They sink a ship when all squares containing that particular ship have been uncovered. The player wins when all their opponents’ ships have been sunk.")
        Else
            Form5.Hide()
            Form6.Hide()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Form7.Show()
            MessageBox.Show("Player 1 is x and Player 2 is O. Try to get 3 in a row while keeping the opponent from doing the same(Winner gets the first turn in the new game)")
        Else
            Form7.Hide()
        End If
    End Sub
End Class
