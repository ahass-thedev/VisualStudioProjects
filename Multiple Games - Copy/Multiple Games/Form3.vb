Public Class Form3
    Dim r As Random
    Dim wager1 As Integer
    Dim wager2 As Integer
    Dim pp1 As Integer = 10
    Dim pp2 As Integer = 10
    Dim coin As Integer
    Dim r2 As Random
    Dim color As Integer
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.head_coin_vb
        PictureBox1.Image = My.Resources.tail_coin_vb
        r = New Random()
        Me.BackColor = Drawing.Color.OrangeRed
        Label3.Text = 10
        Label4.Text = 10
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
End Class