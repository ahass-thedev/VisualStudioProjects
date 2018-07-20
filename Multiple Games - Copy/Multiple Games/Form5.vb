Public Class Form5
    Dim p1 As Integer
    Dim x As Integer
    Dim y As Integer
    Public Property answerx As Integer
    Dim answery As Integer
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label5.Text = p1
        p1 = p1 + 3
        Do Until p1 = 3
            p1 = p1 + 3
        Loop

        PictureBox1.Image = My.Resources.ship1
        PictureBox2.Image = My.Resources.ship1
        PictureBox3.Image = My.Resources.ship1

        Me.BackColor = Color.BlanchedAlmond
        Label10.Hide()
        Button5.Hide()
        Label9.Text = answerx
        Button9.Hide()
        Label11.Hide()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x1, choicex1, choicey1 As Integer
        choicex1 = InputBox("Choose the y coordinate that you would like to move the ship to (max. 400) ")
        x1 = PictureBox1.Location.Y = choicex1
        PictureBox1.Location = New Point(295, choicex1)
        Button1.Hide()
        Select Case choicex1
            Case Is > 401
                MessageBox.Show("The number you input is too big (for x)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
        Select Case choicey1
            Case Is > 401
                MessageBox.Show("The number you input is too big (for y)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x2, choicex2, choicey2 As Integer
        choicex2 = InputBox("Choose the y coordinate that you would like to move the ship to (max. 400) ")
        x2 = PictureBox2.Location.Y = choicex2
        PictureBox2.Location = New Point(choicey2, choicex2)
        Button2.Hide()
        Select Case choicex2
            Case Is > 401
                MessageBox.Show("The number you input is too big (for x)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
        Select Case choicey2
            Case Is > 401
                MessageBox.Show("The number you input is too big (for y)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x3, choicex3, choicey3 As Integer
        choicex3 = InputBox("Choose the y coordinate that you would like to move the ship to (max. 400) ")
        x3 = PictureBox3.Location.Y = choicex3
        PictureBox3.Location = New Point(820, choicex3)
        Button3.Hide()
        Select Case choicex3
            Case Is > 401
                MessageBox.Show("The number you input is too big (for x)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
        Select Case choicey3
            Case Is > 401
                MessageBox.Show("The number you input is too big (for y)")
                MessageBox.Show("Try again or I will pick a random point for you")
        End Select
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Label5.Text = p1
        p1 = p1 + 0
        Label6.Text = (PictureBox1.Location.Y)
        Label7.Text = (PictureBox2.Location.Y)
        Label8.Text = (PictureBox3.Location.Y)
        x = Button5.Location.X + 1
        y = Button5.Location.Y - 30
        Button5.Location = New Point(x, y)
        Button5.Show()
        Form6.Show()
        Me.Hide()
        Button4.Hide()
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Label5.Text = 1 Then
            Label10.Show()
            GroupBox1.Hide()
            Me.BackColor = Color.Lime
        End If
        Dim p2 As New Form6
        p2.answerx1 = TextBox1.Text
        Me.Hide()
        p2.Show()
    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Label5.Text = p1
        p1 = p1 - 1
        PictureBox1.Hide()
        Button1.Hide()
        Button6.Hide()
        x = Button7.Location.X + 1
        y = Button7.Location.Y - 30
        Button7.Location = New Point(x, y)
        x = Button8.Location.X + 1
        y = Button8.Location.Y - 30
        Button8.Location = New Point(x, y)
        Label6.Hide()
        x = Label7.Location.X + 1
        y = Label7.Location.Y - 30
        Label7.Location = New Point(x, y)
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Label5.Text = p1
        p1 = p1 - 1
        PictureBox2.Hide()
        Button2.Hide()
        Button7.Hide()
        x = Button8.Location.X + 1
        y = Button8.Location.Y - 30
        Button8.Location = New Point(x, y)
        Label7.Hide()
        x = Label8.Location.X + 1
        y = Label8.Location.Y - 30
        Label7.Location = New Point(x, y)
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Label5.Text = p1
        p1 = p1 - 1
        PictureBox3.Hide()
        Button3.Hide()
        Button8.Hide()
        Label8.Hide()
    End Sub
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
    End Sub
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs)
        Label5.Text = p1
        p1 = p1 + 0
    End Sub
End Class