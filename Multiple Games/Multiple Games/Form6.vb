Public Class Form6
    Public Property answerx1 As Integer
    Dim answery1 As Integer
    Dim x As Integer
    Dim y As Integer
    Dim p2 As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim choicex4, x4, choicey4 As Integer
        choicex4 = InputBox("Choose the y coordinate that you would like to move the ship to (max. 400) ")
        x4 = PictureBox11.Location.Y = choicex4
        PictureBox11.Location = New Point(295, choicex4)
        Button1.Hide()
        Select Case choicex4
            Case Is > 401
                MessageBox.Show("The number you input is too big (for x)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
        Select Case choicey4
            Case Is > 401
                MessageBox.Show("The number you input is too big (for y)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x6, choicex6, choicey6 As Integer
        choicex6 = InputBox("Choose the y coordinate that you would like to move the ship to (max. 400) ")
        x6 = PictureBox33.Location.Y = choicex6
        PictureBox33.Location = New Point(820, choicex6)
        Button3.Hide()
        Select Case choicex6
            Case Is > 401
                MessageBox.Show("The number you input is too big (for x)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
        Select Case choicey6
            Case Is > 401
                MessageBox.Show("The number you input is too big (for y)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x5, choicex5, choicey5 As Integer
        choicex5 = InputBox("Choose the x coordinate that you would like to move the ship to (max. 400) ")
        x5 = PictureBox22.Location.X = choicex5
        PictureBox22.Location = New Point(choicey5, choicex5)
        Button2.Hide()
        Select Case choicex5
            Case Is > 401
                MessageBox.Show("The number you input is too big (for x)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
        Select Case choicey5
            Case Is > 401
                MessageBox.Show("The number you input is too big (for y)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
    End Sub
    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label5.Text = p2
        p2 = p2 + 3
        Do Until p2 = 3
            p2 = p2 + 3
        Loop

        Button9.Hide()
        PictureBox11.Image = My.Resources.ship3
        PictureBox22.Image = My.Resources.ship3
        PictureBox33.Image = My.Resources.ship3

        Me.BackColor = Color.BurlyWood
        Label9.Text = answerx1
        GroupBox3.Hide()
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Label5.Text = p2
        p2 = p2 + 0
        Label6.Text = (PictureBox11.Location.Y)
        Label7.Text = (PictureBox22.Location.Y)
        Label8.Text = (PictureBox33.Location.Y)
        x = Button5.Location.X + 1
        y = Button5.Location.Y - 30
        Button5.Location = New Point(x, y)
        Button5.Show()
        Form5.Show()
        Me.Hide()
        Button4.Hide()
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim p1 As New Form5
        p1.answerx = TextBox1.Text
        Me.Hide()
        p1.Show()
    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        PictureBox11.Hide()
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        PictureBox22.Hide()
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        PictureBox33.Hide()
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click

    End Sub
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class