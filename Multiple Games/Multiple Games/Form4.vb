Public Class Form4
    Dim r As Random
    Dim computerchoice As Integer
    Dim tie As Integer
    Dim win As Integer
    Dim loss As Integer
    Dim r2 As Random
    Dim color As Integer
    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.rock_vb
        PictureBox2.Image = My.Resources.paper_vb
        PictureBox3.Image = My.Resources.scissors_vb
        r = New Random()
        Me.BackColor = Drawing.Color.LightPink
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        color = r.Next(1, 6)
        Label15.Text = tie
        Label11.Text = win
        Label13.Text = loss
        If RadioButton1.Checked Then
            PictureBox5.Image = My.Resources.rock_vb
        ElseIf RadioButton2.Checked Then
            PictureBox5.Image = My.Resources.paper_vb
        ElseIf RadioButton3.Checked Then
            PictureBox5.Image = My.Resources.scissors_vb
        End If
        computerchoice = r.Next(1, 4)
        If computerchoice = 1 Then
            PictureBox4.Image = My.Resources.rock_vb
        ElseIf computerchoice = 2 Then
            PictureBox4.Image = My.Resources.paper_vb
        ElseIf computerchoice = 3 Then
            PictureBox4.Image = My.Resources.scissors_vb
        End If
        If computerchoice = 1 And RadioButton1.Checked Then
            tie = tie + 1
        ElseIf computerchoice = 2 And RadioButton2.Checked Then
            tie = tie + 1
        ElseIf computerchoice = 3 And RadioButton3.Checked Then
            tie = tie + 1
        End If
        If RadioButton2.Checked And computerchoice = 1 Then
            win = win + 1
        ElseIf RadioButton1.Checked And computerchoice = 3 Then
            win = win + 1
        ElseIf RadioButton3.Checked And computerchoice = 2 Then
            win = win + 1
        End If
        If RadioButton1.Checked And computerchoice = 2 Then
            loss = loss + 1
        ElseIf RadioButton3.Checked And computerchoice = 1 Then
            loss = loss + 1
        ElseIf RadioButton2.Checked And computerchoice = 3 Then
            loss = loss + 1
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label15.Text = tie
        Label11.Text = win
        Label13.Text = loss
        tie = tie - tie
        loss = loss - loss
        win = win - win
    End Sub
End Class